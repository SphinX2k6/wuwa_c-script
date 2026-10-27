using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587D RID: 22653
	public class IRoleMotionInteractTypeT
	{
		// Token: 0x1700A96F RID: 43375
		// (get) Token: 0x060262C0 RID: 156352 RVA: 0x005433F2 File Offset: 0x005415F2
		// (set) Token: 0x060262C1 RID: 156353 RVA: 0x005433FA File Offset: 0x005415FA
		public ERoleMotionInteractType Type { get; set; }

		// Token: 0x060262C2 RID: 156354 RVA: 0x00543403 File Offset: 0x00541603
		public IRoleMotionInteractTypeT()
		{
			this.Type = ERoleMotionInteractType.PetalGrab;
		}
	}
}
