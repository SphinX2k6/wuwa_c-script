using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000643 RID: 1603
	public class IPasserbyNpcMoveBase
	{
		// Token: 0x060021AA RID: 8618 RVA: 0x0005D840 File Offset: 0x0005BA40
		private IPasserbyNpcMoveBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcMoveBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcMoveBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcMoveBase_SetValue());
			}
			return result;
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0005D878 File Offset: 0x0005BA78
		public static IPasserbyNpcMoveBase Create([Nullable(2)] IPasserbyNpcMoveBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcMoveBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0005D88B File Offset: 0x0005BA8B
		public static IPasserbyNpcMoveBase CreateFromSetValue([Nullable(2)] IPasserbyNpcMoveBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcMoveBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0005D89E File Offset: 0x0005BA9E
		public IPasserbyNpcMoveBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcMoveBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x0005D8B1 File Offset: 0x0005BAB1
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x0005D8DC File Offset: 0x0005BADC
		public virtual EPasserbyNpcMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcMoveType.Spline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040017C4 RID: 6084
		[Nullable(2)]
		protected IPasserbyNpcMoveBase FbInstance;

		// Token: 0x040017C5 RID: 6085
		[Nullable(2)]
		protected IPasserbyNpcMoveBase_SetValue PocoInterface;
	}
}
