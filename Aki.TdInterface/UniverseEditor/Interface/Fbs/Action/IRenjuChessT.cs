using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E74 RID: 28276
	public class IRenjuChessT
	{
		// Token: 0x1700D2A0 RID: 53920
		// (get) Token: 0x06031FA3 RID: 204707 RVA: 0x006C2C91 File Offset: 0x006C0E91
		// (set) Token: 0x06031FA4 RID: 204708 RVA: 0x006C2C99 File Offset: 0x006C0E99
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D2A1 RID: 53921
		// (get) Token: 0x06031FA5 RID: 204709 RVA: 0x006C2CA2 File Offset: 0x006C0EA2
		// (set) Token: 0x06031FA6 RID: 204710 RVA: 0x006C2CAA File Offset: 0x006C0EAA
		public int Chessboard { get; set; }

		// Token: 0x1700D2A2 RID: 53922
		// (get) Token: 0x06031FA7 RID: 204711 RVA: 0x006C2CB3 File Offset: 0x006C0EB3
		// (set) Token: 0x06031FA8 RID: 204712 RVA: 0x006C2CBB File Offset: 0x006C0EBB
		public TAdjustPlayerCameraOptionUnion CameraConfig { get; set; }

		// Token: 0x06031FA9 RID: 204713 RVA: 0x006C2CC4 File Offset: 0x006C0EC4
		public IRenjuChessT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Chessboard = 0;
			this.CameraConfig = null;
		}
	}
}
