using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007532 RID: 30002
	public class IProjectionMachineT
	{
		// Token: 0x1700DCB8 RID: 56504
		// (get) Token: 0x060349CB RID: 215499 RVA: 0x007146C3 File Offset: 0x007128C3
		// (set) Token: 0x060349CC RID: 215500 RVA: 0x007146CB File Offset: 0x007128CB
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700DCB9 RID: 56505
		// (get) Token: 0x060349CD RID: 215501 RVA: 0x007146D4 File Offset: 0x007128D4
		// (set) Token: 0x060349CE RID: 215502 RVA: 0x007146DC File Offset: 0x007128DC
		public int ItemId { get; set; }

		// Token: 0x1700DCBA RID: 56506
		// (get) Token: 0x060349CF RID: 215503 RVA: 0x007146E5 File Offset: 0x007128E5
		// (set) Token: 0x060349D0 RID: 215504 RVA: 0x007146ED File Offset: 0x007128ED
		public string PhotoAsset { get; set; }

		// Token: 0x1700DCBB RID: 56507
		// (get) Token: 0x060349D1 RID: 215505 RVA: 0x007146F6 File Offset: 0x007128F6
		// (set) Token: 0x060349D2 RID: 215506 RVA: 0x007146FE File Offset: 0x007128FE
		public bool HideFixedPhoto { get; set; }

		// Token: 0x1700DCBC RID: 56508
		// (get) Token: 0x060349D3 RID: 215507 RVA: 0x00714707 File Offset: 0x00712907
		// (set) Token: 0x060349D4 RID: 215508 RVA: 0x0071470F File Offset: 0x0071290F
		public IProjectionMachinePhotoFilterT PhotoFilter { get; set; }

		// Token: 0x1700DCBD RID: 56509
		// (get) Token: 0x060349D5 RID: 215509 RVA: 0x00714718 File Offset: 0x00712918
		// (set) Token: 0x060349D6 RID: 215510 RVA: 0x00714720 File Offset: 0x00712920
		public byte NullMask { get; set; }

		// Token: 0x060349D7 RID: 215511 RVA: 0x00714729 File Offset: 0x00712929
		public IProjectionMachineT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.ItemId = 0;
			this.PhotoAsset = null;
			this.HideFixedPhoto = false;
			this.PhotoFilter = null;
			this.NullMask = 0;
		}
	}
}
