using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BAD RID: 19373
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterData
	{
		// Token: 0x060305DC RID: 198108 RVA: 0x00D7B70A File Offset: 0x00D7990A
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

		// Token: 0x170060E7 RID: 24807
		// (get) Token: 0x060305DD RID: 198109 RVA: 0x00D7B743 File Offset: 0x00D79943
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170060E8 RID: 24808
		// (get) Token: 0x060305DE RID: 198110 RVA: 0x00D7B750 File Offset: 0x00D79950
		public string Title
		{
			get
			{
				return this.Config.Title;
			}
		}

		// Token: 0x170060E9 RID: 24809
		// (get) Token: 0x060305DF RID: 198111 RVA: 0x00D7B75D File Offset: 0x00D7995D
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x170060EA RID: 24810
		// (get) Token: 0x060305E0 RID: 198112 RVA: 0x00D7B76A File Offset: 0x00D7996A
		public int[] StepIds
		{
			get
			{
				return this.Config.Steps();
			}
		}

		// Token: 0x170060EB RID: 24811
		// (get) Token: 0x060305E1 RID: 198113 RVA: 0x00D7B777 File Offset: 0x00D79977
		public string ImageSmallPath
		{
			get
			{
				return this.Config.ChapterImageSmall;
			}
		}

		// Token: 0x170060EC RID: 24812
		// (get) Token: 0x060305E2 RID: 198114 RVA: 0x00D7B784 File Offset: 0x00D79984
		public string ImageLargePath
		{
			get
			{
				return this.Config.ChapterImageLarge;
			}
		}

		// Token: 0x170060ED RID: 24813
		// (get) Token: 0x060305E3 RID: 198115 RVA: 0x00D7B791 File Offset: 0x00D79991
		public int[] SubEndingIds
		{
			get
			{
				return this.InternelSubEndingIds;
			}
		}

		// Token: 0x170060EE RID: 24814
		// (get) Token: 0x060305E4 RID: 198116 RVA: 0x00D7B799 File Offset: 0x00D79999
		public int BranchingStepId
		{
			get
			{
				return this.Config.BranchPoint;
			}
		}

		// Token: 0x170060EF RID: 24815
		// (get) Token: 0x060305E5 RID: 198117 RVA: 0x00D7B7A6 File Offset: 0x00D799A6
		public bool IsFinished
		{
			get
			{
				return this.IsFinishedInternal;
			}
		}

		// Token: 0x170060F0 RID: 24816
		// (get) Token: 0x060305E6 RID: 198118 RVA: 0x00D7B7AE File Offset: 0x00D799AE
		public bool IsUnlocked
		{
			get
			{
				return this.IsUnlockInternal;
			}
		}

		// Token: 0x170060F1 RID: 24817
		// (get) Token: 0x060305E7 RID: 198119 RVA: 0x00D7B7B6 File Offset: 0x00D799B6
		public string MusicEvent
		{
			get
			{
				return this.Config.MusicEvent;
			}
		}

		// Token: 0x060305E8 RID: 198120 RVA: 0x00D7B7C3 File Offset: 0x00D799C3
		public int GetSubEndingId(int index)
		{
			return this.InternelSubEndingIds[index];
		}

		// Token: 0x060305E9 RID: 198121 RVA: 0x00D7B7D0 File Offset: 0x00D799D0
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

		// Token: 0x04019A19 RID: 104985
		private CiacconaGalChapter Config;

		// Token: 0x04019A1A RID: 104986
		private readonly int[] InternelSubEndingIds;

		// Token: 0x04019A1B RID: 104987
		private bool IsFinishedInternal;

		// Token: 0x04019A1C RID: 104988
		private bool IsUnlockInternal;
	}
}
