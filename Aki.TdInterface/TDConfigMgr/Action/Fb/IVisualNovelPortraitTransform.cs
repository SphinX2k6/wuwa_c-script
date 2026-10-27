using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002570 RID: 9584
	public class IVisualNovelPortraitTransform
	{
		// Token: 0x0600D713 RID: 55059 RVA: 0x00200AD5 File Offset: 0x001FECD5
		[NullableContext(1)]
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

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x0600D714 RID: 55060 RVA: 0x00200AF4 File Offset: 0x001FECF4
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

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x0600D715 RID: 55061 RVA: 0x00200B2C File Offset: 0x001FED2C
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

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x0600D716 RID: 55062 RVA: 0x00200B64 File Offset: 0x001FED64
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

		// Token: 0x04007712 RID: 30482
		private IVisualNovelPortraitTransform Instance;
	}
}
