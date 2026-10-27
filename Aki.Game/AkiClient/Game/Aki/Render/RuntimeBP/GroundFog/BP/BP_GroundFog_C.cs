using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GroundFog.BP
{
	// Token: 0x02003D28 RID: 15656
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_GroundFog.BP_GroundFog_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1681)]
	public class BP_GroundFog_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025A7A RID: 154234 RVA: 0x0095F8EC File Offset: 0x0095DAEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GroundFog_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_GroundFog.BP_GroundFog_C");
			}
			return BP_GroundFog_C._ClassPtr;
		}

		// Token: 0x06025A7B RID: 154235 RVA: 0x0095F910 File Offset: 0x0095DB10
		public BP_GroundFog_C() : this(BuiltinUtils.AllocNativeUObject(BP_GroundFog_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025A7C RID: 154236 RVA: 0x0095F938 File Offset: 0x0095DB38
		[NullableContext(1)]
		public BP_GroundFog_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GroundFog_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DE1 RID: 19937
		// (get) Token: 0x06025A7D RID: 154237 RVA: 0x0095F96B File Offset: 0x0095DB6B
		// (set) Token: 0x06025A7E RID: 154238 RVA: 0x0095F97F File Offset: 0x0095DB7F
		public unsafe UStaticMeshComponent CloudBaseMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004DE2 RID: 19938
		// (get) Token: 0x06025A7F RID: 154239 RVA: 0x0095F994 File Offset: 0x0095DB94
		// (set) Token: 0x06025A80 RID: 154240 RVA: 0x0095F9A8 File Offset: 0x0095DBA8
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004DE3 RID: 19939
		// (get) Token: 0x06025A81 RID: 154241 RVA: 0x0095F9BD File Offset: 0x0095DBBD
		// (set) Token: 0x06025A82 RID: 154242 RVA: 0x0095F9D1 File Offset: 0x0095DBD1
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004DE4 RID: 19940
		// (get) Token: 0x06025A83 RID: 154243 RVA: 0x0095F9E6 File Offset: 0x0095DBE6
		// (set) Token: 0x06025A84 RID: 154244 RVA: 0x0095F9FA File Offset: 0x0095DBFA
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004DE5 RID: 19941
		// (get) Token: 0x06025A85 RID: 154245 RVA: 0x0095FA0F File Offset: 0x0095DC0F
		// (set) Token: 0x06025A86 RID: 154246 RVA: 0x0095FA23 File Offset: 0x0095DC23
		public unsafe UProceduralMeshComponent ProceduralMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004DE6 RID: 19942
		// (get) Token: 0x06025A87 RID: 154247 RVA: 0x0095FA38 File Offset: 0x0095DC38
		// (set) Token: 0x06025A88 RID: 154248 RVA: 0x0095FA4C File Offset: 0x0095DC4C
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004DE7 RID: 19943
		// (get) Token: 0x06025A89 RID: 154249 RVA: 0x0095FA61 File Offset: 0x0095DC61
		// (set) Token: 0x06025A8A RID: 154250 RVA: 0x0095FA75 File Offset: 0x0095DC75
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004DE8 RID: 19944
		// (get) Token: 0x06025A8B RID: 154251 RVA: 0x0095FA8A File Offset: 0x0095DC8A
		// (set) Token: 0x06025A8C RID: 154252 RVA: 0x0095FA9A File Offset: 0x0095DC9A
		public unsafe int Segments
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004DE9 RID: 19945
		// (get) Token: 0x06025A8D RID: 154253 RVA: 0x0095FAAC File Offset: 0x0095DCAC
		// (set) Token: 0x06025A8E RID: 154254 RVA: 0x0095FAE5 File Offset: 0x0095DCE5
		[Nullable(1)]
		public TArray<FVector> PointArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PointArray) == null)
				{
					result = (this._PointArray = new TArray<FVector>(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PointArray.CopyAssign(value);
			}
		}

		// Token: 0x17004DEA RID: 19946
		// (get) Token: 0x06025A8F RID: 154255 RVA: 0x0095FAF4 File Offset: 0x0095DCF4
		// (set) Token: 0x06025A90 RID: 154256 RVA: 0x0095FB2D File Offset: 0x0095DD2D
		[Nullable(1)]
		public TArray<int> Triangles
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Triangles) == null)
				{
					result = (this._Triangles = new TArray<int>(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Triangles.CopyAssign(value);
			}
		}

		// Token: 0x17004DEB RID: 19947
		// (get) Token: 0x06025A91 RID: 154257 RVA: 0x0095FB3C File Offset: 0x0095DD3C
		// (set) Token: 0x06025A92 RID: 154258 RVA: 0x0095FB75 File Offset: 0x0095DD75
		[Nullable(1)]
		public TArray<FVector> NormalArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._NormalArray) == null)
				{
					result = (this._NormalArray = new TArray<FVector>(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NormalArray.CopyAssign(value);
			}
		}

		// Token: 0x17004DEC RID: 19948
		// (get) Token: 0x06025A93 RID: 154259 RVA: 0x0095FB84 File Offset: 0x0095DD84
		// (set) Token: 0x06025A94 RID: 154260 RVA: 0x0095FBBD File Offset: 0x0095DDBD
		[Nullable(1)]
		public TArray<FVector2D> UV
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._UV) == null)
				{
					result = (this._UV = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UV.CopyAssign(value);
			}
		}

		// Token: 0x17004DED RID: 19949
		// (get) Token: 0x06025A95 RID: 154261 RVA: 0x0095FBCB File Offset: 0x0095DDCB
		// (set) Token: 0x06025A96 RID: 154262 RVA: 0x0095FBDF File Offset: 0x0095DDDF
		public unsafe UMaterialInstanceDynamic PlaneFogMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004DEE RID: 19950
		// (get) Token: 0x06025A97 RID: 154263 RVA: 0x0095FBF4 File Offset: 0x0095DDF4
		// (set) Token: 0x06025A98 RID: 154264 RVA: 0x0095FC08 File Offset: 0x0095DE08
		public unsafe FVectorDouble CharacterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004DEF RID: 19951
		// (get) Token: 0x06025A99 RID: 154265 RVA: 0x0095FC1D File Offset: 0x0095DE1D
		// (set) Token: 0x06025A9A RID: 154266 RVA: 0x0095FC31 File Offset: 0x0095DE31
		public unsafe FVector CharacterPosPrez
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004DF0 RID: 19952
		// (get) Token: 0x06025A9B RID: 154267 RVA: 0x0095FC46 File Offset: 0x0095DE46
		// (set) Token: 0x06025A9C RID: 154268 RVA: 0x0095FC56 File Offset: 0x0095DE56
		public unsafe float FadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004DF1 RID: 19953
		// (get) Token: 0x06025A9D RID: 154269 RVA: 0x0095FC67 File Offset: 0x0095DE67
		// (set) Token: 0x06025A9E RID: 154270 RVA: 0x0095FC77 File Offset: 0x0095DE77
		public unsafe float CharacterV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004DF2 RID: 19954
		// (get) Token: 0x06025A9F RID: 154271 RVA: 0x0095FC88 File Offset: 0x0095DE88
		// (set) Token: 0x06025AA0 RID: 154272 RVA: 0x0095FC98 File Offset: 0x0095DE98
		public unsafe float ParticleSpawnDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004DF3 RID: 19955
		// (get) Token: 0x06025AA1 RID: 154273 RVA: 0x0095FCA9 File Offset: 0x0095DEA9
		// (set) Token: 0x06025AA2 RID: 154274 RVA: 0x0095FCB9 File Offset: 0x0095DEB9
		public unsafe bool UpdatePerFourFrame01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DF4 RID: 19956
		// (get) Token: 0x06025AA3 RID: 154275 RVA: 0x0095FCCA File Offset: 0x0095DECA
		// (set) Token: 0x06025AA4 RID: 154276 RVA: 0x0095FCDA File Offset: 0x0095DEDA
		public unsafe bool UpdatePerFourFrame02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DF5 RID: 19957
		// (get) Token: 0x06025AA5 RID: 154277 RVA: 0x0095FCEB File Offset: 0x0095DEEB
		// (set) Token: 0x06025AA6 RID: 154278 RVA: 0x0095FCFB File Offset: 0x0095DEFB
		public unsafe bool UpdatePerFourFrame03
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004DF6 RID: 19958
		// (get) Token: 0x06025AA7 RID: 154279 RVA: 0x0095FD0C File Offset: 0x0095DF0C
		// (set) Token: 0x06025AA8 RID: 154280 RVA: 0x0095FD20 File Offset: 0x0095DF20
		public unsafe FVector position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004DF7 RID: 19959
		// (get) Token: 0x06025AA9 RID: 154281 RVA: 0x0095FD35 File Offset: 0x0095DF35
		// (set) Token: 0x06025AAA RID: 154282 RVA: 0x0095FD49 File Offset: 0x0095DF49
		public unsafe UStaticMesh CloudStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17004DF8 RID: 19960
		// (get) Token: 0x06025AAB RID: 154283 RVA: 0x0095FD5E File Offset: 0x0095DF5E
		// (set) Token: 0x06025AAC RID: 154284 RVA: 0x0095FD72 File Offset: 0x0095DF72
		public unsafe UMaterialInstance CloudMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17004DF9 RID: 19961
		// (get) Token: 0x06025AAD RID: 154285 RVA: 0x0095FD87 File Offset: 0x0095DF87
		// (set) Token: 0x06025AAE RID: 154286 RVA: 0x0095FD9B File Offset: 0x0095DF9B
		public unsafe UMaterialInstanceDynamic CloudMat_DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroundFog_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17004DFA RID: 19962
		// (get) Token: 0x06025AAF RID: 154287 RVA: 0x0095FDB0 File Offset: 0x0095DFB0
		// (set) Token: 0x06025AB0 RID: 154288 RVA: 0x0095FDC0 File Offset: 0x0095DFC0
		public unsafe bool IsEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroundFog_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025AB1 RID: 154289 RVA: 0x0095FDD1 File Offset: 0x0095DFD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePerFourFrame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__UpdatePerFourFrame_NativeFunctionPtr, null);
		}

		// Token: 0x06025AB2 RID: 154290 RVA: 0x0095FDE5 File Offset: 0x0095DFE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalculateCharacterSpace()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__CalculateCharacterSpace_NativeFunctionPtr, null);
		}

		// Token: 0x06025AB3 RID: 154291 RVA: 0x0095FDF9 File Offset: 0x0095DFF9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Calculate_Character_Speed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__Calculate_Character_Speed_NativeFunctionPtr, null);
		}

		// Token: 0x06025AB4 RID: 154292 RVA: 0x0095FE0D File Offset: 0x0095E00D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalculateUVs()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__CalculateUVs_NativeFunctionPtr, null);
		}

		// Token: 0x06025AB5 RID: 154293 RVA: 0x0095FE21 File Offset: 0x0095E021
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalculateNormals()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__CalculateNormals_NativeFunctionPtr, null);
		}

		// Token: 0x06025AB6 RID: 154294 RVA: 0x0095FE35 File Offset: 0x0095E035
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Calculate_Triangles()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__Calculate_Triangles_NativeFunctionPtr, null);
		}

		// Token: 0x06025AB7 RID: 154295 RVA: 0x0095FE49 File Offset: 0x0095E049
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetCurvePoints()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__GetCurvePoints_NativeFunctionPtr, null);
		}

		// Token: 0x06025AB8 RID: 154296 RVA: 0x0095FE5D File Offset: 0x0095E05D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025AB9 RID: 154297 RVA: 0x0095FE71 File Offset: 0x0095E071
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GroundFog_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025ABA RID: 154298 RVA: 0x0095FE88 File Offset: 0x0095E088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_GroundFog_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GroundFog_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GroundFog_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroundFog_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025ABB RID: 154299 RVA: 0x0095FED0 File Offset: 0x0095E0D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_GroundFog_C.__EditorTick_FunctionParams* ptr = stackalloc BP_GroundFog_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GroundFog_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroundFog_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GroundFog_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025ABC RID: 154300 RVA: 0x0095FF18 File Offset: 0x0095E118
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GroundFog_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GroundFog_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GroundFog_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroundFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroundFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025ABD RID: 154301 RVA: 0x0095FF60 File Offset: 0x0095E160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GroundFog_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GroundFog_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GroundFog_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroundFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GroundFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025ABE RID: 154302 RVA: 0x0095FFA7 File Offset: 0x0095E1A7
		protected BP_GroundFog_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CE7 RID: 77031
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_GroundFog.BP_GroundFog_C";

		// Token: 0x04012CE8 RID: 77032
		private static IntPtr _ClassPtr;

		// Token: 0x04012CE9 RID: 77033
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CEA RID: 77034
		internal static int __PropertyOffset_1;

		// Token: 0x04012CEB RID: 77035
		internal static int __PropertyOffset_2;

		// Token: 0x04012CEC RID: 77036
		internal static int __PropertyOffset_3;

		// Token: 0x04012CED RID: 77037
		internal static int __PropertyOffset_4;

		// Token: 0x04012CEE RID: 77038
		internal static int __PropertyOffset_5;

		// Token: 0x04012CEF RID: 77039
		internal static int __PropertyOffset_6;

		// Token: 0x04012CF0 RID: 77040
		internal static int __PropertyOffset_7;

		// Token: 0x04012CF1 RID: 77041
		internal static int __PropertyOffset_8;

		// Token: 0x04012CF2 RID: 77042
		internal static int __PropertyOffset_9;

		// Token: 0x04012CF3 RID: 77043
		private TArray<FVector> _PointArray;

		// Token: 0x04012CF4 RID: 77044
		internal static int __PropertyOffset_10;

		// Token: 0x04012CF5 RID: 77045
		private TArray<int> _Triangles;

		// Token: 0x04012CF6 RID: 77046
		internal static int __PropertyOffset_11;

		// Token: 0x04012CF7 RID: 77047
		private TArray<FVector> _NormalArray;

		// Token: 0x04012CF8 RID: 77048
		internal static int __PropertyOffset_12;

		// Token: 0x04012CF9 RID: 77049
		private TArray<FVector2D> _UV;

		// Token: 0x04012CFA RID: 77050
		internal static int __PropertyOffset_13;

		// Token: 0x04012CFB RID: 77051
		internal static int __PropertyOffset_14;

		// Token: 0x04012CFC RID: 77052
		internal static int __PropertyOffset_15;

		// Token: 0x04012CFD RID: 77053
		internal static int __PropertyOffset_16;

		// Token: 0x04012CFE RID: 77054
		internal static int __PropertyOffset_17;

		// Token: 0x04012CFF RID: 77055
		internal static int __PropertyOffset_18;

		// Token: 0x04012D00 RID: 77056
		internal static int __PropertyOffset_19;

		// Token: 0x04012D01 RID: 77057
		internal static int __PropertyOffset_20;

		// Token: 0x04012D02 RID: 77058
		internal static int __PropertyOffset_21;

		// Token: 0x04012D03 RID: 77059
		internal static int __PropertyOffset_22;

		// Token: 0x04012D04 RID: 77060
		internal static int __PropertyOffset_23;

		// Token: 0x04012D05 RID: 77061
		internal static int __PropertyOffset_24;

		// Token: 0x04012D06 RID: 77062
		internal static int __PropertyOffset_25;

		// Token: 0x04012D07 RID: 77063
		internal static int __PropertyOffset_26;

		// Token: 0x04012D08 RID: 77064
		private static IntPtr __UpdatePerFourFrame_NativeFunctionPtr;

		// Token: 0x04012D09 RID: 77065
		private static IntPtr __CalculateCharacterSpace_NativeFunctionPtr;

		// Token: 0x04012D0A RID: 77066
		private static IntPtr __Calculate_Character_Speed_NativeFunctionPtr;

		// Token: 0x04012D0B RID: 77067
		private static IntPtr __CalculateUVs_NativeFunctionPtr;

		// Token: 0x04012D0C RID: 77068
		private static IntPtr __CalculateNormals_NativeFunctionPtr;

		// Token: 0x04012D0D RID: 77069
		private static IntPtr __Calculate_Triangles_NativeFunctionPtr;

		// Token: 0x04012D0E RID: 77070
		private static IntPtr __GetCurvePoints_NativeFunctionPtr;

		// Token: 0x04012D0F RID: 77071
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012D10 RID: 77072
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012D11 RID: 77073
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A01F RID: 40991
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031AC8 RID: 203464
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A020 RID: 40992
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031AC9 RID: 203465
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
