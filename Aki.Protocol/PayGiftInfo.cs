using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDB RID: 3035
	public sealed class PayGiftInfo : IMessage<PayGiftInfo>, IMessage, IEquatable<PayGiftInfo>, IDeepCloneable<PayGiftInfo>, IBufferMessage
	{
		// Token: 0x060106E3 RID: 67299 RVA: 0x00265095 File Offset: 0x00263295
		[NullableContext(1)]
		public static PayGiftInfo Create()
		{
			return new PayGiftInfo();
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x060106E4 RID: 67300 RVA: 0x0026509C File Offset: 0x0026329C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayGiftInfo> Parser
		{
			get
			{
				return PayGiftInfo._parser;
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x060106E5 RID: 67301 RVA: 0x002650A3 File Offset: 0x002632A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x060106E6 RID: 67302 RVA: 0x002650A6 File Offset: 0x002632A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftInfo.Descriptor;
			}
		}

		// Token: 0x060106E7 RID: 67303 RVA: 0x002650B0 File Offset: 0x002632B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfo()
		{
		}

		// Token: 0x060106E8 RID: 67304 RVA: 0x0026511C File Offset: 0x0026331C
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

		// Token: 0x060106E9 RID: 67305 RVA: 0x002652D1 File Offset: 0x002634D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfo Clone()
		{
			return new PayGiftInfo(this);
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x060106EA RID: 67306 RVA: 0x002652D9 File Offset: 0x002634D9
		// (set) Token: 0x060106EB RID: 67307 RVA: 0x002652E1 File Offset: 0x002634E1
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

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x060106EC RID: 67308 RVA: 0x002652EA File Offset: 0x002634EA
		// (set) Token: 0x060106ED RID: 67309 RVA: 0x002652F2 File Offset: 0x002634F2
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

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x060106EE RID: 67310 RVA: 0x002652FB File Offset: 0x002634FB
		// (set) Token: 0x060106EF RID: 67311 RVA: 0x00265303 File Offset: 0x00263503
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

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x060106F0 RID: 67312 RVA: 0x0026530C File Offset: 0x0026350C
		// (set) Token: 0x060106F1 RID: 67313 RVA: 0x00265314 File Offset: 0x00263514
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

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x060106F2 RID: 67314 RVA: 0x0026531D File Offset: 0x0026351D
		// (set) Token: 0x060106F3 RID: 67315 RVA: 0x00265325 File Offset: 0x00263525
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

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x060106F4 RID: 67316 RVA: 0x0026532E File Offset: 0x0026352E
		// (set) Token: 0x060106F5 RID: 67317 RVA: 0x00265336 File Offset: 0x00263536
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

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x060106F6 RID: 67318 RVA: 0x0026533F File Offset: 0x0026353F
		// (set) Token: 0x060106F7 RID: 67319 RVA: 0x00265347 File Offset: 0x00263547
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

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x060106F8 RID: 67320 RVA: 0x00265350 File Offset: 0x00263550
		// (set) Token: 0x060106F9 RID: 67321 RVA: 0x00265358 File Offset: 0x00263558
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

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x060106FA RID: 67322 RVA: 0x0026536B File Offset: 0x0026356B
		// (set) Token: 0x060106FB RID: 67323 RVA: 0x00265373 File Offset: 0x00263573
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

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x060106FC RID: 67324 RVA: 0x0026537C File Offset: 0x0026357C
		// (set) Token: 0x060106FD RID: 67325 RVA: 0x00265384 File Offset: 0x00263584
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

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x060106FE RID: 67326 RVA: 0x0026538D File Offset: 0x0026358D
		// (set) Token: 0x060106FF RID: 67327 RVA: 0x00265395 File Offset: 0x00263595
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

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x06010700 RID: 67328 RVA: 0x002653A8 File Offset: 0x002635A8
		// (set) Token: 0x06010701 RID: 67329 RVA: 0x002653B0 File Offset: 0x002635B0
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

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x06010702 RID: 67330 RVA: 0x002653C3 File Offset: 0x002635C3
		// (set) Token: 0x06010703 RID: 67331 RVA: 0x002653CB File Offset: 0x002635CB
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

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x06010704 RID: 67332 RVA: 0x002653D4 File Offset: 0x002635D4
		// (set) Token: 0x06010705 RID: 67333 RVA: 0x002653DC File Offset: 0x002635DC
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

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x06010706 RID: 67334 RVA: 0x002653E5 File Offset: 0x002635E5
		// (set) Token: 0x06010707 RID: 67335 RVA: 0x002653ED File Offset: 0x002635ED
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

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x06010708 RID: 67336 RVA: 0x002653F6 File Offset: 0x002635F6
		// (set) Token: 0x06010709 RID: 67337 RVA: 0x002653FE File Offset: 0x002635FE
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

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0601070A RID: 67338 RVA: 0x00265407 File Offset: 0x00263607
		// (set) Token: 0x0601070B RID: 67339 RVA: 0x0026540F File Offset: 0x0026360F
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

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0601070C RID: 67340 RVA: 0x00265418 File Offset: 0x00263618
		// (set) Token: 0x0601070D RID: 67341 RVA: 0x00265420 File Offset: 0x00263620
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

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0601070E RID: 67342 RVA: 0x00265429 File Offset: 0x00263629
		// (set) Token: 0x0601070F RID: 67343 RVA: 0x00265431 File Offset: 0x00263631
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

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x06010710 RID: 67344 RVA: 0x0026543A File Offset: 0x0026363A
		// (set) Token: 0x06010711 RID: 67345 RVA: 0x00265442 File Offset: 0x00263642
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

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x06010712 RID: 67346 RVA: 0x00265455 File Offset: 0x00263655
		// (set) Token: 0x06010713 RID: 67347 RVA: 0x0026545D File Offset: 0x0026365D
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

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x06010714 RID: 67348 RVA: 0x00265470 File Offset: 0x00263670
		// (set) Token: 0x06010715 RID: 67349 RVA: 0x00265478 File Offset: 0x00263678
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

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x06010716 RID: 67350 RVA: 0x00265481 File Offset: 0x00263681
		// (set) Token: 0x06010717 RID: 67351 RVA: 0x00265489 File Offset: 0x00263689
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

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x06010718 RID: 67352 RVA: 0x00265492 File Offset: 0x00263692
		// (set) Token: 0x06010719 RID: 67353 RVA: 0x0026549A File Offset: 0x0026369A
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

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0601071A RID: 67354 RVA: 0x002654A3 File Offset: 0x002636A3
		// (set) Token: 0x0601071B RID: 67355 RVA: 0x002654AB File Offset: 0x002636AB
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

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0601071C RID: 67356 RVA: 0x002654B4 File Offset: 0x002636B4
		// (set) Token: 0x0601071D RID: 67357 RVA: 0x002654BC File Offset: 0x002636BC
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

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0601071E RID: 67358 RVA: 0x002654C5 File Offset: 0x002636C5
		// (set) Token: 0x0601071F RID: 67359 RVA: 0x002654CD File Offset: 0x002636CD
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

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x06010720 RID: 67360 RVA: 0x002654E0 File Offset: 0x002636E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> CurrencyDiscountTags
		{
			get
			{
				return this.currencyDiscountTags_;
			}
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x06010721 RID: 67361 RVA: 0x002654E8 File Offset: 0x002636E8
		// (set) Token: 0x06010722 RID: 67362 RVA: 0x002654F0 File Offset: 0x002636F0
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

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x06010723 RID: 67363 RVA: 0x00265503 File Offset: 0x00263703
		// (set) Token: 0x06010724 RID: 67364 RVA: 0x0026550B File Offset: 0x0026370B
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

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x06010725 RID: 67365 RVA: 0x00265514 File Offset: 0x00263714
		// (set) Token: 0x06010726 RID: 67366 RVA: 0x0026551C File Offset: 0x0026371C
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

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x06010727 RID: 67367 RVA: 0x00265525 File Offset: 0x00263725
		// (set) Token: 0x06010728 RID: 67368 RVA: 0x0026552D File Offset: 0x0026372D
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

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x06010729 RID: 67369 RVA: 0x00265536 File Offset: 0x00263736
		// (set) Token: 0x0601072A RID: 67370 RVA: 0x0026553E File Offset: 0x0026373E
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

		// Token: 0x0601072B RID: 67371 RVA: 0x00265547 File Offset: 0x00263747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftInfo);
		}

		// Token: 0x0601072C RID: 67372 RVA: 0x00265558 File Offset: 0x00263758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PayId == other.PayId && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && this.Sort == other.Sort && this.BuyLimit == other.BuyLimit && this.BoughtCount == other.BoughtCount && !(this.StageImage != other.StageImage) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && !(this.ProductId != other.ProductId) && !(this.Amount != other.Amount) && this.TabId == other.TabId && this.Type == other.Type && this.Locked == other.Locked && this.IsCanBuy == other.IsCanBuy && this.IsRemind == other.IsRemind && this.BuyConditionId == other.BuyConditionId && this.CloudGameTime == other.CloudGameTime && !(this.CloudGameIcon != other.CloudGameIcon) && !(this.Desc != other.Desc) && this.UpdateType == other.UpdateType && this.UpdateTime == other.UpdateTime && this.LastUpdateTime == other.LastUpdateTime && this.Tag == other.Tag && this.PromotionShow == other.PromotionShow && !(this.ShowStageImage != other.ShowStageImage) && this.CurrencyDiscountTags.Equals(other.CurrencyDiscountTags) && !(this.ComplianceDetail != other.ComplianceDetail) && this.Quality == other.Quality && this.VersionId == other.VersionId && this.ShopId == other.ShopId && this.NeedConsoleRulePrompt == other.NeedConsoleRulePrompt && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601072D RID: 67373 RVA: 0x002657BC File Offset: 0x002639BC
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

		// Token: 0x0601072E RID: 67374 RVA: 0x00265B25 File Offset: 0x00263D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601072F RID: 67375 RVA: 0x00265B32 File Offset: 0x00263D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010730 RID: 67376 RVA: 0x00265B3C File Offset: 0x00263D3C
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

		// Token: 0x06010731 RID: 67377 RVA: 0x00265F54 File Offset: 0x00264154
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

		// Token: 0x06010732 RID: 67378 RVA: 0x00266280 File Offset: 0x00264480
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

		// Token: 0x06010733 RID: 67379 RVA: 0x0026655C File Offset: 0x0026475C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010734 RID: 67380 RVA: 0x00266568 File Offset: 0x00264768
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

		// Token: 0x04006827 RID: 26663
		private static readonly MessageParser<PayGiftInfo> _parser = new MessageParser<PayGiftInfo>(() => new PayGiftInfo());

		// Token: 0x04006828 RID: 26664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006829 RID: 26665
		public const int IdFieldNumber = 1;

		// Token: 0x0400682A RID: 26666
		private int id_;

		// Token: 0x0400682B RID: 26667
		public const int PayIdFieldNumber = 2;

		// Token: 0x0400682C RID: 26668
		private int payId_;

		// Token: 0x0400682D RID: 26669
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0400682E RID: 26670
		private int itemId_;

		// Token: 0x0400682F RID: 26671
		public const int ItemCountFieldNumber = 4;

		// Token: 0x04006830 RID: 26672
		private int itemCount_;

		// Token: 0x04006831 RID: 26673
		public const int SortFieldNumber = 5;

		// Token: 0x04006832 RID: 26674
		private int sort_;

		// Token: 0x04006833 RID: 26675
		public const int BuyLimitFieldNumber = 6;

		// Token: 0x04006834 RID: 26676
		private int buyLimit_;

		// Token: 0x04006835 RID: 26677
		public const int BoughtCountFieldNumber = 7;

		// Token: 0x04006836 RID: 26678
		private int boughtCount_;

		// Token: 0x04006837 RID: 26679
		public const int StageImageFieldNumber = 8;

		// Token: 0x04006838 RID: 26680
		private string stageImage_ = "";

		// Token: 0x04006839 RID: 26681
		public const int BeginTimeFieldNumber = 9;

		// Token: 0x0400683A RID: 26682
		private long beginTime_;

		// Token: 0x0400683B RID: 26683
		public const int EndTimeFieldNumber = 10;

		// Token: 0x0400683C RID: 26684
		private long endTime_;

		// Token: 0x0400683D RID: 26685
		public const int ProductIdFieldNumber = 11;

		// Token: 0x0400683E RID: 26686
		private string productId_ = "";

		// Token: 0x0400683F RID: 26687
		public const int AmountFieldNumber = 12;

		// Token: 0x04006840 RID: 26688
		private string amount_ = "";

		// Token: 0x04006841 RID: 26689
		public const int TabIdFieldNumber = 13;

		// Token: 0x04006842 RID: 26690
		private int tabId_;

		// Token: 0x04006843 RID: 26691
		public const int TypeFieldNumber = 14;

		// Token: 0x04006844 RID: 26692
		private int type_;

		// Token: 0x04006845 RID: 26693
		public const int LockedFieldNumber = 15;

		// Token: 0x04006846 RID: 26694
		private bool locked_;

		// Token: 0x04006847 RID: 26695
		public const int IsCanBuyFieldNumber = 16;

		// Token: 0x04006848 RID: 26696
		private bool isCanBuy_;

		// Token: 0x04006849 RID: 26697
		public const int IsRemindFieldNumber = 17;

		// Token: 0x0400684A RID: 26698
		private bool isRemind_;

		// Token: 0x0400684B RID: 26699
		public const int BuyConditionIdFieldNumber = 18;

		// Token: 0x0400684C RID: 26700
		private int buyConditionId_;

		// Token: 0x0400684D RID: 26701
		public const int CloudGameTimeFieldNumber = 19;

		// Token: 0x0400684E RID: 26702
		private int cloudGameTime_;

		// Token: 0x0400684F RID: 26703
		public const int CloudGameIconFieldNumber = 20;

		// Token: 0x04006850 RID: 26704
		private string cloudGameIcon_ = "";

		// Token: 0x04006851 RID: 26705
		public const int DescFieldNumber = 21;

		// Token: 0x04006852 RID: 26706
		private string desc_ = "";

		// Token: 0x04006853 RID: 26707
		public const int UpdateTypeFieldNumber = 22;

		// Token: 0x04006854 RID: 26708
		private PayUpdateType updateType_;

		// Token: 0x04006855 RID: 26709
		public const int UpdateTimeFieldNumber = 23;

		// Token: 0x04006856 RID: 26710
		private long updateTime_;

		// Token: 0x04006857 RID: 26711
		public const int LastUpdateTimeFieldNumber = 24;

		// Token: 0x04006858 RID: 26712
		private long lastUpdateTime_;

		// Token: 0x04006859 RID: 26713
		public const int TagFieldNumber = 25;

		// Token: 0x0400685A RID: 26714
		private int tag_;

		// Token: 0x0400685B RID: 26715
		public const int PromotionShowFieldNumber = 26;

		// Token: 0x0400685C RID: 26716
		private int promotionShow_;

		// Token: 0x0400685D RID: 26717
		public const int ShowStageImageFieldNumber = 27;

		// Token: 0x0400685E RID: 26718
		private string showStageImage_ = "";

		// Token: 0x0400685F RID: 26719
		public const int CurrencyDiscountTagsFieldNumber = 28;

		// Token: 0x04006860 RID: 26720
		private static readonly MapField<string, int>.Codec _map_currencyDiscountTags_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 226U);

		// Token: 0x04006861 RID: 26721
		private readonly MapField<string, int> currencyDiscountTags_ = new MapField<string, int>();

		// Token: 0x04006862 RID: 26722
		public const int ComplianceDetailFieldNumber = 29;

		// Token: 0x04006863 RID: 26723
		private string complianceDetail_ = "";

		// Token: 0x04006864 RID: 26724
		public const int QualityFieldNumber = 30;

		// Token: 0x04006865 RID: 26725
		private int quality_;

		// Token: 0x04006866 RID: 26726
		public const int VersionIdFieldNumber = 31;

		// Token: 0x04006867 RID: 26727
		private int versionId_;

		// Token: 0x04006868 RID: 26728
		public const int ShopIdFieldNumber = 32;

		// Token: 0x04006869 RID: 26729
		private int shopId_;

		// Token: 0x0400686A RID: 26730
		public const int NeedConsoleRulePromptFieldNumber = 33;

		// Token: 0x0400686B RID: 26731
		private bool needConsoleRulePrompt_;
	}
}
