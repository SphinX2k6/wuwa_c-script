using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036D RID: 877
	[NetMessage(EMessageId.DangoBrawlRoundSwitchNotify)]
	public sealed class DangoBrawlRoundSwitchNotify : IMessage<DangoBrawlRoundSwitchNotify>, IMessage, IEquatable<DangoBrawlRoundSwitchNotify>, IDeepCloneable<DangoBrawlRoundSwitchNotify>, IBufferMessage
	{
		// Token: 0x06005789 RID: 22409 RVA: 0x000D5EE5 File Offset: 0x000D40E5
		[NullableContext(1)]
		public static DangoBrawlRoundSwitchNotify Create()
		{
			return new DangoBrawlRoundSwitchNotify();
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x0600578A RID: 22410 RVA: 0x000D5EEC File Offset: 0x000D40EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x0600578B RID: 22411 RVA: 0x000D5EEF File Offset: 0x000D40EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlRoundSwitchNotify.Descriptor;
			}
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x000D5EF6 File Offset: 0x000D40F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoundSwitchNotify()
		{
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x000D5F20 File Offset: 0x000D4120
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

		// Token: 0x0600578E RID: 22414 RVA: 0x000D5FEB File Offset: 0x000D41EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlRoundSwitchNotify Clone()
		{
			return new DangoBrawlRoundSwitchNotify(this);
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600578F RID: 22415 RVA: 0x000D5FF3 File Offset: 0x000D41F3
		// (set) Token: 0x06005790 RID: 22416 RVA: 0x000D5FFB File Offset: 0x000D41FB
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

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06005791 RID: 22417 RVA: 0x000D6004 File Offset: 0x000D4204
		// (set) Token: 0x06005792 RID: 22418 RVA: 0x000D600C File Offset: 0x000D420C
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

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06005793 RID: 22419 RVA: 0x000D6015 File Offset: 0x000D4215
		// (set) Token: 0x06005794 RID: 22420 RVA: 0x000D601D File Offset: 0x000D421D
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

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06005795 RID: 22421 RVA: 0x000D6026 File Offset: 0x000D4226
		// (set) Token: 0x06005796 RID: 22422 RVA: 0x000D602E File Offset: 0x000D422E
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

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06005797 RID: 22423 RVA: 0x000D6037 File Offset: 0x000D4237
		// (set) Token: 0x06005798 RID: 22424 RVA: 0x000D603F File Offset: 0x000D423F
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

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06005799 RID: 22425 RVA: 0x000D6048 File Offset: 0x000D4248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveEventIds
		{
			get
			{
				return this.activeEventIds_;
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x0600579A RID: 22426 RVA: 0x000D6050 File Offset: 0x000D4250
		// (set) Token: 0x0600579B RID: 22427 RVA: 0x000D6058 File Offset: 0x000D4258
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

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x000D6061 File Offset: 0x000D4261
		// (set) Token: 0x0600579D RID: 22429 RVA: 0x000D6069 File Offset: 0x000D4269
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

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x0600579E RID: 22430 RVA: 0x000D6072 File Offset: 0x000D4272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlFighterInfo> Fighters
		{
			get
			{
				return this.fighters_;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x000D607A File Offset: 0x000D427A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlNormalBagItemInfo> OpponentBagItems
		{
			get
			{
				return this.opponentBagItems_;
			}
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x000D6082 File Offset: 0x000D4282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlRoundSwitchNotify);
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x000D6090 File Offset: 0x000D4290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlRoundSwitchNotify other)
		{
			return other != null && (other == this || (this.RoundNum == other.RoundNum && this.OpponentId == other.OpponentId && this.LoseCount == other.LoseCount && this.WinCount == other.WinCount && this.Coin == other.Coin && this.activeEventIds_.Equals(other.activeEventIds_) && object.Equals(this.Event, other.Event) && object.Equals(this.Shop, other.Shop) && this.fighters_.Equals(other.fighters_) && this.opponentBagItems_.Equals(other.opponentBagItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x000D6174 File Offset: 0x000D4374
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

		// Token: 0x060057A3 RID: 22435 RVA: 0x000D626D File Offset: 0x000D446D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x000D627A File Offset: 0x000D447A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x000D6284 File Offset: 0x000D4484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.event_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Event);
			}
			if (this.WinCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WinCount);
			}
			this.fighters_.WriteTo(ref output, DangoBrawlRoundSwitchNotify._repeated_fighters_codec);
			if (this.Coin != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Coin);
			}
			this.opponentBagItems_.WriteTo(ref output, DangoBrawlRoundSwitchNotify._repeated_opponentBagItems_codec);
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoundNum);
			}
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LoseCount);
			}
			this.activeEventIds_.WriteTo(ref output, DangoBrawlRoundSwitchNotify._repeated_activeEventIds_codec);
			if (this.shop_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Shop);
			}
			if (this.OpponentId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.OpponentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x000D639C File Offset: 0x000D459C
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

		// Token: 0x060057A7 RID: 22439 RVA: 0x000D64A4 File Offset: 0x000D46A4
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

		// Token: 0x060057A8 RID: 22440 RVA: 0x000D65BB File Offset: 0x000D47BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x000D65C4 File Offset: 0x000D47C4
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
				if (num > 58U)
				{
					if (num <= 88U)
					{
						if (num == 64U)
						{
							this.RoundNum = input.ReadInt32();
							continue;
						}
						if (num == 80U)
						{
							this.LoseCount = input.ReadInt32();
							continue;
						}
						if (num != 88U)
						{
							goto IL_76;
						}
					}
					else if (num != 90U)
					{
						if (num == 106U)
						{
							if (this.shop_ == null)
							{
								this.Shop = new DangoBrawlShopInfo();
							}
							input.ReadMessage(this.Shop);
							continue;
						}
						if (num != 120U)
						{
							goto IL_76;
						}
						this.OpponentId = input.ReadInt32();
						continue;
					}
					this.activeEventIds_.AddEntriesFrom(ref input, DangoBrawlRoundSwitchNotify._repeated_activeEventIds_codec);
					continue;
				}
				if (num <= 16U)
				{
					if (num == 10U)
					{
						if (this.event_ == null)
						{
							this.Event = new DangoBrawlEventInfo();
						}
						input.ReadMessage(this.Event);
						continue;
					}
					if (num == 16U)
					{
						this.WinCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.fighters_.AddEntriesFrom(ref input, DangoBrawlRoundSwitchNotify._repeated_fighters_codec);
						continue;
					}
					if (num == 48U)
					{
						this.Coin = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						this.opponentBagItems_.AddEntriesFrom(ref input, DangoBrawlRoundSwitchNotify._repeated_opponentBagItems_codec);
						continue;
					}
				}
				IL_76:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003524 RID: 13604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003525 RID: 13605
		public const int RoundNumFieldNumber = 8;

		// Token: 0x04003526 RID: 13606
		private int roundNum_;

		// Token: 0x04003527 RID: 13607
		public const int OpponentIdFieldNumber = 15;

		// Token: 0x04003528 RID: 13608
		private int opponentId_;

		// Token: 0x04003529 RID: 13609
		public const int LoseCountFieldNumber = 10;

		// Token: 0x0400352A RID: 13610
		private int loseCount_;

		// Token: 0x0400352B RID: 13611
		public const int WinCountFieldNumber = 2;

		// Token: 0x0400352C RID: 13612
		private int winCount_;

		// Token: 0x0400352D RID: 13613
		public const int CoinFieldNumber = 6;

		// Token: 0x0400352E RID: 13614
		private int coin_;

		// Token: 0x0400352F RID: 13615
		public const int ActiveEventIdsFieldNumber = 11;

		// Token: 0x04003530 RID: 13616
		private static readonly FieldCodec<int> _repeated_activeEventIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04003531 RID: 13617
		private readonly RepeatedField<int> activeEventIds_ = new RepeatedField<int>();

		// Token: 0x04003532 RID: 13618
		public const int EventFieldNumber = 1;

		// Token: 0x04003533 RID: 13619
		private DangoBrawlEventInfo event_;

		// Token: 0x04003534 RID: 13620
		public const int ShopFieldNumber = 13;

		// Token: 0x04003535 RID: 13621
		private DangoBrawlShopInfo shop_;

		// Token: 0x04003536 RID: 13622
		public const int FightersFieldNumber = 3;

		// Token: 0x04003537 RID: 13623
		private static readonly FieldCodec<DangoBrawlFighterInfo> _repeated_fighters_codec = FieldCodec.ForMessage<DangoBrawlFighterInfo>(26U, DangoBrawlFighterInfo.Parser);

		// Token: 0x04003538 RID: 13624
		private readonly RepeatedField<DangoBrawlFighterInfo> fighters_ = new RepeatedField<DangoBrawlFighterInfo>();

		// Token: 0x04003539 RID: 13625
		public const int OpponentBagItemsFieldNumber = 7;

		// Token: 0x0400353A RID: 13626
		private static readonly FieldCodec<DangoBrawlNormalBagItemInfo> _repeated_opponentBagItems_codec = FieldCodec.ForMessage<DangoBrawlNormalBagItemInfo>(58U, DangoBrawlNormalBagItemInfo.Parser);

		// Token: 0x0400353B RID: 13627
		private readonly RepeatedField<DangoBrawlNormalBagItemInfo> opponentBagItems_ = new RepeatedField<DangoBrawlNormalBagItemInfo>();
	}
}
