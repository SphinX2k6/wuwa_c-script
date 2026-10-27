using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002C7D RID: 11389
[NullableContext(1)]
[Nullable(0)]
public class UiEffectAnsContext : UiAnsContextBase
{
	// Token: 0x17001FF7 RID: 8183
	// (get) Token: 0x06017CAB RID: 97451 RVA: 0x0060D49E File Offset: 0x0060B69E
	public string EffectPath { get; }

	// Token: 0x17001FF8 RID: 8184
	// (get) Token: 0x06017CAC RID: 97452 RVA: 0x0060D4A6 File Offset: 0x0060B6A6
	public USkeletalMeshComponent MeshComponent { get; }

	// Token: 0x17001FF9 RID: 8185
	// (get) Token: 0x06017CAD RID: 97453 RVA: 0x0060D4AE File Offset: 0x0060B6AE
	public FName Socket { get; }

	// Token: 0x17001FFA RID: 8186
	// (get) Token: 0x06017CAE RID: 97454 RVA: 0x0060D4B6 File Offset: 0x0060B6B6
	public bool Attached { get; }

	// Token: 0x17001FFB RID: 8187
	// (get) Token: 0x06017CAF RID: 97455 RVA: 0x0060D4BE File Offset: 0x0060B6BE
	public bool AttachLocationOnly { get; }

	// Token: 0x17001FFC RID: 8188
	// (get) Token: 0x06017CB0 RID: 97456 RVA: 0x0060D4C6 File Offset: 0x0060B6C6
	public FVectorDouble Location { get; }

	// Token: 0x17001FFD RID: 8189
	// (get) Token: 0x06017CB1 RID: 97457 RVA: 0x0060D4CE File Offset: 0x0060B6CE
	public FRotator Rotation { get; }

	// Token: 0x17001FFE RID: 8190
	// (get) Token: 0x06017CB2 RID: 97458 RVA: 0x0060D4D6 File Offset: 0x0060B6D6
	public FVectorDouble Scale { get; }

	// Token: 0x17001FFF RID: 8191
	// (get) Token: 0x06017CB3 RID: 97459 RVA: 0x0060D4DE File Offset: 0x0060B6DE
	public bool PlayOnEnd { get; }

	// Token: 0x17002000 RID: 8192
	// (get) Token: 0x06017CB4 RID: 97460 RVA: 0x0060D4E6 File Offset: 0x0060B6E6
	public bool FasterStop { get; }

	// Token: 0x17002001 RID: 8193
	// (get) Token: 0x06017CB5 RID: 97461 RVA: 0x0060D4EE File Offset: 0x0060B6EE
	public EffectContext EffectContext { get; }

	// Token: 0x17002002 RID: 8194
	// (get) Token: 0x06017CB6 RID: 97462 RVA: 0x0060D4F6 File Offset: 0x0060B6F6
	public FName MultiInstanceKey { get; }

	// Token: 0x17002003 RID: 8195
	// (get) Token: 0x06017CB7 RID: 97463 RVA: 0x0060D4FE File Offset: 0x0060B6FE
	public Action<USkeletalMeshComponent, int> OnEffectSpawn { get; }

	// Token: 0x06017CB8 RID: 97464 RVA: 0x0060D508 File Offset: 0x0060B708
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

	// Token: 0x06017CB9 RID: 97465 RVA: 0x0060D580 File Offset: 0x0060B780
	public override bool IsValid()
	{
		return this.EffectPath != null && this.Socket != null && this.MeshComponent != null;
	}

	// Token: 0x06017CBA RID: 97466 RVA: 0x0060D5A8 File Offset: 0x0060B7A8
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

	// Token: 0x0400B147 RID: 45383
	public int? Handle;
}
