using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02003EF4 RID: 16116
	public class RacingBetsMatchTableTabItem : GridProxyAbstract<ERacingBetsMatchTableType>
	{
		// Token: 0x06028E28 RID: 167464 RVA: 0x00B794A8 File Offset: 0x00B776A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x06028E29 RID: 167465 RVA: 0x00B7953C File Offset: 0x00B7773C
		public override void Refresh(ERacingBetsMatchTableType data, bool isSelected, int gridIndex)
		{
			this.MatchTableType = data;
			RacingBetsMatch? matchTableConfigById = RacingBetsConfig.Instance.GetMatchTableConfigById((int)data);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), matchTableConfigById.Value.Name, Array.Empty<object>());
			int[] groupMatchListArray = matchTableConfigById.Value.GetGroupMatchListArray();
			long num = 0L;
			long num2 = 0L;
			foreach (int matchId in groupMatchListArray)
			{
				ValueTuple<long, long> timeRange = RacingBetsModel.Instance.GetRacingBetsGroupMatchData(matchId).GetTimeRange();
				long item = timeRange.Item1;
				long item2 = timeRange.Item2;
				if (num == 0L || item < num)
				{
					num = item;
				}
				if (num2 == 0L || item2 > num2)
				{
					num2 = item2;
				}
			}
			string text = TimeUtil.Instance.DateFormat6String((double)num);
			string text2 = TimeUtil.Instance.DateFormat6String((double)num2);
			if (text == text2)
			{
				UUIText text3 = base.GetText(2);
				if (text3 != null)
				{
					text3.SetText(text, true);
				}
			}
			else
			{
				UUIText text4 = base.GetText(2);
				if (text4 != null)
				{
					text4.SetText(text + "-" + text2, true);
				}
			}
			RacingBetsLegMatchData curLegMatchData = RacingBetsModel.Instance.GetRacingBetsSeasonData().GetCurLegMatchData();
			if (curLegMatchData != null)
			{
				List<int> list = new List<int>();
				foreach (int matchId2 in groupMatchListArray)
				{
					foreach (RacingBetsLegMatchData racingBetsLegMatchData in RacingBetsModel.Instance.GetRacingBetsGroupMatchData(matchId2).GetLegMatchList())
					{
						list.Add(racingBetsLegMatchData.Id);
					}
				}
				bool uiactive = list.Contains(curLegMatchData.Id);
				UUIItem item3 = base.GetItem(3);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(uiactive);
			}
		}

		// Token: 0x06028E2A RID: 167466 RVA: 0x00B79704 File Offset: 0x00B77904
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06028E2B RID: 167467 RVA: 0x00B7972A File Offset: 0x00B7792A
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06028E2C RID: 167468 RVA: 0x00B79733 File Offset: 0x00B77933
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x06028E2D RID: 167469 RVA: 0x00B7973C File Offset: 0x00B7793C
		[NullableContext(1)]
		public override object GetKey(ERacingBetsMatchTableType data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06028E2E RID: 167470 RVA: 0x00B79744 File Offset: 0x00B77944
		private void OnClickToggle(EToggleState state)
		{
			Action<ERacingBetsMatchTableType> onToggleCallBack = this.OnToggleCallBack;
			if (onToggleCallBack == null)
			{
				return;
			}
			onToggleCallBack(this.MatchTableType);
		}

		// Token: 0x04016398 RID: 91032
		private ERacingBetsMatchTableType MatchTableType = ERacingBetsMatchTableType.GroupMatch;

		// Token: 0x04016399 RID: 91033
		[Nullable(2)]
		public Action<ERacingBetsMatchTableType> OnToggleCallBack;

		// Token: 0x02009AB2 RID: 39602
		private class EComponent
		{
			// Token: 0x04030353 RID: 197459
			public const int ToggleRoot = 0;

			// Token: 0x04030354 RID: 197460
			public const int TextName = 1;

			// Token: 0x04030355 RID: 197461
			public const int TextDate = 2;

			// Token: 0x04030356 RID: 197462
			public const int ItemRacing = 3;
		}
	}
}
