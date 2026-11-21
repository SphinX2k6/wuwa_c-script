using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690E RID: 26894
	public class ICameraPosAndRotT
	{
		// Token: 0x1700C5F7 RID: 50679
		// (get) Token: 0x0602E144 RID: 188740 RVA: 0x0064C15E File Offset: 0x0064A35E
		// (set) Token: 0x0602E145 RID: 188741 RVA: 0x0064C166 File Offset: 0x0064A366
		public IVectorInfoT CameraOffset { get; set; }

		// Token: 0x1700C5F8 RID: 50680
		// (get) Token: 0x0602E146 RID: 188742 RVA: 0x0064C16F File Offset: 0x0064A36F
		// (set) Token: 0x0602E147 RID: 188743 RVA: 0x0064C177 File Offset: 0x0064A377
		public IVectorInfoT CameraRotate { get; set; }

		// Token: 0x0602E148 RID: 188744 RVA: 0x0064C180 File Offset: 0x0064A380
		public ICameraPosAndRotT()
		{
			this.CameraOffset = null;
			this.CameraRotate = null;
		}
	}
}
