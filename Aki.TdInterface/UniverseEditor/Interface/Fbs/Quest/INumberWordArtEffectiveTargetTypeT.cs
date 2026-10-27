using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F60 RID: 16224
	public class INumberWordArtEffectiveTargetTypeT
	{
		// Token: 0x170070D3 RID: 28883
		// (get) Token: 0x06017140 RID: 94528 RVA: 0x003539AE File Offset: 0x00351BAE
		// (set) Token: 0x06017141 RID: 94529 RVA: 0x003539B6 File Offset: 0x00351BB6
		public EWordArtEffectiveTargetType Type { get; set; }

		// Token: 0x170070D4 RID: 28884
		// (get) Token: 0x06017142 RID: 94530 RVA: 0x003539BF File Offset: 0x00351BBF
		// (set) Token: 0x06017143 RID: 94531 RVA: 0x003539C7 File Offset: 0x00351BC7
		public bool ShowUiMotion { get; set; }

		// Token: 0x170070D5 RID: 28885
		// (get) Token: 0x06017144 RID: 94532 RVA: 0x003539D0 File Offset: 0x00351BD0
		// (set) Token: 0x06017145 RID: 94533 RVA: 0x003539D8 File Offset: 0x00351BD8
		public byte NullMask { get; set; }

		// Token: 0x06017146 RID: 94534 RVA: 0x003539E1 File Offset: 0x00351BE1
		public INumberWordArtEffectiveTargetTypeT()
		{
			this.Type = EWordArtEffectiveTargetType.Number;
			this.ShowUiMotion = false;
			this.NullMask = 0;
		}
	}
}
