using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004433 RID: 17459
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_Wwise_AudioSpectrum.BP_Wwise_AudioSpectrum_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_Wwise_AudioSpectrum_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D302 RID: 185090 RVA: 0x00A359B5 File Offset: 0x00A33BB5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Wwise_AudioSpectrum_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_Wwise_AudioSpectrum.BP_Wwise_AudioSpectrum_C");
			}
			return BP_Wwise_AudioSpectrum_C._ClassPtr;
		}

		// Token: 0x0602D303 RID: 185091 RVA: 0x00A359DC File Offset: 0x00A33BDC
		public BP_Wwise_AudioSpectrum_C() : this(BuiltinUtils.AllocNativeUObject(BP_Wwise_AudioSpectrum_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D304 RID: 185092 RVA: 0x00A35A04 File Offset: 0x00A33C04
		[NullableContext(1)]
		public BP_Wwise_AudioSpectrum_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Wwise_AudioSpectrum_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007272 RID: 29298
		// (get) Token: 0x0602D305 RID: 185093 RVA: 0x00A35A37 File Offset: 0x00A33C37
		// (set) Token: 0x0602D306 RID: 185094 RVA: 0x00A35A4B File Offset: 0x00A33C4B
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17007273 RID: 29299
		// (get) Token: 0x0602D307 RID: 185095 RVA: 0x00A35A60 File Offset: 0x00A33C60
		// (set) Token: 0x0602D308 RID: 185096 RVA: 0x00A35A74 File Offset: 0x00A33C74
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17007274 RID: 29300
		// (get) Token: 0x0602D309 RID: 185097 RVA: 0x00A35A89 File Offset: 0x00A33C89
		// (set) Token: 0x0602D30A RID: 185098 RVA: 0x00A35A9D File Offset: 0x00A33C9D
		public unsafe UConstantQNRT Synesthesia_Analysis
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UConstantQNRT>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17007275 RID: 29301
		// (get) Token: 0x0602D30B RID: 185099 RVA: 0x00A35AB4 File Offset: 0x00A33CB4
		// (set) Token: 0x0602D30C RID: 185100 RVA: 0x00A35AED File Offset: 0x00A33CED
		[Nullable(1)]
		public TArray<float> Frequency_Band_Strengths
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Frequency_Band_Strengths) == null)
				{
					result = (this._Frequency_Band_Strengths = new TArray<float>(base.NativePtr + (IntPtr)BP_Wwise_AudioSpectrum_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Frequency_Band_Strengths.CopyAssign(value);
			}
		}

		// Token: 0x17007276 RID: 29302
		// (get) Token: 0x0602D30D RID: 185101 RVA: 0x00A35AFC File Offset: 0x00A33CFC
		// (set) Token: 0x0602D30E RID: 185102 RVA: 0x00A35B35 File Offset: 0x00A33D35
		[Nullable(1)]
		public TArray<float> OutputArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._OutputArray) == null)
				{
					result = (this._OutputArray = new TArray<float>(base.NativePtr + (IntPtr)BP_Wwise_AudioSpectrum_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OutputArray.CopyAssign(value);
			}
		}

		// Token: 0x17007277 RID: 29303
		// (get) Token: 0x0602D30F RID: 185103 RVA: 0x00A35B43 File Offset: 0x00A33D43
		// (set) Token: 0x0602D310 RID: 185104 RVA: 0x00A35B57 File Offset: 0x00A33D57
		public unsafe UAkAudioEvent AkResource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17007278 RID: 29304
		// (get) Token: 0x0602D311 RID: 185105 RVA: 0x00A35B6C File Offset: 0x00A33D6C
		// (set) Token: 0x0602D312 RID: 185106 RVA: 0x00A35B80 File Offset: 0x00A33D80
		public unsafe UAkAudioEvent Ak_Event
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x0602D313 RID: 185107 RVA: 0x00A35B98 File Offset: 0x00A33D98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void NotifyAnalyser(UAkComponent Ak, UAkAudioEvent akEvent)
		{
			BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_FunctionParams* ptr = stackalloc BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ak = ((Ak != null) ? Ak.NativePtr : IntPtr.Zero);
			ptr->akEvent = ((akEvent != null) ? akEvent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D314 RID: 185108 RVA: 0x00A35C04 File Offset: 0x00A33E04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Wwise_AudioSpectrum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Wwise_AudioSpectrum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D315 RID: 185109 RVA: 0x00A35C4C File Offset: 0x00A33E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Wwise_AudioSpectrum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Wwise_AudioSpectrum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D316 RID: 185110 RVA: 0x00A35C94 File Offset: 0x00A33E94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AkCall(UAkComponent Ak, UAkAudioEvent AkEvent)
		{
			BP_Wwise_AudioSpectrum_C.__AkCall_FunctionParams* ptr = stackalloc BP_Wwise_AudioSpectrum_C.__AkCall_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Wwise_AudioSpectrum_C.__AkCall_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Wwise_AudioSpectrum_C.__AkCall_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ak = ((Ak != null) ? Ak.NativePtr : IntPtr.Zero);
			ptr->AkEvent = ((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Wwise_AudioSpectrum_C.__AkCall_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D317 RID: 185111 RVA: 0x00A35CFF File Offset: 0x00A33EFF
		protected BP_Wwise_AudioSpectrum_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04018031 RID: 98353
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_Wwise_AudioSpectrum.BP_Wwise_AudioSpectrum_C";

		// Token: 0x04018032 RID: 98354
		private static IntPtr _ClassPtr;

		// Token: 0x04018033 RID: 98355
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04018034 RID: 98356
		internal static int __PropertyOffset_1;

		// Token: 0x04018035 RID: 98357
		internal static int __PropertyOffset_2;

		// Token: 0x04018036 RID: 98358
		internal static int __PropertyOffset_3;

		// Token: 0x04018037 RID: 98359
		internal static int __PropertyOffset_4;

		// Token: 0x04018038 RID: 98360
		private TArray<float> _Frequency_Band_Strengths;

		// Token: 0x04018039 RID: 98361
		internal static int __PropertyOffset_5;

		// Token: 0x0401803A RID: 98362
		private TArray<float> _OutputArray;

		// Token: 0x0401803B RID: 98363
		internal static int __PropertyOffset_6;

		// Token: 0x0401803C RID: 98364
		internal static int __PropertyOffset_7;

		// Token: 0x0401803D RID: 98365
		private static IntPtr __NotifyAnalyser_NativeFunctionPtr;

		// Token: 0x0401803E RID: 98366
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401803F RID: 98367
		private static IntPtr __AkCall_NativeFunctionPtr;

		// Token: 0x0200A6E9 RID: 42729
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __NotifyAnalyser_FunctionParams
		{
			// Token: 0x040326DB RID: 206555
			[FieldOffset(0)]
			public IntPtr Ak;

			// Token: 0x040326DC RID: 206556
			[FieldOffset(8)]
			public IntPtr akEvent;
		}

		// Token: 0x0200A6EA RID: 42730
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040326DD RID: 206557
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A6EB RID: 42731
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AkCall_FunctionParams
		{
			// Token: 0x040326DE RID: 206558
			[FieldOffset(0)]
			public IntPtr Ak;

			// Token: 0x040326DF RID: 206559
			[FieldOffset(8)]
			public IntPtr AkEvent;
		}
	}
}
