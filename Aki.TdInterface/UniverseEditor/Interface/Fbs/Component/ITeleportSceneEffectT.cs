using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200605D RID: 24669
	public class ITeleportSceneEffectT
	{
		// Token: 0x1700B724 RID: 46884
		// (get) Token: 0x06029A92 RID: 170642 RVA: 0x005AFF26 File Offset: 0x005AE126
		// (set) Token: 0x06029A93 RID: 170643 RVA: 0x005AFF2E File Offset: 0x005AE12E
		public string WorldEffectPath { get; set; }

		// Token: 0x1700B725 RID: 46885
		// (get) Token: 0x06029A94 RID: 170644 RVA: 0x005AFF37 File Offset: 0x005AE137
		// (set) Token: 0x06029A95 RID: 170645 RVA: 0x005AFF3F File Offset: 0x005AE13F
		public string ScreenEffectPath { get; set; }

		// Token: 0x06029A96 RID: 170646 RVA: 0x005AFF48 File Offset: 0x005AE148
		public ITeleportSceneEffectT()
		{
			this.WorldEffectPath = null;
			this.ScreenEffectPath = null;
		}
	}
}
