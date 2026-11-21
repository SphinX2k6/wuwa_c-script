using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059BB RID: 22971
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct SolarSchoolInfoGradesData
	{
		// Token: 0x17006C3C RID: 27708
		// (get) Token: 0x060389D7 RID: 231895 RVA: 0x00FD754F File Offset: 0x00FD574F
		public ESolarSchoolExamType ExamType { get; }

		// Token: 0x17006C3D RID: 27709
		// (get) Token: 0x060389D8 RID: 231896 RVA: 0x00FD7557 File Offset: 0x00FD5757
		public bool HasResult { get; }

		// Token: 0x17006C3E RID: 27710
		// (get) Token: 0x060389D9 RID: 231897 RVA: 0x00FD755F File Offset: 0x00FD575F
		public int Score { get; }

		// Token: 0x17006C3F RID: 27711
		// (get) Token: 0x060389DA RID: 231898 RVA: 0x00FD7567 File Offset: 0x00FD5767
		public int Rank { get; }

		// Token: 0x17006C40 RID: 27712
		// (get) Token: 0x060389DB RID: 231899 RVA: 0x00FD756F File Offset: 0x00FD576F
		public string RankTextId { get; }

		// Token: 0x17006C41 RID: 27713
		// (get) Token: 0x060389DC RID: 231900 RVA: 0x00FD7577 File Offset: 0x00FD5777
		public string RankIconPath { get; }

		// Token: 0x060389DD RID: 231901 RVA: 0x00FD757F File Offset: 0x00FD577F
		public SolarSchoolInfoGradesData(ESolarSchoolExamType examType, bool hasResult, int score, int rank, string rankTextId, string rankIconPath)
		{
			this.ExamType = examType;
			this.HasResult = hasResult;
			this.Score = score;
			this.Rank = rank;
			this.RankTextId = rankTextId;
			this.RankIconPath = rankIconPath;
		}
	}
}
