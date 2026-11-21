using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003DB RID: 987
	public class IFixedDateTime
	{
		// Token: 0x06001365 RID: 4965 RVA: 0x0003F56C File Offset: 0x0003D76C
		private IFixedDateTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedDateTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedDateTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedDateTime_SetValue());
			}
			return result;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0003F5A4 File Offset: 0x0003D7A4
		public static IFixedDateTime Create([Nullable(2)] IFixedDateTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedDateTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0003F5B7 File Offset: 0x0003D7B7
		public static IFixedDateTime CreateFromSetValue([Nullable(2)] IFixedDateTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedDateTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0003F5CA File Offset: 0x0003D7CA
		public IFixedDateTime_SetValue ToSetValue()
		{
			return new IFixedDateTime_SetValue
			{
				Hours = this.Hours,
				Minutes = this.Minutes,
				Seconds = this.Seconds
			};
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0003F5F5 File Offset: 0x0003D7F5
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x0003F620 File Offset: 0x0003D820
		public virtual int Hours
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Hours;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Hours;
			}
			set
			{
				this.GetOrCreatePoco().Hours = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0003F62E File Offset: 0x0003D82E
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x0003F659 File Offset: 0x0003D859
		public virtual int Minutes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Minutes;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Minutes;
			}
			set
			{
				this.GetOrCreatePoco().Minutes = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0003F667 File Offset: 0x0003D867
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x0003F692 File Offset: 0x0003D892
		public virtual int Seconds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Seconds;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Seconds;
			}
			set
			{
				this.GetOrCreatePoco().Seconds = value;
			}
		}

		// Token: 0x04000F9F RID: 3999
		[Nullable(2)]
		protected IFixedDateTime FbInstance;

		// Token: 0x04000FA0 RID: 4000
		[Nullable(2)]
		protected IFixedDateTime_SetValue PocoInterface;
	}
}
