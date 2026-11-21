using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002810 RID: 10256
	public class IVisualNovelCgLoadImage : IVisualNovelCgBase
	{
		// Token: 0x0600E45F RID: 58463 RVA: 0x0021C4D6 File Offset: 0x0021A6D6
		public static IVisualNovelCgLoadImage Create(IVisualNovelCgLoadImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgLoadImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x0600E460 RID: 58464 RVA: 0x0021C4F5 File Offset: 0x0021A6F5
		public override EVisualNovelCgType Type
		{
			get
			{
				return (EVisualNovelCgType)this.Instance.Type;
			}
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x0600E461 RID: 58465 RVA: 0x0021C502 File Offset: 0x0021A702
		public virtual int ImageId
		{
			get
			{
				return this.Instance.ImageId;
			}
		}

		// Token: 0x04007D66 RID: 32102
		private IVisualNovelCgLoadImage Instance;
	}
}
