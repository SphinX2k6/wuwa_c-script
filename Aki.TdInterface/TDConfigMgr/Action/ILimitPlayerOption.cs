using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D43 RID: 7491
	public class ILimitPlayerOption
	{
		// Token: 0x06009F15 RID: 40725 RVA: 0x0016D8F8 File Offset: 0x0016BAF8
		private ILimitPlayerOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerOption_SetValue());
			}
			return result;
		}

		// Token: 0x06009F16 RID: 40726 RVA: 0x0016D930 File Offset: 0x0016BB30
		public static ILimitPlayerOption Create([Nullable(2)] ILimitPlayerOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F17 RID: 40727 RVA: 0x0016D943 File Offset: 0x0016BB43
		public static ILimitPlayerOption CreateFromSetValue([Nullable(2)] ILimitPlayerOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F18 RID: 40728 RVA: 0x0016D956 File Offset: 0x0016BB56
		public ILimitPlayerOption_SetValue ToSetValue()
		{
			return new ILimitPlayerOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x06009F19 RID: 40729 RVA: 0x0016D969 File Offset: 0x0016BB69
		// (set) Token: 0x06009F1A RID: 40730 RVA: 0x0016D994 File Offset: 0x0016BB94
		public virtual ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060E9 RID: 24809
		[Nullable(2)]
		protected ILimitPlayerOption FbInstance;

		// Token: 0x040060EA RID: 24810
		[Nullable(2)]
		protected ILimitPlayerOption_SetValue PocoInterface;
	}
}
