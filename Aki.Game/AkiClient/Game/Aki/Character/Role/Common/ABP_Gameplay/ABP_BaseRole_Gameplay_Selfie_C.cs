using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x020032AD RID: 12973
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Selfie.ABP_BaseRole_Gameplay_Selfie_C")]
	[UnrealStructLayout(7424, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7416)]
	public class ABP_BaseRole_Gameplay_Selfie_C : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A1D RID: 133661 RVA: 0x0094B7FB File Offset: 0x009499FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Selfie_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Selfie.ABP_BaseRole_Gameplay_Selfie_C");
			}
			return ABP_BaseRole_Gameplay_Selfie_C._ClassPtr;
		}

		// Token: 0x06020A1E RID: 133662 RVA: 0x0094B820 File Offset: 0x00949A20
		public ABP_BaseRole_Gameplay_Selfie_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Selfie_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A1F RID: 133663 RVA: 0x0094B848 File Offset: 0x00949A48
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Selfie_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Selfie_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x06020A20 RID: 133664 RVA: 0x0094B87B File Offset: 0x00949A7B
		// (set) Token: 0x06020A21 RID: 133665 RVA: 0x0094B88F File Offset: 0x00949A8F
		public unsafe TsBaseCharacter 角色蓝图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_角色蓝图);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x06020A22 RID: 133666 RVA: 0x0094B8A4 File Offset: 0x00949AA4
		// (set) Token: 0x06020A23 RID: 133667 RVA: 0x0094B8B4 File Offset: 0x00949AB4
		public unsafe float ArmPitchAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_ArmPitchAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_ArmPitchAngle) = value;
			}
		}

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x06020A24 RID: 133668 RVA: 0x0094B8C5 File Offset: 0x00949AC5
		// (set) Token: 0x06020A25 RID: 133669 RVA: 0x0094B8D5 File Offset: 0x00949AD5
		public unsafe float ArmPitchLimitMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_ArmPitchLimitMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_ArmPitchLimitMin) = value;
			}
		}

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x06020A26 RID: 133670 RVA: 0x0094B8E6 File Offset: 0x00949AE6
		// (set) Token: 0x06020A27 RID: 133671 RVA: 0x0094B8F6 File Offset: 0x00949AF6
		public unsafe float ArmPitchLimitMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_ArmPitchLimitMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_ArmPitchLimitMax) = value;
			}
		}

		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x06020A28 RID: 133672 RVA: 0x0094B907 File Offset: 0x00949B07
		// (set) Token: 0x06020A29 RID: 133673 RVA: 0x0094B917 File Offset: 0x00949B17
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_DeltaTimeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_DeltaTimeX) = value;
			}
		}

		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x06020A2A RID: 133674 RVA: 0x0094B928 File Offset: 0x00949B28
		// (set) Token: 0x06020A2B RID: 133675 RVA: 0x0094B93C File Offset: 0x00949B3C
		public unsafe UKuroAnimInstanceRole Kuro_Anim_Instance_Role
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAnimInstanceRole>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_Kuro_Anim_Instance_Role);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_Kuro_Anim_Instance_Role, value);
			}
		}

		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x06020A2C RID: 133676 RVA: 0x0094B951 File Offset: 0x00949B51
		// (set) Token: 0x06020A2D RID: 133677 RVA: 0x0094B961 File Offset: 0x00949B61
		public unsafe float MoveX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_MoveX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_MoveX) = value;
			}
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x06020A2E RID: 133678 RVA: 0x0094B972 File Offset: 0x00949B72
		// (set) Token: 0x06020A2F RID: 133679 RVA: 0x0094B982 File Offset: 0x00949B82
		public unsafe float MoveY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_MoveY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_MoveY) = value;
			}
		}

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x06020A30 RID: 133680 RVA: 0x0094B993 File Offset: 0x00949B93
		// (set) Token: 0x06020A31 RID: 133681 RVA: 0x0094B9A3 File Offset: 0x00949BA3
		public unsafe float BreathStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_BreathStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_BreathStrength) = value;
			}
		}

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x06020A32 RID: 133682 RVA: 0x0094B9B4 File Offset: 0x00949BB4
		// (set) Token: 0x06020A33 RID: 133683 RVA: 0x0094B9C4 File Offset: 0x00949BC4
		public unsafe float PerformStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_PerformStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_PerformStrength) = value;
			}
		}

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x06020A34 RID: 133684 RVA: 0x0094B9D5 File Offset: 0x00949BD5
		// (set) Token: 0x06020A35 RID: 133685 RVA: 0x0094B9E9 File Offset: 0x00949BE9
		public unsafe FVector SightDirectInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_SightDirectInSightBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_SightDirectInSightBone) = value;
			}
		}

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x06020A36 RID: 133686 RVA: 0x0094B9FE File Offset: 0x00949BFE
		// (set) Token: 0x06020A37 RID: 133687 RVA: 0x0094BA12 File Offset: 0x00949C12
		public unsafe FVector UpAxisInSightBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_UpAxisInSightBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Selfie_C.__PropertyOffset_UpAxisInSightBone) = value;
			}
		}

		// Token: 0x06020A38 RID: 133688 RVA: 0x0094BA28 File Offset: 0x00949C28
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A39 RID: 133689 RVA: 0x0094BA70 File Offset: 0x00949C70
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A3A RID: 133690 RVA: 0x0094BAB6 File Offset: 0x00949CB6
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020A3B RID: 133691 RVA: 0x0094BACA File Offset: 0x00949CCA
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Selfie_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020A3C RID: 133692 RVA: 0x0094BADE File Offset: 0x00949CDE
		protected ABP_BaseRole_Gameplay_Selfie_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A60 RID: 72288
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Selfie.ABP_BaseRole_Gameplay_Selfie_C";

		// Token: 0x04011A61 RID: 72289
		private static IntPtr _ClassPtr;

		// Token: 0x04011A62 RID: 72290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A63 RID: 72291
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011A64 RID: 72292
		internal static int __PropertyOffset_ArmPitchAngle;

		// Token: 0x04011A65 RID: 72293
		internal static int __PropertyOffset_ArmPitchLimitMin;

		// Token: 0x04011A66 RID: 72294
		internal static int __PropertyOffset_ArmPitchLimitMax;

		// Token: 0x04011A67 RID: 72295
		internal static int __PropertyOffset_DeltaTimeX;

		// Token: 0x04011A68 RID: 72296
		internal static int __PropertyOffset_Kuro_Anim_Instance_Role;

		// Token: 0x04011A69 RID: 72297
		internal static int __PropertyOffset_MoveX;

		// Token: 0x04011A6A RID: 72298
		internal static int __PropertyOffset_MoveY;

		// Token: 0x04011A6B RID: 72299
		internal static int __PropertyOffset_BreathStrength;

		// Token: 0x04011A6C RID: 72300
		internal static int __PropertyOffset_PerformStrength;

		// Token: 0x04011A6D RID: 72301
		internal static int __PropertyOffset_SightDirectInSightBone;

		// Token: 0x04011A6E RID: 72302
		internal static int __PropertyOffset_UpAxisInSightBone;

		// Token: 0x04011A6F RID: 72303
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011A70 RID: 72304
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x02008F9F RID: 36767
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD3F RID: 183615
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
