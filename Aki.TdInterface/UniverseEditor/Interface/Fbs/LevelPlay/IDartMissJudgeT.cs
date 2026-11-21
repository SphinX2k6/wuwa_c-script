using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048DF RID: 18655
	public class IDartMissJudgeT
	{
		// Token: 0x170081F5 RID: 33269
		// (get) Token: 0x0601B9E5 RID: 113125 RVA: 0x003E7B88 File Offset: 0x003E5D88
		// (set) Token: 0x0601B9E6 RID: 113126 RVA: 0x003E7B90 File Offset: 0x003E5D90
		public int Probability { get; set; }

		// Token: 0x170081F6 RID: 33270
		// (get) Token: 0x0601B9E7 RID: 113127 RVA: 0x003E7B99 File Offset: 0x003E5D99
		// (set) Token: 0x0601B9E8 RID: 113128 RVA: 0x003E7BA1 File Offset: 0x003E5DA1
		public int Range { get; set; }

		// Token: 0x0601B9E9 RID: 113129 RVA: 0x003E7BAA File Offset: 0x003E5DAA
		public IDartMissJudgeT()
		{
			this.Probability = 0;
			this.Range = 0;
		}
	}
}
