using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748A RID: 29834
	public class IPlayerSlideRailEndT
	{
		// Token: 0x1700DB2A RID: 56106
		// (get) Token: 0x060343AE RID: 213934 RVA: 0x00708E8E File Offset: 0x0070708E
		// (set) Token: 0x060343AF RID: 213935 RVA: 0x00708E96 File Offset: 0x00707096
		public ESlideRailEndType Type { get; set; }

		// Token: 0x060343B0 RID: 213936 RVA: 0x00708E9F File Offset: 0x0070709F
		public IPlayerSlideRailEndT()
		{
			this.Type = ESlideRailEndType.Player;
		}
	}
}
