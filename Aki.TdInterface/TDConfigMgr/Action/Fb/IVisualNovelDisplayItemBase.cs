using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002815 RID: 10261
	public class IVisualNovelDisplayItemBase
	{
		// Token: 0x0600E470 RID: 58480 RVA: 0x0021C5F4 File Offset: 0x0021A7F4
		public static IVisualNovelDisplayItemBase Create(IVisualNovelDisplayItemBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x0600E471 RID: 58481 RVA: 0x0021C613 File Offset: 0x0021A813
		public virtual EVisualNovelDisplayItemType Type
		{
			get
			{
				return (EVisualNovelDisplayItemType)this.Instance.Type;
			}
		}

		// Token: 0x04007D6B RID: 32107
		private IVisualNovelDisplayItemBase Instance;
	}
}
