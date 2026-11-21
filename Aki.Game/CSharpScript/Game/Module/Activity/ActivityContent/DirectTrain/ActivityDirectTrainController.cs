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
	// Token: 0x0200568C RID: 22156
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityDirectTrainController : ActivityControllerBase
	{
		// Token: 0x06036AB9 RID: 223929 RVA: 0x00F4194A File Offset: 0x00F3FB4A
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06036ABA RID: 223930 RVA: 0x00F41951 File Offset: 0x00F3FB51
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06036ABB RID: 223931 RVA: 0x00F41954 File Offset: 0x00F3FB54
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06036ABC RID: 223932 RVA: 0x00F41958 File Offset: 0x00F3FB58
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

		// Token: 0x06036ABD RID: 223933 RVA: 0x00F41A2C File Offset: 0x00F3FC2C
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

		// Token: 0x06036ABE RID: 223934 RVA: 0x00F41ACD File Offset: 0x00F3FCCD
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06036ABF RID: 223935 RVA: 0x00F41ACF File Offset: 0x00F3FCCF
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new ActivityDirectTrainData();
		}

		// Token: 0x06036AC0 RID: 223936 RVA: 0x00F41AD6 File Offset: 0x00F3FCD6
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityDirectTrainSubView();
		}

		// Token: 0x06036AC1 RID: 223937 RVA: 0x00F41ADD File Offset: 0x00F3FCDD
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return ActivityDirectTrainModel.Instance.GetPrefabResource(data.Id);
		}

		// Token: 0x1700699A RID: 27034
		// (get) Token: 0x06036AC2 RID: 223938 RVA: 0x00F41AEF File Offset: 0x00F3FCEF
		private Dictionary<EDirectTrainStartCondition, bool> DirectTrainStartConditionMap
		{
			get
			{
				return ActivityDirectTrainHelper.DirectTrainStartConditionMap;
			}
		}

		// Token: 0x06036AC3 RID: 223939 RVA: 0x00F41AF8 File Offset: 0x00F3FCF8
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

		// Token: 0x06036AC4 RID: 223940 RVA: 0x00F41B5C File Offset: 0x00F3FD5C
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

		// Token: 0x06036AC5 RID: 223941 RVA: 0x00F41BE7 File Offset: 0x00F3FDE7
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

		// Token: 0x06036AC6 RID: 223942 RVA: 0x00F41C24 File Offset: 0x00F3FE24
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

		// Token: 0x06036AC7 RID: 223943 RVA: 0x00F41C84 File Offset: 0x00F3FE84
		[NullableContext(2)]
		private void OnThroughTrainForceRemindNotify(IMessage msg, Net.CallbackStatus status)
		{
			ThroughTrainForceRemindNotify throughTrainForceRemindNotify = (ThroughTrainForceRemindNotify)msg;
			ActivityDirectTrainModel.Instance.SetServerRemindActivityId(throughTrainForceRemindNotify.ActivityId);
		}

		// Token: 0x06036AC8 RID: 223944 RVA: 0x00F41CA8 File Offset: 0x00F3FEA8
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

		// Token: 0x06036AC9 RID: 223945 RVA: 0x00F41D18 File Offset: 0x00F3FF18
		[NullableContext(2)]
		private void OnDirectTrainInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			DirectTrainInfoUpdateNotify proto = (DirectTrainInfoUpdateNotify)msg;
			ActivityDirectTrainModel.Instance.UpdateDataFromNotify(proto);
		}

		// Token: 0x06036ACA RID: 223946 RVA: 0x00F41D38 File Offset: 0x00F3FF38
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

		// Token: 0x06036ACB RID: 223947 RVA: 0x00F41D94 File Offset: 0x00F3FF94
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

		// Token: 0x1700699B RID: 27035
		// (get) Token: 0x06036ACC RID: 223948 RVA: 0x00F41EC0 File Offset: 0x00F400C0
		public static ActivityDirectTrainController Instance
		{
			get
			{
				return ActivityDirectTrainController._Instance;
			}
		}

		// Token: 0x06036ACD RID: 223949 RVA: 0x00F41EC7 File Offset: 0x00F400C7
		public static ActivityDirectTrainController GetOrCreateInstance()
		{
			if (ActivityDirectTrainController._Instance == null)
			{
				ActivityDirectTrainController.CreateInstance();
			}
			return ActivityDirectTrainController._Instance;
		}

		// Token: 0x06036ACE RID: 223950 RVA: 0x00F41EDB File Offset: 0x00F400DB
		public static bool CreateInstance()
		{
			if (ActivityDirectTrainController._Instance != null)
			{
				return true;
			}
			ActivityDirectTrainController._Instance = new ActivityDirectTrainController();
			return true;
		}

		// Token: 0x06036ACF RID: 223951 RVA: 0x00F41EF1 File Offset: 0x00F400F1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036AD0 RID: 223952 RVA: 0x00F41EF3 File Offset: 0x00F400F3
		public static void ResetStaticDefaultValue()
		{
			ActivityDirectTrainController._Instance = null;
		}

		// Token: 0x06036AD1 RID: 223953 RVA: 0x00F41EFB File Offset: 0x00F400FB
		static ActivityDirectTrainController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityDirectTrainController.CreateStaticDefaultValue), new Action(ActivityDirectTrainController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE3B RID: 118331
		[Nullable(2)]
		private static ActivityDirectTrainController _Instance;
	}
}
