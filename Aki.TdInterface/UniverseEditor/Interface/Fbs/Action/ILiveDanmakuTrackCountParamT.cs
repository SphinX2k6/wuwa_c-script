using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F2 RID: 28914
	public class ILiveDanmakuTrackCountParamT
	{
		// Token: 0x1700D3BF RID: 54207
		// (get) Token: 0x06032370 RID: 205680 RVA: 0x006CAC9C File Offset: 0x006C8E9C
		// (set) Token: 0x06032371 RID: 205681 RVA: 0x006CACA4 File Offset: 0x006C8EA4
		public ELiveParamType Type { get; set; }

		// Token: 0x1700D3C0 RID: 54208
		// (get) Token: 0x06032372 RID: 205682 RVA: 0x006CACAD File Offset: 0x006C8EAD
		// (set) Token: 0x06032373 RID: 205683 RVA: 0x006CACB5 File Offset: 0x006C8EB5
		public int TrackCount { get; set; }

		// Token: 0x06032374 RID: 205684 RVA: 0x006CACBE File Offset: 0x006C8EBE
		public ILiveDanmakuTrackCountParamT()
		{
			this.Type = ELiveParamType.Heat;
			this.TrackCount = 0;
		}
	}
}
