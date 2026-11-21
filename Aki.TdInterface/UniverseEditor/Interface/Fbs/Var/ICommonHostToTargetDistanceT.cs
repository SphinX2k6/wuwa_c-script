using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E66 RID: 15974
	public class ICommonHostToTargetDistanceT
	{
		// Token: 0x17006BD8 RID: 27608
		// (get) Token: 0x06015855 RID: 88149 RVA: 0x0031A691 File Offset: 0x00318891
		// (set) Token: 0x06015856 RID: 88150 RVA: 0x0031A699 File Offset: 0x00318899
		public ESystemVarName Type { get; set; }

		// Token: 0x17006BD9 RID: 27609
		// (get) Token: 0x06015857 RID: 88151 RVA: 0x0031A6A2 File Offset: 0x003188A2
		// (set) Token: 0x06015858 RID: 88152 RVA: 0x0031A6AA File Offset: 0x003188AA
		public IPosAT Pos { get; set; }

		// Token: 0x17006BDA RID: 27610
		// (get) Token: 0x06015859 RID: 88153 RVA: 0x0031A6B3 File Offset: 0x003188B3
		// (set) Token: 0x0601585A RID: 88154 RVA: 0x0031A6BB File Offset: 0x003188BB
		public EDistanceMeasureMode DistanceMeasureMode { get; set; }

		// Token: 0x0601585B RID: 88155 RVA: 0x0031A6C4 File Offset: 0x003188C4
		public ICommonHostToTargetDistanceT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Pos = null;
			this.DistanceMeasureMode = EDistanceMeasureMode.Horizontal;
		}
	}
}
