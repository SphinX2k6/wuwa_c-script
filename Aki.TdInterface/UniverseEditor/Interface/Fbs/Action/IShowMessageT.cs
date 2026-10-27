using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E6 RID: 28902
	public class IShowMessageT
	{
		// Token: 0x1700D6C8 RID: 54984
		// (get) Token: 0x06033357 RID: 209751 RVA: 0x006E72B5 File Offset: 0x006E54B5
		// (set) Token: 0x06033358 RID: 209752 RVA: 0x006E72BD File Offset: 0x006E54BD
		public string Content { get; set; }

		// Token: 0x06033359 RID: 209753 RVA: 0x006E72C6 File Offset: 0x006E54C6
		public IShowMessageT()
		{
			this.Content = null;
		}
	}
}
