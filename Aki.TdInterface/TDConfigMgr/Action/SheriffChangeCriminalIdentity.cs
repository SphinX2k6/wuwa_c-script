using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021F5 RID: 8693
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffChangeCriminalIdentity : ActionParams
	{
		// Token: 0x0600BEEB RID: 48875 RVA: 0x001B7394 File Offset: 0x001B5594
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

		// Token: 0x0600BEEC RID: 48876 RVA: 0x001B73CC File Offset: 0x001B55CC
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

		// Token: 0x0600BEED RID: 48877 RVA: 0x001B73DF File Offset: 0x001B55DF
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

		// Token: 0x0600BEEE RID: 48878 RVA: 0x001B73F2 File Offset: 0x001B55F2
		public SheriffChangeCriminalIdentity_SetValue ToSetValue()
		{
			return new SheriffChangeCriminalIdentity_SetValue
			{
				CriminalId = this.CriminalId,
				IdentityId = this.IdentityId
			};
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0600BEEF RID: 48879 RVA: 0x001B7411 File Offset: 0x001B5611
		// (set) Token: 0x0600BEF0 RID: 48880 RVA: 0x001B743C File Offset: 0x001B563C
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

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0600BEF1 RID: 48881 RVA: 0x001B744A File Offset: 0x001B564A
		// (set) Token: 0x0600BEF2 RID: 48882 RVA: 0x001B7475 File Offset: 0x001B5675
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

		// Token: 0x040071DB RID: 29147
		[Nullable(2)]
		protected new SheriffChangeCriminalIdentity FbInstance;

		// Token: 0x040071DC RID: 29148
		[Nullable(2)]
		protected SheriffChangeCriminalIdentity_SetValue PocoInterface;
	}
}
