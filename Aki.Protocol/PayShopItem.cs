using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF2 RID: 3058
	public sealed class PayShopItem : IMessage<PayShopItem>, IMessage, IEquatable<PayShopItem>, IDeepCloneable<PayShopItem>, IBufferMessage
	{
		// Token: 0x06010934 RID: 67892 RVA: 0x0026C0BC File Offset: 0x0026A2BC
		[NullableContext(1)]
		public static PayShopItem Create()
		{
			return new PayShopItem();
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x06010935 RID: 67893 RVA: 0x0026C0C3 File Offset: 0x0026A2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayShopItem> Parser
		{
			get
			{
				return PayShopItem._parser;
			}
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x06010936 RID: 67894 RVA: 0x0026C0CA File Offset: 0x0026A2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x06010937 RID: 67895 RVA: 0x0026C0CD File Offset: 0x0026A2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopItem.Descriptor;
			}
		}

		// Token: 0x06010938 RID: 67896 RVA: 0x0026C0D4 File Offset: 0x0026A2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItem()
		{
		}

		// Token: 0x06010939 RID: 67897 RVA: 0x0026C108 File Offset: 0x0026A308
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
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601093A RID: 67898 RVA: 0x0026C315 File Offset: 0x0026A515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopItem Clone()
		{
			return new PayShopItem(this);
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0601093B RID: 67899 RVA: 0x0026C31D File Offset: 0x0026A51D
		// (set) Token: 0x0601093C RID: 67900 RVA: 0x0026C325 File Offset: 0x0026A525
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

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0601093D RID: 67901 RVA: 0x0026C32E File Offset: 0x0026A52E
		// (set) Token: 0x0601093E RID: 67902 RVA: 0x0026C336 File Offset: 0x0026A536
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

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0601093F RID: 67903 RVA: 0x0026C33F File Offset: 0x0026A53F
		// (set) Token: 0x06010940 RID: 67904 RVA: 0x0026C347 File Offset: 0x0026A547
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

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x06010941 RID: 67905 RVA: 0x0026C350 File Offset: 0x0026A550
		// (set) Token: 0x06010942 RID: 67906 RVA: 0x0026C358 File Offset: 0x0026A558
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

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x06010943 RID: 67907 RVA: 0x0026C361 File Offset: 0x0026A561
		// (set) Token: 0x06010944 RID: 67908 RVA: 0x0026C369 File Offset: 0x0026A569
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

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x06010945 RID: 67909 RVA: 0x0026C372 File Offset: 0x0026A572
		// (set) Token: 0x06010946 RID: 67910 RVA: 0x0026C37A File Offset: 0x0026A57A
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

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x06010947 RID: 67911 RVA: 0x0026C383 File Offset: 0x0026A583
		// (set) Token: 0x06010948 RID: 67912 RVA: 0x0026C38B File Offset: 0x0026A58B
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

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x06010949 RID: 67913 RVA: 0x0026C394 File Offset: 0x0026A594
		// (set) Token: 0x0601094A RID: 67914 RVA: 0x0026C39C File Offset: 0x0026A59C
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

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0601094B RID: 67915 RVA: 0x0026C3A5 File Offset: 0x0026A5A5
		// (set) Token: 0x0601094C RID: 67916 RVA: 0x0026C3AD File Offset: 0x0026A5AD
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

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0601094D RID: 67917 RVA: 0x0026C3B6 File Offset: 0x0026A5B6
		// (set) Token: 0x0601094E RID: 67918 RVA: 0x0026C3BE File Offset: 0x0026A5BE
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

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0601094F RID: 67919 RVA: 0x0026C3C7 File Offset: 0x0026A5C7
		// (set) Token: 0x06010950 RID: 67920 RVA: 0x0026C3CF File Offset: 0x0026A5CF
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

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x06010951 RID: 67921 RVA: 0x0026C3D8 File Offset: 0x0026A5D8
		// (set) Token: 0x06010952 RID: 67922 RVA: 0x0026C3E0 File Offset: 0x0026A5E0
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

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x06010953 RID: 67923 RVA: 0x0026C3E9 File Offset: 0x0026A5E9
		// (set) Token: 0x06010954 RID: 67924 RVA: 0x0026C3F1 File Offset: 0x0026A5F1
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

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x06010955 RID: 67925 RVA: 0x0026C3FA File Offset: 0x0026A5FA
		// (set) Token: 0x06010956 RID: 67926 RVA: 0x0026C402 File Offset: 0x0026A602
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

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x06010957 RID: 67927 RVA: 0x0026C40B File Offset: 0x0026A60B
		// (set) Token: 0x06010958 RID: 67928 RVA: 0x0026C413 File Offset: 0x0026A613
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

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x06010959 RID: 67929 RVA: 0x0026C41C File Offset: 0x0026A61C
		// (set) Token: 0x0601095A RID: 67930 RVA: 0x0026C424 File Offset: 0x0026A624
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

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0601095B RID: 67931 RVA: 0x0026C42D File Offset: 0x0026A62D
		// (set) Token: 0x0601095C RID: 67932 RVA: 0x0026C435 File Offset: 0x0026A635
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

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0601095D RID: 67933 RVA: 0x0026C43E File Offset: 0x0026A63E
		// (set) Token: 0x0601095E RID: 67934 RVA: 0x0026C446 File Offset: 0x0026A646
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

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0601095F RID: 67935 RVA: 0x0026C44F File Offset: 0x0026A64F
		// (set) Token: 0x06010960 RID: 67936 RVA: 0x0026C457 File Offset: 0x0026A657
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

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x06010961 RID: 67937 RVA: 0x0026C460 File Offset: 0x0026A660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Coupons
		{
			get
			{
				return this.coupons_;
			}
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x06010962 RID: 67938 RVA: 0x0026C468 File Offset: 0x0026A668
		// (set) Token: 0x06010963 RID: 67939 RVA: 0x0026C470 File Offset: 0x0026A670
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

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x06010964 RID: 67940 RVA: 0x0026C479 File Offset: 0x0026A679
		// (set) Token: 0x06010965 RID: 67941 RVA: 0x0026C481 File Offset: 0x0026A681
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

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x06010966 RID: 67942 RVA: 0x0026C494 File Offset: 0x0026A694
		// (set) Token: 0x06010967 RID: 67943 RVA: 0x0026C49C File Offset: 0x0026A69C
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

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x06010968 RID: 67944 RVA: 0x0026C4AF File Offset: 0x0026A6AF
		// (set) Token: 0x06010969 RID: 67945 RVA: 0x0026C4B7 File Offset: 0x0026A6B7
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

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0601096A RID: 67946 RVA: 0x0026C4C0 File Offset: 0x0026A6C0
		// (set) Token: 0x0601096B RID: 67947 RVA: 0x0026C4C8 File Offset: 0x0026A6C8
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

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0601096C RID: 67948 RVA: 0x0026C4D1 File Offset: 0x0026A6D1
		// (set) Token: 0x0601096D RID: 67949 RVA: 0x0026C4D9 File Offset: 0x0026A6D9
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

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0601096E RID: 67950 RVA: 0x0026C4E2 File Offset: 0x0026A6E2
		// (set) Token: 0x0601096F RID: 67951 RVA: 0x0026C4EA File Offset: 0x0026A6EA
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

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x06010970 RID: 67952 RVA: 0x0026C4F3 File Offset: 0x0026A6F3
		// (set) Token: 0x06010971 RID: 67953 RVA: 0x0026C4FB File Offset: 0x0026A6FB
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

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x06010972 RID: 67954 RVA: 0x0026C504 File Offset: 0x0026A704
		// (set) Token: 0x06010973 RID: 67955 RVA: 0x0026C50C File Offset: 0x0026A70C
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

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x06010974 RID: 67956 RVA: 0x0026C515 File Offset: 0x0026A715
		// (set) Token: 0x06010975 RID: 67957 RVA: 0x0026C51D File Offset: 0x0026A71D
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

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x06010976 RID: 67958 RVA: 0x0026C526 File Offset: 0x0026A726
		// (set) Token: 0x06010977 RID: 67959 RVA: 0x0026C52E File Offset: 0x0026A72E
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

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x06010978 RID: 67960 RVA: 0x0026C537 File Offset: 0x0026A737
		// (set) Token: 0x06010979 RID: 67961 RVA: 0x0026C53F File Offset: 0x0026A73F
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

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0601097A RID: 67962 RVA: 0x0026C552 File Offset: 0x0026A752
		// (set) Token: 0x0601097B RID: 67963 RVA: 0x0026C55A File Offset: 0x0026A75A
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

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0601097C RID: 67964 RVA: 0x0026C563 File Offset: 0x0026A763
		// (set) Token: 0x0601097D RID: 67965 RVA: 0x0026C56B File Offset: 0x0026A76B
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

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0601097E RID: 67966 RVA: 0x0026C574 File Offset: 0x0026A774
		// (set) Token: 0x0601097F RID: 67967 RVA: 0x0026C57C File Offset: 0x0026A77C
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

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x06010980 RID: 67968 RVA: 0x0026C585 File Offset: 0x0026A785
		// (set) Token: 0x06010981 RID: 67969 RVA: 0x0026C58D File Offset: 0x0026A78D
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

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x06010982 RID: 67970 RVA: 0x0026C596 File Offset: 0x0026A796
		// (set) Token: 0x06010983 RID: 67971 RVA: 0x0026C59E File Offset: 0x0026A79E
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

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x06010984 RID: 67972 RVA: 0x0026C5A7 File Offset: 0x0026A7A7
		// (set) Token: 0x06010985 RID: 67973 RVA: 0x0026C5AF File Offset: 0x0026A7AF
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

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x06010986 RID: 67974 RVA: 0x0026C5B8 File Offset: 0x0026A7B8
		// (set) Token: 0x06010987 RID: 67975 RVA: 0x0026C5C0 File Offset: 0x0026A7C0
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

		// Token: 0x06010988 RID: 67976 RVA: 0x0026C5C9 File Offset: 0x0026A7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopItem);
		}

		// Token: 0x06010989 RID: 67977 RVA: 0x0026C5D8 File Offset: 0x0026A7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && this.Locked == other.Locked && this.BuyLimit == other.BuyLimit && this.BoughtCount == other.BoughtCount && object.Equals(this.Price, other.Price) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.BeginPromotionTime == other.BeginPromotionTime && this.EndPromotionTime == other.EndPromotionTime && this.UpdateType == other.UpdateType && this.UpdateTime == other.UpdateTime && this.ShopItemType == other.ShopItemType && this.TagBeginTime == other.TagBeginTime && this.TagEndTime == other.TagEndTime && this.CanBuyGoods == other.CanBuyGoods && this.IsRemind == other.IsRemind && this.BuyLimitConditionId == other.BuyLimitConditionId && this.coupons_.Equals(other.coupons_) && this.LastUpdateTime == other.LastUpdateTime && !(this.StageImage != other.StageImage) && !(this.ShowStageImage != other.ShowStageImage) && this.TabId == other.TabId && this.ShopId == other.ShopId && this.Tag == other.Tag && this.Sort == other.Sort && this.PromotionShow == other.PromotionShow && this.SoldoutShowInShop == other.SoldoutShowInShop && this.ActivityId == other.ActivityId && this.Show == other.Show && !(this.ComplianceDetail != other.ComplianceDetail) && this.Quality == other.Quality && this.DiscountSort == other.DiscountSort && this.OnceBuyLimit == other.OnceBuyLimit && this.IsRecommend == other.IsRecommend && this.IsShowHaveNum == other.IsShowHaveNum && this.IsBuyMaxButton == other.IsBuyMaxButton && this.ConfirmLimitCount == other.ConfirmLimitCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601098A RID: 67978 RVA: 0x0026C88C File Offset: 0x0026AA8C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601098B RID: 67979 RVA: 0x0026CC87 File Offset: 0x0026AE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601098C RID: 67980 RVA: 0x0026CC94 File Offset: 0x0026AE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601098D RID: 67981 RVA: 0x0026CCA0 File Offset: 0x0026AEA0
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601098E RID: 67982 RVA: 0x0026D168 File Offset: 0x0026B368
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601098F RID: 67983 RVA: 0x0026D4E0 File Offset: 0x0026B6E0
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010990 RID: 67984 RVA: 0x0026D838 File Offset: 0x0026BA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010991 RID: 67985 RVA: 0x0026D844 File Offset: 0x0026BA44
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
				if (num <= 200U)
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
					else if (num <= 176U)
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
					}
					else
					{
						if (num == 184U)
						{
							this.IsRemind = input.ReadBool();
							continue;
						}
						if (num == 192U)
						{
							this.BuyLimitConditionId = input.ReadInt32();
							continue;
						}
						if (num == 200U)
						{
							goto IL_3B7;
						}
					}
				}
				else if (num <= 272U)
				{
					if (num <= 232U)
					{
						if (num <= 208U)
						{
							if (num == 202U)
							{
								goto IL_3B7;
							}
							if (num == 208U)
							{
								this.LastUpdateTime = input.ReadInt64();
								continue;
							}
						}
						else
						{
							if (num == 218U)
							{
								this.StageImage = input.ReadString();
								continue;
							}
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
						}
					}
					else if (num <= 248U)
					{
						if (num == 240U)
						{
							this.ShopId = input.ReadInt32();
							continue;
						}
						if (num == 248U)
						{
							this.Tag = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 256U)
						{
							this.Sort = input.ReadInt32();
							continue;
						}
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
					}
				}
				else if (num <= 312U)
				{
					if (num <= 288U)
					{
						if (num == 280U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
						if (num == 288U)
						{
							this.Show = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 298U)
						{
							this.ComplianceDetail = input.ReadString();
							continue;
						}
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
					}
				}
				else if (num <= 328U)
				{
					if (num == 320U)
					{
						this.OnceBuyLimit = input.ReadInt32();
						continue;
					}
					if (num == 328U)
					{
						this.IsRecommend = input.ReadBool();
						continue;
					}
				}
				else
				{
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
					if (num == 352U)
					{
						this.ConfirmLimitCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_3B7:
				this.coupons_.AddEntriesFrom(ref input, PayShopItem._repeated_coupons_codec);
			}
		}

		// Token: 0x04006930 RID: 26928
		private static readonly MessageParser<PayShopItem> _parser = new MessageParser<PayShopItem>(() => new PayShopItem());

		// Token: 0x04006931 RID: 26929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006932 RID: 26930
		public const int IdFieldNumber = 1;

		// Token: 0x04006933 RID: 26931
		private int id_;

		// Token: 0x04006934 RID: 26932
		public const int ItemIdFieldNumber = 3;

		// Token: 0x04006935 RID: 26933
		private int itemId_;

		// Token: 0x04006936 RID: 26934
		public const int ItemCountFieldNumber = 4;

		// Token: 0x04006937 RID: 26935
		private int itemCount_;

		// Token: 0x04006938 RID: 26936
		public const int LockedFieldNumber = 5;

		// Token: 0x04006939 RID: 26937
		private bool locked_;

		// Token: 0x0400693A RID: 26938
		public const int BuyLimitFieldNumber = 6;

		// Token: 0x0400693B RID: 26939
		private int buyLimit_;

		// Token: 0x0400693C RID: 26940
		public const int BoughtCountFieldNumber = 7;

		// Token: 0x0400693D RID: 26941
		private int boughtCount_;

		// Token: 0x0400693E RID: 26942
		public const int PriceFieldNumber = 8;

		// Token: 0x0400693F RID: 26943
		private PayShopPrice price_;

		// Token: 0x04006940 RID: 26944
		public const int BeginTimeFieldNumber = 9;

		// Token: 0x04006941 RID: 26945
		private long beginTime_;

		// Token: 0x04006942 RID: 26946
		public const int EndTimeFieldNumber = 10;

		// Token: 0x04006943 RID: 26947
		private long endTime_;

		// Token: 0x04006944 RID: 26948
		public const int BeginPromotionTimeFieldNumber = 11;

		// Token: 0x04006945 RID: 26949
		private long beginPromotionTime_;

		// Token: 0x04006946 RID: 26950
		public const int EndPromotionTimeFieldNumber = 12;

		// Token: 0x04006947 RID: 26951
		private long endPromotionTime_;

		// Token: 0x04006948 RID: 26952
		public const int UpdateTypeFieldNumber = 13;

		// Token: 0x04006949 RID: 26953
		private PayUpdateType updateType_;

		// Token: 0x0400694A RID: 26954
		public const int UpdateTimeFieldNumber = 14;

		// Token: 0x0400694B RID: 26955
		private long updateTime_;

		// Token: 0x0400694C RID: 26956
		public const int ShopItemTypeFieldNumber = 15;

		// Token: 0x0400694D RID: 26957
		private PayShopItemType shopItemType_;

		// Token: 0x0400694E RID: 26958
		public const int TagBeginTimeFieldNumber = 17;

		// Token: 0x0400694F RID: 26959
		private long tagBeginTime_;

		// Token: 0x04006950 RID: 26960
		public const int TagEndTimeFieldNumber = 18;

		// Token: 0x04006951 RID: 26961
		private long tagEndTime_;

		// Token: 0x04006952 RID: 26962
		public const int CanBuyGoodsFieldNumber = 22;

		// Token: 0x04006953 RID: 26963
		private bool canBuyGoods_;

		// Token: 0x04006954 RID: 26964
		public const int IsRemindFieldNumber = 23;

		// Token: 0x04006955 RID: 26965
		private bool isRemind_;

		// Token: 0x04006956 RID: 26966
		public const int BuyLimitConditionIdFieldNumber = 24;

		// Token: 0x04006957 RID: 26967
		private int buyLimitConditionId_;

		// Token: 0x04006958 RID: 26968
		public const int CouponsFieldNumber = 25;

		// Token: 0x04006959 RID: 26969
		private static readonly FieldCodec<int> _repeated_coupons_codec = FieldCodec.ForInt32(202U);

		// Token: 0x0400695A RID: 26970
		private readonly RepeatedField<int> coupons_ = new RepeatedField<int>();

		// Token: 0x0400695B RID: 26971
		public const int LastUpdateTimeFieldNumber = 26;

		// Token: 0x0400695C RID: 26972
		private long lastUpdateTime_;

		// Token: 0x0400695D RID: 26973
		public const int StageImageFieldNumber = 27;

		// Token: 0x0400695E RID: 26974
		private string stageImage_ = "";

		// Token: 0x0400695F RID: 26975
		public const int ShowStageImageFieldNumber = 28;

		// Token: 0x04006960 RID: 26976
		private string showStageImage_ = "";

		// Token: 0x04006961 RID: 26977
		public const int TabIdFieldNumber = 29;

		// Token: 0x04006962 RID: 26978
		private int tabId_;

		// Token: 0x04006963 RID: 26979
		public const int ShopIdFieldNumber = 30;

		// Token: 0x04006964 RID: 26980
		private int shopId_;

		// Token: 0x04006965 RID: 26981
		public const int TagFieldNumber = 31;

		// Token: 0x04006966 RID: 26982
		private int tag_;

		// Token: 0x04006967 RID: 26983
		public const int SortFieldNumber = 32;

		// Token: 0x04006968 RID: 26984
		private int sort_;

		// Token: 0x04006969 RID: 26985
		public const int PromotionShowFieldNumber = 33;

		// Token: 0x0400696A RID: 26986
		private int promotionShow_;

		// Token: 0x0400696B RID: 26987
		public const int SoldoutShowInShopFieldNumber = 34;

		// Token: 0x0400696C RID: 26988
		private bool soldoutShowInShop_;

		// Token: 0x0400696D RID: 26989
		public const int ActivityIdFieldNumber = 35;

		// Token: 0x0400696E RID: 26990
		private int activityId_;

		// Token: 0x0400696F RID: 26991
		public const int ShowFieldNumber = 36;

		// Token: 0x04006970 RID: 26992
		private bool show_;

		// Token: 0x04006971 RID: 26993
		public const int ComplianceDetailFieldNumber = 37;

		// Token: 0x04006972 RID: 26994
		private string complianceDetail_ = "";

		// Token: 0x04006973 RID: 26995
		public const int QualityFieldNumber = 38;

		// Token: 0x04006974 RID: 26996
		private int quality_;

		// Token: 0x04006975 RID: 26997
		public const int DiscountSortFieldNumber = 39;

		// Token: 0x04006976 RID: 26998
		private int discountSort_;

		// Token: 0x04006977 RID: 26999
		public const int OnceBuyLimitFieldNumber = 40;

		// Token: 0x04006978 RID: 27000
		private int onceBuyLimit_;

		// Token: 0x04006979 RID: 27001
		public const int IsRecommendFieldNumber = 41;

		// Token: 0x0400697A RID: 27002
		private bool isRecommend_;

		// Token: 0x0400697B RID: 27003
		public const int IsShowHaveNumFieldNumber = 42;

		// Token: 0x0400697C RID: 27004
		private bool isShowHaveNum_;

		// Token: 0x0400697D RID: 27005
		public const int IsBuyMaxButtonFieldNumber = 43;

		// Token: 0x0400697E RID: 27006
		private bool isBuyMaxButton_;

		// Token: 0x0400697F RID: 27007
		public const int ConfirmLimitCountFieldNumber = 44;

		// Token: 0x04006980 RID: 27008
		private int confirmLimitCount_;
	}
}
