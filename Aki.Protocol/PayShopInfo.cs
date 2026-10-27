using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEE RID: 3054
	public sealed class PayShopInfo : IMessage<PayShopInfo>, IMessage, IEquatable<PayShopInfo>, IDeepCloneable<PayShopInfo>, IBufferMessage
	{
		// Token: 0x060108CA RID: 67786 RVA: 0x0026AAFE File Offset: 0x00268CFE
		[NullableContext(1)]
		public static PayShopInfo Create()
		{
			return new PayShopInfo();
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x060108CB RID: 67787 RVA: 0x0026AB05 File Offset: 0x00268D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayShopInfo> Parser
		{
			get
			{
				return PayShopInfo._parser;
			}
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x060108CC RID: 67788 RVA: 0x0026AB0C File Offset: 0x00268D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x060108CD RID: 67789 RVA: 0x0026AB0F File Offset: 0x00268D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopInfo.Descriptor;
			}
		}

		// Token: 0x060108CE RID: 67790 RVA: 0x0026AB16 File Offset: 0x00268D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfo()
		{
		}

		// Token: 0x060108CF RID: 67791 RVA: 0x0026AB40 File Offset: 0x00268D40
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

		// Token: 0x060108D0 RID: 67792 RVA: 0x0026ABF2 File Offset: 0x00268DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfo Clone()
		{
			return new PayShopInfo(this);
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x060108D1 RID: 67793 RVA: 0x0026ABFA File Offset: 0x00268DFA
		// (set) Token: 0x060108D2 RID: 67794 RVA: 0x0026AC02 File Offset: 0x00268E02
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

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x060108D3 RID: 67795 RVA: 0x0026AC0B File Offset: 0x00268E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PayShopItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x060108D4 RID: 67796 RVA: 0x0026AC13 File Offset: 0x00268E13
		// (set) Token: 0x060108D5 RID: 67797 RVA: 0x0026AC1B File Offset: 0x00268E1B
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

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x060108D6 RID: 67798 RVA: 0x0026AC24 File Offset: 0x00268E24
		// (set) Token: 0x060108D7 RID: 67799 RVA: 0x0026AC2C File Offset: 0x00268E2C
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

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x060108D8 RID: 67800 RVA: 0x0026AC35 File Offset: 0x00268E35
		// (set) Token: 0x060108D9 RID: 67801 RVA: 0x0026AC3D File Offset: 0x00268E3D
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

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x060108DA RID: 67802 RVA: 0x0026AC46 File Offset: 0x00268E46
		// (set) Token: 0x060108DB RID: 67803 RVA: 0x0026AC4E File Offset: 0x00268E4E
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

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x060108DC RID: 67804 RVA: 0x0026AC57 File Offset: 0x00268E57
		// (set) Token: 0x060108DD RID: 67805 RVA: 0x0026AC5F File Offset: 0x00268E5F
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

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x060108DE RID: 67806 RVA: 0x0026AC68 File Offset: 0x00268E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Money
		{
			get
			{
				return this.money_;
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x060108DF RID: 67807 RVA: 0x0026AC70 File Offset: 0x00268E70
		// (set) Token: 0x060108E0 RID: 67808 RVA: 0x0026AC78 File Offset: 0x00268E78
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

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x060108E1 RID: 67809 RVA: 0x0026AC81 File Offset: 0x00268E81
		// (set) Token: 0x060108E2 RID: 67810 RVA: 0x0026AC89 File Offset: 0x00268E89
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

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x060108E3 RID: 67811 RVA: 0x0026AC9C File Offset: 0x00268E9C
		// (set) Token: 0x060108E4 RID: 67812 RVA: 0x0026ACA4 File Offset: 0x00268EA4
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

		// Token: 0x060108E5 RID: 67813 RVA: 0x0026ACAD File Offset: 0x00268EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopInfo);
		}

		// Token: 0x060108E6 RID: 67814 RVA: 0x0026ACBC File Offset: 0x00268EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.items_.Equals(other.items_) && this.UpdateTime == other.UpdateTime && this.LastUpdateTime == other.LastUpdateTime && this.ShopTabViewType == other.ShopTabViewType && this.DynamicTabId == other.DynamicTabId && this.Sort == other.Sort && this.money_.Equals(other.money_) && this.SortRule == other.SortRule && !(this.PayShopTabTogContent != other.PayShopTabTogContent) && this.EnableServerRedDot == other.EnableServerRedDot && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060108E7 RID: 67815 RVA: 0x0026ADA4 File Offset: 0x00268FA4
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

		// Token: 0x060108E8 RID: 67816 RVA: 0x0026AEC9 File Offset: 0x002690C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060108E9 RID: 67817 RVA: 0x0026AED6 File Offset: 0x002690D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060108EA RID: 67818 RVA: 0x0026AEE0 File Offset: 0x002690E0
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

		// Token: 0x060108EB RID: 67819 RVA: 0x0026B024 File Offset: 0x00269224
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

		// Token: 0x060108EC RID: 67820 RVA: 0x0026B144 File Offset: 0x00269344
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

		// Token: 0x060108ED RID: 67821 RVA: 0x0026B247 File Offset: 0x00269447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060108EE RID: 67822 RVA: 0x0026B250 File Offset: 0x00269450
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

		// Token: 0x040068F5 RID: 26869
		private static readonly MessageParser<PayShopInfo> _parser = new MessageParser<PayShopInfo>(() => new PayShopInfo());

		// Token: 0x040068F6 RID: 26870
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068F7 RID: 26871
		public const int IdFieldNumber = 1;

		// Token: 0x040068F8 RID: 26872
		private int id_;

		// Token: 0x040068F9 RID: 26873
		public const int ItemsFieldNumber = 2;

		// Token: 0x040068FA RID: 26874
		private static readonly FieldCodec<PayShopItem> _repeated_items_codec = FieldCodec.ForMessage<PayShopItem>(18U, PayShopItem.Parser);

		// Token: 0x040068FB RID: 26875
		private readonly RepeatedField<PayShopItem> items_ = new RepeatedField<PayShopItem>();

		// Token: 0x040068FC RID: 26876
		public const int UpdateTimeFieldNumber = 3;

		// Token: 0x040068FD RID: 26877
		private long updateTime_;

		// Token: 0x040068FE RID: 26878
		public const int LastUpdateTimeFieldNumber = 4;

		// Token: 0x040068FF RID: 26879
		private long lastUpdateTime_;

		// Token: 0x04006900 RID: 26880
		public const int ShopTabViewTypeFieldNumber = 5;

		// Token: 0x04006901 RID: 26881
		private int shopTabViewType_;

		// Token: 0x04006902 RID: 26882
		public const int DynamicTabIdFieldNumber = 6;

		// Token: 0x04006903 RID: 26883
		private int dynamicTabId_;

		// Token: 0x04006904 RID: 26884
		public const int SortFieldNumber = 7;

		// Token: 0x04006905 RID: 26885
		private int sort_;

		// Token: 0x04006906 RID: 26886
		public const int MoneyFieldNumber = 8;

		// Token: 0x04006907 RID: 26887
		private static readonly FieldCodec<int> _repeated_money_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006908 RID: 26888
		private readonly RepeatedField<int> money_ = new RepeatedField<int>();

		// Token: 0x04006909 RID: 26889
		public const int SortRuleFieldNumber = 9;

		// Token: 0x0400690A RID: 26890
		private int sortRule_;

		// Token: 0x0400690B RID: 26891
		public const int PayShopTabTogContentFieldNumber = 10;

		// Token: 0x0400690C RID: 26892
		private string payShopTabTogContent_ = "";

		// Token: 0x0400690D RID: 26893
		public const int EnableServerRedDotFieldNumber = 11;

		// Token: 0x0400690E RID: 26894
		private bool enableServerRedDot_;
	}
}
