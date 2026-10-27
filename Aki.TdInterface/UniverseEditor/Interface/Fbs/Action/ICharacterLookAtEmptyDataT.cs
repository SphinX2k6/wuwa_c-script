using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006344 RID: 25412
	public class ICharacterLookAtEmptyDataT
	{
		// Token: 0x1700BD9F RID: 48543
		// (get) Token: 0x0602BF54 RID: 180052 RVA: 0x0060AA1E File Offset: 0x00608C1E
		// (set) Token: 0x0602BF55 RID: 180053 RVA: 0x0060AA26 File Offset: 0x00608C26
		public ECharacterLookAt Type { get; set; }

		// Token: 0x0602BF56 RID: 180054 RVA: 0x0060AA2F File Offset: 0x00608C2F
		public ICharacterLookAtEmptyDataT()
		{
			this.Type = ECharacterLookAt.Empty;
		}
	}
}
