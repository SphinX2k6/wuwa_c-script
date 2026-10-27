using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007179 RID: 29049
	public class ISpecificScanEffectT
	{
		// Token: 0x1700D7CE RID: 55246
		// (get) Token: 0x06033813 RID: 210963 RVA: 0x006F029A File Offset: 0x006EE49A
		// (set) Token: 0x06033814 RID: 210964 RVA: 0x006F02A2 File Offset: 0x006EE4A2
		public ESpecificScanType Type { get; set; }

		// Token: 0x06033815 RID: 210965 RVA: 0x006F02AB File Offset: 0x006EE4AB
		public ISpecificScanEffectT()
		{
			this.Type = ESpecificScanType.None;
		}
	}
}
