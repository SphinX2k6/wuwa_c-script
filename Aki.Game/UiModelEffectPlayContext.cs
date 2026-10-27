using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002C87 RID: 11399
[NullableContext(2)]
[Nullable(0)]
public class UiModelEffectPlayContext
{
	// Token: 0x06017D01 RID: 97537 RVA: 0x0060E7D0 File Offset: 0x0060C9D0
	public void Reset()
	{
		this.EffectPath = null;
		this.Transform = MathUtils.Instance.DefaultTransformDouble;
		this.AttachTargetComponent = null;
		this.Attached = true;
		this.AttachLocationOnly = false;
		this.SocketName = FNameUtil.EMPTY;
		this.IsForceShow = true;
		this.Location = Vector.ZeroVectorDouble;
		this.Rotator = global::Rotator.ZeroRotator;
		this.Scale = Vector.OneVectorDouble;
		this.LocationRule = EAttachmentRule.KeepRelative;
		this.RotationRule = EAttachmentRule.KeepRelative;
		this.ScaleRule = EAttachmentRule.KeepRelative;
		this.EffectType = EEffectType.UiScene3D;
		this.Callback = null;
	}

	// Token: 0x0400B188 RID: 45448
	public string EffectPath;

	// Token: 0x0400B189 RID: 45449
	public FTransformDouble Transform = MathUtils.Instance.DefaultTransformDouble;

	// Token: 0x0400B18A RID: 45450
	public USceneComponent AttachTargetComponent;

	// Token: 0x0400B18B RID: 45451
	public bool Attached = true;

	// Token: 0x0400B18C RID: 45452
	public bool AttachLocationOnly;

	// Token: 0x0400B18D RID: 45453
	public FName SocketName = FNameUtil.EMPTY;

	// Token: 0x0400B18E RID: 45454
	public bool IsForceShow = true;

	// Token: 0x0400B18F RID: 45455
	public FVectorDouble Location = Vector.ZeroVectorDouble;

	// Token: 0x0400B190 RID: 45456
	public FRotator Rotator = global::Rotator.ZeroRotator;

	// Token: 0x0400B191 RID: 45457
	public FVectorDouble Scale = Vector.OneVectorDouble;

	// Token: 0x0400B192 RID: 45458
	public EAttachmentRule LocationRule;

	// Token: 0x0400B193 RID: 45459
	public EAttachmentRule RotationRule;

	// Token: 0x0400B194 RID: 45460
	public EAttachmentRule ScaleRule;

	// Token: 0x0400B195 RID: 45461
	public EEffectType EffectType = EEffectType.UiScene3D;

	// Token: 0x0400B196 RID: 45462
	public Action<ELoadEffectResult, int> Callback;
}
