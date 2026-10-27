using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D6 RID: 26326
	public class IEntityActionContextT
	{
		// Token: 0x1700C392 RID: 50066
		// (get) Token: 0x0602DC3F RID: 187455 RVA: 0x00642745 File Offset: 0x00640945
		// (set) Token: 0x0602DC40 RID: 187456 RVA: 0x0064274D File Offset: 0x0064094D
		public string Type { get; set; }

		// Token: 0x0602DC41 RID: 187457 RVA: 0x00642756 File Offset: 0x00640956
		public IEntityActionContextT()
		{
			this.Type = null;
		}
	}
}
