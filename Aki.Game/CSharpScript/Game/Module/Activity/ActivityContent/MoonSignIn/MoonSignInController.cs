using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x0200645E RID: 25694
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MoonSignInController : ActivityControllerBase
	{
		// Token: 0x06040925 RID: 264485 RVA: 0x00FA0DCB File Offset: 0x00F9EFCB
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06040926 RID: 264486 RVA: 0x00FA0DCD File Offset: 0x00F9EFCD
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMoonPhase";
		}

		// Token: 0x06040927 RID: 264487 RVA: 0x00FA0DD4 File Offset: 0x00F9EFD4
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new MoonSignInSubView();
		}

		// Token: 0x06040928 RID: 264488 RVA: 0x00FA0DDB File Offset: 0x00F9EFDB
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new MoonSignInData();
		}

		// Token: 0x06040929 RID: 264489 RVA: 0x00FA0DEE File Offset: 0x00F9EFEE
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemNotify, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddSpecialItem));
		}

		// Token: 0x0604092A RID: 264490 RVA: 0x00FA0E0C File Offset: 0x00F9F00C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAddCommonItemNotify, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddSpecialItem));
		}

		// Token: 0x0604092B RID: 264491 RVA: 0x00FA0E2A File Offset: 0x00F9F02A
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0604092C RID: 264492 RVA: 0x00FA0E2D File Offset: 0x00F9F02D
		[NullableContext(2)]
		public MoonSignInData GetData()
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId) as MoonSignInData;
		}

		// Token: 0x0604092D RID: 264493 RVA: 0x00FA0E44 File Offset: 0x00F9F044
		public void MoonPhaseRandomRequest(int activityId)
		{
			MoonPhaseRandomRequest message = Aki.Protocol.MoonPhaseRandomRequest.Create();
			Net.Instance.Call(ERequestMessageId.MoonPhaseRandomRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MoonPhaseRandomResponse moonPhaseRandomResponse = (MoonPhaseRandomResponse)msg;
				if (moonPhaseRandomResponse == null)
				{
					return;
				}
				if (moonPhaseRandomResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(moonPhaseRandomResponse.ErrorCode, 27423, null, true, true);
					return;
				}
				MoonSignInData data = this.GetData();
				if (moonPhaseRandomResponse.Result != null && data != null)
				{
					data.HaveSelectMoonPhaseSelectList.Add(moonPhaseRandomResponse.Result);
					data.SelectMoonPhaseList.Add(moonPhaseRandomResponse.Result.MoonPhaseId);
					data.CurrentMoonId = moonPhaseRandomResponse.Result.MoonPhaseId;
				}
				MoonSignInDetailViewOpenData param = new MoonSignInDetailViewOpenData
				{
					MoonId = moonPhaseRandomResponse.Result.MoonPhaseId,
					Wishing = new bool?(true)
				};
				UiManager.Instance.OpenView(EUiViewName.MoonSignInDetailView, param, null);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
			}, 0);
		}

		// Token: 0x0604092E RID: 264494 RVA: 0x00FA0E88 File Offset: 0x00F9F088
		public void MoonPhaseRewardRequest(int activityId)
		{
			MoonPhaseRewardRequest message = Aki.Protocol.MoonPhaseRewardRequest.Create();
			Net.Instance.Call(ERequestMessageId.MoonPhaseRewardRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MoonPhaseRewardResponse moonPhaseRewardResponse = (MoonPhaseRewardResponse)msg;
				if (moonPhaseRewardResponse == null)
				{
					return;
				}
				if (moonPhaseRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(moonPhaseRewardResponse.ErrorCode, 20673, null, true, true);
				}
				MoonSignInData data = this.GetData();
				if (data != null)
				{
					data.MoonGrandReward = true;
				}
				EventSystem.Instance.Emit(EEventName.MoonSignRewardRefresh);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
			}, 0);
		}

		// Token: 0x0604092F RID: 264495 RVA: 0x00FA0ECC File Offset: 0x00F9F0CC
		private void OnAddSpecialItem(IReadOnlyList<IProto_NormalItem> itemList)
		{
			MoonSignInData data = this.GetData();
			if (data == null)
			{
				return;
			}
			using (IEnumerator<IProto_NormalItem> enumerator = itemList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Id == data.UseItemId)
					{
						EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, data.Id);
					}
				}
			}
		}

		// Token: 0x17009488 RID: 38024
		// (get) Token: 0x06040930 RID: 264496 RVA: 0x00FA0F3C File Offset: 0x00F9F13C
		public static MoonSignInController Instance
		{
			get
			{
				return MoonSignInController._Instance;
			}
		}

		// Token: 0x06040931 RID: 264497 RVA: 0x00FA0F43 File Offset: 0x00F9F143
		public static MoonSignInController GetOrCreateInstance()
		{
			if (MoonSignInController._Instance == null)
			{
				MoonSignInController.CreateInstance();
			}
			return MoonSignInController._Instance;
		}

		// Token: 0x06040932 RID: 264498 RVA: 0x00FA0F57 File Offset: 0x00F9F157
		public static bool CreateInstance()
		{
			if (MoonSignInController._Instance != null)
			{
				return true;
			}
			MoonSignInController._Instance = new MoonSignInController();
			return true;
		}

		// Token: 0x06040933 RID: 264499 RVA: 0x00FA0F6D File Offset: 0x00F9F16D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040934 RID: 264500 RVA: 0x00FA0F6F File Offset: 0x00F9F16F
		public static void ResetStaticDefaultValue()
		{
			MoonSignInController._Instance = null;
		}

		// Token: 0x06040935 RID: 264501 RVA: 0x00FA0F77 File Offset: 0x00F9F177
		static MoonSignInController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoonSignInController.CreateStaticDefaultValue), new Action(MoonSignInController.ResetStaticDefaultValue));
		}

		// Token: 0x04021940 RID: 137536
		private int ActivityId;

		// Token: 0x04021941 RID: 137537
		[Nullable(2)]
		private static MoonSignInController _Instance;
	}
}
