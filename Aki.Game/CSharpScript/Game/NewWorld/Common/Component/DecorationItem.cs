using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x020061FB RID: 25083
	[NullableContext(1)]
	[Nullable(0)]
	public class DecorationItem
	{
		// Token: 0x0603C3D4 RID: 246740 RVA: 0x01129488 File Offset: 0x01127688
		public DecorationItem(BaseOutlookComponent owner, USkeletalMeshComponent parentMesh, int index, bool alwaysUpdate, bool needDelayShow)
		{
			this.Owner = owner;
			this.ParentMesh = parentMesh;
			this.Index = index;
			this.AlwaysUpdate = alwaysUpdate;
			this.NeedDelayShow = needDelayShow;
			this.TagComp = this.Owner.Entity.GetComponent<BaseTagComponent>();
			this.UeSkelTickMgrComp = this.Owner.Entity.GetComponent<UeSkeletalTickManageComponent>();
			AActor owner2 = this.ParentMesh.GetOwner();
			TSubclassOf<UActorComponent> @class = USkeletalMeshComponent.StaticClass();
			bool bManualAttachment = false;
			FTransform ftransform = new FTransform();
			this.MeshComp = (owner2.AddComponentByClass(@class, bManualAttachment, ftransform, false, new FName("Dec" + this.Index.ToString())) as USkeletalMeshComponent);
			this.MeshComp.SetComponentTickEnabled(false);
			this.MeshComp.K2_AttachToComponent(this.ParentMesh, FNameUtil.NONE, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
			UeSkeletalTickManageComponent ueSkelTickMgrComp = this.UeSkelTickMgrComp;
			if (ueSkelTickMgrComp != null)
			{
				ueSkelTickMgrComp.AddOrRefreshSkeletalMeshComponent(this.MeshComp);
			}
			UeSkeletalTickManageComponent ueSkelTickMgrComp2 = this.UeSkelTickMgrComp;
			if (ueSkelTickMgrComp2 == null)
			{
				return;
			}
			ueSkelTickMgrComp2.EnableOrDisableSkelTick(this.MeshComp, false);
		}

		// Token: 0x170071AE RID: 29102
		// (get) Token: 0x0603C3D5 RID: 246741 RVA: 0x011295B2 File Offset: 0x011277B2
		// (set) Token: 0x0603C3D6 RID: 246742 RVA: 0x011295BA File Offset: 0x011277BA
		public BaseOutlookComponent Owner { get; set; }

		// Token: 0x170071AF RID: 29103
		// (get) Token: 0x0603C3D7 RID: 246743 RVA: 0x011295C3 File Offset: 0x011277C3
		// (set) Token: 0x0603C3D8 RID: 246744 RVA: 0x011295CB File Offset: 0x011277CB
		public USkeletalMeshComponent ParentMesh { get; set; }

		// Token: 0x170071B0 RID: 29104
		// (get) Token: 0x0603C3D9 RID: 246745 RVA: 0x011295D4 File Offset: 0x011277D4
		// (set) Token: 0x0603C3DA RID: 246746 RVA: 0x011295DC File Offset: 0x011277DC
		public int Index { get; set; }

		// Token: 0x170071B1 RID: 29105
		// (get) Token: 0x0603C3DB RID: 246747 RVA: 0x011295E5 File Offset: 0x011277E5
		// (set) Token: 0x0603C3DC RID: 246748 RVA: 0x011295ED File Offset: 0x011277ED
		protected bool AlwaysUpdate { get; set; }

		// Token: 0x170071B2 RID: 29106
		// (get) Token: 0x0603C3DD RID: 246749 RVA: 0x011295F6 File Offset: 0x011277F6
		// (set) Token: 0x0603C3DE RID: 246750 RVA: 0x011295FE File Offset: 0x011277FE
		protected bool NeedDelayShow { get; set; }

		// Token: 0x0603C3DF RID: 246751 RVA: 0x01129608 File Offset: 0x01127808
		private void ResetMeshAnimationState()
		{
			if (this.MeshComp == null || !this.MeshComp.IsValid())
			{
				return;
			}
			UKuroAnimLibrary.EndAnimNotifyStates(this.MeshComp.GetAnimInstance());
			this.MeshComp.SetComponentTickEnabled(false);
			this.MeshComp.SetAnimClass(default(UClassStackOnlyPtr));
			this.MeshComp.SetMasterPoseComponent(null, false);
			this.MeshComp.SetVisibility(false, false);
		}

		// Token: 0x0603C3E0 RID: 246752 RVA: 0x01129678 File Offset: 0x01127878
		public unsafe bool SetDecorationId(int newId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Decoration;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "[Decoration] Equip Decoration";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Index", this.Index);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("From", this.CurrentConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("To", newId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			if (this.CurrentConfigId == newId)
			{
				return true;
			}
			if (this.MeshComp == null)
			{
				return false;
			}
			this.CurrentConfigId = newId;
			if (newId == 0)
			{
				this.DisableSkeletalMesh();
				return true;
			}
			SDecorationConfig modelConfig = DataTableUtil.GetDataTableRowFromName<SDecorationConfig>(EDataTable.DecorationConfig, newId.ToString());
			if (modelConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Decoration;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "[Decoration] Equip Decoration Error. 缺失DT配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Id", newId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("DecConfigId", newId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				this.CurrentConfigId = 0;
				this.DisableSkeletalMesh();
				return false;
			}
			this.RequireVisible = true;
			this.DestroyEffects();
			this.AddTagsListenerInMap(this.DisplayTags, newId, modelConfig.DisplayTags.GameplayTags);
			this.AddTagsListenerInMap(this.HideTags, newId, modelConfig.HideTags.GameplayTags);
			this.Visible = this.ComputeFinalVisible();
			if (modelConfig.UseStaticMesh)
			{
				return this.SetStaticDecorationId(newId, modelConfig);
			}
			this.CurrentUseStaticMesh = false;
			this.ClearStaticMeshComponent();
			string text = modelConfig.SkeletalMesh.ToAssetPathName();
			if (string.IsNullOrEmpty(text))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Decoration;
				ELogAuthor author3 = ELogAuthor.CWZ;
				string message3 = "[Decoration] Equip Decoration Error. SkeletalMesh路径为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Id", newId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				this.CurrentConfigId = 0;
				this.DisableSkeletalMesh();
				return false;
			}
			ResourceSystem.Instance.LoadAsync<USkeletalMesh>(text, delegate([Nullable(2)] USkeletalMesh skelMesh, string _)
			{
				this.OnMeshLoaded(skelMesh, newId, modelConfig);
			}, 100, "js_undefined");
			return this.CurrentConfigId == newId;
		}

		// Token: 0x0603C3E1 RID: 246753 RVA: 0x011299AC File Offset: 0x01127BAC
		private unsafe void OnMeshLoaded([Nullable(2)] USkeletalMesh skelMesh, int newId, SDecorationConfig modelConfig)
		{
			if (this.MeshComp == null || !this.MeshComp.IsValid())
			{
				if (this.CurrentConfigId == newId)
				{
					this.CurrentConfigId = 0;
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Decoration;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[Decoration] Mesh Load Finished but MeshComp is invalid, skip";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", newId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (this.CurrentConfigId != newId)
			{
				return;
			}
			if (skelMesh == null || !skelMesh.IsValid())
			{
				this.CurrentConfigId = 0;
				this.DisableSkeletalMesh();
				return;
			}
			this.ResetMeshAnimationState();
			this.MeshComp.SetSkeletalMesh(skelMesh, true);
			bool finalVisible = this.ComputeFinalVisible();
			if (modelConfig.SetMasterFollow)
			{
				this.ApplyMasterFollow(newId, modelConfig, finalVisible);
				return;
			}
			this.ApplyIndependentAttach(newId, modelConfig, finalVisible);
		}

		// Token: 0x0603C3E2 RID: 246754 RVA: 0x01129AAC File Offset: 0x01127CAC
		private unsafe void ApplyMasterFollow(int newId, SDecorationConfig modelConfig, bool finalVisible)
		{
			USkeletalMeshComponent subMeshComponent = this.GetSubMeshComponent(modelConfig.SubMeshName);
			if (subMeshComponent == null || !subMeshComponent.IsValid() || subMeshComponent == this.MeshComp || subMeshComponent.SkeletalMesh == null || !subMeshComponent.SkeletalMesh.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Decoration;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[Decoration] SetMasterFollow 失败: master 无效或缺少 SkeletalMesh";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", newId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SubMeshName", modelConfig.SubMeshName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("MasterValid", subMeshComponent != null && subMeshComponent.IsValid());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("MasterSkeletalMeshValid", ((subMeshComponent != null) ? subMeshComponent.SkeletalMesh : null) != null && subMeshComponent.SkeletalMesh.IsValid());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("SameAsSelf", subMeshComponent == this.MeshComp);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				this.MeshComp.SetMasterPoseComponent(null, false);
				this.SpawnEffects(newId, modelConfig, finalVisible);
				this.ApplyPresentationVisibility("SetDecorationId.SetMasterFollow.Fallback", finalVisible);
				return;
			}
			this.MeshComp.SetMasterPoseComponent(subMeshComponent, true);
			this.MeshComp.SetComponentTickEnabled(true);
			this.MeshComp.K2_AttachToComponent(subMeshComponent, FNameUtil.NONE, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
			this.SpawnEffects(newId, modelConfig, finalVisible);
			this.ApplyPresentationVisibility("SetDecorationId.SetMasterFollow", finalVisible);
		}

		// Token: 0x0603C3E3 RID: 246755 RVA: 0x01129C6C File Offset: 0x01127E6C
		private void ApplyIndependentAttach(int newId, SDecorationConfig modelConfig, bool finalVisible)
		{
			this.MeshComp.SetMasterPoseComponent(null, false);
			string text = modelConfig.AnimBlueprint.ToAssetPathName();
			if (!string.IsNullOrEmpty(text))
			{
				ResourceSystem.Instance.LoadAsync<UClass>(text, delegate([Nullable(2)] UClass abpClass, string _)
				{
					if (this.CurrentConfigId != newId)
					{
						return;
					}
					this.MeshComp.SetAnimClass(abpClass.ClassStackOnlyPtr);
					this.MeshComp.SetComponentTickEnabled(this.Visible);
				}, 100, "js_undefined");
			}
			else
			{
				this.MeshComp.SetComponentTickEnabled(finalVisible);
			}
			FName socketName = (modelConfig.AttachSocket.Num() > 0) ? modelConfig.AttachSocket.Get(0) : FNameUtil.NONE;
			this.MeshComp.K2_AttachToComponent(this.ParentMesh, socketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
			this.ApplyAttachTransform(this.MeshComp, modelConfig);
			this.SpawnEffects(newId, modelConfig, finalVisible);
			this.ApplyPresentationVisibility("SetDecorationId", finalVisible);
		}

		// Token: 0x0603C3E4 RID: 246756 RVA: 0x01129D3C File Offset: 0x01127F3C
		private void ApplyAttachTransform(USceneComponent meshComp, SDecorationConfig modelConfig)
		{
			if (modelConfig.AttachTrans.Num() > 0)
			{
				int index = 0;
				int skinId = this.Owner.GetSkinId();
				int num;
				if (skinId > 0 && modelConfig.SkinAttachTrans != null && modelConfig.SkinAttachTrans.TryGetValue(skinId, out num) && num < modelConfig.AttachTrans.Num())
				{
					index = num;
				}
				Transform transform = DecorationItem.tmpTrans;
				FTransform ftransform = modelConfig.AttachTrans.Get(index);
				transform.FromUeTransform(ftransform);
			}
			else
			{
				DecorationItem.tmpTrans.SetLocation(Vector.ZeroVectorProxy);
				DecorationItem.tmpTrans.SetRotation(Quat.IdentityProxy);
				DecorationItem.tmpTrans.SetScale3D(Vector.OneVectorProxy);
			}
			FHitResult fhitResult = new FHitResult();
			FTransformDouble ftransformDouble = DecorationItem.tmpTrans.ToUeTransform();
			meshComp.D_K2_SetRelativeTransform(ftransformDouble, false, ref fhitResult, false);
		}

		// Token: 0x0603C3E5 RID: 246757 RVA: 0x01129DF8 File Offset: 0x01127FF8
		private void DisableSkeletalMesh()
		{
			if (this.MeshComp == null)
			{
				return;
			}
			this.DestroyEffects();
			this.SetVisible(false, "DisableSkeletalMesh");
			this.RemoveTagsListenerInMap(this.DisplayTags);
			this.RemoveTagsListenerInMap(this.HideTags);
			this.ResetMeshAnimationState();
			USkeletalMeshComponent meshComp = this.MeshComp;
			if (meshComp != null)
			{
				meshComp.SetSkeletalMesh(null, true);
			}
			this.ClearStaticMeshComponent();
			this.CurrentUseStaticMesh = false;
			UeSkeletalTickManageComponent ueSkelTickMgrComp = this.UeSkelTickMgrComp;
			if (ueSkelTickMgrComp != null)
			{
				ueSkelTickMgrComp.AddOrRefreshSkeletalMeshComponent(this.MeshComp);
			}
			UeSkeletalTickManageComponent ueSkelTickMgrComp2 = this.UeSkelTickMgrComp;
			if (ueSkelTickMgrComp2 == null)
			{
				return;
			}
			ueSkelTickMgrComp2.EnableOrDisableSkelTick(this.MeshComp, false);
		}

		// Token: 0x0603C3E6 RID: 246758 RVA: 0x01129E8C File Offset: 0x0112808C
		private bool CheckHasTagInMap(Dictionary<int, bool> map, bool zero)
		{
			if (map.Count == 0)
			{
				return zero;
			}
			foreach (KeyValuePair<int, bool> keyValuePair in map)
			{
				if (keyValuePair.Value)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603C3E7 RID: 246759 RVA: 0x01129EF0 File Offset: 0x011280F0
		private bool CheckHasTag()
		{
			return this.CheckHasTagInMap(this.DisplayTags, true) && !this.CheckHasTagInMap(this.HideTags, false);
		}

		// Token: 0x0603C3E8 RID: 246760 RVA: 0x01129F14 File Offset: 0x01128114
		private void AddTagsListenerInMap(Dictionary<int, bool> map, int id, TArray<FGameplayTag> gameplayTags)
		{
			if (this.TagComp == null)
			{
				return;
			}
			this.RemoveTagsListenerInMap(map);
			for (int i = 0; i < gameplayTags.Num(); i++)
			{
				FGameplayTag tag = gameplayTags.Get(i);
				if (tag.TagId() != 0 && !map.ContainsKey(tag.TagId()))
				{
					map[tag.TagId()] = this.TagComp.HasTag(tag.TagId());
					this.TagComp.ListenForTagAddOrRemove(new int?(tag.TagId()), new BaseTagComponent.TTagSwitchedCallback(this.SetDecorationDisplay), null);
				}
			}
		}

		// Token: 0x0603C3E9 RID: 246761 RVA: 0x01129FA4 File Offset: 0x011281A4
		private void RemoveTagsListenerInMap(Dictionary<int, bool> map)
		{
			foreach (KeyValuePair<int, bool> keyValuePair in map)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.RemoveTagAddOrRemoveListener(keyValuePair.Key, new BaseTagComponent.TTagSwitchedCallback(this.SetDecorationDisplay));
				}
			}
			map.Clear();
		}

		// Token: 0x0603C3EA RID: 246762 RVA: 0x0112A018 File Offset: 0x01128218
		private void DestroyEffects()
		{
			if (this.SpawnEffectHandleList == null)
			{
				return;
			}
			foreach (int handle in this.SpawnEffectHandleList)
			{
				EffectSystem.Instance.StopEffectById(handle, "[Decoration] SpawnEffects", true, null);
			}
			this.SpawnEffectHandleList = null;
		}

		// Token: 0x0603C3EB RID: 246763 RVA: 0x0112A090 File Offset: 0x01128290
		private void DisplayEffects(bool display)
		{
			if (this.SpawnEffectHandleList == null)
			{
				return;
			}
			foreach (int handle in this.SpawnEffectHandleList)
			{
				EffectSystem.Instance.SetEffectHidden(handle, !display, "[Decoration] SetVisible", false);
			}
		}

		// Token: 0x0603C3EC RID: 246764 RVA: 0x0112A0FC File Offset: 0x011282FC
		private void SpawnEffects(int id, SDecorationConfig modelConfig, bool visible)
		{
			if (modelConfig.Effects.Num() <= 0 || this.MeshComp == null)
			{
				return;
			}
			for (int i = 0; i < modelConfig.Effects.Num(); i++)
			{
				SDecorationConfig_Effect sdecorationConfig_Effect = modelConfig.Effects.Get(i);
				string text = sdecorationConfig_Effect.EffectData.ToAssetPathName();
				if (!string.IsNullOrEmpty(text))
				{
					EffectSystem instance = EffectSystem.Instance;
					UObject world = GlobalData.World;
					FTransform effectTrans = sdecorationConfig_Effect.EffectTrans;
					FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref effectTrans));
					int num = instance.SpawnEffect(world, ftransformDouble, text, "[Decoration] SpawnEffects", new EffectContext(null, this.MeshComp, false), EEffectType.Scene, null, null, null, false, false);
					if (EffectSystem.Instance.IsValid(num))
					{
						if (this.SpawnEffectHandleList == null)
						{
							this.SpawnEffectHandleList = new List<int>();
						}
						this.SpawnEffectHandleList.Add(num);
						EffectSystem.Instance.GetEffectActor(num).K2_AttachToComponent(this.MeshComp, FNameUtil.GetDynamicFName(sdecorationConfig_Effect.EffectSocketName), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
						if (!visible)
						{
							EffectSystem.Instance.SetEffectHidden(num, true, "[Decoration] SpawnEffectsInitHidden", false);
						}
					}
				}
			}
			this.DisplayEffects(visible);
		}

		// Token: 0x0603C3ED RID: 246765 RVA: 0x0112A218 File Offset: 0x01128418
		private void SetDecorationDisplay(int tagId, bool tagExist)
		{
			if (this.DisplayTags.ContainsKey(tagId))
			{
				this.DisplayTags[tagId] = tagExist;
			}
			if (this.HideTags.ContainsKey(tagId))
			{
				this.HideTags[tagId] = tagExist;
			}
			this.RefreshVisibility("TagChangeExist", false);
		}

		// Token: 0x0603C3EE RID: 246766 RVA: 0x0112A267 File Offset: 0x01128467
		public void SetVisible(bool visible, string reason)
		{
			this.RequireVisible = visible;
			if (visible)
			{
				this.RefreshVisibility(reason, false);
				return;
			}
			this.ApplyPresentationVisibility(reason, false);
		}

		// Token: 0x0603C3EF RID: 246767 RVA: 0x0112A284 File Offset: 0x01128484
		private bool ComputeFinalVisible()
		{
			return this.RequireVisible && this.CheckHasTag() && this.IsActive();
		}

		// Token: 0x0603C3F0 RID: 246768 RVA: 0x0112A2A0 File Offset: 0x011284A0
		public void RefreshVisibility(string reason, bool force = false)
		{
			bool flag = this.CheckHasTag();
			bool flag2 = this.IsActive();
			bool flag3 = this.RequireVisible && flag && flag2;
			if (this.Visible == flag3 && !force)
			{
				return;
			}
			this.ApplyPresentationVisibility(reason, flag3);
		}

		// Token: 0x0603C3F1 RID: 246769 RVA: 0x0112A2DC File Offset: 0x011284DC
		private void ApplyPresentationVisibility(string reason, bool visible)
		{
			this.Visible = visible;
			if (this.CurrentUseStaticMesh)
			{
				if (this.NeedDelayShow && this.Visible)
				{
					TimerSystem.Instance.Next(delegate(float _)
					{
						UStaticMeshComponent staticMeshComp2 = this.StaticMeshComp;
						if (staticMeshComp2 != null)
						{
							staticMeshComp2.SetVisibility(this.Visible, false);
						}
						this.DisplayEffects(this.Visible);
					}, null, null);
					return;
				}
				UStaticMeshComponent staticMeshComp = this.StaticMeshComp;
				if (staticMeshComp != null)
				{
					staticMeshComp.SetVisibility(this.Visible, false);
				}
				this.DisplayEffects(this.Visible);
				return;
			}
			else
			{
				USkeletalMeshComponent meshComp = this.MeshComp;
				UKuroAnimLibrary.EndAnimNotifyStates((meshComp != null) ? meshComp.GetAnimInstance() : null);
				if (this.AlwaysUpdate)
				{
					USkeletalMeshComponent meshComp2 = this.MeshComp;
					if (meshComp2 != null)
					{
						meshComp2.SetVisibility(this.Visible, false);
					}
					this.DisplayEffects(this.Visible);
					return;
				}
				USkeletalMeshComponent meshComp3 = this.MeshComp;
				if (((meshComp3 != null) ? meshComp3.SkeletalMesh : null) != null)
				{
					UeSkeletalTickManageComponent ueSkelTickMgrComp = this.UeSkelTickMgrComp;
					if (ueSkelTickMgrComp != null)
					{
						ueSkelTickMgrComp.AddOrRefreshSkeletalMeshComponent(this.MeshComp);
					}
					UeSkeletalTickManageComponent ueSkelTickMgrComp2 = this.UeSkelTickMgrComp;
					if (ueSkelTickMgrComp2 != null)
					{
						ueSkelTickMgrComp2.EnableOrDisableSkelTick(this.MeshComp, this.Visible);
					}
				}
				if (this.NeedDelayShow && this.Visible)
				{
					TimerSystem.Instance.Next(delegate(float _)
					{
						USkeletalMeshComponent meshComp5 = this.MeshComp;
						if (meshComp5 != null)
						{
							meshComp5.SetVisibility(this.Visible, false);
						}
						this.DisplayEffects(this.Visible);
					}, null, null);
					return;
				}
				USkeletalMeshComponent meshComp4 = this.MeshComp;
				if (meshComp4 != null)
				{
					meshComp4.SetVisibility(this.Visible, false);
				}
				this.DisplayEffects(this.Visible);
				return;
			}
		}

		// Token: 0x0603C3F2 RID: 246770 RVA: 0x0112A421 File Offset: 0x01128621
		private bool IsActive()
		{
			return this.ParentMesh != null && this.Owner.Active && this.Owner.Entity.Active;
		}

		// Token: 0x0603C3F3 RID: 246771 RVA: 0x0112A44C File Offset: 0x0112864C
		private unsafe bool SetStaticDecorationId(int newId, SDecorationConfig modelConfig)
		{
			string text = modelConfig.StaticMesh.ToAssetPathName();
			if (string.IsNullOrEmpty(text))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Decoration;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[Decoration] Equip Decoration Error. StaticMesh路径为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", newId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CurrentConfigId = 0;
				this.DisableSkeletalMesh();
				return false;
			}
			this.CurrentUseStaticMesh = true;
			this.ResetMeshAnimationState();
			USkeletalMeshComponent meshComp = this.MeshComp;
			if (meshComp != null)
			{
				meshComp.SetSkeletalMesh(null, true);
			}
			ResourceSystem.Instance.LoadAsync<UStaticMesh>(text, delegate([Nullable(2)] UStaticMesh staticMesh, string _)
			{
				this.OnStaticMeshLoaded(staticMesh, newId, modelConfig);
			}, 100, "js_undefined");
			return this.CurrentConfigId == newId;
		}

		// Token: 0x0603C3F4 RID: 246772 RVA: 0x0112A560 File Offset: 0x01128760
		private unsafe void OnStaticMeshLoaded([Nullable(2)] UStaticMesh staticMesh, int newId, SDecorationConfig modelConfig)
		{
			if (this.CurrentConfigId != newId || !this.CurrentUseStaticMesh)
			{
				return;
			}
			if (staticMesh == null || !staticMesh.IsValid())
			{
				this.CurrentConfigId = 0;
				this.DisableSkeletalMesh();
				return;
			}
			UStaticMeshComponent ustaticMeshComponent = this.EnsureStaticMeshComponent();
			if (ustaticMeshComponent == null || !ustaticMeshComponent.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Decoration;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[Decoration] StaticMesh Load Finished but StaticMeshComp is invalid, skip";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", newId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CurrentConfigId = 0;
				this.DisableSkeletalMesh();
				return;
			}
			ustaticMeshComponent.SetStaticMesh(staticMesh);
			this.ApplyStaticIndependentAttach(newId, modelConfig, this.ComputeFinalVisible());
		}

		// Token: 0x0603C3F5 RID: 246773 RVA: 0x0112A640 File Offset: 0x01128840
		[NullableContext(2)]
		private UStaticMeshComponent EnsureStaticMeshComponent()
		{
			if (this.StaticMeshComp != null && this.StaticMeshComp.IsValid())
			{
				return this.StaticMeshComp;
			}
			AActor owner = this.ParentMesh.GetOwner();
			TSubclassOf<UActorComponent> @class = UStaticMeshComponent.StaticClass();
			bool bManualAttachment = false;
			FTransform ftransform = new FTransform();
			this.StaticMeshComp = (owner.AddComponentByClass(@class, bManualAttachment, ftransform, false, new FName("DecStatic" + this.Index.ToString())) as UStaticMeshComponent);
			if (this.StaticMeshComp == null)
			{
				return null;
			}
			this.StaticMeshComp.SetComponentTickEnabled(false);
			this.StaticMeshComp.K2_AttachToComponent(this.ParentMesh, FNameUtil.NONE, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
			return this.StaticMeshComp;
		}

		// Token: 0x0603C3F6 RID: 246774 RVA: 0x0112A6F0 File Offset: 0x011288F0
		private void ApplyStaticIndependentAttach(int newId, SDecorationConfig modelConfig, bool finalVisible)
		{
			UStaticMeshComponent ustaticMeshComponent = this.EnsureStaticMeshComponent();
			if (ustaticMeshComponent == null)
			{
				return;
			}
			FName socketName = (modelConfig.AttachSocket.Num() > 0) ? modelConfig.AttachSocket.Get(0) : FNameUtil.NONE;
			ustaticMeshComponent.K2_AttachToComponent(this.ParentMesh, socketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
			this.ApplyAttachTransform(ustaticMeshComponent, modelConfig);
			this.ApplyPresentationVisibility("SetDecorationId.StaticMesh", finalVisible);
		}

		// Token: 0x0603C3F7 RID: 246775 RVA: 0x0112A751 File Offset: 0x01128951
		private void ClearStaticMeshComponent()
		{
			if (this.StaticMeshComp == null || !this.StaticMeshComp.IsValid())
			{
				return;
			}
			this.StaticMeshComp.SetStaticMesh(null);
			this.StaticMeshComp.SetVisibility(false, false);
		}

		// Token: 0x0603C3F8 RID: 246776 RVA: 0x0112A784 File Offset: 0x01128984
		[return: Nullable(2)]
		private USkeletalMeshComponent GetSubMeshComponent(string mesh)
		{
			USkeletalMeshComponent parentMesh = this.ParentMesh;
			if (parentMesh == null || !parentMesh.IsValid())
			{
				return null;
			}
			if (this.ParentMesh.GetOwner() == null || mesh.Length == 0)
			{
				return this.ParentMesh;
			}
			TArray<USceneComponent> tarray = new TArray<USceneComponent>();
			this.ParentMesh.GetChildrenComponents(true, ref tarray);
			TArray<USceneComponent> tarray2 = tarray;
			int num = tarray2.Num();
			for (int i = 0; i < num; i++)
			{
				USceneComponent usceneComponent = tarray2.Get(i);
				string name = usceneComponent.GetName();
				USkeletalMeshComponent uskeletalMeshComponent = usceneComponent as USkeletalMeshComponent;
				if (uskeletalMeshComponent != null && name == mesh)
				{
					return uskeletalMeshComponent;
				}
			}
			return this.ParentMesh;
		}

		// Token: 0x0603C3F9 RID: 246777 RVA: 0x0112A81C File Offset: 0x01128A1C
		public void Clear()
		{
			int currentConfigId = this.CurrentConfigId;
			this.DestroyEffects();
			this.RemoveTagsListenerInMap(this.DisplayTags);
			this.RemoveTagsListenerInMap(this.HideTags);
			this.ResetMeshAnimationState();
			USkeletalMeshComponent meshComp = this.MeshComp;
			if (meshComp != null)
			{
				meshComp.SetSkeletalMesh(null, true);
			}
			this.ClearStaticMeshComponent();
			this.CurrentConfigId = 0;
			this.CurrentUseStaticMesh = false;
			this.Visible = false;
			this.RequireVisible = false;
		}

		// Token: 0x0603C3FA RID: 246778 RVA: 0x0112A889 File Offset: 0x01128A89
		public int GetDecorationConfigId()
		{
			return this.CurrentConfigId;
		}

		// Token: 0x0401FE68 RID: 130664
		[StaticVariableRuleIgnore]
		private static Transform tmpTrans = Transform.Create();

		// Token: 0x0401FE69 RID: 130665
		[Nullable(2)]
		private UeSkeletalTickManageComponent UeSkelTickMgrComp;

		// Token: 0x0401FE6A RID: 130666
		[Nullable(2)]
		public USkeletalMeshComponent MeshComp;

		// Token: 0x0401FE6B RID: 130667
		private int CurrentConfigId;

		// Token: 0x0401FE6C RID: 130668
		private bool Visible = true;

		// Token: 0x0401FE6D RID: 130669
		private bool RequireVisible = true;

		// Token: 0x0401FE6E RID: 130670
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x0401FE6F RID: 130671
		public Dictionary<int, bool> DisplayTags = new Dictionary<int, bool>();

		// Token: 0x0401FE70 RID: 130672
		public Dictionary<int, bool> HideTags = new Dictionary<int, bool>();

		// Token: 0x0401FE71 RID: 130673
		private bool CurrentUseStaticMesh;

		// Token: 0x0401FE72 RID: 130674
		[Nullable(2)]
		private UStaticMeshComponent StaticMeshComp;

		// Token: 0x0401FE78 RID: 130680
		[Nullable(2)]
		private List<int> SpawnEffectHandleList;
	}
}
