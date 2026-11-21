using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000973 RID: 2419
	public class TriggerUe5Component : IComponentBase
	{
		// Token: 0x0600363D RID: 13885 RVA: 0x0008A23C File Offset: 0x0008843C
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

		// Token: 0x0600363E RID: 13886 RVA: 0x0008A274 File Offset: 0x00088474
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

		// Token: 0x0600363F RID: 13887 RVA: 0x0008A287 File Offset: 0x00088487
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

		// Token: 0x06003640 RID: 13888 RVA: 0x0008A29C File Offset: 0x0008849C
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

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x0008A2EC File Offset: 0x000884EC
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x0008A326 File Offset: 0x00088526
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

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x0008A334 File Offset: 0x00088534
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x0008A35E File Offset: 0x0008855E
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

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x0008A36C File Offset: 0x0008856C
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x0008A397 File Offset: 0x00088597
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

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x0008A3A5 File Offset: 0x000885A5
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x0008A3D0 File Offset: 0x000885D0
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

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x0008A3E0 File Offset: 0x000885E0
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x0008A441 File Offset: 0x00088641
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

		// Token: 0x0400238D RID: 9101
		[Nullable(2)]
		protected new TriggerUe5Component FbInstance;

		// Token: 0x0400238E RID: 9102
		[Nullable(2)]
		protected new TriggerUe5Component_SetValue PocoInterface;

		// Token: 0x0400238F RID: 9103
		private ITriggerActions _TriggerActionsCache;

		// Token: 0x04002390 RID: 9104
		private bool _TriggerActionsInited;
	}
}
