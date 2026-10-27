using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003E RID: 62
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientConditionListenerComponent : IComponentBase
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00018CFC File Offset: 0x00016EFC
		private ClientConditionListenerComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientConditionListenerComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientConditionListenerComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientConditionListenerComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00018D34 File Offset: 0x00016F34
		public static ClientConditionListenerComponent Create([Nullable(2)] ClientConditionListenerComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientConditionListenerComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00018D47 File Offset: 0x00016F47
		public static ClientConditionListenerComponent CreateFromSetValue([Nullable(2)] ClientConditionListenerComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientConditionListenerComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00018D5A File Offset: 0x00016F5A
		public new ClientConditionListenerComponent_SetValue ToSetValue()
		{
			return new ClientConditionListenerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Listeners = this.Listeners
			};
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00018D88 File Offset: 0x00016F88
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00018DC2 File Offset: 0x00016FC2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ClientConditionListenerComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00018DD0 File Offset: 0x00016FD0
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00018DFA File Offset: 0x00016FFA
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00018E08 File Offset: 0x00017008
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00018E9B File Offset: 0x0001709B
		public virtual List<IClientConditionListener> Listeners
		{
			get
			{
				if (this._ListenersInited)
				{
					return this._ListenersCache;
				}
				this._ListenersInited = true;
				if (this.FbInstance != null)
				{
					List<IClientConditionListener> listeners = this.FbInstance.Listeners;
					if (listeners != null)
					{
						this._ListenersCache = new List<IClientConditionListener>(listeners.Count);
						for (int i = 0; i < listeners.Count; i++)
						{
							this._ListenersCache.Add(IClientConditionListener.Create(listeners[i]));
						}
					}
				}
				else
				{
					ClientConditionListenerComponent_SetValue pocoInterface = this.PocoInterface;
					this._ListenersCache = ((pocoInterface != null) ? pocoInterface.Listeners : null);
				}
				return this._ListenersCache;
			}
			set
			{
				this.GetOrCreatePoco().Listeners = value;
				this._ListenersInited = false;
			}
		}

		// Token: 0x0400015D RID: 349
		[Nullable(2)]
		protected new ClientConditionListenerComponent FbInstance;

		// Token: 0x0400015E RID: 350
		[Nullable(2)]
		protected new ClientConditionListenerComponent_SetValue PocoInterface;

		// Token: 0x0400015F RID: 351
		private List<IClientConditionListener> _ListenersCache;

		// Token: 0x04000160 RID: 352
		private bool _ListenersInited;
	}
}
