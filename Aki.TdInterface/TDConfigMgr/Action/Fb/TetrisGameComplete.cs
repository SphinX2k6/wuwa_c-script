using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DE9 RID: 11753
	public class TetrisGameComplete : ActionParams
	{
		// Token: 0x0600FFA9 RID: 65449 RVA: 0x0024D396 File Offset: 0x0024B596
		public static TetrisGameComplete Create(ITetrisGameComplete? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TetrisGameComplete
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008B8D RID: 35725
		private ITetrisGameComplete Instance;
	}
}
