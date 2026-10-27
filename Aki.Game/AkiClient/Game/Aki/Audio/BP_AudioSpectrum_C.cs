using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x0200442D RID: 17453
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_AudioSpectrum.BP_AudioSpectrum_C")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class BP_AudioSpectrum_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D265 RID: 184933 RVA: 0x00A34B28 File Offset: 0x00A32D28
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AudioSpectrum_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_AudioSpectrum.BP_AudioSpectrum_C");
			}
			return BP_AudioSpectrum_C._ClassPtr;
		}

		// Token: 0x0602D266 RID: 184934 RVA: 0x00A34B4C File Offset: 0x00A32D4C
		public BP_AudioSpectrum_C() : this(BuiltinUtils.AllocNativeUObject(BP_AudioSpectrum_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D267 RID: 184935 RVA: 0x00A34B74 File Offset: 0x00A32D74
		[NullableContext(1)]
		public BP_AudioSpectrum_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AudioSpectrum_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007241 RID: 29249
		// (get) Token: 0x0602D268 RID: 184936 RVA: 0x00A34BA7 File Offset: 0x00A32DA7
		// (set) Token: 0x0602D269 RID: 184937 RVA: 0x00A34BBB File Offset: 0x00A32DBB
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpectrum_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpectrum_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17007242 RID: 29250
		// (get) Token: 0x0602D26A RID: 184938 RVA: 0x00A34BD0 File Offset: 0x00A32DD0
		// (set) Token: 0x0602D26B RID: 184939 RVA: 0x00A34BE4 File Offset: 0x00A32DE4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpectrum_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpectrum_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17007243 RID: 29251
		// (get) Token: 0x0602D26C RID: 184940 RVA: 0x00A34BF9 File Offset: 0x00A32DF9
		// (set) Token: 0x0602D26D RID: 184941 RVA: 0x00A34C09 File Offset: 0x00A32E09
		public unsafe float Timeline_Time_A7ECE5844EB26A560E8B94A3191248B3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpectrum_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpectrum_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17007244 RID: 29252
		// (get) Token: 0x0602D26E RID: 184942 RVA: 0x00A34C1A File Offset: 0x00A32E1A
		// (set) Token: 0x0602D26F RID: 184943 RVA: 0x00A34C2E File Offset: 0x00A32E2E
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline__Direction_A7ECE5844EB26A560E8B94A3191248B3
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpectrum_C.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpectrum_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17007245 RID: 29253
		// (get) Token: 0x0602D270 RID: 184944 RVA: 0x00A34C43 File Offset: 0x00A32E43
		// (set) Token: 0x0602D271 RID: 184945 RVA: 0x00A34C57 File Offset: 0x00A32E57
		public unsafe UTimelineComponent Timeline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpectrum_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpectrum_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17007246 RID: 29254
		// (get) Token: 0x0602D272 RID: 184946 RVA: 0x00A34C6C File Offset: 0x00A32E6C
		// (set) Token: 0x0602D273 RID: 184947 RVA: 0x00A34C80 File Offset: 0x00A32E80
		public unsafe UConstantQNRT Synesthesia_Analysis
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UConstantQNRT>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpectrum_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpectrum_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17007247 RID: 29255
		// (get) Token: 0x0602D274 RID: 184948 RVA: 0x00A34C98 File Offset: 0x00A32E98
		// (set) Token: 0x0602D275 RID: 184949 RVA: 0x00A34CD1 File Offset: 0x00A32ED1
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
					result = (this._Frequency_Band_Strengths = new TArray<float>(base.NativePtr + (IntPtr)BP_AudioSpectrum_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Frequency_Band_Strengths.CopyAssign(value);
			}
		}

		// Token: 0x0602D276 RID: 184950 RVA: 0x00A34CDF File Offset: 0x00A32EDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpectrum_C.__Timeline__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D277 RID: 184951 RVA: 0x00A34CF3 File Offset: 0x00A32EF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpectrum_C.__Timeline__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D278 RID: 184952 RVA: 0x00A34D07 File Offset: 0x00A32F07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpectrum_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602D279 RID: 184953 RVA: 0x00A34D1B File Offset: 0x00A32F1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AudioSpectrum_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602D27A RID: 184954 RVA: 0x00A34D30 File Offset: 0x00A32F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CallDuration(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
		{
			BP_AudioSpectrum_C.__CallDuration_FunctionParams* ptr = stackalloc BP_AudioSpectrum_C.__CallDuration_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_AudioSpectrum_C.__CallDuration_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpectrum_C.__CallDuration_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CallbackType = CallbackType;
			ptr->CallbackInfo = ((CallbackInfo != null) ? CallbackInfo.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpectrum_C.__CallDuration_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D27B RID: 184955 RVA: 0x00A34D8C File Offset: 0x00A32F8C
		protected BP_AudioSpectrum_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017FCE RID: 98254
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_AudioSpectrum.BP_AudioSpectrum_C";

		// Token: 0x04017FCF RID: 98255
		private static IntPtr _ClassPtr;

		// Token: 0x04017FD0 RID: 98256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017FD1 RID: 98257
		internal static int __PropertyOffset_1;

		// Token: 0x04017FD2 RID: 98258
		internal static int __PropertyOffset_2;

		// Token: 0x04017FD3 RID: 98259
		internal static int __PropertyOffset_3;

		// Token: 0x04017FD4 RID: 98260
		internal static int __PropertyOffset_4;

		// Token: 0x04017FD5 RID: 98261
		internal static int __PropertyOffset_5;

		// Token: 0x04017FD6 RID: 98262
		internal static int __PropertyOffset_6;

		// Token: 0x04017FD7 RID: 98263
		internal static int __PropertyOffset_7;

		// Token: 0x04017FD8 RID: 98264
		private TArray<float> _Frequency_Band_Strengths;

		// Token: 0x04017FD9 RID: 98265
		private static IntPtr __Timeline__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04017FDA RID: 98266
		private static IntPtr __Timeline__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04017FDB RID: 98267
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04017FDC RID: 98268
		private static IntPtr __CallDuration_NativeFunctionPtr;

		// Token: 0x0200A6E4 RID: 42724
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CallDuration_FunctionParams
		{
			// Token: 0x040326D1 RID: 206545
			[FieldOffset(0)]
			public EAkCallbackType CallbackType;

			// Token: 0x040326D2 RID: 206546
			[FieldOffset(8)]
			public IntPtr CallbackInfo;
		}
	}
}
