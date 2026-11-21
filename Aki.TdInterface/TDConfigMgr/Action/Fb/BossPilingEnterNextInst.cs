using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DEC RID: 11756
	public class BossPilingEnterNextInst : ActionParams
	{
		// Token: 0x0600FFB0 RID: 65456 RVA: 0x0024D418 File Offset: 0x0024B618
		public static BossPilingEnterNextInst Create(IBossPilingEnterNextInst? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BossPilingEnterNextInst
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008B90 RID: 35728
		private IBossPilingEnterNextInst Instance;
	}
}
