using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D7 RID: 9431
	public class GetRewardByInteract : ActionParams
	{
		// Token: 0x0600D2A0 RID: 53920 RVA: 0x001F3F22 File Offset: 0x001F2122
		[NullableContext(1)]
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

		// Token: 0x04007385 RID: 29573
		private IGetRewardByInteract Instance;
	}
}
