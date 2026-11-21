using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000334 RID: 820
	public class IDynamicSpawnMonsterConfig
	{
		// Token: 0x06000F99 RID: 3993 RVA: 0x0003734C File Offset: 0x0003554C
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

		// Token: 0x06000F9A RID: 3994 RVA: 0x00037384 File Offset: 0x00035584
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

		// Token: 0x06000F9B RID: 3995 RVA: 0x00037397 File Offset: 0x00035597
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

		// Token: 0x06000F9C RID: 3996 RVA: 0x000373AC File Offset: 0x000355AC
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

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00037412 File Offset: 0x00035612
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x0003743D File Offset: 0x0003563D
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

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x0003744B File Offset: 0x0003564B
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x0003747A File Offset: 0x0003567A
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

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00037488 File Offset: 0x00035688
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x000374AF File Offset: 0x000356AF
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x000374C0 File Offset: 0x000356C0
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00037521 File Offset: 0x00035721
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

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00037538 File Offset: 0x00035738
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x00037572 File Offset: 0x00035772
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

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00037580 File Offset: 0x00035780
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x000375E1 File Offset: 0x000357E1
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

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x000375F8 File Offset: 0x000357F8
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00037659 File Offset: 0x00035859
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

		// Token: 0x04000DAB RID: 3499
		[Nullable(2)]
		protected IDynamicSpawnMonsterConfig FbInstance;

		// Token: 0x04000DAC RID: 3500
		[Nullable(2)]
		protected IDynamicSpawnMonsterConfig_SetValue PocoInterface;

		// Token: 0x04000DAD RID: 3501
		private ISpawnMonsterPreDependOnPreceding _PreConditionCache;

		// Token: 0x04000DAE RID: 3502
		private bool _PreConditionInited;

		// Token: 0x04000DAF RID: 3503
		private IRandomPoolChoose _MonsterChooseTypeCache;

		// Token: 0x04000DB0 RID: 3504
		private bool _MonsterChooseTypeInited;

		// Token: 0x04000DB1 RID: 3505
		private ISpawnMonsterPoint _PointChooseTypeCache;

		// Token: 0x04000DB2 RID: 3506
		private bool _PointChooseTypeInited;
	}
}
