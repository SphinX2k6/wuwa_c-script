using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542C RID: 21548
	public class IInitStateWuYinQuT
	{
		// Token: 0x17009E81 RID: 40577
		// (get) Token: 0x06023665 RID: 144997 RVA: 0x004E5DC6 File Offset: 0x004E3FC6
		// (set) Token: 0x06023666 RID: 144998 RVA: 0x004E5DCE File Offset: 0x004E3FCE
		public EInitStateType Type { get; set; }

		// Token: 0x06023667 RID: 144999 RVA: 0x004E5DD7 File Offset: 0x004E3FD7
		public IInitStateWuYinQuT()
		{
			this.Type = EInitStateType.Birth;
		}
	}
}
