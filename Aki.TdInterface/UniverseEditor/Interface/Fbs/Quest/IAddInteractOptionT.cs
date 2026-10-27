using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF3 RID: 15603
	public class IAddInteractOptionT
	{
		// Token: 0x17006AF5 RID: 27381
		// (get) Token: 0x060157DF RID: 88031 RVA: 0x0031AD63 File Offset: 0x00318F63
		// (set) Token: 0x060157E0 RID: 88032 RVA: 0x0031AD6B File Offset: 0x00318F6B
		public IInteractOptionT Option { get; set; }

		// Token: 0x17006AF6 RID: 27382
		// (get) Token: 0x060157E1 RID: 88033 RVA: 0x0031AD74 File Offset: 0x00318F74
		// (set) Token: 0x060157E2 RID: 88034 RVA: 0x0031AD7C File Offset: 0x00318F7C
		public int EntityId { get; set; }

		// Token: 0x17006AF7 RID: 27383
		// (get) Token: 0x060157E3 RID: 88035 RVA: 0x0031AD85 File Offset: 0x00318F85
		// (set) Token: 0x060157E4 RID: 88036 RVA: 0x0031AD8D File Offset: 0x00318F8D
		public bool IsManualFinish { get; set; }

		// Token: 0x17006AF8 RID: 27384
		// (get) Token: 0x060157E5 RID: 88037 RVA: 0x0031AD96 File Offset: 0x00318F96
		// (set) Token: 0x060157E6 RID: 88038 RVA: 0x0031AD9E File Offset: 0x00318F9E
		public bool IsManualDelete { get; set; }

		// Token: 0x17006AF9 RID: 27385
		// (get) Token: 0x060157E7 RID: 88039 RVA: 0x0031ADA7 File Offset: 0x00318FA7
		// (set) Token: 0x060157E8 RID: 88040 RVA: 0x0031ADAF File Offset: 0x00318FAF
		public string InteractToken { get; set; }

		// Token: 0x17006AFA RID: 27386
		// (get) Token: 0x060157E9 RID: 88041 RVA: 0x0031ADB8 File Offset: 0x00318FB8
		// (set) Token: 0x060157EA RID: 88042 RVA: 0x0031ADC0 File Offset: 0x00318FC0
		public byte NullMask { get; set; }

		// Token: 0x060157EB RID: 88043 RVA: 0x0031ADC9 File Offset: 0x00318FC9
		public IAddInteractOptionT()
		{
			this.Option = null;
			this.EntityId = 0;
			this.IsManualFinish = false;
			this.IsManualDelete = false;
			this.InteractToken = null;
			this.NullMask = 0;
		}
	}
}
