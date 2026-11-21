using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200622D RID: 25133
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemExhibitComponent : EntityComponent
	{
		// Token: 0x0603C798 RID: 247704 RVA: 0x01148CAC File Offset: 0x01146EAC
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreateEntityData p = args.GetP1<CreateEntityData>();
			this.ExhibitData = (p.GetParam<SceneItemExhibitComponent>() as ExhibitComponent);
			if (this.ExhibitData == null)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.BB, "SceneItemExhibitComponent ExhibitData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return true;
		}

		// Token: 0x0603C799 RID: 247705 RVA: 0x01148CF6 File Offset: 0x01146EF6
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			this.StateComponent = base.Entity.GetComponent<SceneItemStateComponent>();
			return true;
		}

		// Token: 0x0603C79A RID: 247706 RVA: 0x01148D2C File Offset: 0x01146F2C
		protected override void OnActivate()
		{
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionShowCompleted));
		}

		// Token: 0x0603C79B RID: 247707 RVA: 0x01148D50 File Offset: 0x01146F50
		private void InitSkeletalMeshComponent()
		{
			SceneItemActorComponent actorComp = this.ActorComp;
			SceneInteractionActor sceneInteractionActor = ((actorComp != null) ? actorComp.GetInteractionMainActor() : null) as SceneInteractionActor;
			AActor aactor = (sceneInteractionActor != null) ? sceneInteractionActor.GetActorByKey("Model") : null;
			if (aactor == null)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.BB, "SceneItemExhibitComponent exhibitActor is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IExhibitEffect exhibitEffect = null;
			IWeaponExhibitConfig weaponExhibitConfig = this.ExhibitData.ExhibitConfig as IWeaponExhibitConfig;
			if (weaponExhibitConfig != null)
			{
				exhibitEffect = weaponExhibitConfig.ActiveEffect;
			}
			else
			{
				IPhantomExhibitConfig phantomExhibitConfig = this.ExhibitData.ExhibitConfig as IPhantomExhibitConfig;
				if (phantomExhibitConfig != null)
				{
					exhibitEffect = phantomExhibitConfig.ActiveEffect;
				}
			}
			if (exhibitEffect != null)
			{
				this.EffectPath = exhibitEffect.Path;
				global::Vector inB = global::Vector.Create((double)exhibitEffect.Offset.X.GetValueOrDefault(), (double)exhibitEffect.Offset.Y.GetValueOrDefault(), (double)exhibitEffect.Offset.Z.GetValueOrDefault());
				this.EffectTransform.SetLocation(this.ActorComp.Owner.D_K2_GetActorLocation());
				this.EffectTransform.GetLocation().Addition(inB, this.EffectTransform.GetLocation());
				this.EffectTransform.SetScale3D(global::Vector.Create((double)exhibitEffect.Scale, (double)exhibitEffect.Scale, (double)exhibitEffect.Scale));
			}
			aactor.SetActorTickEnabled(true);
			aactor.PrimaryActorTick.bCanEverTick = true;
			this.ExhibitActor = aactor;
			if (this.CreatureDataComp.ExhibitionItemId <= 0)
			{
				this.HideSkeletalMeshComponent();
				return;
			}
			this.RefreshSkeletalMeshComponent(this.CreatureDataComp.ExhibitionItemId, true);
		}

		// Token: 0x0603C79C RID: 247708 RVA: 0x01148EE0 File Offset: 0x011470E0
		protected override void OnTick(float delta)
		{
			if (this.ExhibitActor == null)
			{
				return;
			}
			if (!this.CanSelfRotate || this.DeltaSecondRotate == 0f)
			{
				return;
			}
			float yaw = this.DeltaSecondRotate * delta;
			this.Rotator.Yaw = yaw;
			this.ExhibitActor.K2_AddActorLocalRotation(this.Rotator.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x0603C79D RID: 247709 RVA: 0x01148F3E File Offset: 0x0114713E
		protected void OnDeactivate()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionShowCompleted));
		}

		// Token: 0x0603C79E RID: 247710 RVA: 0x01148F62 File Offset: 0x01147162
		protected override bool OnEnd()
		{
			this.CancelPreLoad();
			this.DestroyMeshComponent(this.SkeletonComponentList, this.ExhibitActor);
			CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				charRenderingComponent.K2_DestroyComponent(this.ExhibitActor);
			}
			this.ReleaseEffect();
			return true;
		}

		// Token: 0x0603C79F RID: 247711 RVA: 0x01148F9C File Offset: 0x0114719C
		private void ReleaseEffect()
		{
			if (!EffectSystem.Instance.IsValid(this.EffectHandleId))
			{
				return;
			}
			EffectSystem.Instance.StopEffectById(this.EffectHandleId, "SceneItemExhibitComponent", true, null);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.BB;
			string message = "SceneItemExhibitComponent ReleaseEffect EffectHandleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EffectHandleId", this.EffectHandleId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.EffectHandleId = 0;
		}

		// Token: 0x0603C7A0 RID: 247712 RVA: 0x01149014 File Offset: 0x01147214
		public void RefreshSkeletalMeshComponent(int id, bool forceRefresh = false)
		{
			if (this.ExhibitData == null)
			{
				return;
			}
			if (this.CreatureDataComp.ExhibitionItemId == id && !forceRefresh)
			{
				return;
			}
			if (this.CharRenderingComponent == null)
			{
				this.CharRenderingComponent = this.CreateUiModelCharRenderingComponent();
			}
			this.CreatureDataComp.ExhibitionItemId = id;
			this.ReleaseEffect();
			if (this.ExhibitData.ExhibitConfig.Type == EExhibitItemType.Weapon)
			{
				this.LoadWeaponSkeletalMesh(id);
				return;
			}
			if (this.ExhibitData.ExhibitConfig.Type == EExhibitItemType.Phantom)
			{
				this.LoadPhantomSkeletalMesh(id);
				this.SetExhibitShowEffect(true);
			}
		}

		// Token: 0x0603C7A1 RID: 247713 RVA: 0x011490A0 File Offset: 0x011472A0
		public void HideSkeletalMeshComponent()
		{
			if (this.ExhibitData.ExhibitConfig.Type == EExhibitItemType.Phantom)
			{
				this.SetExhibitShowEffect(false);
			}
			this.CreatureDataComp.ExhibitionItemId = 0;
			this.CanSelfRotate = false;
			this.StopAnimation();
			this.CancelPreLoad();
			if (this.SkeletonComponentList.Count == 0)
			{
				return;
			}
			foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletonComponentList)
			{
				uskeletalMeshComponent.SetHiddenInGame(true, false);
			}
		}

		// Token: 0x0603C7A2 RID: 247714 RVA: 0x01149138 File Offset: 0x01147338
		private CharRenderingComponent CreateUiModelCharRenderingComponent()
		{
			CharRenderingComponent charRenderingComponent = this.ExhibitActor.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as CharRenderingComponent;
			charRenderingComponent.Init(ECharacterRenderingType.Npc);
			charRenderingComponent.SetComponentTickEnabled(true);
			return charRenderingComponent;
		}

		// Token: 0x0603C7A3 RID: 247715 RVA: 0x01149184 File Offset: 0x01147384
		private unsafe void LoadWeaponSkeletalMesh(int id)
		{
			this.CanSelfRotate = false;
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(id));
			List<int> modelIdList = new List<int>();
			List<string> list = new List<string>();
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponItem)
			{
				WeaponConf? weaponItemConfig = InventoryConfig.Instance.GetWeaponItemConfig(id);
				if (weaponItemConfig == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.BB;
					string message = "WeaponConfig is undefined";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				modelIdList = new List<int>(weaponItemConfig.Value.ModelsIter());
				list = new List<string>(weaponItemConfig.Value.StandAnimIter());
			}
			else
			{
				if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.WeaponSkinItem)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SceneItem;
					ELogAuthor author2 = ELogAuthor.BB;
					string message2 = "Invalid ItemType";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemType", itemDataTypeByConfigId);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				WeaponSkin? config = ConfigWeaponSkinById.GetConfig(id, true);
				if (config == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.SceneItem;
					ELogAuthor author3 = ELogAuthor.BB;
					string message3 = "WeaponSkinConfig is undefined";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", id);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				modelIdList = new List<int>(config.Value.ModelsIter());
				list = new List<string>(config.Value.StandAnimIter());
			}
			this.ExhibitActor.SetActorHiddenInGame(true);
			CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				charRenderingComponent.ResetAllRenderingState();
			}
			this.StopAnimation();
			this.CancelPreLoad();
			if (modelIdList.Count <= 0)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.SceneItem;
				ELogAuthor author4 = ELogAuthor.BB;
				string message4 = "ModelIdList is empty";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("id", id);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return;
			}
			if (list.Count <= 0)
			{
				this.LoadModelByModelId(modelIdList, delegate
				{
					this.ExhibitActor.SetActorHiddenInGame(false);
					this.AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;
					this.LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;
					this.MeshStreamTaskId = -1;
					this.WeaponLoadComplete(id, new List<UAnimationAsset>());
				});
				return;
			}
			this.LoadWeaponAnimList(list, delegate(List<UAnimationAsset> animList)
			{
				this.LoadModelByModelId(modelIdList, delegate
				{
					this.ExhibitActor.SetActorHiddenInGame(false);
					this.ExhibitActor.K2_SetActorRotation(FRotator.ZeroRotator, false);
					this.AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;
					this.LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;
					this.MeshStreamTaskId = -1;
					this.WeaponLoadComplete(id, animList);
				});
			});
		}

		// Token: 0x0603C7A4 RID: 247716 RVA: 0x011493E0 File Offset: 0x011475E0
		private void LoadWeaponAnimList(List<string> standAnimList, Action<List<UAnimationAsset>> callback)
		{
			List<UAnimationAsset> animList = new List<UAnimationAsset>();
			if (standAnimList.Count <= 0)
			{
				callback(animList);
			}
			this.LoadAnimByAnimPath(standAnimList[0], delegate(UAnimationAsset animAsset)
			{
				animList.Add(animAsset);
				if (standAnimList.Count == animList.Count)
				{
					callback(animList);
				}
			});
			if (standAnimList.Count > 1)
			{
				this.LoadSecondAnimByAnimPath(standAnimList[1], delegate(UAnimationAsset animAsset)
				{
					animList.Add(animAsset);
					if (standAnimList.Count == animList.Count)
					{
						callback(animList);
					}
				});
			}
		}

		// Token: 0x0603C7A5 RID: 247717 RVA: 0x01149478 File Offset: 0x01147678
		private void WeaponLoadComplete(int itemId, List<UAnimationAsset> animList)
		{
			if (this.SkeletonComponentList.Count == 0)
			{
				return;
			}
			ExhibitWeaponTransform? config = ConfigExhibitWeaponTransformById.GetConfig(WeaponConfig.Instance.GetWeaponConfigByItemId(itemId).Value.TransformId, true);
			List<Transform> weaponExhibitTransform = this.GetWeaponExhibitTransform(config.Value, this.SkeletonComponentList.Count > 1);
			if (weaponExhibitTransform.Count != this.SkeletonComponentList.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.BB;
				string message = "WeaponLoadComplete transformList length not equal SkeletonComponentList length";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			for (int i = 0; i < this.SkeletonComponentList.Count; i++)
			{
				USkeletalMeshComponent uskeletalMeshComponent = this.SkeletonComponentList[i];
				USceneComponent usceneComponent = uskeletalMeshComponent;
				FTransform ftransform = weaponExhibitTransform[i].ToUeTransformOld();
				usceneComponent.K2_SetRelativeTransform(ftransform, false, ref WorldGlobal.SweepHitResult, false);
				uskeletalMeshComponent.SetAnimationMode(EAnimationMode.AnimationSingleNode);
				if (animList.Count > i)
				{
					uskeletalMeshComponent.PlayAnimation(animList[i], true);
				}
			}
			this.CanSelfRotate = true;
			this.DeltaSecondRotate = ((config.Value.RotateTime != 0) ? (360f / (float)config.Value.RotateTime) : 0f);
		}

		// Token: 0x0603C7A6 RID: 247718 RVA: 0x011495BC File Offset: 0x011477BC
		private unsafe void LoadPhantomSkeletalMesh(int id)
		{
			if (this.ExhibitData == null)
			{
				return;
			}
			this.ExhibitActor.SetActorHiddenInGame(true);
			PhantomItem? config = PhantomBattleConfig.Instance.GetPhantomItemById(id);
			this.StopAnimation();
			this.CancelPreLoad();
			this.LoadAnimByAnimPath(config.Value.StandAnim, delegate(UAnimationAsset animAsset)
			{
				SceneItemExhibitComponent <>4__this = this;
				int num = 1;
				List<int> list = new List<int>(num);
				CollectionsMarshal.SetCount<int>(list, num);
				Span<int> span = CollectionsMarshal.AsSpan<int>(list);
				int index = 0;
				*span[index] = config.Value.MeshId;
				<>4__this.LoadModelByModelId(list, delegate
				{
					this.ExhibitActor.SetActorHiddenInGame(false);
					this.AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;
					this.LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;
					this.MeshStreamTaskId = -1;
					this.PhantomLoadComplete(animAsset);
				});
			});
		}

		// Token: 0x0603C7A7 RID: 247719 RVA: 0x01149630 File Offset: 0x01147830
		private void PhantomLoadComplete(UAnimationAsset animAsset)
		{
			if (this.SkeletonComponentList.Count == 0)
			{
				return;
			}
			USkeletalMeshComponent uskeletalMeshComponent = this.SkeletonComponentList[0];
			Transform phantomSkeletalMeshTransform = this.GetPhantomSkeletalMeshTransform(this.CreatureDataComp.ExhibitionItemId);
			FTransform ftransform = phantomSkeletalMeshTransform.ToUeTransformOld();
			uskeletalMeshComponent.K2_SetRelativeTransform(ftransform, false, ref WorldGlobal.SweepHitResult, false);
			uskeletalMeshComponent.SetAnimationMode(EAnimationMode.AnimationSingleNode);
			uskeletalMeshComponent.PlayAnimation(animAsset, true);
		}

		// Token: 0x0603C7A8 RID: 247720 RVA: 0x01149690 File Offset: 0x01147890
		private void LoadModelByModelId(List<int> modelIdList, Action finishCallBack)
		{
			List<string> meshPathList = new List<string>();
			foreach (int num in modelIdList)
			{
				string text = ModelUtil.GetModelConfig(num).网格体.ToAssetPathName();
				if (string.IsNullOrEmpty(text))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.BB;
					string message = "SceneItemExhibitComponent meshPath is empty";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("modelId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					meshPathList.Add(text);
				}
			}
			this.CancelPreLoad();
			this.LoadHandleId = UiModelResourcesManager.Instance.LoadUiModelResources(meshPathList, delegate(EUiRoleLoadResult result, [Nullable(new byte[]
			{
				2,
				1,
				1
			})] Dictionary<string, UObject> resultMap)
			{
				List<USkeletalMesh> list = new List<USkeletalMesh>();
				foreach (string text2 in meshPathList)
				{
					USkeletalMesh uskeletalMesh = ((resultMap != null) ? resultMap[text2] : null) as USkeletalMesh;
					if (uskeletalMesh == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.SceneItem;
						ELogAuthor author2 = ELogAuthor.BB;
						string message2 = "SceneItemExhibitComponent LoadUiModelResources mesh is undefined";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("meshPath", text2);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
					else
					{
						list.Add(uskeletalMesh);
					}
				}
				this.CancelPreMeshStreaming();
				this.DestroyMeshComponent(this.SkeletonComponentList, this.ExhibitActor);
				this.CreateSkeletalMeshComponentList(this.ExhibitActor, list);
				MeshStreamTaskContext meshStreamTaskContext = new MeshStreamTaskContext();
				TArray<USkeletalMesh> tarray = new TArray<USkeletalMesh>();
				foreach (USkeletalMesh value in list)
				{
					tarray.Add(value);
				}
				meshStreamTaskContext.SkeletalMeshes = tarray;
				meshStreamTaskContext.OnTaskFinish = finishCallBack;
				this.MeshStreamTaskId = MeshStreamController.Instance.AddMeshStreamTask(meshStreamTaskContext);
			});
		}

		// Token: 0x0603C7A9 RID: 247721 RVA: 0x01149774 File Offset: 0x01147974
		private void CreateSkeletalMeshComponentList(AActor actor, List<USkeletalMesh> meshList)
		{
			foreach (USkeletalMesh newMesh in meshList)
			{
				USkeletalMeshComponent uskeletalMeshComponent = actor.AddComponentByClass(USkeletalMeshComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as USkeletalMeshComponent;
				uskeletalMeshComponent.SetSkeletalMesh(newMesh, true);
				uskeletalMeshComponent.bConsiderAllBodiesForBounds = true;
				uskeletalMeshComponent.KuroMaterialControllerUpdateGroupMode = EKuroMaterialControllerUpdateGroupMode.CharMesh;
				uskeletalMeshComponent.SetHiddenInGame(false, false);
				uskeletalMeshComponent.SetComponentTickEnabled(true);
				this.AttachToCharRenderingComponent(uskeletalMeshComponent);
				this.SkeletonComponentList.Add(uskeletalMeshComponent);
			}
		}

		// Token: 0x0603C7AA RID: 247722 RVA: 0x01149820 File Offset: 0x01147A20
		private void AttachToCharRenderingComponent(USkeletalMeshComponent skeletalComponent)
		{
			if (this.ExhibitData.ExhibitConfig.Type == EExhibitItemType.Weapon)
			{
				this.CharRenderingComponent.AddComponent("WeaponCase0", skeletalComponent);
				return;
			}
			if (this.ExhibitData.ExhibitConfig.Type == EExhibitItemType.Phantom)
			{
				this.CharRenderingComponent.AddComponent("CharacterMesh0", skeletalComponent);
			}
		}

		// Token: 0x0603C7AB RID: 247723 RVA: 0x01149878 File Offset: 0x01147A78
		private void DestroyMeshComponent(List<USkeletalMeshComponent> meshCompList, AActor actor)
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent in meshCompList)
			{
				uskeletalMeshComponent.K2_DestroyComponent(actor);
			}
			meshCompList.Clear();
		}

		// Token: 0x0603C7AC RID: 247724 RVA: 0x011498CC File Offset: 0x01147ACC
		private void CancelPreLoad()
		{
			if (this.AnimHandleId != UiModelResourcesManager.Instance.InvalidValue)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.AnimHandleId);
				this.AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;
			}
			if (this.SecondAnimHandleId != UiModelResourcesManager.Instance.InvalidValue)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SecondAnimHandleId);
				this.SecondAnimHandleId = UiModelResourcesManager.Instance.InvalidValue;
			}
			if (this.LoadHandleId != UiModelResourcesManager.Instance.InvalidValue)
			{
				UiModelResourcesManager.Instance.CancelUiModelResourceLoad(this.LoadHandleId);
				this.LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;
			}
			this.CancelPreMeshStreaming();
		}

		// Token: 0x0603C7AD RID: 247725 RVA: 0x01149978 File Offset: 0x01147B78
		private void StopAnimation()
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletonComponentList)
			{
				uskeletalMeshComponent.Stop();
			}
		}

		// Token: 0x0603C7AE RID: 247726 RVA: 0x011499C8 File Offset: 0x01147BC8
		private void CancelPreMeshStreaming()
		{
			if (this.MeshStreamTaskId != -1)
			{
				MeshStreamController.Instance.RemoveMeshStreamTask(this.MeshStreamTaskId);
				this.MeshStreamTaskId = -1;
			}
		}

		// Token: 0x0603C7AF RID: 247727 RVA: 0x011499EC File Offset: 0x01147BEC
		private void LoadAnimByAnimPath(string standAnim, Action<UAnimationAsset> finishCallBack)
		{
			this.AnimHandleId = ResourceSystem.Instance.LoadAsync<UAnimationAsset>(standAnim, delegate([Nullable(2)] UAnimationAsset animAsset, string path)
			{
				if (animAsset == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.BB;
					string message = "SceneItemExhibitComponent LoadAnimByModelId animAsset is undefined";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("standAnim", standAnim);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				finishCallBack(animAsset);
			}, ResourceSystem.EResourceLoadPriority.Default, "Ui.PhantomUi");
		}

		// Token: 0x0603C7B0 RID: 247728 RVA: 0x01149A38 File Offset: 0x01147C38
		private void LoadSecondAnimByAnimPath(string secondAnim, Action<UAnimationAsset> finishCallBack)
		{
			this.SecondAnimHandleId = ResourceSystem.Instance.LoadAsync<UAnimationAsset>(secondAnim, delegate([Nullable(2)] UAnimationAsset animAsset, string path)
			{
				if (animAsset == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.BB;
					string message = "SceneItemExhibitComponent LoadSecondAnimByModelId animAsset is undefined";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("secondAnim", secondAnim);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				finishCallBack(animAsset);
			}, ResourceSystem.EResourceLoadPriority.Default, "Ui.PhantomUi");
		}

		// Token: 0x0603C7B1 RID: 247729 RVA: 0x01149A84 File Offset: 0x01147C84
		private List<Transform> GetWeaponExhibitTransform(ExhibitWeaponTransform transformConfig, bool hasSubMesh)
		{
			List<Transform> list = new List<Transform>();
			global::Vector inT = global::Vector.Create((double)transformConfig.Location.Value.X, (double)transformConfig.Location.Value.Y, (double)transformConfig.Location.Value.Z);
			Rotator rotator = Rotator.Create(transformConfig.Rotation.Value.Y, transformConfig.Rotation.Value.Z, transformConfig.Rotation.Value.X);
			global::Vector inS = global::Vector.Create((double)transformConfig.Size, (double)transformConfig.Size, (double)transformConfig.Size);
			Transform item = Transform.Create(rotator.Quaternion(null), inT, inS);
			list.Add(item);
			if (!hasSubMesh)
			{
				return list;
			}
			global::Vector inT2 = global::Vector.Create((double)transformConfig.ScabbardOffset.Value.X, (double)transformConfig.ScabbardOffset.Value.Y, (double)transformConfig.ScabbardOffset.Value.Z);
			Transform item2 = Transform.Create(Rotator.Create(transformConfig.ScabbardRotationOffset.Value.Y, transformConfig.ScabbardRotationOffset.Value.Z, transformConfig.ScabbardRotationOffset.Value.X).Quaternion(null), inT2, inS);
			list.Add(item2);
			return list;
		}

		// Token: 0x0603C7B2 RID: 247730 RVA: 0x01149C34 File Offset: 0x01147E34
		private Transform GetPhantomSkeletalMeshTransform(int itemId)
		{
			ExhibitPhantom? config = ConfigExhibitPhantomById.GetConfig(InventoryConfig.Instance.GetPhantomItemConfig(itemId).Value.MonsterId, true);
			float[] locationArray = config.Value.GetLocationArray();
			global::Vector inT = global::Vector.Create((double)locationArray[0], (double)locationArray[1], (double)locationArray[2]);
			float[] rotatorArray = config.Value.GetRotatorArray();
			Rotator rotator = Rotator.Create(rotatorArray[0], rotatorArray[1], rotatorArray[2]);
			float[] zoomArray = config.Value.GetZoomArray();
			global::Vector inS = global::Vector.Create((double)zoomArray[0], (double)zoomArray[1], (double)zoomArray[2]);
			return Transform.Create(rotator.Quaternion(null), inT, inS);
		}

		// Token: 0x0603C7B3 RID: 247731 RVA: 0x01149CE0 File Offset: 0x01147EE0
		public void SetExhibitShowEffect(bool isActive)
		{
			if (!isActive)
			{
				this.ReleaseEffect();
				return;
			}
			if (EffectSystem.Instance.IsValid(this.EffectHandleId))
			{
				return;
			}
			if (string.IsNullOrEmpty(this.EffectPath))
			{
				return;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject owner = this.ActorComp.Owner;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.EffectTransform.ToUeTransform());
			this.EffectHandleId = instance.SpawnEffect(owner, ftransformDouble, this.EffectPath, "SceneItemExhibitComponent", null, EEffectType.Scene, null, null, null, false, false);
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.BB;
			string message = "SceneItemExhibitComponent SetExhibitShowEffect EffectHandleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EffectHandleId", this.EffectHandleId);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603C7B4 RID: 247732 RVA: 0x01149D8C File Offset: 0x01147F8C
		private void OnSceneInteractionShowCompleted()
		{
			this.InitSkeletalMeshComponent();
		}

		// Token: 0x0603C7B5 RID: 247733 RVA: 0x01149D94 File Offset: 0x01147F94
		[NullableContext(2)]
		public IExhibitItemType GetExhibitConfig()
		{
			if (this.ExhibitData == null)
			{
				return null;
			}
			return this.ExhibitData.ExhibitConfig;
		}

		// Token: 0x0603C7B6 RID: 247734 RVA: 0x01149DAB File Offset: 0x01147FAB
		public int GetItemId()
		{
			return this.CreatureDataComp.ExhibitionItemId;
		}

		// Token: 0x0603C7B7 RID: 247735 RVA: 0x01149DB8 File Offset: 0x01147FB8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemExhibitComponent sceneItemExhibitComponent = (SceneItemExhibitComponent)componentTemplate;
			if (sceneItemExhibitComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemExhibitComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemExhibitComponent.StateComponent == null)
			{
				this.StateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComponent), "StateComponent"))
			{
				return false;
			}
			if (sceneItemExhibitComponent.ExhibitData == null)
			{
				this.ExhibitData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ExhibitData), "ExhibitData"))
			{
				return false;
			}
			if (sceneItemExhibitComponent.ExhibitActor == null)
			{
				this.ExhibitActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ExhibitActor), "ExhibitActor"))
			{
				return false;
			}
			this.LoadHandleId = sceneItemExhibitComponent.LoadHandleId;
			this.MeshStreamTaskId = sceneItemExhibitComponent.MeshStreamTaskId;
			this.AnimHandleId = sceneItemExhibitComponent.AnimHandleId;
			this.SecondAnimHandleId = sceneItemExhibitComponent.SecondAnimHandleId;
			this.CharRenderingComponent = sceneItemExhibitComponent.CharRenderingComponent;
			if (sceneItemExhibitComponent.SkeletonComponentList == null)
			{
				this.SkeletonComponentList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkeletonComponentList), "SkeletonComponentList"))
			{
				return false;
			}
			this.CanSelfRotate = sceneItemExhibitComponent.CanSelfRotate;
			this.DeltaSecondRotate = sceneItemExhibitComponent.DeltaSecondRotate;
			if (sceneItemExhibitComponent.Rotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.Rotator), "Rotator"))
			{
				return false;
			}
			this.EffectPath = sceneItemExhibitComponent.EffectPath;
			if (sceneItemExhibitComponent.EffectTransform != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EffectTransform), "EffectTransform"))
			{
				return false;
			}
			this.EffectHandleId = sceneItemExhibitComponent.EffectHandleId;
			return true;
		}

		// Token: 0x17007240 RID: 29248
		// (get) Token: 0x0603C7B8 RID: 247736 RVA: 0x01149F8A File Offset: 0x0114818A
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007241 RID: 29249
		// (get) Token: 0x0603C7B9 RID: 247737 RVA: 0x01149F8D File Offset: 0x0114818D
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007242 RID: 29250
		// (get) Token: 0x0603C7BA RID: 247738 RVA: 0x01149F90 File Offset: 0x01148190
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007243 RID: 29251
		// (get) Token: 0x0603C7BB RID: 247739 RVA: 0x01149F93 File Offset: 0x01148193
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020098 RID: 131224
		private const string EXHIBIT_ACTOR_REFERENCE_KEY = "Model";

		// Token: 0x04020099 RID: 131225
		[Nullable(2)]
		protected SceneItemActorComponent ActorComp;

		// Token: 0x0402009A RID: 131226
		[Nullable(2)]
		protected CreatureDataComponent CreatureDataComp;

		// Token: 0x0402009B RID: 131227
		[Nullable(2)]
		protected SceneItemStateComponent StateComponent;

		// Token: 0x0402009C RID: 131228
		[Nullable(2)]
		protected ExhibitComponent ExhibitData;

		// Token: 0x0402009D RID: 131229
		[Nullable(2)]
		private AActor ExhibitActor;

		// Token: 0x0402009E RID: 131230
		private int LoadHandleId = UiModelResourcesManager.Instance.InvalidValue;

		// Token: 0x0402009F RID: 131231
		private int MeshStreamTaskId = -1;

		// Token: 0x040200A0 RID: 131232
		private int AnimHandleId = UiModelResourcesManager.Instance.InvalidValue;

		// Token: 0x040200A1 RID: 131233
		private int SecondAnimHandleId = UiModelResourcesManager.Instance.InvalidValue;

		// Token: 0x040200A2 RID: 131234
		[Nullable(2)]
		public CharRenderingComponent CharRenderingComponent;

		// Token: 0x040200A3 RID: 131235
		protected List<USkeletalMeshComponent> SkeletonComponentList = new List<USkeletalMeshComponent>();

		// Token: 0x040200A4 RID: 131236
		private bool CanSelfRotate;

		// Token: 0x040200A5 RID: 131237
		private float DeltaSecondRotate;

		// Token: 0x040200A6 RID: 131238
		private readonly Rotator Rotator = Rotator.Create();

		// Token: 0x040200A7 RID: 131239
		private string EffectPath = "";

		// Token: 0x040200A8 RID: 131240
		private readonly Transform EffectTransform = Transform.Create();

		// Token: 0x040200A9 RID: 131241
		private int EffectHandleId;
	}
}
