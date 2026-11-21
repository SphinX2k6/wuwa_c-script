using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E3D RID: 11837
public class __TsSceneDecorativeUiActor_InheritProxy : TsSceneDecorativeUiActor
{
	// Token: 0x0601C78A RID: 116618 RVA: 0x008BB740 File Offset: 0x008B9940
	[NullableContext(1)]
	public __TsSceneDecorativeUiActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneDecorativeUiActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C78B RID: 116619 RVA: 0x008BB773 File Offset: 0x008B9973
	protected __TsSceneDecorativeUiActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C78C RID: 116620 RVA: 0x008BB77C File Offset: 0x008B997C
	protected override void __CPPCALL_Create3dUi_Implementation()
	{
		base.Create3dUi_Implementation();
	}

	// Token: 0x0601C78D RID: 116621 RVA: 0x008BB784 File Offset: 0x008B9984
	protected override void __CPPCALL_Destroy3dUi_Implementation()
	{
		base.Destroy3dUi_Implementation();
	}

	// Token: 0x0601C78E RID: 116622 RVA: 0x008BB78C File Offset: 0x008B998C
	protected override void __CPPCALL_DrawDistance_Implementation()
	{
		base.DrawDistance_Implementation();
	}
}
