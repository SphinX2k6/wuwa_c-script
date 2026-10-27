using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Prepare.Entrance;
using Google.Protobuf;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200513D RID: 20797
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PhantomArenaGuideController : ActivityControllerBase
	{
		// Token: 0x0603517B RID: 217467 RVA: 0x00C94453 File Offset: 0x00C92653
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603517C RID: 217468 RVA: 0x00C94455 File Offset: 0x00C92655
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_SoundRemnantArenaMainNew";
		}

		// Token: 0x0603517D RID: 217469 RVA: 0x00C9445C File Offset: 0x00C9265C
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new PhantomArenaGuideSubView();
		}

		// Token: 0x0603517E RID: 217470 RVA: 0x00C94463 File Offset: 0x00C92663
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new PhantomArenaGuideActivityData();
		}

		// Token: 0x0603517F RID: 217471 RVA: 0x00C9446A File Offset: 0x00C9266A
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06035180 RID: 217472 RVA: 0x00C94470 File Offset: 0x00C92670
		public static void RequestReward(int activityId)
		{
			PhantomBattleGuideRewardRequest message = PhantomBattleGuideRewardRequest.Create();
			Net.Instance.Call(ERequestMessageId.PhantomBattleGuideRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleGuideRewardResponse phantomBattleGuideRewardResponse = (PhantomBattleGuideRewardResponse)msg;
				if (phantomBattleGuideRewardResponse == null)
				{
					return;
				}
				if (phantomBattleGuideRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleGuideRewardResponse.ErrorCode, 23453, null, true, true);
					return;
				}
				PhantomArenaGuideActivityData phantomArenaGuideActivityData = ActivityModel.Instance.GetActivityById(activityId) as PhantomArenaGuideActivityData;
				if (phantomArenaGuideActivityData == null)
				{
					return;
				}
				phantomArenaGuideActivityData.UpdateReceiveState(true);
			}, 0);
		}

		// Token: 0x1700809E RID: 32926
		// (get) Token: 0x06035181 RID: 217473 RVA: 0x00C944AD File Offset: 0x00C926AD
		public static PhantomArenaGuideController Instance
		{
			get
			{
				return PhantomArenaGuideController._Instance;
			}
		}

		// Token: 0x06035182 RID: 217474 RVA: 0x00C944B4 File Offset: 0x00C926B4
		public static PhantomArenaGuideController GetOrCreateInstance()
		{
			if (PhantomArenaGuideController._Instance == null)
			{
				PhantomArenaGuideController.CreateInstance();
			}
			return PhantomArenaGuideController._Instance;
		}

		// Token: 0x06035183 RID: 217475 RVA: 0x00C944C8 File Offset: 0x00C926C8
		public static bool CreateInstance()
		{
			if (PhantomArenaGuideController._Instance != null)
			{
				return true;
			}
			PhantomArenaGuideController._Instance = new PhantomArenaGuideController();
			return true;
		}

		// Token: 0x06035184 RID: 217476 RVA: 0x00C944DE File Offset: 0x00C926DE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035185 RID: 217477 RVA: 0x00C944E0 File Offset: 0x00C926E0
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaGuideController._Instance = null;
		}

		// Token: 0x06035186 RID: 217478 RVA: 0x00C944E8 File Offset: 0x00C926E8
		static PhantomArenaGuideController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaGuideController.CreateStaticDefaultValue), new Action(PhantomArenaGuideController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C4DD RID: 115933
		[Nullable(2)]
		private static PhantomArenaGuideController _Instance;
	}
}
