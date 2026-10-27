using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026CA RID: 9930
	public class RogueReceiveReward : ActionParams
	{
		// Token: 0x0600DE08 RID: 56840 RVA: 0x0020F4D3 File Offset: 0x0020D6D3
		[NullableContext(1)]
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

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x0600DE09 RID: 56841 RVA: 0x0020F4F4 File Offset: 0x0020D6F4
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

		// Token: 0x04007B48 RID: 31560
		private IRogueReceiveReward Instance;
	}
}
