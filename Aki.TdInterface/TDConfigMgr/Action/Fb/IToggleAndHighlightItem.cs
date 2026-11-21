using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C5D RID: 11357
	public class IToggleAndHighlightItem : ToggleHighlightExploreUi
	{
		// Token: 0x0600F9AF RID: 63919 RVA: 0x00244166 File Offset: 0x00242366
		public static IToggleAndHighlightItem Create(IToggleAndHighlightItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleAndHighlightItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DA3 RID: 19875
		// (get) Token: 0x0600F9B0 RID: 63920 RVA: 0x00244185 File Offset: 0x00242385
		public override EHighlightExploreSkillIconType Type
		{
			get
			{
				return (EHighlightExploreSkillIconType)this.Instance.Type;
			}
		}

		// Token: 0x17004DA4 RID: 19876
		// (get) Token: 0x0600F9B1 RID: 63921 RVA: 0x00244194 File Offset: 0x00242394
		public override EHighlightType? HighlightType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EHighlightType?((EHighlightType)this.Instance.HighlightType);
			}
		}

		// Token: 0x17004DA5 RID: 19877
		// (get) Token: 0x0600F9B2 RID: 63922 RVA: 0x002441CA File Offset: 0x002423CA
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x17004DA6 RID: 19878
		// (get) Token: 0x0600F9B3 RID: 63923 RVA: 0x002441D7 File Offset: 0x002423D7
		public virtual int SkillType
		{
			get
			{
				return this.Instance.SkillType;
			}
		}

		// Token: 0x17004DA7 RID: 19879
		// (get) Token: 0x0600F9B4 RID: 63924 RVA: 0x002441E4 File Offset: 0x002423E4
		public virtual bool? IsShowTips
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsShowTips);
			}
		}

		// Token: 0x17004DA8 RID: 19880
		// (get) Token: 0x0600F9B5 RID: 63925 RVA: 0x0024421C File Offset: 0x0024241C
		public virtual bool? IsSwitchBack
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSwitchBack);
			}
		}

		// Token: 0x04008873 RID: 34931
		private IToggleAndHighlightItem Instance;
	}
}
