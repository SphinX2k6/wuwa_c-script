using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem
{
	// Token: 0x020062AE RID: 25262
	[NullableContext(1)]
	[Nullable(0)]
	public class PrizeDrawingTearItemBase : UiPanelBase
	{
		// Token: 0x0603F8B1 RID: 260273 RVA: 0x00F5E598 File Offset: 0x00F5C798
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.PlaySequencePurely("Reveal", false, false, null, null, false);
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x0603F8B2 RID: 260274 RVA: 0x00F5E5E0 File Offset: 0x00F5C7E0
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603F8B3 RID: 260275 RVA: 0x00F5E5F4 File Offset: 0x00F5C7F4
		public void PlayRevelAnimation()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Reveal", false, false, null, null, false);
		}

		// Token: 0x0603F8B4 RID: 260276 RVA: 0x00F5E623 File Offset: 0x00F5C823
		public void SetRewardList(List<IKujiAwardData> rewardList)
		{
			this.RewardList = rewardList;
		}

		// Token: 0x0603F8B5 RID: 260277 RVA: 0x00F5E62C File Offset: 0x00F5C82C
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

		// Token: 0x040213B2 RID: 136114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<IKujiAwardData> RewardList;

		// Token: 0x040213B3 RID: 136115
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040213B4 RID: 136116
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
