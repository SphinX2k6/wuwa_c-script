using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6D RID: 28269
	public class IFlowActionContextT
	{
		// Token: 0x1700CF2D RID: 53037
		// (get) Token: 0x06030D6B RID: 200043 RVA: 0x006A04E1 File Offset: 0x0069E6E1
		// (set) Token: 0x06030D6C RID: 200044 RVA: 0x006A04E9 File Offset: 0x0069E6E9
		public string Type { get; set; }

		// Token: 0x06030D6D RID: 200045 RVA: 0x006A04F2 File Offset: 0x0069E6F2
		public IFlowActionContextT()
		{
			this.Type = null;
		}
	}
}
