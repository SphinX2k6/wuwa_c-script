using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003234 RID: 12852
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_CameraShakeAndForceFeedback.BP_CameraShakeAndForceFeedback_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class BP_CameraShakeAndForceFeedback_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602014A RID: 131402 RVA: 0x0093CBA0 File Offset: 0x0093ADA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraShakeAndForceFeedback_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_CameraShakeAndForceFeedback.BP_CameraShakeAndForceFeedback_C");
			}
			return BP_CameraShakeAndForceFeedback_C._ClassPtr;
		}

		// Token: 0x0602014B RID: 131403 RVA: 0x0093CBC4 File Offset: 0x0093ADC4
		public BP_CameraShakeAndForceFeedback_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraShakeAndForceFeedback_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602014C RID: 131404 RVA: 0x0093CBEC File Offset: 0x0093ADEC
		[NullableContext(1)]
		public BP_CameraShakeAndForceFeedback_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraShakeAndForceFeedback_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0602014D RID: 131405 RVA: 0x0093CC1F File Offset: 0x0093AE1F
		// (set) Token: 0x0602014E RID: 131406 RVA: 0x0093CC33 File Offset: 0x0093AE33
		[Nullable(2)]
		public unsafe UKuroForceFeedbackEffect ForceFeedbackEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShakeAndForceFeedback_C.__PropertyOffset_ForceFeedbackEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShakeAndForceFeedback_C.__PropertyOffset_ForceFeedbackEffect, value);
			}
		}

		// Token: 0x0602014F RID: 131407 RVA: 0x0093CC48 File Offset: 0x0093AE48
		protected BP_CameraShakeAndForceFeedback_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401140C RID: 70668
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_CameraShakeAndForceFeedback.BP_CameraShakeAndForceFeedback_C";

		// Token: 0x0401140D RID: 70669
		private static IntPtr _ClassPtr;

		// Token: 0x0401140E RID: 70670
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401140F RID: 70671
		internal static int __PropertyOffset_ForceFeedbackEffect;
	}
}
