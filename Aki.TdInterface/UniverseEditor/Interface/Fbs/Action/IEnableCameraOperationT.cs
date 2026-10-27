using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006652 RID: 26194
	public class IEnableCameraOperationT
	{
		// Token: 0x1700C29E RID: 49822
		// (get) Token: 0x0602D803 RID: 186371 RVA: 0x0063B2C6 File Offset: 0x006394C6
		// (set) Token: 0x0602D804 RID: 186372 RVA: 0x0063B2CE File Offset: 0x006394CE
		public ECameraOperationType Type { get; set; }

		// Token: 0x0602D805 RID: 186373 RVA: 0x0063B2D7 File Offset: 0x006394D7
		public IEnableCameraOperationT()
		{
			this.Type = ECameraOperationType.Enable;
		}
	}
}
