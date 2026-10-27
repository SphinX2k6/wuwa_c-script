using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200065E RID: 1630
	[NullableContext(1)]
	[Nullable(0)]
	public class IRangeConstraint
	{
		// Token: 0x060022E4 RID: 8932 RVA: 0x0005FC20 File Offset: 0x0005DE20
		private IRangeConstraint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRangeConstraint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRangeConstraint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRangeConstraint_SetValue());
			}
			return result;
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0005FC58 File Offset: 0x0005DE58
		public static IRangeConstraint Create([Nullable(2)] IRangeConstraint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeConstraint
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0005FC6B File Offset: 0x0005DE6B
		public static IRangeConstraint CreateFromSetValue([Nullable(2)] IRangeConstraint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRangeConstraint
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x0005FC7E File Offset: 0x0005DE7E
		public IRangeConstraint_SetValue ToSetValue()
		{
			return new IRangeConstraint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0005FC91 File Offset: 0x0005DE91
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0005FCBC File Offset: 0x0005DEBC
		public virtual ERangeConstraint Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERangeConstraint.SearchSpawnMonsterPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001838 RID: 6200
		[Nullable(2)]
		protected IRangeConstraint FbInstance;

		// Token: 0x04001839 RID: 6201
		[Nullable(2)]
		protected IRangeConstraint_SetValue PocoInterface;
	}
}
