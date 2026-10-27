using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D07 RID: 19719
	public class ITriggeredEntityT
	{
		// Token: 0x17008F0D RID: 36621
		// (get) Token: 0x0601F4CE RID: 128206 RVA: 0x0045DB32 File Offset: 0x0045BD32
		// (set) Token: 0x0601F4CF RID: 128207 RVA: 0x0045DB3A File Offset: 0x0045BD3A
		public ETargetEntityType Type { get; set; }

		// Token: 0x0601F4D0 RID: 128208 RVA: 0x0045DB43 File Offset: 0x0045BD43
		public ITriggeredEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
