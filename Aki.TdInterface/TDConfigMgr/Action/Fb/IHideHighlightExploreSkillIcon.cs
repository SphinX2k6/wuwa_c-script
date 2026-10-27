using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002976 RID: 10614
	public class IHideHighlightExploreSkillIcon : ToggleHighlightExploreUi
	{
		// Token: 0x0600EB30 RID: 60208 RVA: 0x002269A2 File Offset: 0x00224BA2
		[NullableContext(1)]
		public static IHideHighlightExploreSkillIcon Create(IHideHighlightExploreSkillIcon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideHighlightExploreSkillIcon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x0600EB31 RID: 60209 RVA: 0x002269C1 File Offset: 0x00224BC1
		public override EHighlightExploreSkillIconType Type
		{
			get
			{
				return (EHighlightExploreSkillIconType)this.Instance.Type;
			}
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x0600EB32 RID: 60210 RVA: 0x002269D0 File Offset: 0x00224BD0
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

		// Token: 0x0400818E RID: 33166
		private IHideHighlightExploreSkillIcon Instance;
	}
}
