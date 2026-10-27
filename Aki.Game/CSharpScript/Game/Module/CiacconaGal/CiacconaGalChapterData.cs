using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BCD RID: 23501
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterData
	{
		// Token: 0x0603B690 RID: 243344 RVA: 0x00E2B416 File Offset: 0x00E29616
		public CiacconaGalChapterData(CiacconaGalChapter Config)
		{
			this.Config = Config;
			this.InternelSubEndingIds = new int[]
			{
				Config.SubEnding1,
				Config.SubEnding2,
				Config.SubEnding3
			};
		}

		// Token: 0x17008D15 RID: 36117
		// (get) Token: 0x0603B691 RID: 243345 RVA: 0x00E2B44F File Offset: 0x00E2964F
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008D16 RID: 36118
		// (get) Token: 0x0603B692 RID: 243346 RVA: 0x00E2B45C File Offset: 0x00E2965C
		public string Title
		{
			get
			{
				return this.Config.Title;
			}
		}

		// Token: 0x17008D17 RID: 36119
		// (get) Token: 0x0603B693 RID: 243347 RVA: 0x00E2B469 File Offset: 0x00E29669
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17008D18 RID: 36120
		// (get) Token: 0x0603B694 RID: 243348 RVA: 0x00E2B476 File Offset: 0x00E29676
		public int[] StepIds
		{
			get
			{
				return this.Config.Steps();
			}
		}

		// Token: 0x17008D19 RID: 36121
		// (get) Token: 0x0603B695 RID: 243349 RVA: 0x00E2B483 File Offset: 0x00E29683
		public string ImageSmallPath
		{
			get
			{
				return this.Config.ChapterImageSmall;
			}
		}

		// Token: 0x17008D1A RID: 36122
		// (get) Token: 0x0603B696 RID: 243350 RVA: 0x00E2B490 File Offset: 0x00E29690
		public string ImageLargePath
		{
			get
			{
				return this.Config.ChapterImageLarge;
			}
		}

		// Token: 0x17008D1B RID: 36123
		// (get) Token: 0x0603B697 RID: 243351 RVA: 0x00E2B49D File Offset: 0x00E2969D
		public int[] SubEndingIds
		{
			get
			{
				return this.InternelSubEndingIds;
			}
		}

		// Token: 0x17008D1C RID: 36124
		// (get) Token: 0x0603B698 RID: 243352 RVA: 0x00E2B4A5 File Offset: 0x00E296A5
		public int BranchingStepId
		{
			get
			{
				return this.Config.BranchPoint;
			}
		}

		// Token: 0x17008D1D RID: 36125
		// (get) Token: 0x0603B699 RID: 243353 RVA: 0x00E2B4B2 File Offset: 0x00E296B2
		public bool IsFinished
		{
			get
			{
				return this.IsFinishedInternal;
			}
		}

		// Token: 0x17008D1E RID: 36126
		// (get) Token: 0x0603B69A RID: 243354 RVA: 0x00E2B4BA File Offset: 0x00E296BA
		public bool IsUnlocked
		{
			get
			{
				return this.IsUnlockInternal;
			}
		}

		// Token: 0x17008D1F RID: 36127
		// (get) Token: 0x0603B69B RID: 243355 RVA: 0x00E2B4C2 File Offset: 0x00E296C2
		public string MusicEvent
		{
			get
			{
				return this.Config.MusicEvent;
			}
		}

		// Token: 0x0603B69C RID: 243356 RVA: 0x00E2B4CF File Offset: 0x00E296CF
		public int GetSubEndingId(int index)
		{
			return this.InternelSubEndingIds[index];
		}

		// Token: 0x0603B69D RID: 243357 RVA: 0x00E2B4DC File Offset: 0x00E296DC
		public void UpdateByServerData(CiacconaChapterPbData data)
		{
			using (IEnumerator<CiacconaChapterResultPbData> enumerator = data.ResultDatas.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Finish)
					{
						this.IsFinishedInternal = true;
						break;
					}
				}
			}
			this.IsUnlockInternal = data.Unlock;
		}

		// Token: 0x0401EF68 RID: 126824
		private CiacconaGalChapter Config;

		// Token: 0x0401EF69 RID: 126825
		private readonly int[] InternelSubEndingIds;

		// Token: 0x0401EF6A RID: 126826
		private bool IsFinishedInternal;

		// Token: 0x0401EF6B RID: 126827
		private bool IsUnlockInternal;
	}
}
