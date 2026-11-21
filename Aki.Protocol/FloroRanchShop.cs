using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CE RID: 1486
	public sealed class FloroRanchShop : IMessage<FloroRanchShop>, IMessage, IEquatable<FloroRanchShop>, IDeepCloneable<FloroRanchShop>, IBufferMessage
	{
		// Token: 0x06008A03 RID: 35331 RVA: 0x0014E6D6 File Offset: 0x0014C8D6
		[NullableContext(1)]
		public static FloroRanchShop Create()
		{
			return new FloroRanchShop();
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06008A04 RID: 35332 RVA: 0x0014E6DD File Offset: 0x0014C8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06008A05 RID: 35333 RVA: 0x0014E6E0 File Offset: 0x0014C8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchShop.Descriptor;
			}
		}

		// Token: 0x06008A06 RID: 35334 RVA: 0x0014E6E7 File Offset: 0x0014C8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShop()
		{
		}

		// Token: 0x06008A07 RID: 35335 RVA: 0x0014E708 File Offset: 0x0014C908
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

		// Token: 0x06008A08 RID: 35336 RVA: 0x0014E77E File Offset: 0x0014C97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShop Clone()
		{
			return new FloroRanchShop(this);
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06008A09 RID: 35337 RVA: 0x0014E786 File Offset: 0x0014C986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchShopItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06008A0A RID: 35338 RVA: 0x0014E78E File Offset: 0x0014C98E
		// (set) Token: 0x06008A0B RID: 35339 RVA: 0x0014E796 File Offset: 0x0014C996
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

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06008A0C RID: 35340 RVA: 0x0014E79F File Offset: 0x0014C99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchRefreshCost> Cost
		{
			get
			{
				return this.cost_;
			}
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06008A0D RID: 35341 RVA: 0x0014E7A7 File Offset: 0x0014C9A7
		// (set) Token: 0x06008A0E RID: 35342 RVA: 0x0014E7AF File Offset: 0x0014C9AF
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

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06008A0F RID: 35343 RVA: 0x0014E7B8 File Offset: 0x0014C9B8
		// (set) Token: 0x06008A10 RID: 35344 RVA: 0x0014E7C0 File Offset: 0x0014C9C0
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

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06008A11 RID: 35345 RVA: 0x0014E7C9 File Offset: 0x0014C9C9
		// (set) Token: 0x06008A12 RID: 35346 RVA: 0x0014E7D1 File Offset: 0x0014C9D1
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

		// Token: 0x06008A13 RID: 35347 RVA: 0x0014E7DA File Offset: 0x0014C9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchShop);
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x0014E7E8 File Offset: 0x0014C9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchShop other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && this.AllowedRefresh == other.AllowedRefresh && this.cost_.Equals(other.cost_) && this.IncId == other.IncId && this.FreeTimes == other.FreeTimes && this.JustCard == other.JustCard && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A15 RID: 35349 RVA: 0x0014E87C File Offset: 0x0014CA7C
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

		// Token: 0x06008A16 RID: 35350 RVA: 0x0014E922 File Offset: 0x0014CB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x0014E92F File Offset: 0x0014CB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x0014E938 File Offset: 0x0014CB38
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

		// Token: 0x06008A19 RID: 35353 RVA: 0x0014E9EC File Offset: 0x0014CBEC
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

		// Token: 0x06008A1A RID: 35354 RVA: 0x0014EA80 File Offset: 0x0014CC80
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

		// Token: 0x06008A1B RID: 35355 RVA: 0x0014EB1A File Offset: 0x0014CD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A1C RID: 35356 RVA: 0x0014EB24 File Offset: 0x0014CD24
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

		// Token: 0x04004450 RID: 17488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004451 RID: 17489
		public const int ItemsFieldNumber = 1;

		// Token: 0x04004452 RID: 17490
		private static readonly FieldCodec<FloroRanchShopItem> _repeated_items_codec = FieldCodec.ForMessage<FloroRanchShopItem>(10U, FloroRanchShopItem.Parser);

		// Token: 0x04004453 RID: 17491
		private readonly RepeatedField<FloroRanchShopItem> items_ = new RepeatedField<FloroRanchShopItem>();

		// Token: 0x04004454 RID: 17492
		public const int AllowedRefreshFieldNumber = 2;

		// Token: 0x04004455 RID: 17493
		private bool allowedRefresh_;

		// Token: 0x04004456 RID: 17494
		public const int CostFieldNumber = 3;

		// Token: 0x04004457 RID: 17495
		private static readonly FieldCodec<FloroRanchRefreshCost> _repeated_cost_codec = FieldCodec.ForMessage<FloroRanchRefreshCost>(26U, FloroRanchRefreshCost.Parser);

		// Token: 0x04004458 RID: 17496
		private readonly RepeatedField<FloroRanchRefreshCost> cost_ = new RepeatedField<FloroRanchRefreshCost>();

		// Token: 0x04004459 RID: 17497
		public const int IncIdFieldNumber = 4;

		// Token: 0x0400445A RID: 17498
		private int incId_;

		// Token: 0x0400445B RID: 17499
		public const int FreeTimesFieldNumber = 5;

		// Token: 0x0400445C RID: 17500
		private int freeTimes_;

		// Token: 0x0400445D RID: 17501
		public const int JustCardFieldNumber = 6;

		// Token: 0x0400445E RID: 17502
		private bool justCard_;
	}
}
