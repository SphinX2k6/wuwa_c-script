using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CA2 RID: 7330
	public class IHeadStyleWarning : IHeadStyle
	{
		// Token: 0x06009BB0 RID: 39856 RVA: 0x00167758 File Offset: 0x00165958
		private IHeadStyleWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleWarning_SetValue());
			}
			return result;
		}

		// Token: 0x06009BB1 RID: 39857 RVA: 0x00167790 File Offset: 0x00165990
		public static IHeadStyleWarning Create([Nullable(2)] IHeadStyleWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x001677A3 File Offset: 0x001659A3
		public static IHeadStyleWarning CreateFromSetValue([Nullable(2)] IHeadStyleWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x001677B6 File Offset: 0x001659B6
		public new IHeadStyleWarning_SetValue ToSetValue()
		{
			return new IHeadStyleWarning_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x06009BB4 RID: 39860 RVA: 0x001677C9 File Offset: 0x001659C9
		// (set) Token: 0x06009BB5 RID: 39861 RVA: 0x001677F4 File Offset: 0x001659F4
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F59 RID: 24409
		[Nullable(2)]
		protected new IHeadStyleWarning FbInstance;

		// Token: 0x04005F5A RID: 24410
		[Nullable(2)]
		protected new IHeadStyleWarning_SetValue PocoInterface;
	}
}
