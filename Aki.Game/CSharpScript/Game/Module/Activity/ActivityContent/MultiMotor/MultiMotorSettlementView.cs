using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200639E RID: 25502
	[NullableContext(2)]
	[Nullable(0)]
	public class MultiMotorSettlementView : UiTickViewBase
	{
		// Token: 0x0604023A RID: 262714 RVA: 0x00F87071 File Offset: 0x00F85271
		[NullableContext(1)]
		public MultiMotorSettlementView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604023B RID: 262715 RVA: 0x00F8707C File Offset: 0x00F8527C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeftBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickRightBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604023C RID: 262716 RVA: 0x00F8720C File Offset: 0x00F8540C
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorSettlementView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorSettlementView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604023D RID: 262717 RVA: 0x00F87250 File Offset: 0x00F85450
		protected override void OnStart()
		{
			string textStringId = CreatureModel.Instance.IsMyWorld() ? "Text_ContinueChallenge_Text" : "Text_SuggestContinueChallenge_Text";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, Array.Empty<object>());
			this.InitAutoLeaveTimer();
		}

		// Token: 0x0604023E RID: 262718 RVA: 0x00F87293 File Offset: 0x00F85493
		protected override void OnBeforeDestroy()
		{
			this.ClearAutoLeaveTimer();
		}

		// Token: 0x0604023F RID: 262719 RVA: 0x00F8729C File Offset: 0x00F8549C
		private void InitAutoLeaveTimer()
		{
			int leftSecondToAutoLeave = 300;
			this.AutoLeaveTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float elapsed)
			{
				int leftSecondToAutoLeave;
				if (leftSecondToAutoLeave <= 0)
				{
					this.ClearAutoLeaveTimer();
					OnlineController.Instance.LeaveWorldTeamRequest(PlayerInfoModel.Instance.GetId().GetValueOrDefault(), null);
					return;
				}
				LguiUtil instance = LguiUtil.Instance;
				UUIText text = this.GetText(4);
				string textStringId = "Text_InstanceDungeonLeftTimeToAutoLeave_Text";
				leftSecondToAutoLeave = leftSecondToAutoLeave;
				leftSecondToAutoLeave--;
				instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(leftSecondToAutoLeave.ToString()));
			}, 1000f, 1f, null, null, true);
		}

		// Token: 0x06040240 RID: 262720 RVA: 0x00F872EA File Offset: 0x00F854EA
		private void ClearAutoLeaveTimer()
		{
			if (this.AutoLeaveTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
			}
			this.AutoLeaveTimerId = null;
		}

		// Token: 0x06040241 RID: 262721 RVA: 0x00F87320 File Offset: 0x00F85520
		private void OnClickLeftBtn()
		{
			OnlineController.Instance.LeaveWorldTeamRequest(PlayerInfoModel.Instance.GetId().GetValueOrDefault(), null);
		}

		// Token: 0x06040242 RID: 262722 RVA: 0x00F87352 File Offset: 0x00F85552
		private void OnClickRightBtn()
		{
			InstanceDungeonEntranceController.Instance.SettleViewButtonSuccessOnMultiCallBack(0);
		}

		// Token: 0x06040243 RID: 262723 RVA: 0x00F87360 File Offset: 0x00F85560
		[CompilerGenerated]
		internal static OnlineMotorSettleInfo <OnBeforeStartAsync>g__FindByRank|12_0(int rank, ref MultiMotorSettlementView.<>c__DisplayClass12_0 A_1)
		{
			foreach (OnlineMotorSettleInfo onlineMotorSettleInfo in A_1.openData)
			{
				if (onlineMotorSettleInfo.Ranking == rank)
				{
					return onlineMotorSettleInfo;
				}
			}
			return null;
		}

		// Token: 0x040216AF RID: 136879
		[Nullable(1)]
		public const string ABSOLUTE_RULE_CONST = "MultiMotor_Rank_1_AbsoluteRule_Tag";

		// Token: 0x040216B0 RID: 136880
		[Nullable(1)]
		public const string DESTROYER_CONST = "MultiMotor_Rank_1_Destroyer_Tag";

		// Token: 0x040216B1 RID: 136881
		private const int AUTO_LEAVE_TIME = 300;

		// Token: 0x040216B2 RID: 136882
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, OnlineMotorSettleInfo> SettlementDataMap;

		// Token: 0x040216B3 RID: 136883
		private MultiMotorSettlementPlayerItem ChampionItem;

		// Token: 0x040216B4 RID: 136884
		private MultiMotorSettlementPlayerItem SecondItem;

		// Token: 0x040216B5 RID: 136885
		private MultiMotorSettlementPlayerItem ThirdItem;

		// Token: 0x040216B6 RID: 136886
		private RewardExploreOnlineChallengePlayer RewardExploreOnlineChallengePlayerInst;

		// Token: 0x040216B7 RID: 136887
		private TimerHandle AutoLeaveTimerId;

		// Token: 0x0200C5B8 RID: 50616
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BB20 RID: 244512
			public const int ChampionItem = 0;

			// Token: 0x0403BB21 RID: 244513
			public const int SecondItem = 1;

			// Token: 0x0403BB22 RID: 244514
			public const int ThirdItem = 2;

			// Token: 0x0403BB23 RID: 244515
			public const int LeftBtn = 3;

			// Token: 0x0403BB24 RID: 244516
			public const int LeftBtnText = 4;

			// Token: 0x0403BB25 RID: 244517
			public const int RightBtn = 5;

			// Token: 0x0403BB26 RID: 244518
			public const int RightBtnText = 6;

			// Token: 0x0403BB27 RID: 244519
			public const int ItemTeam = 7;
		}
	}
}
