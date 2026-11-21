using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D5 RID: 1749
	public class IQteCallback
	{
		// Token: 0x06002506 RID: 9478 RVA: 0x000647E4 File Offset: 0x000629E4
		private IQteCallback_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQteCallback 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQteCallback_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQteCallback_SetValue());
			}
			return result;
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x0006481C File Offset: 0x00062A1C
		public static IQteCallback Create([Nullable(2)] IQteCallback instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteCallback
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0006482F File Offset: 0x00062A2F
		public static IQteCallback CreateFromSetValue([Nullable(2)] IQteCallback_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQteCallback
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00064842 File Offset: 0x00062A42
		public IQteCallback_SetValue ToSetValue()
		{
			return new IQteCallback_SetValue
			{
				Actions = this.Actions,
				SendSelfEvent = this.SendSelfEvent
			};
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x00064864 File Offset: 0x00062A64
		// (set) Token: 0x0600250B RID: 9483 RVA: 0x000648F7 File Offset: 0x00062AF7
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
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
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IQteCallback_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x0006490C File Offset: 0x00062B0C
		// (set) Token: 0x0600250D RID: 9485 RVA: 0x00064933 File Offset: 0x00062B33
		[Nullable(2)]
		public virtual string SendSelfEvent
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SendSelfEvent;
				}
				IQteCallback_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SendSelfEvent;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SendSelfEvent = value;
			}
		}

		// Token: 0x04001999 RID: 6553
		[Nullable(2)]
		protected IQteCallback FbInstance;

		// Token: 0x0400199A RID: 6554
		[Nullable(2)]
		protected IQteCallback_SetValue PocoInterface;

		// Token: 0x0400199B RID: 6555
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x0400199C RID: 6556
		private bool _ActionsInited;
	}
}
