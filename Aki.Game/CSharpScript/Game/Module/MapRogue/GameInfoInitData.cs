using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055AC RID: 21932
	[NullableContext(1)]
	[Nullable(0)]
	public class GameInfoInitData : IGameInfoInitData
	{
		// Token: 0x170086A3 RID: 34467
		// (get) Token: 0x06037E49 RID: 228937 RVA: 0x00D3DCBF File Offset: 0x00D3BEBF
		// (set) Token: 0x06037E4A RID: 228938 RVA: 0x00D3DCC7 File Offset: 0x00D3BEC7
		public int InstanceId { get; set; }

		// Token: 0x170086A4 RID: 34468
		// (get) Token: 0x06037E4B RID: 228939 RVA: 0x00D3DCD0 File Offset: 0x00D3BED0
		// (set) Token: 0x06037E4C RID: 228940 RVA: 0x00D3DCD8 File Offset: 0x00D3BED8
		public int RandomSeed { get; set; }

		// Token: 0x170086A5 RID: 34469
		// (get) Token: 0x06037E4D RID: 228941 RVA: 0x00D3DCE1 File Offset: 0x00D3BEE1
		// (set) Token: 0x06037E4E RID: 228942 RVA: 0x00D3DCE9 File Offset: 0x00D3BEE9
		public int MoodMin { get; set; }

		// Token: 0x170086A6 RID: 34470
		// (get) Token: 0x06037E4F RID: 228943 RVA: 0x00D3DCF2 File Offset: 0x00D3BEF2
		// (set) Token: 0x06037E50 RID: 228944 RVA: 0x00D3DCFA File Offset: 0x00D3BEFA
		public int MoodMax { get; set; }

		// Token: 0x170086A7 RID: 34471
		// (get) Token: 0x06037E51 RID: 228945 RVA: 0x00D3DD03 File Offset: 0x00D3BF03
		// (set) Token: 0x06037E52 RID: 228946 RVA: 0x00D3DD0B File Offset: 0x00D3BF0B
		public int InitMood { get; set; }

		// Token: 0x170086A8 RID: 34472
		// (get) Token: 0x06037E53 RID: 228947 RVA: 0x00D3DD14 File Offset: 0x00D3BF14
		// (set) Token: 0x06037E54 RID: 228948 RVA: 0x00D3DD1C File Offset: 0x00D3BF1C
		public List<MapGridData> MapGrids { get; set; }

		// Token: 0x170086A9 RID: 34473
		// (get) Token: 0x06037E55 RID: 228949 RVA: 0x00D3DD25 File Offset: 0x00D3BF25
		// (set) Token: 0x06037E56 RID: 228950 RVA: 0x00D3DD2D File Offset: 0x00D3BF2D
		public int MapWidth { get; set; }

		// Token: 0x170086AA RID: 34474
		// (get) Token: 0x06037E57 RID: 228951 RVA: 0x00D3DD36 File Offset: 0x00D3BF36
		// (set) Token: 0x06037E58 RID: 228952 RVA: 0x00D3DD3E File Offset: 0x00D3BF3E
		public int MapHeight { get; set; }

		// Token: 0x170086AB RID: 34475
		// (get) Token: 0x06037E59 RID: 228953 RVA: 0x00D3DD47 File Offset: 0x00D3BF47
		// (set) Token: 0x06037E5A RID: 228954 RVA: 0x00D3DD4F File Offset: 0x00D3BF4F
		public int PlayerGridIndex { get; set; }

		// Token: 0x170086AC RID: 34476
		// (get) Token: 0x06037E5B RID: 228955 RVA: 0x00D3DD58 File Offset: 0x00D3BF58
		// (set) Token: 0x06037E5C RID: 228956 RVA: 0x00D3DD60 File Offset: 0x00D3BF60
		public int TeamLv { get; set; }

		// Token: 0x170086AD RID: 34477
		// (get) Token: 0x06037E5D RID: 228957 RVA: 0x00D3DD69 File Offset: 0x00D3BF69
		// (set) Token: 0x06037E5E RID: 228958 RVA: 0x00D3DD71 File Offset: 0x00D3BF71
		public bool InBattle { get; set; }

		// Token: 0x170086AE RID: 34478
		// (get) Token: 0x06037E5F RID: 228959 RVA: 0x00D3DD7A File Offset: 0x00D3BF7A
		// (set) Token: 0x06037E60 RID: 228960 RVA: 0x00D3DD82 File Offset: 0x00D3BF82
		public int CurrencyItemId { get; set; }

		// Token: 0x170086AF RID: 34479
		// (get) Token: 0x06037E61 RID: 228961 RVA: 0x00D3DD8B File Offset: 0x00D3BF8B
		// (set) Token: 0x06037E62 RID: 228962 RVA: 0x00D3DD93 File Offset: 0x00D3BF93
		public int MoodRuleId { get; set; }

		// Token: 0x170086B0 RID: 34480
		// (get) Token: 0x06037E63 RID: 228963 RVA: 0x00D3DD9C File Offset: 0x00D3BF9C
		// (set) Token: 0x06037E64 RID: 228964 RVA: 0x00D3DDA4 File Offset: 0x00D3BFA4
		public int RoleMaxStar { get; set; }

		// Token: 0x170086B1 RID: 34481
		// (get) Token: 0x06037E65 RID: 228965 RVA: 0x00D3DDAD File Offset: 0x00D3BFAD
		// (set) Token: 0x06037E66 RID: 228966 RVA: 0x00D3DDB5 File Offset: 0x00D3BFB5
		public int RoleLevel { get; set; }
	}
}
