using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200707A RID: 28794
	[NullableContext(1)]
	[Nullable(0)]
	public class DecorationItem
	{
		// Token: 0x060461CA RID: 287178 RVA: 0x0117FC6C File Offset: 0x0117DE6C
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

		// Token: 0x17009C19 RID: 39961
		// (get) Token: 0x060461CB RID: 287179 RVA: 0x0117FD96 File Offset: 0x0117DF96
		// (set) Token: 0x060461CC RID: 287180 RVA: 0x0117FD9E File Offset: 0x0117DF9E
		public BaseOutlookComponent Owner { get; set; }

		// Token: 0x17009C1A RID: 39962
		// (get) Token: 0x060461CD RID: 287181 RVA: 0x0117FDA7 File Offset: 0x0117DFA7
		// (set) Token: 0x060461CE RID: 287182 RVA: 0x0117FDAF File Offset: 0x0117DFAF
		public USkeletalMeshComponent ParentMesh { get; set; }

		// Token: 0x17009C1B RID: 39963
		// (get) Token: 0x060461CF RID: 287183 RVA: 0x0117FDB8 File Offset: 0x0117DFB8
		// (set) Token: 0x060461D0 RID: 287184 RVA: 0x0117FDC0 File Offset: 0x0117DFC0
		public int Index { get; set; }

		// Token: 0x17009C1C RID: 39964
		// (get) Token: 0x060461D1 RID: 287185 RVA: 0x0117FDC9 File Offset: 0x0117DFC9
		// (set) Token: 0x060461D2 RID: 287186 RVA: 0x0117FDD1 File Offset: 0x0117DFD1
		protected bool AlwaysUpdate { get; set; }

		// Token: 0x17009C1D RID: 39965
		// (get) Token: 0x060461D3 RID: 287187 RVA: 0x0117FDDA File Offset: 0x0117DFDA
		// (set) Token: 0x060461D4 RID: 287188 RVA: 0x0117FDE2 File Offset: 0x0117DFE2
		protected bool NeedDelayShow { get; set; }

		// Token: 0x060461D5 RID: 287189 RVA: 0x0117FDEC File Offset: 0x0117DFEC
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

		// Token: 0x060461D6 RID: 287190 RVA: 0x0117FE5C File Offset: 0x0117E05C
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

		// Token: 0x060461D7 RID: 287191 RVA: 0x01180190 File Offset: 0x0117E390
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

		// Token: 0x060461D8 RID: 287192 RVA: 0x01180290 File Offset: 0x0117E490
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

		// Token: 0x060461D9 RID: 287193 RVA: 0x01180450 File Offset: 0x0117E650
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

		// Token: 0x060461DA RID: 287194 RVA: 0x01180520 File Offset: 0x0117E720
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

		// Token: 0x060461DB RID: 287195 RVA: 0x011805DC File Offset: 0x0117E7DC
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

		// Token: 0x060461DC RID: 287196 RVA: 0x01180670 File Offset: 0x0117E870
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

		// Token: 0x060461DD RID: 287197 RVA: 0x011806D4 File Offset: 0x0117E8D4
		private bool CheckHasTag()
		{
			return this.CheckHasTagInMap(this.DisplayTags, true) && !this.CheckHasTagInMap(this.HideTags, false);
		}

		// Token: 0x060461DE RID: 287198 RVA: 0x011806F8 File Offset: 0x0117E8F8
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

		// Token: 0x060461DF RID: 287199 RVA: 0x01180788 File Offset: 0x0117E988
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

		// Token: 0x060461E0 RID: 287200 RVA: 0x011807FC File Offset: 0x0117E9FC
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

		// Token: 0x060461E1 RID: 287201 RVA: 0x01180874 File Offset: 0x0117EA74
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

		// Token: 0x060461E2 RID: 287202 RVA: 0x011808E0 File Offset: 0x0117EAE0
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

		// Token: 0x060461E3 RID: 287203 RVA: 0x011809FC File Offset: 0x0117EBFC
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

		// Token: 0x060461E4 RID: 287204 RVA: 0x01180A4B File Offset: 0x0117EC4B
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

		// Token: 0x060461E5 RID: 287205 RVA: 0x01180A68 File Offset: 0x0117EC68
		private bool ComputeFinalVisible()
		{
			return this.RequireVisible && this.CheckHasTag() && this.IsActive();
		}

		// Token: 0x060461E6 RID: 287206 RVA: 0x01180A84 File Offset: 0x0117EC84
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

		// Token: 0x060461E7 RID: 287207 RVA: 0x01180AC0 File Offset: 0x0117ECC0
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

		// Token: 0x060461E8 RID: 287208 RVA: 0x01180C05 File Offset: 0x0117EE05
		private bool IsActive()
		{
			return this.ParentMesh != null && this.Owner.Active && this.Owner.Entity.Active;
		}

		// Token: 0x060461E9 RID: 287209 RVA: 0x01180C30 File Offset: 0x0117EE30
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

		// Token: 0x060461EA RID: 287210 RVA: 0x01180D44 File Offset: 0x0117EF44
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

		// Token: 0x060461EB RID: 287211 RVA: 0x01180E24 File Offset: 0x0117F024
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

		// Token: 0x060461EC RID: 287212 RVA: 0x01180ED4 File Offset: 0x0117F0D4
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

		// Token: 0x060461ED RID: 287213 RVA: 0x01180F35 File Offset: 0x0117F135
		private void ClearStaticMeshComponent()
		{
			if (this.StaticMeshComp == null || !this.StaticMeshComp.IsValid())
			{
				return;
			}
			this.StaticMeshComp.SetStaticMesh(null);
			this.StaticMeshComp.SetVisibility(false, false);
		}

		// Token: 0x060461EE RID: 287214 RVA: 0x01180F68 File Offset: 0x0117F168
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

		// Token: 0x060461EF RID: 287215 RVA: 0x01181000 File Offset: 0x0117F200
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

		// Token: 0x060461F0 RID: 287216 RVA: 0x0118106D File Offset: 0x0117F26D
		public int GetDecorationConfigId()
		{
			return this.CurrentConfigId;
		}

		// Token: 0x04024BAD RID: 150445
		[StaticVariableRuleIgnore]
		private static Transform tmpTrans = Transform.Create();

		// Token: 0x04024BAE RID: 150446
		[Nullable(2)]
		private UeSkeletalTickManageComponent UeSkelTickMgrComp;

		// Token: 0x04024BAF RID: 150447
		[Nullable(2)]
		public USkeletalMeshComponent MeshComp;

		// Token: 0x04024BB0 RID: 150448
		private int CurrentConfigId;

		// Token: 0x04024BB1 RID: 150449
		private bool Visible = true;

		// Token: 0x04024BB2 RID: 150450
		private bool RequireVisible = true;

		// Token: 0x04024BB3 RID: 150451
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04024BB4 RID: 150452
		public Dictionary<int, bool> DisplayTags = new Dictionary<int, bool>();

		// Token: 0x04024BB5 RID: 150453
		public Dictionary<int, bool> HideTags = new Dictionary<int, bool>();

		// Token: 0x04024BB6 RID: 150454
		private bool CurrentUseStaticMesh;

		// Token: 0x04024BB7 RID: 150455
		[Nullable(2)]
		private UStaticMeshComponent StaticMeshComp;

		// Token: 0x04024BBD RID: 150461
		[Nullable(2)]
		private List<int> SpawnEffectHandleList;
	}
}
