using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F2F RID: 12079
public class __SceneInteractionDebugTool_InheritProxy : SceneInteractionDebugTool
{
	// Token: 0x0601CA7E RID: 117374 RVA: 0x008C0758 File Offset: 0x008BE958
	[NullableContext(1)]
	public __SceneInteractionDebugTool_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA7F RID: 117375 RVA: 0x008C078B File Offset: 0x008BE98B
	protected __SceneInteractionDebugTool_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CA80 RID: 117376 RVA: 0x008C0794 File Offset: 0x008BE994
	protected override void __CPPCALL_AttachInteraction_Implementation()
	{
		base.AttachInteraction_Implementation();
	}

	// Token: 0x0601CA81 RID: 117377 RVA: 0x008C079C File Offset: 0x008BE99C
	protected override void __CPPCALL_RemoveInteraction_Implementation()
	{
		base.RemoveInteraction_Implementation();
	}
}
