using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200654A RID: 25930
	public class IDeadeyeCameraConfigT
	{
		// Token: 0x1700C0BF RID: 49343
		// (get) Token: 0x0602CFD4 RID: 184276 RVA: 0x0062D100 File Offset: 0x0062B300
		// (set) Token: 0x0602CFD5 RID: 184277 RVA: 0x0062D108 File Offset: 0x0062B308
		public int LookAtPointId { get; set; }

		// Token: 0x1700C0C0 RID: 49344
		// (get) Token: 0x0602CFD6 RID: 184278 RVA: 0x0062D111 File Offset: 0x0062B311
		// (set) Token: 0x0602CFD7 RID: 184279 RVA: 0x0062D119 File Offset: 0x0062B319
		public int SubLensTag { get; set; }

		// Token: 0x1700C0C1 RID: 49345
		// (get) Token: 0x0602CFD8 RID: 184280 RVA: 0x0062D122 File Offset: 0x0062B322
		// (set) Token: 0x0602CFD9 RID: 184281 RVA: 0x0062D12A File Offset: 0x0062B32A
		public float TransitionTime { get; set; }

		// Token: 0x1700C0C2 RID: 49346
		// (get) Token: 0x0602CFDA RID: 184282 RVA: 0x0062D133 File Offset: 0x0062B333
		// (set) Token: 0x0602CFDB RID: 184283 RVA: 0x0062D13B File Offset: 0x0062B33B
		public byte NullMask { get; set; }

		// Token: 0x0602CFDC RID: 184284 RVA: 0x0062D144 File Offset: 0x0062B344
		public IDeadeyeCameraConfigT()
		{
			this.LookAtPointId = 0;
			this.SubLensTag = 0;
			this.TransitionTime = 0f;
			this.NullMask = 0;
		}
	}
}
