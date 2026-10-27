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
	// Token: 0x02003BE3 RID: 15331
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_LightGroup_SyncToMainLight.BP_LightGroup_SyncToMainLight_C")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1614)]
	public class BP_LightGroup_SyncToMainLight_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022A1A RID: 141850 RVA: 0x0090E4DE File Offset: 0x0090C6DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LightGroup_SyncToMainLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_LightGroup_SyncToMainLight.BP_LightGroup_SyncToMainLight_C");
			}
			return BP_LightGroup_SyncToMainLight_C._ClassPtr;
		}

		// Token: 0x06022A1B RID: 141851 RVA: 0x0090E502 File Offset: 0x0090C702
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_LightGroup_SyncToMainLight_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06022A1C RID: 141852 RVA: 0x0090E50C File Offset: 0x0090C70C
		public BP_LightGroup_SyncToMainLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_LightGroup_SyncToMainLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022A1D RID: 141853 RVA: 0x0090E534 File Offset: 0x0090C734
		[NullableContext(1)]
		public BP_LightGroup_SyncToMainLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LightGroup_SyncToMainLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x06022A1E RID: 141854 RVA: 0x0090E567 File Offset: 0x0090C767
		// (set) Token: 0x06022A1F RID: 141855 RVA: 0x0090E57B File Offset: 0x0090C77B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightGroup_SyncToMainLight_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightGroup_SyncToMainLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x06022A20 RID: 141856 RVA: 0x0090E590 File Offset: 0x0090C790
		// (set) Token: 0x06022A21 RID: 141857 RVA: 0x0090E5A0 File Offset: 0x0090C7A0
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x06022A22 RID: 141858 RVA: 0x0090E5B1 File Offset: 0x0090C7B1
		// (set) Token: 0x06022A23 RID: 141859 RVA: 0x0090E5C5 File Offset: 0x0090C7C5
		[Nullable(2)]
		public unsafe BP_GlobalGI_C CachedGI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightGroup_SyncToMainLight_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightGroup_SyncToMainLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x06022A24 RID: 141860 RVA: 0x0090E5DC File Offset: 0x0090C7DC
		// (set) Token: 0x06022A25 RID: 141861 RVA: 0x0090E615 File Offset: 0x0090C815
		[Nullable(1)]
		public TMap<ALight, float> LightInstensityMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<ALight, float> result;
				if ((result = this._LightInstensityMap) == null)
				{
					result = (this._LightInstensityMap = new TMap<ALight, float>(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightInstensityMap.CopyAssign(value);
			}
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x06022A26 RID: 141862 RVA: 0x0090E623 File Offset: 0x0090C823
		// (set) Token: 0x06022A27 RID: 141863 RVA: 0x0090E633 File Offset: 0x0090C833
		public unsafe float TargetMainLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x06022A28 RID: 141864 RVA: 0x0090E644 File Offset: 0x0090C844
		// (set) Token: 0x06022A29 RID: 141865 RVA: 0x0090E654 File Offset: 0x0090C854
		public unsafe int MaxProcessCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x06022A2A RID: 141866 RVA: 0x0090E665 File Offset: 0x0090C865
		// (set) Token: 0x06022A2B RID: 141867 RVA: 0x0090E675 File Offset: 0x0090C875
		public unsafe int NowProcessIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x06022A2C RID: 141868 RVA: 0x0090E686 File Offset: 0x0090C886
		// (set) Token: 0x06022A2D RID: 141869 RVA: 0x0090E69A File Offset: 0x0090C89A
		public unsafe FLinearColor TargetMainLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x06022A2E RID: 141870 RVA: 0x0090E6B0 File Offset: 0x0090C8B0
		// (set) Token: 0x06022A2F RID: 141871 RVA: 0x0090E6E9 File Offset: 0x0090C8E9
		[Nullable(1)]
		public TArray<ALight> Keys
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ALight> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<ALight>(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x06022A30 RID: 141872 RVA: 0x0090E6F7 File Offset: 0x0090C8F7
		// (set) Token: 0x06022A31 RID: 141873 RVA: 0x0090E707 File Offset: 0x0090C907
		public unsafe int MapLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003CCF RID: 15567
		// (get) Token: 0x06022A32 RID: 141874 RVA: 0x0090E718 File Offset: 0x0090C918
		// (set) Token: 0x06022A33 RID: 141875 RVA: 0x0090E728 File Offset: 0x0090C928
		public unsafe bool bLightNotChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x06022A34 RID: 141876 RVA: 0x0090E739 File Offset: 0x0090C939
		// (set) Token: 0x06022A35 RID: 141877 RVA: 0x0090E749 File Offset: 0x0090C949
		public unsafe float NightMulti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x06022A36 RID: 141878 RVA: 0x0090E75A File Offset: 0x0090C95A
		// (set) Token: 0x06022A37 RID: 141879 RVA: 0x0090E76A File Offset: 0x0090C96A
		public unsafe bool TargetBNight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x06022A38 RID: 141880 RVA: 0x0090E77B File Offset: 0x0090C97B
		// (set) Token: 0x06022A39 RID: 141881 RVA: 0x0090E78B File Offset: 0x0090C98B
		public unsafe bool bSyncToToonLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightGroup_SyncToMainLight_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022A3A RID: 141882 RVA: 0x0090E79C File Offset: 0x0090C99C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06022A3B RID: 141883 RVA: 0x0090E7E4 File Offset: 0x0090C9E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06022A3C RID: 141884 RVA: 0x0090E82A File Offset: 0x0090CA2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06022A3D RID: 141885 RVA: 0x0090E83E File Offset: 0x0090CA3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022A3E RID: 141886 RVA: 0x0090E852 File Offset: 0x0090CA52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A3F RID: 141887 RVA: 0x0090E867 File Offset: 0x0090CA67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022A40 RID: 141888 RVA: 0x0090E87B File Offset: 0x0090CA7B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022A41 RID: 141889 RVA: 0x0090E88F File Offset: 0x0090CA8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A42 RID: 141890 RVA: 0x0090E8A4 File Offset: 0x0090CAA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TimeSlicedTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__TimeSlicedTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022A43 RID: 141891 RVA: 0x0090E8B8 File Offset: 0x0090CAB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LightGroup_SyncToMainLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightGroup_SyncToMainLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightGroup_SyncToMainLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightGroup_SyncToMainLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A44 RID: 141892 RVA: 0x0090E900 File Offset: 0x0090CB00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LightGroup_SyncToMainLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightGroup_SyncToMainLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightGroup_SyncToMainLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightGroup_SyncToMainLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightGroup_SyncToMainLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022A45 RID: 141893 RVA: 0x0090E947 File Offset: 0x0090CB47
		protected BP_LightGroup_SyncToMainLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011054 RID: 69716
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04011055 RID: 69717
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_LightGroup_SyncToMainLight.BP_LightGroup_SyncToMainLight_C";

		// Token: 0x04011056 RID: 69718
		private static IntPtr _ClassPtr;

		// Token: 0x04011057 RID: 69719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011058 RID: 69720
		internal static int __PropertyOffset_1;

		// Token: 0x04011059 RID: 69721
		internal static int __PropertyOffset_2;

		// Token: 0x0401105A RID: 69722
		internal static int __PropertyOffset_3;

		// Token: 0x0401105B RID: 69723
		internal static int __PropertyOffset_4;

		// Token: 0x0401105C RID: 69724
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ALight, float> _LightInstensityMap;

		// Token: 0x0401105D RID: 69725
		internal static int __PropertyOffset_5;

		// Token: 0x0401105E RID: 69726
		internal static int __PropertyOffset_6;

		// Token: 0x0401105F RID: 69727
		internal static int __PropertyOffset_7;

		// Token: 0x04011060 RID: 69728
		internal static int __PropertyOffset_8;

		// Token: 0x04011061 RID: 69729
		internal static int __PropertyOffset_9;

		// Token: 0x04011062 RID: 69730
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ALight> _Keys;

		// Token: 0x04011063 RID: 69731
		internal static int __PropertyOffset_10;

		// Token: 0x04011064 RID: 69732
		internal static int __PropertyOffset_11;

		// Token: 0x04011065 RID: 69733
		internal static int __PropertyOffset_12;

		// Token: 0x04011066 RID: 69734
		internal static int __PropertyOffset_13;

		// Token: 0x04011067 RID: 69735
		internal static int __PropertyOffset_14;

		// Token: 0x04011068 RID: 69736
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x04011069 RID: 69737
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x0401106A RID: 69738
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401106B RID: 69739
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401106C RID: 69740
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401106D RID: 69741
		private static IntPtr __TimeSlicedTick_NativeFunctionPtr;

		// Token: 0x0401106E RID: 69742
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009DAE RID: 40366
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031590 RID: 202128
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009DAF RID: 40367
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031591 RID: 202129
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
