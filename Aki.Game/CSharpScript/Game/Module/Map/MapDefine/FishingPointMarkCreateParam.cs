using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004536 RID: 17718
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingPointMarkCreateParam : IDynamicMarkCreateParams
	{
		// Token: 0x17005989 RID: 22921
		// (get) Token: 0x0602CA9B RID: 182939 RVA: 0x00C868D5 File Offset: 0x00C84AD5
		// (set) Token: 0x0602CA9C RID: 182940 RVA: 0x00C868DD File Offset: 0x00C84ADD
		public TTrackTarget TrackTarget { get; set; }

		// Token: 0x1700598A RID: 22922
		// (get) Token: 0x0602CA9D RID: 182941 RVA: 0x00C868E6 File Offset: 0x00C84AE6
		// (set) Token: 0x0602CA9E RID: 182942 RVA: 0x00C868EE File Offset: 0x00C84AEE
		public int MarkConfigId { get; set; }

		// Token: 0x1700598B RID: 22923
		// (get) Token: 0x0602CA9F RID: 182943 RVA: 0x00C868F7 File Offset: 0x00C84AF7
		// (set) Token: 0x0602CAA0 RID: 182944 RVA: 0x00C868FF File Offset: 0x00C84AFF
		public EMarkType MarkType { get; set; }

		// Token: 0x1700598C RID: 22924
		// (get) Token: 0x0602CAA1 RID: 182945 RVA: 0x00C86908 File Offset: 0x00C84B08
		// (set) Token: 0x0602CAA2 RID: 182946 RVA: 0x00C86910 File Offset: 0x00C84B10
		public int? MarkId { get; set; }

		// Token: 0x1700598D RID: 22925
		// (get) Token: 0x0602CAA3 RID: 182947 RVA: 0x00C86919 File Offset: 0x00C84B19
		// (set) Token: 0x0602CAA4 RID: 182948 RVA: 0x00C86921 File Offset: 0x00C84B21
		public ETrackSource? TrackSource { get; set; }

		// Token: 0x1700598E RID: 22926
		// (get) Token: 0x0602CAA5 RID: 182949 RVA: 0x00C8692A File Offset: 0x00C84B2A
		// (set) Token: 0x0602CAA6 RID: 182950 RVA: 0x00C86932 File Offset: 0x00C84B32
		public bool? DestroyOnUnTrack { get; set; }

		// Token: 0x1700598F RID: 22927
		// (get) Token: 0x0602CAA7 RID: 182951 RVA: 0x00C8693B File Offset: 0x00C84B3B
		// (set) Token: 0x0602CAA8 RID: 182952 RVA: 0x00C86943 File Offset: 0x00C84B43
		public int? TeleportId { get; set; }

		// Token: 0x17005990 RID: 22928
		// (get) Token: 0x0602CAA9 RID: 182953 RVA: 0x00C8694C File Offset: 0x00C84B4C
		// (set) Token: 0x0602CAAA RID: 182954 RVA: 0x00C86954 File Offset: 0x00C84B54
		public int? EntityConfigId { get; set; }

		// Token: 0x17005991 RID: 22929
		// (get) Token: 0x0602CAAB RID: 182955 RVA: 0x00C8695D File Offset: 0x00C84B5D
		// (set) Token: 0x0602CAAC RID: 182956 RVA: 0x00C86965 File Offset: 0x00C84B65
		public MarkState? ServerMarkState { get; set; }

		// Token: 0x17005992 RID: 22930
		// (get) Token: 0x0602CAAD RID: 182957 RVA: 0x00C8696E File Offset: 0x00C84B6E
		// (set) Token: 0x0602CAAE RID: 182958 RVA: 0x00C86976 File Offset: 0x00C84B76
		[Nullable(2)]
		public MapAndDungeonInfo MapAndDungeonInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005993 RID: 22931
		// (get) Token: 0x0602CAAF RID: 182959 RVA: 0x00C8697F File Offset: 0x00C84B7F
		// (set) Token: 0x0602CAB0 RID: 182960 RVA: 0x00C86987 File Offset: 0x00C84B87
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17005994 RID: 22932
		// (get) Token: 0x0602CAB1 RID: 182961 RVA: 0x00C86990 File Offset: 0x00C84B90
		// (set) Token: 0x0602CAB2 RID: 182962 RVA: 0x00C86998 File Offset: 0x00C84B98
		public int? AreaId { get; set; }

		// Token: 0x17005995 RID: 22933
		// (get) Token: 0x0602CAB3 RID: 182963 RVA: 0x00C869A1 File Offset: 0x00C84BA1
		// (set) Token: 0x0602CAB4 RID: 182964 RVA: 0x00C869A9 File Offset: 0x00C84BA9
		public EFishPointDetectSourceType FishPointDetectSourceType { get; set; }
	}
}
