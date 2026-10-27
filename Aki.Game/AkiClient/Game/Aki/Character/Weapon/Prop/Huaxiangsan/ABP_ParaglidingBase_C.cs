using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Weapon.Prop.Huaxiangsan
{
	// Token: 0x02004029 RID: 16425
	[UnrealObjectPath("/Game/Aki/Character/Weapon/Prop/Huaxiangsan/ABP_ParaglidingBase.ABP_ParaglidingBase_C")]
	[UnrealStructLayout(3712, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3708)]
	public class ABP_ParaglidingBase_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A210 RID: 172560 RVA: 0x009D6CA5 File Offset: 0x009D4EA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_ParaglidingBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Weapon/Prop/Huaxiangsan/ABP_ParaglidingBase.ABP_ParaglidingBase_C");
			}
			return ABP_ParaglidingBase_C._ClassPtr;
		}

		// Token: 0x0602A211 RID: 172561 RVA: 0x009D6CCC File Offset: 0x009D4ECC
		public ABP_ParaglidingBase_C() : this(BuiltinUtils.AllocNativeUObject(ABP_ParaglidingBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A212 RID: 172562 RVA: 0x009D6CF4 File Offset: 0x009D4EF4
		[NullableContext(1)]
		public ABP_ParaglidingBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_ParaglidingBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066D1 RID: 26321
		// (get) Token: 0x0602A213 RID: 172563 RVA: 0x009D6D27 File Offset: 0x009D4F27
		// (set) Token: 0x0602A214 RID: 172564 RVA: 0x009D6D3B File Offset: 0x009D4F3B
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_ParaglidingBase_C.__PropertyOffset_14);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_ParaglidingBase_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170066D2 RID: 26322
		// (get) Token: 0x0602A215 RID: 172565 RVA: 0x009D6D50 File Offset: 0x009D4F50
		// (set) Token: 0x0602A216 RID: 172566 RVA: 0x009D6D60 File Offset: 0x009D4F60
		public unsafe bool 开伞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066D3 RID: 26323
		// (get) Token: 0x0602A217 RID: 172567 RVA: 0x009D6D71 File Offset: 0x009D4F71
		// (set) Token: 0x0602A218 RID: 172568 RVA: 0x009D6D85 File Offset: 0x009D4F85
		[Nullable(2)]
		public unsafe EffectModelGroup 消散特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectModelGroup>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_ParaglidingBase_C.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_ParaglidingBase_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170066D4 RID: 26324
		// (get) Token: 0x0602A219 RID: 172569 RVA: 0x009D6D9A File Offset: 0x009D4F9A
		// (set) Token: 0x0602A21A RID: 172570 RVA: 0x009D6DAA File Offset: 0x009D4FAA
		public unsafe bool 滑翔滞空
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066D5 RID: 26325
		// (get) Token: 0x0602A21B RID: 172571 RVA: 0x009D6DBB File Offset: 0x009D4FBB
		// (set) Token: 0x0602A21C RID: 172572 RVA: 0x009D6DCB File Offset: 0x009D4FCB
		public unsafe bool 滑翔上升
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066D6 RID: 26326
		// (get) Token: 0x0602A21D RID: 172573 RVA: 0x009D6DDC File Offset: 0x009D4FDC
		// (set) Token: 0x0602A21E RID: 172574 RVA: 0x009D6DEC File Offset: 0x009D4FEC
		public unsafe float 滑翔混合当前值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170066D7 RID: 26327
		// (get) Token: 0x0602A21F RID: 172575 RVA: 0x009D6DFD File Offset: 0x009D4FFD
		// (set) Token: 0x0602A220 RID: 172576 RVA: 0x009D6E0D File Offset: 0x009D500D
		public unsafe float 滑翔混合目标值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170066D8 RID: 26328
		// (get) Token: 0x0602A221 RID: 172577 RVA: 0x009D6E1E File Offset: 0x009D501E
		// (set) Token: 0x0602A222 RID: 172578 RVA: 0x009D6E2E File Offset: 0x009D502E
		public unsafe float 滑翔混合插值值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170066D9 RID: 26329
		// (get) Token: 0x0602A223 RID: 172579 RVA: 0x009D6E3F File Offset: 0x009D503F
		// (set) Token: 0x0602A224 RID: 172580 RVA: 0x009D6E53 File Offset: 0x009D5053
		public unsafe FVector 滑翔伞修正偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x0602A225 RID: 172581 RVA: 0x009D6E68 File Offset: 0x009D5068
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_ParaglidingBase_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A226 RID: 172582 RVA: 0x009D6EF0 File Offset: 0x009D50F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDash(bool Dash)
		{
			ABP_ParaglidingBase_C.__SetDash_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__SetDash_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__SetDash_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__SetDash_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Dash = Dash;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__SetDash_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A227 RID: 172583 RVA: 0x009D6F38 File Offset: 0x009D5138
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetHover(bool Hover)
		{
			ABP_ParaglidingBase_C.__SetHover_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__SetHover_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__SetHover_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__SetHover_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Hover = Hover;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__SetHover_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A228 RID: 172584 RVA: 0x009D6F80 File Offset: 0x009D5180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetOpenParagliding(bool bOpen)
		{
			ABP_ParaglidingBase_C.__SetOpenParagliding_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__SetOpenParagliding_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__SetOpenParagliding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__SetOpenParagliding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bOpen = bOpen;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__SetOpenParagliding_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A229 RID: 172585 RVA: 0x009D6FC8 File Offset: 0x009D51C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SyncAnim(ABP_ParaglidingBase_C Other)
		{
			ABP_ParaglidingBase_C.__SyncAnim_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__SyncAnim_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__SyncAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__SyncAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Other = ((Other != null) ? Other.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__SyncAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A22A RID: 172586 RVA: 0x009D701D File Offset: 0x009D521D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602A22B RID: 172587 RVA: 0x009D7031 File Offset: 0x009D5231
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_ParaglidingBase_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A22C RID: 172588 RVA: 0x009D7048 File Offset: 0x009D5248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A22D RID: 172589 RVA: 0x009D7090 File Offset: 0x009D5290
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A22E RID: 172590 RVA: 0x009D70D7 File Offset: 0x009D52D7
		protected ABP_ParaglidingBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B47 RID: 88903
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Weapon/Prop/Huaxiangsan/ABP_ParaglidingBase.ABP_ParaglidingBase_C";

		// Token: 0x04015B48 RID: 88904
		private static IntPtr _ClassPtr;

		// Token: 0x04015B49 RID: 88905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B4A RID: 88906
		internal static int __PropertyOffset_14;

		// Token: 0x04015B4B RID: 88907
		internal static int __PropertyOffset_15;

		// Token: 0x04015B4C RID: 88908
		internal static int __PropertyOffset_16;

		// Token: 0x04015B4D RID: 88909
		internal static int __PropertyOffset_17;

		// Token: 0x04015B4E RID: 88910
		internal static int __PropertyOffset_18;

		// Token: 0x04015B4F RID: 88911
		internal static int __PropertyOffset_19;

		// Token: 0x04015B50 RID: 88912
		internal static int __PropertyOffset_20;

		// Token: 0x04015B51 RID: 88913
		internal static int __PropertyOffset_21;

		// Token: 0x04015B52 RID: 88914
		internal static int __PropertyOffset_22;

		// Token: 0x04015B53 RID: 88915
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04015B54 RID: 88916
		private static IntPtr __SetDash_NativeFunctionPtr;

		// Token: 0x04015B55 RID: 88917
		private static IntPtr __SetHover_NativeFunctionPtr;

		// Token: 0x04015B56 RID: 88918
		private static IntPtr __SetOpenParagliding_NativeFunctionPtr;

		// Token: 0x04015B57 RID: 88919
		private static IntPtr __SyncAnim_NativeFunctionPtr;

		// Token: 0x04015B58 RID: 88920
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04015B59 RID: 88921
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0200A336 RID: 41782
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x040320F9 RID: 205049
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A337 RID: 41783
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetDash_FunctionParams
		{
			// Token: 0x040320FA RID: 205050
			[FieldOffset(0)]
			public bool Dash;
		}

		// Token: 0x0200A338 RID: 41784
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetHover_FunctionParams
		{
			// Token: 0x040320FB RID: 205051
			[FieldOffset(0)]
			public bool Hover;
		}

		// Token: 0x0200A339 RID: 41785
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetOpenParagliding_FunctionParams
		{
			// Token: 0x040320FC RID: 205052
			[FieldOffset(0)]
			public bool bOpen;
		}

		// Token: 0x0200A33A RID: 41786
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SyncAnim_FunctionParams
		{
			// Token: 0x040320FD RID: 205053
			[FieldOffset(0)]
			public IntPtr Other;
		}

		// Token: 0x0200A33B RID: 41787
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x040320FE RID: 205054
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
