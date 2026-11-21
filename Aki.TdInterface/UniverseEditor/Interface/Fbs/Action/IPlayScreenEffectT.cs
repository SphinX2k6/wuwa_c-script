using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B7 RID: 29879
	public class IPlayScreenEffectT
	{
		// Token: 0x1700DBC4 RID: 56260
		// (get) Token: 0x060345C1 RID: 214465 RVA: 0x0070D3F8 File Offset: 0x0070B5F8
		// (set) Token: 0x060345C2 RID: 214466 RVA: 0x0070D400 File Offset: 0x0070B600
		public EEffectType Type { get; set; }

		// Token: 0x1700DBC5 RID: 56261
		// (get) Token: 0x060345C3 RID: 214467 RVA: 0x0070D409 File Offset: 0x0070B609
		// (set) Token: 0x060345C4 RID: 214468 RVA: 0x0070D411 File Offset: 0x0070B611
		public string Path { get; set; }

		// Token: 0x1700DBC6 RID: 56262
		// (get) Token: 0x060345C5 RID: 214469 RVA: 0x0070D41A File Offset: 0x0070B61A
		// (set) Token: 0x060345C6 RID: 214470 RVA: 0x0070D422 File Offset: 0x0070B622
		public float DestroyTime { get; set; }

		// Token: 0x1700DBC7 RID: 56263
		// (get) Token: 0x060345C7 RID: 214471 RVA: 0x0070D42B File Offset: 0x0070B62B
		// (set) Token: 0x060345C8 RID: 214472 RVA: 0x0070D433 File Offset: 0x0070B633
		public string BindSubScreenKey { get; set; }

		// Token: 0x1700DBC8 RID: 56264
		// (get) Token: 0x060345C9 RID: 214473 RVA: 0x0070D43C File Offset: 0x0070B63C
		// (set) Token: 0x060345CA RID: 214474 RVA: 0x0070D444 File Offset: 0x0070B644
		public byte NullMask { get; set; }

		// Token: 0x060345CB RID: 214475 RVA: 0x0070D44D File Offset: 0x0070B64D
		public IPlayScreenEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.DestroyTime = 0f;
			this.BindSubScreenKey = null;
			this.NullMask = 0;
		}
	}
}
