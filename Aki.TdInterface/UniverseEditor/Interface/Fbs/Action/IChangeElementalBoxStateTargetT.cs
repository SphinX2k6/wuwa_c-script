using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D9 RID: 25305
	public class IChangeElementalBoxStateTargetT
	{
		// Token: 0x1700BCE2 RID: 48354
		// (get) Token: 0x0602BBDF RID: 179167 RVA: 0x00604BF6 File Offset: 0x00602DF6
		// (set) Token: 0x0602BBE0 RID: 179168 RVA: 0x00604BFE File Offset: 0x00602DFE
		public EChangeElementalBoxStateTargetType Type { get; set; }

		// Token: 0x0602BBE1 RID: 179169 RVA: 0x00604C07 File Offset: 0x00602E07
		public IChangeElementalBoxStateTargetT()
		{
			this.Type = EChangeElementalBoxStateTargetType.Player;
		}
	}
}
