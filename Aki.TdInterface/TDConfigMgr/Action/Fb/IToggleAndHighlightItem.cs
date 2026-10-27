using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002977 RID: 10615
	public class IToggleAndHighlightItem : ToggleHighlightExploreUi
	{
		// Token: 0x0600EB34 RID: 60212 RVA: 0x00226A0E File Offset: 0x00224C0E
		[NullableContext(1)]
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

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x0600EB35 RID: 60213 RVA: 0x00226A2D File Offset: 0x00224C2D
		public override EHighlightExploreSkillIconType Type
		{
			get
			{
				return (EHighlightExploreSkillIconType)this.Instance.Type;
			}
		}

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x0600EB36 RID: 60214 RVA: 0x00226A3C File Offset: 0x00224C3C
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

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x0600EB37 RID: 60215 RVA: 0x00226A72 File Offset: 0x00224C72
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x0600EB38 RID: 60216 RVA: 0x00226A7F File Offset: 0x00224C7F
		public virtual int SkillType
		{
			get
			{
				return this.Instance.SkillType;
			}
		}

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x0600EB39 RID: 60217 RVA: 0x00226A8C File Offset: 0x00224C8C
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

		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x0600EB3A RID: 60218 RVA: 0x00226AC4 File Offset: 0x00224CC4
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

		// Token: 0x0400818F RID: 33167
		private IToggleAndHighlightItem Instance;
	}
}
