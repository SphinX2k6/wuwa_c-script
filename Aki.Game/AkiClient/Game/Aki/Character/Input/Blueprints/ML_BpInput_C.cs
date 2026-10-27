using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.Blueprints
{
	// Token: 0x02004268 RID: 17000
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/ML_BpInput.ML_BpInput_C")]
	[UnrealStructLayout(592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 591)]
	public abstract class ML_BpInput_C : BP_InputComponent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C156 RID: 180566 RVA: 0x00A150D8 File Offset: 0x00A132D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ML_BpInput_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/ML_BpInput.ML_BpInput_C");
			}
			return ML_BpInput_C._ClassPtr;
		}

		// Token: 0x0602C157 RID: 180567 RVA: 0x00A150FC File Offset: 0x00A132FC
		protected ML_BpInput_C() : this(BuiltinUtils.AllocNativeUObject(ML_BpInput_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C158 RID: 180568 RVA: 0x00A15124 File Offset: 0x00A13324
		protected ML_BpInput_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040170E3 RID: 94435
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/ML_BpInput.ML_BpInput_C";

		// Token: 0x040170E4 RID: 94436
		private static IntPtr _ClassPtr;

		// Token: 0x040170E5 RID: 94437
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
