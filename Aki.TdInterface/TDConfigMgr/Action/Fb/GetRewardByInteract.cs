using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277C RID: 10108
	public class GetRewardByInteract : ActionParams
	{
		// Token: 0x0600DFF5 RID: 57333 RVA: 0x0020F77E File Offset: 0x0020D97E
		public static GetRewardByInteract Create(IGetRewardByInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GetRewardByInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040079D2 RID: 31186
		private IGetRewardByInteract Instance;
	}
}
