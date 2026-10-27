using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035B RID: 859
	[NetMessage(EMessageId.DangoBrawlInstBaseNotify)]
	public sealed class DangoBrawlInstBaseNotify : IMessage<DangoBrawlInstBaseNotify>, IMessage, IEquatable<DangoBrawlInstBaseNotify>, IDeepCloneable<DangoBrawlInstBaseNotify>, IBufferMessage
	{
		// Token: 0x060055C4 RID: 21956 RVA: 0x000D1881 File Offset: 0x000CFA81
		[NullableContext(1)]
		public static DangoBrawlInstBaseNotify Create()
		{
			return new DangoBrawlInstBaseNotify();
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x060055C5 RID: 21957 RVA: 0x000D1888 File Offset: 0x000CFA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x000D188B File Offset: 0x000CFA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlInstBaseNotify.Descriptor;
			}
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x000D1892 File Offset: 0x000CFA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstBaseNotify()
		{
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x000D18BC File Offset: 0x000CFABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstBaseNotify(DangoBrawlInstBaseNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.roleId_ = other.roleId_;
			this.roundNum_ = other.roundNum_;
			this.opponentId_ = other.opponentId_;
			this.loseCount_ = other.loseCount_;
			this.winCount_ = other.winCount_;
			this.coin_ = other.coin_;
			this.activeEventIds_ = other.activeEventIds_.Clone();
			this.bag_ = ((other.bag_ != null) ? other.bag_.Clone() : null);
			this.phase_ = other.phase_;
			this.event_ = ((other.event_ != null) ? other.event_.Clone() : null);
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			this.fighters_ = other.fighters_.Clone();
			this.opponentBagItems_ = other.opponentBagItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x000D19C7 File Offset: 0x000CFBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstBaseNotify Clone()
		{
			return new DangoBrawlInstBaseNotify(this);
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x000D19CF File Offset: 0x000CFBCF
		// (set) Token: 0x060055CB RID: 21963 RVA: 0x000D19D7 File Offset: 0x000CFBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x000D19E0 File Offset: 0x000CFBE0
		// (set) Token: 0x060055CD RID: 21965 RVA: 0x000D19E8 File Offset: 0x000CFBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x000D19F1 File Offset: 0x000CFBF1
		// (set) Token: 0x060055CF RID: 21967 RVA: 0x000D19F9 File Offset: 0x000CFBF9
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

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060055D0 RID: 21968 RVA: 0x000D1A02 File Offset: 0x000CFC02
		// (set) Token: 0x060055D1 RID: 21969 RVA: 0x000D1A0A File Offset: 0x000CFC0A
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

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060055D2 RID: 21970 RVA: 0x000D1A13 File Offset: 0x000CFC13
		// (set) Token: 0x060055D3 RID: 21971 RVA: 0x000D1A1B File Offset: 0x000CFC1B
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

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060055D4 RID: 21972 RVA: 0x000D1A24 File Offset: 0x000CFC24
		// (set) Token: 0x060055D5 RID: 21973 RVA: 0x000D1A2C File Offset: 0x000CFC2C
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

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060055D6 RID: 21974 RVA: 0x000D1A35 File Offset: 0x000CFC35
		// (set) Token: 0x060055D7 RID: 21975 RVA: 0x000D1A3D File Offset: 0x000CFC3D
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

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x060055D8 RID: 21976 RVA: 0x000D1A46 File Offset: 0x000CFC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveEventIds
		{
			get
			{
				return this.activeEventIds_;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x060055D9 RID: 21977 RVA: 0x000D1A4E File Offset: 0x000CFC4E
		// (set) Token: 0x060055DA RID: 21978 RVA: 0x000D1A56 File Offset: 0x000CFC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagInfo Bag
		{
			get
			{
				return this.bag_;
			}
			set
			{
				this.bag_ = value;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x060055DB RID: 21979 RVA: 0x000D1A5F File Offset: 0x000CFC5F
		// (set) Token: 0x060055DC RID: 21980 RVA: 0x000D1A67 File Offset: 0x000CFC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlPhase Phase
		{
			get
			{
				return this.phase_;
			}
			set
			{
				this.phase_ = value;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060055DD RID: 21981 RVA: 0x000D1A70 File Offset: 0x000CFC70
		// (set) Token: 0x060055DE RID: 21982 RVA: 0x000D1A78 File Offset: 0x000CFC78
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

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x000D1A81 File Offset: 0x000CFC81
		// (set) Token: 0x060055E0 RID: 21984 RVA: 0x000D1A89 File Offset: 0x000CFC89
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

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x060055E1 RID: 21985 RVA: 0x000D1A92 File Offset: 0x000CFC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlFighterInfo> Fighters
		{
			get
			{
				return this.fighters_;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x060055E2 RID: 21986 RVA: 0x000D1A9A File Offset: 0x000CFC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlNormalBagItemInfo> OpponentBagItems
		{
			get
			{
				return this.opponentBagItems_;
			}
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x000D1AA2 File Offset: 0x000CFCA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlInstBaseNotify);
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x000D1AB0 File Offset: 0x000CFCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlInstBaseNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.RoleId == other.RoleId && this.RoundNum == other.RoundNum && this.OpponentId == other.OpponentId && this.LoseCount == other.LoseCount && this.WinCount == other.WinCount && this.Coin == other.Coin && this.activeEventIds_.Equals(other.activeEventIds_) && object.Equals(this.Bag, other.Bag) && this.Phase == other.Phase && object.Equals(this.Event, other.Event) && object.Equals(this.Shop, other.Shop) && this.fighters_.Equals(other.fighters_) && this.opponentBagItems_.Equals(other.opponentBagItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x000D1BD8 File Offset: 0x000CFDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
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
			if (this.bag_ != null)
			{
				num ^= this.Bag.GetHashCode();
			}
			if (this.Phase != DangoBrawlPhase.EventSelect)
			{
				num ^= this.Phase.GetHashCode();
			}
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

		// Token: 0x060055E6 RID: 21990 RVA: 0x000D1D38 File Offset: 0x000CFF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x000D1D45 File Offset: 0x000CFF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x000D1D50 File Offset: 0x000CFF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpponentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.OpponentId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.bag_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Bag);
			}
			if (this.WinCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WinCount);
			}
			if (this.Phase != DangoBrawlPhase.EventSelect)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Phase);
			}
			this.opponentBagItems_.WriteTo(ref output, DangoBrawlInstBaseNotify._repeated_opponentBagItems_codec);
			if (this.event_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Event);
			}
			if (this.shop_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Shop);
			}
			if (this.Coin != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Coin);
			}
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LoseCount);
			}
			this.fighters_.WriteTo(ref output, DangoBrawlInstBaseNotify._repeated_fighters_codec);
			this.activeEventIds_.WriteTo(ref output, DangoBrawlInstBaseNotify._repeated_activeEventIds_codec);
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoundNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x000D1ED8 File Offset: 0x000D00D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
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
			num += this.activeEventIds_.CalculateSize(DangoBrawlInstBaseNotify._repeated_activeEventIds_codec);
			if (this.bag_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Bag);
			}
			if (this.Phase != DangoBrawlPhase.EventSelect)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Phase);
			}
			if (this.event_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Event);
			}
			if (this.shop_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Shop);
			}
			num += this.fighters_.CalculateSize(DangoBrawlInstBaseNotify._repeated_fighters_codec);
			num += this.opponentBagItems_.CalculateSize(DangoBrawlInstBaseNotify._repeated_opponentBagItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x000D2040 File Offset: 0x000D0240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlInstBaseNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
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
			if (other.bag_ != null)
			{
				if (this.bag_ == null)
				{
					this.Bag = new DangoBrawlBagInfo();
				}
				this.Bag.MergeFrom(other.Bag);
			}
			if (other.Phase != DangoBrawlPhase.EventSelect)
			{
				this.Phase = other.Phase;
			}
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

		// Token: 0x060055EB RID: 21995 RVA: 0x000D21BF File Offset: 0x000D03BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x000D21C8 File Offset: 0x000D03C8
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
				if (num <= 66U)
				{
					if (num <= 32U)
					{
						if (num == 8U)
						{
							this.OpponentId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.RoleId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 48U)
					{
						if (num == 42U)
						{
							if (this.bag_ == null)
							{
								this.Bag = new DangoBrawlBagInfo();
							}
							input.ReadMessage(this.Bag);
							continue;
						}
						if (num == 48U)
						{
							this.WinCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.Phase = (DangoBrawlPhase)input.ReadEnum();
							continue;
						}
						if (num == 66U)
						{
							this.opponentBagItems_.AddEntriesFrom(ref input, DangoBrawlInstBaseNotify._repeated_opponentBagItems_codec);
							continue;
						}
					}
				}
				else
				{
					if (num > 96U)
					{
						if (num <= 112U)
						{
							if (num == 106U)
							{
								this.fighters_.AddEntriesFrom(ref input, DangoBrawlInstBaseNotify._repeated_fighters_codec);
								continue;
							}
							if (num != 112U)
							{
								goto IL_AD;
							}
						}
						else if (num != 114U)
						{
							if (num != 120U)
							{
								goto IL_AD;
							}
							this.RoundNum = input.ReadInt32();
							continue;
						}
						this.activeEventIds_.AddEntriesFrom(ref input, DangoBrawlInstBaseNotify._repeated_activeEventIds_codec);
						continue;
					}
					if (num <= 82U)
					{
						if (num == 74U)
						{
							if (this.event_ == null)
							{
								this.Event = new DangoBrawlEventInfo();
							}
							input.ReadMessage(this.Event);
							continue;
						}
						if (num == 82U)
						{
							if (this.shop_ == null)
							{
								this.Shop = new DangoBrawlShopInfo();
							}
							input.ReadMessage(this.Shop);
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.Coin = input.ReadInt32();
							continue;
						}
						if (num == 96U)
						{
							this.LoseCount = input.ReadInt32();
							continue;
						}
					}
				}
				IL_AD:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003440 RID: 13376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003441 RID: 13377
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x04003442 RID: 13378
		private int challengeId_;

		// Token: 0x04003443 RID: 13379
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04003444 RID: 13380
		private int roleId_;

		// Token: 0x04003445 RID: 13381
		public const int RoundNumFieldNumber = 15;

		// Token: 0x04003446 RID: 13382
		private int roundNum_;

		// Token: 0x04003447 RID: 13383
		public const int OpponentIdFieldNumber = 1;

		// Token: 0x04003448 RID: 13384
		private int opponentId_;

		// Token: 0x04003449 RID: 13385
		public const int LoseCountFieldNumber = 12;

		// Token: 0x0400344A RID: 13386
		private int loseCount_;

		// Token: 0x0400344B RID: 13387
		public const int WinCountFieldNumber = 6;

		// Token: 0x0400344C RID: 13388
		private int winCount_;

		// Token: 0x0400344D RID: 13389
		public const int CoinFieldNumber = 11;

		// Token: 0x0400344E RID: 13390
		private int coin_;

		// Token: 0x0400344F RID: 13391
		public const int ActiveEventIdsFieldNumber = 14;

		// Token: 0x04003450 RID: 13392
		private static readonly FieldCodec<int> _repeated_activeEventIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003451 RID: 13393
		private readonly RepeatedField<int> activeEventIds_ = new RepeatedField<int>();

		// Token: 0x04003452 RID: 13394
		public const int BagFieldNumber = 5;

		// Token: 0x04003453 RID: 13395
		private DangoBrawlBagInfo bag_;

		// Token: 0x04003454 RID: 13396
		public const int PhaseFieldNumber = 7;

		// Token: 0x04003455 RID: 13397
		private DangoBrawlPhase phase_;

		// Token: 0x04003456 RID: 13398
		public const int EventFieldNumber = 9;

		// Token: 0x04003457 RID: 13399
		private DangoBrawlEventInfo event_;

		// Token: 0x04003458 RID: 13400
		public const int ShopFieldNumber = 10;

		// Token: 0x04003459 RID: 13401
		private DangoBrawlShopInfo shop_;

		// Token: 0x0400345A RID: 13402
		public const int FightersFieldNumber = 13;

		// Token: 0x0400345B RID: 13403
		private static readonly FieldCodec<DangoBrawlFighterInfo> _repeated_fighters_codec = FieldCodec.ForMessage<DangoBrawlFighterInfo>(106U, DangoBrawlFighterInfo.Parser);

		// Token: 0x0400345C RID: 13404
		private readonly RepeatedField<DangoBrawlFighterInfo> fighters_ = new RepeatedField<DangoBrawlFighterInfo>();

		// Token: 0x0400345D RID: 13405
		public const int OpponentBagItemsFieldNumber = 8;

		// Token: 0x0400345E RID: 13406
		private static readonly FieldCodec<DangoBrawlNormalBagItemInfo> _repeated_opponentBagItems_codec = FieldCodec.ForMessage<DangoBrawlNormalBagItemInfo>(66U, DangoBrawlNormalBagItemInfo.Parser);

		// Token: 0x0400345F RID: 13407
		private readonly RepeatedField<DangoBrawlNormalBagItemInfo> opponentBagItems_ = new RepeatedField<DangoBrawlNormalBagItemInfo>();
	}
}
