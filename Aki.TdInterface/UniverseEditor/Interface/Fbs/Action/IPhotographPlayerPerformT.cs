using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC7 RID: 27847
	public class IPhotographPlayerPerformT
	{
		// Token: 0x1700CF51 RID: 53073
		// (get) Token: 0x06031141 RID: 201025 RVA: 0x006A909A File Offset: 0x006A729A
		// (set) Token: 0x06031142 RID: 201026 RVA: 0x006A90A2 File Offset: 0x006A72A2
		public int MontageId { get; set; }

		// Token: 0x1700CF52 RID: 53074
		// (get) Token: 0x06031143 RID: 201027 RVA: 0x006A90AB File Offset: 0x006A72AB
		// (set) Token: 0x06031144 RID: 201028 RVA: 0x006A90B3 File Offset: 0x006A72B3
		public int FaceId { get; set; }

		// Token: 0x1700CF53 RID: 53075
		// (get) Token: 0x06031145 RID: 201029 RVA: 0x006A90BC File Offset: 0x006A72BC
		// (set) Token: 0x06031146 RID: 201030 RVA: 0x006A90C4 File Offset: 0x006A72C4
		public byte NullMask { get; set; }

		// Token: 0x06031147 RID: 201031 RVA: 0x006A90CD File Offset: 0x006A72CD
		public IPhotographPlayerPerformT()
		{
			this.MontageId = 0;
			this.FaceId = 0;
			this.NullMask = 0;
		}
	}
}
