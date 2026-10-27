using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CB8 RID: 15544
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth.BP_genCloth_C")]
	[UnrealStructLayout(1856, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1852)]
	public class BP_genCloth_C : AKuroCSGenericCloth, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024AB3 RID: 150195 RVA: 0x009456DC File Offset: 0x009438DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_genCloth_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth.BP_genCloth_C");
			}
			return BP_genCloth_C._ClassPtr;
		}

		// Token: 0x06024AB4 RID: 150196 RVA: 0x00945700 File Offset: 0x00943900
		public BP_genCloth_C() : this(BuiltinUtils.AllocNativeUObject(BP_genCloth_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024AB5 RID: 150197 RVA: 0x00945728 File Offset: 0x00943928
		[NullableContext(1)]
		public BP_genCloth_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_genCloth_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700485B RID: 18523
		// (get) Token: 0x06024AB6 RID: 150198 RVA: 0x0094575B File Offset: 0x0094395B
		// (set) Token: 0x06024AB7 RID: 150199 RVA: 0x0094576F File Offset: 0x0094396F
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700485C RID: 18524
		// (get) Token: 0x06024AB8 RID: 150200 RVA: 0x00945784 File Offset: 0x00943984
		// (set) Token: 0x06024AB9 RID: 150201 RVA: 0x00945798 File Offset: 0x00943998
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700485D RID: 18525
		// (get) Token: 0x06024ABA RID: 150202 RVA: 0x009457AD File Offset: 0x009439AD
		// (set) Token: 0x06024ABB RID: 150203 RVA: 0x009457C1 File Offset: 0x009439C1
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700485E RID: 18526
		// (get) Token: 0x06024ABC RID: 150204 RVA: 0x009457D6 File Offset: 0x009439D6
		// (set) Token: 0x06024ABD RID: 150205 RVA: 0x009457EA File Offset: 0x009439EA
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700485F RID: 18527
		// (get) Token: 0x06024ABE RID: 150206 RVA: 0x009457FF File Offset: 0x009439FF
		// (set) Token: 0x06024ABF RID: 150207 RVA: 0x00945813 File Offset: 0x00943A13
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004860 RID: 18528
		// (get) Token: 0x06024AC0 RID: 150208 RVA: 0x00945828 File Offset: 0x00943A28
		// (set) Token: 0x06024AC1 RID: 150209 RVA: 0x00945838 File Offset: 0x00943A38
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004861 RID: 18529
		// (get) Token: 0x06024AC2 RID: 150210 RVA: 0x00945849 File Offset: 0x00943A49
		// (set) Token: 0x06024AC3 RID: 150211 RVA: 0x0094585D File Offset: 0x00943A5D
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004862 RID: 18530
		// (get) Token: 0x06024AC4 RID: 150212 RVA: 0x00945872 File Offset: 0x00943A72
		// (set) Token: 0x06024AC5 RID: 150213 RVA: 0x00945882 File Offset: 0x00943A82
		public unsafe float force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004863 RID: 18531
		// (get) Token: 0x06024AC6 RID: 150214 RVA: 0x00945893 File Offset: 0x00943A93
		// (set) Token: 0x06024AC7 RID: 150215 RVA: 0x009458A3 File Offset: 0x00943AA3
		public unsafe bool Pressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004864 RID: 18532
		// (get) Token: 0x06024AC8 RID: 150216 RVA: 0x009458B4 File Offset: 0x00943AB4
		// (set) Token: 0x06024AC9 RID: 150217 RVA: 0x009458C4 File Offset: 0x00943AC4
		public unsafe bool FS_isPhysicSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004865 RID: 18533
		// (get) Token: 0x06024ACA RID: 150218 RVA: 0x009458D5 File Offset: 0x00943AD5
		// (set) Token: 0x06024ACB RID: 150219 RVA: 0x009458E5 File Offset: 0x00943AE5
		public unsafe float mass_in_kg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004866 RID: 18534
		// (get) Token: 0x06024ACC RID: 150220 RVA: 0x009458F6 File Offset: 0x00943AF6
		// (set) Token: 0x06024ACD RID: 150221 RVA: 0x00945906 File Offset: 0x00943B06
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004867 RID: 18535
		// (get) Token: 0x06024ACE RID: 150222 RVA: 0x00945917 File Offset: 0x00943B17
		// (set) Token: 0x06024ACF RID: 150223 RVA: 0x00945927 File Offset: 0x00943B27
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004868 RID: 18536
		// (get) Token: 0x06024AD0 RID: 150224 RVA: 0x00945938 File Offset: 0x00943B38
		// (set) Token: 0x06024AD1 RID: 150225 RVA: 0x00945948 File Offset: 0x00943B48
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004869 RID: 18537
		// (get) Token: 0x06024AD2 RID: 150226 RVA: 0x00945959 File Offset: 0x00943B59
		// (set) Token: 0x06024AD3 RID: 150227 RVA: 0x00945969 File Offset: 0x00943B69
		public unsafe bool ReadFromBPL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700486A RID: 18538
		// (get) Token: 0x06024AD4 RID: 150228 RVA: 0x0094597A File Offset: 0x00943B7A
		// (set) Token: 0x06024AD5 RID: 150229 RVA: 0x0094598A File Offset: 0x00943B8A
		public unsafe bool extraOneMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700486B RID: 18539
		// (get) Token: 0x06024AD6 RID: 150230 RVA: 0x0094599B File Offset: 0x00943B9B
		// (set) Token: 0x06024AD7 RID: 150231 RVA: 0x009459AF File Offset: 0x00943BAF
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x1700486C RID: 18540
		// (get) Token: 0x06024AD8 RID: 150232 RVA: 0x009459C4 File Offset: 0x00943BC4
		// (set) Token: 0x06024AD9 RID: 150233 RVA: 0x009459D8 File Offset: 0x00943BD8
		public unsafe UMaterialInstanceDynamic MID1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700486D RID: 18541
		// (get) Token: 0x06024ADA RID: 150234 RVA: 0x009459ED File Offset: 0x00943BED
		// (set) Token: 0x06024ADB RID: 150235 RVA: 0x009459FD File Offset: 0x00943BFD
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700486E RID: 18542
		// (get) Token: 0x06024ADC RID: 150236 RVA: 0x00945A0E File Offset: 0x00943C0E
		// (set) Token: 0x06024ADD RID: 150237 RVA: 0x00945A1E File Offset: 0x00943C1E
		public unsafe bool UseYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x06024ADE RID: 150238 RVA: 0x00945A2F File Offset: 0x00943C2F
		// (set) Token: 0x06024ADF RID: 150239 RVA: 0x00945A3F File Offset: 0x00943C3F
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x06024AE0 RID: 150240 RVA: 0x00945A50 File Offset: 0x00943C50
		// (set) Token: 0x06024AE1 RID: 150241 RVA: 0x00945A64 File Offset: 0x00943C64
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x06024AE2 RID: 150242 RVA: 0x00945A79 File Offset: 0x00943C79
		// (set) Token: 0x06024AE3 RID: 150243 RVA: 0x00945A8D File Offset: 0x00943C8D
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x06024AE4 RID: 150244 RVA: 0x00945AA2 File Offset: 0x00943CA2
		// (set) Token: 0x06024AE5 RID: 150245 RVA: 0x00945AB6 File Offset: 0x00943CB6
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x06024AE6 RID: 150246 RVA: 0x00945ACB File Offset: 0x00943CCB
		// (set) Token: 0x06024AE7 RID: 150247 RVA: 0x00945ADF File Offset: 0x00943CDF
		public unsafe FVector gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x06024AE8 RID: 150248 RVA: 0x00945AF4 File Offset: 0x00943CF4
		// (set) Token: 0x06024AE9 RID: 150249 RVA: 0x00945B04 File Offset: 0x00943D04
		public unsafe bool UseStaticCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x06024AEA RID: 150250 RVA: 0x00945B15 File Offset: 0x00943D15
		// (set) Token: 0x06024AEB RID: 150251 RVA: 0x00945B29 File Offset: 0x00943D29
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x06024AEC RID: 150252 RVA: 0x00945B40 File Offset: 0x00943D40
		// (set) Token: 0x06024AED RID: 150253 RVA: 0x00945B79 File Offset: 0x00943D79
		[Nullable(1)]
		public TArray<FKuroCSUnifiedCollider_genericCloth> ColArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_genericCloth> result;
				if ((result = this._ColArr) == null)
				{
					result = (this._ColArr = new TArray<FKuroCSUnifiedCollider_genericCloth>(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_28, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ColArr.CopyAssign(value);
			}
		}

		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x06024AEE RID: 150254 RVA: 0x00945B87 File Offset: 0x00943D87
		// (set) Token: 0x06024AEF RID: 150255 RVA: 0x00945B97 File Offset: 0x00943D97
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x06024AF0 RID: 150256 RVA: 0x00945BA8 File Offset: 0x00943DA8
		// (set) Token: 0x06024AF1 RID: 150257 RVA: 0x00945BB8 File Offset: 0x00943DB8
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x06024AF2 RID: 150258 RVA: 0x00945BC9 File Offset: 0x00943DC9
		// (set) Token: 0x06024AF3 RID: 150259 RVA: 0x00945BD9 File Offset: 0x00943DD9
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x06024AF4 RID: 150260 RVA: 0x00945BEA File Offset: 0x00943DEA
		// (set) Token: 0x06024AF5 RID: 150261 RVA: 0x00945BFA File Offset: 0x00943DFA
		public unsafe bool alreadyBuildArr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700487B RID: 18555
		// (get) Token: 0x06024AF6 RID: 150262 RVA: 0x00945C0B File Offset: 0x00943E0B
		// (set) Token: 0x06024AF7 RID: 150263 RVA: 0x00945C1B File Offset: 0x00943E1B
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700487C RID: 18556
		// (get) Token: 0x06024AF8 RID: 150264 RVA: 0x00945C2C File Offset: 0x00943E2C
		// (set) Token: 0x06024AF9 RID: 150265 RVA: 0x00945C3C File Offset: 0x00943E3C
		public unsafe bool PlatformCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024AFA RID: 150266 RVA: 0x00945C4D File Offset: 0x00943E4D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024AFB RID: 150267 RVA: 0x00945C61 File Offset: 0x00943E61
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024AFC RID: 150268 RVA: 0x00945C76 File Offset: 0x00943E76
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024AFD RID: 150269 RVA: 0x00945C8A File Offset: 0x00943E8A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024AFE RID: 150270 RVA: 0x00945CA0 File Offset: 0x00943EA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_genCloth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_genCloth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_genCloth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024AFF RID: 150271 RVA: 0x00945CE8 File Offset: 0x00943EE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_genCloth_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_genCloth_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_genCloth_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024B00 RID: 150272 RVA: 0x00945D30 File Offset: 0x00943F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_genCloth_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_genCloth_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_genCloth_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024B01 RID: 150273 RVA: 0x00945D7C File Offset: 0x00943F7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_genCloth_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_genCloth_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_genCloth_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024B02 RID: 150274 RVA: 0x00945DC8 File Offset: 0x00943FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			BP_genCloth_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_genCloth_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024B03 RID: 150275 RVA: 0x00945E7C File Offset: 0x0094407C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024B04 RID: 150276 RVA: 0x00945F38 File Offset: 0x00944138
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024B05 RID: 150277 RVA: 0x00945FC4 File Offset: 0x009441C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_genCloth_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_genCloth_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_genCloth_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024B06 RID: 150278 RVA: 0x00946027 File Offset: 0x00944227
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024B07 RID: 150279 RVA: 0x0094603B File Offset: 0x0094423B
		protected BP_genCloth_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012377 RID: 74615
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth.BP_genCloth_C";

		// Token: 0x04012378 RID: 74616
		private static IntPtr _ClassPtr;

		// Token: 0x04012379 RID: 74617
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401237A RID: 74618
		internal static int __PropertyOffset_1;

		// Token: 0x0401237B RID: 74619
		internal static int __PropertyOffset_2;

		// Token: 0x0401237C RID: 74620
		internal static int __PropertyOffset_3;

		// Token: 0x0401237D RID: 74621
		internal static int __PropertyOffset_4;

		// Token: 0x0401237E RID: 74622
		internal static int __PropertyOffset_5;

		// Token: 0x0401237F RID: 74623
		internal static int __PropertyOffset_6;

		// Token: 0x04012380 RID: 74624
		internal static int __PropertyOffset_7;

		// Token: 0x04012381 RID: 74625
		internal static int __PropertyOffset_8;

		// Token: 0x04012382 RID: 74626
		internal static int __PropertyOffset_9;

		// Token: 0x04012383 RID: 74627
		internal static int __PropertyOffset_10;

		// Token: 0x04012384 RID: 74628
		internal static int __PropertyOffset_11;

		// Token: 0x04012385 RID: 74629
		internal static int __PropertyOffset_12;

		// Token: 0x04012386 RID: 74630
		internal static int __PropertyOffset_13;

		// Token: 0x04012387 RID: 74631
		internal static int __PropertyOffset_14;

		// Token: 0x04012388 RID: 74632
		internal static int __PropertyOffset_15;

		// Token: 0x04012389 RID: 74633
		internal static int __PropertyOffset_16;

		// Token: 0x0401238A RID: 74634
		internal static int __PropertyOffset_17;

		// Token: 0x0401238B RID: 74635
		internal static int __PropertyOffset_18;

		// Token: 0x0401238C RID: 74636
		internal static int __PropertyOffset_19;

		// Token: 0x0401238D RID: 74637
		internal static int __PropertyOffset_20;

		// Token: 0x0401238E RID: 74638
		internal static int __PropertyOffset_21;

		// Token: 0x0401238F RID: 74639
		internal static int __PropertyOffset_22;

		// Token: 0x04012390 RID: 74640
		internal static int __PropertyOffset_23;

		// Token: 0x04012391 RID: 74641
		internal static int __PropertyOffset_24;

		// Token: 0x04012392 RID: 74642
		internal static int __PropertyOffset_25;

		// Token: 0x04012393 RID: 74643
		internal static int __PropertyOffset_26;

		// Token: 0x04012394 RID: 74644
		internal static int __PropertyOffset_27;

		// Token: 0x04012395 RID: 74645
		internal static int __PropertyOffset_28;

		// Token: 0x04012396 RID: 74646
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_genericCloth> _ColArr;

		// Token: 0x04012397 RID: 74647
		internal static int __PropertyOffset_29;

		// Token: 0x04012398 RID: 74648
		internal static int __PropertyOffset_30;

		// Token: 0x04012399 RID: 74649
		internal static int __PropertyOffset_31;

		// Token: 0x0401239A RID: 74650
		internal static int __PropertyOffset_32;

		// Token: 0x0401239B RID: 74651
		internal static int __PropertyOffset_33;

		// Token: 0x0401239C RID: 74652
		internal static int __PropertyOffset_34;

		// Token: 0x0401239D RID: 74653
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401239E RID: 74654
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401239F RID: 74655
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040123A0 RID: 74656
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040123A1 RID: 74657
		private static IntPtr __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040123A2 RID: 74658
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040123A3 RID: 74659
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040123A4 RID: 74660
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040123A5 RID: 74661
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009F5F RID: 40799
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031947 RID: 203079
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F60 RID: 40800
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031948 RID: 203080
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F61 RID: 40801
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031949 RID: 203081
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x0403194A RID: 203082
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403194B RID: 203083
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403194C RID: 203084
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x0403194D RID: 203085
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x02009F62 RID: 40802
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403194E RID: 203086
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403194F RID: 203087
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031950 RID: 203088
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031951 RID: 203089
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031952 RID: 203090
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031953 RID: 203091
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F63 RID: 40803
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031954 RID: 203092
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031955 RID: 203093
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031956 RID: 203094
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031957 RID: 203095
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F64 RID: 40804
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031958 RID: 203096
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031959 RID: 203097
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0403195A RID: 203098
			[FieldOffset(32)]
			public int Id;
		}
	}
}
