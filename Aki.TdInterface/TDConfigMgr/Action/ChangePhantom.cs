using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001639 RID: 5689
	public class ChangePhantom : ActionParams
	{
		// Token: 0x06008071 RID: 32881 RVA: 0x00131C7C File Offset: 0x0012FE7C
		private ChangePhantom_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangePhantom 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangePhantom_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangePhantom_SetValue());
			}
			return result;
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x00131CB4 File Offset: 0x0012FEB4
		public static ChangePhantom Create([Nullable(2)] ChangePhantom instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangePhantom
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x00131CC7 File Offset: 0x0012FEC7
		public static ChangePhantom CreateFromSetValue([Nullable(2)] ChangePhantom_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangePhantom
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x00131CDA File Offset: 0x0012FEDA
		public ChangePhantom_SetValue ToSetValue()
		{
			return new ChangePhantom_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x06008075 RID: 32885 RVA: 0x00131CED File Offset: 0x0012FEED
		// (set) Token: 0x06008076 RID: 32886 RVA: 0x00131D18 File Offset: 0x0012FF18
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04004A2C RID: 18988
		[Nullable(2)]
		protected new ChangePhantom FbInstance;

		// Token: 0x04004A2D RID: 18989
		[Nullable(2)]
		protected ChangePhantom_SetValue PocoInterface;
	}
}
