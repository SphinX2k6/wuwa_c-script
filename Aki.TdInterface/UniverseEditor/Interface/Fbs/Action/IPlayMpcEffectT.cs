using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AB RID: 29867
	public class IPlayMpcEffectT
	{
		// Token: 0x1700DB8B RID: 56203
		// (get) Token: 0x0603451B RID: 214299 RVA: 0x0070BFDD File Offset: 0x0070A1DD
		// (set) Token: 0x0603451C RID: 214300 RVA: 0x0070BFE5 File Offset: 0x0070A1E5
		public EEffectType Type { get; set; }

		// Token: 0x1700DB8C RID: 56204
		// (get) Token: 0x0603451D RID: 214301 RVA: 0x0070BFEE File Offset: 0x0070A1EE
		// (set) Token: 0x0603451E RID: 214302 RVA: 0x0070BFF6 File Offset: 0x0070A1F6
		public string Path { get; set; }

		// Token: 0x1700DB8D RID: 56205
		// (get) Token: 0x0603451F RID: 214303 RVA: 0x0070BFFF File Offset: 0x0070A1FF
		// (set) Token: 0x06034520 RID: 214304 RVA: 0x0070C007 File Offset: 0x0070A207
		public TPos2Union Pos2 { get; set; }

		// Token: 0x1700DB8E RID: 56206
		// (get) Token: 0x06034521 RID: 214305 RVA: 0x0070C010 File Offset: 0x0070A210
		// (set) Token: 0x06034522 RID: 214306 RVA: 0x0070C018 File Offset: 0x0070A218
		public List<IPostProcessVolumeCenterPositionT> Params { get; set; }

		// Token: 0x06034523 RID: 214307 RVA: 0x0070C021 File Offset: 0x0070A221
		public IPlayMpcEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.Pos2 = null;
			this.Params = null;
		}
	}
}
