using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033BD RID: 13245
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/BP_CineCamera.BP_CineCamera_C")]
	[UnrealStructLayout(4064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4052)]
	public class BP_CineCamera_C : ACineCameraActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602195A RID: 137562 RVA: 0x00964895 File Offset: 0x00962A95
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CineCamera_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Camera/BP_CineCamera.BP_CineCamera_C");
			}
			return BP_CineCamera_C._ClassPtr;
		}

		// Token: 0x0602195B RID: 137563 RVA: 0x009648BC File Offset: 0x00962ABC
		public BP_CineCamera_C() : this(BuiltinUtils.AllocNativeUObject(BP_CineCamera_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602195C RID: 137564 RVA: 0x009648E4 File Offset: 0x00962AE4
		public BP_CineCamera_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CineCamera_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x0602195D RID: 137565 RVA: 0x00964917 File Offset: 0x00962B17
		// (set) Token: 0x0602195E RID: 137566 RVA: 0x00964927 File Offset: 0x00962B27
		public unsafe float ResolutionAdaptFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_ResolutionAdaptFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_ResolutionAdaptFactor) = value;
			}
		}

		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x0602195F RID: 137567 RVA: 0x00964938 File Offset: 0x00962B38
		// (set) Token: 0x06021960 RID: 137568 RVA: 0x00964948 File Offset: 0x00962B48
		public unsafe bool IsAutoTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_IsAutoTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_IsAutoTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004502 RID: 17666
		// (get) Token: 0x06021961 RID: 137569 RVA: 0x00964959 File Offset: 0x00962B59
		// (set) Token: 0x06021962 RID: 137570 RVA: 0x00964969 File Offset: 0x00962B69
		public unsafe float OffsetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_OffsetTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_OffsetTime) = value;
			}
		}

		// Token: 0x17004503 RID: 17667
		// (get) Token: 0x06021963 RID: 137571 RVA: 0x0096497A File Offset: 0x00962B7A
		// (set) Token: 0x06021964 RID: 137572 RVA: 0x0096498A File Offset: 0x00962B8A
		public unsafe float MaxOffsetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_MaxOffsetTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_MaxOffsetTime) = value;
			}
		}

		// Token: 0x17004504 RID: 17668
		// (get) Token: 0x06021965 RID: 137573 RVA: 0x0096499C File Offset: 0x00962B9C
		// (set) Token: 0x06021966 RID: 137574 RVA: 0x009649D5 File Offset: 0x00962BD5
		public FCameraFilmbackSettings Filmback
		{
			get
			{
				base.FastCheckIsValid();
				FCameraFilmbackSettings result;
				if ((result = this._Filmback) == null)
				{
					result = (this._Filmback = new FCameraFilmbackSettings(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Filmback, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraFilmbackSettings.StaticStruct(), base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Filmback, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004505 RID: 17669
		// (get) Token: 0x06021967 RID: 137575 RVA: 0x009649F6 File Offset: 0x00962BF6
		// (set) Token: 0x06021968 RID: 137576 RVA: 0x00964A06 File Offset: 0x00962C06
		public unsafe bool Constrain_Aspect_Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Constrain_Aspect_Ratio) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Constrain_Aspect_Ratio) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x06021969 RID: 137577 RVA: 0x00964A17 File Offset: 0x00962C17
		// (set) Token: 0x0602196A RID: 137578 RVA: 0x00964A27 File Offset: 0x00962C27
		public unsafe float Current_Focal_Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Current_Focal_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Current_Focal_Length) = value;
			}
		}

		// Token: 0x17004507 RID: 17671
		// (get) Token: 0x0602196B RID: 137579 RVA: 0x00964A38 File Offset: 0x00962C38
		// (set) Token: 0x0602196C RID: 137580 RVA: 0x00964A48 File Offset: 0x00962C48
		public unsafe float Current_Aperture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Current_Aperture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Current_Aperture) = value;
			}
		}

		// Token: 0x17004508 RID: 17672
		// (get) Token: 0x0602196D RID: 137581 RVA: 0x00964A5C File Offset: 0x00962C5C
		// (set) Token: 0x0602196E RID: 137582 RVA: 0x00964A95 File Offset: 0x00962C95
		public FCameraFocusSettings Focus_Settings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraFocusSettings result;
				if ((result = this._Focus_Settings) == null)
				{
					result = (this._Focus_Settings = new FCameraFocusSettings(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Focus_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraFocusSettings.StaticStruct(), base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Focus_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004509 RID: 17673
		// (get) Token: 0x0602196F RID: 137583 RVA: 0x00964AB8 File Offset: 0x00962CB8
		// (set) Token: 0x06021970 RID: 137584 RVA: 0x00964AF1 File Offset: 0x00962CF1
		public FCameraLensSettings Lens_Settings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraLensSettings result;
				if ((result = this._Lens_Settings) == null)
				{
					result = (this._Lens_Settings = new FCameraLensSettings(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Lens_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraLensSettings.StaticStruct(), base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_Lens_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700450A RID: 17674
		// (get) Token: 0x06021971 RID: 137585 RVA: 0x00964B12 File Offset: 0x00962D12
		// (set) Token: 0x06021972 RID: 137586 RVA: 0x00964B22 File Offset: 0x00962D22
		public unsafe float FocalRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_FocalRegion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_FocalRegion) = value;
			}
		}

		// Token: 0x06021973 RID: 137587 RVA: 0x00964B33 File Offset: 0x00962D33
		[SkipLocalsInit]
		public virtual void ResetSeqCineCamSetting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__ResetSeqCineCamSetting_NativeFunctionPtr, null);
		}

		// Token: 0x06021974 RID: 137588 RVA: 0x00964B47 File Offset: 0x00962D47
		[SkipLocalsInit]
		public virtual void ApplyUiCameraSettings()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__ApplyUiCameraSettings_NativeFunctionPtr, null);
		}

		// Token: 0x06021975 RID: 137589 RVA: 0x00964B5C File Offset: 0x00962D5C
		[SkipLocalsInit]
		public unsafe virtual void BeginAutoTransform(float TimeLength)
		{
			BP_CineCamera_C.__BeginAutoTransform_FunctionParams* ptr = stackalloc BP_CineCamera_C.__BeginAutoTransform_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CineCamera_C.__BeginAutoTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CineCamera_C.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeLength = TimeLength;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021976 RID: 137590 RVA: 0x00964BA4 File Offset: 0x00962DA4
		[SkipLocalsInit]
		protected unsafe virtual void BeginAutoTransform_Implementation(float TimeLength)
		{
			BP_CineCamera_C.__BeginAutoTransform_FunctionParams* ptr = stackalloc BP_CineCamera_C.__BeginAutoTransform_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CineCamera_C.__BeginAutoTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CineCamera_C.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeLength = TimeLength;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CineCamera_C.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021977 RID: 137591 RVA: 0x00964BEA File Offset: 0x00962DEA
		[SkipLocalsInit]
		public virtual void EndAutoTransform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__EndAutoTransform_NativeFunctionPtr, null);
		}

		// Token: 0x06021978 RID: 137592 RVA: 0x00964BFE File Offset: 0x00962DFE
		[SkipLocalsInit]
		protected virtual void EndAutoTransform_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CineCamera_C.__EndAutoTransform_NativeFunctionPtr, null);
		}

		// Token: 0x06021979 RID: 137593 RVA: 0x00964C14 File Offset: 0x00962E14
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CineCamera_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CineCamera_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CineCamera_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CineCamera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602197A RID: 137594 RVA: 0x00964C5C File Offset: 0x00962E5C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CineCamera_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CineCamera_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CineCamera_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CineCamera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CineCamera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602197B RID: 137595 RVA: 0x00964CA2 File Offset: 0x00962EA2
		protected BP_CineCamera_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125F4 RID: 75252
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/BP_CineCamera.BP_CineCamera_C";

		// Token: 0x040125F5 RID: 75253
		private static IntPtr _ClassPtr;

		// Token: 0x040125F6 RID: 75254
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125F7 RID: 75255
		internal static int __PropertyOffset_ResolutionAdaptFactor;

		// Token: 0x040125F8 RID: 75256
		internal static int __PropertyOffset_IsAutoTransform;

		// Token: 0x040125F9 RID: 75257
		internal static int __PropertyOffset_OffsetTime;

		// Token: 0x040125FA RID: 75258
		internal static int __PropertyOffset_MaxOffsetTime;

		// Token: 0x040125FB RID: 75259
		internal static int __PropertyOffset_Filmback;

		// Token: 0x040125FC RID: 75260
		[Nullable(2)]
		private FCameraFilmbackSettings _Filmback;

		// Token: 0x040125FD RID: 75261
		internal static int __PropertyOffset_Constrain_Aspect_Ratio;

		// Token: 0x040125FE RID: 75262
		internal static int __PropertyOffset_Current_Focal_Length;

		// Token: 0x040125FF RID: 75263
		internal static int __PropertyOffset_Current_Aperture;

		// Token: 0x04012600 RID: 75264
		internal static int __PropertyOffset_Focus_Settings;

		// Token: 0x04012601 RID: 75265
		[Nullable(2)]
		private FCameraFocusSettings _Focus_Settings;

		// Token: 0x04012602 RID: 75266
		internal static int __PropertyOffset_Lens_Settings;

		// Token: 0x04012603 RID: 75267
		[Nullable(2)]
		private FCameraLensSettings _Lens_Settings;

		// Token: 0x04012604 RID: 75268
		internal static int __PropertyOffset_FocalRegion;

		// Token: 0x04012605 RID: 75269
		private static IntPtr __ResetSeqCineCamSetting_NativeFunctionPtr;

		// Token: 0x04012606 RID: 75270
		private static IntPtr __ApplyUiCameraSettings_NativeFunctionPtr;

		// Token: 0x04012607 RID: 75271
		private static IntPtr __BeginAutoTransform_NativeFunctionPtr;

		// Token: 0x04012608 RID: 75272
		private static IntPtr __EndAutoTransform_NativeFunctionPtr;

		// Token: 0x04012609 RID: 75273
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009088 RID: 37000
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BeginAutoTransform_FunctionParams
		{
			// Token: 0x0402CEA5 RID: 183973
			[FieldOffset(0)]
			public float TimeLength;
		}

		// Token: 0x02009089 RID: 37001
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CEA6 RID: 183974
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
