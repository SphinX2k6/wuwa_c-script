using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DD RID: 30173
	public class IRemovePreloadResourceActionT
	{
		// Token: 0x1700DDC7 RID: 56775
		// (get) Token: 0x06034EF6 RID: 216822 RVA: 0x0071CEC9 File Offset: 0x0071B0C9
		// (set) Token: 0x06034EF7 RID: 216823 RVA: 0x0071CED1 File Offset: 0x0071B0D1
		public TRemovePreloadResourceConfigUnion RemovePreloadResourceObjectType { get; set; }

		// Token: 0x06034EF8 RID: 216824 RVA: 0x0071CEDA File Offset: 0x0071B0DA
		public IRemovePreloadResourceActionT()
		{
			this.RemovePreloadResourceObjectType = null;
		}
	}
}
