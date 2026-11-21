using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015D9 RID: 5593
	public class AcceptFishingEntrust : ActionParams
	{
		// Token: 0x06007E38 RID: 32312 RVA: 0x0012D7A4 File Offset: 0x0012B9A4
		private AcceptFishingEntrust_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AcceptFishingEntrust 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AcceptFishingEntrust_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AcceptFishingEntrust_SetValue());
			}
			return result;
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x0012D7DC File Offset: 0x0012B9DC
		public static AcceptFishingEntrust Create([Nullable(2)] AcceptFishingEntrust instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AcceptFishingEntrust
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x0012D7EF File Offset: 0x0012B9EF
		public static AcceptFishingEntrust CreateFromSetValue([Nullable(2)] AcceptFishingEntrust_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AcceptFishingEntrust
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E3B RID: 32315 RVA: 0x0012D802 File Offset: 0x0012BA02
		public AcceptFishingEntrust_SetValue ToSetValue()
		{
			return new AcceptFishingEntrust_SetValue
			{
				EntrustId = this.EntrustId,
				IsAutoTracking = this.IsAutoTracking
			};
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x06007E3C RID: 32316 RVA: 0x0012D821 File Offset: 0x0012BA21
		// (set) Token: 0x06007E3D RID: 32317 RVA: 0x0012D84C File Offset: 0x0012BA4C
		public virtual int EntrustId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntrustId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntrustId;
			}
			set
			{
				this.GetOrCreatePoco().EntrustId = value;
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x06007E3E RID: 32318 RVA: 0x0012D85C File Offset: 0x0012BA5C
		// (set) Token: 0x06007E3F RID: 32319 RVA: 0x0012D896 File Offset: 0x0012BA96
		public virtual bool? IsAutoTracking
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAutoTracking;
				}
				AcceptFishingEntrust_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAutoTracking;
			}
			set
			{
				this.GetOrCreatePoco().IsAutoTracking = value;
			}
		}

		// Token: 0x04004918 RID: 18712
		[Nullable(2)]
		protected new AcceptFishingEntrust FbInstance;

		// Token: 0x04004919 RID: 18713
		[Nullable(2)]
		protected AcceptFishingEntrust_SetValue PocoInterface;
	}
}
