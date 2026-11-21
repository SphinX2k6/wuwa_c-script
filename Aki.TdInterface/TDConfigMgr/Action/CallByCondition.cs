using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001615 RID: 5653
	public class CallByCondition : ActionParams
	{
		// Token: 0x06007F9D RID: 32669 RVA: 0x00130318 File Offset: 0x0012E518
		private CallByCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CallByCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CallByCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CallByCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06007F9E RID: 32670 RVA: 0x00130350 File Offset: 0x0012E550
		public static CallByCondition Create([Nullable(2)] CallByCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CallByCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x00130363 File Offset: 0x0012E563
		public static CallByCondition CreateFromSetValue([Nullable(2)] CallByCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CallByCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x00130376 File Offset: 0x0012E576
		public CallByCondition_SetValue ToSetValue()
		{
			return new CallByCondition_SetValue
			{
				Conditions = this.Conditions,
				TrueActions = this.TrueActions,
				FalseActions = this.FalseActions
			};
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x06007FA1 RID: 32673 RVA: 0x001303A4 File Offset: 0x0012E5A4
		// (set) Token: 0x06007FA2 RID: 32674 RVA: 0x00130405 File Offset: 0x0012E605
		public virtual IConditions Conditions
		{
			get
			{
				if (this._ConditionsInited)
				{
					return this._ConditionsCache;
				}
				this._ConditionsInited = true;
				if (this.FbInstance != null)
				{
					this._ConditionsCache = IConditions.Create(this.FbInstance.Conditions);
				}
				else
				{
					CallByCondition_SetValue pocoInterface = this.PocoInterface;
					this._ConditionsCache = ((pocoInterface != null) ? pocoInterface.Conditions : null);
				}
				return this._ConditionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Conditions = value;
				this._ConditionsInited = false;
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x06007FA3 RID: 32675 RVA: 0x0013041C File Offset: 0x0012E61C
		// (set) Token: 0x06007FA4 RID: 32676 RVA: 0x001304AF File Offset: 0x0012E6AF
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> TrueActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._TrueActionsInited)
				{
					return this._TrueActionsCache;
				}
				this._TrueActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> trueActions = this.FbInstance.TrueActions;
					if (trueActions != null)
					{
						this._TrueActionsCache = new List<ActionInfo>(trueActions.Count);
						for (int i = 0; i < trueActions.Count; i++)
						{
							this._TrueActionsCache.Add(ActionInfo.Create(trueActions[i]));
						}
					}
				}
				else
				{
					CallByCondition_SetValue pocoInterface = this.PocoInterface;
					this._TrueActionsCache = ((pocoInterface != null) ? pocoInterface.TrueActions : null);
				}
				return this._TrueActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().TrueActions = value;
				this._TrueActionsInited = false;
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x06007FA5 RID: 32677 RVA: 0x001304C4 File Offset: 0x0012E6C4
		// (set) Token: 0x06007FA6 RID: 32678 RVA: 0x00130557 File Offset: 0x0012E757
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> FalseActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._FalseActionsInited)
				{
					return this._FalseActionsCache;
				}
				this._FalseActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> falseActions = this.FbInstance.FalseActions;
					if (falseActions != null)
					{
						this._FalseActionsCache = new List<ActionInfo>(falseActions.Count);
						for (int i = 0; i < falseActions.Count; i++)
						{
							this._FalseActionsCache.Add(ActionInfo.Create(falseActions[i]));
						}
					}
				}
				else
				{
					CallByCondition_SetValue pocoInterface = this.PocoInterface;
					this._FalseActionsCache = ((pocoInterface != null) ? pocoInterface.FalseActions : null);
				}
				return this._FalseActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().FalseActions = value;
				this._FalseActionsInited = false;
			}
		}

		// Token: 0x040049C4 RID: 18884
		[Nullable(2)]
		protected new CallByCondition FbInstance;

		// Token: 0x040049C5 RID: 18885
		[Nullable(2)]
		protected CallByCondition_SetValue PocoInterface;

		// Token: 0x040049C6 RID: 18886
		private IConditions _ConditionsCache;

		// Token: 0x040049C7 RID: 18887
		private bool _ConditionsInited;

		// Token: 0x040049C8 RID: 18888
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _TrueActionsCache;

		// Token: 0x040049C9 RID: 18889
		private bool _TrueActionsInited;

		// Token: 0x040049CA RID: 18890
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FalseActionsCache;

		// Token: 0x040049CB RID: 18891
		private bool _FalseActionsInited;
	}
}
