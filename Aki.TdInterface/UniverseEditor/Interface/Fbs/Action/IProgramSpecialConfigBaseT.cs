using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200752C RID: 29996
	public class IProgramSpecialConfigBaseT
	{
		// Token: 0x1700DCAE RID: 56494
		// (get) Token: 0x060349A1 RID: 215457 RVA: 0x007141BE File Offset: 0x007123BE
		// (set) Token: 0x060349A2 RID: 215458 RVA: 0x007141C6 File Offset: 0x007123C6
		public EPlayMovieProgramSpecialConfigType Type { get; set; }

		// Token: 0x060349A3 RID: 215459 RVA: 0x007141CF File Offset: 0x007123CF
		public IProgramSpecialConfigBaseT()
		{
			this.Type = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
		}
	}
}
