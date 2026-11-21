using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D02 RID: 23810
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsAttachEffectContext : IEffectContext
	{
		// Token: 0x17006E94 RID: 28308
		// (get) Token: 0x0603A3DB RID: 238555 RVA: 0x01075136 File Offset: 0x01073336
		// (set) Token: 0x0603A3DC RID: 238556 RVA: 0x0107513E File Offset: 0x0107333E
		public string AssetPath { get; set; }

		// Token: 0x17006E95 RID: 28309
		// (get) Token: 0x0603A3DD RID: 238557 RVA: 0x01075147 File Offset: 0x01073347
		// (set) Token: 0x0603A3DE RID: 238558 RVA: 0x0107514F File Offset: 0x0107334F
		public Transform Transform { get; set; }

		// Token: 0x17006E96 RID: 28310
		// (get) Token: 0x0603A3DF RID: 238559 RVA: 0x01075158 File Offset: 0x01073358
		// (set) Token: 0x0603A3E0 RID: 238560 RVA: 0x01075160 File Offset: 0x01073360
		[Nullable(2)]
		public EntityHandle EntityHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006E97 RID: 28311
		// (get) Token: 0x0603A3E1 RID: 238561 RVA: 0x01075169 File Offset: 0x01073369
		// (set) Token: 0x0603A3E2 RID: 238562 RVA: 0x01075171 File Offset: 0x01073371
		public bool? ShouldAttachToEntity { get; set; }

		// Token: 0x17006E98 RID: 28312
		// (get) Token: 0x0603A3E3 RID: 238563 RVA: 0x0107517A File Offset: 0x0107337A
		// (set) Token: 0x0603A3E4 RID: 238564 RVA: 0x01075182 File Offset: 0x01073382
		public FName? AttachSocket { get; set; }

		// Token: 0x17006E99 RID: 28313
		// (get) Token: 0x0603A3E5 RID: 238565 RVA: 0x0107518B File Offset: 0x0107338B
		// (set) Token: 0x0603A3E6 RID: 238566 RVA: 0x01075193 File Offset: 0x01073393
		[Nullable(2)]
		public Vector AttachOffset { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0603A3E7 RID: 238567 RVA: 0x0107519C File Offset: 0x0107339C
		public TsAttachEffectContext(string assetPath, Transform transform, [Nullable(2)] EntityHandle entityHandle = null, bool? shouldAttachToEntity = null, FName? attachSocket = null, [Nullable(2)] Vector attachOffset = null)
		{
			this.AssetPath = assetPath;
			this.Transform = transform;
			this.EntityHandle = entityHandle;
			this.ShouldAttachToEntity = shouldAttachToEntity;
			this.AttachSocket = attachSocket;
			this.AttachOffset = attachOffset;
		}
	}
}
