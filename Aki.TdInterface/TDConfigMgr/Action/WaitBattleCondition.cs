using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024EC RID: 9452
	public class WaitBattleCondition : ActionParams
	{
		// Token: 0x0600CD80 RID: 52608 RVA: 0x001D3E88 File Offset: 0x001D2088
		private WaitBattleCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("WaitBattleCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			WaitBattleCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new WaitBattleCondition_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD81 RID: 52609 RVA: 0x001D3EC0 File Offset: 0x001D20C0
		public static WaitBattleCondition Create([Nullable(2)] WaitBattleCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WaitBattleCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD82 RID: 52610 RVA: 0x001D3ED3 File Offset: 0x001D20D3
		public static WaitBattleCondition CreateFromSetValue([Nullable(2)] WaitBattleCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new WaitBattleCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD83 RID: 52611 RVA: 0x001D3EE6 File Offset: 0x001D20E6
		public WaitBattleCondition_SetValue ToSetValue()
		{
			return new WaitBattleCondition_SetValue
			{
				StateOption = this.StateOption
			};
		}

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x0600CD84 RID: 52612 RVA: 0x001D3EFC File Offset: 0x001D20FC
		// (set) Token: 0x0600CD85 RID: 52613 RVA: 0x001D3F5D File Offset: 0x001D215D
		public virtual IDetectBattleTag StateOption
		{
			get
			{
				if (this._StateOptionInited)
				{
					return this._StateOptionCache;
				}
				this._StateOptionInited = true;
				if (this.FbInstance != null)
				{
					this._StateOptionCache = IDetectBattleTag.Create(this.FbInstance.StateOption);
				}
				else
				{
					WaitBattleCondition_SetValue pocoInterface = this.PocoInterface;
					this._StateOptionCache = ((pocoInterface != null) ? pocoInterface.StateOption : null);
				}
				return this._StateOptionCache;
			}
			set
			{
				this.GetOrCreatePoco().StateOption = value;
				this._StateOptionInited = false;
			}
		}

		// Token: 0x040079B0 RID: 31152
		[Nullable(2)]
		protected new WaitBattleCondition FbInstance;

		// Token: 0x040079B1 RID: 31153
		[Nullable(2)]
		protected WaitBattleCondition_SetValue PocoInterface;

		// Token: 0x040079B2 RID: 31154
		private IDetectBattleTag _StateOptionCache;

		// Token: 0x040079B3 RID: 31155
		private bool _StateOptionInited;
	}
}
