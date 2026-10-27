using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x02003C18 RID: 15384
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_BookShelfinteraction.BP_BookShelfinteraction_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1145)]
	public class BP_BookShelfinteraction_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023385 RID: 144261 RVA: 0x0091DCBC File Offset: 0x0091BEBC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BookShelfinteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_BookShelfinteraction.BP_BookShelfinteraction_C");
			}
			return BP_BookShelfinteraction_C._ClassPtr;
		}

		// Token: 0x06023386 RID: 144262 RVA: 0x0091DCE0 File Offset: 0x0091BEE0
		public BP_BookShelfinteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_BookShelfinteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023387 RID: 144263 RVA: 0x0091DD08 File Offset: 0x0091BF08
		[NullableContext(1)]
		public BP_BookShelfinteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BookShelfinteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x06023388 RID: 144264 RVA: 0x0091DD3B File Offset: 0x0091BF3B
		// (set) Token: 0x06023389 RID: 144265 RVA: 0x0091DD4F File Offset: 0x0091BF4F
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookShelfinteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookShelfinteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x0602338A RID: 144266 RVA: 0x0091DD64 File Offset: 0x0091BF64
		// (set) Token: 0x0602338B RID: 144267 RVA: 0x0091DD78 File Offset: 0x0091BF78
		public unsafe UKuroRegionBoxComponent KuroRegionBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRegionBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookShelfinteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookShelfinteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x0602338C RID: 144268 RVA: 0x0091DD8D File Offset: 0x0091BF8D
		// (set) Token: 0x0602338D RID: 144269 RVA: 0x0091DDA1 File Offset: 0x0091BFA1
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookShelfinteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookShelfinteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x0602338E RID: 144270 RVA: 0x0091DDB6 File Offset: 0x0091BFB6
		// (set) Token: 0x0602338F RID: 144271 RVA: 0x0091DDCA File Offset: 0x0091BFCA
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookShelfinteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookShelfinteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x06023390 RID: 144272 RVA: 0x0091DDDF File Offset: 0x0091BFDF
		// (set) Token: 0x06023391 RID: 144273 RVA: 0x0091DDF3 File Offset: 0x0091BFF3
		public unsafe FVectorDouble AttackPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x06023392 RID: 144274 RVA: 0x0091DE08 File Offset: 0x0091C008
		// (set) Token: 0x06023393 RID: 144275 RVA: 0x0091DE18 File Offset: 0x0091C018
		public unsafe bool Active
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x06023394 RID: 144276 RVA: 0x0091DE29 File Offset: 0x0091C029
		// (set) Token: 0x06023395 RID: 144277 RVA: 0x0091DE39 File Offset: 0x0091C039
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x06023396 RID: 144278 RVA: 0x0091DE4C File Offset: 0x0091C04C
		// (set) Token: 0x06023397 RID: 144279 RVA: 0x0091DE85 File Offset: 0x0091C085
		[Nullable(1)]
		public TArray<int> Frames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Frames) == null)
				{
					result = (this._Frames = new TArray<int>(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Frames.CopyAssign(value);
			}
		}

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x06023398 RID: 144280 RVA: 0x0091DE93 File Offset: 0x0091C093
		// (set) Token: 0x06023399 RID: 144281 RVA: 0x0091DEA3 File Offset: 0x0091C0A3
		public unsafe int ActiveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x0602339A RID: 144282 RVA: 0x0091DEB4 File Offset: 0x0091C0B4
		// (set) Token: 0x0602339B RID: 144283 RVA: 0x0091DEC4 File Offset: 0x0091C0C4
		public unsafe float NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x0602339C RID: 144284 RVA: 0x0091DED5 File Offset: 0x0091C0D5
		// (set) Token: 0x0602339D RID: 144285 RVA: 0x0091DEE5 File Offset: 0x0091C0E5
		public unsafe bool NewVar_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookShelfinteraction_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602339E RID: 144286 RVA: 0x0091DEF8 File Offset: 0x0091C0F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_BookShelfinteraction_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_BookShelfinteraction_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_BookShelfinteraction_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BookShelfinteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BookShelfinteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602339F RID: 144287 RVA: 0x0091DF5C File Offset: 0x0091C15C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BookShelfinteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BookShelfinteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BookShelfinteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BookShelfinteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BookShelfinteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233A0 RID: 144288 RVA: 0x0091DFA4 File Offset: 0x0091C1A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BookShelfinteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BookShelfinteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BookShelfinteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BookShelfinteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BookShelfinteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060233A1 RID: 144289 RVA: 0x0091DFEC File Offset: 0x0091C1EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233A2 RID: 144290 RVA: 0x0091E0A8 File Offset: 0x0091C2A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BookShelfinteraction_C.__BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233A3 RID: 144291 RVA: 0x0091E131 File Offset: 0x0091C331
		protected BP_BookShelfinteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115D3 RID: 71123
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_BookShelfinteraction.BP_BookShelfinteraction_C";

		// Token: 0x040115D4 RID: 71124
		private static IntPtr _ClassPtr;

		// Token: 0x040115D5 RID: 71125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115D6 RID: 71126
		internal static int __PropertyOffset_1;

		// Token: 0x040115D7 RID: 71127
		internal static int __PropertyOffset_2;

		// Token: 0x040115D8 RID: 71128
		internal static int __PropertyOffset_3;

		// Token: 0x040115D9 RID: 71129
		internal static int __PropertyOffset_4;

		// Token: 0x040115DA RID: 71130
		internal static int __PropertyOffset_5;

		// Token: 0x040115DB RID: 71131
		internal static int __PropertyOffset_6;

		// Token: 0x040115DC RID: 71132
		internal static int __PropertyOffset_7;

		// Token: 0x040115DD RID: 71133
		internal static int __PropertyOffset_8;

		// Token: 0x040115DE RID: 71134
		private TArray<int> _Frames;

		// Token: 0x040115DF RID: 71135
		internal static int __PropertyOffset_9;

		// Token: 0x040115E0 RID: 71136
		internal static int __PropertyOffset_10;

		// Token: 0x040115E1 RID: 71137
		internal static int __PropertyOffset_11;

		// Token: 0x040115E2 RID: 71138
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040115E3 RID: 71139
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040115E4 RID: 71140
		private static IntPtr __BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040115E5 RID: 71141
		private static IntPtr __BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E36 RID: 40502
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031689 RID: 202377
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403168A RID: 202378
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0403168B RID: 202379
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009E37 RID: 40503
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403168C RID: 202380
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E38 RID: 40504
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403168D RID: 202381
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403168E RID: 202382
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403168F RID: 202383
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031690 RID: 202384
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031691 RID: 202385
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031692 RID: 202386
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E39 RID: 40505
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BookShelfinteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031693 RID: 202387
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031694 RID: 202388
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031695 RID: 202389
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031696 RID: 202390
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
