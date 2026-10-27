using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x02003C3F RID: 15423
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_BridgeModels_BrokenMobile_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IBPI_BridgeModels_BrokenMobile_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06023901 RID: 145665 RVA: 0x00926D87 File Offset: 0x00924F87
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BridgeModels_BrokenMobile_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C");
			}
			return BP_BridgeModels_BrokenMobile_C._ClassPtr;
		}

		// Token: 0x06023902 RID: 145666 RVA: 0x00926DAC File Offset: 0x00924FAC
		public BP_BridgeModels_BrokenMobile_C() : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_BrokenMobile_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023903 RID: 145667 RVA: 0x00926DD4 File Offset: 0x00924FD4
		[NullableContext(1)]
		public BP_BridgeModels_BrokenMobile_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_BrokenMobile_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x06023904 RID: 145668 RVA: 0x00926E07 File Offset: 0x00925007
		// (set) Token: 0x06023905 RID: 145669 RVA: 0x00926E1B File Offset: 0x0092501B
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x06023906 RID: 145670 RVA: 0x00926E30 File Offset: 0x00925030
		// (set) Token: 0x06023907 RID: 145671 RVA: 0x00926E44 File Offset: 0x00925044
		public unsafe UStaticMeshComponent SM_Gel_Pro_305AM_FX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x06023908 RID: 145672 RVA: 0x00926E59 File Offset: 0x00925059
		// (set) Token: 0x06023909 RID: 145673 RVA: 0x00926E6D File Offset: 0x0092506D
		public unsafe UStaticMeshComponent SM_Gel_Pro_304AM_FX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x0602390A RID: 145674 RVA: 0x00926E82 File Offset: 0x00925082
		// (set) Token: 0x0602390B RID: 145675 RVA: 0x00926E96 File Offset: 0x00925096
		public unsafe UStaticMeshComponent SM_MB_Gel_Bri_04TL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x0602390C RID: 145676 RVA: 0x00926EAB File Offset: 0x009250AB
		// (set) Token: 0x0602390D RID: 145677 RVA: 0x00926EBF File Offset: 0x009250BF
		public unsafe UStaticMeshComponent SM_Gel_Bri_04IL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x0602390E RID: 145678 RVA: 0x00926ED4 File Offset: 0x009250D4
		// (set) Token: 0x0602390F RID: 145679 RVA: 0x00926EE8 File Offset: 0x009250E8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x06023910 RID: 145680 RVA: 0x00926F00 File Offset: 0x00925100
		// (set) Token: 0x06023911 RID: 145681 RVA: 0x00926F39 File Offset: 0x00925139
		[Nullable(1)]
		public custom custom
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				custom result;
				if ((result = this._custom) == null)
				{
					result = (this._custom = new custom(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_7, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x06023912 RID: 145682 RVA: 0x00926F5A File Offset: 0x0092515A
		// (set) Token: 0x06023913 RID: 145683 RVA: 0x00926F6E File Offset: 0x0092516E
		public unsafe FVector NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x06023914 RID: 145684 RVA: 0x00926F83 File Offset: 0x00925183
		// (set) Token: 0x06023915 RID: 145685 RVA: 0x00926F93 File Offset: 0x00925193
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x06023916 RID: 145686 RVA: 0x00926FA4 File Offset: 0x009251A4
		// (set) Token: 0x06023917 RID: 145687 RVA: 0x00926FB4 File Offset: 0x009251B4
		public unsafe bool IsBroken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x06023918 RID: 145688 RVA: 0x00926FC5 File Offset: 0x009251C5
		// (set) Token: 0x06023919 RID: 145689 RVA: 0x00926FD5 File Offset: 0x009251D5
		public unsafe float InterpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x0602391A RID: 145690 RVA: 0x00926FE6 File Offset: 0x009251E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BreakTest()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__BreakTest_NativeFunctionPtr, null);
		}

		// Token: 0x0602391B RID: 145691 RVA: 0x00926FFA File Offset: 0x009251FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0602391C RID: 145692 RVA: 0x00927010 File Offset: 0x00925210
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetBridgeLink(int idx, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UChildActorComponent> tempArray1)
		{
			BP_BridgeModels_BrokenMobile_C.__GetBridgeLink_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__GetBridgeLink_FunctionParams[(UIntPtr)575] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__GetBridgeLink_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr, 1);
			ptr->idx = idx;
			TArray<UChildActorComponent> tarray = tempArray1;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->tempArray1);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr);
			TArray<UChildActorComponent> tarray2 = tempArray1;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->tempArray1);
			}
			UnrealReflectionUtils.DestroyStruct(BP_BridgeModels_BrokenMobile_C.__GetBridgeLink_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602391D RID: 145693 RVA: 0x00927092 File Offset: 0x00925292
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602391E RID: 145694 RVA: 0x009270A6 File Offset: 0x009252A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602391F RID: 145695 RVA: 0x009270BC File Offset: 0x009252BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5(int PlayingID)
		{
			BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023920 RID: 145696 RVA: 0x00927102 File Offset: 0x00925302
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023921 RID: 145697 RVA: 0x00927116 File Offset: 0x00925316
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023922 RID: 145698 RVA: 0x0092712C File Offset: 0x0092532C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023923 RID: 145699 RVA: 0x00927174 File Offset: 0x00925374
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023924 RID: 145700 RVA: 0x009271BB File Offset: 0x009253BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BreakEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__BreakEvent_NativeFunctionPtr, null);
		}

		// Token: 0x06023925 RID: 145701 RVA: 0x009271CF File Offset: 0x009253CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BreakTrigger()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__BreakTrigger_NativeFunctionPtr, null);
		}

		// Token: 0x06023926 RID: 145702 RVA: 0x009271E4 File Offset: 0x009253E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023927 RID: 145703 RVA: 0x009272A0 File Offset: 0x009254A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023928 RID: 145704 RVA: 0x00927329 File Offset: 0x00925529
		protected BP_BridgeModels_BrokenMobile_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040118F1 RID: 71921
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C";

		// Token: 0x040118F2 RID: 71922
		private static IntPtr _ClassPtr;

		// Token: 0x040118F3 RID: 71923
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040118F4 RID: 71924
		public static IntPtr __custom__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040118F5 RID: 71925
		internal static int __PropertyOffset_1;

		// Token: 0x040118F6 RID: 71926
		internal static int __PropertyOffset_2;

		// Token: 0x040118F7 RID: 71927
		internal static int __PropertyOffset_3;

		// Token: 0x040118F8 RID: 71928
		internal static int __PropertyOffset_4;

		// Token: 0x040118F9 RID: 71929
		internal static int __PropertyOffset_5;

		// Token: 0x040118FA RID: 71930
		internal static int __PropertyOffset_6;

		// Token: 0x040118FB RID: 71931
		internal static int __PropertyOffset_7;

		// Token: 0x040118FC RID: 71932
		private custom _custom;

		// Token: 0x040118FD RID: 71933
		internal static int __PropertyOffset_8;

		// Token: 0x040118FE RID: 71934
		internal static int __PropertyOffset_9;

		// Token: 0x040118FF RID: 71935
		internal static int __PropertyOffset_10;

		// Token: 0x04011900 RID: 71936
		internal static int __PropertyOffset_11;

		// Token: 0x04011901 RID: 71937
		private static IntPtr __BreakTest_NativeFunctionPtr;

		// Token: 0x04011902 RID: 71938
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04011903 RID: 71939
		private static IntPtr __GetBridgeLink_NativeFunctionPtr;

		// Token: 0x04011904 RID: 71940
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011905 RID: 71941
		private static IntPtr __Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_NativeFunctionPtr;

		// Token: 0x04011906 RID: 71942
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011907 RID: 71943
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011908 RID: 71944
		private static IntPtr __BreakEvent_NativeFunctionPtr;

		// Token: 0x04011909 RID: 71945
		private static IntPtr __BreakTrigger_NativeFunctionPtr;

		// Token: 0x0401190A RID: 71946
		private static IntPtr __BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401190B RID: 71947
		private static IntPtr __BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E77 RID: 40567
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 560)]
		protected ref struct __GetBridgeLink_FunctionParams
		{
			// Token: 0x0403170C RID: 202508
			[FieldOffset(0)]
			public int idx;

			// Token: 0x0403170D RID: 202509
			[FieldOffset(8)]
			public byte tempArray1;
		}

		// Token: 0x02009E78 RID: 40568
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_FunctionParams
		{
			// Token: 0x0403170E RID: 202510
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009E79 RID: 40569
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403170F RID: 202511
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E7A RID: 40570
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031710 RID: 202512
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031711 RID: 202513
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031712 RID: 202514
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031713 RID: 202515
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031714 RID: 202516
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031715 RID: 202517
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E7B RID: 40571
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031716 RID: 202518
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031717 RID: 202519
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031718 RID: 202520
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031719 RID: 202521
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
