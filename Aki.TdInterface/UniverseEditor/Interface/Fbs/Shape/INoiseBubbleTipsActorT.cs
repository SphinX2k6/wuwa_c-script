using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004038 RID: 16440
	public class INoiseBubbleTipsActorT
	{
		// Token: 0x17006FBB RID: 28603
		// (get) Token: 0x06016931 RID: 92465 RVA: 0x0033AC9C File Offset: 0x00338E9C
		// (set) Token: 0x06016932 RID: 92466 RVA: 0x0033ACA4 File Offset: 0x00338EA4
		public ETipsActorType Type { get; set; }

		// Token: 0x17006FBC RID: 28604
		// (get) Token: 0x06016933 RID: 92467 RVA: 0x0033ACAD File Offset: 0x00338EAD
		// (set) Token: 0x06016934 RID: 92468 RVA: 0x0033ACB5 File Offset: 0x00338EB5
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006FBD RID: 28605
		// (get) Token: 0x06016935 RID: 92469 RVA: 0x0033ACBE File Offset: 0x00338EBE
		// (set) Token: 0x06016936 RID: 92470 RVA: 0x0033ACC6 File Offset: 0x00338EC6
		public ENoiseBubbleColor Color { get; set; }

		// Token: 0x17006FBE RID: 28606
		// (get) Token: 0x06016937 RID: 92471 RVA: 0x0033ACCF File Offset: 0x00338ECF
		// (set) Token: 0x06016938 RID: 92472 RVA: 0x0033ACD7 File Offset: 0x00338ED7
		public byte NullMask { get; set; }

		// Token: 0x06016939 RID: 92473 RVA: 0x0033ACE0 File Offset: 0x00338EE0
		public INoiseBubbleTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Color = ENoiseBubbleColor.Green;
			this.NullMask = 0;
		}
	}
}
