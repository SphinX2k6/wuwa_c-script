using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C5B RID: 11355
	public class IHideHighlightExploreSkillIconTargetConfig
	{
		// Token: 0x0600F9A6 RID: 63910 RVA: 0x0024405A File Offset: 0x0024225A
		public static IHideHighlightExploreSkillIconTargetConfig Create(IHideHighlightExploreSkillIconTargetConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideHighlightExploreSkillIconTargetConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D9E RID: 19870
		// (get) Token: 0x0600F9A7 RID: 63911 RVA: 0x00244079 File Offset: 0x00242279
		public virtual int SkillType
		{
			get
			{
				return this.Instance.SkillType;
			}
		}

		// Token: 0x17004D9F RID: 19871
		// (get) Token: 0x0600F9A8 RID: 63912 RVA: 0x00244088 File Offset: 0x00242288
		public virtual int? ItemId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ItemId);
			}
		}

		// Token: 0x0400886F RID: 34927
		private IHideHighlightExploreSkillIconTargetConfig Instance;
	}
}
