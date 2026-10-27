using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B8A RID: 27530
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsAttachEffectContext : IEffectContext
	{
		// Token: 0x17009991 RID: 39313
		// (get) Token: 0x06044289 RID: 279177 RVA: 0x010CB49E File Offset: 0x010C969E
		// (set) Token: 0x0604428A RID: 279178 RVA: 0x010CB4A6 File Offset: 0x010C96A6
		public string AssetPath { get; set; }

		// Token: 0x17009992 RID: 39314
		// (get) Token: 0x0604428B RID: 279179 RVA: 0x010CB4AF File Offset: 0x010C96AF
		// (set) Token: 0x0604428C RID: 279180 RVA: 0x010CB4B7 File Offset: 0x010C96B7
		public Transform Transform { get; set; }

		// Token: 0x17009993 RID: 39315
		// (get) Token: 0x0604428D RID: 279181 RVA: 0x010CB4C0 File Offset: 0x010C96C0
		// (set) Token: 0x0604428E RID: 279182 RVA: 0x010CB4C8 File Offset: 0x010C96C8
		[Nullable(2)]
		public EntityHandle EntityHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009994 RID: 39316
		// (get) Token: 0x0604428F RID: 279183 RVA: 0x010CB4D1 File Offset: 0x010C96D1
		// (set) Token: 0x06044290 RID: 279184 RVA: 0x010CB4D9 File Offset: 0x010C96D9
		public bool? ShouldAttachToEntity { get; set; }

		// Token: 0x17009995 RID: 39317
		// (get) Token: 0x06044291 RID: 279185 RVA: 0x010CB4E2 File Offset: 0x010C96E2
		// (set) Token: 0x06044292 RID: 279186 RVA: 0x010CB4EA File Offset: 0x010C96EA
		public FName? AttachSocket { get; set; }

		// Token: 0x17009996 RID: 39318
		// (get) Token: 0x06044293 RID: 279187 RVA: 0x010CB4F3 File Offset: 0x010C96F3
		// (set) Token: 0x06044294 RID: 279188 RVA: 0x010CB4FB File Offset: 0x010C96FB
		[Nullable(2)]
		public Vector AttachOffset { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06044295 RID: 279189 RVA: 0x010CB504 File Offset: 0x010C9704
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
