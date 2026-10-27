using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.Loading.View
{
	// Token: 0x020039D4 RID: 14804
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/Loading/View/WBP_UILoading.WBP_UILoading_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1340)]
	public class WBP_UILoading_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF45 RID: 126789 RVA: 0x008A5C20 File Offset: 0x008A3E20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_UILoading_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/Loading/View/WBP_UILoading.WBP_UILoading_C");
			}
			return WBP_UILoading_C._ClassPtr;
		}

		// Token: 0x0601EF46 RID: 126790 RVA: 0x008A5C44 File Offset: 0x008A3E44
		public WBP_UILoading_C() : this(BuiltinUtils.AllocNativeUObject(WBP_UILoading_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF47 RID: 126791 RVA: 0x008A5C6C File Offset: 0x008A3E6C
		[NullableContext(1)]
		public WBP_UILoading_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_UILoading_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0601EF48 RID: 126792 RVA: 0x008A5C9F File Offset: 0x008A3E9F
		// (set) Token: 0x0601EF49 RID: 126793 RVA: 0x008A5CB3 File Offset: 0x008A3EB3
		public unsafe UImage Image
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0601EF4A RID: 126794 RVA: 0x008A5CC8 File Offset: 0x008A3EC8
		// (set) Token: 0x0601EF4B RID: 126795 RVA: 0x008A5CDC File Offset: 0x008A3EDC
		public unsafe UImage Image_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0601EF4C RID: 126796 RVA: 0x008A5CF1 File Offset: 0x008A3EF1
		// (set) Token: 0x0601EF4D RID: 126797 RVA: 0x008A5D05 File Offset: 0x008A3F05
		public unsafe UImage Image_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x0601EF4E RID: 126798 RVA: 0x008A5D1A File Offset: 0x008A3F1A
		// (set) Token: 0x0601EF4F RID: 126799 RVA: 0x008A5D2E File Offset: 0x008A3F2E
		public unsafe UImage Image_Background
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x0601EF50 RID: 126800 RVA: 0x008A5D43 File Offset: 0x008A3F43
		// (set) Token: 0x0601EF51 RID: 126801 RVA: 0x008A5D57 File Offset: 0x008A3F57
		public unsafe UKuroUMGSafeZone KuroUMGSafeZone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroUMGSafeZone>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x0601EF52 RID: 126802 RVA: 0x008A5D6C File Offset: 0x008A3F6C
		// (set) Token: 0x0601EF53 RID: 126803 RVA: 0x008A5D80 File Offset: 0x008A3F80
		public unsafe UProgressBar ProgressBar
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProgressBar>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x0601EF54 RID: 126804 RVA: 0x008A5D95 File Offset: 0x008A3F95
		// (set) Token: 0x0601EF55 RID: 126805 RVA: 0x008A5DA9 File Offset: 0x008A3FA9
		public unsafe UTextBlock ProgressText
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0601EF56 RID: 126806 RVA: 0x008A5DBE File Offset: 0x008A3FBE
		// (set) Token: 0x0601EF57 RID: 126807 RVA: 0x008A5DD2 File Offset: 0x008A3FD2
		public unsafe UImage TexBg
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0601EF58 RID: 126808 RVA: 0x008A5DE7 File Offset: 0x008A3FE7
		// (set) Token: 0x0601EF59 RID: 126809 RVA: 0x008A5DFB File Offset: 0x008A3FFB
		public unsafe UImage TexBgDeco
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x0601EF5A RID: 126810 RVA: 0x008A5E10 File Offset: 0x008A4010
		// (set) Token: 0x0601EF5B RID: 126811 RVA: 0x008A5E24 File Offset: 0x008A4024
		public unsafe UImage TexProgressHandle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0601EF5C RID: 126812 RVA: 0x008A5E39 File Offset: 0x008A4039
		// (set) Token: 0x0601EF5D RID: 126813 RVA: 0x008A5E4D File Offset: 0x008A404D
		public unsafe UTextBlock Tips
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x0601EF5E RID: 126814 RVA: 0x008A5E62 File Offset: 0x008A4062
		// (set) Token: 0x0601EF5F RID: 126815 RVA: 0x008A5E76 File Offset: 0x008A4076
		public unsafe UTextBlock Title
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_UILoading_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x0601EF60 RID: 126816 RVA: 0x008A5E8B File Offset: 0x008A408B
		// (set) Token: 0x0601EF61 RID: 126817 RVA: 0x008A5E9B File Offset: 0x008A409B
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x0601EF62 RID: 126818 RVA: 0x008A5EAC File Offset: 0x008A40AC
		// (set) Token: 0x0601EF63 RID: 126819 RVA: 0x008A5EBC File Offset: 0x008A40BC
		public unsafe float FirstProgressRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x0601EF64 RID: 126820 RVA: 0x008A5ECD File Offset: 0x008A40CD
		// (set) Token: 0x0601EF65 RID: 126821 RVA: 0x008A5EDD File Offset: 0x008A40DD
		public unsafe float SecondeLoadingRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x0601EF66 RID: 126822 RVA: 0x008A5EEE File Offset: 0x008A40EE
		// (set) Token: 0x0601EF67 RID: 126823 RVA: 0x008A5EFE File Offset: 0x008A40FE
		public unsafe float FirstSpeedRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x0601EF68 RID: 126824 RVA: 0x008A5F0F File Offset: 0x008A410F
		// (set) Token: 0x0601EF69 RID: 126825 RVA: 0x008A5F1F File Offset: 0x008A411F
		public unsafe float SecondSpeedRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x0601EF6A RID: 126826 RVA: 0x008A5F30 File Offset: 0x008A4130
		// (set) Token: 0x0601EF6B RID: 126827 RVA: 0x008A5F40 File Offset: 0x008A4140
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x0601EF6C RID: 126828 RVA: 0x008A5F51 File Offset: 0x008A4151
		// (set) Token: 0x0601EF6D RID: 126829 RVA: 0x008A5F61 File Offset: 0x008A4161
		public unsafe float ClampProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x0601EF6E RID: 126830 RVA: 0x008A5F72 File Offset: 0x008A4172
		// (set) Token: 0x0601EF6F RID: 126831 RVA: 0x008A5F82 File Offset: 0x008A4182
		public unsafe float SpeedRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x0601EF70 RID: 126832 RVA: 0x008A5F94 File Offset: 0x008A4194
		// (set) Token: 0x0601EF71 RID: 126833 RVA: 0x008A5FCD File Offset: 0x008A41CD
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
					result = (this._UIOnlyInputModeReply = new FInputModeReply(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_21, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputModeReply.StaticStruct(), base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_21, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x0601EF72 RID: 126834 RVA: 0x008A5FEE File Offset: 0x008A41EE
		// (set) Token: 0x0601EF73 RID: 126835 RVA: 0x008A5FFE File Offset: 0x008A41FE
		public unsafe float ProgressBarWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_UILoading_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x0601EF74 RID: 126836 RVA: 0x008A600F File Offset: 0x008A420F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MoveProgressHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__MoveProgressHandle_NativeFunctionPtr, null);
		}

		// Token: 0x0601EF75 RID: 126837 RVA: 0x008A6023 File Offset: 0x008A4223
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshProgressBarWidth()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__RefreshProgressBarWidth_NativeFunctionPtr, null);
		}

		// Token: 0x0601EF76 RID: 126838 RVA: 0x008A6037 File Offset: 0x008A4237
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RebootFinished()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__RebootFinished_NativeFunctionPtr, null);
		}

		// Token: 0x0601EF77 RID: 126839 RVA: 0x008A604C File Offset: 0x008A424C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateOtherLoadingProgerss(float InProgress)
		{
			WBP_UILoading_C.__UpdateOtherLoadingProgerss_FunctionParams* ptr = stackalloc WBP_UILoading_C.__UpdateOtherLoadingProgerss_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(WBP_UILoading_C.__UpdateOtherLoadingProgerss_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_UILoading_C.__UpdateOtherLoadingProgerss_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InProgress = InProgress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__UpdateOtherLoadingProgerss_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EF78 RID: 126840 RVA: 0x008A6094 File Offset: 0x008A4294
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetProgress(float InProgress, float ClampProgress, bool Forece)
		{
			WBP_UILoading_C.__SetProgress_FunctionParams* ptr = stackalloc WBP_UILoading_C.__SetProgress_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(WBP_UILoading_C.__SetProgress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_UILoading_C.__SetProgress_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InProgress = InProgress;
			ptr->ClampProgress = ClampProgress;
			ptr->Forece = Forece;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__SetProgress_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EF79 RID: 126841 RVA: 0x008A60EC File Offset: 0x008A42EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_UILoading_C.__Tick_FunctionParams* ptr = stackalloc WBP_UILoading_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_UILoading_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_UILoading_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EF7A RID: 126842 RVA: 0x008A6154 File Offset: 0x008A4354
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_UILoading_C.__Tick_FunctionParams* ptr = stackalloc WBP_UILoading_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_UILoading_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_UILoading_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_UILoading_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601EF7B RID: 126843 RVA: 0x008A61BD File Offset: 0x008A43BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void Construct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__Construct_NativeFunctionPtr, null);
		}

		// Token: 0x0601EF7C RID: 126844 RVA: 0x008A61D1 File Offset: 0x008A43D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void Construct_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_UILoading_C.__Construct_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601EF7D RID: 126845 RVA: 0x008A61E6 File Offset: 0x008A43E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void Destruct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_UILoading_C.__Destruct_NativeFunctionPtr, null);
		}

		// Token: 0x0601EF7E RID: 126846 RVA: 0x008A61FA File Offset: 0x008A43FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void Destruct_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_UILoading_C.__Destruct_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601EF7F RID: 126847 RVA: 0x008A620F File Offset: 0x008A440F
		protected WBP_UILoading_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ECFB RID: 60667
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/Loading/View/WBP_UILoading.WBP_UILoading_C";

		// Token: 0x0400ECFC RID: 60668
		private static IntPtr _ClassPtr;

		// Token: 0x0400ECFD RID: 60669
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ECFE RID: 60670
		internal static int __PropertyOffset_1;

		// Token: 0x0400ECFF RID: 60671
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED00 RID: 60672
		internal static int __PropertyOffset_3;

		// Token: 0x0400ED01 RID: 60673
		internal static int __PropertyOffset_4;

		// Token: 0x0400ED02 RID: 60674
		internal static int __PropertyOffset_5;

		// Token: 0x0400ED03 RID: 60675
		internal static int __PropertyOffset_6;

		// Token: 0x0400ED04 RID: 60676
		internal static int __PropertyOffset_7;

		// Token: 0x0400ED05 RID: 60677
		internal static int __PropertyOffset_8;

		// Token: 0x0400ED06 RID: 60678
		internal static int __PropertyOffset_9;

		// Token: 0x0400ED07 RID: 60679
		internal static int __PropertyOffset_10;

		// Token: 0x0400ED08 RID: 60680
		internal static int __PropertyOffset_11;

		// Token: 0x0400ED09 RID: 60681
		internal static int __PropertyOffset_12;

		// Token: 0x0400ED0A RID: 60682
		internal static int __PropertyOffset_13;

		// Token: 0x0400ED0B RID: 60683
		internal static int __PropertyOffset_14;

		// Token: 0x0400ED0C RID: 60684
		internal static int __PropertyOffset_15;

		// Token: 0x0400ED0D RID: 60685
		internal static int __PropertyOffset_16;

		// Token: 0x0400ED0E RID: 60686
		internal static int __PropertyOffset_17;

		// Token: 0x0400ED0F RID: 60687
		internal static int __PropertyOffset_18;

		// Token: 0x0400ED10 RID: 60688
		internal static int __PropertyOffset_19;

		// Token: 0x0400ED11 RID: 60689
		internal static int __PropertyOffset_20;

		// Token: 0x0400ED12 RID: 60690
		internal static int __PropertyOffset_21;

		// Token: 0x0400ED13 RID: 60691
		private FInputModeReply _UIOnlyInputModeReply;

		// Token: 0x0400ED14 RID: 60692
		internal static int __PropertyOffset_22;

		// Token: 0x0400ED15 RID: 60693
		private static IntPtr __MoveProgressHandle_NativeFunctionPtr;

		// Token: 0x0400ED16 RID: 60694
		private static IntPtr __RefreshProgressBarWidth_NativeFunctionPtr;

		// Token: 0x0400ED17 RID: 60695
		private static IntPtr __RebootFinished_NativeFunctionPtr;

		// Token: 0x0400ED18 RID: 60696
		private static IntPtr __UpdateOtherLoadingProgerss_NativeFunctionPtr;

		// Token: 0x0400ED19 RID: 60697
		private static IntPtr __SetProgress_NativeFunctionPtr;

		// Token: 0x0400ED1A RID: 60698
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0400ED1B RID: 60699
		private static IntPtr __Construct_NativeFunctionPtr;

		// Token: 0x0400ED1C RID: 60700
		private static IntPtr __Destruct_NativeFunctionPtr;

		// Token: 0x020099CB RID: 39371
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateOtherLoadingProgerss_FunctionParams
		{
			// Token: 0x04030E94 RID: 200340
			[FieldOffset(0)]
			public float InProgress;
		}

		// Token: 0x020099CC RID: 39372
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __SetProgress_FunctionParams
		{
			// Token: 0x04030E95 RID: 200341
			[FieldOffset(0)]
			public float InProgress;

			// Token: 0x04030E96 RID: 200342
			[FieldOffset(4)]
			public float ClampProgress;

			// Token: 0x04030E97 RID: 200343
			[FieldOffset(8)]
			public bool Forece;
		}

		// Token: 0x020099CD RID: 39373
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x04030E98 RID: 200344
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04030E99 RID: 200345
			[FieldOffset(56)]
			public float InDeltaTime;
		}
	}
}
