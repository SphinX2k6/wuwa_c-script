using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A48 RID: 27208
	public class ILongPressInteractStyleConfigTimeBackInteractT
	{
		// Token: 0x1700C9E0 RID: 51680
		// (get) Token: 0x0602FA42 RID: 195138 RVA: 0x0067C1BF File Offset: 0x0067A3BF
		// (set) Token: 0x0602FA43 RID: 195139 RVA: 0x0067C1C7 File Offset: 0x0067A3C7
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x1700C9E1 RID: 51681
		// (get) Token: 0x0602FA44 RID: 195140 RVA: 0x0067C1D0 File Offset: 0x0067A3D0
		// (set) Token: 0x0602FA45 RID: 195141 RVA: 0x0067C1D8 File Offset: 0x0067A3D8
		public string TidContent { get; set; }

		// Token: 0x1700C9E2 RID: 51682
		// (get) Token: 0x0602FA46 RID: 195142 RVA: 0x0067C1E1 File Offset: 0x0067A3E1
		// (set) Token: 0x0602FA47 RID: 195143 RVA: 0x0067C1E9 File Offset: 0x0067A3E9
		public float StartProgress { get; set; }

		// Token: 0x1700C9E3 RID: 51683
		// (get) Token: 0x0602FA48 RID: 195144 RVA: 0x0067C1F2 File Offset: 0x0067A3F2
		// (set) Token: 0x0602FA49 RID: 195145 RVA: 0x0067C1FA File Offset: 0x0067A3FA
		public byte NullMask { get; set; }

		// Token: 0x0602FA4A RID: 195146 RVA: 0x0067C203 File Offset: 0x0067A403
		public ILongPressInteractStyleConfigTimeBackInteractT()
		{
			this.Type = ELongPressInteractStyle.Default;
			this.TidContent = null;
			this.StartProgress = 0f;
			this.NullMask = 0;
		}
	}
}
