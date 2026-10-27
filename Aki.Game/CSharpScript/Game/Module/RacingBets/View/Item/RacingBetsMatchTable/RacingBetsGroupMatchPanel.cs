using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02004F28 RID: 20264
	public class RacingBetsGroupMatchPanel : UiPanelBase
	{
		// Token: 0x06033FA6 RID: 212902 RVA: 0x00C2F3CC File Offset: 0x00C2D5CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x06033FA7 RID: 212903 RVA: 0x00C2F494 File Offset: 0x00C2D694
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x06033FA8 RID: 212904 RVA: 0x00C2F4B0 File Offset: 0x00C2D6B0
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsGroupMatchPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsGroupMatchPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033FA9 RID: 212905 RVA: 0x00C2F4F4 File Offset: 0x00C2D6F4
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			RacingBetsGroupMatchPanel.<OnBeforeShowAsyncImplement>d__8 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RacingBetsGroupMatchPanel.<OnBeforeShowAsyncImplement>d__8>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06033FAA RID: 212906 RVA: 0x00C2F538 File Offset: 0x00C2D738
		private void RefreshLine()
		{
			int[] groupMatchListArray = RacingBetsConfig.Instance.GetMatchTableConfigById(1).Value.GetGroupMatchListArray();
			for (int i = 0; i < groupMatchListArray.Length - 1; i++)
			{
				RacingBetsGroupMatchData racingBetsGroupMatchData = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(groupMatchListArray[i]);
				int name = i;
				UUIItem item = base.GetItem(name);
				if (item != null)
				{
					item.SetUIActive(racingBetsGroupMatchData.IsGroupMatchFinished());
				}
			}
		}

		// Token: 0x06033FAB RID: 212907 RVA: 0x00C2F5A0 File Offset: 0x00C2D7A0
		public UniTask PlayAnim()
		{
			RacingBetsGroupMatchPanel.<PlayAnim>d__10 <PlayAnim>d__;
			<PlayAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAnim>d__.<>4__this = this;
			<PlayAnim>d__.<>1__state = -1;
			<PlayAnim>d__.<>t__builder.Start<RacingBetsGroupMatchPanel.<PlayAnim>d__10>(ref <PlayAnim>d__);
			return <PlayAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06033FAC RID: 212908 RVA: 0x00C2F5E4 File Offset: 0x00C2D7E4
		public void ResetItemAlpha()
		{
			foreach (RacingBetsMatchItemBase racingBetsMatchItemBase in this.MatchItemList)
			{
				racingBetsMatchItemBase.GetRootItem().Alpha = 0f;
			}
		}

		// Token: 0x0401B9B8 RID: 113080
		private const int GROUP_MATCH_NUM = 5;

		// Token: 0x0401B9B9 RID: 113081
		private const int ADVANCED_INDEX = 3;

		// Token: 0x0401B9BA RID: 113082
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x0401B9BB RID: 113083
		[Nullable(1)]
		private readonly List<RacingBetsMatchItemBase> MatchItemList = new List<RacingBetsMatchItemBase>();

		// Token: 0x0200B07B RID: 45179
		private class EComponent
		{
			// Token: 0x040358FA RID: 219386
			public const int ItemLine1 = 0;

			// Token: 0x040358FB RID: 219387
			public const int ItemLine2 = 1;

			// Token: 0x040358FC RID: 219388
			public const int ItemLine3 = 2;

			// Token: 0x040358FD RID: 219389
			public const int ItemPos1 = 3;

			// Token: 0x040358FE RID: 219390
			public const int ItemPos2 = 4;

			// Token: 0x040358FF RID: 219391
			public const int ItemPos3 = 5;

			// Token: 0x04035900 RID: 219392
			public const int ItemPos4 = 6;

			// Token: 0x04035901 RID: 219393
			public const int ItemPos5 = 7;
		}
	}
}
