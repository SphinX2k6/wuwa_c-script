using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.BrokenGlass
{
	// Token: 0x02003E35 RID: 15925
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow.BP_BrokenWindow_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1554)]
	public class BP_BrokenWindow_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027F9B RID: 163739 RVA: 0x009A0F37 File Offset: 0x0099F137
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BrokenWindow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow.BP_BrokenWindow_C");
			}
			return BP_BrokenWindow_C._ClassPtr;
		}

		// Token: 0x06027F9C RID: 163740 RVA: 0x009A0F5C File Offset: 0x0099F15C
		public BP_BrokenWindow_C() : this(BuiltinUtils.AllocNativeUObject(BP_BrokenWindow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027F9D RID: 163741 RVA: 0x009A0F84 File Offset: 0x0099F184
		[NullableContext(1)]
		public BP_BrokenWindow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BrokenWindow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B0F RID: 23311
		// (get) Token: 0x06027F9E RID: 163742 RVA: 0x009A0FB7 File Offset: 0x0099F1B7
		// (set) Token: 0x06027F9F RID: 163743 RVA: 0x009A0FCB File Offset: 0x0099F1CB
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005B10 RID: 23312
		// (get) Token: 0x06027FA0 RID: 163744 RVA: 0x009A0FE0 File Offset: 0x0099F1E0
		// (set) Token: 0x06027FA1 RID: 163745 RVA: 0x009A0FF4 File Offset: 0x0099F1F4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BrokenWindow_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005B11 RID: 23313
		// (get) Token: 0x06027FA2 RID: 163746 RVA: 0x009A1009 File Offset: 0x0099F209
		// (set) Token: 0x06027FA3 RID: 163747 RVA: 0x009A101D File Offset: 0x0099F21D
		public unsafe FVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005B12 RID: 23314
		// (get) Token: 0x06027FA4 RID: 163748 RVA: 0x009A1034 File Offset: 0x0099F234
		// (set) Token: 0x06027FA5 RID: 163749 RVA: 0x009A106D File Offset: 0x0099F26D
		[Nullable(1)]
		public TArray<FVector> UVList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._UVList) == null)
				{
					result = (this._UVList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UVList.CopyAssign(value);
			}
		}

		// Token: 0x17005B13 RID: 23315
		// (get) Token: 0x06027FA6 RID: 163750 RVA: 0x009A107B File Offset: 0x0099F27B
		// (set) Token: 0x06027FA7 RID: 163751 RVA: 0x009A108B File Offset: 0x0099F28B
		public unsafe int UVIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005B14 RID: 23316
		// (get) Token: 0x06027FA8 RID: 163752 RVA: 0x009A109C File Offset: 0x0099F29C
		// (set) Token: 0x06027FA9 RID: 163753 RVA: 0x009A10AC File Offset: 0x0099F2AC
		public unsafe float HitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005B15 RID: 23317
		// (get) Token: 0x06027FAA RID: 163754 RVA: 0x009A10BD File Offset: 0x0099F2BD
		// (set) Token: 0x06027FAB RID: 163755 RVA: 0x009A10CD File Offset: 0x0099F2CD
		public unsafe float TraceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005B16 RID: 23318
		// (get) Token: 0x06027FAC RID: 163756 RVA: 0x009A10DE File Offset: 0x0099F2DE
		// (set) Token: 0x06027FAD RID: 163757 RVA: 0x009A10F2 File Offset: 0x0099F2F2
		public unsafe FVector LastWeaponPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005B17 RID: 23319
		// (get) Token: 0x06027FAE RID: 163758 RVA: 0x009A1107 File Offset: 0x0099F307
		// (set) Token: 0x06027FAF RID: 163759 RVA: 0x009A1117 File Offset: 0x0099F317
		public unsafe float CrackPointState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005B18 RID: 23320
		// (get) Token: 0x06027FB0 RID: 163760 RVA: 0x009A1128 File Offset: 0x0099F328
		// (set) Token: 0x06027FB1 RID: 163761 RVA: 0x009A1161 File Offset: 0x0099F361
		[Nullable(1)]
		public TArray<int> BitMask
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BitMask) == null)
				{
					result = (this._BitMask = new TArray<int>(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BitMask.CopyAssign(value);
			}
		}

		// Token: 0x17005B19 RID: 23321
		// (get) Token: 0x06027FB2 RID: 163762 RVA: 0x009A116F File Offset: 0x0099F36F
		// (set) Token: 0x06027FB3 RID: 163763 RVA: 0x009A117F File Offset: 0x0099F37F
		public unsafe int FinalStateMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005B1A RID: 23322
		// (get) Token: 0x06027FB4 RID: 163764 RVA: 0x009A1190 File Offset: 0x0099F390
		// (set) Token: 0x06027FB5 RID: 163765 RVA: 0x009A11A0 File Offset: 0x0099F3A0
		public unsafe float InteractRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005B1B RID: 23323
		// (get) Token: 0x06027FB6 RID: 163766 RVA: 0x009A11B1 File Offset: 0x0099F3B1
		// (set) Token: 0x06027FB7 RID: 163767 RVA: 0x009A11C1 File Offset: 0x0099F3C1
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B1C RID: 23324
		// (get) Token: 0x06027FB8 RID: 163768 RVA: 0x009A11D2 File Offset: 0x0099F3D2
		// (set) Token: 0x06027FB9 RID: 163769 RVA: 0x009A11E2 File Offset: 0x0099F3E2
		public unsafe bool LastPointUseAble
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BrokenWindow_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027FBA RID: 163770 RVA: 0x009A11F3 File Offset: 0x0099F3F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06027FBB RID: 163771 RVA: 0x009A1208 File Offset: 0x0099F408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BrokenWindow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BrokenWindow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BrokenWindow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027FBC RID: 163772 RVA: 0x009A1250 File Offset: 0x0099F450
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BrokenWindow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BrokenWindow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BrokenWindow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BrokenWindow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027FBD RID: 163773 RVA: 0x009A1298 File Offset: 0x0099F498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_BrokenWindow_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_BrokenWindow_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_BrokenWindow_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BrokenWindow_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BrokenWindow_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027FBE RID: 163774 RVA: 0x009A12FB File Offset: 0x0099F4FB
		protected BP_BrokenWindow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040144AF RID: 83119
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/BrokenGlass/BP_BrokenWindow.BP_BrokenWindow_C";

		// Token: 0x040144B0 RID: 83120
		private static IntPtr _ClassPtr;

		// Token: 0x040144B1 RID: 83121
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040144B2 RID: 83122
		internal static int __PropertyOffset_1;

		// Token: 0x040144B3 RID: 83123
		internal static int __PropertyOffset_2;

		// Token: 0x040144B4 RID: 83124
		internal static int __PropertyOffset_3;

		// Token: 0x040144B5 RID: 83125
		internal static int __PropertyOffset_4;

		// Token: 0x040144B6 RID: 83126
		private TArray<FVector> _UVList;

		// Token: 0x040144B7 RID: 83127
		internal static int __PropertyOffset_5;

		// Token: 0x040144B8 RID: 83128
		internal static int __PropertyOffset_6;

		// Token: 0x040144B9 RID: 83129
		internal static int __PropertyOffset_7;

		// Token: 0x040144BA RID: 83130
		internal static int __PropertyOffset_8;

		// Token: 0x040144BB RID: 83131
		internal static int __PropertyOffset_9;

		// Token: 0x040144BC RID: 83132
		internal static int __PropertyOffset_10;

		// Token: 0x040144BD RID: 83133
		private TArray<int> _BitMask;

		// Token: 0x040144BE RID: 83134
		internal static int __PropertyOffset_11;

		// Token: 0x040144BF RID: 83135
		internal static int __PropertyOffset_12;

		// Token: 0x040144C0 RID: 83136
		internal static int __PropertyOffset_13;

		// Token: 0x040144C1 RID: 83137
		internal static int __PropertyOffset_14;

		// Token: 0x040144C2 RID: 83138
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x040144C3 RID: 83139
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040144C4 RID: 83140
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x0200A2B8 RID: 41656
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FEF RID: 204783
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2B9 RID: 41657
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031FF0 RID: 204784
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031FF1 RID: 204785
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031FF2 RID: 204786
			[FieldOffset(32)]
			public int Id;
		}
	}
}
