using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007224 RID: 29220
	public class ISubtitleStyleBaseT
	{
		// Token: 0x1700D8E9 RID: 55529
		// (get) Token: 0x06033D5E RID: 212318 RVA: 0x006F9B56 File Offset: 0x006F7D56
		// (set) Token: 0x06033D5F RID: 212319 RVA: 0x006F9B5E File Offset: 0x006F7D5E
		public ESubtitleStyle Type { get; set; }

		// Token: 0x06033D60 RID: 212320 RVA: 0x006F9B67 File Offset: 0x006F7D67
		public ISubtitleStyleBaseT()
		{
			this.Type = ESubtitleStyle.LevelA;
		}
	}
}
