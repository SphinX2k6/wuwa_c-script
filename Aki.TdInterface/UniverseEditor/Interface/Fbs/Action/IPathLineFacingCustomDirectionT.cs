using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073CE RID: 29646
	public class IPathLineFacingCustomDirectionT
	{
		// Token: 0x1700D9C6 RID: 55750
		// (get) Token: 0x06033DB2 RID: 212402 RVA: 0x006FE4B4 File Offset: 0x006FC6B4
		// (set) Token: 0x06033DB3 RID: 212403 RVA: 0x006FE4BC File Offset: 0x006FC6BC
		public EPathLineFacingType Type { get; set; }

		// Token: 0x1700D9C7 RID: 55751
		// (get) Token: 0x06033DB4 RID: 212404 RVA: 0x006FE4C5 File Offset: 0x006FC6C5
		// (set) Token: 0x06033DB5 RID: 212405 RVA: 0x006FE4CD File Offset: 0x006FC6CD
		public float Yaw { get; set; }

		// Token: 0x06033DB6 RID: 212406 RVA: 0x006FE4D6 File Offset: 0x006FC6D6
		public IPathLineFacingCustomDirectionT()
		{
			this.Type = EPathLineFacingType.Current;
			this.Yaw = 0f;
		}
	}
}
