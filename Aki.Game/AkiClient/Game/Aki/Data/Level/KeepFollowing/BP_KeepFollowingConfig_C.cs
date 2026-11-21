using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.KeepFollowing
{
	// Token: 0x020031C9 RID: 12745
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/KeepFollowing/BP_KeepFollowingConfig.BP_KeepFollowingConfig_C")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 348)]
	public class BP_KeepFollowingConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8DD RID: 129245 RVA: 0x009304EE File Offset: 0x0092E6EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KeepFollowingConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/KeepFollowing/BP_KeepFollowingConfig.BP_KeepFollowingConfig_C");
			}
			return BP_KeepFollowingConfig_C._ClassPtr;
		}

		// Token: 0x0601F8DE RID: 129246 RVA: 0x00930514 File Offset: 0x0092E714
		public BP_KeepFollowingConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_KeepFollowingConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8DF RID: 129247 RVA: 0x0093053C File Offset: 0x0092E73C
		public BP_KeepFollowingConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KeepFollowingConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0601F8E0 RID: 129248 RVA: 0x0093056F File Offset: 0x0092E76F
		// (set) Token: 0x0601F8E1 RID: 129249 RVA: 0x00930583 File Offset: 0x0092E783
		public unsafe FVector2D 步行跟随方位向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_步行跟随方位向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_步行跟随方位向量) = value;
			}
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0601F8E2 RID: 129250 RVA: 0x00930598 File Offset: 0x0092E798
		// (set) Token: 0x0601F8E3 RID: 129251 RVA: 0x009305AC File Offset: 0x0092E7AC
		public unsafe FVector2D 跑步跟随方位向量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跑步跟随方位向量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跑步跟随方位向量) = value;
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0601F8E4 RID: 129252 RVA: 0x009305C1 File Offset: 0x0092E7C1
		// (set) Token: 0x0601F8E5 RID: 129253 RVA: 0x009305D5 File Offset: 0x0092E7D5
		public unsafe FVector2D 跟随变速范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跟随变速范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跟随变速范围) = value;
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0601F8E6 RID: 129254 RVA: 0x009305EA File Offset: 0x0092E7EA
		// (set) Token: 0x0601F8E7 RID: 129255 RVA: 0x009305FA File Offset: 0x0092E7FA
		public unsafe bool 是否启用位移修正
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_是否启用位移修正) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_是否启用位移修正) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0601F8E8 RID: 129256 RVA: 0x0093060B File Offset: 0x0092E80B
		// (set) Token: 0x0601F8E9 RID: 129257 RVA: 0x0093061B File Offset: 0x0092E81B
		public unsafe int 位移修正距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_位移修正距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_位移修正距离) = value;
			}
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0601F8EA RID: 129258 RVA: 0x0093062C File Offset: 0x0092E82C
		// (set) Token: 0x0601F8EB RID: 129259 RVA: 0x0093063C File Offset: 0x0092E83C
		public unsafe int 保持站立距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_保持站立距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_保持站立距离) = value;
			}
		}

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0601F8EC RID: 129260 RVA: 0x0093064D File Offset: 0x0092E84D
		// (set) Token: 0x0601F8ED RID: 129261 RVA: 0x0093065D File Offset: 0x0092E85D
		public unsafe int 走跑状态分界速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_走跑状态分界速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_走跑状态分界速度) = value;
			}
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0601F8EE RID: 129262 RVA: 0x0093066E File Offset: 0x0092E86E
		// (set) Token: 0x0601F8EF RID: 129263 RVA: 0x0093067E File Offset: 0x0092E87E
		public unsafe int 走跑分界速度浮动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_走跑分界速度浮动);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_走跑分界速度浮动) = value;
			}
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x0601F8F0 RID: 129264 RVA: 0x0093068F File Offset: 0x0092E88F
		// (set) Token: 0x0601F8F1 RID: 129265 RVA: 0x0093069F File Offset: 0x0092E89F
		public unsafe int 跑冲刺分界速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跑冲刺分界速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跑冲刺分界速度) = value;
			}
		}

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0601F8F2 RID: 129266 RVA: 0x009306B0 File Offset: 0x0092E8B0
		// (set) Token: 0x0601F8F3 RID: 129267 RVA: 0x009306C0 File Offset: 0x0092E8C0
		public unsafe int 跑冲刺分界速度浮动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跑冲刺分界速度浮动);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跑冲刺分界速度浮动) = value;
			}
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x0601F8F4 RID: 129268 RVA: 0x009306D1 File Offset: 0x0092E8D1
		// (set) Token: 0x0601F8F5 RID: 129269 RVA: 0x009306E1 File Offset: 0x0092E8E1
		public unsafe int 跟随距离容差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跟随距离容差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跟随距离容差) = value;
			}
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x0601F8F6 RID: 129270 RVA: 0x009306F2 File Offset: 0x0092E8F2
		// (set) Token: 0x0601F8F7 RID: 129271 RVA: 0x00930702 File Offset: 0x0092E902
		public unsafe int 转向角度容差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_转向角度容差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_转向角度容差) = value;
			}
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0601F8F8 RID: 129272 RVA: 0x00930713 File Offset: 0x0092E913
		// (set) Token: 0x0601F8F9 RID: 129273 RVA: 0x00930723 File Offset: 0x0092E923
		public unsafe int 最大转向持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_最大转向持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_最大转向持续时间) = value;
			}
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0601F8FA RID: 129274 RVA: 0x00930734 File Offset: 0x0092E934
		// (set) Token: 0x0601F8FB RID: 129275 RVA: 0x00930744 File Offset: 0x0092E944
		public unsafe int 变速加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_变速加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_变速加速度) = value;
			}
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x0601F8FC RID: 129276 RVA: 0x00930755 File Offset: 0x0092E955
		// (set) Token: 0x0601F8FD RID: 129277 RVA: 0x00930765 File Offset: 0x0092E965
		public unsafe int 转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_转向速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_转向速度) = value;
			}
		}

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x0601F8FE RID: 129278 RVA: 0x00930776 File Offset: 0x0092E976
		// (set) Token: 0x0601F8FF RID: 129279 RVA: 0x00930786 File Offset: 0x0092E986
		public unsafe int 高低差允许范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_高低差允许范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_高低差允许范围) = value;
			}
		}

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0601F900 RID: 129280 RVA: 0x00930797 File Offset: 0x0092E997
		// (set) Token: 0x0601F901 RID: 129281 RVA: 0x009307A7 File Offset: 0x0092E9A7
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_DebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0601F902 RID: 129282 RVA: 0x009307B8 File Offset: 0x0092E9B8
		// (set) Token: 0x0601F903 RID: 129283 RVA: 0x009307C8 File Offset: 0x0092E9C8
		public unsafe int 位移修正速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_位移修正速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_位移修正速度) = value;
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0601F904 RID: 129284 RVA: 0x009307D9 File Offset: 0x0092E9D9
		// (set) Token: 0x0601F905 RID: 129285 RVA: 0x009307E9 File Offset: 0x0092E9E9
		public unsafe bool 是否启用超时传送
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_是否启用超时传送) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_是否启用超时传送) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0601F906 RID: 129286 RVA: 0x009307FA File Offset: 0x0092E9FA
		// (set) Token: 0x0601F907 RID: 129287 RVA: 0x0093080A File Offset: 0x0092EA0A
		public unsafe int 异常距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_异常距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_异常距离) = value;
			}
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0601F908 RID: 129288 RVA: 0x0093081B File Offset: 0x0092EA1B
		// (set) Token: 0x0601F909 RID: 129289 RVA: 0x0093082B File Offset: 0x0092EA2B
		public unsafe int 超时时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_超时时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_超时时间) = value;
			}
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x0601F90A RID: 129290 RVA: 0x0093083C File Offset: 0x0092EA3C
		// (set) Token: 0x0601F90B RID: 129291 RVA: 0x00930875 File Offset: 0x0092EA75
		public TArray<int> 传送特效buffID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._传送特效buffID) == null)
				{
					result = (this._传送特效buffID = new TArray<int>(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_传送特效buffID, this));
				}
				return result;
			}
			set
			{
				this.传送特效buffID.CopyAssign(value);
			}
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x0601F90C RID: 129292 RVA: 0x00930883 File Offset: 0x0092EA83
		// (set) Token: 0x0601F90D RID: 129293 RVA: 0x00930893 File Offset: 0x0092EA93
		public unsafe int 被阻挡触发传送时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_被阻挡触发传送时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_被阻挡触发传送时间) = value;
			}
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x0601F90E RID: 129294 RVA: 0x009308A4 File Offset: 0x0092EAA4
		// (set) Token: 0x0601F90F RID: 129295 RVA: 0x009308B4 File Offset: 0x0092EAB4
		public unsafe int StandardWalkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_StandardWalkSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_StandardWalkSpeed) = value;
			}
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0601F910 RID: 129296 RVA: 0x009308C5 File Offset: 0x0092EAC5
		// (set) Token: 0x0601F911 RID: 129297 RVA: 0x009308D5 File Offset: 0x0092EAD5
		public unsafe int StandardRunSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_StandardRunSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_StandardRunSpeed) = value;
			}
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0601F912 RID: 129298 RVA: 0x009308E6 File Offset: 0x0092EAE6
		// (set) Token: 0x0601F913 RID: 129299 RVA: 0x009308F6 File Offset: 0x0092EAF6
		public unsafe int StandardSprintSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_StandardSprintSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_StandardSprintSpeed) = value;
			}
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0601F914 RID: 129300 RVA: 0x00930907 File Offset: 0x0092EB07
		// (set) Token: 0x0601F915 RID: 129301 RVA: 0x00930917 File Offset: 0x0092EB17
		public unsafe bool 只使用标准速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_只使用标准速度) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_只使用标准速度) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x0601F916 RID: 129302 RVA: 0x00930928 File Offset: 0x0092EB28
		// (set) Token: 0x0601F917 RID: 129303 RVA: 0x00930938 File Offset: 0x0092EB38
		public unsafe int 保持站立角色距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_保持站立角色距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_保持站立角色距离) = value;
			}
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x0601F918 RID: 129304 RVA: 0x00930949 File Offset: 0x0092EB49
		// (set) Token: 0x0601F919 RID: 129305 RVA: 0x00930959 File Offset: 0x0092EB59
		public unsafe int 加速延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_加速延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_加速延迟时间) = value;
			}
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x0601F91A RID: 129306 RVA: 0x0093096A File Offset: 0x0092EB6A
		// (set) Token: 0x0601F91B RID: 129307 RVA: 0x0093097A File Offset: 0x0092EB7A
		public unsafe int 移动延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_移动延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_移动延迟时间) = value;
			}
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x0601F91C RID: 129308 RVA: 0x0093098B File Offset: 0x0092EB8B
		// (set) Token: 0x0601F91D RID: 129309 RVA: 0x0093099B File Offset: 0x0092EB9B
		public unsafe bool 自动转向目标
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_自动转向目标) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_自动转向目标) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0601F91E RID: 129310 RVA: 0x009309AC File Offset: 0x0092EBAC
		// (set) Token: 0x0601F91F RID: 129311 RVA: 0x009309BC File Offset: 0x0092EBBC
		public unsafe bool 非近距离同步跟随
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_非近距离同步跟随) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_非近距离同步跟随) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x0601F920 RID: 129312 RVA: 0x009309D0 File Offset: 0x0092EBD0
		// (set) Token: 0x0601F921 RID: 129313 RVA: 0x00930A09 File Offset: 0x0092EC09
		public TArray<FVector2D> 跑步跟随方位备选
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._跑步跟随方位备选) == null)
				{
					result = (this._跑步跟随方位备选 = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跑步跟随方位备选, this));
				}
				return result;
			}
			set
			{
				this.跑步跟随方位备选.CopyAssign(value);
			}
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0601F922 RID: 129314 RVA: 0x00930A18 File Offset: 0x0092EC18
		// (set) Token: 0x0601F923 RID: 129315 RVA: 0x00930A51 File Offset: 0x0092EC51
		public TArray<FVector2D> 步行跟随方位备选
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._步行跟随方位备选) == null)
				{
					result = (this._步行跟随方位备选 = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_步行跟随方位备选, this));
				}
				return result;
			}
			set
			{
				this.步行跟随方位备选.CopyAssign(value);
			}
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0601F924 RID: 129316 RVA: 0x00930A60 File Offset: 0x0092EC60
		// (set) Token: 0x0601F925 RID: 129317 RVA: 0x00930A99 File Offset: 0x0092EC99
		public SFreeFollowingConfig 自动跟随信息
		{
			get
			{
				base.FastCheckIsValid();
				SFreeFollowingConfig result;
				if ((result = this._自动跟随信息) == null)
				{
					result = (this._自动跟随信息 = new SFreeFollowingConfig(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_自动跟随信息, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFreeFollowingConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_自动跟随信息, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0601F926 RID: 129318 RVA: 0x00930ABA File Offset: 0x0092ECBA
		// (set) Token: 0x0601F927 RID: 129319 RVA: 0x00930ACE File Offset: 0x0092ECCE
		public unsafe SFollowSitConfig 跟随坐下信息
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跟随坐下信息);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KeepFollowingConfig_C.__PropertyOffset_跟随坐下信息) = value;
			}
		}

		// Token: 0x0601F928 RID: 129320 RVA: 0x00930AE3 File Offset: 0x0092ECE3
		protected BP_KeepFollowingConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010ED1 RID: 69329
		public new const string __ObjectPath = "/Game/Aki/Data/Level/KeepFollowing/BP_KeepFollowingConfig.BP_KeepFollowingConfig_C";

		// Token: 0x04010ED2 RID: 69330
		private static IntPtr _ClassPtr;

		// Token: 0x04010ED3 RID: 69331
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010ED4 RID: 69332
		internal static int __PropertyOffset_步行跟随方位向量;

		// Token: 0x04010ED5 RID: 69333
		internal static int __PropertyOffset_跑步跟随方位向量;

		// Token: 0x04010ED6 RID: 69334
		internal static int __PropertyOffset_跟随变速范围;

		// Token: 0x04010ED7 RID: 69335
		internal static int __PropertyOffset_是否启用位移修正;

		// Token: 0x04010ED8 RID: 69336
		internal static int __PropertyOffset_位移修正距离;

		// Token: 0x04010ED9 RID: 69337
		internal static int __PropertyOffset_保持站立距离;

		// Token: 0x04010EDA RID: 69338
		internal static int __PropertyOffset_走跑状态分界速度;

		// Token: 0x04010EDB RID: 69339
		internal static int __PropertyOffset_走跑分界速度浮动;

		// Token: 0x04010EDC RID: 69340
		internal static int __PropertyOffset_跑冲刺分界速度;

		// Token: 0x04010EDD RID: 69341
		internal static int __PropertyOffset_跑冲刺分界速度浮动;

		// Token: 0x04010EDE RID: 69342
		internal static int __PropertyOffset_跟随距离容差;

		// Token: 0x04010EDF RID: 69343
		internal static int __PropertyOffset_转向角度容差;

		// Token: 0x04010EE0 RID: 69344
		internal static int __PropertyOffset_最大转向持续时间;

		// Token: 0x04010EE1 RID: 69345
		internal static int __PropertyOffset_变速加速度;

		// Token: 0x04010EE2 RID: 69346
		internal static int __PropertyOffset_转向速度;

		// Token: 0x04010EE3 RID: 69347
		internal static int __PropertyOffset_高低差允许范围;

		// Token: 0x04010EE4 RID: 69348
		internal static int __PropertyOffset_DebugDraw;

		// Token: 0x04010EE5 RID: 69349
		internal static int __PropertyOffset_位移修正速度;

		// Token: 0x04010EE6 RID: 69350
		internal static int __PropertyOffset_是否启用超时传送;

		// Token: 0x04010EE7 RID: 69351
		internal static int __PropertyOffset_异常距离;

		// Token: 0x04010EE8 RID: 69352
		internal static int __PropertyOffset_超时时间;

		// Token: 0x04010EE9 RID: 69353
		internal static int __PropertyOffset_传送特效buffID;

		// Token: 0x04010EEA RID: 69354
		[Nullable(2)]
		private TArray<int> _传送特效buffID;

		// Token: 0x04010EEB RID: 69355
		internal static int __PropertyOffset_被阻挡触发传送时间;

		// Token: 0x04010EEC RID: 69356
		internal static int __PropertyOffset_StandardWalkSpeed;

		// Token: 0x04010EED RID: 69357
		internal static int __PropertyOffset_StandardRunSpeed;

		// Token: 0x04010EEE RID: 69358
		internal static int __PropertyOffset_StandardSprintSpeed;

		// Token: 0x04010EEF RID: 69359
		internal static int __PropertyOffset_只使用标准速度;

		// Token: 0x04010EF0 RID: 69360
		internal static int __PropertyOffset_保持站立角色距离;

		// Token: 0x04010EF1 RID: 69361
		internal static int __PropertyOffset_加速延迟时间;

		// Token: 0x04010EF2 RID: 69362
		internal static int __PropertyOffset_移动延迟时间;

		// Token: 0x04010EF3 RID: 69363
		internal static int __PropertyOffset_自动转向目标;

		// Token: 0x04010EF4 RID: 69364
		internal static int __PropertyOffset_非近距离同步跟随;

		// Token: 0x04010EF5 RID: 69365
		internal static int __PropertyOffset_跑步跟随方位备选;

		// Token: 0x04010EF6 RID: 69366
		[Nullable(2)]
		private TArray<FVector2D> _跑步跟随方位备选;

		// Token: 0x04010EF7 RID: 69367
		internal static int __PropertyOffset_步行跟随方位备选;

		// Token: 0x04010EF8 RID: 69368
		[Nullable(2)]
		private TArray<FVector2D> _步行跟随方位备选;

		// Token: 0x04010EF9 RID: 69369
		internal static int __PropertyOffset_自动跟随信息;

		// Token: 0x04010EFA RID: 69370
		[Nullable(2)]
		private SFreeFollowingConfig _自动跟随信息;

		// Token: 0x04010EFB RID: 69371
		internal static int __PropertyOffset_跟随坐下信息;
	}
}
