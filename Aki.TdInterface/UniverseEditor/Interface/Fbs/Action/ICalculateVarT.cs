using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200626D RID: 25197
	public class ICalculateVarT
	{
		// Token: 0x1700BBC5 RID: 48069
		// (get) Token: 0x0602B7C5 RID: 178117 RVA: 0x005FCCE4 File Offset: 0x005FAEE4
		// (set) Token: 0x0602B7C6 RID: 178118 RVA: 0x005FCCEC File Offset: 0x005FAEEC
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x1700BBC6 RID: 48070
		// (get) Token: 0x0602B7C7 RID: 178119 RVA: 0x005FCCF5 File Offset: 0x005FAEF5
		// (set) Token: 0x0602B7C8 RID: 178120 RVA: 0x005FCCFD File Offset: 0x005FAEFD
		public string Op { get; set; }

		// Token: 0x1700BBC7 RID: 48071
		// (get) Token: 0x0602B7C9 RID: 178121 RVA: 0x005FCD06 File Offset: 0x005FAF06
		// (set) Token: 0x0602B7CA RID: 178122 RVA: 0x005FCD0E File Offset: 0x005FAF0E
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x1700BBC8 RID: 48072
		// (get) Token: 0x0602B7CB RID: 178123 RVA: 0x005FCD17 File Offset: 0x005FAF17
		// (set) Token: 0x0602B7CC RID: 178124 RVA: 0x005FCD1F File Offset: 0x005FAF1F
		public TVarRefUnion Result { get; set; }

		// Token: 0x0602B7CD RID: 178125 RVA: 0x005FCD28 File Offset: 0x005FAF28
		public ICalculateVarT()
		{
			this.Var1 = null;
			this.Op = null;
			this.Var2 = null;
			this.Result = null;
		}
	}
}
