using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F08 RID: 20232
	public class IBeamLayoutConfigWallT
	{
		// Token: 0x170091A7 RID: 37287
		// (get) Token: 0x0601FFA6 RID: 130982 RVA: 0x004734BE File Offset: 0x004716BE
		// (set) Token: 0x0601FFA7 RID: 130983 RVA: 0x004734C6 File Offset: 0x004716C6
		public EBeamLayoutType Type { get; set; }

		// Token: 0x170091A8 RID: 37288
		// (get) Token: 0x0601FFA8 RID: 130984 RVA: 0x004734CF File Offset: 0x004716CF
		// (set) Token: 0x0601FFA9 RID: 130985 RVA: 0x004734D7 File Offset: 0x004716D7
		public int Count { get; set; }

		// Token: 0x170091A9 RID: 37289
		// (get) Token: 0x0601FFAA RID: 130986 RVA: 0x004734E0 File Offset: 0x004716E0
		// (set) Token: 0x0601FFAB RID: 130987 RVA: 0x004734E8 File Offset: 0x004716E8
		public float Distance { get; set; }

		// Token: 0x0601FFAC RID: 130988 RVA: 0x004734F1 File Offset: 0x004716F1
		public IBeamLayoutConfigWallT()
		{
			this.Type = EBeamLayoutType.BeamWall;
			this.Count = 0;
			this.Distance = 0f;
		}
	}
}
