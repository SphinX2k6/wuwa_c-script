using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002213 RID: 8723
[NullableContext(1)]
[Nullable(0)]
public class UiRoleWeaponComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect, IUiModelSetPlanarReflectionRenderOffset
{
	// Token: 0x06015759 RID: 87897 RVA: 0x0063B970 File Offset: 0x00639B70
	protected override void OnInit()
	{
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.AnsControllerComponent = base.Owner.CheckGetComponent<UiModelAnsControllerComponent>();
	}

	// Token: 0x0601575A RID: 87898 RVA: 0x0063B9C4 File Offset: 0x00639BC4
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
		ansControllerComponent.RegisterAnsTrigger(typeof(UiWeaponAnsContext), new Action<UiAnsContextBase>(this.OnAnsBegin), new Action<UiAnsContextBase>(this.OnAnsEnd), null, null);
	}

	// Token: 0x0601575B RID: 87899 RVA: 0x0063BA6C File Offset: 0x00639C6C
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

	// Token: 0x0601575C RID: 87900 RVA: 0x0063BB24 File Offset: 0x00639D24
	public void OnModelDitherEffectChange(float value)
	{
		this.SetDitherEffect(value);
	}

	// Token: 0x0601575D RID: 87901 RVA: 0x0063BB30 File Offset: 0x00639D30
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

	// Token: 0x0601575E RID: 87902 RVA: 0x0063BB78 File Offset: 0x00639D78
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

	// Token: 0x0601575F RID: 87903 RVA: 0x0063BBD4 File Offset: 0x00639DD4
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

	// Token: 0x06015760 RID: 87904 RVA: 0x0063BCF4 File Offset: 0x00639EF4
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

	// Token: 0x06015761 RID: 87905 RVA: 0x0063BD76 File Offset: 0x00639F76
	public void OnRoleIdChange()
	{
		this.HideAllWeapon(false);
		this.ResetWeaponStatesOnRole();
		this.RefreshWeaponByRole();
	}

	// Token: 0x06015762 RID: 87906 RVA: 0x0063BD8C File Offset: 0x00639F8C
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

	// Token: 0x06015763 RID: 87907 RVA: 0x0063BE00 File Offset: 0x0063A000
	public void OnRoleMeshLoadComplete()
	{
		this.AttachWeaponToRole();
	}

	// Token: 0x06015764 RID: 87908 RVA: 0x0063BE08 File Offset: 0x0063A008
	public void ShowAllWeapon(bool addMaterialController = false)
	{
		for (int i = 0; i < this.WeaponHandleList.Count; i++)
		{
			this.ShowWeaponByIndex(i, addMaterialController);
		}
	}

	// Token: 0x06015765 RID: 87909 RVA: 0x0063BE34 File Offset: 0x0063A034
	public void HideAllWeapon(bool playEffect = false)
	{
		for (int i = 0; i < this.WeaponHandleList.Count; i++)
		{
			this.HideWeaponByIndex(i, playEffect);
		}
	}

	// Token: 0x06015766 RID: 87910 RVA: 0x0063BE60 File Offset: 0x0063A060
	public void ResetWeaponStatesOnRole()
	{
		for (int i = 0; i < this.WeaponStatesOnRole.Count; i++)
		{
			this.WeaponStatesOnRole[i] = false;
		}
	}

	// Token: 0x06015767 RID: 87911 RVA: 0x0063BE90 File Offset: 0x0063A090
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

	// Token: 0x06015768 RID: 87912 RVA: 0x0063BF48 File Offset: 0x0063A148
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

	// Token: 0x06015769 RID: 87913 RVA: 0x0063C000 File Offset: 0x0063A200
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

	// Token: 0x0601576A RID: 87914 RVA: 0x0063C084 File Offset: 0x0063A284
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

	// Token: 0x0601576B RID: 87915 RVA: 0x0063C110 File Offset: 0x0063A310
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

	// Token: 0x0601576C RID: 87916 RVA: 0x0063C1DC File Offset: 0x0063A3DC
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

	// Token: 0x0601576D RID: 87917 RVA: 0x0063C2A3 File Offset: 0x0063A4A3
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

	// Token: 0x0601576E RID: 87918 RVA: 0x0063C2C0 File Offset: 0x0063A4C0
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

	// Token: 0x0601576F RID: 87919 RVA: 0x0063C420 File Offset: 0x0063A620
	public bool HasWeapon()
	{
		return this.WeaponData != null;
	}

	// Token: 0x06015770 RID: 87920 RVA: 0x0063C42C File Offset: 0x0063A62C
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

	// Token: 0x06015771 RID: 87921 RVA: 0x0063C4B8 File Offset: 0x0063A6B8
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

	// Token: 0x06015772 RID: 87922 RVA: 0x0063C520 File Offset: 0x0063A720
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

	// Token: 0x06015773 RID: 87923 RVA: 0x0063C58C File Offset: 0x0063A78C
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

	// Token: 0x06015774 RID: 87924 RVA: 0x0063C5E5 File Offset: 0x0063A7E5
	public int GetWeaponCount()
	{
		return this.WeaponCount;
	}

	// Token: 0x06015775 RID: 87925 RVA: 0x0063C5F0 File Offset: 0x0063A7F0
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

	// Token: 0x06015776 RID: 87926 RVA: 0x0063C684 File Offset: 0x0063A884
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

	// Token: 0x0400B5D1 RID: 46545
	[Nullable(2)]
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B5D2 RID: 46546
	[Nullable(2)]
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B5D3 RID: 46547
	[Nullable(2)]
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B5D4 RID: 46548
	[Nullable(2)]
	private UiModelAnsControllerComponent AnsControllerComponent;

	// Token: 0x0400B5D5 RID: 46549
	[Nullable(2)]
	private WeaponDataBase WeaponData;

	// Token: 0x0400B5D6 RID: 46550
	private int WeaponSkinId = -1;

	// Token: 0x0400B5D7 RID: 46551
	private readonly List<SkeletalObserverHandle> WeaponHandleList = new List<SkeletalObserverHandle>();

	// Token: 0x0400B5D8 RID: 46552
	private int WeaponCount;

	// Token: 0x0400B5D9 RID: 46553
	private readonly List<string> WeaponSocketNames = new List<string>();

	// Token: 0x0400B5DA RID: 46554
	private readonly List<EWeaponState> WeaponStateList = new List<EWeaponState>();

	// Token: 0x0400B5DB RID: 46555
	private readonly List<bool> WeaponStatesOnRole = new List<bool>();
}
