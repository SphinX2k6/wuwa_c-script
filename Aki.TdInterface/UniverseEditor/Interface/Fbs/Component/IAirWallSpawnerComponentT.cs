using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A7 RID: 21415
	public class IAirWallSpawnerComponentT
	{
		// Token: 0x1700977F RID: 38783
		// (get) Token: 0x060216D5 RID: 136917 RVA: 0x0049CBF7 File Offset: 0x0049ADF7
		// (set) Token: 0x060216D6 RID: 136918 RVA: 0x0049CBFF File Offset: 0x0049ADFF
		public bool Disabled { get; set; }

		// Token: 0x17009780 RID: 38784
		// (get) Token: 0x060216D7 RID: 136919 RVA: 0x0049CC08 File Offset: 0x0049AE08
		// (set) Token: 0x060216D8 RID: 136920 RVA: 0x0049CC10 File Offset: 0x0049AE10
		public int SplineEntity { get; set; }

		// Token: 0x17009781 RID: 38785
		// (get) Token: 0x060216D9 RID: 136921 RVA: 0x0049CC19 File Offset: 0x0049AE19
		// (set) Token: 0x060216DA RID: 136922 RVA: 0x0049CC21 File Offset: 0x0049AE21
		public string WallName { get; set; }

		// Token: 0x17009782 RID: 38786
		// (get) Token: 0x060216DB RID: 136923 RVA: 0x0049CC2A File Offset: 0x0049AE2A
		// (set) Token: 0x060216DC RID: 136924 RVA: 0x0049CC32 File Offset: 0x0049AE32
		public float Thickness { get; set; }

		// Token: 0x17009783 RID: 38787
		// (get) Token: 0x060216DD RID: 136925 RVA: 0x0049CC3B File Offset: 0x0049AE3B
		// (set) Token: 0x060216DE RID: 136926 RVA: 0x0049CC43 File Offset: 0x0049AE43
		public float Height { get; set; }

		// Token: 0x17009784 RID: 38788
		// (get) Token: 0x060216DF RID: 136927 RVA: 0x0049CC4C File Offset: 0x0049AE4C
		// (set) Token: 0x060216E0 RID: 136928 RVA: 0x0049CC54 File Offset: 0x0049AE54
		public EBiasDirection BiasDirection { get; set; }

		// Token: 0x17009785 RID: 38789
		// (get) Token: 0x060216E1 RID: 136929 RVA: 0x0049CC5D File Offset: 0x0049AE5D
		// (set) Token: 0x060216E2 RID: 136930 RVA: 0x0049CC65 File Offset: 0x0049AE65
		public bool IsExtend { get; set; }

		// Token: 0x17009786 RID: 38790
		// (get) Token: 0x060216E3 RID: 136931 RVA: 0x0049CC6E File Offset: 0x0049AE6E
		// (set) Token: 0x060216E4 RID: 136932 RVA: 0x0049CC76 File Offset: 0x0049AE76
		public bool HasCover { get; set; }

		// Token: 0x17009787 RID: 38791
		// (get) Token: 0x060216E5 RID: 136933 RVA: 0x0049CC7F File Offset: 0x0049AE7F
		// (set) Token: 0x060216E6 RID: 136934 RVA: 0x0049CC87 File Offset: 0x0049AE87
		public List<IActorRefT> WallActorsRef { get; set; }

		// Token: 0x17009788 RID: 38792
		// (get) Token: 0x060216E7 RID: 136935 RVA: 0x0049CC90 File Offset: 0x0049AE90
		// (set) Token: 0x060216E8 RID: 136936 RVA: 0x0049CC98 File Offset: 0x0049AE98
		public IAirWallWholeSpawnModeT SpawnMode { get; set; }

		// Token: 0x17009789 RID: 38793
		// (get) Token: 0x060216E9 RID: 136937 RVA: 0x0049CCA1 File Offset: 0x0049AEA1
		// (set) Token: 0x060216EA RID: 136938 RVA: 0x0049CCA9 File Offset: 0x0049AEA9
		public byte NullMask { get; set; }

		// Token: 0x060216EB RID: 136939 RVA: 0x0049CCB4 File Offset: 0x0049AEB4
		public IAirWallSpawnerComponentT()
		{
			this.Disabled = false;
			this.SplineEntity = 0;
			this.WallName = null;
			this.Thickness = 0f;
			this.Height = 0f;
			this.BiasDirection = EBiasDirection.Inner;
			this.IsExtend = false;
			this.HasCover = false;
			this.WallActorsRef = null;
			this.SpawnMode = null;
			this.NullMask = 0;
		}
	}
}
