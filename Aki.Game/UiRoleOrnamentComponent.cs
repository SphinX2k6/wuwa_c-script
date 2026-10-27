using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002CB6 RID: 11446
[NullableContext(1)]
[Nullable(0)]
public class UiRoleOrnamentComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect, IUiModelRenderingMaterialChange, IUiModelSetPlanarReflectionRenderOffset
{
	// Token: 0x06017E98 RID: 97944 RVA: 0x00613EC0 File Offset: 0x006120C0
	protected override void OnInit()
	{
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.BuffComponent = base.Owner.CheckGetComponent<UiRoleBuffComponent>();
		this.TagComponent = base.Owner.GetComponent<UiModelTagComponent>();
	}

	// Token: 0x06017E99 RID: 97945 RVA: 0x00613F24 File Offset: 0x00612124
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeRoleModelLoad));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleModelReady));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelSetMorphTypeComplete, new Action(this.OnRoleModelReady));
	}

	// Token: 0x06017E9A RID: 97946 RVA: 0x00613F98 File Offset: 0x00612198
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeRoleModelLoad));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleModelReady));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelSetMorphTypeComplete, new Action(this.OnRoleModelReady));
		this.DestroyAllOrnaments();
	}

	// Token: 0x06017E9B RID: 97947 RVA: 0x00614011 File Offset: 0x00612211
	public void SetPendingContexts(OrnamentModelContext[] contexts)
	{
		this.PendingOrnamentContexts = contexts;
	}

	// Token: 0x06017E9C RID: 97948 RVA: 0x0061401A File Offset: 0x0061221A
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

	// Token: 0x06017E9D RID: 97949 RVA: 0x00614029 File Offset: 0x00612229
	public bool HasPendingContexts()
	{
		return this.PendingOrnamentContexts != null;
	}

	// Token: 0x06017E9E RID: 97950 RVA: 0x00614034 File Offset: 0x00612234
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
		(from x in array
		select x.ModelId).ToArray<int>();
		this.OrnamentHandleMap.Keys.ToArray<int>();
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

	// Token: 0x06017E9F RID: 97951 RVA: 0x0061434C File Offset: 0x0061254C
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

	// Token: 0x06017EA0 RID: 97952 RVA: 0x00614388 File Offset: 0x00612588
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

	// Token: 0x06017EA1 RID: 97953 RVA: 0x00614408 File Offset: 0x00612608
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

	// Token: 0x06017EA2 RID: 97954 RVA: 0x00614478 File Offset: 0x00612678
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

	// Token: 0x06017EA3 RID: 97955 RVA: 0x006144E8 File Offset: 0x006126E8
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

	// Token: 0x06017EA4 RID: 97956 RVA: 0x00614578 File Offset: 0x00612778
	public void OnRenderingMaterialRemove(int materialId, bool isGroup, bool withEnding)
	{
		this.ActiveMaterialMap.Remove(materialId);
		foreach (KeyValuePair<int, SkeletalObserverHandle> keyValuePair in this.OrnamentHandleMap)
		{
			this.RemoveMaterialFromOrnament(keyValuePair.Key, keyValuePair.Value, materialId, isGroup, withEnding);
		}
	}

	// Token: 0x06017EA5 RID: 97957 RVA: 0x006145E8 File Offset: 0x006127E8
	public void OnModelVisibleChange(bool visible)
	{
		if (visible)
		{
			this.SyncAllOrnamentsVisible();
			return;
		}
		this.SetAllOrnamentsActualVisible(false);
	}

	// Token: 0x06017EA6 RID: 97958 RVA: 0x006145FC File Offset: 0x006127FC
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

	// Token: 0x06017EA7 RID: 97959 RVA: 0x00614654 File Offset: 0x00612854
	private void SyncAllOrnamentsVisible()
	{
		foreach (int modelId in this.OrnamentHandleMap.Keys)
		{
			this.SyncOrnamentVisible(modelId);
		}
	}

	// Token: 0x06017EA8 RID: 97960 RVA: 0x006146AC File Offset: 0x006128AC
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

	// Token: 0x06017EA9 RID: 97961 RVA: 0x00614710 File Offset: 0x00612910
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

	// Token: 0x06017EAA RID: 97962 RVA: 0x00614758 File Offset: 0x00612958
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

	// Token: 0x06017EAB RID: 97963 RVA: 0x006147A1 File Offset: 0x006129A1
	private bool IsRoleModelLoaded()
	{
		return this.ModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete;
	}

	// Token: 0x06017EAC RID: 97964 RVA: 0x006147B4 File Offset: 0x006129B4
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

	// Token: 0x06017EAD RID: 97965 RVA: 0x00614820 File Offset: 0x00612A20
	private void AttachAllOrnamentToRole()
	{
		foreach (int modelId in this.OrnamentHandleMap.Keys)
		{
			this.AttachOrnamentToRole(modelId);
		}
	}

	// Token: 0x06017EAE RID: 97966 RVA: 0x00614878 File Offset: 0x00612A78
	private SDecorationConfig GetOrnamentConfig(int configId)
	{
		return DataTableUtil.GetDataTableRowFromName<SDecorationConfig>(EDataTable.DecorationConfig, configId.ToString());
	}

	// Token: 0x06017EAF RID: 97967 RVA: 0x00614888 File Offset: 0x00612A88
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

	// Token: 0x06017EB0 RID: 97968 RVA: 0x006148F4 File Offset: 0x00612AF4
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

	// Token: 0x06017EB1 RID: 97969 RVA: 0x00614990 File Offset: 0x00612B90
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

	// Token: 0x06017EB2 RID: 97970 RVA: 0x006149DC File Offset: 0x00612BDC
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

	// Token: 0x06017EB3 RID: 97971 RVA: 0x00614A30 File Offset: 0x00612C30
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

	// Token: 0x06017EB4 RID: 97972 RVA: 0x00614AC0 File Offset: 0x00612CC0
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

	// Token: 0x06017EB5 RID: 97973 RVA: 0x00614BE4 File Offset: 0x00612DE4
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

	// Token: 0x06017EB6 RID: 97974 RVA: 0x00614C80 File Offset: 0x00612E80
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

	// Token: 0x06017EB7 RID: 97975 RVA: 0x00614D10 File Offset: 0x00612F10
	private void DestroyAllOrnamentEffects()
	{
		foreach (int modelId in new List<int>(this.OrnamentEffectHandleMap.Keys))
		{
			this.DestroyOrnamentEffects(modelId);
		}
		this.OrnamentEffectHandleMap.Clear();
	}

	// Token: 0x06017EB8 RID: 97976 RVA: 0x00614D78 File Offset: 0x00612F78
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

	// Token: 0x06017EB9 RID: 97977 RVA: 0x00614DB8 File Offset: 0x00612FB8
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

	// Token: 0x06017EBA RID: 97978 RVA: 0x00614E6C File Offset: 0x0061306C
	private void SyncActiveMaterialsToOrnament(int modelId, SkeletalObserverHandle handle)
	{
		foreach (KeyValuePair<int, ActiveMaterialEntry> keyValuePair in this.ActiveMaterialMap)
		{
			ActiveMaterialEntry value = keyValuePair.Value;
			this.AddMaterialToOrnament(modelId, handle, keyValuePair.Key, value.Data, value.IsGroup, value.WithAnimObject);
		}
	}

	// Token: 0x06017EBB RID: 97979 RVA: 0x00614EE4 File Offset: 0x006130E4
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

	// Token: 0x06017EBC RID: 97980 RVA: 0x00614F70 File Offset: 0x00613170
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

	// Token: 0x06017EBD RID: 97981 RVA: 0x00614FF0 File Offset: 0x006131F0
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

	// Token: 0x06017EBE RID: 97982 RVA: 0x006150AC File Offset: 0x006132AC
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

	// Token: 0x06017EBF RID: 97983 RVA: 0x0061510C File Offset: 0x0061330C
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

	// Token: 0x06017EC0 RID: 97984 RVA: 0x006151A0 File Offset: 0x006133A0
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

	// Token: 0x06017EC1 RID: 97985 RVA: 0x006151F8 File Offset: 0x006133F8
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

	// Token: 0x06017EC2 RID: 97986 RVA: 0x0061529C File Offset: 0x0061349C
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

	// Token: 0x06017EC3 RID: 97987 RVA: 0x00615330 File Offset: 0x00613530
	private bool CheckOrnamentTagVisible(int modelId)
	{
		Dictionary<int, bool> map;
		this.OrnamentDisplayTagsMap.TryGetValue(modelId, out map);
		Dictionary<int, bool> map2;
		this.OrnamentHideTagsMap.TryGetValue(modelId, out map2);
		return UiRoleOrnamentComponent.CheckHasTagInMap(map, true) && !UiRoleOrnamentComponent.CheckHasTagInMap(map2, false);
	}

	// Token: 0x06017EC4 RID: 97988 RVA: 0x00615370 File Offset: 0x00613570
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

	// Token: 0x06017EC5 RID: 97989 RVA: 0x006153D4 File Offset: 0x006135D4
	private void RefreshEquipTags(OrnamentModelContext[] ctxList)
	{
		if (this.TagComponent == null)
		{
			return;
		}
		HashSet<int> hashSet = new HashSet<int>(from ctx in ctxList
		select ctx.ModelId);
		foreach (int num in this.OrnamentEquipTagsMap.Keys.ToArray<int>())
		{
			if (!hashSet.Contains(num))
			{
				this.RemoveEquipTags(num);
			}
		}
		foreach (OrnamentModelContext ornamentModelContext in ctxList)
		{
			this.AddEquipTags(ornamentModelContext.ModelId, ornamentModelContext.EquipTags);
		}
	}

	// Token: 0x06017EC6 RID: 97990 RVA: 0x00615474 File Offset: 0x00613674
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

	// Token: 0x06017EC7 RID: 97991 RVA: 0x00615550 File Offset: 0x00613750
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

	// Token: 0x06017EC8 RID: 97992 RVA: 0x006155B8 File Offset: 0x006137B8
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

	// Token: 0x0400B244 RID: 45636
	public bool FollowRoleVisibility;

	// Token: 0x0400B245 RID: 45637
	[Nullable(2)]
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B246 RID: 45638
	[Nullable(2)]
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B247 RID: 45639
	[Nullable(2)]
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B248 RID: 45640
	[Nullable(2)]
	private UiModelBuffComponent BuffComponent;

	// Token: 0x0400B249 RID: 45641
	private readonly Dictionary<int, OrnamentModelContext> OrnamentContextMap = new Dictionary<int, OrnamentModelContext>();

	// Token: 0x0400B24A RID: 45642
	private readonly Dictionary<int, EOrnamentState> OrnamentStateMap = new Dictionary<int, EOrnamentState>();

	// Token: 0x0400B24B RID: 45643
	private readonly Dictionary<int, SkeletalObserverHandle> OrnamentHandleMap = new Dictionary<int, SkeletalObserverHandle>();

	// Token: 0x0400B24C RID: 45644
	private readonly Dictionary<int, HashSet<int>> OrnamentEffectHandleMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x0400B24D RID: 45645
	private readonly Dictionary<int, long[]> OrnamentBuffMap = new Dictionary<int, long[]>();

	// Token: 0x0400B24E RID: 45646
	private readonly Dictionary<int, ActiveMaterialEntry> ActiveMaterialMap = new Dictionary<int, ActiveMaterialEntry>();

	// Token: 0x0400B24F RID: 45647
	private readonly Dictionary<int, Dictionary<int, int>> OrnamentMaterialIdMap = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400B250 RID: 45648
	private readonly Dictionary<int, Dictionary<int, bool>> OrnamentDisplayTagsMap = new Dictionary<int, Dictionary<int, bool>>();

	// Token: 0x0400B251 RID: 45649
	private readonly Dictionary<int, Dictionary<int, bool>> OrnamentHideTagsMap = new Dictionary<int, Dictionary<int, bool>>();

	// Token: 0x0400B252 RID: 45650
	private readonly Dictionary<int, int> TagListenerRefCount = new Dictionary<int, int>();

	// Token: 0x0400B253 RID: 45651
	private readonly Dictionary<int, int[]> OrnamentEquipTagsMap = new Dictionary<int, int[]>();

	// Token: 0x0400B254 RID: 45652
	[Nullable(2)]
	private UiModelTagComponent TagComponent;

	// Token: 0x0400B255 RID: 45653
	private bool DeferOrnamentAttachUntilRoleMeshReady;

	// Token: 0x0400B256 RID: 45654
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private OrnamentModelContext[] PendingOrnamentContexts;
}
