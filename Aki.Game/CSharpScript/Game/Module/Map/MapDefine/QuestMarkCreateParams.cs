using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200455D RID: 17757
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMarkCreateParams : IDynamicMarkCreateParams
	{
		// Token: 0x17005A25 RID: 23077
		// (get) Token: 0x0602CBCB RID: 183243 RVA: 0x00C872B7 File Offset: 0x00C854B7
		// (set) Token: 0x0602CBCC RID: 183244 RVA: 0x00C872BF File Offset: 0x00C854BF
		public TTrackTarget TrackTarget { get; set; }

		// Token: 0x17005A26 RID: 23078
		// (get) Token: 0x0602CBCD RID: 183245 RVA: 0x00C872C8 File Offset: 0x00C854C8
		// (set) Token: 0x0602CBCE RID: 183246 RVA: 0x00C872D0 File Offset: 0x00C854D0
		public int MarkConfigId { get; set; }

		// Token: 0x17005A27 RID: 23079
		// (get) Token: 0x0602CBCF RID: 183247 RVA: 0x00C872D9 File Offset: 0x00C854D9
		// (set) Token: 0x0602CBD0 RID: 183248 RVA: 0x00C872E1 File Offset: 0x00C854E1
		public EMarkType MarkType { get; set; }

		// Token: 0x17005A28 RID: 23080
		// (get) Token: 0x0602CBD1 RID: 183249 RVA: 0x00C872EA File Offset: 0x00C854EA
		// (set) Token: 0x0602CBD2 RID: 183250 RVA: 0x00C872F2 File Offset: 0x00C854F2
		public int? MarkId { get; set; }

		// Token: 0x17005A29 RID: 23081
		// (get) Token: 0x0602CBD3 RID: 183251 RVA: 0x00C872FB File Offset: 0x00C854FB
		// (set) Token: 0x0602CBD4 RID: 183252 RVA: 0x00C87303 File Offset: 0x00C85503
		public ETrackSource? TrackSource { get; set; }

		// Token: 0x17005A2A RID: 23082
		// (get) Token: 0x0602CBD5 RID: 183253 RVA: 0x00C8730C File Offset: 0x00C8550C
		// (set) Token: 0x0602CBD6 RID: 183254 RVA: 0x00C87314 File Offset: 0x00C85514
		public bool? DestroyOnUnTrack { get; set; }

		// Token: 0x17005A2B RID: 23083
		// (get) Token: 0x0602CBD7 RID: 183255 RVA: 0x00C8731D File Offset: 0x00C8551D
		// (set) Token: 0x0602CBD8 RID: 183256 RVA: 0x00C87325 File Offset: 0x00C85525
		public int? TeleportId { get; set; }

		// Token: 0x17005A2C RID: 23084
		// (get) Token: 0x0602CBD9 RID: 183257 RVA: 0x00C8732E File Offset: 0x00C8552E
		// (set) Token: 0x0602CBDA RID: 183258 RVA: 0x00C87336 File Offset: 0x00C85536
		public int? EntityConfigId { get; set; }

		// Token: 0x17005A2D RID: 23085
		// (get) Token: 0x0602CBDB RID: 183259 RVA: 0x00C8733F File Offset: 0x00C8553F
		// (set) Token: 0x0602CBDC RID: 183260 RVA: 0x00C87347 File Offset: 0x00C85547
		public MarkState? ServerMarkState { get; set; }

		// Token: 0x17005A2E RID: 23086
		// (get) Token: 0x0602CBDD RID: 183261 RVA: 0x00C87350 File Offset: 0x00C85550
		// (set) Token: 0x0602CBDE RID: 183262 RVA: 0x00C87358 File Offset: 0x00C85558
		[Nullable(2)]
		public MapAndDungeonInfo MapAndDungeonInfo { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005A2F RID: 23087
		// (get) Token: 0x0602CBDF RID: 183263 RVA: 0x00C87361 File Offset: 0x00C85561
		// (set) Token: 0x0602CBE0 RID: 183264 RVA: 0x00C87369 File Offset: 0x00C85569
		public EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17005A30 RID: 23088
		// (get) Token: 0x0602CBE1 RID: 183265 RVA: 0x00C87372 File Offset: 0x00C85572
		// (set) Token: 0x0602CBE2 RID: 183266 RVA: 0x00C8737A File Offset: 0x00C8557A
		public int? AreaId { get; set; }

		// Token: 0x04017FE4 RID: 98276
		public long TreeId;

		// Token: 0x04017FE5 RID: 98277
		public int NodeId;

		// Token: 0x04017FE6 RID: 98278
		public bool? IsBoundToParentQuest;
	}
}
