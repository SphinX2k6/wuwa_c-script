using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EC7 RID: 3783
[NullableContext(1)]
[Nullable(0)]
public class DamageUiManager : Singleton
{
	// Token: 0x06009726 RID: 38694 RVA: 0x002CC604 File Offset: 0x002CA804
	public void Initialize()
	{
		this.MinDamageOffsetScale = (float)ConfigCommonParamById.GetIntConfig("MinDamageOffsetScale").Value / 100f;
		this.MaxDamageOffsetScale = (float)ConfigCommonParamById.GetIntConfig("MaxDamageOffsetScale").Value / 100f;
		this.MinDamageOffsetDistance = (float)ConfigCommonParamById.GetIntConfig("MinDamageOffsetDistance").Value;
		this.MaxDamageOffsetDistance = (float)ConfigCommonParamById.GetIntConfig("MaxDamageOffsetDistance").Value;
		this.DamagePositionCache = global::Vector.Create();
		this.DamageTextConfigList = DamageUiConfig.Instance.GetAllDamageTextConfig();
		IReadOnlyList<DamageTextArea> allDamageTextArea = DamageUiConfig.Instance.GetAllDamageTextArea();
		if (allDamageTextArea != null)
		{
			foreach (DamageTextArea value in allDamageTextArea)
			{
				this.DamageTextAreaMap.Add(value.Id, value);
			}
		}
		this.InitializeDamageViewData();
	}

	// Token: 0x06009727 RID: 38695 RVA: 0x002CC6F8 File Offset: 0x002CA8F8
	public void InitializeDamageViewData()
	{
		if (this.DamageTextConfigList == null)
		{
			return;
		}
		foreach (DamageText damageTextConfig in this.DamageTextConfigList)
		{
			DamageViewData damageViewData = new DamageViewData();
			damageViewData.Initialize(damageTextConfig);
			this.DamageViewDataMap.Add(damageTextConfig.Id, damageViewData);
			if (!StringUtils.IsEmpty(damageViewData.CriticalNiagaraPath))
			{
				int criticalNiagaraId;
				if (!this.CriticalNiagaraPathMap.TryGetValue(damageViewData.CriticalNiagaraPath, out criticalNiagaraId))
				{
					damageViewData.CriticalNiagaraId = this.CriticalNiagaraId;
					this.CriticalNiagaraPathMap.Add(damageViewData.CriticalNiagaraPath, damageViewData.CriticalNiagaraId);
					this.CriticalNiagaraId++;
				}
				else
				{
					damageViewData.CriticalNiagaraId = criticalNiagaraId;
				}
			}
		}
	}

	// Token: 0x06009728 RID: 38696 RVA: 0x002CC7CC File Offset: 0x002CA9CC
	public void ClearDamageViewData()
	{
		this.DamageViewDataMap.Clear();
	}

