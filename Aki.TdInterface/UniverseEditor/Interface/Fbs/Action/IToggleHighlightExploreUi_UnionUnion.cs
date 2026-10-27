using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200740D RID: 29709
	public class IToggleHighlightExploreUi_UnionUnion
	{
		// Token: 0x1700E1A4 RID: 57764
		// (get) Token: 0x06035F8B RID: 221067 RVA: 0x00757EB4 File Offset: 0x007560B4
		// (set) Token: 0x06035F8C RID: 221068 RVA: 0x00757EBC File Offset: 0x007560BC
		public IToggleHighlightExploreUi_Union Type { get; set; }

		// Token: 0x1700E1A5 RID: 57765
		// (get) Token: 0x06035F8D RID: 221069 RVA: 0x00757EC5 File Offset: 0x007560C5
		// (set) Token: 0x06035F8E RID: 221070 RVA: 0x00757ECD File Offset: 0x007560CD
		public object Value { get; set; }

		// Token: 0x06035F8F RID: 221071 RVA: 0x00757ED6 File Offset: 0x007560D6
		public IToggleHighlightExploreUi_UnionUnion()
		{
			this.Type = IToggleHighlightExploreUi_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035F90 RID: 221072 RVA: 0x00757EEC File Offset: 0x007560EC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035F91 RID: 221073 RVA: 0x00757EFE File Offset: 0x007560FE
		public IToggleHighlightExploreUiT AsIToggleHighlightExploreUi()
		{
			return this.As<IToggleHighlightExploreUiT>();
		}

		// Token: 0x06035F92 RID: 221074 RVA: 0x00757F06 File Offset: 0x00756106
		public static IToggleHighlightExploreUi_UnionUnion FromIToggleHighlightExploreUi(IToggleHighlightExploreUiT _itogglehighlightexploreui)
		{
			return new IToggleHighlightExploreUi_UnionUnion
			{
				Type = IToggleHighlightExploreUi_Union.IToggleHighlightExploreUi,
				Value = _itogglehighlightexploreui
			};
		}

		// Token: 0x06035F93 RID: 221075 RVA: 0x00757F1B File Offset: 0x0075611B
		public IShowHighlightExploreSkillIconT AsIShowHighlightExploreSkillIcon()
		{
			return this.As<IShowHighlightExploreSkillIconT>();
		}

		// Token: 0x06035F94 RID: 221076 RVA: 0x00757F23 File Offset: 0x00756123
		public static IToggleHighlightExploreUi_UnionUnion FromIShowHighlightExploreSkillIcon(IShowHighlightExploreSkillIconT _ishowhighlightexploreskillicon)
		{
			return new IToggleHighlightExploreUi_UnionUnion
			{
				Type = IToggleHighlightExploreUi_Union.IShowHighlightExploreSkillIcon,
				Value = _ishowhighlightexploreskillicon
			};
		}

		// Token: 0x06035F95 RID: 221077 RVA: 0x00757F38 File Offset: 0x00756138
		public IHideHighlightExploreSkillIconT AsIHideHighlightExploreSkillIcon()
		{
			return this.As<IHideHighlightExploreSkillIconT>();
		}

		// Token: 0x06035F96 RID: 221078 RVA: 0x00757F40 File Offset: 0x00756140
		public static IToggleHighlightExploreUi_UnionUnion FromIHideHighlightExploreSkillIcon(IHideHighlightExploreSkillIconT _ihidehighlightexploreskillicon)
		{
			return new IToggleHighlightExploreUi_UnionUnion
			{
				Type = IToggleHighlightExploreUi_Union.IHideHighlightExploreSkillIcon,
				Value = _ihidehighlightexploreskillicon
			};
		}

		// Token: 0x06035F97 RID: 221079 RVA: 0x00757F55 File Offset: 0x00756155
		public IToggleAndHighlightItemT AsIToggleAndHighlightItem()
		{
			return this.As<IToggleAndHighlightItemT>();
		}

		// Token: 0x06035F98 RID: 221080 RVA: 0x00757F5D File Offset: 0x0075615D
		public static IToggleHighlightExploreUi_UnionUnion FromIToggleAndHighlightItem(IToggleAndHighlightItemT _itoggleandhighlightitem)
		{
			return new IToggleHighlightExploreUi_UnionUnion
			{
				Type = IToggleHighlightExploreUi_Union.IToggleAndHighlightItem,
				Value = _itoggleandhighlightitem
			};
		}

		// Token: 0x06035F99 RID: 221081 RVA: 0x00757F74 File Offset: 0x00756174
		public static int Pack(FlatBufferBuilder builder, IToggleHighlightExploreUi_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IToggleHighlightExploreUi_Union.IToggleHighlightExploreUi:
				return IToggleHighlightExploreUi.Pack(builder, _o.AsIToggleHighlightExploreUi()).Value;
			case IToggleHighlightExploreUi_Union.IShowHighlightExploreSkillIcon:
				return IShowHighlightExploreSkillIcon.Pack(builder, _o.AsIShowHighlightExploreSkillIcon()).Value;
			case IToggleHighlightExploreUi_Union.IHideHighlightExploreSkillIcon:
				return IHideHighlightExploreSkillIcon.Pack(builder, _o.AsIHideHighlightExploreSkillIcon()).Value;
			case IToggleHighlightExploreUi_Union.IToggleAndHighlightItem:
				return IToggleAndHighlightItem.Pack(builder, _o.AsIToggleAndHighlightItem()).Value;
			default:
				return 0;
			}
		}
	}
}
