using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200298E RID: 10638
	public class RogueReceiveReward : ActionParams
	{
		// Token: 0x0600EBE4 RID: 60388 RVA: 0x0022BD13 File Offset: 0x00229F13
		public static RogueReceiveReward Create(IRogueReceiveReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RogueReceiveReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004576 RID: 17782
		// (get) Token: 0x0600EBE5 RID: 60389 RVA: 0x0022BD34 File Offset: 0x00229F34
		public virtual ERogueRewardReceiveType? RogueRewardReceiveType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ERogueRewardReceiveType?((ERogueRewardReceiveType)this.Instance.RogueRewardReceiveType);
			}
		}

		// Token: 0x040081E8 RID: 33256
		private IRogueReceiveReward Instance;
	}
}
