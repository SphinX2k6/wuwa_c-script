using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DD RID: 9181
	public class RoverRogueCreateRoomReward : ActionParams
	{
		// Token: 0x0600C7FA RID: 51194 RVA: 0x001C9870 File Offset: 0x001C7A70
		private RoverRogueCreateRoomReward_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RoverRogueCreateRoomReward 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RoverRogueCreateRoomReward_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RoverRogueCreateRoomReward_SetValue());
			}
			return result;
		}

		// Token: 0x0600C7FB RID: 51195 RVA: 0x001C98A8 File Offset: 0x001C7AA8
		public static RoverRogueCreateRoomReward Create([Nullable(2)] RoverRogueCreateRoomReward instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoverRogueCreateRoomReward
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C7FC RID: 51196 RVA: 0x001C98BB File Offset: 0x001C7ABB
		public static RoverRogueCreateRoomReward CreateFromSetValue([Nullable(2)] RoverRogueCreateRoomReward_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RoverRogueCreateRoomReward
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C7FD RID: 51197 RVA: 0x001C98CE File Offset: 0x001C7ACE
		public RoverRogueCreateRoomReward_SetValue ToSetValue()
		{
			return new RoverRogueCreateRoomReward_SetValue
			{
				RewardType = this.RewardType
			};
		}

		// Token: 0x17003C49 RID: 15433
		// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x001C98E1 File Offset: 0x001C7AE1
		// (set) Token: 0x0600C7FF RID: 51199 RVA: 0x001C990C File Offset: 0x001C7B0C
		public virtual int RewardType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RewardType;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RewardType;
			}
			set
			{
				this.GetOrCreatePoco().RewardType = value;
			}
		}

		// Token: 0x040076BD RID: 30397
		[Nullable(2)]
		protected new RoverRogueCreateRoomReward FbInstance;

		// Token: 0x040076BE RID: 30398
		[Nullable(2)]
		protected RoverRogueCreateRoomReward_SetValue PocoInterface;
	}
}
