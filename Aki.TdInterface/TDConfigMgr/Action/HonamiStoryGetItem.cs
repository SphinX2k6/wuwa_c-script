using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001749 RID: 5961
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryGetItem : ActionParams
	{
		// Token: 0x06007E27 RID: 32295 RVA: 0x0012E330 File Offset: 0x0012C530
		private HonamiStoryGetItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HonamiStoryGetItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HonamiStoryGetItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HonamiStoryGetItem_SetValue());
			}
			return result;
		}

		// Token: 0x06007E28 RID: 32296 RVA: 0x0012E368 File Offset: 0x0012C568
		public static HonamiStoryGetItem Create([Nullable(2)] HonamiStoryGetItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryGetItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x0012E37B File Offset: 0x0012C57B
		public static HonamiStoryGetItem CreateFromSetValue([Nullable(2)] HonamiStoryGetItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HonamiStoryGetItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x0012E38E File Offset: 0x0012C58E
		public HonamiStoryGetItem_SetValue ToSetValue()
		{
			return new HonamiStoryGetItem_SetValue
			{
				ActivityId = this.ActivityId,
				ItemId = this.ItemId
			};
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x06007E2B RID: 32299 RVA: 0x0012E3AD File Offset: 0x0012C5AD
		// (set) Token: 0x06007E2C RID: 32300 RVA: 0x0012E3D8 File Offset: 0x0012C5D8
		public virtual int ActivityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActivityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActivityId;
			}
			set
			{
				this.GetOrCreatePoco().ActivityId = value;
			}
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x06007E2D RID: 32301 RVA: 0x0012E3E6 File Offset: 0x0012C5E6
		// (set) Token: 0x06007E2E RID: 32302 RVA: 0x0012E40D File Offset: 0x0012C60D
		public virtual List<int> ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				HonamiStoryGetItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x04005062 RID: 20578
		[Nullable(2)]
		protected new HonamiStoryGetItem FbInstance;

		// Token: 0x04005063 RID: 20579
		[Nullable(2)]
		protected HonamiStoryGetItem_SetValue PocoInterface;
	}
}
