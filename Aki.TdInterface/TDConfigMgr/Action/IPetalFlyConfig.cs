using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE1 RID: 7905
	public class IPetalFlyConfig : ISportConfig
	{
		// Token: 0x0600A841 RID: 43073 RVA: 0x0017E6A0 File Offset: 0x0017C8A0
		private IPetalFlyConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPetalFlyConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPetalFlyConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPetalFlyConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A842 RID: 43074 RVA: 0x0017E6D8 File Offset: 0x0017C8D8
		public static IPetalFlyConfig Create([Nullable(2)] IPetalFlyConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalFlyConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x0017E6EB File Offset: 0x0017C8EB
		public static IPetalFlyConfig CreateFromSetValue([Nullable(2)] IPetalFlyConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPetalFlyConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A844 RID: 43076 RVA: 0x0017E6FE File Offset: 0x0017C8FE
		public new IPetalFlyConfig_SetValue ToSetValue()
		{
			return new IPetalFlyConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600A845 RID: 43077 RVA: 0x0017E711 File Offset: 0x0017C911
		// (set) Token: 0x0600A846 RID: 43078 RVA: 0x0017E73C File Offset: 0x0017C93C
		public override ESportStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESportStateType.Slide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400652E RID: 25902
		[Nullable(2)]
		protected new IPetalFlyConfig FbInstance;

		// Token: 0x0400652F RID: 25903
		[Nullable(2)]
		protected new IPetalFlyConfig_SetValue PocoInterface;
	}
}
