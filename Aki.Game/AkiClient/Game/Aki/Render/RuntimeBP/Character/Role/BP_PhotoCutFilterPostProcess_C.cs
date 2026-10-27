using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Role
{
	// Token: 0x02003DF8 RID: 15864
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Role/BP_PhotoCutFilterPostProcess.BP_PhotoCutFilterPostProcess_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1588)]
	public class BP_PhotoCutFilterPostProcess_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060279DE RID: 162270 RVA: 0x009963BA File Offset: 0x009945BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhotoCutFilterPostProcess_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Role/BP_PhotoCutFilterPostProcess.BP_PhotoCutFilterPostProcess_C");
			}
			return BP_PhotoCutFilterPostProcess_C._ClassPtr;
		}

		// Token: 0x060279DF RID: 162271 RVA: 0x009963E0 File Offset: 0x009945E0
		public BP_PhotoCutFilterPostProcess_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhotoCutFilterPostProcess_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060279E0 RID: 162272 RVA: 0x00996408 File Offset: 0x00994608
		[NullableContext(1)]
		public BP_PhotoCutFilterPostProcess_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhotoCutFilterPostProcess_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005907 RID: 22791
		// (get) Token: 0x060279E1 RID: 162273 RVA: 0x0099643B File Offset: 0x0099463B
		// (set) Token: 0x060279E2 RID: 162274 RVA: 0x0099644F File Offset: 0x0099464F
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005908 RID: 22792
		// (get) Token: 0x060279E3 RID: 162275 RVA: 0x00996464 File Offset: 0x00994664
		// (set) Token: 0x060279E4 RID: 162276 RVA: 0x00996478 File Offset: 0x00994678
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005909 RID: 22793
		// (get) Token: 0x060279E5 RID: 162277 RVA: 0x0099648D File Offset: 0x0099468D
		// (set) Token: 0x060279E6 RID: 162278 RVA: 0x009964A1 File Offset: 0x009946A1
		public unsafe UMaterialInterface PostProcessMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700590A RID: 22794
		// (get) Token: 0x060279E7 RID: 162279 RVA: 0x009964B6 File Offset: 0x009946B6
		// (set) Token: 0x060279E8 RID: 162280 RVA: 0x009964CA File Offset: 0x009946CA
		public unsafe UMaterialInstanceDynamic PostProcessMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhotoCutFilterPostProcess_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700590B RID: 22795
		// (get) Token: 0x060279E9 RID: 162281 RVA: 0x009964DF File Offset: 0x009946DF
		// (set) Token: 0x060279EA RID: 162282 RVA: 0x009964EF File Offset: 0x009946EF
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700590C RID: 22796
		// (get) Token: 0x060279EB RID: 162283 RVA: 0x00996500 File Offset: 0x00994700
		// (set) Token: 0x060279EC RID: 162284 RVA: 0x00996510 File Offset: 0x00994710
		public unsafe float FieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700590D RID: 22797
		// (get) Token: 0x060279ED RID: 162285 RVA: 0x00996521 File Offset: 0x00994721
		// (set) Token: 0x060279EE RID: 162286 RVA: 0x00996531 File Offset: 0x00994731
		public unsafe float NearPlaneOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700590E RID: 22798
		// (get) Token: 0x060279EF RID: 162287 RVA: 0x00996542 File Offset: 0x00994742
		// (set) Token: 0x060279F0 RID: 162288 RVA: 0x00996556 File Offset: 0x00994756
		public unsafe FLinearColor CameraPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700590F RID: 22799
		// (get) Token: 0x060279F1 RID: 162289 RVA: 0x0099656B File Offset: 0x0099476B
		// (set) Token: 0x060279F2 RID: 162290 RVA: 0x0099657F File Offset: 0x0099477F
		public unsafe FLinearColor CameraUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005910 RID: 22800
		// (get) Token: 0x060279F3 RID: 162291 RVA: 0x00996594 File Offset: 0x00994794
		// (set) Token: 0x060279F4 RID: 162292 RVA: 0x009965A8 File Offset: 0x009947A8
		public unsafe FLinearColor CameraForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005911 RID: 22801
		// (get) Token: 0x060279F5 RID: 162293 RVA: 0x009965BD File Offset: 0x009947BD
		// (set) Token: 0x060279F6 RID: 162294 RVA: 0x009965D1 File Offset: 0x009947D1
		public unsafe FLinearColor CameraRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005912 RID: 22802
		// (get) Token: 0x060279F7 RID: 162295 RVA: 0x009965E6 File Offset: 0x009947E6
		// (set) Token: 0x060279F8 RID: 162296 RVA: 0x009965F6 File Offset: 0x009947F6
		public unsafe bool UseScreenUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005913 RID: 22803
		// (get) Token: 0x060279F9 RID: 162297 RVA: 0x00996607 File Offset: 0x00994807
		// (set) Token: 0x060279FA RID: 162298 RVA: 0x00996617 File Offset: 0x00994817
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005914 RID: 22804
		// (get) Token: 0x060279FB RID: 162299 RVA: 0x00996628 File Offset: 0x00994828
		// (set) Token: 0x060279FC RID: 162300 RVA: 0x00996638 File Offset: 0x00994838
		public unsafe bool IsTickEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005915 RID: 22805
		// (get) Token: 0x060279FD RID: 162301 RVA: 0x00996649 File Offset: 0x00994849
		// (set) Token: 0x060279FE RID: 162302 RVA: 0x00996659 File Offset: 0x00994859
		public unsafe float CameraClipMaskInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005916 RID: 22806
		// (get) Token: 0x060279FF RID: 162303 RVA: 0x0099666A File Offset: 0x0099486A
		// (set) Token: 0x06027A00 RID: 162304 RVA: 0x0099667A File Offset: 0x0099487A
		public unsafe float ElapsedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005917 RID: 22807
		// (get) Token: 0x06027A01 RID: 162305 RVA: 0x0099668B File Offset: 0x0099488B
		// (set) Token: 0x06027A02 RID: 162306 RVA: 0x0099669B File Offset: 0x0099489B
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005918 RID: 22808
		// (get) Token: 0x06027A03 RID: 162307 RVA: 0x009966AC File Offset: 0x009948AC
		// (set) Token: 0x06027A04 RID: 162308 RVA: 0x009966BC File Offset: 0x009948BC
		public unsafe float LifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005919 RID: 22809
		// (get) Token: 0x06027A05 RID: 162309 RVA: 0x009966CD File Offset: 0x009948CD
		// (set) Token: 0x06027A06 RID: 162310 RVA: 0x009966DD File Offset: 0x009948DD
		public unsafe float EndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCutFilterPostProcess_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x06027A07 RID: 162311 RVA: 0x009966EE File Offset: 0x009948EE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SwitchScreenUV()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__SwitchScreenUV_NativeFunctionPtr, null);
		}

		// Token: 0x06027A08 RID: 162312 RVA: 0x00996702 File Offset: 0x00994902
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetUpPostProcess()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__SetUpPostProcess_NativeFunctionPtr, null);
		}

		// Token: 0x06027A09 RID: 162313 RVA: 0x00996718 File Offset: 0x00994918
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027A0A RID: 162314 RVA: 0x00996777 File Offset: 0x00994977
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027A0B RID: 162315 RVA: 0x0099678B File Offset: 0x0099498B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027A0C RID: 162316 RVA: 0x009967A0 File Offset: 0x009949A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027A0D RID: 162317 RVA: 0x009967E8 File Offset: 0x009949E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027A0E RID: 162318 RVA: 0x00996830 File Offset: 0x00994A30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027A0F RID: 162319 RVA: 0x00996878 File Offset: 0x00994A78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhotoCutFilterPostProcess_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhotoCutFilterPostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027A10 RID: 162320 RVA: 0x009968BF File Offset: 0x00994ABF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DelayToFadeOut()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhotoCutFilterPostProcess_C.__DelayToFadeOut_NativeFunctionPtr, null);
		}

		// Token: 0x06027A11 RID: 162321 RVA: 0x009968D3 File Offset: 0x00994AD3
		protected BP_PhotoCutFilterPostProcess_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014094 RID: 82068
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Role/BP_PhotoCutFilterPostProcess.BP_PhotoCutFilterPostProcess_C";

		// Token: 0x04014095 RID: 82069
		private static IntPtr _ClassPtr;

		// Token: 0x04014096 RID: 82070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014097 RID: 82071
		internal static int __PropertyOffset_1;

		// Token: 0x04014098 RID: 82072
		internal static int __PropertyOffset_2;

		// Token: 0x04014099 RID: 82073
		internal static int __PropertyOffset_3;

		// Token: 0x0401409A RID: 82074
		internal static int __PropertyOffset_4;

		// Token: 0x0401409B RID: 82075
		internal static int __PropertyOffset_5;

		// Token: 0x0401409C RID: 82076
		internal static int __PropertyOffset_6;

		// Token: 0x0401409D RID: 82077
		internal static int __PropertyOffset_7;

		// Token: 0x0401409E RID: 82078
		internal static int __PropertyOffset_8;

		// Token: 0x0401409F RID: 82079
		internal static int __PropertyOffset_9;

		// Token: 0x040140A0 RID: 82080
		internal static int __PropertyOffset_10;

		// Token: 0x040140A1 RID: 82081
		internal static int __PropertyOffset_11;

		// Token: 0x040140A2 RID: 82082
		internal static int __PropertyOffset_12;

		// Token: 0x040140A3 RID: 82083
		internal static int __PropertyOffset_13;

		// Token: 0x040140A4 RID: 82084
		internal static int __PropertyOffset_14;

		// Token: 0x040140A5 RID: 82085
		internal static int __PropertyOffset_15;

		// Token: 0x040140A6 RID: 82086
		internal static int __PropertyOffset_16;

		// Token: 0x040140A7 RID: 82087
		internal static int __PropertyOffset_17;

		// Token: 0x040140A8 RID: 82088
		internal static int __PropertyOffset_18;

		// Token: 0x040140A9 RID: 82089
		internal static int __PropertyOffset_19;

		// Token: 0x040140AA RID: 82090
		private static IntPtr __SwitchScreenUV_NativeFunctionPtr;

		// Token: 0x040140AB RID: 82091
		private static IntPtr __SetUpPostProcess_NativeFunctionPtr;

		// Token: 0x040140AC RID: 82092
		private static IntPtr __UpdateFxParams_NativeFunctionPtr;

		// Token: 0x040140AD RID: 82093
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040140AE RID: 82094
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040140AF RID: 82095
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040140B0 RID: 82096
		private static IntPtr __DelayToFadeOut_NativeFunctionPtr;

		// Token: 0x0200A255 RID: 41557
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __UpdateFxParams_FunctionParams
		{
			// Token: 0x04031EF0 RID: 204528
			[FieldOffset(0)]
			public FVectorDouble CameraLocation;

			// Token: 0x04031EF1 RID: 204529
			[FieldOffset(24)]
			public FRotator CameraRotation;

			// Token: 0x04031EF2 RID: 204530
			[FieldOffset(36)]
			public float AspectRatio;

			// Token: 0x04031EF3 RID: 204531
			[FieldOffset(40)]
			public float FieldOfView;
		}

		// Token: 0x0200A256 RID: 41558
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031EF4 RID: 204532
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A257 RID: 41559
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031EF5 RID: 204533
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
