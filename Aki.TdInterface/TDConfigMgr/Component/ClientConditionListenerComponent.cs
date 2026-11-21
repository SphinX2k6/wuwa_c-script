using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003E RID: 62
	public class ClientConditionListenerComponent : IComponentBase
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00019670 File Offset: 0x00017870
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

		// Token: 0x06000227 RID: 551 RVA: 0x000196A8 File Offset: 0x000178A8
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

		// Token: 0x06000228 RID: 552 RVA: 0x000196BB File Offset: 0x000178BB
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

		// Token: 0x06000229 RID: 553 RVA: 0x000196CE File Offset: 0x000178CE
		public new ClientConditionListenerComponent_SetValue ToSetValue()
		{
			return new ClientConditionListenerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Listeners = this.Listeners
			};
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000196FC File Offset: 0x000178FC
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00019736 File Offset: 0x00017936
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00019744 File Offset: 0x00017944
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0001976E File Offset: 0x0001796E
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

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0001977C File Offset: 0x0001797C
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0001980F File Offset: 0x00017A0F
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

		// Token: 0x04000162 RID: 354
		[Nullable(2)]
		protected new ClientConditionListenerComponent FbInstance;

		// Token: 0x04000163 RID: 355
		[Nullable(2)]
		protected new ClientConditionListenerComponent_SetValue PocoInterface;

		// Token: 0x04000164 RID: 356
		private List<IClientConditionListener> _ListenersCache;

		// Token: 0x04000165 RID: 357
		private bool _ListenersInited;
	}
}
