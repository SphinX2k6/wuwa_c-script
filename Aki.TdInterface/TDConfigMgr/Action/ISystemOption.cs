using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200214A RID: 8522
	public class ISystemOption
	{
		// Token: 0x0600B4E4 RID: 46308 RVA: 0x00195164 File Offset: 0x00193364
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

		// Token: 0x0600B4E5 RID: 46309 RVA: 0x0019519C File Offset: 0x0019339C
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

		// Token: 0x0600B4E6 RID: 46310 RVA: 0x001951AF File Offset: 0x001933AF
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

		// Token: 0x0600B4E7 RID: 46311 RVA: 0x001951C2 File Offset: 0x001933C2
		public ISystemOption_SetValue ToSetValue()
		{
			return new ISystemOption_SetValue
			{
				OptionId = this.OptionId,
				Actions = this.Actions
			};
		}

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600B4E8 RID: 46312 RVA: 0x001951E4 File Offset: 0x001933E4
		// (set) Token: 0x0600B4E9 RID: 46313 RVA: 0x0019521E File Offset: 0x0019341E
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

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600B4EA RID: 46314 RVA: 0x0019522C File Offset: 0x0019342C
		// (set) Token: 0x0600B4EB RID: 46315 RVA: 0x001952BF File Offset: 0x001934BF
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

		// Token: 0x04006AFF RID: 27391
		[Nullable(2)]
		protected ISystemOption FbInstance;

		// Token: 0x04006B00 RID: 27392
		[Nullable(2)]
		protected ISystemOption_SetValue PocoInterface;

		// Token: 0x04006B01 RID: 27393
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04006B02 RID: 27394
		private bool _ActionsInited;
	}
}
