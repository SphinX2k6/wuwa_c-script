using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B4 RID: 29108
	public class IMechStuntConfigTypeT
	{
		// Token: 0x1700D536 RID: 54582
		// (get) Token: 0x06032A28 RID: 207400 RVA: 0x006D7862 File Offset: 0x006D5A62
		// (set) Token: 0x06032A29 RID: 207401 RVA: 0x006D786A File Offset: 0x006D5A6A
		public EMechStuntType Type { get; set; }

		// Token: 0x06032A2A RID: 207402 RVA: 0x006D7873 File Offset: 0x006D5A73
		public IMechStuntConfigTypeT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
