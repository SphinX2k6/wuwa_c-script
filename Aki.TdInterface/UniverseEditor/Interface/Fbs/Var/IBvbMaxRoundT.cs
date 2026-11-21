using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E42 RID: 15938
	public class IBvbMaxRoundT
	{
		// Token: 0x17006BAA RID: 27562
		// (get) Token: 0x06015769 RID: 87913 RVA: 0x00319152 File Offset: 0x00317352
		// (set) Token: 0x0601576A RID: 87914 RVA: 0x0031915A File Offset: 0x0031735A
		public ESystemVarName Type { get; set; }

		// Token: 0x0601576B RID: 87915 RVA: 0x00319163 File Offset: 0x00317363
		public IBvbMaxRoundT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
