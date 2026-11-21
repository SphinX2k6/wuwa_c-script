using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AF5 RID: 31477
	public class ITalkItem_UnionUnion
	{
		// Token: 0x1700EBC5 RID: 60357
		// (get) Token: 0x06038A80 RID: 232064 RVA: 0x007AA092 File Offset: 0x007A8292
		// (set) Token: 0x06038A81 RID: 232065 RVA: 0x007AA09A File Offset: 0x007A829A
		public ITalkItem_Union Type { get; set; }

		// Token: 0x1700EBC6 RID: 60358
		// (get) Token: 0x06038A82 RID: 232066 RVA: 0x007AA0A3 File Offset: 0x007A82A3
		// (set) Token: 0x06038A83 RID: 232067 RVA: 0x007AA0AB File Offset: 0x007A82AB
		public object Value { get; set; }

		// Token: 0x06038A84 RID: 232068 RVA: 0x007AA0B4 File Offset: 0x007A82B4
		public ITalkItem_UnionUnion()
		{
			this.Type = ITalkItem_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038A85 RID: 232069 RVA: 0x007AA0CA File Offset: 0x007A82CA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038A86 RID: 232070 RVA: 0x007AA0DC File Offset: 0x007A82DC
		public ITalkItemT AsITalkItem()
		{
			return this.As<ITalkItemT>();
		}

		// Token: 0x06038A87 RID: 232071 RVA: 0x007AA0E4 File Offset: 0x007A82E4
		public static ITalkItem_UnionUnion FromITalkItem(ITalkItemT _italkitem)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItem,
				Value = _italkitem
			};
		}

		// Token: 0x06038A88 RID: 232072 RVA: 0x007AA0F9 File Offset: 0x007A82F9
		public ITalkItemDialogT AsITalkItemDialog()
		{
			return this.As<ITalkItemDialogT>();
		}

		// Token: 0x06038A89 RID: 232073 RVA: 0x007AA101 File Offset: 0x007A8301
		public static ITalkItem_UnionUnion FromITalkItemDialog(ITalkItemDialogT _italkitemdialog)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemDialog,
				Value = _italkitemdialog
			};
		}

		// Token: 0x06038A8A RID: 232074 RVA: 0x007AA116 File Offset: 0x007A8316
		public ITalkItemOptionT AsITalkItemOption()
		{
			return this.As<ITalkItemOptionT>();
		}

		// Token: 0x06038A8B RID: 232075 RVA: 0x007AA11E File Offset: 0x007A831E
		public static ITalkItem_UnionUnion FromITalkItemOption(ITalkItemOptionT _italkitemoption)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemOption,
				Value = _italkitemoption
			};
		}

		// Token: 0x06038A8C RID: 232076 RVA: 0x007AA133 File Offset: 0x007A8333
		public ITalkItemSystemOptionT AsITalkItemSystemOption()
		{
			return this.As<ITalkItemSystemOptionT>();
		}

		// Token: 0x06038A8D RID: 232077 RVA: 0x007AA13B File Offset: 0x007A833B
		public static ITalkItem_UnionUnion FromITalkItemSystemOption(ITalkItemSystemOptionT _italkitemsystemoption)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemSystemOption,
				Value = _italkitemsystemoption
			};
		}

		// Token: 0x06038A8E RID: 232078 RVA: 0x007AA150 File Offset: 0x007A8350
		public ITalkItemCenterTextT AsITalkItemCenterText()
		{
			return this.As<ITalkItemCenterTextT>();
		}

		// Token: 0x06038A8F RID: 232079 RVA: 0x007AA158 File Offset: 0x007A8358
		public static ITalkItem_UnionUnion FromITalkItemCenterText(ITalkItemCenterTextT _italkitemcentertext)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemCenterText,
				Value = _italkitemcentertext
			};
		}

		// Token: 0x06038A90 RID: 232080 RVA: 0x007AA16D File Offset: 0x007A836D
		public ITalkItemQteT AsITalkItemQte()
		{
			return this.As<ITalkItemQteT>();
		}

		// Token: 0x06038A91 RID: 232081 RVA: 0x007AA175 File Offset: 0x007A8375
		public static ITalkItem_UnionUnion FromITalkItemQte(ITalkItemQteT _italkitemqte)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemQte,
				Value = _italkitemqte
			};
		}

		// Token: 0x06038A92 RID: 232082 RVA: 0x007AA18A File Offset: 0x007A838A
		public ITalkItemNoTextItemT AsITalkItemNoTextItem()
		{
			return this.As<ITalkItemNoTextItemT>();
		}

		// Token: 0x06038A93 RID: 232083 RVA: 0x007AA192 File Offset: 0x007A8392
		public static ITalkItem_UnionUnion FromITalkItemNoTextItem(ITalkItemNoTextItemT _italkitemnotextitem)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemNoTextItem,
				Value = _italkitemnotextitem
			};
		}

		// Token: 0x06038A94 RID: 232084 RVA: 0x007AA1A7 File Offset: 0x007A83A7
		public ITalkItemPhoneMessageT AsITalkItemPhoneMessage()
		{
			return this.As<ITalkItemPhoneMessageT>();
		}

		// Token: 0x06038A95 RID: 232085 RVA: 0x007AA1AF File Offset: 0x007A83AF
		public static ITalkItem_UnionUnion FromITalkItemPhoneMessage(ITalkItemPhoneMessageT _italkitemphonemessage)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemPhoneMessage,
				Value = _italkitemphonemessage
			};
		}

		// Token: 0x06038A96 RID: 232086 RVA: 0x007AA1C4 File Offset: 0x007A83C4
		public ITalkItemAvgTalkT AsITalkItemAvgTalk()
		{
			return this.As<ITalkItemAvgTalkT>();
		}

		// Token: 0x06038A97 RID: 232087 RVA: 0x007AA1CC File Offset: 0x007A83CC
		public static ITalkItem_UnionUnion FromITalkItemAvgTalk(ITalkItemAvgTalkT _italkitemavgtalk)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgTalk,
				Value = _italkitemavgtalk
			};
		}

		// Token: 0x06038A98 RID: 232088 RVA: 0x007AA1E2 File Offset: 0x007A83E2
		public ITalkItemAvgEnterT AsITalkItemAvgEnter()
		{
			return this.As<ITalkItemAvgEnterT>();
		}

		// Token: 0x06038A99 RID: 232089 RVA: 0x007AA1EA File Offset: 0x007A83EA
		public static ITalkItem_UnionUnion FromITalkItemAvgEnter(ITalkItemAvgEnterT _italkitemavgenter)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgEnter,
				Value = _italkitemavgenter
			};
		}

		// Token: 0x06038A9A RID: 232090 RVA: 0x007AA200 File Offset: 0x007A8400
		public ITalkItemAvgExitT AsITalkItemAvgExit()
		{
			return this.As<ITalkItemAvgExitT>();
		}

		// Token: 0x06038A9B RID: 232091 RVA: 0x007AA208 File Offset: 0x007A8408
		public static ITalkItem_UnionUnion FromITalkItemAvgExit(ITalkItemAvgExitT _italkitemavgexit)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgExit,
				Value = _italkitemavgexit
			};
		}

		// Token: 0x06038A9C RID: 232092 RVA: 0x007AA21E File Offset: 0x007A841E
		public ITalkItemAvgOptionT AsITalkItemAvgOption()
		{
			return this.As<ITalkItemAvgOptionT>();
		}

		// Token: 0x06038A9D RID: 232093 RVA: 0x007AA226 File Offset: 0x007A8426
		public static ITalkItem_UnionUnion FromITalkItemAvgOption(ITalkItemAvgOptionT _italkitemavgoption)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgOption,
				Value = _italkitemavgoption
			};
		}

		// Token: 0x06038A9E RID: 232094 RVA: 0x007AA23C File Offset: 0x007A843C
		public ITalkItemAvgNarrationT AsITalkItemAvgNarration()
		{
			return this.As<ITalkItemAvgNarrationT>();
		}

		// Token: 0x06038A9F RID: 232095 RVA: 0x007AA244 File Offset: 0x007A8444
		public static ITalkItem_UnionUnion FromITalkItemAvgNarration(ITalkItemAvgNarrationT _italkitemavgnarration)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgNarration,
				Value = _italkitemavgnarration
			};
		}

		// Token: 0x06038AA0 RID: 232096 RVA: 0x007AA25A File Offset: 0x007A845A
		public ITalkItemAvgCenterTextT AsITalkItemAvgCenterText()
		{
			return this.As<ITalkItemAvgCenterTextT>();
		}

		// Token: 0x06038AA1 RID: 232097 RVA: 0x007AA262 File Offset: 0x007A8462
		public static ITalkItem_UnionUnion FromITalkItemAvgCenterText(ITalkItemAvgCenterTextT _italkitemavgcentertext)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemAvgCenterText,
				Value = _italkitemavgcentertext
			};
		}

		// Token: 0x06038AA2 RID: 232098 RVA: 0x007AA278 File Offset: 0x007A8478
		public ITalkItemVisualNovelTalkT AsITalkItemVisualNovelTalk()
		{
			return this.As<ITalkItemVisualNovelTalkT>();
		}

		// Token: 0x06038AA3 RID: 232099 RVA: 0x007AA280 File Offset: 0x007A8480
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelTalk(ITalkItemVisualNovelTalkT _italkitemvisualnoveltalk)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelTalk,
				Value = _italkitemvisualnoveltalk
			};
		}

		// Token: 0x06038AA4 RID: 232100 RVA: 0x007AA296 File Offset: 0x007A8496
		public ITalkItemVisualNovelNoTextItemT AsITalkItemVisualNovelNoTextItem()
		{
			return this.As<ITalkItemVisualNovelNoTextItemT>();
		}

		// Token: 0x06038AA5 RID: 232101 RVA: 0x007AA29E File Offset: 0x007A849E
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelNoTextItem(ITalkItemVisualNovelNoTextItemT _italkitemvisualnovelnotextitem)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelNoTextItem,
				Value = _italkitemvisualnovelnotextitem
			};
		}

		// Token: 0x06038AA6 RID: 232102 RVA: 0x007AA2B4 File Offset: 0x007A84B4
		public ITalkItemVisualNovelNarrationT AsITalkItemVisualNovelNarration()
		{
			return this.As<ITalkItemVisualNovelNarrationT>();
		}

		// Token: 0x06038AA7 RID: 232103 RVA: 0x007AA2BC File Offset: 0x007A84BC
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelNarration(ITalkItemVisualNovelNarrationT _italkitemvisualnovelnarration)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelNarration,
				Value = _italkitemvisualnovelnarration
			};
		}

		// Token: 0x06038AA8 RID: 232104 RVA: 0x007AA2D2 File Offset: 0x007A84D2
		public ITalkItemVisualNovelOptionT AsITalkItemVisualNovelOption()
		{
			return this.As<ITalkItemVisualNovelOptionT>();
		}

		// Token: 0x06038AA9 RID: 232105 RVA: 0x007AA2DA File Offset: 0x007A84DA
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelOption(ITalkItemVisualNovelOptionT _italkitemvisualnoveloption)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelOption,
				Value = _italkitemvisualnoveloption
			};
		}

		// Token: 0x06038AAA RID: 232106 RVA: 0x007AA2F0 File Offset: 0x007A84F0
		public ITalkItemVisualNovelCenterTextT AsITalkItemVisualNovelCenterText()
		{
			return this.As<ITalkItemVisualNovelCenterTextT>();
		}

		// Token: 0x06038AAB RID: 232107 RVA: 0x007AA2F8 File Offset: 0x007A84F8
		public static ITalkItem_UnionUnion FromITalkItemVisualNovelCenterText(ITalkItemVisualNovelCenterTextT _italkitemvisualnovelcentertext)
		{
			return new ITalkItem_UnionUnion
			{
				Type = ITalkItem_Union.ITalkItemVisualNovelCenterText,
				Value = _italkitemvisualnovelcentertext
			};
		}

		// Token: 0x06038AAC RID: 232108 RVA: 0x007AA310 File Offset: 0x007A8510
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
