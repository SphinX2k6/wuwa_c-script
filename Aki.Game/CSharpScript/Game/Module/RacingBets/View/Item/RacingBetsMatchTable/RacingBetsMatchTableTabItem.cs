using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02004F2B RID: 20267
	public class RacingBetsMatchTableTabItem : GridProxyAbstract<ERacingBetsMatchTableType>
	{
		// Token: 0x06033FBA RID: 212922 RVA: 0x00C2FD00 File Offset: 0x00C2DF00
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

		// Token: 0x06033FBB RID: 212923 RVA: 0x00C2FD94 File Offset: 0x00C2DF94
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

		// Token: 0x06033FBC RID: 212924 RVA: 0x00C2FF5C File Offset: 0x00C2E15C
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06033FBD RID: 212925 RVA: 0x00C2FF82 File Offset: 0x00C2E182
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06033FBE RID: 212926 RVA: 0x00C2FF8B File Offset: 0x00C2E18B
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x06033FBF RID: 212927 RVA: 0x00C2FF94 File Offset: 0x00C2E194
		[NullableContext(1)]
		public override object GetKey(ERacingBetsMatchTableType data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06033FC0 RID: 212928 RVA: 0x00C2FF9C File Offset: 0x00C2E19C
		private void OnClickToggle(EToggleState state)
		{
			Action<ERacingBetsMatchTableType> onToggleCallBack = this.OnToggleCallBack;
			if (onToggleCallBack == null)
			{
				return;
			}
			onToggleCallBack(this.MatchTableType);
		}

		// Token: 0x0401B9C3 RID: 113091
		private ERacingBetsMatchTableType MatchTableType = ERacingBetsMatchTableType.GroupMatch;

		// Token: 0x0401B9C4 RID: 113092
		[Nullable(2)]
		public Action<ERacingBetsMatchTableType> OnToggleCallBack;

		// Token: 0x0200B082 RID: 45186
		private class EComponent
		{
			// Token: 0x04035928 RID: 219432
			public const int ToggleRoot = 0;

			// Token: 0x04035929 RID: 219433
			public const int TextName = 1;

			// Token: 0x0403592A RID: 219434
			public const int TextDate = 2;

			// Token: 0x0403592B RID: 219435
			public const int ItemRacing = 3;
		}
	}
}
