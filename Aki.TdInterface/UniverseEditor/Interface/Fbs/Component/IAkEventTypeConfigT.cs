using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B9 RID: 21433
	public class IAkEventTypeConfigT
	{
		// Token: 0x170097A1 RID: 38817
		// (get) Token: 0x0602175F RID: 137055 RVA: 0x0049D9E6 File Offset: 0x0049BBE6
		// (set) Token: 0x06021760 RID: 137056 RVA: 0x0049D9EE File Offset: 0x0049BBEE
		public EAkEventType Type { get; set; }

		// Token: 0x06021761 RID: 137057 RVA: 0x0049D9F7 File Offset: 0x0049BBF7
		public IAkEventTypeConfigT()
		{
			this.Type = EAkEventType.Point;
		}
	}
}
