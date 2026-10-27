using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038EB RID: 14571
public class __BulletBlueprintFunctionLibrary_SubClassMissingExportProxy : __BulletBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EB4E RID: 125774 RVA: 0x00897E0C File Offset: 0x0089600C
	[NullableContext(1)]
	protected __BulletBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB4F RID: 125775 RVA: 0x00897E3F File Offset: 0x0089603F
	protected __BulletBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
