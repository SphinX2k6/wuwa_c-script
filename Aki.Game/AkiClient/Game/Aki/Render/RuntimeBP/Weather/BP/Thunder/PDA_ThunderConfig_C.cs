using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP.Thunder
{
	// Token: 0x02003A84 RID: 14980
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_ThunderConfig.PDA_ThunderConfig_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1081)]
	public class PDA_ThunderConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC9A RID: 130202 RVA: 0x008C2AC4 File Offset: 0x008C0CC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_ThunderConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_ThunderConfig.PDA_ThunderConfig_C");
			}
			return PDA_ThunderConfig_C._ClassPtr;
		}

		// Token: 0x0601FC9B RID: 130203 RVA: 0x008C2AE8 File Offset: 0x008C0CE8
		public PDA_ThunderConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_ThunderConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC9C RID: 130204 RVA: 0x008C2B10 File Offset: 0x008C0D10
		public PDA_ThunderConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_ThunderConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0601FC9D RID: 130205 RVA: 0x008C2B43 File Offset: 0x008C0D43
		// (set) Token: 0x0601FC9E RID: 130206 RVA: 0x008C2B53 File Offset: 0x008C0D53
		public unsafe float 落雷概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x0601FC9F RID: 130207 RVA: 0x008C2B64 File Offset: 0x008C0D64
		// (set) Token: 0x0601FCA0 RID: 130208 RVA: 0x008C2B74 File Offset: 0x008C0D74
		public unsafe float 雷落地概率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0601FCA1 RID: 130209 RVA: 0x008C2B85 File Offset: 0x008C0D85
		// (set) Token: 0x0601FCA2 RID: 130210 RVA: 0x008C2B95 File Offset: 0x008C0D95
		public unsafe float 落雷间隔Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x0601FCA3 RID: 130211 RVA: 0x008C2BA6 File Offset: 0x008C0DA6
		// (set) Token: 0x0601FCA4 RID: 130212 RVA: 0x008C2BB6 File Offset: 0x008C0DB6
		public unsafe float 落雷间隔Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x0601FCA5 RID: 130213 RVA: 0x008C2BC7 File Offset: 0x008C0DC7
		// (set) Token: 0x0601FCA6 RID: 130214 RVA: 0x008C2BDB File Offset: 0x008C0DDB
		[Nullable(2)]
		public unsafe UNiagaraSystem ThunderNiagara
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ThunderConfig_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ThunderConfig_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x0601FCA7 RID: 130215 RVA: 0x008C2BF0 File Offset: 0x008C0DF0
		// (set) Token: 0x0601FCA8 RID: 130216 RVA: 0x008C2C29 File Offset: 0x008C0E29
		public FKuroCurveFloat 灯光强度曲线
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._灯光强度曲线) == null)
				{
					result = (this._灯光强度曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x0601FCA9 RID: 130217 RVA: 0x008C2C4C File Offset: 0x008C0E4C
		// (set) Token: 0x0601FCAA RID: 130218 RVA: 0x008C2C85 File Offset: 0x008C0E85
		public FKuroCurveFloat 灯光半径曲线
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._灯光半径曲线) == null)
				{
					result = (this._灯光半径曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x0601FCAB RID: 130219 RVA: 0x008C2CA8 File Offset: 0x008C0EA8
		// (set) Token: 0x0601FCAC RID: 130220 RVA: 0x008C2CE1 File Offset: 0x008C0EE1
		public FKuroCurveFloat 后处理强度曲线
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._后处理强度曲线) == null)
				{
					result = (this._后处理强度曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x0601FCAD RID: 130221 RVA: 0x008C2D02 File Offset: 0x008C0F02
		// (set) Token: 0x0601FCAE RID: 130222 RVA: 0x008C2D12 File Offset: 0x008C0F12
		public unsafe float 落雷内半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x0601FCAF RID: 130223 RVA: 0x008C2D23 File Offset: 0x008C0F23
		// (set) Token: 0x0601FCB0 RID: 130224 RVA: 0x008C2D33 File Offset: 0x008C0F33
		public unsafe float 落雷外半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x0601FCB1 RID: 130225 RVA: 0x008C2D44 File Offset: 0x008C0F44
		// (set) Token: 0x0601FCB2 RID: 130226 RVA: 0x008C2D54 File Offset: 0x008C0F54
		public unsafe float 位置系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x0601FCB3 RID: 130227 RVA: 0x008C2D65 File Offset: 0x008C0F65
		// (set) Token: 0x0601FCB4 RID: 130228 RVA: 0x008C2D75 File Offset: 0x008C0F75
		public unsafe float 射线高度Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x0601FCB5 RID: 130229 RVA: 0x008C2D86 File Offset: 0x008C0F86
		// (set) Token: 0x0601FCB6 RID: 130230 RVA: 0x008C2D96 File Offset: 0x008C0F96
		public unsafe float 射线高度Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x0601FCB7 RID: 130231 RVA: 0x008C2DA8 File Offset: 0x008C0FA8
		// (set) Token: 0x0601FCB8 RID: 130232 RVA: 0x008C2DE1 File Offset: 0x008C0FE1
		public FKuroCurveFloat 云层雷闪光强度曲线
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._云层雷闪光强度曲线) == null)
				{
					result = (this._云层雷闪光强度曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x0601FCB9 RID: 130233 RVA: 0x008C2E02 File Offset: 0x008C1002
		// (set) Token: 0x0601FCBA RID: 130234 RVA: 0x008C2E16 File Offset: 0x008C1016
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent_2D
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ThunderConfig_C.__PropertyOffset_14);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ThunderConfig_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x0601FCBB RID: 130235 RVA: 0x008C2E2B File Offset: 0x008C102B
		// (set) Token: 0x0601FCBC RID: 130236 RVA: 0x008C2E3B File Offset: 0x008C103B
		public unsafe int _2DEventStopTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x0601FCBD RID: 130237 RVA: 0x008C2E4C File Offset: 0x008C104C
		// (set) Token: 0x0601FCBE RID: 130238 RVA: 0x008C2E60 File Offset: 0x008C1060
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent_Lightening
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ThunderConfig_C.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ThunderConfig_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x0601FCBF RID: 130239 RVA: 0x008C2E78 File Offset: 0x008C1078
		// (set) Token: 0x0601FCC0 RID: 130240 RVA: 0x008C2EB1 File Offset: 0x008C10B1
		public FKuroCurveFloat 云层压暗曲线
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._云层压暗曲线) == null)
				{
					result = (this._云层压暗曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_17, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x0601FCC1 RID: 130241 RVA: 0x008C2ED4 File Offset: 0x008C10D4
		// (set) Token: 0x0601FCC2 RID: 130242 RVA: 0x008C2F0D File Offset: 0x008C110D
		public FKuroCurveFloat 暗角曲线
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._暗角曲线) == null)
				{
					result = (this._暗角曲线 = new FKuroCurveFloat(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_18, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x0601FCC3 RID: 130243 RVA: 0x008C2F2E File Offset: 0x008C112E
		// (set) Token: 0x0601FCC4 RID: 130244 RVA: 0x008C2F3E File Offset: 0x008C113E
		public unsafe bool 局部云层闪光
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x0601FCC5 RID: 130245 RVA: 0x008C2F4F File Offset: 0x008C114F
		// (set) Token: 0x0601FCC6 RID: 130246 RVA: 0x008C2F5F File Offset: 0x008C115F
		public unsafe float 云层闪电高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x0601FCC7 RID: 130247 RVA: 0x008C2F70 File Offset: 0x008C1170
		// (set) Token: 0x0601FCC8 RID: 130248 RVA: 0x008C2F84 File Offset: 0x008C1184
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset PostProcessData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ThunderConfig_C.__PropertyOffset_21);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_ThunderConfig_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x0601FCC9 RID: 130249 RVA: 0x008C2F99 File Offset: 0x008C1199
		// (set) Token: 0x0601FCCA RID: 130250 RVA: 0x008C2FAD File Offset: 0x008C11AD
		public unsafe FLinearColor 默认闪电颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x0601FCCB RID: 130251 RVA: 0x008C2FC2 File Offset: 0x008C11C2
		// (set) Token: 0x0601FCCC RID: 130252 RVA: 0x008C2FD2 File Offset: 0x008C11D2
		public unsafe float 落雷最小半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x0601FCCD RID: 130253 RVA: 0x008C2FE3 File Offset: 0x008C11E3
		// (set) Token: 0x0601FCCE RID: 130254 RVA: 0x008C2FF3 File Offset: 0x008C11F3
		public unsafe float 落雷最大半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x0601FCCF RID: 130255 RVA: 0x008C3004 File Offset: 0x008C1204
		// (set) Token: 0x0601FCD0 RID: 130256 RVA: 0x008C3014 File Offset: 0x008C1214
		public unsafe float 落雷边缘区域厚度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x0601FCD1 RID: 130257 RVA: 0x008C3025 File Offset: 0x008C1225
		// (set) Token: 0x0601FCD2 RID: 130258 RVA: 0x008C3035 File Offset: 0x008C1235
		public unsafe float 最小垂直角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x0601FCD3 RID: 130259 RVA: 0x008C3046 File Offset: 0x008C1246
		// (set) Token: 0x0601FCD4 RID: 130260 RVA: 0x008C3056 File Offset: 0x008C1256
		public unsafe float 最大垂直角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x0601FCD5 RID: 130261 RVA: 0x008C3067 File Offset: 0x008C1267
		// (set) Token: 0x0601FCD6 RID: 130262 RVA: 0x008C3077 File Offset: 0x008C1277
		public unsafe float 水平朝向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x0601FCD7 RID: 130263 RVA: 0x008C3088 File Offset: 0x008C1288
		// (set) Token: 0x0601FCD8 RID: 130264 RVA: 0x008C3098 File Offset: 0x008C1298
		public unsafe float 水平朝向强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x0601FCD9 RID: 130265 RVA: 0x008C30A9 File Offset: 0x008C12A9
		// (set) Token: 0x0601FCDA RID: 130266 RVA: 0x008C30B9 File Offset: 0x008C12B9
		public unsafe float 随机种子
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x0601FCDB RID: 130267 RVA: 0x008C30CA File Offset: 0x008C12CA
		// (set) Token: 0x0601FCDC RID: 130268 RVA: 0x008C30DA File Offset: 0x008C12DA
		public unsafe bool 全方位落雷
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_ThunderConfig_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FCDD RID: 130269 RVA: 0x008C30EB File Offset: 0x008C12EB
		protected PDA_ThunderConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F51A RID: 62746
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_ThunderConfig.PDA_ThunderConfig_C";

		// Token: 0x0400F51B RID: 62747
		private static IntPtr _ClassPtr;

		// Token: 0x0400F51C RID: 62748
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F51D RID: 62749
		internal static int __PropertyOffset_0;

		// Token: 0x0400F51E RID: 62750
		internal static int __PropertyOffset_1;

		// Token: 0x0400F51F RID: 62751
		internal static int __PropertyOffset_2;

		// Token: 0x0400F520 RID: 62752
		internal static int __PropertyOffset_3;

		// Token: 0x0400F521 RID: 62753
		internal static int __PropertyOffset_4;

		// Token: 0x0400F522 RID: 62754
		internal static int __PropertyOffset_5;

		// Token: 0x0400F523 RID: 62755
		[Nullable(2)]
		private FKuroCurveFloat _灯光强度曲线;

		// Token: 0x0400F524 RID: 62756
		internal static int __PropertyOffset_6;

		// Token: 0x0400F525 RID: 62757
		[Nullable(2)]
		private FKuroCurveFloat _灯光半径曲线;

		// Token: 0x0400F526 RID: 62758
		internal static int __PropertyOffset_7;

		// Token: 0x0400F527 RID: 62759
		[Nullable(2)]
		private FKuroCurveFloat _后处理强度曲线;

		// Token: 0x0400F528 RID: 62760
		internal static int __PropertyOffset_8;

		// Token: 0x0400F529 RID: 62761
		internal static int __PropertyOffset_9;

		// Token: 0x0400F52A RID: 62762
		internal static int __PropertyOffset_10;

		// Token: 0x0400F52B RID: 62763
		internal static int __PropertyOffset_11;

		// Token: 0x0400F52C RID: 62764
		internal static int __PropertyOffset_12;

		// Token: 0x0400F52D RID: 62765
		internal static int __PropertyOffset_13;

		// Token: 0x0400F52E RID: 62766
		[Nullable(2)]
		private FKuroCurveFloat _云层雷闪光强度曲线;

		// Token: 0x0400F52F RID: 62767
		internal static int __PropertyOffset_14;

		// Token: 0x0400F530 RID: 62768
		internal static int __PropertyOffset_15;

		// Token: 0x0400F531 RID: 62769
		internal static int __PropertyOffset_16;

		// Token: 0x0400F532 RID: 62770
		internal static int __PropertyOffset_17;

		// Token: 0x0400F533 RID: 62771
		[Nullable(2)]
		private FKuroCurveFloat _云层压暗曲线;

		// Token: 0x0400F534 RID: 62772
		internal static int __PropertyOffset_18;

		// Token: 0x0400F535 RID: 62773
		[Nullable(2)]
		private FKuroCurveFloat _暗角曲线;

		// Token: 0x0400F536 RID: 62774
		internal static int __PropertyOffset_19;

		// Token: 0x0400F537 RID: 62775
		internal static int __PropertyOffset_20;

		// Token: 0x0400F538 RID: 62776
		internal static int __PropertyOffset_21;

		// Token: 0x0400F539 RID: 62777
		internal static int __PropertyOffset_22;

		// Token: 0x0400F53A RID: 62778
		internal static int __PropertyOffset_23;

		// Token: 0x0400F53B RID: 62779
		internal static int __PropertyOffset_24;

		// Token: 0x0400F53C RID: 62780
		internal static int __PropertyOffset_25;

		// Token: 0x0400F53D RID: 62781
		internal static int __PropertyOffset_26;

		// Token: 0x0400F53E RID: 62782
		internal static int __PropertyOffset_27;

		// Token: 0x0400F53F RID: 62783
		internal static int __PropertyOffset_28;

		// Token: 0x0400F540 RID: 62784
		internal static int __PropertyOffset_29;

		// Token: 0x0400F541 RID: 62785
		internal static int __PropertyOffset_30;

		// Token: 0x0400F542 RID: 62786
		internal static int __PropertyOffset_31;
	}
}
