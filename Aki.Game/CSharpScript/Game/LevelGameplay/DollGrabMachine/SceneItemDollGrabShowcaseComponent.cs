using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x0200604F RID: 24655
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemDollGrabShowcaseComponent : EntityComponent
	{
		// Token: 0x17007022 RID: 28706
		// (get) Token: 0x0603B354 RID: 242516 RVA: 0x010BFFBB File Offset: 0x010BE1BB
		public string BelongType
		{
			get
			{
				return this.Config.BelongType.ToEnumString();
			}
		}

		// Token: 0x17007023 RID: 28707
		// (get) Token: 0x0603B355 RID: 242517 RVA: 0x010BFFCD File Offset: 0x010BE1CD
		public int PdDataId
		{
			get
			{
				return this.CreatureDataComp.GetPbDataId();
			}
		}

		// Token: 0x17007024 RID: 28708
		// (get) Token: 0x0603B356 RID: 242518 RVA: 0x010BFFDA File Offset: 0x010BE1DA
		[Nullable(2)]
		public IShowcaseFullViewCameraConfig AllViewCameraInfo
		{
			[NullableContext(2)]
			get
			{
				IDollGrabShowcaseDollCameraConfig cameraConfig = this.Config.CameraConfig;
				if (cameraConfig == null)
				{
					return null;
				}
				return cameraConfig.FullViewCamera;
			}
		}

		// Token: 0x17007025 RID: 28709
		// (get) Token: 0x0603B357 RID: 242519 RVA: 0x010BFFF2 File Offset: 0x010BE1F2
		public bool IsActive
		{
			get
			{
				return this.IsActiveInternal;
			}
		}

		// Token: 0x17007026 RID: 28710
		// (get) Token: 0x0603B358 RID: 242520 RVA: 0x010BFFFA File Offset: 0x010BE1FA
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IShowcaseDeliveryReward> DeliveryRewards
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this.Config.DeliveryRewards;
			}
		}

		// Token: 0x17007027 RID: 28711
		// (get) Token: 0x0603B359 RID: 242521 RVA: 0x010C0007 File Offset: 0x010BE207
		public int? BindInfiniteModeDollGrabEntityId
		{
			get
			{
				return this.Config.BindInfiniteModeDollGrabEntityId;
			}
		}

		// Token: 0x0603B35A RID: 242522 RVA: 0x010C0014 File Offset: 0x010BE214
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.IsInitializingInternal = true;
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			DollGrabShowcaseComponent dollGrabShowcaseComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemDollGrabShowcaseComponent>() as DollGrabShowcaseComponent;
			if (dollGrabShowcaseComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DollGrabMachine;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[DollGrabShowcase] 组件配置缺失";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.Config = dollGrabShowcaseComponent;
			IReadOnlyList<DollGrabItemComboCsv> configList = ConfigDollGrabItemComboCsvAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabShowcase] 娃娃信息配置缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			using (IEnumerator<DollGrabItemComboCsv> enumerator = configList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DollGrabItemComboCsv comboConfig = enumerator.Current;
					if (comboConfig.MainItemId != 0)
					{
						int mainItemId = comboConfig.MainItemId;
						DollGrabItemsCsv? config = ConfigDollGrabItemsCsvById.GetConfig(mainItemId, true);
						if (config == null)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.DollGrabMachine;
							ELogAuthor author2 = ELogAuthor.FJH;
							string message2 = "[DollItemInfo] 娃娃信息配置缺失";
							ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ItemId", mainItemId);
							instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						}
						else if (!(config.Value.ShowcaseBelongType != this.BelongType))
						{
							DollItemInfo dollItemInfo = new DollItemInfo
							{
								MainItemId = mainItemId,
								DollIdleAnimPath = config.Value.DollShowcaseIdleMontage
							};
							dollItemInfo.BindingItemIdSet.Add(config.Value.BindingItemId);
							int count = this.DollItemInfoList.Count;
							this.DollItemInfoIndexMap[mainItemId] = count;
							this.DollItemInfoElementIndexMap[comboConfig.Id] = count;
							IDollGrabShowcaseDollCameraConfig cameraConfig = this.Config.CameraConfig;
							IDollComboCameraConfig dollComboCameraConfig = (cameraConfig != null) ? cameraConfig.DollCamera.ComboCameras.Find((IDollComboCameraConfig camera) => camera.ComboId == comboConfig.Id) : null;
							if (dollComboCameraConfig != null)
							{
								DollItemInfo dollItemInfo2 = dollItemInfo;
								DollViewCameraInfo dollViewCameraInfo = new DollViewCameraInfo();
								dollViewCameraInfo.Location = global::Vector.Create((double)dollComboCameraConfig.PosAndRot.X.GetValueOrDefault(), (double)dollComboCameraConfig.PosAndRot.Y.GetValueOrDefault(), (double)dollComboCameraConfig.PosAndRot.Z.GetValueOrDefault());
								dollViewCameraInfo.Rotation = global::Rotator.Create(dollComboCameraConfig.PosAndRot.Pitch.GetValueOrDefault(), dollComboCameraConfig.PosAndRot.A.GetValueOrDefault(), dollComboCameraConfig.PosAndRot.Roll.GetValueOrDefault());
								IDollGrabShowcaseDollCameraConfig cameraConfig2 = this.Config.CameraConfig;
								dollViewCameraInfo.Fov = ((cameraConfig2 != null) ? cameraConfig2.DollCamera.Fov : 0f);
								dollItemInfo2.ViewCameraInfo = dollViewCameraInfo;
							}
							foreach (int num in comboConfig.PartItemIdsIter())
							{
								DollGrabItemsCsv? config2 = ConfigDollGrabItemsCsvById.GetConfig(num, true);
								if (config2 != null)
								{
									dollItemInfo.BindingItemIdSet.Add(config2.Value.BindingItemId);
								}
								dollItemInfo.PartDollIdList.Add(num);
								this.DollItemInfoIndexMap[num] = count;
							}
							this.DollItemInfoList.Add(dollItemInfo);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0603B35B RID: 242523 RVA: 0x010C03D0 File Offset: 0x010BE5D0
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DollGrabMachine;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[DollGrabShowcase] 组件缺失";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return true;
		}

		// Token: 0x0603B35C RID: 242524 RVA: 0x010C0448 File Offset: 0x010BE648
		protected override void OnActivate()
		{
			if (!this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionShowCompleted));
			}
			else
			{
				this.OnSceneInteractionShowCompleted();
			}
			DollGrabShowcaseController.Instance.RegisterShowcase(this);
		}

		// Token: 0x0603B35D RID: 242525 RVA: 0x010C0497 File Offset: 0x010BE697
		protected override void OnEnable()
		{
			if (!this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionShowCompleted));
				return;
			}
			this.OnSceneInteractionShowCompleted();
		}

		// Token: 0x0603B35E RID: 242526 RVA: 0x010C04CF File Offset: 0x010BE6CF
		protected override void OnDisable(string reason)
		{
			this.DeleteDollShowCaseData();
		}

		// Token: 0x0603B35F RID: 242527 RVA: 0x010C04D7 File Offset: 0x010BE6D7
		protected override bool OnEnd()
		{
			DollGrabShowcaseController.Instance.UnregisterShowcase(this);
			return true;
		}

		// Token: 0x0603B360 RID: 242528 RVA: 0x010C04E8 File Offset: 0x010BE6E8
		private void InitDollShowcaseActorsData(AActor actor)
		{
			this.DeleteDollShowCaseData();
			this.ElementContainerActor = actor;
			TArray<AActor> tarray = new TArray<AActor>();
			this.ElementContainerActor.GetAttachedActors(ref tarray, true);
			for (int i = 0; i < tarray.Num(); i++)
			{
				BP_DollShowCaseActor_C bp_DollShowCaseActor_C = tarray.Get(i) as BP_DollShowCaseActor_C;
				int index;
				if (bp_DollShowCaseActor_C != null && this.DollItemInfoElementIndexMap.TryGetValue(bp_DollShowCaseActor_C.DollElementId, out index))
				{
					DollItemInfo valueOrDefault = this.DollItemInfoList.GetValueOrDefault(index);
					if (valueOrDefault == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.DollGrabMachine;
						ELogAuthor author = ELogAuthor.FJH;
						string message = "[DollGrabShowcase] 展示柜中存在没有配置的娃娃";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ElementId", bp_DollShowCaseActor_C.DollElementId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else
					{
						valueOrDefault.DollShowCaseActor = bp_DollShowCaseActor_C;
						valueOrDefault.DollShowCaseActor.SetActorHiddenInGame(true);
					}
				}
			}
		}

		// Token: 0x0603B361 RID: 242529 RVA: 0x010C05B0 File Offset: 0x010BE7B0
		private UniTask InitDollShowcaseChildSkeletalMesh(USkeletalMeshComponent skeletalMeshComp, DollItemInfo dollItemInfo, int itemId, int dollPartCount)
		{
			SceneItemDollGrabShowcaseComponent.<InitDollShowcaseChildSkeletalMesh>d__31 <InitDollShowcaseChildSkeletalMesh>d__;
			<InitDollShowcaseChildSkeletalMesh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDollShowcaseChildSkeletalMesh>d__.skeletalMeshComp = skeletalMeshComp;
			<InitDollShowcaseChildSkeletalMesh>d__.dollItemInfo = dollItemInfo;
			<InitDollShowcaseChildSkeletalMesh>d__.itemId = itemId;
			<InitDollShowcaseChildSkeletalMesh>d__.dollPartCount = dollPartCount;
			<InitDollShowcaseChildSkeletalMesh>d__.<>1__state = -1;
			<InitDollShowcaseChildSkeletalMesh>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<InitDollShowcaseChildSkeletalMesh>d__31>(ref <InitDollShowcaseChildSkeletalMesh>d__);
			return <InitDollShowcaseChildSkeletalMesh>d__.<>t__builder.Task;
		}

		// Token: 0x0603B362 RID: 242530 RVA: 0x010C060C File Offset: 0x010BE80C
		private UniTask InitDollShowcaseActorSkeletalMesh(DollItemInfo dollItemInfo)
		{
			SceneItemDollGrabShowcaseComponent.<InitDollShowcaseActorSkeletalMesh>d__32 <InitDollShowcaseActorSkeletalMesh>d__;
			<InitDollShowcaseActorSkeletalMesh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDollShowcaseActorSkeletalMesh>d__.<>4__this = this;
			<InitDollShowcaseActorSkeletalMesh>d__.dollItemInfo = dollItemInfo;
			<InitDollShowcaseActorSkeletalMesh>d__.<>1__state = -1;
			<InitDollShowcaseActorSkeletalMesh>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<InitDollShowcaseActorSkeletalMesh>d__32>(ref <InitDollShowcaseActorSkeletalMesh>d__);
			return <InitDollShowcaseActorSkeletalMesh>d__.<>t__builder.Task;
		}

		// Token: 0x0603B363 RID: 242531 RVA: 0x010C0658 File Offset: 0x010BE858
		private void CollectDollActorOriginalMaterialBySkeletalMesh(DollItemInfo dollItemInfo, int itemId, USkeletalMeshComponent skeletalMeshComp)
		{
			List<UMaterialInterface> list = new List<UMaterialInterface>();
			int numMaterials = skeletalMeshComp.GetNumMaterials();
			for (int i = 0; i < numMaterials; i++)
			{
				UMaterialInterface material = skeletalMeshComp.GetMaterial(i);
				if (material != null)
				{
					list.Add(material);
				}
			}
			dollItemInfo.OriginalMaterialMap[itemId] = list.ToArray();
		}

		// Token: 0x0603B364 RID: 242532 RVA: 0x010C06A4 File Offset: 0x010BE8A4
		private void CollectDollActorOriginalMaterial()
		{
			foreach (DollItemInfo dollItemInfo in this.DollItemInfoList)
			{
				BP_DollShowCaseActor_C dollShowCaseActor = dollItemInfo.DollShowCaseActor;
				USkeletalMeshComponent uskeletalMeshComponent;
				if (dollShowCaseActor != null && dollShowCaseActor.SkeletalMeshMap.TryGetValue(dollItemInfo.MainItemId, out uskeletalMeshComponent) && uskeletalMeshComponent != null)
				{
					this.CollectDollActorOriginalMaterialBySkeletalMesh(dollItemInfo, dollItemInfo.MainItemId, uskeletalMeshComponent);
				}
				foreach (int num in dollItemInfo.PartDollIdList)
				{
					BP_DollShowCaseActor_C dollShowCaseActor2 = dollItemInfo.DollShowCaseActor;
					USkeletalMeshComponent uskeletalMeshComponent2;
					if (dollShowCaseActor2 != null && dollShowCaseActor2.SkeletalMeshMap.TryGetValue(num, out uskeletalMeshComponent2) && uskeletalMeshComponent2 != null)
					{
						this.CollectDollActorOriginalMaterialBySkeletalMesh(dollItemInfo, num, uskeletalMeshComponent2);
					}
				}
			}
		}

		// Token: 0x0603B365 RID: 242533 RVA: 0x010C0790 File Offset: 0x010BE990
		public UniTask InitAllDollShowcaseActors()
		{
			SceneItemDollGrabShowcaseComponent.<InitAllDollShowcaseActors>d__35 <InitAllDollShowcaseActors>d__;
			<InitAllDollShowcaseActors>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAllDollShowcaseActors>d__.<>4__this = this;
			<InitAllDollShowcaseActors>d__.<>1__state = -1;
			<InitAllDollShowcaseActors>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<InitAllDollShowcaseActors>d__35>(ref <InitAllDollShowcaseActors>d__);
			return <InitAllDollShowcaseActors>d__.<>t__builder.Task;
		}

		// Token: 0x0603B366 RID: 242534 RVA: 0x010C07D4 File Offset: 0x010BE9D4
		private void ClearAllDollShowCaseActors()
		{
			foreach (DollItemInfo dollItemInfo in this.DollItemInfoList)
			{
				foreach (int key in dollItemInfo.PartDollIdList)
				{
					BP_DollShowCaseActor_C dollShowCaseActor = dollItemInfo.DollShowCaseActor;
					USkeletalMeshComponent uskeletalMeshComponent;
					if (dollShowCaseActor != null && dollShowCaseActor.SkeletalMeshMap.TryGetValue(key, out uskeletalMeshComponent) && uskeletalMeshComponent != null)
					{
						uskeletalMeshComponent.K2_DestroyComponent(dollItemInfo.DollShowCaseActor);
						dollItemInfo.DollShowCaseActor.SkeletalMeshMap.Remove(key);
					}
				}
				BP_DollShowCaseActor_C dollShowCaseActor2 = dollItemInfo.DollShowCaseActor;
				USkeletalMeshComponent uskeletalMeshComponent2 = (dollShowCaseActor2 != null) ? dollShowCaseActor2.SkeletalMesh : null;
				if (uskeletalMeshComponent2 != null)
				{
					UMaterialInterface[] array;
					if (dollItemInfo.OriginalMaterialMap.TryGetValue(dollItemInfo.MainItemId, out array))
					{
						for (int i = 0; i < array.Length; i++)
						{
							uskeletalMeshComponent2.SetMaterial(i, array[i]);
						}
					}
					uskeletalMeshComponent2.SetAnimation(null);
					uskeletalMeshComponent2.SetSkeletalMesh(null, true);
					dollItemInfo.DollShowCaseActor.SkeletalMeshMap.Remove(dollItemInfo.MainItemId);
				}
				BP_DollShowCaseActor_C dollShowCaseActor3 = dollItemInfo.DollShowCaseActor;
				if (dollShowCaseActor3 != null)
				{
					dollShowCaseActor3.SetActorHiddenInGame(true);
				}
				dollItemInfo.OriginalMaterialMap.Clear();
			}
		}

		// Token: 0x0603B367 RID: 242535 RVA: 0x010C094C File Offset: 0x010BEB4C
		private void HandleDollActorMaterialByDelivery(DollItemInfo dollItemInfo, DollDeliveryInfo deliveryInfo)
		{
			BP_DollShowCaseActor_C dollShowCaseActor = dollItemInfo.DollShowCaseActor;
			float num = ((dollShowCaseActor != null) ? dollShowCaseActor.CompleteEffectDurationTime : 0f) * (float)TimeUtil.Instance.InverseMillisecond;
			this.SetDollActorMaterial(dollItemInfo, deliveryInfo.ItemId, false).Forget();
			BP_DollShowCaseActor_C dollShowCaseActor2 = dollItemInfo.DollShowCaseActor;
			if (dollShowCaseActor2 != null)
			{
				dollShowCaseActor2.SwitchLightState(deliveryInfo.LightIndex, deliveryInfo.IsComplete);
			}
			if (deliveryInfo.IsLast)
			{
				if (num > 0f)
				{
					TimerSystem.Instance.Delay(delegate(float _)
					{
						Action deliveryCompleteCallback2 = this.DeliveryCompleteCallback;
						if (deliveryCompleteCallback2 != null)
						{
							deliveryCompleteCallback2();
						}
						this.DeliveryCompleteCallback = null;
					}, num, null, null, true, 1f);
					return;
				}
				Action deliveryCompleteCallback = this.DeliveryCompleteCallback;
				if (deliveryCompleteCallback != null)
				{
					deliveryCompleteCallback();
				}
				this.DeliveryCompleteCallback = null;
			}
		}

		// Token: 0x0603B368 RID: 242536 RVA: 0x010C09F5 File Offset: 0x010BEBF5
		public void SetDeliveryCompleteCallback(Action callback)
		{
			this.DeliveryCompleteCallback = callback;
		}

		// Token: 0x0603B369 RID: 242537 RVA: 0x010C0A00 File Offset: 0x010BEC00
		private void DelayHandleDollActorMaterialByDelivery(DollItemInfo dollItemInfo, DollDeliveryInfo deliveryInfo, float intervalTime)
		{
			float num = intervalTime * (float)TimeUtil.Instance.InverseMillisecond;
			if (num <= 0f)
			{
				this.HandleDollActorMaterialByDelivery(dollItemInfo, deliveryInfo);
				return;
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.HandleDollActorMaterialByDelivery(dollItemInfo, deliveryInfo);
			}, num, null, null, true, 1f);
		}

		// Token: 0x0603B36A RID: 242538 RVA: 0x010C0A74 File Offset: 0x010BEC74
		private void HandleDollActorShowByDelivery(IReadOnlyList<DollDeliveryInfo> deliveryInfoList)
		{
			if (deliveryInfoList.Count == 0)
			{
				Action deliveryCompleteCallback = this.DeliveryCompleteCallback;
				if (deliveryCompleteCallback != null)
				{
					deliveryCompleteCallback();
				}
				this.DeliveryCompleteCallback = null;
				return;
			}
			float num = 0f;
			foreach (DollDeliveryInfo dollDeliveryInfo in deliveryInfoList)
			{
				int index;
				if (this.DollItemInfoIndexMap.TryGetValue(dollDeliveryInfo.ItemId, out index))
				{
					DollItemInfo dollItemInfo = this.DollItemInfoList[index];
					if (((dollItemInfo != null) ? dollItemInfo.DollShowCaseActor : null) != null)
					{
						num += dollItemInfo.DollShowCaseActor.PlayEffectIntervalTime;
						this.DelayHandleDollActorMaterialByDelivery(dollItemInfo, dollDeliveryInfo, num);
					}
				}
			}
		}

		// Token: 0x0603B36B RID: 242539 RVA: 0x010C0B28 File Offset: 0x010BED28
		private void DeleteDollShowCaseData()
		{
			foreach (DollItemInfo dollItemInfo in this.DollItemInfoList)
			{
				dollItemInfo.DollShowCaseActor = null;
			}
		}

		// Token: 0x0603B36C RID: 242540 RVA: 0x010C0B7C File Offset: 0x010BED7C
		private void OnSceneInteractionShowCompleted()
		{
			AActor referenceActor = this.ActorComp.GetReferenceActor("ElementContainer");
			if (referenceActor != null)
			{
				this.InitDollShowcaseActorsData(referenceActor);
			}
			DollGrabShowcaseComponentPb dollGrabShowcaseInfo = this.CreatureDataComp.DollGrabShowcaseInfo;
			if (((dollGrabShowcaseInfo != null) ? dollGrabShowcaseInfo.DollItems : null) != null)
			{
				this.OnNotifyDollDeliveryInfos(this.CreatureDataComp.DollGrabShowcaseInfo.DollItems, false);
			}
			this.IsInitializingInternal = false;
		}

		// Token: 0x0603B36D RID: 242541 RVA: 0x010C0BDC File Offset: 0x010BEDDC
		public void OnNotifyDollDeliveryInfos(IReadOnlyList<int> itemIds, bool needEffect)
		{
			bool flag = false;
			bool hasFirstCompleteDollInternal = this.HasFirstCompleteDollInternal;
			foreach (int num in itemIds)
			{
				int index;
				if (this.DollItemInfoIndexMap.TryGetValue(num, out index) && !this.DeliveryInfo.Contains(num))
				{
					DollItemInfo dollItemInfo = this.DollItemInfoList[index];
					if (dollItemInfo != null)
					{
						dollItemInfo.ShowedItemIds.Add(num);
						flag = (flag || dollItemInfo.IsCollectComplete());
						if (flag && !this.HasFirstCompleteDollInternal)
						{
							this.HasFirstCompleteDollInternal = true;
						}
					}
					if (this.IsActiveInternal || this.IsInitializingInternal)
					{
						this.HandleDeliveryInfo(num, needEffect);
					}
					else
					{
						this.DeliveryInfo.Add(num);
					}
				}
			}
			EventSystem.Instance.Emit<bool, bool>(EEventName.OnDollGrabMachineDelivery, hasFirstCompleteDollInternal, flag);
		}

		// Token: 0x0603B36E RID: 242542 RVA: 0x010C0CC4 File Offset: 0x010BEEC4
		public void HandleDeliveryInfo(int itemId, bool needEffect)
		{
			int index;
			if (!this.DollItemInfoIndexMap.TryGetValue(itemId, out index))
			{
				return;
			}
			DollItemInfo dollItemInfo = this.DollItemInfoList[index];
			if (dollItemInfo == null)
			{
				return;
			}
			dollItemInfo.ShowedItemIds.Add(itemId);
		}

		// Token: 0x0603B36F RID: 242543 RVA: 0x010C0D00 File Offset: 0x010BEF00
		private void HandleShowCaseGridLight()
		{
			foreach (DollItemInfo dollItemInfo in this.DollItemInfoList)
			{
				bool isComplete = dollItemInfo.IsCollectComplete();
				BP_DollShowCaseActor_C dollShowCaseActor = dollItemInfo.DollShowCaseActor;
				if (dollShowCaseActor != null)
				{
					dollShowCaseActor.SwitchLightState(dollItemInfo.ShowedItemIds.Count, isComplete);
				}
			}
		}

		// Token: 0x0603B370 RID: 242544 RVA: 0x010C0D70 File Offset: 0x010BEF70
		private UniTask SetDollActorMaterial(DollItemInfo dollItemInfo, int itemId, bool isFromInit)
		{
			SceneItemDollGrabShowcaseComponent.<SetDollActorMaterial>d__46 <SetDollActorMaterial>d__;
			<SetDollActorMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetDollActorMaterial>d__.<>4__this = this;
			<SetDollActorMaterial>d__.dollItemInfo = dollItemInfo;
			<SetDollActorMaterial>d__.itemId = itemId;
			<SetDollActorMaterial>d__.isFromInit = isFromInit;
			<SetDollActorMaterial>d__.<>1__state = -1;
			<SetDollActorMaterial>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<SetDollActorMaterial>d__46>(ref <SetDollActorMaterial>d__);
			return <SetDollActorMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0603B371 RID: 242545 RVA: 0x010C0DCC File Offset: 0x010BEFCC
		private void PlayDeliveryEffect(DollItemInfo dollItemInfo, int itemId, USkeletalMeshComponent skeletalMeshComponent, Action<int> beforePlayCallback)
		{
			global::Transform transform = global::Transform.Create();
			transform.SetLocation(skeletalMeshComponent.D_K2_GetComponentLocation());
			int indexByItemId = dollItemInfo.GetIndexByItemId(itemId);
			if (indexByItemId >= 0)
			{
				BP_DollShowCaseActor_C dollShowCaseActor = dollItemInfo.DollShowCaseActor;
				if (dollShowCaseActor != null && dollShowCaseActor.EffectOffsetLocationList.IsValidIndex(indexByItemId))
				{
					global::Vector inB = global::Vector.Create(dollItemInfo.DollShowCaseActor.EffectOffsetLocationList.Get(indexByItemId));
					transform.GetLocation().AdditionEqual(inB);
				}
			}
			string effectPath = EffectUtil.GetEffectPath("DA_Fx_Group_Sl2_MZ_WaWa_ChuXian");
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(transform.ToUeTransform());
			instance.SpawnUnloopedEffect(world, ftransformDouble, effectPath, "[SceneItemDollGrabShowcaseComponent.PlayDeliveryEffect]", null, EEffectType.Scene, null, null, beforePlayCallback, false, false);
		}

		// Token: 0x0603B372 RID: 242546 RVA: 0x010C0E78 File Offset: 0x010BF078
		private UniTask InitDollActorMaterial()
		{
			SceneItemDollGrabShowcaseComponent.<InitDollActorMaterial>d__48 <InitDollActorMaterial>d__;
			<InitDollActorMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDollActorMaterial>d__.<>4__this = this;
			<InitDollActorMaterial>d__.<>1__state = -1;
			<InitDollActorMaterial>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<InitDollActorMaterial>d__48>(ref <InitDollActorMaterial>d__);
			return <InitDollActorMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0603B373 RID: 242547 RVA: 0x010C0EBC File Offset: 0x010BF0BC
		private UniTask InitDollActorIdleAnimation()
		{
			SceneItemDollGrabShowcaseComponent.<InitDollActorIdleAnimation>d__49 <InitDollActorIdleAnimation>d__;
			<InitDollActorIdleAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDollActorIdleAnimation>d__.<>4__this = this;
			<InitDollActorIdleAnimation>d__.<>1__state = -1;
			<InitDollActorIdleAnimation>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<InitDollActorIdleAnimation>d__49>(ref <InitDollActorIdleAnimation>d__);
			return <InitDollActorIdleAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x0603B374 RID: 242548 RVA: 0x010C0F00 File Offset: 0x010BF100
		private UniTask SetDollActorIdleAnimation(DollItemInfo dollItemInfo)
		{
			SceneItemDollGrabShowcaseComponent.<SetDollActorIdleAnimation>d__50 <SetDollActorIdleAnimation>d__;
			<SetDollActorIdleAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetDollActorIdleAnimation>d__.dollItemInfo = dollItemInfo;
			<SetDollActorIdleAnimation>d__.<>1__state = -1;
			<SetDollActorIdleAnimation>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<SetDollActorIdleAnimation>d__50>(ref <SetDollActorIdleAnimation>d__);
			return <SetDollActorIdleAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x0603B375 RID: 242549 RVA: 0x010C0F44 File Offset: 0x010BF144
		public void OnStartShowcaseGameplay()
		{
			if (this.IsActiveInternal)
			{
				return;
			}
			this.IsActiveInternal = true;
			List<DollDeliveryInfo> list = new List<DollDeliveryInfo>();
			if (this.DeliveryInfo.Count > 0)
			{
				for (int i = 0; i < this.DeliveryInfo.Count; i++)
				{
					int num = this.DeliveryInfo[i];
					this.HandleDeliveryInfo(num, false);
					int index;
					if (this.DollItemInfoIndexMap.TryGetValue(num, out index))
					{
						DollItemInfo dollItemInfo = this.DollItemInfoList[index];
						if (dollItemInfo != null)
						{
							list.Add(new DollDeliveryInfo(num, dollItemInfo.ShowedItemIds.Count, dollItemInfo.IsCollectComplete(), i == this.DeliveryInfo.Count - 1));
						}
					}
				}
				this.DeliveryInfo.Clear();
			}
			this.HandleDollActorShowByDelivery(list);
		}

		// Token: 0x0603B376 RID: 242550 RVA: 0x010C1006 File Offset: 0x010BF206
		public void OnEndShowcaseGameplay()
		{
			this.IsActiveInternal = false;
			this.ClearAllDollShowCaseActors();
		}

		// Token: 0x0603B377 RID: 242551 RVA: 0x010C1018 File Offset: 0x010BF218
		public void OpenDollViewCamera(int itemId)
		{
			int index;
			if (!this.DollItemInfoIndexMap.TryGetValue(itemId, out index))
			{
				return;
			}
			DollItemInfo dollItemInfo = this.DollItemInfoList[index];
			if (dollItemInfo.ViewCameraInfo == null)
			{
				return;
			}
			DollGrabCameraConfig cameraInfo = new DollGrabCameraConfig(dollItemInfo.ViewCameraInfo.Location, dollItemInfo.ViewCameraInfo.Rotation, 0.5f, 0.5f, true, true, dollItemInfo.ViewCameraInfo.Fov);
			DollGrabModel.Instance.ExecuteAdjustPlayerCamera(this.ActorComp, cameraInfo, "DollGrabMachineFixCamera", null);
		}

		// Token: 0x0603B378 RID: 242552 RVA: 0x010C1096 File Offset: 0x010BF296
		public void CloseDollViewCamera()
		{
			DollGrabShowcaseController.Instance.OpenAllViewCamera(null);
		}

		// Token: 0x0603B379 RID: 242553 RVA: 0x010C10A3 File Offset: 0x010BF2A3
		public List<DollItemInfo> GetDollItemInfoList()
		{
			return this.DollItemInfoList;
		}

		// Token: 0x0603B37A RID: 242554 RVA: 0x010C10AC File Offset: 0x010BF2AC
		[NullableContext(2)]
		public IDollCollectData GetCollectData()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (DollItemInfo dollItemInfo in this.DollItemInfoList)
			{
				if (dollItemInfo.IsCollectComplete())
				{
					num++;
				}
				num2 += dollItemInfo.GetTotalItemCount();
				num3 += dollItemInfo.GetShowedItemCount();
			}
			return new DollCollectData
			{
				CurrentCollectCount = num,
				TotalCollectCount = this.DollItemInfoList.Count,
				CurrentCollectItemCount = num3,
				TotalCollectItemCount = num2
			};
		}

		// Token: 0x0603B37B RID: 242555 RVA: 0x010C114C File Offset: 0x010BF34C
		public List<int> GetAllBindingItemIds()
		{
			List<int> list = new List<int>();
			foreach (DollItemInfo dollItemInfo in this.DollItemInfoList)
			{
				foreach (int item in dollItemInfo.BindingItemIdSet)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0603B37C RID: 242556 RVA: 0x010C11E0 File Offset: 0x010BF3E0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemDollGrabShowcaseComponent sceneItemDollGrabShowcaseComponent = (SceneItemDollGrabShowcaseComponent)componentTemplate;
			if (sceneItemDollGrabShowcaseComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemDollGrabShowcaseComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemDollGrabShowcaseComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemDollGrabShowcaseComponent.ElementContainerActor == null)
			{
				this.ElementContainerActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ElementContainerActor), "ElementContainerActor"))
			{
				return false;
			}
			if (sceneItemDollGrabShowcaseComponent.DollItemInfoList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DollItemInfoList), "DollItemInfoList"))
			{
				return false;
			}
			if (sceneItemDollGrabShowcaseComponent.DollItemInfoIndexMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DollItemInfoIndexMap), "DollItemInfoIndexMap"))
			{
				return false;
			}
			if (sceneItemDollGrabShowcaseComponent.DollItemInfoElementIndexMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DollItemInfoElementIndexMap), "DollItemInfoElementIndexMap"))
			{
				return false;
			}
			if (sceneItemDollGrabShowcaseComponent.DeliveryInfo != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DeliveryInfo), "DeliveryInfo"))
			{
				return false;
			}
			this.HasFirstCompleteDollInternal = sceneItemDollGrabShowcaseComponent.HasFirstCompleteDollInternal;
			this.IsActiveInternal = sceneItemDollGrabShowcaseComponent.IsActiveInternal;
			this.IsInitializingInternal = sceneItemDollGrabShowcaseComponent.IsInitializingInternal;
			if (sceneItemDollGrabShowcaseComponent.DeliveryCompleteCallback == null)
			{
				this.DeliveryCompleteCallback = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DeliveryCompleteCallback), "DeliveryCompleteCallback"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007028 RID: 28712
		// (get) Token: 0x0603B37D RID: 242557 RVA: 0x010C1383 File Offset: 0x010BF583
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007029 RID: 28713
		// (get) Token: 0x0603B37E RID: 242558 RVA: 0x010C1386 File Offset: 0x010BF586
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700702A RID: 28714
		// (get) Token: 0x0603B37F RID: 242559 RVA: 0x010C1389 File Offset: 0x010BF589
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700702B RID: 28715
		// (get) Token: 0x0603B380 RID: 242560 RVA: 0x010C138C File Offset: 0x010BF58C
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700702C RID: 28716
		// (get) Token: 0x0603B381 RID: 242561 RVA: 0x010C138F File Offset: 0x010BF58F
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401F276 RID: 127606
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401F277 RID: 127607
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;

		// Token: 0x0401F278 RID: 127608
		[Nullable(2)]
		private DollGrabShowcaseComponent Config;

		// Token: 0x0401F279 RID: 127609
		[Nullable(2)]
		private AActor ElementContainerActor;

		// Token: 0x0401F27A RID: 127610
		private readonly List<DollItemInfo> DollItemInfoList = new List<DollItemInfo>();

		// Token: 0x0401F27B RID: 127611
		private readonly Dictionary<int, int> DollItemInfoIndexMap = new Dictionary<int, int>();

		// Token: 0x0401F27C RID: 127612
		private readonly Dictionary<int, int> DollItemInfoElementIndexMap = new Dictionary<int, int>();

		// Token: 0x0401F27D RID: 127613
		private readonly List<int> DeliveryInfo = new List<int>();

		// Token: 0x0401F27E RID: 127614
		private bool HasFirstCompleteDollInternal;

		// Token: 0x0401F27F RID: 127615
		private bool IsActiveInternal;

		// Token: 0x0401F280 RID: 127616
		private bool IsInitializingInternal;

		// Token: 0x0401F281 RID: 127617
		[Nullable(2)]
		private Action DeliveryCompleteCallback;
	}
}
