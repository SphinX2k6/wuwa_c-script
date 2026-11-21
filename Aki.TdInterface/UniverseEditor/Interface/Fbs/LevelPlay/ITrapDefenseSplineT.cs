using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A3B RID: 19003
	public class ITrapDefenseSplineT
	{
		// Token: 0x17008552 RID: 34130
		// (get) Token: 0x0601C89A RID: 116890 RVA: 0x00407049 File Offset: 0x00405249
		// (set) Token: 0x0601C89B RID: 116891 RVA: 0x00407051 File Offset: 0x00405251
		public string SplineEntityId { get; set; }

		// Token: 0x17008553 RID: 34131
		// (get) Token: 0x0601C89C RID: 116892 RVA: 0x0040705A File Offset: 0x0040525A
		// (set) Token: 0x0601C89D RID: 116893 RVA: 0x00407062 File Offset: 0x00405262
		public float DelayTime { get; set; }

		// Token: 0x17008554 RID: 34132
		// (get) Token: 0x0601C89E RID: 116894 RVA: 0x0040706B File Offset: 0x0040526B
		// (set) Token: 0x0601C89F RID: 116895 RVA: 0x00407073 File Offset: 0x00405273
		public float IntervalTime { get; set; }

		// Token: 0x0601C8A0 RID: 116896 RVA: 0x0040707C File Offset: 0x0040527C
		public ITrapDefenseSplineT()
		{
			this.SplineEntityId = null;
			this.DelayTime = 0f;
			this.IntervalTime = 0f;
		}
	}
}
