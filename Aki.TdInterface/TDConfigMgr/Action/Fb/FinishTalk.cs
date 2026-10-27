using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025B4 RID: 9652
	public class FinishTalk : ActionParams
	{
		// Token: 0x0600D925 RID: 55589 RVA: 0x00206660 File Offset: 0x00204860
		[NullableContext(1)]
		public static FinishTalk Create(IFinishTalk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishTalk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040078A4 RID: 30884
		private IFinishTalk Instance;
	}
}
