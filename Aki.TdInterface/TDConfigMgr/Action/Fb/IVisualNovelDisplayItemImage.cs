using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002816 RID: 10262
	public class IVisualNovelDisplayItemImage : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600E473 RID: 58483 RVA: 0x0021C628 File Offset: 0x0021A828
		public static IVisualNovelDisplayItemImage Create(IVisualNovelDisplayItemImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x0600E474 RID: 58484 RVA: 0x0021C647 File Offset: 0x0021A847
		public override EVisualNovelDisplayItemType Type
		{
			get
			{
				return (EVisualNovelDisplayItemType)this.Instance.Type;
			}
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x0600E475 RID: 58485 RVA: 0x0021C654 File Offset: 0x0021A854
		public virtual int DisplayImageId
		{
			get
			{
				return this.Instance.DisplayImageId;
			}
		}

		// Token: 0x04007D6C RID: 32108
		private IVisualNovelDisplayItemImage Instance;
	}
}
