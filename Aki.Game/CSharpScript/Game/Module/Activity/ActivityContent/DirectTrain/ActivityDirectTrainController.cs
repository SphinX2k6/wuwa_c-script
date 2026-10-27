using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain
{
	// Token: 0x0200673C RID: 26428
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityDirectTrainController : ActivityControllerBase
	{
		// Token: 0x06041F6D RID: 270189 RVA: 0x0100059A File Offset: 0x00FFE79A
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06041F6E RID: 270190 RVA: 0x010005A1 File Offset: 0x00FFE7A1
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06041F6F RID: 270191 RVA: 0x010005A4 File Offset: 0x00FFE7A4
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06041F70 RID: 270192 RVA: 0x010005A8 File Offset: 0x00FFE7A8
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityUpdate));
			EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
			Net.Instance.Register(ENotifyMessageId.ThroughTrainForceRemindNotify, new Action<IMessage, Net.CallbackStatus>(this.OnThroughTrainForceRemindNotify));
			Net.Instance.Register(ENotifyMessageId.DirectTrainPreOpenCloseNotify, new Action<IMessage, Net.CallbackStatus>(this.OnDirectTrainPreOpenCloseNotify));
			Net.Instance.Register(ENotifyMessageId.DirectTrainInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnDirectTrainInfoNotify));
			Net.Instance.Register(ENotifyMessageId.DirectTrainInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnDirectTrainInfoUpdateNotify));
		}

		// Token: 0x06041F71 RID: 270193 RVA: 0x0100067C File Offset: 0x00FFE87C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityUpdate));
			EventSystem.Instance.Remove<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
			Net.Instance.UnRegister(ENotifyMessageId.ThroughTrainForceRemindNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DirectTrainPreOpenCloseNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DirectTrainInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.DirectTrainInfoUpdateNotify);
		}

		// Token: 0x06041F72 RID: 270194 RVA: 0x0100071D File Offset: 0x00FFE91D
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06041F73 RID: 270195 RVA: 0x0100071F File Offset: 0x00FFE91F
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new ActivityDirectTrainData();
		}

		// Token: 0x06041F74 RID: 270196 RVA: 0x01000726 File Offset: 0x00FFE926
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityDirectTrainSubView();
		}

		// Token: 0x06041F75 RID: 270197 RVA: 0x0100072D File Offset: 0x00FFE92D
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return ActivityDirectTrainModel.Instance.GetPrefabResource(data.Id);
		}

		// Token: 0x1700965B RID: 38491
		// (get) Token: 0x06041F76 RID: 270198 RVA: 0x0100073F File Offset: 0x00FFE93F
		private Dictionary<EDirectTrainStartCondition, bool> DirectTrainStartConditionMap
		{
			get
			{
				return ActivityDirectTrainHelper.DirectTrainStartConditionMap;
			}
		}

		// Token: 0x06041F77 RID: 270199 RVA: 0x01000748 File Offset: 0x00FFE948
		private void OnReceiveActivityData(int type, IReadOnlyList<int> activityIds)
		{
			if (type != 30)
			{
				return;
			}
			foreach (int subActivityId in activityIds)
			{
				DirectTrainModel.Instance.RefreshSubActivityCache(subActivityId);
			}
			EventSystem.Instance.Emit<int>(EEventName.ActivityDirectTrainRedDotUpdate, 0);
		}

		// Token: 0x06041F78 RID: 270200 RVA: 0x010007AC File Offset: 0x00FFE9AC
		private void OnWorldDone()
		{
			UniTask? uniTask = null;
			if (FunctionModel.Instance.IsOpen(10053))
			{
				this.CheckIsStart(false);
			}
			else if (!UiManager.Instance.IsViewOpen(EUiViewName.DirectTrainProView) && !UiManager.Instance.IsViewOpen(EUiViewName.DirectTrainDetailView))
			{
				uniTask = new UniTask?(ActivityDirectTrainHelper.TryOpenPro(true));
			}
			if (uniTask != null)
			{
				uniTask.Value.ContinueWith(new Action(this.LoadInitDataIfNeed)).Forget();
				return;
			}
			this.LoadInitDataIfNeed();
		}

		// Token: 0x06041F79 RID: 270201 RVA: 0x01000837 File Offset: 0x00FFEA37
		private void LoadInitDataIfNeed()
		{
			if (ActivityDirectTrainModel.Instance.HasInitData())
			{
				return;
			}
			ActivityDirectTrainHelper.RequestDirectTrainInfoBeforeActivityOpen().ContinueWith(delegate(DirectTrainInfoResponse result)
			{
				ActivityDirectTrainModel.Instance.LoadDataFromInfoProto(result);
			}).Forget();
		}

		// Token: 0x06041F7A RID: 270202 RVA: 0x01000874 File Offset: 0x00FFEA74
		private void OnActivityUpdate(int activityId)
		{
			if (!FunctionModel.Instance.IsOpen(10053))
			{
				return;
			}
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(activityId);
			if (activityById == null || activityById.Type != ActivityType.ThroughTrain || activityById.Id != activityId)
			{
				return;
			}
			bool flag = activityById.IsUnLock();
			this.DirectTrainStartConditionMap[EDirectTrainStartCondition.ActivityOpen] = flag;
			if (flag)
			{
				this.CheckIsStart(true);
			}
		}

		// Token: 0x06041F7B RID: 270203 RVA: 0x010008D4 File Offset: 0x00FFEAD4
		[NullableContext(2)]
		private void OnThroughTrainForceRemindNotify(IMessage msg, Net.CallbackStatus status)
		{
			ThroughTrainForceRemindNotify throughTrainForceRemindNotify = (ThroughTrainForceRemindNotify)msg;
			ActivityDirectTrainModel.Instance.SetServerRemindActivityId(throughTrainForceRemindNotify.ActivityId);
		}

		// Token: 0x06041F7C RID: 270204 RVA: 0x010008F8 File Offset: 0x00FFEAF8
		[NullableContext(2)]
		private void OnDirectTrainPreOpenCloseNotify(IMessage msg, Net.CallbackStatus status)
		{
			DirectTrainPreOpenCloseNotify directTrainPreOpenCloseNotify = (DirectTrainPreOpenCloseNotify)msg;
			SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.DirectTrainPro);
			if (UiManager.Instance.IsViewOpen(EUiViewName.DirectTrainProView))
			{
				UiManager.Instance.CloseView(EUiViewName.DirectTrainProView, null);
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.DirectTrainDetailView))
			{
				UiManager.Instance.CloseView(EUiViewName.DirectTrainDetailView, null);
			}
			ActivityDirectTrainHelper.IsProOpen = false;
			ActivityDirectTrainHelper.EmitEventsForOther(false);
		}

		// Token: 0x06041F7D RID: 270205 RVA: 0x01000968 File Offset: 0x00FFEB68
		[NullableContext(2)]
		private void OnDirectTrainInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			DirectTrainInfoUpdateNotify proto = (DirectTrainInfoUpdateNotify)msg;
			ActivityDirectTrainModel.Instance.UpdateDataFromNotify(proto);
		}

		// Token: 0x06041F7E RID: 270206 RVA: 0x01000988 File Offset: 0x00FFEB88
		[NullableContext(2)]
		private void OnDirectTrainInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			DirectTrainInfoNotify directTrainInfoNotify = (DirectTrainInfoNotify)msg;
			if (directTrainInfoNotify.Activity != null && directTrainInfoNotify.Activity.Id != 0)
			{
				ActivityDirectTrainHelper.IsProOpen = true;
				ActivityDirectTrainHelper.EmitEventsForOther(true);
				if (!LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.IsDirectTrainProOpened, false) && GameModeModel.Instance.WorldDoneAndLoadingClosed)
				{
					ActivityDirectTrainHelper.TryOpenPro(true).Forget();
				}
			}
		}

		// Token: 0x06041F7F RID: 270207 RVA: 0x010009E4 File Offset: 0x00FFEBE4
		private void CheckIsStart(bool isInstantly = false)
		{
			if (PublicUtil.Instance.GetIsSilentLogin())
			{
				return;
			}
			int severRemindId = ActivityDirectTrainModel.Instance.GetDirectTrainServerRemindId();
			if (severRemindId != 0)
			{
				DirectTrainActivity? directTrainActivityConfById = ActivityDirectTrainConfig.Instance.GetDirectTrainActivityConfById(severRemindId);
				if (directTrainActivityConfById != null && directTrainActivityConfById.Value.IsForceRemind)
				{
					this.DirectTrainStartConditionMap[EDirectTrainStartCondition.ServerConditionDone] = true;
				}
			}
			bool flag = true;
			foreach (object obj in Enum.GetValues(typeof(EDirectTrainStartCondition)))
			{
				EDirectTrainStartCondition key = (EDirectTrainStartCondition)obj;
				bool flag2;
				if (!this.DirectTrainStartConditionMap.TryGetValue(key, out flag2) || !flag2)
				{
					flag = false;
					key.ToString();
					break;
				}
			}
			if (!flag)
			{
				return;
			}
			if (ActivityDirectTrainModel.Instance.AlreadyStartView)
			{
				return;
			}
			if (severRemindId != 0)
			{
				SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.DirectTrain, ESplashScreenType.Config, delegate()
				{
					DirectTrainSubActivityViewModel directTrainSubActivityViewModel = DirectTrainModel.Instance.BuildSubActivityViewModel(severRemindId);
					if (directTrainSubActivityViewModel == null)
					{
						SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.DirectTrain);
						return;
					}
					UiManager.Instance.OpenView(EUiViewName.DirectTrainDetailView, directTrainSubActivityViewModel, null);
				});
				SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
			}
		}

		// Token: 0x1700965C RID: 38492
		// (get) Token: 0x06041F80 RID: 270208 RVA: 0x01000B10 File Offset: 0x00FFED10
		public static ActivityDirectTrainController Instance
		{
			get
			{
				return ActivityDirectTrainController._Instance;
			}
		}

		// Token: 0x06041F81 RID: 270209 RVA: 0x01000B17 File Offset: 0x00FFED17
		public static ActivityDirectTrainController GetOrCreateInstance()
		{
			if (ActivityDirectTrainController._Instance == null)
			{
				ActivityDirectTrainController.CreateInstance();
			}
			return ActivityDirectTrainController._Instance;
		}

		// Token: 0x06041F82 RID: 270210 RVA: 0x01000B2B File Offset: 0x00FFED2B
		public static bool CreateInstance()
		{
			if (ActivityDirectTrainController._Instance != null)
			{
				return true;
			}
			ActivityDirectTrainController._Instance = new ActivityDirectTrainController();
			return true;
		}

		// Token: 0x06041F83 RID: 270211 RVA: 0x01000B41 File Offset: 0x00FFED41
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041F84 RID: 270212 RVA: 0x01000B43 File Offset: 0x00FFED43
		public static void ResetStaticDefaultValue()
		{
			ActivityDirectTrainController._Instance = null;
		}

		// Token: 0x06041F85 RID: 270213 RVA: 0x01000B4B File Offset: 0x00FFED4B
		static ActivityDirectTrainController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityDirectTrainController.CreateStaticDefaultValue), new Action(ActivityDirectTrainController.ResetStaticDefaultValue));
		}

		// Token: 0x040225E2 RID: 140770
		[Nullable(2)]
		private static ActivityDirectTrainController _Instance;
	}
}
