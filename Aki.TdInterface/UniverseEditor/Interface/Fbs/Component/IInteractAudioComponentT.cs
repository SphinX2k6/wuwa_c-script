using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005438 RID: 21560
	public class IInteractAudioComponentT
	{
		// Token: 0x17009E8E RID: 40590
		// (get) Token: 0x060236B1 RID: 145073 RVA: 0x004E6593 File Offset: 0x004E4793
		// (set) Token: 0x060236B2 RID: 145074 RVA: 0x004E659B File Offset: 0x004E479B
		public bool Disabled { get; set; }

		// Token: 0x17009E8F RID: 40591
		// (get) Token: 0x060236B3 RID: 145075 RVA: 0x004E65A4 File Offset: 0x004E47A4
		// (set) Token: 0x060236B4 RID: 145076 RVA: 0x004E65AC File Offset: 0x004E47AC
		public EInteractAudioMaterial CollisionMaterial { get; set; }

		// Token: 0x17009E90 RID: 40592
		// (get) Token: 0x060236B5 RID: 145077 RVA: 0x004E65B5 File Offset: 0x004E47B5
		// (set) Token: 0x060236B6 RID: 145078 RVA: 0x004E65BD File Offset: 0x004E47BD
		public IAudioEventConfigT InteractEventConfig { get; set; }

		// Token: 0x17009E91 RID: 40593
		// (get) Token: 0x060236B7 RID: 145079 RVA: 0x004E65C6 File Offset: 0x004E47C6
		// (set) Token: 0x060236B8 RID: 145080 RVA: 0x004E65CE File Offset: 0x004E47CE
		public byte NullMask { get; set; }

		// Token: 0x060236B9 RID: 145081 RVA: 0x004E65D7 File Offset: 0x004E47D7
		public IInteractAudioComponentT()
		{
			this.Disabled = false;
			this.CollisionMaterial = EInteractAudioMaterial.GrowSolution;
			this.InteractEventConfig = null;
			this.NullMask = 0;
		}
	}
}
