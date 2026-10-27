using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003FAC RID: 16300
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_CameraShakeAndForceFeedback.BP_CameraShakeAndForceFeedback_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class BP_CameraShakeAndForceFeedback_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029B1A RID: 170778 RVA: 0x009CA27A File Offset: 0x009C847A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraShakeAndForceFeedback_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_CameraShakeAndForceFeedback.BP_CameraShakeAndForceFeedback_C");
			}
			return BP_CameraShakeAndForceFeedback_C._ClassPtr;
		}

		// Token: 0x06029B1B RID: 170779 RVA: 0x009CA2A0 File Offset: 0x009C84A0
		public BP_CameraShakeAndForceFeedback_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraShakeAndForceFeedback_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029B1C RID: 170780 RVA: 0x009CA2C8 File Offset: 0x009C84C8
		[NullableContext(1)]
		public BP_CameraShakeAndForceFeedback_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraShakeAndForceFeedback_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064C5 RID: 25797
		// (get) Token: 0x06029B1D RID: 170781 RVA: 0x009CA2FB File Offset: 0x009C84FB
		// (set) Token: 0x06029B1E RID: 170782 RVA: 0x009CA30F File Offset: 0x009C850F
		[Nullable(2)]
		public unsafe UKuroForceFeedbackEffect ForceFeedbackEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShakeAndForceFeedback_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShakeAndForceFeedback_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06029B1F RID: 170783 RVA: 0x009CA324 File Offset: 0x009C8524
		protected BP_CameraShakeAndForceFeedback_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015664 RID: 87652
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_CameraShakeAndForceFeedback.BP_CameraShakeAndForceFeedback_C";

		// Token: 0x04015665 RID: 87653
		private static IntPtr _ClassPtr;

		// Token: 0x04015666 RID: 87654
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015667 RID: 87655
		internal static int __PropertyOffset_0;
	}
}
