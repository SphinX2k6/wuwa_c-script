using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A0 RID: 22944
	public class IInitStateT
	{
		// Token: 0x1700A69D RID: 42653
		// (get) Token: 0x06025683 RID: 153219 RVA: 0x00521D92 File Offset: 0x0051FF92
		// (set) Token: 0x06025684 RID: 153220 RVA: 0x00521D9A File Offset: 0x0051FF9A
		public EInitStateType Type { get; set; }

		// Token: 0x06025685 RID: 153221 RVA: 0x00521DA3 File Offset: 0x0051FFA3
		public IInitStateT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
