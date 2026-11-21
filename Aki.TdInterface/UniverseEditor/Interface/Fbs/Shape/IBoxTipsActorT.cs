using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FFF RID: 16383
	public class IBoxTipsActorT
	{
		// Token: 0x17006F01 RID: 28417
		// (get) Token: 0x060166CB RID: 91851 RVA: 0x00335EB8 File Offset: 0x003340B8
		// (set) Token: 0x060166CC RID: 91852 RVA: 0x00335EC0 File Offset: 0x003340C0
		public ETipsActorType Type { get; set; }

		// Token: 0x17006F02 RID: 28418
		// (get) Token: 0x060166CD RID: 91853 RVA: 0x00335EC9 File Offset: 0x003340C9
		// (set) Token: 0x060166CE RID: 91854 RVA: 0x00335ED1 File Offset: 0x003340D1
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006F03 RID: 28419
		// (get) Token: 0x060166CF RID: 91855 RVA: 0x00335EDA File Offset: 0x003340DA
		// (set) Token: 0x060166D0 RID: 91856 RVA: 0x00335EE2 File Offset: 0x003340E2
		public float X { get; set; }

		// Token: 0x17006F04 RID: 28420
		// (get) Token: 0x060166D1 RID: 91857 RVA: 0x00335EEB File Offset: 0x003340EB
		// (set) Token: 0x060166D2 RID: 91858 RVA: 0x00335EF3 File Offset: 0x003340F3
		public float Y { get; set; }

		// Token: 0x17006F05 RID: 28421
		// (get) Token: 0x060166D3 RID: 91859 RVA: 0x00335EFC File Offset: 0x003340FC
		// (set) Token: 0x060166D4 RID: 91860 RVA: 0x00335F04 File Offset: 0x00334104
		public float Z { get; set; }

		// Token: 0x17006F06 RID: 28422
		// (get) Token: 0x060166D5 RID: 91861 RVA: 0x00335F0D File Offset: 0x0033410D
		// (set) Token: 0x060166D6 RID: 91862 RVA: 0x00335F15 File Offset: 0x00334115
		public byte NullMask { get; set; }

		// Token: 0x060166D7 RID: 91863 RVA: 0x00335F1E File Offset: 0x0033411E
		public IBoxTipsActorT()
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
