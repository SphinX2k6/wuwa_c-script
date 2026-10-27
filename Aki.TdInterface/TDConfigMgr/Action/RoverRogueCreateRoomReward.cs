using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200217C RID: 8572
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverRogueCreateRoomReward : ActionParams
	{
		// Token: 0x0600BC6C RID: 48236 RVA: 0x001B26BC File Offset: 0x001B08BC
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

		// Token: 0x0600BC6D RID: 48237 RVA: 0x001B26F4 File Offset: 0x001B08F4
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

		// Token: 0x0600BC6E RID: 48238 RVA: 0x001B2707 File Offset: 0x001B0907
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

		// Token: 0x0600BC6F RID: 48239 RVA: 0x001B271A File Offset: 0x001B091A
		public RoverRogueCreateRoomReward_SetValue ToSetValue()
		{
			return new RoverRogueCreateRoomReward_SetValue
			{
				RewardType = this.RewardType
			};
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600BC70 RID: 48240 RVA: 0x001B272D File Offset: 0x001B092D
		// (set) Token: 0x0600BC71 RID: 48241 RVA: 0x001B2758 File Offset: 0x001B0958
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

		// Token: 0x04007088 RID: 28808
		[Nullable(2)]
		protected new RoverRogueCreateRoomReward FbInstance;

		// Token: 0x04007089 RID: 28809
		[Nullable(2)]
		protected RoverRogueCreateRoomReward_SetValue PocoInterface;
	}
}
