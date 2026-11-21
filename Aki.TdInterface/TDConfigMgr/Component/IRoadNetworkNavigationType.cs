using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200072B RID: 1835
	public class IRoadNetworkNavigationType
	{
		// Token: 0x060026FA RID: 9978 RVA: 0x000689D8 File Offset: 0x00066BD8
		private IRoadNetworkNavigationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoadNetworkNavigationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoadNetworkNavigationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoadNetworkNavigationType_SetValue());
			}
			return result;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00068A10 File Offset: 0x00066C10
		public static IRoadNetworkNavigationType Create([Nullable(2)] IRoadNetworkNavigationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoadNetworkNavigationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00068A23 File Offset: 0x00066C23
		public static IRoadNetworkNavigationType CreateFromSetValue([Nullable(2)] IRoadNetworkNavigationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoadNetworkNavigationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x00068A36 File Offset: 0x00066C36
		public IRoadNetworkNavigationType_SetValue ToSetValue()
		{
			return new IRoadNetworkNavigationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x00068A49 File Offset: 0x00066C49
		// (set) Token: 0x060026FF RID: 9983 RVA: 0x00068A74 File Offset: 0x00066C74
		public virtual ERoadNetworkNavigationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoadNetworkNavigationType.Traffic;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001AB4 RID: 6836
		[Nullable(2)]
		protected IRoadNetworkNavigationType FbInstance;

		// Token: 0x04001AB5 RID: 6837
		[Nullable(2)]
		protected IRoadNetworkNavigationType_SetValue PocoInterface;
	}
}
