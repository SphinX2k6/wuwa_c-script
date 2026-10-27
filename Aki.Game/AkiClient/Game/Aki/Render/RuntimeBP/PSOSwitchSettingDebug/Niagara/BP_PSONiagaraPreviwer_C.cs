using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PSOSwitchSettingDebug.Niagara
{
	// Token: 0x02003BCE RID: 15310
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/Niagara/BP_PSONiagaraPreviwer.BP_PSONiagaraPreviwer_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_PSONiagaraPreviwer_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022594 RID: 140692 RVA: 0x00906803 File Offset: 0x00904A03
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PSONiagaraPreviwer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/Niagara/BP_PSONiagaraPreviwer.BP_PSONiagaraPreviwer_C");
			}
			return BP_PSONiagaraPreviwer_C._ClassPtr;
		}

		// Token: 0x06022595 RID: 140693 RVA: 0x00906828 File Offset: 0x00904A28
		public BP_PSONiagaraPreviwer_C() : this(BuiltinUtils.AllocNativeUObject(BP_PSONiagaraPreviwer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022596 RID: 140694 RVA: 0x00906850 File Offset: 0x00904A50
		[NullableContext(1)]
		public BP_PSONiagaraPreviwer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PSONiagaraPreviwer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x06022597 RID: 140695 RVA: 0x00906883 File Offset: 0x00904A83
		// (set) Token: 0x06022598 RID: 140696 RVA: 0x00906897 File Offset: 0x00904A97
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PSONiagaraPreviwer_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PSONiagaraPreviwer_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x06022599 RID: 140697 RVA: 0x009068AC File Offset: 0x00904AAC
		// (set) Token: 0x0602259A RID: 140698 RVA: 0x009068C0 File Offset: 0x00904AC0
		public unsafe PDA_PSONiagaraMaterialList_C Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_PSONiagaraMaterialList_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PSONiagaraPreviwer_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PSONiagaraPreviwer_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0602259B RID: 140699 RVA: 0x009068D5 File Offset: 0x00904AD5
		// (set) Token: 0x0602259C RID: 140700 RVA: 0x009068E5 File Offset: 0x00904AE5
		public unsafe int SpriteCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0602259D RID: 140701 RVA: 0x009068F6 File Offset: 0x00904AF6
		// (set) Token: 0x0602259E RID: 140702 RVA: 0x00906906 File Offset: 0x00904B06
		public unsafe int MeshCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0602259F RID: 140703 RVA: 0x00906917 File Offset: 0x00904B17
		// (set) Token: 0x060225A0 RID: 140704 RVA: 0x00906927 File Offset: 0x00904B27
		public unsafe bool Found
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x060225A1 RID: 140705 RVA: 0x00906938 File Offset: 0x00904B38
		// (set) Token: 0x060225A2 RID: 140706 RVA: 0x00906948 File Offset: 0x00904B48
		public unsafe int StartSearchIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x060225A3 RID: 140707 RVA: 0x00906959 File Offset: 0x00904B59
		// (set) Token: 0x060225A4 RID: 140708 RVA: 0x00906969 File Offset: 0x00904B69
		public unsafe int ArrayLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x060225A5 RID: 140709 RVA: 0x0090697A File Offset: 0x00904B7A
		// (set) Token: 0x060225A6 RID: 140710 RVA: 0x0090698A File Offset: 0x00904B8A
		public unsafe float TickCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x060225A7 RID: 140711 RVA: 0x0090699B File Offset: 0x00904B9B
		// (set) Token: 0x060225A8 RID: 140712 RVA: 0x009069AB File Offset: 0x00904BAB
		public unsafe int RibbonCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x060225A9 RID: 140713 RVA: 0x009069BC File Offset: 0x00904BBC
		// (set) Token: 0x060225AA RID: 140714 RVA: 0x009069D0 File Offset: 0x00904BD0
		[Nullable(1)]
		public unsafe string MaterialsFilePath
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_10)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_PSONiagaraPreviwer_C.__PropertyOffset_10)), value);
			}
		}

		// Token: 0x060225AB RID: 140715 RVA: 0x009069E5 File Offset: 0x00904BE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WriteToConfig()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PSONiagaraPreviwer_C.__WriteToConfig_NativeFunctionPtr, null);
		}

		// Token: 0x060225AC RID: 140716 RVA: 0x009069F9 File Offset: 0x00904BF9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PSONiagaraPreviwer_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060225AD RID: 140717 RVA: 0x00906A0D File Offset: 0x00904C0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PSONiagaraPreviwer_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060225AE RID: 140718 RVA: 0x00906A24 File Offset: 0x00904C24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PSONiagaraPreviwer_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PSONiagaraPreviwer_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PSONiagaraPreviwer_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PSONiagaraPreviwer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PSONiagaraPreviwer_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060225AF RID: 140719 RVA: 0x00906A6C File Offset: 0x00904C6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PSONiagaraPreviwer_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PSONiagaraPreviwer_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PSONiagaraPreviwer_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PSONiagaraPreviwer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PSONiagaraPreviwer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060225B0 RID: 140720 RVA: 0x00906AB4 File Offset: 0x00904CB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PSONiagaraPreviwer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PSONiagaraPreviwer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PSONiagaraPreviwer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PSONiagaraPreviwer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PSONiagaraPreviwer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060225B1 RID: 140721 RVA: 0x00906AFC File Offset: 0x00904CFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PSONiagaraPreviwer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PSONiagaraPreviwer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PSONiagaraPreviwer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PSONiagaraPreviwer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PSONiagaraPreviwer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060225B2 RID: 140722 RVA: 0x00906B43 File Offset: 0x00904D43
		protected BP_PSONiagaraPreviwer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DA5 RID: 69029
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/Niagara/BP_PSONiagaraPreviwer.BP_PSONiagaraPreviwer_C";

		// Token: 0x04010DA6 RID: 69030
		private static IntPtr _ClassPtr;

		// Token: 0x04010DA7 RID: 69031
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DA8 RID: 69032
		internal static int __PropertyOffset_1;

		// Token: 0x04010DA9 RID: 69033
		internal static int __PropertyOffset_2;

		// Token: 0x04010DAA RID: 69034
		internal static int __PropertyOffset_3;

		// Token: 0x04010DAB RID: 69035
		internal static int __PropertyOffset_4;

		// Token: 0x04010DAC RID: 69036
		internal static int __PropertyOffset_5;

		// Token: 0x04010DAD RID: 69037
		internal static int __PropertyOffset_6;

		// Token: 0x04010DAE RID: 69038
		internal static int __PropertyOffset_7;

		// Token: 0x04010DAF RID: 69039
		internal static int __PropertyOffset_8;

		// Token: 0x04010DB0 RID: 69040
		internal static int __PropertyOffset_9;

		// Token: 0x04010DB1 RID: 69041
		internal static int __PropertyOffset_10;

		// Token: 0x04010DB2 RID: 69042
		private static IntPtr __WriteToConfig_NativeFunctionPtr;

		// Token: 0x04010DB3 RID: 69043
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010DB4 RID: 69044
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010DB5 RID: 69045
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009D6C RID: 40300
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040314EA RID: 201962
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D6D RID: 40301
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314EB RID: 201963
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
