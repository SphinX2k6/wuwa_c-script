using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004041 RID: 16449
	public class IRelativeTipActorTransformT
	{
		// Token: 0x17006FC9 RID: 28617
		// (get) Token: 0x06016971 RID: 92529 RVA: 0x0033B392 File Offset: 0x00339592
		// (set) Token: 0x06016972 RID: 92530 RVA: 0x0033B39A File Offset: 0x0033959A
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006FCA RID: 28618
		// (get) Token: 0x06016973 RID: 92531 RVA: 0x0033B3A3 File Offset: 0x003395A3
		// (set) Token: 0x06016974 RID: 92532 RVA: 0x0033B3AB File Offset: 0x003395AB
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006FCB RID: 28619
		// (get) Token: 0x06016975 RID: 92533 RVA: 0x0033B3B4 File Offset: 0x003395B4
		// (set) Token: 0x06016976 RID: 92534 RVA: 0x0033B3BC File Offset: 0x003395BC
		public IVectorInfoT Rot { get; set; }

		// Token: 0x17006FCC RID: 28620
		// (get) Token: 0x06016977 RID: 92535 RVA: 0x0033B3C5 File Offset: 0x003395C5
		// (set) Token: 0x06016978 RID: 92536 RVA: 0x0033B3CD File Offset: 0x003395CD
		public int RelativeEntityId { get; set; }

		// Token: 0x06016979 RID: 92537 RVA: 0x0033B3D6 File Offset: 0x003395D6
		public IRelativeTipActorTransformT()
		{
			this.Type = ETipsActorTransformType.Absolute;
			this.Pos = null;
			this.Rot = null;
			this.RelativeEntityId = 0;
		}
	}
}
