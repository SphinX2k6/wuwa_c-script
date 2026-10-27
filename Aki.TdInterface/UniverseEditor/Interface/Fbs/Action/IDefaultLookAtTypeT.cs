using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006559 RID: 25945
	public class IDefaultLookAtTypeT
	{
		// Token: 0x1700C0D9 RID: 49369
		// (get) Token: 0x0602D04C RID: 184396 RVA: 0x0062DBDE File Offset: 0x0062BDDE
		// (set) Token: 0x0602D04D RID: 184397 RVA: 0x0062DBE6 File Offset: 0x0062BDE6
		public EDefaultLookAtType Type { get; set; }

		// Token: 0x0602D04E RID: 184398 RVA: 0x0062DBEF File Offset: 0x0062BDEF
		public IDefaultLookAtTypeT()
		{
			this.Type = EDefaultLookAtType.LookAtBubbleEntity;
		}
	}
}
