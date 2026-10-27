using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F0 RID: 30448
	public class THighlightExploreSkillIconUnion
	{
		// Token: 0x1700E639 RID: 58937
		// (get) Token: 0x0603759E RID: 226718 RVA: 0x0077F4FC File Offset: 0x0077D6FC
		// (set) Token: 0x0603759F RID: 226719 RVA: 0x0077F504 File Offset: 0x0077D704
		public THighlightExploreSkillIcon Type { get; set; }

		// Token: 0x1700E63A RID: 58938
		// (get) Token: 0x060375A0 RID: 226720 RVA: 0x0077F50D File Offset: 0x0077D70D
		// (set) Token: 0x060375A1 RID: 226721 RVA: 0x0077F515 File Offset: 0x0077D715
		public object Value { get; set; }

		// Token: 0x060375A2 RID: 226722 RVA: 0x0077F51E File Offset: 0x0077D71E
		public THighlightExploreSkillIconUnion()
		{
			this.Type = THighlightExploreSkillIcon.NONE;
			this.Value = null;
		}

		// Token: 0x060375A3 RID: 226723 RVA: 0x0077F534 File Offset: 0x0077D734
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060375A4 RID: 226724 RVA: 0x0077F546 File Offset: 0x0077D746
		public IHideHighlightExploreSkillIconT AsIHideHighlightExploreSkillIcon()
		{
			return this.As<IHideHighlightExploreSkillIconT>();
		}

		// Token: 0x060375A5 RID: 226725 RVA: 0x0077F54E File Offset: 0x0077D74E
		public static THighlightExploreSkillIconUnion FromIHideHighlightExploreSkillIcon(IHideHighlightExploreSkillIconT _ihidehighlightexploreskillicon)
		{
			return new THighlightExploreSkillIconUnion
			{
				Type = THighlightExploreSkillIcon.IHideHighlightExploreSkillIcon,
				Value = _ihidehighlightexploreskillicon
			};
		}

		// Token: 0x060375A6 RID: 226726 RVA: 0x0077F563 File Offset: 0x0077D763
		public IShowHighlightExploreSkillIconT AsIShowHighlightExploreSkillIcon()
		{
			return this.As<IShowHighlightExploreSkillIconT>();
		}

		// Token: 0x060375A7 RID: 226727 RVA: 0x0077F56B File Offset: 0x0077D76B
		public static THighlightExploreSkillIconUnion FromIShowHighlightExploreSkillIcon(IShowHighlightExploreSkillIconT _ishowhighlightexploreskillicon)
		{
			return new THighlightExploreSkillIconUnion
			{
				Type = THighlightExploreSkillIcon.IShowHighlightExploreSkillIcon,
				Value = _ishowhighlightexploreskillicon
			};
		}

		// Token: 0x060375A8 RID: 226728 RVA: 0x0077F580 File Offset: 0x0077D780
		public IToggleAndHighlightItemT AsIToggleAndHighlightItem()
		{
			return this.As<IToggleAndHighlightItemT>();
		}

		// Token: 0x060375A9 RID: 226729 RVA: 0x0077F588 File Offset: 0x0077D788
		public static THighlightExploreSkillIconUnion FromIToggleAndHighlightItem(IToggleAndHighlightItemT _itoggleandhighlightitem)
		{
			return new THighlightExploreSkillIconUnion
			{
				Type = THighlightExploreSkillIcon.IToggleAndHighlightItem,
				Value = _itoggleandhighlightitem
			};
		}

		// Token: 0x060375AA RID: 226730 RVA: 0x0077F5A0 File Offset: 0x0077D7A0
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
