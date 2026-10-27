using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5C RID: 28252
	public class IRemovePreloadResourceActionT
	{
		// Token: 0x1700D275 RID: 53877
		// (get) Token: 0x06031ECE RID: 204494 RVA: 0x006C13C9 File Offset: 0x006BF5C9
		// (set) Token: 0x06031ECF RID: 204495 RVA: 0x006C13D1 File Offset: 0x006BF5D1
		public TRemovePreloadResourceConfigUnion RemovePreloadResourceObjectType { get; set; }

		// Token: 0x06031ED0 RID: 204496 RVA: 0x006C13DA File Offset: 0x006BF5DA
		public IRemovePreloadResourceActionT()
		{
			this.RemovePreloadResourceObjectType = null;
		}
	}
}
