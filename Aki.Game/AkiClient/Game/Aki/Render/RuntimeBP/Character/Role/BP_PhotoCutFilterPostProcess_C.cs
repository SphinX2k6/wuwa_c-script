using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Role
{
	// Token: 0x0200311A RID: 12570
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Role/BP_PhotoCutFilterPostProcess.BP_PhotoCutFilterPostProcess_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1588)]
	public class BP_PhotoCutFilterPostProcess_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ECAC RID: 126124 RVA: 0x0091D6A8 File Offset: 0x0091B8A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhotoCutFilterPostProcess_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Role/BP_PhotoCutFilterPostProcess.BP_PhotoCutFilterPostProcess_C");
			}
			return BP_PhotoCutFilterPostProcess_C._ClassPtr;
		}

		// Token: 0x0601ECAD RID: 126125 RVA: 0x0091D6CC File Offset: 0x0091B8CC
		public BP_PhotoCutFilterPostProcess_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhotoCutFilterPostProcess_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ECAE RID: 126126 RVA: 0x0091D6F4 File Offset: 0x0091B8F4
		[NullableContext(1)]
		public BP_PhotoCutFilterPostProcess_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhotoCutFilterPostProcess_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0601ECAF RID: 126127 RVA: 0x0091D727 File Offset: 0x0091B927
		// (set) Token: 0x0601ECB0 RID: 126128 RVA: 0x0091D73B File Offset: 0x0091B93B
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_KuroPostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_KuroPostProcess, value);
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0601ECB1 RID: 126129 RVA: 0x0091D750 File Offset: 0x0091B950
		// (set) Token: 0x0601ECB2 RID: 126130 RVA: 0x0091D764 File Offset: 0x0091B964
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0601ECB3 RID: 126131 RVA: 0x0091D779 File Offset: 0x0091B979
		// (set) Token: 0x0601ECB4 RID: 126132 RVA: 0x0091D78D File Offset: 0x0091B98D
		public unsafe UMaterialInterface PostProcessMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_PostProcessMat);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_PostProcessMat, value);
			}
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0601ECB5 RID: 126133 RVA: 0x0091D7A2 File Offset: 0x0091B9A2
		// (set) Token: 0x0601ECB6 RID: 126134 RVA: 0x0091D7B6 File Offset: 0x0091B9B6
		public unsafe UMaterialInstanceDynamic PostProcessMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_PostProcessMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_PostProcessMI, value);
			}
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0601ECB7 RID: 126135 RVA: 0x0091D7CB File Offset: 0x0091B9CB
		// (set) Token: 0x0601ECB8 RID: 126136 RVA: 0x0091D7DB File Offset: 0x0091B9DB
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_AspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_AspectRatio) = value;
			}
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0601ECB9 RID: 126137 RVA: 0x0091D7EC File Offset: 0x0091B9EC
		// (set) Token: 0x0601ECBA RID: 126138 RVA: 0x0091D7FC File Offset: 0x0091B9FC
		public unsafe float FieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_FieldOfView);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_FieldOfView) = value;
			}
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0601ECBB RID: 126139 RVA: 0x0091D80D File Offset: 0x0091BA0D
		// (set) Token: 0x0601ECBC RID: 126140 RVA: 0x0091D81D File Offset: 0x0091BA1D
		public unsafe float NearPlaneOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_NearPlaneOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_NearPlaneOffset) = value;
			}
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0601ECBD RID: 126141 RVA: 0x0091D82E File Offset: 0x0091BA2E
		// (set) Token: 0x0601ECBE RID: 126142 RVA: 0x0091D842 File Offset: 0x0091BA42
		public unsafe FLinearColor CameraPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraPos) = value;
			}
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0601ECBF RID: 126143 RVA: 0x0091D857 File Offset: 0x0091BA57
		// (set) Token: 0x0601ECC0 RID: 126144 RVA: 0x0091D86B File Offset: 0x0091BA6B
		public unsafe FLinearColor CameraUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraUp) = value;
			}
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0601ECC1 RID: 126145 RVA: 0x0091D880 File Offset: 0x0091BA80
		// (set) Token: 0x0601ECC2 RID: 126146 RVA: 0x0091D894 File Offset: 0x0091BA94
		public unsafe FLinearColor CameraForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraForward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraForward) = value;
			}
		}

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0601ECC3 RID: 126147 RVA: 0x0091D8A9 File Offset: 0x0091BAA9
		// (set) Token: 0x0601ECC4 RID: 126148 RVA: 0x0091D8BD File Offset: 0x0091BABD
		public unsafe FLinearColor CameraRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraRight) = value;
			}
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0601ECC5 RID: 126149 RVA: 0x0091D8D2 File Offset: 0x0091BAD2
		// (set) Token: 0x0601ECC6 RID: 126150 RVA: 0x0091D8E2 File Offset: 0x0091BAE2
		public unsafe bool UseScreenUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_UseScreenUV) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_UseScreenUV) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0601ECC7 RID: 126151 RVA: 0x0091D8F3 File Offset: 0x0091BAF3
		// (set) Token: 0x0601ECC8 RID: 126152 RVA: 0x0091D903 File Offset: 0x0091BB03
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_IsTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_IsTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0601ECC9 RID: 126153 RVA: 0x0091D914 File Offset: 0x0091BB14
		// (set) Token: 0x0601ECCA RID: 126154 RVA: 0x0091D924 File Offset: 0x0091BB24
		public unsafe bool IsTickEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_IsTickEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_IsTickEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0601ECCB RID: 126155 RVA: 0x0091D935 File Offset: 0x0091BB35
		// (set) Token: 0x0601ECCC RID: 126156 RVA: 0x0091D945 File Offset: 0x0091BB45
		public unsafe float CameraClipMaskInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraClipMaskInt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_CameraClipMaskInt) = value;
			}
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0601ECCD RID: 126157 RVA: 0x0091D956 File Offset: 0x0091BB56
		// (set) Token: 0x0601ECCE RID: 126158 RVA: 0x0091D966 File Offset: 0x0091BB66
		public unsafe float ElapsedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_ElapsedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_ElapsedTime) = value;
			}
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0601ECCF RID: 126159 RVA: 0x0091D977 File Offset: 0x0091BB77
		// (set) Token: 0x0601ECD0 RID: 126160 RVA: 0x0091D987 File Offset: 0x0091BB87
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_Delta_Seconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_Delta_Seconds) = value;
			}
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0601ECD1 RID: 126161 RVA: 0x0091D998 File Offset: 0x0091BB98
		// (set) Token: 0x0601ECD2 RID: 126162 RVA: 0x0091D9A8 File Offset: 0x0091BBA8
		public unsafe float LifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_LifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_LifeTime) = value;
			}
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0601ECD3 RID: 126163 RVA: 0x0091D9B9 File Offset: 0x0091BBB9
		// (set) Token: 0x0601ECD4 RID: 126164 RVA: 0x0091D9C9 File Offset: 0x0091BBC9
		public unsafe float EndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_EndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_EndTime) = value;
			}
		}

		// Token: 0x0601ECD5 RID: 126165 RVA: 0x0091D9DA File Offset: 0x0091BBDA
		[SkipLocalsInit]
		public virtual void SwitchScreenUV()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__SwitchScreenUV_NativeFunctionPtr, null);
		}

		// Token: 0x0601ECD6 RID: 126166 RVA: 0x0091D9EE File Offset: 0x0091BBEE
		[SkipLocalsInit]
		public virtual void SetUpPostProcess()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__SetUpPostProcess_NativeFunctionPtr, null);
		}

		// Token: 0x0601ECD7 RID: 126167 RVA: 0x0091DA04 File Offset: 0x0091BC04
		[SkipLocalsInit]
		public unsafe virtual void UpdateFxParams(FVectorDouble CameraLocation, FRotator CameraRotation, float AspectRatio, float FieldOfView)
		{
			BP_PhotoCutFilterPostProcess_C.__UpdateFxParams_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__UpdateFxParams_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__UpdateFxParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__UpdateFxParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CameraLocation = CameraLocation;
			ptr->CameraRotation = CameraRotation;
			ptr->AspectRatio = AspectRatio;
			ptr->FieldOfView = FieldOfView;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__UpdateFxParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ECD8 RID: 126168 RVA: 0x0091DA63 File Offset: 0x0091BC63
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601ECD9 RID: 126169 RVA: 0x0091DA77 File Offset: 0x0091BC77
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601ECDA RID: 126170 RVA: 0x0091DA8C File Offset: 0x0091BC8C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ECDB RID: 126171 RVA: 0x0091DAD4 File Offset: 0x0091BCD4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ECDC RID: 126172 RVA: 0x0091DB1C File Offset: 0x0091BD1C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ECDD RID: 126173 RVA: 0x0091DB64 File Offset: 0x0091BD64
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601ECDE RID: 126174 RVA: 0x0091DBAA File Offset: 0x0091BDAA
		[SkipLocalsInit]
		public virtual void DelayToFadeOut()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__DelayToFadeOut_NativeFunctionPtr, null);
		}

		// Token: 0x0601ECDF RID: 126175 RVA: 0x0091DBBE File Offset: 0x0091BDBE
		protected BP_PhotoCutFilterPostProcess_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040105C1 RID: 67009
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Role/BP_PhotoCutFilterPostProcess.BP_PhotoCutFilterPostProcess_C";

		// Token: 0x040105C2 RID: 67010
		private static IntPtr _ClassPtr;

		// Token: 0x040105C3 RID: 67011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040105C4 RID: 67012
		internal static int __PropertyOffset_KuroPostProcess;

		// Token: 0x040105C5 RID: 67013
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040105C6 RID: 67014
		internal static int __PropertyOffset_PostProcessMat;

		// Token: 0x040105C7 RID: 67015
		internal static int __PropertyOffset_PostProcessMI;

		// Token: 0x040105C8 RID: 67016
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x040105C9 RID: 67017
		internal static int __PropertyOffset_FieldOfView;

		// Token: 0x040105CA RID: 67018
		internal static int __PropertyOffset_NearPlaneOffset;

		// Token: 0x040105CB RID: 67019
		internal static int __PropertyOffset_CameraPos;

		// Token: 0x040105CC RID: 67020
		internal static int __PropertyOffset_CameraUp;

		// Token: 0x040105CD RID: 67021
		internal static int __PropertyOffset_CameraForward;

		// Token: 0x040105CE RID: 67022
		internal static int __PropertyOffset_CameraRight;

		// Token: 0x040105CF RID: 67023
		internal static int __PropertyOffset_UseScreenUV;

		// Token: 0x040105D0 RID: 67024
		internal static int __PropertyOffset_IsTick;

		// Token: 0x040105D1 RID: 67025
		internal static int __PropertyOffset_IsTickEnd;

		// Token: 0x040105D2 RID: 67026
		internal static int __PropertyOffset_CameraClipMaskInt;

		// Token: 0x040105D3 RID: 67027
		internal static int __PropertyOffset_ElapsedTime;

		// Token: 0x040105D4 RID: 67028
		internal static int __PropertyOffset_Delta_Seconds;

		// Token: 0x040105D5 RID: 67029
		internal static int __PropertyOffset_LifeTime;

		// Token: 0x040105D6 RID: 67030
		internal static int __PropertyOffset_EndTime;

		// Token: 0x040105D7 RID: 67031
		private static IntPtr __SwitchScreenUV_NativeFunctionPtr;

		// Token: 0x040105D8 RID: 67032
		private static IntPtr __SetUpPostProcess_NativeFunctionPtr;

		// Token: 0x040105D9 RID: 67033
		private static IntPtr __UpdateFxParams_NativeFunctionPtr;

		// Token: 0x040105DA RID: 67034
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040105DB RID: 67035
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040105DC RID: 67036
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040105DD RID: 67037
		private static IntPtr __DelayToFadeOut_NativeFunctionPtr;

		// Token: 0x02008ED6 RID: 36566
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __UpdateFxParams_FunctionParams
		{
			// Token: 0x0402CB90 RID: 183184
			[FieldOffset(0)]
			public FVectorDouble CameraLocation;

			// Token: 0x0402CB91 RID: 183185
			[FieldOffset(24)]
			public FRotator CameraRotation;

			// Token: 0x0402CB92 RID: 183186
			[FieldOffset(36)]
			public float AspectRatio;

			// Token: 0x0402CB93 RID: 183187
			[FieldOffset(40)]
			public float FieldOfView;
		}

		// Token: 0x02008ED7 RID: 36567
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CB94 RID: 183188
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008ED8 RID: 36568
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CB95 RID: 183189
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
