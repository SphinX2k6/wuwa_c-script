using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005923 RID: 22819
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolPrizeDrawingTearItemBase : UiPanelBase
	{
		// Token: 0x060383DE RID: 230366 RVA: 0x00FB9E4C File Offset: 0x00FB804C
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.PlaySequencePurely("Reveal", false, false, null, null, false);
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x060383DF RID: 230367 RVA: 0x00FB9E94 File Offset: 0x00FB8094
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x060383E0 RID: 230368 RVA: 0x00FB9EA8 File Offset: 0x00FB80A8
		public void PlayRevelAnimation()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Reveal", false, false, null, null, false);
		}

		// Token: 0x060383E1 RID: 230369 RVA: 0x00FB9ED7 File Offset: 0x00FB80D7
		public void SetRewardList(List<ISolarSchoolPrizeAwardData> rewardList)
		{
			this.RewardList = rewardList;
		}

		// Token: 0x060383E2 RID: 230370 RVA: 0x00FB9EE0 File Offset: 0x00FB80E0
		protected string RareIdToTexPath(int id, bool isNormal = false)
		{
			string[] array;
			if (!this.RareToTexIdMap.TryGetValue(id, out array))
			{
				return "";
			}
			string resourceId = (isNormal && array.Length > 1) ? array[1] : array[0];
			return UiResourceConfig.Instance.GetResourcePath(resourceId);
		}

		// Token: 0x060383E3 RID: 230371 RVA: 0x00FB9F20 File Offset: 0x00FB8120
		protected string GetItemIconPath(int itemId)
		{
			SolarSchoolItem? solarSchoolItem;
			return ((SolarSchoolConfig.Instance.GetItem(itemId) != null) ? solarSchoolItem.GetValueOrDefault().Icon : null) ?? string.Empty;
		}

		// Token: 0x0401D9ED RID: 121325
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<ISolarSchoolPrizeAwardData> RewardList;

		// Token: 0x0401D9EE RID: 121326
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D9EF RID: 121327
		private readonly Dictionary<int, string[]> RareToTexIdMap = new Dictionary<int, string[]>
		{
			{
				0,
				new string[]
				{
					"T_PrizeDrawingTearLevelS"
				}
			},
			{
				1,
				new string[]
				{
					"T_PrizeDrawingTearLevelA",
					"T_PrizeDrawingTearLevelA_Nml"
				}
			},
			{
				2,
				new string[]
				{
					"T_PrizeDrawingTearLevelB",
					"T_PrizeDrawingTearLevelB_Nml"
				}
			},
			{
				3,
				new string[]
				{
					"T_PrizeDrawingTearLevelC",
					"T_PrizeDrawingTearLevelC_Nml"
				}
			},
			{
				4,
				new string[]
				{
					"T_PrizeDrawingTearLevelD",
					"T_PrizeDrawingTearLevelD_Nml"
				}
			},
			{
				5,
				new string[]
				{
					"T_PrizeDrawingTearLevelE",
					"T_PrizeDrawingTearLevelE_Nml"
				}
			},
			{
				6,
				new string[]
				{
					"T_PrizeDrawingTearLevelF",
					"T_PrizeDrawingTearLevelF_Nml"
				}
			}
		};
	}
}
