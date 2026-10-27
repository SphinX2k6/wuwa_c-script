using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B45 RID: 15173
	public class Record_ESystemModuleName_ISystemVarDefinesT
	{
		// Token: 0x17006816 RID: 26646
		// (get) Token: 0x06014BDF RID: 84959 RVA: 0x00303E77 File Offset: 0x00302077
		// (set) Token: 0x06014BE0 RID: 84960 RVA: 0x00303E7F File Offset: 0x0030207F
		public ESystemModuleName Key { get; set; }

		// Token: 0x17006817 RID: 26647
		// (get) Token: 0x06014BE1 RID: 84961 RVA: 0x00303E88 File Offset: 0x00302088
		// (set) Token: 0x06014BE2 RID: 84962 RVA: 0x00303E90 File Offset: 0x00302090
		public List<ISystemVarDefineT> Values { get; set; }

		// Token: 0x06014BE3 RID: 84963 RVA: 0x00303E99 File Offset: 0x00302099
		public Record_ESystemModuleName_ISystemVarDefinesT()
		{
			this.Key = ESystemModuleName.Common;
			this.Values = null;
		}
	}
}
