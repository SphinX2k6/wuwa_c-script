using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SwingInteraction
{
	// Token: 0x020030A9 RID: 12457
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian.BP_QiuQian_C")]
	[UnrealStructLayout(1720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1716)]
	public class BP_QiuQian_C : BP_PhysicsActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD6D RID: 122221 RVA: 0x009038E7 File Offset: 0x00901AE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QiuQian_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian.BP_QiuQian_C");
			}
			return BP_QiuQian_C._ClassPtr;
		}

		// Token: 0x0601DD6E RID: 122222 RVA: 0x0090390C File Offset: 0x00901B0C
		public BP_QiuQian_C() : this(BuiltinUtils.AllocNativeUObject(BP_QiuQian_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD6F RID: 122223 RVA: 0x00903934 File Offset: 0x00901B34
		[NullableContext(1)]
		public BP_QiuQian_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QiuQian_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0601DD70 RID: 122224 RVA: 0x00903967 File Offset: 0x00901B67
		// (set) Token: 0x0601DD71 RID: 122225 RVA: 0x0090397B File Offset: 0x00901B7B
		public unsafe UStaticMeshComponent SM_SwingSingleRopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_SM_SwingSingleRopeR);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_SM_SwingSingleRopeR, value);
			}
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0601DD72 RID: 122226 RVA: 0x00903990 File Offset: 0x00901B90
		// (set) Token: 0x0601DD73 RID: 122227 RVA: 0x009039A4 File Offset: 0x00901BA4
		public unsafe UStaticMeshComponent SM_SwingSingleRopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_SM_SwingSingleRopeL);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_SM_SwingSingleRopeL, value);
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0601DD74 RID: 122228 RVA: 0x009039B9 File Offset: 0x00901BB9
		// (set) Token: 0x0601DD75 RID: 122229 RVA: 0x009039CD File Offset: 0x00901BCD
		public unsafe UStaticMeshComponent SM_SwingTop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_SM_SwingTop);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_SM_SwingTop, value);
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0601DD76 RID: 122230 RVA: 0x009039E2 File Offset: 0x00901BE2
		// (set) Token: 0x0601DD77 RID: 122231 RVA: 0x009039F6 File Offset: 0x00901BF6
		public unsafe UStaticMeshComponent StaticMesh_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_StaticMesh_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_StaticMesh_0, value);
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0601DD78 RID: 122232 RVA: 0x00903A0C File Offset: 0x00901C0C
		// (set) Token: 0x0601DD79 RID: 122233 RVA: 0x00903A45 File Offset: 0x00901C45
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
					result = (this._NameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_NameList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NameList.CopyAssign(value);
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0601DD7A RID: 122234 RVA: 0x00903A53 File Offset: 0x00901C53
		// (set) Token: 0x0601DD7B RID: 122235 RVA: 0x00903A63 File Offset: 0x00901C63
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_debugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_debugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0601DD7C RID: 122236 RVA: 0x00903A74 File Offset: 0x00901C74
		// (set) Token: 0x0601DD7D RID: 122237 RVA: 0x00903A84 File Offset: 0x00901C84
		public unsafe bool bUseConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_bUseConstantDt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_bUseConstantDt) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0601DD7E RID: 122238 RVA: 0x00903A95 File Offset: 0x00901C95
		// (set) Token: 0x0601DD7F RID: 122239 RVA: 0x00903AA5 File Offset: 0x00901CA5
		public unsafe float ConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_ConstantDt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_ConstantDt) = value;
			}
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0601DD80 RID: 122240 RVA: 0x00903AB6 File Offset: 0x00901CB6
		// (set) Token: 0x0601DD81 RID: 122241 RVA: 0x00903ACA File Offset: 0x00901CCA
		public unsafe FVector StartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_StartOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_StartOffset) = value;
			}
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0601DD82 RID: 122242 RVA: 0x00903ADF File Offset: 0x00901CDF
		// (set) Token: 0x0601DD83 RID: 122243 RVA: 0x00903AEF File Offset: 0x00901CEF
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_particleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_particleCount) = value;
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0601DD84 RID: 122244 RVA: 0x00903B00 File Offset: 0x00901D00
		// (set) Token: 0x0601DD85 RID: 122245 RVA: 0x00903B10 File Offset: 0x00901D10
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_linkDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_linkDis) = value;
			}
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0601DD86 RID: 122246 RVA: 0x00903B21 File Offset: 0x00901D21
		// (set) Token: 0x0601DD87 RID: 122247 RVA: 0x00903B35 File Offset: 0x00901D35
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_accel_ext);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_accel_ext) = value;
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x0601DD88 RID: 122248 RVA: 0x00903B4A File Offset: 0x00901D4A
		// (set) Token: 0x0601DD89 RID: 122249 RVA: 0x00903B5A File Offset: 0x00901D5A
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x0601DD8A RID: 122250 RVA: 0x00903B6B File Offset: 0x00901D6B
		// (set) Token: 0x0601DD8B RID: 122251 RVA: 0x00903B7B File Offset: 0x00901D7B
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_volDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_volDamping) = value;
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x0601DD8C RID: 122252 RVA: 0x00903B8C File Offset: 0x00901D8C
		// (set) Token: 0x0601DD8D RID: 122253 RVA: 0x00903BA0 File Offset: 0x00901DA0
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_startPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_startPos) = value;
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x0601DD8E RID: 122254 RVA: 0x00903BB5 File Offset: 0x00901DB5
		// (set) Token: 0x0601DD8F RID: 122255 RVA: 0x00903BC9 File Offset: 0x00901DC9
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_endPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_endPos) = value;
			}
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x0601DD90 RID: 122256 RVA: 0x00903BDE File Offset: 0x00901DDE
		// (set) Token: 0x0601DD91 RID: 122257 RVA: 0x00903BF2 File Offset: 0x00901DF2
		public unsafe FVector leftPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_leftPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_leftPos) = value;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x0601DD92 RID: 122258 RVA: 0x00903C07 File Offset: 0x00901E07
		// (set) Token: 0x0601DD93 RID: 122259 RVA: 0x00903C1B File Offset: 0x00901E1B
		public unsafe FVector rightPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_rightPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_rightPos) = value;
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x0601DD94 RID: 122260 RVA: 0x00903C30 File Offset: 0x00901E30
		// (set) Token: 0x0601DD95 RID: 122261 RVA: 0x00903C44 File Offset: 0x00901E44
		public unsafe FVector leftNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_leftNorm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_leftNorm) = value;
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x0601DD96 RID: 122262 RVA: 0x00903C59 File Offset: 0x00901E59
		// (set) Token: 0x0601DD97 RID: 122263 RVA: 0x00903C6D File Offset: 0x00901E6D
		public unsafe FVector rightNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_rightNorm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_rightNorm) = value;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x0601DD98 RID: 122264 RVA: 0x00903C82 File Offset: 0x00901E82
		// (set) Token: 0x0601DD99 RID: 122265 RVA: 0x00903C92 File Offset: 0x00901E92
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_pushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_pushStrength) = value;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0601DD9A RID: 122266 RVA: 0x00903CA3 File Offset: 0x00901EA3
		// (set) Token: 0x0601DD9B RID: 122267 RVA: 0x00903CB3 File Offset: 0x00901EB3
		public unsafe float endParticleMassScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_endParticleMassScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_endParticleMassScale) = value;
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x0601DD9C RID: 122268 RVA: 0x00903CC4 File Offset: 0x00901EC4
		// (set) Token: 0x0601DD9D RID: 122269 RVA: 0x00903CD4 File Offset: 0x00901ED4
		public unsafe float debugDrawDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_debugDrawDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_debugDrawDuration) = value;
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0601DD9E RID: 122270 RVA: 0x00903CE5 File Offset: 0x00901EE5
		// (set) Token: 0x0601DD9F RID: 122271 RVA: 0x00903CF5 File Offset: 0x00901EF5
		public unsafe bool IsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_IsEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_IsEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0601DDA0 RID: 122272 RVA: 0x00903D06 File Offset: 0x00901F06
		// (set) Token: 0x0601DDA1 RID: 122273 RVA: 0x00903D16 File Offset: 0x00901F16
		public unsafe bool IsPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_IsPC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_IsPC) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0601DDA2 RID: 122274 RVA: 0x00903D27 File Offset: 0x00901F27
		// (set) Token: 0x0601DDA3 RID: 122275 RVA: 0x00903D3B File Offset: 0x00901F3B
		public unsafe UMaterialInstanceDynamic DMI_RopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_DMI_RopeL);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_DMI_RopeL, value);
			}
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x0601DDA4 RID: 122276 RVA: 0x00903D50 File Offset: 0x00901F50
		// (set) Token: 0x0601DDA5 RID: 122277 RVA: 0x00903D64 File Offset: 0x00901F64
		public unsafe UMaterialInstanceDynamic DMI_RopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_DMI_RopeR);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_DMI_RopeR, value);
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x0601DDA6 RID: 122278 RVA: 0x00903D79 File Offset: 0x00901F79
		// (set) Token: 0x0601DDA7 RID: 122279 RVA: 0x00903D89 File Offset: 0x00901F89
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x0601DDA8 RID: 122280 RVA: 0x00903D9A File Offset: 0x00901F9A
		// (set) Token: 0x0601DDA9 RID: 122281 RVA: 0x00903DAA File Offset: 0x00901FAA
		public unsafe bool IsWarm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_IsWarm) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_IsWarm) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x0601DDAA RID: 122282 RVA: 0x00903DBB File Offset: 0x00901FBB
		// (set) Token: 0x0601DDAB RID: 122283 RVA: 0x00903DCB File Offset: 0x00901FCB
		public unsafe float WarmTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_WarmTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_WarmTime) = value;
			}
		}

		// Token: 0x0601DDAC RID: 122284 RVA: 0x00903DDC File Offset: 0x00901FDC
		[SkipLocalsInit]
		public virtual void InitializeParticleArr()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__InitializeParticleArr_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDAD RID: 122285 RVA: 0x00903DF0 File Offset: 0x00901FF0
		[SkipLocalsInit]
		public unsafe virtual void SetDMIOffsetEnable(bool OffsetEnable)
		{
			BP_QiuQian_C.__SetDMIOffsetEnable_FunctionParams* ptr = stackalloc BP_QiuQian_C.__SetDMIOffsetEnable_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_QiuQian_C.__SetDMIOffsetEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OffsetEnable = OffsetEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DDAE RID: 122286 RVA: 0x00903E36 File Offset: 0x00902036
		[SkipLocalsInit]
		public virtual void UpdateaDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__UpdateaDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDAF RID: 122287 RVA: 0x00903E4A File Offset: 0x0090204A
		[SkipLocalsInit]
		public virtual void InitializeDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__InitializeDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDB0 RID: 122288 RVA: 0x00903E60 File Offset: 0x00902060
		[SkipLocalsInit]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_QiuQian_C.__solve_FunctionParams* ptr = stackalloc BP_QiuQian_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_QiuQian_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x0601DDB1 RID: 122289 RVA: 0x00903EE1 File Offset: 0x009020E1
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDB2 RID: 122290 RVA: 0x00903EF5 File Offset: 0x009020F5
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDB3 RID: 122291 RVA: 0x00903F09 File Offset: 0x00902109
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDB4 RID: 122292 RVA: 0x00903F1D File Offset: 0x0090211D
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDB5 RID: 122293 RVA: 0x00903F34 File Offset: 0x00902134
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_QiuQian_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QiuQian_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QiuQian_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DDB6 RID: 122294 RVA: 0x00903F7C File Offset: 0x0090217C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_QiuQian_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QiuQian_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QiuQian_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DDB7 RID: 122295 RVA: 0x00903FC2 File Offset: 0x009021C2
		[SkipLocalsInit]
		public virtual void place_plank_event()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__place_plank_event_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDB8 RID: 122296 RVA: 0x00903FD6 File Offset: 0x009021D6
		[SkipLocalsInit]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDB9 RID: 122297 RVA: 0x00903FEA File Offset: 0x009021EA
		[SkipLocalsInit]
		protected override void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDBA RID: 122298 RVA: 0x00903FFE File Offset: 0x009021FE
		[SkipLocalsInit]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDBB RID: 122299 RVA: 0x00904012 File Offset: 0x00902212
		[SkipLocalsInit]
		protected override void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x0601DDBC RID: 122300 RVA: 0x00904026 File Offset: 0x00902226
		protected BP_QiuQian_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBEB RID: 64491
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian.BP_QiuQian_C";

		// Token: 0x0400FBEC RID: 64492
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBED RID: 64493
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBEE RID: 64494
		internal static int __PropertyOffset_SM_SwingSingleRopeR;

		// Token: 0x0400FBEF RID: 64495
		internal static int __PropertyOffset_SM_SwingSingleRopeL;

		// Token: 0x0400FBF0 RID: 64496
		internal static int __PropertyOffset_SM_SwingTop;

		// Token: 0x0400FBF1 RID: 64497
		internal static int __PropertyOffset_StaticMesh_0;

		// Token: 0x0400FBF2 RID: 64498
		internal static int __PropertyOffset_NameList;

		// Token: 0x0400FBF3 RID: 64499
		private TArray<FName> _NameList;

		// Token: 0x0400FBF4 RID: 64500
		internal static int __PropertyOffset_debugDraw;

		// Token: 0x0400FBF5 RID: 64501
		internal static int __PropertyOffset_bUseConstantDt;

		// Token: 0x0400FBF6 RID: 64502
		internal static int __PropertyOffset_ConstantDt;

		// Token: 0x0400FBF7 RID: 64503
		internal static int __PropertyOffset_StartOffset;

		// Token: 0x0400FBF8 RID: 64504
		internal static int __PropertyOffset_particleCount;

		// Token: 0x0400FBF9 RID: 64505
		internal static int __PropertyOffset_linkDis;

		// Token: 0x0400FBFA RID: 64506
		internal static int __PropertyOffset_accel_ext;

		// Token: 0x0400FBFB RID: 64507
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400FBFC RID: 64508
		internal static int __PropertyOffset_volDamping;

		// Token: 0x0400FBFD RID: 64509
		internal static int __PropertyOffset_startPos;

		// Token: 0x0400FBFE RID: 64510
		internal static int __PropertyOffset_endPos;

		// Token: 0x0400FBFF RID: 64511
		internal static int __PropertyOffset_leftPos;

		// Token: 0x0400FC00 RID: 64512
		internal static int __PropertyOffset_rightPos;

		// Token: 0x0400FC01 RID: 64513
		internal static int __PropertyOffset_leftNorm;

		// Token: 0x0400FC02 RID: 64514
		internal static int __PropertyOffset_rightNorm;

		// Token: 0x0400FC03 RID: 64515
		internal static int __PropertyOffset_pushStrength;

		// Token: 0x0400FC04 RID: 64516
		internal static int __PropertyOffset_endParticleMassScale;

		// Token: 0x0400FC05 RID: 64517
		internal static int __PropertyOffset_debugDrawDuration;

		// Token: 0x0400FC06 RID: 64518
		internal static int __PropertyOffset_IsEnable;

		// Token: 0x0400FC07 RID: 64519
		internal static int __PropertyOffset_IsPC;

		// Token: 0x0400FC08 RID: 64520
		internal static int __PropertyOffset_DMI_RopeL;

		// Token: 0x0400FC09 RID: 64521
		internal static int __PropertyOffset_DMI_RopeR;

		// Token: 0x0400FC0A RID: 64522
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400FC0B RID: 64523
		internal static int __PropertyOffset_IsWarm;

		// Token: 0x0400FC0C RID: 64524
		internal static int __PropertyOffset_WarmTime;

		// Token: 0x0400FC0D RID: 64525
		private static IntPtr __InitializeParticleArr_NativeFunctionPtr;

		// Token: 0x0400FC0E RID: 64526
		private static IntPtr __SetDMIOffsetEnable_NativeFunctionPtr;

		// Token: 0x0400FC0F RID: 64527
		private static IntPtr __UpdateaDMI_NativeFunctionPtr;

		// Token: 0x0400FC10 RID: 64528
		private static IntPtr __InitializeDMI_NativeFunctionPtr;

		// Token: 0x0400FC11 RID: 64529
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x0400FC12 RID: 64530
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FC13 RID: 64531
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC14 RID: 64532
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FC15 RID: 64533
		private static IntPtr __place_plank_event_NativeFunctionPtr;

		// Token: 0x0400FC16 RID: 64534
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400FC17 RID: 64535
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02008DC2 RID: 36290
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __SetDMIOffsetEnable_FunctionParams
		{
			// Token: 0x0402C9BD RID: 182717
			[FieldOffset(0)]
			public bool OffsetEnable;
		}

		// Token: 0x02008DC3 RID: 36291
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x0402C9BE RID: 182718
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x0402C9BF RID: 182719
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x0402C9C0 RID: 182720
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x0402C9C1 RID: 182721
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x0402C9C2 RID: 182722
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x0402C9C3 RID: 182723
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02008DC4 RID: 36292
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C9C4 RID: 182724
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
