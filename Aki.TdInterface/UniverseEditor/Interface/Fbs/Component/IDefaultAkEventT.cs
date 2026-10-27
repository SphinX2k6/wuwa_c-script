using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005079 RID: 20601
	public class IDefaultAkEventT
	{
		// Token: 0x17009577 RID: 38263
		// (get) Token: 0x0602106D RID: 135277 RVA: 0x004967CE File Offset: 0x004949CE
		// (set) Token: 0x0602106E RID: 135278 RVA: 0x004967D6 File Offset: 0x004949D6
		public EAkEventType Type { get; set; }

		// Token: 0x0602106F RID: 135279 RVA: 0x004967DF File Offset: 0x004949DF
		public IDefaultAkEventT()
		{
			this.Type = EAkEventType.Point;
		}
	}
}
