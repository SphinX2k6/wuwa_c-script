using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006207 RID: 25095
	public class IBlendAnimTargetBaseT
	{
		// Token: 0x1700BB12 RID: 47890
		// (get) Token: 0x0602B433 RID: 177203 RVA: 0x005F5B66 File Offset: 0x005F3D66
		// (set) Token: 0x0602B434 RID: 177204 RVA: 0x005F5B6E File Offset: 0x005F3D6E
		public EBlendAnimTarget Type { get; set; }

		// Token: 0x0602B435 RID: 177205 RVA: 0x005F5B77 File Offset: 0x005F3D77
		public IBlendAnimTargetBaseT()
		{
			this.Type = EBlendAnimTarget.Player;
		}
	}
}
