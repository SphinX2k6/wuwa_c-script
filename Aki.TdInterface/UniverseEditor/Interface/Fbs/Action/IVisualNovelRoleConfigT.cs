using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DDA RID: 32218
	public class IVisualNovelRoleConfigT
	{
		// Token: 0x1700F161 RID: 61793
		// (get) Token: 0x0603A3A3 RID: 238499 RVA: 0x007D8FC4 File Offset: 0x007D71C4
		// (set) Token: 0x0603A3A4 RID: 238500 RVA: 0x007D8FCC File Offset: 0x007D71CC
		public int Expression { get; set; }

		// Token: 0x1700F162 RID: 61794
		// (get) Token: 0x0603A3A5 RID: 238501 RVA: 0x007D8FD5 File Offset: 0x007D71D5
		// (set) Token: 0x0603A3A6 RID: 238502 RVA: 0x007D8FDD File Offset: 0x007D71DD
		public EAvgVisualEffect VisualEffect { get; set; }

		// Token: 0x1700F163 RID: 61795
		// (get) Token: 0x0603A3A7 RID: 238503 RVA: 0x007D8FE6 File Offset: 0x007D71E6
		// (set) Token: 0x0603A3A8 RID: 238504 RVA: 0x007D8FEE File Offset: 0x007D71EE
		public bool HideAvatar { get; set; }

		// Token: 0x1700F164 RID: 61796
		// (get) Token: 0x0603A3A9 RID: 238505 RVA: 0x007D8FF7 File Offset: 0x007D71F7
		// (set) Token: 0x0603A3AA RID: 238506 RVA: 0x007D8FFF File Offset: 0x007D71FF
		public bool HidePortrait { get; set; }

		// Token: 0x1700F165 RID: 61797
		// (get) Token: 0x0603A3AB RID: 238507 RVA: 0x007D9008 File Offset: 0x007D7208
		// (set) Token: 0x0603A3AC RID: 238508 RVA: 0x007D9010 File Offset: 0x007D7210
		public int CustomLayer { get; set; }

		// Token: 0x1700F166 RID: 61798
		// (get) Token: 0x0603A3AD RID: 238509 RVA: 0x007D9019 File Offset: 0x007D7219
		// (set) Token: 0x0603A3AE RID: 238510 RVA: 0x007D9021 File Offset: 0x007D7221
		public byte NullMask { get; set; }

		// Token: 0x0603A3AF RID: 238511 RVA: 0x007D902A File Offset: 0x007D722A
		public IVisualNovelRoleConfigT()
		{
			this.Expression = 0;
			this.VisualEffect = EAvgVisualEffect.Default;
			this.HideAvatar = false;
			this.HidePortrait = false;
			this.CustomLayer = 0;
			this.NullMask = 0;
		}
	}
}
