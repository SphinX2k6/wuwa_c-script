using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000040 RID: 64
	public class ClientTriggerComponent : IComponentBase
	{
		// Token: 0x06000232 RID: 562 RVA: 0x00019834 File Offset: 0x00017A34
		private ClientTriggerComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientTriggerComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientTriggerComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientTriggerComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001986C File Offset: 0x00017A6C
		public static ClientTriggerComponent Create([Nullable(2)] ClientTriggerComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientTriggerComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001987F File Offset: 0x00017A7F
		public static ClientTriggerComponent CreateFromSetValue([Nullable(2)] ClientTriggerComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientTriggerComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00019894 File Offset: 0x00017A94
		public new ClientTriggerComponent_SetValue ToSetValue()
		{
			return new ClientTriggerComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				TriggerMatch = this.TriggerMatch,
				OnTriggerEnter = this.OnTriggerEnter,
				OnTriggerExit = this.OnTriggerExit
			};
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000198E4 File Offset: 0x00017AE4
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0001991E File Offset: 0x00017B1E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ClientTriggerComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0001992C File Offset: 0x00017B2C
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00019956 File Offset: 0x00017B56
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00019964 File Offset: 0x00017B64
		// (set) Token: 0x0600023B RID: 571 RVA: 0x000199C5 File Offset: 0x00017BC5
		public virtual ITriggerMatchConfig TriggerMatch
		{
			get
			{
				if (this._TriggerMatchInited)
				{
					return this._TriggerMatchCache;
				}
				this._TriggerMatchInited = true;
				if (this.FbInstance != null)
				{
					this._TriggerMatchCache = ITriggerMatchConfig.Create(this.FbInstance.TriggerMatch);
				}
				else
				{
					ClientTriggerComponent_SetValue pocoInterface = this.PocoInterface;
					this._TriggerMatchCache = ((pocoInterface != null) ? pocoInterface.TriggerMatch : null);
				}
				return this._TriggerMatchCache;
			}
			set
			{
				this.GetOrCreatePoco().TriggerMatch = value;
				this._TriggerMatchInited = false;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600023C RID: 572 RVA: 0x000199DC File Offset: 0x00017BDC
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00019A3D File Offset: 0x00017C3D
		public virtual ITriggeredConfig OnTriggerEnter
		{
			get
			{
				if (this._OnTriggerEnterInited)
				{
					return this._OnTriggerEnterCache;
				}
				this._OnTriggerEnterInited = true;
				if (this.FbInstance != null)
				{
					this._OnTriggerEnterCache = ITriggeredConfig.Create(this.FbInstance.OnTriggerEnter);
				}
				else
				{
					ClientTriggerComponent_SetValue pocoInterface = this.PocoInterface;
					this._OnTriggerEnterCache = ((pocoInterface != null) ? pocoInterface.OnTriggerEnter : null);
				}
				return this._OnTriggerEnterCache;
			}
			set
			{
				this.GetOrCreatePoco().OnTriggerEnter = value;
				this._OnTriggerEnterInited = false;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00019A54 File Offset: 0x00017C54
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00019AB5 File Offset: 0x00017CB5
		public virtual ITriggeredConfig OnTriggerExit
		{
			get
			{
				if (this._OnTriggerExitInited)
				{
					return this._OnTriggerExitCache;
				}
				this._OnTriggerExitInited = true;
				if (this.FbInstance != null)
				{
					this._OnTriggerExitCache = ITriggeredConfig.Create(this.FbInstance.OnTriggerExit);
				}
				else
				{
					ClientTriggerComponent_SetValue pocoInterface = this.PocoInterface;
					this._OnTriggerExitCache = ((pocoInterface != null) ? pocoInterface.OnTriggerExit : null);
				}
				return this._OnTriggerExitCache;
			}
			set
			{
				this.GetOrCreatePoco().OnTriggerExit = value;
				this._OnTriggerExitInited = false;
			}
		}

		// Token: 0x04000169 RID: 361
		[Nullable(2)]
		protected new ClientTriggerComponent FbInstance;

		// Token: 0x0400016A RID: 362
		[Nullable(2)]
		protected new ClientTriggerComponent_SetValue PocoInterface;

		// Token: 0x0400016B RID: 363
		private ITriggerMatchConfig _TriggerMatchCache;

		// Token: 0x0400016C RID: 364
		private bool _TriggerMatchInited;

		// Token: 0x0400016D RID: 365
		private ITriggeredConfig _OnTriggerEnterCache;

		// Token: 0x0400016E RID: 366
		private bool _OnTriggerEnterInited;

		// Token: 0x0400016F RID: 367
		private ITriggeredConfig _OnTriggerExitCache;

		// Token: 0x04000170 RID: 368
		private bool _OnTriggerExitInited;
	}
}
