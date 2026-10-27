using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039B4 RID: 14772
public class __SceneInteractionDebugTool_InheritProxy : SceneInteractionDebugTool
{
	// Token: 0x0601EE55 RID: 126549 RVA: 0x008A0A74 File Offset: 0x0089EC74
	[NullableContext(1)]
	public __SceneInteractionDebugTool_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionDebugTool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE56 RID: 126550 RVA: 0x008A0AA7 File Offset: 0x0089ECA7
	protected __SceneInteractionDebugTool_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EE57 RID: 126551 RVA: 0x008A0AB0 File Offset: 0x0089ECB0
	protected override void __CPPCALL_AttachInteraction_Implementation()
	{
		base.AttachInteraction_Implementation();
	}

	// Token: 0x0601EE58 RID: 126552 RVA: 0x008A0AB8 File Offset: 0x0089ECB8
	protected override void __CPPCALL_RemoveInteraction_Implementation()
	{
		base.RemoveInteraction_Implementation();
	}
}
