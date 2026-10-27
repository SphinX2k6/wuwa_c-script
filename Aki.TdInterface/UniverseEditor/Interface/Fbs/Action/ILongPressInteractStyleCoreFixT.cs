using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4E RID: 27214
	public class ILongPressInteractStyleCoreFixT
	{
		// Token: 0x1700C9E8 RID: 51688
		// (get) Token: 0x0602FA6C RID: 195180 RVA: 0x0067C582 File Offset: 0x0067A782
		// (set) Token: 0x0602FA6D RID: 195181 RVA: 0x0067C58A File Offset: 0x0067A78A
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x0602FA6E RID: 195182 RVA: 0x0067C593 File Offset: 0x0067A793
		public ILongPressInteractStyleCoreFixT()
		{
			this.Type = ELongPressInteractStyle.Default;
		}
	}
}
