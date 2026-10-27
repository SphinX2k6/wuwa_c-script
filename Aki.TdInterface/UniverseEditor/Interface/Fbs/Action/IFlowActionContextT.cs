using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067ED RID: 26605
	public class IFlowActionContextT
	{
		// Token: 0x1700C577 RID: 50551
		// (get) Token: 0x0602E525 RID: 189733 RVA: 0x00652D9D File Offset: 0x00650F9D
		// (set) Token: 0x0602E526 RID: 189734 RVA: 0x00652DA5 File Offset: 0x00650FA5
		public string Type { get; set; }

		// Token: 0x0602E527 RID: 189735 RVA: 0x00652DAE File Offset: 0x00650FAE
		public IFlowActionContextT()
		{
			this.Type = null;
		}
	}
}
