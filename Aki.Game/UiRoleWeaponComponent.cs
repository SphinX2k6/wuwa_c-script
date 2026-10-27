using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002CBA RID: 11450
[NullableContext(1)]
[Nullable(0)]
public class UiRoleWeaponComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect, IUiModelSetPlanarReflectionRenderOffset
{
	// Token: 0x06017EE0 RID: 98016 RVA: 0x00615CB4 File Offset: 0x00613EB4
	protected override void OnInit()
	{
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.AnsControllerComponent = base.Owner.CheckGetComponent<UiModelAnsControllerComponent>();
	}

	// Token: 0x06017EE1 RID: 98017 RVA: 0x00615D08 File Offset: 0x00613F08
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelSetMorphTypeComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelRoleDataIdChange, new Action(this.OnRoleIdChange));
		UiModelAnsControllerComponent ansControllerComponent = this.AnsControllerComponent;
		if (ansControllerComponent == null)
		{
			return;
		}
		ansControllerComponent.RegisterAnsTrigger("UiWeaponAnsContext", new Action<UiAnsContextBase>(this.OnAnsBegin), new Action<UiAnsContextBase>(this.OnAnsEnd), null, null);
	}

	// Token: 0x06017EE2 RID: 98018 RVA: 0x00615DAC File Offset: 0x00613FAC
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelSetMorphTypeComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelRoleDataIdChange, new Action(this.OnRoleIdChange));
		foreach (SkeletalObserverHandle skeletalObserverHandle in this.WeaponHandleList)
		{
			SkeletalObserverManager.DestroySkeletalObserver(skeletalObserverHandle);
		}
	}

	// Token: 0x06017EE3 RID: 98019 RVA: 0x00615E64 File Offset: 0x00614064
	public void OnModelDitherEffectChange(float value)
	{
		this.SetDitherEffect(value);
	}

	// Token: 0x06017EE4 RID: 98020 RVA: 0x00615E70 File Offset: 0x00614070
	public void OnModelVisibleChange(bool visible)
	{
		for (int i = 0; i < this.WeaponStatesOnRole.Count; i++)
		{
			if (this.WeaponStatesOnRole[i] && visible)
			{
				this.ShowWeaponByIndex(i, false);
			}
			else
			{
				this.HideWeaponByIndex(i, false);
			}
		}
	}

	// Token: 0x06017EE5 RID: 98021 RVA: 0x00615EB8 File Offset: 0x006140B8
	private void TrimWeaponHandles(int targetCount)
	{
		for (int i = this.WeaponHandleList.Count - 1; i >= targetCount; i--)
		{
			SkeletalObserverManager.DestroySkeletalObserver(this.WeaponHandleList[i]);
			this.WeaponHandleList.RemoveAt(i);
			this.WeaponStateList.RemoveAt(i);
			this.WeaponStatesOnRole.RemoveAt(i);
		}
	}

	// Token: 0x06017EE6 RID: 98022 RVA: 0x00615F14 File Offset: 0x00614114
	public void Refresh()
	{
		if (this.WeaponData == null)
		{
			return;
		}
		int[] models = this.WeaponData.GetModels(this.WeaponSkinId);
		this.WeaponCount = models.Length;
		this.TrimWeaponHandles(this.WeaponCount);
		for (int i = this.WeaponHandleList.Count; i < this.WeaponCount; i++)
		{
			SkeletalObserverHandle item = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.WeaponOnRole);
			this.WeaponHandleList.Add(item);
			this.WeaponStateList.Add(EWeaponState.None);
			this.WeaponStatesOnRole.Add(false);
			this.HideWeaponByIndex(i, false);
		}
		for (int j = 0; j < this.WeaponCount; j++)
		{
			UiModelBase model = this.WeaponHandleList[j].Model;
			UiWeaponDataComponent uiWeaponDataComponent = model.CheckGetComponent<UiWeaponDataComponent>();
			if (uiWeaponDataComponent != null)
			{
				uiWeaponDataComponent.SetWeaponData(this.WeaponData);
			}
			UiModelUtil.Instance.SetWeaponLevelMaterialBreachLevel(model, this.WeaponData.GetBreachLevel());
			UiModelLoadComponent uiModelLoadComponent = model.CheckGetComponent<UiModelLoadComponent>();
			int weaponIndex = j;
			if (uiModelLoadComponent != null)
			{
				uiModelLoadComponent.LoadModelByModelId(models[j], false, delegate
				{
					this.SyncWeaponVisibleWhenLoaded(weaponIndex);
				}, null);
			}
		}
	}

	// Token: 0x06017EE7 RID: 98023 RVA: 0x00616034 File Offset: 0x00614234
	private void SyncWeaponVisibleWhenLoaded(int weaponIndex)
	{
		if (weaponIndex < 0 || weaponIndex >= this.WeaponHandleList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weapon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "显示武器索引错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("weaponIndex", weaponIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		EWeaponState eweaponState = this.WeaponStateList[weaponIndex];
		UiModelBase model = this.WeaponHandleList[weaponIndex].Model;
		this.ApplyPlanarReflectionRenderOffset(model);
		UiModelUtil.Instance.SetVisible(model, eweaponState == EWeaponState.Showing);
	}

	// Token: 0x06017EE8 RID: 98024 RVA: 0x006160B6 File Offset: 0x006142B6
	public void OnRoleIdChange()
	{
		this.HideAllWeapon(false);
		this.ResetWeaponStatesOnRole();
		this.RefreshWeaponByRole();
	}

	// Token: 0x06017EE9 RID: 98025 RVA: 0x006160CC File Offset: 0x006142CC
	public void RefreshWeaponByRole()
	{
		this.RefreshWeaponCase();
		int roleDataId = this.RoleDataComponent.RoleDataId;
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleDataId, true);
		int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(roleDataId);
		if (roleDataById != null)
		{
			if (roleDataById.IsTrialRole())
			{
				WeaponTrialData weaponData = RoleModel.Instance.GetRoleRobotData(roleDataId).GetWeaponData();
				this.SetWeaponByWeaponData(weaponData, skinIdByRoleId);
				return;
			}
			WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(roleDataId, true);
			this.SetWeaponByWeaponData(weaponDataByRoleDataId, skinIdByRoleId);
		}
	}

	// Token: 0x06017EEA RID: 98026 RVA: 0x00616140 File Offset: 0x00614340
	public void OnRoleMeshLoadComplete()
	{
		this.AttachWeaponToRole();
	}

	// Token: 0x06017EEB RID: 98027 RVA: 0x00616148 File Offset: 0x00614348
	public void ShowAllWeapon(bool addMaterialController = false)
	{
		for (int i = 0; i < this.WeaponHandleList.Count; i++)
		{
			this.ShowWeaponByIndex(i, addMaterialController);
		}
	}

	// Token: 0x06017EEC RID: 98028 RVA: 0x00616174 File Offset: 0x00614374
	public void HideAllWeapon(bool playEffect = false)
	{
		for (int i = 0; i < this.WeaponHandleList.Count; i++)
		{
			this.HideWeaponByIndex(i, playEffect);
		}
	}

	// Token: 0x06017EED RID: 98029 RVA: 0x006161A0 File Offset: 0x006143A0
	public void ResetWeaponStatesOnRole()
	{
		for (int i = 0; i < this.WeaponStatesOnRole.Count; i++)
		{
			this.WeaponStatesOnRole[i] = false;
		}
	}

	// Token: 0x06017EEE RID: 98030 RVA: 0x006161D0 File Offset: 0x006143D0
	public void ShowWeaponByIndex(int index, bool addMaterialController = false)
	{
		if (index < 0 || index >= this.WeaponHandleList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weapon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "显示武器索引错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiModelBase model = this.WeaponHandleList[index].Model;
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		this.WeaponStateList[index] = EWeaponState.Showing;
		if (((uiModelDataComponent != null) ? new bool?(uiModelDataComponent.GetVisible()) : null).GetValueOrDefault())
		{
			return;
		}
		if (uiModelDataComponent != null)
		{
			uiModelDataComponent.SetVisible(true);
		}
		if (addMaterialController)
		{
			UiModelUtil.Instance.SetRenderingMaterial(model, "ChangeWeaponMaterialController");
		}
	}

	// Token: 0x06017EEF RID: 98031 RVA: 0x00616288 File Offset: 0x00614488
	public void HideWeaponByIndex(int index, bool playEffect = false)
	{
		if (index < 0 || index >= this.WeaponHandleList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weapon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "隐藏武器索引错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiModelBase model = this.WeaponHandleList[index].Model;
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		this.WeaponStateList[index] = EWeaponState.Hidden;
		if (!((uiModelDataComponent != null) ? new bool?(uiModelDataComponent.GetVisible()) : null).GetValueOrDefault())
		{
			return;
		}
		if (uiModelDataComponent != null)
		{
			uiModelDataComponent.SetVisible(false);
		}
		if (playEffect)
		{
			UiModelUtil.Instance.PlayEffectOnRoot(model, "ShowHideWeaponEffect");
		}
	}

	// Token: 0x06017EF0 RID: 98032 RVA: 0x00616340 File Offset: 0x00614540
	public void RefreshWeaponCase()
	{
		int roleConfigId = this.RoleDataComponent.RoleConfigId;
		SModelConfig modelConfig = ModelUtil.GetModelConfig(RoleConfig.Instance.GetRoleConfig(roleConfigId).Value.UiMeshId);
		if (modelConfig == null)
		{
			return;
		}
		TArray<string> battleSockets = modelConfig.BattleSockets;
		this.WeaponSocketNames.Clear();
		for (int i = 0; i < battleSockets.Num(); i++)
		{
			string item = battleSockets.Get(i);
			this.WeaponSocketNames.Add(item);
		}
	}

	// Token: 0x06017EF1 RID: 98033 RVA: 0x006163C4 File Offset: 0x006145C4
	public void RefreshWeaponDa()
	{
		if (this.WeaponData == null)
		{
			return;
		}
		int breachLevel = this.WeaponData.GetBreachLevel();
		foreach (SkeletalObserverHandle skeletalObserverHandle in this.WeaponHandleList)
		{
			if (skeletalObserverHandle.Model != null)
			{
				UiModelUtil.Instance.SetWeaponLevelMaterialBreachLevel(skeletalObserverHandle.Model, breachLevel);
				UiModelUtil.Instance.TryApplyWeaponLevelMaterial(skeletalObserverHandle.Model);
			}
		}
	}

	// Token: 0x06017EF2 RID: 98034 RVA: 0x00616450 File Offset: 0x00614650
	public void AttachWeaponToRole()
	{
		if (this.ModelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			return;
		}
		USkeletalMeshComponent mainMeshComponent = this.ActorComponent.MainMeshComponent;
		for (int i = 0; i < this.WeaponCount; i++)
		{
			SkeletalObserverHandle skeletalObserverHandle = this.WeaponHandleList[i];
			FName socketName = (i < this.WeaponSocketNames.Count) ? FNameUtil.GetCheckDynamicFName(this.WeaponSocketNames[i]) : FName.NAME_None;
			UiModelBase model = skeletalObserverHandle.Model;
			UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
			if (uiModelActorComponent != null)
			{
				AActor actor = uiModelActorComponent.Actor;
				if (actor != null)
				{
					actor.K2_AttachToComponent(mainMeshComponent, socketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
				}
			}
			FHitResult fhitResult = new FHitResult();
			if (uiModelActorComponent != null)
			{
				AActor actor2 = uiModelActorComponent.Actor;
				if (actor2 != null)
				{
					actor2.D_K2_SetActorRelativeTransform(MathUtils.Instance.DefaultTransformDouble, false, ref fhitResult, false);
				}
			}
		}
	}

	// Token: 0x06017EF3 RID: 98035 RVA: 0x0061651C File Offset: 0x0061471C
	private void HangWeaponByIndex(int index, FName? socketName)
	{
		if (index < 0 || index >= this.WeaponHandleList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weapon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "挂载武器索引错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiModelBase model = this.WeaponHandleList[index].Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent == null)
		{
			return;
		}
		AActor actor = uiModelActorComponent.Actor;
		if (actor == null)
		{
			return;
		}
		actor.K2_AttachToComponent(this.ActorComponent.MainMeshComponent, socketName ?? ((index < this.WeaponSocketNames.Count) ? FNameUtil.GetCheckDynamicFName(this.WeaponSocketNames[index]) : FName.NAME_None), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
	}

	// Token: 0x06017EF4 RID: 98036 RVA: 0x006165E3 File Offset: 0x006147E3
	[NullableContext(2)]
	public void SetWeaponByWeaponData(WeaponDataBase weaponData, int weaponSkinId)
	{
		if (weaponData == null)
		{
			return;
		}
		this.WeaponData = weaponData;
		this.WeaponSkinId = weaponSkinId;
		this.Refresh();
	}

	// Token: 0x06017EF5 RID: 98037 RVA: 0x00616600 File Offset: 0x00614800
	public void ReplaceWeaponModel(int[] modelIds, [Nullable(2)] Action loadFinishCallBack = null)
	{
		UiRoleWeaponComponent.<>c__DisplayClass32_0 CS$<>8__locals1 = new UiRoleWeaponComponent.<>c__DisplayClass32_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.loadFinishCallBack = loadFinishCallBack;
		this.WeaponCount = modelIds.Length;
		this.TrimWeaponHandles(this.WeaponCount);
		for (int i = this.WeaponHandleList.Count; i < this.WeaponCount; i++)
		{
			SkeletalObserverHandle item = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.WeaponOnRole);
			this.WeaponHandleList.Add(item);
			this.WeaponStateList.Add(EWeaponState.None);
			this.WeaponStatesOnRole.Add(false);
			this.HideWeaponByIndex(i, false);
		}
		CS$<>8__locals1.finishCount = 0;
		WeaponDataBase weaponData = this.WeaponData;
		int breachLevel = (weaponData != null) ? weaponData.GetBreachLevel() : 0;
		for (int j = 0; j < this.WeaponCount; j++)
		{
			UiModelBase model = this.WeaponHandleList[j].Model;
			UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
			int? num = (uiModelDataComponent != null) ? new int?(uiModelDataComponent.ModelConfigId) : null;
			int num2 = modelIds[j];
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				UiModelUtil.Instance.SetWeaponLevelMaterialBreachLevel(model, breachLevel);
				UiModelLoadComponent uiModelLoadComponent = model.CheckGetComponent<UiModelLoadComponent>();
				if (uiModelLoadComponent != null)
				{
					uiModelLoadComponent.LoadModelByModelId(modelIds[j], false, delegate
					{
						CS$<>8__locals1.<>4__this.ApplyPlanarReflectionRenderOffset(model);
						CS$<>8__locals1.<ReplaceWeaponModel>g__CallBackCache|0();
					}, null);
				}
			}
		}
	}

	// Token: 0x06017EF6 RID: 98038 RVA: 0x00616760 File Offset: 0x00614960
	public bool HasWeapon()
	{
		return this.WeaponData != null;
	}

	// Token: 0x06017EF7 RID: 98039 RVA: 0x0061676C File Offset: 0x0061496C
	public void SetWeaponTransformByIndex(int index, FTransform transform)
	{
		if (index < 0 || index >= this.WeaponHandleList.Count)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weapon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "设置武器偏移索引错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiModelBase model = this.WeaponHandleList[index].Model;
		object obj = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		FHitResult fhitResult = new FHitResult();
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		USkeletalMeshComponent mainMeshComponent = obj2.MainMeshComponent;
		if (mainMeshComponent == null)
		{
			return;
		}
		mainMeshComponent.K2_SetRelativeTransform(transform, false, ref fhitResult, false);
	}

	// Token: 0x06017EF8 RID: 98040 RVA: 0x006167F8 File Offset: 0x006149F8
	public void SetDitherEffect(float ditherRate)
	{
		foreach (SkeletalObserverHandle skeletalObserverHandle in this.WeaponHandleList)
		{
			UiModelBase model = skeletalObserverHandle.Model;
			UiModelDataComponent uiModelDataComponent = (model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null;
			if (uiModelDataComponent != null)
			{
				uiModelDataComponent.SetDitherEffect(ditherRate);
			}
		}
	}

	// Token: 0x06017EF9 RID: 98041 RVA: 0x00616860 File Offset: 0x00614A60
	public void OnModelPlanarReflectionRenderOffsetChange(bool enable, FVector? offset)
	{
		foreach (SkeletalObserverHandle skeletalObserverHandle in this.WeaponHandleList)
		{
			UiModelBase model = skeletalObserverHandle.Model;
			UiModelDataComponent uiModelDataComponent = (model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null;
			if (uiModelDataComponent != null)
			{
				uiModelDataComponent.SetPlanarReflectionRenderOffset(enable, offset);
			}
		}
	}

	// Token: 0x06017EFA RID: 98042 RVA: 0x006168CC File Offset: 0x00614ACC
	[NullableContext(2)]
	private void ApplyPlanarReflectionRenderOffset(UiModelBase weaponModel)
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		bool? flag = (modelDataComponent != null) ? modelDataComponent.GetPlanarReflectionRenderOffsetEnabled() : null;
		if (modelDataComponent == null || flag == null)
		{
			return;
		}
		UiModelDataComponent uiModelDataComponent = (weaponModel != null) ? weaponModel.CheckGetComponent<UiModelDataComponent>() : null;
		if (uiModelDataComponent == null)
		{
			return;
		}
		uiModelDataComponent.SetPlanarReflectionRenderOffset(flag.Value, modelDataComponent.GetPlanarReflectionRenderOffset());
	}

	// Token: 0x06017EFB RID: 98043 RVA: 0x00616925 File Offset: 0x00614B25
	public int GetWeaponCount()
	{
		return this.WeaponCount;
	}

	// Token: 0x06017EFC RID: 98044 RVA: 0x00616930 File Offset: 0x00614B30
	public void OnAnsBegin(UiAnsContextBase ansContext)
	{
		UiWeaponAnsContext uiWeaponAnsContext = ansContext as UiWeaponAnsContext;
		int index = uiWeaponAnsContext.Index;
		if (index < 0 || index >= this.WeaponStatesOnRole.Count)
		{
			return;
		}
		this.WeaponStatesOnRole[index] = true;
		this.ShowWeaponByIndex(index, uiWeaponAnsContext.ShowMaterialController);
		if (!FNameUtil.IsEmpty(new FName?(uiWeaponAnsContext.HangSocketName)))
		{
			this.HangWeaponByIndex(index, new FName?(uiWeaponAnsContext.HangSocketName));
		}
		if (uiWeaponAnsContext.Transform != null)
		{
			this.SetWeaponTransformByIndex(index, uiWeaponAnsContext.Transform.Value);
		}
	}

	// Token: 0x06017EFD RID: 98045 RVA: 0x006169C4 File Offset: 0x00614BC4
	public void OnAnsEnd(UiAnsContextBase ansContext)
	{
		UiWeaponAnsContext uiWeaponAnsContext = ansContext as UiWeaponAnsContext;
		int index = uiWeaponAnsContext.Index;
		if (index < 0 || index >= this.WeaponStatesOnRole.Count)
		{
			return;
		}
		this.WeaponStatesOnRole[index] = false;
		this.HideWeaponByIndex(index, uiWeaponAnsContext.HideEffect);
		if (!FNameUtil.IsEmpty(new FName?(uiWeaponAnsContext.HangSocketName)))
		{
			this.HangWeaponByIndex(index, null);
		}
	}

	// Token: 0x0400B266 RID: 45670
	[Nullable(2)]
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B267 RID: 45671
	[Nullable(2)]
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B268 RID: 45672
	[Nullable(2)]
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B269 RID: 45673
	[Nullable(2)]
	private UiModelAnsControllerComponent AnsControllerComponent;

	// Token: 0x0400B26A RID: 45674
	[Nullable(2)]
	private WeaponDataBase WeaponData;

	// Token: 0x0400B26B RID: 45675
	private int WeaponSkinId = -1;

	// Token: 0x0400B26C RID: 45676
	private readonly List<SkeletalObserverHandle> WeaponHandleList = new List<SkeletalObserverHandle>();

	// Token: 0x0400B26D RID: 45677
	private int WeaponCount;

	// Token: 0x0400B26E RID: 45678
	private readonly List<string> WeaponSocketNames = new List<string>();

	// Token: 0x0400B26F RID: 45679
	private readonly List<EWeaponState> WeaponStateList = new List<EWeaponState>();

	// Token: 0x0400B270 RID: 45680
	private readonly List<bool> WeaponStatesOnRole = new List<bool>();
}
