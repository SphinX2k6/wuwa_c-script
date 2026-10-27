using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x02003C17 RID: 15383
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimationTrigger.BP_AnimationTrigger_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1684)]
	public class BP_AnimationTrigger_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602335F RID: 144223 RVA: 0x0091D7F1 File Offset: 0x0091B9F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AnimationTrigger_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimationTrigger.BP_AnimationTrigger_C");
			}
			return BP_AnimationTrigger_C._ClassPtr;
		}

		// Token: 0x06023360 RID: 144224 RVA: 0x0091D818 File Offset: 0x0091BA18
		public BP_AnimationTrigger_C() : this(BuiltinUtils.AllocNativeUObject(BP_AnimationTrigger_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023361 RID: 144225 RVA: 0x0091D840 File Offset: 0x0091BA40
		public BP_AnimationTrigger_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AnimationTrigger_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x06023362 RID: 144226 RVA: 0x0091D873 File Offset: 0x0091BA73
		// (set) Token: 0x06023363 RID: 144227 RVA: 0x0091D887 File Offset: 0x0091BA87
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimationTrigger_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimationTrigger_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x06023364 RID: 144228 RVA: 0x0091D89C File Offset: 0x0091BA9C
		// (set) Token: 0x06023365 RID: 144229 RVA: 0x0091D8B0 File Offset: 0x0091BAB0
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimationTrigger_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AnimationTrigger_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x06023366 RID: 144230 RVA: 0x0091D8C5 File Offset: 0x0091BAC5
		// (set) Token: 0x06023367 RID: 144231 RVA: 0x0091D8D5 File Offset: 0x0091BAD5
		public unsafe bool IN
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x06023368 RID: 144232 RVA: 0x0091D8E6 File Offset: 0x0091BAE6
		// (set) Token: 0x06023369 RID: 144233 RVA: 0x0091D8F6 File Offset: 0x0091BAF6
		public unsafe bool OUT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x0602336A RID: 144234 RVA: 0x0091D907 File Offset: 0x0091BB07
		// (set) Token: 0x0602336B RID: 144235 RVA: 0x0091D91B File Offset: 0x0091BB1B
		public unsafe FVector 触发框大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x0602336C RID: 144236 RVA: 0x0091D930 File Offset: 0x0091BB30
		// (set) Token: 0x0602336D RID: 144237 RVA: 0x0091D940 File Offset: 0x0091BB40
		public unsafe float 动画时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x0602336E RID: 144238 RVA: 0x0091D954 File Offset: 0x0091BB54
		// (set) Token: 0x0602336F RID: 144239 RVA: 0x0091D98D File Offset: 0x0091BB8D
		public TMap<UStaticMesh, int> 模型资产
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMesh, int> result;
				if ((result = this._模型资产) == null)
				{
					result = (this._模型资产 = new TMap<UStaticMesh, int>(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.模型资产.CopyAssign(value);
			}
		}

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x06023370 RID: 144240 RVA: 0x0091D99C File Offset: 0x0091BB9C
		// (set) Token: 0x06023371 RID: 144241 RVA: 0x0091D9D5 File Offset: 0x0091BBD5
		public TMap<UStaticMeshComponent, int> Components
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMeshComponent, int> result;
				if ((result = this._Components) == null)
				{
					result = (this._Components = new TMap<UStaticMeshComponent, int>(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.Components.CopyAssign(value);
			}
		}

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x06023372 RID: 144242 RVA: 0x0091D9E3 File Offset: 0x0091BBE3
		// (set) Token: 0x06023373 RID: 144243 RVA: 0x0091D9F3 File Offset: 0x0091BBF3
		public unsafe bool Trigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x06023374 RID: 144244 RVA: 0x0091DA04 File Offset: 0x0091BC04
		// (set) Token: 0x06023375 RID: 144245 RVA: 0x0091DA14 File Offset: 0x0091BC14
		public unsafe int InBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x06023376 RID: 144246 RVA: 0x0091DA25 File Offset: 0x0091BC25
		// (set) Token: 0x06023377 RID: 144247 RVA: 0x0091DA35 File Offset: 0x0091BC35
		public unsafe float LastTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x06023378 RID: 144248 RVA: 0x0091DA46 File Offset: 0x0091BC46
		// (set) Token: 0x06023379 RID: 144249 RVA: 0x0091DA56 File Offset: 0x0091BC56
		public unsafe float CurrentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x0602337A RID: 144250 RVA: 0x0091DA67 File Offset: 0x0091BC67
		// (set) Token: 0x0602337B RID: 144251 RVA: 0x0091DA77 File Offset: 0x0091BC77
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimationTrigger_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x0602337C RID: 144252 RVA: 0x0091DA88 File Offset: 0x0091BC88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimationTrigger_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602337D RID: 144253 RVA: 0x0091DA9C File Offset: 0x0091BC9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimationTrigger_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602337E RID: 144254 RVA: 0x0091DAB1 File Offset: 0x0091BCB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimationTrigger_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602337F RID: 144255 RVA: 0x0091DAC5 File Offset: 0x0091BCC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimationTrigger_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023380 RID: 144256 RVA: 0x0091DADC File Offset: 0x0091BCDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023381 RID: 144257 RVA: 0x0091DB98 File Offset: 0x0091BD98
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimationTrigger_C.__BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023382 RID: 144258 RVA: 0x0091DC24 File Offset: 0x0091BE24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_AnimationTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AnimationTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AnimationTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimationTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimationTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023383 RID: 144259 RVA: 0x0091DC6C File Offset: 0x0091BE6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_AnimationTrigger_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AnimationTrigger_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AnimationTrigger_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimationTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimationTrigger_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023384 RID: 144260 RVA: 0x0091DCB3 File Offset: 0x0091BEB3
		protected BP_AnimationTrigger_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115BC RID: 71100
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_AnimationTrigger.BP_AnimationTrigger_C";

		// Token: 0x040115BD RID: 71101
		private static IntPtr _ClassPtr;

		// Token: 0x040115BE RID: 71102
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115BF RID: 71103
		internal static int __PropertyOffset_1;

		// Token: 0x040115C0 RID: 71104
		internal static int __PropertyOffset_2;

		// Token: 0x040115C1 RID: 71105
		internal static int __PropertyOffset_3;

		// Token: 0x040115C2 RID: 71106
		internal static int __PropertyOffset_4;

		// Token: 0x040115C3 RID: 71107
		internal static int __PropertyOffset_5;

		// Token: 0x040115C4 RID: 71108
		internal static int __PropertyOffset_6;

		// Token: 0x040115C5 RID: 71109
		internal static int __PropertyOffset_7;

		// Token: 0x040115C6 RID: 71110
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UStaticMesh, int> _模型资产;

		// Token: 0x040115C7 RID: 71111
		internal static int __PropertyOffset_8;

		// Token: 0x040115C8 RID: 71112
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UStaticMeshComponent, int> _Components;

		// Token: 0x040115C9 RID: 71113
		internal static int __PropertyOffset_9;

		// Token: 0x040115CA RID: 71114
		internal static int __PropertyOffset_10;

		// Token: 0x040115CB RID: 71115
		internal static int __PropertyOffset_11;

		// Token: 0x040115CC RID: 71116
		internal static int __PropertyOffset_12;

		// Token: 0x040115CD RID: 71117
		internal static int __PropertyOffset_13;

		// Token: 0x040115CE RID: 71118
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040115CF RID: 71119
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040115D0 RID: 71120
		private static IntPtr __BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040115D1 RID: 71121
		private static IntPtr __BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040115D2 RID: 71122
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E33 RID: 40499
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403167E RID: 202366
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403167F RID: 202367
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031680 RID: 202368
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031681 RID: 202369
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031682 RID: 202370
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031683 RID: 202371
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E34 RID: 40500
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_AnimationTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031684 RID: 202372
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031685 RID: 202373
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031686 RID: 202374
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031687 RID: 202375
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009E35 RID: 40501
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031688 RID: 202376
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
