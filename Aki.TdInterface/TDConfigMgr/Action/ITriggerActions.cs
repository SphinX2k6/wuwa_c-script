using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200223F RID: 8767
	public class ITriggerActions
	{
		// Token: 0x0600BF14 RID: 48916 RVA: 0x001B90F0 File Offset: 0x001B72F0
		private ITriggerActions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerActions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerActions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerActions_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF15 RID: 48917 RVA: 0x001B9128 File Offset: 0x001B7328
		public static ITriggerActions Create([Nullable(2)] ITriggerActions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerActions
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF16 RID: 48918 RVA: 0x001B913B File Offset: 0x001B733B
		public static ITriggerActions CreateFromSetValue([Nullable(2)] ITriggerActions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerActions
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF17 RID: 48919 RVA: 0x001B914E File Offset: 0x001B734E
		public ITriggerActions_SetValue ToSetValue()
		{
			return new ITriggerActions_SetValue
			{
				Actions = this.Actions
			};
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x0600BF18 RID: 48920 RVA: 0x001B9164 File Offset: 0x001B7364
		// (set) Token: 0x0600BF19 RID: 48921 RVA: 0x001B91F7 File Offset: 0x001B73F7
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
					ITriggerActions_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04007286 RID: 29318
		[Nullable(2)]
		protected ITriggerActions FbInstance;

		// Token: 0x04007287 RID: 29319
		[Nullable(2)]
		protected ITriggerActions_SetValue PocoInterface;

		// Token: 0x04007288 RID: 29320
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04007289 RID: 29321
		private bool _ActionsInited;
	}
}
