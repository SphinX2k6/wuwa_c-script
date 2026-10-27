using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Common.Gameplay
{
	// Token: 0x020041A2 RID: 16802
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/Gameplay/ABP_BaseNPC_Gameplay_Ecology.ABP_BaseNPC_Gameplay_Ecology_C")]
	[UnrealStructLayout(6656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 6647)]
	public class ABP_BaseNPC_Gameplay_Ecology_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BB12 RID: 178962 RVA: 0x00A07AAC File Offset: 0x00A05CAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseNPC_Gameplay_Ecology_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Common/Gameplay/ABP_BaseNPC_Gameplay_Ecology.ABP_BaseNPC_Gameplay_Ecology_C");
			}
			return ABP_BaseNPC_Gameplay_Ecology_C._ClassPtr;
		}

		// Token: 0x0602BB13 RID: 178963 RVA: 0x00A07AD0 File Offset: 0x00A05CD0
		public ABP_BaseNPC_Gameplay_Ecology_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseNPC_Gameplay_Ecology_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BB14 RID: 178964 RVA: 0x00A07AF8 File Offset: 0x00A05CF8
		[NullableContext(1)]
		public ABP_BaseNPC_Gameplay_Ecology_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseNPC_Gameplay_Ecology_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C8A RID: 27786
		// (get) Token: 0x0602BB15 RID: 178965 RVA: 0x00A07B2B File Offset: 0x00A05D2B
		// (set) Token: 0x0602BB16 RID: 178966 RVA: 0x00A07B3F File Offset: 0x00A05D3F
		[Nullable(2)]
		public unsafe TsBaseCharacter As_Ts_Base_Character
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_29);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17006C8B RID: 27787
		// (get) Token: 0x0602BB17 RID: 178967 RVA: 0x00A07B54 File Offset: 0x00A05D54
		// (set) Token: 0x0602BB18 RID: 178968 RVA: 0x00A07B64 File Offset: 0x00A05D64
		public unsafe int Entity_Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17006C8C RID: 27788
		// (get) Token: 0x0602BB19 RID: 178969 RVA: 0x00A07B75 File Offset: 0x00A05D75
		// (set) Token: 0x0602BB1A RID: 178970 RVA: 0x00A07B85 File Offset: 0x00A05D85
		public unsafe bool 状态_花车
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C8D RID: 27789
		// (get) Token: 0x0602BB1B RID: 178971 RVA: 0x00A07B96 File Offset: 0x00A05D96
		// (set) Token: 0x0602BB1C RID: 178972 RVA: 0x00A07BA6 File Offset: 0x00A05DA6
		public unsafe bool 状态_花车舞蹈
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C8E RID: 27790
		// (get) Token: 0x0602BB1D RID: 178973 RVA: 0x00A07BB7 File Offset: 0x00A05DB7
		// (set) Token: 0x0602BB1E RID: 178974 RVA: 0x00A07BC7 File Offset: 0x00A05DC7
		public unsafe bool 状态_花车右位
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseNPC_Gameplay_Ecology_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602BB1F RID: 178975 RVA: 0x00A07BD8 File Offset: 0x00A05DD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseNPC_Gameplay_Ecology_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseNPC_Gameplay_Ecology_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseNPC_Gameplay_Ecology_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_Gameplay_Ecology_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_Gameplay_Ecology_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BB20 RID: 178976 RVA: 0x00A07C60 File Offset: 0x00A05E60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BB21 RID: 178977 RVA: 0x00A07CA8 File Offset: 0x00A05EA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BB22 RID: 178978 RVA: 0x00A07CEF File Offset: 0x00A05EEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BB23 RID: 178979 RVA: 0x00A07D03 File Offset: 0x00A05F03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseNPC_Gameplay_Ecology_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BB24 RID: 178980 RVA: 0x00A07D18 File Offset: 0x00A05F18
		protected ABP_BaseNPC_Gameplay_Ecology_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016C28 RID: 93224
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Common/Gameplay/ABP_BaseNPC_Gameplay_Ecology.ABP_BaseNPC_Gameplay_Ecology_C";

		// Token: 0x04016C29 RID: 93225
		private static IntPtr _ClassPtr;

		// Token: 0x04016C2A RID: 93226
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016C2B RID: 93227
		internal static int __PropertyOffset_29;

		// Token: 0x04016C2C RID: 93228
		internal static int __PropertyOffset_30;

		// Token: 0x04016C2D RID: 93229
		internal static int __PropertyOffset_31;

		// Token: 0x04016C2E RID: 93230
		internal static int __PropertyOffset_32;

		// Token: 0x04016C2F RID: 93231
		internal static int __PropertyOffset_33;

		// Token: 0x04016C30 RID: 93232
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016C31 RID: 93233
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04016C32 RID: 93234
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0200A581 RID: 42369
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032409 RID: 205833
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A582 RID: 42370
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0403240A RID: 205834
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
