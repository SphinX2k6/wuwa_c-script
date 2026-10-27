using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SandTrail
{
	// Token: 0x02003C20 RID: 15392
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_SandInteraction.BP_SandInteraction_C")]
	[UnrealStructLayout(2200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2200)]
	public class BP_SandInteraction_C : NinjaLive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602347B RID: 144507 RVA: 0x0091FA75 File Offset: 0x0091DC75
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SandInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_SandInteraction.BP_SandInteraction_C");
			}
			return BP_SandInteraction_C._ClassPtr;
		}

		// Token: 0x0602347C RID: 144508 RVA: 0x0091FA9C File Offset: 0x0091DC9C
		public BP_SandInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_SandInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602347D RID: 144509 RVA: 0x0091FAC4 File Offset: 0x0091DCC4
		[NullableContext(1)]
		public BP_SandInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SandInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x0602347E RID: 144510 RVA: 0x0091FAF7 File Offset: 0x0091DCF7
		// (set) Token: 0x0602347F RID: 144511 RVA: 0x0091FB0B File Offset: 0x0091DD0B
		[Nullable(2)]
		public unsafe UNiagaraComponent SandParticle1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandInteraction_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x06023480 RID: 144512 RVA: 0x0091FB20 File Offset: 0x0091DD20
		// (set) Token: 0x06023481 RID: 144513 RVA: 0x0091FB34 File Offset: 0x0091DD34
		[Nullable(2)]
		public unsafe UNiagaraComponent SandParticle
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandInteraction_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SandInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x06023482 RID: 144514 RVA: 0x0091FB49 File Offset: 0x0091DD49
		// (set) Token: 0x06023483 RID: 144515 RVA: 0x0091FB59 File Offset: 0x0091DD59
		public unsafe bool bMoto
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x06023484 RID: 144516 RVA: 0x0091FB6A File Offset: 0x0091DD6A
		// (set) Token: 0x06023485 RID: 144517 RVA: 0x0091FB7A File Offset: 0x0091DD7A
		public unsafe float OriginKuroTrailEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x06023486 RID: 144518 RVA: 0x0091FB8B File Offset: 0x0091DD8B
		// (set) Token: 0x06023487 RID: 144519 RVA: 0x0091FB9B File Offset: 0x0091DD9B
		public unsafe float CharacterVeloMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x06023488 RID: 144520 RVA: 0x0091FBAC File Offset: 0x0091DDAC
		// (set) Token: 0x06023489 RID: 144521 RVA: 0x0091FBBC File Offset: 0x0091DDBC
		public unsafe float CharacterGlobalBrush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x0602348A RID: 144522 RVA: 0x0091FBCD File Offset: 0x0091DDCD
		// (set) Token: 0x0602348B RID: 144523 RVA: 0x0091FBDD File Offset: 0x0091DDDD
		public unsafe bool CloseOriTrail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x0602348C RID: 144524 RVA: 0x0091FBEE File Offset: 0x0091DDEE
		// (set) Token: 0x0602348D RID: 144525 RVA: 0x0091FBFE File Offset: 0x0091DDFE
		public unsafe bool bPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x0602348E RID: 144526 RVA: 0x0091FC10 File Offset: 0x0091DE10
		// (set) Token: 0x0602348F RID: 144527 RVA: 0x0091FC49 File Offset: 0x0091DE49
		[Nullable(1)]
		public TSet<string> physicMaterialsSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._physicMaterialsSet) == null)
				{
					result = (this._physicMaterialsSet = new TSet<string>(base.NativePtr + (IntPtr)BP_SandInteraction_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.physicMaterialsSet.CopyAssign(value);
			}
		}

		// Token: 0x06023490 RID: 144528 RVA: 0x0091FC58 File Offset: 0x0091DE58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CheckPhysicMat([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> Array)
		{
			BP_SandInteraction_C.__CheckPhysicMat_FunctionParams* ptr = stackalloc BP_SandInteraction_C.__CheckPhysicMat_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_SandInteraction_C.__CheckPhysicMat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SandInteraction_C.__CheckPhysicMat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Array);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SandInteraction_C.__CheckPhysicMat_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Array);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SandInteraction_C.__CheckPhysicMat_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023491 RID: 144529 RVA: 0x0091FCD0 File Offset: 0x0091DED0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SandInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SandInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SandInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SandInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SandInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023492 RID: 144530 RVA: 0x0091FD18 File Offset: 0x0091DF18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SandInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SandInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SandInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SandInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SandInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023493 RID: 144531 RVA: 0x0091FD5F File Offset: 0x0091DF5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SandInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023494 RID: 144532 RVA: 0x0091FD73 File Offset: 0x0091DF73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SandInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023495 RID: 144533 RVA: 0x0091FD88 File Offset: 0x0091DF88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_SandInteraction_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SandInteraction_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SandInteraction_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SandInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SandInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023496 RID: 144534 RVA: 0x0091FDD4 File Offset: 0x0091DFD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_SandInteraction_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_SandInteraction_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SandInteraction_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SandInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SandInteraction_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023497 RID: 144535 RVA: 0x0091FE20 File Offset: 0x0091E020
		protected BP_SandInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011665 RID: 71269
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_SandInteraction.BP_SandInteraction_C";

		// Token: 0x04011666 RID: 71270
		private static IntPtr _ClassPtr;

		// Token: 0x04011667 RID: 71271
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011668 RID: 71272
		internal new static int __PropertyOffset_1;

		// Token: 0x04011669 RID: 71273
		internal new static int __PropertyOffset_2;

		// Token: 0x0401166A RID: 71274
		internal new static int __PropertyOffset_3;

		// Token: 0x0401166B RID: 71275
		internal new static int __PropertyOffset_4;

		// Token: 0x0401166C RID: 71276
		internal new static int __PropertyOffset_5;

		// Token: 0x0401166D RID: 71277
		internal new static int __PropertyOffset_6;

		// Token: 0x0401166E RID: 71278
		internal new static int __PropertyOffset_7;

		// Token: 0x0401166F RID: 71279
		internal new static int __PropertyOffset_8;

		// Token: 0x04011670 RID: 71280
		internal new static int __PropertyOffset_9;

		// Token: 0x04011671 RID: 71281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _physicMaterialsSet;

		// Token: 0x04011672 RID: 71282
		private static IntPtr __CheckPhysicMat_NativeFunctionPtr;

		// Token: 0x04011673 RID: 71283
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011674 RID: 71284
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011675 RID: 71285
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009E4A RID: 40522
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CheckPhysicMat_FunctionParams
		{
			// Token: 0x040316BC RID: 202428
			[FieldOffset(0)]
			public byte Array;
		}

		// Token: 0x02009E4B RID: 40523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316BD RID: 202429
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E4C RID: 40524
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040316BE RID: 202430
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
