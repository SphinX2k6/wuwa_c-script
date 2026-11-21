using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001959 RID: 6489
	public class IAlertSystemOption
	{
		// Token: 0x06008A03 RID: 35331 RVA: 0x001485DC File Offset: 0x001467DC
		private IAlertSystemOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAlertSystemOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAlertSystemOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAlertSystemOption_SetValue());
			}
			return result;
		}

		// Token: 0x06008A04 RID: 35332 RVA: 0x00148614 File Offset: 0x00146814
		public static IAlertSystemOption Create([Nullable(2)] IAlertSystemOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAlertSystemOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A05 RID: 35333 RVA: 0x00148627 File Offset: 0x00146827
		public static IAlertSystemOption CreateFromSetValue([Nullable(2)] IAlertSystemOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAlertSystemOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A06 RID: 35334 RVA: 0x0014863A File Offset: 0x0014683A
		public IAlertSystemOption_SetValue ToSetValue()
		{
			return new IAlertSystemOption_SetValue
			{
				Type = this.Type,
				AreaId = this.AreaId
			};
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x06008A07 RID: 35335 RVA: 0x00148659 File Offset: 0x00146859
		// (set) Token: 0x06008A08 RID: 35336 RVA: 0x00148684 File Offset: 0x00146884
		public virtual EAlertSystemOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x06008A09 RID: 35337 RVA: 0x00148692 File Offset: 0x00146892
		// (set) Token: 0x06008A0A RID: 35338 RVA: 0x001486BD File Offset: 0x001468BD
		public virtual int AreaId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AreaId;
			}
			set
			{
				this.GetOrCreatePoco().AreaId = value;
			}
		}

		// Token: 0x04005775 RID: 22389
		[Nullable(2)]
		protected IAlertSystemOption FbInstance;

		// Token: 0x04005776 RID: 22390
		[Nullable(2)]
		protected IAlertSystemOption_SetValue PocoInterface;
	}
}
