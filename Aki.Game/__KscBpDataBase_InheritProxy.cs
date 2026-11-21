using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E19 RID: 11801
public class __KscBpDataBase_InheritProxy : KscBpDataBase
{
	// Token: 0x0601C71E RID: 116510 RVA: 0x008BAB84 File Offset: 0x008B8D84
	[NullableContext(1)]
	public __KscBpDataBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBpDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C71F RID: 116511 RVA: 0x008BABB7 File Offset: 0x008B8DB7
	protected __KscBpDataBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
