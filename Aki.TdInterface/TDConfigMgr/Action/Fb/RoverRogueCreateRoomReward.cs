using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CF8 RID: 11512
	public class RoverRogueCreateRoomReward : ActionParams
	{
		// Token: 0x0600FBFF RID: 64511 RVA: 0x00247696 File Offset: 0x00245896
		public static RoverRogueCreateRoomReward Create(IRoverRogueCreateRoomReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoverRogueCreateRoomReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EBD RID: 20157
		// (get) Token: 0x0600FC00 RID: 64512 RVA: 0x002476B5 File Offset: 0x002458B5
		public virtual int RewardType
		{
			get
			{
				return this.Instance.RewardType;
			}
		}

		// Token: 0x040089A0 RID: 35232
		private IRoverRogueCreateRoomReward Instance;
	}
}
