using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002819 RID: 10265
	public class IVisualNovelPortraitTransform
	{
		// Token: 0x0600E47E RID: 58494 RVA: 0x0021C6DE File Offset: 0x0021A8DE
		public static IVisualNovelPortraitTransform Create(IVisualNovelPortraitTransform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPortraitTransform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x0600E47F RID: 58495 RVA: 0x0021C700 File Offset: 0x0021A900
		public virtual int? PosX
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PosX);
			}
		}

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x0600E480 RID: 58496 RVA: 0x0021C738 File Offset: 0x0021A938
		public virtual int? PosY
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PosY);
			}
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x0600E481 RID: 58497 RVA: 0x0021C770 File Offset: 0x0021A970
		public virtual float? Scale
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Scale);
			}
		}

		// Token: 0x04007D6F RID: 32111
		private IVisualNovelPortraitTransform Instance;
	}
}
