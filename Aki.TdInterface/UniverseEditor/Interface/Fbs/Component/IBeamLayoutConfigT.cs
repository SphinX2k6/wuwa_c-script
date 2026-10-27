using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F05 RID: 20229
	public class IBeamLayoutConfigT
	{
		// Token: 0x170091A2 RID: 37282
		// (get) Token: 0x0601FF90 RID: 130960 RVA: 0x0047327A File Offset: 0x0047147A
		// (set) Token: 0x0601FF91 RID: 130961 RVA: 0x00473282 File Offset: 0x00471482
		public EBeamLayoutType Type { get; set; }

		// Token: 0x0601FF92 RID: 130962 RVA: 0x0047328B File Offset: 0x0047148B
		public IBeamLayoutConfigT()
		{
			this.Type = EBeamLayoutType.BeamWall;
		}
	}
}
