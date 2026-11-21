using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200220F RID: 8719
[NullableContext(1)]
[Nullable(0)]
public class UiRoleOrnamentComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect, IUiModelRenderingMaterialChange, IUiModelSetPlanarReflectionRenderOffset
{
	// Token: 0x0601570C RID: 87820 RVA: 0x00639A4C File Offset: 0x00637C4C
	protected override void OnInit()
	{
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.BuffComponent = base.Owner.CheckGetComponent<UiRoleBuffComponent>();
		this.TagComponent = base.Owner.GetComponent<UiModelTagComponent>();
	}

	// Token: 0x0601570D RID: 87821 RVA: 0x00639AB0 File Offset: 0x00637CB0
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeRoleModelLoad));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleModelReady));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelSetMorphTypeComplete, new Action(this.OnRoleModelReady));
	}

	// Token: 0x0601570E RID: 87822 RVA: 0x00639B24 File Offset: 0x00637D24
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeRoleModelLoad));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleModelReady));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelSetMorphTypeComplete, new Action(this.OnRoleModelReady));
		this.DestroyAllOrnaments();
	}

	// Token: 0x0601570F RID: 87823 RVA: 0x00639B9D File Offset: 0x00637D9D
	public void SetPendingContexts(OrnamentModelContext[] contexts)
	{
		this.PendingOrnamentContexts = contexts;
	}

	// Token: 0x06015710 RID: 87824 RVA: 0x00639BA6 File Offset: 0x00637DA6
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public OrnamentModelContext[] ConsumePendingContexts()
	{
		OrnamentModelContext[] pendingOrnamentContexts = this.PendingOrnamentContexts;
		this.PendingOrnamentContexts = null;
		return pendingOrnamentContexts;
	}

	// Token: 0x06015711 RID: 87825 RVA: 0x00639BB5 File Offset: 0x00637DB5
	public bool HasPendingContexts()
	{
		return this.PendingOrnamentContexts != null;
	}

	// Token: 0x06015712 RID: 87826 RVA: 0x00639BC0 File Offset: 0x00637DC0
	public void RefreshModels([Nullable(new byte[]
	{
		2,
		1
	})] OrnamentModelContext[] contexts = null, bool forceRefresh = false)
	{
		OrnamentModelContext[] array = (contexts != null && contexts.Length != 0) ? contexts : UiModelUtil.GetSkinWearingOrnamentContexts(this.RoleDataComponent.RoleDataId, this.RoleDataComponent.RoleSkinId).ToArray();
		if (array == null || array.Length == 0)
		{
			this.DestroyAllOrnaments();
			return;
		}
		if (!forceRefresh && this.IsSameModelIds(array))
		{
			return;
		}
		UiRoleOrnamentComponent.SelectModelIds(array);
		UiRoleOrnamentComponent.ToIntArray(this.OrnamentHandleMap.Keys);
		bool flag = this.IsRoleModelLoaded();
		this.OrnamentContextMap.Clear();
		foreach (OrnamentModelContext ornamentModelContext in array)
		{
			this.OrnamentContextMap[ornamentModelContext.ModelId] = ornamentModelContext;
		}
		this.RefreshEquipTags(array);
		List<int> list = new List<int>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (int num in this.OrnamentHandleMap.Keys)
		{
			if (!this.OrnamentContextMap.ContainsKey(num))
			{
				list.Add(num);
			}
			else
			{
				hashSet.Add(num);
			}
		}
		foreach (int modelId in list)
		{
			this.DestroyOrnamentByModelId(modelId);
		}
		foreach (KeyValuePair<int, OrnamentModelContext> keyValuePair in this.OrnamentContextMap)
		{
			int i;
			OrnamentModelContext ornamentModelContext2;
			keyValuePair.Deconstruct(out i, out ornamentModelContext2);
			int num2 = i;
			OrnamentModelContext ornamentModelContext3 = ornamentModelContext2;
			if (ornamentModelContext3.HideInUi)
			{
				if (flag)
				{
					this.AddOrnamentBuffs(num2, ornamentModelContext3.OrnamentUiBuff.ToArray());
				}
			}
			else
			{
				this.OrnamentStateMap[num2] = EOrnamentState.Showing;
				if (!hashSet.Contains(num2))
				{
					SkeletalObserverHandle skeletalObserverHandle;
					if (!this.OrnamentHandleMap.TryGetValue(num2, out skeletalObserverHandle))
					{
						skeletalObserverHandle = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.OrnamentOnRole);
						this.OrnamentHandleMap[num2] = skeletalObserverHandle;
						this.RegisterOrnamentTagListeners(num2);
						UiDecorationLoadComponent uiDecorationLoadComponent = skeletalObserverHandle.Model.CheckGetComponent<UiDecorationLoadComponent>();
						uiDecorationLoadComponent.SetAttachActorComponent(this.ActorComponent);
						uiDecorationLoadComponent.SetAttachSkinId(this.RoleDataComponent.RoleSkinId);
						int capturedModelId = num2;
						OrnamentModelContext capturedCtx = ornamentModelContext3;
						uiDecorationLoadComponent.LoadModelByModelId(capturedModelId, 0, false, delegate
						{
							if (!this.OrnamentHandleMap.ContainsKey(capturedModelId))
							{
								return;
							}
							this.ApplyPlanarReflectionRenderOffset(capturedModelId);
							if (this.IsRoleModelLoaded())
							{
								this.AttachOrnamentToRole(capturedModelId);
								this.SyncOrnamentVisible(capturedModelId);
								this.SpawnOrnamentEffects(capturedModelId);
								this.AddOrnamentBuffs(capturedModelId, capturedCtx.OrnamentUiBuff.ToArray());
							}
						}, null, true);
					}
					else if (flag)
					{
						this.AttachOrnamentToRole(num2);
						this.SyncOrnamentVisible(num2);
						this.SpawnOrnamentEffects(num2);
						this.AddOrnamentBuffs(num2, ornamentModelContext3.OrnamentUiBuff.ToArray());
					}
				}
			}
		}
	}

	// Token: 0x06015713 RID: 87827 RVA: 0x00639EB4 File Offset: 0x006380B4
	[NullableContext(2)]
	public AActor GetActorByModelId(int modelId)
	{
		SkeletalObserverHandle skeletalObserverHandle;
		if (!this.OrnamentHandleMap.TryGetValue(modelId, out skeletalObserverHandle))
		{
			return null;
		}
		UiModelBase model = skeletalObserverHandle.Model;
		if (model == null)
		{
			return null;
		}
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		if (uiModelActorComponent == null)
		{
			return null;
		}
		return uiModelActorComponent.Actor;
	}

	// Token: 0x06015714 RID: 87828 RVA: 0x00639EF0 File Offset: 0x006380F0
	public void OnModelPlanarReflectionRenderOffsetChange(bool enable, FVector? offset)
	{
		foreach (int key in this.OrnamentHandleMap.Keys)
		{
			SkeletalObserverHandle skeletalObserverHandle;
			if (this.OrnamentHandleMap.TryGetValue(key, out skeletalObserverHandle))
			{
				UiModelBase model = skeletalObserverHandle.Model;
				UiModelDataComponent uiModelDataComponent = (model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null;
				if (uiModelDataComponent != null)
				{
					uiModelDataComponent.SetPlanarReflectionRenderOffset(enable, offset);
				}
			}
		}
	}

	// Token: 0x06015715 RID: 87829 RVA: 0x00639F70 File Offset: 0x00638170
	private void ApplyPlanarReflectionRenderOffset(int modelId)
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		bool? flag = (modelDataComponent != null) ? modelDataComponent.GetPlanarReflectionRenderOffsetEnabled() : null;
		SkeletalObserverHandle skeletalObserverHandle;
		if (modelDataComponent == null || flag == null || !this.OrnamentHandleMap.TryGetValue(modelId, out skeletalObserverHandle))
		{
			return;
		}
		UiModelBase model = skeletalObserverHandle.Model;
		UiModelDataComponent uiModelDataComponent = (model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null;
		if (uiModelDataComponent == null)
		{
			return;
		}
		uiModelDataComponent.SetPlanarReflectionRenderOffset(flag.Value, modelDataComponent.GetPlanarReflectionRenderOffset());
	}

	// Token: 0x06015716 RID: 87830 RVA: 0x00639FE0 File Offset: 0x006381E0
	public void OnModelDitherEffectChange(float value)
	{
		foreach (SkeletalObserverHandle skeletalObserverHandle in this.OrnamentHandleMap.Values)
		{
			UiModelBase model = skeletalObserverHandle.Model;
			UiModelDataComponent uiModelDataComponent = (model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null;
			if (uiModelDataComponent != null)
			{
				uiModelDataComponent.SetDitherEffect(value);
			}
		}
	}

	// Token: 0x06015717 RID: 87831 RVA: 0x0063A050 File Offset: 0x00638250
	public void OnRenderingMaterialAdd(int materialId, UObject data, bool isGroup, bool withAnimObject)
	{
		ActiveMaterialEntry activeMaterialEntry = new ActiveMaterialEntry();
		activeMaterialEntry.Data = data;
		activeMaterialEntry.IsGroup = isGroup;
		activeMaterialEntry.WithAnimObject = withAnimObject;
		this.ActiveMaterialMap.Add(materialId, activeMaterialEntry);
		foreach (KeyValuePair<int, SkeletalObserverHandle> keyValuePair in this.OrnamentHandleMap)
		{
			this.AddMaterialToOrnament(keyValuePair.Key, keyValuePair.Value, materialId, data, isGroup, withAnimObject);
		}
	}

	// Token: 0x06015718 RID: 87832 RVA: 0x0063A0E0 File Offset: 0x006382E0
	public void OnRenderingMaterialRemove(int materialId, bool isGroup, bool withEnding)
	{
		this.ActiveMaterialMap.Remove(materialId);
		foreach (KeyValuePair<int, SkeletalObserverHandle> keyValuePair in this.OrnamentHandleMap)
		{
			this.RemoveMaterialFromOrnament(keyValuePair.Key, keyValuePair.Value, materialId, isGroup, withEnding);
		}
	}

	// Token: 0x06015719 RID: 87833 RVA: 0x0063A150 File Offset: 0x00638350
	public void OnModelVisibleChange(bool visible)
	{
		if (visible)
		{
			this.SyncAllOrnamentsVisible();
			return;
		}
		this.SetAllOrnamentsActualVisible(false);
	}

	// Token: 0x0601571A RID: 87834 RVA: 0x0063A164 File Offset: 0x00638364
	private void SyncOrnamentVisible(int modelId)
	{
		bool flag;
		if (this.FollowRoleVisibility)
		{
			UiModelDataComponent modelDataComponent = this.ModelDataComponent;
			flag = (modelDataComponent != null && modelDataComponent.GetVisible());
		}
		else
		{
			flag = true;
		}
		bool flag2 = flag;
		EOrnamentState eornamentState;
		this.OrnamentStateMap.TryGetValue(modelId, out eornamentState);
		bool flag3 = eornamentState == EOrnamentState.Showing;
		this.ApplyOrnamentVisible(modelId, flag2 && flag3 && this.CheckOrnamentTagVisible(modelId));
	}

	// Token: 0x0601571B RID: 87835 RVA: 0x0063A1BC File Offset: 0x006383BC
	private void SyncAllOrnamentsVisible()
	{
		foreach (int modelId in this.OrnamentHandleMap.Keys)
		{
			this.SyncOrnamentVisible(modelId);
		}
	}

	// Token: 0x0601571C RID: 87836 RVA: 0x0063A214 File Offset: 0x00638414
	private void SetAllOrnamentsActualVisible(bool visible)
	{
		foreach (int modelId in this.OrnamentHandleMap.Keys)
		{
			this.ApplyOrnamentVisible(modelId, visible);
			if (visible)
			{
				this.AttachOrnamentToRole(modelId);
			}
		}
	}

	// Token: 0x0601571D RID: 87837 RVA: 0x0063A278 File Offset: 0x00638478
	private void ApplyOrnamentVisible(int modelId, bool visible)
	{
		SkeletalObserverHandle skeletalObserverHandle;
		if (!this.OrnamentHandleMap.TryGetValue(modelId, out skeletalObserverHandle))
		{
			return;
		}
		UiModelBase model = skeletalObserverHandle.Model;
		UiModelDataComponent uiModelDataComponent = (model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null;
		if (uiModelDataComponent == null || visible == uiModelDataComponent.GetVisible())
		{
			return;
		}
		uiModelDataComponent.SetVisible(visible);
	}

	// Token: 0x0601571E RID: 87838 RVA: 0x0063A2C0 File Offset: 0x006384C0
	private bool IsSameModelIds(OrnamentModelContext[] ctxList)
	{
		if (ctxList.Length != this.OrnamentContextMap.Count)
		{
			return false;
		}
		foreach (OrnamentModelContext ornamentModelContext in ctxList)
		{
			if (!this.OrnamentContextMap.ContainsKey(ornamentModelContext.ModelId))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601571F RID: 87839 RVA: 0x0063A309 File Offset: 0x00638509
	private bool IsRoleModelLoaded()
	{
		return this.ModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete;
	}

	// Token: 0x06015720 RID: 87840 RVA: 0x0063A31C File Offset: 0x0063851C
	private void AttachOrnamentToRole(int modelId)
	{
		if (this.DeferOrnamentAttachUntilRoleMeshReady || !this.IsRoleModelLoaded())
		{
			return;
		}
		SkeletalObserverHandle skeletalObserverHandle;
		if (!this.OrnamentHandleMap.TryGetValue(modelId, out skeletalObserverHandle))
		{
			return;
		}
		UiModelBase model = skeletalObserverHandle.Model;
		UiDecorationLoadComponent uiDecorationLoadComponent = (model != null) ? model.CheckGetComponent<UiDecorationLoadComponent>() : null;
		if (uiDecorationLoadComponent != null)
		{
			uiDecorationLoadComponent.SetAttachSkinId(this.RoleDataComponent.RoleSkinId);
		}
		if (uiDecorationLoadComponent != null)
		{
			uiDecorationLoadComponent.AttachToTarget();
		}
		this.SyncActiveMaterialsToOrnament(modelId, skeletalObserverHandle);
	}

	// Token: 0x06015721 RID: 87841 RVA: 0x0063A388 File Offset: 0x00638588
	private void AttachAllOrnamentToRole()
	{
		foreach (int modelId in this.OrnamentHandleMap.Keys)
		{
			this.AttachOrnamentToRole(modelId);
		}
	}

	// Token: 0x06015722 RID: 87842 RVA: 0x0063A3E0 File Offset: 0x006385E0
	private SDecorationConfig GetOrnamentConfig(int configId)
	{
		return DataTableUtil.GetDataTableRowFromName<SDecorationConfig>(EDataTable.DecorationConfig, configId.ToString());
	}

	// Token: 0x06015723 RID: 87843 RVA: 0x0063A3F0 File Offset: 0x006385F0
	private void DestroyOrnamentByModelId(int modelId)
	{
		this.OrnamentMaterialIdMap.Remove(modelId);
		this.RemoveOrnamentTagListeners(modelId);
		this.RemoveOrnamentBuffs(modelId);
		this.DestroyOrnamentEffects(modelId);
		SkeletalObserverHandle skeletalObserverHandle;
		if (this.OrnamentHandleMap.TryGetValue(modelId, out skeletalObserverHandle))
		{
			SkeletalObserverManager.DestroySkeletalObserver(skeletalObserverHandle);
		}
		this.OrnamentHandleMap.Remove(modelId);
		this.OrnamentStateMap.Remove(modelId);
		this.OrnamentContextMap.Remove(modelId);
	}

	// Token: 0x06015724 RID: 87844 RVA: 0x0063A45C File Offset: 0x0063865C
	private void DestroyAllOrnaments()
	{
		this.OrnamentMaterialIdMap.Clear();
		this.RemoveAllOrnamentTagListeners();
		this.RemoveAllEquipTags();
		this.RemoveAllOrnamentBuffs();
		this.DestroyAllOrnamentEffects();
		foreach (SkeletalObserverHandle skeletalObserverHandle in this.OrnamentHandleMap.Values)
		{
			SkeletalObserverManager.DestroySkeletalObserver(skeletalObserverHandle);
		}
		this.OrnamentHandleMap.Clear();
		this.OrnamentStateMap.Clear();
		this.OrnamentContextMap.Clear();
	}

	// Token: 0x06015725 RID: 87845 RVA: 0x0063A4F8 File Offset: 0x006386F8
	private void AddOrnamentBuffs(int modelId, long[] buffIds)
	{
		if (this.BuffComponent == null || buffIds == null || buffIds.Length == 0)
		{
			return;
		}
		foreach (long buffId in buffIds)
		{
			this.BuffComponent.AddBuffByBuffId(buffId);
		}
		this.OrnamentBuffMap[modelId] = buffIds;
	}

	// Token: 0x06015726 RID: 87846 RVA: 0x0063A544 File Offset: 0x00638744
	private void RemoveOrnamentBuffs(int modelId)
	{
		long[] array;
		if (!this.OrnamentBuffMap.TryGetValue(modelId, out array) || this.BuffComponent == null)
		{
			return;
		}
		foreach (long buffId in array)
		{
			this.BuffComponent.RemoveBuffByBuffId(buffId);
		}
		this.OrnamentBuffMap.Remove(modelId);
	}

	// Token: 0x06015727 RID: 87847 RVA: 0x0063A598 File Offset: 0x00638798
	private void RemoveAllOrnamentBuffs()
	{
		if (this.BuffComponent == null)
		{
			this.OrnamentBuffMap.Clear();
			return;
		}
		foreach (long[] array in this.OrnamentBuffMap.Values)
		{
			foreach (long buffId in array)
			{
				this.BuffComponent.RemoveBuffByBuffId(buffId);
			}
		}
		this.OrnamentBuffMap.Clear();
	}

	// Token: 0x06015728 RID: 87848 RVA: 0x0063A628 File Offset: 0x00638828
	private void SpawnOrnamentEffects(int modelId)
	{
		HashSet<int> hashSet;
		if (this.OrnamentEffectHandleMap.TryGetValue(modelId, out hashSet) && hashSet.Count > 0)
		{
			return;
		}
		SDecorationConfig ornamentConfig = this.GetOrnamentConfig(modelId);
		if (ornamentConfig.Effects.Num() <= 0 && ornamentConfig.UIEffects.Num() <= 0)
		{
			return;
		}
		SkeletalObserverHandle skeletalObserverHandle;
		if (!this.OrnamentHandleMap.TryGetValue(modelId, out skeletalObserverHandle))
		{
			return;
		}
		UiModelBase model = skeletalObserverHandle.Model;
		USkeletalMeshComponent uskeletalMeshComponent;
		if (model == null)
		{
			uskeletalMeshComponent = null;
		}
		else
		{
			UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
			uskeletalMeshComponent = ((uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null);
		}
		USkeletalMeshComponent uskeletalMeshComponent2 = uskeletalMeshComponent;
		if (uskeletalMeshComponent2 == null)
		{
			return;
		}
		UiModelBase model2 = skeletalObserverHandle.Model;
		UiModelEffectComponent uiModelEffectComponent = (model2 != null) ? model2.CheckGetComponent<UiModelEffectComponent>() : null;
		if (uiModelEffectComponent == null)
		{
			return;
		}
		if (hashSet == null)
		{
			hashSet = new HashSet<int>();
			this.OrnamentEffectHandleMap[modelId] = hashSet;
		}
		this.SpawnEffectsFromConfig(modelId, ornamentConfig.Effects, uskeletalMeshComponent2, uiModelEffectComponent, hashSet, "Effects");
		this.SpawnEffectsFromConfig(modelId, ornamentConfig.UIEffects, uskeletalMeshComponent2, uiModelEffectComponent, hashSet, "UIEffects");
		UiModelBase model3 = skeletalObserverHandle.Model;
		bool? flag;
		if (model3 == null)
		{
			flag = null;
		}
		else
		{
			UiModelDataComponent uiModelDataComponent = model3.CheckGetComponent<UiModelDataComponent>();
			flag = ((uiModelDataComponent != null) ? new bool?(uiModelDataComponent.GetVisible()) : null);
		}
		bool? flag2 = flag;
		if (!flag2.GetValueOrDefault())
		{
			uiModelEffectComponent.OnModelVisibleChange(false);
		}
	}

	// Token: 0x06015729 RID: 87849 RVA: 0x0063A74C File Offset: 0x0063894C
	private void SpawnEffectsFromConfig(int modelId, TArray<SDecorationConfig_Effect> effects, USkeletalMeshComponent meshComp, UiModelEffectComponent effectComp, HashSet<int> effectHandleList, string effectSource)
	{
		for (int i = 0; i < effects.Num(); i++)
		{
			SDecorationConfig_Effect sdecorationConfig_Effect = effects.Get(i);
			UiModelEffectPlayContext context = new UiModelEffectPlayContext
			{
				EffectPath = sdecorationConfig_Effect.EffectData.ToAssetPathName(),
				AttachTargetComponent = meshComp,
				Transform = MathUtils.Instance.DefaultTransformDouble,
				SocketName = (FNameUtil.GetDynamicFName(sdecorationConfig_Effect.EffectSocketName) ?? FName.NAME_None),
				IsForceShow = false
			};
			int item = effectComp.PlayEffectByContext(context);
			effectHandleList.Add(item);
		}
	}

	// Token: 0x0601572A RID: 87850 RVA: 0x0063A7E8 File Offset: 0x006389E8
	private void DestroyOrnamentEffects(int modelId)
	{
		HashSet<int> hashSet;
		if (!this.OrnamentEffectHandleMap.TryGetValue(modelId, out hashSet))
		{
			return;
		}
		SkeletalObserverHandle skeletalObserverHandle;
		if (!this.OrnamentHandleMap.TryGetValue(modelId, out skeletalObserverHandle))
		{
			return;
		}
		UiModelBase model = skeletalObserverHandle.Model;
		UiModelEffectComponent uiModelEffectComponent = (model != null) ? model.CheckGetComponent<UiModelEffectComponent>() : null;
		if (uiModelEffectComponent == null)
		{
			return;
		}
		foreach (int effectHandle in hashSet)
		{
			uiModelEffectComponent.StopEffect(effectHandle, true);
		}
		hashSet.Clear();
	}

	// Token: 0x0601572B RID: 87851 RVA: 0x0063A878 File Offset: 0x00638A78
	private void DestroyAllOrnamentEffects()
	{
		foreach (int modelId in new List<int>(this.OrnamentEffectHandleMap.Keys))
		{
			this.DestroyOrnamentEffects(modelId);
		}
		this.OrnamentEffectHandleMap.Clear();
	}

	// Token: 0x0601572C RID: 87852 RVA: 0x0063A8E0 File Offset: 0x00638AE0
	private void OnBeforeRoleModelLoad()
	{
		this.DeferOrnamentAttachUntilRoleMeshReady = true;
		this.SetAllOrnamentsActualVisible(false);
		this.DestroyAllOrnamentEffects();
		this.RemoveAllOrnamentBuffs();
		OrnamentModelContext[] pendingOrnamentContexts = this.PendingOrnamentContexts;
		this.PendingOrnamentContexts = null;
		this.RefreshModels(pendingOrnamentContexts, false);
	}

	// Token: 0x0601572D RID: 87853 RVA: 0x0063A920 File Offset: 0x00638B20
	private void OnRoleModelReady()
	{
		this.DeferOrnamentAttachUntilRoleMeshReady = false;
		this.AttachAllOrnamentToRole();
		this.SyncAllOrnamentsVisible();
		foreach (KeyValuePair<int, OrnamentModelContext> keyValuePair in this.OrnamentContextMap)
		{
			int num;
			OrnamentModelContext ornamentModelContext;
			keyValuePair.Deconstruct(out num, out ornamentModelContext);
			int num2 = num;
			OrnamentModelContext ornamentModelContext2 = ornamentModelContext;
			if (ornamentModelContext2.HideInUi)
			{
				this.AddOrnamentBuffs(num2, ornamentModelContext2.OrnamentUiBuff.ToArray());
			}
			else if (this.OrnamentHandleMap.ContainsKey(num2))
			{
				this.SpawnOrnamentEffects(num2);
				this.AddOrnamentBuffs(num2, ornamentModelContext2.OrnamentUiBuff.ToArray());
			}
		}
	}

	// Token: 0x0601572E RID: 87854 RVA: 0x0063A9D4 File Offset: 0x00638BD4
	private void SyncActiveMaterialsToOrnament(int modelId, SkeletalObserverHandle handle)
	{
		foreach (KeyValuePair<int, ActiveMaterialEntry> keyValuePair in this.ActiveMaterialMap)
		{
			ActiveMaterialEntry value = keyValuePair.Value;
			this.AddMaterialToOrnament(modelId, handle, keyValuePair.Key, value.Data, value.IsGroup, value.WithAnimObject);
		}
	}

	// Token: 0x0601572F RID: 87855 RVA: 0x0063AA4C File Offset: 0x00638C4C
	private void AddMaterialToOrnament(int modelId, SkeletalObserverHandle handle, int materialId, UObject data, bool isGroup, bool withAnimObject)
	{
		UiModelBase model = handle.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		CharRenderingComponent charRenderingComponent = (uiModelActorComponent != null) ? uiModelActorComponent.CharRenderingComponent : null;
		if (charRenderingComponent == null)
		{
			return;
		}
		int value = withAnimObject ? ((int)charRenderingComponent.AddMaterialControllerDataWithAnimObject(data, uiModelActorComponent.MainMeshComponent, null)) : (isGroup ? charRenderingComponent.AddMaterialControllerDataGroup(data) : charRenderingComponent.AddMaterialControllerData(data));
		Dictionary<int, int> dictionary;
		if (!this.OrnamentMaterialIdMap.TryGetValue(modelId, out dictionary))
		{
			dictionary = new Dictionary<int, int>();
			this.OrnamentMaterialIdMap[modelId] = dictionary;
		}
		dictionary[materialId] = value;
	}

	// Token: 0x06015730 RID: 87856 RVA: 0x0063AAD8 File Offset: 0x00638CD8
	private void RemoveMaterialFromOrnament(int modelId, SkeletalObserverHandle handle, int materialId, bool isGroup, bool withEnding)
	{
		Dictionary<int, int> dictionary;
		if (!this.OrnamentMaterialIdMap.TryGetValue(modelId, out dictionary))
		{
			return;
		}
		int handle2;
		if (dictionary.TryGetValue(materialId, out handle2))
		{
			dictionary.Remove(materialId);
			UiModelBase model = handle.Model;
			UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
			CharRenderingComponent charRenderingComponent = (uiModelActorComponent != null) ? uiModelActorComponent.CharRenderingComponent : null;
			if (charRenderingComponent == null)
			{
				return;
			}
			if (withEnding)
			{
				if (isGroup)
				{
					charRenderingComponent.RemoveMaterialControllerDataGroupWithEnding(handle2);
					return;
				}
				charRenderingComponent.RemoveMaterialControllerDataWithEnding(handle2);
				return;
			}
			else
			{
				if (isGroup)
				{
					charRenderingComponent.RemoveMaterialControllerDataGroup(handle2);
					return;
				}
				charRenderingComponent.RemoveMaterialControllerData(handle2);
			}
		}
	}

	// Token: 0x06015731 RID: 87857 RVA: 0x0063AB58 File Offset: 0x00638D58
	private void OnOrnamentTagChanged(int tagId, bool tagExist, params object[] _)
	{
		foreach (Dictionary<int, bool> dictionary in this.OrnamentDisplayTagsMap.Values)
		{
			if (dictionary.ContainsKey(tagId))
			{
				dictionary[tagId] = tagExist;
			}
		}
		foreach (Dictionary<int, bool> dictionary2 in this.OrnamentHideTagsMap.Values)
		{
			if (dictionary2.ContainsKey(tagId))
			{
				dictionary2[tagId] = tagExist;
			}
		}
		this.SyncAllOrnamentsVisible();
	}

	// Token: 0x06015732 RID: 87858 RVA: 0x0063AC14 File Offset: 0x00638E14
	private void RegisterOrnamentTagListeners(int modelId)
	{
		if (this.TagComponent == null)
		{
			return;
		}
		SDecorationConfig ornamentConfig = this.GetOrnamentConfig(modelId);
		Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
		Dictionary<int, bool> dictionary2 = new Dictionary<int, bool>();
		this.AddTagsFromContainer(dictionary, ornamentConfig.UIDisplayTags);
		this.AddTagsFromContainer(dictionary2, ornamentConfig.UIHideTags);
		this.OrnamentDisplayTagsMap[modelId] = dictionary;
		this.OrnamentHideTagsMap[modelId] = dictionary2;
	}

	// Token: 0x06015733 RID: 87859 RVA: 0x0063AC74 File Offset: 0x00638E74
	private void AddTagsFromContainer(Dictionary<int, bool> map, FGameplayTagContainer container)
	{
		if (this.TagComponent == null)
		{
			return;
		}
		TArray<FGameplayTag> gameplayTags = container.GameplayTags;
		for (int i = 0; i < gameplayTags.Num(); i++)
		{
			int num = gameplayTags.Get(i).TagId();
			if (num != 0 && !map.ContainsKey(num))
			{
				map[num] = this.TagComponent.ContainsTagById(num);
				int num2;
				this.TagListenerRefCount.TryGetValue(num, out num2);
				if (num2 == 0)
				{
					this.TagComponent.AddTagListener(num, new TTagSwitchedCallback(this.OnOrnamentTagChanged));
				}
				this.TagListenerRefCount[num] = num2 + 1;
			}
		}
	}

	// Token: 0x06015734 RID: 87860 RVA: 0x0063AD08 File Offset: 0x00638F08
	private void RemoveOrnamentTagListeners(int modelId)
	{
		Dictionary<int, bool> map;
		if (this.OrnamentDisplayTagsMap.TryGetValue(modelId, out map))
		{
			this.RemoveTagListenersFromMap(map);
			this.OrnamentDisplayTagsMap.Remove(modelId);
		}
		Dictionary<int, bool> map2;
		if (this.OrnamentHideTagsMap.TryGetValue(modelId, out map2))
		{
			this.RemoveTagListenersFromMap(map2);
			this.OrnamentHideTagsMap.Remove(modelId);
		}
	}

	// Token: 0x06015735 RID: 87861 RVA: 0x0063AD60 File Offset: 0x00638F60
	private void RemoveTagListenersFromMap(Dictionary<int, bool> map)
	{
		if (this.TagComponent == null)
		{
			return;
		}
		foreach (int num in map.Keys)
		{
			int num2;
			this.TagListenerRefCount.TryGetValue(num, out num2);
			if (num2 <= 1)
			{
				this.TagComponent.RemoveTagListener(num, new TTagSwitchedCallback(this.OnOrnamentTagChanged));
				this.TagListenerRefCount.Remove(num);
			}
			else
			{
				this.TagListenerRefCount[num] = num2 - 1;
			}
		}
		map.Clear();
	}

	// Token: 0x06015736 RID: 87862 RVA: 0x0063AE04 File Offset: 0x00639004
	private void RemoveAllOrnamentTagListeners()
	{
		if (this.TagComponent != null)
		{
			foreach (int tagId in this.TagListenerRefCount.Keys)
			{
				this.TagComponent.RemoveTagListener(tagId, new TTagSwitchedCallback(this.OnOrnamentTagChanged));
			}
		}
		this.TagListenerRefCount.Clear();
		this.OrnamentDisplayTagsMap.Clear();
		this.OrnamentHideTagsMap.Clear();
	}

	// Token: 0x06015737 RID: 87863 RVA: 0x0063AE98 File Offset: 0x00639098
	private bool CheckOrnamentTagVisible(int modelId)
	{
		Dictionary<int, bool> map;
		this.OrnamentDisplayTagsMap.TryGetValue(modelId, out map);
		Dictionary<int, bool> map2;
		this.OrnamentHideTagsMap.TryGetValue(modelId, out map2);
		return UiRoleOrnamentComponent.CheckHasTagInMap(map, true) && !UiRoleOrnamentComponent.CheckHasTagInMap(map2, false);
	}

	// Token: 0x06015738 RID: 87864 RVA: 0x0063AED8 File Offset: 0x006390D8
	[NullableContext(2)]
	private static bool CheckHasTagInMap(Dictionary<int, bool> map, bool defaultValue)
	{
		if (map == null || map.Count == 0)
		{
			return defaultValue;
		}
		using (Dictionary<int, bool>.ValueCollection.Enumerator enumerator = map.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06015739 RID: 87865 RVA: 0x0063AF3C File Offset: 0x0063913C
	private static int[] SelectModelIds(OrnamentModelContext[] contexts)
	{
		int[] array = new int[contexts.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = contexts[i].ModelId;
		}
		return array;
	}

	// Token: 0x0601573A RID: 87866 RVA: 0x0063AF6C File Offset: 0x0063916C
	private static int[] ToIntArray(ICollection<int> source)
	{
		int[] array = new int[source.Count];
		source.CopyTo(array, 0);
		return array;
	}

	// Token: 0x0601573B RID: 87867 RVA: 0x0063AF90 File Offset: 0x00639190
	private static string[] ToTagNames(ICollection<int> tagIds)
	{
		string[] array = new string[tagIds.Count];
		int num = 0;
		foreach (int tagId in tagIds)
		{
			array[num++] = GameplayTagUtils.GetNameByTagId(tagId);
		}
		return array;
	}

	// Token: 0x0601573C RID: 87868 RVA: 0x0063AFF0 File Offset: 0x006391F0
	private void RefreshEquipTags(OrnamentModelContext[] ctxList)
	{
		if (this.TagComponent == null)
		{
			return;
		}
		HashSet<int> hashSet = new HashSet<int>();
		foreach (OrnamentModelContext ornamentModelContext in ctxList)
		{
			hashSet.Add(ornamentModelContext.ModelId);
		}
		foreach (int num in UiRoleOrnamentComponent.ToIntArray(this.OrnamentEquipTagsMap.Keys))
		{
			if (!hashSet.Contains(num))
			{
				this.RemoveEquipTags(num);
			}
		}
		foreach (OrnamentModelContext ornamentModelContext2 in ctxList)
		{
			this.AddEquipTags(ornamentModelContext2.ModelId, ornamentModelContext2.EquipTags);
		}
	}

	// Token: 0x0601573D RID: 87869 RVA: 0x0063B090 File Offset: 0x00639290
	private void AddEquipTags(int modelId, List<string> tagNames)
	{
		if (this.TagComponent == null || this.OrnamentEquipTagsMap.ContainsKey(modelId))
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (string text in tagNames)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(text);
			if (GameplayTagUtils.GetGameplayTagById(tagIdByName) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiModel;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "OrnamentComp EquipTag不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagName", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				this.TagComponent.AddTagById(tagIdByName, Array.Empty<object>());
				list.Add(tagIdByName);
			}
		}
		if (list.Count > 0)
		{
			this.OrnamentEquipTagsMap[modelId] = list.ToArray();
		}
	}

	// Token: 0x0601573E RID: 87870 RVA: 0x0063B16C File Offset: 0x0063936C
	private void RemoveEquipTags(int modelId)
	{
		int[] array;
		if (!this.OrnamentEquipTagsMap.TryGetValue(modelId, out array) || this.TagComponent == null)
		{
			this.OrnamentEquipTagsMap.Remove(modelId);
			return;
		}
		foreach (int tagId in array)
		{
			this.TagComponent.ReduceTagById(tagId, Array.Empty<object>());
		}
		this.OrnamentEquipTagsMap.Remove(modelId);
	}

	// Token: 0x0601573F RID: 87871 RVA: 0x0063B1D4 File Offset: 0x006393D4
	private void RemoveAllEquipTags()
	{
		if (this.TagComponent != null)
		{
			foreach (KeyValuePair<int, int[]> keyValuePair in this.OrnamentEquipTagsMap)
			{
				int i;
				int[] array;
				keyValuePair.Deconstruct(out i, out array);
				foreach (int tagId in array)
				{
					this.TagComponent.ReduceTagById(tagId, Array.Empty<object>());
				}
			}
		}
		this.OrnamentEquipTagsMap.Clear();
	}

	// Token: 0x0400B5AF RID: 46511
	public bool FollowRoleVisibility;

	// Token: 0x0400B5B0 RID: 46512
	[Nullable(2)]
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B5B1 RID: 46513
	[Nullable(2)]
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B5B2 RID: 46514
	[Nullable(2)]
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B5B3 RID: 46515
	[Nullable(2)]
	private UiModelBuffComponent BuffComponent;

	// Token: 0x0400B5B4 RID: 46516
	private readonly Dictionary<int, OrnamentModelContext> OrnamentContextMap = new Dictionary<int, OrnamentModelContext>();

	// Token: 0x0400B5B5 RID: 46517
	private readonly Dictionary<int, EOrnamentState> OrnamentStateMap = new Dictionary<int, EOrnamentState>();

	// Token: 0x0400B5B6 RID: 46518
	private readonly Dictionary<int, SkeletalObserverHandle> OrnamentHandleMap = new Dictionary<int, SkeletalObserverHandle>();

	// Token: 0x0400B5B7 RID: 46519
	private readonly Dictionary<int, HashSet<int>> OrnamentEffectHandleMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x0400B5B8 RID: 46520
	private readonly Dictionary<int, long[]> OrnamentBuffMap = new Dictionary<int, long[]>();

	// Token: 0x0400B5B9 RID: 46521
	private readonly Dictionary<int, ActiveMaterialEntry> ActiveMaterialMap = new Dictionary<int, ActiveMaterialEntry>();

	// Token: 0x0400B5BA RID: 46522
	private readonly Dictionary<int, Dictionary<int, int>> OrnamentMaterialIdMap = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400B5BB RID: 46523
	private readonly Dictionary<int, Dictionary<int, bool>> OrnamentDisplayTagsMap = new Dictionary<int, Dictionary<int, bool>>();

	// Token: 0x0400B5BC RID: 46524
	private readonly Dictionary<int, Dictionary<int, bool>> OrnamentHideTagsMap = new Dictionary<int, Dictionary<int, bool>>();

	// Token: 0x0400B5BD RID: 46525
	private readonly Dictionary<int, int> TagListenerRefCount = new Dictionary<int, int>();

	// Token: 0x0400B5BE RID: 46526
	private readonly Dictionary<int, int[]> OrnamentEquipTagsMap = new Dictionary<int, int[]>();

	// Token: 0x0400B5BF RID: 46527
	[Nullable(2)]
	private UiModelTagComponent TagComponent;

	// Token: 0x0400B5C0 RID: 46528
	private bool DeferOrnamentAttachUntilRoleMeshReady;

	// Token: 0x0400B5C1 RID: 46529
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private OrnamentModelContext[] PendingOrnamentContexts;
}
