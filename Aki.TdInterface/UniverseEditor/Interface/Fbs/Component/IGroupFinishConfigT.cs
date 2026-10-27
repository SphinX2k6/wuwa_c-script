using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200534E RID: 21326
	public class IGroupFinishConfigT
	{
		// Token: 0x17009CB4 RID: 40116
		// (get) Token: 0x06022E34 RID: 142900 RVA: 0x004D52FE File Offset: 0x004D34FE
		// (set) Token: 0x06022E35 RID: 142901 RVA: 0x004D5306 File Offset: 0x004D3506
		public EGroupFinishConfig Type { get; set; }

		// Token: 0x06022E36 RID: 142902 RVA: 0x004D530F File Offset: 0x004D350F
		public IGroupFinishConfigT()
		{
			this.Type = EGroupFinishConfig.Silence;
		}
	}
}
