using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B8C RID: 15244
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_BeiBi_S.BP_DollItem_BeiBi_S_C")]
	[UnrealStructLayout(1784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1784)]
	public class BP_DollItem_BeiBi_S_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021EC4 RID: 138948 RVA: 0x008F9ACA File Offset: 0x008F7CCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_BeiBi_S_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_BeiBi_S.BP_DollItem_BeiBi_S_C");
			}
			return BP_DollItem_BeiBi_S_C._ClassPtr;
		}

		// Token: 0x06021EC5 RID: 138949 RVA: 0x008F9AF0 File Offset: 0x008F7CF0
		public BP_DollItem_BeiBi_S_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_BeiBi_S_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021EC6 RID: 138950 RVA: 0x008F9B18 File Offset: 0x008F7D18
		[NullableContext(1)]
		public BP_DollItem_BeiBi_S_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_BeiBi_S_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x06021EC7 RID: 138951 RVA: 0x008F9B4B File Offset: 0x008F7D4B
		// (set) Token: 0x06021EC8 RID: 138952 RVA: 0x008F9B5F File Offset: 0x008F7D5F
		public unsafe UNiagaraComponent NS_Fx_Sl2_MZ_BeiBi_01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x06021EC9 RID: 138953 RVA: 0x008F9B74 File Offset: 0x008F7D74
		// (set) Token: 0x06021ECA RID: 138954 RVA: 0x008F9B88 File Offset: 0x008F7D88
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x06021ECB RID: 138955 RVA: 0x008F9B9D File Offset: 0x008F7D9D
		// (set) Token: 0x06021ECC RID: 138956 RVA: 0x008F9BB1 File Offset: 0x008F7DB1
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x06021ECD RID: 138957 RVA: 0x008F9BC6 File Offset: 0x008F7DC6
		// (set) Token: 0x06021ECE RID: 138958 RVA: 0x008F9BD6 File Offset: 0x008F7DD6
		public unsafe float fade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x06021ECF RID: 138959 RVA: 0x008F9BE7 File Offset: 0x008F7DE7
		// (set) Token: 0x06021ED0 RID: 138960 RVA: 0x008F9BF7 File Offset: 0x008F7DF7
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x06021ED1 RID: 138961 RVA: 0x008F9C08 File Offset: 0x008F7E08
		// (set) Token: 0x06021ED2 RID: 138962 RVA: 0x008F9C1C File Offset: 0x008F7E1C
		public unsafe UMaterialInstanceDynamic Dmaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x06021ED3 RID: 138963 RVA: 0x008F9C31 File Offset: 0x008F7E31
		// (set) Token: 0x06021ED4 RID: 138964 RVA: 0x008F9C41 File Offset: 0x008F7E41
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x06021ED5 RID: 138965 RVA: 0x008F9C52 File Offset: 0x008F7E52
		// (set) Token: 0x06021ED6 RID: 138966 RVA: 0x008F9C66 File Offset: 0x008F7E66
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x06021ED7 RID: 138967 RVA: 0x008F9C7B File Offset: 0x008F7E7B
		// (set) Token: 0x06021ED8 RID: 138968 RVA: 0x008F9C8B File Offset: 0x008F7E8B
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_BeiBi_S_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x06021ED9 RID: 138969 RVA: 0x008F9C9C File Offset: 0x008F7E9C
		// (set) Token: 0x06021EDA RID: 138970 RVA: 0x008F9CB0 File Offset: 0x008F7EB0
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x06021EDB RID: 138971 RVA: 0x008F9CC5 File Offset: 0x008F7EC5
		// (set) Token: 0x06021EDC RID: 138972 RVA: 0x008F9CD9 File Offset: 0x008F7ED9
		public unsafe UHoudiniPointCache HoudiniPointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x06021EDD RID: 138973 RVA: 0x008F9CEE File Offset: 0x008F7EEE
		// (set) Token: 0x06021EDE RID: 138974 RVA: 0x008F9D02 File Offset: 0x008F7F02
		public unsafe UMaterialInstance InputMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x06021EDF RID: 138975 RVA: 0x008F9D17 File Offset: 0x008F7F17
		// (set) Token: 0x06021EE0 RID: 138976 RVA: 0x008F9D2B File Offset: 0x008F7F2B
		public unsafe UMaterialInstanceDynamic Dmaterial_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x06021EE1 RID: 138977 RVA: 0x008F9D40 File Offset: 0x008F7F40
		// (set) Token: 0x06021EE2 RID: 138978 RVA: 0x008F9D54 File Offset: 0x008F7F54
		public unsafe UMaterialInstance InputMaterial_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_BeiBi_S_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x06021EE3 RID: 138979 RVA: 0x008F9D69 File Offset: 0x008F7F69
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_BeiBi_S_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021EE4 RID: 138980 RVA: 0x008F9D7D File Offset: 0x008F7F7D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_BeiBi_S_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021EE5 RID: 138981 RVA: 0x008F9D94 File Offset: 0x008F7F94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DollItem_BeiBi_S_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DollItem_BeiBi_S_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DollItem_BeiBi_S_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollItem_BeiBi_S_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_BeiBi_S_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021EE6 RID: 138982 RVA: 0x008F9DDC File Offset: 0x008F7FDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DollItem_BeiBi_S_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DollItem_BeiBi_S_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DollItem_BeiBi_S_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollItem_BeiBi_S_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_BeiBi_S_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021EE7 RID: 138983 RVA: 0x008F9E23 File Offset: 0x008F8023
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_BeiBi_S_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021EE8 RID: 138984 RVA: 0x008F9E37 File Offset: 0x008F8037
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_BeiBi_S_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021EE9 RID: 138985 RVA: 0x008F9E4C File Offset: 0x008F804C
		protected BP_DollItem_BeiBi_S_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010958 RID: 67928
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_BeiBi_S.BP_DollItem_BeiBi_S_C";

		// Token: 0x04010959 RID: 67929
		private static IntPtr _ClassPtr;

		// Token: 0x0401095A RID: 67930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401095B RID: 67931
		internal new static int __PropertyOffset_1;

		// Token: 0x0401095C RID: 67932
		internal new static int __PropertyOffset_2;

		// Token: 0x0401095D RID: 67933
		internal new static int __PropertyOffset_3;

		// Token: 0x0401095E RID: 67934
		internal new static int __PropertyOffset_4;

		// Token: 0x0401095F RID: 67935
		internal new static int __PropertyOffset_5;

		// Token: 0x04010960 RID: 67936
		internal new static int __PropertyOffset_6;

		// Token: 0x04010961 RID: 67937
		internal new static int __PropertyOffset_7;

		// Token: 0x04010962 RID: 67938
		internal new static int __PropertyOffset_8;

		// Token: 0x04010963 RID: 67939
		internal new static int __PropertyOffset_9;

		// Token: 0x04010964 RID: 67940
		internal new static int __PropertyOffset_10;

		// Token: 0x04010965 RID: 67941
		internal new static int __PropertyOffset_11;

		// Token: 0x04010966 RID: 67942
		internal static int __PropertyOffset_12;

		// Token: 0x04010967 RID: 67943
		internal static int __PropertyOffset_13;

		// Token: 0x04010968 RID: 67944
		internal static int __PropertyOffset_14;

		// Token: 0x04010969 RID: 67945
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401096A RID: 67946
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401096B RID: 67947
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009CF4 RID: 40180
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040313F5 RID: 201717
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
