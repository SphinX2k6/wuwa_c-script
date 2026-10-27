using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E08 RID: 28168
	public class IRandomVarT
	{
		// Token: 0x1700D1FF RID: 53759
		// (get) Token: 0x06031C60 RID: 203872 RVA: 0x006BD480 File Offset: 0x006BB680
		// (set) Token: 0x06031C61 RID: 203873 RVA: 0x006BD488 File Offset: 0x006BB688
		public TVarRefUnion LeftVar { get; set; }

		// Token: 0x1700D200 RID: 53760
		// (get) Token: 0x06031C62 RID: 203874 RVA: 0x006BD491 File Offset: 0x006BB691
		// (set) Token: 0x06031C63 RID: 203875 RVA: 0x006BD499 File Offset: 0x006BB699
		public TVarRefUnion RightVar { get; set; }

		// Token: 0x1700D201 RID: 53761
		// (get) Token: 0x06031C64 RID: 203876 RVA: 0x006BD4A2 File Offset: 0x006BB6A2
		// (set) Token: 0x06031C65 RID: 203877 RVA: 0x006BD4AA File Offset: 0x006BB6AA
		public TVarRefUnion Result { get; set; }

		// Token: 0x06031C66 RID: 203878 RVA: 0x006BD4B3 File Offset: 0x006BB6B3
		public IRandomVarT()
		{
			this.LeftVar = null;
			this.RightVar = null;
			this.Result = null;
		}
	}
}
