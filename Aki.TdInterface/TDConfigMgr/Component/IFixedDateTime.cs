using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000392 RID: 914
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedDateTime
	{
		// Token: 0x06001221 RID: 4641 RVA: 0x0003C288 File Offset: 0x0003A488
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

		// Token: 0x06001222 RID: 4642 RVA: 0x0003C2C0 File Offset: 0x0003A4C0
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

		// Token: 0x06001223 RID: 4643 RVA: 0x0003C2D3 File Offset: 0x0003A4D3
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

		// Token: 0x06001224 RID: 4644 RVA: 0x0003C2E6 File Offset: 0x0003A4E6
		public IFixedDateTime_SetValue ToSetValue()
		{
			return new IFixedDateTime_SetValue
			{
				Hours = this.Hours,
				Minutes = this.Minutes,
				Seconds = this.Seconds
			};
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0003C311 File Offset: 0x0003A511
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x0003C33C File Offset: 0x0003A53C
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x0003C34A File Offset: 0x0003A54A
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x0003C375 File Offset: 0x0003A575
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

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0003C383 File Offset: 0x0003A583
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x0003C3AE File Offset: 0x0003A5AE
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

		// Token: 0x04000EA8 RID: 3752
		[Nullable(2)]
		protected IFixedDateTime FbInstance;

		// Token: 0x04000EA9 RID: 3753
		[Nullable(2)]
		protected IFixedDateTime_SetValue PocoInterface;
	}
}