	// Token: 0x06009729 RID: 38697 RVA: 0x002CC7DC File Offset: 0x002CA9DC
	[NullableContext(2)]
	public DamageViewData GetDamageViewData(int damageTextId)
	{
		DamageViewData result;
		if (this.DamageViewDataMap.TryGetValue(damageTextId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600972A RID: 38698 RVA: 0x002CC7FC File Offset: 0x002CA9FC
	public bool IsUeDamageConfigRegistered(int damageTextId)
	{
		if (this.UeDamageUiManagerInternal == null)
		{
			return false;
		}
		DamageViewData damageViewData = this.GetDamageViewData(damageTextId);
		DamageText? damageText = (damageViewData != null) ? damageViewData.DamageTextConfig : null;
		return damageText != null && damageText.Value.UseForOptimization;
	}

	// Token: 0x0600972B RID: 38699 RVA: 0x002CC84C File Offset: 0x002CAA4C
	public FDamageInfo CreateDamageInfoForScene(int damage, int damageConfigId, FVectorDouble damagePosition, bool bOwnPlayer, bool bCrit, bool bCure, string damageText)
	{
		return new FDamageInfo
		{
			Damage = damage,
			DamageConfigId = damageConfigId,
			DamagePosition = damagePosition,
			bOwnPlayer = bOwnPlayer,
			bCrit = bCrit,
			bCure = bCure,
			DamageText = damageText,
			ExpiredTime = 0f
		};
	}

	// Token: 0x0600972C RID: 38700 RVA: 0x002CC8A0 File Offset: 0x002CAAA0
	public FDamageInfo CreateDamageInfoForLgui(int damage, int damageConfigId, FVector2D lguiPos, bool bOwnPlayer, bool bCrit, bool bCure, string damageText)
	{
		return new FDamageInfo
		{
			Damage = damage,
			bUseLGUIPos = true,
			LGUIPos = lguiPos,
			DamageConfigId = damageConfigId,
			bOwnPlayer = bOwnPlayer,
			bCrit = bCrit,
			bCure = bCure,
			DamageText = damageText,
			ExpiredTime = 0f
		};
	}

	// Token: 0x0600972D RID: 38701 RVA: 0x002CC8FC File Offset: 0x002CAAFC
	public void PreloadDamageView()
	{
		for (int i = this.UnusedDamageViewList.Count; i < 21; i++)
		{
			DamageView damageView = new DamageView();
			damageView.Init();
			this.TotalDamageViewNum++;
			this.UnusedDamageViewList.Add(damageView);
		}
	}

	// Token: 0x0600972E RID: 38702 RVA: 0x002CC948 File Offset: 0x002CAB48
	public void ApplyDamage(float damage, int elementId, FVectorDouble damagePosition, Entity target, bool bCritical, bool bCure, int damageTextId = -1, string damageText = "", int damageTextAreaId = 0)
	{
		if (!this.IsDamageViewVisible)
		{
			return;
		}
		if (!target.Active)
		{
			return;
		}
		if (damageTextId < 0)
		{
			return;
		}
		if (damageTextId == 1 && bCure && damage == 0f)
		{
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			return;
		}
		bool flag = getCurrentEntity.Id == target.Id;
		if (this.EnableOptimization || damageTextId == 2)
		{
			if (this.UeDamageUiManagerInternal != null)
			{
				int num = (int)Math.Floor((double)Math.Abs(damage));
				int damageConfigId = this.MakeDamageTextId(elementId, bCure, (float)num, damageTextId);
				string damageText2 = damageText;
				if (!StringUtils.IsEmpty(damageText))
				{
					string textContentIdById = TextConfig.Instance.GetTextContentIdById(damageText);
					damageText2 = (TextConfig.Instance.GetMultiTextByKey(textContentIdById) ?? " ");
				}
				FDamageInfo fdamageInfo = new FDamageInfo();
				fdamageInfo.Damage = num;
				fdamageInfo.DamageConfigId = damageConfigId;
				fdamageInfo.DamagePosition = damagePosition;
				fdamageInfo.bOwnPlayer = flag;
				fdamageInfo.bCrit = bCritical;
				fdamageInfo.bCure = bCure;
				fdamageInfo.DamageText = damageText2;
				fdamageInfo.ExpiredTime = 0f;
				this.UeDamageUiManagerInternal.AddDamageInfo(fdamageInfo);
				return;
			}
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.CFT, "产生性能伤害飘字时，缺少ueDamageUiManager", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		DamageInfo damageInfo;
		if (this.UnusedDamageInfoList.Count > 0)
		{
			int index = this.UnusedDamageInfoList.Count - 1;
			damageInfo = this.UnusedDamageInfoList[index];
			this.UnusedDamageInfoList.RemoveAt(index);
		}
		else
		{
			damageInfo = new DamageInfo();
		}
		damageInfo.Damage = damage;
		damageInfo.ElementId = elementId;
		damageInfo.DamagePosition = new FVectorDouble?(damagePosition);
		damageInfo.IsOwnPlayer = flag;
		damageInfo.IsCritical = bCritical;
		damageInfo.IsCure = bCure;
		damageInfo.DamageTextId = damageTextId;
		damageInfo.DamageText = damageText;
		damageInfo.DamageTextAreaId = damageTextAreaId;
		damageInfo.EntityId = target.Id;
		damageInfo.EnableOptimization = false;
		damageInfo.Valid = true;
		if (flag)
		{
			global::Vector actorLocationProxy = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy;
			if (actorLocationProxy != null)
			{
				damageInfo.BaseLocation.FromUeVector(actorLocationProxy);
			}
			else
			{
				damageInfo.BaseLocation.Reset();
			}
		}
		this.DamageInfoQueue.Push(damageInfo);
	}

	// Token: 0x0600972F RID: 38703 RVA: 0x002CCB6C File Offset: 0x002CAD6C
	private unsafe void ApplyDamageInner(DamageInfo damageInfo, [Nullable(new byte[]
	{
		2,
		1
	})] List<DamageInfo> mergeDamageInfoList = null)
	{
		if (!this.IsDamageViewVisible)
		{
			return;
		}
		int num = (int)Math.Floor((double)Math.Abs(damageInfo.Damage));
		int num2 = this.MakeDamageTextId(damageInfo.ElementId, damageInfo.IsCure, (float)num, damageInfo.DamageTextId);
		if (num2 < 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "[DamageText]产生伤害飘字时，伤害飘字Id无效";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("textId", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("elementId", damageInfo.ElementId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bCure", damageInfo.IsCure);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("damageTextId", damageInfo.DamageTextId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		global::Vector damagePositionCache = this.DamagePositionCache;
		FVectorDouble value = damageInfo.DamagePosition.Value;
		damagePositionCache.DeepCopy(value);
		DamageViewData damageViewData = this.GetDamageViewData(num2);
		if (damageViewData == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.CFT;
			string message2 = "找不到对应的伤害飘字配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("伤害飘字Id", num2);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.ProjectWorldLocationToScreenPosition(damageInfo.DamagePosition.Value) == null)
		{
			return;
		}
		DamageView damageView;
		if (this.UnusedDamageViewList.Count > 0)
		{
			int index = this.UnusedDamageViewList.Count - 1;
			damageView = this.UnusedDamageViewList[index];
			this.UnusedDamageViewList.RemoveAt(index);
		}
		else
		{
			damageView = new DamageView();
			damageView.Init();
			this.TotalDamageViewNum++;
		}
		this.DamageViewSet.Add(damageView);
		damageView.InitializeData((float)num, this.DamagePositionCache, damageInfo.BaseLocation, damageViewData, damageInfo.IsCritical, damageInfo.IsCure, damageInfo.IsOwnPlayer, damageInfo.DamageText, damageInfo.DamageTextAreaId, mergeDamageInfoList);
	}

	// Token: 0x06009730 RID: 38704 RVA: 0x002CCD6C File Offset: 0x002CAF6C
	public void Tick(float delta)
	{
		float delta2 = delta * Time.Instance.InverseSelfCenteredTimeDilation;
		if (this.TimeScaleEnable)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null && getCurrentEntity.Valid)
			{
				WorldEntity entity = getCurrentEntity.Entity;
				float? num;
				if (entity == null)
				{
					num = null;
				}
				else
				{
					CharacterTimeScaleComponent component = entity.GetComponent<CharacterTimeScaleComponent>();
					num = ((component != null) ? new float?(component.CurrentTimeScale) : null);
				}
				float? num2 = num;
				float valueOrDefault = num2.GetValueOrDefault(1f);
				foreach (DamageView damageView in this.DamageViewSet)
				{
					damageView.SetTimeScale(valueOrDefault);
				}
			}
		}
		foreach (DamageView damageView2 in this.DamageViewSet)
		{
			damageView2.Tick(delta2);
		}
		int num3 = 0;
		while (num3 < 1 && !this.DamageInfoQueue.Empty)
		{
			DamageInfo damageInfo = this.DamageInfoQueue.Pop();
			if (!damageInfo.Valid)
			{
				num3--;
				this.UnusedDamageInfoList.Add(damageInfo);
			}
			else
			{
				if (!CharacterModel.Instance.IsValid(damageInfo.EntityId))
				{
					List<DamageInfo> list = new List<DamageInfo>();
					for (int i = 0; i < this.DamageInfoQueue.Size; i++)
					{
						DamageInfo damageInfo2 = this.DamageInfoQueue.Get(i);
						if (damageInfo2.EntityId == damageInfo.EntityId)
						{
							list.Add(damageInfo2);
							damageInfo2.Valid = false;
						}
					}
					this.ApplyDamageInner(damageInfo, list);
				}
				else
				{
					this.ApplyDamageInner(damageInfo, null);
				}
				this.UnusedDamageInfoList.Add(damageInfo);
			}
			num3++;
		}
		if (this.UeDamageUiManager != null)
		{
			global::Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
			UDamageUiManager ueDamageUiManager = this.UeDamageUiManager;
			float num4 = delta * (float)TimeUtil.Instance.Millisecond;
			FVectorDouble fvectorDouble = cameraLocation.ToUeVector(false);
			ueDamageUiManager.Update(num4, fvectorDouble, Global.CharacterController);
		}
	}

	// Token: 0x06009731 RID: 38705 RVA: 0x002CCF90 File Offset: 0x002CB190
	private int MakeDamageTextId(int elementId, bool bCure, float damage, int damageTextId = -1)
	{
		int result;
		if (damageTextId != 0 && damageTextId != -1 && damageTextId != 2)
		{
			result = damageTextId;
		}
		else if (damage == 0f)
		{
			result = 9;
		}
		else if (elementId > 0)
		{
			result = elementId;
		}
		else if (bCure)
		{
			result = 8;
		}
		else
		{
			result = 10;
		}
		return result;
	}

	// Token: 0x06009732 RID: 38706 RVA: 0x002CCFD4 File Offset: 0x002CB1D4
	public FVector2D? ProjectWorldLocationToScreenPosition(FVectorDouble worldLocation)
	{
		if (!UGameplayStatics.D_ProjectWorldToScreen(Global.CharacterController, worldLocation, ref this.ResultDamagePositionRef, false))
		{
			return null;
		}
		FVector2D resultDamagePositionRef = this.ResultDamagePositionRef;
		float x = resultDamagePositionRef.X;
		float y = resultDamagePositionRef.Y;
		if (float.IsNaN(x) || float.IsNaN(y) || !float.IsFinite(x) || !float.IsFinite(y))
		{
			return null;
		}
		return new FVector2D?(resultDamagePositionRef);
	}

	// Token: 0x06009733 RID: 38707 RVA: 0x002CD045 File Offset: 0x002CB245
	public FVector2D ScreenPositionToLguiPosition(FVector2D screenPosition)
	{
		return UiLayer.Instance.UiRootItem.GetCanvasScaler().ConvertPositionFromViewportToLGUICanvas(screenPosition);
	}

	// Token: 0x06009734 RID: 38708 RVA: 0x002CD060 File Offset: 0x002CB260
	[NullableContext(2)]
	public FVector2D ConvertUiItemToLguiPosition(UUIItem uiItem = null, FVector2D? offset = null)
	{
		FVector2D result = new FVector2D(0f, 0f);
		if (uiItem != null)
		{
			ULGUIBPLibrary.GetUIWorldPosForceUpdate(uiItem);
			bool bIsScaledByDPI = true;
			FVector2D fvector2D = new FVector2D(0.5f, 0.5f);
			FVector2D positionInViewportWithPivot = uiItem.GetPositionInViewportWithPivot(bIsScaledByDPI, fvector2D);
			FVector2D fvector2D2 = this.ScreenPositionToLguiPosition(positionInViewportWithPivot);
			result.X = fvector2D2.X;
			result.Y = fvector2D2.Y;
		}
		if (offset != null)
		{
			result.X += offset.Value.X;
			result.Y += offset.Value.Y;
		}
		return result;
	}

	// Token: 0x06009735 RID: 38709 RVA: 0x002CD0FC File Offset: 0x002CB2FC
	public void RemoveDamageView(DamageView damageView)
	{
		if (this.DamageViewSet.Contains(damageView))
		{
			damageView.ClearData();
			this.DamageViewSet.Remove(damageView);
			this.UnusedDamageViewList.Add(damageView);
		}
	}

	// Token: 0x06009736 RID: 38710 RVA: 0x002CD12C File Offset: 0x002CB32C
	public void OnEditorPlatformChanged()
	{
		foreach (DamageView damageView in this.DamageViewSet)
		{
			damageView.RefreshFontSize();
		}
		foreach (DamageView damageView2 in this.UnusedDamageViewList)
		{
			damageView2.RefreshFontSize();
		}
	}

	// Token: 0x06009737 RID: 38711 RVA: 0x002CD1BC File Offset: 0x002CB3BC
	public void SetDamageTimeScaleEnable(bool bEnable)
	{
		this.TimeScaleEnable = bEnable;
		if (!this.TimeScaleEnable)
		{
			foreach (DamageView damageView in this.DamageViewSet)
			{
				damageView.SetTimeScale(1f);
			}
		}
	}

	// Token: 0x06009738 RID: 38712 RVA: 0x002CD220 File Offset: 0x002CB420
	public void SetDamageViewVisible(bool bVisible)
	{
		this.IsDamageViewVisible = bVisible;
		if (this.UeDamageUiManagerInternal != null)
		{
			this.UeDamageUiManagerInternal.bDamageViewVisible = this.IsDamageViewVisible;
			if (!bVisible)
			{
				this.UeDamageUiManagerInternal.ClearDamageInfo();
			}
		}
	}

	// Token: 0x06009739 RID: 38713 RVA: 0x002CD250 File Offset: 0x002CB450
	public bool GetDamageViewVisible()
	{
		return this.IsDamageViewVisible;
	}

	// Token: 0x0600973A RID: 38714 RVA: 0x002CD258 File Offset: 0x002CB458
	[return: Nullable(2)]
	public UGeometryHandle PlayDamageNumBatch(string damageTextString, FVector2D uiPosition, FColor textColor, int animType = 1)
	{
		return null;
	}

	// Token: 0x0600973B RID: 38715 RVA: 0x002CD25B File Offset: 0x002CB45B
	public void UpdateDamageLocation(UGeometryHandle geometryHandle, FVector2D uiPosition, int animType = 1)
	{
	}

	// Token: 0x0600973C RID: 38716 RVA: 0x002CD260 File Offset: 0x002CB460
	public int EnableDamageViewOptimization()
	{
		int enableOptimizationIdGen = this.EnableOptimizationIdGen;
		this.EnableOptimizationIdGen = enableOptimizationIdGen + 1;
		int num = enableOptimizationIdGen;
		this.EnableOptimizationHandleSet.Add(num);
		this.EnableOptimization = true;
		return num;
	}

	// Token: 0x0600973D RID: 38717 RVA: 0x002CD294 File Offset: 0x002CB494
	public void DisableDamageViewOptimization(int id)
	{
		this.EnableOptimizationHandleSet.Remove(id);
		bool enableOptimization = this.EnableOptimizationHandleSet.Count > 0;
		this.EnableOptimization = enableOptimization;
	}

	// Token: 0x0600973E RID: 38718 RVA: 0x002CD2C4 File Offset: 0x002CB4C4
	public DamageTextArea? GetDamageTextAreaById(int id)
	{
		DamageTextArea value;
		if (this.DamageTextAreaMap.TryGetValue(id, out value))
		{
			return new DamageTextArea?(value);
		}
		return null;
	}

	// Token: 0x0600973F RID: 38719 RVA: 0x002CD2F4 File Offset: 0x002CB4F4
	public void OnLeaveLevel()
	{
		foreach (DamageView damageView in this.DamageViewSet)
		{
			damageView.ClearData();
			damageView.Destroy(null);
		}
		this.DamageViewSet.Clear();
		foreach (DamageView damageView2 in this.UnusedDamageViewList)
		{
			damageView2.Destroy(null);
		}
		this.UnusedDamageViewList.Clear();
		this.TotalDamageViewNum = 0;
		this.DamageInfoQueue.Clear();
		this.UnusedDamageInfoList.Clear();
		this.CriticalNiagaraList.Clear();
		this.CriticalNiagaraId = 0;
	}

	// Token: 0x06009740 RID: 38720 RVA: 0x002CD3D0 File Offset: 0x002CB5D0
	public void Clear()
	{
		this.EnableOptimizationHandleSet.Clear();
		this.EnableOptimization = false;
	}

	// Token: 0x06009741 RID: 38721 RVA: 0x002CD3E4 File Offset: 0x002CB5E4
	public void InitUeDamageUiManager(UDamageUiManager ueDamageUiManager)
	{
		if (this.UeDamageConfig != null)
		{
			ueDamageUiManager.InitDamageConfig(this.UeDamageConfig);
		}
		if (this.DamageDynamicBatchActor == null)
		{
			return;
		}
		if (this.DamageViewActor == null)
		{
			return;
		}
		ueDamageUiManager.InitAllRes(this.GetDamageParentItem(), this.DamageDynamicBatchActor, this.DamageViewActor, this.HideDamageCritEffect ? 1 : 20, Info.Instance.IsMobilePlatform());
		foreach (DamageText damageText in this.DamageTextConfigList)
		{
			if (damageText.UseForOptimization)
			{
				int id = damageText.Id;
				DamageViewData damageViewData;
				if (this.DamageViewDataMap.TryGetValue(id, out damageViewData))
				{
					FDamageViewData fdamageViewData = new FDamageViewData();
					fdamageViewData.ConfigId = damageViewData.ConfigId;
					fdamageViewData.MinRandomOffsetX = (int)damageViewData.MinRandomOffsetX;
					fdamageViewData.MinRandomOffsetY = (int)damageViewData.MinRandomOffsetY;
					fdamageViewData.MaxRandomOffsetX = (int)damageViewData.MaxRandomOffsetX;
					fdamageViewData.MaxRandomOffsetY = (int)damageViewData.MaxRandomOffsetY;
					fdamageViewData.TextColor = damageViewData.TextColor.Value;
					fdamageViewData.CritTextColor = damageViewData.CriticalTextColor.Value;
					fdamageViewData.OutlineColor = damageViewData.StrokeColor.Value;
					fdamageViewData.CritOutlineColor = damageViewData.CriticalStrokeColor.Value;
					fdamageViewData.CritNiagaraType = (this.HideDamageCritEffect ? -1 : damageViewData.CriticalNiagaraId);
					int num;
					fdamageViewData.OwnDamageAnimType = (this.DamageAnimMap.TryGetValue(damageViewData.DamageTextConfig.Value.OwnDamageSequence, out num) ? num : 0);
					int num2;
					fdamageViewData.OwnCritDamageAnimType = (this.DamageAnimMap.TryGetValue(damageViewData.DamageTextConfig.Value.OwnCriticalDamageSequence, out num2) ? num2 : 0);
					int num3;
					fdamageViewData.MonsterDamageAnimType = (this.DamageAnimMap.TryGetValue(damageViewData.DamageTextConfig.Value.MonsterDamageSequence, out num3) ? num3 : 0);
					int num4;
					fdamageViewData.MonsterCritDamageAnimType = (this.DamageAnimMap.TryGetValue(damageViewData.DamageTextConfig.Value.MonsterCriticalDamageSequence, out num4) ? num4 : 0);
					int num5;
					fdamageViewData.TextDamageAnimType = (this.DamageAnimMap.TryGetValue(damageViewData.DamageTextConfig.Value.DamageTextSequence, out num5) ? num5 : 0);
					fdamageViewData.IconPath = damageViewData.DamageTextConfig.Value.Icon;
					fdamageViewData.IconScale = damageViewData.DamageTextConfig.Value.IconScale;
					ueDamageUiManager.AddDamageViewData(fdamageViewData);
				}
			}
		}
		foreach (UNiagaraSystem critNiagara in this.CriticalNiagaraList)
		{
			ueDamageUiManager.AddCritNiagara(critNiagara);
		}
		ueDamageUiManager.bDamageViewVisible = this.IsDamageViewVisible;
	}

	// Token: 0x06009742 RID: 38722 RVA: 0x002CD6F0 File Offset: 0x002CB8F0
	public UniTask PreloadAsync()
	{
		DamageUiManager.<PreloadAsync>d__61 <PreloadAsync>d__;
		<PreloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadAsync>d__.<>4__this = this;
		<PreloadAsync>d__.<>1__state = -1;
		<PreloadAsync>d__.<>t__builder.Start<DamageUiManager.<PreloadAsync>d__61>(ref <PreloadAsync>d__);
		return <PreloadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009743 RID: 38723 RVA: 0x002CD734 File Offset: 0x002CB934
	private UniTask LoadCriticalNiagara(string path, int id)
	{
		DamageUiManager.<LoadCriticalNiagara>d__62 <LoadCriticalNiagara>d__;
		<LoadCriticalNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadCriticalNiagara>d__.<>4__this = this;
		<LoadCriticalNiagara>d__.path = path;
		<LoadCriticalNiagara>d__.id = id;
		<LoadCriticalNiagara>d__.<>1__state = -1;
		<LoadCriticalNiagara>d__.<>t__builder.Start<DamageUiManager.<LoadCriticalNiagara>d__62>(ref <LoadCriticalNiagara>d__);
		return <LoadCriticalNiagara>d__.<>t__builder.Task;
	}

	// Token: 0x06009744 RID: 38724 RVA: 0x002CD788 File Offset: 0x002CB988
	private UniTask LoadDamageDynamicBatchActor()
	{
		DamageUiManager.<LoadDamageDynamicBatchActor>d__63 <LoadDamageDynamicBatchActor>d__;
		<LoadDamageDynamicBatchActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadDamageDynamicBatchActor>d__.<>4__this = this;
		<LoadDamageDynamicBatchActor>d__.<>1__state = -1;
		<LoadDamageDynamicBatchActor>d__.<>t__builder.Start<DamageUiManager.<LoadDamageDynamicBatchActor>d__63>(ref <LoadDamageDynamicBatchActor>d__);
		return <LoadDamageDynamicBatchActor>d__.<>t__builder.Task;
	}

	// Token: 0x06009745 RID: 38725 RVA: 0x002CD7CC File Offset: 0x002CB9CC
	private UniTask LoadDamageViewActor()
	{
		DamageUiManager.<LoadDamageViewActor>d__64 <LoadDamageViewActor>d__;
		<LoadDamageViewActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadDamageViewActor>d__.<>4__this = this;
		<LoadDamageViewActor>d__.<>1__state = -1;
		<LoadDamageViewActor>d__.<>t__builder.Start<DamageUiManager.<LoadDamageViewActor>d__64>(ref <LoadDamageViewActor>d__);
		return <LoadDamageViewActor>d__.<>t__builder.Task;
	}

	// Token: 0x06009746 RID: 38726 RVA: 0x002CD810 File Offset: 0x002CBA10
	private string GetDamageBatchResourceId()
	{
		int curInstSubType = this.GetCurInstSubType();
		if (curInstSubType < 0)
		{
			return "UiItem_DamageView_Num_Prefab";
		}
		return DamageUiDefine.inst2DamageDynamicBatch.GetValueOrDefault((EDungeonSubType)curInstSubType) ?? "UiItem_DamageView_Num_Prefab";
	}

	// Token: 0x06009747 RID: 38727 RVA: 0x002CD844 File Offset: 0x002CBA44
	private string GetDamageViewResourceId()
	{
		int curInstSubType = this.GetCurInstSubType();
		if (curInstSubType < 0)
		{
			return "UiItem_DamageView_Sim_Prefab";
		}
		return DamageUiDefine.inst2DamageView.GetValueOrDefault((EDungeonSubType)curInstSubType) ?? "UiItem_DamageView_Sim_Prefab";
	}

	// Token: 0x06009748 RID: 38728 RVA: 0x002CD878 File Offset: 0x002CBA78
	private UUIItem GetDamageParentItem()
	{
		DamageUiDefine.DamageParentSlot damageParentSlot = DamageUiDefine.DefaultDamageParent;
		int curInstSubType = this.GetCurInstSubType();
		DamageUiDefine.DamageParentSlot damageParentSlot2;
		if (curInstSubType >= 0 && DamageUiDefine.inst2DamageParent.TryGetValue((EDungeonSubType)curInstSubType, out damageParentSlot2))
		{
			damageParentSlot = damageParentSlot2;
		}
		UUIItem layerUnit = UiLayer.Instance.GetLayerUnit(damageParentSlot.Layer, damageParentSlot.Index);
		if (layerUnit == null)
		{
			return UiLayer.Instance.GetBattleViewUnit(0);
		}
		return layerUnit;
	}

	// Token: 0x06009749 RID: 38729 RVA: 0x002CD8D0 File Offset: 0x002CBAD0
	private int GetCurInstSubType()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		if (config == null)
		{
			return -1;
		}
		return config.Value.InstSubType;
	}

	// Token: 0x0600974A RID: 38730 RVA: 0x002CD910 File Offset: 0x002CBB10
	public string FormatDamageNumber(float num)
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		if (instanceId == 0)
		{
			return num.ToString();
		}
		if (instanceId == this.CachedCurInstId)
		{
			IDamageNumFormatRule cachedDamageNumFormatRule = this.CachedDamageNumFormatRule;
			return ((cachedDamageNumFormatRule != null) ? cachedDamageNumFormatRule.FormatNumber(num) : null) ?? num.ToString();
		}
		this.CachedCurInstId = instanceId;
		this.CachedDamageNumFormatRule = null;
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		if (config == null)
		{
			return num.ToString();
		}
		int instSubType = config.Value.InstSubType;
		IDamageNumFormatRule valueOrDefault = DamageNumFormatRuleDefine.DamageNumFormatRuleMap.GetValueOrDefault((EDungeonSubType)instSubType);
		if (valueOrDefault == null)
		{
			return num.ToString();
		}
		this.CachedDamageNumFormatRule = valueOrDefault;
		return valueOrDefault.FormatNumber(num);
	}

	// Token: 0x1700106F RID: 4207
	// (get) Token: 0x0600974B RID: 38731 RVA: 0x002CD9BC File Offset: 0x002CBBBC
	[Nullable(2)]
	public UDamageUiManager UeDamageUiManager
	{
		[NullableContext(2)]
		get
		{
			return this.UeDamageUiManagerInternal;
		}
	}

	// Token: 0x0600974C RID: 38732 RVA: 0x002CD9C4 File Offset: 0x002CBBC4
	public void StartUeDamageUiManager()
	{
		if (this.UeDamageUiManagerInternal != null)
		{
			return;
		}
		this.UeDamageUiManagerInternal = UDamageUiManager.CreateInstance(GlobalData.World);
		if (this.DamageDynamicBatchActor == null)
		{
			this.PreloadAsync().ContinueWith(delegate()
			{
				if (this.UeDamageUiManagerInternal != null)
				{
					this.InitUeDamageUiManager(this.UeDamageUiManagerInternal);
					return;
				}
				this.DamageDynamicBatchActor = null;
				this.DamageViewActor = null;
			});
			return;
		}
		this.InitUeDamageUiManager(this.UeDamageUiManagerInternal);
	}

	// Token: 0x0600974D RID: 38733 RVA: 0x002CDA17 File Offset: 0x002CBC17
	public void StopUeDamageUiManager()
	{
		if (this.UeDamageUiManagerInternal != null)
		{
			UDamageUiManager.DestroyInstance();
			this.UeDamageUiManagerInternal = null;
		}
		this.UeDamageConfig = null;
		this.HideDamageCritEffect = false;
		this.DamageDynamicBatchActor = null;
		this.DamageViewActor = null;
	}

	// Token: 0x0600974E RID: 38734 RVA: 0x002CDA4C File Offset: 0x002CBC4C
	public void SetUeDamageConfig(FDamageConfig config, bool hideDamageCritEffect = false)
	{
		if (this.UeDamageUiManager != null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "UeDamageUiManager已经初始化过，此时再设置DamageConfig不会生效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.UeDamageConfig = config;
		this.HideDamageCritEffect = hideDamageCritEffect;
	}

	// Token: 0x0600974F RID: 38735 RVA: 0x002CDA8C File Offset: 0x002CBC8C
	public void UpdateKscWorld()
	{
		UDamageUiManager ueDamageUiManager = this.UeDamageUiManager;
		if (ueDamageUiManager == null)
		{
			return;
		}
		ueDamageUiManager.UpdateKscWorld();
	}

	// Token: 0x17001070 RID: 4208
	// (get) Token: 0x06009750 RID: 38736 RVA: 0x002CDA9E File Offset: 0x002CBC9E
	public static DamageUiManager Instance
	{
		get
		{
			if (DamageUiManager._instance == null)
			{
				DamageUiManager._instance = new DamageUiManager();
				DamageUiManager._instance.OnInit();
			}
			return DamageUiManager._instance;
		}
	}

	// Token: 0x06009751 RID: 38737 RVA: 0x002CDAC1 File Offset: 0x002CBCC1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009752 RID: 38738 RVA: 0x002CDAC3 File Offset: 0x002CBCC3
	public static void ResetStaticDefaultValue()
	{
		DamageUiManager instance = DamageUiManager._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		DamageUiManager._instance = null;
	}

	// Token: 0x06009753 RID: 38739 RVA: 0x002CDADC File Offset: 0x002CBCDC
	static DamageUiManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageUiManager.CreateStaticDefaultValue), new Action(DamageUiManager.ResetStaticDefaultValue));
	}

	// Token: 0x04005ACC RID: 23244
	private const int PRELOAD_DAMAGE_VIEW_COUNT = 21;

	// Token: 0x04005ACD RID: 23245
	private const int MAX_DAMAGE_PER_FRAME = 1;

	// Token: 0x04005ACE RID: 23246
	private readonly Queue<DamageInfo> DamageInfoQueue = new Queue<DamageInfo>(4);

	// Token: 0x04005ACF RID: 23247
	private readonly List<DamageInfo> UnusedDamageInfoList = new List<DamageInfo>();

	// Token: 0x04005AD0 RID: 23248
	public int TotalDamageViewNum;

	// Token: 0x04005AD1 RID: 23249
	private readonly HashSet<DamageView> DamageViewSet = new HashSet<DamageView>();

	// Token: 0x04005AD2 RID: 23250
	private readonly List<DamageView> UnusedDamageViewList = new List<DamageView>();

	// Token: 0x04005AD3 RID: 23251
	private readonly Dictionary<int, DamageViewData> DamageViewDataMap = new Dictionary<int, DamageViewData>();

	// Token: 0x04005AD4 RID: 23252
	private bool IsDamageViewVisible = true;

	// Token: 0x04005AD5 RID: 23253
	public float MinDamageOffsetScale;

	// Token: 0x04005AD6 RID: 23254
	public float MaxDamageOffsetScale;

	// Token: 0x04005AD7 RID: 23255
	public float MinDamageOffsetDistance;

	// Token: 0x04005AD8 RID: 23256
	public float MaxDamageOffsetDistance;

	// Token: 0x04005AD9 RID: 23257
	[Nullable(2)]
	public global::Vector DamagePositionCache;

	// Token: 0x04005ADA RID: 23258
	[Nullable(2)]
	private IReadOnlyList<DamageText> DamageTextConfigList;

	// Token: 0x04005ADB RID: 23259
	private readonly Dictionary<int, DamageTextArea> DamageTextAreaMap = new Dictionary<int, DamageTextArea>();

	// Token: 0x04005ADC RID: 23260
	private FVector2D ResultDamagePositionRef = new FVector2D();

	// Token: 0x04005ADD RID: 23261
	private bool TimeScaleEnable;

	// Token: 0x04005ADE RID: 23262
	public bool EnableOptimization;

	// Token: 0x04005ADF RID: 23263
	private int EnableOptimizationIdGen;

	// Token: 0x04005AE0 RID: 23264
	private readonly HashSet<int> EnableOptimizationHandleSet = new HashSet<int>();

	// Token: 0x04005AE1 RID: 23265
	private readonly Dictionary<string, int> CriticalNiagaraPathMap = new Dictionary<string, int>();

	// Token: 0x04005AE2 RID: 23266
	private readonly List<UNiagaraSystem> CriticalNiagaraList = new List<UNiagaraSystem>();

	// Token: 0x04005AE3 RID: 23267
	private int CriticalNiagaraId;

	// Token: 0x04005AE4 RID: 23268
	[Nullable(2)]
	private AUIBaseActor DamageDynamicBatchActor;

	// Token: 0x04005AE5 RID: 23269
	[Nullable(2)]
	private AUIBaseActor DamageViewActor;

	// Token: 0x04005AE6 RID: 23270
	public readonly Dictionary<string, int> DamageAnimMap = new Dictionary<string, int>
	{
		{
			"",
			0
		},
		{
			"Ani_OwnDamageSequence",
			1
		},
		{
			"Ani_OwnCriticalDamageSequence",
			2
		},
		{
			"Ani_MonsterDamageSequence",
			3
		},
		{
			"Ani_MonsterCriticalDamageSequence",
			4
		},
		{
			"Ani_BuffSequence",
			5
		},
		{
			"Ani_SpecialDamage",
			6
		},
		{
			"Ani_SpecialCriticalDamage",
			7
		},
		{
			"Ani_SpecialPathDamage",
			8
		},
		{
			"Ani_HeavyDamage",
			9
		},
		{
			"Ani_HeavyCriticalDamage",
			10
		},
		{
			"Ani_OwnShieldCoverSequence",
			11
		},
		{
			"Ani_Heal",
			12
		}
	};

	// Token: 0x04005AE7 RID: 23271
	private readonly Stat TickStat1 = Stat.Create("DamageUiManager.TickStat1", "", "");

	// Token: 0x04005AE8 RID: 23272
	[Nullable(2)]
	private UDamageUiManager UeDamageUiManagerInternal;

	// Token: 0x04005AE9 RID: 23273
	[Nullable(2)]
	private FDamageConfig UeDamageConfig;

	// Token: 0x04005AEA RID: 23274
	public bool HideDamageCritEffect;

	// Token: 0x04005AEB RID: 23275
	private int CachedCurInstId;

	// Token: 0x04005AEC RID: 23276
	[Nullable(2)]
	private IDamageNumFormatRule CachedDamageNumFormatRule;

	// Token: 0x04005AED RID: 23277
	[Nullable(2)]
	private static DamageUiManager _instance;
}
