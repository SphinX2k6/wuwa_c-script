using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x020021E0 RID: 8672
[NullableContext(2)]
[Nullable(0)]
public class UiModelEffectPlayContext
{
	// Token: 0x06015574 RID: 87412 RVA: 0x00634298 File Offset: 0x00632498
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

	// Token: 0x0400B4F3 RID: 46323
	public string EffectPath;

	// Token: 0x0400B4F4 RID: 46324
	public FTransformDouble Transform = MathUtils.Instance.DefaultTransformDouble;

	// Token: 0x0400B4F5 RID: 46325
	public USceneComponent AttachTargetComponent;

	// Token: 0x0400B4F6 RID: 46326
	public bool Attached = true;

	// Token: 0x0400B4F7 RID: 46327
	public bool AttachLocationOnly;

	// Token: 0x0400B4F8 RID: 46328
	public FName SocketName = FNameUtil.EMPTY;

	// Token: 0x0400B4F9 RID: 46329
	public bool IsForceShow = true;

	// Token: 0x0400B4FA RID: 46330
	public FVectorDouble Location = Vector.ZeroVectorDouble;

	// Token: 0x0400B4FB RID: 46331
	public FRotator Rotator = global::Rotator.ZeroRotator;

	// Token: 0x0400B4FC RID: 46332
	public FVectorDouble Scale = Vector.OneVectorDouble;

	// Token: 0x0400B4FD RID: 46333
	public EAttachmentRule LocationRule;

	// Token: 0x0400B4FE RID: 46334
	public EAttachmentRule RotationRule;

	// Token: 0x0400B4FF RID: 46335
	public EAttachmentRule ScaleRule;

	// Token: 0x0400B500 RID: 46336
	public EEffectType EffectType = EEffectType.UiScene3D;

	// Token: 0x0400B501 RID: 46337
	public Action<ELoadEffectResult, int> Callback;
}
