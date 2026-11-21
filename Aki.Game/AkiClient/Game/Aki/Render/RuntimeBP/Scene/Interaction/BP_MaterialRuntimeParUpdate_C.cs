using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030BD RID: 12477
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_MaterialRuntimeParUpdate.BP_MaterialRuntimeParUpdate_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_MaterialRuntimeParUpdate_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DFBD RID: 122813 RVA: 0x00907C65 File Offset: 0x00905E65
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MaterialRuntimeParUpdate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_MaterialRuntimeParUpdate.BP_MaterialRuntimeParUpdate_C");
			}
			return BP_MaterialRuntimeParUpdate_C._ClassPtr;
		}

		// Token: 0x0601DFBE RID: 122814 RVA: 0x00907C8C File Offset: 0x00905E8C
		public BP_MaterialRuntimeParUpdate_C() : this(BuiltinUtils.AllocNativeUObject(BP_MaterialRuntimeParUpdate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DFBF RID: 122815 RVA: 0x00907CB4 File Offset: 0x00905EB4
		[NullableContext(1)]
		public BP_MaterialRuntimeParUpdate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MaterialRuntimeParUpdate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0601DFC0 RID: 122816 RVA: 0x00907CE7 File Offset: 0x00905EE7
		// (set) Token: 0x0601DFC1 RID: 122817 RVA: 0x00907CFB File Offset: 0x00905EFB
		public unsafe USceneComponent Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Target);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0601DFC2 RID: 122818 RVA: 0x00907D10 File Offset: 0x00905F10
		// (set) Token: 0x0601DFC3 RID: 122819 RVA: 0x00907D24 File Offset: 0x00905F24
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0601DFC4 RID: 122820 RVA: 0x00907D39 File Offset: 0x00905F39
		// (set) Token: 0x0601DFC5 RID: 122821 RVA: 0x00907D49 File Offset: 0x00905F49
		public unsafe int Material_Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Material_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Material_Index) = value;
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0601DFC6 RID: 122822 RVA: 0x00907D5A File Offset: 0x00905F5A
		// (set) Token: 0x0601DFC7 RID: 122823 RVA: 0x00907D6E File Offset: 0x00905F6E
		public unsafe FLinearColor NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_NewVar_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_NewVar_0) = value;
			}
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0601DFC8 RID: 122824 RVA: 0x00907D83 File Offset: 0x00905F83
		// (set) Token: 0x0601DFC9 RID: 122825 RVA: 0x00907D97 File Offset: 0x00905F97
		public unsafe ItemMaterialControllerActorData DA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ItemMaterialControllerActorData>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_DA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialRuntimeParUpdate_C.__PropertyOffset_DA, value);
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0601DFCA RID: 122826 RVA: 0x00907DAC File Offset: 0x00905FAC
		// (set) Token: 0x0601DFCB RID: 122827 RVA: 0x00907DE5 File Offset: 0x00905FE5
		[Nullable(1)]
		public TMap<FName, FKuroCurveFloat> Custom_Scalar_Par_Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._Custom_Scalar_Par_Map) == null)
				{
					result = (this._Custom_Scalar_Par_Map = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Custom_Scalar_Par_Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Custom_Scalar_Par_Map.CopyAssign(value);
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0601DFCC RID: 122828 RVA: 0x00907DF3 File Offset: 0x00905FF3
		// (set) Token: 0x0601DFCD RID: 122829 RVA: 0x00907E03 File Offset: 0x00906003
		public unsafe float DateTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_DateTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_DateTime) = value;
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0601DFCE RID: 122830 RVA: 0x00907E14 File Offset: 0x00906014
		// (set) Token: 0x0601DFCF RID: 122831 RVA: 0x00907E28 File Offset: 0x00906028
		public unsafe FName FloatParam_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_FloatParam_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_FloatParam_0) = value;
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0601DFD0 RID: 122832 RVA: 0x00907E3D File Offset: 0x0090603D
		// (set) Token: 0x0601DFD1 RID: 122833 RVA: 0x00907E4D File Offset: 0x0090604D
		public unsafe float FloatParam_Value_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_FloatParam_Value_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_FloatParam_Value_0) = value;
			}
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0601DFD2 RID: 122834 RVA: 0x00907E5E File Offset: 0x0090605E
		// (set) Token: 0x0601DFD3 RID: 122835 RVA: 0x00907E72 File Offset: 0x00906072
		public unsafe FName VectorParam_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_VectorParam_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_VectorParam_0) = value;
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0601DFD4 RID: 122836 RVA: 0x00907E87 File Offset: 0x00906087
		// (set) Token: 0x0601DFD5 RID: 122837 RVA: 0x00907E9B File Offset: 0x0090609B
		public unsafe FLinearColor VectorParam_Value_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_VectorParam_Value_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_VectorParam_Value_0) = value;
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0601DFD6 RID: 122838 RVA: 0x00907EB0 File Offset: 0x009060B0
		// (set) Token: 0x0601DFD7 RID: 122839 RVA: 0x00907EE9 File Offset: 0x009060E9
		[Nullable(1)]
		public TArray<UMaterialInstance> Materials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Materials, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0601DFD8 RID: 122840 RVA: 0x00907EF7 File Offset: 0x009060F7
		// (set) Token: 0x0601DFD9 RID: 122841 RVA: 0x00907F07 File Offset: 0x00906107
		public unsafe bool IsPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_IsPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_IsPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0601DFDA RID: 122842 RVA: 0x00907F18 File Offset: 0x00906118
		// (set) Token: 0x0601DFDB RID: 122843 RVA: 0x00907F28 File Offset: 0x00906128
		public unsafe float Time_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Time_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Time_Speed) = value;
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0601DFDC RID: 122844 RVA: 0x00907F39 File Offset: 0x00906139
		// (set) Token: 0x0601DFDD RID: 122845 RVA: 0x00907F49 File Offset: 0x00906149
		public unsafe float MaxDurationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_MaxDurationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_MaxDurationTime) = value;
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0601DFDE RID: 122846 RVA: 0x00907F5A File Offset: 0x0090615A
		// (set) Token: 0x0601DFDF RID: 122847 RVA: 0x00907F6A File Offset: 0x0090616A
		public unsafe float Timer_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Timer_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MaterialRuntimeParUpdate_C.__PropertyOffset_Timer_0) = value;
			}
		}

		// Token: 0x0601DFE0 RID: 122848 RVA: 0x00907F7B File Offset: 0x0090617B
		[SkipLocalsInit]
		public virtual void CleanArray()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__CleanArray_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFE1 RID: 122849 RVA: 0x00907F8F File Offset: 0x0090618F
		[SkipLocalsInit]
		public virtual void Play()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__Play_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFE2 RID: 122850 RVA: 0x00907FA3 File Offset: 0x009061A3
		[SkipLocalsInit]
		public virtual void Set_Initialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__Set_Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFE3 RID: 122851 RVA: 0x00907FB7 File Offset: 0x009061B7
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFE4 RID: 122852 RVA: 0x00907FCB File Offset: 0x009061CB
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFE5 RID: 122853 RVA: 0x00907FDF File Offset: 0x009061DF
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFE6 RID: 122854 RVA: 0x00907FF3 File Offset: 0x009061F3
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFE7 RID: 122855 RVA: 0x00908008 File Offset: 0x00906208
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MaterialRuntimeParUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DFE8 RID: 122856 RVA: 0x00908050 File Offset: 0x00906250
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MaterialRuntimeParUpdate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MaterialRuntimeParUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MaterialRuntimeParUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DFE9 RID: 122857 RVA: 0x00908096 File Offset: 0x00906296
		protected BP_MaterialRuntimeParUpdate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD81 RID: 64897
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_MaterialRuntimeParUpdate.BP_MaterialRuntimeParUpdate_C";

		// Token: 0x0400FD82 RID: 64898
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD83 RID: 64899
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD84 RID: 64900
		internal static int __PropertyOffset_Target;

		// Token: 0x0400FD85 RID: 64901
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FD86 RID: 64902
		internal static int __PropertyOffset_Material_Index;

		// Token: 0x0400FD87 RID: 64903
		internal static int __PropertyOffset_NewVar_0;

		// Token: 0x0400FD88 RID: 64904
		internal static int __PropertyOffset_DA;

		// Token: 0x0400FD89 RID: 64905
		internal static int __PropertyOffset_Custom_Scalar_Par_Map;

		// Token: 0x0400FD8A RID: 64906
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _Custom_Scalar_Par_Map;

		// Token: 0x0400FD8B RID: 64907
		internal static int __PropertyOffset_DateTime;

		// Token: 0x0400FD8C RID: 64908
		internal static int __PropertyOffset_FloatParam_0;

		// Token: 0x0400FD8D RID: 64909
		internal static int __PropertyOffset_FloatParam_Value_0;

		// Token: 0x0400FD8E RID: 64910
		internal static int __PropertyOffset_VectorParam_0;

		// Token: 0x0400FD8F RID: 64911
		internal static int __PropertyOffset_VectorParam_Value_0;

		// Token: 0x0400FD90 RID: 64912
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400FD91 RID: 64913
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Materials;

		// Token: 0x0400FD92 RID: 64914
		internal static int __PropertyOffset_IsPlay;

		// Token: 0x0400FD93 RID: 64915
		internal static int __PropertyOffset_Time_Speed;

		// Token: 0x0400FD94 RID: 64916
		internal static int __PropertyOffset_MaxDurationTime;

		// Token: 0x0400FD95 RID: 64917
		internal static int __PropertyOffset_Timer_0;

		// Token: 0x0400FD96 RID: 64918
		private static IntPtr __CleanArray_NativeFunctionPtr;

		// Token: 0x0400FD97 RID: 64919
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x0400FD98 RID: 64920
		private static IntPtr __Set_Initialize_NativeFunctionPtr;

		// Token: 0x0400FD99 RID: 64921
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FD9A RID: 64922
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FD9B RID: 64923
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008DFF RID: 36351
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA27 RID: 182823
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
