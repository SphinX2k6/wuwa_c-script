using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.CarPaint.BluePrints
{
	// Token: 0x02003CCB RID: 15563
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarPaintChange.BP_CarPaintChange_C")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class BP_CarPaintChange_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_CarPaintChange_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06024D7F RID: 150911 RVA: 0x00949C52 File Offset: 0x00947E52
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CarPaintChange_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarPaintChange.BP_CarPaintChange_C");
			}
			return BP_CarPaintChange_C._ClassPtr;
		}

		// Token: 0x06024D80 RID: 150912 RVA: 0x00949C78 File Offset: 0x00947E78
		public BP_CarPaintChange_C() : this(BuiltinUtils.AllocNativeUObject(BP_CarPaintChange_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024D81 RID: 150913 RVA: 0x00949CA0 File Offset: 0x00947EA0
		[NullableContext(1)]
		public BP_CarPaintChange_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CarPaintChange_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x06024D82 RID: 150914 RVA: 0x00949CD3 File Offset: 0x00947ED3
		// (set) Token: 0x06024D83 RID: 150915 RVA: 0x00949CE7 File Offset: 0x00947EE7
		public unsafe UStaticMeshComponent PlaneDissolve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x06024D84 RID: 150916 RVA: 0x00949CFC File Offset: 0x00947EFC
		// (set) Token: 0x06024D85 RID: 150917 RVA: 0x00949D10 File Offset: 0x00947F10
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x06024D86 RID: 150918 RVA: 0x00949D25 File Offset: 0x00947F25
		// (set) Token: 0x06024D87 RID: 150919 RVA: 0x00949D39 File Offset: 0x00947F39
		public unsafe UStaticMeshComponent SM_Vehicle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x06024D88 RID: 150920 RVA: 0x00949D4E File Offset: 0x00947F4E
		// (set) Token: 0x06024D89 RID: 150921 RVA: 0x00949D62 File Offset: 0x00947F62
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700496C RID: 18796
		// (get) Token: 0x06024D8A RID: 150922 RVA: 0x00949D77 File Offset: 0x00947F77
		// (set) Token: 0x06024D8B RID: 150923 RVA: 0x00949D87 File Offset: 0x00947F87
		public unsafe float CurrentColorSet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x06024D8C RID: 150924 RVA: 0x00949D98 File Offset: 0x00947F98
		// (set) Token: 0x06024D8D RID: 150925 RVA: 0x00949DA8 File Offset: 0x00947FA8
		public unsafe float TargetColorSet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x06024D8E RID: 150926 RVA: 0x00949DB9 File Offset: 0x00947FB9
		// (set) Token: 0x06024D8F RID: 150927 RVA: 0x00949DC9 File Offset: 0x00947FC9
		public unsafe float ColorChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x06024D90 RID: 150928 RVA: 0x00949DDA File Offset: 0x00947FDA
		// (set) Token: 0x06024D91 RID: 150929 RVA: 0x00949DEA File Offset: 0x00947FEA
		public unsafe bool ShouldUpdateChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x06024D92 RID: 150930 RVA: 0x00949DFB File Offset: 0x00947FFB
		// (set) Token: 0x06024D93 RID: 150931 RVA: 0x00949E0F File Offset: 0x0094800F
		public unsafe UMaterialInstanceDynamic CarPaintDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x06024D94 RID: 150932 RVA: 0x00949E24 File Offset: 0x00948024
		// (set) Token: 0x06024D95 RID: 150933 RVA: 0x00949E38 File Offset: 0x00948038
		public unsafe UMaterialInstanceDynamic CarPaintDMI1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x06024D96 RID: 150934 RVA: 0x00949E4D File Offset: 0x0094804D
		// (set) Token: 0x06024D97 RID: 150935 RVA: 0x00949E61 File Offset: 0x00948061
		public unsafe UMaterialInstanceDynamic CarPaintDMI2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004973 RID: 18803
		// (get) Token: 0x06024D98 RID: 150936 RVA: 0x00949E78 File Offset: 0x00948078
		// (set) Token: 0x06024D99 RID: 150937 RVA: 0x00949EB1 File Offset: 0x009480B1
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> CarPaintDMIList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._CarPaintDMIList) == null)
				{
					result = (this._CarPaintDMIList = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CarPaintDMIList.CopyAssign(value);
			}
		}

		// Token: 0x17004974 RID: 18804
		// (get) Token: 0x06024D9A RID: 150938 RVA: 0x00949EBF File Offset: 0x009480BF
		// (set) Token: 0x06024D9B RID: 150939 RVA: 0x00949ECF File Offset: 0x009480CF
		public unsafe int ColorSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x06024D9C RID: 150940 RVA: 0x00949EE0 File Offset: 0x009480E0
		// (set) Token: 0x06024D9D RID: 150941 RVA: 0x00949EF0 File Offset: 0x009480F0
		public unsafe bool PlayPlaneDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x06024D9E RID: 150942 RVA: 0x00949F01 File Offset: 0x00948101
		// (set) Token: 0x06024D9F RID: 150943 RVA: 0x00949F11 File Offset: 0x00948111
		public unsafe float DirEdgeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x06024DA0 RID: 150944 RVA: 0x00949F22 File Offset: 0x00948122
		// (set) Token: 0x06024DA1 RID: 150945 RVA: 0x00949F36 File Offset: 0x00948136
		public unsafe FLinearColor PlaneDisEdgeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x06024DA2 RID: 150946 RVA: 0x00949F4B File Offset: 0x0094814B
		// (set) Token: 0x06024DA3 RID: 150947 RVA: 0x00949F5F File Offset: 0x0094815F
		public unsafe UStaticMesh SMVehicle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x06024DA4 RID: 150948 RVA: 0x00949F74 File Offset: 0x00948174
		// (set) Token: 0x06024DA5 RID: 150949 RVA: 0x00949F84 File Offset: 0x00948184
		public unsafe bool EditorDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x06024DA6 RID: 150950 RVA: 0x00949F95 File Offset: 0x00948195
		// (set) Token: 0x06024DA7 RID: 150951 RVA: 0x00949FA5 File Offset: 0x009481A5
		public unsafe float ChangeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x06024DA8 RID: 150952 RVA: 0x00949FB6 File Offset: 0x009481B6
		// (set) Token: 0x06024DA9 RID: 150953 RVA: 0x00949FC6 File Offset: 0x009481C6
		public unsafe float ChangeEdgeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700497C RID: 18812
		// (get) Token: 0x06024DAA RID: 150954 RVA: 0x00949FD7 File Offset: 0x009481D7
		// (set) Token: 0x06024DAB RID: 150955 RVA: 0x00949FEB File Offset: 0x009481EB
		public unsafe FLinearColor ChangeEdgeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700497D RID: 18813
		// (get) Token: 0x06024DAC RID: 150956 RVA: 0x0094A000 File Offset: 0x00948200
		// (set) Token: 0x06024DAD RID: 150957 RVA: 0x0094A010 File Offset: 0x00948210
		public unsafe bool UseBPTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x06024DAE RID: 150958 RVA: 0x0094A021 File Offset: 0x00948221
		// (set) Token: 0x06024DAF RID: 150959 RVA: 0x0094A035 File Offset: 0x00948235
		public unsafe UTexture2D BaseTex2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x06024DB0 RID: 150960 RVA: 0x0094A04A File Offset: 0x0094824A
		// (set) Token: 0x06024DB1 RID: 150961 RVA: 0x0094A05E File Offset: 0x0094825E
		public unsafe UTexture2D BaseTex3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x06024DB2 RID: 150962 RVA: 0x0094A073 File Offset: 0x00948273
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RecoverMat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__RecoverMat_NativeFunctionPtr, null);
		}

		// Token: 0x06024DB3 RID: 150963 RVA: 0x0094A087 File Offset: 0x00948287
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Initialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x06024DB4 RID: 150964 RVA: 0x0094A09C File Offset: 0x0094829C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDMIListScalar([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstanceDynamic> NewParam)
		{
			BP_CarPaintChange_C.__SetDMIListScalar_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__SetDMIListScalar_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_CarPaintChange_C.__SetDMIListScalar_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__SetDMIListScalar_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UMaterialInstanceDynamic> tarray = NewParam;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->NewParam);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetDMIListScalar_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInstanceDynamic> tarray2 = NewParam;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->NewParam);
			}
			UnrealReflectionUtils.DestroyStruct(BP_CarPaintChange_C.__SetDMIListScalar_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06024DB5 RID: 150965 RVA: 0x0094A114 File Offset: 0x00948314
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDMI(UMaterialInstanceDynamic NewParam)
		{
			BP_CarPaintChange_C.__SetDMI_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__SetDMI_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_CarPaintChange_C.__SetDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__SetDMI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = ((NewParam != null) ? NewParam.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetDMI_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024DB6 RID: 150966 RVA: 0x0094A169 File Offset: 0x00948369
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetColorFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetColorFunction_NativeFunctionPtr, null);
		}

		// Token: 0x06024DB7 RID: 150967 RVA: 0x0094A17D File Offset: 0x0094837D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024DB8 RID: 150968 RVA: 0x0094A191 File Offset: 0x00948391
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarPaintChange_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024DB9 RID: 150969 RVA: 0x0094A1A6 File Offset: 0x009483A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024DBA RID: 150970 RVA: 0x0094A1BA File Offset: 0x009483BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarPaintChange_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024DBB RID: 150971 RVA: 0x0094A1D0 File Offset: 0x009483D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CarPaintChange_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024DBC RID: 150972 RVA: 0x0094A218 File Offset: 0x00948418
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CarPaintChange_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarPaintChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024DBD RID: 150973 RVA: 0x0094A260 File Offset: 0x00948460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetColorChange(float TargetColorSet)
		{
			BP_CarPaintChange_C.__SetColorChange_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__SetColorChange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__SetColorChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__SetColorChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetColorSet = TargetColorSet;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetColorChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024DBE RID: 150974 RVA: 0x0094A2A8 File Offset: 0x009484A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CarPaintChange_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024DBF RID: 150975 RVA: 0x0094A2F0 File Offset: 0x009484F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CarPaintChange_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarPaintChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024DC0 RID: 150976 RVA: 0x0094A338 File Offset: 0x00948538
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetColorFunctionByBPI(bool _bool)
		{
			BP_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__SetColorFunctionByBPI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->_bool = _bool;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetColorFunctionByBPI_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024DC1 RID: 150977 RVA: 0x0094A37E File Offset: 0x0094857E
		protected BP_CarPaintChange_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012503 RID: 75011
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarPaintChange.BP_CarPaintChange_C";

		// Token: 0x04012504 RID: 75012
		private static IntPtr _ClassPtr;

		// Token: 0x04012505 RID: 75013
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012506 RID: 75014
		internal static int __PropertyOffset_1;

		// Token: 0x04012507 RID: 75015
		internal static int __PropertyOffset_2;

		// Token: 0x04012508 RID: 75016
		internal static int __PropertyOffset_3;

		// Token: 0x04012509 RID: 75017
		internal static int __PropertyOffset_4;

		// Token: 0x0401250A RID: 75018
		internal static int __PropertyOffset_5;

		// Token: 0x0401250B RID: 75019
		internal static int __PropertyOffset_6;

		// Token: 0x0401250C RID: 75020
		internal static int __PropertyOffset_7;

		// Token: 0x0401250D RID: 75021
		internal static int __PropertyOffset_8;

		// Token: 0x0401250E RID: 75022
		internal static int __PropertyOffset_9;

		// Token: 0x0401250F RID: 75023
		internal static int __PropertyOffset_10;

		// Token: 0x04012510 RID: 75024
		internal static int __PropertyOffset_11;

		// Token: 0x04012511 RID: 75025
		internal static int __PropertyOffset_12;

		// Token: 0x04012512 RID: 75026
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CarPaintDMIList;

		// Token: 0x04012513 RID: 75027
		internal static int __PropertyOffset_13;

		// Token: 0x04012514 RID: 75028
		internal static int __PropertyOffset_14;

		// Token: 0x04012515 RID: 75029
		internal static int __PropertyOffset_15;

		// Token: 0x04012516 RID: 75030
		internal static int __PropertyOffset_16;

		// Token: 0x04012517 RID: 75031
		internal static int __PropertyOffset_17;

		// Token: 0x04012518 RID: 75032
		internal static int __PropertyOffset_18;

		// Token: 0x04012519 RID: 75033
		internal static int __PropertyOffset_19;

		// Token: 0x0401251A RID: 75034
		internal static int __PropertyOffset_20;

		// Token: 0x0401251B RID: 75035
		internal static int __PropertyOffset_21;

		// Token: 0x0401251C RID: 75036
		internal static int __PropertyOffset_22;

		// Token: 0x0401251D RID: 75037
		internal static int __PropertyOffset_23;

		// Token: 0x0401251E RID: 75038
		internal static int __PropertyOffset_24;

		// Token: 0x0401251F RID: 75039
		private static IntPtr __RecoverMat_NativeFunctionPtr;

		// Token: 0x04012520 RID: 75040
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04012521 RID: 75041
		private static IntPtr __SetDMIListScalar_NativeFunctionPtr;

		// Token: 0x04012522 RID: 75042
		private static IntPtr __SetDMI_NativeFunctionPtr;

		// Token: 0x04012523 RID: 75043
		private static IntPtr __SetColorFunction_NativeFunctionPtr;

		// Token: 0x04012524 RID: 75044
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012525 RID: 75045
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012526 RID: 75046
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012527 RID: 75047
		private static IntPtr __SetColorChange_NativeFunctionPtr;

		// Token: 0x04012528 RID: 75048
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012529 RID: 75049
		private static IntPtr __SetColorFunctionByBPI_NativeFunctionPtr;

		// Token: 0x02009F76 RID: 40822
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetDMIListScalar_FunctionParams
		{
			// Token: 0x0403197D RID: 203133
			[FieldOffset(0)]
			public byte NewParam;
		}

		// Token: 0x02009F77 RID: 40823
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetDMI_FunctionParams
		{
			// Token: 0x0403197E RID: 203134
			[FieldOffset(0)]
			public IntPtr NewParam;
		}

		// Token: 0x02009F78 RID: 40824
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403197F RID: 203135
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F79 RID: 40825
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetColorChange_FunctionParams
		{
			// Token: 0x04031980 RID: 203136
			[FieldOffset(0)]
			public float TargetColorSet;
		}

		// Token: 0x02009F7A RID: 40826
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031981 RID: 203137
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F7B RID: 40827
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetColorFunctionByBPI_FunctionParams
		{
			// Token: 0x04031982 RID: 203138
			[FieldOffset(0)]
			public bool _bool;
		}
	}
}
