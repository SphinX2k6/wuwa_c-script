using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E90 RID: 20112
	public class IAkEventTypeConfigT
	{
		// Token: 0x17009042 RID: 36930
		// (get) Token: 0x0601FA6A RID: 129642 RVA: 0x00468782 File Offset: 0x00466982
		// (set) Token: 0x0601FA6B RID: 129643 RVA: 0x0046878A File Offset: 0x0046698A
		public EAkEventType Type { get; set; }

		// Token: 0x0601FA6C RID: 129644 RVA: 0x00468793 File Offset: 0x00466993
		public IAkEventTypeConfigT()
		{
			this.Type = EAkEventType.Point;
		}
	}
}
