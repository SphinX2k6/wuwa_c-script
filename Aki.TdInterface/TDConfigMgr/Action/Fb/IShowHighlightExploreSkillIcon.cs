using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002975 RID: 10613
	public class IShowHighlightExploreSkillIcon : ToggleHighlightExploreUi
	{
		// Token: 0x0600EB29 RID: 60201 RVA: 0x002268E6 File Offset: 0x00224AE6
		[NullableContext(1)]
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

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x0600EB2A RID: 60202 RVA: 0x00226905 File Offset: 0x00224B05
		public override EHighlightExploreSkillIconType Type
		{
			get
			{
				return (EHighlightExploreSkillIconType)this.Instance.Type;
			}
		}

		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x0600EB2B RID: 60203 RVA: 0x00226914 File Offset: 0x00224B14
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

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x0600EB2C RID: 60204 RVA: 0x0022694A File Offset: 0x00224B4A
		public virtual int SkillType
		{
			get
			{
				return this.Instance.SkillType;
			}
		}

		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x0600EB2D RID: 60205 RVA: 0x00226957 File Offset: 0x00224B57
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x0600EB2E RID: 60206 RVA: 0x00226964 File Offset: 0x00224B64
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

		// Token: 0x0400818D RID: 33165
		private IShowHighlightExploreSkillIcon Instance;
	}
}
