using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429F RID: 17055
	public class IWordArtConfigT
	{
		// Token: 0x17007913 RID: 30995
		// (get) Token: 0x06019457 RID: 103511 RVA: 0x003A11FB File Offset: 0x0039F3FB
		// (set) Token: 0x06019458 RID: 103512 RVA: 0x003A1203 File Offset: 0x0039F403
		public INumberWordArtEffectiveTargetTypeT EffectiveTarget { get; set; }

		// Token: 0x17007914 RID: 30996
		// (get) Token: 0x06019459 RID: 103513 RVA: 0x003A120C File Offset: 0x0039F40C
		// (set) Token: 0x0601945A RID: 103514 RVA: 0x003A1214 File Offset: 0x0039F414
		public IWordArtDefaultResourceTypeT Resource { get; set; }

		// Token: 0x0601945B RID: 103515 RVA: 0x003A121D File Offset: 0x0039F41D
		public IWordArtConfigT()
		{
			this.EffectiveTarget = null;
			this.Resource = null;
		}
	}
}
