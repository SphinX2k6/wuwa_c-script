using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem
{
	// Token: 0x0200522C RID: 21036
	[NullableContext(1)]
	[Nullable(0)]
	public class PrizeDrawingTearItemBase : UiPanelBase
	{
		// Token: 0x06034572 RID: 214386 RVA: 0x00EA54F4 File Offset: 0x00EA36F4
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.PlaySequencePurely("Reveal", false, false, null, null, false);
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
		}

		// Token: 0x06034573 RID: 214387 RVA: 0x00EA553C File Offset: 0x00EA373C
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x06034574 RID: 214388 RVA: 0x00EA5550 File Offset: 0x00EA3750
		public void PlayRevelAnimation()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Reveal", false, false, null, null, false);
		}

		// Token: 0x06034575 RID: 214389 RVA: 0x00EA557F File Offset: 0x00EA377F
		public void SetRewardList(List<IKujiAwardData> rewardList)
		{
			this.RewardList = rewardList;
		}

		// Token: 0x06034576 RID: 214390 RVA: 0x00EA5588 File Offset: 0x00EA3788
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

		// Token: 0x0401BCE1 RID: 113889
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<IKujiAwardData> RewardList;

		// Token: 0x0401BCE2 RID: 113890
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401BCE3 RID: 113891
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
