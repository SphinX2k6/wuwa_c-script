using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007431 RID: 29745
	public class IPhotographCameraTransformBaseT
	{
		// Token: 0x1700DA79 RID: 55929
		// (get) Token: 0x060340B8 RID: 213176 RVA: 0x0070381A File Offset: 0x00701A1A
		// (set) Token: 0x060340B9 RID: 213177 RVA: 0x00703822 File Offset: 0x00701A22
		public EPhotographCameraTransform Type { get; set; }

		// Token: 0x060340BA RID: 213178 RVA: 0x0070382B File Offset: 0x00701A2B
		public IPhotographCameraTransformBaseT()
		{
			this.Type = EPhotographCameraTransform.Absolute;
		}
	}
}
