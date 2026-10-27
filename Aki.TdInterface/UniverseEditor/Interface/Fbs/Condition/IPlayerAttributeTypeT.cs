using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C86 RID: 19590
	public class IPlayerAttributeTypeT
	{
		// Token: 0x17008E45 RID: 36421
		// (get) Token: 0x0601F12B RID: 127275 RVA: 0x00457B76 File Offset: 0x00455D76
		// (set) Token: 0x0601F12C RID: 127276 RVA: 0x00457B7E File Offset: 0x00455D7E
		public EPlayerAttributeType Type { get; set; }

		// Token: 0x0601F12D RID: 127277 RVA: 0x00457B87 File Offset: 0x00455D87
		public IPlayerAttributeTypeT()
		{
			this.Type = EPlayerAttributeType.Health;
		}
	}
}
