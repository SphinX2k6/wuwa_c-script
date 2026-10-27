using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B4 RID: 14516
public class __AiWeaponBlueprintFunctionLibrary_InheritProxy : AiWeaponBlueprintFunctionLibrary
{
	// Token: 0x0601EA8A RID: 125578 RVA: 0x008963C8 File Offset: 0x008945C8
	[NullableContext(1)]
	public __AiWeaponBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AiWeaponBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA8B RID: 125579 RVA: 0x008963FB File Offset: 0x008945FB
	protected __AiWeaponBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
