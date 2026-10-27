using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039E4 RID: 14820
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 632)]
	public class BP_EventManager_C : BP_ManagerBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F058 RID: 127064 RVA: 0x008A7BD7 File Offset: 0x008A5DD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EventManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C");
			}
			return BP_EventManager_C._ClassPtr;
		}

		// Token: 0x0601F059 RID: 127065 RVA: 0x008A7BFC File Offset: 0x008A5DFC
		public BP_EventManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_EventManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F05A RID: 127066 RVA: 0x008A7C24 File Offset: 0x008A5E24
		public BP_EventManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EventManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x0601F05B RID: 127067 RVA: 0x008A7C58 File Offset: 0x008A5E58
		// (set) Token: 0x0601F05C RID: 127068 RVA: 0x008A7C91 File Offset: 0x008A5E91
		public 界面生命周期改变 界面生命周期改变
		{
			get
			{
				base.FastCheckIsValid();
				界面生命周期改变 result;
				if ((result = this._界面生命周期改变) == null)
				{
					result = (this._界面生命周期改变 = new 界面生命周期改变(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_0, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x0601F05D RID: 127069 RVA: 0x008A7CB4 File Offset: 0x008A5EB4
		// (set) Token: 0x0601F05E RID: 127070 RVA: 0x008A7CED File Offset: 0x008A5EED
		public 当有角色受击时 当有角色受击时
		{
			get
			{
				base.FastCheckIsValid();
				当有角色受击时 result;
				if ((result = this._当有角色受击时) == null)
				{
					result = (this._当有角色受击时 = new 当有角色受击时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_1, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0601F05F RID: 127071 RVA: 0x008A7D10 File Offset: 0x008A5F10
		// (set) Token: 0x0601F060 RID: 127072 RVA: 0x008A7D49 File Offset: 0x008A5F49
		public 当解密界面打开时 当解密界面打开时
		{
			get
			{
				base.FastCheckIsValid();
				当解密界面打开时 result;
				if ((result = this._当解密界面打开时) == null)
				{
					result = (this._当解密界面打开时 = new 当解密界面打开时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_2, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x0601F061 RID: 127073 RVA: 0x008A7D6C File Offset: 0x008A5F6C
		// (set) Token: 0x0601F062 RID: 127074 RVA: 0x008A7DA5 File Offset: 0x008A5FA5
		public 删除实体 删除实体
		{
			get
			{
				base.FastCheckIsValid();
				删除实体 result;
				if ((result = this._删除实体) == null)
				{
					result = (this._删除实体 = new 删除实体(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_3, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x0601F063 RID: 127075 RVA: 0x008A7DC8 File Offset: 0x008A5FC8
		// (set) Token: 0x0601F064 RID: 127076 RVA: 0x008A7E01 File Offset: 0x008A6001
		public WorldDoneNotify WorldDoneNotify
		{
			get
			{
				base.FastCheckIsValid();
				WorldDoneNotify result;
				if ((result = this._WorldDoneNotify) == null)
				{
					result = (this._WorldDoneNotify = new WorldDoneNotify(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_4, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x0601F065 RID: 127077 RVA: 0x008A7E24 File Offset: 0x008A6024
		// (set) Token: 0x0601F066 RID: 127078 RVA: 0x008A7E5D File Offset: 0x008A605D
		public 增加实体 增加实体
		{
			get
			{
				base.FastCheckIsValid();
				增加实体 result;
				if ((result = this._增加实体) == null)
				{
					result = (this._增加实体 = new 增加实体(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_5, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x0601F067 RID: 127079 RVA: 0x008A7E80 File Offset: 0x008A6080
		// (set) Token: 0x0601F068 RID: 127080 RVA: 0x008A7EB9 File Offset: 0x008A60B9
		public 当换人完成时 当换人完成时
		{
			get
			{
				base.FastCheckIsValid();
				当换人完成时 result;
				if ((result = this._当换人完成时) == null)
				{
					result = (this._当换人完成时 = new 当换人完成时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_6, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x0601F069 RID: 127081 RVA: 0x008A7EDC File Offset: 0x008A60DC
		// (set) Token: 0x0601F06A RID: 127082 RVA: 0x008A7F15 File Offset: 0x008A6115
		public 子弹命中前 子弹命中前
		{
			get
			{
				base.FastCheckIsValid();
				子弹命中前 result;
				if ((result = this._子弹命中前) == null)
				{
					result = (this._子弹命中前 = new 子弹命中前(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_7, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0601F06B RID: 127083 RVA: 0x008A7F38 File Offset: 0x008A6138
		// (set) Token: 0x0601F06C RID: 127084 RVA: 0x008A7F71 File Offset: 0x008A6171
		public 角色部位血量变化时 角色部位血量变化时
		{
			get
			{
				base.FastCheckIsValid();
				角色部位血量变化时 result;
				if ((result = this._角色部位血量变化时) == null)
				{
					result = (this._角色部位血量变化时 = new 角色部位血量变化时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_8, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x0601F06D RID: 127085 RVA: 0x008A7F94 File Offset: 0x008A6194
		// (set) Token: 0x0601F06E RID: 127086 RVA: 0x008A7FCD File Offset: 0x008A61CD
		public 角色部位弱点打击时 角色部位弱点打击时
		{
			get
			{
				base.FastCheckIsValid();
				角色部位弱点打击时 result;
				if ((result = this._角色部位弱点打击时) == null)
				{
					result = (this._角色部位弱点打击时 = new 角色部位弱点打击时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_9, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x0601F06F RID: 127087 RVA: 0x008A7FF0 File Offset: 0x008A61F0
		// (set) Token: 0x0601F070 RID: 127088 RVA: 0x008A8029 File Offset: 0x008A6229
		public AI巡逻达到样条点 AI巡逻达到样条点
		{
			get
			{
				base.FastCheckIsValid();
				AI巡逻达到样条点 result;
				if ((result = this._AI巡逻达到样条点) == null)
				{
					result = (this._AI巡逻达到样条点 = new AI巡逻达到样条点(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_10, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0601F071 RID: 127089 RVA: 0x008A804C File Offset: 0x008A624C
		// (set) Token: 0x0601F072 RID: 127090 RVA: 0x008A8085 File Offset: 0x008A6285
		public 被控物广播 被控物广播
		{
			get
			{
				base.FastCheckIsValid();
				被控物广播 result;
				if ((result = this._被控物广播) == null)
				{
					result = (this._被控物广播 = new 被控物广播(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_11, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0601F073 RID: 127091 RVA: 0x008A80A8 File Offset: 0x008A62A8
		// (set) Token: 0x0601F074 RID: 127092 RVA: 0x008A80E1 File Offset: 0x008A62E1
		public CaughtEntity CaughtEntity
		{
			get
			{
				base.FastCheckIsValid();
				CaughtEntity result;
				if ((result = this._CaughtEntity) == null)
				{
					result = (this._CaughtEntity = new CaughtEntity(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_12, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x0601F075 RID: 127093 RVA: 0x008A8104 File Offset: 0x008A6304
		// (set) Token: 0x0601F076 RID: 127094 RVA: 0x008A813D File Offset: 0x008A633D
		public 角色状态切换时 角色状态切换时
		{
			get
			{
				base.FastCheckIsValid();
				角色状态切换时 result;
				if ((result = this._角色状态切换时) == null)
				{
					result = (this._角色状态切换时 = new 角色状态切换时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_13, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x0601F077 RID: 127095 RVA: 0x008A8160 File Offset: 0x008A6360
		// (set) Token: 0x0601F078 RID: 127096 RVA: 0x008A8199 File Offset: 0x008A6399
		public 当触发对策事件时 当触发对策事件时
		{
			get
			{
				base.FastCheckIsValid();
				当触发对策事件时 result;
				if ((result = this._当触发对策事件时) == null)
				{
					result = (this._当触发对策事件时 = new 当触发对策事件时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_14, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x0601F079 RID: 127097 RVA: 0x008A81BC File Offset: 0x008A63BC
		// (set) Token: 0x0601F07A RID: 127098 RVA: 0x008A81F5 File Offset: 0x008A63F5
		public 当有角色死亡时 当有角色死亡时
		{
			get
			{
				base.FastCheckIsValid();
				当有角色死亡时 result;
				if ((result = this._当有角色死亡时) == null)
				{
					result = (this._当有角色死亡时 = new 当有角色死亡时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_15, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x0601F07B RID: 127099 RVA: 0x008A8218 File Offset: 0x008A6418
		// (set) Token: 0x0601F07C RID: 127100 RVA: 0x008A8251 File Offset: 0x008A6451
		public 小队战斗状态改变时 小队战斗状态改变时
		{
			get
			{
				base.FastCheckIsValid();
				小队战斗状态改变时 result;
				if ((result = this._小队战斗状态改变时) == null)
				{
					result = (this._小队战斗状态改变时 = new 小队战斗状态改变时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_16, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0601F07D RID: 127101 RVA: 0x008A8274 File Offset: 0x008A6474
		// (set) Token: 0x0601F07E RID: 127102 RVA: 0x008A82AD File Offset: 0x008A64AD
		public 小队技能目标改变时 小队技能目标改变时
		{
			get
			{
				base.FastCheckIsValid();
				小队技能目标改变时 result;
				if ((result = this._小队技能目标改变时) == null)
				{
					result = (this._小队技能目标改变时 = new 小队技能目标改变时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_17, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0601F07F RID: 127103 RVA: 0x008A82D0 File Offset: 0x008A64D0
		// (set) Token: 0x0601F080 RID: 127104 RVA: 0x008A8309 File Offset: 0x008A6509
		public 抓取目标成功时 抓取目标成功时
		{
			get
			{
				base.FastCheckIsValid();
				抓取目标成功时 result;
				if ((result = this._抓取目标成功时) == null)
				{
					result = (this._抓取目标成功时 = new 抓取目标成功时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_18, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0601F081 RID: 127105 RVA: 0x008A832C File Offset: 0x008A652C
		// (set) Token: 0x0601F082 RID: 127106 RVA: 0x008A8365 File Offset: 0x008A6565
		public 材质播放结束时 材质播放结束时
		{
			get
			{
				base.FastCheckIsValid();
				材质播放结束时 result;
				if ((result = this._材质播放结束时) == null)
				{
					result = (this._材质播放结束时 = new 材质播放结束时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_19, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0601F083 RID: 127107 RVA: 0x008A8388 File Offset: 0x008A6588
		// (set) Token: 0x0601F084 RID: 127108 RVA: 0x008A83C1 File Offset: 0x008A65C1
		public 当编队更新时 当编队更新时
		{
			get
			{
				base.FastCheckIsValid();
				当编队更新时 result;
				if ((result = this._当编队更新时) == null)
				{
					result = (this._当编队更新时 = new 当编队更新时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_20, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x0601F085 RID: 127109 RVA: 0x008A83E4 File Offset: 0x008A65E4
		// (set) Token: 0x0601F086 RID: 127110 RVA: 0x008A841D File Offset: 0x008A661D
		public OnEnterPhotograph OnEnterPhotograph
		{
			get
			{
				base.FastCheckIsValid();
				OnEnterPhotograph result;
				if ((result = this._OnEnterPhotograph) == null)
				{
					result = (this._OnEnterPhotograph = new OnEnterPhotograph(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_21, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x0601F087 RID: 127111 RVA: 0x008A8440 File Offset: 0x008A6640
		// (set) Token: 0x0601F088 RID: 127112 RVA: 0x008A8479 File Offset: 0x008A6679
		public OnExitPhotograph OnExitPhotograph
		{
			get
			{
				base.FastCheckIsValid();
				OnExitPhotograph result;
				if ((result = this._OnExitPhotograph) == null)
				{
					result = (this._OnExitPhotograph = new OnExitPhotograph(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_22, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_22, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x0601F089 RID: 127113 RVA: 0x008A849C File Offset: 0x008A669C
		// (set) Token: 0x0601F08A RID: 127114 RVA: 0x008A84D5 File Offset: 0x008A66D5
		public 被控物撞到水面时 被控物撞到水面时
		{
			get
			{
				base.FastCheckIsValid();
				被控物撞到水面时 result;
				if ((result = this._被控物撞到水面时) == null)
				{
					result = (this._被控物撞到水面时 = new 被控物撞到水面时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_23, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x0601F08B RID: 127115 RVA: 0x008A84F8 File Offset: 0x008A66F8
		// (set) Token: 0x0601F08C RID: 127116 RVA: 0x008A8531 File Offset: 0x008A6731
		public 开始吸取污染物 开始吸取污染物
		{
			get
			{
				base.FastCheckIsValid();
				开始吸取污染物 result;
				if ((result = this._开始吸取污染物) == null)
				{
					result = (this._开始吸取污染物 = new 开始吸取污染物(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_24, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_24, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0601F08D RID: 127117 RVA: 0x008A8554 File Offset: 0x008A6754
		// (set) Token: 0x0601F08E RID: 127118 RVA: 0x008A858D File Offset: 0x008A678D
		public 停止吸取污染物 停止吸取污染物
		{
			get
			{
				base.FastCheckIsValid();
				停止吸取污染物 result;
				if ((result = this._停止吸取污染物) == null)
				{
					result = (this._停止吸取污染物 = new 停止吸取污染物(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_25, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0601F08F RID: 127119 RVA: 0x008A85B0 File Offset: 0x008A67B0
		// (set) Token: 0x0601F090 RID: 127120 RVA: 0x008A85E9 File Offset: 0x008A67E9
		public 当捕鱼船创建时 当捕鱼船创建时
		{
			get
			{
				base.FastCheckIsValid();
				当捕鱼船创建时 result;
				if ((result = this._当捕鱼船创建时) == null)
				{
					result = (this._当捕鱼船创建时 = new 当捕鱼船创建时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_26, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_26, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0601F091 RID: 127121 RVA: 0x008A860C File Offset: 0x008A680C
		// (set) Token: 0x0601F092 RID: 127122 RVA: 0x008A8645 File Offset: 0x008A6845
		public 子弹撞到水面时 子弹撞到水面时
		{
			get
			{
				base.FastCheckIsValid();
				子弹撞到水面时 result;
				if ((result = this._子弹撞到水面时) == null)
				{
					result = (this._子弹撞到水面时 = new 子弹撞到水面时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_27, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_27, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0601F093 RID: 127123 RVA: 0x008A8668 File Offset: 0x008A6868
		// (set) Token: 0x0601F094 RID: 127124 RVA: 0x008A86A1 File Offset: 0x008A68A1
		public 当有角色复活时 当有角色复活时
		{
			get
			{
				base.FastCheckIsValid();
				当有角色复活时 result;
				if ((result = this._当有角色复活时) == null)
				{
					result = (this._当有角色复活时 = new 当有角色复活时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_28, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_28, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0601F095 RID: 127125 RVA: 0x008A86C4 File Offset: 0x008A68C4
		// (set) Token: 0x0601F096 RID: 127126 RVA: 0x008A86FD File Offset: 0x008A68FD
		public 武器交互场景时 武器交互场景时
		{
			get
			{
				base.FastCheckIsValid();
				武器交互场景时 result;
				if ((result = this._武器交互场景时) == null)
				{
					result = (this._武器交互场景时 = new 武器交互场景时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_29, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_29, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x0601F097 RID: 127127 RVA: 0x008A8720 File Offset: 0x008A6920
		// (set) Token: 0x0601F098 RID: 127128 RVA: 0x008A8759 File Offset: 0x008A6959
		public 当浮游炮瞄准可以自动开炮时 当浮游炮瞄准可以自动开炮时
		{
			get
			{
				base.FastCheckIsValid();
				当浮游炮瞄准可以自动开炮时 result;
				if ((result = this._当浮游炮瞄准可以自动开炮时) == null)
				{
					result = (this._当浮游炮瞄准可以自动开炮时 = new 当浮游炮瞄准可以自动开炮时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_30, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x0601F099 RID: 127129 RVA: 0x008A877C File Offset: 0x008A697C
		// (set) Token: 0x0601F09A RID: 127130 RVA: 0x008A87B5 File Offset: 0x008A69B5
		public 音乐节拍事件触发时 音乐节拍事件触发时
		{
			get
			{
				base.FastCheckIsValid();
				音乐节拍事件触发时 result;
				if ((result = this._音乐节拍事件触发时) == null)
				{
					result = (this._音乐节拍事件触发时 = new 音乐节拍事件触发时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_31, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_31, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x0601F09B RID: 127131 RVA: 0x008A87D8 File Offset: 0x008A69D8
		// (set) Token: 0x0601F09C RID: 127132 RVA: 0x008A8811 File Offset: 0x008A6A11
		public 当触发结算镜头时 当触发结算镜头时
		{
			get
			{
				base.FastCheckIsValid();
				当触发结算镜头时 result;
				if ((result = this._当触发结算镜头时) == null)
				{
					result = (this._当触发结算镜头时 = new 当触发结算镜头时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_32, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_32, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x0601F09D RID: 127133 RVA: 0x008A8834 File Offset: 0x008A6A34
		// (set) Token: 0x0601F09E RID: 127134 RVA: 0x008A886D File Offset: 0x008A6A6D
		public 当触发相机注视时 当触发相机注视时
		{
			get
			{
				base.FastCheckIsValid();
				当触发相机注视时 result;
				if ((result = this._当触发相机注视时) == null)
				{
					result = (this._当触发相机注视时 = new 当触发相机注视时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_33, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_33, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x0601F09F RID: 127135 RVA: 0x008A8890 File Offset: 0x008A6A90
		// (set) Token: 0x0601F0A0 RID: 127136 RVA: 0x008A88C9 File Offset: 0x008A6AC9
		public 演出状态改变时 演出状态改变时
		{
			get
			{
				base.FastCheckIsValid();
				演出状态改变时 result;
				if ((result = this._演出状态改变时) == null)
				{
					result = (this._演出状态改变时 = new 演出状态改变时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_34, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_34, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601F0A1 RID: 127137 RVA: 0x008A88EA File Offset: 0x008A6AEA
		protected BP_EventManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EDA0 RID: 60832
		public new const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C";

		// Token: 0x0400EDA1 RID: 60833
		private static IntPtr _ClassPtr;

		// Token: 0x0400EDA2 RID: 60834
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EDA3 RID: 60835
		public static IntPtr __演出状态改变时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDA4 RID: 60836
		public static IntPtr __当触发相机注视时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDA5 RID: 60837
		public static IntPtr __当触发结算镜头时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDA6 RID: 60838
		public static IntPtr __音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDA7 RID: 60839
		public static IntPtr __当浮游炮瞄准可以自动开炮时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDA8 RID: 60840
		public static IntPtr __武器交互场景时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDA9 RID: 60841
		public static IntPtr __当有角色复活时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDAA RID: 60842
		public static IntPtr __子弹撞到水面时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDAB RID: 60843
		public static IntPtr __当捕鱼船创建时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDAC RID: 60844
		public static IntPtr __停止吸取污染物__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDAD RID: 60845
		public static IntPtr __开始吸取污染物__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDAE RID: 60846
		public static IntPtr __被控物撞到水面时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDAF RID: 60847
		public static IntPtr __OnExitPhotograph__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB0 RID: 60848
		public static IntPtr __OnEnterPhotograph__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB1 RID: 60849
		public static IntPtr __当编队更新时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB2 RID: 60850
		public static IntPtr __材质播放结束时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB3 RID: 60851
		public static IntPtr __抓取目标成功时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB4 RID: 60852
		public static IntPtr __小队技能目标改变时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB5 RID: 60853
		public static IntPtr __小队战斗状态改变时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB6 RID: 60854
		public static IntPtr __当有角色死亡时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB7 RID: 60855
		public static IntPtr __当触发对策事件时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB8 RID: 60856
		public static IntPtr __角色状态切换时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDB9 RID: 60857
		public static IntPtr __CaughtEntity__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDBA RID: 60858
		public static IntPtr __被控物广播__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDBB RID: 60859
		public static IntPtr __AI巡逻达到样条点__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDBC RID: 60860
		public static IntPtr __角色部位弱点打击时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDBD RID: 60861
		public static IntPtr __角色部位血量变化时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDBE RID: 60862
		public static IntPtr __子弹命中前__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDBF RID: 60863
		public static IntPtr __当换人完成时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDC0 RID: 60864
		public static IntPtr __增加实体__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDC1 RID: 60865
		public static IntPtr __WorldDoneNotify__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDC2 RID: 60866
		public static IntPtr __删除实体__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDC3 RID: 60867
		public static IntPtr __当解密界面打开时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDC4 RID: 60868
		public static IntPtr __当有角色受击时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDC5 RID: 60869
		public static IntPtr __界面生命周期改变__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400EDC6 RID: 60870
		internal new static int __PropertyOffset_0;

		// Token: 0x0400EDC7 RID: 60871
		[Nullable(2)]
		private 界面生命周期改变 _界面生命周期改变;

		// Token: 0x0400EDC8 RID: 60872
		internal new static int __PropertyOffset_1;

		// Token: 0x0400EDC9 RID: 60873
		[Nullable(2)]
		private 当有角色受击时 _当有角色受击时;

		// Token: 0x0400EDCA RID: 60874
		internal new static int __PropertyOffset_2;

		// Token: 0x0400EDCB RID: 60875
		[Nullable(2)]
		private 当解密界面打开时 _当解密界面打开时;

		// Token: 0x0400EDCC RID: 60876
		internal static int __PropertyOffset_3;

		// Token: 0x0400EDCD RID: 60877
		[Nullable(2)]
		private 删除实体 _删除实体;

		// Token: 0x0400EDCE RID: 60878
		internal static int __PropertyOffset_4;

		// Token: 0x0400EDCF RID: 60879
		[Nullable(2)]
		private WorldDoneNotify _WorldDoneNotify;

		// Token: 0x0400EDD0 RID: 60880
		internal static int __PropertyOffset_5;

		// Token: 0x0400EDD1 RID: 60881
		[Nullable(2)]
		private 增加实体 _增加实体;

		// Token: 0x0400EDD2 RID: 60882
		internal static int __PropertyOffset_6;

		// Token: 0x0400EDD3 RID: 60883
		[Nullable(2)]
		private 当换人完成时 _当换人完成时;

		// Token: 0x0400EDD4 RID: 60884
		internal static int __PropertyOffset_7;

		// Token: 0x0400EDD5 RID: 60885
		[Nullable(2)]
		private 子弹命中前 _子弹命中前;

		// Token: 0x0400EDD6 RID: 60886
		internal static int __PropertyOffset_8;

		// Token: 0x0400EDD7 RID: 60887
		[Nullable(2)]
		private 角色部位血量变化时 _角色部位血量变化时;

		// Token: 0x0400EDD8 RID: 60888
		internal static int __PropertyOffset_9;

		// Token: 0x0400EDD9 RID: 60889
		[Nullable(2)]
		private 角色部位弱点打击时 _角色部位弱点打击时;

		// Token: 0x0400EDDA RID: 60890
		internal static int __PropertyOffset_10;

		// Token: 0x0400EDDB RID: 60891
		[Nullable(2)]
		private AI巡逻达到样条点 _AI巡逻达到样条点;

		// Token: 0x0400EDDC RID: 60892
		internal static int __PropertyOffset_11;

		// Token: 0x0400EDDD RID: 60893
		[Nullable(2)]
		private 被控物广播 _被控物广播;

		// Token: 0x0400EDDE RID: 60894
		internal static int __PropertyOffset_12;

		// Token: 0x0400EDDF RID: 60895
		[Nullable(2)]
		private CaughtEntity _CaughtEntity;

		// Token: 0x0400EDE0 RID: 60896
		internal static int __PropertyOffset_13;

		// Token: 0x0400EDE1 RID: 60897
		[Nullable(2)]
		private 角色状态切换时 _角色状态切换时;

		// Token: 0x0400EDE2 RID: 60898
		internal static int __PropertyOffset_14;

		// Token: 0x0400EDE3 RID: 60899
		[Nullable(2)]
		private 当触发对策事件时 _当触发对策事件时;

		// Token: 0x0400EDE4 RID: 60900
		internal static int __PropertyOffset_15;

		// Token: 0x0400EDE5 RID: 60901
		[Nullable(2)]
		private 当有角色死亡时 _当有角色死亡时;

		// Token: 0x0400EDE6 RID: 60902
		internal static int __PropertyOffset_16;

		// Token: 0x0400EDE7 RID: 60903
		[Nullable(2)]
		private 小队战斗状态改变时 _小队战斗状态改变时;

		// Token: 0x0400EDE8 RID: 60904
		internal static int __PropertyOffset_17;

		// Token: 0x0400EDE9 RID: 60905
		[Nullable(2)]
		private 小队技能目标改变时 _小队技能目标改变时;

		// Token: 0x0400EDEA RID: 60906
		internal static int __PropertyOffset_18;

		// Token: 0x0400EDEB RID: 60907
		[Nullable(2)]
		private 抓取目标成功时 _抓取目标成功时;

		// Token: 0x0400EDEC RID: 60908
		internal static int __PropertyOffset_19;

		// Token: 0x0400EDED RID: 60909
		[Nullable(2)]
		private 材质播放结束时 _材质播放结束时;

		// Token: 0x0400EDEE RID: 60910
		internal static int __PropertyOffset_20;

		// Token: 0x0400EDEF RID: 60911
		[Nullable(2)]
		private 当编队更新时 _当编队更新时;

		// Token: 0x0400EDF0 RID: 60912
		internal static int __PropertyOffset_21;

		// Token: 0x0400EDF1 RID: 60913
		[Nullable(2)]
		private OnEnterPhotograph _OnEnterPhotograph;

		// Token: 0x0400EDF2 RID: 60914
		internal static int __PropertyOffset_22;

		// Token: 0x0400EDF3 RID: 60915
		[Nullable(2)]
		private OnExitPhotograph _OnExitPhotograph;

		// Token: 0x0400EDF4 RID: 60916
		internal static int __PropertyOffset_23;

		// Token: 0x0400EDF5 RID: 60917
		[Nullable(2)]
		private 被控物撞到水面时 _被控物撞到水面时;

		// Token: 0x0400EDF6 RID: 60918
		internal static int __PropertyOffset_24;

		// Token: 0x0400EDF7 RID: 60919
		[Nullable(2)]
		private 开始吸取污染物 _开始吸取污染物;

		// Token: 0x0400EDF8 RID: 60920
		internal static int __PropertyOffset_25;

		// Token: 0x0400EDF9 RID: 60921
		[Nullable(2)]
		private 停止吸取污染物 _停止吸取污染物;

		// Token: 0x0400EDFA RID: 60922
		internal static int __PropertyOffset_26;

		// Token: 0x0400EDFB RID: 60923
		[Nullable(2)]
		private 当捕鱼船创建时 _当捕鱼船创建时;

		// Token: 0x0400EDFC RID: 60924
		internal static int __PropertyOffset_27;

		// Token: 0x0400EDFD RID: 60925
		[Nullable(2)]
		private 子弹撞到水面时 _子弹撞到水面时;

		// Token: 0x0400EDFE RID: 60926
		internal static int __PropertyOffset_28;

		// Token: 0x0400EDFF RID: 60927
		[Nullable(2)]
		private 当有角色复活时 _当有角色复活时;

		// Token: 0x0400EE00 RID: 60928
		internal static int __PropertyOffset_29;

		// Token: 0x0400EE01 RID: 60929
		[Nullable(2)]
		private 武器交互场景时 _武器交互场景时;

		// Token: 0x0400EE02 RID: 60930
		internal static int __PropertyOffset_30;

		// Token: 0x0400EE03 RID: 60931
		[Nullable(2)]
		private 当浮游炮瞄准可以自动开炮时 _当浮游炮瞄准可以自动开炮时;

		// Token: 0x0400EE04 RID: 60932
		internal static int __PropertyOffset_31;

		// Token: 0x0400EE05 RID: 60933
		[Nullable(2)]
		private 音乐节拍事件触发时 _音乐节拍事件触发时;

		// Token: 0x0400EE06 RID: 60934
		internal static int __PropertyOffset_32;

		// Token: 0x0400EE07 RID: 60935
		[Nullable(2)]
		private 当触发结算镜头时 _当触发结算镜头时;

		// Token: 0x0400EE08 RID: 60936
		internal static int __PropertyOffset_33;

		// Token: 0x0400EE09 RID: 60937
		[Nullable(2)]
		private 当触发相机注视时 _当触发相机注视时;

		// Token: 0x0400EE0A RID: 60938
		internal static int __PropertyOffset_34;

		// Token: 0x0400EE0B RID: 60939
		[Nullable(2)]
		private 演出状态改变时 _演出状态改变时;
	}
}
