using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF8 RID: 8184
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerActions
	{
		// Token: 0x0600B3FE RID: 46078 RVA: 0x001A2B84 File Offset: 0x001A0D84
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

		// Token: 0x0600B3FF RID: 46079 RVA: 0x001A2BBC File Offset: 0x001A0DBC
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

		// Token: 0x0600B400 RID: 46080 RVA: 0x001A2BCF File Offset: 0x001A0DCF
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

		// Token: 0x0600B401 RID: 46081 RVA: 0x001A2BE2 File Offset: 0x001A0DE2
		public ITriggerActions_SetValue ToSetValue()
		{
			return new ITriggerActions_SetValue
			{
				Actions = this.Actions
			};
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600B402 RID: 46082 RVA: 0x001A2BF8 File Offset: 0x001A0DF8
		// (set) Token: 0x0600B403 RID: 46083 RVA: 0x001A2C8B File Offset: 0x001A0E8B
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

		// Token: 0x04006C84 RID: 27780
		[Nullable(2)]
		protected ITriggerActions FbInstance;

		// Token: 0x04006C85 RID: 27781
		[Nullable(2)]
		protected ITriggerActions_SetValue PocoInterface;

		// Token: 0x04006C86 RID: 27782
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006C87 RID: 27783
		private bool _ActionsInited;
	}
}
