using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006160 RID: 24928
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLevelInfoList
	{
		// Token: 0x0603F00E RID: 258062 RVA: 0x00F387EC File Offset: 0x00F369EC
		public RoverlikeLevelInfoList(UUIScrollViewWithScrollbarComponent scrollView)
		{
			UUILayoutBase layout = scrollView.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			this.InfoLayout = new GenericLayout<RoverlikeLevelInfoItem, RoverlikeLevelInfoItemData>(layout, () => new RoverlikeLevelInfoItem(), null, false, true);
		}

		// Token: 0x0603F00F RID: 258063 RVA: 0x00F38854 File Offset: 0x00F36A54
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

		// Token: 0x0603F010 RID: 258064 RVA: 0x00F388AC File Offset: 0x00F36AAC
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

		// Token: 0x0603F011 RID: 258065 RVA: 0x00F389BC File Offset: 0x00F36BBC
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

		// Token: 0x0603F012 RID: 258066 RVA: 0x00F38A38 File Offset: 0x00F36C38
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

		// Token: 0x0603F013 RID: 258067 RVA: 0x00F38A7C File Offset: 0x00F36C7C
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

		// Token: 0x04020DF4 RID: 134644
		private readonly GenericLayout<RoverlikeLevelInfoItem, RoverlikeLevelInfoItemData> InfoLayout;

		// Token: 0x04020DF5 RID: 134645
		private List<RoverlikeLevelInfoItemData> LastInfoDataList = new List<RoverlikeLevelInfoItemData>();
	}
}
