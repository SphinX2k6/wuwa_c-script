using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.FindSunSpirit
{
	// Token: 0x02003154 RID: 12628
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/FindSunSpirit/BP_FindSunSpiritGlobalConfig.BP_FindSunSpiritGlobalConfig_C")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class BP_FindSunSpiritGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F0E9 RID: 127209 RVA: 0x00925654 File Offset: 0x00923854
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FindSunSpiritGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/FindSunSpirit/BP_FindSunSpiritGlobalConfig.BP_FindSunSpiritGlobalConfig_C");
			}
			return BP_FindSunSpiritGlobalConfig_C._ClassPtr;
		}

		// Token: 0x0601F0EA RID: 127210 RVA: 0x00925678 File Offset: 0x00923878
		public BP_FindSunSpiritGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FindSunSpiritGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F0EB RID: 127211 RVA: 0x009256A0 File Offset: 0x009238A0
		public BP_FindSunSpiritGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FindSunSpiritGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0601F0EC RID: 127212 RVA: 0x009256D3 File Offset: 0x009238D3
		// (set) Token: 0x0601F0ED RID: 127213 RVA: 0x009256E7 File Offset: 0x009238E7
		[Nullable(2)]
		public unsafe UAnimMontage 跳跃蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃蒙太奇);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃蒙太奇, value);
			}
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0601F0EE RID: 127214 RVA: 0x009256FC File Offset: 0x009238FC
		// (set) Token: 0x0601F0EF RID: 127215 RVA: 0x0092570C File Offset: 0x0092390C
		public unsafe int 跳跃旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃旋转速度) = value;
			}
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0601F0F0 RID: 127216 RVA: 0x0092571D File Offset: 0x0092391D
		// (set) Token: 0x0601F0F1 RID: 127217 RVA: 0x0092572D File Offset: 0x0092392D
		public unsafe int 跳跃高度偏移基准
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃高度偏移基准);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃高度偏移基准) = value;
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0601F0F2 RID: 127218 RVA: 0x0092573E File Offset: 0x0092393E
		// (set) Token: 0x0601F0F3 RID: 127219 RVA: 0x0092574E File Offset: 0x0092394E
		public unsafe int 跳跃时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃时间) = value;
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0601F0F4 RID: 127220 RVA: 0x0092575F File Offset: 0x0092395F
		// (set) Token: 0x0601F0F5 RID: 127221 RVA: 0x0092576F File Offset: 0x0092396F
		public unsafe int 跳跃上升偏移曲线高度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃上升偏移曲线高度范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃上升偏移曲线高度范围) = value;
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0601F0F6 RID: 127222 RVA: 0x00925780 File Offset: 0x00923980
		// (set) Token: 0x0601F0F7 RID: 127223 RVA: 0x00925790 File Offset: 0x00923990
		public unsafe int 跳跃下降偏移曲线高度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃下降偏移曲线高度范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃下降偏移曲线高度范围) = value;
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0601F0F8 RID: 127224 RVA: 0x009257A1 File Offset: 0x009239A1
		// (set) Token: 0x0601F0F9 RID: 127225 RVA: 0x009257B5 File Offset: 0x009239B5
		[Nullable(2)]
		public unsafe UCurveFloat 跳跃上升偏移曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃上升偏移曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃上升偏移曲线, value);
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0601F0FA RID: 127226 RVA: 0x009257CA File Offset: 0x009239CA
		// (set) Token: 0x0601F0FB RID: 127227 RVA: 0x009257DE File Offset: 0x009239DE
		[Nullable(2)]
		public unsafe UCurveFloat 跳跃下降偏移曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃下降偏移曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_跳跃下降偏移曲线, value);
			}
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0601F0FC RID: 127228 RVA: 0x009257F3 File Offset: 0x009239F3
		// (set) Token: 0x0601F0FD RID: 127229 RVA: 0x00925807 File Offset: 0x00923A07
		[Nullable(2)]
		public unsafe UAnimMontage 奔跑蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_奔跑蒙太奇);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_奔跑蒙太奇, value);
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0601F0FE RID: 127230 RVA: 0x0092581C File Offset: 0x00923A1C
		// (set) Token: 0x0601F0FF RID: 127231 RVA: 0x0092582C File Offset: 0x00923A2C
		public unsafe int 奔跑移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_奔跑移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_奔跑移动速度) = value;
			}
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0601F100 RID: 127232 RVA: 0x0092583D File Offset: 0x00923A3D
		// (set) Token: 0x0601F101 RID: 127233 RVA: 0x0092584D File Offset: 0x00923A4D
		public unsafe int 奔跑旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_奔跑旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_奔跑旋转速度) = value;
			}
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0601F102 RID: 127234 RVA: 0x0092585E File Offset: 0x00923A5E
		// (set) Token: 0x0601F103 RID: 127235 RVA: 0x0092586E File Offset: 0x00923A6E
		public unsafe int 奔跑结束停顿时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_奔跑结束停顿时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_奔跑结束停顿时间) = value;
			}
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0601F104 RID: 127236 RVA: 0x0092587F File Offset: 0x00923A7F
		// (set) Token: 0x0601F105 RID: 127237 RVA: 0x0092588F File Offset: 0x00923A8F
		public unsafe int 导航线持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_导航线持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_导航线持续时间) = value;
			}
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0601F106 RID: 127238 RVA: 0x009258A0 File Offset: 0x00923AA0
		// (set) Token: 0x0601F107 RID: 127239 RVA: 0x009258B5 File Offset: 0x00923AB5
		public TSoftObjectPtr<UEffectModelGroup> 成功导航线特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_成功导航线特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_成功导航线特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0601F108 RID: 127240 RVA: 0x009258DA File Offset: 0x00923ADA
		// (set) Token: 0x0601F109 RID: 127241 RVA: 0x009258EF File Offset: 0x00923AEF
		public TSoftObjectPtr<UEffectModelGroup> 失败导航线特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_失败导航线特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_失败导航线特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0601F10A RID: 127242 RVA: 0x00925914 File Offset: 0x00923B14
		// (set) Token: 0x0601F10B RID: 127243 RVA: 0x0092594D File Offset: 0x00923B4D
		public FSoftObjectPath 扩散装置路径
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._扩散装置路径) == null)
				{
					result = (this._扩散装置路径 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_扩散装置路径, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_扩散装置路径, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0601F10C RID: 127244 RVA: 0x0092596E File Offset: 0x00923B6E
		// (set) Token: 0x0601F10D RID: 127245 RVA: 0x0092597E File Offset: 0x00923B7E
		public unsafe int 扩散触发持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_扩散触发持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_扩散触发持续时间) = value;
			}
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0601F10E RID: 127246 RVA: 0x00925990 File Offset: 0x00923B90
		// (set) Token: 0x0601F10F RID: 127247 RVA: 0x009259C9 File Offset: 0x00923BC9
		public TArray<FIntPoint> 扩散影响范围
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIntPoint> result;
				if ((result = this._扩散影响范围) == null)
				{
					result = (this._扩散影响范围 = new TArray<FIntPoint>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_扩散影响范围, this));
				}
				return result;
			}
			set
			{
				this.扩散影响范围.CopyAssign(value);
			}
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0601F110 RID: 127248 RVA: 0x009259D7 File Offset: 0x00923BD7
		// (set) Token: 0x0601F111 RID: 127249 RVA: 0x009259EC File Offset: 0x00923BEC
		public TSoftObjectPtr<UNiagaraSystem> 关卡地板Niagara
		{
			get
			{
				return new TSoftObjectPtr<UNiagaraSystem>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_关卡地板Niagara, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_关卡地板Niagara, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0601F112 RID: 127250 RVA: 0x00925A11 File Offset: 0x00923C11
		// (set) Token: 0x0601F113 RID: 127251 RVA: 0x00925A21 File Offset: 0x00923C21
		public unsafe int 关卡地板单位大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_关卡地板单位大小);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_关卡地板单位大小) = value;
			}
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0601F114 RID: 127252 RVA: 0x00925A32 File Offset: 0x00923C32
		// (set) Token: 0x0601F115 RID: 127253 RVA: 0x00925A46 File Offset: 0x00923C46
		[Nullable(2)]
		public unsafe UAnimMontage 寻路失败蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_寻路失败蒙太奇);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_寻路失败蒙太奇, value);
			}
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0601F116 RID: 127254 RVA: 0x00925A5B File Offset: 0x00923C5B
		// (set) Token: 0x0601F117 RID: 127255 RVA: 0x00925A6F File Offset: 0x00923C6F
		[Nullable(2)]
		public unsafe UAnimMontage 到达终点蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_到达终点蒙太奇);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_到达终点蒙太奇, value);
			}
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0601F118 RID: 127256 RVA: 0x00925A84 File Offset: 0x00923C84
		// (set) Token: 0x0601F119 RID: 127257 RVA: 0x00925A98 File Offset: 0x00923C98
		[Nullable(2)]
		public unsafe UAnimMontage 终点待机蒙太奇
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_终点待机蒙太奇);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_终点待机蒙太奇, value);
			}
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0601F11A RID: 127258 RVA: 0x00925AAD File Offset: 0x00923CAD
		// (set) Token: 0x0601F11B RID: 127259 RVA: 0x00925AC2 File Offset: 0x00923CC2
		public TSoftObjectPtr<UEffectModelGroup> 射击轨迹特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_射击轨迹特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_射击轨迹特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0601F11C RID: 127260 RVA: 0x00925AE7 File Offset: 0x00923CE7
		// (set) Token: 0x0601F11D RID: 127261 RVA: 0x00925AFC File Offset: 0x00923CFC
		public TSoftObjectPtr<UEffectModelGroup> 射击终点特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_射击终点特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_射击终点特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0601F11E RID: 127262 RVA: 0x00925B21 File Offset: 0x00923D21
		// (set) Token: 0x0601F11F RID: 127263 RVA: 0x00925B31 File Offset: 0x00923D31
		public unsafe int 射击冷却时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_射击冷却时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_射击冷却时间) = value;
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0601F120 RID: 127264 RVA: 0x00925B42 File Offset: 0x00923D42
		// (set) Token: 0x0601F121 RID: 127265 RVA: 0x00925B52 File Offset: 0x00923D52
		public unsafe int 失败重置延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_失败重置延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FindSunSpiritGlobalConfig_C.__PropertyOffset_失败重置延迟时间) = value;
			}
		}

		// Token: 0x0601F122 RID: 127266 RVA: 0x00925B63 File Offset: 0x00923D63
		protected BP_FindSunSpiritGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401097D RID: 67965
		public new const string __ObjectPath = "/Game/Aki/GamePlay/FindSunSpirit/BP_FindSunSpiritGlobalConfig.BP_FindSunSpiritGlobalConfig_C";

		// Token: 0x0401097E RID: 67966
		private static IntPtr _ClassPtr;

		// Token: 0x0401097F RID: 67967
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010980 RID: 67968
		internal static int __PropertyOffset_跳跃蒙太奇;

		// Token: 0x04010981 RID: 67969
		internal static int __PropertyOffset_跳跃旋转速度;

		// Token: 0x04010982 RID: 67970
		internal static int __PropertyOffset_跳跃高度偏移基准;

		// Token: 0x04010983 RID: 67971
		internal static int __PropertyOffset_跳跃时间;

		// Token: 0x04010984 RID: 67972
		internal static int __PropertyOffset_跳跃上升偏移曲线高度范围;

		// Token: 0x04010985 RID: 67973
		internal static int __PropertyOffset_跳跃下降偏移曲线高度范围;

		// Token: 0x04010986 RID: 67974
		internal static int __PropertyOffset_跳跃上升偏移曲线;

		// Token: 0x04010987 RID: 67975
		internal static int __PropertyOffset_跳跃下降偏移曲线;

		// Token: 0x04010988 RID: 67976
		internal static int __PropertyOffset_奔跑蒙太奇;

		// Token: 0x04010989 RID: 67977
		internal static int __PropertyOffset_奔跑移动速度;

		// Token: 0x0401098A RID: 67978
		internal static int __PropertyOffset_奔跑旋转速度;

		// Token: 0x0401098B RID: 67979
		internal static int __PropertyOffset_奔跑结束停顿时间;

		// Token: 0x0401098C RID: 67980
		internal static int __PropertyOffset_导航线持续时间;

		// Token: 0x0401098D RID: 67981
		internal static int __PropertyOffset_成功导航线特效;

		// Token: 0x0401098E RID: 67982
		internal static int __PropertyOffset_失败导航线特效;

		// Token: 0x0401098F RID: 67983
		internal static int __PropertyOffset_扩散装置路径;

		// Token: 0x04010990 RID: 67984
		[Nullable(2)]
		private FSoftObjectPath _扩散装置路径;

		// Token: 0x04010991 RID: 67985
		internal static int __PropertyOffset_扩散触发持续时间;

		// Token: 0x04010992 RID: 67986
		internal static int __PropertyOffset_扩散影响范围;

		// Token: 0x04010993 RID: 67987
		[Nullable(2)]
		private TArray<FIntPoint> _扩散影响范围;

		// Token: 0x04010994 RID: 67988
		internal static int __PropertyOffset_关卡地板Niagara;

		// Token: 0x04010995 RID: 67989
		internal static int __PropertyOffset_关卡地板单位大小;

		// Token: 0x04010996 RID: 67990
		internal static int __PropertyOffset_寻路失败蒙太奇;

		// Token: 0x04010997 RID: 67991
		internal static int __PropertyOffset_到达终点蒙太奇;

		// Token: 0x04010998 RID: 67992
		internal static int __PropertyOffset_终点待机蒙太奇;

		// Token: 0x04010999 RID: 67993
		internal static int __PropertyOffset_射击轨迹特效;

		// Token: 0x0401099A RID: 67994
		internal static int __PropertyOffset_射击终点特效;

		// Token: 0x0401099B RID: 67995
		internal static int __PropertyOffset_射击冷却时间;

		// Token: 0x0401099C RID: 67996
		internal static int __PropertyOffset_失败重置延迟时间;
	}
}
