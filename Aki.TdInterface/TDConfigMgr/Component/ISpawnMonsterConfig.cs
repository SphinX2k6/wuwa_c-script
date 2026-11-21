using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000787 RID: 1927
	public class ISpawnMonsterConfig
	{
		// Token: 0x06002928 RID: 10536 RVA: 0x0006D1B8 File Offset: 0x0006B3B8
		private ISpawnMonsterConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0006D1F0 File Offset: 0x0006B3F0
		public static ISpawnMonsterConfig Create([Nullable(2)] ISpawnMonsterConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0006D203 File Offset: 0x0006B403
		public static ISpawnMonsterConfig CreateFromSetValue([Nullable(2)] ISpawnMonsterConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0006D218 File Offset: 0x0006B418
		public ISpawnMonsterConfig_SetValue ToSetValue()
		{
			return new ISpawnMonsterConfig_SetValue
			{
				Id = this.Id,
				DelayTime = this.DelayTime,
				TargetsToAwake = this.TargetsToAwake,
				CompleteCondition = this.CompleteCondition,
				PreCondition = this.PreCondition
			};
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x0006D266 File Offset: 0x0006B466
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x0006D291 File Offset: 0x0006B491
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

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x0006D29F File Offset: 0x0006B49F
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x0006D2CE File Offset: 0x0006B4CE
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

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x0006D2DC File Offset: 0x0006B4DC
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x0006D303 File Offset: 0x0006B503
		[Nullable(2)]
		public virtual List<int> TargetsToAwake
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetsToAwake;
				}
				ISpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetsToAwake;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TargetsToAwake = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x0006D311 File Offset: 0x0006B511
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x0006D338 File Offset: 0x0006B538
		public virtual ISpawnMonsterCompleteCondition CompleteCondition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CompleteCondition;
				}
				ISpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x0006D348 File Offset: 0x0006B548
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x0006D3A9 File Offset: 0x0006B5A9
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
					ISpawnMonsterConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001BE1 RID: 7137
		[Nullable(2)]
		protected ISpawnMonsterConfig FbInstance;

		// Token: 0x04001BE2 RID: 7138
		[Nullable(2)]
		protected ISpawnMonsterConfig_SetValue PocoInterface;

		// Token: 0x04001BE3 RID: 7139
		private ISpawnMonsterPreDependOnPreceding _PreConditionCache;

		// Token: 0x04001BE4 RID: 7140
		private bool _PreConditionInited;
	}
}
