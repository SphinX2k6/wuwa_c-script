using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B96 RID: 7062
	[NullableContext(1)]
	[Nullable(0)]
	public class ILimitPlayerOption
	{
		// Token: 0x06009733 RID: 38707 RVA: 0x0015CD4C File Offset: 0x0015AF4C
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

		// Token: 0x06009734 RID: 38708 RVA: 0x0015CD84 File Offset: 0x0015AF84
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

		// Token: 0x06009735 RID: 38709 RVA: 0x0015CD97 File Offset: 0x0015AF97
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

		// Token: 0x06009736 RID: 38710 RVA: 0x0015CDAA File Offset: 0x0015AFAA
		public ILimitPlayerOption_SetValue ToSetValue()
		{
			return new ILimitPlayerOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x06009737 RID: 38711 RVA: 0x0015CDBD File Offset: 0x0015AFBD
		// (set) Token: 0x06009738 RID: 38712 RVA: 0x0015CDE8 File Offset: 0x0015AFE8
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

		// Token: 0x04005C50 RID: 23632
		[Nullable(2)]
		protected ILimitPlayerOption FbInstance;

		// Token: 0x04005C51 RID: 23633
		[Nullable(2)]
		protected ILimitPlayerOption_SetValue PocoInterface;
	}
}
