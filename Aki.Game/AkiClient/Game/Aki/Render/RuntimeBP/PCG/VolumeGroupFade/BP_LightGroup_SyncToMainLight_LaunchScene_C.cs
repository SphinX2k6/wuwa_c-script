using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.VolumeGroupFade
{
	// Token: 0x02003BE4 RID: 15332
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_LightGroup_SyncToMainLight_LaunchScene.BP_LightGroup_SyncToMainLight_LaunchScene_C")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1613)]
	public class BP_LightGroup_SyncToMainLight_LaunchScene_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022A46 RID: 141894 RVA: 0x0090E950 File Offset: 0x0090CB50
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LightGroup_SyncToMainLight_LaunchScene_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_LightGroup_SyncToMainLight_LaunchScene.BP_LightGroup_SyncToMainLight_LaunchScene_C");
			}
			return BP_LightGroup_SyncToMainLight_LaunchScene_C._ClassPtr;
		}

		// Token: 0x06022A47 RID: 141895 RVA: 0x0090E974 File Offset: 0x0090CB74
		public BP_LightGroup_SyncToMainLight_LaunchScene_C() : this(BuiltinUtils.AllocNativeUObject(BP_LightGroup_SyncToMainLight_LaunchScene_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022A48 RID: 141896 RVA: 0x0090E99C File Offset: 0x0090CB9C
		public BP_LightGroup_SyncToMainLight_LaunchScene_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LightGroup_SyncToMainLight_LaunchScene_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x06022A49 RID: 141897 RVA: 0x0090E9CF File Offset: 0x0090CBCF
		// (set) Token: 0x06022A4A RID: 141898 RVA: 0x0090E9E3 File Offset: 0x0090CBE3
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x06022A4B RID: 141899 RVA: 0x0090E9F8 File Offset: 0x0090CBF8
		// (set) Token: 0x06022A4C RID: 141900 RVA: 0x0090EA08 File Offset: 0x0090CC08
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x06022A4D RID: 141901 RVA: 0x0090EA19 File Offset: 0x0090CC19
		// (set) Token: 0x06022A4E RID: 141902 RVA: 0x0090EA2D File Offset: 0x0090CC2D
		[Nullable(2)]
		public unsafe BP_GlobalGI_LaunchScene_C CachedGI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_LaunchScene_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x06022A4F RID: 141903 RVA: 0x0090EA44 File Offset: 0x0090CC44
		// (set) Token: 0x06022A50 RID: 141904 RVA: 0x0090EA7D File Offset: 0x0090CC7D
		public TMap<ALight, float> LightInstensityMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ALight, float> result;
				if ((result = this._LightInstensityMap) == null)
				{
					result = (this._LightInstensityMap = new TMap<ALight, float>(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.LightInstensityMap.CopyAssign(value);
			}
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x06022A51 RID: 141905 RVA: 0x0090EA8B File Offset: 0x0090CC8B
		// (set) Token: 0x06022A52 RID: 141906 RVA: 0x0090EA9B File Offset: 0x0090CC9B
		public unsafe float TargetMainLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x06022A53 RID: 141907 RVA: 0x0090EAAC File Offset: 0x0090CCAC
		// (set) Token: 0x06022A54 RID: 141908 RVA: 0x0090EABC File Offset: 0x0090CCBC
		public unsafe int MaxProcessCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x06022A55 RID: 141909 RVA: 0x0090EACD File Offset: 0x0090CCCD
		// (set) Token: 0x06022A56 RID: 141910 RVA: 0x0090EADD File Offset: 0x0090CCDD
		public unsafe int NowProcessIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x06022A57 RID: 141911 RVA: 0x0090EAEE File Offset: 0x0090CCEE
		// (set) Token: 0x06022A58 RID: 141912 RVA: 0x0090EB02 File Offset: 0x0090CD02
		public unsafe FLinearColor TargetMainLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x06022A59 RID: 141913 RVA: 0x0090EB18 File Offset: 0x0090CD18
		// (set) Token: 0x06022A5A RID: 141914 RVA: 0x0090EB51 File Offset: 0x0090CD51
		public TArray<ALight> Keys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ALight> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<ALight>(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x06022A5B RID: 141915 RVA: 0x0090EB5F File Offset: 0x0090CD5F
		// (set) Token: 0x06022A5C RID: 141916 RVA: 0x0090EB6F File Offset: 0x0090CD6F
		public unsafe int MapLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x06022A5D RID: 141917 RVA: 0x0090EB80 File Offset: 0x0090CD80
		// (set) Token: 0x06022A5E RID: 141918 RVA: 0x0090EB90 File Offset: 0x0090CD90
		public unsafe bool bLightNotChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x06022A5F RID: 141919 RVA: 0x0090EBA1 File Offset: 0x0090CDA1
		// (set) Token: 0x06022A60 RID: 141920 RVA: 0x0090EBB1 File Offset: 0x0090CDB1
		public unsafe float NightMulti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x06022A61 RID: 141921 RVA: 0x0090EBC2 File Offset: 0x0090CDC2
		// (set) Token: 0x06022A62 RID: 141922 RVA: 0x0090EBD2 File Offset: 0x0090CDD2
		public unsafe bool TargetBNight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_LaunchScene_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022A63 RID: 141923 RVA: 0x0090EBE3 File Offset: 0x0090CDE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06022A64 RID: 141924 RVA: 0x0090EBF7 File Offset: 0x0090CDF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022A65 RID: 141925 RVA: 0x0090EC0B File Offset: 0x0090CE0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A66 RID: 141926 RVA: 0x0090EC20 File Offset: 0x0090CE20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022A67 RID: 141927 RVA: 0x0090EC34 File Offset: 0x0090CE34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022A68 RID: 141928 RVA: 0x0090EC48 File Offset: 0x0090CE48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A69 RID: 141929 RVA: 0x0090EC5D File Offset: 0x0090CE5D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TimeSlicedTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__TimeSlicedTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022A6A RID: 141930 RVA: 0x0090EC74 File Offset: 0x0090CE74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A6B RID: 141931 RVA: 0x0090ECBC File Offset: 0x0090CEBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_LaunchScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022A6C RID: 141932 RVA: 0x0090ED03 File Offset: 0x0090CF03
		protected BP_LightGroup_SyncToMainLight_LaunchScene_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401106F RID: 69743
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_LightGroup_SyncToMainLight_LaunchScene.BP_LightGroup_SyncToMainLight_LaunchScene_C";

		// Token: 0x04011070 RID: 69744
		private static IntPtr _ClassPtr;

		// Token: 0x04011071 RID: 69745
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011072 RID: 69746
		internal static int __PropertyOffset_1;

		// Token: 0x04011073 RID: 69747
		internal static int __PropertyOffset_2;

		// Token: 0x04011074 RID: 69748
		internal static int __PropertyOffset_3;

		// Token: 0x04011075 RID: 69749
		internal static int __PropertyOffset_4;

		// Token: 0x04011076 RID: 69750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ALight, float> _LightInstensityMap;

		// Token: 0x04011077 RID: 69751
		internal static int __PropertyOffset_5;

		// Token: 0x04011078 RID: 69752
		internal static int __PropertyOffset_6;

		// Token: 0x04011079 RID: 69753
		internal static int __PropertyOffset_7;

		// Token: 0x0401107A RID: 69754
		internal static int __PropertyOffset_8;

		// Token: 0x0401107B RID: 69755
		internal static int __PropertyOffset_9;

		// Token: 0x0401107C RID: 69756
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ALight> _Keys;

		// Token: 0x0401107D RID: 69757
		internal static int __PropertyOffset_10;

		// Token: 0x0401107E RID: 69758
		internal static int __PropertyOffset_11;

		// Token: 0x0401107F RID: 69759
		internal static int __PropertyOffset_12;

		// Token: 0x04011080 RID: 69760
		internal static int __PropertyOffset_13;

		// Token: 0x04011081 RID: 69761
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04011082 RID: 69762
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011083 RID: 69763
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011084 RID: 69764
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011085 RID: 69765
		private static IntPtr __TimeSlicedTick_NativeFunctionPtr;

		// Token: 0x04011086 RID: 69766
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009DB0 RID: 40368
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031592 RID: 202130
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
