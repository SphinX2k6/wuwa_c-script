using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F47 RID: 16199
	public class Record_ESystemModuleName_ISystemVarDefinesT
	{
		// Token: 0x17006DB1 RID: 28081
		// (get) Token: 0x06016089 RID: 90249 RVA: 0x0032A107 File Offset: 0x00328307
		// (set) Token: 0x0601608A RID: 90250 RVA: 0x0032A10F File Offset: 0x0032830F
		public ESystemModuleName Key { get; set; }

		// Token: 0x17006DB2 RID: 28082
		// (get) Token: 0x0601608B RID: 90251 RVA: 0x0032A118 File Offset: 0x00328318
		// (set) Token: 0x0601608C RID: 90252 RVA: 0x0032A120 File Offset: 0x00328320
		public List<ISystemVarDefineT> Values { get; set; }

		// Token: 0x0601608D RID: 90253 RVA: 0x0032A129 File Offset: 0x00328329
		public Record_ESystemModuleName_ISystemVarDefinesT()
		{
			this.Key = ESystemModuleName.Common;
			this.Values = null;
		}
	}
}
