using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x020053C3 RID: 21443
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMotorLinkageController : ActivityControllerBase
	{
		// Token: 0x06035512 RID: 218386 RVA: 0x00EE50CF File Offset: 0x00EE32CF
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06035513 RID: 218387 RVA: 0x00EE50D2 File Offset: 0x00EE32D2
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06035514 RID: 218388 RVA: 0x00EE50D4 File Offset: 0x00EE32D4
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMotoLinkage";
		}

		// Token: 0x06035515 RID: 218389 RVA: 0x00EE50DB File Offset: 0x00EE32DB
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityMotorLinkageSubView();
		}

		// Token: 0x06035516 RID: 218390 RVA: 0x00EE50E2 File Offset: 0x00EE32E2
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Id = data.Id;
			return new ActivityMotorLinkageData();
		}

		// Token: 0x170067E2 RID: 26594
		// (get) Token: 0x06035517 RID: 218391 RVA: 0x00EE50F5 File Offset: 0x00EE32F5
		public int ActivityId
		{
			get
			{
				return this.Id;
			}
		}

		// Token: 0x170067E3 RID: 26595
		// (get) Token: 0x06035518 RID: 218392 RVA: 0x00EE50FD File Offset: 0x00EE32FD
		[Nullable(2)]
		public ActivityMotorLinkageData ActivityData
		{
			[NullableContext(2)]
			get
			{
				ActivityModel instance = ActivityModel.Instance;
				return ((instance != null) ? instance.GetActivityById(this.Id) : null) as ActivityMotorLinkageData;
			}
		}

		// Token: 0x06035519 RID: 218393 RVA: 0x00EE511B File Offset: 0x00EE331B
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MotorcycleTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleActivityDataNotify));
		}

		// Token: 0x0603551A RID: 218394 RVA: 0x00EE5139 File Offset: 0x00EE3339
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MotorcycleTaskUpdateNotify);
		}

		// Token: 0x0603551B RID: 218395 RVA: 0x00EE514C File Offset: 0x00EE334C
		[NullableContext(2)]
		private void HandleActivityDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			MotorcycleTaskUpdateNotify notify = (MotorcycleTaskUpdateNotify)msg;
			this.ActivityData.OnQuestUpdateNotify(notify);
		}

		// Token: 0x0603551C RID: 218396 RVA: 0x00EE516C File Offset: 0x00EE336C
		public UniTask ReceiveAllRewardRequest(int ipId)
		{
			ActivityMotorLinkageController.<ReceiveAllRewardRequest>d__13 <ReceiveAllRewardRequest>d__;
			<ReceiveAllRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReceiveAllRewardRequest>d__.<>4__this = this;
			<ReceiveAllRewardRequest>d__.ipId = ipId;
			<ReceiveAllRewardRequest>d__.<>1__state = -1;
			<ReceiveAllRewardRequest>d__.<>t__builder.Start<ActivityMotorLinkageController.<ReceiveAllRewardRequest>d__13>(ref <ReceiveAllRewardRequest>d__);
			return <ReceiveAllRewardRequest>d__.<>t__builder.Task;
		}

		// Token: 0x170067E4 RID: 26596
		// (get) Token: 0x0603551D RID: 218397 RVA: 0x00EE51B7 File Offset: 0x00EE33B7
		public static ActivityMotorLinkageController Instance
		{
			get
			{
				return ActivityMotorLinkageController._Instance;
			}
		}

		// Token: 0x0603551E RID: 218398 RVA: 0x00EE51BE File Offset: 0x00EE33BE
		public static ActivityMotorLinkageController GetOrCreateInstance()
		{
			if (ActivityMotorLinkageController._Instance == null)
			{
				ActivityMotorLinkageController.CreateInstance();
			}
			return ActivityMotorLinkageController._Instance;
		}

		// Token: 0x0603551F RID: 218399 RVA: 0x00EE51D2 File Offset: 0x00EE33D2
		public static bool CreateInstance()
		{
			if (ActivityMotorLinkageController._Instance != null)
			{
				return true;
			}
			ActivityMotorLinkageController._Instance = new ActivityMotorLinkageController();
			return true;
		}

		// Token: 0x06035520 RID: 218400 RVA: 0x00EE51E8 File Offset: 0x00EE33E8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035521 RID: 218401 RVA: 0x00EE51EA File Offset: 0x00EE33EA
		public static void ResetStaticDefaultValue()
		{
			ActivityMotorLinkageController._Instance = null;
		}

		// Token: 0x06035522 RID: 218402 RVA: 0x00EE51F2 File Offset: 0x00EE33F2
		static ActivityMotorLinkageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorLinkageController.CreateStaticDefaultValue), new Action(ActivityMotorLinkageController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C203 RID: 115203
		private int Id;

		// Token: 0x0401C204 RID: 115204
		[Nullable(2)]
		private static ActivityMotorLinkageController _Instance;
	}
}
