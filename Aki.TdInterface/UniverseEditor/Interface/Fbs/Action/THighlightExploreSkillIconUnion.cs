using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F04 RID: 32516
	public class THighlightExploreSkillIconUnion
	{
		// Token: 0x1700F27B RID: 62075
		// (get) Token: 0x0603AA6B RID: 240235 RVA: 0x007E3A08 File Offset: 0x007E1C08
		// (set) Token: 0x0603AA6C RID: 240236 RVA: 0x007E3A10 File Offset: 0x007E1C10
		public THighlightExploreSkillIcon Type { get; set; }

		// Token: 0x1700F27C RID: 62076
		// (get) Token: 0x0603AA6D RID: 240237 RVA: 0x007E3A19 File Offset: 0x007E1C19
		// (set) Token: 0x0603AA6E RID: 240238 RVA: 0x007E3A21 File Offset: 0x007E1C21
		public object Value { get; set; }

		// Token: 0x0603AA6F RID: 240239 RVA: 0x007E3A2A File Offset: 0x007E1C2A
		public THighlightExploreSkillIconUnion()
		{
			this.Type = THighlightExploreSkillIcon.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA70 RID: 240240 RVA: 0x007E3A40 File Offset: 0x007E1C40
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA71 RID: 240241 RVA: 0x007E3A52 File Offset: 0x007E1C52
		public IHideHighlightExploreSkillIconT AsIHideHighlightExploreSkillIcon()
		{
			return this.As<IHideHighlightExploreSkillIconT>();
		}

		// Token: 0x0603AA72 RID: 240242 RVA: 0x007E3A5A File Offset: 0x007E1C5A
		public static THighlightExploreSkillIconUnion FromIHideHighlightExploreSkillIcon(IHideHighlightExploreSkillIconT _ihidehighlightexploreskillicon)
		{
			return new THighlightExploreSkillIconUnion
			{
				Type = THighlightExploreSkillIcon.IHideHighlightExploreSkillIcon,
				Value = _ihidehighlightexploreskillicon
			};
		}

		// Token: 0x0603AA73 RID: 240243 RVA: 0x007E3A6F File Offset: 0x007E1C6F
		public IShowHighlightExploreSkillIconT AsIShowHighlightExploreSkillIcon()
		{
			return this.As<IShowHighlightExploreSkillIconT>();
		}

		// Token: 0x0603AA74 RID: 240244 RVA: 0x007E3A77 File Offset: 0x007E1C77
		public static THighlightExploreSkillIconUnion FromIShowHighlightExploreSkillIcon(IShowHighlightExploreSkillIconT _ishowhighlightexploreskillicon)
		{
			return new THighlightExploreSkillIconUnion
			{
				Type = THighlightExploreSkillIcon.IShowHighlightExploreSkillIcon,
				Value = _ishowhighlightexploreskillicon
			};
		}

		// Token: 0x0603AA75 RID: 240245 RVA: 0x007E3A8C File Offset: 0x007E1C8C
		public IToggleAndHighlightItemT AsIToggleAndHighlightItem()
		{
			return this.As<IToggleAndHighlightItemT>();
		}

		// Token: 0x0603AA76 RID: 240246 RVA: 0x007E3A94 File Offset: 0x007E1C94
		public static THighlightExploreSkillIconUnion FromIToggleAndHighlightItem(IToggleAndHighlightItemT _itoggleandhighlightitem)
		{
			return new THighlightExploreSkillIconUnion
			{
				Type = THighlightExploreSkillIcon.IToggleAndHighlightItem,
				Value = _itoggleandhighlightitem
			};
		}

		// Token: 0x0603AA77 RID: 240247 RVA: 0x007E3AAC File Offset: 0x007E1CAC
		public static int Pack(FlatBufferBuilder builder, THighlightExploreSkillIconUnion _o)
		{
			switch (_o.Type)
			{
			case THighlightExploreSkillIcon.IHideHighlightExploreSkillIcon:
				return IHideHighlightExploreSkillIcon.Pack(builder, _o.AsIHideHighlightExploreSkillIcon()).Value;
			case THighlightExploreSkillIcon.IShowHighlightExploreSkillIcon:
				return IShowHighlightExploreSkillIcon.Pack(builder, _o.AsIShowHighlightExploreSkillIcon()).Value;
			case THighlightExploreSkillIcon.IToggleAndHighlightItem:
				return IToggleAndHighlightItem.Pack(builder, _o.AsIToggleAndHighlightItem()).Value;
			default:
				return 0;
			}
		}
	}
}
