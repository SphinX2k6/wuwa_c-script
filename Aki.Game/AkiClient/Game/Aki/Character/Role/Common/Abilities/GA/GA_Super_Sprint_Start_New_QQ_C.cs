using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200417A RID: 16762
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_QQ.GA_Super_Sprint_Start_New_QQ_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class GA_Super_Sprint_Start_New_QQ_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B643 RID: 177731 RVA: 0x009FF374 File Offset: 0x009FD574
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Start_New_QQ_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_QQ.GA_Super_Sprint_Start_New_QQ_C");
			}
			return GA_Super_Sprint_Start_New_QQ_C._ClassPtr;
		}

		// Token: 0x0602B644 RID: 177732 RVA: 0x009FF398 File Offset: 0x009FD598
		public GA_Super_Sprint_Start_New_QQ_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_QQ_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B645 RID: 177733 RVA: 0x009FF3C0 File Offset: 0x009FD5C0
		[NullableContext(1)]
		public GA_Super_Sprint_Start_New_QQ_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Start_New_QQ_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B06 RID: 27398
		// (get) Token: 0x0602B646 RID: 177734 RVA: 0x009FF3F3 File Offset: 0x009FD5F3
		// (set) Token: 0x0602B647 RID: 177735 RVA: 0x009FF403 File Offset: 0x009FD603
		public unsafe bool 刷新当前子弹跑
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B07 RID: 27399
		// (get) Token: 0x0602B648 RID: 177736 RVA: 0x009FF414 File Offset: 0x009FD614
		// (set) Token: 0x0602B649 RID: 177737 RVA: 0x009FF424 File Offset: 0x009FD624
		public unsafe bool 需要中断特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B08 RID: 27400
		// (get) Token: 0x0602B64A RID: 177738 RVA: 0x009FF435 File Offset: 0x009FD635
		// (set) Token: 0x0602B64B RID: 177739 RVA: 0x009FF445 File Offset: 0x009FD645
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B09 RID: 27401
		// (get) Token: 0x0602B64C RID: 177740 RVA: 0x009FF456 File Offset: 0x009FD656
		// (set) Token: 0x0602B64D RID: 177741 RVA: 0x009FF466 File Offset: 0x009FD666
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B0A RID: 27402
		// (get) Token: 0x0602B64E RID: 177742 RVA: 0x009FF477 File Offset: 0x009FD677
		// (set) Token: 0x0602B64F RID: 177743 RVA: 0x009FF487 File Offset: 0x009FD687
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Start_New_QQ_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B650 RID: 177744 RVA: 0x009FF498 File Offset: 0x009FD698
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3C5F9A4E0(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A3C5F9A4E0_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A3C5F9A4E0_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A3C5F9A4E0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A3C5F9A4E0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A3C5F9A4E0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B651 RID: 177745 RVA: 0x009FF4E4 File Offset: 0x009FD6E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A350CE11F9(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A350CE11F9_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A350CE11F9_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A350CE11F9_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A350CE11F9_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A350CE11F9_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B652 RID: 177746 RVA: 0x009FF530 File Offset: 0x009FD730
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A339B4D4E7(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A339B4D4E7_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A339B4D4E7_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A339B4D4E7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A339B4D4E7_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__Added_21071CB943CD992BF8EFD6A339B4D4E7_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B653 RID: 177747 RVA: 0x009FF57C File Offset: 0x009FD77C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D38179C57504(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Start_New_QQ_C.__Removed_DB9F64004F8908FEAD99D38179C57504_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_QQ_C.__Removed_DB9F64004F8908FEAD99D38179C57504_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_QQ_C.__Removed_DB9F64004F8908FEAD99D38179C57504_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_QQ_C.__Removed_DB9F64004F8908FEAD99D38179C57504_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__Removed_DB9F64004F8908FEAD99D38179C57504_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B654 RID: 177748 RVA: 0x009FF5C7 File Offset: 0x009FD7C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_511E700845ECF2F3F9E523B6D6B2EE6C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__OnFinish_511E700845ECF2F3F9E523B6D6B2EE6C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B655 RID: 177749 RVA: 0x009FF5DB File Offset: 0x009FD7DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81BC0ADAC0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__OnTick_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B656 RID: 177750 RVA: 0x009FF5EF File Offset: 0x009FD7EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81BC0ADAC0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__OnCancelled_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B657 RID: 177751 RVA: 0x009FF603 File Offset: 0x009FD803
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81BC0ADAC0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__OnInterrupted_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B658 RID: 177752 RVA: 0x009FF617 File Offset: 0x009FD817
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81BC0ADAC0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__OnBlendOut_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B659 RID: 177753 RVA: 0x009FF62B File Offset: 0x009FD82B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81BC0ADAC0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__OnCompleted_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B65A RID: 177754 RVA: 0x009FF63F File Offset: 0x009FD83F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B65B RID: 177755 RVA: 0x009FF653 File Offset: 0x009FD853
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B65C RID: 177756 RVA: 0x009FF668 File Offset: 0x009FD868
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B65D RID: 177757 RVA: 0x009FF6B0 File Offset: 0x009FD8B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Start_New_QQ_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B65E RID: 177758 RVA: 0x009FF6F7 File Offset: 0x009FD8F7
		protected GA_Super_Sprint_Start_New_QQ_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016938 RID: 92472
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Start_New_QQ.GA_Super_Sprint_Start_New_QQ_C";

		// Token: 0x04016939 RID: 92473
		private static IntPtr _ClassPtr;

		// Token: 0x0401693A RID: 92474
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401693B RID: 92475
		internal new static int __PropertyOffset_1;

		// Token: 0x0401693C RID: 92476
		internal new static int __PropertyOffset_2;

		// Token: 0x0401693D RID: 92477
		internal new static int __PropertyOffset_3;

		// Token: 0x0401693E RID: 92478
		internal static int __PropertyOffset_4;

		// Token: 0x0401693F RID: 92479
		internal static int __PropertyOffset_5;

		// Token: 0x04016940 RID: 92480
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3C5F9A4E0_NativeFunctionPtr;

		// Token: 0x04016941 RID: 92481
		private static IntPtr __Added_21071CB943CD992BF8EFD6A350CE11F9_NativeFunctionPtr;

		// Token: 0x04016942 RID: 92482
		private static IntPtr __Added_21071CB943CD992BF8EFD6A339B4D4E7_NativeFunctionPtr;

		// Token: 0x04016943 RID: 92483
		private static IntPtr __Removed_DB9F64004F8908FEAD99D38179C57504_NativeFunctionPtr;

		// Token: 0x04016944 RID: 92484
		private static IntPtr __OnFinish_511E700845ECF2F3F9E523B6D6B2EE6C_NativeFunctionPtr;

		// Token: 0x04016945 RID: 92485
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr;

		// Token: 0x04016946 RID: 92486
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr;

		// Token: 0x04016947 RID: 92487
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr;

		// Token: 0x04016948 RID: 92488
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr;

		// Token: 0x04016949 RID: 92489
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81BC0ADAC0_NativeFunctionPtr;

		// Token: 0x0401694A RID: 92490
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401694B RID: 92491
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A510 RID: 42256
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3C5F9A4E0_FunctionParams
		{
			// Token: 0x0403237E RID: 205694
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A511 RID: 42257
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A350CE11F9_FunctionParams
		{
			// Token: 0x0403237F RID: 205695
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A512 RID: 42258
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A339B4D4E7_FunctionParams
		{
			// Token: 0x04032380 RID: 205696
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A513 RID: 42259
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D38179C57504_FunctionParams
		{
			// Token: 0x04032381 RID: 205697
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A514 RID: 42260
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032382 RID: 205698
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
