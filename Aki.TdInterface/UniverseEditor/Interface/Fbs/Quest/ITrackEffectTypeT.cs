using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004650 RID: 18000
	public class ITrackEffectTypeT
	{
		// Token: 0x17007E0B RID: 32267
		// (get) Token: 0x0601A604 RID: 108036 RVA: 0x003C1212 File Offset: 0x003BF412
		// (set) Token: 0x0601A605 RID: 108037 RVA: 0x003C121A File Offset: 0x003BF41A
		public ETrackEffectType Type { get; set; }

		// Token: 0x0601A606 RID: 108038 RVA: 0x003C1223 File Offset: 0x003BF423
		public ITrackEffectTypeT()
		{
			this.Type = ETrackEffectType.AutoChange;
		}
	}
}
