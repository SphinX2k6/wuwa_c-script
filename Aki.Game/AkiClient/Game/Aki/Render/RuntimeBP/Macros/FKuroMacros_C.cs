using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Macros
{
	// Token: 0x02003CEF RID: 15599
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Macros/FKuroMacros.FKuroMacros_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class FKuroMacros_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060252DB RID: 152283 RVA: 0x00953199 File Offset: 0x00951399
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (FKuroMacros_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Macros/FKuroMacros.FKuroMacros_C");
			}
			return FKuroMacros_C._ClassPtr;
		}

		// Token: 0x060252DC RID: 152284 RVA: 0x009531C0 File Offset: 0x009513C0
		protected FKuroMacros_C() : this(BuiltinUtils.AllocNativeUObject(FKuroMacros_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060252DD RID: 152285 RVA: 0x009531E8 File Offset: 0x009513E8
		protected FKuroMacros_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012846 RID: 75846
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Macros/FKuroMacros.FKuroMacros_C";

		// Token: 0x04012847 RID: 75847
		private static IntPtr _ClassPtr;

		// Token: 0x04012848 RID: 75848
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
