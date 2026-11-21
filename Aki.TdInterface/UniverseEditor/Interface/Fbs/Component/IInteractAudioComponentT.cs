using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BE RID: 22974
	public class IInteractAudioComponentT
	{
		// Token: 0x1700A6C8 RID: 42696
		// (get) Token: 0x06025769 RID: 153449 RVA: 0x005235BF File Offset: 0x005217BF
		// (set) Token: 0x0602576A RID: 153450 RVA: 0x005235C7 File Offset: 0x005217C7
		public bool Disabled { get; set; }

		// Token: 0x1700A6C9 RID: 42697
		// (get) Token: 0x0602576B RID: 153451 RVA: 0x005235D0 File Offset: 0x005217D0
		// (set) Token: 0x0602576C RID: 153452 RVA: 0x005235D8 File Offset: 0x005217D8
		public EInteractAudioMaterial CollisionMaterial { get; set; }

		// Token: 0x1700A6CA RID: 42698
		// (get) Token: 0x0602576D RID: 153453 RVA: 0x005235E1 File Offset: 0x005217E1
		// (set) Token: 0x0602576E RID: 153454 RVA: 0x005235E9 File Offset: 0x005217E9
		public IAudioEventConfigT InteractEventConfig { get; set; }

		// Token: 0x1700A6CB RID: 42699
		// (get) Token: 0x0602576F RID: 153455 RVA: 0x005235F2 File Offset: 0x005217F2
		// (set) Token: 0x06025770 RID: 153456 RVA: 0x005235FA File Offset: 0x005217FA
		public byte NullMask { get; set; }

		// Token: 0x06025771 RID: 153457 RVA: 0x00523603 File Offset: 0x00521803
		public IInteractAudioComponentT()
		{
			this.Disabled = false;
			this.CollisionMaterial = EInteractAudioMaterial.GrowSolution;
			this.InteractEventConfig = null;
			this.NullMask = 0;
		}
	}
}
