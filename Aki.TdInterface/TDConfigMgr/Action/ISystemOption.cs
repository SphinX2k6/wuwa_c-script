using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F11 RID: 7953
	[NullableContext(1)]
	[Nullable(0)]
	public class ISystemOption
	{
		// Token: 0x0600AA12 RID: 43538 RVA: 0x0017F16C File Offset: 0x0017D36C
		private ISystemOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISystemOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISystemOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISystemOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x0017F1A4 File Offset: 0x0017D3A4
		public static ISystemOption Create([Nullable(2)] ISystemOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x0017F1B7 File Offset: 0x0017D3B7
		public static ISystemOption CreateFromSetValue([Nullable(2)] ISystemOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISystemOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x0017F1CA File Offset: 0x0017D3CA
		public ISystemOption_SetValue ToSetValue()
		{
			return new ISystemOption_SetValue
			{
				OptionId = this.OptionId,
				Actions = this.Actions
			};
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600AA16 RID: 43542 RVA: 0x0017F1EC File Offset: 0x0017D3EC
		// (set) Token: 0x0600AA17 RID: 43543 RVA: 0x0017F226 File Offset: 0x0017D426
		public virtual int? OptionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionId;
				}
				ISystemOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionId;
			}
			set
			{
				this.GetOrCreatePoco().OptionId = value;
			}
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600AA18 RID: 43544 RVA: 0x0017F234 File Offset: 0x0017D434
		// (set) Token: 0x0600AA19 RID: 43545 RVA: 0x0017F2C7 File Offset: 0x0017D4C7
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
					ISystemOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006510 RID: 25872
		[Nullable(2)]
		protected ISystemOption FbInstance;

		// Token: 0x04006511 RID: 25873
		[Nullable(2)]
		protected ISystemOption_SetValue PocoInterface;

		// Token: 0x04006512 RID: 25874
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006513 RID: 25875
		private bool _ActionsInited;
	}
}
