using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FCB RID: 20427
	public class ICommonRotationConfigT
	{
		// Token: 0x170093F8 RID: 37880
		// (get) Token: 0x0602087D RID: 133245 RVA: 0x004862D1 File Offset: 0x004844D1
		// (set) Token: 0x0602087E RID: 133246 RVA: 0x004862D9 File Offset: 0x004844D9
		public ERotationType Type { get; set; }

		// Token: 0x170093F9 RID: 37881
		// (get) Token: 0x0602087F RID: 133247 RVA: 0x004862E2 File Offset: 0x004844E2
		// (set) Token: 0x06020880 RID: 133248 RVA: 0x004862EA File Offset: 0x004844EA
		public float Time { get; set; }

		// Token: 0x170093FA RID: 37882
		// (get) Token: 0x06020881 RID: 133249 RVA: 0x004862F3 File Offset: 0x004844F3
		// (set) Token: 0x06020882 RID: 133250 RVA: 0x004862FB File Offset: 0x004844FB
		public float Cd { get; set; }

		// Token: 0x170093FB RID: 37883
		// (get) Token: 0x06020883 RID: 133251 RVA: 0x00486304 File Offset: 0x00484504
		// (set) Token: 0x06020884 RID: 133252 RVA: 0x0048630C File Offset: 0x0048450C
		public string Curve { get; set; }

		// Token: 0x170093FC RID: 37884
		// (get) Token: 0x06020885 RID: 133253 RVA: 0x00486315 File Offset: 0x00484515
		// (set) Token: 0x06020886 RID: 133254 RVA: 0x0048631D File Offset: 0x0048451D
		public byte NullMask { get; set; }

		// Token: 0x06020887 RID: 133255 RVA: 0x00486326 File Offset: 0x00484526
		public ICommonRotationConfigT()
		{
			this.Type = ERotationType.Relative;
			this.Time = 0f;
			this.Cd = 0f;
			this.Curve = null;
			this.NullMask = 0;
		}
	}
}
