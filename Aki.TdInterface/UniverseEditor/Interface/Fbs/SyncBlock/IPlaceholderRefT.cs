using System;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F87 RID: 16263
	public class IPlaceholderRefT
	{
		// Token: 0x17006E10 RID: 28176
		// (get) Token: 0x0601629F RID: 90783 RVA: 0x0032DC44 File Offset: 0x0032BE44
		// (set) Token: 0x060162A0 RID: 90784 RVA: 0x0032DC4C File Offset: 0x0032BE4C
		public TPlaceholderType Type { get; set; }

		// Token: 0x17006E11 RID: 28177
		// (get) Token: 0x060162A1 RID: 90785 RVA: 0x0032DC55 File Offset: 0x0032BE55
		// (set) Token: 0x060162A2 RID: 90786 RVA: 0x0032DC5D File Offset: 0x0032BE5D
		public string Name { get; set; }

		// Token: 0x17006E12 RID: 28178
		// (get) Token: 0x060162A3 RID: 90787 RVA: 0x0032DC66 File Offset: 0x0032BE66
		// (set) Token: 0x060162A4 RID: 90788 RVA: 0x0032DC6E File Offset: 0x0032BE6E
		public string FieldName { get; set; }

		// Token: 0x060162A5 RID: 90789 RVA: 0x0032DC77 File Offset: 0x0032BE77
		public IPlaceholderRefT()
		{
			this.Type = TPlaceholderType.BuffIdList;
			this.Name = null;
			this.FieldName = null;
		}
	}
}
