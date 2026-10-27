using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200148B RID: 5259
	[NullableContext(1)]
	[Nullable(0)]
	public class AddBuffToFollowShooter : ActionParams
	{
		// Token: 0x060077A6 RID: 30630 RVA: 0x0011F280 File Offset: 0x0011D480
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

		// Token: 0x060077A7 RID: 30631 RVA: 0x0011F2B8 File Offset: 0x0011D4B8
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

		// Token: 0x060077A8 RID: 30632 RVA: 0x0011F2CB File Offset: 0x0011D4CB
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

		// Token: 0x060077A9 RID: 30633 RVA: 0x0011F2DE File Offset: 0x0011D4DE
		public AddBuffToFollowShooter_SetValue ToSetValue()
		{
			return new AddBuffToFollowShooter_SetValue
			{
				BuffIds = this.BuffIds,
				FollowShooterId = this.FollowShooterId
			};
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x060077AA RID: 30634 RVA: 0x0011F2FD File Offset: 0x0011D4FD
		// (set) Token: 0x060077AB RID: 30635 RVA: 0x0011F324 File Offset: 0x0011D524
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

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x0011F334 File Offset: 0x0011D534
		// (set) Token: 0x060077AD RID: 30637 RVA: 0x0011F36E File Offset: 0x0011D56E
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

		// Token: 0x04004596 RID: 17814
		[Nullable(2)]
		protected new AddBuffToFollowShooter FbInstance;

		// Token: 0x04004597 RID: 17815
		[Nullable(2)]
		protected AddBuffToFollowShooter_SetValue PocoInterface;
	}
}
