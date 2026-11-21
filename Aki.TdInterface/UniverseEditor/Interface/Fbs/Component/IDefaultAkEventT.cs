using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DE RID: 21982
	public class IDefaultAkEventT
	{
		// Token: 0x17009D64 RID: 40292
		// (get) Token: 0x06022FC1 RID: 143297 RVA: 0x004D0712 File Offset: 0x004CE912
		// (set) Token: 0x06022FC2 RID: 143298 RVA: 0x004D071A File Offset: 0x004CE91A
		public EAkEventType Type { get; set; }

		// Token: 0x06022FC3 RID: 143299 RVA: 0x004D0723 File Offset: 0x004CE923
		public IDefaultAkEventT()
		{
			this.Type = EAkEventType.Point;
		}
	}
}
