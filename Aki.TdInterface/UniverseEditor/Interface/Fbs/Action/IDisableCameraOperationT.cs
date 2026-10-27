using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065DA RID: 26074
	public class IDisableCameraOperationT
	{
		// Token: 0x1700C183 RID: 49539
		// (get) Token: 0x0602D394 RID: 185236 RVA: 0x00632CAE File Offset: 0x00630EAE
		// (set) Token: 0x0602D395 RID: 185237 RVA: 0x00632CB6 File Offset: 0x00630EB6
		public ECameraOperationType Type { get; set; }

		// Token: 0x0602D396 RID: 185238 RVA: 0x00632CBF File Offset: 0x00630EBF
		public IDisableCameraOperationT()
		{
			this.Type = ECameraOperationType.Enable;
		}
	}
}
