using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneObjFloat
{
	// Token: 0x02003C15 RID: 15381
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneObjFloat/BP_SceneObjFloat.BP_SceneObjFloat_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_SceneObjFloat_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023329 RID: 144169 RVA: 0x0091CFCC File Offset: 0x0091B1CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneObjFloat_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneObjFloat/BP_SceneObjFloat.BP_SceneObjFloat_C");
			}
			return BP_SceneObjFloat_C._ClassPtr;
		}

		// Token: 0x0602332A RID: 144170 RVA: 0x0091CFF0 File Offset: 0x0091B1F0
		public BP_SceneObjFloat_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneObjFloat_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602332B RID: 144171 RVA: 0x0091D018 File Offset: 0x0091B218
		[NullableContext(1)]
		public BP_SceneObjFloat_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneObjFloat_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x0602332C RID: 144172 RVA: 0x0091D04B File Offset: 0x0091B24B
		// (set) Token: 0x0602332D RID: 144173 RVA: 0x0091D05F File Offset: 0x0091B25F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneObjFloat_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneObjFloat_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x0602332E RID: 144174 RVA: 0x0091D074 File Offset: 0x0091B274
		// (set) Token: 0x0602332F RID: 144175 RVA: 0x0091D088 File Offset: 0x0091B288
		public unsafe AActor TraceActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneObjFloat_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneObjFloat_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x06023330 RID: 144176 RVA: 0x0091D09D File Offset: 0x0091B29D
		// (set) Token: 0x06023331 RID: 144177 RVA: 0x0091D0B1 File Offset: 0x0091B2B1
		public unsafe UMaterialInterface Mat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneObjFloat_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneObjFloat_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x06023332 RID: 144178 RVA: 0x0091D0C6 File Offset: 0x0091B2C6
		// (set) Token: 0x06023333 RID: 144179 RVA: 0x0091D0D6 File Offset: 0x0091B2D6
		public unsafe float FLerpMinDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneObjFloat_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneObjFloat_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x06023334 RID: 144180 RVA: 0x0091D0E8 File Offset: 0x0091B2E8
		// (set) Token: 0x06023335 RID: 144181 RVA: 0x0091D121 File Offset: 0x0091B321
		[Nullable(1)]
		public TArray<AStaticMeshActor> SceneObjFloat
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._SceneObjFloat) == null)
				{
					result = (this._SceneObjFloat = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_SceneObjFloat_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SceneObjFloat.CopyAssign(value);
			}
		}

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x06023336 RID: 144182 RVA: 0x0091D12F File Offset: 0x0091B32F
		// (set) Token: 0x06023337 RID: 144183 RVA: 0x0091D143 File Offset: 0x0091B343
		public unsafe FVectorDouble Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneObjFloat_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneObjFloat_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06023338 RID: 144184 RVA: 0x0091D158 File Offset: 0x0091B358
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 收集ActorTag为SceneFloat的漂浮物()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneObjFloat_C.__收集ActorTag为SceneFloat的漂浮物_NativeFunctionPtr, null);
		}

		// Token: 0x06023339 RID: 144185 RVA: 0x0091D16C File Offset: 0x0091B36C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneObjFloat_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602333A RID: 144186 RVA: 0x0091D180 File Offset: 0x0091B380
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneObjFloat_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602333B RID: 144187 RVA: 0x0091D198 File Offset: 0x0091B398
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602333C RID: 144188 RVA: 0x0091D1F0 File Offset: 0x0091B3F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneObjFloat_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602333D RID: 144189 RVA: 0x0091D248 File Offset: 0x0091B448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SceneObjFloat_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneObjFloat_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneObjFloat_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneObjFloat_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneObjFloat_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602333E RID: 144190 RVA: 0x0091D290 File Offset: 0x0091B490
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SceneObjFloat_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneObjFloat_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneObjFloat_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneObjFloat_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneObjFloat_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602333F RID: 144191 RVA: 0x0091D2D7 File Offset: 0x0091B4D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneObjFloat_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06023340 RID: 144192 RVA: 0x0091D2EB File Offset: 0x0091B4EB
		protected BP_SceneObjFloat_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011597 RID: 71063
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneObjFloat/BP_SceneObjFloat.BP_SceneObjFloat_C";

		// Token: 0x04011598 RID: 71064
		private static IntPtr _ClassPtr;

		// Token: 0x04011599 RID: 71065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401159A RID: 71066
		internal static int __PropertyOffset_1;

		// Token: 0x0401159B RID: 71067
		internal static int __PropertyOffset_2;

		// Token: 0x0401159C RID: 71068
		internal static int __PropertyOffset_3;

		// Token: 0x0401159D RID: 71069
		internal static int __PropertyOffset_4;

		// Token: 0x0401159E RID: 71070
		internal static int __PropertyOffset_5;

		// Token: 0x0401159F RID: 71071
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _SceneObjFloat;

		// Token: 0x040115A0 RID: 71072
		internal static int __PropertyOffset_6;

		// Token: 0x040115A1 RID: 71073
		private static IntPtr __收集ActorTag为SceneFloat的漂浮物_NativeFunctionPtr;

		// Token: 0x040115A2 RID: 71074
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040115A3 RID: 71075
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x040115A4 RID: 71076
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040115A5 RID: 71077
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E26 RID: 40486
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x04031671 RID: 202353
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02009E27 RID: 40487
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031672 RID: 202354
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
