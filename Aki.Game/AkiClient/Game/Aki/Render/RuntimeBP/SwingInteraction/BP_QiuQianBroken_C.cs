using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SwingInteraction
{
	// Token: 0x02003ABF RID: 15039
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQianBroken.BP_QiuQianBroken_C")]
	[UnrealStructLayout(1752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1748)]
	public class BP_QiuQianBroken_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020499 RID: 132249 RVA: 0x008CEB9A File Offset: 0x008CCD9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QiuQianBroken_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQianBroken.BP_QiuQianBroken_C");
			}
			return BP_QiuQianBroken_C._ClassPtr;
		}

		// Token: 0x0602049A RID: 132250 RVA: 0x008CEBC0 File Offset: 0x008CCDC0
		public BP_QiuQianBroken_C() : this(BuiltinUtils.AllocNativeUObject(BP_QiuQianBroken_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602049B RID: 132251 RVA: 0x008CEBE8 File Offset: 0x008CCDE8
		[NullableContext(1)]
		public BP_QiuQianBroken_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QiuQianBroken_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0602049C RID: 132252 RVA: 0x008CEC1B File Offset: 0x008CCE1B
		// (set) Token: 0x0602049D RID: 132253 RVA: 0x008CEC2F File Offset: 0x008CCE2F
		public unsafe UStaticMeshComponent SM_SwingSingleRopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0602049E RID: 132254 RVA: 0x008CEC44 File Offset: 0x008CCE44
		// (set) Token: 0x0602049F RID: 132255 RVA: 0x008CEC58 File Offset: 0x008CCE58
		public unsafe UStaticMeshComponent SM_SwingSingleRopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x060204A0 RID: 132256 RVA: 0x008CEC6D File Offset: 0x008CCE6D
		// (set) Token: 0x060204A1 RID: 132257 RVA: 0x008CEC81 File Offset: 0x008CCE81
		public unsafe UStaticMeshComponent SM_SwingTop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x060204A2 RID: 132258 RVA: 0x008CEC96 File Offset: 0x008CCE96
		// (set) Token: 0x060204A3 RID: 132259 RVA: 0x008CECAA File Offset: 0x008CCEAA
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x060204A4 RID: 132260 RVA: 0x008CECBF File Offset: 0x008CCEBF
		// (set) Token: 0x060204A5 RID: 132261 RVA: 0x008CECD3 File Offset: 0x008CCED3
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x060204A6 RID: 132262 RVA: 0x008CECE8 File Offset: 0x008CCEE8
		// (set) Token: 0x060204A7 RID: 132263 RVA: 0x008CECF8 File Offset: 0x008CCEF8
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x060204A8 RID: 132264 RVA: 0x008CED09 File Offset: 0x008CCF09
		// (set) Token: 0x060204A9 RID: 132265 RVA: 0x008CED19 File Offset: 0x008CCF19
		public unsafe bool bUseConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x060204AA RID: 132266 RVA: 0x008CED2A File Offset: 0x008CCF2A
		// (set) Token: 0x060204AB RID: 132267 RVA: 0x008CED3A File Offset: 0x008CCF3A
		public unsafe float ConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x060204AC RID: 132268 RVA: 0x008CED4B File Offset: 0x008CCF4B
		// (set) Token: 0x060204AD RID: 132269 RVA: 0x008CED5B File Offset: 0x008CCF5B
		public unsafe float GroundHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x060204AE RID: 132270 RVA: 0x008CED6C File Offset: 0x008CCF6C
		// (set) Token: 0x060204AF RID: 132271 RVA: 0x008CED80 File Offset: 0x008CCF80
		public unsafe FVector LeftPosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x060204B0 RID: 132272 RVA: 0x008CED95 File Offset: 0x008CCF95
		// (set) Token: 0x060204B1 RID: 132273 RVA: 0x008CEDA9 File Offset: 0x008CCFA9
		public unsafe FVector StartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x060204B2 RID: 132274 RVA: 0x008CEDBE File Offset: 0x008CCFBE
		// (set) Token: 0x060204B3 RID: 132275 RVA: 0x008CEDD2 File Offset: 0x008CCFD2
		public unsafe FVector RuntimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x060204B4 RID: 132276 RVA: 0x008CEDE7 File Offset: 0x008CCFE7
		// (set) Token: 0x060204B5 RID: 132277 RVA: 0x008CEDF7 File Offset: 0x008CCFF7
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x060204B6 RID: 132278 RVA: 0x008CEE08 File Offset: 0x008CD008
		// (set) Token: 0x060204B7 RID: 132279 RVA: 0x008CEE18 File Offset: 0x008CD018
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x060204B8 RID: 132280 RVA: 0x008CEE29 File Offset: 0x008CD029
		// (set) Token: 0x060204B9 RID: 132281 RVA: 0x008CEE3D File Offset: 0x008CD03D
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x060204BA RID: 132282 RVA: 0x008CEE52 File Offset: 0x008CD052
		// (set) Token: 0x060204BB RID: 132283 RVA: 0x008CEE62 File Offset: 0x008CD062
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x060204BC RID: 132284 RVA: 0x008CEE73 File Offset: 0x008CD073
		// (set) Token: 0x060204BD RID: 132285 RVA: 0x008CEE83 File Offset: 0x008CD083
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x060204BE RID: 132286 RVA: 0x008CEE94 File Offset: 0x008CD094
		// (set) Token: 0x060204BF RID: 132287 RVA: 0x008CEEA8 File Offset: 0x008CD0A8
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x060204C0 RID: 132288 RVA: 0x008CEEBD File Offset: 0x008CD0BD
		// (set) Token: 0x060204C1 RID: 132289 RVA: 0x008CEED1 File Offset: 0x008CD0D1
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x060204C2 RID: 132290 RVA: 0x008CEEE8 File Offset: 0x008CD0E8
		// (set) Token: 0x060204C3 RID: 132291 RVA: 0x008CEF21 File Offset: 0x008CD121
		[Nullable(1)]
		public TArray<FName> NameList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NameList) == null)
				{
					result = (this._NameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NameList.CopyAssign(value);
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x060204C4 RID: 132292 RVA: 0x008CEF2F File Offset: 0x008CD12F
		// (set) Token: 0x060204C5 RID: 132293 RVA: 0x008CEF43 File Offset: 0x008CD143
		public unsafe FVector leftPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x060204C6 RID: 132294 RVA: 0x008CEF58 File Offset: 0x008CD158
		// (set) Token: 0x060204C7 RID: 132295 RVA: 0x008CEF6C File Offset: 0x008CD16C
		public unsafe FVector rightPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x060204C8 RID: 132296 RVA: 0x008CEF81 File Offset: 0x008CD181
		// (set) Token: 0x060204C9 RID: 132297 RVA: 0x008CEF95 File Offset: 0x008CD195
		public unsafe FVector leftNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x060204CA RID: 132298 RVA: 0x008CEFAC File Offset: 0x008CD1AC
		// (set) Token: 0x060204CB RID: 132299 RVA: 0x008CEFE5 File Offset: 0x008CD1E5
		[Nullable(1)]
		public TArray<FParticle_QiuQian> particleArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FParticle_QiuQian> result;
				if ((result = this._particleArr) == null)
				{
					result = (this._particleArr = new TArray<FParticle_QiuQian>(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_24, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.particleArr.CopyAssign(value);
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x060204CC RID: 132300 RVA: 0x008CEFF3 File Offset: 0x008CD1F3
		// (set) Token: 0x060204CD RID: 132301 RVA: 0x008CF007 File Offset: 0x008CD207
		public unsafe FVector rightNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x060204CE RID: 132302 RVA: 0x008CF01C File Offset: 0x008CD21C
		// (set) Token: 0x060204CF RID: 132303 RVA: 0x008CF02C File Offset: 0x008CD22C
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x060204D0 RID: 132304 RVA: 0x008CF03D File Offset: 0x008CD23D
		// (set) Token: 0x060204D1 RID: 132305 RVA: 0x008CF04D File Offset: 0x008CD24D
		public unsafe float endParticleMassScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x060204D2 RID: 132306 RVA: 0x008CF05E File Offset: 0x008CD25E
		// (set) Token: 0x060204D3 RID: 132307 RVA: 0x008CF06E File Offset: 0x008CD26E
		public unsafe float debugDrawDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x060204D4 RID: 132308 RVA: 0x008CF080 File Offset: 0x008CD280
		// (set) Token: 0x060204D5 RID: 132309 RVA: 0x008CF0B9 File Offset: 0x008CD2B9
		[Nullable(1)]
		public TArray<USplineMeshComponent> SplineMesh
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USplineMeshComponent> result;
				if ((result = this._SplineMesh) == null)
				{
					result = (this._SplineMesh = new TArray<USplineMeshComponent>(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_29, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SplineMesh.CopyAssign(value);
			}
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x060204D6 RID: 132310 RVA: 0x008CF0C8 File Offset: 0x008CD2C8
		// (set) Token: 0x060204D7 RID: 132311 RVA: 0x008CF101 File Offset: 0x008CD301
		[Nullable(1)]
		public TArray<USplineMeshComponent> SplineMeshR
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USplineMeshComponent> result;
				if ((result = this._SplineMeshR) == null)
				{
					result = (this._SplineMeshR = new TArray<USplineMeshComponent>(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_30, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SplineMeshR.CopyAssign(value);
			}
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x060204D8 RID: 132312 RVA: 0x008CF10F File Offset: 0x008CD30F
		// (set) Token: 0x060204D9 RID: 132313 RVA: 0x008CF11F File Offset: 0x008CD31F
		public unsafe bool IsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x060204DA RID: 132314 RVA: 0x008CF130 File Offset: 0x008CD330
		// (set) Token: 0x060204DB RID: 132315 RVA: 0x008CF140 File Offset: 0x008CD340
		public unsafe bool IsPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x060204DC RID: 132316 RVA: 0x008CF151 File Offset: 0x008CD351
		// (set) Token: 0x060204DD RID: 132317 RVA: 0x008CF165 File Offset: 0x008CD365
		public unsafe UMaterialInstanceDynamic DMI_RopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x060204DE RID: 132318 RVA: 0x008CF17A File Offset: 0x008CD37A
		// (set) Token: 0x060204DF RID: 132319 RVA: 0x008CF18E File Offset: 0x008CD38E
		public unsafe UMaterialInstanceDynamic DMI_RopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQianBroken_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x060204E0 RID: 132320 RVA: 0x008CF1A3 File Offset: 0x008CD3A3
		// (set) Token: 0x060204E1 RID: 132321 RVA: 0x008CF1B3 File Offset: 0x008CD3B3
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQianBroken_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x060204E2 RID: 132322 RVA: 0x008CF1C4 File Offset: 0x008CD3C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeParticleArr()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__InitializeParticleArr_NativeFunctionPtr, null);
		}

		// Token: 0x060204E3 RID: 132323 RVA: 0x008CF1D8 File Offset: 0x008CD3D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDMIOffsetEnable(bool OffsetEnable)
		{
			BP_QiuQianBroken_C.__SetDMIOffsetEnable_FunctionParams* ptr = stackalloc BP_QiuQianBroken_C.__SetDMIOffsetEnable_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_QiuQianBroken_C.__SetDMIOffsetEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQianBroken_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OffsetEnable = OffsetEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060204E4 RID: 132324 RVA: 0x008CF21E File Offset: 0x008CD41E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateaDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__UpdateaDMI_NativeFunctionPtr, null);
		}

		// Token: 0x060204E5 RID: 132325 RVA: 0x008CF232 File Offset: 0x008CD432
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__InitializeDMI_NativeFunctionPtr, null);
		}

		// Token: 0x060204E6 RID: 132326 RVA: 0x008CF248 File Offset: 0x008CD448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_QiuQianBroken_C.__solve_FunctionParams* ptr = stackalloc BP_QiuQianBroken_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_QiuQianBroken_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQianBroken_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x060204E7 RID: 132327 RVA: 0x008CF2C9 File Offset: 0x008CD4C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060204E8 RID: 132328 RVA: 0x008CF2DD File Offset: 0x008CD4DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQianBroken_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060204E9 RID: 132329 RVA: 0x008CF2F2 File Offset: 0x008CD4F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void place_plank_event()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__place_plank_event_NativeFunctionPtr, null);
		}

		// Token: 0x060204EA RID: 132330 RVA: 0x008CF308 File Offset: 0x008CD508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_QiuQianBroken_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QiuQianBroken_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QiuQianBroken_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQianBroken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060204EB RID: 132331 RVA: 0x008CF350 File Offset: 0x008CD550
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_QiuQianBroken_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QiuQianBroken_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QiuQianBroken_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQianBroken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQianBroken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060204EC RID: 132332 RVA: 0x008CF397 File Offset: 0x008CD597
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060204ED RID: 132333 RVA: 0x008CF3AB File Offset: 0x008CD5AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQianBroken_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060204EE RID: 132334 RVA: 0x008CF3C0 File Offset: 0x008CD5C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x060204EF RID: 132335 RVA: 0x008CF3D4 File Offset: 0x008CD5D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQianBroken_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060204F0 RID: 132336 RVA: 0x008CF3E9 File Offset: 0x008CD5E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQianBroken_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x060204F1 RID: 132337 RVA: 0x008CF3FD File Offset: 0x008CD5FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQianBroken_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060204F2 RID: 132338 RVA: 0x008CF412 File Offset: 0x008CD612
		protected BP_QiuQianBroken_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9D9 RID: 63961
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQianBroken.BP_QiuQianBroken_C";

		// Token: 0x0400F9DA RID: 63962
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9DB RID: 63963
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9DC RID: 63964
		internal static int __PropertyOffset_1;

		// Token: 0x0400F9DD RID: 63965
		internal static int __PropertyOffset_2;

		// Token: 0x0400F9DE RID: 63966
		internal static int __PropertyOffset_3;

		// Token: 0x0400F9DF RID: 63967
		internal static int __PropertyOffset_4;

		// Token: 0x0400F9E0 RID: 63968
		internal static int __PropertyOffset_5;

		// Token: 0x0400F9E1 RID: 63969
		internal static int __PropertyOffset_6;

		// Token: 0x0400F9E2 RID: 63970
		internal static int __PropertyOffset_7;

		// Token: 0x0400F9E3 RID: 63971
		internal static int __PropertyOffset_8;

		// Token: 0x0400F9E4 RID: 63972
		internal static int __PropertyOffset_9;

		// Token: 0x0400F9E5 RID: 63973
		internal static int __PropertyOffset_10;

		// Token: 0x0400F9E6 RID: 63974
		internal static int __PropertyOffset_11;

		// Token: 0x0400F9E7 RID: 63975
		internal static int __PropertyOffset_12;

		// Token: 0x0400F9E8 RID: 63976
		internal static int __PropertyOffset_13;

		// Token: 0x0400F9E9 RID: 63977
		internal static int __PropertyOffset_14;

		// Token: 0x0400F9EA RID: 63978
		internal static int __PropertyOffset_15;

		// Token: 0x0400F9EB RID: 63979
		internal static int __PropertyOffset_16;

		// Token: 0x0400F9EC RID: 63980
		internal static int __PropertyOffset_17;

		// Token: 0x0400F9ED RID: 63981
		internal static int __PropertyOffset_18;

		// Token: 0x0400F9EE RID: 63982
		internal static int __PropertyOffset_19;

		// Token: 0x0400F9EF RID: 63983
		internal static int __PropertyOffset_20;

		// Token: 0x0400F9F0 RID: 63984
		private TArray<FName> _NameList;

		// Token: 0x0400F9F1 RID: 63985
		internal static int __PropertyOffset_21;

		// Token: 0x0400F9F2 RID: 63986
		internal static int __PropertyOffset_22;

		// Token: 0x0400F9F3 RID: 63987
		internal static int __PropertyOffset_23;

		// Token: 0x0400F9F4 RID: 63988
		internal static int __PropertyOffset_24;

		// Token: 0x0400F9F5 RID: 63989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticle_QiuQian> _particleArr;

		// Token: 0x0400F9F6 RID: 63990
		internal static int __PropertyOffset_25;

		// Token: 0x0400F9F7 RID: 63991
		internal static int __PropertyOffset_26;

		// Token: 0x0400F9F8 RID: 63992
		internal static int __PropertyOffset_27;

		// Token: 0x0400F9F9 RID: 63993
		internal static int __PropertyOffset_28;

		// Token: 0x0400F9FA RID: 63994
		internal static int __PropertyOffset_29;

		// Token: 0x0400F9FB RID: 63995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineMeshComponent> _SplineMesh;

		// Token: 0x0400F9FC RID: 63996
		internal static int __PropertyOffset_30;

		// Token: 0x0400F9FD RID: 63997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineMeshComponent> _SplineMeshR;

		// Token: 0x0400F9FE RID: 63998
		internal static int __PropertyOffset_31;

		// Token: 0x0400F9FF RID: 63999
		internal static int __PropertyOffset_32;

		// Token: 0x0400FA00 RID: 64000
		internal static int __PropertyOffset_33;

		// Token: 0x0400FA01 RID: 64001
		internal static int __PropertyOffset_34;

		// Token: 0x0400FA02 RID: 64002
		internal static int __PropertyOffset_35;

		// Token: 0x0400FA03 RID: 64003
		private static IntPtr __InitializeParticleArr_NativeFunctionPtr;

		// Token: 0x0400FA04 RID: 64004
		private static IntPtr __SetDMIOffsetEnable_NativeFunctionPtr;

		// Token: 0x0400FA05 RID: 64005
		private static IntPtr __UpdateaDMI_NativeFunctionPtr;

		// Token: 0x0400FA06 RID: 64006
		private static IntPtr __InitializeDMI_NativeFunctionPtr;

		// Token: 0x0400FA07 RID: 64007
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x0400FA08 RID: 64008
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FA09 RID: 64009
		private static IntPtr __place_plank_event_NativeFunctionPtr;

		// Token: 0x0400FA0A RID: 64010
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FA0B RID: 64011
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FA0C RID: 64012
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400FA0D RID: 64013
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009B9F RID: 39839
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __SetDMIOffsetEnable_FunctionParams
		{
			// Token: 0x040311F8 RID: 201208
			[FieldOffset(0)]
			public bool OffsetEnable;
		}

		// Token: 0x02009BA0 RID: 39840
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x040311F9 RID: 201209
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x040311FA RID: 201210
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x040311FB RID: 201211
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x040311FC RID: 201212
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x040311FD RID: 201213
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x040311FE RID: 201214
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02009BA1 RID: 39841
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311FF RID: 201215
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
