using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002FC5 RID: 12229
public class GameplayCueHookUp : GameplayCueBase
{
	// Token: 0x06019ECA RID: 106186 RVA: 0x006C80BF File Offset: 0x006C62BF
	protected override void OnInit()
	{
	}

	// Token: 0x06019ECB RID: 106187 RVA: 0x006C80C1 File Offset: 0x006C62C1
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x06019ECC RID: 106188 RVA: 0x006C80C4 File Offset: 0x006C62C4
	protected override void OnCreate()
	{
		this.HookItem = GameplayCueHookCommonItem.Spawn(this.ActorInternal, FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value, this.GetTargetPosition(), this.CueConfig.Resources(), true);
	}

	// Token: 0x06019ECD RID: 106189 RVA: 0x006C810C File Offset: 0x006C630C
	protected override void OnDestroy()
	{
		this.HookItem.Destroy();
	}

	// Token: 0x06019ECE RID: 106190 RVA: 0x006C811C File Offset: 0x006C631C
	private FVectorDouble GetTargetPosition()
	{
		Aki.Config.Vector value = this.CueConfig.Location.Value;
		FTransformDouble ftransformDouble = this.ActorInternal.D_GetTransform();
		FVectorDouble fvectorDouble = new FVectorDouble((double)value.X, (double)value.Y, (double)value.Z);
		return ftransformDouble.TransformPositionNoScale(fvectorDouble);
	}

	// Token: 0x0400C42E RID: 50222
	[Nullable(2)]
	private GameplayCueHookCommonItem HookItem;
}
