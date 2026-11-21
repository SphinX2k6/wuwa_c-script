using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EE0 RID: 12000
public class __AudioVisualizationInstanceBase_SubClassMissingExportProxy : __AudioVisualizationInstanceBase_InheritProxy
{
	// Token: 0x0601C970 RID: 117104 RVA: 0x008BE7A8 File Offset: 0x008BC9A8
	[NullableContext(1)]
	protected __AudioVisualizationInstanceBase_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AudioVisualizationInstanceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C971 RID: 117105 RVA: 0x008BE7DB File Offset: 0x008BC9DB
	protected __AudioVisualizationInstanceBase_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
