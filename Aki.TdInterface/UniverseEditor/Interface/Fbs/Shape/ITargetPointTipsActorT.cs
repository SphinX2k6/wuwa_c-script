using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C56 RID: 15446
	public class ITargetPointTipsActorT
	{
		// Token: 0x17006A8A RID: 27274
		// (get) Token: 0x060155D7 RID: 87511 RVA: 0x003171D7 File Offset: 0x003153D7
		// (set) Token: 0x060155D8 RID: 87512 RVA: 0x003171DF File Offset: 0x003153DF
		public ETipsActorType Type { get; set; }

		// Token: 0x17006A8B RID: 27275
		// (get) Token: 0x060155D9 RID: 87513 RVA: 0x003171E8 File Offset: 0x003153E8
		// (set) Token: 0x060155DA RID: 87514 RVA: 0x003171F0 File Offset: 0x003153F0
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006A8C RID: 27276
		// (get) Token: 0x060155DB RID: 87515 RVA: 0x003171F9 File Offset: 0x003153F9
		// (set) Token: 0x060155DC RID: 87516 RVA: 0x00317201 File Offset: 0x00315401
		public string Label { get; set; }

		// Token: 0x17006A8D RID: 27277
		// (get) Token: 0x060155DD RID: 87517 RVA: 0x0031720A File Offset: 0x0031540A
		// (set) Token: 0x060155DE RID: 87518 RVA: 0x00317212 File Offset: 0x00315412
		public byte NullMask { get; set; }

		// Token: 0x060155DF RID: 87519 RVA: 0x0031721B File Offset: 0x0031541B
		public ITargetPointTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Label = null;
			this.NullMask = 0;
		}
	}
}
