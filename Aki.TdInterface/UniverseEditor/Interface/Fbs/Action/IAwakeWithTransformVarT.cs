using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D7 RID: 25047
	public class IAwakeWithTransformVarT
	{
		// Token: 0x1700BAC1 RID: 47809
		// (get) Token: 0x0602B2BB RID: 176827 RVA: 0x005F363B File Offset: 0x005F183B
		// (set) Token: 0x0602B2BC RID: 176828 RVA: 0x005F3643 File Offset: 0x005F1843
		public EAwakePosType Type { get; set; }

		// Token: 0x1700BAC2 RID: 47810
		// (get) Token: 0x0602B2BD RID: 176829 RVA: 0x005F364C File Offset: 0x005F184C
		// (set) Token: 0x0602B2BE RID: 176830 RVA: 0x005F3654 File Offset: 0x005F1854
		public TVarRefUnion TransformVar { get; set; }

		// Token: 0x0602B2BF RID: 176831 RVA: 0x005F365D File Offset: 0x005F185D
		public IAwakeWithTransformVarT()
		{
			this.Type = EAwakePosType.TransformVar;
			this.TransformVar = null;
		}
	}
}
