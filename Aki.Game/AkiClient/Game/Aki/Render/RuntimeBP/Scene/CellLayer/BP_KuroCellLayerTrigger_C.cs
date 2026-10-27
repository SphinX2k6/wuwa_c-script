using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.CellLayer
{
	// Token: 0x02003BA1 RID: 15265
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/CellLayer/BP_KuroCellLayerTrigger.BP_KuroCellLayerTrigger_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1092)]
	public class BP_KuroCellLayerTrigger_C : AWorldPartitionKuroCellLayerTrigger, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F93 RID: 139155 RVA: 0x008FB125 File Offset: 0x008F9325
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCellLayerTrigger_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/CellLayer/BP_KuroCellLayerTrigger.BP_KuroCellLayerTrigger_C");
			}
			return BP_KuroCellLayerTrigger_C._ClassPtr;
		}

		// Token: 0x06021F94 RID: 139156 RVA: 0x008FB14C File Offset: 0x008F934C
		public BP_KuroCellLayerTrigger_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCellLayerTrigger_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F95 RID: 139157 RVA: 0x008FB174 File Offset: 0x008F9374
		[NullableContext(1)]
		public BP_KuroCellLayerTrigger_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCellLayerTrigger_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x06021F96 RID: 139158 RVA: 0x008FB1A7 File Offset: 0x008F93A7
		// (set) Token: 0x06021F97 RID: 139159 RVA: 0x008FB1BB File Offset: 0x008F93BB
		public unsafe UBoxComponent LeaveBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCellLayerTrigger_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCellLayerTrigger_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x06021F98 RID: 139160 RVA: 0x008FB1D0 File Offset: 0x008F93D0
		// (set) Token: 0x06021F99 RID: 139161 RVA: 0x008FB1E4 File Offset: 0x008F93E4
		public unsafe UBoxComponent EnterBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCellLayerTrigger_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCellLayerTrigger_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x06021F9A RID: 139162 RVA: 0x008FB1F9 File Offset: 0x008F93F9
		// (set) Token: 0x06021F9B RID: 139163 RVA: 0x008FB209 File Offset: 0x008F9409
		public unsafe EKuroCellLayerType Enter
		{
			get
			{
				return (EKuroCellLayerType)(*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_3));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_3) = (byte)value;
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x06021F9C RID: 139164 RVA: 0x008FB21A File Offset: 0x008F941A
		// (set) Token: 0x06021F9D RID: 139165 RVA: 0x008FB22A File Offset: 0x008F942A
		public unsafe EKuroCellLayerType Leave
		{
			get
			{
				return (EKuroCellLayerType)(*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_4));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_4) = (byte)value;
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x06021F9E RID: 139166 RVA: 0x008FB23B File Offset: 0x008F943B
		// (set) Token: 0x06021F9F RID: 139167 RVA: 0x008FB24B File Offset: 0x008F944B
		public unsafe bool InSideEnterBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x06021FA0 RID: 139168 RVA: 0x008FB25C File Offset: 0x008F945C
		// (set) Token: 0x06021FA1 RID: 139169 RVA: 0x008FB26C File Offset: 0x008F946C
		public unsafe bool InSideLeaveBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x06021FA2 RID: 139170 RVA: 0x008FB27D File Offset: 0x008F947D
		// (set) Token: 0x06021FA3 RID: 139171 RVA: 0x008FB28D File Offset: 0x008F948D
		public unsafe bool OldInSideEnterBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x06021FA4 RID: 139172 RVA: 0x008FB29E File Offset: 0x008F949E
		// (set) Token: 0x06021FA5 RID: 139173 RVA: 0x008FB2AE File Offset: 0x008F94AE
		public unsafe bool OldInSideLeaveBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x06021FA6 RID: 139174 RVA: 0x008FB2BF File Offset: 0x008F94BF
		// (set) Token: 0x06021FA7 RID: 139175 RVA: 0x008FB2CF File Offset: 0x008F94CF
		public unsafe EStreamingSourcePriority StreamingSourcePriority
		{
			get
			{
				return (EStreamingSourcePriority)(*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_9));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_9) = (byte)value;
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x06021FA8 RID: 139176 RVA: 0x008FB2E0 File Offset: 0x008F94E0
		// (set) Token: 0x06021FA9 RID: 139177 RVA: 0x008FB2F4 File Offset: 0x008F94F4
		public unsafe FName ExclusiveDatalayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCellLayerTrigger_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06021FAA RID: 139178 RVA: 0x008FB309 File Offset: 0x008F9509
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnLeaveBoxEndOverlap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__OnLeaveBoxEndOverlap_NativeFunctionPtr, null);
		}

		// Token: 0x06021FAB RID: 139179 RVA: 0x008FB31D File Offset: 0x008F951D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnEnterBoxBeginOverlap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__OnEnterBoxBeginOverlap_NativeFunctionPtr, null);
		}

		// Token: 0x06021FAC RID: 139180 RVA: 0x008FB331 File Offset: 0x008F9531
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnTeleportStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__OnTeleportStart_NativeFunctionPtr, null);
		}

		// Token: 0x06021FAD RID: 139181 RVA: 0x008FB345 File Offset: 0x008F9545
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnTeleportStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__OnTeleportStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021FAE RID: 139182 RVA: 0x008FB35C File Offset: 0x008F955C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCellLayerTrigger_EnterBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_EnterBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_EnterBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_EnterBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_EnterBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_EnterBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021FAF RID: 139183 RVA: 0x008FB418 File Offset: 0x008F9618
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCellLayerTrigger_LeaveBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_LeaveBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_LeaveBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_LeaveBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_LeaveBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__BndEvt__BP_KuroCellLayerTrigger_LeaveBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021FB0 RID: 139184 RVA: 0x008FB4A4 File Offset: 0x008F96A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCellLayerTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCellLayerTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCellLayerTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCellLayerTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021FB1 RID: 139185 RVA: 0x008FB4EC File Offset: 0x008F96EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCellLayerTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCellLayerTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCellLayerTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCellLayerTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021FB2 RID: 139186 RVA: 0x008FB533 File Offset: 0x008F9733
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021FB3 RID: 139187 RVA: 0x008FB547 File Offset: 0x008F9747
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCellLayerTrigger_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021FB4 RID: 139188 RVA: 0x008FB55C File Offset: 0x008F975C
		protected BP_KuroCellLayerTrigger_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109DD RID: 68061
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/CellLayer/BP_KuroCellLayerTrigger.BP_KuroCellLayerTrigger_C";

		// Token: 0x040109DE RID: 68062
		private static IntPtr _ClassPtr;

		// Token: 0x040109DF RID: 68063
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109E0 RID: 68064
		internal static int __PropertyOffset_1;

		// Token: 0x040109E1 RID: 68065
		internal static int __PropertyOffset_2;

		// Token: 0x040109E2 RID: 68066
		internal static int __PropertyOffset_3;

		// Token: 0x040109E3 RID: 68067
		internal static int __PropertyOffset_4;

		// Token: 0x040109E4 RID: 68068
		internal static int __PropertyOffset_5;

		// Token: 0x040109E5 RID: 68069
		internal static int __PropertyOffset_6;

		// Token: 0x040109E6 RID: 68070
		internal static int __PropertyOffset_7;

		// Token: 0x040109E7 RID: 68071
		internal static int __PropertyOffset_8;

		// Token: 0x040109E8 RID: 68072
		internal static int __PropertyOffset_9;

		// Token: 0x040109E9 RID: 68073
		internal static int __PropertyOffset_10;

		// Token: 0x040109EA RID: 68074
		private static IntPtr __OnLeaveBoxEndOverlap_NativeFunctionPtr;

		// Token: 0x040109EB RID: 68075
		private static IntPtr __OnEnterBoxBeginOverlap_NativeFunctionPtr;

		// Token: 0x040109EC RID: 68076
		private static IntPtr __OnTeleportStart_NativeFunctionPtr;

		// Token: 0x040109ED RID: 68077
		private static IntPtr __BndEvt__BP_KuroCellLayerTrigger_EnterBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040109EE RID: 68078
		private static IntPtr __BndEvt__BP_KuroCellLayerTrigger_LeaveBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040109EF RID: 68079
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040109F0 RID: 68080
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009CF9 RID: 40185
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCellLayerTrigger_EnterBox_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040313FB RID: 201723
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040313FC RID: 201724
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040313FD RID: 201725
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040313FE RID: 201726
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040313FF RID: 201727
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031400 RID: 201728
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009CFA RID: 40186
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCellLayerTrigger_LeaveBox_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031401 RID: 201729
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031402 RID: 201730
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031403 RID: 201731
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031404 RID: 201732
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009CFB RID: 40187
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031405 RID: 201733
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
