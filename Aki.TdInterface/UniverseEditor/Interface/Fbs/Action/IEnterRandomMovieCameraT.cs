using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4A RID: 27978
	public class IEnterRandomMovieCameraT
	{
		// Token: 0x1700CD3A RID: 52538
		// (get) Token: 0x0603042E RID: 197678 RVA: 0x0068F5F3 File Offset: 0x0068D7F3
		// (set) Token: 0x0603042F RID: 197679 RVA: 0x0068F5FB File Offset: 0x0068D7FB
		public EMovieCameraType Type { get; set; }

		// Token: 0x1700CD3B RID: 52539
		// (get) Token: 0x06030430 RID: 197680 RVA: 0x0068F604 File Offset: 0x0068D804
		// (set) Token: 0x06030431 RID: 197681 RVA: 0x0068F60C File Offset: 0x0068D80C
		public List<string> RowNames { get; set; }

		// Token: 0x06030432 RID: 197682 RVA: 0x0068F615 File Offset: 0x0068D815
		public IEnterRandomMovieCameraT()
		{
			this.Type = EMovieCameraType.Common;
			this.RowNames = null;
		}
	}
}
