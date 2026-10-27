using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003ADF RID: 15071
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_StaticMesh_AborbForce.BP_StaticMesh_AborbForce_C")]
	[UnrealStructLayout(1352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1348)]
	public class BP_StaticMesh_AborbForce_C : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208E8 RID: 133352 RVA: 0x008D6311 File Offset: 0x008D4511
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StaticMesh_AborbForce_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_StaticMesh_AborbForce.BP_StaticMesh_AborbForce_C");
			}
			return BP_StaticMesh_AborbForce_C._ClassPtr;
		}

		// Token: 0x060208E9 RID: 133353 RVA: 0x008D6338 File Offset: 0x008D4538
		public BP_StaticMesh_AborbForce_C() : this(BuiltinUtils.AllocNativeUObject(BP_StaticMesh_AborbForce_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208EA RID: 133354 RVA: 0x008D6360 File Offset: 0x008D4560
		public BP_StaticMesh_AborbForce_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StaticMesh_AborbForce_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x060208EB RID: 133355 RVA: 0x008D6393 File Offset: 0x008D4593
		// (set) Token: 0x060208EC RID: 133356 RVA: 0x008D63A7 File Offset: 0x008D45A7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_AborbForce_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_AborbForce_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x060208ED RID: 133357 RVA: 0x008D63BC File Offset: 0x008D45BC
		// (set) Token: 0x060208EE RID: 133358 RVA: 0x008D63F5 File Offset: 0x008D45F5
		public TArray<AActor> StaticActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._StaticActors) == null)
				{
					result = (this._StaticActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.StaticActors.CopyAssign(value);
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x060208EF RID: 133359 RVA: 0x008D6403 File Offset: 0x008D4603
		// (set) Token: 0x060208F0 RID: 133360 RVA: 0x008D6417 File Offset: 0x008D4617
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x060208F1 RID: 133361 RVA: 0x008D642C File Offset: 0x008D462C
		// (set) Token: 0x060208F2 RID: 133362 RVA: 0x008D6465 File Offset: 0x008D4665
		public FKuroCurveFloat Acceleration
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Acceleration) == null)
				{
					result = (this._Acceleration = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x060208F3 RID: 133363 RVA: 0x008D6488 File Offset: 0x008D4688
		// (set) Token: 0x060208F4 RID: 133364 RVA: 0x008D64C1 File Offset: 0x008D46C1
		public TArray<AActor> RuntimeActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._RuntimeActors) == null)
				{
					result = (this._RuntimeActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.RuntimeActors.CopyAssign(value);
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x060208F5 RID: 133365 RVA: 0x008D64D0 File Offset: 0x008D46D0
		// (set) Token: 0x060208F6 RID: 133366 RVA: 0x008D6509 File Offset: 0x008D4709
		public TArray<FVector> Speeds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Speeds) == null)
				{
					result = (this._Speeds = new TArray<FVector>(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.Speeds.CopyAssign(value);
			}
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x060208F7 RID: 133367 RVA: 0x008D6517 File Offset: 0x008D4717
		// (set) Token: 0x060208F8 RID: 133368 RVA: 0x008D6527 File Offset: 0x008D4727
		public unsafe float TimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x060208F9 RID: 133369 RVA: 0x008D6538 File Offset: 0x008D4738
		// (set) Token: 0x060208FA RID: 133370 RVA: 0x008D6548 File Offset: 0x008D4748
		public unsafe float Delta_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x060208FB RID: 133371 RVA: 0x008D6559 File Offset: 0x008D4759
		// (set) Token: 0x060208FC RID: 133372 RVA: 0x008D656D File Offset: 0x008D476D
		public unsafe FVector Speed_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x060208FD RID: 133373 RVA: 0x008D6582 File Offset: 0x008D4782
		// (set) Token: 0x060208FE RID: 133374 RVA: 0x008D6596 File Offset: 0x008D4796
		[Nullable(2)]
		public unsafe AActor Actor_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_AborbForce_C.__PropertyOffset_10);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_AborbForce_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x060208FF RID: 133375 RVA: 0x008D65AC File Offset: 0x008D47AC
		// (set) Token: 0x06020900 RID: 133376 RVA: 0x008D65E5 File Offset: 0x008D47E5
		public TArray<UStaticMeshComponent> StaticMeshesHidden
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._StaticMeshesHidden) == null)
				{
					result = (this._StaticMeshesHidden = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshesHidden.CopyAssign(value);
			}
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x06020901 RID: 133377 RVA: 0x008D65F4 File Offset: 0x008D47F4
		// (set) Token: 0x06020902 RID: 133378 RVA: 0x008D662D File Offset: 0x008D482D
		public TArray<float> Masses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Masses) == null)
				{
					result = (this._Masses = new TArray<float>(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.Masses.CopyAssign(value);
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x06020903 RID: 133379 RVA: 0x008D663B File Offset: 0x008D483B
		// (set) Token: 0x06020904 RID: 133380 RVA: 0x008D664B File Offset: 0x008D484B
		public unsafe float Acc_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StaticMesh_AborbForce_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x06020905 RID: 133381 RVA: 0x008D665C File Offset: 0x008D485C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CopyStaticMeshAndHide(AActor Actor, ref AActor ActorAdded)
		{
			BP_StaticMesh_AborbForce_C.__CopyStaticMeshAndHide_FunctionParams* ptr = stackalloc BP_StaticMesh_AborbForce_C.__CopyStaticMeshAndHide_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_StaticMesh_AborbForce_C.__CopyStaticMeshAndHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StaticMesh_AborbForce_C.__CopyStaticMeshAndHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ref BP_StaticMesh_AborbForce_C.__CopyStaticMeshAndHide_FunctionParams ptr2 = ref *ptr;
			AActor aactor = ActorAdded;
			ptr2.ActorAdded = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__CopyStaticMeshAndHide_NativeFunctionPtr, (void*)ptr);
			ActorAdded = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->ActorAdded);
		}

		// Token: 0x06020906 RID: 133382 RVA: 0x008D66D9 File Offset: 0x008D48D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Revert()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__Revert_NativeFunctionPtr, null);
		}

		// Token: 0x06020907 RID: 133383 RVA: 0x008D66ED File Offset: 0x008D48ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x06020908 RID: 133384 RVA: 0x008D6701 File Offset: 0x008D4901
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020909 RID: 133385 RVA: 0x008D6715 File Offset: 0x008D4915
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602090A RID: 133386 RVA: 0x008D672C File Offset: 0x008D492C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_StaticMesh_AborbForce_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StaticMesh_AborbForce_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StaticMesh_AborbForce_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StaticMesh_AborbForce_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602090B RID: 133387 RVA: 0x008D6774 File Offset: 0x008D4974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_StaticMesh_AborbForce_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StaticMesh_AborbForce_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StaticMesh_AborbForce_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StaticMesh_AborbForce_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602090C RID: 133388 RVA: 0x008D67BC File Offset: 0x008D49BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_StaticMesh_AborbForce_C.__EditorTick_FunctionParams* ptr = stackalloc BP_StaticMesh_AborbForce_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StaticMesh_AborbForce_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StaticMesh_AborbForce_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602090D RID: 133389 RVA: 0x008D6804 File Offset: 0x008D4A04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_StaticMesh_AborbForce_C.__EditorTick_FunctionParams* ptr = stackalloc BP_StaticMesh_AborbForce_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StaticMesh_AborbForce_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StaticMesh_AborbForce_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StaticMesh_AborbForce_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602090E RID: 133390 RVA: 0x008D684B File Offset: 0x008D4A4B
		protected BP_StaticMesh_AborbForce_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC77 RID: 64631
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_StaticMesh_AborbForce.BP_StaticMesh_AborbForce_C";

		// Token: 0x0400FC78 RID: 64632
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC79 RID: 64633
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC7A RID: 64634
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC7B RID: 64635
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC7C RID: 64636
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _StaticActors;

		// Token: 0x0400FC7D RID: 64637
		internal static int __PropertyOffset_3;

		// Token: 0x0400FC7E RID: 64638
		internal static int __PropertyOffset_4;

		// Token: 0x0400FC7F RID: 64639
		[Nullable(2)]
		private FKuroCurveFloat _Acceleration;

		// Token: 0x0400FC80 RID: 64640
		internal static int __PropertyOffset_5;

		// Token: 0x0400FC81 RID: 64641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _RuntimeActors;

		// Token: 0x0400FC82 RID: 64642
		internal static int __PropertyOffset_6;

		// Token: 0x0400FC83 RID: 64643
		[Nullable(2)]
		private TArray<FVector> _Speeds;

		// Token: 0x0400FC84 RID: 64644
		internal static int __PropertyOffset_7;

		// Token: 0x0400FC85 RID: 64645
		internal static int __PropertyOffset_8;

		// Token: 0x0400FC86 RID: 64646
		internal static int __PropertyOffset_9;

		// Token: 0x0400FC87 RID: 64647
		internal static int __PropertyOffset_10;

		// Token: 0x0400FC88 RID: 64648
		internal static int __PropertyOffset_11;

		// Token: 0x0400FC89 RID: 64649
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _StaticMeshesHidden;

		// Token: 0x0400FC8A RID: 64650
		internal static int __PropertyOffset_12;

		// Token: 0x0400FC8B RID: 64651
		[Nullable(2)]
		private TArray<float> _Masses;

		// Token: 0x0400FC8C RID: 64652
		internal static int __PropertyOffset_13;

		// Token: 0x0400FC8D RID: 64653
		private static IntPtr __CopyStaticMeshAndHide_NativeFunctionPtr;

		// Token: 0x0400FC8E RID: 64654
		private static IntPtr __Revert_NativeFunctionPtr;

		// Token: 0x0400FC8F RID: 64655
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400FC90 RID: 64656
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FC91 RID: 64657
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FC92 RID: 64658
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009BDB RID: 39899
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __CopyStaticMeshAndHide_FunctionParams
		{
			// Token: 0x0403126E RID: 201326
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0403126F RID: 201327
			[FieldOffset(8)]
			public IntPtr ActorAdded;
		}

		// Token: 0x02009BDC RID: 39900
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031270 RID: 201328
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BDD RID: 39901
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031271 RID: 201329
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
