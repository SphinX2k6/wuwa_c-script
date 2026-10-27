using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D0 RID: 26320
	public class IEnterRandomMovieCameraT
	{
		// Token: 0x1700C389 RID: 50057
		// (get) Token: 0x0602DC11 RID: 187409 RVA: 0x0064233F File Offset: 0x0064053F
		// (set) Token: 0x0602DC12 RID: 187410 RVA: 0x00642347 File Offset: 0x00640547
		public EMovieCameraType Type { get; set; }

		// Token: 0x1700C38A RID: 50058
		// (get) Token: 0x0602DC13 RID: 187411 RVA: 0x00642350 File Offset: 0x00640550
		// (set) Token: 0x0602DC14 RID: 187412 RVA: 0x00642358 File Offset: 0x00640558
		public List<string> RowNames { get; set; }

		// Token: 0x0602DC15 RID: 187413 RVA: 0x00642361 File Offset: 0x00640561
		public IEnterRandomMovieCameraT()
		{
			this.Type = EMovieCameraType.Common;
			this.RowNames = null;
		}
	}
}
