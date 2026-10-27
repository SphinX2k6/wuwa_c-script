using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200070D RID: 1805
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateConfig
	{
		// Token: 0x060026D7 RID: 9943 RVA: 0x00067B08 File Offset: 0x00065D08
		private IStateConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00067B40 File Offset: 0x00065D40
		public static IStateConfig Create([Nullable(2)] IStateConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00067B53 File Offset: 0x00065D53
		public static IStateConfig CreateFromSetValue([Nullable(2)] IStateConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00067B66 File Offset: 0x00065D66
		public IStateConfig_SetValue ToSetValue()
		{
			return new IStateConfig_SetValue
			{
				State = this.State,
				Duration = this.Duration
			};
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x00067B85 File Offset: 0x00065D85
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00067BB0 File Offset: 0x00065DB0
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x00067BBE File Offset: 0x00065DBE
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x00067BED File Offset: 0x00065DED
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04001A48 RID: 6728
		[Nullable(2)]
		protected IStateConfig FbInstance;

		// Token: 0x04001A49 RID: 6729
		[Nullable(2)]
		protected IStateConfig_SetValue PocoInterface;
	}
}
