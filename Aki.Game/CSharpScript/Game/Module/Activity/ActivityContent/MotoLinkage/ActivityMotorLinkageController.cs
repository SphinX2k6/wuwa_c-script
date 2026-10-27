using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x02006445 RID: 25669
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMotorLinkageController : ActivityControllerBase
	{
		// Token: 0x06040851 RID: 264273 RVA: 0x00F9E153 File Offset: 0x00F9C353
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06040852 RID: 264274 RVA: 0x00F9E156 File Offset: 0x00F9C356
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06040853 RID: 264275 RVA: 0x00F9E158 File Offset: 0x00F9C358
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMotoLinkage";
		}

		// Token: 0x06040854 RID: 264276 RVA: 0x00F9E15F File Offset: 0x00F9C35F
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityMotorLinkageSubView();
		}

		// Token: 0x06040855 RID: 264277 RVA: 0x00F9E166 File Offset: 0x00F9C366
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Id = data.Id;
			return new ActivityMotorLinkageData();
		}

		// Token: 0x17009480 RID: 38016
		// (get) Token: 0x06040856 RID: 264278 RVA: 0x00F9E179 File Offset: 0x00F9C379
		public int ActivityId
		{
			get
			{
				return this.Id;
			}
		}

		// Token: 0x17009481 RID: 38017
		// (get) Token: 0x06040857 RID: 264279 RVA: 0x00F9E181 File Offset: 0x00F9C381
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

		// Token: 0x06040858 RID: 264280 RVA: 0x00F9E19F File Offset: 0x00F9C39F
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MotorcycleTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleActivityDataNotify));
		}

		// Token: 0x06040859 RID: 264281 RVA: 0x00F9E1BD File Offset: 0x00F9C3BD
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MotorcycleTaskUpdateNotify);
		}

		// Token: 0x0604085A RID: 264282 RVA: 0x00F9E1D0 File Offset: 0x00F9C3D0
		[NullableContext(2)]
		private void HandleActivityDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			MotorcycleTaskUpdateNotify notify = (MotorcycleTaskUpdateNotify)msg;
			this.ActivityData.OnQuestUpdateNotify(notify);
		}

		// Token: 0x0604085B RID: 264283 RVA: 0x00F9E1F0 File Offset: 0x00F9C3F0
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

		// Token: 0x17009482 RID: 38018
		// (get) Token: 0x0604085C RID: 264284 RVA: 0x00F9E23B File Offset: 0x00F9C43B
		public static ActivityMotorLinkageController Instance
		{
			get
			{
				return ActivityMotorLinkageController._Instance;
			}
		}

		// Token: 0x0604085D RID: 264285 RVA: 0x00F9E242 File Offset: 0x00F9C442
		public static ActivityMotorLinkageController GetOrCreateInstance()
		{
			if (ActivityMotorLinkageController._Instance == null)
			{
				ActivityMotorLinkageController.CreateInstance();
			}
			return ActivityMotorLinkageController._Instance;
		}

		// Token: 0x0604085E RID: 264286 RVA: 0x00F9E256 File Offset: 0x00F9C456
		public static bool CreateInstance()
		{
			if (ActivityMotorLinkageController._Instance != null)
			{
				return true;
			}
			ActivityMotorLinkageController._Instance = new ActivityMotorLinkageController();
			return true;
		}

		// Token: 0x0604085F RID: 264287 RVA: 0x00F9E26C File Offset: 0x00F9C46C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040860 RID: 264288 RVA: 0x00F9E26E File Offset: 0x00F9C46E
		public static void ResetStaticDefaultValue()
		{
			ActivityMotorLinkageController._Instance = null;
		}

		// Token: 0x06040861 RID: 264289 RVA: 0x00F9E276 File Offset: 0x00F9C476
		static ActivityMotorLinkageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorLinkageController.CreateStaticDefaultValue), new Action(ActivityMotorLinkageController.ResetStaticDefaultValue));
		}

		// Token: 0x040218D4 RID: 137428
		private int Id;

		// Token: 0x040218D5 RID: 137429
		[Nullable(2)]
		private static ActivityMotorLinkageController _Instance;
	}
}
