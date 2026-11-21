using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424E RID: 16974
	public class IEventTypeConfigT
	{
		// Token: 0x170073BD RID: 29629
		// (get) Token: 0x06017A0D RID: 96781 RVA: 0x0035EA56 File Offset: 0x0035CC56
		// (set) Token: 0x06017A0E RID: 96782 RVA: 0x0035EA5E File Offset: 0x0035CC5E
		public ECommonEventType Type { get; set; }

		// Token: 0x06017A0F RID: 96783 RVA: 0x0035EA67 File Offset: 0x0035CC67
		public IEventTypeConfigT()
		{
			this.Type = ECommonEventType.VarValueChange;
		}
	}
}
