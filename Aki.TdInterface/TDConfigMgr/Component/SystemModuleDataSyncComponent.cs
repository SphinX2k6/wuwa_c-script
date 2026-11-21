using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000956 RID: 2390
	public class SystemModuleDataSyncComponent : IComponentBase
	{
		// Token: 0x06003531 RID: 13617 RVA: 0x000876EC File Offset: 0x000858EC
		private SystemModuleDataSyncComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SystemModuleDataSyncComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SystemModuleDataSyncComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SystemModuleDataSyncComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00087724 File Offset: 0x00085924
		public static SystemModuleDataSyncComponent Create([Nullable(2)] SystemModuleDataSyncComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SystemModuleDataSyncComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00087737 File Offset: 0x00085937
		public static SystemModuleDataSyncComponent CreateFromSetValue([Nullable(2)] SystemModuleDataSyncComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SystemModuleDataSyncComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0008774A File Offset: 0x0008594A
		public new SystemModuleDataSyncComponent_SetValue ToSetValue()
		{
			return new SystemModuleDataSyncComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				SystemModuleData = this.SystemModuleData
			};
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06003535 RID: 13621 RVA: 0x00087778 File Offset: 0x00085978
		// (set) Token: 0x06003536 RID: 13622 RVA: 0x000877B2 File Offset: 0x000859B2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				SystemModuleDataSyncComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06003537 RID: 13623 RVA: 0x000877C0 File Offset: 0x000859C0
		// (set) Token: 0x06003538 RID: 13624 RVA: 0x000877EA File Offset: 0x000859EA
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

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x000877F8 File Offset: 0x000859F8
		// (set) Token: 0x0600353A RID: 13626 RVA: 0x00087859 File Offset: 0x00085A59
		public virtual ISystemModuleDataSyncMotorRacing SystemModuleData
		{
			get
			{
				if (this._SystemModuleDataInited)
				{
					return this._SystemModuleDataCache;
				}
				this._SystemModuleDataInited = true;
				if (this.FbInstance != null)
				{
					this._SystemModuleDataCache = ISystemModuleDataSyncMotorRacing.Create(this.FbInstance.SystemModuleData);
				}
				else
				{
					SystemModuleDataSyncComponent_SetValue pocoInterface = this.PocoInterface;
					this._SystemModuleDataCache = ((pocoInterface != null) ? pocoInterface.SystemModuleData : null);
				}
				return this._SystemModuleDataCache;
			}
			set
			{
				this.GetOrCreatePoco().SystemModuleData = value;
				this._SystemModuleDataInited = false;
			}
		}

		// Token: 0x040022D1 RID: 8913
		[Nullable(2)]
		protected new SystemModuleDataSyncComponent FbInstance;

		// Token: 0x040022D2 RID: 8914
		[Nullable(2)]
		protected new SystemModuleDataSyncComponent_SetValue PocoInterface;

		// Token: 0x040022D3 RID: 8915
		private ISystemModuleDataSyncMotorRacing _SystemModuleDataCache;

		// Token: 0x040022D4 RID: 8916
		private bool _SystemModuleDataInited;
	}
}
