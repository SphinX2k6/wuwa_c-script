using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016CE RID: 5838
	public class DollGrabItemDelivery : ActionParams
	{
		// Token: 0x060082C1 RID: 33473 RVA: 0x001393D4 File Offset: 0x001375D4
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

		// Token: 0x060082C2 RID: 33474 RVA: 0x0013940C File Offset: 0x0013760C
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

		// Token: 0x060082C3 RID: 33475 RVA: 0x0013941F File Offset: 0x0013761F
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

		// Token: 0x060082C4 RID: 33476 RVA: 0x00139432 File Offset: 0x00137632
		public DollGrabItemDelivery_SetValue ToSetValue()
		{
			return new DollGrabItemDelivery_SetValue
			{
				ShowcaseId = this.ShowcaseId
			};
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x060082C5 RID: 33477 RVA: 0x00139445 File Offset: 0x00137645
		// (set) Token: 0x060082C6 RID: 33478 RVA: 0x00139470 File Offset: 0x00137670
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

		// Token: 0x04004AED RID: 19181
		[Nullable(2)]
		protected new DollGrabItemDelivery FbInstance;

		// Token: 0x04004AEE RID: 19182
		[Nullable(2)]
		protected DollGrabItemDelivery_SetValue PocoInterface;
	}
}
