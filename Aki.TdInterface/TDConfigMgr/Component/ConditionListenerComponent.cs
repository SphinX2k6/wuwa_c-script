using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000048 RID: 72
	public class ConditionListenerComponent : IComponentBase
	{
		// Token: 0x06000268 RID: 616 RVA: 0x00019F34 File Offset: 0x00018134
		private ConditionListenerComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ConditionListenerComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ConditionListenerComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ConditionListenerComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00019F6C File Offset: 0x0001816C
		public static ConditionListenerComponent Create([Nullable(2)] ConditionListenerComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ConditionListenerComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00019F7F File Offset: 0x0001817F
		public static ConditionListenerComponent CreateFromSetValue([Nullable(2)] ConditionListenerComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ConditionListenerComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00019F92 File Offset: 0x00018192
		public new ConditionListenerComponent_SetValue ToSetValue()
		{
			return new ConditionListenerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Listeners = this.Listeners
			};
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00019FC0 File Offset: 0x000181C0
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00019FFA File Offset: 0x000181FA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ConditionListenerComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0001A008 File Offset: 0x00018208
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0001A032 File Offset: 0x00018232
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001A040 File Offset: 0x00018240
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0001A0D3 File Offset: 0x000182D3
		public virtual List<ICondtionListener> Listeners
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
					List<ICondtionListener> listeners = this.FbInstance.Listeners;
					if (listeners != null)
					{
						this._ListenersCache = new List<ICondtionListener>(listeners.Count);
						for (int i = 0; i < listeners.Count; i++)
						{
							this._ListenersCache.Add(ICondtionListener.Create(listeners[i]));
						}
					}
				}
				else
				{
					ConditionListenerComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000186 RID: 390
		[Nullable(2)]
		protected new ConditionListenerComponent FbInstance;

		// Token: 0x04000187 RID: 391
		[Nullable(2)]
		protected new ConditionListenerComponent_SetValue PocoInterface;

		// Token: 0x04000188 RID: 392
		private List<ICondtionListener> _ListenersCache;

		// Token: 0x04000189 RID: 393
		private bool _ListenersInited;
	}
}
