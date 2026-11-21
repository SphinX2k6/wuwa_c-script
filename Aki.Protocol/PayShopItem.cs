using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE2 RID: 3042
	public sealed class PayShopItem : IMessage<PayShopItem>, IMessage, IEquatable<PayShopItem>, IDeepCloneable<PayShopItem>, IBufferMessage
	{
		// Token: 0x06010830 RID: 67632 RVA: 0x0026A1F8 File Offset: 0x002683F8
		[NullableContext(1)]
		public static PayShopItem Create()
		{
			return new PayShopItem();
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x06010831 RID: 67633 RVA: 0x0026A1FF File Offset: 0x002683FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayShopItem> Parser
		{
			get
			{
				return PayShopItem._parser;
			}
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x06010832 RID: 67634 RVA: 0x0026A206 File Offset: 0x00268406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x06010833 RID: 67635 RVA: 0x0026A209 File Offset: 0x00268409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopItem.Descriptor;
			}
		}

		// Token: 0x06010834 RID: 67636 RVA: 0x0026A210 File Offset: 0x00268410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItem()
		{
		}

		// Token: 0x06010835 RID: 67637 RVA: 0x0026A244 File Offset: 0x00268444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItem(PayShopItem other) : this()
		{
			this.id_ = other.id_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this.locked_ = other.locked_;
			this.buyLimit_ = other.buyLimit_;
			this.boughtCount_ = other.boughtCount_;
			this.price_ = ((other.price_ != null) ? other.price_.Clone() : null);
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.beginPromotionTime_ = other.beginPromotionTime_;
			this.endPromotionTime_ = other.endPromotionTime_;
			this.updateType_ = other.updateType_;
			this.updateTime_ = other.updateTime_;
			this.shopItemType_ = other.shopItemType_;
			this.tagBeginTime_ = other.tagBeginTime_;
			this.tagEndTime_ = other.tagEndTime_;
			this.canBuyGoods_ = other.canBuyGoods_;
			this.isRemind_ = other.isRemind_;
			this.buyLimitConditionId_ = other.buyLimitConditionId_;
			this.coupons_ = other.coupons_.Clone();
			this.lastUpdateTime_ = other.lastUpdateTime_;
			this.stageImage_ = other.stageImage_;
			this.showStageImage_ = other.showStageImage_;
			this.tabId_ = other.tabId_;
			this.shopId_ = other.shopId_;
			this.tag_ = other.tag_;
			this.sort_ = other.sort_;
			this.promotionShow_ = other.promotionShow_;
			this.soldoutShowInShop_ = other.soldoutShowInShop_;
			this.activityId_ = other.activityId_;
			this.show_ = other.show_;
			this.complianceDetail_ = other.complianceDetail_;
			this.quality_ = other.quality_;
			this.discountSort_ = other.discountSort_;
			this.onceBuyLimit_ = other.onceBuyLimit_;
			this.isRecommend_ = other.isRecommend_;
			this.isShowHaveNum_ = other.isShowHaveNum_;
			this.isBuyMaxButton_ = other.isBuyMaxButton_;
			this.confirmLimitCount_ = other.confirmLimitCount_;
			this.showBeginTime_ = other.showBeginTime_;
			this.showEndTime_ = other.showEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010836 RID: 67638 RVA: 0x0026A469 File Offset: 0x00268669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItem Clone()
		{
			return new PayShopItem(this);
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x06010837 RID: 67639 RVA: 0x0026A471 File Offset: 0x00268671
		// (set) Token: 0x06010838 RID: 67640 RVA: 0x0026A479 File Offset: 0x00268679
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

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x06010839 RID: 67641 RVA: 0x0026A482 File Offset: 0x00268682
		// (set) Token: 0x0601083A RID: 67642 RVA: 0x0026A48A File Offset: 0x0026868A
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

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0601083B RID: 67643 RVA: 0x0026A493 File Offset: 0x00268693
		// (set) Token: 0x0601083C RID: 67644 RVA: 0x0026A49B File Offset: 0x0026869B
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

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0601083D RID: 67645 RVA: 0x0026A4A4 File Offset: 0x002686A4
		// (set) Token: 0x0601083E RID: 67646 RVA: 0x0026A4AC File Offset: 0x002686AC
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

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0601083F RID: 67647 RVA: 0x0026A4B5 File Offset: 0x002686B5
		// (set) Token: 0x06010840 RID: 67648 RVA: 0x0026A4BD File Offset: 0x002686BD
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

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x06010841 RID: 67649 RVA: 0x0026A4C6 File Offset: 0x002686C6
		// (set) Token: 0x06010842 RID: 67650 RVA: 0x0026A4CE File Offset: 0x002686CE
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

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x06010843 RID: 67651 RVA: 0x0026A4D7 File Offset: 0x002686D7
		// (set) Token: 0x06010844 RID: 67652 RVA: 0x0026A4DF File Offset: 0x002686DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopPrice Price
		{
			get
			{
				return this.price_;
			}
			set
			{
				this.price_ = value;
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x06010845 RID: 67653 RVA: 0x0026A4E8 File Offset: 0x002686E8
		// (set) Token: 0x06010846 RID: 67654 RVA: 0x0026A4F0 File Offset: 0x002686F0
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

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x06010847 RID: 67655 RVA: 0x0026A4F9 File Offset: 0x002686F9
		// (set) Token: 0x06010848 RID: 67656 RVA: 0x0026A501 File Offset: 0x00268701
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

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x06010849 RID: 67657 RVA: 0x0026A50A File Offset: 0x0026870A
		// (set) Token: 0x0601084A RID: 67658 RVA: 0x0026A512 File Offset: 0x00268712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginPromotionTime
		{
			get
			{
				return this.beginPromotionTime_;
			}
			set
			{
				this.beginPromotionTime_ = value;
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0601084B RID: 67659 RVA: 0x0026A51B File Offset: 0x0026871B
		// (set) Token: 0x0601084C RID: 67660 RVA: 0x0026A523 File Offset: 0x00268723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndPromotionTime
		{
			get
			{
				return this.endPromotionTime_;
			}
			set
			{
				this.endPromotionTime_ = value;
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0601084D RID: 67661 RVA: 0x0026A52C File Offset: 0x0026872C
		// (set) Token: 0x0601084E RID: 67662 RVA: 0x0026A534 File Offset: 0x00268734
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

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0601084F RID: 67663 RVA: 0x0026A53D File Offset: 0x0026873D
		// (set) Token: 0x06010850 RID: 67664 RVA: 0x0026A545 File Offset: 0x00268745
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

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x06010851 RID: 67665 RVA: 0x0026A54E File Offset: 0x0026874E
		// (set) Token: 0x06010852 RID: 67666 RVA: 0x0026A556 File Offset: 0x00268756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItemType ShopItemType
		{
			get
			{
				return this.shopItemType_;
			}
			set
			{
				this.shopItemType_ = value;
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x06010853 RID: 67667 RVA: 0x0026A55F File Offset: 0x0026875F
		// (set) Token: 0x06010854 RID: 67668 RVA: 0x0026A567 File Offset: 0x00268767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TagBeginTime
		{
			get
			{
				return this.tagBeginTime_;
			}
			set
			{
				this.tagBeginTime_ = value;
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x06010855 RID: 67669 RVA: 0x0026A570 File Offset: 0x00268770
		// (set) Token: 0x06010856 RID: 67670 RVA: 0x0026A578 File Offset: 0x00268778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TagEndTime
		{
			get
			{
				return this.tagEndTime_;
			}
			set
			{
				this.tagEndTime_ = value;
			}
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x06010857 RID: 67671 RVA: 0x0026A581 File Offset: 0x00268781
		// (set) Token: 0x06010858 RID: 67672 RVA: 0x0026A589 File Offset: 0x00268789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanBuyGoods
		{
			get
			{
				return this.canBuyGoods_;
			}
			set
			{
				this.canBuyGoods_ = value;
			}
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x06010859 RID: 67673 RVA: 0x0026A592 File Offset: 0x00268792
		// (set) Token: 0x0601085A RID: 67674 RVA: 0x0026A59A File Offset: 0x0026879A
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

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0601085B RID: 67675 RVA: 0x0026A5A3 File Offset: 0x002687A3
		// (set) Token: 0x0601085C RID: 67676 RVA: 0x0026A5AB File Offset: 0x002687AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuyLimitConditionId
		{
			get
			{
				return this.buyLimitConditionId_;
			}
			set
			{
				this.buyLimitConditionId_ = value;
			}
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0601085D RID: 67677 RVA: 0x0026A5B4 File Offset: 0x002687B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Coupons
		{
			get
			{
				return this.coupons_;
			}
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0601085E RID: 67678 RVA: 0x0026A5BC File Offset: 0x002687BC
		// (set) Token: 0x0601085F RID: 67679 RVA: 0x0026A5C4 File Offset: 0x002687C4
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

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x06010860 RID: 67680 RVA: 0x0026A5CD File Offset: 0x002687CD
		// (set) Token: 0x06010861 RID: 67681 RVA: 0x0026A5D5 File Offset: 0x002687D5
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

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x06010862 RID: 67682 RVA: 0x0026A5E8 File Offset: 0x002687E8
		// (set) Token: 0x06010863 RID: 67683 RVA: 0x0026A5F0 File Offset: 0x002687F0
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

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x06010864 RID: 67684 RVA: 0x0026A603 File Offset: 0x00268803
		// (set) Token: 0x06010865 RID: 67685 RVA: 0x0026A60B File Offset: 0x0026880B
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

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x06010866 RID: 67686 RVA: 0x0026A614 File Offset: 0x00268814
		// (set) Token: 0x06010867 RID: 67687 RVA: 0x0026A61C File Offset: 0x0026881C
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

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x06010868 RID: 67688 RVA: 0x0026A625 File Offset: 0x00268825
		// (set) Token: 0x06010869 RID: 67689 RVA: 0x0026A62D File Offset: 0x0026882D
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

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0601086A RID: 67690 RVA: 0x0026A636 File Offset: 0x00268836
		// (set) Token: 0x0601086B RID: 67691 RVA: 0x0026A63E File Offset: 0x0026883E
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

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0601086C RID: 67692 RVA: 0x0026A647 File Offset: 0x00268847
		// (set) Token: 0x0601086D RID: 67693 RVA: 0x0026A64F File Offset: 0x0026884F
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

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0601086E RID: 67694 RVA: 0x0026A658 File Offset: 0x00268858
		// (set) Token: 0x0601086F RID: 67695 RVA: 0x0026A660 File Offset: 0x00268860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SoldoutShowInShop
		{
			get
			{
				return this.soldoutShowInShop_;
			}
			set
			{
				this.soldoutShowInShop_ = value;
			}
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x06010870 RID: 67696 RVA: 0x0026A669 File Offset: 0x00268869
		// (set) Token: 0x06010871 RID: 67697 RVA: 0x0026A671 File Offset: 0x00268871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x06010872 RID: 67698 RVA: 0x0026A67A File Offset: 0x0026887A
		// (set) Token: 0x06010873 RID: 67699 RVA: 0x0026A682 File Offset: 0x00268882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Show
		{
			get
			{
				return this.show_;
			}
			set
			{
				this.show_ = value;
			}
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x06010874 RID: 67700 RVA: 0x0026A68B File Offset: 0x0026888B
		// (set) Token: 0x06010875 RID: 67701 RVA: 0x0026A693 File Offset: 0x00268893
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

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x06010876 RID: 67702 RVA: 0x0026A6A6 File Offset: 0x002688A6
		// (set) Token: 0x06010877 RID: 67703 RVA: 0x0026A6AE File Offset: 0x002688AE
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

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x06010878 RID: 67704 RVA: 0x0026A6B7 File Offset: 0x002688B7
		// (set) Token: 0x06010879 RID: 67705 RVA: 0x0026A6BF File Offset: 0x002688BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiscountSort
		{
			get
			{
				return this.discountSort_;
			}
			set
			{
				this.discountSort_ = value;
			}
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0601087A RID: 67706 RVA: 0x0026A6C8 File Offset: 0x002688C8
		// (set) Token: 0x0601087B RID: 67707 RVA: 0x0026A6D0 File Offset: 0x002688D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OnceBuyLimit
		{
			get
			{
				return this.onceBuyLimit_;
			}
			set
			{
				this.onceBuyLimit_ = value;
			}
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0601087C RID: 67708 RVA: 0x0026A6D9 File Offset: 0x002688D9
		// (set) Token: 0x0601087D RID: 67709 RVA: 0x0026A6E1 File Offset: 0x002688E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRecommend
		{
			get
			{
				return this.isRecommend_;
			}
			set
			{
				this.isRecommend_ = value;
			}
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0601087E RID: 67710 RVA: 0x0026A6EA File Offset: 0x002688EA
		// (set) Token: 0x0601087F RID: 67711 RVA: 0x0026A6F2 File Offset: 0x002688F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShowHaveNum
		{
			get
			{
				return this.isShowHaveNum_;
			}
			set
			{
				this.isShowHaveNum_ = value;
			}
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x06010880 RID: 67712 RVA: 0x0026A6FB File Offset: 0x002688FB
		// (set) Token: 0x06010881 RID: 67713 RVA: 0x0026A703 File Offset: 0x00268903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBuyMaxButton
		{
			get
			{
				return this.isBuyMaxButton_;
			}
			set
			{
				this.isBuyMaxButton_ = value;
			}
		}

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x06010882 RID: 67714 RVA: 0x0026A70C File Offset: 0x0026890C
		// (set) Token: 0x06010883 RID: 67715 RVA: 0x0026A714 File Offset: 0x00268914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfirmLimitCount
		{
			get
			{
				return this.confirmLimitCount_;
			}
			set
			{
				this.confirmLimitCount_ = value;
			}
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x06010884 RID: 67716 RVA: 0x0026A71D File Offset: 0x0026891D
		// (set) Token: 0x06010885 RID: 67717 RVA: 0x0026A725 File Offset: 0x00268925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ShowBeginTime
		{
			get
			{
				return this.showBeginTime_;
			}
			set
			{
				this.showBeginTime_ = value;
			}
		}

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x06010886 RID: 67718 RVA: 0x0026A72E File Offset: 0x0026892E
		// (set) Token: 0x06010887 RID: 67719 RVA: 0x0026A736 File Offset: 0x00268936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ShowEndTime
		{
			get
			{
				return this.showEndTime_;
			}
			set
			{
				this.showEndTime_ = value;
			}
		}

		// Token: 0x06010888 RID: 67720 RVA: 0x0026A73F File Offset: 0x0026893F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopItem);
		}

		// Token: 0x06010889 RID: 67721 RVA: 0x0026A750 File Offset: 0x00268950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && this.Locked == other.Locked && this.BuyLimit == other.BuyLimit && this.BoughtCount == other.BoughtCount && object.Equals(this.Price, other.Price) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.BeginPromotionTime == other.BeginPromotionTime && this.EndPromotionTime == other.EndPromotionTime && this.UpdateType == other.UpdateType && this.UpdateTime == other.UpdateTime && this.ShopItemType == other.ShopItemType && this.TagBeginTime == other.TagBeginTime && this.TagEndTime == other.TagEndTime && this.CanBuyGoods == other.CanBuyGoods && this.IsRemind == other.IsRemind && this.BuyLimitConditionId == other.BuyLimitConditionId && this.coupons_.Equals(other.coupons_) && this.LastUpdateTime == other.LastUpdateTime && !(this.StageImage != other.StageImage) && !(this.ShowStageImage != other.ShowStageImage) && this.TabId == other.TabId && this.ShopId == other.ShopId && this.Tag == other.Tag && this.Sort == other.Sort && this.PromotionShow == other.PromotionShow && this.SoldoutShowInShop == other.SoldoutShowInShop && this.ActivityId == other.ActivityId && this.Show == other.Show && !(this.ComplianceDetail != other.ComplianceDetail) && this.Quality == other.Quality && this.DiscountSort == other.DiscountSort && this.OnceBuyLimit == other.OnceBuyLimit && this.IsRecommend == other.IsRecommend && this.IsShowHaveNum == other.IsShowHaveNum && this.IsBuyMaxButton == other.IsBuyMaxButton && this.ConfirmLimitCount == other.ConfirmLimitCount && this.ShowBeginTime == other.ShowBeginTime && this.ShowEndTime == other.ShowEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601088A RID: 67722 RVA: 0x0026AA24 File Offset: 0x00268C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this.Locked)
			{
				num ^= this.Locked.GetHashCode();
			}
			if (this.BuyLimit != 0)
			{
				num ^= this.BuyLimit.GetHashCode();
			}
			if (this.BoughtCount != 0)
			{
				num ^= this.BoughtCount.GetHashCode();
			}
			if (this.price_ != null)
			{
				num ^= this.Price.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.BeginPromotionTime != 0L)
			{
				num ^= this.BeginPromotionTime.GetHashCode();
			}
			if (this.EndPromotionTime != 0L)
			{
				num ^= this.EndPromotionTime.GetHashCode();
			}
			if (this.UpdateType != PayUpdateType.None)
			{
				num ^= this.UpdateType.GetHashCode();
			}
			if (this.UpdateTime != 0L)
			{
				num ^= this.UpdateTime.GetHashCode();
			}
			if (this.ShopItemType != PayShopItemType.Normal)
			{
				num ^= this.ShopItemType.GetHashCode();
			}
			if (this.TagBeginTime != 0L)
			{
				num ^= this.TagBeginTime.GetHashCode();
			}
			if (this.TagEndTime != 0L)
			{
				num ^= this.TagEndTime.GetHashCode();
			}
			if (this.CanBuyGoods)
			{
				num ^= this.CanBuyGoods.GetHashCode();
			}
			if (this.IsRemind)
			{
				num ^= this.IsRemind.GetHashCode();
			}
			if (this.BuyLimitConditionId != 0)
			{
				num ^= this.BuyLimitConditionId.GetHashCode();
			}
			num ^= this.coupons_.GetHashCode();
			if (this.LastUpdateTime != 0L)
			{
				num ^= this.LastUpdateTime.GetHashCode();
			}
			if (this.StageImage.Length != 0)
			{
				num ^= this.StageImage.GetHashCode();
			}
			if (this.ShowStageImage.Length != 0)
			{
				num ^= this.ShowStageImage.GetHashCode();
			}
			if (this.TabId != 0)
			{
				num ^= this.TabId.GetHashCode();
			}
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Tag != 0)
			{
				num ^= this.Tag.GetHashCode();
			}
			if (this.Sort != 0)
			{
				num ^= this.Sort.GetHashCode();
			}
			if (this.PromotionShow != 0)
			{
				num ^= this.PromotionShow.GetHashCode();
			}
			if (this.SoldoutShowInShop)
			{
				num ^= this.SoldoutShowInShop.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Show)
			{
				num ^= this.Show.GetHashCode();
			}
			if (this.ComplianceDetail.Length != 0)
			{
				num ^= this.ComplianceDetail.GetHashCode();
			}
			if (this.Quality != 0)
			{
				num ^= this.Quality.GetHashCode();
			}
			if (this.DiscountSort != 0)
			{
				num ^= this.DiscountSort.GetHashCode();
			}
			if (this.OnceBuyLimit != 0)
			{
				num ^= this.OnceBuyLimit.GetHashCode();
			}
			if (this.IsRecommend)
			{
				num ^= this.IsRecommend.GetHashCode();
			}
			if (this.IsShowHaveNum)
			{
				num ^= this.IsShowHaveNum.GetHashCode();
			}
			if (this.IsBuyMaxButton)
			{
				num ^= this.IsBuyMaxButton.GetHashCode();
			}
			if (this.ConfirmLimitCount != 0)
			{
				num ^= this.ConfirmLimitCount.GetHashCode();
			}
			if (this.ShowBeginTime != 0L)
			{
				num ^= this.ShowBeginTime.GetHashCode();
			}
			if (this.ShowEndTime != 0L)
			{
				num ^= this.ShowEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601088B RID: 67723 RVA: 0x0026AE51 File Offset: 0x00269051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601088C RID: 67724 RVA: 0x0026AE5E File Offset: 0x0026905E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601088D RID: 67725 RVA: 0x0026AE68 File Offset: 0x00269068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
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
			if (this.Locked)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Locked);
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
			if (this.price_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Price);
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
			if (this.BeginPromotionTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.BeginPromotionTime);
			}
			if (this.EndPromotionTime != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EndPromotionTime);
			}
			if (this.UpdateType != PayUpdateType.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.UpdateType);
			}
			if (this.UpdateTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.UpdateTime);
			}
			if (this.ShopItemType != PayShopItemType.Normal)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ShopItemType);
			}
			if (this.TagBeginTime != 0L)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt64(this.TagBeginTime);
			}
			if (this.TagEndTime != 0L)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt64(this.TagEndTime);
			}
			if (this.CanBuyGoods)
			{
				output.WriteRawTag(176, 1);
				output.WriteBool(this.CanBuyGoods);
			}
			if (this.IsRemind)
			{
				output.WriteRawTag(184, 1);
				output.WriteBool(this.IsRemind);
			}
			if (this.BuyLimitConditionId != 0)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt32(this.BuyLimitConditionId);
			}
			this.coupons_.WriteTo(ref output, PayShopItem._repeated_coupons_codec);
			if (this.LastUpdateTime != 0L)
			{
				output.WriteRawTag(208, 1);
				output.WriteInt64(this.LastUpdateTime);
			}
			if (this.StageImage.Length != 0)
			{
				output.WriteRawTag(218, 1);
				output.WriteString(this.StageImage);
			}
			if (this.ShowStageImage.Length != 0)
			{
				output.WriteRawTag(226, 1);
				output.WriteString(this.ShowStageImage);
			}
			if (this.TabId != 0)
			{
				output.WriteRawTag(232, 1);
				output.WriteInt32(this.TabId);
			}
			if (this.ShopId != 0)
			{
				output.WriteRawTag(240, 1);
				output.WriteInt32(this.ShopId);
			}
			if (this.Tag != 0)
			{
				output.WriteRawTag(248, 1);
				output.WriteInt32(this.Tag);
			}
			if (this.Sort != 0)
			{
				output.WriteRawTag(128, 2);
				output.WriteInt32(this.Sort);
			}
			if (this.PromotionShow != 0)
			{
				output.WriteRawTag(136, 2);
				output.WriteInt32(this.PromotionShow);
			}
			if (this.SoldoutShowInShop)
			{
				output.WriteRawTag(144, 2);
				output.WriteBool(this.SoldoutShowInShop);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(152, 2);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Show)
			{
				output.WriteRawTag(160, 2);
				output.WriteBool(this.Show);
			}
			if (this.ComplianceDetail.Length != 0)
			{
				output.WriteRawTag(170, 2);
				output.WriteString(this.ComplianceDetail);
			}
			if (this.Quality != 0)
			{
				output.WriteRawTag(176, 2);
				output.WriteInt32(this.Quality);
			}
			if (this.DiscountSort != 0)
			{
				output.WriteRawTag(184, 2);
				output.WriteInt32(this.DiscountSort);
			}
			if (this.OnceBuyLimit != 0)
			{
				output.WriteRawTag(192, 2);
				output.WriteInt32(this.OnceBuyLimit);
			}
			if (this.IsRecommend)
			{
				output.WriteRawTag(200, 2);
				output.WriteBool(this.IsRecommend);
			}
			if (this.IsShowHaveNum)
			{
				output.WriteRawTag(208, 2);
				output.WriteBool(this.IsShowHaveNum);
			}
			if (this.IsBuyMaxButton)
			{
				output.WriteRawTag(216, 2);
				output.WriteBool(this.IsBuyMaxButton);
			}
			if (this.ConfirmLimitCount != 0)
			{
				output.WriteRawTag(224, 2);
				output.WriteInt32(this.ConfirmLimitCount);
			}
			if (this.ShowBeginTime != 0L)
			{
				output.WriteRawTag(232, 2);
				output.WriteInt64(this.ShowBeginTime);
			}
			if (this.ShowEndTime != 0L)
			{
				output.WriteRawTag(240, 2);
				output.WriteInt64(this.ShowEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601088E RID: 67726 RVA: 0x0026B370 File Offset: 0x00269570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this.Locked)
			{
				num += 2;
			}
			if (this.BuyLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuyLimit);
			}
			if (this.BoughtCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoughtCount);
			}
			if (this.price_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Price);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.BeginPromotionTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginPromotionTime);
			}
			if (this.EndPromotionTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndPromotionTime);
			}
			if (this.UpdateType != PayUpdateType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.UpdateType);
			}
			if (this.UpdateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpdateTime);
			}
			if (this.ShopItemType != PayShopItemType.Normal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ShopItemType);
			}
			if (this.TagBeginTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.TagBeginTime);
			}
			if (this.TagEndTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.TagEndTime);
			}
			if (this.CanBuyGoods)
			{
				num += 3;
			}
			if (this.IsRemind)
			{
				num += 3;
			}
			if (this.BuyLimitConditionId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BuyLimitConditionId);
			}
			num += this.coupons_.CalculateSize(PayShopItem._repeated_coupons_codec);
			if (this.LastUpdateTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LastUpdateTime);
			}
			if (this.StageImage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.StageImage);
			}
			if (this.ShowStageImage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ShowStageImage);
			}
			if (this.TabId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TabId);
			}
			if (this.ShopId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.Tag != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Tag);
			}
			if (this.Sort != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Sort);
			}
			if (this.PromotionShow != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PromotionShow);
			}
			if (this.SoldoutShowInShop)
			{
				num += 3;
			}
			if (this.ActivityId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Show)
			{
				num += 3;
			}
			if (this.ComplianceDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ComplianceDetail);
			}
			if (this.Quality != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Quality);
			}
			if (this.DiscountSort != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DiscountSort);
			}
			if (this.OnceBuyLimit != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.OnceBuyLimit);
			}
			if (this.IsRecommend)
			{
				num += 3;
			}
			if (this.IsShowHaveNum)
			{
				num += 3;
			}
			if (this.IsBuyMaxButton)
			{
				num += 3;
			}
			if (this.ConfirmLimitCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ConfirmLimitCount);
			}
			if (this.ShowBeginTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.ShowBeginTime);
			}
			if (this.ShowEndTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.ShowEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601088F RID: 67727 RVA: 0x0026B718 File Offset: 0x00269918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			if (other.Locked)
			{
				this.Locked = other.Locked;
			}
			if (other.BuyLimit != 0)
			{
				this.BuyLimit = other.BuyLimit;
			}
			if (other.BoughtCount != 0)
			{
				this.BoughtCount = other.BoughtCount;
			}
			if (other.price_ != null)
			{
				if (this.price_ == null)
				{
					this.Price = new PayShopPrice();
				}
				this.Price.MergeFrom(other.Price);
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.BeginPromotionTime != 0L)
			{
				this.BeginPromotionTime = other.BeginPromotionTime;
			}
			if (other.EndPromotionTime != 0L)
			{
				this.EndPromotionTime = other.EndPromotionTime;
			}
			if (other.UpdateType != PayUpdateType.None)
			{
				this.UpdateType = other.UpdateType;
			}
			if (other.UpdateTime != 0L)
			{
				this.UpdateTime = other.UpdateTime;
			}
			if (other.ShopItemType != PayShopItemType.Normal)
			{
				this.ShopItemType = other.ShopItemType;
			}
			if (other.TagBeginTime != 0L)
			{
				this.TagBeginTime = other.TagBeginTime;
			}
			if (other.TagEndTime != 0L)
			{
				this.TagEndTime = other.TagEndTime;
			}
			if (other.CanBuyGoods)
			{
				this.CanBuyGoods = other.CanBuyGoods;
			}
			if (other.IsRemind)
			{
				this.IsRemind = other.IsRemind;
			}
			if (other.BuyLimitConditionId != 0)
			{
				this.BuyLimitConditionId = other.BuyLimitConditionId;
			}
			this.coupons_.Add(other.coupons_);
			if (other.LastUpdateTime != 0L)
			{
				this.LastUpdateTime = other.LastUpdateTime;
			}
			if (other.StageImage.Length != 0)
			{
				this.StageImage = other.StageImage;
			}
			if (other.ShowStageImage.Length != 0)
			{
				this.ShowStageImage = other.ShowStageImage;
			}
			if (other.TabId != 0)
			{
				this.TabId = other.TabId;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Tag != 0)
			{
				this.Tag = other.Tag;
			}
			if (other.Sort != 0)
			{
				this.Sort = other.Sort;
			}
			if (other.PromotionShow != 0)
			{
				this.PromotionShow = other.PromotionShow;
			}
			if (other.SoldoutShowInShop)
			{
				this.SoldoutShowInShop = other.SoldoutShowInShop;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Show)
			{
				this.Show = other.Show;
			}
			if (other.ComplianceDetail.Length != 0)
			{
				this.ComplianceDetail = other.ComplianceDetail;
			}
			if (other.Quality != 0)
			{
				this.Quality = other.Quality;
			}
			if (other.DiscountSort != 0)
			{
				this.DiscountSort = other.DiscountSort;
			}
			if (other.OnceBuyLimit != 0)
			{
				this.OnceBuyLimit = other.OnceBuyLimit;
			}
			if (other.IsRecommend)
			{
				this.IsRecommend = other.IsRecommend;
			}
			if (other.IsShowHaveNum)
			{
				this.IsShowHaveNum = other.IsShowHaveNum;
			}
			if (other.IsBuyMaxButton)
			{
				this.IsBuyMaxButton = other.IsBuyMaxButton;
			}
			if (other.ConfirmLimitCount != 0)
			{
				this.ConfirmLimitCount = other.ConfirmLimitCount;
			}
			if (other.ShowBeginTime != 0L)
			{
				this.ShowBeginTime = other.ShowBeginTime;
			}
			if (other.ShowEndTime != 0L)
			{
				this.ShowEndTime = other.ShowEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010890 RID: 67728 RVA: 0x0026BA98 File Offset: 0x00269C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010891 RID: 67729 RVA: 0x0026BAA4 File Offset: 0x00269CA4
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
				if (num <= 202U)
				{
					if (num <= 88U)
					{
						if (num <= 48U)
						{
							if (num <= 24U)
							{
								if (num == 8U)
								{
									this.Id = input.ReadInt32();
									continue;
								}
								if (num == 24U)
								{
									this.ItemId = input.ReadInt32();
									continue;
								}
							}
							else
							{
								if (num == 32U)
								{
									this.ItemCount = input.ReadInt32();
									continue;
								}
								if (num == 40U)
								{
									this.Locked = input.ReadBool();
									continue;
								}
								if (num == 48U)
								{
									this.BuyLimit = input.ReadInt32();
									continue;
								}
							}
						}
						else if (num <= 66U)
						{
							if (num == 56U)
							{
								this.BoughtCount = input.ReadInt32();
								continue;
							}
							if (num == 66U)
							{
								if (this.price_ == null)
								{
									this.Price = new PayShopPrice();
								}
								input.ReadMessage(this.Price);
								continue;
							}
						}
						else
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
							if (num == 88U)
							{
								this.BeginPromotionTime = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 136U)
					{
						if (num <= 104U)
						{
							if (num == 96U)
							{
								this.EndPromotionTime = input.ReadInt64();
								continue;
							}
							if (num == 104U)
							{
								this.UpdateType = (PayUpdateType)input.ReadEnum();
								continue;
							}
						}
						else
						{
							if (num == 112U)
							{
								this.UpdateTime = input.ReadInt64();
								continue;
							}
							if (num == 120U)
							{
								this.ShopItemType = (PayShopItemType)input.ReadEnum();
								continue;
							}
							if (num == 136U)
							{
								this.TagBeginTime = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 184U)
					{
						if (num == 144U)
						{
							this.TagEndTime = input.ReadInt64();
							continue;
						}
						if (num == 176U)
						{
							this.CanBuyGoods = input.ReadBool();
							continue;
						}
						if (num == 184U)
						{
							this.IsRemind = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 192U)
						{
							this.BuyLimitConditionId = input.ReadInt32();
							continue;
						}
						if (num == 200U || num == 202U)
						{
							this.coupons_.AddEntriesFrom(ref input, PayShopItem._repeated_coupons_codec);
							continue;
						}
					}
				}
				else if (num <= 280U)
				{
					if (num <= 240U)
					{
						if (num <= 218U)
						{
							if (num == 208U)
							{
								this.LastUpdateTime = input.ReadInt64();
								continue;
							}
							if (num == 218U)
							{
								this.StageImage = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 226U)
							{
								this.ShowStageImage = input.ReadString();
								continue;
							}
							if (num == 232U)
							{
								this.TabId = input.ReadInt32();
								continue;
							}
							if (num == 240U)
							{
								this.ShopId = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 256U)
					{
						if (num == 248U)
						{
							this.Tag = input.ReadInt32();
							continue;
						}
						if (num == 256U)
						{
							this.Sort = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 264U)
						{
							this.PromotionShow = input.ReadInt32();
							continue;
						}
						if (num == 272U)
						{
							this.SoldoutShowInShop = input.ReadBool();
							continue;
						}
						if (num == 280U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 320U)
				{
					if (num <= 298U)
					{
						if (num == 288U)
						{
							this.Show = input.ReadBool();
							continue;
						}
						if (num == 298U)
						{
							this.ComplianceDetail = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 304U)
						{
							this.Quality = input.ReadInt32();
							continue;
						}
						if (num == 312U)
						{
							this.DiscountSort = input.ReadInt32();
							continue;
						}
						if (num == 320U)
						{
							this.OnceBuyLimit = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 344U)
				{
					if (num == 328U)
					{
						this.IsRecommend = input.ReadBool();
						continue;
					}
					if (num == 336U)
					{
						this.IsShowHaveNum = input.ReadBool();
						continue;
					}
					if (num == 344U)
					{
						this.IsBuyMaxButton = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 352U)
					{
						this.ConfirmLimitCount = input.ReadInt32();
						continue;
					}
					if (num == 360U)
					{
						this.ShowBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 368U)
					{
						this.ShowEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006940 RID: 26944
		private static readonly MessageParser<PayShopItem> _parser = new MessageParser<PayShopItem>(() => new PayShopItem());

		// Token: 0x04006941 RID: 26945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006942 RID: 26946
		public const int IdFieldNumber = 1;

		// Token: 0x04006943 RID: 26947
		private int id_;

		// Token: 0x04006944 RID: 26948
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04006945 RID: 26949
		private int itemId_;

		// Token: 0x04006946 RID: 26950
		public const int ItemCountFieldNumber = 4;

		// Token: 0x04006947 RID: 26951
		private int itemCount_;

		// Token: 0x04006948 RID: 26952
		public const int LockedFieldNumber = 5;

		// Token: 0x04006949 RID: 26953
		private bool locked_;

		// Token: 0x0400694A RID: 26954
		public const int BuyLimitFieldNumber = 6;

		// Token: 0x0400694B RID: 26955
		private int buyLimit_;

		// Token: 0x0400694C RID: 26956
		public const int BoughtCountFieldNumber = 7;

		// Token: 0x0400694D RID: 26957
		private int boughtCount_;

		// Token: 0x0400694E RID: 26958
		public const int PriceFieldNumber = 8;

		// Token: 0x0400694F RID: 26959
		private PayShopPrice price_;

		// Token: 0x04006950 RID: 26960
		public const int BeginTimeFieldNumber = 9;

		// Token: 0x04006951 RID: 26961
		private long beginTime_;

		// Token: 0x04006952 RID: 26962
		public const int EndTimeFieldNumber = 10;

		// Token: 0x04006953 RID: 26963
		private long endTime_;

		// Token: 0x04006954 RID: 26964
		public const int BeginPromotionTimeFieldNumber = 11;

		// Token: 0x04006955 RID: 26965
		private long beginPromotionTime_;

		// Token: 0x04006956 RID: 26966
		public const int EndPromotionTimeFieldNumber = 12;

		// Token: 0x04006957 RID: 26967
		private long endPromotionTime_;

		// Token: 0x04006958 RID: 26968
		public const int UpdateTypeFieldNumber = 13;

		// Token: 0x04006959 RID: 26969
		private PayUpdateType updateType_;

		// Token: 0x0400695A RID: 26970
		public const int UpdateTimeFieldNumber = 14;

		// Token: 0x0400695B RID: 26971
		private long updateTime_;

		// Token: 0x0400695C RID: 26972
		public const int ShopItemTypeFieldNumber = 15;

		// Token: 0x0400695D RID: 26973
		private PayShopItemType shopItemType_;

		// Token: 0x0400695E RID: 26974
		public const int TagBeginTimeFieldNumber = 17;

		// Token: 0x0400695F RID: 26975
		private long tagBeginTime_;

		// Token: 0x04006960 RID: 26976
		public const int TagEndTimeFieldNumber = 18;

		// Token: 0x04006961 RID: 26977
		private long tagEndTime_;

		// Token: 0x04006962 RID: 26978
		public const int CanBuyGoodsFieldNumber = 22;

		// Token: 0x04006963 RID: 26979
		private bool canBuyGoods_;

		// Token: 0x04006964 RID: 26980
		public const int IsRemindFieldNumber = 23;

		// Token: 0x04006965 RID: 26981
		private bool isRemind_;

		// Token: 0x04006966 RID: 26982
		public const int BuyLimitConditionIdFieldNumber = 24;

		// Token: 0x04006967 RID: 26983
		private int buyLimitConditionId_;

		// Token: 0x04006968 RID: 26984
		public const int CouponsFieldNumber = 25;

		// Token: 0x04006969 RID: 26985
		private static readonly FieldCodec<int> _repeated_coupons_codec = FieldCodec.ForInt32(202U);

		// Token: 0x0400696A RID: 26986
		private readonly RepeatedField<int> coupons_ = new RepeatedField<int>();

		// Token: 0x0400696B RID: 26987
		public const int LastUpdateTimeFieldNumber = 26;

		// Token: 0x0400696C RID: 26988
		private long lastUpdateTime_;

		// Token: 0x0400696D RID: 26989
		public const int StageImageFieldNumber = 27;

		// Token: 0x0400696E RID: 26990
		private string stageImage_ = "";

		// Token: 0x0400696F RID: 26991
		public const int ShowStageImageFieldNumber = 28;

		// Token: 0x04006970 RID: 26992
		private string showStageImage_ = "";

		// Token: 0x04006971 RID: 26993
		public const int TabIdFieldNumber = 29;

		// Token: 0x04006972 RID: 26994
		private int tabId_;

		// Token: 0x04006973 RID: 26995
		public const int ShopIdFieldNumber = 30;

		// Token: 0x04006974 RID: 26996
		private int shopId_;

		// Token: 0x04006975 RID: 26997
		public const int TagFieldNumber = 31;

		// Token: 0x04006976 RID: 26998
		private int tag_;

		// Token: 0x04006977 RID: 26999
		public const int SortFieldNumber = 32;

		// Token: 0x04006978 RID: 27000
		private int sort_;

		// Token: 0x04006979 RID: 27001
		public const int PromotionShowFieldNumber = 33;

		// Token: 0x0400697A RID: 27002
		private int promotionShow_;

		// Token: 0x0400697B RID: 27003
		public const int SoldoutShowInShopFieldNumber = 34;

		// Token: 0x0400697C RID: 27004
		private bool soldoutShowInShop_;

		// Token: 0x0400697D RID: 27005
		public const int ActivityIdFieldNumber = 35;

		// Token: 0x0400697E RID: 27006
		private int activityId_;

		// Token: 0x0400697F RID: 27007
		public const int ShowFieldNumber = 36;

		// Token: 0x04006980 RID: 27008
		private bool show_;

		// Token: 0x04006981 RID: 27009
		public const int ComplianceDetailFieldNumber = 37;

		// Token: 0x04006982 RID: 27010
		private string complianceDetail_ = "";

		// Token: 0x04006983 RID: 27011
		public const int QualityFieldNumber = 38;

		// Token: 0x04006984 RID: 27012
		private int quality_;

		// Token: 0x04006985 RID: 27013
		public const int DiscountSortFieldNumber = 39;

		// Token: 0x04006986 RID: 27014
		private int discountSort_;

		// Token: 0x04006987 RID: 27015
		public const int OnceBuyLimitFieldNumber = 40;

		// Token: 0x04006988 RID: 27016
		private int onceBuyLimit_;

		// Token: 0x04006989 RID: 27017
		public const int IsRecommendFieldNumber = 41;

		// Token: 0x0400698A RID: 27018
		private bool isRecommend_;

		// Token: 0x0400698B RID: 27019
		public const int IsShowHaveNumFieldNumber = 42;

		// Token: 0x0400698C RID: 27020
		private bool isShowHaveNum_;

		// Token: 0x0400698D RID: 27021
		public const int IsBuyMaxButtonFieldNumber = 43;

		// Token: 0x0400698E RID: 27022
		private bool isBuyMaxButton_;

		// Token: 0x0400698F RID: 27023
		public const int ConfirmLimitCountFieldNumber = 44;

		// Token: 0x04006990 RID: 27024
		private int confirmLimitCount_;

		// Token: 0x04006991 RID: 27025
		public const int ShowBeginTimeFieldNumber = 45;

		// Token: 0x04006992 RID: 27026
		private long showBeginTime_;

		// Token: 0x04006993 RID: 27027
		public const int ShowEndTimeFieldNumber = 46;

		// Token: 0x04006994 RID: 27028
		private long showEndTime_;
	}
}
