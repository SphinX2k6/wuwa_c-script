using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2
{
	// Token: 0x02003BC1 RID: 15297
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_RoofRainDropActivator.BP_RoofRainDropActivator_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_RoofRainDropActivator_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060223FD RID: 140285 RVA: 0x00903832 File Offset: 0x00901A32
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RoofRainDropActivator_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_RoofRainDropActivator.BP_RoofRainDropActivator_C");
			}
			return BP_RoofRainDropActivator_C._ClassPtr;
		}

		// Token: 0x060223FE RID: 140286 RVA: 0x00903858 File Offset: 0x00901A58
		public BP_RoofRainDropActivator_C() : this(BuiltinUtils.AllocNativeUObject(BP_RoofRainDropActivator_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060223FF RID: 140287 RVA: 0x00903880 File Offset: 0x00901A80
		[NullableContext(1)]
		public BP_RoofRainDropActivator_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RoofRainDropActivator_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x06022400 RID: 140288 RVA: 0x009038B3 File Offset: 0x00901AB3
		// (set) Token: 0x06022401 RID: 140289 RVA: 0x009038C7 File Offset: 0x00901AC7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RoofRainDropActivator_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RoofRainDropActivator_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x06022402 RID: 140290 RVA: 0x009038DC File Offset: 0x00901ADC
		// (set) Token: 0x06022403 RID: 140291 RVA: 0x00903915 File Offset: 0x00901B15
		[Nullable(1)]
		public TArray<AActor> RoofDropLists
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._RoofDropLists) == null)
				{
					result = (this._RoofDropLists = new TArray<AActor>(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RoofDropLists.CopyAssign(value);
			}
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x06022404 RID: 140292 RVA: 0x00903923 File Offset: 0x00901B23
		// (set) Token: 0x06022405 RID: 140293 RVA: 0x00903933 File Offset: 0x00901B33
		public unsafe float Rain_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x06022406 RID: 140294 RVA: 0x00903944 File Offset: 0x00901B44
		// (set) Token: 0x06022407 RID: 140295 RVA: 0x00903954 File Offset: 0x00901B54
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x06022408 RID: 140296 RVA: 0x00903965 File Offset: 0x00901B65
		// (set) Token: 0x06022409 RID: 140297 RVA: 0x00903979 File Offset: 0x00901B79
		public unsafe TEnumAsByte<EKuroRainType> RainType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x0602240A RID: 140298 RVA: 0x0090398E File Offset: 0x00901B8E
		// (set) Token: 0x0602240B RID: 140299 RVA: 0x0090399E File Offset: 0x00901B9E
		public unsafe bool Is_in_Cave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x0602240C RID: 140300 RVA: 0x009039AF File Offset: 0x00901BAF
		// (set) Token: 0x0602240D RID: 140301 RVA: 0x009039BF File Offset: 0x00901BBF
		public unsafe float WeatherChangePastTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x0602240E RID: 140302 RVA: 0x009039D0 File Offset: 0x00901BD0
		// (set) Token: 0x0602240F RID: 140303 RVA: 0x009039E0 File Offset: 0x00901BE0
		public unsafe float FadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RoofRainDropActivator_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x06022410 RID: 140304 RVA: 0x009039F1 File Offset: 0x00901BF1
		// (set) Token: 0x06022411 RID: 140305 RVA: 0x00903A05 File Offset: 0x00901C05
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MID_WaterDrop
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RoofRainDropActivator_C.__PropertyOffset_9);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RoofRainDropActivator_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x06022412 RID: 140306 RVA: 0x00903A1A File Offset: 0x00901C1A
		// (set) Token: 0x06022413 RID: 140307 RVA: 0x00903A2E File Offset: 0x00901C2E
		[Nullable(2)]
		public unsafe BP_GlobalGI_C GlobalGI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RoofRainDropActivator_C.__PropertyOffset_10);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RoofRainDropActivator_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x06022414 RID: 140308 RVA: 0x00903A44 File Offset: 0x00901C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetBasicDropletParameters(float RainIntensity, float Gravity, EKuroRainType RainType, bool IsInCave)
		{
			BP_RoofRainDropActivator_C.__SetBasicDropletParameters_FunctionParams* ptr = stackalloc BP_RoofRainDropActivator_C.__SetBasicDropletParameters_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_RoofRainDropActivator_C.__SetBasicDropletParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RoofRainDropActivator_C.__SetBasicDropletParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RainIntensity = RainIntensity;
			ptr->Gravity = Gravity;
			ptr->RainType = RainType;
			ptr->IsInCave = IsInCave;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RoofRainDropActivator_C.__SetBasicDropletParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022415 RID: 140309 RVA: 0x00903AA5 File Offset: 0x00901CA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RoofRainDropActivator_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022416 RID: 140310 RVA: 0x00903AB9 File Offset: 0x00901CB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RoofRainDropActivator_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022417 RID: 140311 RVA: 0x00903AD0 File Offset: 0x00901CD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_RoofRainDropActivator_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RoofRainDropActivator_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RoofRainDropActivator_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RoofRainDropActivator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RoofRainDropActivator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022418 RID: 140312 RVA: 0x00903B18 File Offset: 0x00901D18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_RoofRainDropActivator_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RoofRainDropActivator_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RoofRainDropActivator_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RoofRainDropActivator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RoofRainDropActivator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022419 RID: 140313 RVA: 0x00903B60 File Offset: 0x00901D60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_RoofRainDropActivator_C.__EditorTick_FunctionParams* ptr = stackalloc BP_RoofRainDropActivator_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RoofRainDropActivator_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RoofRainDropActivator_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RoofRainDropActivator_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602241A RID: 140314 RVA: 0x00903BA8 File Offset: 0x00901DA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_RoofRainDropActivator_C.__EditorTick_FunctionParams* ptr = stackalloc BP_RoofRainDropActivator_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RoofRainDropActivator_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RoofRainDropActivator_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RoofRainDropActivator_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602241B RID: 140315 RVA: 0x00903BEF File Offset: 0x00901DEF
		protected BP_RoofRainDropActivator_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010C9A RID: 68762
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_RoofRainDropActivator.BP_RoofRainDropActivator_C";

		// Token: 0x04010C9B RID: 68763
		private static IntPtr _ClassPtr;

		// Token: 0x04010C9C RID: 68764
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010C9D RID: 68765
		internal static int __PropertyOffset_1;

		// Token: 0x04010C9E RID: 68766
		internal static int __PropertyOffset_2;

		// Token: 0x04010C9F RID: 68767
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _RoofDropLists;

		// Token: 0x04010CA0 RID: 68768
		internal static int __PropertyOffset_3;

		// Token: 0x04010CA1 RID: 68769
		internal static int __PropertyOffset_4;

		// Token: 0x04010CA2 RID: 68770
		internal static int __PropertyOffset_5;

		// Token: 0x04010CA3 RID: 68771
		internal static int __PropertyOffset_6;

		// Token: 0x04010CA4 RID: 68772
		internal static int __PropertyOffset_7;

		// Token: 0x04010CA5 RID: 68773
		internal static int __PropertyOffset_8;

		// Token: 0x04010CA6 RID: 68774
		internal static int __PropertyOffset_9;

		// Token: 0x04010CA7 RID: 68775
		internal static int __PropertyOffset_10;

		// Token: 0x04010CA8 RID: 68776
		private static IntPtr __SetBasicDropletParameters_NativeFunctionPtr;

		// Token: 0x04010CA9 RID: 68777
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010CAA RID: 68778
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010CAB RID: 68779
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009D58 RID: 40280
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetBasicDropletParameters_FunctionParams
		{
			// Token: 0x040314CC RID: 201932
			[FieldOffset(0)]
			public float RainIntensity;

			// Token: 0x040314CD RID: 201933
			[FieldOffset(4)]
			public float Gravity;

			// Token: 0x040314CE RID: 201934
			[FieldOffset(8)]
			public TEnumAsByte<EKuroRainType> RainType;

			// Token: 0x040314CF RID: 201935
			[FieldOffset(9)]
			public bool IsInCave;
		}

		// Token: 0x02009D59 RID: 40281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314D0 RID: 201936
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D5A RID: 40282
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040314D1 RID: 201937
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
