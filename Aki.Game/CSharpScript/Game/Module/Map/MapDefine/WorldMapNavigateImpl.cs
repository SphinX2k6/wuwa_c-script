using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200453E RID: 17726
	public class WorldMapNavigateImpl : IWorldMapNavigate
	{
		// Token: 0x170059B6 RID: 22966
		// (get) Token: 0x0602CAEA RID: 183018 RVA: 0x00C869CB File Offset: 0x00C84BCB
		// (set) Token: 0x0602CAEB RID: 183019 RVA: 0x00C869D3 File Offset: 0x00C84BD3
		public int AreaId { get; set; }

		// Token: 0x170059B7 RID: 22967
		// (get) Token: 0x0602CAEC RID: 183020 RVA: 0x00C869DC File Offset: 0x00C84BDC
		// (set) Token: 0x0602CAED RID: 183021 RVA: 0x00C869E4 File Offset: 0x00C84BE4
		public int? StateId { get; set; }

		// Token: 0x170059B8 RID: 22968
		// (get) Token: 0x0602CAEE RID: 183022 RVA: 0x00C869ED File Offset: 0x00C84BED
		// (set) Token: 0x0602CAEF RID: 183023 RVA: 0x00C869F5 File Offset: 0x00C84BF5
		public int CountryId { get; set; }

		// Token: 0x170059B9 RID: 22969
		// (get) Token: 0x0602CAF0 RID: 183024 RVA: 0x00C869FE File Offset: 0x00C84BFE
		// (set) Token: 0x0602CAF1 RID: 183025 RVA: 0x00C86A06 File Offset: 0x00C84C06
		public int MarkId { get; set; }

		// Token: 0x170059BA RID: 22970
		// (get) Token: 0x0602CAF2 RID: 183026 RVA: 0x00C86A0F File Offset: 0x00C84C0F
		// (set) Token: 0x0602CAF3 RID: 183027 RVA: 0x00C86A17 File Offset: 0x00C84C17
		public EMarkType MarkType { get; set; }

		// Token: 0x170059BB RID: 22971
		// (get) Token: 0x0602CAF4 RID: 183028 RVA: 0x00C86A20 File Offset: 0x00C84C20
		// (set) Token: 0x0602CAF5 RID: 183029 RVA: 0x00C86A28 File Offset: 0x00C84C28
		public int SortIndex { get; set; }

		// Token: 0x170059BC RID: 22972
		// (get) Token: 0x0602CAF6 RID: 183030 RVA: 0x00C86A31 File Offset: 0x00C84C31
		// (set) Token: 0x0602CAF7 RID: 183031 RVA: 0x00C86A39 File Offset: 0x00C84C39
		public int MapConfigId { get; set; }
	}
}
