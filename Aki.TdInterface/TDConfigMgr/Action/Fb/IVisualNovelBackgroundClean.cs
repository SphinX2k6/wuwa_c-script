using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002814 RID: 10260
	public class IVisualNovelBackgroundClean : IVisualNovelBackgroundBase
	{
		// Token: 0x0600E46D RID: 58477 RVA: 0x0021C5C0 File Offset: 0x0021A7C0
		public static IVisualNovelBackgroundClean Create(IVisualNovelBackgroundClean? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundClean
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x0600E46E RID: 58478 RVA: 0x0021C5DF File Offset: 0x0021A7DF
		public override EVisualNovelBackgroundType Type
		{
			get
			{
				return (EVisualNovelBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x04007D6A RID: 32106
		private IVisualNovelBackgroundClean Instance;
	}
}
