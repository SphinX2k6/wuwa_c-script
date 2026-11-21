using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002813 RID: 10259
	public class IVisualNovelBackgroundLoad : IVisualNovelBackgroundBase
	{
		// Token: 0x0600E469 RID: 58473 RVA: 0x0021C57F File Offset: 0x0021A77F
		public static IVisualNovelBackgroundLoad Create(IVisualNovelBackgroundLoad? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundLoad
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x0600E46A RID: 58474 RVA: 0x0021C59E File Offset: 0x0021A79E
		public override EVisualNovelBackgroundType Type
		{
			get
			{
				return (EVisualNovelBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x0600E46B RID: 58475 RVA: 0x0021C5AB File Offset: 0x0021A7AB
		public virtual int BackgroundId
		{
			get
			{
				return this.Instance.BackgroundId;
			}
		}

		// Token: 0x04007D69 RID: 32105
		private IVisualNovelBackgroundLoad Instance;
	}
}
