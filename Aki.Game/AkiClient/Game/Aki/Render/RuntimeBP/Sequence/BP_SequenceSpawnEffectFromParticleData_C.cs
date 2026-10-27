using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003ADE RID: 15070
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_SequenceSpawnEffectFromParticleData.BP_SequenceSpawnEffectFromParticleData_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1132)]
	public class BP_SequenceSpawnEffectFromParticleData_C : AActor, IUnrealUObject, IUnrealObject, INiagaraParticleCallbackHandler, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060208CF RID: 133327 RVA: 0x008D5F40 File Offset: 0x008D4140
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceSpawnEffectFromParticleData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_SequenceSpawnEffectFromParticleData.BP_SequenceSpawnEffectFromParticleData_C");
			}
			return BP_SequenceSpawnEffectFromParticleData_C._ClassPtr;
		}

		// Token: 0x060208D0 RID: 133328 RVA: 0x008D5F64 File Offset: 0x008D4164
		int INiagaraParticleCallbackHandler.InterfaceOffset()
		{
			return BP_SequenceSpawnEffectFromParticleData_C.__InterfaceOffset_INiagaraParticleCallbackHandler;
		}

		// Token: 0x060208D1 RID: 133329 RVA: 0x008D5F6C File Offset: 0x008D416C
		public BP_SequenceSpawnEffectFromParticleData_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceSpawnEffectFromParticleData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208D2 RID: 133330 RVA: 0x008D5F94 File Offset: 0x008D4194
		[NullableContext(1)]
		public BP_SequenceSpawnEffectFromParticleData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceSpawnEffectFromParticleData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x060208D3 RID: 133331 RVA: 0x008D5FC7 File Offset: 0x008D41C7
		// (set) Token: 0x060208D4 RID: 133332 RVA: 0x008D5FDB File Offset: 0x008D41DB
		public unsafe UNiagaraComponent NiagaraSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x060208D5 RID: 133333 RVA: 0x008D5FF0 File Offset: 0x008D41F0
		// (set) Token: 0x060208D6 RID: 133334 RVA: 0x008D6004 File Offset: 0x008D4204
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x060208D7 RID: 133335 RVA: 0x008D601C File Offset: 0x008D421C
		// (set) Token: 0x060208D8 RID: 133336 RVA: 0x008D6055 File Offset: 0x008D4255
		[Nullable(1)]
		public TArray<int> EffectComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._EffectComponents) == null)
				{
					result = (this._EffectComponents = new TArray<int>(base.NativePtr + (IntPtr)BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EffectComponents.CopyAssign(value);
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x060208D9 RID: 133337 RVA: 0x008D6063 File Offset: 0x008D4263
		// (set) Token: 0x060208DA RID: 133338 RVA: 0x008D6077 File Offset: 0x008D4277
		public unsafe UNiagaraSystem SourceNiagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x060208DB RID: 133339 RVA: 0x008D608C File Offset: 0x008D428C
		// (set) Token: 0x060208DC RID: 133340 RVA: 0x008D60A0 File Offset: 0x008D42A0
		public unsafe UNiagaraSystem TargetNiagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x060208DD RID: 133341 RVA: 0x008D60B8 File Offset: 0x008D42B8
		// (set) Token: 0x060208DE RID: 133342 RVA: 0x008D60F1 File Offset: 0x008D42F1
		[Nullable(1)]
		public TArray<ANiagaraActor> Actors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ANiagaraActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<ANiagaraActor>(base.NativePtr + (IntPtr)BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x060208DF RID: 133343 RVA: 0x008D60FF File Offset: 0x008D42FF
		// (set) Token: 0x060208E0 RID: 133344 RVA: 0x008D6113 File Offset: 0x008D4313
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceSpawnEffectFromParticleData_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x060208E1 RID: 133345 RVA: 0x008D6128 File Offset: 0x008D4328
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReceiveParticleData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060208E2 RID: 133346 RVA: 0x008D61B8 File Offset: 0x008D43B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveParticleData_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060208E3 RID: 133347 RVA: 0x008D6247 File Offset: 0x008D4447
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceSpawnEffectFromParticleData_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060208E4 RID: 133348 RVA: 0x008D625B File Offset: 0x008D445B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceSpawnEffectFromParticleData_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060208E5 RID: 133349 RVA: 0x008D6270 File Offset: 0x008D4470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208E6 RID: 133350 RVA: 0x008D62BC File Offset: 0x008D44BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceSpawnEffectFromParticleData_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060208E7 RID: 133351 RVA: 0x008D6308 File Offset: 0x008D4508
		protected BP_SequenceSpawnEffectFromParticleData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC67 RID: 64615
		internal static int __InterfaceOffset_INiagaraParticleCallbackHandler;

		// Token: 0x0400FC68 RID: 64616
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_SequenceSpawnEffectFromParticleData.BP_SequenceSpawnEffectFromParticleData_C";

		// Token: 0x0400FC69 RID: 64617
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC6A RID: 64618
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC6B RID: 64619
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC6C RID: 64620
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC6D RID: 64621
		internal static int __PropertyOffset_3;

		// Token: 0x0400FC6E RID: 64622
		private TArray<int> _EffectComponents;

		// Token: 0x0400FC6F RID: 64623
		internal static int __PropertyOffset_4;

		// Token: 0x0400FC70 RID: 64624
		internal static int __PropertyOffset_5;

		// Token: 0x0400FC71 RID: 64625
		internal static int __PropertyOffset_6;

		// Token: 0x0400FC72 RID: 64626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ANiagaraActor> _Actors;

		// Token: 0x0400FC73 RID: 64627
		internal static int __PropertyOffset_7;

		// Token: 0x0400FC74 RID: 64628
		private static IntPtr __ReceiveParticleData_NativeFunctionPtr;

		// Token: 0x0400FC75 RID: 64629
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC76 RID: 64630
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009BD9 RID: 39897
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveParticleData_FunctionParams
		{
			// Token: 0x0403126B RID: 201323
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x0403126C RID: 201324
			[FieldOffset(16)]
			public IntPtr NiagaraSystem;
		}

		// Token: 0x02009BDA RID: 39898
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403126D RID: 201325
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
