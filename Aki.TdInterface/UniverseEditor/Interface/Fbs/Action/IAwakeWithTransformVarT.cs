using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006845 RID: 26693
	public class IAwakeWithTransformVarT
	{
		// Token: 0x1700C444 RID: 50244
		// (get) Token: 0x0602DA02 RID: 186882 RVA: 0x0063E0AF File Offset: 0x0063C2AF
		// (set) Token: 0x0602DA03 RID: 186883 RVA: 0x0063E0B7 File Offset: 0x0063C2B7
		public EAwakePosType Type { get; set; }

		// Token: 0x1700C445 RID: 50245
		// (get) Token: 0x0602DA04 RID: 186884 RVA: 0x0063E0C0 File Offset: 0x0063C2C0
		// (set) Token: 0x0602DA05 RID: 186885 RVA: 0x0063E0C8 File Offset: 0x0063C2C8
		public TVarRefUnion TransformVar { get; set; }

		// Token: 0x0602DA06 RID: 186886 RVA: 0x0063E0D1 File Offset: 0x0063C2D1
		public IAwakeWithTransformVarT()
		{
			this.Type = EAwakePosType.TransformVar;
			this.TransformVar = null;
		}
	}
}
