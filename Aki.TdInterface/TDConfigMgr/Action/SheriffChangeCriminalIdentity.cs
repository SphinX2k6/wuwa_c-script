using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002460 RID: 9312
	public class SheriffChangeCriminalIdentity : ActionParams
	{
		// Token: 0x0600CAA7 RID: 51879 RVA: 0x001CEA20 File Offset: 0x001CCC20
		private SheriffChangeCriminalIdentity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SheriffChangeCriminalIdentity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SheriffChangeCriminalIdentity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SheriffChangeCriminalIdentity_SetValue());
			}
			return result;
		}

		// Token: 0x0600CAA8 RID: 51880 RVA: 0x001CEA58 File Offset: 0x001CCC58
		public static SheriffChangeCriminalIdentity Create([Nullable(2)] SheriffChangeCriminalIdentity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffChangeCriminalIdentity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CAA9 RID: 51881 RVA: 0x001CEA6B File Offset: 0x001CCC6B
		public static SheriffChangeCriminalIdentity CreateFromSetValue([Nullable(2)] SheriffChangeCriminalIdentity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SheriffChangeCriminalIdentity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CAAA RID: 51882 RVA: 0x001CEA7E File Offset: 0x001CCC7E
		public SheriffChangeCriminalIdentity_SetValue ToSetValue()
		{
			return new SheriffChangeCriminalIdentity_SetValue
			{
				CriminalId = this.CriminalId,
				IdentityId = this.IdentityId
			};
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x0600CAAB RID: 51883 RVA: 0x001CEA9D File Offset: 0x001CCC9D
		// (set) Token: 0x0600CAAC RID: 51884 RVA: 0x001CEAC8 File Offset: 0x001CCCC8
		public virtual int CriminalId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CriminalId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CriminalId;
			}
			set
			{
				this.GetOrCreatePoco().CriminalId = value;
			}
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x0600CAAD RID: 51885 RVA: 0x001CEAD6 File Offset: 0x001CCCD6
		// (set) Token: 0x0600CAAE RID: 51886 RVA: 0x001CEB01 File Offset: 0x001CCD01
		public virtual int IdentityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IdentityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.IdentityId;
			}
			set
			{
				this.GetOrCreatePoco().IdentityId = value;
			}
		}

		// Token: 0x04007824 RID: 30756
		[Nullable(2)]
		protected new SheriffChangeCriminalIdentity FbInstance;

		// Token: 0x04007825 RID: 30757
		[Nullable(2)]
		protected SheriffChangeCriminalIdentity_SetValue PocoInterface;
	}
}
