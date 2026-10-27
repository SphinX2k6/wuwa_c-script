using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A8B RID: 14987
	public class ICommonHostToTargetDistanceT
	{
		// Token: 0x170066A8 RID: 26280
		// (get) Token: 0x06014539 RID: 83257 RVA: 0x002F74A5 File Offset: 0x002F56A5
		// (set) Token: 0x0601453A RID: 83258 RVA: 0x002F74AD File Offset: 0x002F56AD
		public ESystemVarName Type { get; set; }

		// Token: 0x170066A9 RID: 26281
		// (get) Token: 0x0601453B RID: 83259 RVA: 0x002F74B6 File Offset: 0x002F56B6
		// (set) Token: 0x0601453C RID: 83260 RVA: 0x002F74BE File Offset: 0x002F56BE
		public IPosAT Pos { get; set; }

		// Token: 0x170066AA RID: 26282
		// (get) Token: 0x0601453D RID: 83261 RVA: 0x002F74C7 File Offset: 0x002F56C7
		// (set) Token: 0x0601453E RID: 83262 RVA: 0x002F74CF File Offset: 0x002F56CF
		public EDistanceMeasureMode DistanceMeasureMode { get; set; }

		// Token: 0x0601453F RID: 83263 RVA: 0x002F74D8 File Offset: 0x002F56D8
		public ICommonHostToTargetDistanceT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Pos = null;
			this.DistanceMeasureMode = EDistanceMeasureMode.Horizontal;
		}
	}
}
