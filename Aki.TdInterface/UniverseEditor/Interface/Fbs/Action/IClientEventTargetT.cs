using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1E RID: 27166
	public class IClientEventTargetT
	{
		// Token: 0x1700C7B8 RID: 51128
		// (get) Token: 0x0602E9AF RID: 190895 RVA: 0x0065AEA2 File Offset: 0x006590A2
		// (set) Token: 0x0602E9B0 RID: 190896 RVA: 0x0065AEAA File Offset: 0x006590AA
		public EClientEventTarget Type { get; set; }

		// Token: 0x0602E9B1 RID: 190897 RVA: 0x0065AEB3 File Offset: 0x006590B3
		public IClientEventTargetT()
		{
			this.Type = EClientEventTarget.Self;
		}
	}
}
