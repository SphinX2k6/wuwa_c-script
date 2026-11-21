using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006FB RID: 1787
	public class IRangeConstraint
	{
		// Token: 0x060025EA RID: 9706 RVA: 0x00066934 File Offset: 0x00064B34
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

		// Token: 0x060025EB RID: 9707 RVA: 0x0006696C File Offset: 0x00064B6C
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

		// Token: 0x060025EC RID: 9708 RVA: 0x0006697F File Offset: 0x00064B7F
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

		// Token: 0x060025ED RID: 9709 RVA: 0x00066992 File Offset: 0x00064B92
		public IRangeConstraint_SetValue ToSetValue()
		{
			return new IRangeConstraint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000669A5 File Offset: 0x00064BA5
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x000669D0 File Offset: 0x00064BD0
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

		// Token: 0x04001A2A RID: 6698
		[Nullable(2)]
		protected IRangeConstraint FbInstance;

		// Token: 0x04001A2B RID: 6699
		[Nullable(2)]
		protected IRangeConstraint_SetValue PocoInterface;
	}
}
