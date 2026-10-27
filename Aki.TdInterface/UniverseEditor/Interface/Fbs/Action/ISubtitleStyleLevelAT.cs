using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722A RID: 29226
	public class ISubtitleStyleLevelAT
	{
		// Token: 0x1700D8EE RID: 55534
		// (get) Token: 0x06033D7E RID: 212350 RVA: 0x006F9E16 File Offset: 0x006F8016
		// (set) Token: 0x06033D7F RID: 212351 RVA: 0x006F9E1E File Offset: 0x006F801E
		public ESubtitleStyle Type { get; set; }

		// Token: 0x06033D80 RID: 212352 RVA: 0x006F9E27 File Offset: 0x006F8027
		public ISubtitleStyleLevelAT()
		{
			this.Type = ESubtitleStyle.LevelA;
		}
	}
}
