using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002519 RID: 9497
public class GameplayCueHookUp : GameplayCueBase
{
	// Token: 0x060177DC RID: 96220 RVA: 0x006EE993 File Offset: 0x006ECB93
	protected override void OnInit()
	{
	}

	// Token: 0x060177DD RID: 96221 RVA: 0x006EE995 File Offset: 0x006ECB95
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x060177DE RID: 96222 RVA: 0x006EE998 File Offset: 0x006ECB98
	protected override void OnCreate()
	{
		this.HookItem = GameplayCueHookCommonItem.Spawn(this.ActorInternal, FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value, this.GetTargetPosition(), this.CueConfig.Resources(), true);
	}

	// Token: 0x060177DF RID: 96223 RVA: 0x006EE9E0 File Offset: 0x006ECBE0
	protected override void OnDestroy()
	{
		this.HookItem.Destroy();
	}

	// Token: 0x060177E0 RID: 96224 RVA: 0x006EE9F0 File Offset: 0x006ECBF0
	private FVectorDouble GetTargetPosition()
	{
		Aki.Config.Vector value = this.CueConfig.Location.Value;
		FTransformDouble ftransformDouble = this.ActorInternal.D_GetTransform();
		FVectorDouble fvectorDouble = new FVectorDouble((double)value.X, (double)value.Y, (double)value.Z);
		return ftransformDouble.TransformPositionNoScale(fvectorDouble);
	}

	// Token: 0x0400C7D7 RID: 51159
	[Nullable(2)]
	private GameplayCueHookCommonItem HookItem;
}
