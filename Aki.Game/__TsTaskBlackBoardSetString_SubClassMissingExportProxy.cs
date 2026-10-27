using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003657 RID: 13911
public class __TsTaskBlackBoardSetString_SubClassMissingExportProxy : __TsTaskBlackBoardSetString_InheritProxy
{
	// Token: 0x0601E26F RID: 123503 RVA: 0x00882B20 File Offset: 0x00880D20
	[NullableContext(1)]
	protected __TsTaskBlackBoardSetString_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E270 RID: 123504 RVA: 0x00882B53 File Offset: 0x00880D53
	protected __TsTaskBlackBoardSetString_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E271 RID: 123505 RVA: 0x00882B5C File Offset: 0x00880D5C
	protected unsafe override void InitTsVariables()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitTsVariables"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
