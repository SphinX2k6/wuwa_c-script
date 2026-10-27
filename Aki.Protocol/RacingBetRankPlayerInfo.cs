using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E47 RID: 3655
	public sealed class RacingBetRankPlayerInfo : IMessage<RacingBetRankPlayerInfo>, IMessage, IEquatable<RacingBetRankPlayerInfo>, IDeepCloneable<RacingBetRankPlayerInfo>, IBufferMessage
	{
		// Token: 0x060139F1 RID: 80369 RVA: 0x002DA0A4 File Offset: 0x002D82A4
		[NullableContext(1)]
		public static RacingBetRankPlayerInfo Create()
		{
			return new RacingBetRankPlayerInfo();
		}

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x060139F2 RID: 80370 RVA: 0x002DA0AB File Offset: 0x002D82AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetRankPlayerInfo> Parser
		{
			get
			{
				return RacingBetRankPlayerInfo._parser;
			}
		}

		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x060139F3 RID: 80371 RVA: 0x002DA0B2 File Offset: 0x002D82B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x060139F4 RID: 80372 RVA: 0x002DA0B5 File Offset: 0x002D82B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetRankPlayerInfo.Descriptor;
			}
		}

		// Token: 0x060139F5 RID: 80373 RVA: 0x002DA0BC File Offset: 0x002D82BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankPlayerInfo()
		{
		}

		// Token: 0x060139F6 RID: 80374 RVA: 0x002DA0D0 File Offset: 0x002D82D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankPlayerInfo(RacingBetRankPlayerInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.headIcon_ = other.headIcon_;
			this.name_ = other.name_;
			this.cash_ = other.cash_;
			this.hitNum_ = other.hitNum_;
			this.rank_ = other.rank_;
			this.rankNameless_ = other.rankNameless_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139F7 RID: 80375 RVA: 0x002DA148 File Offset: 0x002D8348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankPlayerInfo Clone()
		{
			return new RacingBetRankPlayerInfo(this);
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x060139F8 RID: 80376 RVA: 0x002DA150 File Offset: 0x002D8350
		// (set) Token: 0x060139F9 RID: 80377 RVA: 0x002DA158 File Offset: 0x002D8358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x060139FA RID: 80378 RVA: 0x002DA161 File Offset: 0x002D8361
		// (set) Token: 0x060139FB RID: 80379 RVA: 0x002DA169 File Offset: 0x002D8369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadIcon
		{
			get
			{
				return this.headIcon_;
			}
			set
			{
				this.headIcon_ = value;
			}
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x060139FC RID: 80380 RVA: 0x002DA172 File Offset: 0x002D8372
		// (set) Token: 0x060139FD RID: 80381 RVA: 0x002DA17A File Offset: 0x002D837A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x060139FE RID: 80382 RVA: 0x002DA18D File Offset: 0x002D838D
		// (set) Token: 0x060139FF RID: 80383 RVA: 0x002DA195 File Offset: 0x002D8395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cash
		{
			get
			{
				return this.cash_;
			}
			set
			{
				this.cash_ = value;
			}
		}

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x06013A00 RID: 80384 RVA: 0x002DA19E File Offset: 0x002D839E
		// (set) Token: 0x06013A01 RID: 80385 RVA: 0x002DA1A6 File Offset: 0x002D83A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HitNum
		{
			get
			{
				return this.hitNum_;
			}
			set
			{
				this.hitNum_ = value;
			}
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x06013A02 RID: 80386 RVA: 0x002DA1AF File Offset: 0x002D83AF
		// (set) Token: 0x06013A03 RID: 80387 RVA: 0x002DA1B7 File Offset: 0x002D83B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x06013A04 RID: 80388 RVA: 0x002DA1C0 File Offset: 0x002D83C0
		// (set) Token: 0x06013A05 RID: 80389 RVA: 0x002DA1C8 File Offset: 0x002D83C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RankNameless
		{
			get
			{
				return this.rankNameless_;
			}
			set
			{
				this.rankNameless_ = value;
			}
		}

		// Token: 0x06013A06 RID: 80390 RVA: 0x002DA1D1 File Offset: 0x002D83D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetRankPlayerInfo);
		}

		// Token: 0x06013A07 RID: 80391 RVA: 0x002DA1E0 File Offset: 0x002D83E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetRankPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.HeadIcon == other.HeadIcon && !(this.Name != other.Name) && this.Cash == other.Cash && this.HitNum == other.HitNum && this.Rank == other.Rank && this.RankNameless == other.RankNameless && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A08 RID: 80392 RVA: 0x002DA280 File Offset: 0x002D8480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.HeadIcon != 0)
			{
				num ^= this.HeadIcon.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Cash != 0)
			{
				num ^= this.Cash.GetHashCode();
			}
			if (this.HitNum != 0)
			{
				num ^= this.HitNum.GetHashCode();
			}
			if (this.Rank != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.RankNameless)
			{
				num ^= this.RankNameless.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A09 RID: 80393 RVA: 0x002DA357 File Offset: 0x002D8557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A0A RID: 80394 RVA: 0x002DA364 File Offset: 0x002D8564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A0B RID: 80395 RVA: 0x002DA370 File Offset: 0x002D8570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.HeadIcon != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HeadIcon);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			if (this.Cash != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Cash);
			}
			if (this.HitNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.HitNum);
			}
			if (this.Rank != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Rank);
			}
			if (this.RankNameless)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.RankNameless);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A0C RID: 80396 RVA: 0x002DA45C File Offset: 0x002D865C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.HeadIcon != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadIcon);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Cash != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cash);
			}
			if (this.HitNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HitNum);
			}
			if (this.Rank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rank);
			}
			if (this.RankNameless)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A0D RID: 80397 RVA: 0x002DA524 File Offset: 0x002D8724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetRankPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.HeadIcon != 0)
			{
				this.HeadIcon = other.HeadIcon;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Cash != 0)
			{
				this.Cash = other.Cash;
			}
			if (other.HitNum != 0)
			{
				this.HitNum = other.HitNum;
			}
			if (other.Rank != 0)
			{
				this.Rank = other.Rank;
			}
			if (other.RankNameless)
			{
				this.RankNameless = other.RankNameless;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A0E RID: 80398 RVA: 0x002DA5DD File Offset: 0x002D87DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A0F RID: 80399 RVA: 0x002DA5E8 File Offset: 0x002D87E8
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
					if (num == 8U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HeadIcon = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else if (num <= 48U)
				{
					if (num == 32U)
					{
						this.Cash = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.HitNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Rank = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.RankNameless = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007812 RID: 30738
		private static readonly MessageParser<RacingBetRankPlayerInfo> _parser = new MessageParser<RacingBetRankPlayerInfo>(() => new RacingBetRankPlayerInfo());

		// Token: 0x04007813 RID: 30739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007814 RID: 30740
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007815 RID: 30741
		private int playerId_;

		// Token: 0x04007816 RID: 30742
		public const int HeadIconFieldNumber = 2;

		// Token: 0x04007817 RID: 30743
		private int headIcon_;

		// Token: 0x04007818 RID: 30744
		public const int NameFieldNumber = 3;

		// Token: 0x04007819 RID: 30745
		private string name_ = "";

		// Token: 0x0400781A RID: 30746
		public const int CashFieldNumber = 4;

		// Token: 0x0400781B RID: 30747
		private int cash_;

		// Token: 0x0400781C RID: 30748
		public const int HitNumFieldNumber = 6;

		// Token: 0x0400781D RID: 30749
		private int hitNum_;

		// Token: 0x0400781E RID: 30750
		public const int RankFieldNumber = 7;

		// Token: 0x0400781F RID: 30751
		private int rank_;

		// Token: 0x04007820 RID: 30752
		public const int RankNamelessFieldNumber = 8;

		// Token: 0x04007821 RID: 30753
		private bool rankNameless_;
	}
}
