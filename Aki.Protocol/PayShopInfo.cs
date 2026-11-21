using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDE RID: 3038
	public sealed class PayShopInfo : IMessage<PayShopInfo>, IMessage, IEquatable<PayShopInfo>, IDeepCloneable<PayShopInfo>, IBufferMessage
	{
		// Token: 0x060107C6 RID: 67526 RVA: 0x00268C3B File Offset: 0x00266E3B
		[NullableContext(1)]
		public static PayShopInfo Create()
		{
			return new PayShopInfo();
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x060107C7 RID: 67527 RVA: 0x00268C42 File Offset: 0x00266E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayShopInfo> Parser
		{
			get
			{
				return PayShopInfo._parser;
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x060107C8 RID: 67528 RVA: 0x00268C49 File Offset: 0x00266E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x060107C9 RID: 67529 RVA: 0x00268C4C File Offset: 0x00266E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopInfo.Descriptor;
			}
		}

		// Token: 0x060107CA RID: 67530 RVA: 0x00268C53 File Offset: 0x00266E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfo()
		{
		}

		// Token: 0x060107CB RID: 67531 RVA: 0x00268C7C File Offset: 0x00266E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfo(PayShopInfo other) : this()
		{
			this.id_ = other.id_;
			this.items_ = other.items_.Clone();
			this.updateTime_ = other.updateTime_;
			this.lastUpdateTime_ = other.lastUpdateTime_;
			this.shopTabViewType_ = other.shopTabViewType_;
			this.dynamicTabId_ = other.dynamicTabId_;
			this.sort_ = other.sort_;
			this.money_ = other.money_.Clone();
			this.sortRule_ = other.sortRule_;
			this.payShopTabTogContent_ = other.payShopTabTogContent_;
			this.enableServerRedDot_ = other.enableServerRedDot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060107CC RID: 67532 RVA: 0x00268D2E File Offset: 0x00266F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfo Clone()
		{
			return new PayShopInfo(this);
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x060107CD RID: 67533 RVA: 0x00268D36 File Offset: 0x00266F36
		// (set) Token: 0x060107CE RID: 67534 RVA: 0x00268D3E File Offset: 0x00266F3E
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

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x060107CF RID: 67535 RVA: 0x00268D47 File Offset: 0x00266F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x060107D0 RID: 67536 RVA: 0x00268D4F File Offset: 0x00266F4F
		// (set) Token: 0x060107D1 RID: 67537 RVA: 0x00268D57 File Offset: 0x00266F57
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

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x060107D2 RID: 67538 RVA: 0x00268D60 File Offset: 0x00266F60
		// (set) Token: 0x060107D3 RID: 67539 RVA: 0x00268D68 File Offset: 0x00266F68
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

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x060107D4 RID: 67540 RVA: 0x00268D71 File Offset: 0x00266F71
		// (set) Token: 0x060107D5 RID: 67541 RVA: 0x00268D79 File Offset: 0x00266F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopTabViewType
		{
			get
			{
				return this.shopTabViewType_;
			}
			set
			{
				this.shopTabViewType_ = value;
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x060107D6 RID: 67542 RVA: 0x00268D82 File Offset: 0x00266F82
		// (set) Token: 0x060107D7 RID: 67543 RVA: 0x00268D8A File Offset: 0x00266F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DynamicTabId
		{
			get
			{
				return this.dynamicTabId_;
			}
			set
			{
				this.dynamicTabId_ = value;
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x060107D8 RID: 67544 RVA: 0x00268D93 File Offset: 0x00266F93
		// (set) Token: 0x060107D9 RID: 67545 RVA: 0x00268D9B File Offset: 0x00266F9B
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

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x060107DA RID: 67546 RVA: 0x00268DA4 File Offset: 0x00266FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Money
		{
			get
			{
				return this.money_;
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x060107DB RID: 67547 RVA: 0x00268DAC File Offset: 0x00266FAC
		// (set) Token: 0x060107DC RID: 67548 RVA: 0x00268DB4 File Offset: 0x00266FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SortRule
		{
			get
			{
				return this.sortRule_;
			}
			set
			{
				this.sortRule_ = value;
			}
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x060107DD RID: 67549 RVA: 0x00268DBD File Offset: 0x00266FBD
		// (set) Token: 0x060107DE RID: 67550 RVA: 0x00268DC5 File Offset: 0x00266FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PayShopTabTogContent
		{
			get
			{
				return this.payShopTabTogContent_;
			}
			set
			{
				this.payShopTabTogContent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x060107DF RID: 67551 RVA: 0x00268DD8 File Offset: 0x00266FD8
		// (set) Token: 0x060107E0 RID: 67552 RVA: 0x00268DE0 File Offset: 0x00266FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableServerRedDot
		{
			get
			{
				return this.enableServerRedDot_;
			}
			set
			{
				this.enableServerRedDot_ = value;
			}
		}

		// Token: 0x060107E1 RID: 67553 RVA: 0x00268DE9 File Offset: 0x00266FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopInfo);
		}

		// Token: 0x060107E2 RID: 67554 RVA: 0x00268DF8 File Offset: 0x00266FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.items_.Equals(other.items_) && this.UpdateTime == other.UpdateTime && this.LastUpdateTime == other.LastUpdateTime && this.ShopTabViewType == other.ShopTabViewType && this.DynamicTabId == other.DynamicTabId && this.Sort == other.Sort && this.money_.Equals(other.money_) && this.SortRule == other.SortRule && !(this.PayShopTabTogContent != other.PayShopTabTogContent) && this.EnableServerRedDot == other.EnableServerRedDot && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060107E3 RID: 67555 RVA: 0x00268EE0 File Offset: 0x002670E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this.UpdateTime != 0L)
			{
				num ^= this.UpdateTime.GetHashCode();
			}
			if (this.LastUpdateTime != 0L)
			{
				num ^= this.LastUpdateTime.GetHashCode();
			}
			if (this.ShopTabViewType != 0)
			{
				num ^= this.ShopTabViewType.GetHashCode();
			}
			if (this.DynamicTabId != 0)
			{
				num ^= this.DynamicTabId.GetHashCode();
			}
			if (this.Sort != 0)
			{
				num ^= this.Sort.GetHashCode();
			}
			num ^= this.money_.GetHashCode();
			if (this.SortRule != 0)
			{
				num ^= this.SortRule.GetHashCode();
			}
			if (this.PayShopTabTogContent.Length != 0)
			{
				num ^= this.PayShopTabTogContent.GetHashCode();
			}
			if (this.EnableServerRedDot)
			{
				num ^= this.EnableServerRedDot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060107E4 RID: 67556 RVA: 0x00269005 File Offset: 0x00267205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060107E5 RID: 67557 RVA: 0x00269012 File Offset: 0x00267212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060107E6 RID: 67558 RVA: 0x0026901C File Offset: 0x0026721C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.items_.WriteTo(ref output, PayShopInfo._repeated_items_codec);
			if (this.UpdateTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UpdateTime);
			}
			if (this.LastUpdateTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.LastUpdateTime);
			}
			if (this.ShopTabViewType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ShopTabViewType);
			}
			if (this.DynamicTabId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DynamicTabId);
			}
			if (this.Sort != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Sort);
			}
			this.money_.WriteTo(ref output, PayShopInfo._repeated_money_codec);
			if (this.SortRule != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SortRule);
			}
			if (this.PayShopTabTogContent.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.PayShopTabTogContent);
			}
			if (this.EnableServerRedDot)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.EnableServerRedDot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060107E7 RID: 67559 RVA: 0x00269160 File Offset: 0x00267360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.items_.CalculateSize(PayShopInfo._repeated_items_codec);
			if (this.UpdateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpdateTime);
			}
			if (this.LastUpdateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastUpdateTime);
			}
			if (this.ShopTabViewType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopTabViewType);
			}
			if (this.DynamicTabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DynamicTabId);
			}
			if (this.Sort != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sort);
			}
			num += this.money_.CalculateSize(PayShopInfo._repeated_money_codec);
			if (this.SortRule != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SortRule);
			}
			if (this.PayShopTabTogContent.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PayShopTabTogContent);
			}
			if (this.EnableServerRedDot)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060107E8 RID: 67560 RVA: 0x00269280 File Offset: 0x00267480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.items_.Add(other.items_);
			if (other.UpdateTime != 0L)
			{
				this.UpdateTime = other.UpdateTime;
			}
			if (other.LastUpdateTime != 0L)
			{
				this.LastUpdateTime = other.LastUpdateTime;
			}
			if (other.ShopTabViewType != 0)
			{
				this.ShopTabViewType = other.ShopTabViewType;
			}
			if (other.DynamicTabId != 0)
			{
				this.DynamicTabId = other.DynamicTabId;
			}
			if (other.Sort != 0)
			{
				this.Sort = other.Sort;
			}
			this.money_.Add(other.money_);
			if (other.SortRule != 0)
			{
				this.SortRule = other.SortRule;
			}
			if (other.PayShopTabTogContent.Length != 0)
			{
				this.PayShopTabTogContent = other.PayShopTabTogContent;
			}
			if (other.EnableServerRedDot)
			{
				this.EnableServerRedDot = other.EnableServerRedDot;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060107E9 RID: 67561 RVA: 0x00269383 File Offset: 0x00267583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060107EA RID: 67562 RVA: 0x0026938C File Offset: 0x0026758C
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
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							this.items_.AddEntriesFrom(ref input, PayShopInfo._repeated_items_codec);
							continue;
						}
						if (num == 24U)
						{
							this.UpdateTime = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.LastUpdateTime = input.ReadInt64();
							continue;
						}
						if (num == 40U)
						{
							this.ShopTabViewType = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.DynamicTabId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 66U)
				{
					if (num == 56U)
					{
						this.Sort = input.ReadInt32();
						continue;
					}
					if (num == 64U || num == 66U)
					{
						this.money_.AddEntriesFrom(ref input, PayShopInfo._repeated_money_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.SortRule = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						this.PayShopTabTogContent = input.ReadString();
						continue;
					}
					if (num == 88U)
					{
						this.EnableServerRedDot = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006905 RID: 26885
		private static readonly MessageParser<PayShopInfo> _parser = new MessageParser<PayShopInfo>(() => new PayShopInfo());

		// Token: 0x04006906 RID: 26886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006907 RID: 26887
		public const int IdFieldNumber = 1;

		// Token: 0x04006908 RID: 26888
		private int id_;

		// Token: 0x04006909 RID: 26889
		public const int ItemsFieldNumber = 2;

		// Token: 0x0400690A RID: 26890
		private static readonly FieldCodec<PayShopItem> _repeated_items_codec = FieldCodec.ForMessage<PayShopItem>(18U, PayShopItem.Parser);

		// Token: 0x0400690B RID: 26891
		private readonly RepeatedField<PayShopItem> items_ = new RepeatedField<PayShopItem>();

		// Token: 0x0400690C RID: 26892
		public const int UpdateTimeFieldNumber = 3;

		// Token: 0x0400690D RID: 26893
		private long updateTime_;

		// Token: 0x0400690E RID: 26894
		public const int LastUpdateTimeFieldNumber = 4;

		// Token: 0x0400690F RID: 26895
		private long lastUpdateTime_;

		// Token: 0x04006910 RID: 26896
		public const int ShopTabViewTypeFieldNumber = 5;

		// Token: 0x04006911 RID: 26897
		private int shopTabViewType_;

		// Token: 0x04006912 RID: 26898
		public const int DynamicTabIdFieldNumber = 6;

		// Token: 0x04006913 RID: 26899
		private int dynamicTabId_;

		// Token: 0x04006914 RID: 26900
		public const int SortFieldNumber = 7;

		// Token: 0x04006915 RID: 26901
		private int sort_;

		// Token: 0x04006916 RID: 26902
		public const int MoneyFieldNumber = 8;

		// Token: 0x04006917 RID: 26903
		private static readonly FieldCodec<int> _repeated_money_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006918 RID: 26904
		private readonly RepeatedField<int> money_ = new RepeatedField<int>();

		// Token: 0x04006919 RID: 26905
		public const int SortRuleFieldNumber = 9;

		// Token: 0x0400691A RID: 26906
		private int sortRule_;

		// Token: 0x0400691B RID: 26907
		public const int PayShopTabTogContentFieldNumber = 10;

		// Token: 0x0400691C RID: 26908
		private string payShopTabTogContent_ = "";

		// Token: 0x0400691D RID: 26909
		public const int EnableServerRedDotFieldNumber = 11;

		// Token: 0x0400691E RID: 26910
		private bool enableServerRedDot_;
	}
}
