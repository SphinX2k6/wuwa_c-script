using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C59 RID: 11353
	public class ToggleHighlightExploreUi : ActionParams
	{
		// Token: 0x0600F99B RID: 63899 RVA: 0x00243F34 File Offset: 0x00242134
		public static ToggleHighlightExploreUi Create(IToggleHighlightExploreUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleHighlightExploreUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D97 RID: 19863
		// (get) Token: 0x0600F99C RID: 63900 RVA: 0x00243F53 File Offset: 0x00242153
		public virtual EHighlightExploreSkillIconType Type
		{
			get
			{
				return (EHighlightExploreSkillIconType)this.Instance.Type;
			}
		}

		// Token: 0x17004D98 RID: 19864
		// (get) Token: 0x0600F99D RID: 63901 RVA: 0x00243F60 File Offset: 0x00242160
		public virtual EHighlightType? HighlightType
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

		// Token: 0x0400886D RID: 34925
		private IToggleHighlightExploreUi Instance;
	}
}
