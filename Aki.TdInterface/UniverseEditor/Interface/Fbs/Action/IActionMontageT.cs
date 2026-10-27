using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006081 RID: 24705
	public class IActionMontageT
	{
		// Token: 0x1700B61F RID: 46623
		// (get) Token: 0x06029D9E RID: 171422 RVA: 0x005BDB3F File Offset: 0x005BBD3F
		// (set) Token: 0x06029D9F RID: 171423 RVA: 0x005BDB47 File Offset: 0x005BBD47
		public EActionMontageType MontageType { get; set; }

		// Token: 0x1700B620 RID: 46624
		// (get) Token: 0x06029DA0 RID: 171424 RVA: 0x005BDB50 File Offset: 0x005BBD50
		// (set) Token: 0x06029DA1 RID: 171425 RVA: 0x005BDB58 File Offset: 0x005BBD58
		public string Path { get; set; }

		// Token: 0x06029DA2 RID: 171426 RVA: 0x005BDB61 File Offset: 0x005BBD61
		public IActionMontageT()
		{
			this.MontageType = EActionMontageType.Normal;
			this.Path = null;
		}
	}
}
