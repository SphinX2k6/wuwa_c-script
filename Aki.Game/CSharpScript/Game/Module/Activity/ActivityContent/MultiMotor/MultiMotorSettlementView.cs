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
	// Token: 0x0200531C RID: 21276
	[NullableContext(2)]
	[Nullable(0)]
	public class MultiMotorSettlementView : UiTickViewBase
	{
		// Token: 0x06034EFB RID: 216827 RVA: 0x00ECDFA9 File Offset: 0x00ECC1A9
		[NullableContext(1)]
		public MultiMotorSettlementView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034EFC RID: 216828 RVA: 0x00ECDFB4 File Offset: 0x00ECC1B4
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

		// Token: 0x06034EFD RID: 216829 RVA: 0x00ECE144 File Offset: 0x00ECC344
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorSettlementView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorSettlementView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034EFE RID: 216830 RVA: 0x00ECE188 File Offset: 0x00ECC388
		protected override void OnStart()
		{
			string textStringId = CreatureModel.Instance.IsMyWorld() ? "Text_ContinueChallenge_Text" : "Text_SuggestContinueChallenge_Text";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, Array.Empty<object>());
			this.InitAutoLeaveTimer();
		}

		// Token: 0x06034EFF RID: 216831 RVA: 0x00ECE1CB File Offset: 0x00ECC3CB
		protected override void OnBeforeDestroy()
		{
			this.ClearAutoLeaveTimer();
		}

		// Token: 0x06034F00 RID: 216832 RVA: 0x00ECE1D4 File Offset: 0x00ECC3D4
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

		// Token: 0x06034F01 RID: 216833 RVA: 0x00ECE222 File Offset: 0x00ECC422
		private void ClearAutoLeaveTimer()
		{
			if (this.AutoLeaveTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
			}
			this.AutoLeaveTimerId = null;
		}

		// Token: 0x06034F02 RID: 216834 RVA: 0x00ECE258 File Offset: 0x00ECC458
		private void OnClickLeftBtn()
		{
			OnlineController.Instance.LeaveWorldTeamRequest(PlayerInfoModel.Instance.GetId().GetValueOrDefault(), null);
		}

		// Token: 0x06034F03 RID: 216835 RVA: 0x00ECE28A File Offset: 0x00ECC48A
		private void OnClickRightBtn()
		{
			InstanceDungeonEntranceController.Instance.SettleViewButtonSuccessOnMultiCallBack(0);
		}

		// Token: 0x06034F04 RID: 216836 RVA: 0x00ECE298 File Offset: 0x00ECC498
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

		// Token: 0x0401BFDE RID: 114654
		[Nullable(1)]
		public const string ABSOLUTE_RULE_CONST = "MultiMotor_Rank_1_AbsoluteRule_Tag";

		// Token: 0x0401BFDF RID: 114655
		[Nullable(1)]
		public const string DESTROYER_CONST = "MultiMotor_Rank_1_Destroyer_Tag";

		// Token: 0x0401BFE0 RID: 114656
		private const int AUTO_LEAVE_TIME = 300;

		// Token: 0x0401BFE1 RID: 114657
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, OnlineMotorSettleInfo> SettlementDataMap;

		// Token: 0x0401BFE2 RID: 114658
		private MultiMotorSettlementPlayerItem ChampionItem;

		// Token: 0x0401BFE3 RID: 114659
		private MultiMotorSettlementPlayerItem SecondItem;

		// Token: 0x0401BFE4 RID: 114660
		private MultiMotorSettlementPlayerItem ThirdItem;

		// Token: 0x0401BFE5 RID: 114661
		private RewardExploreOnlineChallengePlayer RewardExploreOnlineChallengePlayerInst;

		// Token: 0x0401BFE6 RID: 114662
		private TimerHandle AutoLeaveTimerId;

		// Token: 0x0200AF9F RID: 44959
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403647F RID: 222335
			public const int ChampionItem = 0;

			// Token: 0x04036480 RID: 222336
			public const int SecondItem = 1;

			// Token: 0x04036481 RID: 222337
			public const int ThirdItem = 2;

			// Token: 0x04036482 RID: 222338
			public const int LeftBtn = 3;

			// Token: 0x04036483 RID: 222339
			public const int LeftBtnText = 4;

			// Token: 0x04036484 RID: 222340
			public const int RightBtn = 5;

			// Token: 0x04036485 RID: 222341
			public const int RightBtnText = 6;

			// Token: 0x04036486 RID: 222342
			public const int ItemTeam = 7;
		}
	}
}
