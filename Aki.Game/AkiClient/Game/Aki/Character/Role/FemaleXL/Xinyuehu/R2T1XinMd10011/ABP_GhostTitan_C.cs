using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.FemaleXL.Xinyuehu.R2T1XinMd10011
{
	// Token: 0x02003294 RID: 12948
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleXL/Xinyuehu/R2T1XinMd10011/ABP_GhostTitan.ABP_GhostTitan_C")]
	[UnrealStructLayout(9296, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 9281)]
	public class ABP_GhostTitan_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020709 RID: 132873 RVA: 0x00946A3C File Offset: 0x00944C3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_GhostTitan_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleXL/Xinyuehu/R2T1XinMd10011/ABP_GhostTitan.ABP_GhostTitan_C");
			}
			return ABP_GhostTitan_C._ClassPtr;
		}

		// Token: 0x0602070A RID: 132874 RVA: 0x00946A60 File Offset: 0x00944C60
		public ABP_GhostTitan_C() : this(BuiltinUtils.AllocNativeUObject(ABP_GhostTitan_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602070B RID: 132875 RVA: 0x00946A88 File Offset: 0x00944C88
		[NullableContext(1)]
		public ABP_GhostTitan_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_GhostTitan_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x0602070C RID: 132876 RVA: 0x00946ABB File Offset: 0x00944CBB
		// (set) Token: 0x0602070D RID: 132877 RVA: 0x00946ACF File Offset: 0x00944CCF
		public unsafe FName CurrentIdleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_CurrentIdleType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_CurrentIdleType) = value;
			}
		}

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x0602070E RID: 132878 RVA: 0x00946AE4 File Offset: 0x00944CE4
		// (set) Token: 0x0602070F RID: 132879 RVA: 0x00946AF4 File Offset: 0x00944CF4
		public unsafe bool RestVariantIsA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_RestVariantIsA) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_RestVariantIsA) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x06020710 RID: 132880 RVA: 0x00946B05 File Offset: 0x00944D05
		// (set) Token: 0x06020711 RID: 132881 RVA: 0x00946B19 File Offset: 0x00944D19
		public unsafe FVector SightTargetDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_SightTargetDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_SightTargetDirect) = value;
			}
		}

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x06020712 RID: 132882 RVA: 0x00946B2E File Offset: 0x00944D2E
		// (set) Token: 0x06020713 RID: 132883 RVA: 0x00946B3E File Offset: 0x00944D3E
		public unsafe float SightAlphaCurrent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_SightAlphaCurrent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_SightAlphaCurrent) = value;
			}
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x06020714 RID: 132884 RVA: 0x00946B4F File Offset: 0x00944D4F
		// (set) Token: 0x06020715 RID: 132885 RVA: 0x00946B5F File Offset: 0x00944D5F
		public unsafe bool IsPlayingSpecial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_IsPlayingSpecial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_GhostTitan_C.__PropertyOffset_IsPlayingSpecial) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020716 RID: 132886 RVA: 0x00946B70 File Offset: 0x00944D70
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_GhostTitan_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_GhostTitan_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020717 RID: 132887 RVA: 0x00946BB8 File Offset: 0x00944DB8
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_GhostTitan_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_GhostTitan_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_GhostTitan_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020718 RID: 132888 RVA: 0x00946BFE File Offset: 0x00944DFE
		protected ABP_GhostTitan_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401186B RID: 71787
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleXL/Xinyuehu/R2T1XinMd10011/ABP_GhostTitan.ABP_GhostTitan_C";

		// Token: 0x0401186C RID: 71788
		private static IntPtr _ClassPtr;

		// Token: 0x0401186D RID: 71789
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401186E RID: 71790
		internal static int __PropertyOffset_CurrentIdleType;

		// Token: 0x0401186F RID: 71791
		internal static int __PropertyOffset_RestVariantIsA;

		// Token: 0x04011870 RID: 71792
		internal static int __PropertyOffset_SightTargetDirect;

		// Token: 0x04011871 RID: 71793
		internal static int __PropertyOffset_SightAlphaCurrent;

		// Token: 0x04011872 RID: 71794
		internal static int __PropertyOffset_IsPlayingSpecial;

		// Token: 0x04011873 RID: 71795
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x02008F6A RID: 36714
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CCEA RID: 183530
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
