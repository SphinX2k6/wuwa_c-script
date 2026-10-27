using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038EC RID: 14572
public class __LogicDataAddBuff_InheritProxy : LogicDataAddBuff
{
	// Token: 0x0601EB50 RID: 125776 RVA: 0x00897E48 File Offset: 0x00896048
	[NullableContext(1)]
	public __LogicDataAddBuff_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB51 RID: 125777 RVA: 0x00897E7B File Offset: 0x0089607B
	protected __LogicDataAddBuff_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
