using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053DC RID: 21468
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MoonSignInController : ActivityControllerBase
	{
		// Token: 0x060355E6 RID: 218598 RVA: 0x00EE7D47 File Offset: 0x00EE5F47
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060355E7 RID: 218599 RVA: 0x00EE7D49 File Offset: 0x00EE5F49
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMoonPhase";
		}

		// Token: 0x060355E8 RID: 218600 RVA: 0x00EE7D50 File Offset: 0x00EE5F50
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new MoonSignInSubView();
		}

		// Token: 0x060355E9 RID: 218601 RVA: 0x00EE7D57 File Offset: 0x00EE5F57
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new MoonSignInData();
		}

		// Token: 0x060355EA RID: 218602 RVA: 0x00EE7D6A File Offset: 0x00EE5F6A
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemNotify, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddSpecialItem));
		}

		// Token: 0x060355EB RID: 218603 RVA: 0x00EE7D88 File Offset: 0x00EE5F88
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAddCommonItemNotify, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddSpecialItem));
		}

		// Token: 0x060355EC RID: 218604 RVA: 0x00EE7DA6 File Offset: 0x00EE5FA6
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060355ED RID: 218605 RVA: 0x00EE7DA9 File Offset: 0x00EE5FA9
		[NullableContext(2)]
		public MoonSignInData GetData()
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId) as MoonSignInData;
		}

		// Token: 0x060355EE RID: 218606 RVA: 0x00EE7DC0 File Offset: 0x00EE5FC0
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(moonPhaseRandomResponse.ErrorCode, 18392, null, true, true);
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

		// Token: 0x060355EF RID: 218607 RVA: 0x00EE7E04 File Offset: 0x00EE6004
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(moonPhaseRewardResponse.ErrorCode, 15018, null, true, true);
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

		// Token: 0x060355F0 RID: 218608 RVA: 0x00EE7E48 File Offset: 0x00EE6048
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

		// Token: 0x170067EA RID: 26602
		// (get) Token: 0x060355F1 RID: 218609 RVA: 0x00EE7EB8 File Offset: 0x00EE60B8
		public static MoonSignInController Instance
		{
			get
			{
				return MoonSignInController._Instance;
			}
		}

		// Token: 0x060355F2 RID: 218610 RVA: 0x00EE7EBF File Offset: 0x00EE60BF
		public static MoonSignInController GetOrCreateInstance()
		{
			if (MoonSignInController._Instance == null)
			{
				MoonSignInController.CreateInstance();
			}
			return MoonSignInController._Instance;
		}

		// Token: 0x060355F3 RID: 218611 RVA: 0x00EE7ED3 File Offset: 0x00EE60D3
		public static bool CreateInstance()
		{
			if (MoonSignInController._Instance != null)
			{
				return true;
			}
			MoonSignInController._Instance = new MoonSignInController();
			return true;
		}

		// Token: 0x060355F4 RID: 218612 RVA: 0x00EE7EE9 File Offset: 0x00EE60E9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060355F5 RID: 218613 RVA: 0x00EE7EEB File Offset: 0x00EE60EB
		public static void ResetStaticDefaultValue()
		{
			MoonSignInController._Instance = null;
		}

		// Token: 0x060355F6 RID: 218614 RVA: 0x00EE7EF3 File Offset: 0x00EE60F3
		static MoonSignInController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoonSignInController.CreateStaticDefaultValue), new Action(MoonSignInController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C26F RID: 115311
		private int ActivityId;

		// Token: 0x0401C270 RID: 115312
		[Nullable(2)]
		private static MoonSignInController _Instance;
	}
}
