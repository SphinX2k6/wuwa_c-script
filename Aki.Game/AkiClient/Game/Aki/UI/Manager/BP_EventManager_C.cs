using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200303B RID: 12347
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 648)]
	public class BP_EventManager_C : BP_ManagerBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D4B7 RID: 119991 RVA: 0x008F01DB File Offset: 0x008EE3DB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EventManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C");
			}
			return BP_EventManager_C._ClassPtr;
		}

		// Token: 0x0601D4B8 RID: 119992 RVA: 0x008F0200 File Offset: 0x008EE400
		public BP_EventManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_EventManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D4B9 RID: 119993 RVA: 0x008F0228 File Offset: 0x008EE428
		public BP_EventManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EventManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0601D4BA RID: 119994 RVA: 0x008F025C File Offset: 0x008EE45C
		// (set) Token: 0x0601D4BB RID: 119995 RVA: 0x008F0295 File Offset: 0x008EE495
		public 界面生命周期改变 界面生命周期改变
		{
			get
			{
				base.FastCheckIsValid();
				界面生命周期改变 result;
				if ((result = this._界面生命周期改变) == null)
				{
					result = (this._界面生命周期改变 = new 界面生命周期改变(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_界面生命周期改变, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_界面生命周期改变, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0601D4BC RID: 119996 RVA: 0x008F02B8 File Offset: 0x008EE4B8
		// (set) Token: 0x0601D4BD RID: 119997 RVA: 0x008F02F1 File Offset: 0x008EE4F1
		public 当有角色受击时 当有角色受击时
		{
			get
			{
				base.FastCheckIsValid();
				当有角色受击时 result;
				if ((result = this._当有角色受击时) == null)
				{
					result = (this._当有角色受击时 = new 当有角色受击时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当有角色受击时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当有角色受击时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0601D4BE RID: 119998 RVA: 0x008F0314 File Offset: 0x008EE514
		// (set) Token: 0x0601D4BF RID: 119999 RVA: 0x008F034D File Offset: 0x008EE54D
		public 当解密界面打开时 当解密界面打开时
		{
			get
			{
				base.FastCheckIsValid();
				当解密界面打开时 result;
				if ((result = this._当解密界面打开时) == null)
				{
					result = (this._当解密界面打开时 = new 当解密界面打开时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当解密界面打开时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当解密界面打开时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x0601D4C0 RID: 120000 RVA: 0x008F0370 File Offset: 0x008EE570
		// (set) Token: 0x0601D4C1 RID: 120001 RVA: 0x008F03A9 File Offset: 0x008EE5A9
		public 删除实体 删除实体
		{
			get
			{
				base.FastCheckIsValid();
				删除实体 result;
				if ((result = this._删除实体) == null)
				{
					result = (this._删除实体 = new 删除实体(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_删除实体, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_删除实体, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x0601D4C2 RID: 120002 RVA: 0x008F03CC File Offset: 0x008EE5CC
		// (set) Token: 0x0601D4C3 RID: 120003 RVA: 0x008F0405 File Offset: 0x008EE605
		public WorldDoneNotify WorldDoneNotify
		{
			get
			{
				base.FastCheckIsValid();
				WorldDoneNotify result;
				if ((result = this._WorldDoneNotify) == null)
				{
					result = (this._WorldDoneNotify = new WorldDoneNotify(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_WorldDoneNotify, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_WorldDoneNotify, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x0601D4C4 RID: 120004 RVA: 0x008F0428 File Offset: 0x008EE628
		// (set) Token: 0x0601D4C5 RID: 120005 RVA: 0x008F0461 File Offset: 0x008EE661
		public 增加实体 增加实体
		{
			get
			{
				base.FastCheckIsValid();
				增加实体 result;
				if ((result = this._增加实体) == null)
				{
					result = (this._增加实体 = new 增加实体(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_增加实体, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_增加实体, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x0601D4C6 RID: 120006 RVA: 0x008F0484 File Offset: 0x008EE684
		// (set) Token: 0x0601D4C7 RID: 120007 RVA: 0x008F04BD File Offset: 0x008EE6BD
		public 当换人完成时 当换人完成时
		{
			get
			{
				base.FastCheckIsValid();
				当换人完成时 result;
				if ((result = this._当换人完成时) == null)
				{
					result = (this._当换人完成时 = new 当换人完成时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当换人完成时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当换人完成时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x0601D4C8 RID: 120008 RVA: 0x008F04E0 File Offset: 0x008EE6E0
		// (set) Token: 0x0601D4C9 RID: 120009 RVA: 0x008F0519 File Offset: 0x008EE719
		public 子弹命中前 子弹命中前
		{
			get
			{
				base.FastCheckIsValid();
				子弹命中前 result;
				if ((result = this._子弹命中前) == null)
				{
					result = (this._子弹命中前 = new 子弹命中前(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_子弹命中前, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_子弹命中前, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x0601D4CA RID: 120010 RVA: 0x008F053C File Offset: 0x008EE73C
		// (set) Token: 0x0601D4CB RID: 120011 RVA: 0x008F0575 File Offset: 0x008EE775
		public 角色部位血量变化时 角色部位血量变化时
		{
			get
			{
				base.FastCheckIsValid();
				角色部位血量变化时 result;
				if ((result = this._角色部位血量变化时) == null)
				{
					result = (this._角色部位血量变化时 = new 角色部位血量变化时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_角色部位血量变化时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_角色部位血量变化时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0601D4CC RID: 120012 RVA: 0x008F0598 File Offset: 0x008EE798
		// (set) Token: 0x0601D4CD RID: 120013 RVA: 0x008F05D1 File Offset: 0x008EE7D1
		public 角色部位弱点打击时 角色部位弱点打击时
		{
			get
			{
				base.FastCheckIsValid();
				角色部位弱点打击时 result;
				if ((result = this._角色部位弱点打击时) == null)
				{
					result = (this._角色部位弱点打击时 = new 角色部位弱点打击时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_角色部位弱点打击时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_角色部位弱点打击时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0601D4CE RID: 120014 RVA: 0x008F05F4 File Offset: 0x008EE7F4
		// (set) Token: 0x0601D4CF RID: 120015 RVA: 0x008F062D File Offset: 0x008EE82D
		public AI巡逻达到样条点 AI巡逻达到样条点
		{
			get
			{
				base.FastCheckIsValid();
				AI巡逻达到样条点 result;
				if ((result = this._AI巡逻达到样条点) == null)
				{
					result = (this._AI巡逻达到样条点 = new AI巡逻达到样条点(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_AI巡逻达到样条点, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_AI巡逻达到样条点, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x0601D4D0 RID: 120016 RVA: 0x008F0650 File Offset: 0x008EE850
		// (set) Token: 0x0601D4D1 RID: 120017 RVA: 0x008F0689 File Offset: 0x008EE889
		public 被控物广播 被控物广播
		{
			get
			{
				base.FastCheckIsValid();
				被控物广播 result;
				if ((result = this._被控物广播) == null)
				{
					result = (this._被控物广播 = new 被控物广播(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_被控物广播, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_被控物广播, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0601D4D2 RID: 120018 RVA: 0x008F06AC File Offset: 0x008EE8AC
		// (set) Token: 0x0601D4D3 RID: 120019 RVA: 0x008F06E5 File Offset: 0x008EE8E5
		public CaughtEntity CaughtEntity
		{
			get
			{
				base.FastCheckIsValid();
				CaughtEntity result;
				if ((result = this._CaughtEntity) == null)
				{
					result = (this._CaughtEntity = new CaughtEntity(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_CaughtEntity, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_CaughtEntity, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0601D4D4 RID: 120020 RVA: 0x008F0708 File Offset: 0x008EE908
		// (set) Token: 0x0601D4D5 RID: 120021 RVA: 0x008F0741 File Offset: 0x008EE941
		public 角色状态切换时 角色状态切换时
		{
			get
			{
				base.FastCheckIsValid();
				角色状态切换时 result;
				if ((result = this._角色状态切换时) == null)
				{
					result = (this._角色状态切换时 = new 角色状态切换时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_角色状态切换时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_角色状态切换时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0601D4D6 RID: 120022 RVA: 0x008F0764 File Offset: 0x008EE964
		// (set) Token: 0x0601D4D7 RID: 120023 RVA: 0x008F079D File Offset: 0x008EE99D
		public 当触发对策事件时 当触发对策事件时
		{
			get
			{
				base.FastCheckIsValid();
				当触发对策事件时 result;
				if ((result = this._当触发对策事件时) == null)
				{
					result = (this._当触发对策事件时 = new 当触发对策事件时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当触发对策事件时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当触发对策事件时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x0601D4D8 RID: 120024 RVA: 0x008F07C0 File Offset: 0x008EE9C0
		// (set) Token: 0x0601D4D9 RID: 120025 RVA: 0x008F07F9 File Offset: 0x008EE9F9
		public 当有角色死亡时 当有角色死亡时
		{
			get
			{
				base.FastCheckIsValid();
				当有角色死亡时 result;
				if ((result = this._当有角色死亡时) == null)
				{
					result = (this._当有角色死亡时 = new 当有角色死亡时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当有角色死亡时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当有角色死亡时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x0601D4DA RID: 120026 RVA: 0x008F081C File Offset: 0x008EEA1C
		// (set) Token: 0x0601D4DB RID: 120027 RVA: 0x008F0855 File Offset: 0x008EEA55
		public 小队战斗状态改变时 小队战斗状态改变时
		{
			get
			{
				base.FastCheckIsValid();
				小队战斗状态改变时 result;
				if ((result = this._小队战斗状态改变时) == null)
				{
					result = (this._小队战斗状态改变时 = new 小队战斗状态改变时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_小队战斗状态改变时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_小队战斗状态改变时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x0601D4DC RID: 120028 RVA: 0x008F0878 File Offset: 0x008EEA78
		// (set) Token: 0x0601D4DD RID: 120029 RVA: 0x008F08B1 File Offset: 0x008EEAB1
		public 小队技能目标改变时 小队技能目标改变时
		{
			get
			{
				base.FastCheckIsValid();
				小队技能目标改变时 result;
				if ((result = this._小队技能目标改变时) == null)
				{
					result = (this._小队技能目标改变时 = new 小队技能目标改变时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_小队技能目标改变时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_小队技能目标改变时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x0601D4DE RID: 120030 RVA: 0x008F08D4 File Offset: 0x008EEAD4
		// (set) Token: 0x0601D4DF RID: 120031 RVA: 0x008F090D File Offset: 0x008EEB0D
		public 抓取目标成功时 抓取目标成功时
		{
			get
			{
				base.FastCheckIsValid();
				抓取目标成功时 result;
				if ((result = this._抓取目标成功时) == null)
				{
					result = (this._抓取目标成功时 = new 抓取目标成功时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_抓取目标成功时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_抓取目标成功时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0601D4E0 RID: 120032 RVA: 0x008F0930 File Offset: 0x008EEB30
		// (set) Token: 0x0601D4E1 RID: 120033 RVA: 0x008F0969 File Offset: 0x008EEB69
		public 材质播放结束时 材质播放结束时
		{
			get
			{
				base.FastCheckIsValid();
				材质播放结束时 result;
				if ((result = this._材质播放结束时) == null)
				{
					result = (this._材质播放结束时 = new 材质播放结束时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_材质播放结束时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_材质播放结束时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0601D4E2 RID: 120034 RVA: 0x008F098C File Offset: 0x008EEB8C
		// (set) Token: 0x0601D4E3 RID: 120035 RVA: 0x008F09C5 File Offset: 0x008EEBC5
		public 当编队更新时 当编队更新时
		{
			get
			{
				base.FastCheckIsValid();
				当编队更新时 result;
				if ((result = this._当编队更新时) == null)
				{
					result = (this._当编队更新时 = new 当编队更新时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当编队更新时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当编队更新时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0601D4E4 RID: 120036 RVA: 0x008F09E8 File Offset: 0x008EEBE8
		// (set) Token: 0x0601D4E5 RID: 120037 RVA: 0x008F0A21 File Offset: 0x008EEC21
		public OnEnterPhotograph OnEnterPhotograph
		{
			get
			{
				base.FastCheckIsValid();
				OnEnterPhotograph result;
				if ((result = this._OnEnterPhotograph) == null)
				{
					result = (this._OnEnterPhotograph = new OnEnterPhotograph(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_OnEnterPhotograph, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_OnEnterPhotograph, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0601D4E6 RID: 120038 RVA: 0x008F0A44 File Offset: 0x008EEC44
		// (set) Token: 0x0601D4E7 RID: 120039 RVA: 0x008F0A7D File Offset: 0x008EEC7D
		public OnExitPhotograph OnExitPhotograph
		{
			get
			{
				base.FastCheckIsValid();
				OnExitPhotograph result;
				if ((result = this._OnExitPhotograph) == null)
				{
					result = (this._OnExitPhotograph = new OnExitPhotograph(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_OnExitPhotograph, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_OnExitPhotograph, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0601D4E8 RID: 120040 RVA: 0x008F0AA0 File Offset: 0x008EECA0
		// (set) Token: 0x0601D4E9 RID: 120041 RVA: 0x008F0AD9 File Offset: 0x008EECD9
		public 被控物撞到水面时 被控物撞到水面时
		{
			get
			{
				base.FastCheckIsValid();
				被控物撞到水面时 result;
				if ((result = this._被控物撞到水面时) == null)
				{
					result = (this._被控物撞到水面时 = new 被控物撞到水面时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_被控物撞到水面时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_被控物撞到水面时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0601D4EA RID: 120042 RVA: 0x008F0AFC File Offset: 0x008EECFC
		// (set) Token: 0x0601D4EB RID: 120043 RVA: 0x008F0B35 File Offset: 0x008EED35
		public 开始吸取污染物 开始吸取污染物
		{
			get
			{
				base.FastCheckIsValid();
				开始吸取污染物 result;
				if ((result = this._开始吸取污染物) == null)
				{
					result = (this._开始吸取污染物 = new 开始吸取污染物(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_开始吸取污染物, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_开始吸取污染物, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x0601D4EC RID: 120044 RVA: 0x008F0B58 File Offset: 0x008EED58
		// (set) Token: 0x0601D4ED RID: 120045 RVA: 0x008F0B91 File Offset: 0x008EED91
		public 停止吸取污染物 停止吸取污染物
		{
			get
			{
				base.FastCheckIsValid();
				停止吸取污染物 result;
				if ((result = this._停止吸取污染物) == null)
				{
					result = (this._停止吸取污染物 = new 停止吸取污染物(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_停止吸取污染物, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_停止吸取污染物, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0601D4EE RID: 120046 RVA: 0x008F0BB4 File Offset: 0x008EEDB4
		// (set) Token: 0x0601D4EF RID: 120047 RVA: 0x008F0BED File Offset: 0x008EEDED
		public 当捕鱼船创建时 当捕鱼船创建时
		{
			get
			{
				base.FastCheckIsValid();
				当捕鱼船创建时 result;
				if ((result = this._当捕鱼船创建时) == null)
				{
					result = (this._当捕鱼船创建时 = new 当捕鱼船创建时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当捕鱼船创建时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当捕鱼船创建时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x0601D4F0 RID: 120048 RVA: 0x008F0C10 File Offset: 0x008EEE10
		// (set) Token: 0x0601D4F1 RID: 120049 RVA: 0x008F0C49 File Offset: 0x008EEE49
		public 子弹撞到水面时 子弹撞到水面时
		{
			get
			{
				base.FastCheckIsValid();
				子弹撞到水面时 result;
				if ((result = this._子弹撞到水面时) == null)
				{
					result = (this._子弹撞到水面时 = new 子弹撞到水面时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_子弹撞到水面时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_子弹撞到水面时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0601D4F2 RID: 120050 RVA: 0x008F0C6C File Offset: 0x008EEE6C
		// (set) Token: 0x0601D4F3 RID: 120051 RVA: 0x008F0CA5 File Offset: 0x008EEEA5
		public 当有角色复活时 当有角色复活时
		{
			get
			{
				base.FastCheckIsValid();
				当有角色复活时 result;
				if ((result = this._当有角色复活时) == null)
				{
					result = (this._当有角色复活时 = new 当有角色复活时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当有角色复活时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当有角色复活时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0601D4F4 RID: 120052 RVA: 0x008F0CC8 File Offset: 0x008EEEC8
		// (set) Token: 0x0601D4F5 RID: 120053 RVA: 0x008F0D01 File Offset: 0x008EEF01
		public 武器交互场景时 武器交互场景时
		{
			get
			{
				base.FastCheckIsValid();
				武器交互场景时 result;
				if ((result = this._武器交互场景时) == null)
				{
					result = (this._武器交互场景时 = new 武器交互场景时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_武器交互场景时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_武器交互场景时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x0601D4F6 RID: 120054 RVA: 0x008F0D24 File Offset: 0x008EEF24
		// (set) Token: 0x0601D4F7 RID: 120055 RVA: 0x008F0D5D File Offset: 0x008EEF5D
		public 当浮游炮瞄准可以自动开炮时 当浮游炮瞄准可以自动开炮时
		{
			get
			{
				base.FastCheckIsValid();
				当浮游炮瞄准可以自动开炮时 result;
				if ((result = this._当浮游炮瞄准可以自动开炮时) == null)
				{
					result = (this._当浮游炮瞄准可以自动开炮时 = new 当浮游炮瞄准可以自动开炮时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当浮游炮瞄准可以自动开炮时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当浮游炮瞄准可以自动开炮时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x0601D4F8 RID: 120056 RVA: 0x008F0D80 File Offset: 0x008EEF80
		// (set) Token: 0x0601D4F9 RID: 120057 RVA: 0x008F0DB9 File Offset: 0x008EEFB9
		public 音乐节拍事件触发时 音乐节拍事件触发时
		{
			get
			{
				base.FastCheckIsValid();
				音乐节拍事件触发时 result;
				if ((result = this._音乐节拍事件触发时) == null)
				{
					result = (this._音乐节拍事件触发时 = new 音乐节拍事件触发时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_音乐节拍事件触发时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_音乐节拍事件触发时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0601D4FA RID: 120058 RVA: 0x008F0DDC File Offset: 0x008EEFDC
		// (set) Token: 0x0601D4FB RID: 120059 RVA: 0x008F0E15 File Offset: 0x008EF015
		public 当触发结算镜头时 当触发结算镜头时
		{
			get
			{
				base.FastCheckIsValid();
				当触发结算镜头时 result;
				if ((result = this._当触发结算镜头时) == null)
				{
					result = (this._当触发结算镜头时 = new 当触发结算镜头时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当触发结算镜头时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当触发结算镜头时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0601D4FC RID: 120060 RVA: 0x008F0E38 File Offset: 0x008EF038
		// (set) Token: 0x0601D4FD RID: 120061 RVA: 0x008F0E71 File Offset: 0x008EF071
		public 当触发相机注视时 当触发相机注视时
		{
			get
			{
				base.FastCheckIsValid();
				当触发相机注视时 result;
				if ((result = this._当触发相机注视时) == null)
				{
					result = (this._当触发相机注视时 = new 当触发相机注视时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当触发相机注视时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_当触发相机注视时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x0601D4FE RID: 120062 RVA: 0x008F0E94 File Offset: 0x008EF094
		// (set) Token: 0x0601D4FF RID: 120063 RVA: 0x008F0ECD File Offset: 0x008EF0CD
		public 演出状态改变时 演出状态改变时
		{
			get
			{
				base.FastCheckIsValid();
				演出状态改变时 result;
				if ((result = this._演出状态改变时) == null)
				{
					result = (this._演出状态改变时 = new 演出状态改变时(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_演出状态改变时, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_演出状态改变时, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x0601D500 RID: 120064 RVA: 0x008F0EF0 File Offset: 0x008EF0F0
		// (set) Token: 0x0601D501 RID: 120065 RVA: 0x008F0F29 File Offset: 0x008EF129
		public 触发NPC脚印事件 触发NPC脚印事件
		{
			get
			{
				base.FastCheckIsValid();
				触发NPC脚印事件 result;
				if ((result = this._触发NPC脚印事件) == null)
				{
					result = (this._触发NPC脚印事件 = new 触发NPC脚印事件(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_触发NPC脚印事件, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_EventManager_C.__PropertyOffset_触发NPC脚印事件, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601D502 RID: 120066 RVA: 0x008F0F4A File Offset: 0x008EF14A
		protected BP_EventManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F6C5 RID: 63173
		public new const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C";

		// Token: 0x0400F6C6 RID: 63174
		private static IntPtr _ClassPtr;

		// Token: 0x0400F6C7 RID: 63175
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F6C8 RID: 63176
		public static IntPtr __触发NPC脚印事件__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6C9 RID: 63177
		public static IntPtr __演出状态改变时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6CA RID: 63178
		public static IntPtr __当触发相机注视时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6CB RID: 63179
		public static IntPtr __当触发结算镜头时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6CC RID: 63180
		public static IntPtr __音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6CD RID: 63181
		public static IntPtr __当浮游炮瞄准可以自动开炮时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6CE RID: 63182
		public static IntPtr __武器交互场景时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6CF RID: 63183
		public static IntPtr __当有角色复活时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D0 RID: 63184
		public static IntPtr __子弹撞到水面时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D1 RID: 63185
		public static IntPtr __当捕鱼船创建时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D2 RID: 63186
		public static IntPtr __停止吸取污染物__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D3 RID: 63187
		public static IntPtr __开始吸取污染物__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D4 RID: 63188
		public static IntPtr __被控物撞到水面时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D5 RID: 63189
		public static IntPtr __OnExitPhotograph__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D6 RID: 63190
		public static IntPtr __OnEnterPhotograph__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D7 RID: 63191
		public static IntPtr __当编队更新时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D8 RID: 63192
		public static IntPtr __材质播放结束时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6D9 RID: 63193
		public static IntPtr __抓取目标成功时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6DA RID: 63194
		public static IntPtr __小队技能目标改变时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6DB RID: 63195
		public static IntPtr __小队战斗状态改变时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6DC RID: 63196
		public static IntPtr __当有角色死亡时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6DD RID: 63197
		public static IntPtr __当触发对策事件时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6DE RID: 63198
		public static IntPtr __角色状态切换时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6DF RID: 63199
		public static IntPtr __CaughtEntity__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E0 RID: 63200
		public static IntPtr __被控物广播__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E1 RID: 63201
		public static IntPtr __AI巡逻达到样条点__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E2 RID: 63202
		public static IntPtr __角色部位弱点打击时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E3 RID: 63203
		public static IntPtr __角色部位血量变化时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E4 RID: 63204
		public static IntPtr __子弹命中前__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E5 RID: 63205
		public static IntPtr __当换人完成时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E6 RID: 63206
		public static IntPtr __增加实体__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E7 RID: 63207
		public static IntPtr __WorldDoneNotify__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E8 RID: 63208
		public static IntPtr __删除实体__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6E9 RID: 63209
		public static IntPtr __当解密界面打开时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6EA RID: 63210
		public static IntPtr __当有角色受击时__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6EB RID: 63211
		public static IntPtr __界面生命周期改变__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F6EC RID: 63212
		internal static int __PropertyOffset_界面生命周期改变;

		// Token: 0x0400F6ED RID: 63213
		[Nullable(2)]
		private 界面生命周期改变 _界面生命周期改变;

		// Token: 0x0400F6EE RID: 63214
		internal static int __PropertyOffset_当有角色受击时;

		// Token: 0x0400F6EF RID: 63215
		[Nullable(2)]
		private 当有角色受击时 _当有角色受击时;

		// Token: 0x0400F6F0 RID: 63216
		internal static int __PropertyOffset_当解密界面打开时;

		// Token: 0x0400F6F1 RID: 63217
		[Nullable(2)]
		private 当解密界面打开时 _当解密界面打开时;

		// Token: 0x0400F6F2 RID: 63218
		internal static int __PropertyOffset_删除实体;

		// Token: 0x0400F6F3 RID: 63219
		[Nullable(2)]
		private 删除实体 _删除实体;

		// Token: 0x0400F6F4 RID: 63220
		internal static int __PropertyOffset_WorldDoneNotify;

		// Token: 0x0400F6F5 RID: 63221
		[Nullable(2)]
		private WorldDoneNotify _WorldDoneNotify;

		// Token: 0x0400F6F6 RID: 63222
		internal static int __PropertyOffset_增加实体;

		// Token: 0x0400F6F7 RID: 63223
		[Nullable(2)]
		private 增加实体 _增加实体;

		// Token: 0x0400F6F8 RID: 63224
		internal static int __PropertyOffset_当换人完成时;

		// Token: 0x0400F6F9 RID: 63225
		[Nullable(2)]
		private 当换人完成时 _当换人完成时;

		// Token: 0x0400F6FA RID: 63226
		internal static int __PropertyOffset_子弹命中前;

		// Token: 0x0400F6FB RID: 63227
		[Nullable(2)]
		private 子弹命中前 _子弹命中前;

		// Token: 0x0400F6FC RID: 63228
		internal static int __PropertyOffset_角色部位血量变化时;

		// Token: 0x0400F6FD RID: 63229
		[Nullable(2)]
		private 角色部位血量变化时 _角色部位血量变化时;

		// Token: 0x0400F6FE RID: 63230
		internal static int __PropertyOffset_角色部位弱点打击时;

		// Token: 0x0400F6FF RID: 63231
		[Nullable(2)]
		private 角色部位弱点打击时 _角色部位弱点打击时;

		// Token: 0x0400F700 RID: 63232
		internal static int __PropertyOffset_AI巡逻达到样条点;

		// Token: 0x0400F701 RID: 63233
		[Nullable(2)]
		private AI巡逻达到样条点 _AI巡逻达到样条点;

		// Token: 0x0400F702 RID: 63234
		internal static int __PropertyOffset_被控物广播;

		// Token: 0x0400F703 RID: 63235
		[Nullable(2)]
		private 被控物广播 _被控物广播;

		// Token: 0x0400F704 RID: 63236
		internal static int __PropertyOffset_CaughtEntity;

		// Token: 0x0400F705 RID: 63237
		[Nullable(2)]
		private CaughtEntity _CaughtEntity;

		// Token: 0x0400F706 RID: 63238
		internal static int __PropertyOffset_角色状态切换时;

		// Token: 0x0400F707 RID: 63239
		[Nullable(2)]
		private 角色状态切换时 _角色状态切换时;

		// Token: 0x0400F708 RID: 63240
		internal static int __PropertyOffset_当触发对策事件时;

		// Token: 0x0400F709 RID: 63241
		[Nullable(2)]
		private 当触发对策事件时 _当触发对策事件时;

		// Token: 0x0400F70A RID: 63242
		internal static int __PropertyOffset_当有角色死亡时;

		// Token: 0x0400F70B RID: 63243
		[Nullable(2)]
		private 当有角色死亡时 _当有角色死亡时;

		// Token: 0x0400F70C RID: 63244
		internal static int __PropertyOffset_小队战斗状态改变时;

		// Token: 0x0400F70D RID: 63245
		[Nullable(2)]
		private 小队战斗状态改变时 _小队战斗状态改变时;

		// Token: 0x0400F70E RID: 63246
		internal static int __PropertyOffset_小队技能目标改变时;

		// Token: 0x0400F70F RID: 63247
		[Nullable(2)]
		private 小队技能目标改变时 _小队技能目标改变时;

		// Token: 0x0400F710 RID: 63248
		internal static int __PropertyOffset_抓取目标成功时;

		// Token: 0x0400F711 RID: 63249
		[Nullable(2)]
		private 抓取目标成功时 _抓取目标成功时;

		// Token: 0x0400F712 RID: 63250
		internal static int __PropertyOffset_材质播放结束时;

		// Token: 0x0400F713 RID: 63251
		[Nullable(2)]
		private 材质播放结束时 _材质播放结束时;

		// Token: 0x0400F714 RID: 63252
		internal static int __PropertyOffset_当编队更新时;

		// Token: 0x0400F715 RID: 63253
		[Nullable(2)]
		private 当编队更新时 _当编队更新时;

		// Token: 0x0400F716 RID: 63254
		internal static int __PropertyOffset_OnEnterPhotograph;

		// Token: 0x0400F717 RID: 63255
		[Nullable(2)]
		private OnEnterPhotograph _OnEnterPhotograph;

		// Token: 0x0400F718 RID: 63256
		internal static int __PropertyOffset_OnExitPhotograph;

		// Token: 0x0400F719 RID: 63257
		[Nullable(2)]
		private OnExitPhotograph _OnExitPhotograph;

		// Token: 0x0400F71A RID: 63258
		internal static int __PropertyOffset_被控物撞到水面时;

		// Token: 0x0400F71B RID: 63259
		[Nullable(2)]
		private 被控物撞到水面时 _被控物撞到水面时;

		// Token: 0x0400F71C RID: 63260
		internal static int __PropertyOffset_开始吸取污染物;

		// Token: 0x0400F71D RID: 63261
		[Nullable(2)]
		private 开始吸取污染物 _开始吸取污染物;

		// Token: 0x0400F71E RID: 63262
		internal static int __PropertyOffset_停止吸取污染物;

		// Token: 0x0400F71F RID: 63263
		[Nullable(2)]
		private 停止吸取污染物 _停止吸取污染物;

		// Token: 0x0400F720 RID: 63264
		internal static int __PropertyOffset_当捕鱼船创建时;

		// Token: 0x0400F721 RID: 63265
		[Nullable(2)]
		private 当捕鱼船创建时 _当捕鱼船创建时;

		// Token: 0x0400F722 RID: 63266
		internal static int __PropertyOffset_子弹撞到水面时;

		// Token: 0x0400F723 RID: 63267
		[Nullable(2)]
		private 子弹撞到水面时 _子弹撞到水面时;

		// Token: 0x0400F724 RID: 63268
		internal static int __PropertyOffset_当有角色复活时;

		// Token: 0x0400F725 RID: 63269
		[Nullable(2)]
		private 当有角色复活时 _当有角色复活时;

		// Token: 0x0400F726 RID: 63270
		internal static int __PropertyOffset_武器交互场景时;

		// Token: 0x0400F727 RID: 63271
		[Nullable(2)]
		private 武器交互场景时 _武器交互场景时;

		// Token: 0x0400F728 RID: 63272
		internal static int __PropertyOffset_当浮游炮瞄准可以自动开炮时;

		// Token: 0x0400F729 RID: 63273
		[Nullable(2)]
		private 当浮游炮瞄准可以自动开炮时 _当浮游炮瞄准可以自动开炮时;

		// Token: 0x0400F72A RID: 63274
		internal static int __PropertyOffset_音乐节拍事件触发时;

		// Token: 0x0400F72B RID: 63275
		[Nullable(2)]
		private 音乐节拍事件触发时 _音乐节拍事件触发时;

		// Token: 0x0400F72C RID: 63276
		internal static int __PropertyOffset_当触发结算镜头时;

		// Token: 0x0400F72D RID: 63277
		[Nullable(2)]
		private 当触发结算镜头时 _当触发结算镜头时;

		// Token: 0x0400F72E RID: 63278
		internal static int __PropertyOffset_当触发相机注视时;

		// Token: 0x0400F72F RID: 63279
		[Nullable(2)]
		private 当触发相机注视时 _当触发相机注视时;

		// Token: 0x0400F730 RID: 63280
		internal static int __PropertyOffset_演出状态改变时;

		// Token: 0x0400F731 RID: 63281
		[Nullable(2)]
		private 演出状态改变时 _演出状态改变时;

		// Token: 0x0400F732 RID: 63282
		internal static int __PropertyOffset_触发NPC脚印事件;

		// Token: 0x0400F733 RID: 63283
		[Nullable(2)]
		private 触发NPC脚印事件 _触发NPC脚印事件;
	}
}
