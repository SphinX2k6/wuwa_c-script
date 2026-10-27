using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002ED RID: 749
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicSpawnMonsterConfig
	{
		// Token: 0x06000E69 RID: 3689 RVA: 0x00034418 File Offset: 0x00032618
		private IDynamicSpawnMonsterConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicSpawnMonsterConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicSpawnMonsterConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicSpawnMonsterConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00034450 File Offset: 0x00032650
		public static IDynamicSpawnMonsterConfig Create([Nullable(2)] IDynamicSpawnMonsterConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicSpawnMonsterConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00034463 File Offset: 0x00032663
		public static IDynamicSpawnMonsterConfig CreateFromSetValue([Nullable(2)] IDynamicSpawnMonsterConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicSpawnMonsterConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00034478 File Offset: 0x00032678
		public IDynamicSpawnMonsterConfig_SetValue ToSetValue()
		{
			return new IDynamicSpawnMonsterConfig_SetValue
			{
				Id = this.Id,
				DelayTime = this.DelayTime,
				CompleteCondition = this.CompleteCondition,
				PreCondition = this.PreCondition,
				Interval = this.Interval,
				MonsterChooseType = this.MonsterChooseType,
				PointChooseType = this.PointChooseType
			};
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000344DE File Offset: 0x000326DE
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00034509 File Offset: 0x00032709
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00034517 File Offset: 0x00032717
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00034546 File Offset: 0x00032746
		public virtual float DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00034554 File Offset: 0x00032754
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x0003457B File Offset: 0x0003277B
		public virtual ISpawnMonsterCompleteCondition CompleteCondition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompleteCondition;
				}
				IDynamicSpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CompleteCondition;
			}
			set
			{
				this.GetOrCreatePoco().CompleteCondition = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0003458C File Offset: 0x0003278C
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x000345ED File Offset: 0x000327ED
		public virtual ISpawnMonsterPreDependOnPreceding PreCondition
		{
			get
			{
				if (this._PreConditionInited)
				{
					return this._PreConditionCache;
				}
				this._PreConditionInited = true;
				if (this.FbInstance != null)
				{
					this._PreConditionCache = ISpawnMonsterPreDependOnPreceding.Create(this.FbInstance.PreCondition);
				}
				else
				{
					IDynamicSpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
					this._PreConditionCache = ((pocoInterface != null) ? pocoInterface.PreCondition : null);
				}
				return this._PreConditionCache;
			}
			set
			{
				this.GetOrCreatePoco().PreCondition = value;
				this._PreConditionInited = false;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00034604 File Offset: 0x00032804
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x0003463E File Offset: 0x0003283E
		public virtual float? Interval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Interval;
				}
				IDynamicSpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Interval;
			}
			set
			{
				this.GetOrCreatePoco().Interval = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0003464C File Offset: 0x0003284C
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x000346AD File Offset: 0x000328AD
		public virtual IRandomPoolChoose MonsterChooseType
		{
			get
			{
				if (this._MonsterChooseTypeInited)
				{
					return this._MonsterChooseTypeCache;
				}
				this._MonsterChooseTypeInited = true;
				if (this.FbInstance != null)
				{
					this._MonsterChooseTypeCache = IRandomPoolChoose.Create(this.FbInstance.MonsterChooseType);
				}
				else
				{
					IDynamicSpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
					this._MonsterChooseTypeCache = ((pocoInterface != null) ? pocoInterface.MonsterChooseType : null);
				}
				return this._MonsterChooseTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().MonsterChooseType = value;
				this._MonsterChooseTypeInited = false;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x000346C4 File Offset: 0x000328C4
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x00034725 File Offset: 0x00032925
		public virtual ISpawnMonsterPoint PointChooseType
		{
			get
			{
				if (this._PointChooseTypeInited)
				{
					return this._PointChooseTypeCache;
				}
				this._PointChooseTypeInited = true;
				if (this.FbInstance != null)
				{
					this._PointChooseTypeCache = ISpawnMonsterPoint.Create(this.FbInstance.PointChooseType);
				}
				else
				{
					IDynamicSpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
					this._PointChooseTypeCache = ((pocoInterface != null) ? pocoInterface.PointChooseType : null);
				}
				return this._PointChooseTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().PointChooseType = value;
				this._PointChooseTypeInited = false;
			}
		}

		// Token: 0x04000CC1 RID: 3265
		[Nullable(2)]
		protected IDynamicSpawnMonsterConfig FbInstance;

		// Token: 0x04000CC2 RID: 3266
		[Nullable(2)]
		protected IDynamicSpawnMonsterConfig_SetValue PocoInterface;

		// Token: 0x04000CC3 RID: 3267
		private ISpawnMonsterPreDependOnPreceding _PreConditionCache;

		// Token: 0x04000CC4 RID: 3268
		private bool _PreConditionInited;

		// Token: 0x04000CC5 RID: 3269
		private IRandomPoolChoose _MonsterChooseTypeCache;

		// Token: 0x04000CC6 RID: 3270
		private bool _MonsterChooseTypeInited;

		// Token: 0x04000CC7 RID: 3271
		private ISpawnMonsterPoint _PointChooseTypeCache;

		// Token: 0x04000CC8 RID: 3272
		private bool _PointChooseTypeInited;
	}
}
