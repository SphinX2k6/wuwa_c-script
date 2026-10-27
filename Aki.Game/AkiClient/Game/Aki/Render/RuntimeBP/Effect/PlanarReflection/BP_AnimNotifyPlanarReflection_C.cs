using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.PlanarReflection
{
	// Token: 0x02003DD3 RID: 15827
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_AnimNotifyPlanarReflection.BP_AnimNotifyPlanarReflection_C")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class BP_AnimNotifyPlanarReflection_C : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027787 RID: 161671 RVA: 0x0099233D File Offset: 0x0099053D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AnimNotifyPlanarReflection_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_AnimNotifyPlanarReflection.BP_AnimNotifyPlanarReflection_C");
			}
			return BP_AnimNotifyPlanarReflection_C._ClassPtr;
		}

		// Token: 0x06027788 RID: 161672 RVA: 0x00992364 File Offset: 0x00990564
		public BP_AnimNotifyPlanarReflection_C() : this(BuiltinUtils.AllocNativeUObject(BP_AnimNotifyPlanarReflection_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027789 RID: 161673 RVA: 0x0099238C File Offset: 0x0099058C
		public BP_AnimNotifyPlanarReflection_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AnimNotifyPlanarReflection_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005858 RID: 22616
		// (get) Token: 0x0602778A RID: 161674 RVA: 0x009923BF File Offset: 0x009905BF
		// (set) Token: 0x0602778B RID: 161675 RVA: 0x009923D3 File Offset: 0x009905D3
		public unsafe FTransform Spawn_Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimNotifyPlanarReflection_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimNotifyPlanarReflection_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005859 RID: 22617
		// (get) Token: 0x0602778C RID: 161676 RVA: 0x009923E8 File Offset: 0x009905E8
		// (set) Token: 0x0602778D RID: 161677 RVA: 0x009923FC File Offset: 0x009905FC
		public unsafe FName Socket_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AnimNotifyPlanarReflection_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AnimNotifyPlanarReflection_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700585A RID: 22618
		// (get) Token: 0x0602778E RID: 161678 RVA: 0x00992414 File Offset: 0x00990614
		// (set) Token: 0x0602778F RID: 161679 RVA: 0x0099244D File Offset: 0x0099064D
		public TMap<FName, TSoftObjectPtr<BP_EffectPlanarReflection_Base_C>> PlanarReflection
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, TSoftObjectPtr<BP_EffectPlanarReflection_Base_C>> result;
				if ((result = this._PlanarReflection) == null)
				{
					result = (this._PlanarReflection = new TMap<FName, TSoftObjectPtr<BP_EffectPlanarReflection_Base_C>>(base.NativePtr + (IntPtr)BP_AnimNotifyPlanarReflection_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.PlanarReflection.CopyAssign(value);
			}
		}

		// Token: 0x1700585B RID: 22619
		// (get) Token: 0x06027790 RID: 161680 RVA: 0x0099245C File Offset: 0x0099065C
		// (set) Token: 0x06027791 RID: 161681 RVA: 0x00992495 File Offset: 0x00990695
		public FKuroCurveFloat OpacityCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._OpacityCurve) == null)
				{
					result = (this._OpacityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_AnimNotifyPlanarReflection_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_AnimNotifyPlanarReflection_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027792 RID: 161682 RVA: 0x009924B8 File Offset: 0x009906B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_FunctionParams* ptr = stackalloc BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->FrameDeltaTime = FrameDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06027793 RID: 161683 RVA: 0x00992534 File Offset: 0x00990734
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_FunctionParams* ptr = stackalloc BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->FrameDeltaTime = FrameDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimNotifyPlanarReflection_C.__K2_NotifyTick_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06027794 RID: 161684 RVA: 0x009925B0 File Offset: 0x009907B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_FunctionParams* ptr = stackalloc BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->TotalDuration = TotalDuration;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06027795 RID: 161685 RVA: 0x0099262C File Offset: 0x0099082C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_FunctionParams* ptr = stackalloc BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->TotalDuration = TotalDuration;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimNotifyPlanarReflection_C.__K2_NotifyBegin_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06027796 RID: 161686 RVA: 0x009926A8 File Offset: 0x009908A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_FunctionParams* ptr = stackalloc BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06027797 RID: 161687 RVA: 0x0099271C File Offset: 0x0099091C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_FunctionParams* ptr = stackalloc BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimNotifyPlanarReflection_C.__K2_NotifyEnd_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06027798 RID: 161688 RVA: 0x00992791 File Offset: 0x00990991
		protected BP_AnimNotifyPlanarReflection_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F0A RID: 81674
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/PlanarReflection/BP_AnimNotifyPlanarReflection.BP_AnimNotifyPlanarReflection_C";

		// Token: 0x04013F0B RID: 81675
		private static IntPtr _ClassPtr;

		// Token: 0x04013F0C RID: 81676
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F0D RID: 81677
		internal static int __PropertyOffset_0;

		// Token: 0x04013F0E RID: 81678
		internal static int __PropertyOffset_1;

		// Token: 0x04013F0F RID: 81679
		internal static int __PropertyOffset_2;

		// Token: 0x04013F10 RID: 81680
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FName, TSoftObjectPtr<BP_EffectPlanarReflection_Base_C>> _PlanarReflection;

		// Token: 0x04013F11 RID: 81681
		internal static int __PropertyOffset_3;

		// Token: 0x04013F12 RID: 81682
		[Nullable(2)]
		private FKuroCurveFloat _OpacityCurve;

		// Token: 0x04013F13 RID: 81683
		private static IntPtr __K2_NotifyTick_NativeFunctionPtr;

		// Token: 0x04013F14 RID: 81684
		private static IntPtr __K2_NotifyBegin_NativeFunctionPtr;

		// Token: 0x04013F15 RID: 81685
		private static IntPtr __K2_NotifyEnd_NativeFunctionPtr;

		// Token: 0x0200A239 RID: 41529
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected new ref struct __K2_NotifyTick_FunctionParams
		{
			// Token: 0x04031EBE RID: 204478
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04031EBF RID: 204479
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04031EC0 RID: 204480
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x04031EC1 RID: 204481
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x0200A23A RID: 41530
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected new ref struct __K2_NotifyBegin_FunctionParams
		{
			// Token: 0x04031EC2 RID: 204482
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04031EC3 RID: 204483
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04031EC4 RID: 204484
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x04031EC5 RID: 204485
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x0200A23B RID: 41531
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected new ref struct __K2_NotifyEnd_FunctionParams
		{
			// Token: 0x04031EC6 RID: 204486
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04031EC7 RID: 204487
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04031EC8 RID: 204488
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
