using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001480 RID: 5248
	[NullableContext(1)]
	[Nullable(0)]
	public class AcceptFishingEntrust : ActionParams
	{
		// Token: 0x0600776B RID: 30571 RVA: 0x0011EB58 File Offset: 0x0011CD58
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

		// Token: 0x0600776C RID: 30572 RVA: 0x0011EB90 File Offset: 0x0011CD90
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

		// Token: 0x0600776D RID: 30573 RVA: 0x0011EBA3 File Offset: 0x0011CDA3
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

		// Token: 0x0600776E RID: 30574 RVA: 0x0011EBB6 File Offset: 0x0011CDB6
		public AcceptFishingEntrust_SetValue ToSetValue()
		{
			return new AcceptFishingEntrust_SetValue
			{
				EntrustId = this.EntrustId,
				IsAutoTracking = this.IsAutoTracking
			};
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600776F RID: 30575 RVA: 0x0011EBD5 File Offset: 0x0011CDD5
		// (set) Token: 0x06007770 RID: 30576 RVA: 0x0011EC00 File Offset: 0x0011CE00
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

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x06007771 RID: 30577 RVA: 0x0011EC10 File Offset: 0x0011CE10
		// (set) Token: 0x06007772 RID: 30578 RVA: 0x0011EC4A File Offset: 0x0011CE4A
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

		// Token: 0x0400457D RID: 17789
		[Nullable(2)]
		protected new AcceptFishingEntrust FbInstance;

		// Token: 0x0400457E RID: 17790
		[Nullable(2)]
		protected AcceptFishingEntrust_SetValue PocoInterface;
	}
}
