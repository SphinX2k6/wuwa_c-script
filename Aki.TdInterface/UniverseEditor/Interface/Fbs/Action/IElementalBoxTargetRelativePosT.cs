using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAB RID: 27819
	public class IElementalBoxTargetRelativePosT
	{
		// Token: 0x1700CC07 RID: 52231
		// (get) Token: 0x0602FEF8 RID: 196344 RVA: 0x0068660F File Offset: 0x0068480F
		// (set) Token: 0x0602FEF9 RID: 196345 RVA: 0x00686617 File Offset: 0x00684817
		public EElementalBoxTargetPosType Type { get; set; }

		// Token: 0x1700CC08 RID: 52232
		// (get) Token: 0x0602FEFA RID: 196346 RVA: 0x00686620 File Offset: 0x00684820
		// (set) Token: 0x0602FEFB RID: 196347 RVA: 0x00686628 File Offset: 0x00684828
		public IVectorInfoT RelativePos { get; set; }

		// Token: 0x0602FEFC RID: 196348 RVA: 0x00686631 File Offset: 0x00684831
		public IElementalBoxTargetRelativePosT()
		{
			this.Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
			this.RelativePos = null;
		}
	}
}
