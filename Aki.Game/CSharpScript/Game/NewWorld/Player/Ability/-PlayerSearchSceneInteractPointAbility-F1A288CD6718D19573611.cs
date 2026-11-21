using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.NewWorld.Player.Ability
{
	// Token: 0x020061DE RID: 25054
	[NullableContext(1)]
	[Nullable(0)]
	internal class <PlayerSearchSceneInteractPointAbility>F1A288CD6718D19573611C8AFEB07CD8B0525D222D3381BA0ED014CAAA637126E__SceneInteractSearchParams : ISceneInteractSearchParams
	{
		// Token: 0x17007176 RID: 29046
		// (get) Token: 0x0603C223 RID: 246307 RVA: 0x0111DA2E File Offset: 0x0111BC2E
		// (set) Token: 0x0603C224 RID: 246308 RVA: 0x0111DA36 File Offset: 0x0111BC36
		public Vector CameraLocation { get; set; }

		// Token: 0x17007177 RID: 29047
		// (get) Token: 0x0603C225 RID: 246309 RVA: 0x0111DA3F File Offset: 0x0111BC3F
		// (set) Token: 0x0603C226 RID: 246310 RVA: 0x0111DA47 File Offset: 0x0111BC47
		public Vector CameraForward { get; set; }

		// Token: 0x17007178 RID: 29048
		// (get) Token: 0x0603C227 RID: 246311 RVA: 0x0111DA50 File Offset: 0x0111BC50
		// (set) Token: 0x0603C228 RID: 246312 RVA: 0x0111DA58 File Offset: 0x0111BC58
		public Vector CurrentRoleLocation { get; set; }

		// Token: 0x17007179 RID: 29049
		// (get) Token: 0x0603C229 RID: 246313 RVA: 0x0111DA61 File Offset: 0x0111BC61
		// (set) Token: 0x0603C22A RID: 246314 RVA: 0x0111DA69 File Offset: 0x0111BC69
		[Nullable(2)]
		public EntityHandle CurrentRoleEntityHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700717A RID: 29050
		// (get) Token: 0x0603C22B RID: 246315 RVA: 0x0111DA72 File Offset: 0x0111BC72
		// (set) Token: 0x0603C22C RID: 246316 RVA: 0x0111DA7A File Offset: 0x0111BC7A
		public Func<ISceneInteractPoint, bool> IsInteractingPoint { get; set; }
	}
}
