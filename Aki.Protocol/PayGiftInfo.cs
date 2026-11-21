using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCB RID: 3019
	public sealed class PayGiftInfo : IMessage<PayGiftInfo>, IMessage, IEquatable<PayGiftInfo>, IDeepCloneable<PayGiftInfo>, IBufferMessage
	{
		// Token: 0x060105DF RID: 67039 RVA: 0x002631D9 File Offset: 0x002613D9
		[NullableContext(1)]
		public static PayGiftInfo Create()
		{
			return new PayGiftInfo();
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x060105E0 RID: 67040 RVA: 0x002631E0 File Offset: 0x002613E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayGiftInfo> Parser
		{
			get
			{
				return PayGiftInfo._parser;
			}
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x060105E1 RID: 67041 RVA: 0x002631E7 File Offset: 0x002613E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x060105E2 RID: 67042 RVA: 0x002631EA File Offset: 0x002613EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftInfo.Descriptor;
			}
		}

		// Token: 0x060105E3 RID: 67043 RVA: 0x002631F4 File Offset: 0x002613F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfo()
		{
		}

		// Token: 0x060105E4 RID: 67044 RVA: 0x00263260 File Offset: 0x00261460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfo(PayGiftInfo other) : this()
		{
			this.id_ = other.id_;
			this.payId_ = other.payId_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this.sort_ = other.sort_;
			this.buyLimit_ = other.buyLimit_;
			this.boughtCount_ = other.boughtCount_;
			this.stageImage_ = other.stageImage_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.productId_ = other.productId_;
			this.amount_ = other.amount_;
			this.tabId_ = other.tabId_;
			this.type_ = other.type_;
			this.locked_ = other.locked_;
			this.isCanBuy_ = other.isCanBuy_;
			this.isRemind_ = other.isRemind_;
			this.buyConditionId_ = other.buyConditionId_;
			this.cloudGameTime_ = other.cloudGameTime_;
			this.cloudGameIcon_ = other.cloudGameIcon_;
			this.desc_ = other.desc_;
			this.updateType_ = other.updateType_;
			this.updateTime_ = other.updateTime_;
			this.lastUpdateTime_ = other.lastUpdateTime_;
			this.tag_ = other.tag_;
			this.promotionShow_ = other.promotionShow_;
			this.showStageImage_ = other.showStageImage_;
			this.currencyDiscountTags_ = other.currencyDiscountTags_.Clone();
			this.complianceDetail_ = other.complianceDetail_;
			this.quality_ = other.quality_;
			this.versionId_ = other.versionId_;
			this.shopId_ = other.shopId_;
			this.needConsoleRulePrompt_ = other.needConsoleRulePrompt_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105E5 RID: 67045 RVA: 0x00263415 File Offset: 0x00261615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfo Clone()
		{
			return new PayGiftInfo(this);
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x060105E6 RID: 67046 RVA: 0x0026341D File Offset: 0x0026161D
		// (set) Token: 0x060105E7 RID: 67047 RVA: 0x00263425 File Offset: 0x00261625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x060105E8 RID: 67048 RVA: 0x0026342E File Offset: 0x0026162E
		// (set) Token: 0x060105E9 RID: 67049 RVA: 0x00263436 File Offset: 0x00261636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PayId
		{
			get
			{
				return this.payId_;
			}
			set
			{
				this.payId_ = value;
			}
		}

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x060105EA RID: 67050 RVA: 0x0026343F File Offset: 0x0026163F
		// (set) Token: 0x060105EB RID: 67051 RVA: 0x00263447 File Offset: 0x00261647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x060105EC RID: 67052 RVA: 0x00263450 File Offset: 0x00261650
		// (set) Token: 0x060105ED RID: 67053 RVA: 0x00263458 File Offset: 0x00261658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x060105EE RID: 67054 RVA: 0x00263461 File Offset: 0x00261661
		// (set) Token: 0x060105EF RID: 67055 RVA: 0x00263469 File Offset: 0x00261669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sort
		{
			get
			{
				return this.sort_;
			}
			set
			{
				this.sort_ = value;
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x060105F0 RID: 67056 RVA: 0x00263472 File Offset: 0x00261672
		// (set) Token: 0x060105F1 RID: 67057 RVA: 0x0026347A File Offset: 0x0026167A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuyLimit
		{
			get
			{
				return this.buyLimit_;
			}
			set
			{
				this.buyLimit_ = value;
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x060105F2 RID: 67058 RVA: 0x00263483 File Offset: 0x00261683
		// (set) Token: 0x060105F3 RID: 67059 RVA: 0x0026348B File Offset: 0x0026168B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoughtCount
		{
			get
			{
				return this.boughtCount_;
			}
			set
			{
				this.boughtCount_ = value;
			}
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x060105F4 RID: 67060 RVA: 0x00263494 File Offset: 0x00261694
		// (set) Token: 0x060105F5 RID: 67061 RVA: 0x0026349C File Offset: 0x0026169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StageImage
		{
			get
			{
				return this.stageImage_;
			}
			set
			{
				this.stageImage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x060105F6 RID: 67062 RVA: 0x002634AF File Offset: 0x002616AF
		// (set) Token: 0x060105F7 RID: 67063 RVA: 0x002634B7 File Offset: 0x002616B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x060105F8 RID: 67064 RVA: 0x002634C0 File Offset: 0x002616C0
		// (set) Token: 0x060105F9 RID: 67065 RVA: 0x002634C8 File Offset: 0x002616C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x060105FA RID: 67066 RVA: 0x002634D1 File Offset: 0x002616D1
		// (set) Token: 0x060105FB RID: 67067 RVA: 0x002634D9 File Offset: 0x002616D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ProductId
		{
			get
			{
				return this.productId_;
			}
			set
			{
				this.productId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x060105FC RID: 67068 RVA: 0x002634EC File Offset: 0x002616EC
		// (set) Token: 0x060105FD RID: 67069 RVA: 0x002634F4 File Offset: 0x002616F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Amount
		{
			get
			{
				return this.amount_;
			}
			set
			{
				this.amount_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x060105FE RID: 67070 RVA: 0x00263507 File Offset: 0x00261707
		// (set) Token: 0x060105FF RID: 67071 RVA: 0x0026350F File Offset: 0x0026170F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabId
		{
			get
			{
				return this.tabId_;
			}
			set
			{
				this.tabId_ = value;
			}
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x06010600 RID: 67072 RVA: 0x00263518 File Offset: 0x00261718
		// (set) Token: 0x06010601 RID: 67073 RVA: 0x00263520 File Offset: 0x00261720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x06010602 RID: 67074 RVA: 0x00263529 File Offset: 0x00261729
		// (set) Token: 0x06010603 RID: 67075 RVA: 0x00263531 File Offset: 0x00261731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Locked
		{
			get
			{
				return this.locked_;
			}
			set
			{
				this.locked_ = value;
			}
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x06010604 RID: 67076 RVA: 0x0026353A File Offset: 0x0026173A
		// (set) Token: 0x06010605 RID: 67077 RVA: 0x00263542 File Offset: 0x00261742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCanBuy
		{
			get
			{
				return this.isCanBuy_;
			}
			set
			{
				this.isCanBuy_ = value;
			}
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x06010606 RID: 67078 RVA: 0x0026354B File Offset: 0x0026174B
		// (set) Token: 0x06010607 RID: 67079 RVA: 0x00263553 File Offset: 0x00261753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRemind
		{
			get
			{
				return this.isRemind_;
			}
			set
			{
				this.isRemind_ = value;
			}
		}

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x06010608 RID: 67080 RVA: 0x0026355C File Offset: 0x0026175C
		// (set) Token: 0x06010609 RID: 67081 RVA: 0x00263564 File Offset: 0x00261764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuyConditionId
		{
			get
			{
				return this.buyConditionId_;
			}
			set
			{
				this.buyConditionId_ = value;
			}
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0601060A RID: 67082 RVA: 0x0026356D File Offset: 0x0026176D
		// (set) Token: 0x0601060B RID: 67083 RVA: 0x00263575 File Offset: 0x00261775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CloudGameTime
		{
			get
			{
				return this.cloudGameTime_;
			}
			set
			{
				this.cloudGameTime_ = value;
			}
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0601060C RID: 67084 RVA: 0x0026357E File Offset: 0x0026177E
		// (set) Token: 0x0601060D RID: 67085 RVA: 0x00263586 File Offset: 0x00261786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CloudGameIcon
		{
			get
			{
				return this.cloudGameIcon_;
			}
			set
			{
				this.cloudGameIcon_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0601060E RID: 67086 RVA: 0x00263599 File Offset: 0x00261799
		// (set) Token: 0x0601060F RID: 67087 RVA: 0x002635A1 File Offset: 0x002617A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Desc
		{
			get
			{
				return this.desc_;
			}
			set
			{
				this.desc_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x06010610 RID: 67088 RVA: 0x002635B4 File Offset: 0x002617B4
		// (set) Token: 0x06010611 RID: 67089 RVA: 0x002635BC File Offset: 0x002617BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayUpdateType UpdateType
		{
			get
			{
				return this.updateType_;
			}
			set
			{
				this.updateType_ = value;
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x06010612 RID: 67090 RVA: 0x002635C5 File Offset: 0x002617C5
		// (set) Token: 0x06010613 RID: 67091 RVA: 0x002635CD File Offset: 0x002617CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpdateTime
		{
			get
			{
				return this.updateTime_;
			}
			set
			{
				this.updateTime_ = value;
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x06010614 RID: 67092 RVA: 0x002635D6 File Offset: 0x002617D6
		// (set) Token: 0x06010615 RID: 67093 RVA: 0x002635DE File Offset: 0x002617DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastUpdateTime
		{
			get
			{
				return this.lastUpdateTime_;
			}
			set
			{
				this.lastUpdateTime_ = value;
			}
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x06010616 RID: 67094 RVA: 0x002635E7 File Offset: 0x002617E7
		// (set) Token: 0x06010617 RID: 67095 RVA: 0x002635EF File Offset: 0x002617EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Tag
		{
			get
			{
				return this.tag_;
			}
			set
			{
				this.tag_ = value;
			}
		}

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x06010618 RID: 67096 RVA: 0x002635F8 File Offset: 0x002617F8
		// (set) Token: 0x06010619 RID: 67097 RVA: 0x00263600 File Offset: 0x00261800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PromotionShow
		{
			get
			{
				return this.promotionShow_;
			}
			set
			{
				this.promotionShow_ = value;
			}
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0601061A RID: 67098 RVA: 0x00263609 File Offset: 0x00261809
		// (set) Token: 0x0601061B RID: 67099 RVA: 0x00263611 File Offset: 0x00261811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ShowStageImage
		{
			get
			{
				return this.showStageImage_;
			}
			set
			{
				this.showStageImage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0601061C RID: 67100 RVA: 0x00263624 File Offset: 0x00261824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> CurrencyDiscountTags
		{
			get
			{
				return this.currencyDiscountTags_;
			}
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0601061D RID: 67101 RVA: 0x0026362C File Offset: 0x0026182C
		// (set) Token: 0x0601061E RID: 67102 RVA: 0x00263634 File Offset: 0x00261834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ComplianceDetail
		{
			get
			{
				return this.complianceDetail_;
			}
			set
			{
				this.complianceDetail_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0601061F RID: 67103 RVA: 0x00263647 File Offset: 0x00261847
		// (set) Token: 0x06010620 RID: 67104 RVA: 0x0026364F File Offset: 0x0026184F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quality
		{
			get
			{
				return this.quality_;
			}
			set
			{
				this.quality_ = value;
			}
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x06010621 RID: 67105 RVA: 0x00263658 File Offset: 0x00261858
		// (set) Token: 0x06010622 RID: 67106 RVA: 0x00263660 File Offset: 0x00261860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VersionId
		{
			get
			{
				return this.versionId_;
			}
			set
			{
				this.versionId_ = value;
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x06010623 RID: 67107 RVA: 0x00263669 File Offset: 0x00261869
		// (set) Token: 0x06010624 RID: 67108 RVA: 0x00263671 File Offset: 0x00261871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x06010625 RID: 67109 RVA: 0x0026367A File Offset: 0x0026187A
		// (set) Token: 0x06010626 RID: 67110 RVA: 0x00263682 File Offset: 0x00261882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedConsoleRulePrompt
		{
			get
			{
				return this.needConsoleRulePrompt_;
			}
			set
			{
				this.needConsoleRulePrompt_ = value;
			}
		}

		// Token: 0x06010627 RID: 67111 RVA: 0x0026368B File Offset: 0x0026188B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftInfo);
		}

		// Token: 0x06010628 RID: 67112 RVA: 0x0026369C File Offset: 0x0026189C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PayId == other.PayId && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && this.Sort == other.Sort && this.BuyLimit == other.BuyLimit && this.BoughtCount == other.BoughtCount && !(this.StageImage != other.StageImage) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && !(this.ProductId != other.ProductId) && !(this.Amount != other.Amount) && this.TabId == other.TabId && this.Type == other.Type && this.Locked == other.Locked && this.IsCanBuy == other.IsCanBuy && this.IsRemind == other.IsRemind && this.BuyConditionId == other.BuyConditionId && this.CloudGameTime == other.CloudGameTime && !(this.CloudGameIcon != other.CloudGameIcon) && !(this.Desc != other.Desc) && this.UpdateType == other.UpdateType && this.UpdateTime == other.UpdateTime && this.LastUpdateTime == other.LastUpdateTime && this.Tag == other.Tag && this.PromotionShow == other.PromotionShow && !(this.ShowStageImage != other.ShowStageImage) && this.CurrencyDiscountTags.Equals(other.CurrencyDiscountTags) && !(this.ComplianceDetail != other.ComplianceDetail) && this.Quality == other.Quality && this.VersionId == other.VersionId && this.ShopId == other.ShopId && this.NeedConsoleRulePrompt == other.NeedConsoleRulePrompt && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010629 RID: 67113 RVA: 0x00263900 File Offset: 0x00261B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PayId != 0)
			{
				num ^= this.PayId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this.Sort != 0)
			{
				num ^= this.Sort.GetHashCode();
			}
			if (this.BuyLimit != 0)
			{
				num ^= this.BuyLimit.GetHashCode();
			}
			if (this.BoughtCount != 0)
			{
				num ^= this.BoughtCount.GetHashCode();
			}
			if (this.StageImage.Length != 0)
			{
				num ^= this.StageImage.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.ProductId.Length != 0)
			{
				num ^= this.ProductId.GetHashCode();
			}
			if (this.Amount.Length != 0)
			{
				num ^= this.Amount.GetHashCode();
			}
			if (this.TabId != 0)
			{
				num ^= this.TabId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Locked)
			{
				num ^= this.Locked.GetHashCode();
			}
			if (this.IsCanBuy)
			{
				num ^= this.IsCanBuy.GetHashCode();
			}
			if (this.IsRemind)
			{
				num ^= this.IsRemind.GetHashCode();
			}
			if (this.BuyConditionId != 0)
			{
				num ^= this.BuyConditionId.GetHashCode();
			}
			if (this.CloudGameTime != 0)
			{
				num ^= this.CloudGameTime.GetHashCode();
			}
			if (this.CloudGameIcon.Length != 0)
			{
				num ^= this.CloudGameIcon.GetHashCode();
			}
			if (this.Desc.Length != 0)
			{
				num ^= this.Desc.GetHashCode();
			}
			if (this.UpdateType != PayUpdateType.None)
			{
				num ^= this.UpdateType.GetHashCode();
			}
			if (this.UpdateTime != 0L)
			{
				num ^= this.UpdateTime.GetHashCode();
			}
			if (this.LastUpdateTime != 0L)
			{
				num ^= this.LastUpdateTime.GetHashCode();
			}
			if (this.Tag != 0)
			{
				num ^= this.Tag.GetHashCode();
			}
			if (this.PromotionShow != 0)
			{
				num ^= this.PromotionShow.GetHashCode();
			}
			if (this.ShowStageImage.Length != 0)
			{
				num ^= this.ShowStageImage.GetHashCode();
			}
			num ^= this.CurrencyDiscountTags.GetHashCode();
			if (this.ComplianceDetail.Length != 0)
			{
				num ^= this.ComplianceDetail.GetHashCode();
			}
			if (this.Quality != 0)
			{
				num ^= this.Quality.GetHashCode();
			}
			if (this.VersionId != 0)
			{
				num ^= this.VersionId.GetHashCode();
			}
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.NeedConsoleRulePrompt)
			{
				num ^= this.NeedConsoleRulePrompt.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601062A RID: 67114 RVA: 0x00263C69 File Offset: 0x00261E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601062B RID: 67115 RVA: 0x00263C76 File Offset: 0x00261E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601062C RID: 67116 RVA: 0x00263C80 File Offset: 0x00261E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.PayId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PayId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemCount);
			}
			if (this.Sort != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Sort);
			}
			if (this.BuyLimit != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BuyLimit);
			}
			if (this.BoughtCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BoughtCount);
			}
			if (this.StageImage.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.StageImage);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EndTime);
			}
			if (this.ProductId.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ProductId);
			}
			if (this.Amount.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Amount);
			}
			if (this.TabId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TabId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Type);
			}
			if (this.Locked)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Locked);
			}
			if (this.IsCanBuy)
			{
				output.WriteRawTag(128, 1);
				output.WriteBool(this.IsCanBuy);
			}
			if (this.IsRemind)
			{
				output.WriteRawTag(136, 1);
				output.WriteBool(this.IsRemind);
			}
			if (this.BuyConditionId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.BuyConditionId);
			}
			if (this.CloudGameTime != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.CloudGameTime);
			}
			if (this.CloudGameIcon.Length != 0)
			{
				output.WriteRawTag(162, 1);
				output.WriteString(this.CloudGameIcon);
			}
			if (this.Desc.Length != 0)
			{
				output.WriteRawTag(170, 1);
				output.WriteString(this.Desc);
			}
			if (this.UpdateType != PayUpdateType.None)
			{
				output.WriteRawTag(176, 1);
				output.WriteEnum((int)this.UpdateType);
			}
			if (this.UpdateTime != 0L)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt64(this.UpdateTime);
			}
			if (this.LastUpdateTime != 0L)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt64(this.LastUpdateTime);
			}
			if (this.Tag != 0)
			{
				output.WriteRawTag(200, 1);
				output.WriteInt32(this.Tag);
			}
			if (this.PromotionShow != 0)
			{
				output.WriteRawTag(208, 1);
				output.WriteInt32(this.PromotionShow);
			}
			if (this.ShowStageImage.Length != 0)
			{
				output.WriteRawTag(218, 1);
				output.WriteString(this.ShowStageImage);
			}
			this.currencyDiscountTags_.WriteTo(ref output, PayGiftInfo._map_currencyDiscountTags_codec);
			if (this.ComplianceDetail.Length != 0)
			{
				output.WriteRawTag(234, 1);
				output.WriteString(this.ComplianceDetail);
			}
			if (this.Quality != 0)
			{
				output.WriteRawTag(240, 1);
				output.WriteInt32(this.Quality);
			}
			if (this.VersionId != 0)
			{
				output.WriteRawTag(248, 1);
				output.WriteInt32(this.VersionId);
			}
			if (this.ShopId != 0)
			{
				output.WriteRawTag(128, 2);
				output.WriteInt32(this.ShopId);
			}
			if (this.NeedConsoleRulePrompt)
			{
				output.WriteRawTag(136, 2);
				output.WriteBool(this.NeedConsoleRulePrompt);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601062D RID: 67117 RVA: 0x00264098 File Offset: 0x00262298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.PayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PayId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this.Sort != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sort);
			}
			if (this.BuyLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuyLimit);
			}
			if (this.BoughtCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoughtCount);
			}
			if (this.StageImage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StageImage);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.ProductId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProductId);
			}
			if (this.Amount.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Amount);
			}
			if (this.TabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TabId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Locked)
			{
				num += 2;
			}
			if (this.IsCanBuy)
			{
				num += 3;
			}
			if (this.IsRemind)
			{
				num += 3;
			}
			if (this.BuyConditionId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BuyConditionId);
			}
			if (this.CloudGameTime != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CloudGameTime);
			}
			if (this.CloudGameIcon.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.CloudGameIcon);
			}
			if (this.Desc.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Desc);
			}
			if (this.UpdateType != PayUpdateType.None)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.UpdateType);
			}
			if (this.UpdateTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.UpdateTime);
			}
			if (this.LastUpdateTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LastUpdateTime);
			}
			if (this.Tag != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Tag);
			}
			if (this.PromotionShow != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PromotionShow);
			}
			if (this.ShowStageImage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ShowStageImage);
			}
			num += this.currencyDiscountTags_.CalculateSize(PayGiftInfo._map_currencyDiscountTags_codec);
			if (this.ComplianceDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ComplianceDetail);
			}
			if (this.Quality != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Quality);
			}
			if (this.VersionId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.VersionId);
			}
			if (this.ShopId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.NeedConsoleRulePrompt)
			{
				num += 3;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601062E RID: 67118 RVA: 0x002643C4 File Offset: 0x002625C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.PayId != 0)
			{
				this.PayId = other.PayId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			if (other.Sort != 0)
			{
				this.Sort = other.Sort;
			}
			if (other.BuyLimit != 0)
			{
				this.BuyLimit = other.BuyLimit;
			}
			if (other.BoughtCount != 0)
			{
				this.BoughtCount = other.BoughtCount;
			}
			if (other.StageImage.Length != 0)
			{
				this.StageImage = other.StageImage;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.ProductId.Length != 0)
			{
				this.ProductId = other.ProductId;
			}
			if (other.Amount.Length != 0)
			{
				this.Amount = other.Amount;
			}
			if (other.TabId != 0)
			{
				this.TabId = other.TabId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Locked)
			{
				this.Locked = other.Locked;
			}
			if (other.IsCanBuy)
			{
				this.IsCanBuy = other.IsCanBuy;
			}
			if (other.IsRemind)
			{
				this.IsRemind = other.IsRemind;
			}
			if (other.BuyConditionId != 0)
			{
				this.BuyConditionId = other.BuyConditionId;
			}
			if (other.CloudGameTime != 0)
			{
				this.CloudGameTime = other.CloudGameTime;
			}
			if (other.CloudGameIcon.Length != 0)
			{
				this.CloudGameIcon = other.CloudGameIcon;
			}
			if (other.Desc.Length != 0)
			{
				this.Desc = other.Desc;
			}
			if (other.UpdateType != PayUpdateType.None)
			{
				this.UpdateType = other.UpdateType;
			}
			if (other.UpdateTime != 0L)
			{
				this.UpdateTime = other.UpdateTime;
			}
			if (other.LastUpdateTime != 0L)
			{
				this.LastUpdateTime = other.LastUpdateTime;
			}
			if (other.Tag != 0)
			{
				this.Tag = other.Tag;
			}
			if (other.PromotionShow != 0)
			{
				this.PromotionShow = other.PromotionShow;
			}
			if (other.ShowStageImage.Length != 0)
			{
				this.ShowStageImage = other.ShowStageImage;
			}
			this.currencyDiscountTags_.MergeFrom(other.currencyDiscountTags_);
			if (other.ComplianceDetail.Length != 0)
			{
				this.ComplianceDetail = other.ComplianceDetail;
			}
			if (other.Quality != 0)
			{
				this.Quality = other.Quality;
			}
			if (other.VersionId != 0)
			{
				this.VersionId = other.VersionId;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.NeedConsoleRulePrompt)
			{
				this.NeedConsoleRulePrompt = other.NeedConsoleRulePrompt;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601062F RID: 67119 RVA: 0x002646A0 File Offset: 0x002628A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010630 RID: 67120 RVA: 0x002646AC File Offset: 0x002628AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 128U)
				{
					if (num <= 66U)
					{
						if (num <= 32U)
						{
							if (num <= 16U)
							{
								if (num == 8U)
								{
									this.Id = input.ReadInt32();
									continue;
								}
								if (num == 16U)
								{
									this.PayId = input.ReadInt32();
									continue;
								}
							}
							else
							{
								if (num == 24U)
								{
									this.ItemId = input.ReadInt32();
									continue;
								}
								if (num == 32U)
								{
									this.ItemCount = input.ReadInt32();
									continue;
								}
							}
						}
						else if (num <= 48U)
						{
							if (num == 40U)
							{
								this.Sort = input.ReadInt32();
								continue;
							}
							if (num == 48U)
							{
								this.BuyLimit = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 56U)
							{
								this.BoughtCount = input.ReadInt32();
								continue;
							}
							if (num == 66U)
							{
								this.StageImage = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 98U)
					{
						if (num <= 80U)
						{
							if (num == 72U)
							{
								this.BeginTime = input.ReadInt64();
								continue;
							}
							if (num == 80U)
							{
								this.EndTime = input.ReadInt64();
								continue;
							}
						}
						else
						{
							if (num == 90U)
							{
								this.ProductId = input.ReadString();
								continue;
							}
							if (num == 98U)
							{
								this.Amount = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 112U)
					{
						if (num == 104U)
						{
							this.TabId = input.ReadInt32();
							continue;
						}
						if (num == 112U)
						{
							this.Type = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 120U)
						{
							this.Locked = input.ReadBool();
							continue;
						}
						if (num == 128U)
						{
							this.IsCanBuy = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 192U)
				{
					if (num <= 162U)
					{
						if (num <= 144U)
						{
							if (num == 136U)
							{
								this.IsRemind = input.ReadBool();
								continue;
							}
							if (num == 144U)
							{
								this.BuyConditionId = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 152U)
							{
								this.CloudGameTime = input.ReadInt32();
								continue;
							}
							if (num == 162U)
							{
								this.CloudGameIcon = input.ReadString();
								continue;
							}
						}
					}
					else if (num <= 176U)
					{
						if (num == 170U)
						{
							this.Desc = input.ReadString();
							continue;
						}
						if (num == 176U)
						{
							this.UpdateType = (PayUpdateType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 184U)
						{
							this.UpdateTime = input.ReadInt64();
							continue;
						}
						if (num == 192U)
						{
							this.LastUpdateTime = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 226U)
				{
					if (num <= 208U)
					{
						if (num == 200U)
						{
							this.Tag = input.ReadInt32();
							continue;
						}
						if (num == 208U)
						{
							this.PromotionShow = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 218U)
						{
							this.ShowStageImage = input.ReadString();
							continue;
						}
						if (num == 226U)
						{
							this.currencyDiscountTags_.AddEntriesFrom(ref input, PayGiftInfo._map_currencyDiscountTags_codec);
							continue;
						}
					}
				}
				else if (num <= 240U)
				{
					if (num == 234U)
					{
						this.ComplianceDetail = input.ReadString();
						continue;
					}
					if (num == 240U)
					{
						this.Quality = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 248U)
					{
						this.VersionId = input.ReadInt32();
						continue;
					}
					if (num == 256U)
					{
						this.ShopId = input.ReadInt32();
						continue;
					}
					if (num == 264U)
					{
						this.NeedConsoleRulePrompt = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006837 RID: 26679
		private static readonly MessageParser<PayGiftInfo> _parser = new MessageParser<PayGiftInfo>(() => new PayGiftInfo());

		// Token: 0x04006838 RID: 26680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006839 RID: 26681
		public const int IdFieldNumber = 1;

		// Token: 0x0400683A RID: 26682
		private int id_;

		// Token: 0x0400683B RID: 26683
		public const int PayIdFieldNumber = 2;

		// Token: 0x0400683C RID: 26684
		private int payId_;

		// Token: 0x0400683D RID: 26685
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0400683E RID: 26686
		private int itemId_;

		// Token: 0x0400683F RID: 26687
		public const int ItemCountFieldNumber = 4;

		// Token: 0x04006840 RID: 26688
		private int itemCount_;

		// Token: 0x04006841 RID: 26689
		public const int SortFieldNumber = 5;

		// Token: 0x04006842 RID: 26690
		private int sort_;

		// Token: 0x04006843 RID: 26691
		public const int BuyLimitFieldNumber = 6;

		// Token: 0x04006844 RID: 26692
		private int buyLimit_;

		// Token: 0x04006845 RID: 26693
		public const int BoughtCountFieldNumber = 7;

		// Token: 0x04006846 RID: 26694
		private int boughtCount_;

		// Token: 0x04006847 RID: 26695
		public const int StageImageFieldNumber = 8;

		// Token: 0x04006848 RID: 26696
		private string stageImage_ = "";

		// Token: 0x04006849 RID: 26697
		public const int BeginTimeFieldNumber = 9;

		// Token: 0x0400684A RID: 26698
		private long beginTime_;

		// Token: 0x0400684B RID: 26699
		public const int EndTimeFieldNumber = 10;

		// Token: 0x0400684C RID: 26700
		private long endTime_;

		// Token: 0x0400684D RID: 26701
		public const int ProductIdFieldNumber = 11;

		// Token: 0x0400684E RID: 26702
		private string productId_ = "";

		// Token: 0x0400684F RID: 26703
		public const int AmountFieldNumber = 12;

		// Token: 0x04006850 RID: 26704
		private string amount_ = "";

		// Token: 0x04006851 RID: 26705
		public const int TabIdFieldNumber = 13;

		// Token: 0x04006852 RID: 26706
		private int tabId_;

		// Token: 0x04006853 RID: 26707
		public const int TypeFieldNumber = 14;

		// Token: 0x04006854 RID: 26708
		private int type_;

		// Token: 0x04006855 RID: 26709
		public const int LockedFieldNumber = 15;

		// Token: 0x04006856 RID: 26710
		private bool locked_;

		// Token: 0x04006857 RID: 26711
		public const int IsCanBuyFieldNumber = 16;

		// Token: 0x04006858 RID: 26712
		private bool isCanBuy_;

		// Token: 0x04006859 RID: 26713
		public const int IsRemindFieldNumber = 17;

		// Token: 0x0400685A RID: 26714
		private bool isRemind_;

		// Token: 0x0400685B RID: 26715
		public const int BuyConditionIdFieldNumber = 18;

		// Token: 0x0400685C RID: 26716
		private int buyConditionId_;

		// Token: 0x0400685D RID: 26717
		public const int CloudGameTimeFieldNumber = 19;

		// Token: 0x0400685E RID: 26718
		private int cloudGameTime_;

		// Token: 0x0400685F RID: 26719
		public const int CloudGameIconFieldNumber = 20;

		// Token: 0x04006860 RID: 26720
		private string cloudGameIcon_ = "";

		// Token: 0x04006861 RID: 26721
		public const int DescFieldNumber = 21;

		// Token: 0x04006862 RID: 26722
		private string desc_ = "";

		// Token: 0x04006863 RID: 26723
		public const int UpdateTypeFieldNumber = 22;

		// Token: 0x04006864 RID: 26724
		private PayUpdateType updateType_;

		// Token: 0x04006865 RID: 26725
		public const int UpdateTimeFieldNumber = 23;

		// Token: 0x04006866 RID: 26726
		private long updateTime_;

		// Token: 0x04006867 RID: 26727
		public const int LastUpdateTimeFieldNumber = 24;

		// Token: 0x04006868 RID: 26728
		private long lastUpdateTime_;

		// Token: 0x04006869 RID: 26729
		public const int TagFieldNumber = 25;

		// Token: 0x0400686A RID: 26730
		private int tag_;

		// Token: 0x0400686B RID: 26731
		public const int PromotionShowFieldNumber = 26;

		// Token: 0x0400686C RID: 26732
		private int promotionShow_;

		// Token: 0x0400686D RID: 26733
		public const int ShowStageImageFieldNumber = 27;

		// Token: 0x0400686E RID: 26734
		private string showStageImage_ = "";

		// Token: 0x0400686F RID: 26735
		public const int CurrencyDiscountTagsFieldNumber = 28;

		// Token: 0x04006870 RID: 26736
		private static readonly MapField<string, int>.Codec _map_currencyDiscountTags_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 226U);

		// Token: 0x04006871 RID: 26737
		private readonly MapField<string, int> currencyDiscountTags_ = new MapField<string, int>();

		// Token: 0x04006872 RID: 26738
		public const int ComplianceDetailFieldNumber = 29;

		// Token: 0x04006873 RID: 26739
		private string complianceDetail_ = "";

		// Token: 0x04006874 RID: 26740
		public const int QualityFieldNumber = 30;

		// Token: 0x04006875 RID: 26741
		private int quality_;

		// Token: 0x04006876 RID: 26742
		public const int VersionIdFieldNumber = 31;

		// Token: 0x04006877 RID: 26743
		private int versionId_;

		// Token: 0x04006878 RID: 26744
		public const int ShopIdFieldNumber = 32;

		// Token: 0x04006879 RID: 26745
		private int shopId_;

		// Token: 0x0400687A RID: 26746
		public const int NeedConsoleRulePromptFieldNumber = 33;

		// Token: 0x0400687B RID: 26747
		private bool needConsoleRulePrompt_;
	}
}
