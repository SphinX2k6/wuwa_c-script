using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02003EF1 RID: 16113
	public class RacingBetsGroupMatchPanel : UiPanelBase
	{
		// Token: 0x06028E14 RID: 167444 RVA: 0x00B78B74 File Offset: 0x00B76D74
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

		// Token: 0x06028E15 RID: 167445 RVA: 0x00B78C3C File Offset: 0x00B76E3C
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x06028E16 RID: 167446 RVA: 0x00B78C58 File Offset: 0x00B76E58
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsGroupMatchPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsGroupMatchPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028E17 RID: 167447 RVA: 0x00B78C9C File Offset: 0x00B76E9C
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			RacingBetsGroupMatchPanel.<OnBeforeShowAsyncImplement>d__8 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RacingBetsGroupMatchPanel.<OnBeforeShowAsyncImplement>d__8>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06028E18 RID: 167448 RVA: 0x00B78CE0 File Offset: 0x00B76EE0
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

		// Token: 0x06028E19 RID: 167449 RVA: 0x00B78D48 File Offset: 0x00B76F48
		public UniTask PlayAnim()
		{
			RacingBetsGroupMatchPanel.<PlayAnim>d__10 <PlayAnim>d__;
			<PlayAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAnim>d__.<>4__this = this;
			<PlayAnim>d__.<>1__state = -1;
			<PlayAnim>d__.<>t__builder.Start<RacingBetsGroupMatchPanel.<PlayAnim>d__10>(ref <PlayAnim>d__);
			return <PlayAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06028E1A RID: 167450 RVA: 0x00B78D8C File Offset: 0x00B76F8C
		public void ResetItemAlpha()
		{
			foreach (RacingBetsMatchItemBase racingBetsMatchItemBase in this.MatchItemList)
			{
				racingBetsMatchItemBase.GetRootItem().Alpha = 0f;
			}
		}

		// Token: 0x0401638D RID: 91021
		private const int GROUP_MATCH_NUM = 5;

		// Token: 0x0401638E RID: 91022
		private const int ADVANCED_INDEX = 3;

		// Token: 0x0401638F RID: 91023
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x04016390 RID: 91024
		[Nullable(1)]
		private readonly List<RacingBetsMatchItemBase> MatchItemList = new List<RacingBetsMatchItemBase>();

		// Token: 0x02009AAB RID: 39595
		private class EComponent
		{
			// Token: 0x04030325 RID: 197413
			public const int ItemLine1 = 0;

			// Token: 0x04030326 RID: 197414
			public const int ItemLine2 = 1;

			// Token: 0x04030327 RID: 197415
			public const int ItemLine3 = 2;

			// Token: 0x04030328 RID: 197416
			public const int ItemPos1 = 3;

			// Token: 0x04030329 RID: 197417
			public const int ItemPos2 = 4;

			// Token: 0x0403032A RID: 197418
			public const int ItemPos3 = 5;

			// Token: 0x0403032B RID: 197419
			public const int ItemPos4 = 6;

			// Token: 0x0403032C RID: 197420
			public const int ItemPos5 = 7;
		}
	}
}
