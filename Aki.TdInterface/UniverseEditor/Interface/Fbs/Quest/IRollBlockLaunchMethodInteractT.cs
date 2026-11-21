using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200452D RID: 17709
	public class IRollBlockLaunchMethodInteractT
	{
		// Token: 0x17007B2C RID: 31532
		// (get) Token: 0x06019A30 RID: 105008 RVA: 0x003A6D08 File Offset: 0x003A4F08
		// (set) Token: 0x06019A31 RID: 105009 RVA: 0x003A6D10 File Offset: 0x003A4F10
		public ERollBlockLaunchMethod Type { get; set; }

		// Token: 0x17007B2D RID: 31533
		// (get) Token: 0x06019A32 RID: 105010 RVA: 0x003A6D19 File Offset: 0x003A4F19
		// (set) Token: 0x06019A33 RID: 105011 RVA: 0x003A6D21 File Offset: 0x003A4F21
		public int TargetId { get; set; }

		// Token: 0x06019A34 RID: 105012 RVA: 0x003A6D2A File Offset: 0x003A4F2A
		public IRollBlockLaunchMethodInteractT()
		{
			this.Type = ERollBlockLaunchMethod.Interact;
			this.TargetId = 0;
		}
	}
}
