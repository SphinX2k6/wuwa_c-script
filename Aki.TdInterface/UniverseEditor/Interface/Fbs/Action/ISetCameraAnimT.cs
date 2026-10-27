using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD2 RID: 28626
	public class ISetCameraAnimT
	{
		// Token: 0x1700D485 RID: 54405
		// (get) Token: 0x06032993 RID: 207251 RVA: 0x006D3C7F File Offset: 0x006D1E7F
		// (set) Token: 0x06032994 RID: 207252 RVA: 0x006D3C87 File Offset: 0x006D1E87
		public string CameraAnimDataAsset { get; set; }

		// Token: 0x1700D486 RID: 54406
		// (get) Token: 0x06032995 RID: 207253 RVA: 0x006D3C90 File Offset: 0x006D1E90
		// (set) Token: 0x06032996 RID: 207254 RVA: 0x006D3C98 File Offset: 0x006D1E98
		public float Speed { get; set; }

		// Token: 0x1700D487 RID: 54407
		// (get) Token: 0x06032997 RID: 207255 RVA: 0x006D3CA1 File Offset: 0x006D1EA1
		// (set) Token: 0x06032998 RID: 207256 RVA: 0x006D3CA9 File Offset: 0x006D1EA9
		public bool UseNoise { get; set; }

		// Token: 0x1700D488 RID: 54408
		// (get) Token: 0x06032999 RID: 207257 RVA: 0x006D3CB2 File Offset: 0x006D1EB2
		// (set) Token: 0x0603299A RID: 207258 RVA: 0x006D3CBA File Offset: 0x006D1EBA
		public byte NullMask { get; set; }

		// Token: 0x0603299B RID: 207259 RVA: 0x006D3CC3 File Offset: 0x006D1EC3
		public ISetCameraAnimT()
		{
			this.CameraAnimDataAsset = null;
			this.Speed = 0f;
			this.UseNoise = false;
			this.NullMask = 0;
		}
	}
}
