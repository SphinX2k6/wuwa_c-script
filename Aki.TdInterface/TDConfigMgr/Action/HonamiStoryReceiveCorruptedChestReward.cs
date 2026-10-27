using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200174C RID: 5964
	[NullableContext(2)]
	[Nullable(0)]
	public class HonamiStoryReceiveCorruptedChestReward : ActionParams
	{
		// Token: 0x06007E33 RID: 32307 RVA: 0x0012E448 File Offset: 0x0012C648
		[NullableContext(1)]
		private HonamiStoryReceiveCorruptedChestReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HonamiStoryReceiveCorruptedChestReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HonamiStoryReceiveCorruptedChestReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HonamiStoryReceiveCorruptedChestReward_SetValue());
			}
			return result;
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x0012E480 File Offset: 0x0012C680
		[NullableContext(1)]
		public static HonamiStoryReceiveCorruptedChestReward Create([Nullable(2)] HonamiStoryReceiveCorruptedChestReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HonamiStoryReceiveCorruptedChestReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x0012E493 File Offset: 0x0012C693
		[NullableContext(1)]
		public static HonamiStoryReceiveCorruptedChestReward CreateFromSetValue([Nullable(2)] HonamiStoryReceiveCorruptedChestReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HonamiStoryReceiveCorruptedChestReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x0012E4A6 File Offset: 0x0012C6A6
		[NullableContext(1)]
		public HonamiStoryReceiveCorruptedChestReward_SetValue ToSetValue()
		{
			return new HonamiStoryReceiveCorruptedChestReward_SetValue
			{
				Cost = this.Cost,
				CostGroup = this.CostGroup,
				ChangeSelfEntityStateAfterReceived = this.ChangeSelfEntityStateAfterReceived
			};
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x06007E37 RID: 32311 RVA: 0x0012E4D1 File Offset: 0x0012C6D1
		// (set) Token: 0x06007E38 RID: 32312 RVA: 0x0012E4FC File Offset: 0x0012C6FC
		public virtual int Cost
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Cost;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Cost;
			}
			set
			{
				this.GetOrCreatePoco().Cost = value;
			}
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x06007E39 RID: 32313 RVA: 0x0012E50C File Offset: 0x0012C70C
		// (set) Token: 0x06007E3A RID: 32314 RVA: 0x0012E546 File Offset: 0x0012C746
		public virtual int? CostGroup
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CostGroup;
				}
				HonamiStoryReceiveCorruptedChestReward_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CostGroup;
			}
			set
			{
				this.GetOrCreatePoco().CostGroup = value;
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x06007E3B RID: 32315 RVA: 0x0012E554 File Offset: 0x0012C754
		// (set) Token: 0x06007E3C RID: 32316 RVA: 0x0012E57B File Offset: 0x0012C77B
		public virtual string ChangeSelfEntityStateAfterReceived
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfEntityStateAfterReceived;
				}
				HonamiStoryReceiveCorruptedChestReward_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ChangeSelfEntityStateAfterReceived;
			}
			set
			{
				this.GetOrCreatePoco().ChangeSelfEntityStateAfterReceived = value;
			}
		}

		// Token: 0x04005067 RID: 20583
		protected new HonamiStoryReceiveCorruptedChestReward FbInstance;

		// Token: 0x04005068 RID: 20584
		protected HonamiStoryReceiveCorruptedChestReward_SetValue PocoInterface;
	}
}
