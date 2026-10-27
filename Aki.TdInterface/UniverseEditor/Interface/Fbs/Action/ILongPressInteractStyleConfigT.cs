using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A42 RID: 27202
	public class ILongPressInteractStyleConfigT
	{
		// Token: 0x1700C9D7 RID: 51671
		// (get) Token: 0x0602FA16 RID: 195094 RVA: 0x0067BD6A File Offset: 0x00679F6A
		// (set) Token: 0x0602FA17 RID: 195095 RVA: 0x0067BD72 File Offset: 0x00679F72
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x0602FA18 RID: 195096 RVA: 0x0067BD7B File Offset: 0x00679F7B
		public ILongPressInteractStyleConfigT()
		{
			this.Type = ELongPressInteractStyle.Default;
		}
	}
}
