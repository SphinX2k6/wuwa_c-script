using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000048 RID: 72
	[NullableContext(1)]
	[Nullable(0)]
	public class ConditionListenerComponent : IComponentBase
	{
		// Token: 0x06000264 RID: 612 RVA: 0x000195C0 File Offset: 0x000177C0
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

		// Token: 0x06000265 RID: 613 RVA: 0x000195F8 File Offset: 0x000177F8
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

		// Token: 0x06000266 RID: 614 RVA: 0x0001960B File Offset: 0x0001780B
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

		// Token: 0x06000267 RID: 615 RVA: 0x0001961E File Offset: 0x0001781E
		public new ConditionListenerComponent_SetValue ToSetValue()
		{
			return new ConditionListenerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Listeners = this.Listeners
			};
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0001964C File Offset: 0x0001784C
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00019686 File Offset: 0x00017886
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00019694 File Offset: 0x00017894
		// (set) Token: 0x0600026B RID: 619 RVA: 0x000196BE File Offset: 0x000178BE
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000196CC File Offset: 0x000178CC
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0001975F File Offset: 0x0001795F
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

		// Token: 0x04000181 RID: 385
		[Nullable(2)]
		protected new ConditionListenerComponent FbInstance;

		// Token: 0x04000182 RID: 386
		[Nullable(2)]
		protected new ConditionListenerComponent_SetValue PocoInterface;

		// Token: 0x04000183 RID: 387
		private List<ICondtionListener> _ListenersCache;

		// Token: 0x04000184 RID: 388
		private bool _ListenersInited;
	}
}
