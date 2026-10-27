using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001570 RID: 5488
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabItemDelivery : ActionParams
	{
		// Token: 0x06007BE3 RID: 31715 RVA: 0x0012A328 File Offset: 0x00128528
		private DollGrabItemDelivery_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DollGrabItemDelivery 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DollGrabItemDelivery_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DollGrabItemDelivery_SetValue());
			}
			return result;
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x0012A360 File Offset: 0x00128560
		public static DollGrabItemDelivery Create([Nullable(2)] DollGrabItemDelivery instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DollGrabItemDelivery
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x0012A373 File Offset: 0x00128573
		public static DollGrabItemDelivery CreateFromSetValue([Nullable(2)] DollGrabItemDelivery_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DollGrabItemDelivery
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x0012A386 File Offset: 0x00128586
		public DollGrabItemDelivery_SetValue ToSetValue()
		{
			return new DollGrabItemDelivery_SetValue
			{
				ShowcaseId = this.ShowcaseId
			};
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x06007BE7 RID: 31719 RVA: 0x0012A399 File Offset: 0x00128599
		// (set) Token: 0x06007BE8 RID: 31720 RVA: 0x0012A3C4 File Offset: 0x001285C4
		public virtual int ShowcaseId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowcaseId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ShowcaseId;
			}
			set
			{
				this.GetOrCreatePoco().ShowcaseId = value;
			}
		}

		// Token: 0x0400474D RID: 18253
		[Nullable(2)]
		protected new DollGrabItemDelivery FbInstance;

		// Token: 0x0400474E RID: 18254
		[Nullable(2)]
		protected DollGrabItemDelivery_SetValue PocoInterface;
	}
}
