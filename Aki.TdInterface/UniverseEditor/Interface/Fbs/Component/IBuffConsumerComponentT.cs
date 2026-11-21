using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005461 RID: 21601
	public class IBuffConsumerComponentT
	{
		// Token: 0x1700999C RID: 39324
		// (get) Token: 0x06021EC6 RID: 138950 RVA: 0x004AD016 File Offset: 0x004AB216
		// (set) Token: 0x06021EC7 RID: 138951 RVA: 0x004AD01E File Offset: 0x004AB21E
		public bool Disabled { get; set; }

		// Token: 0x1700999D RID: 39325
		// (get) Token: 0x06021EC8 RID: 138952 RVA: 0x004AD027 File Offset: 0x004AB227
		// (set) Token: 0x06021EC9 RID: 138953 RVA: 0x004AD02F File Offset: 0x004AB22F
		public long BuffId { get; set; }

		// Token: 0x1700999E RID: 39326
		// (get) Token: 0x06021ECA RID: 138954 RVA: 0x004AD038 File Offset: 0x004AB238
		// (set) Token: 0x06021ECB RID: 138955 RVA: 0x004AD040 File Offset: 0x004AB240
		public long BulletId { get; set; }

		// Token: 0x1700999F RID: 39327
		// (get) Token: 0x06021ECC RID: 138956 RVA: 0x004AD049 File Offset: 0x004AB249
		// (set) Token: 0x06021ECD RID: 138957 RVA: 0x004AD051 File Offset: 0x004AB251
		public int ProducerEntityId { get; set; }

		// Token: 0x170099A0 RID: 39328
		// (get) Token: 0x06021ECE RID: 138958 RVA: 0x004AD05A File Offset: 0x004AB25A
		// (set) Token: 0x06021ECF RID: 138959 RVA: 0x004AD062 File Offset: 0x004AB262
		public byte NullMask { get; set; }

		// Token: 0x06021ED0 RID: 138960 RVA: 0x004AD06B File Offset: 0x004AB26B
		public IBuffConsumerComponentT()
		{
			this.Disabled = false;
			this.BuffId = 0L;
			this.BulletId = 0L;
			this.ProducerEntityId = 0;
			this.NullMask = 0;
		}
	}
}
