using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB7 RID: 28087
	public class IProjectionMachineT
	{
		// Token: 0x1700D170 RID: 53616
		// (get) Token: 0x060319CF RID: 203215 RVA: 0x006B8FDB File Offset: 0x006B71DB
		// (set) Token: 0x060319D0 RID: 203216 RVA: 0x006B8FE3 File Offset: 0x006B71E3
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D171 RID: 53617
		// (get) Token: 0x060319D1 RID: 203217 RVA: 0x006B8FEC File Offset: 0x006B71EC
		// (set) Token: 0x060319D2 RID: 203218 RVA: 0x006B8FF4 File Offset: 0x006B71F4
		public int ItemId { get; set; }

		// Token: 0x1700D172 RID: 53618
		// (get) Token: 0x060319D3 RID: 203219 RVA: 0x006B8FFD File Offset: 0x006B71FD
		// (set) Token: 0x060319D4 RID: 203220 RVA: 0x006B9005 File Offset: 0x006B7205
		public string PhotoAsset { get; set; }

		// Token: 0x1700D173 RID: 53619
		// (get) Token: 0x060319D5 RID: 203221 RVA: 0x006B900E File Offset: 0x006B720E
		// (set) Token: 0x060319D6 RID: 203222 RVA: 0x006B9016 File Offset: 0x006B7216
		public bool HideFixedPhoto { get; set; }

		// Token: 0x1700D174 RID: 53620
		// (get) Token: 0x060319D7 RID: 203223 RVA: 0x006B901F File Offset: 0x006B721F
		// (set) Token: 0x060319D8 RID: 203224 RVA: 0x006B9027 File Offset: 0x006B7227
		public IProjectionMachinePhotoFilterT PhotoFilter { get; set; }

		// Token: 0x1700D175 RID: 53621
		// (get) Token: 0x060319D9 RID: 203225 RVA: 0x006B9030 File Offset: 0x006B7230
		// (set) Token: 0x060319DA RID: 203226 RVA: 0x006B9038 File Offset: 0x006B7238
		public byte NullMask { get; set; }

		// Token: 0x060319DB RID: 203227 RVA: 0x006B9041 File Offset: 0x006B7241
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
