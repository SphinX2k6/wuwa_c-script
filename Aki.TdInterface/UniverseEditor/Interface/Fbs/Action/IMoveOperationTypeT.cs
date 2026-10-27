using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4F RID: 27471
	public class IMoveOperationTypeT
	{
		// Token: 0x1700CC1E RID: 52254
		// (get) Token: 0x06030387 RID: 197511 RVA: 0x0068D6AE File Offset: 0x0068B8AE
		// (set) Token: 0x06030388 RID: 197512 RVA: 0x0068D6B6 File Offset: 0x0068B8B6
		public EMoveOperationType Type { get; set; }

		// Token: 0x06030389 RID: 197513 RVA: 0x0068D6BF File Offset: 0x0068B8BF
		public IMoveOperationTypeT()
		{
			this.Type = EMoveOperationType.Enable;
		}
	}
}
