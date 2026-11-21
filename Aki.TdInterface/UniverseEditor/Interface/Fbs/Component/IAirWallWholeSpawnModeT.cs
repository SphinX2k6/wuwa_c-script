using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B6 RID: 21430
	public class IAirWallWholeSpawnModeT
	{
		// Token: 0x1700979A RID: 38810
		// (get) Token: 0x06021745 RID: 137029 RVA: 0x0049D791 File Offset: 0x0049B991
		// (set) Token: 0x06021746 RID: 137030 RVA: 0x0049D799 File Offset: 0x0049B999
		public EAirWallSpawnMode Type { get; set; }

		// Token: 0x1700979B RID: 38811
		// (get) Token: 0x06021747 RID: 137031 RVA: 0x0049D7A2 File Offset: 0x0049B9A2
		// (set) Token: 0x06021748 RID: 137032 RVA: 0x0049D7AA File Offset: 0x0049B9AA
		public TAirWallSpawnStyleUnion SpawnStyle { get; set; }

		// Token: 0x1700979C RID: 38812
		// (get) Token: 0x06021749 RID: 137033 RVA: 0x0049D7B3 File Offset: 0x0049B9B3
		// (set) Token: 0x0602174A RID: 137034 RVA: 0x0049D7BB File Offset: 0x0049B9BB
		public float Thickness { get; set; }

		// Token: 0x1700979D RID: 38813
		// (get) Token: 0x0602174B RID: 137035 RVA: 0x0049D7C4 File Offset: 0x0049B9C4
		// (set) Token: 0x0602174C RID: 137036 RVA: 0x0049D7CC File Offset: 0x0049B9CC
		public float Height { get; set; }

		// Token: 0x1700979E RID: 38814
		// (get) Token: 0x0602174D RID: 137037 RVA: 0x0049D7D5 File Offset: 0x0049B9D5
		// (set) Token: 0x0602174E RID: 137038 RVA: 0x0049D7DD File Offset: 0x0049B9DD
		public float Depth { get; set; }

		// Token: 0x0602174F RID: 137039 RVA: 0x0049D7E6 File Offset: 0x0049B9E6
		public IAirWallWholeSpawnModeT()
		{
			this.Type = EAirWallSpawnMode.Whole;
			this.SpawnStyle = null;
			this.Thickness = 0f;
			this.Height = 0f;
			this.Depth = 0f;
		}
	}
}
