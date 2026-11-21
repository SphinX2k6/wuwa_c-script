using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760A RID: 30218
	public class IResetEntityPosT
	{
		// Token: 0x1700DE0A RID: 56842
		// (get) Token: 0x06035057 RID: 217175 RVA: 0x0071F66A File Offset: 0x0071D86A
		// (set) Token: 0x06035058 RID: 217176 RVA: 0x0071F672 File Offset: 0x0071D872
		public int EntityId { get; set; }

		// Token: 0x06035059 RID: 217177 RVA: 0x0071F67B File Offset: 0x0071D87B
		public IResetEntityPosT()
		{
			this.EntityId = 0;
		}
	}
}
