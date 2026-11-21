using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F2F RID: 16175
	public class IWoodenBoxProliferateParamsT
	{
		// Token: 0x17006D8D RID: 28045
		// (get) Token: 0x06015FD7 RID: 90071 RVA: 0x00328F0A File Offset: 0x0032710A
		// (set) Token: 0x06015FD8 RID: 90072 RVA: 0x00328F12 File Offset: 0x00327112
		public EParamsPreset Type { get; set; }

		// Token: 0x17006D8E RID: 28046
		// (get) Token: 0x06015FD9 RID: 90073 RVA: 0x00328F1B File Offset: 0x0032711B
		// (set) Token: 0x06015FDA RID: 90074 RVA: 0x00328F23 File Offset: 0x00327123
		public TWoodenBoxProliferateSpawnConfigUnion SpawnConfig { get; set; }

		// Token: 0x17006D8F RID: 28047
		// (get) Token: 0x06015FDB RID: 90075 RVA: 0x00328F2C File Offset: 0x0032712C
		// (set) Token: 0x06015FDC RID: 90076 RVA: 0x00328F34 File Offset: 0x00327134
		public EWoodenBoxProliferateVisualType ProliferateVisualType { get; set; }

		// Token: 0x17006D90 RID: 28048
		// (get) Token: 0x06015FDD RID: 90077 RVA: 0x00328F3D File Offset: 0x0032713D
		// (set) Token: 0x06015FDE RID: 90078 RVA: 0x00328F45 File Offset: 0x00327145
		public string ProliferateReadyState { get; set; }

		// Token: 0x17006D91 RID: 28049
		// (get) Token: 0x06015FDF RID: 90079 RVA: 0x00328F4E File Offset: 0x0032714E
		// (set) Token: 0x06015FE0 RID: 90080 RVA: 0x00328F56 File Offset: 0x00327156
		public string ProliferatedState { get; set; }

		// Token: 0x17006D92 RID: 28050
		// (get) Token: 0x06015FE1 RID: 90081 RVA: 0x00328F5F File Offset: 0x0032715F
		// (set) Token: 0x06015FE2 RID: 90082 RVA: 0x00328F67 File Offset: 0x00327167
		public float ProliferateDuration { get; set; }

		// Token: 0x17006D93 RID: 28051
		// (get) Token: 0x06015FE3 RID: 90083 RVA: 0x00328F70 File Offset: 0x00327170
		// (set) Token: 0x06015FE4 RID: 90084 RVA: 0x00328F78 File Offset: 0x00327178
		public byte NullMask { get; set; }

		// Token: 0x06015FE5 RID: 90085 RVA: 0x00328F81 File Offset: 0x00327181
		public IWoodenBoxProliferateParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.SpawnConfig = null;
			this.ProliferateVisualType = EWoodenBoxProliferateVisualType.SlenderJadeBamboo;
			this.ProliferateReadyState = null;
			this.ProliferatedState = null;
			this.ProliferateDuration = 0f;
			this.NullMask = 0;
		}
	}
}
