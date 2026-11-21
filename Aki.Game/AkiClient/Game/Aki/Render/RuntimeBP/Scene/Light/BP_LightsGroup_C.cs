using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x020030B4 RID: 12468
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightsGroup.BP_LightsGroup_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1145)]
	public class BP_LightsGroup_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DF2B RID: 122667 RVA: 0x00906BC2 File Offset: 0x00904DC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LightsGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightsGroup.BP_LightsGroup_C");
			}
			return BP_LightsGroup_C._ClassPtr;
		}

		// Token: 0x0601DF2C RID: 122668 RVA: 0x00906BE8 File Offset: 0x00904DE8
		public BP_LightsGroup_C() : this(BuiltinUtils.AllocNativeUObject(BP_LightsGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DF2D RID: 122669 RVA: 0x00906C10 File Offset: 0x00904E10
		[NullableContext(1)]
		public BP_LightsGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LightsGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0601DF2E RID: 122670 RVA: 0x00906C43 File Offset: 0x00904E43
		// (set) Token: 0x0601DF2F RID: 122671 RVA: 0x00906C57 File Offset: 0x00904E57
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightsGroup_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightsGroup_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0601DF30 RID: 122672 RVA: 0x00906C6C File Offset: 0x00904E6C
		// (set) Token: 0x0601DF31 RID: 122673 RVA: 0x00906C7C File Offset: 0x00904E7C
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_IsTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_IsTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0601DF32 RID: 122674 RVA: 0x00906C8D File Offset: 0x00904E8D
		// (set) Token: 0x0601DF33 RID: 122675 RVA: 0x00906C9D File Offset: 0x00904E9D
		public unsafe bool TurnOffOrOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_TurnOffOrOn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_TurnOffOrOn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x0601DF34 RID: 122676 RVA: 0x00906CAE File Offset: 0x00904EAE
		// (set) Token: 0x0601DF35 RID: 122677 RVA: 0x00906CBE File Offset: 0x00904EBE
		public unsafe bool UseSimpleToggle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_UseSimpleToggle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_UseSimpleToggle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x0601DF36 RID: 122678 RVA: 0x00906CCF File Offset: 0x00904ECF
		// (set) Token: 0x0601DF37 RID: 122679 RVA: 0x00906CDF File Offset: 0x00904EDF
		public unsafe bool UseColorChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_UseColorChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_UseColorChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x0601DF38 RID: 122680 RVA: 0x00906CF0 File Offset: 0x00904EF0
		// (set) Token: 0x0601DF39 RID: 122681 RVA: 0x00906D00 File Offset: 0x00904F00
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x0601DF3A RID: 122682 RVA: 0x00906D11 File Offset: 0x00904F11
		// (set) Token: 0x0601DF3B RID: 122683 RVA: 0x00906D21 File Offset: 0x00904F21
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0601DF3C RID: 122684 RVA: 0x00906D32 File Offset: 0x00904F32
		// (set) Token: 0x0601DF3D RID: 122685 RVA: 0x00906D42 File Offset: 0x00904F42
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_DeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_DeltaSeconds) = value;
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0601DF3E RID: 122686 RVA: 0x00906D54 File Offset: 0x00904F54
		// (set) Token: 0x0601DF3F RID: 122687 RVA: 0x00906D8D File Offset: 0x00904F8D
		[Nullable(1)]
		public TArray<float> LightsIntensity
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LightsIntensity) == null)
				{
					result = (this._LightsIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_LightsIntensity, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightsIntensity.CopyAssign(value);
			}
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0601DF40 RID: 122688 RVA: 0x00906D9B File Offset: 0x00904F9B
		// (set) Token: 0x0601DF41 RID: 122689 RVA: 0x00906DAF File Offset: 0x00904FAF
		public unsafe FLinearColor ColorOriginal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_ColorOriginal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_ColorOriginal) = value;
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0601DF42 RID: 122690 RVA: 0x00906DC4 File Offset: 0x00904FC4
		// (set) Token: 0x0601DF43 RID: 122691 RVA: 0x00906DD8 File Offset: 0x00904FD8
		public unsafe FLinearColor ColorTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_ColorTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_ColorTarget) = value;
			}
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0601DF44 RID: 122692 RVA: 0x00906DED File Offset: 0x00904FED
		// (set) Token: 0x0601DF45 RID: 122693 RVA: 0x00906E01 File Offset: 0x00905001
		[Nullable(1)]
		public unsafe string Test
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_LightsGroup_C.__PropertyOffset_Test)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_LightsGroup_C.__PropertyOffset_Test)), value);
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0601DF46 RID: 122694 RVA: 0x00906E16 File Offset: 0x00905016
		// (set) Token: 0x0601DF47 RID: 122695 RVA: 0x00906E26 File Offset: 0x00905026
		public unsafe bool EnableLightsOnBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_EnableLightsOnBeginPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightsGroup_C.__PropertyOffset_EnableLightsOnBeginPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601DF48 RID: 122696 RVA: 0x00906E38 File Offset: 0x00905038
		[SkipLocalsInit]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601DF49 RID: 122697 RVA: 0x00906E80 File Offset: 0x00905080
		[SkipLocalsInit]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightsGroup_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightsGroup_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601DF4A RID: 122698 RVA: 0x00906EC8 File Offset: 0x009050C8
		[SkipLocalsInit]
		public unsafe virtual void LightsColorChange(float ElapsedTime, FLinearColor ColorOriginal, FLinearColor ColorTarget)
		{
			BP_LightsGroup_C.__LightsColorChange_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__LightsColorChange_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_LightsGroup_C.__LightsColorChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__LightsColorChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			ptr->ColorOriginal = ColorOriginal;
			ptr->ColorTarget = ColorTarget;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__LightsColorChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF4B RID: 122699 RVA: 0x00906F1F File Offset: 0x0090511F
		[SkipLocalsInit]
		public virtual void ToggleLightsColorChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ToggleLightsColorChange_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF4C RID: 122700 RVA: 0x00906F33 File Offset: 0x00905133
		[SkipLocalsInit]
		public virtual void GetLightsIntensity()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__GetLightsIntensity_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF4D RID: 122701 RVA: 0x00906F48 File Offset: 0x00905148
		[SkipLocalsInit]
		public unsafe virtual void Timer(ref float ElapsedTime)
		{
			BP_LightsGroup_C.__Timer_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__Timer_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_LightsGroup_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x0601DF4E RID: 122702 RVA: 0x00906F98 File Offset: 0x00905198
		[SkipLocalsInit]
		public unsafe virtual void TurnOnLights(float ElapsedTime)
		{
			BP_LightsGroup_C.__TurnOnLights_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__TurnOnLights_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_LightsGroup_C.__TurnOnLights_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__TurnOnLights_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__TurnOnLights_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF4F RID: 122703 RVA: 0x00906FE0 File Offset: 0x009051E0
		[SkipLocalsInit]
		public unsafe virtual void TurnOffLights(float ElapsedTime)
		{
			BP_LightsGroup_C.__TurnOffLights_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__TurnOffLights_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_LightsGroup_C.__TurnOffLights_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__TurnOffLights_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__TurnOffLights_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF50 RID: 122704 RVA: 0x00907026 File Offset: 0x00905226
		[SkipLocalsInit]
		public virtual void ToggleLightsIntensity()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ToggleLightsIntensity_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF51 RID: 122705 RVA: 0x0090703C File Offset: 0x0090523C
		[SkipLocalsInit]
		public unsafe virtual void ToggleLights(bool inEnable)
		{
			BP_LightsGroup_C.__ToggleLights_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__ToggleLights_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_LightsGroup_C.__ToggleLights_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__ToggleLights_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inEnable = inEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ToggleLights_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF52 RID: 122706 RVA: 0x00907085 File Offset: 0x00905285
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF53 RID: 122707 RVA: 0x00907099 File Offset: 0x00905299
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightsGroup_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF54 RID: 122708 RVA: 0x009070B0 File Offset: 0x009052B0
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LightsGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightsGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightsGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF55 RID: 122709 RVA: 0x009070F8 File Offset: 0x009052F8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LightsGroup_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightsGroup_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightsGroup_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightsGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightsGroup_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF56 RID: 122710 RVA: 0x0090713E File Offset: 0x0090533E
		protected BP_LightsGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD20 RID: 64800
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightsGroup.BP_LightsGroup_C";

		// Token: 0x0400FD21 RID: 64801
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD22 RID: 64802
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD23 RID: 64803
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FD24 RID: 64804
		internal static int __PropertyOffset_IsTick;

		// Token: 0x0400FD25 RID: 64805
		internal static int __PropertyOffset_TurnOffOrOn;

		// Token: 0x0400FD26 RID: 64806
		internal static int __PropertyOffset_UseSimpleToggle;

		// Token: 0x0400FD27 RID: 64807
		internal static int __PropertyOffset_UseColorChange;

		// Token: 0x0400FD28 RID: 64808
		internal static int __PropertyOffset_Time;

		// Token: 0x0400FD29 RID: 64809
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400FD2A RID: 64810
		internal static int __PropertyOffset_DeltaSeconds;

		// Token: 0x0400FD2B RID: 64811
		internal static int __PropertyOffset_LightsIntensity;

		// Token: 0x0400FD2C RID: 64812
		[Nullable(2)]
		private TArray<float> _LightsIntensity;

		// Token: 0x0400FD2D RID: 64813
		internal static int __PropertyOffset_ColorOriginal;

		// Token: 0x0400FD2E RID: 64814
		internal static int __PropertyOffset_ColorTarget;

		// Token: 0x0400FD2F RID: 64815
		internal static int __PropertyOffset_Test;

		// Token: 0x0400FD30 RID: 64816
		internal static int __PropertyOffset_EnableLightsOnBeginPlay;

		// Token: 0x0400FD31 RID: 64817
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x0400FD32 RID: 64818
		private static IntPtr __LightsColorChange_NativeFunctionPtr;

		// Token: 0x0400FD33 RID: 64819
		private static IntPtr __ToggleLightsColorChange_NativeFunctionPtr;

		// Token: 0x0400FD34 RID: 64820
		private static IntPtr __GetLightsIntensity_NativeFunctionPtr;

		// Token: 0x0400FD35 RID: 64821
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x0400FD36 RID: 64822
		private static IntPtr __TurnOnLights_NativeFunctionPtr;

		// Token: 0x0400FD37 RID: 64823
		private static IntPtr __TurnOffLights_NativeFunctionPtr;

		// Token: 0x0400FD38 RID: 64824
		private static IntPtr __ToggleLightsIntensity_NativeFunctionPtr;

		// Token: 0x0400FD39 RID: 64825
		private static IntPtr __ToggleLights_NativeFunctionPtr;

		// Token: 0x0400FD3A RID: 64826
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FD3B RID: 64827
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008DF1 RID: 36337
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x0402CA12 RID: 182802
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02008DF2 RID: 36338
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __LightsColorChange_FunctionParams
		{
			// Token: 0x0402CA13 RID: 182803
			[FieldOffset(0)]
			public float ElapsedTime;

			// Token: 0x0402CA14 RID: 182804
			[FieldOffset(4)]
			public FLinearColor ColorOriginal;

			// Token: 0x0402CA15 RID: 182805
			[FieldOffset(20)]
			public FLinearColor ColorTarget;
		}

		// Token: 0x02008DF3 RID: 36339
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x0402CA16 RID: 182806
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02008DF4 RID: 36340
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __TurnOnLights_FunctionParams
		{
			// Token: 0x0402CA17 RID: 182807
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02008DF5 RID: 36341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __TurnOffLights_FunctionParams
		{
			// Token: 0x0402CA18 RID: 182808
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02008DF6 RID: 36342
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __ToggleLights_FunctionParams
		{
			// Token: 0x0402CA19 RID: 182809
			[FieldOffset(0)]
			public bool inEnable;
		}

		// Token: 0x02008DF7 RID: 36343
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA1A RID: 182810
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
