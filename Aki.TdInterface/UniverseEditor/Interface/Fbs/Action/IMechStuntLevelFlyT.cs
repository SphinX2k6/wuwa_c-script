using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C0 RID: 29120
	public class IMechStuntLevelFlyT
	{
		// Token: 0x1700D541 RID: 54593
		// (get) Token: 0x06032A74 RID: 207476 RVA: 0x006D7F16 File Offset: 0x006D6116
		// (set) Token: 0x06032A75 RID: 207477 RVA: 0x006D7F1E File Offset: 0x006D611E
		public EMechStuntType Type { get; set; }

		// Token: 0x06032A76 RID: 207478 RVA: 0x006D7F27 File Offset: 0x006D6127
		public IMechStuntLevelFlyT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
