using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000639 RID: 1593
	public class IPasserbyNpcGenerateTypeBase
	{
		// Token: 0x0600217E RID: 8574 RVA: 0x0005D34C File Offset: 0x0005B54C
		private IPasserbyNpcGenerateTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcGenerateTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcGenerateTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcGenerateTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x0005D384 File Offset: 0x0005B584
		public static IPasserbyNpcGenerateTypeBase Create([Nullable(2)] IPasserbyNpcGenerateTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcGenerateTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x0005D397 File Offset: 0x0005B597
		public static IPasserbyNpcGenerateTypeBase CreateFromSetValue([Nullable(2)] IPasserbyNpcGenerateTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcGenerateTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0005D3AA File Offset: 0x0005B5AA
		public IPasserbyNpcGenerateTypeBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcGenerateTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0005D3BD File Offset: 0x0005B5BD
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x0005D3E8 File Offset: 0x0005B5E8
		public virtual EPasserbyNpcGenerateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcGenerateType.RandomStand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040017AD RID: 6061
		[Nullable(2)]
		protected IPasserbyNpcGenerateTypeBase FbInstance;

		// Token: 0x040017AE RID: 6062
		[Nullable(2)]
		protected IPasserbyNpcGenerateTypeBase_SetValue PocoInterface;
	}
}
