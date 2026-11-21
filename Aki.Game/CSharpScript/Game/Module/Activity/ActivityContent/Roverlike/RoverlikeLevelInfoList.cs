using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050DE RID: 20702
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLevelInfoList
	{
		// Token: 0x06033CCE RID: 212174 RVA: 0x00E7F6C0 File Offset: 0x00E7D8C0
		public RoverlikeLevelInfoList(UUIScrollViewWithScrollbarComponent scrollView)
		{
			UUILayoutBase layout = scrollView.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			this.InfoLayout = new GenericLayout<RoverlikeLevelInfoItem, RoverlikeLevelInfoItemData>(layout, () => new RoverlikeLevelInfoItem(), null, false, true);
		}

		// Token: 0x06033CCF RID: 212175 RVA: 0x00E7F728 File Offset: 0x00E7D928
		public void RefreshByConfig(RoverRogueIns? cfg)
		{
			List<RoverlikeLevelInfoItemData> list = this.BuildInfoDataList(cfg);
			List<int> changedIndexList = this.DiffInfoDataList(this.LastInfoDataList, list);
			this.LastInfoDataList = list;
			this.InfoLayout.RefreshByData(list, delegate
			{
				this.PlayInfoItemRefreshAnim(changedIndexList);
			}, false);
		}

		// Token: 0x06033CD0 RID: 212176 RVA: 0x00E7F780 File Offset: 0x00E7D980
		private List<RoverlikeLevelInfoItemData> BuildInfoDataList(RoverRogueIns? cfg)
		{
			List<RoverlikeLevelInfoItemData> list = new List<RoverlikeLevelInfoItemData>();
			if (cfg == null)
			{
				return list;
			}
			RoverRogueIns value = cfg.Value;
			list.Add(new RoverlikeLevelInfoItemData
			{
				TextId = value.LevelRoomNumDesc,
				Params = (value.GetLevelRoomNumParamArray() ?? Array.Empty<int>())
			});
			list.Add(new RoverlikeLevelInfoItemData
			{
				TextId = value.LevelMonsterRateDesc,
				Params = (value.GetLevelMonsterRateParamArray() ?? Array.Empty<int>())
			});
			list.Add(new RoverlikeLevelInfoItemData
			{
				TextId = value.LevelRewardRateDesc,
				Params = (value.GetLevelRewardRateParamArray() ?? Array.Empty<int>())
			});
			for (int i = 0; i < value.LevelDetailDescLength; i++)
			{
				IntArray? intArray = value.LevelDetailParam(i);
				list.Add(new RoverlikeLevelInfoItemData
				{
					TextId = value.LevelDetailDesc(i),
					Params = (((intArray != null) ? intArray.GetValueOrDefault().GetArrayIntArray() : null) ?? Array.Empty<int>())
				});
			}
			return list;
		}

		// Token: 0x06033CD1 RID: 212177 RVA: 0x00E7F890 File Offset: 0x00E7DA90
		private List<int> DiffInfoDataList(IReadOnlyList<RoverlikeLevelInfoItemData> oldList, IReadOnlyList<RoverlikeLevelInfoItemData> newList)
		{
			List<int> list = new List<int>();
			if (oldList.Count == 0)
			{
				return list;
			}
			for (int i = 0; i < newList.Count; i++)
			{
				RoverlikeLevelInfoItemData roverlikeLevelInfoItemData = newList[i];
				RoverlikeLevelInfoItemData roverlikeLevelInfoItemData2 = (i < oldList.Count) ? oldList[i] : null;
				if (roverlikeLevelInfoItemData2 == null || roverlikeLevelInfoItemData2.TextId != roverlikeLevelInfoItemData.TextId || !this.IsNumberArrayEqual(roverlikeLevelInfoItemData2.Params, roverlikeLevelInfoItemData.Params))
				{
					list.Add(i);
				}
			}
			return list;
		}

		// Token: 0x06033CD2 RID: 212178 RVA: 0x00E7F90C File Offset: 0x00E7DB0C
		private bool IsNumberArrayEqual(IReadOnlyList<int> a, IReadOnlyList<int> b)
		{
			if (a.Count != b.Count)
			{
				return false;
			}
			for (int i = 0; i < a.Count; i++)
			{
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06033CD3 RID: 212179 RVA: 0x00E7F950 File Offset: 0x00E7DB50
		private void PlayInfoItemRefreshAnim(IReadOnlyList<int> changedIndexList)
		{
			foreach (int index in changedIndexList)
			{
				RoverlikeLevelInfoItem layoutItemByIndex = this.InfoLayout.GetLayoutItemByIndex(index);
				if (layoutItemByIndex != null)
				{
					layoutItemByIndex.PlayRefreshAnim();
				}
			}
		}

		// Token: 0x0401B721 RID: 112417
		private readonly GenericLayout<RoverlikeLevelInfoItem, RoverlikeLevelInfoItemData> InfoLayout;

		// Token: 0x0401B722 RID: 112418
		private List<RoverlikeLevelInfoItemData> LastInfoDataList = new List<RoverlikeLevelInfoItemData>();
	}
}
