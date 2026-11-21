using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.Loading.View
{
	// Token: 0x02003036 RID: 12342
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/Loading/View/WBP_UILoading.WBP_UILoading_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1340)]
	public class WBP_UILoading_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D449 RID: 119881 RVA: 0x008EF763 File Offset: 0x008ED963
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_UILoading_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/Loading/View/WBP_UILoading.WBP_UILoading_C");
			}
			return WBP_UILoading_C._ClassPtr;
		}

		// Token: 0x0601D44A RID: 119882 RVA: 0x008EF788 File Offset: 0x008ED988
		public WBP_UILoading_C() : this(BuiltinUtils.AllocNativeUObject(WBP_UILoading_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D44B RID: 119883 RVA: 0x008EF7B0 File Offset: 0x008ED9B0
		[NullableContext(1)]
		public WBP_UILoading_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_UILoading_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x0601D44C RID: 119884 RVA: 0x008EF7E3 File Offset: 0x008ED9E3
		// (set) Token: 0x0601D44D RID: 119885 RVA: 0x008EF7F7 File Offset: 0x008ED9F7
		public unsafe UImage Image
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Image);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Image, value);
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0601D44E RID: 119886 RVA: 0x008EF80C File Offset: 0x008EDA0C
		// (set) Token: 0x0601D44F RID: 119887 RVA: 0x008EF820 File Offset: 0x008EDA20
		public unsafe UImage Image_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Image_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Image_0, value);
			}
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0601D450 RID: 119888 RVA: 0x008EF835 File Offset: 0x008EDA35
		// (set) Token: 0x0601D451 RID: 119889 RVA: 0x008EF849 File Offset: 0x008EDA49
		public unsafe UImage Image_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Image_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Image_1, value);
			}
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0601D452 RID: 119890 RVA: 0x008EF85E File Offset: 0x008EDA5E
		// (set) Token: 0x0601D453 RID: 119891 RVA: 0x008EF872 File Offset: 0x008EDA72
		public unsafe UImage Image_Background
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Image_Background);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Image_Background, value);
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x0601D454 RID: 119892 RVA: 0x008EF887 File Offset: 0x008EDA87
		// (set) Token: 0x0601D455 RID: 119893 RVA: 0x008EF89B File Offset: 0x008EDA9B
		public unsafe UTextBlock ProgressText
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_ProgressText);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_ProgressText, value);
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0601D456 RID: 119894 RVA: 0x008EF8B0 File Offset: 0x008EDAB0
		// (set) Token: 0x0601D457 RID: 119895 RVA: 0x008EF8C4 File Offset: 0x008EDAC4
		public unsafe UImage TexBg
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_TexBg);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_TexBg, value);
			}
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0601D458 RID: 119896 RVA: 0x008EF8D9 File Offset: 0x008EDAD9
		// (set) Token: 0x0601D459 RID: 119897 RVA: 0x008EF8ED File Offset: 0x008EDAED
		public unsafe UImage TexBgDeco
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_TexBgDeco);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_TexBgDeco, value);
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x0601D45A RID: 119898 RVA: 0x008EF902 File Offset: 0x008EDB02
		// (set) Token: 0x0601D45B RID: 119899 RVA: 0x008EF916 File Offset: 0x008EDB16
		public unsafe UImage TexProgressHandle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_TexProgressHandle);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_TexProgressHandle, value);
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x0601D45C RID: 119900 RVA: 0x008EF92B File Offset: 0x008EDB2B
		// (set) Token: 0x0601D45D RID: 119901 RVA: 0x008EF93F File Offset: 0x008EDB3F
		public unsafe UTextBlock Tips
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Tips);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Tips, value);
			}
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0601D45E RID: 119902 RVA: 0x008EF954 File Offset: 0x008EDB54
		// (set) Token: 0x0601D45F RID: 119903 RVA: 0x008EF968 File Offset: 0x008EDB68
		public unsafe UTextBlock Title
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Title);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_Title, value);
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0601D460 RID: 119904 RVA: 0x008EF97D File Offset: 0x008EDB7D
		// (set) Token: 0x0601D461 RID: 119905 RVA: 0x008EF98D File Offset: 0x008EDB8D
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_Progress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_Progress) = value;
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0601D462 RID: 119906 RVA: 0x008EF99E File Offset: 0x008EDB9E
		// (set) Token: 0x0601D463 RID: 119907 RVA: 0x008EF9AE File Offset: 0x008EDBAE
		public unsafe float FirstProgressRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_FirstProgressRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_FirstProgressRatio) = value;
			}
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x0601D464 RID: 119908 RVA: 0x008EF9BF File Offset: 0x008EDBBF
		// (set) Token: 0x0601D465 RID: 119909 RVA: 0x008EF9CF File Offset: 0x008EDBCF
		public unsafe float SecondeLoadingRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_SecondeLoadingRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_SecondeLoadingRatio) = value;
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0601D466 RID: 119910 RVA: 0x008EF9E0 File Offset: 0x008EDBE0
		// (set) Token: 0x0601D467 RID: 119911 RVA: 0x008EF9F0 File Offset: 0x008EDBF0
		public unsafe float FirstSpeedRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_FirstSpeedRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_FirstSpeedRate) = value;
			}
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x0601D468 RID: 119912 RVA: 0x008EFA01 File Offset: 0x008EDC01
		// (set) Token: 0x0601D469 RID: 119913 RVA: 0x008EFA11 File Offset: 0x008EDC11
		public unsafe float SecondSpeedRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_SecondSpeedRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_SecondSpeedRate) = value;
			}
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x0601D46A RID: 119914 RVA: 0x008EFA22 File Offset: 0x008EDC22
		// (set) Token: 0x0601D46B RID: 119915 RVA: 0x008EFA32 File Offset: 0x008EDC32
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0601D46C RID: 119916 RVA: 0x008EFA43 File Offset: 0x008EDC43
		// (set) Token: 0x0601D46D RID: 119917 RVA: 0x008EFA53 File Offset: 0x008EDC53
		public unsafe float ClampProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_ClampProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_ClampProgress) = value;
			}
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0601D46E RID: 119918 RVA: 0x008EFA64 File Offset: 0x008EDC64
		// (set) Token: 0x0601D46F RID: 119919 RVA: 0x008EFA74 File Offset: 0x008EDC74
		public unsafe float SpeedRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_SpeedRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_SpeedRate) = value;
			}
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0601D470 RID: 119920 RVA: 0x008EFA88 File Offset: 0x008EDC88
		// (set) Token: 0x0601D471 RID: 119921 RVA: 0x008EFAC1 File Offset: 0x008EDCC1
		[Nullable(1)]
		public FInputModeReply UIOnlyInputModeReply
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInputModeReply result;
				if ((result = this._UIOnlyInputModeReply) == null)
				{
					result = (this._UIOnlyInputModeReply = new FInputModeReply(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_UIOnlyInputModeReply, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputModeReply.StaticStruct(), base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_UIOnlyInputModeReply, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x0601D472 RID: 119922 RVA: 0x008EFAE2 File Offset: 0x008EDCE2
		// (set) Token: 0x0601D473 RID: 119923 RVA: 0x008EFAF2 File Offset: 0x008EDCF2
		public unsafe float ProgressBarWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_ProgressBarWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_ProgressBarWidth) = value;
			}
		}

		// Token: 0x0601D474 RID: 119924 RVA: 0x008EFB03 File Offset: 0x008EDD03
		[SkipLocalsInit]
		public virtual void MoveProgressHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__MoveProgressHandle_NativeFunctionPtr, null);
		}

		// Token: 0x0601D475 RID: 119925 RVA: 0x008EFB17 File Offset: 0x008EDD17
		[SkipLocalsInit]
		public virtual void RefreshProgressBarWidth()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__RefreshProgressBarWidth_NativeFunctionPtr, null);
		}

		// Token: 0x0601D476 RID: 119926 RVA: 0x008EFB2B File Offset: 0x008EDD2B
		[SkipLocalsInit]
		public virtual void RebootFinished()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__RebootFinished_NativeFunctionPtr, null);
		}

		// Token: 0x0601D477 RID: 119927 RVA: 0x008EFB40 File Offset: 0x008EDD40
		[SkipLocalsInit]
		public unsafe virtual void UpdateOtherLoadingProgerss(float InProgress)
		{
			WBP_UILoading_C.__UpdateOtherLoadingProgerss_FunctionParams* ptr = stackalloc WBP_UILoading_C.__UpdateOtherLoadingProgerss_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(WBP_UILoading_C.__UpdateOtherLoadingProgerss_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_UILoading_C.__UpdateOtherLoadingProgerss_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InProgress = InProgress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__UpdateOtherLoadingProgerss_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D478 RID: 119928 RVA: 0x008EFB88 File Offset: 0x008EDD88
		[SkipLocalsInit]
		public unsafe virtual void SetProgress(float InProgress, float ClampProgress, bool Forece)
		{
			WBP_UILoading_C.__SetProgress_FunctionParams* ptr = stackalloc WBP_UILoading_C.__SetProgress_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(WBP_UILoading_C.__SetProgress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_UILoading_C.__SetProgress_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InProgress = InProgress;
			ptr->ClampProgress = ClampProgress;
			ptr->Forece = Forece;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__SetProgress_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D479 RID: 119929 RVA: 0x008EFBDF File Offset: 0x008EDDDF
		[SkipLocalsInit]
		public override void Construct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__Construct_NativeFunctionPtr, null);
		}

		// Token: 0x0601D47A RID: 119930 RVA: 0x008EFBF3 File Offset: 0x008EDDF3
		[SkipLocalsInit]
		protected virtual void Construct_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_UILoading_C.__Construct_NativeFunctionPtr, null);
		}

		// Token: 0x0601D47B RID: 119931 RVA: 0x008EFC07 File Offset: 0x008EDE07
		[SkipLocalsInit]
		public override void Destruct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__Destruct_NativeFunctionPtr, null);
		}

		// Token: 0x0601D47C RID: 119932 RVA: 0x008EFC1B File Offset: 0x008EDE1B
		[SkipLocalsInit]
		protected virtual void Destruct_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_UILoading_C.__Destruct_NativeFunctionPtr, null);
		}

		// Token: 0x0601D47D RID: 119933 RVA: 0x008EFC2F File Offset: 0x008EDE2F
		protected WBP_UILoading_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F68B RID: 63115
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/Loading/View/WBP_UILoading.WBP_UILoading_C";

		// Token: 0x0400F68C RID: 63116
		private static IntPtr _ClassPtr;

		// Token: 0x0400F68D RID: 63117
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F68E RID: 63118
		internal static int __PropertyOffset_Image;

		// Token: 0x0400F68F RID: 63119
		internal static int __PropertyOffset_Image_0;

		// Token: 0x0400F690 RID: 63120
		internal static int __PropertyOffset_Image_1;

		// Token: 0x0400F691 RID: 63121
		internal static int __PropertyOffset_Image_Background;

		// Token: 0x0400F692 RID: 63122
		internal static int __PropertyOffset_ProgressText;

		// Token: 0x0400F693 RID: 63123
		internal static int __PropertyOffset_TexBg;

		// Token: 0x0400F694 RID: 63124
		internal static int __PropertyOffset_TexBgDeco;

		// Token: 0x0400F695 RID: 63125
		internal static int __PropertyOffset_TexProgressHandle;

		// Token: 0x0400F696 RID: 63126
		internal static int __PropertyOffset_Tips;

		// Token: 0x0400F697 RID: 63127
		internal static int __PropertyOffset_Title;

		// Token: 0x0400F698 RID: 63128
		internal static int __PropertyOffset_Progress;

		// Token: 0x0400F699 RID: 63129
		internal static int __PropertyOffset_FirstProgressRatio;

		// Token: 0x0400F69A RID: 63130
		internal static int __PropertyOffset_SecondeLoadingRatio;

		// Token: 0x0400F69B RID: 63131
		internal static int __PropertyOffset_FirstSpeedRate;

		// Token: 0x0400F69C RID: 63132
		internal static int __PropertyOffset_SecondSpeedRate;

		// Token: 0x0400F69D RID: 63133
		internal static int __PropertyOffset_Speed;

		// Token: 0x0400F69E RID: 63134
		internal static int __PropertyOffset_ClampProgress;

		// Token: 0x0400F69F RID: 63135
		internal static int __PropertyOffset_SpeedRate;

		// Token: 0x0400F6A0 RID: 63136
		internal static int __PropertyOffset_UIOnlyInputModeReply;

		// Token: 0x0400F6A1 RID: 63137
		private FInputModeReply _UIOnlyInputModeReply;

		// Token: 0x0400F6A2 RID: 63138
		internal static int __PropertyOffset_ProgressBarWidth;

		// Token: 0x0400F6A3 RID: 63139
		private static IntPtr __MoveProgressHandle_NativeFunctionPtr;

		// Token: 0x0400F6A4 RID: 63140
		private static IntPtr __RefreshProgressBarWidth_NativeFunctionPtr;

		// Token: 0x0400F6A5 RID: 63141
		private static IntPtr __RebootFinished_NativeFunctionPtr;

		// Token: 0x0400F6A6 RID: 63142
		private static IntPtr __UpdateOtherLoadingProgerss_NativeFunctionPtr;

		// Token: 0x0400F6A7 RID: 63143
		private static IntPtr __SetProgress_NativeFunctionPtr;

		// Token: 0x0400F6A8 RID: 63144
		private static IntPtr __Construct_NativeFunctionPtr;

		// Token: 0x0400F6A9 RID: 63145
		private static IntPtr __Destruct_NativeFunctionPtr;

		// Token: 0x02008C8C RID: 35980
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateOtherLoadingProgerss_FunctionParams
		{
			// Token: 0x0402C785 RID: 182149
			[FieldOffset(0)]
			public float InProgress;
		}

		// Token: 0x02008C8D RID: 35981
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __SetProgress_FunctionParams
		{
			// Token: 0x0402C786 RID: 182150
			[FieldOffset(0)]
			public float InProgress;

			// Token: 0x0402C787 RID: 182151
			[FieldOffset(4)]
			public float ClampProgress;

			// Token: 0x0402C788 RID: 182152
			[FieldOffset(8)]
			public bool Forece;
		}
	}
}
