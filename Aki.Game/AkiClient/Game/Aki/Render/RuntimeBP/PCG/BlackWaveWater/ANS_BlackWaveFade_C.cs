using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BlackWaveWater
{
	// Token: 0x02003CCF RID: 15567
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BlackWaveWater/ANS_BlackWaveFade.ANS_BlackWaveFade_C")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class ANS_BlackWaveFade_C : UAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E6A RID: 151146 RVA: 0x0094B5B4 File Offset: 0x009497B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ANS_BlackWaveFade_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BlackWaveWater/ANS_BlackWaveFade.ANS_BlackWaveFade_C");
			}
			return ANS_BlackWaveFade_C._ClassPtr;
		}

		// Token: 0x06024E6B RID: 151147 RVA: 0x0094B5D8 File Offset: 0x009497D8
		public ANS_BlackWaveFade_C() : this(BuiltinUtils.AllocNativeUObject(ANS_BlackWaveFade_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E6C RID: 151148 RVA: 0x0094B600 File Offset: 0x00949800
		[NullableContext(1)]
		public ANS_BlackWaveFade_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANS_BlackWaveFade_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049C4 RID: 18884
		// (get) Token: 0x06024E6D RID: 151149 RVA: 0x0094B633 File Offset: 0x00949833
		// (set) Token: 0x06024E6E RID: 151150 RVA: 0x0094B643 File Offset: 0x00949843
		public unsafe float LerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170049C5 RID: 18885
		// (get) Token: 0x06024E6F RID: 151151 RVA: 0x0094B654 File Offset: 0x00949854
		// (set) Token: 0x06024E70 RID: 151152 RVA: 0x0094B664 File Offset: 0x00949864
		public unsafe bool bUseMeshPositionAsFadeCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049C6 RID: 18886
		// (get) Token: 0x06024E71 RID: 151153 RVA: 0x0094B675 File Offset: 0x00949875
		// (set) Token: 0x06024E72 RID: 151154 RVA: 0x0094B689 File Offset: 0x00949889
		public unsafe FVectorDouble FadePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170049C7 RID: 18887
		// (get) Token: 0x06024E73 RID: 151155 RVA: 0x0094B6A0 File Offset: 0x009498A0
		// (set) Token: 0x06024E74 RID: 151156 RVA: 0x0094B6D9 File Offset: 0x009498D9
		[Nullable(1)]
		public FKuroCurveFloat FadeOpacityCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FadeOpacityCurve) == null)
				{
					result = (this._FadeOpacityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170049C8 RID: 18888
		// (get) Token: 0x06024E75 RID: 151157 RVA: 0x0094B6FC File Offset: 0x009498FC
		// (set) Token: 0x06024E76 RID: 151158 RVA: 0x0094B735 File Offset: 0x00949935
		[Nullable(1)]
		public FKuroCurveFloat FadeRadiusCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FadeRadiusCurve) == null)
				{
					result = (this._FadeRadiusCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)ANS_BlackWaveFade_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06024E77 RID: 151159 RVA: 0x0094B758 File Offset: 0x00949958
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool Received_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			ANS_BlackWaveFade_C.__Received_NotifyEnd_FunctionParams* ptr = stackalloc ANS_BlackWaveFade_C.__Received_NotifyEnd_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(ANS_BlackWaveFade_C.__Received_NotifyEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_BlackWaveFade_C.__Received_NotifyEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_BlackWaveFade_C.__Received_NotifyEnd_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06024E78 RID: 151160 RVA: 0x0094B7CC File Offset: 0x009499CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool Received_NotifyEnd_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			ANS_BlackWaveFade_C.__Received_NotifyEnd_FunctionParams* ptr = stackalloc ANS_BlackWaveFade_C.__Received_NotifyEnd_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(ANS_BlackWaveFade_C.__Received_NotifyEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_BlackWaveFade_C.__Received_NotifyEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_BlackWaveFade_C.__Received_NotifyEnd_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06024E79 RID: 151161 RVA: 0x0094B840 File Offset: 0x00949A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InitParams(UObject WorldContextObject)
		{
			ANS_BlackWaveFade_C.__InitParams_FunctionParams* ptr = stackalloc ANS_BlackWaveFade_C.__InitParams_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ANS_BlackWaveFade_C.__InitParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_BlackWaveFade_C.__InitParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_BlackWaveFade_C.__InitParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024E7A RID: 151162 RVA: 0x0094B898 File Offset: 0x00949A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool Received_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			ANS_BlackWaveFade_C.__Received_NotifyBegin_FunctionParams* ptr = stackalloc ANS_BlackWaveFade_C.__Received_NotifyBegin_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(ANS_BlackWaveFade_C.__Received_NotifyBegin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_BlackWaveFade_C.__Received_NotifyBegin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->TotalDuration = TotalDuration;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_BlackWaveFade_C.__Received_NotifyBegin_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06024E7B RID: 151163 RVA: 0x0094B910 File Offset: 0x00949B10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool Received_NotifyBegin_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			ANS_BlackWaveFade_C.__Received_NotifyBegin_FunctionParams* ptr = stackalloc ANS_BlackWaveFade_C.__Received_NotifyBegin_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(ANS_BlackWaveFade_C.__Received_NotifyBegin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_BlackWaveFade_C.__Received_NotifyBegin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->TotalDuration = TotalDuration;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_BlackWaveFade_C.__Received_NotifyBegin_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06024E7C RID: 151164 RVA: 0x0094B98C File Offset: 0x00949B8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool Received_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			ANS_BlackWaveFade_C.__Received_NotifyTick_FunctionParams* ptr = stackalloc ANS_BlackWaveFade_C.__Received_NotifyTick_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(ANS_BlackWaveFade_C.__Received_NotifyTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_BlackWaveFade_C.__Received_NotifyTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->FrameDeltaTime = FrameDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ANS_BlackWaveFade_C.__Received_NotifyTick_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06024E7D RID: 151165 RVA: 0x0094BA04 File Offset: 0x00949C04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool Received_NotifyTick_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			ANS_BlackWaveFade_C.__Received_NotifyTick_FunctionParams* ptr = stackalloc ANS_BlackWaveFade_C.__Received_NotifyTick_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(ANS_BlackWaveFade_C.__Received_NotifyTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ANS_BlackWaveFade_C.__Received_NotifyTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			ptr->FrameDeltaTime = FrameDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ANS_BlackWaveFade_C.__Received_NotifyTick_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06024E7E RID: 151166 RVA: 0x0094BA7D File Offset: 0x00949C7D
		protected ANS_BlackWaveFade_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012587 RID: 75143
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BlackWaveWater/ANS_BlackWaveFade.ANS_BlackWaveFade_C";

		// Token: 0x04012588 RID: 75144
		private static IntPtr _ClassPtr;

		// Token: 0x04012589 RID: 75145
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401258A RID: 75146
		internal static int __PropertyOffset_0;

		// Token: 0x0401258B RID: 75147
		internal static int __PropertyOffset_1;

		// Token: 0x0401258C RID: 75148
		internal static int __PropertyOffset_2;

		// Token: 0x0401258D RID: 75149
		internal static int __PropertyOffset_3;

		// Token: 0x0401258E RID: 75150
		private FKuroCurveFloat _FadeOpacityCurve;

		// Token: 0x0401258F RID: 75151
		internal static int __PropertyOffset_4;

		// Token: 0x04012590 RID: 75152
		private FKuroCurveFloat _FadeRadiusCurve;

		// Token: 0x04012591 RID: 75153
		private static IntPtr __Received_NotifyEnd_NativeFunctionPtr;

		// Token: 0x04012592 RID: 75154
		private static IntPtr __InitParams_NativeFunctionPtr;

		// Token: 0x04012593 RID: 75155
		private static IntPtr __Received_NotifyBegin_NativeFunctionPtr;

		// Token: 0x04012594 RID: 75156
		private static IntPtr __Received_NotifyTick_NativeFunctionPtr;

		// Token: 0x02009F84 RID: 40836
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected new ref struct __Received_NotifyEnd_FunctionParams
		{
			// Token: 0x0403199D RID: 203165
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x0403199E RID: 203166
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x0403199F RID: 203167
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02009F85 RID: 40837
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InitParams_FunctionParams
		{
			// Token: 0x040319A0 RID: 203168
			[FieldOffset(0)]
			public IntPtr WorldContextObject;
		}

		// Token: 0x02009F86 RID: 40838
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected new ref struct __Received_NotifyBegin_FunctionParams
		{
			// Token: 0x040319A1 RID: 203169
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040319A2 RID: 203170
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040319A3 RID: 203171
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x040319A4 RID: 203172
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02009F87 RID: 40839
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected new ref struct __Received_NotifyTick_FunctionParams
		{
			// Token: 0x040319A5 RID: 203173
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040319A6 RID: 203174
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040319A7 RID: 203175
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x040319A8 RID: 203176
			[FieldOffset(20)]
			public bool __Result;
		}
	}
}
