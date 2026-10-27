using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200068A RID: 1674
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoadNetworkNavigationType
	{
		// Token: 0x060023DE RID: 9182 RVA: 0x00061A10 File Offset: 0x0005FC10
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

		// Token: 0x060023DF RID: 9183 RVA: 0x00061A48 File Offset: 0x0005FC48
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

		// Token: 0x060023E0 RID: 9184 RVA: 0x00061A5B File Offset: 0x0005FC5B
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

		// Token: 0x060023E1 RID: 9185 RVA: 0x00061A6E File Offset: 0x0005FC6E
		public IRoadNetworkNavigationType_SetValue ToSetValue()
		{
			return new IRoadNetworkNavigationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x00061A81 File Offset: 0x0005FC81
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x00061AAC File Offset: 0x0005FCAC
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

		// Token: 0x040018B7 RID: 6327
		[Nullable(2)]
		protected IRoadNetworkNavigationType FbInstance;

		// Token: 0x040018B8 RID: 6328
		[Nullable(2)]
		protected IRoadNetworkNavigationType_SetValue PocoInterface;
	}
}
