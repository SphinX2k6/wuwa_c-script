using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Volume
{
	// Token: 0x02003BE1 RID: 15329
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Volume/BP_KuroCmdVolume.BP_KuroCmdVolume_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1563)]
	public class BP_KuroCmdVolume_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022987 RID: 141703 RVA: 0x0090D096 File Offset: 0x0090B296
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCmdVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Volume/BP_KuroCmdVolume.BP_KuroCmdVolume_C");
			}
			return BP_KuroCmdVolume_C._ClassPtr;
		}

		// Token: 0x06022988 RID: 141704 RVA: 0x0090D0BC File Offset: 0x0090B2BC
		public BP_KuroCmdVolume_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCmdVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022989 RID: 141705 RVA: 0x0090D0E4 File Offset: 0x0090B2E4
		public BP_KuroCmdVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCmdVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0602298A RID: 141706 RVA: 0x0090D117 File Offset: 0x0090B317
		// (set) Token: 0x0602298B RID: 141707 RVA: 0x0090D12B File Offset: 0x0090B32B
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCmdVolume_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCmdVolume_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0602298C RID: 141708 RVA: 0x0090D140 File Offset: 0x0090B340
		// (set) Token: 0x0602298D RID: 141709 RVA: 0x0090D154 File Offset: 0x0090B354
		public unsafe FVector WorldLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0602298E RID: 141710 RVA: 0x0090D169 File Offset: 0x0090B369
		// (set) Token: 0x0602298F RID: 141711 RVA: 0x0090D17D File Offset: 0x0090B37D
		public unsafe FVector Box_Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x06022990 RID: 141712 RVA: 0x0090D194 File Offset: 0x0090B394
		// (set) Token: 0x06022991 RID: 141713 RVA: 0x0090D1CD File Offset: 0x0090B3CD
		public TArray<string> InBoxCmd
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._InBoxCmd) == null)
				{
					result = (this._InBoxCmd = new TArray<string>(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.InBoxCmd.CopyAssign(value);
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x06022992 RID: 141714 RVA: 0x0090D1DC File Offset: 0x0090B3DC
		// (set) Token: 0x06022993 RID: 141715 RVA: 0x0090D215 File Offset: 0x0090B415
		public TArray<string> OutBoxCmd
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OutBoxCmd) == null)
				{
					result = (this._OutBoxCmd = new TArray<string>(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.OutBoxCmd.CopyAssign(value);
			}
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x06022994 RID: 141716 RVA: 0x0090D223 File Offset: 0x0090B423
		// (set) Token: 0x06022995 RID: 141717 RVA: 0x0090D233 File Offset: 0x0090B433
		public unsafe bool bPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x06022996 RID: 141718 RVA: 0x0090D244 File Offset: 0x0090B444
		// (set) Token: 0x06022997 RID: 141719 RVA: 0x0090D27D File Offset: 0x0090B47D
		public TArray<string> InBoxCmdMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._InBoxCmdMobile) == null)
				{
					result = (this._InBoxCmdMobile = new TArray<string>(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.InBoxCmdMobile.CopyAssign(value);
			}
		}

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x06022998 RID: 141720 RVA: 0x0090D28C File Offset: 0x0090B48C
		// (set) Token: 0x06022999 RID: 141721 RVA: 0x0090D2C5 File Offset: 0x0090B4C5
		public TArray<string> OutBoxCmdMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OutBoxCmdMobile) == null)
				{
					result = (this._OutBoxCmdMobile = new TArray<string>(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.OutBoxCmdMobile.CopyAssign(value);
			}
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0602299A RID: 141722 RVA: 0x0090D2D3 File Offset: 0x0090B4D3
		// (set) Token: 0x0602299B RID: 141723 RVA: 0x0090D2E3 File Offset: 0x0090B4E3
		public unsafe bool bValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0602299C RID: 141724 RVA: 0x0090D2F4 File Offset: 0x0090B4F4
		// (set) Token: 0x0602299D RID: 141725 RVA: 0x0090D304 File Offset: 0x0090B504
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0602299E RID: 141726 RVA: 0x0090D315 File Offset: 0x0090B515
		// (set) Token: 0x0602299F RID: 141727 RVA: 0x0090D325 File Offset: 0x0090B525
		public unsafe bool bIgnoreCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCmdVolume_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x060229A0 RID: 141728 RVA: 0x0090D336 File Offset: 0x0090B536
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableCmd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__DisableCmd_NativeFunctionPtr, null);
		}

		// Token: 0x060229A1 RID: 141729 RVA: 0x0090D34A File Offset: 0x0090B54A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableCmd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__EnableCmd_NativeFunctionPtr, null);
		}

		// Token: 0x060229A2 RID: 141730 RVA: 0x0090D360 File Offset: 0x0090B560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool HasValidCmd()
		{
			BP_KuroCmdVolume_C.__HasValidCmd_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__HasValidCmd_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__HasValidCmd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__HasValidCmd_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__HasValidCmd_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060229A3 RID: 141731 RVA: 0x0090D3A5 File Offset: 0x0090B5A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060229A4 RID: 141732 RVA: 0x0090D3B9 File Offset: 0x0090B5B9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCmdVolume_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060229A5 RID: 141733 RVA: 0x0090D3CE File Offset: 0x0090B5CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060229A6 RID: 141734 RVA: 0x0090D3E2 File Offset: 0x0090B5E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCmdVolume_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060229A7 RID: 141735 RVA: 0x0090D3F8 File Offset: 0x0090B5F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCmdVolume_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060229A8 RID: 141736 RVA: 0x0090D440 File Offset: 0x0090B640
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCmdVolume_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCmdVolume_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060229A9 RID: 141737 RVA: 0x0090D488 File Offset: 0x0090B688
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_KuroCmdVolume_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060229AA RID: 141738 RVA: 0x0090D4D0 File Offset: 0x0090B6D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCmdVolume_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCmdVolume_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060229AB RID: 141739 RVA: 0x0090D518 File Offset: 0x0090B718
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroCmdVolume_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060229AC RID: 141740 RVA: 0x0090D564 File Offset: 0x0090B764
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroCmdVolume_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCmdVolume_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060229AD RID: 141741 RVA: 0x0090D5B0 File Offset: 0x0090B7B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060229AE RID: 141742 RVA: 0x0090D66C File Offset: 0x0090B86C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCmdVolume_C.__BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060229AF RID: 141743 RVA: 0x0090D6F5 File Offset: 0x0090B8F5
		protected BP_KuroCmdVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FE0 RID: 69600
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Volume/BP_KuroCmdVolume.BP_KuroCmdVolume_C";

		// Token: 0x04010FE1 RID: 69601
		private static IntPtr _ClassPtr;

		// Token: 0x04010FE2 RID: 69602
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FE3 RID: 69603
		internal static int __PropertyOffset_1;

		// Token: 0x04010FE4 RID: 69604
		internal static int __PropertyOffset_2;

		// Token: 0x04010FE5 RID: 69605
		internal static int __PropertyOffset_3;

		// Token: 0x04010FE6 RID: 69606
		internal static int __PropertyOffset_4;

		// Token: 0x04010FE7 RID: 69607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _InBoxCmd;

		// Token: 0x04010FE8 RID: 69608
		internal static int __PropertyOffset_5;

		// Token: 0x04010FE9 RID: 69609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OutBoxCmd;

		// Token: 0x04010FEA RID: 69610
		internal static int __PropertyOffset_6;

		// Token: 0x04010FEB RID: 69611
		internal static int __PropertyOffset_7;

		// Token: 0x04010FEC RID: 69612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _InBoxCmdMobile;

		// Token: 0x04010FED RID: 69613
		internal static int __PropertyOffset_8;

		// Token: 0x04010FEE RID: 69614
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OutBoxCmdMobile;

		// Token: 0x04010FEF RID: 69615
		internal static int __PropertyOffset_9;

		// Token: 0x04010FF0 RID: 69616
		internal static int __PropertyOffset_10;

		// Token: 0x04010FF1 RID: 69617
		internal static int __PropertyOffset_11;

		// Token: 0x04010FF2 RID: 69618
		private static IntPtr __DisableCmd_NativeFunctionPtr;

		// Token: 0x04010FF3 RID: 69619
		private static IntPtr __EnableCmd_NativeFunctionPtr;

		// Token: 0x04010FF4 RID: 69620
		private static IntPtr __HasValidCmd_NativeFunctionPtr;

		// Token: 0x04010FF5 RID: 69621
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010FF6 RID: 69622
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010FF7 RID: 69623
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010FF8 RID: 69624
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010FF9 RID: 69625
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010FFA RID: 69626
		private static IntPtr __BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010FFB RID: 69627
		private static IntPtr __BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D9C RID: 40348
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __HasValidCmd_FunctionParams
		{
			// Token: 0x04031575 RID: 202101
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009D9D RID: 40349
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031576 RID: 202102
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D9E RID: 40350
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031577 RID: 202103
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D9F RID: 40351
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031578 RID: 202104
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009DA0 RID: 40352
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031579 RID: 202105
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403157A RID: 202106
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403157B RID: 202107
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403157C RID: 202108
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403157D RID: 202109
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403157E RID: 202110
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009DA1 RID: 40353
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCmdVolume_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403157F RID: 202111
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031580 RID: 202112
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031581 RID: 202113
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031582 RID: 202114
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
