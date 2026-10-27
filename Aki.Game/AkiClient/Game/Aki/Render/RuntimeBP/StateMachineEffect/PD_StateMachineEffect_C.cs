using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003AC7 RID: 15047
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/PD_StateMachineEffect.PD_StateMachineEffect_C")]
	[UnrealStructLayout(1824, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1824)]
	public class PD_StateMachineEffect_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602067F RID: 132735 RVA: 0x008D1C4D File Offset: 0x008CFE4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_StateMachineEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/StateMachineEffect/PD_StateMachineEffect.PD_StateMachineEffect_C");
			}
			return PD_StateMachineEffect_C._ClassPtr;
		}

		// Token: 0x06020680 RID: 132736 RVA: 0x008D1C74 File Offset: 0x008CFE74
		public PD_StateMachineEffect_C() : this(BuiltinUtils.AllocNativeUObject(PD_StateMachineEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020681 RID: 132737 RVA: 0x008D1C9C File Offset: 0x008CFE9C
		public PD_StateMachineEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_StateMachineEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x06020682 RID: 132738 RVA: 0x008D1CD0 File Offset: 0x008CFED0
		// (set) Token: 0x06020683 RID: 132739 RVA: 0x008D1D09 File Offset: 0x008CFF09
		public SEffectStateInfo State1
		{
			get
			{
				base.FastCheckIsValid();
				SEffectStateInfo result;
				if ((result = this._State1) == null)
				{
					result = (this._State1 = new SEffectStateInfo(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateInfo.StaticStruct(), base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x06020684 RID: 132740 RVA: 0x008D1D2C File Offset: 0x008CFF2C
		// (set) Token: 0x06020685 RID: 132741 RVA: 0x008D1D65 File Offset: 0x008CFF65
		public SEffectStateInfo State2
		{
			get
			{
				base.FastCheckIsValid();
				SEffectStateInfo result;
				if ((result = this._State2) == null)
				{
					result = (this._State2 = new SEffectStateInfo(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateInfo.StaticStruct(), base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x06020686 RID: 132742 RVA: 0x008D1D88 File Offset: 0x008CFF88
		// (set) Token: 0x06020687 RID: 132743 RVA: 0x008D1DC1 File Offset: 0x008CFFC1
		public SEffectStateInfo State3
		{
			get
			{
				base.FastCheckIsValid();
				SEffectStateInfo result;
				if ((result = this._State3) == null)
				{
					result = (this._State3 = new SEffectStateInfo(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateInfo.StaticStruct(), base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x06020688 RID: 132744 RVA: 0x008D1DE4 File Offset: 0x008CFFE4
		// (set) Token: 0x06020689 RID: 132745 RVA: 0x008D1E1D File Offset: 0x008D001D
		public SEffectStateInfo State4
		{
			get
			{
				base.FastCheckIsValid();
				SEffectStateInfo result;
				if ((result = this._State4) == null)
				{
					result = (this._State4 = new SEffectStateInfo(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateInfo.StaticStruct(), base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0602068A RID: 132746 RVA: 0x008D1E40 File Offset: 0x008D0040
		// (set) Token: 0x0602068B RID: 132747 RVA: 0x008D1E79 File Offset: 0x008D0079
		public SEffectStateInfo State5
		{
			get
			{
				base.FastCheckIsValid();
				SEffectStateInfo result;
				if ((result = this._State5) == null)
				{
					result = (this._State5 = new SEffectStateInfo(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateInfo.StaticStruct(), base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x0602068C RID: 132748 RVA: 0x008D1E9C File Offset: 0x008D009C
		// (set) Token: 0x0602068D RID: 132749 RVA: 0x008D1ED5 File Offset: 0x008D00D5
		public TArray<UStaticMesh> StaticMeshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._StaticMeshes) == null)
				{
					result = (this._StaticMeshes = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshes.CopyAssign(value);
			}
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0602068E RID: 132750 RVA: 0x008D1EE4 File Offset: 0x008D00E4
		// (set) Token: 0x0602068F RID: 132751 RVA: 0x008D1F1D File Offset: 0x008D011D
		public TArray<UNiagaraSystem> NiagaraSystems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraSystem> result;
				if ((result = this._NiagaraSystems) == null)
				{
					result = (this._NiagaraSystems = new TArray<UNiagaraSystem>(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.NiagaraSystems.CopyAssign(value);
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x06020690 RID: 132752 RVA: 0x008D1F2C File Offset: 0x008D012C
		// (set) Token: 0x06020691 RID: 132753 RVA: 0x008D1F65 File Offset: 0x008D0165
		public TArray<FTransform> StaticMeshTransform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._StaticMeshTransform) == null)
				{
					result = (this._StaticMeshTransform = new TArray<FTransform>(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshTransform.CopyAssign(value);
			}
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x06020692 RID: 132754 RVA: 0x008D1F74 File Offset: 0x008D0174
		// (set) Token: 0x06020693 RID: 132755 RVA: 0x008D1FAD File Offset: 0x008D01AD
		public TArray<FTransform> NiagaraParticleTransform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._NiagaraParticleTransform) == null)
				{
					result = (this._NiagaraParticleTransform = new TArray<FTransform>(base.NativePtr + (IntPtr)PD_StateMachineEffect_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.NiagaraParticleTransform.CopyAssign(value);
			}
		}

		// Token: 0x06020694 RID: 132756 RVA: 0x008D1FBC File Offset: 0x008D01BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetStateInfo(EEffectState InputState, ref SEffectStateInfo Ret)
		{
			PD_StateMachineEffect_C.__GetStateInfo_FunctionParams* ptr = stackalloc PD_StateMachineEffect_C.__GetStateInfo_FunctionParams[(UIntPtr)367] + 15L / (long)sizeof(PD_StateMachineEffect_C.__GetStateInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PD_StateMachineEffect_C.__GetStateInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputState = InputState;
			if (Ret != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateInfo.StaticStruct(), &ptr->Ret, Ret.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_StateMachineEffect_C.__GetStateInfo_NativeFunctionPtr, (void*)ptr);
			if (Ret != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectStateInfo.StaticStruct(), Ret.NativePtr, &ptr->Ret, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(PD_StateMachineEffect_C.__GetStateInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020695 RID: 132757 RVA: 0x008D2063 File Offset: 0x008D0263
		protected PD_StateMachineEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB07 RID: 64263
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/PD_StateMachineEffect.PD_StateMachineEffect_C";

		// Token: 0x0400FB08 RID: 64264
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB09 RID: 64265
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB0A RID: 64266
		internal static int __PropertyOffset_0;

		// Token: 0x0400FB0B RID: 64267
		[Nullable(2)]
		private SEffectStateInfo _State1;

		// Token: 0x0400FB0C RID: 64268
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB0D RID: 64269
		[Nullable(2)]
		private SEffectStateInfo _State2;

		// Token: 0x0400FB0E RID: 64270
		internal static int __PropertyOffset_2;

		// Token: 0x0400FB0F RID: 64271
		[Nullable(2)]
		private SEffectStateInfo _State3;

		// Token: 0x0400FB10 RID: 64272
		internal static int __PropertyOffset_3;

		// Token: 0x0400FB11 RID: 64273
		[Nullable(2)]
		private SEffectStateInfo _State4;

		// Token: 0x0400FB12 RID: 64274
		internal static int __PropertyOffset_4;

		// Token: 0x0400FB13 RID: 64275
		[Nullable(2)]
		private SEffectStateInfo _State5;

		// Token: 0x0400FB14 RID: 64276
		internal static int __PropertyOffset_5;

		// Token: 0x0400FB15 RID: 64277
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _StaticMeshes;

		// Token: 0x0400FB16 RID: 64278
		internal static int __PropertyOffset_6;

		// Token: 0x0400FB17 RID: 64279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSystem> _NiagaraSystems;

		// Token: 0x0400FB18 RID: 64280
		internal static int __PropertyOffset_7;

		// Token: 0x0400FB19 RID: 64281
		[Nullable(2)]
		private TArray<FTransform> _StaticMeshTransform;

		// Token: 0x0400FB1A RID: 64282
		internal static int __PropertyOffset_8;

		// Token: 0x0400FB1B RID: 64283
		[Nullable(2)]
		private TArray<FTransform> _NiagaraParticleTransform;

		// Token: 0x0400FB1C RID: 64284
		private static IntPtr __GetStateInfo_NativeFunctionPtr;

		// Token: 0x02009BB4 RID: 39860
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __GetStateInfo_FunctionParams
		{
			// Token: 0x04031231 RID: 201265
			[FieldOffset(0)]
			public TEnumAsByte<EEffectState> InputState;

			// Token: 0x04031232 RID: 201266
			[FieldOffset(8)]
			public byte Ret;
		}
	}
}
