using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BCF RID: 23503
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChoiceData
	{
		// Token: 0x0603B6A4 RID: 243364 RVA: 0x00E2B5DB File Offset: 0x00E297DB
		public CiacconaGalChoiceData(CiacconaGalChoice config)
		{
			this.Config = config;
		}

		// Token: 0x17008D25 RID: 36133
		// (get) Token: 0x0603B6A5 RID: 243365 RVA: 0x00E2B5F8 File Offset: 0x00E297F8
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008D26 RID: 36134
		// (get) Token: 0x0603B6A6 RID: 243366 RVA: 0x00E2B614 File Offset: 0x00E29814
		public string Content
		{
			get
			{
				return this.Config.Content;
			}
		}

		// Token: 0x17008D27 RID: 36135
		// (get) Token: 0x0603B6A7 RID: 243367 RVA: 0x00E2B630 File Offset: 0x00E29830
		public int RequiredInspiration
		{
			get
			{
				return this.Config.RequiredInspiration;
			}
		}

		// Token: 0x17008D28 RID: 36136
		// (get) Token: 0x0603B6A8 RID: 243368 RVA: 0x00E2B64C File Offset: 0x00E2984C
		public bool NeedInspiration
		{
			get
			{
				return this.Config.RequiredInspiration > 0;
			}
		}

		// Token: 0x17008D29 RID: 36137
		// (get) Token: 0x0603B6A9 RID: 243369 RVA: 0x00E2B66A File Offset: 0x00E2986A
		public bool IsAvailable
		{
			get
			{
				return this.State == ECiacconaGalStepState.Normal;
			}
		}

		// Token: 0x17008D2A RID: 36138
		// (get) Token: 0x0603B6AA RID: 243370 RVA: 0x00E2B675 File Offset: 0x00E29875
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

		// Token: 0x17008D2B RID: 36139
		// (get) Token: 0x0603B6AB RID: 243371 RVA: 0x00E2B698 File Offset: 0x00E29898
		public int ToStepId
		{
			get
			{
				return this.Config.ToStep;
			}
		}

		// Token: 0x17008D2C RID: 36140
		// (get) Token: 0x0603B6AC RID: 243372 RVA: 0x00E2B6B4 File Offset: 0x00E298B4
		public int CorrSubEndingId
		{
			get
			{
				return this.Config.CorrSubEnding;
			}
		}

		// Token: 0x17008D2D RID: 36141
		// (get) Token: 0x0603B6AD RID: 243373 RVA: 0x00E2B6CF File Offset: 0x00E298CF
		private bool HasChosen
		{
			get
			{
				return this.HasChosenInternal;
			}
		}

		// Token: 0x17008D2E RID: 36142
		// (get) Token: 0x0603B6AE RID: 243374 RVA: 0x00E2B6D7 File Offset: 0x00E298D7
		private bool HasInspired
		{
			get
			{
				return !this.NeedInspiration || this.HasInspiredInternal;
			}
		}

		// Token: 0x17008D2F RID: 36143
		// (get) Token: 0x0603B6AF RID: 243375 RVA: 0x00E2B6E9 File Offset: 0x00E298E9
		private bool IsUnlocked
		{
			get
			{
				return this.IsUnlockedInternal;
			}
		}

		// Token: 0x0603B6B0 RID: 243376 RVA: 0x00E2B6F4 File Offset: 0x00E298F4
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
			this.HasChosenInternal = chapterData.ResultDatas.Any((CiacconaChapterResultPbData resultData) => resultData.ResultId == this.CorrSubEndingId && resultData.Finish);
		}

		// Token: 0x0401EF6D RID: 126829
		private bool HasInspiredInternal = true;

		// Token: 0x0401EF6E RID: 126830
		private bool HasChosenInternal;

		// Token: 0x0401EF6F RID: 126831
		private bool IsUnlockedInternal = true;

		// Token: 0x0401EF70 RID: 126832
		private readonly CiacconaGalChoice Config;
	}
}
