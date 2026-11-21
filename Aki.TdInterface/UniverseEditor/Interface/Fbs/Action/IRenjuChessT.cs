using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F8 RID: 30200
	public class IRenjuChessT
	{
		// Token: 0x1700DDF7 RID: 56823
		// (get) Token: 0x06034FE3 RID: 217059 RVA: 0x0071E9C5 File Offset: 0x0071CBC5
		// (set) Token: 0x06034FE4 RID: 217060 RVA: 0x0071E9CD File Offset: 0x0071CBCD
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700DDF8 RID: 56824
		// (get) Token: 0x06034FE5 RID: 217061 RVA: 0x0071E9D6 File Offset: 0x0071CBD6
		// (set) Token: 0x06034FE6 RID: 217062 RVA: 0x0071E9DE File Offset: 0x0071CBDE
		public int Chessboard { get; set; }

		// Token: 0x1700DDF9 RID: 56825
		// (get) Token: 0x06034FE7 RID: 217063 RVA: 0x0071E9E7 File Offset: 0x0071CBE7
		// (set) Token: 0x06034FE8 RID: 217064 RVA: 0x0071E9EF File Offset: 0x0071CBEF
		public TAdjustPlayerCameraOptionUnion CameraConfig { get; set; }

		// Token: 0x06034FE9 RID: 217065 RVA: 0x0071E9F8 File Offset: 0x0071CBF8
		public IRenjuChessT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Chessboard = 0;
			this.CameraConfig = null;
		}
	}
}
