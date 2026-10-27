using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014BC RID: 5308
	[NullableContext(1)]
	[Nullable(0)]
	public class CallByCondition : ActionParams
	{
		// Token: 0x060078D0 RID: 30928 RVA: 0x001216CC File Offset: 0x0011F8CC
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

		// Token: 0x060078D1 RID: 30929 RVA: 0x00121704 File Offset: 0x0011F904
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

		// Token: 0x060078D2 RID: 30930 RVA: 0x00121717 File Offset: 0x0011F917
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

		// Token: 0x060078D3 RID: 30931 RVA: 0x0012172A File Offset: 0x0011F92A
		public CallByCondition_SetValue ToSetValue()
		{
			return new CallByCondition_SetValue
			{
				Conditions = this.Conditions,
				TrueActions = this.TrueActions,
				FalseActions = this.FalseActions
			};
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x060078D4 RID: 30932 RVA: 0x00121758 File Offset: 0x0011F958
		// (set) Token: 0x060078D5 RID: 30933 RVA: 0x001217B9 File Offset: 0x0011F9B9
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

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x060078D6 RID: 30934 RVA: 0x001217D0 File Offset: 0x0011F9D0
		// (set) Token: 0x060078D7 RID: 30935 RVA: 0x00121863 File Offset: 0x0011FA63
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> TrueActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().TrueActions = value;
				this._TrueActionsInited = false;
			}
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x060078D8 RID: 30936 RVA: 0x00121878 File Offset: 0x0011FA78
		// (set) Token: 0x060078D9 RID: 30937 RVA: 0x0012190B File Offset: 0x0011FB0B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> FalseActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().FalseActions = value;
				this._FalseActionsInited = false;
			}
		}

		// Token: 0x04004629 RID: 17961
		[Nullable(2)]
		protected new CallByCondition FbInstance;

		// Token: 0x0400462A RID: 17962
		[Nullable(2)]
		protected CallByCondition_SetValue PocoInterface;

		// Token: 0x0400462B RID: 17963
		private IConditions _ConditionsCache;

		// Token: 0x0400462C RID: 17964
		private bool _ConditionsInited;

		// Token: 0x0400462D RID: 17965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _TrueActionsCache;

		// Token: 0x0400462E RID: 17966
		private bool _TrueActionsInited;

		// Token: 0x0400462F RID: 17967
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FalseActionsCache;

		// Token: 0x04004630 RID: 17968
		private bool _FalseActionsInited;
	}
}
