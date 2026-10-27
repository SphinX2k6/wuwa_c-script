using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556A RID: 21866
	public class IMonsterChooseTypeT
	{
		// Token: 0x1700A18D RID: 41357
		// (get) Token: 0x060242CD RID: 148173 RVA: 0x004FF0FA File Offset: 0x004FD2FA
		// (set) Token: 0x060242CE RID: 148174 RVA: 0x004FF102 File Offset: 0x004FD302
		public EMonsterChooseType Type { get; set; }

		// Token: 0x060242CF RID: 148175 RVA: 0x004FF10B File Offset: 0x004FD30B
		public IMonsterChooseTypeT()
		{
			this.Type = EMonsterChooseType.RandomPoolChoose;
		}
	}
}
