using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE7 RID: 15335
	public class IActorParamT
	{
		// Token: 0x17006936 RID: 26934
		// (get) Token: 0x0601515F RID: 86367 RVA: 0x0030E4BA File Offset: 0x0030C6BA
		// (set) Token: 0x06015160 RID: 86368 RVA: 0x0030E4C2 File Offset: 0x0030C6C2
		public ETipsActorType Type { get; set; }

		// Token: 0x17006937 RID: 26935
		// (get) Token: 0x06015161 RID: 86369 RVA: 0x0030E4CB File Offset: 0x0030C6CB
		// (set) Token: 0x06015162 RID: 86370 RVA: 0x0030E4D3 File Offset: 0x0030C6D3
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006938 RID: 26936
		// (get) Token: 0x06015163 RID: 86371 RVA: 0x0030E4DC File Offset: 0x0030C6DC
		// (set) Token: 0x06015164 RID: 86372 RVA: 0x0030E4E4 File Offset: 0x0030C6E4
		public byte NullMask { get; set; }

		// Token: 0x06015165 RID: 86373 RVA: 0x0030E4ED File Offset: 0x0030C6ED
		public IActorParamT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.NullMask = 0;
		}
	}
}
