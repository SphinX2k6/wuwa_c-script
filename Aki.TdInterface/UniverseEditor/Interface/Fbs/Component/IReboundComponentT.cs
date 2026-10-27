using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580C RID: 22540
	public class IReboundComponentT
	{
		// Token: 0x1700A864 RID: 43108
		// (get) Token: 0x06025E5B RID: 155227 RVA: 0x00539F27 File Offset: 0x00538127
		// (set) Token: 0x06025E5C RID: 155228 RVA: 0x00539F2F File Offset: 0x0053812F
		public bool Disabled { get; set; }

		// Token: 0x1700A865 RID: 43109
		// (get) Token: 0x06025E5D RID: 155229 RVA: 0x00539F38 File Offset: 0x00538138
		// (set) Token: 0x06025E5E RID: 155230 RVA: 0x00539F40 File Offset: 0x00538140
		public long BulletId { get; set; }

		// Token: 0x1700A866 RID: 43110
		// (get) Token: 0x06025E5F RID: 155231 RVA: 0x00539F49 File Offset: 0x00538149
		// (set) Token: 0x06025E60 RID: 155232 RVA: 0x00539F51 File Offset: 0x00538151
		public IForwardFrontReboundT Option { get; set; }

		// Token: 0x1700A867 RID: 43111
		// (get) Token: 0x06025E61 RID: 155233 RVA: 0x00539F5A File Offset: 0x0053815A
		// (set) Token: 0x06025E62 RID: 155234 RVA: 0x00539F62 File Offset: 0x00538162
		public byte NullMask { get; set; }

		// Token: 0x06025E63 RID: 155235 RVA: 0x00539F6B File Offset: 0x0053816B
		public IReboundComponentT()
		{
			this.Disabled = false;
			this.BulletId = 0L;
			this.Option = null;
			this.NullMask = 0;
		}
	}
}
