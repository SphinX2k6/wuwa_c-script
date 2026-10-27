using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E3 RID: 1507
	public sealed class FloroRanchShop : IMessage<FloroRanchShop>, IMessage, IEquatable<FloroRanchShop>, IDeepCloneable<FloroRanchShop>, IBufferMessage
	{
		// Token: 0x06008B6B RID: 35691 RVA: 0x001512EB File Offset: 0x0014F4EB
		[NullableContext(1)]
		public static FloroRanchShop Create()
		{
			return new FloroRanchShop();
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06008B6C RID: 35692 RVA: 0x001512F2 File Offset: 0x0014F4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06008B6D RID: 35693 RVA: 0x001512F5 File Offset: 0x0014F4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchShop.Descriptor;
			}
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x001512FC File Offset: 0x0014F4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShop()
		{
		}

		// Token: 0x06008B6F RID: 35695 RVA: 0x0015131C File Offset: 0x0014F51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShop(FloroRanchShop other) : this()
		{
			this.items_ = other.items_.Clone();
			this.allowedRefresh_ = other.allowedRefresh_;
			this.cost_ = other.cost_.Clone();
			this.incId_ = other.incId_;
			this.freeTimes_ = other.freeTimes_;
			this.justCard_ = other.justCard_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B70 RID: 35696 RVA: 0x00151392 File Offset: 0x0014F592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShop Clone()
		{
			return new FloroRanchShop(this);
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06008B71 RID: 35697 RVA: 0x0015139A File Offset: 0x0014F59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchShopItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x001513A2 File Offset: 0x0014F5A2
		// (set) Token: 0x06008B73 RID: 35699 RVA: 0x001513AA File Offset: 0x0014F5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllowedRefresh
		{
			get
			{
				return this.allowedRefresh_;
			}
			set
			{
				this.allowedRefresh_ = value;
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06008B74 RID: 35700 RVA: 0x001513B3 File Offset: 0x0014F5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchRefreshCost> Cost
		{
			get
			{
				return this.cost_;
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06008B75 RID: 35701 RVA: 0x001513BB File Offset: 0x0014F5BB
		// (set) Token: 0x06008B76 RID: 35702 RVA: 0x001513C3 File Offset: 0x0014F5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x001513CC File Offset: 0x0014F5CC
		// (set) Token: 0x06008B78 RID: 35704 RVA: 0x001513D4 File Offset: 0x0014F5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FreeTimes
		{
			get
			{
				return this.freeTimes_;
			}
			set
			{
				this.freeTimes_ = value;
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06008B79 RID: 35705 RVA: 0x001513DD File Offset: 0x0014F5DD
		// (set) Token: 0x06008B7A RID: 35706 RVA: 0x001513E5 File Offset: 0x0014F5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JustCard
		{
			get
			{
				return this.justCard_;
			}
			set
			{
				this.justCard_ = value;
			}
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x001513EE File Offset: 0x0014F5EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchShop);
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x001513FC File Offset: 0x0014F5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchShop other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && this.AllowedRefresh == other.AllowedRefresh && this.cost_.Equals(other.cost_) && this.IncId == other.IncId && this.FreeTimes == other.FreeTimes && this.JustCard == other.JustCard && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x00151490 File Offset: 0x0014F690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.items_.GetHashCode();
			if (this.AllowedRefresh)
			{
				num ^= this.AllowedRefresh.GetHashCode();
			}
			num ^= this.cost_.GetHashCode();
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.FreeTimes != 0)
			{
				num ^= this.FreeTimes.GetHashCode();
			}
			if (this.JustCard)
			{
				num ^= this.JustCard.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B7E RID: 35710 RVA: 0x00151536 File Offset: 0x0014F736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B7F RID: 35711 RVA: 0x00151543 File Offset: 0x0014F743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x0015154C File Offset: 0x0014F74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, FloroRanchShop._repeated_items_codec);
			if (this.AllowedRefresh)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AllowedRefresh);
			}
			this.cost_.WriteTo(ref output, FloroRanchShop._repeated_cost_codec);
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.FreeTimes != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FreeTimes);
			}
			if (this.JustCard)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.JustCard);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x00151600 File Offset: 0x0014F800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(FloroRanchShop._repeated_items_codec);
			if (this.AllowedRefresh)
			{
				num += 2;
			}
			num += this.cost_.CalculateSize(FloroRanchShop._repeated_cost_codec);
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.FreeTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FreeTimes);
			}
			if (this.JustCard)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x00151694 File Offset: 0x0014F894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchShop other)
		{
			if (other == null)
			{
				return;
			}
			this.items_.Add(other.items_);
			if (other.AllowedRefresh)
			{
				this.AllowedRefresh = other.AllowedRefresh;
			}
			this.cost_.Add(other.cost_);
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.FreeTimes != 0)
			{
				this.FreeTimes = other.FreeTimes;
			}
			if (other.JustCard)
			{
				this.JustCard = other.JustCard;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x0015172E File Offset: 0x0014F92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x00151738 File Offset: 0x0014F938
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.items_.AddEntriesFrom(ref input, FloroRanchShop._repeated_items_codec);
						continue;
					}
					if (num == 16U)
					{
						this.AllowedRefresh = input.ReadBool();
						continue;
					}
					if (num == 26U)
					{
						this.cost_.AddEntriesFrom(ref input, FloroRanchShop._repeated_cost_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.FreeTimes = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.JustCard = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400445A RID: 17498
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400445B RID: 17499
		public const int ItemsFieldNumber = 1;

		// Token: 0x0400445C RID: 17500
		private static readonly FieldCodec<FloroRanchShopItem> _repeated_items_codec = FieldCodec.ForMessage<FloroRanchShopItem>(10U, FloroRanchShopItem.Parser);

		// Token: 0x0400445D RID: 17501
		private readonly RepeatedField<FloroRanchShopItem> items_ = new RepeatedField<FloroRanchShopItem>();

		// Token: 0x0400445E RID: 17502
		public const int AllowedRefreshFieldNumber = 2;

		// Token: 0x0400445F RID: 17503
		private bool allowedRefresh_;

		// Token: 0x04004460 RID: 17504
		public const int CostFieldNumber = 3;

		// Token: 0x04004461 RID: 17505
		private static readonly FieldCodec<FloroRanchRefreshCost> _repeated_cost_codec = FieldCodec.ForMessage<FloroRanchRefreshCost>(26U, FloroRanchRefreshCost.Parser);

		// Token: 0x04004462 RID: 17506
		private readonly RepeatedField<FloroRanchRefreshCost> cost_ = new RepeatedField<FloroRanchRefreshCost>();

		// Token: 0x04004463 RID: 17507
		public const int IncIdFieldNumber = 4;

		// Token: 0x04004464 RID: 17508
		private int incId_;

		// Token: 0x04004465 RID: 17509
		public const int FreeTimesFieldNumber = 5;

		// Token: 0x04004466 RID: 17510
		private int freeTimes_;

		// Token: 0x04004467 RID: 17511
		public const int JustCardFieldNumber = 6;

		// Token: 0x04004468 RID: 17512
		private bool justCard_;
	}
}
