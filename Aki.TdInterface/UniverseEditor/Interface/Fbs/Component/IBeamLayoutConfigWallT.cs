using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543A RID: 21562
	public class IBeamLayoutConfigWallT
	{
		// Token: 0x17009929 RID: 39209
		// (get) Token: 0x06021D16 RID: 138518 RVA: 0x004A9852 File Offset: 0x004A7A52
		// (set) Token: 0x06021D17 RID: 138519 RVA: 0x004A985A File Offset: 0x004A7A5A
		public EBeamLayoutType Type { get; set; }

		// Token: 0x1700992A RID: 39210
		// (get) Token: 0x06021D18 RID: 138520 RVA: 0x004A9863 File Offset: 0x004A7A63
		// (set) Token: 0x06021D19 RID: 138521 RVA: 0x004A986B File Offset: 0x004A7A6B
		public int Count { get; set; }

		// Token: 0x1700992B RID: 39211
		// (get) Token: 0x06021D1A RID: 138522 RVA: 0x004A9874 File Offset: 0x004A7A74
		// (set) Token: 0x06021D1B RID: 138523 RVA: 0x004A987C File Offset: 0x004A7A7C
		public float Distance { get; set; }

		// Token: 0x06021D1C RID: 138524 RVA: 0x004A9885 File Offset: 0x004A7A85
		public IBeamLayoutConfigWallT()
		{
			this.Type = EBeamLayoutType.BeamWall;
			this.Count = 0;
			this.Distance = 0f;
		}
	}
}
