using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Prepare.Entrance;
using Google.Protobuf;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200410D RID: 16653
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PhantomArenaGuideController : ActivityControllerBase
	{
		// Token: 0x0602A074 RID: 172148 RVA: 0x00BE1867 File Offset: 0x00BDFA67
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0602A075 RID: 172149 RVA: 0x00BE1869 File Offset: 0x00BDFA69
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_SoundRemnantArenaMainNew";
		}

		// Token: 0x0602A076 RID: 172150 RVA: 0x00BE1870 File Offset: 0x00BDFA70
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new PhantomArenaGuideSubView();
		}

		// Token: 0x0602A077 RID: 172151 RVA: 0x00BE1877 File Offset: 0x00BDFA77
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new PhantomArenaGuideActivityData();
		}

		// Token: 0x0602A078 RID: 172152 RVA: 0x00BE187E File Offset: 0x00BDFA7E
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0602A079 RID: 172153 RVA: 0x00BE1884 File Offset: 0x00BDFA84
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleGuideRewardResponse.ErrorCode, 21038, null, true, true);
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

		// Token: 0x1700545E RID: 21598
		// (get) Token: 0x0602A07A RID: 172154 RVA: 0x00BE18C1 File Offset: 0x00BDFAC1
		public static PhantomArenaGuideController Instance
		{
			get
			{
				return PhantomArenaGuideController._Instance;
			}
		}

		// Token: 0x0602A07B RID: 172155 RVA: 0x00BE18C8 File Offset: 0x00BDFAC8
		public static PhantomArenaGuideController GetOrCreateInstance()
		{
			if (PhantomArenaGuideController._Instance == null)
			{
				PhantomArenaGuideController.CreateInstance();
			}
			return PhantomArenaGuideController._Instance;
		}

		// Token: 0x0602A07C RID: 172156 RVA: 0x00BE18DC File Offset: 0x00BDFADC
		public static bool CreateInstance()
		{
			if (PhantomArenaGuideController._Instance != null)
			{
				return true;
			}
			PhantomArenaGuideController._Instance = new PhantomArenaGuideController();
			return true;
		}

		// Token: 0x0602A07D RID: 172157 RVA: 0x00BE18F2 File Offset: 0x00BDFAF2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602A07E RID: 172158 RVA: 0x00BE18F4 File Offset: 0x00BDFAF4
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaGuideController._Instance = null;
		}

		// Token: 0x0602A07F RID: 172159 RVA: 0x00BE18FC File Offset: 0x00BDFAFC
		static PhantomArenaGuideController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaGuideController.CreateStaticDefaultValue), new Action(PhantomArenaGuideController.ResetStaticDefaultValue));
		}

		// Token: 0x04016F12 RID: 93970
		[Nullable(2)]
		private static PhantomArenaGuideController _Instance;
	}
}
