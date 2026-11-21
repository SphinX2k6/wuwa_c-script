using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BAF RID: 19375
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChoiceData
	{
		// Token: 0x060305F0 RID: 198128 RVA: 0x00D7B8CF File Offset: 0x00D79ACF
		public CiacconaGalChoiceData(CiacconaGalChoice config)
		{
			this.Config = config;
		}

		// Token: 0x170060F7 RID: 24823
		// (get) Token: 0x060305F1 RID: 198129 RVA: 0x00D7B8EC File Offset: 0x00D79AEC
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170060F8 RID: 24824
		// (get) Token: 0x060305F2 RID: 198130 RVA: 0x00D7B908 File Offset: 0x00D79B08
		public string Content
		{
			get
			{
				return this.Config.Content;
			}
		}

		// Token: 0x170060F9 RID: 24825
		// (get) Token: 0x060305F3 RID: 198131 RVA: 0x00D7B924 File Offset: 0x00D79B24
		public int RequiredInspiration
		{
			get
			{
				return this.Config.RequiredInspiration;
			}
		}

		// Token: 0x170060FA RID: 24826
		// (get) Token: 0x060305F4 RID: 198132 RVA: 0x00D7B940 File Offset: 0x00D79B40
		public bool NeedInspiration
		{
			get
			{
				return this.Config.RequiredInspiration > 0;
			}
		}

		// Token: 0x170060FB RID: 24827
		// (get) Token: 0x060305F5 RID: 198133 RVA: 0x00D7B95E File Offset: 0x00D79B5E
		public bool IsAvailable
		{
			get
			{
				return this.State == ECiacconaGalStepState.Normal;
			}
		}

		// Token: 0x170060FC RID: 24828
		// (get) Token: 0x060305F6 RID: 198134 RVA: 0x00D7B969 File Offset: 0x00D79B69
		public ECiacconaGalStepState State
		{
			get
			{
				if (!this.IsUnlocked)
				{
					return ECiacconaGalStepState.LockingByCondition;
				}
				if (!this.HasInspired)
				{
					return ECiacconaGalStepState.LockingByInspiration;
				}
				if (this.HasChosen)
				{
					return ECiacconaGalStepState.Chosen;
				}
				return ECiacconaGalStepState.Normal;
			}
		}

		// Token: 0x170060FD RID: 24829
		// (get) Token: 0x060305F7 RID: 198135 RVA: 0x00D7B98C File Offset: 0x00D79B8C
		public int ToStepId
		{
			get
			{
				return this.Config.ToStep;
			}
		}

		// Token: 0x170060FE RID: 24830
		// (get) Token: 0x060305F8 RID: 198136 RVA: 0x00D7B9A8 File Offset: 0x00D79BA8
		public int CorrSubEndingId
		{
			get
			{
				return this.Config.CorrSubEnding;
			}
		}

		// Token: 0x170060FF RID: 24831
		// (get) Token: 0x060305F9 RID: 198137 RVA: 0x00D7B9C3 File Offset: 0x00D79BC3
		private bool HasChosen
		{
			get
			{
				return this.HasChosenInternal;
			}
		}

		// Token: 0x17006100 RID: 24832
		// (get) Token: 0x060305FA RID: 198138 RVA: 0x00D7B9CB File Offset: 0x00D79BCB
		private bool HasInspired
		{
			get
			{
				return !this.NeedInspiration || this.HasInspiredInternal;
			}
		}

		// Token: 0x17006101 RID: 24833
		// (get) Token: 0x060305FB RID: 198139 RVA: 0x00D7B9DD File Offset: 0x00D79BDD
		private bool IsUnlocked
		{
			get
			{
				return this.IsUnlockedInternal;
			}
		}

		// Token: 0x060305FC RID: 198140 RVA: 0x00D7B9E8 File Offset: 0x00D79BE8
		public void UpdateByServerData(CiacconaChapterPbData chapterData)
		{
			foreach (CiacconaChapterChoicePbData ciacconaChapterChoicePbData in chapterData.ChoiceDatas)
			{
				if (ciacconaChapterChoicePbData.ChoiceId == this.Id)
				{
					this.HasInspiredInternal = ciacconaChapterChoicePbData.InspirationUnlock;
					this.IsUnlockedInternal = ciacconaChapterChoicePbData.ConditionUnlock;
					break;
				}
			}
			bool hasChosenInternal = false;
			for (int i = 0; i < chapterData.ResultDatas.Count; i++)
			{
				CiacconaChapterResultPbData ciacconaChapterResultPbData = chapterData.ResultDatas[i];
				if (ciacconaChapterResultPbData.ResultId == this.CorrSubEndingId && ciacconaChapterResultPbData.Finish)
				{
					hasChosenInternal = true;
					break;
				}
			}
			this.HasChosenInternal = hasChosenInternal;
		}

		// Token: 0x04019A1E RID: 104990
		private bool HasInspiredInternal = true;

		// Token: 0x04019A1F RID: 104991
		private bool HasChosenInternal;

		// Token: 0x04019A20 RID: 104992
		private bool IsUnlockedInternal = true;

		// Token: 0x04019A21 RID: 104993
		private readonly CiacconaGalChoice Config;
	}
}
