using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200017C RID: 380
	public class ExhibitComponent : IComponentBase
	{
		// Token: 0x06000476 RID: 1142 RVA: 0x0001EC20 File Offset: 0x0001CE20
		private ExhibitComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExhibitComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExhibitComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExhibitComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001EC58 File Offset: 0x0001CE58
		public static ExhibitComponent Create([Nullable(2)] ExhibitComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExhibitComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001EC6B File Offset: 0x0001CE6B
		public static ExhibitComponent CreateFromSetValue([Nullable(2)] ExhibitComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExhibitComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001EC7E File Offset: 0x0001CE7E
		public new ExhibitComponent_SetValue ToSetValue()
		{
			return new ExhibitComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ExhibitConfig = this.ExhibitConfig
			};
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0001ECAC File Offset: 0x0001CEAC
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0001ECE6 File Offset: 0x0001CEE6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ExhibitComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0001ED1E File Offset: 0x0001CF1E
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001ED2C File Offset: 0x0001CF2C
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0001ED53 File Offset: 0x0001CF53
		public virtual IExhibitItemType ExhibitConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExhibitConfig;
				}
				ExhibitComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExhibitConfig;
			}
			set
			{
				this.GetOrCreatePoco().ExhibitConfig = value;
			}
		}

		// Token: 0x0400071D RID: 1821
		[Nullable(2)]
		protected new ExhibitComponent FbInstance;

		// Token: 0x0400071E RID: 1822
		[Nullable(2)]
		protected new ExhibitComponent_SetValue PocoInterface;
	}
}
