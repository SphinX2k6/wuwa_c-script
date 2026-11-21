using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002812 RID: 10258
	public class IVisualNovelBackgroundBase
	{
		// Token: 0x0600E466 RID: 58470 RVA: 0x0021C54B File Offset: 0x0021A74B
		public static IVisualNovelBackgroundBase Create(IVisualNovelBackgroundBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x0600E467 RID: 58471 RVA: 0x0021C56A File Offset: 0x0021A76A
		public virtual EVisualNovelBackgroundType Type
		{
			get
			{
				return (EVisualNovelBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x04007D68 RID: 32104
		private IVisualNovelBackgroundBase Instance;
	}
}
