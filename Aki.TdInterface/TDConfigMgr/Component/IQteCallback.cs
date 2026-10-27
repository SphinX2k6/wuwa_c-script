using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000638 RID: 1592
	[NullableContext(1)]
	[Nullable(0)]
	public class IQteCallback
	{
		// Token: 0x06002200 RID: 8704 RVA: 0x0005DAD0 File Offset: 0x0005BCD0
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

		// Token: 0x06002201 RID: 8705 RVA: 0x0005DB08 File Offset: 0x0005BD08
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

		// Token: 0x06002202 RID: 8706 RVA: 0x0005DB1B File Offset: 0x0005BD1B
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

		// Token: 0x06002203 RID: 8707 RVA: 0x0005DB2E File Offset: 0x0005BD2E
		public IQteCallback_SetValue ToSetValue()
		{
			return new IQteCallback_SetValue
			{
				Actions = this.Actions,
				SendSelfEvent = this.SendSelfEvent
			};
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x0005DB50 File Offset: 0x0005BD50
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x0005DBE3 File Offset: 0x0005BDE3
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

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x0005DBF8 File Offset: 0x0005BDF8
		// (set) Token: 0x06002207 RID: 8711 RVA: 0x0005DC1F File Offset: 0x0005BE1F
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

		// Token: 0x040017A7 RID: 6055
		[Nullable(2)]
		protected IQteCallback FbInstance;

		// Token: 0x040017A8 RID: 6056
		[Nullable(2)]
		protected IQteCallback_SetValue PocoInterface;

		// Token: 0x040017A9 RID: 6057
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x040017AA RID: 6058
		private bool _ActionsInited;
	}
}
