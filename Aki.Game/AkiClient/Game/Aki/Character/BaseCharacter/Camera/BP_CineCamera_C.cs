using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x0200439E RID: 17310
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/BP_CineCamera.BP_CineCamera_C")]
	[UnrealStructLayout(4016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4004)]
	public class BP_CineCamera_C : ACineCameraActor, IUnrealUObject, IUnrealObject, ISeqAutoTransformInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602CD4A RID: 183626 RVA: 0x00A29BFC File Offset: 0x00A27DFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CineCamera_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Camera/BP_CineCamera.BP_CineCamera_C");
			}
			return BP_CineCamera_C._ClassPtr;
		}

		// Token: 0x0602CD4B RID: 183627 RVA: 0x00A29C20 File Offset: 0x00A27E20
		int ISeqAutoTransformInterface.InterfaceOffset()
		{
			return BP_CineCamera_C.__InterfaceOffset_ISeqAutoTransformInterface;
		}

		// Token: 0x0602CD4C RID: 183628 RVA: 0x00A29C28 File Offset: 0x00A27E28
		public BP_CineCamera_C() : this(BuiltinUtils.AllocNativeUObject(BP_CineCamera_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CD4D RID: 183629 RVA: 0x00A29C50 File Offset: 0x00A27E50
		public BP_CineCamera_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CineCamera_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070FF RID: 28927
		// (get) Token: 0x0602CD4E RID: 183630 RVA: 0x00A29C83 File Offset: 0x00A27E83
		// (set) Token: 0x0602CD4F RID: 183631 RVA: 0x00A29C93 File Offset: 0x00A27E93
		public unsafe float ResolutionAdaptFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007100 RID: 28928
		// (get) Token: 0x0602CD50 RID: 183632 RVA: 0x00A29CA4 File Offset: 0x00A27EA4
		// (set) Token: 0x0602CD51 RID: 183633 RVA: 0x00A29CDD File Offset: 0x00A27EDD
		public FDataTableRowHandle UiCameraAnimationRow
		{
			get
			{
				base.FastCheckIsValid();
				FDataTableRowHandle result;
				if ((result = this._UiCameraAnimationRow) == null)
				{
					result = (this._UiCameraAnimationRow = new FDataTableRowHandle(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDataTableRowHandle.StaticStruct(), base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007101 RID: 28929
		// (get) Token: 0x0602CD52 RID: 183634 RVA: 0x00A29CFE File Offset: 0x00A27EFE
		// (set) Token: 0x0602CD53 RID: 183635 RVA: 0x00A29D0E File Offset: 0x00A27F0E
		public unsafe bool IsAutoTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007102 RID: 28930
		// (get) Token: 0x0602CD54 RID: 183636 RVA: 0x00A29D1F File Offset: 0x00A27F1F
		// (set) Token: 0x0602CD55 RID: 183637 RVA: 0x00A29D2F File Offset: 0x00A27F2F
		public unsafe float OffsetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17007103 RID: 28931
		// (get) Token: 0x0602CD56 RID: 183638 RVA: 0x00A29D40 File Offset: 0x00A27F40
		// (set) Token: 0x0602CD57 RID: 183639 RVA: 0x00A29D50 File Offset: 0x00A27F50
		public unsafe float MaxOffsetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17007104 RID: 28932
		// (get) Token: 0x0602CD58 RID: 183640 RVA: 0x00A29D64 File Offset: 0x00A27F64
		// (set) Token: 0x0602CD59 RID: 183641 RVA: 0x00A29D9D File Offset: 0x00A27F9D
		public FCameraFilmbackSettings Filmback
		{
			get
			{
				base.FastCheckIsValid();
				FCameraFilmbackSettings result;
				if ((result = this._Filmback) == null)
				{
					result = (this._Filmback = new FCameraFilmbackSettings(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraFilmbackSettings.StaticStruct(), base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007105 RID: 28933
		// (get) Token: 0x0602CD5A RID: 183642 RVA: 0x00A29DBE File Offset: 0x00A27FBE
		// (set) Token: 0x0602CD5B RID: 183643 RVA: 0x00A29DCE File Offset: 0x00A27FCE
		public unsafe bool Constrain_Aspect_Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007106 RID: 28934
		// (get) Token: 0x0602CD5C RID: 183644 RVA: 0x00A29DDF File Offset: 0x00A27FDF
		// (set) Token: 0x0602CD5D RID: 183645 RVA: 0x00A29DEF File Offset: 0x00A27FEF
		public unsafe float Current_Focal_Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17007107 RID: 28935
		// (get) Token: 0x0602CD5E RID: 183646 RVA: 0x00A29E00 File Offset: 0x00A28000
		// (set) Token: 0x0602CD5F RID: 183647 RVA: 0x00A29E10 File Offset: 0x00A28010
		public unsafe float Current_Aperture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17007108 RID: 28936
		// (get) Token: 0x0602CD60 RID: 183648 RVA: 0x00A29E24 File Offset: 0x00A28024
		// (set) Token: 0x0602CD61 RID: 183649 RVA: 0x00A29E5D File Offset: 0x00A2805D
		public FCameraFocusSettings Focus_Settings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraFocusSettings result;
				if ((result = this._Focus_Settings) == null)
				{
					result = (this._Focus_Settings = new FCameraFocusSettings(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraFocusSettings.StaticStruct(), base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007109 RID: 28937
		// (get) Token: 0x0602CD62 RID: 183650 RVA: 0x00A29E80 File Offset: 0x00A28080
		// (set) Token: 0x0602CD63 RID: 183651 RVA: 0x00A29EB9 File Offset: 0x00A280B9
		public FCameraLensSettings Lens_Settings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraLensSettings result;
				if ((result = this._Lens_Settings) == null)
				{
					result = (this._Lens_Settings = new FCameraLensSettings(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraLensSettings.StaticStruct(), base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700710A RID: 28938
		// (get) Token: 0x0602CD64 RID: 183652 RVA: 0x00A29EDA File Offset: 0x00A280DA
		// (set) Token: 0x0602CD65 RID: 183653 RVA: 0x00A29EEA File Offset: 0x00A280EA
		public unsafe float FocalRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CineCamera_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x0602CD66 RID: 183654 RVA: 0x00A29EFB File Offset: 0x00A280FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetSeqCineCamSetting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__ResetSeqCineCamSetting_NativeFunctionPtr, null);
		}

		// Token: 0x0602CD67 RID: 183655 RVA: 0x00A29F0F File Offset: 0x00A2810F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ApplyUiCameraSettings()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__ApplyUiCameraSettings_NativeFunctionPtr, null);
		}

		// Token: 0x0602CD68 RID: 183656 RVA: 0x00A29F24 File Offset: 0x00A28124
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BeginAutoTransform(float TimeLength)
		{
			BP_CineCamera_C.__BeginAutoTransform_FunctionParams* ptr = stackalloc BP_CineCamera_C.__BeginAutoTransform_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CineCamera_C.__BeginAutoTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CineCamera_C.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeLength = TimeLength;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602CD69 RID: 183657 RVA: 0x00A29F6C File Offset: 0x00A2816C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BeginAutoTransform_Implementation(float TimeLength)
		{
			BP_CineCamera_C.__BeginAutoTransform_FunctionParams* ptr = stackalloc BP_CineCamera_C.__BeginAutoTransform_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CineCamera_C.__BeginAutoTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CineCamera_C.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimeLength = TimeLength;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CineCamera_C.__BeginAutoTransform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602CD6A RID: 183658 RVA: 0x00A29FB3 File Offset: 0x00A281B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndAutoTransform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__EndAutoTransform_NativeFunctionPtr, null);
		}

		// Token: 0x0602CD6B RID: 183659 RVA: 0x00A29FC7 File Offset: 0x00A281C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EndAutoTransform_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CineCamera_C.__EndAutoTransform_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602CD6C RID: 183660 RVA: 0x00A29FDC File Offset: 0x00A281DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CineCamera_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CineCamera_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CineCamera_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CineCamera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CineCamera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602CD6D RID: 183661 RVA: 0x00A2A024 File Offset: 0x00A28224
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CineCamera_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CineCamera_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CineCamera_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CineCamera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CineCamera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602CD6E RID: 183662 RVA: 0x00A2A06B File Offset: 0x00A2826B
		protected BP_CineCamera_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A7C RID: 96892
		internal static int __InterfaceOffset_ISeqAutoTransformInterface;

		// Token: 0x04017A7D RID: 96893
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/BP_CineCamera.BP_CineCamera_C";

		// Token: 0x04017A7E RID: 96894
		private static IntPtr _ClassPtr;

		// Token: 0x04017A7F RID: 96895
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A80 RID: 96896
		internal static int __PropertyOffset_1;

		// Token: 0x04017A81 RID: 96897
		internal static int __PropertyOffset_2;

		// Token: 0x04017A82 RID: 96898
		[Nullable(2)]
		private FDataTableRowHandle _UiCameraAnimationRow;

		// Token: 0x04017A83 RID: 96899
		internal static int __PropertyOffset_3;

		// Token: 0x04017A84 RID: 96900
		internal static int __PropertyOffset_4;

		// Token: 0x04017A85 RID: 96901
		internal static int __PropertyOffset_5;

		// Token: 0x04017A86 RID: 96902
		internal static int __PropertyOffset_6;

		// Token: 0x04017A87 RID: 96903
		[Nullable(2)]
		private FCameraFilmbackSettings _Filmback;

		// Token: 0x04017A88 RID: 96904
		internal static int __PropertyOffset_7;

		// Token: 0x04017A89 RID: 96905
		internal static int __PropertyOffset_8;

		// Token: 0x04017A8A RID: 96906
		internal static int __PropertyOffset_9;

		// Token: 0x04017A8B RID: 96907
		internal static int __PropertyOffset_10;

		// Token: 0x04017A8C RID: 96908
		[Nullable(2)]
		private FCameraFocusSettings _Focus_Settings;

		// Token: 0x04017A8D RID: 96909
		internal static int __PropertyOffset_11;

		// Token: 0x04017A8E RID: 96910
		[Nullable(2)]
		private FCameraLensSettings _Lens_Settings;

		// Token: 0x04017A8F RID: 96911
		internal static int __PropertyOffset_12;

		// Token: 0x04017A90 RID: 96912
		private static IntPtr __ResetSeqCineCamSetting_NativeFunctionPtr;

		// Token: 0x04017A91 RID: 96913
		private static IntPtr __ApplyUiCameraSettings_NativeFunctionPtr;

		// Token: 0x04017A92 RID: 96914
		private static IntPtr __BeginAutoTransform_NativeFunctionPtr;

		// Token: 0x04017A93 RID: 96915
		private static IntPtr __EndAutoTransform_NativeFunctionPtr;

		// Token: 0x04017A94 RID: 96916
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A675 RID: 42613
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BeginAutoTransform_FunctionParams
		{
			// Token: 0x040325B9 RID: 206265
			[FieldOffset(0)]
			public float TimeLength;
		}

		// Token: 0x0200A676 RID: 42614
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040325BA RID: 206266
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
