using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BED RID: 15341
	public class IBottomAlignSemiBoxTipsActorT
	{
		// Token: 0x17006943 RID: 26947
		// (get) Token: 0x06015191 RID: 86417 RVA: 0x0030EA20 File Offset: 0x0030CC20
		// (set) Token: 0x06015192 RID: 86418 RVA: 0x0030EA28 File Offset: 0x0030CC28
		public ETipsActorType Type { get; set; }

		// Token: 0x17006944 RID: 26948
		// (get) Token: 0x06015193 RID: 86419 RVA: 0x0030EA31 File Offset: 0x0030CC31
		// (set) Token: 0x06015194 RID: 86420 RVA: 0x0030EA39 File Offset: 0x0030CC39
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006945 RID: 26949
		// (get) Token: 0x06015195 RID: 86421 RVA: 0x0030EA42 File Offset: 0x0030CC42
		// (set) Token: 0x06015196 RID: 86422 RVA: 0x0030EA4A File Offset: 0x0030CC4A
		public float X { get; set; }

		// Token: 0x17006946 RID: 26950
		// (get) Token: 0x06015197 RID: 86423 RVA: 0x0030EA53 File Offset: 0x0030CC53
		// (set) Token: 0x06015198 RID: 86424 RVA: 0x0030EA5B File Offset: 0x0030CC5B
		public float Y { get; set; }

		// Token: 0x17006947 RID: 26951
		// (get) Token: 0x06015199 RID: 86425 RVA: 0x0030EA64 File Offset: 0x0030CC64
		// (set) Token: 0x0601519A RID: 86426 RVA: 0x0030EA6C File Offset: 0x0030CC6C
		public float Z { get; set; }

		// Token: 0x17006948 RID: 26952
		// (get) Token: 0x0601519B RID: 86427 RVA: 0x0030EA75 File Offset: 0x0030CC75
		// (set) Token: 0x0601519C RID: 86428 RVA: 0x0030EA7D File Offset: 0x0030CC7D
		public byte NullMask { get; set; }

		// Token: 0x0601519D RID: 86429 RVA: 0x0030EA86 File Offset: 0x0030CC86
		public IBottomAlignSemiBoxTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.NullMask = 0;
		}
	}
}
