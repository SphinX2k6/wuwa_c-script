using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C38 RID: 15416
	public class IRequestResultT
	{
		// Token: 0x17006A2C RID: 27180
		// (get) Token: 0x060154A1 RID: 87201 RVA: 0x00314DAF File Offset: 0x00312FAF
		// (set) Token: 0x060154A2 RID: 87202 RVA: 0x00314DB7 File Offset: 0x00312FB7
		public bool IsSuccess { get; set; }

		// Token: 0x17006A2D RID: 27181
		// (get) Token: 0x060154A3 RID: 87203 RVA: 0x00314DC0 File Offset: 0x00312FC0
		// (set) Token: 0x060154A4 RID: 87204 RVA: 0x00314DC8 File Offset: 0x00312FC8
		public string Reason { get; set; }

		// Token: 0x060154A5 RID: 87205 RVA: 0x00314DD1 File Offset: 0x00312FD1
		public IRequestResultT()
		{
			this.IsSuccess = false;
			this.Reason = null;
		}
	}
}
