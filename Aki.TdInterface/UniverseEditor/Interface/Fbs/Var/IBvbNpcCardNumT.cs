using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E45 RID: 15941
	public class IBvbNpcCardNumT
	{
		// Token: 0x17006BAD RID: 27565
		// (get) Token: 0x0601577B RID: 87931 RVA: 0x003192CA File Offset: 0x003174CA
		// (set) Token: 0x0601577C RID: 87932 RVA: 0x003192D2 File Offset: 0x003174D2
		public ESystemVarName Type { get; set; }

		// Token: 0x0601577D RID: 87933 RVA: 0x003192DB File Offset: 0x003174DB
		public IBvbNpcCardNumT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
