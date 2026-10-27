using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02004F26 RID: 20262
	public class RacingBetsEliminationMatchPanel : UiPanelBase
	{
		// Token: 0x06033F97 RID: 212887 RVA: 0x00C2ED74 File Offset: 0x00C2CF74
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
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem))
			};
		}

		// Token: 0x06033F98 RID: 212888 RVA: 0x00C2EEDC File Offset: 0x00C2D0DC
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x06033F99 RID: 212889 RVA: 0x00C2EEF8 File Offset: 0x00C2D0F8
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsEliminationMatchPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsEliminationMatchPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033F9A RID: 212890 RVA: 0x00C2EF3C File Offset: 0x00C2D13C
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			RacingBetsEliminationMatchPanel.<OnBeforeShowAsyncImplement>d__10 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RacingBetsEliminationMatchPanel.<OnBeforeShowAsyncImplement>d__10>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06033F9B RID: 212891 RVA: 0x00C2EF80 File Offset: 0x00C2D180
		private void RefreshLine()
		{
			int[] groupMatchListArray = RacingBetsConfig.Instance.GetMatchTableConfigById(2).Value.GetGroupMatchListArray();
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

		// Token: 0x06033F9C RID: 212892 RVA: 0x00C2EFE8 File Offset: 0x00C2D1E8
		public UniTask PlayAnim()
		{
			RacingBetsEliminationMatchPanel.<PlayAnim>d__12 <PlayAnim>d__;
			<PlayAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAnim>d__.<>4__this = this;
			<PlayAnim>d__.<>1__state = -1;
			<PlayAnim>d__.<>t__builder.Start<RacingBetsEliminationMatchPanel.<PlayAnim>d__12>(ref <PlayAnim>d__);
			return <PlayAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06033F9D RID: 212893 RVA: 0x00C2F02C File Offset: 0x00C2D22C
		public void ResetItemAlpha()
		{
			foreach (RacingBetsMatchItemBase racingBetsMatchItemBase in this.MatchItemList)
			{
				racingBetsMatchItemBase.GetRootItem().Alpha = 0f;
			}
		}

		// Token: 0x0401B9AF RID: 113071
		private const int GROUP_MATCH_NUM = 7;

		// Token: 0x0401B9B0 RID: 113072
		private const int ADVANCED_INDEX = 5;

		// Token: 0x0401B9B1 RID: 113073
		private const int FAILURE_INDEX1 = 2;

		// Token: 0x0401B9B2 RID: 113074
		private const int FAILURE_INDEX2 = 4;

		// Token: 0x0401B9B3 RID: 113075
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x0401B9B4 RID: 113076
		[Nullable(1)]
		private readonly List<RacingBetsMatchItemBase> MatchItemList = new List<RacingBetsMatchItemBase>();

		// Token: 0x0200B073 RID: 45171
		private class EComponent
		{
			// Token: 0x040358C2 RID: 219330
			public const int ItemLine1 = 0;

			// Token: 0x040358C3 RID: 219331
			public const int ItemLine2 = 1;

			// Token: 0x040358C4 RID: 219332
			public const int ItemLine3 = 2;

			// Token: 0x040358C5 RID: 219333
			public const int ItemLine4 = 3;

			// Token: 0x040358C6 RID: 219334
			public const int ItemLine5 = 4;

			// Token: 0x040358C7 RID: 219335
			public const int ItemPos1 = 5;

			// Token: 0x040358C8 RID: 219336
			public const int ItemPos2 = 6;

			// Token: 0x040358C9 RID: 219337
			public const int ItemPos3 = 7;

			// Token: 0x040358CA RID: 219338
			public const int ItemPos4 = 8;

			// Token: 0x040358CB RID: 219339
			public const int ItemPos5 = 9;

			// Token: 0x040358CC RID: 219340
			public const int ItemPos6 = 10;

			// Token: 0x040358CD RID: 219341
			public const int ItemPos7 = 11;

			// Token: 0x040358CE RID: 219342
			public const int ScrollView = 12;

			// Token: 0x040358CF RID: 219343
			public const int Content = 13;

			// Token: 0x040358D0 RID: 219344
			public const int ItemLeftIcon = 14;

			// Token: 0x040358D1 RID: 219345
			public const int ItemRightIcon = 15;
		}
	}
}
