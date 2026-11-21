using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BF7 RID: 31735
	public class IToggleHighlightExploreUi_UnionUnion
	{
		// Token: 0x1700EDB9 RID: 60857
		// (get) Token: 0x0603933E RID: 234302 RVA: 0x007BA628 File Offset: 0x007B8828
		// (set) Token: 0x0603933F RID: 234303 RVA: 0x007BA630 File Offset: 0x007B8830
		public IToggleHighlightExploreUi_Union Type { get; set; }

		// Token: 0x1700EDBA RID: 60858
		// (get) Token: 0x06039340 RID: 234304 RVA: 0x007BA639 File Offset: 0x007B8839
		// (set) Token: 0x06039341 RID: 234305 RVA: 0x007BA641 File Offset: 0x007B8841
		public object Value { get; set; }

		// Token: 0x06039342 RID: 234306 RVA: 0x007BA64A File Offset: 0x007B884A
		public IToggleHighlightExploreUi_UnionUnion()
		{
			this.Type = IToggleHighlightExploreUi_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039343 RID: 234307 RVA: 0x007BA660 File Offset: 0x007B8860
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039344 RID: 234308 RVA: 0x007BA672 File Offset: 0x007B8872
		public IToggleHighlightExploreUiT AsIToggleHighlightExploreUi()
		{
			return this.As<IToggleHighlightExploreUiT>();
		}

		// Token: 0x06039345 RID: 234309 RVA: 0x007BA67A File Offset: 0x007B887A
		public static IToggleHighlightExploreUi_UnionUnion FromIToggleHighlightExploreUi(IToggleHighlightExploreUiT _itogglehighlightexploreui)
		{
			return new IToggleHighlightExploreUi_UnionUnion
			{
				Type = IToggleHighlightExploreUi_Union.IToggleHighlightExploreUi,
				Value = _itogglehighlightexploreui
			};
		}

		// Token: 0x06039346 RID: 234310 RVA: 0x007BA68F File Offset: 0x007B888F
		public IShowHighlightExploreSkillIconT AsIShowHighlightExploreSkillIcon()
		{
			return this.As<IShowHighlightExploreSkillIconT>();
		}

		// Token: 0x06039347 RID: 234311 RVA: 0x007BA697 File Offset: 0x007B8897
		public static IToggleHighlightExploreUi_UnionUnion FromIShowHighlightExploreSkillIcon(IShowHighlightExploreSkillIconT _ishowhighlightexploreskillicon)
		{
			return new IToggleHighlightExploreUi_UnionUnion
			{
				Type = IToggleHighlightExploreUi_Union.IShowHighlightExploreSkillIcon,
				Value = _ishowhighlightexploreskillicon
			};
		}

		// Token: 0x06039348 RID: 234312 RVA: 0x007BA6AC File Offset: 0x007B88AC
		public IHideHighlightExploreSkillIconT AsIHideHighlightExploreSkillIcon()
		{
			return this.As<IHideHighlightExploreSkillIconT>();
		}

		// Token: 0x06039349 RID: 234313 RVA: 0x007BA6B4 File Offset: 0x007B88B4
		public static IToggleHighlightExploreUi_UnionUnion FromIHideHighlightExploreSkillIcon(IHideHighlightExploreSkillIconT _ihidehighlightexploreskillicon)
		{
			return new IToggleHighlightExploreUi_UnionUnion
			{
				Type = IToggleHighlightExploreUi_Union.IHideHighlightExploreSkillIcon,
				Value = _ihidehighlightexploreskillicon
			};
		}

		// Token: 0x0603934A RID: 234314 RVA: 0x007BA6C9 File Offset: 0x007B88C9
		public IToggleAndHighlightItemT AsIToggleAndHighlightItem()
		{
			return this.As<IToggleAndHighlightItemT>();
		}

		// Token: 0x0603934B RID: 234315 RVA: 0x007BA6D1 File Offset: 0x007B88D1
		public static IToggleHighlightExploreUi_UnionUnion FromIToggleAndHighlightItem(IToggleAndHighlightItemT _itoggleandhighlightitem)
		{
			return new IToggleHighlightExploreUi_UnionUnion
			{
				Type = IToggleHighlightExploreUi_Union.IToggleAndHighlightItem,
				Value = _itoggleandhighlightitem
			};
		}

		// Token: 0x0603934C RID: 234316 RVA: 0x007BA6E8 File Offset: 0x007B88E8
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
