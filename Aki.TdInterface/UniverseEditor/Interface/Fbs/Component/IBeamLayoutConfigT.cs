using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005437 RID: 21559
	public class IBeamLayoutConfigT
	{
		// Token: 0x17009924 RID: 39204
		// (get) Token: 0x06021D00 RID: 138496 RVA: 0x004A960E File Offset: 0x004A780E
		// (set) Token: 0x06021D01 RID: 138497 RVA: 0x004A9616 File Offset: 0x004A7816
		public EBeamLayoutType Type { get; set; }

		// Token: 0x06021D02 RID: 138498 RVA: 0x004A961F File Offset: 0x004A781F
		public IBeamLayoutConfigT()
		{
			this.Type = EBeamLayoutType.BeamWall;
		}
	}
}
