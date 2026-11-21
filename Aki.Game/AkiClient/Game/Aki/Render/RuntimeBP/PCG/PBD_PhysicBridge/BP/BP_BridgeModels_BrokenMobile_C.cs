using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x020030E2 RID: 12514
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_BridgeModels_BrokenMobile_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IBPI_BridgeModels_BrokenMobile_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E3E1 RID: 123873 RVA: 0x0090EEDD File Offset: 0x0090D0DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BridgeModels_BrokenMobile_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C");
			}
			return BP_BridgeModels_BrokenMobile_C._ClassPtr;
		}

		// Token: 0x0601E3E2 RID: 123874 RVA: 0x0090EF04 File Offset: 0x0090D104
		public BP_BridgeModels_BrokenMobile_C() : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_BrokenMobile_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E3E3 RID: 123875 RVA: 0x0090EF2C File Offset: 0x0090D12C
		[NullableContext(1)]
		public BP_BridgeModels_BrokenMobile_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BridgeModels_BrokenMobile_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0601E3E4 RID: 123876 RVA: 0x0090EF5F File Offset: 0x0090D15F
		// (set) Token: 0x0601E3E5 RID: 123877 RVA: 0x0090EF73 File Offset: 0x0090D173
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_Box);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_Box, value);
			}
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0601E3E6 RID: 123878 RVA: 0x0090EF88 File Offset: 0x0090D188
		// (set) Token: 0x0601E3E7 RID: 123879 RVA: 0x0090EF9C File Offset: 0x0090D19C
		public unsafe UStaticMeshComponent SM_Gel_Pro_305AM_FX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_SM_Gel_Pro_305AM_FX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_SM_Gel_Pro_305AM_FX, value);
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0601E3E8 RID: 123880 RVA: 0x0090EFB1 File Offset: 0x0090D1B1
		// (set) Token: 0x0601E3E9 RID: 123881 RVA: 0x0090EFC5 File Offset: 0x0090D1C5
		public unsafe UStaticMeshComponent SM_Gel_Pro_304AM_FX
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_SM_Gel_Pro_304AM_FX);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_SM_Gel_Pro_304AM_FX, value);
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0601E3EA RID: 123882 RVA: 0x0090EFDA File Offset: 0x0090D1DA
		// (set) Token: 0x0601E3EB RID: 123883 RVA: 0x0090EFEE File Offset: 0x0090D1EE
		public unsafe UStaticMeshComponent SM_MB_Gel_Bri_04TL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_SM_MB_Gel_Bri_04TL);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_SM_MB_Gel_Bri_04TL, value);
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0601E3EC RID: 123884 RVA: 0x0090F003 File Offset: 0x0090D203
		// (set) Token: 0x0601E3ED RID: 123885 RVA: 0x0090F017 File Offset: 0x0090D217
		public unsafe UStaticMeshComponent SM_Gel_Bri_04IL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_SM_Gel_Bri_04IL);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_SM_Gel_Bri_04IL, value);
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0601E3EE RID: 123886 RVA: 0x0090F02C File Offset: 0x0090D22C
		// (set) Token: 0x0601E3EF RID: 123887 RVA: 0x0090F040 File Offset: 0x0090D240
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BridgeModels_BrokenMobile_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0601E3F0 RID: 123888 RVA: 0x0090F058 File Offset: 0x0090D258
		// (set) Token: 0x0601E3F1 RID: 123889 RVA: 0x0090F091 File Offset: 0x0090D291
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
					result = (this._custom = new custom(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_custom, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_custom, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0601E3F2 RID: 123890 RVA: 0x0090F0B2 File Offset: 0x0090D2B2
		// (set) Token: 0x0601E3F3 RID: 123891 RVA: 0x0090F0C6 File Offset: 0x0090D2C6
		public unsafe FVector NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_NewVar_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_NewVar_0) = value;
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0601E3F4 RID: 123892 RVA: 0x0090F0DB File Offset: 0x0090D2DB
		// (set) Token: 0x0601E3F5 RID: 123893 RVA: 0x0090F0EB File Offset: 0x0090D2EB
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_CustomTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_CustomTime) = value;
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0601E3F6 RID: 123894 RVA: 0x0090F0FC File Offset: 0x0090D2FC
		// (set) Token: 0x0601E3F7 RID: 123895 RVA: 0x0090F10C File Offset: 0x0090D30C
		public unsafe bool IsBroken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_IsBroken) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_IsBroken) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0601E3F8 RID: 123896 RVA: 0x0090F11D File Offset: 0x0090D31D
		// (set) Token: 0x0601E3F9 RID: 123897 RVA: 0x0090F12D File Offset: 0x0090D32D
		public unsafe float InterpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_InterpTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BridgeModels_BrokenMobile_C.__PropertyOffset_InterpTime) = value;
			}
		}

		// Token: 0x0601E3FA RID: 123898 RVA: 0x0090F13E File Offset: 0x0090D33E
		[SkipLocalsInit]
		public virtual void BreakTest()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__BreakTest_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3FB RID: 123899 RVA: 0x0090F152 File Offset: 0x0090D352
		[SkipLocalsInit]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3FC RID: 123900 RVA: 0x0090F168 File Offset: 0x0090D368
		[SkipLocalsInit]
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

		// Token: 0x0601E3FD RID: 123901 RVA: 0x0090F1EA File Offset: 0x0090D3EA
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3FE RID: 123902 RVA: 0x0090F1FE File Offset: 0x0090D3FE
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3FF RID: 123903 RVA: 0x0090F214 File Offset: 0x0090D414
		[SkipLocalsInit]
		public unsafe virtual void Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5(int PlayingID)
		{
			BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E400 RID: 123904 RVA: 0x0090F25A File Offset: 0x0090D45A
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E401 RID: 123905 RVA: 0x0090F26E File Offset: 0x0090D46E
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E402 RID: 123906 RVA: 0x0090F284 File Offset: 0x0090D484
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E403 RID: 123907 RVA: 0x0090F2CC File Offset: 0x0090D4CC
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BridgeModels_BrokenMobile_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BridgeModels_BrokenMobile_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E404 RID: 123908 RVA: 0x0090F312 File Offset: 0x0090D512
		[SkipLocalsInit]
		public virtual void BreakEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__BreakEvent_NativeFunctionPtr, null);
		}

		// Token: 0x0601E405 RID: 123909 RVA: 0x0090F326 File Offset: 0x0090D526
		[SkipLocalsInit]
		public virtual void BreakTrigger()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BridgeModels_BrokenMobile_C.__BreakTrigger_NativeFunctionPtr, null);
		}

		// Token: 0x0601E406 RID: 123910 RVA: 0x0090F33C File Offset: 0x0090D53C
		[SkipLocalsInit]
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

		// Token: 0x0601E407 RID: 123911 RVA: 0x0090F3F8 File Offset: 0x0090D5F8
		[SkipLocalsInit]
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

		// Token: 0x0601E408 RID: 123912 RVA: 0x0090F481 File Offset: 0x0090D681
		protected BP_BridgeModels_BrokenMobile_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010012 RID: 65554
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C";

		// Token: 0x04010013 RID: 65555
		private static IntPtr _ClassPtr;

		// Token: 0x04010014 RID: 65556
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010015 RID: 65557
		public static IntPtr __custom__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010016 RID: 65558
		internal static int __PropertyOffset_Box;

		// Token: 0x04010017 RID: 65559
		internal static int __PropertyOffset_SM_Gel_Pro_305AM_FX;

		// Token: 0x04010018 RID: 65560
		internal static int __PropertyOffset_SM_Gel_Pro_304AM_FX;

		// Token: 0x04010019 RID: 65561
		internal static int __PropertyOffset_SM_MB_Gel_Bri_04TL;

		// Token: 0x0401001A RID: 65562
		internal static int __PropertyOffset_SM_Gel_Bri_04IL;

		// Token: 0x0401001B RID: 65563
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401001C RID: 65564
		internal static int __PropertyOffset_custom;

		// Token: 0x0401001D RID: 65565
		private custom _custom;

		// Token: 0x0401001E RID: 65566
		internal static int __PropertyOffset_NewVar_0;

		// Token: 0x0401001F RID: 65567
		internal static int __PropertyOffset_CustomTime;

		// Token: 0x04010020 RID: 65568
		internal static int __PropertyOffset_IsBroken;

		// Token: 0x04010021 RID: 65569
		internal static int __PropertyOffset_InterpTime;

		// Token: 0x04010022 RID: 65570
		private static IntPtr __BreakTest_NativeFunctionPtr;

		// Token: 0x04010023 RID: 65571
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04010024 RID: 65572
		private static IntPtr __GetBridgeLink_NativeFunctionPtr;

		// Token: 0x04010025 RID: 65573
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010026 RID: 65574
		private static IntPtr __Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_NativeFunctionPtr;

		// Token: 0x04010027 RID: 65575
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010028 RID: 65576
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010029 RID: 65577
		private static IntPtr __BreakEvent_NativeFunctionPtr;

		// Token: 0x0401002A RID: 65578
		private static IntPtr __BreakTrigger_NativeFunctionPtr;

		// Token: 0x0401002B RID: 65579
		private static IntPtr __BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401002C RID: 65580
		private static IntPtr __BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02008E4E RID: 36430
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 560)]
		protected ref struct __GetBridgeLink_FunctionParams
		{
			// Token: 0x0402CA8F RID: 182927
			[FieldOffset(0)]
			public int idx;

			// Token: 0x0402CA90 RID: 182928
			[FieldOffset(8)]
			public byte tempArray1;
		}

		// Token: 0x02008E4F RID: 36431
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_92BA8E5D417BEAC0CD4FF88EAA5B9EC5_FunctionParams
		{
			// Token: 0x0402CA91 RID: 182929
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02008E50 RID: 36432
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA92 RID: 182930
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E51 RID: 36433
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0402CA93 RID: 182931
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402CA94 RID: 182932
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402CA95 RID: 182933
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402CA96 RID: 182934
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0402CA97 RID: 182935
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0402CA98 RID: 182936
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02008E52 RID: 36434
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BridgeModels_BrokenMobile_Box_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0402CA99 RID: 182937
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402CA9A RID: 182938
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402CA9B RID: 182939
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402CA9C RID: 182940
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
