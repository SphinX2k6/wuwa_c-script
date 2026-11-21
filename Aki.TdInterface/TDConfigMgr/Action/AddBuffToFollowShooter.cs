using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015E4 RID: 5604
	public class AddBuffToFollowShooter : ActionParams
	{
		// Token: 0x06007E73 RID: 32371 RVA: 0x0012DECC File Offset: 0x0012C0CC
		private AddBuffToFollowShooter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AddBuffToFollowShooter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AddBuffToFollowShooter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AddBuffToFollowShooter_SetValue());
			}
			return result;
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x0012DF04 File Offset: 0x0012C104
		public static AddBuffToFollowShooter Create([Nullable(2)] AddBuffToFollowShooter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddBuffToFollowShooter
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x0012DF17 File Offset: 0x0012C117
		public static AddBuffToFollowShooter CreateFromSetValue([Nullable(2)] AddBuffToFollowShooter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AddBuffToFollowShooter
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x0012DF2A File Offset: 0x0012C12A
		public AddBuffToFollowShooter_SetValue ToSetValue()
		{
			return new AddBuffToFollowShooter_SetValue
			{
				BuffIds = this.BuffIds,
				FollowShooterId = this.FollowShooterId
			};
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x06007E77 RID: 32375 RVA: 0x0012DF49 File Offset: 0x0012C149
		// (set) Token: 0x06007E78 RID: 32376 RVA: 0x0012DF70 File Offset: 0x0012C170
		public virtual List<long> BuffIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffIds;
				}
				AddBuffToFollowShooter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BuffIds;
			}
			set
			{
				this.GetOrCreatePoco().BuffIds = value;
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x06007E79 RID: 32377 RVA: 0x0012DF80 File Offset: 0x0012C180
		// (set) Token: 0x06007E7A RID: 32378 RVA: 0x0012DFBA File Offset: 0x0012C1BA
		public virtual int? FollowShooterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FollowShooterId;
				}
				AddBuffToFollowShooter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FollowShooterId;
			}
			set
			{
				this.GetOrCreatePoco().FollowShooterId = value;
			}
		}

		// Token: 0x04004931 RID: 18737
		[Nullable(2)]
		protected new AddBuffToFollowShooter FbInstance;

		// Token: 0x04004932 RID: 18738
		[Nullable(2)]
		protected AddBuffToFollowShooter_SetValue PocoInterface;
	}
}
