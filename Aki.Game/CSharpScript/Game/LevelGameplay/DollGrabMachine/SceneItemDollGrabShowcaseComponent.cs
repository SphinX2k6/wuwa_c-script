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
	// Token: 0x02006ECF RID: 28367
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemDollGrabShowcaseComponent : EntityComponent
	{
		// Token: 0x17009AE8 RID: 39656
		// (get) Token: 0x060451B0 RID: 283056 RVA: 0x0111619B File Offset: 0x0111439B
		public string BelongType
		{
			get
			{
				return this.Config.BelongType.ToEnumString();
			}
		}

		// Token: 0x17009AE9 RID: 39657
		// (get) Token: 0x060451B1 RID: 283057 RVA: 0x011161AD File Offset: 0x011143AD
		public int PdDataId
		{
			get
			{
				return this.CreatureDataComp.GetPbDataId();
			}
		}

		// Token: 0x17009AEA RID: 39658
		// (get) Token: 0x060451B2 RID: 283058 RVA: 0x011161BA File Offset: 0x011143BA
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

		// Token: 0x17009AEB RID: 39659
		// (get) Token: 0x060451B3 RID: 283059 RVA: 0x011161D2 File Offset: 0x011143D2
		public bool IsActive
		{
			get
			{
				return this.IsActiveInternal;
			}
		}

		// Token: 0x17009AEC RID: 39660
		// (get) Token: 0x060451B4 RID: 283060 RVA: 0x011161DA File Offset: 0x011143DA
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

		// Token: 0x17009AED RID: 39661
		// (get) Token: 0x060451B5 RID: 283061 RVA: 0x011161E7 File Offset: 0x011143E7
		public int? BindInfiniteModeDollGrabEntityId
		{
			get
			{
				return this.Config.BindInfiniteModeDollGrabEntityId;
			}
		}

		// Token: 0x060451B6 RID: 283062 RVA: 0x011161F4 File Offset: 0x011143F4
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

		// Token: 0x060451B7 RID: 283063 RVA: 0x011165B0 File Offset: 0x011147B0
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

		// Token: 0x060451B8 RID: 283064 RVA: 0x01116628 File Offset: 0x01114828
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

		// Token: 0x060451B9 RID: 283065 RVA: 0x01116677 File Offset: 0x01114877
		protected override void OnEnable()
		{
			if (!this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionShowCompleted));
				return;
			}
			this.OnSceneInteractionShowCompleted();
		}

		// Token: 0x060451BA RID: 283066 RVA: 0x011166AF File Offset: 0x011148AF
		protected override void OnDisable(string reason)
		{
			this.DeleteDollShowCaseData();
		}

		// Token: 0x060451BB RID: 283067 RVA: 0x011166B7 File Offset: 0x011148B7
		protected override bool OnEnd()
		{
			DollGrabShowcaseController.Instance.UnregisterShowcase(this);
			return true;
		}

		// Token: 0x060451BC RID: 283068 RVA: 0x011166C8 File Offset: 0x011148C8
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

		// Token: 0x060451BD RID: 283069 RVA: 0x01116790 File Offset: 0x01114990
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

		// Token: 0x060451BE RID: 283070 RVA: 0x011167EC File Offset: 0x011149EC
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

		// Token: 0x060451BF RID: 283071 RVA: 0x01116838 File Offset: 0x01114A38
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

		// Token: 0x060451C0 RID: 283072 RVA: 0x01116884 File Offset: 0x01114A84
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

		// Token: 0x060451C1 RID: 283073 RVA: 0x01116970 File Offset: 0x01114B70
		public UniTask InitAllDollShowcaseActors()
		{
			SceneItemDollGrabShowcaseComponent.<InitAllDollShowcaseActors>d__35 <InitAllDollShowcaseActors>d__;
			<InitAllDollShowcaseActors>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAllDollShowcaseActors>d__.<>4__this = this;
			<InitAllDollShowcaseActors>d__.<>1__state = -1;
			<InitAllDollShowcaseActors>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<InitAllDollShowcaseActors>d__35>(ref <InitAllDollShowcaseActors>d__);
			return <InitAllDollShowcaseActors>d__.<>t__builder.Task;
		}

		// Token: 0x060451C2 RID: 283074 RVA: 0x011169B4 File Offset: 0x01114BB4
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

		// Token: 0x060451C3 RID: 283075 RVA: 0x01116B2C File Offset: 0x01114D2C
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

		// Token: 0x060451C4 RID: 283076 RVA: 0x01116BD5 File Offset: 0x01114DD5
		public void SetDeliveryCompleteCallback(Action callback)
		{
			this.DeliveryCompleteCallback = callback;
		}

		// Token: 0x060451C5 RID: 283077 RVA: 0x01116BE0 File Offset: 0x01114DE0
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

		// Token: 0x060451C6 RID: 283078 RVA: 0x01116C54 File Offset: 0x01114E54
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

		// Token: 0x060451C7 RID: 283079 RVA: 0x01116D08 File Offset: 0x01114F08
		private void DeleteDollShowCaseData()
		{
			foreach (DollItemInfo dollItemInfo in this.DollItemInfoList)
			{
				dollItemInfo.DollShowCaseActor = null;
			}
		}

		// Token: 0x060451C8 RID: 283080 RVA: 0x01116D5C File Offset: 0x01114F5C
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

		// Token: 0x060451C9 RID: 283081 RVA: 0x01116DBC File Offset: 0x01114FBC
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

		// Token: 0x060451CA RID: 283082 RVA: 0x01116EA4 File Offset: 0x011150A4
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

		// Token: 0x060451CB RID: 283083 RVA: 0x01116EE0 File Offset: 0x011150E0
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

		// Token: 0x060451CC RID: 283084 RVA: 0x01116F50 File Offset: 0x01115150
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

		// Token: 0x060451CD RID: 283085 RVA: 0x01116FAC File Offset: 0x011151AC
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

		// Token: 0x060451CE RID: 283086 RVA: 0x01117058 File Offset: 0x01115258
		private UniTask InitDollActorMaterial()
		{
			SceneItemDollGrabShowcaseComponent.<InitDollActorMaterial>d__48 <InitDollActorMaterial>d__;
			<InitDollActorMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDollActorMaterial>d__.<>4__this = this;
			<InitDollActorMaterial>d__.<>1__state = -1;
			<InitDollActorMaterial>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<InitDollActorMaterial>d__48>(ref <InitDollActorMaterial>d__);
			return <InitDollActorMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x060451CF RID: 283087 RVA: 0x0111709C File Offset: 0x0111529C
		private UniTask InitDollActorIdleAnimation()
		{
			SceneItemDollGrabShowcaseComponent.<InitDollActorIdleAnimation>d__49 <InitDollActorIdleAnimation>d__;
			<InitDollActorIdleAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDollActorIdleAnimation>d__.<>4__this = this;
			<InitDollActorIdleAnimation>d__.<>1__state = -1;
			<InitDollActorIdleAnimation>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<InitDollActorIdleAnimation>d__49>(ref <InitDollActorIdleAnimation>d__);
			return <InitDollActorIdleAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x060451D0 RID: 283088 RVA: 0x011170E0 File Offset: 0x011152E0
		private UniTask SetDollActorIdleAnimation(DollItemInfo dollItemInfo)
		{
			SceneItemDollGrabShowcaseComponent.<SetDollActorIdleAnimation>d__50 <SetDollActorIdleAnimation>d__;
			<SetDollActorIdleAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetDollActorIdleAnimation>d__.dollItemInfo = dollItemInfo;
			<SetDollActorIdleAnimation>d__.<>1__state = -1;
			<SetDollActorIdleAnimation>d__.<>t__builder.Start<SceneItemDollGrabShowcaseComponent.<SetDollActorIdleAnimation>d__50>(ref <SetDollActorIdleAnimation>d__);
			return <SetDollActorIdleAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x060451D1 RID: 283089 RVA: 0x01117124 File Offset: 0x01115324
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

		// Token: 0x060451D2 RID: 283090 RVA: 0x011171E6 File Offset: 0x011153E6
		public void OnEndShowcaseGameplay()
		{
			this.IsActiveInternal = false;
			this.ClearAllDollShowCaseActors();
		}

		// Token: 0x060451D3 RID: 283091 RVA: 0x011171F8 File Offset: 0x011153F8
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

		// Token: 0x060451D4 RID: 283092 RVA: 0x01117276 File Offset: 0x01115476
		public void CloseDollViewCamera()
		{
			DollGrabShowcaseController.Instance.OpenAllViewCamera(null);
		}

		// Token: 0x060451D5 RID: 283093 RVA: 0x01117283 File Offset: 0x01115483
		public List<DollItemInfo> GetDollItemInfoList()
		{
			return this.DollItemInfoList;
		}

		// Token: 0x060451D6 RID: 283094 RVA: 0x0111728C File Offset: 0x0111548C
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

		// Token: 0x060451D7 RID: 283095 RVA: 0x0111732C File Offset: 0x0111552C
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

		// Token: 0x060451D8 RID: 283096 RVA: 0x011173C0 File Offset: 0x011155C0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemDollGrabShowcaseComponent sceneItemDollGrabShowcaseComponent = (SceneItemDollGrabShowcaseComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (sceneItemDollGrabShowcaseComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemDollGrabShowcaseComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemDollGrabShowcaseComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DollGrabShowcaseComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ElementContainerActor"))
			{
				if (sceneItemDollGrabShowcaseComponent.ElementContainerActor == null)
				{
					this.ElementContainerActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.ElementContainerActor), "ElementContainerActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DollItemInfoList") && sceneItemDollGrabShowcaseComponent.DollItemInfoList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<DollItemInfo>>(this.DollItemInfoList), "DollItemInfoList"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DollItemInfoIndexMap") && sceneItemDollGrabShowcaseComponent.DollItemInfoIndexMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.DollItemInfoIndexMap), "DollItemInfoIndexMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DollItemInfoElementIndexMap") && sceneItemDollGrabShowcaseComponent.DollItemInfoElementIndexMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.DollItemInfoElementIndexMap), "DollItemInfoElementIndexMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DeliveryInfo") && sceneItemDollGrabShowcaseComponent.DeliveryInfo != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<int>>(this.DeliveryInfo), "DeliveryInfo"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("HasFirstCompleteDollInternal"))
			{
				this.HasFirstCompleteDollInternal = sceneItemDollGrabShowcaseComponent.HasFirstCompleteDollInternal;
			}
			if (base.CanResetComponentProperty("IsActiveInternal"))
			{
				this.IsActiveInternal = sceneItemDollGrabShowcaseComponent.IsActiveInternal;
			}
			if (base.CanResetComponentProperty("IsInitializingInternal"))
			{
				this.IsInitializingInternal = sceneItemDollGrabShowcaseComponent.IsInitializingInternal;
			}
			if (base.CanResetComponentProperty("DeliveryCompleteCallback"))
			{
				if (sceneItemDollGrabShowcaseComponent.DeliveryCompleteCallback == null)
				{
					this.DeliveryCompleteCallback = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action>(this.DeliveryCompleteCallback), "DeliveryCompleteCallback"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04023FC3 RID: 147395
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04023FC4 RID: 147396
		[Nullable(2)]
		private SceneItemActorComponent ActorComp;

		// Token: 0x04023FC5 RID: 147397
		[Nullable(2)]
		private DollGrabShowcaseComponent Config;

		// Token: 0x04023FC6 RID: 147398
		[Nullable(2)]
		private AActor ElementContainerActor;

		// Token: 0x04023FC7 RID: 147399
		private readonly List<DollItemInfo> DollItemInfoList = new List<DollItemInfo>();

		// Token: 0x04023FC8 RID: 147400
		private readonly Dictionary<int, int> DollItemInfoIndexMap = new Dictionary<int, int>();

		// Token: 0x04023FC9 RID: 147401
		private readonly Dictionary<int, int> DollItemInfoElementIndexMap = new Dictionary<int, int>();

		// Token: 0x04023FCA RID: 147402
		private readonly List<int> DeliveryInfo = new List<int>();

		// Token: 0x04023FCB RID: 147403
		private bool HasFirstCompleteDollInternal;

		// Token: 0x04023FCC RID: 147404
		private bool IsActiveInternal;

		// Token: 0x04023FCD RID: 147405
		private bool IsInitializingInternal;

		// Token: 0x04023FCE RID: 147406
		[Nullable(2)]
		private Action DeliveryCompleteCallback;
	}
}
