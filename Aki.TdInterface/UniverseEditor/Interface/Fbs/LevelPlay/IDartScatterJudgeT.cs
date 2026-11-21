using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048E5 RID: 18661
	public class IDartScatterJudgeT
	{
		// Token: 0x170081FD RID: 33277
		// (get) Token: 0x0601BA0D RID: 113165 RVA: 0x003E7F00 File Offset: 0x003E6100
		// (set) Token: 0x0601BA0E RID: 113166 RVA: 0x003E7F08 File Offset: 0x003E6108
		public int Probability { get; set; }

		// Token: 0x170081FE RID: 33278
		// (get) Token: 0x0601BA0F RID: 113167 RVA: 0x003E7F11 File Offset: 0x003E6111
		// (set) Token: 0x0601BA10 RID: 113168 RVA: 0x003E7F19 File Offset: 0x003E6119
		public int Range { get; set; }

		// Token: 0x0601BA11 RID: 113169 RVA: 0x003E7F22 File Offset: 0x003E6122
		public IDartScatterJudgeT()
		{
			this.Probability = 0;
			this.Range = 0;
		}
	}
}
