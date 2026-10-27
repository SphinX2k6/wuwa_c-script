using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.Blueprints
{
	// Token: 0x02004269 RID: 17001
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/ML_InputComponent.ML_InputComponent_C")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public abstract class ML_InputComponent_C : BP_InputBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C159 RID: 180569 RVA: 0x00A1512D File Offset: 0x00A1332D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ML_InputComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/ML_InputComponent.ML_InputComponent_C");
			}
			return ML_InputComponent_C._ClassPtr;
		}

		// Token: 0x0602C15A RID: 180570 RVA: 0x00A15154 File Offset: 0x00A13354
		protected ML_InputComponent_C() : this(BuiltinUtils.AllocNativeUObject(ML_InputComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C15B RID: 180571 RVA: 0x00A1517C File Offset: 0x00A1337C
		protected ML_InputComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040170E6 RID: 94438
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/ML_InputComponent.ML_InputComponent_C";

		// Token: 0x040170E7 RID: 94439
		private static IntPtr _ClassPtr;

		// Token: 0x040170E8 RID: 94440
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
