using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007972 RID: 31090
	public class ISportConfigT
	{
		// Token: 0x1700E3FA RID: 58362
		// (get) Token: 0x06036C16 RID: 224278 RVA: 0x007531C2 File Offset: 0x007513C2
		// (set) Token: 0x06036C17 RID: 224279 RVA: 0x007531CA File Offset: 0x007513CA
		public ESportStateType Type { get; set; }

		// Token: 0x06036C18 RID: 224280 RVA: 0x007531D3 File Offset: 0x007513D3
		public ISportConfigT()
		{
			this.Type = ESportStateType.Slide;
		}
	}
}
