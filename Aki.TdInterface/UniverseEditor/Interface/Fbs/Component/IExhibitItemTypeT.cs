using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573A RID: 22330
	public class IExhibitItemTypeT
	{
		// Token: 0x1700A143 RID: 41283
		// (get) Token: 0x06023EEA RID: 147178 RVA: 0x004F0816 File Offset: 0x004EEA16
		// (set) Token: 0x06023EEB RID: 147179 RVA: 0x004F081E File Offset: 0x004EEA1E
		public EExhibitItemType Type { get; set; }

		// Token: 0x06023EEC RID: 147180 RVA: 0x004F0827 File Offset: 0x004EEA27
		public IExhibitItemTypeT()
		{
			this.Type = EExhibitItemType.Phantom;
		}
	}
}
