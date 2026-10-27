using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D30 RID: 15664
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_HHAGlobalGI.BP_HHAGlobalGI_C")]
	[UnrealStructLayout(17344, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 17343)]
	public class BP_HHAGlobalGI_C : BP_GlobalGI_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F34 RID: 155444 RVA: 0x00967359 File Offset: 0x00965559
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HHAGlobalGI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_HHAGlobalGI.BP_HHAGlobalGI_C");
			}
			return BP_HHAGlobalGI_C._ClassPtr;
		}

		// Token: 0x06025F35 RID: 155445 RVA: 0x00967380 File Offset: 0x00965580
		public BP_HHAGlobalGI_C() : this(BuiltinUtils.AllocNativeUObject(BP_HHAGlobalGI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F36 RID: 155446 RVA: 0x009673A8 File Offset: 0x009655A8
		[NullableContext(1)]
		public BP_HHAGlobalGI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HHAGlobalGI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025F37 RID: 155447 RVA: 0x009673DB File Offset: 0x009655DB
		protected BP_HHAGlobalGI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012FBF RID: 77759
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_HHAGlobalGI.BP_HHAGlobalGI_C";

		// Token: 0x04012FC0 RID: 77760
		private static IntPtr _ClassPtr;

		// Token: 0x04012FC1 RID: 77761
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
