using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B0B RID: 15115
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Child.BP_KuroLightDecal_Child_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_KuroLightDecal_Child_C : BP_KuroLightDecal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020F16 RID: 134934 RVA: 0x008E0CD0 File Offset: 0x008DEED0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroLightDecal_Child_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Child.BP_KuroLightDecal_Child_C");
			}
			return BP_KuroLightDecal_Child_C._ClassPtr;
		}

		// Token: 0x06020F17 RID: 134935 RVA: 0x008E0CF4 File Offset: 0x008DEEF4
		public BP_KuroLightDecal_Child_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroLightDecal_Child_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F18 RID: 134936 RVA: 0x008E0D1C File Offset: 0x008DEF1C
		[NullableContext(1)]
		public BP_KuroLightDecal_Child_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroLightDecal_Child_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020F19 RID: 134937 RVA: 0x008E0D4F File Offset: 0x008DEF4F
		protected BP_KuroLightDecal_Child_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010036 RID: 65590
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Child.BP_KuroLightDecal_Child_C";

		// Token: 0x04010037 RID: 65591
		private static IntPtr _ClassPtr;

		// Token: 0x04010038 RID: 65592
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
