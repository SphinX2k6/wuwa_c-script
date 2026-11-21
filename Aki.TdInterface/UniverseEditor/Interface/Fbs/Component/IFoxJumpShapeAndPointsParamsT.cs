using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583C RID: 22588
	public class IFoxJumpShapeAndPointsParamsT
	{
		// Token: 0x1700A396 RID: 41878
		// (get) Token: 0x06024943 RID: 149827 RVA: 0x00506AE8 File Offset: 0x00504CE8
		// (set) Token: 0x06024944 RID: 149828 RVA: 0x00506AF0 File Offset: 0x00504CF0
		public IBoxTriggerShapeT BoxShape { get; set; }

		// Token: 0x1700A397 RID: 41879
		// (get) Token: 0x06024945 RID: 149829 RVA: 0x00506AF9 File Offset: 0x00504CF9
		// (set) Token: 0x06024946 RID: 149830 RVA: 0x00506B01 File Offset: 0x00504D01
		public List<IVectorInfoT> PointOffsets { get; set; }

		// Token: 0x06024947 RID: 149831 RVA: 0x00506B0A File Offset: 0x00504D0A
		public IFoxJumpShapeAndPointsParamsT()
		{
			this.BoxShape = null;
			this.PointOffsets = null;
		}
	}
}
