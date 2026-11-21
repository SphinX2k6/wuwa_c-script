using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002294 RID: 8852
	public class IVillageInfrBuildOption
	{
		// Token: 0x0600C0D0 RID: 49360 RVA: 0x001BC254 File Offset: 0x001BA454
		private IVillageInfrBuildOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVillageInfrBuildOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVillageInfrBuildOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVillageInfrBuildOption_SetValue());
			}
			return result;
		}

		// Token: 0x0600C0D1 RID: 49361 RVA: 0x001BC28C File Offset: 0x001BA48C
		public static IVillageInfrBuildOption Create([Nullable(2)] IVillageInfrBuildOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrBuildOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0D2 RID: 49362 RVA: 0x001BC29F File Offset: 0x001BA49F
		public static IVillageInfrBuildOption CreateFromSetValue([Nullable(2)] IVillageInfrBuildOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVillageInfrBuildOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0D3 RID: 49363 RVA: 0x001BC2B2 File Offset: 0x001BA4B2
		public IVillageInfrBuildOption_SetValue ToSetValue()
		{
			return new IVillageInfrBuildOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0600C0D4 RID: 49364 RVA: 0x001BC2C5 File Offset: 0x001BA4C5
		// (set) Token: 0x0600C0D5 RID: 49365 RVA: 0x001BC2F0 File Offset: 0x001BA4F0
		public virtual EVillageInfrBuildType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVillageInfrBuildType.Village;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400734D RID: 29517
		[Nullable(2)]
		protected IVillageInfrBuildOption FbInstance;

		// Token: 0x0400734E RID: 29518
		[Nullable(2)]
		protected IVillageInfrBuildOption_SetValue PocoInterface;
	}
}
