using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DEC RID: 32236
	public class IVisualNovelStopScreenEffectPersistentT
	{
		// Token: 0x1700F17D RID: 61821
		// (get) Token: 0x0603A41D RID: 238621 RVA: 0x007D9AB3 File Offset: 0x007D7CB3
		// (set) Token: 0x0603A41E RID: 238622 RVA: 0x007D9ABB File Offset: 0x007D7CBB
		public EVisualNovelStopScreenEffectType Type { get; set; }

		// Token: 0x1700F17E RID: 61822
		// (get) Token: 0x0603A41F RID: 238623 RVA: 0x007D9AC4 File Offset: 0x007D7CC4
		// (set) Token: 0x0603A420 RID: 238624 RVA: 0x007D9ACC File Offset: 0x007D7CCC
		public string PersistentEffectPath { get; set; }

		// Token: 0x0603A421 RID: 238625 RVA: 0x007D9AD5 File Offset: 0x007D7CD5
		public IVisualNovelStopScreenEffectPersistentT()
		{
			this.Type = EVisualNovelStopScreenEffectType.Persistent;
			this.PersistentEffectPath = null;
		}
	}
}
