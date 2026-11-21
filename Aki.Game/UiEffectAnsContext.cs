using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x020021D6 RID: 8662
[NullableContext(1)]
[Nullable(0)]
public class UiEffectAnsContext : UiAnsContextBase
{
	// Token: 0x17002048 RID: 8264
	// (get) Token: 0x0601551E RID: 87326 RVA: 0x00632F82 File Offset: 0x00631182
	public string EffectPath { get; }

	// Token: 0x17002049 RID: 8265
	// (get) Token: 0x0601551F RID: 87327 RVA: 0x00632F8A File Offset: 0x0063118A
	public USkeletalMeshComponent MeshComponent { get; }

	// Token: 0x1700204A RID: 8266
	// (get) Token: 0x06015520 RID: 87328 RVA: 0x00632F92 File Offset: 0x00631192
	public FName Socket { get; }

	// Token: 0x1700204B RID: 8267
	// (get) Token: 0x06015521 RID: 87329 RVA: 0x00632F9A File Offset: 0x0063119A
	public bool Attached { get; }

	// Token: 0x1700204C RID: 8268
	// (get) Token: 0x06015522 RID: 87330 RVA: 0x00632FA2 File Offset: 0x006311A2
	public bool AttachLocationOnly { get; }

	// Token: 0x1700204D RID: 8269
	// (get) Token: 0x06015523 RID: 87331 RVA: 0x00632FAA File Offset: 0x006311AA
	public FVectorDouble Location { get; }

	// Token: 0x1700204E RID: 8270
	// (get) Token: 0x06015524 RID: 87332 RVA: 0x00632FB2 File Offset: 0x006311B2
	public FRotator Rotation { get; }

	// Token: 0x1700204F RID: 8271
	// (get) Token: 0x06015525 RID: 87333 RVA: 0x00632FBA File Offset: 0x006311BA
	public FVectorDouble Scale { get; }

	// Token: 0x17002050 RID: 8272
	// (get) Token: 0x06015526 RID: 87334 RVA: 0x00632FC2 File Offset: 0x006311C2
	public bool PlayOnEnd { get; }

	// Token: 0x17002051 RID: 8273
	// (get) Token: 0x06015527 RID: 87335 RVA: 0x00632FCA File Offset: 0x006311CA
	public bool FasterStop { get; }

	// Token: 0x17002052 RID: 8274
	// (get) Token: 0x06015528 RID: 87336 RVA: 0x00632FD2 File Offset: 0x006311D2
	public EffectContext EffectContext { get; }

	// Token: 0x17002053 RID: 8275
	// (get) Token: 0x06015529 RID: 87337 RVA: 0x00632FDA File Offset: 0x006311DA
	public FName MultiInstanceKey { get; }

	// Token: 0x17002054 RID: 8276
	// (get) Token: 0x0601552A RID: 87338 RVA: 0x00632FE2 File Offset: 0x006311E2
	public Action<USkeletalMeshComponent, int> OnEffectSpawn { get; }

	// Token: 0x0601552B RID: 87339 RVA: 0x00632FEC File Offset: 0x006311EC
	public UiEffectAnsContext(string effectPath, USkeletalMeshComponent meshComponent, FName socket, bool attached, bool attachLocationOnly, FVectorDouble location, FRotator rotation, FVectorDouble scale, bool playOnEnd, bool fasterStop, EffectContext effectContext, FName effectInstanceName, Action<USkeletalMeshComponent, int> onEffectSpawn)
	{
		this.EffectPath = effectPath;
		this.MeshComponent = meshComponent;
		this.Socket = socket;
		this.Attached = attached;
		this.AttachLocationOnly = attachLocationOnly;
		this.Location = location;
		this.Rotation = rotation;
		this.Scale = scale;
		this.PlayOnEnd = playOnEnd;
		this.FasterStop = fasterStop;
		this.EffectContext = effectContext;
		this.MultiInstanceKey = effectInstanceName;
		this.OnEffectSpawn = onEffectSpawn;
	}

	// Token: 0x0601552C RID: 87340 RVA: 0x00633064 File Offset: 0x00631264
	public override bool IsValid()
	{
		return this.EffectPath != null && this.Socket != null && this.MeshComponent != null;
	}

	// Token: 0x0601552D RID: 87341 RVA: 0x0063308C File Offset: 0x0063128C
	public override bool IsEqual(UiAnsContextBase inAnsContext)
	{
		UiEffectAnsContext uiEffectAnsContext = inAnsContext as UiEffectAnsContext;
		if (uiEffectAnsContext == null)
		{
			return false;
		}
		if (!this.IsValid() || !uiEffectAnsContext.IsValid())
		{
			return false;
		}
		FName a = (this.MultiInstanceKey == default(FName)) ? FNameUtil.NONE : this.MultiInstanceKey;
		FName b = (uiEffectAnsContext.MultiInstanceKey == default(FName)) ? FNameUtil.NONE : uiEffectAnsContext.MultiInstanceKey;
		return this.EffectPath == uiEffectAnsContext.EffectPath && this.Socket == uiEffectAnsContext.Socket && this.MeshComponent == uiEffectAnsContext.MeshComponent && a == b;
	}

	// Token: 0x0400B4B2 RID: 46258
	public int? Handle;
}
