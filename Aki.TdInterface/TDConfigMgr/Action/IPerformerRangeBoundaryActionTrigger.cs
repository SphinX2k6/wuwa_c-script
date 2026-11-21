using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EDD RID: 7901
	public class IPerformerRangeBoundaryActionTrigger
	{
		// Token: 0x0600A829 RID: 43049 RVA: 0x0017E324 File Offset: 0x0017C524
		private IPerformerRangeBoundaryActionTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPerformerRangeBoundaryActionTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPerformerRangeBoundaryActionTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPerformerRangeBoundaryActionTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x0600A82A RID: 43050 RVA: 0x0017E35C File Offset: 0x0017C55C
		public static IPerformerRangeBoundaryActionTrigger Create([Nullable(2)] IPerformerRangeBoundaryActionTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPerformerRangeBoundaryActionTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x0017E36F File Offset: 0x0017C56F
		public static IPerformerRangeBoundaryActionTrigger CreateFromSetValue([Nullable(2)] IPerformerRangeBoundaryActionTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPerformerRangeBoundaryActionTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A82C RID: 43052 RVA: 0x0017E382 File Offset: 0x0017C582
		public IPerformerRangeBoundaryActionTrigger_SetValue ToSetValue()
		{
			return new IPerformerRangeBoundaryActionTrigger_SetValue
			{
				Range = this.Range,
				Actions = this.Actions
			};
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600A82D RID: 43053 RVA: 0x0017E3A1 File Offset: 0x0017C5A1
		// (set) Token: 0x0600A82E RID: 43054 RVA: 0x0017E3CC File Offset: 0x0017C5CC
		public virtual int Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600A82F RID: 43055 RVA: 0x0017E3DC File Offset: 0x0017C5DC
		// (set) Token: 0x0600A830 RID: 43056 RVA: 0x0017E46F File Offset: 0x0017C66F
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IPerformerRangeBoundaryActionTrigger_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04006520 RID: 25888
		[Nullable(2)]
		protected IPerformerRangeBoundaryActionTrigger FbInstance;

		// Token: 0x04006521 RID: 25889
		[Nullable(2)]
		protected IPerformerRangeBoundaryActionTrigger_SetValue PocoInterface;

		// Token: 0x04006522 RID: 25890
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006523 RID: 25891
		private bool _ActionsInited;
	}
}
