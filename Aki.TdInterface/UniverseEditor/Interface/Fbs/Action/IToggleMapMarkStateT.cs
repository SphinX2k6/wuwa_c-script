using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BFA RID: 31738
	public class IToggleMapMarkStateT
	{
		// Token: 0x1700EDBD RID: 60861
		// (get) Token: 0x0603935C RID: 234332 RVA: 0x007BA8EA File Offset: 0x007B8AEA
		// (set) Token: 0x0603935D RID: 234333 RVA: 0x007BA8F2 File Offset: 0x007B8AF2
		public EMapMarkState Type { get; set; }

		// Token: 0x0603935E RID: 234334 RVA: 0x007BA8FB File Offset: 0x007B8AFB
		public IToggleMapMarkStateT()
		{
			this.Type = EMapMarkState.Show;
		}
	}
}
