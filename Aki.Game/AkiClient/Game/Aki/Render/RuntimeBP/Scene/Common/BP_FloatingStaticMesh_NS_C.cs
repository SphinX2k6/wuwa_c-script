using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B5C RID: 15196
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh_NS.BP_FloatingStaticMesh_NS_C")]
	[UnrealStructLayout(2816, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2816)]
	public class BP_FloatingStaticMesh_NS_C : AKuroFloatingStaticMesh, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B4A RID: 138058 RVA: 0x008F3948 File Offset: 0x008F1B48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatingStaticMesh_NS_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh_NS.BP_FloatingStaticMesh_NS_C");
			}
			return BP_FloatingStaticMesh_NS_C._ClassPtr;
		}

		// Token: 0x06021B4B RID: 138059 RVA: 0x008F396C File Offset: 0x008F1B6C
		public BP_FloatingStaticMesh_NS_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatingStaticMesh_NS_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B4C RID: 138060 RVA: 0x008F3994 File Offset: 0x008F1B94
		[NullableContext(1)]
		public BP_FloatingStaticMesh_NS_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatingStaticMesh_NS_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x06021B4D RID: 138061 RVA: 0x008F39C7 File Offset: 0x008F1BC7
		// (set) Token: 0x06021B4E RID: 138062 RVA: 0x008F39DB File Offset: 0x008F1BDB
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x06021B4F RID: 138063 RVA: 0x008F39F0 File Offset: 0x008F1BF0
		// (set) Token: 0x06021B50 RID: 138064 RVA: 0x008F3A04 File Offset: 0x008F1C04
		public unsafe UKuroVirtualAttachmentParentComponent KuroVirtualAttachmentParent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVirtualAttachmentParentComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x06021B51 RID: 138065 RVA: 0x008F3A19 File Offset: 0x008F1C19
		// (set) Token: 0x06021B52 RID: 138066 RVA: 0x008F3A2D File Offset: 0x008F1C2D
		public unsafe UStaticMeshComponent StaticMeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x06021B53 RID: 138067 RVA: 0x008F3A42 File Offset: 0x008F1C42
		// (set) Token: 0x06021B54 RID: 138068 RVA: 0x008F3A56 File Offset: 0x008F1C56
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x06021B55 RID: 138069 RVA: 0x008F3A6B File Offset: 0x008F1C6B
		// (set) Token: 0x06021B56 RID: 138070 RVA: 0x008F3A7B File Offset: 0x008F1C7B
		public unsafe bool 使用材质参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x06021B57 RID: 138071 RVA: 0x008F3A8C File Offset: 0x008F1C8C
		// (set) Token: 0x06021B58 RID: 138072 RVA: 0x008F3AC5 File Offset: 0x008F1CC5
		[Nullable(1)]
		public TMap<FName, float> FloatParameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x06021B59 RID: 138073 RVA: 0x008F3AD4 File Offset: 0x008F1CD4
		// (set) Token: 0x06021B5A RID: 138074 RVA: 0x008F3B0D File Offset: 0x008F1D0D
		[Nullable(1)]
		public TMap<FName, FLinearColor> ColorParameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x06021B5B RID: 138075 RVA: 0x008F3B1B File Offset: 0x008F1D1B
		// (set) Token: 0x06021B5C RID: 138076 RVA: 0x008F3B2F File Offset: 0x008F1D2F
		public unsafe FLinearColor EmissionDayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x06021B5D RID: 138077 RVA: 0x008F3B44 File Offset: 0x008F1D44
		// (set) Token: 0x06021B5E RID: 138078 RVA: 0x008F3B58 File Offset: 0x008F1D58
		public unsafe FLinearColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x06021B5F RID: 138079 RVA: 0x008F3B6D File Offset: 0x008F1D6D
		// (set) Token: 0x06021B60 RID: 138080 RVA: 0x008F3B7D File Offset: 0x008F1D7D
		public unsafe bool UseWholeDayEmission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x06021B61 RID: 138081 RVA: 0x008F3B90 File Offset: 0x008F1D90
		// (set) Token: 0x06021B62 RID: 138082 RVA: 0x008F3BC9 File Offset: 0x008F1DC9
		[Nullable(1)]
		public TMap<AActor, FTransformDouble> ChildActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FTransformDouble> result;
				if ((result = this._ChildActors) == null)
				{
					result = (this._ChildActors = new TMap<AActor, FTransformDouble>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ChildActors.CopyAssign(value);
			}
		}

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x06021B63 RID: 138083 RVA: 0x008F3BD8 File Offset: 0x008F1DD8
		// (set) Token: 0x06021B64 RID: 138084 RVA: 0x008F3C11 File Offset: 0x008F1E11
		[Nullable(1)]
		public TArray<float> CustomData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new TArray<float>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x06021B65 RID: 138085 RVA: 0x008F3C1F File Offset: 0x008F1E1F
		// (set) Token: 0x06021B66 RID: 138086 RVA: 0x008F3C2F File Offset: 0x008F1E2F
		public unsafe bool SpecialBlueprintActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x06021B67 RID: 138087 RVA: 0x008F3C40 File Offset: 0x008F1E40
		// (set) Token: 0x06021B68 RID: 138088 RVA: 0x008F3C50 File Offset: 0x008F1E50
		public unsafe bool OverrideSuperFarActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x06021B69 RID: 138089 RVA: 0x008F3C61 File Offset: 0x008F1E61
		// (set) Token: 0x06021B6A RID: 138090 RVA: 0x008F3C71 File Offset: 0x008F1E71
		public unsafe bool HiddenState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_NS_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x06021B6B RID: 138091 RVA: 0x008F3C82 File Offset: 0x008F1E82
		// (set) Token: 0x06021B6C RID: 138092 RVA: 0x008F3C96 File Offset: 0x008F1E96
		public unsafe UNiagaraSystem NiagaraSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_NS_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x06021B6D RID: 138093 RVA: 0x008F3CAB File Offset: 0x008F1EAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetCustomData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_NS_C.__SetCustomData_NativeFunctionPtr, null);
		}

		// Token: 0x06021B6E RID: 138094 RVA: 0x008F3CC0 File Offset: 0x008F1EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CopyCustomPrimitiveData(UStaticMeshComponent Target)
		{
			BP_FloatingStaticMesh_NS_C.__CopyCustomPrimitiveData_FunctionParams* ptr = stackalloc BP_FloatingStaticMesh_NS_C.__CopyCustomPrimitiveData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FloatingStaticMesh_NS_C.__CopyCustomPrimitiveData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingStaticMesh_NS_C.__CopyCustomPrimitiveData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_NS_C.__CopyCustomPrimitiveData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021B6F RID: 138095 RVA: 0x008F3D15 File Offset: 0x008F1F15
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshChildActors()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_NS_C.__RefreshChildActors_NativeFunctionPtr, null);
		}

		// Token: 0x06021B70 RID: 138096 RVA: 0x008F3D29 File Offset: 0x008F1F29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_NS_C.__SetMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x06021B71 RID: 138097 RVA: 0x008F3D3D File Offset: 0x008F1F3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_NS_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021B72 RID: 138098 RVA: 0x008F3D51 File Offset: 0x008F1F51
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingStaticMesh_NS_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021B73 RID: 138099 RVA: 0x008F3D66 File Offset: 0x008F1F66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_NS_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021B74 RID: 138100 RVA: 0x008F3D7A File Offset: 0x008F1F7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingStaticMesh_NS_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021B75 RID: 138101 RVA: 0x008F3D8F File Offset: 0x008F1F8F
		protected BP_FloatingStaticMesh_NS_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401071C RID: 67356
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh_NS.BP_FloatingStaticMesh_NS_C";

		// Token: 0x0401071D RID: 67357
		private static IntPtr _ClassPtr;

		// Token: 0x0401071E RID: 67358
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401071F RID: 67359
		internal static int __PropertyOffset_1;

		// Token: 0x04010720 RID: 67360
		internal static int __PropertyOffset_2;

		// Token: 0x04010721 RID: 67361
		internal static int __PropertyOffset_3;

		// Token: 0x04010722 RID: 67362
		internal static int __PropertyOffset_4;

		// Token: 0x04010723 RID: 67363
		internal static int __PropertyOffset_5;

		// Token: 0x04010724 RID: 67364
		internal static int __PropertyOffset_6;

		// Token: 0x04010725 RID: 67365
		private TMap<FName, float> _FloatParameters;

		// Token: 0x04010726 RID: 67366
		internal static int __PropertyOffset_7;

		// Token: 0x04010727 RID: 67367
		private TMap<FName, FLinearColor> _ColorParameters;

		// Token: 0x04010728 RID: 67368
		internal static int __PropertyOffset_8;

		// Token: 0x04010729 RID: 67369
		internal static int __PropertyOffset_9;

		// Token: 0x0401072A RID: 67370
		internal static int __PropertyOffset_10;

		// Token: 0x0401072B RID: 67371
		internal static int __PropertyOffset_11;

		// Token: 0x0401072C RID: 67372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<AActor, FTransformDouble> _ChildActors;

		// Token: 0x0401072D RID: 67373
		internal static int __PropertyOffset_12;

		// Token: 0x0401072E RID: 67374
		private TArray<float> _CustomData;

		// Token: 0x0401072F RID: 67375
		internal static int __PropertyOffset_13;

		// Token: 0x04010730 RID: 67376
		internal static int __PropertyOffset_14;

		// Token: 0x04010731 RID: 67377
		internal static int __PropertyOffset_15;

		// Token: 0x04010732 RID: 67378
		internal static int __PropertyOffset_16;

		// Token: 0x04010733 RID: 67379
		private static IntPtr __SetCustomData_NativeFunctionPtr;

		// Token: 0x04010734 RID: 67380
		private static IntPtr __CopyCustomPrimitiveData_NativeFunctionPtr;

		// Token: 0x04010735 RID: 67381
		private static IntPtr __RefreshChildActors_NativeFunctionPtr;

		// Token: 0x04010736 RID: 67382
		private static IntPtr __SetMaterialParams_NativeFunctionPtr;

		// Token: 0x04010737 RID: 67383
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010738 RID: 67384
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009CC2 RID: 40130
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CopyCustomPrimitiveData_FunctionParams
		{
			// Token: 0x040313A7 RID: 201639
			[FieldOffset(0)]
			public IntPtr Target;
		}
	}
}
