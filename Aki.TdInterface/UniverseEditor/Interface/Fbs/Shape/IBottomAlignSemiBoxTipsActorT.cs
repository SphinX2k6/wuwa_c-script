using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF9 RID: 16377
	public class IBottomAlignSemiBoxTipsActorT
	{
		// Token: 0x17006EEB RID: 28395
		// (get) Token: 0x06016687 RID: 91783 RVA: 0x003355A8 File Offset: 0x003337A8
		// (set) Token: 0x06016688 RID: 91784 RVA: 0x003355B0 File Offset: 0x003337B0
		public ETipsActorType Type { get; set; }

		// Token: 0x17006EEC RID: 28396
		// (get) Token: 0x06016689 RID: 91785 RVA: 0x003355B9 File Offset: 0x003337B9
		// (set) Token: 0x0601668A RID: 91786 RVA: 0x003355C1 File Offset: 0x003337C1
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006EED RID: 28397
		// (get) Token: 0x0601668B RID: 91787 RVA: 0x003355CA File Offset: 0x003337CA
		// (set) Token: 0x0601668C RID: 91788 RVA: 0x003355D2 File Offset: 0x003337D2
		public float X { get; set; }

		// Token: 0x17006EEE RID: 28398
		// (get) Token: 0x0601668D RID: 91789 RVA: 0x003355DB File Offset: 0x003337DB
		// (set) Token: 0x0601668E RID: 91790 RVA: 0x003355E3 File Offset: 0x003337E3
		public float Y { get; set; }

		// Token: 0x17006EEF RID: 28399
		// (get) Token: 0x0601668F RID: 91791 RVA: 0x003355EC File Offset: 0x003337EC
		// (set) Token: 0x06016690 RID: 91792 RVA: 0x003355F4 File Offset: 0x003337F4
		public float Z { get; set; }

		// Token: 0x17006EF0 RID: 28400
		// (get) Token: 0x06016691 RID: 91793 RVA: 0x003355FD File Offset: 0x003337FD
		// (set) Token: 0x06016692 RID: 91794 RVA: 0x00335605 File Offset: 0x00333805
		public byte NullMask { get; set; }

		// Token: 0x06016693 RID: 91795 RVA: 0x0033560E File Offset: 0x0033380E
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
