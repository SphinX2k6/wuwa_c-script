using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0B RID: 10763
	public class RoverRogueCreateRoomReward : ActionParams
	{
		// Token: 0x0600ED68 RID: 60776 RVA: 0x00229D12 File Offset: 0x00227F12
		[NullableContext(1)]
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

		// Token: 0x17004B14 RID: 19220
		// (get) Token: 0x0600ED69 RID: 60777 RVA: 0x00229D31 File Offset: 0x00227F31
		public virtual int RewardType
		{
			get
			{
				return this.Instance.RewardType;
			}
		}

		// Token: 0x040082AF RID: 33455
		private IRoverRogueCreateRoomReward Instance;
	}
}
