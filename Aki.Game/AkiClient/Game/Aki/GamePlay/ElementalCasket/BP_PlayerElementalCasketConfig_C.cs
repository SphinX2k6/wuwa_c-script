using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.ElementalCasket
{
	// Token: 0x02003155 RID: 12629
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/ElementalCasket/BP_PlayerElementalCasketConfig.BP_PlayerElementalCasketConfig_C")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class BP_PlayerElementalCasketConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F123 RID: 127267 RVA: 0x00925B6C File Offset: 0x00923D6C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlayerElementalCasketConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/ElementalCasket/BP_PlayerElementalCasketConfig.BP_PlayerElementalCasketConfig_C");
			}
			return BP_PlayerElementalCasketConfig_C._ClassPtr;
		}

		// Token: 0x0601F124 RID: 127268 RVA: 0x00925B90 File Offset: 0x00923D90
		public BP_PlayerElementalCasketConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlayerElementalCasketConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F125 RID: 127269 RVA: 0x00925BB8 File Offset: 0x00923DB8
		public BP_PlayerElementalCasketConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlayerElementalCasketConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0601F126 RID: 127270 RVA: 0x00925BEC File Offset: 0x00923DEC
		// (set) Token: 0x0601F127 RID: 127271 RVA: 0x00925C25 File Offset: 0x00923E25
		public FSoftObjectPath 匣子核心路径
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._匣子核心路径) == null)
				{
					result = (this._匣子核心路径 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_匣子核心路径, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_匣子核心路径, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0601F128 RID: 127272 RVA: 0x00925C46 File Offset: 0x00923E46
		// (set) Token: 0x0601F129 RID: 127273 RVA: 0x00925C56 File Offset: 0x00923E56
		public unsafe float 领域半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_领域半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_领域半径) = value;
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0601F12A RID: 127274 RVA: 0x00925C68 File Offset: 0x00923E68
		// (set) Token: 0x0601F12B RID: 127275 RVA: 0x00925CA1 File Offset: 0x00923EA1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalFieldConfig> 领域元素配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalFieldConfig> result;
				if ((result = this._领域元素配置) == null)
				{
					result = (this._领域元素配置 = new TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalFieldConfig>(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_领域元素配置, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.领域元素配置.CopyAssign(value);
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0601F12C RID: 127276 RVA: 0x00925CB0 File Offset: 0x00923EB0
		// (set) Token: 0x0601F12D RID: 127277 RVA: 0x00925CE9 File Offset: 0x00923EE9
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<ECasketElementType>, TSoftObjectPtr<EffectModelGroup>> 重置核心特效
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECasketElementType>, TSoftObjectPtr<EffectModelGroup>> result;
				if ((result = this._重置核心特效) == null)
				{
					result = (this._重置核心特效 = new TMap<TEnumAsByte<ECasketElementType>, TSoftObjectPtr<EffectModelGroup>>(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_重置核心特效, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.重置核心特效.CopyAssign(value);
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0601F12E RID: 127278 RVA: 0x00925CF7 File Offset: 0x00923EF7
		// (set) Token: 0x0601F12F RID: 127279 RVA: 0x00925D0B File Offset: 0x00923F0B
		public unsafe FVector 核心位置偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_核心位置偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_核心位置偏移) = value;
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0601F130 RID: 127280 RVA: 0x00925D20 File Offset: 0x00923F20
		// (set) Token: 0x0601F131 RID: 127281 RVA: 0x00925D34 File Offset: 0x00923F34
		public unsafe FRotator 核心基础旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_核心基础旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_核心基础旋转) = value;
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0601F132 RID: 127282 RVA: 0x00925D49 File Offset: 0x00923F49
		// (set) Token: 0x0601F133 RID: 127283 RVA: 0x00925D59 File Offset: 0x00923F59
		public unsafe float 拉取时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_拉取时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_拉取时间) = value;
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0601F134 RID: 127284 RVA: 0x00925D6A File Offset: 0x00923F6A
		// (set) Token: 0x0601F135 RID: 127285 RVA: 0x00925D7A File Offset: 0x00923F7A
		public unsafe float 拉取延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_拉取延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_拉取延迟时间) = value;
			}
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0601F136 RID: 127286 RVA: 0x00925D8B File Offset: 0x00923F8B
		// (set) Token: 0x0601F137 RID: 127287 RVA: 0x00925D9B File Offset: 0x00923F9B
		public unsafe float 牵引时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_牵引时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_牵引时间) = value;
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0601F138 RID: 127288 RVA: 0x00925DAC File Offset: 0x00923FAC
		// (set) Token: 0x0601F139 RID: 127289 RVA: 0x00925DBC File Offset: 0x00923FBC
		public unsafe int 牵引高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_牵引高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_牵引高度) = value;
			}
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0601F13A RID: 127290 RVA: 0x00925DCD File Offset: 0x00923FCD
		// (set) Token: 0x0601F13B RID: 127291 RVA: 0x00925DDD File Offset: 0x00923FDD
		public unsafe float 归还时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_归还时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_归还时间) = value;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0601F13C RID: 127292 RVA: 0x00925DEE File Offset: 0x00923FEE
		// (set) Token: 0x0601F13D RID: 127293 RVA: 0x00925DFE File Offset: 0x00923FFE
		public unsafe float 归还延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_归还延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_归还延迟时间) = value;
			}
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0601F13E RID: 127294 RVA: 0x00925E0F File Offset: 0x0092400F
		// (set) Token: 0x0601F13F RID: 127295 RVA: 0x00925E1F File Offset: 0x0092401F
		public unsafe float 下落时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_下落时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_下落时间) = value;
			}
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0601F140 RID: 127296 RVA: 0x00925E30 File Offset: 0x00924030
		// (set) Token: 0x0601F141 RID: 127297 RVA: 0x00925E40 File Offset: 0x00924040
		public unsafe int 下落高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_下落高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_下落高度) = value;
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0601F142 RID: 127298 RVA: 0x00925E51 File Offset: 0x00924051
		// (set) Token: 0x0601F143 RID: 127299 RVA: 0x00925E61 File Offset: 0x00924061
		public unsafe int 位置插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_位置插值速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_位置插值速度) = value;
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0601F144 RID: 127300 RVA: 0x00925E72 File Offset: 0x00924072
		// (set) Token: 0x0601F145 RID: 127301 RVA: 0x00925E82 File Offset: 0x00924082
		public unsafe int 旋转插值速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_旋转插值速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_旋转插值速度) = value;
			}
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0601F146 RID: 127302 RVA: 0x00925E93 File Offset: 0x00924093
		// (set) Token: 0x0601F147 RID: 127303 RVA: 0x00925EA3 File Offset: 0x009240A3
		public unsafe int 插值距离上限
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_插值距离上限);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_插值距离上限) = value;
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0601F148 RID: 127304 RVA: 0x00925EB4 File Offset: 0x009240B4
		// (set) Token: 0x0601F149 RID: 127305 RVA: 0x00925EC4 File Offset: 0x009240C4
		public unsafe float 匹配延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_匹配延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_匹配延迟时间) = value;
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0601F14A RID: 127306 RVA: 0x00925ED5 File Offset: 0x009240D5
		// (set) Token: 0x0601F14B RID: 127307 RVA: 0x00925EE5 File Offset: 0x009240E5
		public unsafe float 匹配移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_匹配移动时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_匹配移动时间) = value;
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0601F14C RID: 127308 RVA: 0x00925EF6 File Offset: 0x009240F6
		// (set) Token: 0x0601F14D RID: 127309 RVA: 0x00925F06 File Offset: 0x00924106
		public unsafe float 取消匹配延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_取消匹配延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_取消匹配延迟时间) = value;
			}
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0601F14E RID: 127310 RVA: 0x00925F17 File Offset: 0x00924117
		// (set) Token: 0x0601F14F RID: 127311 RVA: 0x00925F27 File Offset: 0x00924127
		public unsafe float 取消匹配移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_取消匹配移动时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_取消匹配移动时间) = value;
			}
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0601F150 RID: 127312 RVA: 0x00925F38 File Offset: 0x00924138
		// (set) Token: 0x0601F151 RID: 127313 RVA: 0x00925F71 File Offset: 0x00924171
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalCoreAudioConfig> 匣子核心音频
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalCoreAudioConfig> result;
				if ((result = this._匣子核心音频) == null)
				{
					result = (this._匣子核心音频 = new TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalCoreAudioConfig>(base.NativePtr + (IntPtr)BP_PlayerElementalCasketConfig_C.__PropertyOffset_匣子核心音频, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.匣子核心音频.CopyAssign(value);
			}
		}

		// Token: 0x0601F152 RID: 127314 RVA: 0x00925F7F File Offset: 0x0092417F
		protected BP_PlayerElementalCasketConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401099D RID: 67997
		public new const string __ObjectPath = "/Game/Aki/GamePlay/ElementalCasket/BP_PlayerElementalCasketConfig.BP_PlayerElementalCasketConfig_C";

		// Token: 0x0401099E RID: 67998
		private static IntPtr _ClassPtr;

		// Token: 0x0401099F RID: 67999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109A0 RID: 68000
		internal static int __PropertyOffset_匣子核心路径;

		// Token: 0x040109A1 RID: 68001
		[Nullable(2)]
		private FSoftObjectPath _匣子核心路径;

		// Token: 0x040109A2 RID: 68002
		internal static int __PropertyOffset_领域半径;

		// Token: 0x040109A3 RID: 68003
		internal static int __PropertyOffset_领域元素配置;

		// Token: 0x040109A4 RID: 68004
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalFieldConfig> _领域元素配置;

		// Token: 0x040109A5 RID: 68005
		internal static int __PropertyOffset_重置核心特效;

		// Token: 0x040109A6 RID: 68006
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<ECasketElementType>, TSoftObjectPtr<EffectModelGroup>> _重置核心特效;

		// Token: 0x040109A7 RID: 68007
		internal static int __PropertyOffset_核心位置偏移;

		// Token: 0x040109A8 RID: 68008
		internal static int __PropertyOffset_核心基础旋转;

		// Token: 0x040109A9 RID: 68009
		internal static int __PropertyOffset_拉取时间;

		// Token: 0x040109AA RID: 68010
		internal static int __PropertyOffset_拉取延迟时间;

		// Token: 0x040109AB RID: 68011
		internal static int __PropertyOffset_牵引时间;

		// Token: 0x040109AC RID: 68012
		internal static int __PropertyOffset_牵引高度;

		// Token: 0x040109AD RID: 68013
		internal static int __PropertyOffset_归还时间;

		// Token: 0x040109AE RID: 68014
		internal static int __PropertyOffset_归还延迟时间;

		// Token: 0x040109AF RID: 68015
		internal static int __PropertyOffset_下落时间;

		// Token: 0x040109B0 RID: 68016
		internal static int __PropertyOffset_下落高度;

		// Token: 0x040109B1 RID: 68017
		internal static int __PropertyOffset_位置插值速度;

		// Token: 0x040109B2 RID: 68018
		internal static int __PropertyOffset_旋转插值速度;

		// Token: 0x040109B3 RID: 68019
		internal static int __PropertyOffset_插值距离上限;

		// Token: 0x040109B4 RID: 68020
		internal static int __PropertyOffset_匹配延迟时间;

		// Token: 0x040109B5 RID: 68021
		internal static int __PropertyOffset_匹配移动时间;

		// Token: 0x040109B6 RID: 68022
		internal static int __PropertyOffset_取消匹配延迟时间;

		// Token: 0x040109B7 RID: 68023
		internal static int __PropertyOffset_取消匹配移动时间;

		// Token: 0x040109B8 RID: 68024
		internal static int __PropertyOffset_匣子核心音频;

		// Token: 0x040109B9 RID: 68025
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECasketElementType>, SPlayerElementalCoreAudioConfig> _匣子核心音频;
	}
}
