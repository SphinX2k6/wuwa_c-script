using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200447D RID: 17533
	public class IDartScatterJudgeT
	{
		// Token: 0x17007BBE RID: 31678
		// (get) Token: 0x0601A23C RID: 107068 RVA: 0x003BBCF4 File Offset: 0x003B9EF4
		// (set) Token: 0x0601A23D RID: 107069 RVA: 0x003BBCFC File Offset: 0x003B9EFC
		public int Probability { get; set; }

		// Token: 0x17007BBF RID: 31679
		// (get) Token: 0x0601A23E RID: 107070 RVA: 0x003BBD05 File Offset: 0x003B9F05
		// (set) Token: 0x0601A23F RID: 107071 RVA: 0x003BBD0D File Offset: 0x003B9F0D
		public int Range { get; set; }

		// Token: 0x0601A240 RID: 107072 RVA: 0x003BBD16 File Offset: 0x003B9F16
		public IDartScatterJudgeT()
		{
			this.Probability = 0;
			this.Range = 0;
		}
	}
}
