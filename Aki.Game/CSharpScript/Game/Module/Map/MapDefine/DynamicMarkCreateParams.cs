using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004525 RID: 17701
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicMarkCreateParams : IDynamicMarkCreateParams
	{
		// Token: 0x1700597C RID: 22908
		// (get) Token: 0x0602CA80 RID: 182912 RVA: 0x00C867E6 File Offset: 0x00C849E6
		// (set) Token: 0x0602CA81 RID: 182913 RVA: 0x00C867EE File Offset: 0x00C849EE
		public TTrackTarget TrackTarget { get; set; }

		// Token: 0x1700597D RID: 22909
		// (get) Token: 0x0602CA82 RID: 182914 RVA: 0x00C867F7 File Offset: 0x00C849F7
		// (set) Token: 0x0602CA83 RID: 182915 RVA: 0x00C867FF File Offset: 0x00C849FF
		public int MarkConfigId { get; set; }

		// Token: 0x1700597E RID: 22910
		// (get) Token: 0x0602CA84 RID: 182916 RVA: 0x00C86808 File Offset: 0x00C84A08
		// (set) Token: 0x0602CA85 RID: 182917 RVA: 0x00C86810 File Offset: 0x00C84A10
		public EMarkType MarkType { get; set; }

		// Token: 0x1700597F RID: 22911
		// (get) Token: 0x0602CA86 RID: 182918 RVA: 0x00C86819 File Offset: 0x00C84A19
		// (set) Token: 0x0602CA87 RID: 182919 RVA: 0x00C86821 File Offset: 0x00C84A21
		public int? MarkId { get; set; }

		// Token: 0x17005980 RID: 22912
		// (get) Token: 0x0602CA88 RID: 182920 RVA: 0x00C8682A File Offset: 0x00C84A2A
		// (set) Token: 0x0602CA89 RID: 182921 RVA: 0x00C86832 File Offset: 0x00C84A32
		public ETrackSource? TrackSource { get; set; }

		// Token: 0x17005981 RID: 22913
		// (get) Token: 0x0602CA8A RID: 182922 RVA: 0x00C8683B File Offset: 0x00C84A3B
		// (set) Token: 0x0602CA8B RID: 182923 RVA: 0x00C86843 File Offset: 0x00C84A43
		public bool? DestroyOnUnTrack { get; set; }

		// Token: 0x17005982 RID: 22914
		// (get) Token: 0x0602CA8C RID: 182924 RVA: 0x00C8684C File Offset: 0x00C84A4C
		// (set) Token: 0x0602CA8D RID: 182925 RVA: 0x00C86854 File Offset: 0x00C84A54
		public int? TeleportId { get; set; }

		// Token: 0x17005983 RID: 22915
		// (get) Token: 0x0602CA8E RID: 182926 RVA: 0x00C8685D File Offset: 0x00C84A5D
		// (set) Token: 0x0602CA8F RID: 182927 RVA: 0x00C86865 File Offset: 0x00C84A65
		public int? EntityConfigId { get; set; }

		// Token: 0x17005984 RID: 22916
		// (get) Token: 0x0602CA90 RID: 182928 RVA: 0x00C8686E File Offset: 0x00C84A6E
		// (set) Token: 0x0602CA91 RID: 182929 RVA: 0x00C86876 File Offset: 0x00C84A76
		public MarkState? ServerMarkState { get; set; }

		// Token: 0x17005985 RID: 22917
		// (get) Token: 0x0602CA92 RID: 182930 RVA: 0x00C8687F File Offset: 0x00C84A7F
		// (set) Token: 0x0602CA93 RID: 182931 RVA: 0x00C86887 File Offset: 0x00C84A87
		[Nullable(2)]
		public MapAndDungeonInfo MapAndDungeonInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005986 RID: 22918
		// (get) Token: 0x0602CA94 RID: 182932 RVA: 0x00C86890 File Offset: 0x00C84A90
		// (set) Token: 0x0602CA95 RID: 182933 RVA: 0x00C86898 File Offset: 0x00C84A98
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17005987 RID: 22919
		// (get) Token: 0x0602CA96 RID: 182934 RVA: 0x00C868A1 File Offset: 0x00C84AA1
		// (set) Token: 0x0602CA97 RID: 182935 RVA: 0x00C868A9 File Offset: 0x00C84AA9
		public int? AreaId { get; set; }
	}
}
