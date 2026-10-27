using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B01 RID: 15105
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_DispersionLightPostprocess.BP_DispersionLightPostprocess_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1496)]
	public class BP_DispersionLightPostprocess_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020CB6 RID: 134326 RVA: 0x008DD6EE File Offset: 0x008DB8EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DispersionLightPostprocess_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_DispersionLightPostprocess.BP_DispersionLightPostprocess_C");
			}
			return BP_DispersionLightPostprocess_C._ClassPtr;
		}

		// Token: 0x06020CB7 RID: 134327 RVA: 0x008DD714 File Offset: 0x008DB914
		public BP_DispersionLightPostprocess_C() : this(BuiltinUtils.AllocNativeUObject(BP_DispersionLightPostprocess_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020CB8 RID: 134328 RVA: 0x008DD73C File Offset: 0x008DB93C
		[NullableContext(1)]
		public BP_DispersionLightPostprocess_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DispersionLightPostprocess_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x06020CB9 RID: 134329 RVA: 0x008DD76F File Offset: 0x008DB96F
		// (set) Token: 0x06020CBA RID: 134330 RVA: 0x008DD783 File Offset: 0x008DB983
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x06020CBB RID: 134331 RVA: 0x008DD798 File Offset: 0x008DB998
		// (set) Token: 0x06020CBC RID: 134332 RVA: 0x008DD7AC File Offset: 0x008DB9AC
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x06020CBD RID: 134333 RVA: 0x008DD7C1 File Offset: 0x008DB9C1
		// (set) Token: 0x06020CBE RID: 134334 RVA: 0x008DD7D5 File Offset: 0x008DB9D5
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x06020CBF RID: 134335 RVA: 0x008DD7EA File Offset: 0x008DB9EA
		// (set) Token: 0x06020CC0 RID: 134336 RVA: 0x008DD7FE File Offset: 0x008DB9FE
		public unsafe UMaterialInterface MainMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x06020CC1 RID: 134337 RVA: 0x008DD813 File Offset: 0x008DBA13
		// (set) Token: 0x06020CC2 RID: 134338 RVA: 0x008DD827 File Offset: 0x008DBA27
		public unsafe UMaterialInterface AddMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x06020CC3 RID: 134339 RVA: 0x008DD83C File Offset: 0x008DBA3C
		// (set) Token: 0x06020CC4 RID: 134340 RVA: 0x008DD850 File Offset: 0x008DBA50
		public unsafe UMaterialInterface MultyMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x06020CC5 RID: 134341 RVA: 0x008DD865 File Offset: 0x008DBA65
		// (set) Token: 0x06020CC6 RID: 134342 RVA: 0x008DD879 File Offset: 0x008DBA79
		public unsafe UTexture BaseTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x06020CC7 RID: 134343 RVA: 0x008DD88E File Offset: 0x008DBA8E
		// (set) Token: 0x06020CC8 RID: 134344 RVA: 0x008DD8A2 File Offset: 0x008DBAA2
		public unsafe FLinearColor BaseTexRGBA_Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x06020CC9 RID: 134345 RVA: 0x008DD8B7 File Offset: 0x008DBAB7
		// (set) Token: 0x06020CCA RID: 134346 RVA: 0x008DD8CB File Offset: 0x008DBACB
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x06020CCB RID: 134347 RVA: 0x008DD8E0 File Offset: 0x008DBAE0
		// (set) Token: 0x06020CCC RID: 134348 RVA: 0x008DD8F4 File Offset: 0x008DBAF4
		public unsafe FLinearColor LightShadowColor_Multi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x06020CCD RID: 134349 RVA: 0x008DD909 File Offset: 0x008DBB09
		// (set) Token: 0x06020CCE RID: 134350 RVA: 0x008DD919 File Offset: 0x008DBB19
		public unsafe float LightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x06020CCF RID: 134351 RVA: 0x008DD92A File Offset: 0x008DBB2A
		// (set) Token: 0x06020CD0 RID: 134352 RVA: 0x008DD93A File Offset: 0x008DBB3A
		public unsafe float LightShadowIntensity_Multi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x06020CD1 RID: 134353 RVA: 0x008DD94B File Offset: 0x008DBB4B
		// (set) Token: 0x06020CD2 RID: 134354 RVA: 0x008DD95B File Offset: 0x008DBB5B
		public unsafe float ShadowProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x06020CD3 RID: 134355 RVA: 0x008DD96C File Offset: 0x008DBB6C
		// (set) Token: 0x06020CD4 RID: 134356 RVA: 0x008DD97C File Offset: 0x008DBB7C
		public unsafe float ShadowWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x06020CD5 RID: 134357 RVA: 0x008DD98D File Offset: 0x008DBB8D
		// (set) Token: 0x06020CD6 RID: 134358 RVA: 0x008DD99D File Offset: 0x008DBB9D
		public unsafe float InnerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x06020CD7 RID: 134359 RVA: 0x008DD9AE File Offset: 0x008DBBAE
		// (set) Token: 0x06020CD8 RID: 134360 RVA: 0x008DD9BE File Offset: 0x008DBBBE
		public unsafe float SecondOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x06020CD9 RID: 134361 RVA: 0x008DD9CF File Offset: 0x008DBBCF
		// (set) Token: 0x06020CDA RID: 134362 RVA: 0x008DD9DF File Offset: 0x008DBBDF
		public unsafe float ThirdOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x06020CDB RID: 134363 RVA: 0x008DD9F0 File Offset: 0x008DBBF0
		// (set) Token: 0x06020CDC RID: 134364 RVA: 0x008DDA00 File Offset: 0x008DBC00
		public unsafe float OffsetStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x06020CDD RID: 134365 RVA: 0x008DDA11 File Offset: 0x008DBC11
		// (set) Token: 0x06020CDE RID: 134366 RVA: 0x008DDA21 File Offset: 0x008DBC21
		public unsafe float U_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x06020CDF RID: 134367 RVA: 0x008DDA32 File Offset: 0x008DBC32
		// (set) Token: 0x06020CE0 RID: 134368 RVA: 0x008DDA42 File Offset: 0x008DBC42
		public unsafe float V_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x06020CE1 RID: 134369 RVA: 0x008DDA53 File Offset: 0x008DBC53
		// (set) Token: 0x06020CE2 RID: 134370 RVA: 0x008DDA63 File Offset: 0x008DBC63
		public unsafe float U_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x06020CE3 RID: 134371 RVA: 0x008DDA74 File Offset: 0x008DBC74
		// (set) Token: 0x06020CE4 RID: 134372 RVA: 0x008DDA84 File Offset: 0x008DBC84
		public unsafe float V_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x06020CE5 RID: 134373 RVA: 0x008DDA95 File Offset: 0x008DBC95
		// (set) Token: 0x06020CE6 RID: 134374 RVA: 0x008DDAA9 File Offset: 0x008DBCA9
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x06020CE7 RID: 134375 RVA: 0x008DDABE File Offset: 0x008DBCBE
		// (set) Token: 0x06020CE8 RID: 134376 RVA: 0x008DDACE File Offset: 0x008DBCCE
		public unsafe bool UseMultiBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x06020CE9 RID: 134377 RVA: 0x008DDAE0 File Offset: 0x008DBCE0
		// (set) Token: 0x06020CEA RID: 134378 RVA: 0x008DDB19 File Offset: 0x008DBD19
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_25, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x06020CEB RID: 134379 RVA: 0x008DDB28 File Offset: 0x008DBD28
		// (set) Token: 0x06020CEC RID: 134380 RVA: 0x008DDB61 File Offset: 0x008DBD61
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_26, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x06020CED RID: 134381 RVA: 0x008DDB70 File Offset: 0x008DBD70
		// (set) Token: 0x06020CEE RID: 134382 RVA: 0x008DDBA9 File Offset: 0x008DBDA9
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x06020CEF RID: 134383 RVA: 0x008DDBB7 File Offset: 0x008DBDB7
		// (set) Token: 0x06020CF0 RID: 134384 RVA: 0x008DDBC7 File Offset: 0x008DBDC7
		public unsafe float NoiseUSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x06020CF1 RID: 134385 RVA: 0x008DDBD8 File Offset: 0x008DBDD8
		// (set) Token: 0x06020CF2 RID: 134386 RVA: 0x008DDBE8 File Offset: 0x008DBDE8
		public unsafe float NoiseVSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x06020CF3 RID: 134387 RVA: 0x008DDBF9 File Offset: 0x008DBDF9
		// (set) Token: 0x06020CF4 RID: 134388 RVA: 0x008DDC09 File Offset: 0x008DBE09
		public unsafe float NoiseUVMulty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x06020CF5 RID: 134389 RVA: 0x008DDC1A File Offset: 0x008DBE1A
		// (set) Token: 0x06020CF6 RID: 134390 RVA: 0x008DDC2A File Offset: 0x008DBE2A
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x06020CF7 RID: 134391 RVA: 0x008DDC3B File Offset: 0x008DBE3B
		// (set) Token: 0x06020CF8 RID: 134392 RVA: 0x008DDC4F File Offset: 0x008DBE4F
		public unsafe UTexture NoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DispersionLightPostprocess_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x06020CF9 RID: 134393 RVA: 0x008DDC64 File Offset: 0x008DBE64
		// (set) Token: 0x06020CFA RID: 134394 RVA: 0x008DDC74 File Offset: 0x008DBE74
		public unsafe float Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x06020CFB RID: 134395 RVA: 0x008DDC85 File Offset: 0x008DBE85
		// (set) Token: 0x06020CFC RID: 134396 RVA: 0x008DDC95 File Offset: 0x008DBE95
		public unsafe float Desaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DispersionLightPostprocess_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x06020CFD RID: 134397 RVA: 0x008DDCA6 File Offset: 0x008DBEA6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06020CFE RID: 134398 RVA: 0x008DDCBA File Offset: 0x008DBEBA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__UpdateEditor_NativeFunctionPtr, null);
		}

		// Token: 0x06020CFF RID: 134399 RVA: 0x008DDCCE File Offset: 0x008DBECE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020D00 RID: 134400 RVA: 0x008DDCE2 File Offset: 0x008DBEE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020D01 RID: 134401 RVA: 0x008DDCF7 File Offset: 0x008DBEF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020D02 RID: 134402 RVA: 0x008DDD0B File Offset: 0x008DBF0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020D03 RID: 134403 RVA: 0x008DDD20 File Offset: 0x008DBF20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DispersionLightPostprocess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DispersionLightPostprocess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DispersionLightPostprocess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DispersionLightPostprocess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D04 RID: 134404 RVA: 0x008DDD68 File Offset: 0x008DBF68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DispersionLightPostprocess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DispersionLightPostprocess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DispersionLightPostprocess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DispersionLightPostprocess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020D05 RID: 134405 RVA: 0x008DDDAF File Offset: 0x008DBFAF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020D06 RID: 134406 RVA: 0x008DDDC3 File Offset: 0x008DBFC3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DispersionLightPostprocess_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020D07 RID: 134407 RVA: 0x008DDDD8 File Offset: 0x008DBFD8
		protected BP_DispersionLightPostprocess_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEE4 RID: 65252
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_DispersionLightPostprocess.BP_DispersionLightPostprocess_C";

		// Token: 0x0400FEE5 RID: 65253
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEE6 RID: 65254
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEE7 RID: 65255
		internal static int __PropertyOffset_1;

		// Token: 0x0400FEE8 RID: 65256
		internal static int __PropertyOffset_2;

		// Token: 0x0400FEE9 RID: 65257
		internal static int __PropertyOffset_3;

		// Token: 0x0400FEEA RID: 65258
		internal static int __PropertyOffset_4;

		// Token: 0x0400FEEB RID: 65259
		internal static int __PropertyOffset_5;

		// Token: 0x0400FEEC RID: 65260
		internal static int __PropertyOffset_6;

		// Token: 0x0400FEED RID: 65261
		internal static int __PropertyOffset_7;

		// Token: 0x0400FEEE RID: 65262
		internal static int __PropertyOffset_8;

		// Token: 0x0400FEEF RID: 65263
		internal static int __PropertyOffset_9;

		// Token: 0x0400FEF0 RID: 65264
		internal static int __PropertyOffset_10;

		// Token: 0x0400FEF1 RID: 65265
		internal static int __PropertyOffset_11;

		// Token: 0x0400FEF2 RID: 65266
		internal static int __PropertyOffset_12;

		// Token: 0x0400FEF3 RID: 65267
		internal static int __PropertyOffset_13;

		// Token: 0x0400FEF4 RID: 65268
		internal static int __PropertyOffset_14;

		// Token: 0x0400FEF5 RID: 65269
		internal static int __PropertyOffset_15;

		// Token: 0x0400FEF6 RID: 65270
		internal static int __PropertyOffset_16;

		// Token: 0x0400FEF7 RID: 65271
		internal static int __PropertyOffset_17;

		// Token: 0x0400FEF8 RID: 65272
		internal static int __PropertyOffset_18;

		// Token: 0x0400FEF9 RID: 65273
		internal static int __PropertyOffset_19;

		// Token: 0x0400FEFA RID: 65274
		internal static int __PropertyOffset_20;

		// Token: 0x0400FEFB RID: 65275
		internal static int __PropertyOffset_21;

		// Token: 0x0400FEFC RID: 65276
		internal static int __PropertyOffset_22;

		// Token: 0x0400FEFD RID: 65277
		internal static int __PropertyOffset_23;

		// Token: 0x0400FEFE RID: 65278
		internal static int __PropertyOffset_24;

		// Token: 0x0400FEFF RID: 65279
		internal static int __PropertyOffset_25;

		// Token: 0x0400FF00 RID: 65280
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0400FF01 RID: 65281
		internal static int __PropertyOffset_26;

		// Token: 0x0400FF02 RID: 65282
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0400FF03 RID: 65283
		internal static int __PropertyOffset_27;

		// Token: 0x0400FF04 RID: 65284
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0400FF05 RID: 65285
		internal static int __PropertyOffset_28;

		// Token: 0x0400FF06 RID: 65286
		internal static int __PropertyOffset_29;

		// Token: 0x0400FF07 RID: 65287
		internal static int __PropertyOffset_30;

		// Token: 0x0400FF08 RID: 65288
		internal static int __PropertyOffset_31;

		// Token: 0x0400FF09 RID: 65289
		internal static int __PropertyOffset_32;

		// Token: 0x0400FF0A RID: 65290
		internal static int __PropertyOffset_33;

		// Token: 0x0400FF0B RID: 65291
		internal static int __PropertyOffset_34;

		// Token: 0x0400FF0C RID: 65292
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x0400FF0D RID: 65293
		private static IntPtr __UpdateEditor_NativeFunctionPtr;

		// Token: 0x0400FF0E RID: 65294
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FF0F RID: 65295
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FF10 RID: 65296
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FF11 RID: 65297
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009C3D RID: 39997
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312ED RID: 201453
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
