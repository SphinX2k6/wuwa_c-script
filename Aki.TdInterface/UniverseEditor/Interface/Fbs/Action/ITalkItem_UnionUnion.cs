using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731D RID: 29469
	public class ITalkItem_UnionUnion
	{
		// Token: 0x1700DFC9 RID: 57289
		// (get) Token: 0x0603574D RID: 218957 RVA: 0x00748509 File Offset: 0x00746709
		// (set) Token: 0x0603574E RID: 218958 RVA: 0x00748511 File Offset: 0x00746711
		public ITalkItem_Union Type { get; set; }

		// Token: 0x1700DFCA RID: 57290
		// (get) Token: 0x0603574F RID: 218959 RVA: 0x0074851A File Offset: 0x0074671A
		// (set) Token: 0x06035750 RID: 218960 RVA: 0x00748522 File Offset: 0x00746722
		public object Value { get; set; }

		// Token: 0x06035751 RID: 218961 RVA: 0x0074852B File Offset: 0x0074672B
		public ITalkItem_UnionUnion()
		{
			this.Type = ITalkItem_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035752 RID: 218962 RVA: 0x00748541 File Offset: 0x00746741
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035753 RID: 218963 RVA: 0x00748553 File Offset: 0x00746753
		public ITalkItemT AsITalkItem()
		{
			return this.As<ITalkItemT>();
		}

		// Token: 0x06035754 RID: 218964 RVA: 0x0074855B File Offset: 0x0074675B
		public static ITalkItem_UnionUnion FromITalkItem(ITalkItemT _italkitem)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItem,
				Value = _italkitem
			};
		}

		// Token: 0x06035755 RID: 218965 RVA: 0x00748570 File Offset: 0x00746770
		public ITalkItemDialogT AsITalkItemDialog()
		{
			return this.As<ITalkItemDialogT>();
		}

		// Token: 0x06035756 RID: 218966 RVA: 0x00748578 File Offset: 0x00746778
		public static ITalkItem_UnionUnion FromITalkItemDialog(ITalkItemDialogT _italkitemdialog)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemDialog,
				Value = _italkitemdialog
			};
		}

		// Token: 0x06035757 RID: 218967 RVA: 0x0074858D File Offset: 0x0074678D
		public ITalkItemOptionT AsITalkItemOption()
		{
			return this.As<ITalkItemOptionT>();
		}

		// Token: 0x06035758 RID: 218968 RVA: 0x00748595 File Offset: 0x00746795
		public static ITalkItem_UnionUnion FromITalkItemOption(ITalkItemOptionT _italkitemoption)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemOption,
				Value = _italkitemoption
			};
		}

		// Token: 0x06035759 RID: 218969 RVA: 0x007485AA File Offset: 0x007467AA
		public ITalkItemSystemOptionT AsITalkItemSystemOption()
		{
			return this.As<ITalkItemSystemOptionT>();
		}

		// Token: 0x0603575A RID: 218970 RVA: 0x007485B2 File Offset: 0x007467B2
		public static ITalkItem_UnionUnion FromITalkItemSystemOption(ITalkItemSystemOptionT _italkitemsystemoption)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemSystemOption,
				Value = _italkitemsystemoption
			};
		}

		// Token: 0x0603575B RID: 218971 RVA: 0x007485C7 File Offset: 0x007467C7
		public ITalkItemCenterTextT AsITalkItemCenterText()
		{
			return this.As<ITalkItemCenterTextT>();
		}

		// Token: 0x0603575C RID: 218972 RVA: 0x007485CF File Offset: 0x007467CF
		public static ITalkItem_UnionUnion FromITalkItemCenterText(ITalkItemCenterTextT _italkitemcentertext)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemCenterText,
				Value = _italkitemcentertext
			};
		}

		// Token: 0x0603575D RID: 218973 RVA: 0x007485E4 File Offset: 0x007467E4
		public ITalkItemQteT AsITalkItemQte()
		{
			return this.As<ITalkItemQteT>();
		}

		// Token: 0x0603575E RID: 218974 RVA: 0x007485EC File Offset: 0x007467EC
		public static ITalkItem_UnionUnion FromITalkItemQte(ITalkItemQteT _italkitemqte)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemQte,
				Value = _italkitemqte
			};
		}

		// Token: 0x0603575F RID: 218975 RVA: 0x00748601 File Offset: 0x00746801
		public ITalkItemNoTextItemT AsITalkItemNoTextItem()
		{
			return this.As<ITalkItemNoTextItemT>();
		}

		// Token: 0x06035760 RID: 218976 RVA: 0x00748609 File Offset: 0x00746809
		public static ITalkItem_UnionUnion FromITalkItemNoTextItem(ITalkItemNoTextItemT _italkitemnotextitem)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemNoTextItem,
				Value = _italkitemnotextitem
			};
		}

		// Token: 0x06035761 RID: 218977 RVA: 0x0074861E File Offset: 0x0074681E
		public ITalkItemPhoneMessageT AsITalkItemPhoneMessage()
		{
			return this.As<ITalkItemPhoneMessageT>();
		}

		// Token: 0x06035762 RID: 218978 RVA: 0x00748626 File Offset: 0x00746826
		public static ITalkItem_UnionUnion FromITalkItemPhoneMessage(ITalkItemPhoneMessageT _italkitemphonemessage)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemPhoneMessage,
				Value = _italkitemphonemessage
			};
		}

		// Token: 0x06035763 RID: 218979 RVA: 0x0074863B File Offset: 0x0074683B
		public ITalkItemAvgTalkT AsITalkItemAvgTalk()
		{
			return this.As<ITalkItemAvgTalkT>();
		}

		// Token: 0x06035764 RID: 218980 RVA: 0x00748643 File Offset: 0x00746843
		public static ITalkItem_UnionUnion FromITalkItemAvgTalk(ITalkItemAvgTalkT _italkitemavgtalk)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgTalk,
				Value = _italkitemavgtalk
			};
		}

		// Token: 0x06035765 RID: 218981 RVA: 0x00748659 File Offset: 0x00746859
		public ITalkItemAvgEnterT AsITalkItemAvgEnter()
		{
			return this.As<ITalkItemAvgEnterT>();
		}

		// Token: 0x06035766 RID: 218982 RVA: 0x00748661 File Offset: 0x00746861
		public static ITalkItem_UnionUnion FromITalkItemAvgEnter(ITalkItemAvgEnterT _italkitemavgenter)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgEnter,
				Value = _italkitemavgenter
			};
		}

		// Token: 0x06035767 RID: 218983 RVA: 0x00748677 File Offset: 0x00746877
		public ITalkItemAvgExitT AsITalkItemAvgExit()
		{
			return this.As<ITalkItemAvgExitT>();
		}

		// Token: 0x06035768 RID: 218984 RVA: 0x0074867F File Offset: 0x0074687F
		public static ITalkItem_UnionUnion FromITalkItemAvgExit(ITalkItemAvgExitT _italkitemavgexit)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgExit,
				Value = _italkitemavgexit
			};
		}

		// Token: 0x06035769 RID: 218985 RVA: 0x00748695 File Offset: 0x00746895
		public ITalkItemAvgOptionT AsITalkItemAvgOption()
		{
			return this.As<ITalkItemAvgOptionT>();
		}

		// Token: 0x0603576A RID: 218986 RVA: 0x0074869D File Offset: 0x0074689D
		public static ITalkItem_UnionUnion FromITalkItemAvgOption(ITalkItemAvgOptionT _italkitemavgoption)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgOption,
				Value = _italkitemavgoption
			};
		}

		// Token: 0x0603576B RID: 218987 RVA: 0x007486B3 File Offset: 0x007468B3
		public ITalkItemAvgNarrationT AsITalkItemAvgNarration()
		{
			return this.As<ITalkItemAvgNarrationT>();
		}

		// Token: 0x0603576C RID: 218988 RVA: 0x007486BB File Offset: 0x007468BB
		public static ITalkItem_UnionUnion FromITalkItemAvgNarration(ITalkItemAvgNarrationT _italkitemavgnarration)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgNarration,
				Value = _italkitemavgnarration
			};
		}

		// Token: 0x0603576D RID: 218989 RVA: 0x007486D1 File Offset: 0x007468D1
		public ITalkItemAvgCenterTextT AsITalkItemAvgCenterText()
		{
			return this.As<ITalkItemAvgCenterTextT>();
		}

		// Token: 0x0603576E RID: 218990 RVA: 0x007486D9 File Offset: 0x007468D9
		public static ITalkItem_UnionUnion FromITalkItemAvgCenterText(ITalkItemAvgCenterTextT _italkitemavgcentertext)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgCenterText,
				Value = _italkitemavgcentertext
			};
		}

		// Token: 0x0603576F RID: 218991 RVA: 0x007486EF File Offset: 0x007468EF
		public ITalkItemVisualNovelTalkT AsITalkItemVisualNovelTalk()
		{
			return this.As<ITalkItemVisualNovelTalkT>();
		}

		// Token: 0x06035770 RID: 218992 RVA: 0x007486F7 File Offset: 0x007468F7
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelTalk(ITalkItemVisualNovelTalkT _italkitemvisualnoveltalk)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelTalk,
				Value = _italkitemvisualnoveltalk
			};
		}

		// Token: 0x06035771 RID: 218993 RVA: 0x0074870D File Offset: 0x0074690D
		public ITalkItemVisualNovelNoTextItemT AsITalkItemVisualNovelNoTextItem()
		{
			return this.As<ITalkItemVisualNovelNoTextItemT>();
		}

		// Token: 0x06035772 RID: 218994 RVA: 0x00748715 File Offset: 0x00746915
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelNoTextItem(ITalkItemVisualNovelNoTextItemT _italkitemvisualnovelnotextitem)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelNoTextItem,
				Value = _italkitemvisualnovelnotextitem
			};
		}

		// Token: 0x06035773 RID: 218995 RVA: 0x0074872B File Offset: 0x0074692B
		public ITalkItemVisualNovelNarrationT AsITalkItemVisualNovelNarration()
		{
			return this.As<ITalkItemVisualNovelNarrationT>();
		}

		// Token: 0x06035774 RID: 218996 RVA: 0x00748733 File Offset: 0x00746933
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelNarration(ITalkItemVisualNovelNarrationT _italkitemvisualnovelnarration)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelNarration,
				Value = _italkitemvisualnovelnarration
			};
		}

		// Token: 0x06035775 RID: 218997 RVA: 0x00748749 File Offset: 0x00746949
		public ITalkItemVisualNovelOptionT AsITalkItemVisualNovelOption()
		{
			return this.As<ITalkItemVisualNovelOptionT>();
		}

		// Token: 0x06035776 RID: 218998 RVA: 0x00748751 File Offset: 0x00746951
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelOption(ITalkItemVisualNovelOptionT _italkitemvisualnoveloption)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelOption,
				Value = _italkitemvisualnoveloption
			};
		}

		// Token: 0x06035777 RID: 218999 RVA: 0x00748767 File Offset: 0x00746967
		public ITalkItemVisualNovelCenterTextT AsITalkItemVisualNovelCenterText()
		{
			return this.As<ITalkItemVisualNovelCenterTextT>();
		}

		// Token: 0x06035778 RID: 219000 RVA: 0x0074876F File Offset: 0x0074696F
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelCenterText(ITalkItemVisualNovelCenterTextT _italkitemvisualnovelcentertext)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelCenterText,
				Value = _italkitemvisualnovelcentertext
			};
		}

		// Token: 0x06035779 RID: 219001 RVA: 0x00748788 File Offset: 0x00746988
		public static int Pack(FlatBufferBuilder builder, ITalkItem_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkItem_Union.ITalkItem:
				return ITalkItem.Pack(builder, _o.AsITalkItem()).Value;
			case ITalkItem_Union.ITalkItemDialog:
				return ITalkItemDialog.Pack(builder, _o.AsITalkItemDialog()).Value;
			case ITalkItem_Union.ITalkItemOption:
				return ITalkItemOption.Pack(builder, _o.AsITalkItemOption()).Value;
			case ITalkItem_Union.ITalkItemSystemOption:
				return ITalkItemSystemOption.Pack(builder, _o.AsITalkItemSystemOption()).Value;
			case ITalkItem_Union.ITalkItemCenterText:
				return ITalkItemCenterText.Pack(builder, _o.AsITalkItemCenterText()).Value;
			case ITalkItem_Union.ITalkItemQte:
				return ITalkItemQte.Pack(builder, _o.AsITalkItemQte()).Value;
			case ITalkItem_Union.ITalkItemNoTextItem:
				return ITalkItemNoTextItem.Pack(builder, _o.AsITalkItemNoTextItem()).Value;
			case ITalkItem_Union.ITalkItemPhoneMessage:
				return ITalkItemPhoneMessage.Pack(builder, _o.AsITalkItemPhoneMessage()).Value;
			case ITalkItem_Union.ITalkItemAvgTalk:
				return ITalkItemAvgTalk.Pack(builder, _o.AsITalkItemAvgTalk()).Value;
			case ITalkItem_Union.ITalkItemAvgEnter:
				return ITalkItemAvgEnter.Pack(builder, _o.AsITalkItemAvgEnter()).Value;
			case ITalkItem_Union.ITalkItemAvgExit:
				return ITalkItemAvgExit.Pack(builder, _o.AsITalkItemAvgExit()).Value;
			case ITalkItem_Union.ITalkItemAvgOption:
				return ITalkItemAvgOption.Pack(builder, _o.AsITalkItemAvgOption()).Value;
			case ITalkItem_Union.ITalkItemAvgNarration:
				return ITalkItemAvgNarration.Pack(builder, _o.AsITalkItemAvgNarration()).Value;
			case ITalkItem_Union.ITalkItemAvgCenterText:
				return ITalkItemAvgCenterText.Pack(builder, _o.AsITalkItemAvgCenterText()).Value;
			case ITalkItem_Union.ITalkItemVisualNovelTalk:
				return ITalkItemVisualNovelTalk.Pack(builder, _o.AsITalkItemVisualNovelTalk()).Value;
			case ITalkItem_Union.ITalkItemVisualNovelNoTextItem:
				return ITalkItemVisualNovelNoTextItem.Pack(builder, _o.AsITalkItemVisualNovelNoTextItem()).Value;
			case ITalkItem_Union.ITalkItemVisualNovelNarration:
				return ITalkItemVisualNovelNarration.Pack(builder, _o.AsITalkItemVisualNovelNarration()).Value;
			case ITalkItem_Union.ITalkItemVisualNovelOption:
				return ITalkItemVisualNovelOption.Pack(builder, _o.AsITalkItemVisualNovelOption()).Value;
			case ITalkItem_Union.ITalkItemVisualNovelCenterText:
				return ITalkItemVisualNovelCenterText.Pack(builder, _o.AsITalkItemVisualNovelCenterText()).Value;
			default:
				return 0;
			}
		}
	}
}
