using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C68 RID: 7272
	public class IFunction
	{
		// Token: 0x06009AA2 RID: 39586 RVA: 0x00165C00 File Offset: 0x00163E00
		private IFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFunction_SetValue());
			}
			return result;
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x00165C38 File Offset: 0x00163E38
		public static IFunction Create([Nullable(2)] IFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AA4 RID: 39588 RVA: 0x00165C4B File Offset: 0x00163E4B
		public static IFunction CreateFromSetValue([Nullable(2)] IFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x00165C5E File Offset: 0x00163E5E
		public IFunction_SetValue ToSetValue()
		{
			return new IFunction_SetValue
			{
				Name = this.Name,
				Actions = this.Actions
			};
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x06009AA6 RID: 39590 RVA: 0x00165C7D File Offset: 0x00163E7D
		// (set) Token: 0x06009AA7 RID: 39591 RVA: 0x00165CA8 File Offset: 0x00163EA8
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x06009AA8 RID: 39592 RVA: 0x00165CB8 File Offset: 0x00163EB8
		// (set) Token: 0x06009AA9 RID: 39593 RVA: 0x00165D4B File Offset: 0x00163F4B
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
					IFunction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005EE9 RID: 24297
		[Nullable(2)]
		protected IFunction FbInstance;

		// Token: 0x04005EEA RID: 24298
		[Nullable(2)]
		protected IFunction_SetValue PocoInterface;

		// Token: 0x04005EEB RID: 24299
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04005EEC RID: 24300
		private bool _ActionsInited;
	}
}
