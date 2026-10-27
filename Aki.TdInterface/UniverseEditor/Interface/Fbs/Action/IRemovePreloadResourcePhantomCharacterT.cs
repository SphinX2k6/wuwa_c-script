using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E65 RID: 28261
	public class IRemovePreloadResourcePhantomCharacterT
	{
		// Token: 0x1700D27F RID: 53887
		// (get) Token: 0x06031F08 RID: 204552 RVA: 0x006C19E5 File Offset: 0x006BFBE5
		// (set) Token: 0x06031F09 RID: 204553 RVA: 0x006C19ED File Offset: 0x006BFBED
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x1700D280 RID: 53888
		// (get) Token: 0x06031F0A RID: 204554 RVA: 0x006C19F6 File Offset: 0x006BFBF6
		// (set) Token: 0x06031F0B RID: 204555 RVA: 0x006C19FE File Offset: 0x006BFBFE
		public int Id { get; set; }

		// Token: 0x1700D281 RID: 53889
		// (get) Token: 0x06031F0C RID: 204556 RVA: 0x006C1A07 File Offset: 0x006BFC07
		// (set) Token: 0x06031F0D RID: 204557 RVA: 0x006C1A0F File Offset: 0x006BFC0F
		public IDelayRemoveAfterSkillFinishT DelayReMove { get; set; }

		// Token: 0x06031F0E RID: 204558 RVA: 0x006C1A18 File Offset: 0x006BFC18
		public IRemovePreloadResourcePhantomCharacterT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			this.Id = 0;
			this.DelayReMove = null;
		}
	}
}
