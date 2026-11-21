using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Weapon.Prop.Huaxiangsan
{
	// Token: 0x02003285 RID: 12933
	[UnrealObjectPath("/Game/Aki/Character/Weapon/Prop/Huaxiangsan/ABP_ParaglidingBase.ABP_ParaglidingBase_C")]
	[UnrealStructLayout(3728, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3724)]
	public class ABP_ParaglidingBase_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020582 RID: 132482 RVA: 0x00943D7B File Offset: 0x00941F7B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_ParaglidingBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Weapon/Prop/Huaxiangsan/ABP_ParaglidingBase.ABP_ParaglidingBase_C");
			}
			return ABP_ParaglidingBase_C._ClassPtr;
		}

		// Token: 0x06020583 RID: 132483 RVA: 0x00943DA0 File Offset: 0x00941FA0
		public ABP_ParaglidingBase_C() : this(BuiltinUtils.AllocNativeUObject(ABP_ParaglidingBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020584 RID: 132484 RVA: 0x00943DC8 File Offset: 0x00941FC8
		[NullableContext(1)]
		public ABP_ParaglidingBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_ParaglidingBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x06020585 RID: 132485 RVA: 0x00943DFB File Offset: 0x00941FFB
		// (set) Token: 0x06020586 RID: 132486 RVA: 0x00943E0F File Offset: 0x0094200F
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_ParaglidingBase_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_ParaglidingBase_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x06020587 RID: 132487 RVA: 0x00943E24 File Offset: 0x00942024
		// (set) Token: 0x06020588 RID: 132488 RVA: 0x00943E34 File Offset: 0x00942034
		public unsafe bool 开伞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_开伞) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_开伞) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x06020589 RID: 132489 RVA: 0x00943E45 File Offset: 0x00942045
		// (set) Token: 0x0602058A RID: 132490 RVA: 0x00943E59 File Offset: 0x00942059
		[Nullable(2)]
		public unsafe EffectModelGroup 消散特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectModelGroup>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_ParaglidingBase_C.__PropertyOffset_消散特效);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_ParaglidingBase_C.__PropertyOffset_消散特效, value);
			}
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x0602058B RID: 132491 RVA: 0x00943E6E File Offset: 0x0094206E
		// (set) Token: 0x0602058C RID: 132492 RVA: 0x00943E7E File Offset: 0x0094207E
		public unsafe bool 滑翔滞空
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔滞空) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔滞空) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x0602058D RID: 132493 RVA: 0x00943E8F File Offset: 0x0094208F
		// (set) Token: 0x0602058E RID: 132494 RVA: 0x00943E9F File Offset: 0x0094209F
		public unsafe bool 滑翔上升
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔上升) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔上升) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x0602058F RID: 132495 RVA: 0x00943EB0 File Offset: 0x009420B0
		// (set) Token: 0x06020590 RID: 132496 RVA: 0x00943EC0 File Offset: 0x009420C0
		public unsafe float 滑翔混合当前值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔混合当前值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔混合当前值) = value;
			}
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x06020591 RID: 132497 RVA: 0x00943ED1 File Offset: 0x009420D1
		// (set) Token: 0x06020592 RID: 132498 RVA: 0x00943EE1 File Offset: 0x009420E1
		public unsafe float 滑翔混合目标值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔混合目标值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔混合目标值) = value;
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x06020593 RID: 132499 RVA: 0x00943EF2 File Offset: 0x009420F2
		// (set) Token: 0x06020594 RID: 132500 RVA: 0x00943F02 File Offset: 0x00942102
		public unsafe float 滑翔混合插值值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔混合插值值速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔混合插值值速度) = value;
			}
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x06020595 RID: 132501 RVA: 0x00943F13 File Offset: 0x00942113
		// (set) Token: 0x06020596 RID: 132502 RVA: 0x00943F27 File Offset: 0x00942127
		public unsafe FVector 滑翔伞修正偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔伞修正偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_ParaglidingBase_C.__PropertyOffset_滑翔伞修正偏移) = value;
			}
		}

		// Token: 0x06020597 RID: 132503 RVA: 0x00943F3C File Offset: 0x0094213C
		[SkipLocalsInit]
		public unsafe virtual void SetDash(bool Dash)
		{
			ABP_ParaglidingBase_C.__SetDash_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__SetDash_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__SetDash_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__SetDash_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Dash = Dash;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__SetDash_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020598 RID: 132504 RVA: 0x00943F84 File Offset: 0x00942184
		[SkipLocalsInit]
		public unsafe virtual void SetHover(bool Hover)
		{
			ABP_ParaglidingBase_C.__SetHover_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__SetHover_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__SetHover_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__SetHover_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Hover = Hover;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__SetHover_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020599 RID: 132505 RVA: 0x00943FCC File Offset: 0x009421CC
		[SkipLocalsInit]
		public unsafe virtual void SetOpenParagliding(bool bOpen)
		{
			ABP_ParaglidingBase_C.__SetOpenParagliding_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__SetOpenParagliding_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__SetOpenParagliding_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__SetOpenParagliding_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bOpen = bOpen;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__SetOpenParagliding_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602059A RID: 132506 RVA: 0x00944014 File Offset: 0x00942214
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void SyncAnim(ABP_ParaglidingBase_C Other)
		{
			ABP_ParaglidingBase_C.__SyncAnim_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__SyncAnim_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__SyncAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__SyncAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Other = ((Other != null) ? Other.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__SyncAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602059B RID: 132507 RVA: 0x00944069 File Offset: 0x00942269
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602059C RID: 132508 RVA: 0x0094407D File Offset: 0x0094227D
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_ParaglidingBase_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602059D RID: 132509 RVA: 0x00944094 File Offset: 0x00942294
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602059E RID: 132510 RVA: 0x009440DC File Offset: 0x009422DC
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_ParaglidingBase_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602059F RID: 132511 RVA: 0x00944122 File Offset: 0x00942322
		protected ABP_ParaglidingBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011769 RID: 71529
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Weapon/Prop/Huaxiangsan/ABP_ParaglidingBase.ABP_ParaglidingBase_C";

		// Token: 0x0401176A RID: 71530
		private static IntPtr _ClassPtr;

		// Token: 0x0401176B RID: 71531
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401176C RID: 71532
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x0401176D RID: 71533
		internal static int __PropertyOffset_开伞;

		// Token: 0x0401176E RID: 71534
		internal static int __PropertyOffset_消散特效;

		// Token: 0x0401176F RID: 71535
		internal static int __PropertyOffset_滑翔滞空;

		// Token: 0x04011770 RID: 71536
		internal static int __PropertyOffset_滑翔上升;

		// Token: 0x04011771 RID: 71537
		internal static int __PropertyOffset_滑翔混合当前值;

		// Token: 0x04011772 RID: 71538
		internal static int __PropertyOffset_滑翔混合目标值;

		// Token: 0x04011773 RID: 71539
		internal static int __PropertyOffset_滑翔混合插值值速度;

		// Token: 0x04011774 RID: 71540
		internal static int __PropertyOffset_滑翔伞修正偏移;

		// Token: 0x04011775 RID: 71541
		private static IntPtr __SetDash_NativeFunctionPtr;

		// Token: 0x04011776 RID: 71542
		private static IntPtr __SetHover_NativeFunctionPtr;

		// Token: 0x04011777 RID: 71543
		private static IntPtr __SetOpenParagliding_NativeFunctionPtr;

		// Token: 0x04011778 RID: 71544
		private static IntPtr __SyncAnim_NativeFunctionPtr;

		// Token: 0x04011779 RID: 71545
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x0401177A RID: 71546
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x02008F4F RID: 36687
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetDash_FunctionParams
		{
			// Token: 0x0402CCC3 RID: 183491
			[FieldOffset(0)]
			public bool Dash;
		}

		// Token: 0x02008F50 RID: 36688
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetHover_FunctionParams
		{
			// Token: 0x0402CCC4 RID: 183492
			[FieldOffset(0)]
			public bool Hover;
		}

		// Token: 0x02008F51 RID: 36689
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetOpenParagliding_FunctionParams
		{
			// Token: 0x0402CCC5 RID: 183493
			[FieldOffset(0)]
			public bool bOpen;
		}

		// Token: 0x02008F52 RID: 36690
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SyncAnim_FunctionParams
		{
			// Token: 0x0402CCC6 RID: 183494
			[FieldOffset(0)]
			public IntPtr Other;
		}

		// Token: 0x02008F53 RID: 36691
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CCC7 RID: 183495
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
