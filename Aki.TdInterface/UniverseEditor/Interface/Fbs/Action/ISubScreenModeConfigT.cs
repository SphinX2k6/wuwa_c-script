using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007212 RID: 29202
	public class ISubScreenModeConfigT
	{
		// Token: 0x1700D8CD RID: 55501
		// (get) Token: 0x06033CC6 RID: 212166 RVA: 0x006F89F2 File Offset: 0x006F6BF2
		// (set) Token: 0x06033CC7 RID: 212167 RVA: 0x006F89FA File Offset: 0x006F6BFA
		public ESubScreenOperationType Type { get; set; }

		// Token: 0x06033CC8 RID: 212168 RVA: 0x006F8A03 File Offset: 0x006F6C03
		public ISubScreenModeConfigT()
		{
			this.Type = ESubScreenOperationType.Init;
		}
	}
}
