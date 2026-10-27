using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000365 RID: 869
	[NetMessage(EMessageId.DangoBrawlRoundSwitchNotify)]
	public sealed class DangoBrawlRoundSwitchNotify : IMessage<DangoBrawlRoundSwitchNotify>, IMessage, IEquatable<DangoBrawlRoundSwitchNotify>, IDeepCloneable<DangoBrawlRoundSwitchNotify>, IBufferMessage
	{
		// Token: 0x0600569C RID: 22172 RVA: 0x000D385C File Offset: 0x000D1A5C
		[NullableContext(1)]
		public static DangoBrawlRoundSwitchNotify Create()
		{
			return new DangoBrawlRoundSwitchNotify();
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x0600569D RID: 22173 RVA: 0x000D3863 File Offset: 0x000D1A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x0600569E RID: 22174 RVA: 0x000D3866 File Offset: 0x000D1A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlRoundSwitchNotify.Descriptor;
			}
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x000D386D File Offset: 0x000D1A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoundSwitchNotify()
		{
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x000D3898 File Offset: 0x000D1A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoundSwitchNotify(DangoBrawlRoundSwitchNotify other) : this()
		{
			this.roundNum_ = other.roundNum_;
			this.opponentId_ = other.opponentId_;
			this.loseCount_ = other.loseCount_;
			this.winCount_ = other.winCount_;
			this.coin_ = other.coin_;
			this.activeEventIds_ = other.activeEventIds_.Clone();
			this.event_ = ((other.event_ != null) ? other.event_.Clone() : null);
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			this.fighters_ = other.fighters_.Clone();
			this.opponentBagItems_ = other.opponentBagItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x000D3963 File Offset: 0x000D1B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoundSwitchNotify Clone()
		{
			return new DangoBrawlRoundSwitchNotify(this);
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060056A2 RID: 22178 RVA: 0x000D396B File Offset: 0x000D1B6B
		// (set) Token: 0x060056A3 RID: 22179 RVA: 0x000D3973 File Offset: 0x000D1B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundNum
		{
			get
			{
				return this.roundNum_;
			}
			set
			{
				this.roundNum_ = value;
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060056A4 RID: 22180 RVA: 0x000D397C File Offset: 0x000D1B7C
		// (set) Token: 0x060056A5 RID: 22181 RVA: 0x000D3984 File Offset: 0x000D1B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OpponentId
		{
			get
			{
				return this.opponentId_;
			}
			set
			{
				this.opponentId_ = value;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x060056A6 RID: 22182 RVA: 0x000D398D File Offset: 0x000D1B8D
		// (set) Token: 0x060056A7 RID: 22183 RVA: 0x000D3995 File Offset: 0x000D1B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoseCount
		{
			get
			{
				return this.loseCount_;
			}
			set
			{
				this.loseCount_ = value;
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060056A8 RID: 22184 RVA: 0x000D399E File Offset: 0x000D1B9E
		// (set) Token: 0x060056A9 RID: 22185 RVA: 0x000D39A6 File Offset: 0x000D1BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WinCount
		{
			get
			{
				return this.winCount_;
			}
			set
			{
				this.winCount_ = value;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060056AA RID: 22186 RVA: 0x000D39AF File Offset: 0x000D1BAF
		// (set) Token: 0x060056AB RID: 22187 RVA: 0x000D39B7 File Offset: 0x000D1BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Coin
		{
			get
			{
				return this.coin_;
			}
			set
			{
				this.coin_ = value;
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060056AC RID: 22188 RVA: 0x000D39C0 File Offset: 0x000D1BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveEventIds
		{
			get
			{
				return this.activeEventIds_;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060056AD RID: 22189 RVA: 0x000D39C8 File Offset: 0x000D1BC8
		// (set) Token: 0x060056AE RID: 22190 RVA: 0x000D39D0 File Offset: 0x000D1BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventInfo Event
		{
			get
			{
				return this.event_;
			}
			set
			{
				this.event_ = value;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060056AF RID: 22191 RVA: 0x000D39D9 File Offset: 0x000D1BD9
		// (set) Token: 0x060056B0 RID: 22192 RVA: 0x000D39E1 File Offset: 0x000D1BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo Shop
		{
			get
			{
				return this.shop_;
			}
			set
			{
				this.shop_ = value;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060056B1 RID: 22193 RVA: 0x000D39EA File Offset: 0x000D1BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlFighterInfo> Fighters
		{
			get
			{
				return this.fighters_;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060056B2 RID: 22194 RVA: 0x000D39F2 File Offset: 0x000D1BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlNormalBagItemInfo> OpponentBagItems
		{
			get
			{
				return this.opponentBagItems_;
			}
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x000D39FA File Offset: 0x000D1BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlRoundSwitchNotify);
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x000D3A08 File Offset: 0x000D1C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlRoundSwitchNotify other)
		{
			return other != null && (other == this || (this.RoundNum == other.RoundNum && this.OpponentId == other.OpponentId && this.LoseCount == other.LoseCount && this.WinCount == other.WinCount && this.Coin == other.Coin && this.activeEventIds_.Equals(other.activeEventIds_) && object.Equals(this.Event, other.Event) && object.Equals(this.Shop, other.Shop) && this.fighters_.Equals(other.fighters_) && this.opponentBagItems_.Equals(other.opponentBagItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x000D3AEC File Offset: 0x000D1CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundNum != 0)
			{
				num ^= this.RoundNum.GetHashCode();
			}
			if (this.OpponentId != 0)
			{
				num ^= this.OpponentId.GetHashCode();
			}
			if (this.LoseCount != 0)
			{
				num ^= this.LoseCount.GetHashCode();
			}
			if (this.WinCount != 0)
			{
				num ^= this.WinCount.GetHashCode();
			}
			if (this.Coin != 0)
			{
				num ^= this.Coin.GetHashCode();
			}
			num ^= this.activeEventIds_.GetHashCode();
			if (this.event_ != null)
			{
				num ^= this.Event.GetHashCode();
			}
			if (this.shop_ != null)
			{
				num ^= this.Shop.GetHashCode();
			}
			num ^= this.fighters_.GetHashCode();
			num ^= this.opponentBagItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x000D3BE5 File Offset: 0x000D1DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x000D3BF2 File Offset: 0x000D1DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x000D3BFC File Offset: 0x000D1DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.opponentBagItems_.WriteTo(ref output, DangoBrawlRoundSwitchNotify._repeated_opponentBagItems_codec);
			if (this.WinCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WinCount);
			}
			if (this.shop_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Shop);
			}
			this.activeEventIds_.WriteTo(ref output, DangoBrawlRoundSwitchNotify._repeated_activeEventIds_codec);
			this.fighters_.WriteTo(ref output, DangoBrawlRoundSwitchNotify._repeated_fighters_codec);
			if (this.event_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Event);
			}
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LoseCount);
			}
			if (this.OpponentId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.OpponentId);
			}
			if (this.Coin != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Coin);
			}
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoundNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x000D3D14 File Offset: 0x000D1F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundNum);
			}
			if (this.OpponentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OpponentId);
			}
			if (this.LoseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoseCount);
			}
			if (this.WinCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WinCount);
			}
			if (this.Coin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Coin);
			}
			num += this.activeEventIds_.CalculateSize(DangoBrawlRoundSwitchNotify._repeated_activeEventIds_codec);
			if (this.event_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Event);
			}
			if (this.shop_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Shop);
			}
			num += this.fighters_.CalculateSize(DangoBrawlRoundSwitchNotify._repeated_fighters_codec);
			num += this.opponentBagItems_.CalculateSize(DangoBrawlRoundSwitchNotify._repeated_opponentBagItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x000D3E1C File Offset: 0x000D201C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlRoundSwitchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundNum != 0)
			{
				this.RoundNum = other.RoundNum;
			}
			if (other.OpponentId != 0)
			{
				this.OpponentId = other.OpponentId;
			}
			if (other.LoseCount != 0)
			{
				this.LoseCount = other.LoseCount;
			}
			if (other.WinCount != 0)
			{
				this.WinCount = other.WinCount;
			}
			if (other.Coin != 0)
			{
				this.Coin = other.Coin;
			}
			this.activeEventIds_.Add(other.activeEventIds_);
			if (other.event_ != null)
			{
				if (this.event_ == null)
				{
					this.Event = new DangoBrawlEventInfo();
				}
				this.Event.MergeFrom(other.Event);
			}
			if (other.shop_ != null)
			{
				if (this.shop_ == null)
				{
					this.Shop = new DangoBrawlShopInfo();
				}
				this.Shop.MergeFrom(other.Shop);
			}
			this.fighters_.Add(other.fighters_);
			this.opponentBagItems_.Add(other.opponentBagItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x000D3F33 File Offset: 0x000D2133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x000D3F3C File Offset: 0x000D213C
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
				if (num <= 58U)
				{
					if (num <= 40U)
					{
						if (num == 10U)
						{
							this.opponentBagItems_.AddEntriesFrom(ref input, DangoBrawlRoundSwitchNotify._repeated_opponentBagItems_codec);
							continue;
						}
						if (num == 40U)
						{
							this.WinCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.shop_ == null)
							{
								this.Shop = new DangoBrawlShopInfo();
							}
							input.ReadMessage(this.Shop);
							continue;
						}
						if (num == 56U || num == 58U)
						{
							this.activeEventIds_.AddEntriesFrom(ref input, DangoBrawlRoundSwitchNotify._repeated_activeEventIds_codec);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 74U)
					{
						this.fighters_.AddEntriesFrom(ref input, DangoBrawlRoundSwitchNotify._repeated_fighters_codec);
						continue;
					}
					if (num == 82U)
					{
						if (this.event_ == null)
						{
							this.Event = new DangoBrawlEventInfo();
						}
						input.ReadMessage(this.Event);
						continue;
					}
					if (num == 88U)
					{
						this.LoseCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.OpponentId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Coin = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.RoundNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003488 RID: 13448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003489 RID: 13449
		public const int RoundNumFieldNumber = 14;

		// Token: 0x0400348A RID: 13450
		private int roundNum_;

		// Token: 0x0400348B RID: 13451
		public const int OpponentIdFieldNumber = 12;

		// Token: 0x0400348C RID: 13452
		private int opponentId_;

		// Token: 0x0400348D RID: 13453
		public const int LoseCountFieldNumber = 11;

		// Token: 0x0400348E RID: 13454
		private int loseCount_;

		// Token: 0x0400348F RID: 13455
		public const int WinCountFieldNumber = 5;

		// Token: 0x04003490 RID: 13456
		private int winCount_;

		// Token: 0x04003491 RID: 13457
		public const int CoinFieldNumber = 13;

		// Token: 0x04003492 RID: 13458
		private int coin_;

		// Token: 0x04003493 RID: 13459
		public const int ActiveEventIdsFieldNumber = 7;

		// Token: 0x04003494 RID: 13460
		private static readonly FieldCodec<int> _repeated_activeEventIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04003495 RID: 13461
		private readonly RepeatedField<int> activeEventIds_ = new RepeatedField<int>();

		// Token: 0x04003496 RID: 13462
		public const int EventFieldNumber = 10;

		// Token: 0x04003497 RID: 13463
		private DangoBrawlEventInfo event_;

		// Token: 0x04003498 RID: 13464
		public const int ShopFieldNumber = 6;

		// Token: 0x04003499 RID: 13465
		private DangoBrawlShopInfo shop_;

		// Token: 0x0400349A RID: 13466
		public const int FightersFieldNumber = 9;

		// Token: 0x0400349B RID: 13467
		private static readonly FieldCodec<DangoBrawlFighterInfo> _repeated_fighters_codec = FieldCodec.ForMessage<DangoBrawlFighterInfo>(74U, DangoBrawlFighterInfo.Parser);

		// Token: 0x0400349C RID: 13468
		private readonly RepeatedField<DangoBrawlFighterInfo> fighters_ = new RepeatedField<DangoBrawlFighterInfo>();

		// Token: 0x0400349D RID: 13469
		public const int OpponentBagItemsFieldNumber = 1;

		// Token: 0x0400349E RID: 13470
		private static readonly FieldCodec<DangoBrawlNormalBagItemInfo> _repeated_opponentBagItems_codec = FieldCodec.ForMessage<DangoBrawlNormalBagItemInfo>(10U, DangoBrawlNormalBagItemInfo.Parser);

		// Token: 0x0400349F RID: 13471
		private readonly RepeatedField<DangoBrawlNormalBagItemInfo> opponentBagItems_ = new RepeatedField<DangoBrawlNormalBagItemInfo>();
	}
}
