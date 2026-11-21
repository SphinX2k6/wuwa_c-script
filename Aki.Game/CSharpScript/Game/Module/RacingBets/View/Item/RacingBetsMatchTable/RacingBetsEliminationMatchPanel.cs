using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02003EEF RID: 16111
	public class RacingBetsEliminationMatchPanel : UiPanelBase
	{
		// Token: 0x06028E05 RID: 167429 RVA: 0x00B7851C File Offset: 0x00B7671C
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

		// Token: 0x06028E06 RID: 167430 RVA: 0x00B78684 File Offset: 0x00B76884
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x06028E07 RID: 167431 RVA: 0x00B786A0 File Offset: 0x00B768A0
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsEliminationMatchPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsEliminationMatchPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028E08 RID: 167432 RVA: 0x00B786E4 File Offset: 0x00B768E4
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			RacingBetsEliminationMatchPanel.<OnBeforeShowAsyncImplement>d__10 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RacingBetsEliminationMatchPanel.<OnBeforeShowAsyncImplement>d__10>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06028E09 RID: 167433 RVA: 0x00B78728 File Offset: 0x00B76928
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

		// Token: 0x06028E0A RID: 167434 RVA: 0x00B78790 File Offset: 0x00B76990
		public UniTask PlayAnim()
		{
			RacingBetsEliminationMatchPanel.<PlayAnim>d__12 <PlayAnim>d__;
			<PlayAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAnim>d__.<>4__this = this;
			<PlayAnim>d__.<>1__state = -1;
			<PlayAnim>d__.<>t__builder.Start<RacingBetsEliminationMatchPanel.<PlayAnim>d__12>(ref <PlayAnim>d__);
			return <PlayAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06028E0B RID: 167435 RVA: 0x00B787D4 File Offset: 0x00B769D4
		public void ResetItemAlpha()
		{
			foreach (RacingBetsMatchItemBase racingBetsMatchItemBase in this.MatchItemList)
			{
				racingBetsMatchItemBase.GetRootItem().Alpha = 0f;
			}
		}

		// Token: 0x04016384 RID: 91012
		private const int GROUP_MATCH_NUM = 7;

		// Token: 0x04016385 RID: 91013
		private const int ADVANCED_INDEX = 5;

		// Token: 0x04016386 RID: 91014
		private const int FAILURE_INDEX1 = 2;

		// Token: 0x04016387 RID: 91015
		private const int FAILURE_INDEX2 = 4;

		// Token: 0x04016388 RID: 91016
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x04016389 RID: 91017
		[Nullable(1)]
		private readonly List<RacingBetsMatchItemBase> MatchItemList = new List<RacingBetsMatchItemBase>();

		// Token: 0x02009AA3 RID: 39587
		private class EComponent
		{
			// Token: 0x040302ED RID: 197357
			public const int ItemLine1 = 0;

			// Token: 0x040302EE RID: 197358
			public const int ItemLine2 = 1;

			// Token: 0x040302EF RID: 197359
			public const int ItemLine3 = 2;

			// Token: 0x040302F0 RID: 197360
			public const int ItemLine4 = 3;

			// Token: 0x040302F1 RID: 197361
			public const int ItemLine5 = 4;

			// Token: 0x040302F2 RID: 197362
			public const int ItemPos1 = 5;

			// Token: 0x040302F3 RID: 197363
			public const int ItemPos2 = 6;

			// Token: 0x040302F4 RID: 197364
			public const int ItemPos3 = 7;

			// Token: 0x040302F5 RID: 197365
			public const int ItemPos4 = 8;

			// Token: 0x040302F6 RID: 197366
			public const int ItemPos5 = 9;

			// Token: 0x040302F7 RID: 197367
			public const int ItemPos6 = 10;

			// Token: 0x040302F8 RID: 197368
			public const int ItemPos7 = 11;

			// Token: 0x040302F9 RID: 197369
			public const int ScrollView = 12;

			// Token: 0x040302FA RID: 197370
			public const int Content = 13;

			// Token: 0x040302FB RID: 197371
			public const int ItemLeftIcon = 14;

			// Token: 0x040302FC RID: 197372
			public const int ItemRightIcon = 15;
		}
	}
}
