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
	// Token: 0x02006ECD RID: 28365
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabShowcaseController : ControllerBase
	{
		// Token: 0x17009AD1 RID: 39633
		// (get) Token: 0x06045141 RID: 282945 RVA: 0x01111804 File Offset: 0x0110FA04
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

		// Token: 0x17009AD2 RID: 39634
		// (get) Token: 0x06045142 RID: 282946 RVA: 0x01111871 File Offset: 0x0110FA71
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

		// Token: 0x17009AD3 RID: 39635
		// (get) Token: 0x06045143 RID: 282947 RVA: 0x01111888 File Offset: 0x0110FA88
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

		// Token: 0x17009AD4 RID: 39636
		// (get) Token: 0x06045144 RID: 282948 RVA: 0x0111189B File Offset: 0x0110FA9B
		public bool IsEndlessMode
		{
			get
			{
				SceneItemDollGrabMachineComponent dollGrabMachineComponent = this.DollGrabMachineComponent;
				return dollGrabMachineComponent != null && dollGrabMachineComponent.IsEndlessMode;
			}
		}

		// Token: 0x17009AD5 RID: 39637
		// (get) Token: 0x06045145 RID: 282949 RVA: 0x011118AE File Offset: 0x0110FAAE
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

		// Token: 0x06045146 RID: 282950 RVA: 0x011118C4 File Offset: 0x0110FAC4
		protected override bool OnInit()
		{
			global::Log.Instance.Info(ELogModule.DollGrabMachine, ELogAuthor.FJH, "[DollGrabMachineController] 初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			DollGrabModel.Instance.LoadDollGrabMachineGlobalConfig();
			return true;
		}

		// Token: 0x06045147 RID: 282951 RVA: 0x011118FB File Offset: 0x0110FAFB
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

		// Token: 0x06045148 RID: 282952 RVA: 0x01111934 File Offset: 0x0110FB34
		public UniTask InitAllDollShowcaseActors()
		{
			DollGrabShowcaseController.<InitAllDollShowcaseActors>d__17 <InitAllDollShowcaseActors>d__;
			<InitAllDollShowcaseActors>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAllDollShowcaseActors>d__.<>4__this = this;
			<InitAllDollShowcaseActors>d__.<>1__state = -1;
			<InitAllDollShowcaseActors>d__.<>t__builder.Start<DollGrabShowcaseController.<InitAllDollShowcaseActors>d__17>(ref <InitAllDollShowcaseActors>d__);
			return <InitAllDollShowcaseActors>d__.<>t__builder.Task;
		}

		// Token: 0x06045149 RID: 282953 RVA: 0x01111978 File Offset: 0x0110FB78
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

		// Token: 0x0604514A RID: 282954 RVA: 0x01111A28 File Offset: 0x0110FC28
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

		// Token: 0x0604514B RID: 282955 RVA: 0x01111A64 File Offset: 0x0110FC64
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

		// Token: 0x0604514C RID: 282956 RVA: 0x01111BD0 File Offset: 0x0110FDD0
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

		// Token: 0x0604514D RID: 282957 RVA: 0x01111C1C File Offset: 0x0110FE1C
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

		// Token: 0x0604514E RID: 282958 RVA: 0x01111C9F File Offset: 0x0110FE9F
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

		// Token: 0x0604514F RID: 282959 RVA: 0x01111CDC File Offset: 0x0110FEDC
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

		// Token: 0x06045150 RID: 282960 RVA: 0x01111F58 File Offset: 0x01110158
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

		// Token: 0x06045151 RID: 282961 RVA: 0x01111FB8 File Offset: 0x011101B8
		[NullableContext(0)]
		public UniTask<bool> RequestDollMachineMapInfoAsync()
		{
			DollGrabShowcaseController.<RequestDollMachineMapInfoAsync>d__26 <RequestDollMachineMapInfoAsync>d__;
			<RequestDollMachineMapInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestDollMachineMapInfoAsync>d__.<>1__state = -1;
			<RequestDollMachineMapInfoAsync>d__.<>t__builder.Start<DollGrabShowcaseController.<RequestDollMachineMapInfoAsync>d__26>(ref <RequestDollMachineMapInfoAsync>d__);
			return <RequestDollMachineMapInfoAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045152 RID: 282962 RVA: 0x01111FF4 File Offset: 0x011101F4
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

		// Token: 0x06045153 RID: 282963 RVA: 0x01112064 File Offset: 0x01110264
		public void UnregisterShowcase(SceneItemDollGrabShowcaseComponent comp)
		{
			if (!this.DollGrabShowcaseMap.ContainsKey(comp.BelongType))
			{
				return;
			}
			this.DollGrabShowcaseMap.Remove(comp.BelongType);
		}

		// Token: 0x06045154 RID: 282964 RVA: 0x0111208C File Offset: 0x0111028C
		public List<DollItemInfo> GetCurrentDollItemInfoList()
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return new List<DollItemInfo>();
			}
			return this.DollGrabShowcaseComponent.GetDollItemInfoList();
		}

		// Token: 0x06045155 RID: 282965 RVA: 0x011120A7 File Offset: 0x011102A7
		[NullableContext(2)]
		public IDollCollectData GetCollectData()
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return null;
			}
			return this.DollGrabShowcaseComponent.GetCollectData();
		}

		// Token: 0x06045156 RID: 282966 RVA: 0x011120BE File Offset: 0x011102BE
		public void SetDeliveryCompleteCallback(Action callback)
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return;
			}
			this.DollGrabShowcaseComponent.SetDeliveryCompleteCallback(callback);
		}

		// Token: 0x06045157 RID: 282967 RVA: 0x011120D8 File Offset: 0x011102D8
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

		// Token: 0x06045158 RID: 282968 RVA: 0x0111210C File Offset: 0x0111030C
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

		// Token: 0x06045159 RID: 282969 RVA: 0x01112157 File Offset: 0x01110357
		public List<int> GetShowcaseBindingItemIds()
		{
			if (this.DollGrabShowcaseComponent == null)
			{
				return new List<int>();
			}
			return this.DollGrabShowcaseComponent.GetAllBindingItemIds();
		}

		// Token: 0x17009AD6 RID: 39638
		// (get) Token: 0x0604515A RID: 282970 RVA: 0x01112172 File Offset: 0x01110372
		public static DollGrabShowcaseController Instance
		{
			get
			{
				return DollGrabShowcaseController._Instance;
			}
		}

		// Token: 0x0604515B RID: 282971 RVA: 0x01112179 File Offset: 0x01110379
		public static DollGrabShowcaseController GetOrCreateInstance()
		{
			if (DollGrabShowcaseController._Instance == null)
			{
				DollGrabShowcaseController.CreateInstance();
			}
			return DollGrabShowcaseController._Instance;
		}

		// Token: 0x0604515C RID: 282972 RVA: 0x0111218D File Offset: 0x0111038D
		public static bool CreateInstance()
		{
			if (DollGrabShowcaseController._Instance != null)
			{
				return true;
			}
			DollGrabShowcaseController._Instance = new DollGrabShowcaseController();
			return true;
		}

		// Token: 0x0604515D RID: 282973 RVA: 0x011121A3 File Offset: 0x011103A3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604515E RID: 282974 RVA: 0x011121A5 File Offset: 0x011103A5
		public static void ResetStaticDefaultValue()
		{
			DollGrabShowcaseController._Instance = null;
		}

		// Token: 0x0604515F RID: 282975 RVA: 0x011121AD File Offset: 0x011103AD
		static DollGrabShowcaseController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DollGrabShowcaseController.CreateStaticDefaultValue), new Action(DollGrabShowcaseController.ResetStaticDefaultValue));
		}

		// Token: 0x04023F85 RID: 147333
		[Nullable(2)]
		private SceneItemDollGrabShowcaseComponent DollGrabShowcaseComponent;

		// Token: 0x04023F86 RID: 147334
		private bool IsGameplayReady;

		// Token: 0x04023F87 RID: 147335
		private readonly Dictionary<string, List<int>> DollDeliveryInfo = new Dictionary<string, List<int>>();

		// Token: 0x04023F88 RID: 147336
		private readonly Dictionary<string, SceneItemDollGrabShowcaseComponent> DollGrabShowcaseMap = new Dictionary<string, SceneItemDollGrabShowcaseComponent>();

		// Token: 0x04023F89 RID: 147337
		public bool EndToEndlessMode;

		// Token: 0x04023F8A RID: 147338
		[Nullable(2)]
		private static DollGrabShowcaseController _Instance;
	}
}
