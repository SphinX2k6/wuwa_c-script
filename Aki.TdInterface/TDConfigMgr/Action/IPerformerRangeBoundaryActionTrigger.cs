using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CD6 RID: 7382
	[NullableContext(1)]
	[Nullable(0)]
	public class IPerformerRangeBoundaryActionTrigger
	{
		// Token: 0x06009E7B RID: 40571 RVA: 0x0016A6C4 File Offset: 0x001688C4
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

		// Token: 0x06009E7C RID: 40572 RVA: 0x0016A6FC File Offset: 0x001688FC
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

		// Token: 0x06009E7D RID: 40573 RVA: 0x0016A70F File Offset: 0x0016890F
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

		// Token: 0x06009E7E RID: 40574 RVA: 0x0016A722 File Offset: 0x00168922
		public IPerformerRangeBoundaryActionTrigger_SetValue ToSetValue()
		{
			return new IPerformerRangeBoundaryActionTrigger_SetValue
			{
				Range = this.Range,
				Actions = this.Actions
			};
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x06009E7F RID: 40575 RVA: 0x0016A741 File Offset: 0x00168941
		// (set) Token: 0x06009E80 RID: 40576 RVA: 0x0016A76C File Offset: 0x0016896C
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

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x06009E81 RID: 40577 RVA: 0x0016A77C File Offset: 0x0016897C
		// (set) Token: 0x06009E82 RID: 40578 RVA: 0x0016A80F File Offset: 0x00168A0F
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

		// Token: 0x04005FC4 RID: 24516
		[Nullable(2)]
		protected IPerformerRangeBoundaryActionTrigger FbInstance;

		// Token: 0x04005FC5 RID: 24517
		[Nullable(2)]
		protected IPerformerRangeBoundaryActionTrigger_SetValue PocoInterface;

		// Token: 0x04005FC6 RID: 24518
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04005FC7 RID: 24519
		private bool _ActionsInited;
	}
}
