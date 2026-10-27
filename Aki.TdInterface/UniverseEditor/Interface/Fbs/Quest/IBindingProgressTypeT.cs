using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D32 RID: 15666
	public class IBindingProgressTypeT
	{
		// Token: 0x17006B78 RID: 27512
		// (get) Token: 0x06015A37 RID: 88631 RVA: 0x0031F96A File Offset: 0x0031DB6A
		// (set) Token: 0x06015A38 RID: 88632 RVA: 0x0031F972 File Offset: 0x0031DB72
		public EBindingProgressType Type { get; set; }

		// Token: 0x06015A39 RID: 88633 RVA: 0x0031F97B File Offset: 0x0031DB7B
		public IBindingProgressTypeT()
		{
			this.Type = EBindingProgressType.PlayerHavingItemCount;
		}
	}
}
