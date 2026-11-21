using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000363 RID: 867
	[NetMessage(EMessageId.DangoBrawlInstBaseNotify)]
	public sealed class DangoBrawlInstBaseNotify : IMessage<DangoBrawlInstBaseNotify>, IMessage, IEquatable<DangoBrawlInstBaseNotify>, IDeepCloneable<DangoBrawlInstBaseNotify>, IBufferMessage
	{
		// Token: 0x060056B1 RID: 22193 RVA: 0x000D3F0D File Offset: 0x000D210D
		[NullableContext(1)]
		public static DangoBrawlInstBaseNotify Create()
		{
			return new DangoBrawlInstBaseNotify();
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060056B2 RID: 22194 RVA: 0x000D3F14 File Offset: 0x000D2114
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
		// (get) Token: 0x060056B3 RID: 22195 RVA: 0x000D3F17 File Offset: 0x000D2117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlInstBaseNotify.Descriptor;
			}
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x000D3F1E File Offset: 0x000D211E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstBaseNotify()
		{
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x000D3F48 File Offset: 0x000D2148
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

		// Token: 0x060056B6 RID: 22198 RVA: 0x000D4053 File Offset: 0x000D2253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstBaseNotify Clone()
		{
			return new DangoBrawlInstBaseNotify(this);
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060056B7 RID: 22199 RVA: 0x000D405B File Offset: 0x000D225B
		// (set) Token: 0x060056B8 RID: 22200 RVA: 0x000D4063 File Offset: 0x000D2263
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

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060056B9 RID: 22201 RVA: 0x000D406C File Offset: 0x000D226C
		// (set) Token: 0x060056BA RID: 22202 RVA: 0x000D4074 File Offset: 0x000D2274
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

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x060056BB RID: 22203 RVA: 0x000D407D File Offset: 0x000D227D
		// (set) Token: 0x060056BC RID: 22204 RVA: 0x000D4085 File Offset: 0x000D2285
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

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060056BD RID: 22205 RVA: 0x000D408E File Offset: 0x000D228E
		// (set) Token: 0x060056BE RID: 22206 RVA: 0x000D4096 File Offset: 0x000D2296
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

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060056BF RID: 22207 RVA: 0x000D409F File Offset: 0x000D229F
		// (set) Token: 0x060056C0 RID: 22208 RVA: 0x000D40A7 File Offset: 0x000D22A7
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

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060056C1 RID: 22209 RVA: 0x000D40B0 File Offset: 0x000D22B0
		// (set) Token: 0x060056C2 RID: 22210 RVA: 0x000D40B8 File Offset: 0x000D22B8
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

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060056C3 RID: 22211 RVA: 0x000D40C1 File Offset: 0x000D22C1
		// (set) Token: 0x060056C4 RID: 22212 RVA: 0x000D40C9 File Offset: 0x000D22C9
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

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060056C5 RID: 22213 RVA: 0x000D40D2 File Offset: 0x000D22D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveEventIds
		{
			get
			{
				return this.activeEventIds_;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x000D40DA File Offset: 0x000D22DA
		// (set) Token: 0x060056C7 RID: 22215 RVA: 0x000D40E2 File Offset: 0x000D22E2
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

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060056C8 RID: 22216 RVA: 0x000D40EB File Offset: 0x000D22EB
		// (set) Token: 0x060056C9 RID: 22217 RVA: 0x000D40F3 File Offset: 0x000D22F3
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

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060056CA RID: 22218 RVA: 0x000D40FC File Offset: 0x000D22FC
		// (set) Token: 0x060056CB RID: 22219 RVA: 0x000D4104 File Offset: 0x000D2304
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

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x000D410D File Offset: 0x000D230D
		// (set) Token: 0x060056CD RID: 22221 RVA: 0x000D4115 File Offset: 0x000D2315
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

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060056CE RID: 22222 RVA: 0x000D411E File Offset: 0x000D231E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlFighterInfo> Fighters
		{
			get
			{
				return this.fighters_;
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x060056CF RID: 22223 RVA: 0x000D4126 File Offset: 0x000D2326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlNormalBagItemInfo> OpponentBagItems
		{
			get
			{
				return this.opponentBagItems_;
			}
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x000D412E File Offset: 0x000D232E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlInstBaseNotify);
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x000D413C File Offset: 0x000D233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlInstBaseNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.RoleId == other.RoleId && this.RoundNum == other.RoundNum && this.OpponentId == other.OpponentId && this.LoseCount == other.LoseCount && this.WinCount == other.WinCount && this.Coin == other.Coin && this.activeEventIds_.Equals(other.activeEventIds_) && object.Equals(this.Bag, other.Bag) && this.Phase == other.Phase && object.Equals(this.Event, other.Event) && object.Equals(this.Shop, other.Shop) && this.fighters_.Equals(other.fighters_) && this.opponentBagItems_.Equals(other.opponentBagItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x000D4264 File Offset: 0x000D2464
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

		// Token: 0x060056D3 RID: 22227 RVA: 0x000D43C4 File Offset: 0x000D25C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x000D43D1 File Offset: 0x000D25D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x000D43DC File Offset: 0x000D25DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shop_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Shop);
			}
			if (this.Coin != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Coin);
			}
			if (this.bag_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Bag);
			}
			this.activeEventIds_.WriteTo(ref output, DangoBrawlInstBaseNotify._repeated_activeEventIds_codec);
			if (this.Phase != DangoBrawlPhase.EventSelect)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Phase);
			}
			this.opponentBagItems_.WriteTo(ref output, DangoBrawlInstBaseNotify._repeated_opponentBagItems_codec);
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.OpponentId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.OpponentId);
			}
			this.fighters_.WriteTo(ref output, DangoBrawlInstBaseNotify._repeated_fighters_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoundNum);
			}
			if (this.event_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Event);
			}
			if (this.LoseCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LoseCount);
			}
			if (this.WinCount != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.WinCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x000D4564 File Offset: 0x000D2764
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

		// Token: 0x060056D7 RID: 22231 RVA: 0x000D46CC File Offset: 0x000D28CC
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

		// Token: 0x060056D8 RID: 22232 RVA: 0x000D484B File Offset: 0x000D2A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x000D4854 File Offset: 0x000D2A54
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
				if (num <= 50U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							if (this.shop_ == null)
							{
								this.Shop = new DangoBrawlShopInfo();
							}
							input.ReadMessage(this.Shop);
							continue;
						}
						if (num == 16U)
						{
							this.Coin = input.ReadInt32();
							continue;
						}
						if (num == 26U)
						{
							if (this.bag_ == null)
							{
								this.Bag = new DangoBrawlBagInfo();
							}
							input.ReadMessage(this.Bag);
							continue;
						}
					}
					else if (num <= 34U)
					{
						if (num == 32U || num == 34U)
						{
							this.activeEventIds_.AddEntriesFrom(ref input, DangoBrawlInstBaseNotify._repeated_activeEventIds_codec);
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.Phase = (DangoBrawlPhase)input.ReadEnum();
							continue;
						}
						if (num == 50U)
						{
							this.opponentBagItems_.AddEntriesFrom(ref input, DangoBrawlInstBaseNotify._repeated_opponentBagItems_codec);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 64U)
					{
						if (num == 56U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.OpponentId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 74U)
						{
							this.fighters_.AddEntriesFrom(ref input, DangoBrawlInstBaseNotify._repeated_fighters_codec);
							continue;
						}
						if (num == 88U)
						{
							this.RoleId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 96U)
					{
						this.RoundNum = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.event_ == null)
						{
							this.Event = new DangoBrawlEventInfo();
						}
						input.ReadMessage(this.Event);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.LoseCount = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.WinCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034DC RID: 13532
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034DD RID: 13533
		public const int ChallengeIdFieldNumber = 7;

		// Token: 0x040034DE RID: 13534
		private int challengeId_;

		// Token: 0x040034DF RID: 13535
		public const int RoleIdFieldNumber = 11;

		// Token: 0x040034E0 RID: 13536
		private int roleId_;

		// Token: 0x040034E1 RID: 13537
		public const int RoundNumFieldNumber = 12;

		// Token: 0x040034E2 RID: 13538
		private int roundNum_;

		// Token: 0x040034E3 RID: 13539
		public const int OpponentIdFieldNumber = 8;

		// Token: 0x040034E4 RID: 13540
		private int opponentId_;

		// Token: 0x040034E5 RID: 13541
		public const int LoseCountFieldNumber = 14;

		// Token: 0x040034E6 RID: 13542
		private int loseCount_;

		// Token: 0x040034E7 RID: 13543
		public const int WinCountFieldNumber = 15;

		// Token: 0x040034E8 RID: 13544
		private int winCount_;

		// Token: 0x040034E9 RID: 13545
		public const int CoinFieldNumber = 2;

		// Token: 0x040034EA RID: 13546
		private int coin_;

		// Token: 0x040034EB RID: 13547
		public const int ActiveEventIdsFieldNumber = 4;

		// Token: 0x040034EC RID: 13548
		private static readonly FieldCodec<int> _repeated_activeEventIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040034ED RID: 13549
		private readonly RepeatedField<int> activeEventIds_ = new RepeatedField<int>();

		// Token: 0x040034EE RID: 13550
		public const int BagFieldNumber = 3;

		// Token: 0x040034EF RID: 13551
		private DangoBrawlBagInfo bag_;

		// Token: 0x040034F0 RID: 13552
		public const int PhaseFieldNumber = 5;

		// Token: 0x040034F1 RID: 13553
		private DangoBrawlPhase phase_;

		// Token: 0x040034F2 RID: 13554
		public const int EventFieldNumber = 13;

		// Token: 0x040034F3 RID: 13555
		private DangoBrawlEventInfo event_;

		// Token: 0x040034F4 RID: 13556
		public const int ShopFieldNumber = 1;

		// Token: 0x040034F5 RID: 13557
		private DangoBrawlShopInfo shop_;

		// Token: 0x040034F6 RID: 13558
		public const int FightersFieldNumber = 9;

		// Token: 0x040034F7 RID: 13559
		private static readonly FieldCodec<DangoBrawlFighterInfo> _repeated_fighters_codec = FieldCodec.ForMessage<DangoBrawlFighterInfo>(74U, DangoBrawlFighterInfo.Parser);

		// Token: 0x040034F8 RID: 13560
		private readonly RepeatedField<DangoBrawlFighterInfo> fighters_ = new RepeatedField<DangoBrawlFighterInfo>();

		// Token: 0x040034F9 RID: 13561
		public const int OpponentBagItemsFieldNumber = 6;

		// Token: 0x040034FA RID: 13562
		private static readonly FieldCodec<DangoBrawlNormalBagItemInfo> _repeated_opponentBagItems_codec = FieldCodec.ForMessage<DangoBrawlNormalBagItemInfo>(50U, DangoBrawlNormalBagItemInfo.Parser);

		// Token: 0x040034FB RID: 13563
		private readonly RepeatedField<DangoBrawlNormalBagItemInfo> opponentBagItems_ = new RepeatedField<DangoBrawlNormalBagItemInfo>();
	}
}
