using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x020030DD RID: 12509
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimaInteraction.BP_AnimaInteraction_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1485)]
	public class BP_AnimaInteraction_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_DayNightEvent_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E35D RID: 123741 RVA: 0x0090DFFF File Offset: 0x0090C1FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AnimaInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimaInteraction.BP_AnimaInteraction_C");
			}
			return BP_AnimaInteraction_C._ClassPtr;
		}

		// Token: 0x0601E35E RID: 123742 RVA: 0x0090E024 File Offset: 0x0090C224
		public BP_AnimaInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_AnimaInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E35F RID: 123743 RVA: 0x0090E04C File Offset: 0x0090C24C
		[NullableContext(1)]
		public BP_AnimaInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AnimaInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0601E360 RID: 123744 RVA: 0x0090E07F File Offset: 0x0090C27F
		// (set) Token: 0x0601E361 RID: 123745 RVA: 0x0090E093 File Offset: 0x0090C293
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SK_Col_Bui_42AM
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimaInteraction_C.__PropertyOffset_SK_Col_Bui_42AM);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimaInteraction_C.__PropertyOffset_SK_Col_Bui_42AM, value);
			}
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0601E362 RID: 123746 RVA: 0x0090E0A8 File Offset: 0x0090C2A8
		// (set) Token: 0x0601E363 RID: 123747 RVA: 0x0090E0BC File Offset: 0x0090C2BC
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimaInteraction_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimaInteraction_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0601E364 RID: 123748 RVA: 0x0090E0D1 File Offset: 0x0090C2D1
		// (set) Token: 0x0601E365 RID: 123749 RVA: 0x0090E0E1 File Offset: 0x0090C2E1
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimaInteraction_C.__PropertyOffset_Delta_Seconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimaInteraction_C.__PropertyOffset_Delta_Seconds) = value;
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0601E366 RID: 123750 RVA: 0x0090E0F2 File Offset: 0x0090C2F2
		// (set) Token: 0x0601E367 RID: 123751 RVA: 0x0090E102 File Offset: 0x0090C302
		public unsafe bool IsDaytime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimaInteraction_C.__PropertyOffset_IsDaytime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimaInteraction_C.__PropertyOffset_IsDaytime) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E368 RID: 123752 RVA: 0x0090E113 File Offset: 0x0090C313
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E369 RID: 123753 RVA: 0x0090E127 File Offset: 0x0090C327
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimaInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E36A RID: 123754 RVA: 0x0090E13C File Offset: 0x0090C33C
		[SkipLocalsInit]
		public unsafe virtual void OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E36B RID: 123755 RVA: 0x0090E184 File Offset: 0x0090C384
		[SkipLocalsInit]
		public unsafe virtual void OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E36C RID: 123756 RVA: 0x0090E1CC File Offset: 0x0090C3CC
		[SkipLocalsInit]
		public unsafe virtual void OnInterrupted_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnInterrupted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E36D RID: 123757 RVA: 0x0090E214 File Offset: 0x0090C414
		[SkipLocalsInit]
		public unsafe virtual void OnBlendOut_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnBlendOut_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E36E RID: 123758 RVA: 0x0090E25C File Offset: 0x0090C45C
		[SkipLocalsInit]
		public unsafe virtual void OnCompleted_142B7BB44212D48928074EA2B856E6F8(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnCompleted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E36F RID: 123759 RVA: 0x0090E2A4 File Offset: 0x0090C4A4
		[SkipLocalsInit]
		public unsafe virtual void OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E370 RID: 123760 RVA: 0x0090E2EC File Offset: 0x0090C4EC
		[SkipLocalsInit]
		public unsafe virtual void OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E371 RID: 123761 RVA: 0x0090E334 File Offset: 0x0090C534
		[SkipLocalsInit]
		public unsafe virtual void OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E372 RID: 123762 RVA: 0x0090E37C File Offset: 0x0090C57C
		[SkipLocalsInit]
		public unsafe virtual void OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E373 RID: 123763 RVA: 0x0090E3C4 File Offset: 0x0090C5C4
		[SkipLocalsInit]
		public unsafe virtual void OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B(FName NotifyName)
		{
			BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NotifyName = NotifyName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E374 RID: 123764 RVA: 0x0090E40A File Offset: 0x0090C60A
		[SkipLocalsInit]
		public virtual void OnEnterNight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnEnterNight_NativeFunctionPtr, null);
		}

		// Token: 0x0601E375 RID: 123765 RVA: 0x0090E41E File Offset: 0x0090C61E
		[SkipLocalsInit]
		public virtual void OnEnterDay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__OnEnterDay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E376 RID: 123766 RVA: 0x0090E432 File Offset: 0x0090C632
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E377 RID: 123767 RVA: 0x0090E446 File Offset: 0x0090C646
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimaInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E378 RID: 123768 RVA: 0x0090E45C File Offset: 0x0090C65C
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimaInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E379 RID: 123769 RVA: 0x0090E4A8 File Offset: 0x0090C6A8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_AnimaInteraction_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimaInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimaInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E37A RID: 123770 RVA: 0x0090E4F3 File Offset: 0x0090C6F3
		protected BP_AnimaInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFBD RID: 65469
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimaInteraction.BP_AnimaInteraction_C";

		// Token: 0x0400FFBE RID: 65470
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFBF RID: 65471
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFC0 RID: 65472
		internal static int __PropertyOffset_SK_Col_Bui_42AM;

		// Token: 0x0400FFC1 RID: 65473
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FFC2 RID: 65474
		internal static int __PropertyOffset_Delta_Seconds;

		// Token: 0x0400FFC3 RID: 65475
		internal static int __PropertyOffset_IsDaytime;

		// Token: 0x0400FFC4 RID: 65476
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FFC5 RID: 65477
		private static IntPtr __OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x0400FFC6 RID: 65478
		private static IntPtr __OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x0400FFC7 RID: 65479
		private static IntPtr __OnInterrupted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x0400FFC8 RID: 65480
		private static IntPtr __OnBlendOut_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x0400FFC9 RID: 65481
		private static IntPtr __OnCompleted_142B7BB44212D48928074EA2B856E6F8_NativeFunctionPtr;

		// Token: 0x0400FFCA RID: 65482
		private static IntPtr __OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x0400FFCB RID: 65483
		private static IntPtr __OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x0400FFCC RID: 65484
		private static IntPtr __OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x0400FFCD RID: 65485
		private static IntPtr __OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x0400FFCE RID: 65486
		private static IntPtr __OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_NativeFunctionPtr;

		// Token: 0x0400FFCF RID: 65487
		private static IntPtr __OnEnterNight_NativeFunctionPtr;

		// Token: 0x0400FFD0 RID: 65488
		private static IntPtr __OnEnterDay_NativeFunctionPtr;

		// Token: 0x0400FFD1 RID: 65489
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FFD2 RID: 65490
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008E40 RID: 36416
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyEnd_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x0402CA81 RID: 182913
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E41 RID: 36417
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyBegin_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x0402CA82 RID: 182914
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E42 RID: 36418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnInterrupted_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x0402CA83 RID: 182915
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E43 RID: 36419
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnBlendOut_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x0402CA84 RID: 182916
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E44 RID: 36420
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnCompleted_142B7BB44212D48928074EA2B856E6F8_FunctionParams
		{
			// Token: 0x0402CA85 RID: 182917
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E45 RID: 36421
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyEnd_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x0402CA86 RID: 182918
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E46 RID: 36422
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnNotifyBegin_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x0402CA87 RID: 182919
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E47 RID: 36423
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnInterrupted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x0402CA88 RID: 182920
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E48 RID: 36424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnBlendOut_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x0402CA89 RID: 182921
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E49 RID: 36425
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OnCompleted_194B232544CEDB40C8F0FA9B8B995E7B_FunctionParams
		{
			// Token: 0x0402CA8A RID: 182922
			[FieldOffset(0)]
			public FName NotifyName;
		}

		// Token: 0x02008E4A RID: 36426
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CA8B RID: 182923
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
