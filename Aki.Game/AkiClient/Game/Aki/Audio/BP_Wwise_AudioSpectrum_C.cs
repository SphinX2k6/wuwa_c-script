using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x020033FD RID: 13309
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_Wwise_AudioSpectrum.BP_Wwise_AudioSpectrum_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_Wwise_AudioSpectrum_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C85 RID: 138373 RVA: 0x0096AE8E File Offset: 0x0096908E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Wwise_AudioSpectrum_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_Wwise_AudioSpectrum.BP_Wwise_AudioSpectrum_C");
			}
			return BP_Wwise_AudioSpectrum_C._ClassPtr;
		}

		// Token: 0x06021C86 RID: 138374 RVA: 0x0096AEB4 File Offset: 0x009690B4
		public BP_Wwise_AudioSpectrum_C() : this(BuiltinUtils.AllocNativeUObject(BP_Wwise_AudioSpectrum_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C87 RID: 138375 RVA: 0x0096AEDC File Offset: 0x009690DC
		[NullableContext(1)]
		public BP_Wwise_AudioSpectrum_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Wwise_AudioSpectrum_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004608 RID: 17928
		// (get) Token: 0x06021C88 RID: 138376 RVA: 0x0096AF0F File Offset: 0x0096910F
		// (set) Token: 0x06021C89 RID: 138377 RVA: 0x0096AF23 File Offset: 0x00969123
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_Ak);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_Ak, value);
			}
		}

		// Token: 0x17004609 RID: 17929
		// (get) Token: 0x06021C8A RID: 138378 RVA: 0x0096AF38 File Offset: 0x00969138
		// (set) Token: 0x06021C8B RID: 138379 RVA: 0x0096AF4C File Offset: 0x0096914C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700460A RID: 17930
		// (get) Token: 0x06021C8C RID: 138380 RVA: 0x0096AF64 File Offset: 0x00969164
		// (set) Token: 0x06021C8D RID: 138381 RVA: 0x0096AF9D File Offset: 0x0096919D
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
					result = (this._Frequency_Band_Strengths = new TArray<float>(base.NativePtr + (IntPtr)BP_Wwise_AudioSpectrum_C.__PropertyOffset_Frequency_Band_Strengths, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Frequency_Band_Strengths.CopyAssign(value);
			}
		}

		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x06021C8E RID: 138382 RVA: 0x0096AFAC File Offset: 0x009691AC
		// (set) Token: 0x06021C8F RID: 138383 RVA: 0x0096AFE5 File Offset: 0x009691E5
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
					result = (this._OutputArray = new TArray<float>(base.NativePtr + (IntPtr)BP_Wwise_AudioSpectrum_C.__PropertyOffset_OutputArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OutputArray.CopyAssign(value);
			}
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x06021C90 RID: 138384 RVA: 0x0096AFF3 File Offset: 0x009691F3
		// (set) Token: 0x06021C91 RID: 138385 RVA: 0x0096B007 File Offset: 0x00969207
		public unsafe UAkAudioEvent AkResource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_AkResource);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_AkResource, value);
			}
		}

		// Token: 0x1700460D RID: 17933
		// (get) Token: 0x06021C92 RID: 138386 RVA: 0x0096B01C File Offset: 0x0096921C
		// (set) Token: 0x06021C93 RID: 138387 RVA: 0x0096B030 File Offset: 0x00969230
		public unsafe UAkAudioEvent Ak_Event
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_Ak_Event);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Wwise_AudioSpectrum_C.__PropertyOffset_Ak_Event, value);
			}
		}

		// Token: 0x06021C94 RID: 138388 RVA: 0x0096B048 File Offset: 0x00969248
		[SkipLocalsInit]
		public unsafe virtual void NotifyAnalyser(UAkComponent Ak, UAkAudioEvent akEvent)
		{
			BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_FunctionParams* ptr = stackalloc BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ak = ((Ak != null) ? Ak.NativePtr : IntPtr.Zero);
			ptr->akEvent = ((akEvent != null) ? akEvent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Wwise_AudioSpectrum_C.__NotifyAnalyser_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C95 RID: 138389 RVA: 0x0096B0B4 File Offset: 0x009692B4
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Wwise_AudioSpectrum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Wwise_AudioSpectrum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C96 RID: 138390 RVA: 0x0096B0FC File Offset: 0x009692FC
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Wwise_AudioSpectrum_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Wwise_AudioSpectrum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Wwise_AudioSpectrum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C97 RID: 138391 RVA: 0x0096B144 File Offset: 0x00969344
		[SkipLocalsInit]
		public unsafe virtual void AkCall(UAkComponent Ak, UAkAudioEvent AkEvent)
		{
			BP_Wwise_AudioSpectrum_C.__AkCall_FunctionParams* ptr = stackalloc BP_Wwise_AudioSpectrum_C.__AkCall_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_Wwise_AudioSpectrum_C.__AkCall_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Wwise_AudioSpectrum_C.__AkCall_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ak = ((Ak != null) ? Ak.NativePtr : IntPtr.Zero);
			ptr->AkEvent = ((AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Wwise_AudioSpectrum_C.__AkCall_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C98 RID: 138392 RVA: 0x0096B1AF File Offset: 0x009693AF
		protected BP_Wwise_AudioSpectrum_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129F3 RID: 76275
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_Wwise_AudioSpectrum.BP_Wwise_AudioSpectrum_C";

		// Token: 0x040129F4 RID: 76276
		private static IntPtr _ClassPtr;

		// Token: 0x040129F5 RID: 76277
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129F6 RID: 76278
		internal static int __PropertyOffset_Ak;

		// Token: 0x040129F7 RID: 76279
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040129F8 RID: 76280
		internal static int __PropertyOffset_Frequency_Band_Strengths;

		// Token: 0x040129F9 RID: 76281
		private TArray<float> _Frequency_Band_Strengths;

		// Token: 0x040129FA RID: 76282
		internal static int __PropertyOffset_OutputArray;

		// Token: 0x040129FB RID: 76283
		private TArray<float> _OutputArray;

		// Token: 0x040129FC RID: 76284
		internal static int __PropertyOffset_AkResource;

		// Token: 0x040129FD RID: 76285
		internal static int __PropertyOffset_Ak_Event;

		// Token: 0x040129FE RID: 76286
		private static IntPtr __NotifyAnalyser_NativeFunctionPtr;

		// Token: 0x040129FF RID: 76287
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012A00 RID: 76288
		private static IntPtr __AkCall_NativeFunctionPtr;

		// Token: 0x020090E4 RID: 37092
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __NotifyAnalyser_FunctionParams
		{
			// Token: 0x0402CF92 RID: 184210
			[FieldOffset(0)]
			public IntPtr Ak;

			// Token: 0x0402CF93 RID: 184211
			[FieldOffset(8)]
			public IntPtr akEvent;
		}

		// Token: 0x020090E5 RID: 37093
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CF94 RID: 184212
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x020090E6 RID: 37094
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AkCall_FunctionParams
		{
			// Token: 0x0402CF95 RID: 184213
			[FieldOffset(0)]
			public IntPtr Ak;

			// Token: 0x0402CF96 RID: 184214
			[FieldOffset(8)]
			public IntPtr AkEvent;
		}
	}
}
