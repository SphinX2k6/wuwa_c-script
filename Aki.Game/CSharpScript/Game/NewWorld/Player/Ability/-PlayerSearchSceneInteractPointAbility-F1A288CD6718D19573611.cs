using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.NewWorld.Player.Ability
{
	// Token: 0x0200705D RID: 28765
	[NullableContext(1)]
	[Nullable(0)]
	internal class <PlayerSearchSceneInteractPointAbility>F1A288CD6718D19573611C8AFEB07CD8B0525D222D3381BA0ED014CAAA637126E__SceneInteractSearchParams : ISceneInteractSearchParams
	{
		// Token: 0x17009BF2 RID: 39922
		// (get) Token: 0x0604602A RID: 286762 RVA: 0x01173E2F File Offset: 0x0117202F
		// (set) Token: 0x0604602B RID: 286763 RVA: 0x01173E37 File Offset: 0x01172037
		public Vector CameraLocation { get; set; }

		// Token: 0x17009BF3 RID: 39923
		// (get) Token: 0x0604602C RID: 286764 RVA: 0x01173E40 File Offset: 0x01172040
		// (set) Token: 0x0604602D RID: 286765 RVA: 0x01173E48 File Offset: 0x01172048
		public Vector CameraForward { get; set; }

		// Token: 0x17009BF4 RID: 39924
		// (get) Token: 0x0604602E RID: 286766 RVA: 0x01173E51 File Offset: 0x01172051
		// (set) Token: 0x0604602F RID: 286767 RVA: 0x01173E59 File Offset: 0x01172059
		public Vector CurrentRoleLocation { get; set; }

		// Token: 0x17009BF5 RID: 39925
		// (get) Token: 0x06046030 RID: 286768 RVA: 0x01173E62 File Offset: 0x01172062
		// (set) Token: 0x06046031 RID: 286769 RVA: 0x01173E6A File Offset: 0x0117206A
		[Nullable(2)]
		public EntityHandle CurrentRoleEntityHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009BF6 RID: 39926
		// (get) Token: 0x06046032 RID: 286770 RVA: 0x01173E73 File Offset: 0x01172073
		// (set) Token: 0x06046033 RID: 286771 RVA: 0x01173E7B File Offset: 0x0117207B
		public Func<ISceneInteractPoint, bool> IsInteractingPoint { get; set; }
	}
}
