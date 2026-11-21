using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745D RID: 29789
	public class IPlayEffect2T
	{
		// Token: 0x1700DAEC RID: 56044
		// (get) Token: 0x06034275 RID: 213621 RVA: 0x00706EE3 File Offset: 0x007050E3
		// (set) Token: 0x06034276 RID: 213622 RVA: 0x00706EEB File Offset: 0x007050EB
		public EEffectType Type { get; set; }

		// Token: 0x1700DAED RID: 56045
		// (get) Token: 0x06034277 RID: 213623 RVA: 0x00706EF4 File Offset: 0x007050F4
		// (set) Token: 0x06034278 RID: 213624 RVA: 0x00706EFC File Offset: 0x007050FC
		public string Path { get; set; }

		// Token: 0x06034279 RID: 213625 RVA: 0x00706F05 File Offset: 0x00705105
		public IPlayEffect2T()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
		}
	}
}
