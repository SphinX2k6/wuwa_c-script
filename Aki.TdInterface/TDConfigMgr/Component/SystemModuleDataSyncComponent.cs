using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B3 RID: 2227
	[NullableContext(1)]
	[Nullable(0)]
	public class SystemModuleDataSyncComponent : IComponentBase
	{
		// Token: 0x060031F5 RID: 12789 RVA: 0x00080204 File Offset: 0x0007E404
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

		// Token: 0x060031F6 RID: 12790 RVA: 0x0008023C File Offset: 0x0007E43C
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

		// Token: 0x060031F7 RID: 12791 RVA: 0x0008024F File Offset: 0x0007E44F
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

		// Token: 0x060031F8 RID: 12792 RVA: 0x00080262 File Offset: 0x0007E462
		public new SystemModuleDataSyncComponent_SetValue ToSetValue()
		{
			return new SystemModuleDataSyncComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				SystemModuleData = this.SystemModuleData
			};
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x00080290 File Offset: 0x0007E490
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x000802CA File Offset: 0x0007E4CA
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

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x000802D8 File Offset: 0x0007E4D8
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x00080302 File Offset: 0x0007E502
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

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x00080310 File Offset: 0x0007E510
		// (set) Token: 0x060031FE RID: 12798 RVA: 0x00080371 File Offset: 0x0007E571
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

		// Token: 0x040020BF RID: 8383
		[Nullable(2)]
		protected new SystemModuleDataSyncComponent FbInstance;

		// Token: 0x040020C0 RID: 8384
		[Nullable(2)]
		protected new SystemModuleDataSyncComponent_SetValue PocoInterface;

		// Token: 0x040020C1 RID: 8385
		private ISystemModuleDataSyncMotorRacing _SystemModuleDataCache;

		// Token: 0x040020C2 RID: 8386
		private bool _SystemModuleDataInited;
	}
}
