using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D1 RID: 21201
	public class IFoxJumpShapeAndPointsParamsT
	{
		// Token: 0x17009B8D RID: 39821
		// (get) Token: 0x0602297F RID: 141695 RVA: 0x004CB9EC File Offset: 0x004C9BEC
		// (set) Token: 0x06022980 RID: 141696 RVA: 0x004CB9F4 File Offset: 0x004C9BF4
		public IBoxTriggerShapeT BoxShape { get; set; }

		// Token: 0x17009B8E RID: 39822
		// (get) Token: 0x06022981 RID: 141697 RVA: 0x004CB9FD File Offset: 0x004C9BFD
		// (set) Token: 0x06022982 RID: 141698 RVA: 0x004CBA05 File Offset: 0x004C9C05
		public List<IVectorInfoT> PointOffsets { get; set; }

		// Token: 0x06022983 RID: 141699 RVA: 0x004CBA0E File Offset: 0x004C9C0E
		public IFoxJumpShapeAndPointsParamsT()
		{
			this.BoxShape = null;
			this.PointOffsets = null;
		}
	}
}
