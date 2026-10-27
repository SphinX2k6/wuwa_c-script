using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F6 RID: 23030
	public class ISunSpiritCollectComponentT
	{
		// Token: 0x1700AD09 RID: 44297
		// (get) Token: 0x0602715A RID: 160090 RVA: 0x00560929 File Offset: 0x0055EB29
		// (set) Token: 0x0602715B RID: 160091 RVA: 0x00560931 File Offset: 0x0055EB31
		public bool Disabled { get; set; }

		// Token: 0x1700AD0A RID: 44298
		// (get) Token: 0x0602715C RID: 160092 RVA: 0x0056093A File Offset: 0x0055EB3A
		// (set) Token: 0x0602715D RID: 160093 RVA: 0x00560942 File Offset: 0x0055EB42
		public int AreaId { get; set; }

		// Token: 0x1700AD0B RID: 44299
		// (get) Token: 0x0602715E RID: 160094 RVA: 0x0056094B File Offset: 0x0055EB4B
		// (set) Token: 0x0602715F RID: 160095 RVA: 0x00560953 File Offset: 0x0055EB53
		public float SunSpiritScale { get; set; }

		// Token: 0x1700AD0C RID: 44300
		// (get) Token: 0x06027160 RID: 160096 RVA: 0x0056095C File Offset: 0x0055EB5C
		// (set) Token: 0x06027161 RID: 160097 RVA: 0x00560964 File Offset: 0x0055EB64
		public ISunSpiritPlayerBattleConfigT PlayerBattleConfig { get; set; }

		// Token: 0x1700AD0D RID: 44301
		// (get) Token: 0x06027162 RID: 160098 RVA: 0x0056096D File Offset: 0x0055EB6D
		// (set) Token: 0x06027163 RID: 160099 RVA: 0x00560975 File Offset: 0x0055EB75
		public byte NullMask { get; set; }

		// Token: 0x06027164 RID: 160100 RVA: 0x0056097E File Offset: 0x0055EB7E
		public ISunSpiritCollectComponentT()
		{
			this.Disabled = false;
			this.AreaId = 0;
			this.SunSpiritScale = 0f;
			this.PlayerBattleConfig = null;
			this.NullMask = 0;
		}
	}
}
