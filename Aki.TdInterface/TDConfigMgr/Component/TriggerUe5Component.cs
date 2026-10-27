using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008D0 RID: 2256
	[NullableContext(1)]
	[Nullable(0)]
	public class TriggerUe5Component : IComponentBase
	{
		// Token: 0x06003301 RID: 13057 RVA: 0x00082D94 File Offset: 0x00080F94
		private TriggerUe5Component_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TriggerUe5Component 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TriggerUe5Component_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TriggerUe5Component_SetValue());
			}
			return result;
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00082DCC File Offset: 0x00080FCC
		public static TriggerUe5Component Create([Nullable(2)] TriggerUe5Component instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerUe5Component
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00082DDF File Offset: 0x00080FDF
		public static TriggerUe5Component CreateFromSetValue([Nullable(2)] TriggerUe5Component_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TriggerUe5Component
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x00082DF4 File Offset: 0x00080FF4
		public new TriggerUe5Component_SetValue ToSetValue()
		{
			return new TriggerUe5Component_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				MaxTriggerTimes = this.MaxTriggerTimes,
				IsNotLoad = this.IsNotLoad,
				TriggerActions = this.TriggerActions
			};
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x00082E44 File Offset: 0x00081044
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x00082E7E File Offset: 0x0008107E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TriggerUe5Component_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x00082E8C File Offset: 0x0008108C
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x00082EB6 File Offset: 0x000810B6
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

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x00082EC4 File Offset: 0x000810C4
		// (set) Token: 0x0600330A RID: 13066 RVA: 0x00082EEF File Offset: 0x000810EF
		public virtual int MaxTriggerTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxTriggerTimes;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxTriggerTimes;
			}
			set
			{
				this.GetOrCreatePoco().MaxTriggerTimes = value;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x0600330B RID: 13067 RVA: 0x00082EFD File Offset: 0x000810FD
		// (set) Token: 0x0600330C RID: 13068 RVA: 0x00082F28 File Offset: 0x00081128
		public virtual bool IsNotLoad
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNotLoad;
				}
				return this.PocoInterface != null && this.PocoInterface.IsNotLoad;
			}
			set
			{
				this.GetOrCreatePoco().IsNotLoad = value;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x00082F38 File Offset: 0x00081138
		// (set) Token: 0x0600330E RID: 13070 RVA: 0x00082F99 File Offset: 0x00081199
		public virtual ITriggerActions TriggerActions
		{
			get
			{
				if (this._TriggerActionsInited)
				{
					return this._TriggerActionsCache;
				}
				this._TriggerActionsInited = true;
				if (this.FbInstance != null)
				{
					this._TriggerActionsCache = ITriggerActions.Create(this.FbInstance.TriggerActions);
				}
				else
				{
					TriggerUe5Component_SetValue pocoInterface = this.PocoInterface;
					this._TriggerActionsCache = ((pocoInterface != null) ? pocoInterface.TriggerActions : null);
				}
				return this._TriggerActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().TriggerActions = value;
				this._TriggerActionsInited = false;
			}
		}

		// Token: 0x0400217D RID: 8573
		[Nullable(2)]
		protected new TriggerUe5Component FbInstance;

		// Token: 0x0400217E RID: 8574
		[Nullable(2)]
		protected new TriggerUe5Component_SetValue PocoInterface;

		// Token: 0x0400217F RID: 8575
		private ITriggerActions _TriggerActionsCache;

		// Token: 0x04002180 RID: 8576
		private bool _TriggerActionsInited;
	}
}
