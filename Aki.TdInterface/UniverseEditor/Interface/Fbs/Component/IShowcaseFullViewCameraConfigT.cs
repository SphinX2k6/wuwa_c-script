using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F1C RID: 24348
	public class IShowcaseFullViewCameraConfigT
	{
		// Token: 0x1700B419 RID: 46105
		// (get) Token: 0x06028DF0 RID: 167408 RVA: 0x00595ADF File Offset: 0x00593CDF
		// (set) Token: 0x06028DF1 RID: 167409 RVA: 0x00595AE7 File Offset: 0x00593CE7
		public float Fov { get; set; }

		// Token: 0x1700B41A RID: 46106
		// (get) Token: 0x06028DF2 RID: 167410 RVA: 0x00595AF0 File Offset: 0x00593CF0
		// (set) Token: 0x06028DF3 RID: 167411 RVA: 0x00595AF8 File Offset: 0x00593CF8
		public IPosAndRotT PosAndRot { get; set; }

		// Token: 0x06028DF4 RID: 167412 RVA: 0x00595B01 File Offset: 0x00593D01
		public IShowcaseFullViewCameraConfigT()
		{
			this.Fov = 0f;
			this.PosAndRot = null;
		}
	}
}
