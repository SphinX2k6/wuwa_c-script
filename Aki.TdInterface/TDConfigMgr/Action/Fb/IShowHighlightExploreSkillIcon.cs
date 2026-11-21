using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C5A RID: 11354
	public class IShowHighlightExploreSkillIcon : ToggleHighlightExploreUi
	{
		// Token: 0x0600F99F RID: 63903 RVA: 0x00243F9E File Offset: 0x0024219E
		public static IShowHighlightExploreSkillIcon Create(IShowHighlightExploreSkillIcon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowHighlightExploreSkillIcon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D99 RID: 19865
		// (get) Token: 0x0600F9A0 RID: 63904 RVA: 0x00243FBD File Offset: 0x002421BD
		public override EHighlightExploreSkillIconType Type
		{
			get
			{
				return (EHighlightExploreSkillIconType)this.Instance.Type;
			}
		}

		// Token: 0x17004D9A RID: 19866
		// (get) Token: 0x0600F9A1 RID: 63905 RVA: 0x00243FCC File Offset: 0x002421CC
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

		// Token: 0x17004D9B RID: 19867
		// (get) Token: 0x0600F9A2 RID: 63906 RVA: 0x00244002 File Offset: 0x00242202
		public virtual int SkillType
		{
			get
			{
				return this.Instance.SkillType;
			}
		}

		// Token: 0x17004D9C RID: 19868
		// (get) Token: 0x0600F9A3 RID: 63907 RVA: 0x0024400F File Offset: 0x0024220F
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004D9D RID: 19869
		// (get) Token: 0x0600F9A4 RID: 63908 RVA: 0x0024401C File Offset: 0x0024221C
		public virtual bool? IsSwitchBack
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSwitchBack);
			}
		}

		// Token: 0x0400886E RID: 34926
		private IShowHighlightExploreSkillIcon Instance;
	}
}
