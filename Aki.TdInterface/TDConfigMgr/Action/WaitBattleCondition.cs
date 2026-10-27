using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200227F RID: 8831
	[NullableContext(1)]
	[Nullable(0)]
	public class WaitBattleCondition : ActionParams
	{
		// Token: 0x0600C1BA RID: 49594 RVA: 0x001BC704 File Offset: 0x001BA904
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

		// Token: 0x0600C1BB RID: 49595 RVA: 0x001BC73C File Offset: 0x001BA93C
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

		// Token: 0x0600C1BC RID: 49596 RVA: 0x001BC74F File Offset: 0x001BA94F
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

		// Token: 0x0600C1BD RID: 49597 RVA: 0x001BC762 File Offset: 0x001BA962
		public WaitBattleCondition_SetValue ToSetValue()
		{
			return new WaitBattleCondition_SetValue
			{
				StateOption = this.StateOption
			};
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0600C1BE RID: 49598 RVA: 0x001BC778 File Offset: 0x001BA978
		// (set) Token: 0x0600C1BF RID: 49599 RVA: 0x001BC7D9 File Offset: 0x001BA9D9
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

		// Token: 0x04007363 RID: 29539
		[Nullable(2)]
		protected new WaitBattleCondition FbInstance;

		// Token: 0x04007364 RID: 29540
		[Nullable(2)]
		protected WaitBattleCondition_SetValue PocoInterface;

		// Token: 0x04007365 RID: 29541
		private IDetectBattleTag _StateOptionCache;

		// Token: 0x04007366 RID: 29542
		private bool _StateOptionInited;
	}
}
