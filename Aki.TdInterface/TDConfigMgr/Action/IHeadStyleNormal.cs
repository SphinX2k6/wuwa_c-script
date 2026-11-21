using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C9E RID: 7326
	public class IHeadStyleNormal : IHeadStyle
	{
		// Token: 0x06009B9C RID: 39836 RVA: 0x00167558 File Offset: 0x00165758
		private IHeadStyleNormal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleNormal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleNormal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleNormal_SetValue());
			}
			return result;
		}

		// Token: 0x06009B9D RID: 39837 RVA: 0x00167590 File Offset: 0x00165790
		public static IHeadStyleNormal Create([Nullable(2)] IHeadStyleNormal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleNormal
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B9E RID: 39838 RVA: 0x001675A3 File Offset: 0x001657A3
		public static IHeadStyleNormal CreateFromSetValue([Nullable(2)] IHeadStyleNormal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleNormal
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B9F RID: 39839 RVA: 0x001675B6 File Offset: 0x001657B6
		public new IHeadStyleNormal_SetValue ToSetValue()
		{
			return new IHeadStyleNormal_SetValue
			{
				Type = this.Type,
				WhoId = this.WhoId
			};
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x06009BA0 RID: 39840 RVA: 0x001675D5 File Offset: 0x001657D5
		// (set) Token: 0x06009BA1 RID: 39841 RVA: 0x00167600 File Offset: 0x00165800
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

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x06009BA2 RID: 39842 RVA: 0x0016760E File Offset: 0x0016580E
		// (set) Token: 0x06009BA3 RID: 39843 RVA: 0x00167639 File Offset: 0x00165839
		public virtual int WhoId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WhoId;
			}
			set
			{
				this.GetOrCreatePoco().WhoId = value;
			}
		}

		// Token: 0x04005F51 RID: 24401
		[Nullable(2)]
		protected new IHeadStyleNormal FbInstance;

		// Token: 0x04005F52 RID: 24402
		[Nullable(2)]
		protected new IHeadStyleNormal_SetValue PocoInterface;
	}
}
