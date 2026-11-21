using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x0200604D RID: 24653
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabShowcaseController : ControllerBase
	{
		// Token: 0x17007008 RID: 28680
		// (get) Token: 0x0603B2E2 RID: 242402 RVA: 0x010BB8E0 File Offset: 0x010B9AE0
		[Nullable(2)]
		private SceneItemDollGrabMachineComponent DollGrabMachineComponent
		{
			[NullableContext(2)]
			get
			{
				if (this.DollGrabShowcaseComponent == null)
				{
					return null;
				}
				int? bindInfiniteModeDollGrabEntityId = this.DollGrabShowcaseComponent.BindInfiniteModeDollGrabEntityId;
				bool flag = (bindInfiniteModeDollGrabEntityId ?? 0) == 0;
				if (flag)
				{
					return null;
				}
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(bindInfiniteModeDollGrabEntityId.Value);
				if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) == null)
				{
					return null;
				}
				return entityByPbDataId.Entity.GetComponent<SceneItemDollGrabMachineComponent>();
			}
		}

		// Token: 0x17007009 RID: 28681
		// (get) Token: 0x0603B2E3 RID: 242403 RVA: 0x010BB94D File Offset: 0x010B9B4D
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
				if (this.DollGrabShowcaseComponent == null)
				{
					return null;
				}
				return this.DollGrabShowcaseComponent.DeliveryRewards;
			}
		}

		// Token: 0x1700700A RID: 28682
		// (get) Token: 0x0603B2E4 RID: 242404 RVA: 0x010BB964 File Offset: 0x010B9B64
		public int ConditionId
		{
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				if (dollGrabMachineComponent == null)
				{
					return 0;
				}
				return dollGrabMachineComponent.ConditionId;
			}
		}

		// Token: 0x1700700B RID: 28683
		// (get) Token: 0x0603B2E5 RID: 242405 RVA: 0x010BB977 File Offset: 0x010B9B77
		public bool IsEndlessMode
		{
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				return dollGrabMachineComponent != null && dollGrabMachineComponent.IsEndlessMode;
			}
		}

		// Token: 0x1700700C RID: 28684
		// (get) Token: 0x0603B2E6 RID: 242406 RVA: 0x010BB98A File Offset: 0x010B9B8A
		[Nullable(2)]
		public IDollGrabInfiniteShowCaseRewardData CurrentScoreRewardData
		{
			[NullableContext(2)]
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				if (dollGrabMachineComponent == null)
				{
					return null;
				}
				return dollGrabMachineComponent.CurrentScoreRewardData;
			}
		}

		// Token: 0x0603B2E7 RID: 242407 RVA: 0x010BB9A0 File Offset: 0x010B9BA0
		protected override bool OnInit()
		{
			global::Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineController] 初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			DollGrabModel.Instance.LoadDollGrabMachineGlobalConfig();
			return true;
		}

		// Token: 0x0603B2E8 RID: 242408 RVA: 0x010BB9D7 File Offset: 0x010B9BD7
		private void OpenDollGrabShowcaseInspectView()
		{
			if (this.IsGameplayReady)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DollGrabShowcaseInspectView, null, delegate(bool _, int _)
			{
				this.DollGrabShowcaseComponent.OnStartShowcaseGameplay();
			});
			this.IsGameplayReady = true;
			TsInteractionUtils.RegisterOpenViewName(EUiViewName.DollGrabShowcaseInspectView);
		}

		// Token: 0x0603B2E9 RID: 242409 RVA: 0x010BBA10 File Offset: 0x010B9C10
		public UniTask InitAllDollShowcaseActors()
		{
			DollGrabShowcaseController.<InitAllDollShowcaseActors>d__17 <InitAllDollShowcaseActors>d__;
			<InitAllDollShowcaseActors>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAllDollShowcaseActors>d__.<>4__this = this;
			<InitAllDollShowcaseActors>d__.<>1__state = -1;
			<InitAllDollShowcaseActors>d__.<>t__builder.Start<DollGrabShowcaseController.<InitAllDollShowcaseActors>d__17>(ref <InitAllDollShowcaseActors>d__);
			return <InitAllDollShowcaseActors>d__.<>t__builder.Task;
		}

		// Token: 0x0603B2EA RID: 242410 RVA: 0x010BBA54 File Offset: 0x010B9C54
		public void StartDollGrabShowcaseView(IDollGrabShowcase config)
		{
			if (this.IsGameplayReady)
			{
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(config.ShowcaseEntityId);
			if (!entityByPbDataId || !entityByPbDataId.Entity)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.DollGrabMachine;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[DollGrabShowcase] 娃娃展示柜实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", config.ShowcaseEntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.DollGrabShowcaseComponent = entityByPbDataId.Entity.GetComponent<SceneItemDollGrabShowcaseComponent>();
			if (this.DollGrabShowcaseComponent == null)
			{
				global::Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabShowcase] 娃娃展示柜实体没有SceneItemDollGrabShowcaseComponent组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.OpenDollGrabShowcaseInspectView();
		}

		// Token: 0x0603B2EB RID: 242411 RVA: 0x010BBB04 File Offset: 0x010B9D04
		public void StartDollGrabShowcaseViewByDelivery()
		{
			if (this.IsGameplayReady || this.DollGrabShowcaseComponent == null)
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.DollGrabDeliveryView))
			{
				UiManager.Instance.CloseView(EUiViewName.DollGrabDeliveryView, null);
			}
			this.OpenDollGrabShowcaseInspectView();
		}

		// Token: 0x0603B2EC RID: 242412 RVA: 0x010BBB40 File Offset: 0x010B9D40
		[NullableContext(2)]
		public void OpenAllViewCamera(Action<ELevelEventState> finishCallback = null)
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return;
			}
			SceneItemActorComponent component = this.DollGrabShowcaseComponent.Entity.GetComponent<SceneItemActorComponent>();
			if (!component)
			{
				global::Log.Instance.Error(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabShowcase] 娃娃展示柜实体没有SceneItemActorComponent组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			IShowcaseFullViewCameraConfig allViewCameraInfo = this.DollGrabShowcaseComponent.AllViewCameraInfo;
			if (allViewCameraInfo == null)
			{
				return;
			}
			MathUtils.Instance.CommonTempVector.Set((double)allViewCameraInfo.PosAndRot.X.GetValueOrDefault(), (double)allViewCameraInfo.PosAndRot.Y.GetValueOrDefault(), (double)allViewCameraInfo.PosAndRot.Z.GetValueOrDefault());
			MathUtils.Instance.CommonTempRotator.Set(allViewCameraInfo.PosAndRot.Pitch.GetValueOrDefault(), allViewCameraInfo.PosAndRot.A.GetValueOrDefault(), allViewCameraInfo.PosAndRot.Roll.GetValueOrDefault());
			BP_CineCamera_C cineCamera = CameraController.Instance.MainModel.SceneCamera.DisplayComponent.CineCamera;
			float fov = LguiUtil.AdaptFieldOfViewByViewport(allViewCameraInfo.Fov, (cineCamera != null) ? cineCamera.AspectRatio_DEPRECATED : 1.7777778f);
			DollGrabCameraConfig cameraInfo = new DollGrabCameraConfig(MathUtils.Instance.CommonTempVector, MathUtils.Instance.CommonTempRotator, 0.5f, 0.5f, true, true, fov);
			DollGrabModel.Instance.ExecuteAdjustPlayerCamera(component, cameraInfo, "DollGrabMachineFixCamera", finishCallback);
		}

		// Token: 0x0603B2ED RID: 242413 RVA: 0x010BBCAC File Offset: 0x010B9EAC
		public UniTask OpenFocusViewCamera(DollViewCameraInfo cameraInfo)
		{
			DollGrabShowcaseController.<OpenFocusViewCamera>d__21 <OpenFocusViewCamera>d__;
			<OpenFocusViewCamera>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenFocusViewCamera>d__.<>4__this = this;
			<OpenFocusViewCamera>d__.cameraInfo = cameraInfo;
			<OpenFocusViewCamera>d__.<>1__state = -1;
			<OpenFocusViewCamera>d__.<>t__builder.Start<DollGrabShowcaseController.<OpenFocusViewCamera>d__21>(ref <OpenFocusViewCamera>d__);
			return <OpenFocusViewCamera>d__.<>t__builder.Task;
		}

		// Token: 0x0603B2EE RID: 242414 RVA: 0x010BBCF8 File Offset: 0x010B9EF8
		public void OnClickMoveInput(string name, InputDistributeDefine.EActionType actionType)
		{
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				if (name == "向左移动")
				{
					this.DollGrabShowcaseComponent.OpenDollViewCamera(350001);
					return;
				}
				if (!(name == "向右移动"))
				{
					return;
				}
				this.DollGrabShowcaseComponent.OpenDollViewCamera(350002);
				return;
			}
			else
			{
				if (name == "向左移动")
				{
					this.DollGrabShowcaseComponent.CloseDollViewCamera();
					return;
				}
				if (!(name == "向右移动"))
				{
					return;
				}
				this.DollGrabShowcaseComponent.CloseDollViewCamera();
				return;
			}
		}

		// Token: 0x0603B2EF RID: 242415 RVA: 0x010BBD7B File Offset: 0x010B9F7B
		public void ExitDollGrabGameplay()
		{
			this.IsGameplayReady = false;
			if (!this.EndToEndlessMode)
			{
				DollGrabModel.Instance.ExecuteRestorePlayerCamera("DollGrabMachineFixCamera", null);
			}
			this.EndToEndlessMode = false;
			this.DollGrabShowcaseComponent.OnEndShowcaseGameplay();
			this.DollGrabShowcaseComponent = null;
		}

		// Token: 0x0603B2F0 RID: 242416 RVA: 0x010BBDB8 File Offset: 0x010B9FB8
		public void OnNotifyDollDelivery(DollDeliveryNotify notify)
		{
			Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
			foreach (int num in notify.ItemIds)
			{
				DollGrabItemsCsv? config = ConfigDollGrabItemsCsvById.GetConfig(num, true);
				if (config == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[OnNotifyDollDelivery] 交付娃娃信息配置缺失";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					if (!dictionary.ContainsKey(config.Value.ShowcaseBelongType))
					{
						dictionary.Add(config.Value.ShowcaseBelongType, new List<int>());
					}
					dictionary[config.Value.ShowcaseBelongType].Add(num);
				}
			}
			foreach (KeyValuePair<string, List<int>> keyValuePair in dictionary)
			{
				string text;
				List<int> list;
				keyValuePair.Deconstruct(out text, out list);
				string key = text;
				List<int> list2 = list;
				if (this.DollGrabShowcaseMap.ContainsKey(key))
				{
					this.DollGrabShowcaseMap[key].OnNotifyDollDeliveryInfos(list2, true);
				}
				else if (!this.DollDeliveryInfo.ContainsKey(key))
				{
					this.DollDeliveryInfo.Add(key, list2);
				}
				else
				{
					this.DollDeliveryInfo[key].AddRange(list2);
				}
			}
			foreach (int num2 in notify.DropIds)
			{
				Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(num2);
				if (dropPackagePreview == null)
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.DollGrabMachine;
					ELogAuthor author2 = ELogAuthor.FJH;
					string message2 = "[OnNotifyDollDelivery] 交付掉落信息配置缺失";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DropId", num2);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					foreach (KeyValuePair<int, int> keyValuePair2 in dropPackagePreview)
					{
						int num3;
						int num4;
						keyValuePair2.Deconstruct(out num3, out num4);
						int configId = num3;
						int count = num4;
						RewardItemData item = new RewardItemData(configId, count, null, EDropItemType.Normal);
						DollGrabModel.Instance.DollDeliveryRewardData.Add(item);
					}
				}
			}
		}

		// Token: 0x0603B2F1 RID: 242417 RVA: 0x010BC034 File Offset: 0x010BA234
		public void OnClickDelivery()
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return;
			}
			DollDeliveryRequest dollDeliveryRequest = DollDeliveryRequest.Create();
			dollDeliveryRequest.EntityCfgId = this.DollGrabShowcaseComponent.PdDataId;
			Net.Instance.Call(ERequestMessageId.DollDeliveryRequest, dollDeliveryRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DollDeliveryResponse dollDeliveryResponse = (DollDeliveryResponse)msg;
				if (dollDeliveryResponse == null)
				{
					return;
				}
				if (dollDeliveryResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.DollGrabMachine;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[OnClickDelivery] 交付请求失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("errorCode", dollDeliveryResponse.ErrorCode);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					EventSystem.Instance.Emit<bool>(EEventName.OnDollGrabMachineDeliveryFinish, false);
				}
			}, 0);
		}

		// Token: 0x0603B2F2 RID: 242418 RVA: 0x010BC094 File Offset: 0x010BA294
		[NullableContext(0)]
		public UniTask<bool> RequestDollMachineMapInfoAsync()
		{
			DollGrabShowcaseController.<RequestDollMachineMapInfoAsync>d__26 <RequestDollMachineMapInfoAsync>d__;
			<RequestDollMachineMapInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestDollMachineMapInfoAsync>d__.<>1__state = -1;
			<RequestDollMachineMapInfoAsync>d__.<>t__builder.Start<DollGrabShowcaseController.<RequestDollMachineMapInfoAsync>d__26>(ref <RequestDollMachineMapInfoAsync>d__);
			return <RequestDollMachineMapInfoAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B2F3 RID: 242419 RVA: 0x010BC0D0 File Offset: 0x010BA2D0
		public void RegisterShowcase(SceneItemDollGrabShowcaseComponent comp)
		{
			if (this.DollGrabShowcaseMap.ContainsKey(comp.BelongType))
			{
				return;
			}
			this.DollGrabShowcaseMap.Add(comp.BelongType, comp);
			if (this.DollDeliveryInfo.ContainsKey(comp.BelongType))
			{
				comp.OnNotifyDollDeliveryInfos(this.DollDeliveryInfo[comp.BelongType], true);
				this.DollDeliveryInfo.Remove(comp.BelongType);
			}
		}

		// Token: 0x0603B2F4 RID: 242420 RVA: 0x010BC140 File Offset: 0x010BA340
		public void UnregisterShowcase(SceneItemDollGrabShowcaseComponent comp)
		{
			if (!this.DollGrabShowcaseMap.ContainsKey(comp.BelongType))
			{
				return;
			}
			this.DollGrabShowcaseMap.Remove(comp.BelongType);
		}

		// Token: 0x0603B2F5 RID: 242421 RVA: 0x010BC168 File Offset: 0x010BA368
		public List<DollItemInfo> GetCurrentDollItemInfoList()
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return new List<DollItemInfo>();
			}
			return this.DollGrabShowcaseComponent.GetDollItemInfoList();
		}

		// Token: 0x0603B2F6 RID: 242422 RVA: 0x010BC183 File Offset: 0x010BA383
		[NullableContext(2)]
		public IDollCollectData GetCollectData()
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return null;
			}
			return this.DollGrabShowcaseComponent.GetCollectData();
		}

		// Token: 0x0603B2F7 RID: 242423 RVA: 0x010BC19A File Offset: 0x010BA39A
		public void SetDeliveryCompleteCallback(Action callback)
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return;
			}
			this.DollGrabShowcaseComponent.SetDeliveryCompleteCallback(callback);
		}

		// Token: 0x0603B2F8 RID: 242424 RVA: 0x010BC1B4 File Offset: 0x010BA3B4
		public void ChangeShowcasePerformanceState(int state)
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return;
			}
			SceneItemStateComponent component = this.DollGrabShowcaseComponent.Entity.GetComponent<SceneItemStateComponent>();
			if (component == null)
			{
				return;
			}
			component.ChangePerformanceState(state, false, true);
		}

		// Token: 0x0603B2F9 RID: 242425 RVA: 0x010BC1E8 File Offset: 0x010BA3E8
		[NullableContext(0)]
		public UniTask<int?> StartDollGrabDeliveryView([Nullable(1)] SceneItemDollGrabShowcaseComponent showcaseComp)
		{
			DollGrabShowcaseController.<StartDollGrabDeliveryView>d__33 <StartDollGrabDeliveryView>d__;
			<StartDollGrabDeliveryView>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
			<StartDollGrabDeliveryView>d__.<>4__this = this;
			<StartDollGrabDeliveryView>d__.showcaseComp = showcaseComp;
			<StartDollGrabDeliveryView>d__.<>1__state = -1;
			<StartDollGrabDeliveryView>d__.<>t__builder.Start<DollGrabShowcaseController.<StartDollGrabDeliveryView>d__33>(ref <StartDollGrabDeliveryView>d__);
			return <StartDollGrabDeliveryView>d__.<>t__builder.Task;
		}

		// Token: 0x0603B2FA RID: 242426 RVA: 0x010BC233 File Offset: 0x010BA433
		public List<int> GetShowcaseBindingItemIds()
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return new List<int>();
			}
			return this.DollGrabShowcaseComponent.GetAllBindingItemIds();
		}

		// Token: 0x1700700D RID: 28685
		// (get) Token: 0x0603B2FB RID: 242427 RVA: 0x010BC24E File Offset: 0x010BA44E
		public static DollGrabShowcaseController Instance
		{
			get
			{
				return DollGrabShowcaseController._Instance;
			}
		}

		// Token: 0x0603B2FC RID: 242428 RVA: 0x010BC255 File Offset: 0x010BA455
		public static DollGrabShowcaseController GetOrCreateInstance()
		{
			if (DollGrabShowcaseController._Instance == null)
			{
				DollGrabShowcaseController.CreateInstance();
			}
			return DollGrabShowcaseController._Instance;
		}

		// Token: 0x0603B2FD RID: 242429 RVA: 0x010BC269 File Offset: 0x010BA469
		public static bool CreateInstance()
		{
			if (DollGrabShowcaseController._Instance != null)
			{
				return true;
			}
			DollGrabShowcaseController._Instance = new DollGrabShowcaseController();
			return true;
		}

		// Token: 0x0603B2FE RID: 242430 RVA: 0x010BC27F File Offset: 0x010BA47F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B2FF RID: 242431 RVA: 0x010BC281 File Offset: 0x010BA481
		public static void ResetStaticDefaultValue()
		{
			DollGrabShowcaseController._Instance = null;
		}

		// Token: 0x0603B300 RID: 242432 RVA: 0x010BC289 File Offset: 0x010BA489
		static DollGrabShowcaseController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DollGrabShowcaseController.CreateStaticDefaultValue), new Action(DollGrabShowcaseController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F238 RID: 127544
		[Nullable(2)]
		private SceneItemDollGrabShowcaseComponent DollGrabShowcaseComponent;

		// Token: 0x0401F239 RID: 127545
		private bool IsGameplayReady;

		// Token: 0x0401F23A RID: 127546
		private readonly Dictionary<string, List<int>> DollDeliveryInfo = new Dictionary<string, List<int>>();

		// Token: 0x0401F23B RID: 127547
		private readonly Dictionary<string, SceneItemDollGrabShowcaseComponent> DollGrabShowcaseMap = new Dictionary<string, SceneItemDollGrabShowcaseComponent>();

		// Token: 0x0401F23C RID: 127548
		public bool EndToEndlessMode;

		// Token: 0x0401F23D RID: 127549
		[Nullable(2)]
		private static DollGrabShowcaseController _Instance;
	}
}
