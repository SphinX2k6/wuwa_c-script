using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F0B RID: 16139
	public class IVarIntervalT
	{
		// Token: 0x17006D4B RID: 27979
		// (get) Token: 0x06015EA1 RID: 89761 RVA: 0x00326DDB File Offset: 0x00324FDB
		// (set) Token: 0x06015EA2 RID: 89762 RVA: 0x00326DE3 File Offset: 0x00324FE3
		public TVarRefUnion VarMin { get; set; }

		// Token: 0x17006D4C RID: 27980
		// (get) Token: 0x06015EA3 RID: 89763 RVA: 0x00326DEC File Offset: 0x00324FEC
		// (set) Token: 0x06015EA4 RID: 89764 RVA: 0x00326DF4 File Offset: 0x00324FF4
		public TVarRefUnion VarMax { get; set; }

		// Token: 0x06015EA5 RID: 89765 RVA: 0x00326DFD File Offset: 0x00324FFD
		public IVarIntervalT()
		{
			this.VarMin = null;
			this.VarMax = null;
		}
	}
}
