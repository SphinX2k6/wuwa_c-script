using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B1B RID: 15131
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowDecal.BP_ShadowDecal_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1212)]
	public class BP_ShadowDecal_C : AKuroDecalActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060211CE RID: 135630 RVA: 0x008E528C File Offset: 0x008E348C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ShadowDecal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowDecal.BP_ShadowDecal_C");
			}
			return BP_ShadowDecal_C._ClassPtr;
		}

		// Token: 0x060211CF RID: 135631 RVA: 0x008E52B0 File Offset: 0x008E34B0
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_ShadowDecal_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x060211D0 RID: 135632 RVA: 0x008E52B8 File Offset: 0x008E34B8
		public BP_ShadowDecal_C() : this(BuiltinUtils.AllocNativeUObject(BP_ShadowDecal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211D1 RID: 135633 RVA: 0x008E52E0 File Offset: 0x008E34E0
		[NullableContext(1)]
		public BP_ShadowDecal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ShadowDecal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x060211D2 RID: 135634 RVA: 0x008E5313 File Offset: 0x008E3513
		// (set) Token: 0x060211D3 RID: 135635 RVA: 0x008E5327 File Offset: 0x008E3527
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x060211D4 RID: 135636 RVA: 0x008E533C File Offset: 0x008E353C
		// (set) Token: 0x060211D5 RID: 135637 RVA: 0x008E5350 File Offset: 0x008E3550
		public unsafe UMaterialInstanceDynamic DYMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x060211D6 RID: 135638 RVA: 0x008E5365 File Offset: 0x008E3565
		// (set) Token: 0x060211D7 RID: 135639 RVA: 0x008E5379 File Offset: 0x008E3579
		public unsafe UTexture2D ShadowTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x060211D8 RID: 135640 RVA: 0x008E538E File Offset: 0x008E358E
		// (set) Token: 0x060211D9 RID: 135641 RVA: 0x008E539E File Offset: 0x008E359E
		public unsafe float ShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x060211DA RID: 135642 RVA: 0x008E53AF File Offset: 0x008E35AF
		// (set) Token: 0x060211DB RID: 135643 RVA: 0x008E53BF File Offset: 0x008E35BF
		public unsafe float InvShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x060211DC RID: 135644 RVA: 0x008E53D0 File Offset: 0x008E35D0
		// (set) Token: 0x060211DD RID: 135645 RVA: 0x008E53E4 File Offset: 0x008E35E4
		public unsafe UTexture2D EvolutionaryTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShadowDecal_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x060211DE RID: 135646 RVA: 0x008E53F9 File Offset: 0x008E35F9
		// (set) Token: 0x060211DF RID: 135647 RVA: 0x008E5409 File Offset: 0x008E3609
		public unsafe float EvolutionaryIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x060211E0 RID: 135648 RVA: 0x008E541A File Offset: 0x008E361A
		// (set) Token: 0x060211E1 RID: 135649 RVA: 0x008E542A File Offset: 0x008E362A
		public unsafe float EvolutionaryRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x060211E2 RID: 135650 RVA: 0x008E543B File Offset: 0x008E363B
		// (set) Token: 0x060211E3 RID: 135651 RVA: 0x008E544B File Offset: 0x008E364B
		public unsafe float EvolutionaryDirectional_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x060211E4 RID: 135652 RVA: 0x008E545C File Offset: 0x008E365C
		// (set) Token: 0x060211E5 RID: 135653 RVA: 0x008E546C File Offset: 0x008E366C
		public unsafe float EvolutionaryDirectional_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x060211E6 RID: 135654 RVA: 0x008E547D File Offset: 0x008E367D
		// (set) Token: 0x060211E7 RID: 135655 RVA: 0x008E548D File Offset: 0x008E368D
		public unsafe float MobileShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x060211E8 RID: 135656 RVA: 0x008E549E File Offset: 0x008E369E
		// (set) Token: 0x060211E9 RID: 135657 RVA: 0x008E54AE File Offset: 0x008E36AE
		public unsafe int DALayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x060211EA RID: 135658 RVA: 0x008E54BF File Offset: 0x008E36BF
		// (set) Token: 0x060211EB RID: 135659 RVA: 0x008E54D3 File Offset: 0x008E36D3
		public unsafe FName MPC_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x060211EC RID: 135660 RVA: 0x008E54E8 File Offset: 0x008E36E8
		// (set) Token: 0x060211ED RID: 135661 RVA: 0x008E54F8 File Offset: 0x008E36F8
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x060211EE RID: 135662 RVA: 0x008E5509 File Offset: 0x008E3709
		// (set) Token: 0x060211EF RID: 135663 RVA: 0x008E5519 File Offset: 0x008E3719
		public unsafe float RestoreVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x060211F0 RID: 135664 RVA: 0x008E552A File Offset: 0x008E372A
		// (set) Token: 0x060211F1 RID: 135665 RVA: 0x008E553A File Offset: 0x008E373A
		public unsafe float DeltaTimeTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x060211F2 RID: 135666 RVA: 0x008E554B File Offset: 0x008E374B
		// (set) Token: 0x060211F3 RID: 135667 RVA: 0x008E555B File Offset: 0x008E375B
		public unsafe float WindIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x060211F4 RID: 135668 RVA: 0x008E556C File Offset: 0x008E376C
		// (set) Token: 0x060211F5 RID: 135669 RVA: 0x008E557C File Offset: 0x008E377C
		public unsafe float WindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x060211F6 RID: 135670 RVA: 0x008E558D File Offset: 0x008E378D
		// (set) Token: 0x060211F7 RID: 135671 RVA: 0x008E559D File Offset: 0x008E379D
		public unsafe float WindDir_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x060211F8 RID: 135672 RVA: 0x008E55AE File Offset: 0x008E37AE
		// (set) Token: 0x060211F9 RID: 135673 RVA: 0x008E55BE File Offset: 0x008E37BE
		public unsafe float WindDir_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x060211FA RID: 135674 RVA: 0x008E55CF File Offset: 0x008E37CF
		// (set) Token: 0x060211FB RID: 135675 RVA: 0x008E55DF File Offset: 0x008E37DF
		public unsafe float StrenghtAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x060211FC RID: 135676 RVA: 0x008E55F0 File Offset: 0x008E37F0
		// (set) Token: 0x060211FD RID: 135677 RVA: 0x008E5600 File Offset: 0x008E3800
		public unsafe float WindRandomSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x060211FE RID: 135678 RVA: 0x008E5611 File Offset: 0x008E3811
		// (set) Token: 0x060211FF RID: 135679 RVA: 0x008E5621 File Offset: 0x008E3821
		public unsafe float WindRandomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShadowDecal_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x06021200 RID: 135680 RVA: 0x008E5634 File Offset: 0x008E3834
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_ShadowDecal_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_ShadowDecal_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowDecal_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowDecal_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowDecal_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021201 RID: 135681 RVA: 0x008E567C File Offset: 0x008E387C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_ShadowDecal_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_ShadowDecal_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowDecal_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowDecal_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowDecal_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021202 RID: 135682 RVA: 0x008E56C2 File Offset: 0x008E38C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FromDa()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowDecal_C.__FromDa_NativeFunctionPtr, null);
		}

		// Token: 0x06021203 RID: 135683 RVA: 0x008E56D6 File Offset: 0x008E38D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowDecal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021204 RID: 135684 RVA: 0x008E56EA File Offset: 0x008E38EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowDecal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021205 RID: 135685 RVA: 0x008E5700 File Offset: 0x008E3900
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ShadowDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShadowDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShadowDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021206 RID: 135686 RVA: 0x008E5748 File Offset: 0x008E3948
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ShadowDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShadowDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShadowDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShadowDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShadowDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021207 RID: 135687 RVA: 0x008E578F File Offset: 0x008E398F
		protected BP_ShadowDecal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101CC RID: 65996
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x040101CD RID: 65997
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ShadowDecal.BP_ShadowDecal_C";

		// Token: 0x040101CE RID: 65998
		private static IntPtr _ClassPtr;

		// Token: 0x040101CF RID: 65999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101D0 RID: 66000
		internal static int __PropertyOffset_1;

		// Token: 0x040101D1 RID: 66001
		internal static int __PropertyOffset_2;

		// Token: 0x040101D2 RID: 66002
		internal static int __PropertyOffset_3;

		// Token: 0x040101D3 RID: 66003
		internal static int __PropertyOffset_4;

		// Token: 0x040101D4 RID: 66004
		internal static int __PropertyOffset_5;

		// Token: 0x040101D5 RID: 66005
		internal static int __PropertyOffset_6;

		// Token: 0x040101D6 RID: 66006
		internal static int __PropertyOffset_7;

		// Token: 0x040101D7 RID: 66007
		internal static int __PropertyOffset_8;

		// Token: 0x040101D8 RID: 66008
		internal static int __PropertyOffset_9;

		// Token: 0x040101D9 RID: 66009
		internal static int __PropertyOffset_10;

		// Token: 0x040101DA RID: 66010
		internal static int __PropertyOffset_11;

		// Token: 0x040101DB RID: 66011
		internal static int __PropertyOffset_12;

		// Token: 0x040101DC RID: 66012
		internal static int __PropertyOffset_13;

		// Token: 0x040101DD RID: 66013
		internal static int __PropertyOffset_14;

		// Token: 0x040101DE RID: 66014
		internal static int __PropertyOffset_15;

		// Token: 0x040101DF RID: 66015
		internal static int __PropertyOffset_16;

		// Token: 0x040101E0 RID: 66016
		internal static int __PropertyOffset_17;

		// Token: 0x040101E1 RID: 66017
		internal static int __PropertyOffset_18;

		// Token: 0x040101E2 RID: 66018
		internal static int __PropertyOffset_19;

		// Token: 0x040101E3 RID: 66019
		internal static int __PropertyOffset_20;

		// Token: 0x040101E4 RID: 66020
		internal static int __PropertyOffset_21;

		// Token: 0x040101E5 RID: 66021
		internal static int __PropertyOffset_22;

		// Token: 0x040101E6 RID: 66022
		internal static int __PropertyOffset_23;

		// Token: 0x040101E7 RID: 66023
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x040101E8 RID: 66024
		private static IntPtr __FromDa_NativeFunctionPtr;

		// Token: 0x040101E9 RID: 66025
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040101EA RID: 66026
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C70 RID: 40048
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x0403132E RID: 201518
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C71 RID: 40049
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403132F RID: 201519
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
