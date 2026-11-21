using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E37 RID: 3639
	public sealed class RacingBetRankPlayerInfo : IMessage<RacingBetRankPlayerInfo>, IMessage, IEquatable<RacingBetRankPlayerInfo>, IDeepCloneable<RacingBetRankPlayerInfo>, IBufferMessage
	{
		// Token: 0x0601390C RID: 80140 RVA: 0x002D89E8 File Offset: 0x002D6BE8
		[NullableContext(1)]
		public static RacingBetRankPlayerInfo Create()
		{
			return new RacingBetRankPlayerInfo();
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x0601390D RID: 80141 RVA: 0x002D89EF File Offset: 0x002D6BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetRankPlayerInfo> Parser
		{
			get
			{
				return RacingBetRankPlayerInfo._parser;
			}
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x0601390E RID: 80142 RVA: 0x002D89F6 File Offset: 0x002D6BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x0601390F RID: 80143 RVA: 0x002D89F9 File Offset: 0x002D6BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetRankPlayerInfo.Descriptor;
			}
		}

		// Token: 0x06013910 RID: 80144 RVA: 0x002D8A00 File Offset: 0x002D6C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankPlayerInfo()
		{
		}

		// Token: 0x06013911 RID: 80145 RVA: 0x002D8A14 File Offset: 0x002D6C14
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

		// Token: 0x06013912 RID: 80146 RVA: 0x002D8A8C File Offset: 0x002D6C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankPlayerInfo Clone()
		{
			return new RacingBetRankPlayerInfo(this);
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x06013913 RID: 80147 RVA: 0x002D8A94 File Offset: 0x002D6C94
		// (set) Token: 0x06013914 RID: 80148 RVA: 0x002D8A9C File Offset: 0x002D6C9C
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

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x06013915 RID: 80149 RVA: 0x002D8AA5 File Offset: 0x002D6CA5
		// (set) Token: 0x06013916 RID: 80150 RVA: 0x002D8AAD File Offset: 0x002D6CAD
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

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x06013917 RID: 80151 RVA: 0x002D8AB6 File Offset: 0x002D6CB6
		// (set) Token: 0x06013918 RID: 80152 RVA: 0x002D8ABE File Offset: 0x002D6CBE
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

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x06013919 RID: 80153 RVA: 0x002D8AD1 File Offset: 0x002D6CD1
		// (set) Token: 0x0601391A RID: 80154 RVA: 0x002D8AD9 File Offset: 0x002D6CD9
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

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x0601391B RID: 80155 RVA: 0x002D8AE2 File Offset: 0x002D6CE2
		// (set) Token: 0x0601391C RID: 80156 RVA: 0x002D8AEA File Offset: 0x002D6CEA
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

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x0601391D RID: 80157 RVA: 0x002D8AF3 File Offset: 0x002D6CF3
		// (set) Token: 0x0601391E RID: 80158 RVA: 0x002D8AFB File Offset: 0x002D6CFB
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

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x0601391F RID: 80159 RVA: 0x002D8B04 File Offset: 0x002D6D04
		// (set) Token: 0x06013920 RID: 80160 RVA: 0x002D8B0C File Offset: 0x002D6D0C
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

		// Token: 0x06013921 RID: 80161 RVA: 0x002D8B15 File Offset: 0x002D6D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetRankPlayerInfo);
		}

		// Token: 0x06013922 RID: 80162 RVA: 0x002D8B24 File Offset: 0x002D6D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetRankPlayerInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.HeadIcon == other.HeadIcon && !(this.Name != other.Name) && this.Cash == other.Cash && this.HitNum == other.HitNum && this.Rank == other.Rank && this.RankNameless == other.RankNameless && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013923 RID: 80163 RVA: 0x002D8BC4 File Offset: 0x002D6DC4
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

		// Token: 0x06013924 RID: 80164 RVA: 0x002D8C9B File Offset: 0x002D6E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013925 RID: 80165 RVA: 0x002D8CA8 File Offset: 0x002D6EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013926 RID: 80166 RVA: 0x002D8CB4 File Offset: 0x002D6EB4
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

		// Token: 0x06013927 RID: 80167 RVA: 0x002D8DA0 File Offset: 0x002D6FA0
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

		// Token: 0x06013928 RID: 80168 RVA: 0x002D8E68 File Offset: 0x002D7068
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

		// Token: 0x06013929 RID: 80169 RVA: 0x002D8F21 File Offset: 0x002D7121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601392A RID: 80170 RVA: 0x002D8F2C File Offset: 0x002D712C
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

		// Token: 0x0400783C RID: 30780
		private static readonly MessageParser<RacingBetRankPlayerInfo> _parser = new MessageParser<RacingBetRankPlayerInfo>(() => new RacingBetRankPlayerInfo());

		// Token: 0x0400783D RID: 30781
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400783E RID: 30782
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400783F RID: 30783
		private int playerId_;

		// Token: 0x04007840 RID: 30784
		public const int HeadIconFieldNumber = 2;

		// Token: 0x04007841 RID: 30785
		private int headIcon_;

		// Token: 0x04007842 RID: 30786
		public const int NameFieldNumber = 3;

		// Token: 0x04007843 RID: 30787
		private string name_ = "";

		// Token: 0x04007844 RID: 30788
		public const int CashFieldNumber = 4;

		// Token: 0x04007845 RID: 30789
		private int cash_;

		// Token: 0x04007846 RID: 30790
		public const int HitNumFieldNumber = 6;

		// Token: 0x04007847 RID: 30791
		private int hitNum_;

		// Token: 0x04007848 RID: 30792
		public const int RankFieldNumber = 7;

		// Token: 0x04007849 RID: 30793
		private int rank_;

		// Token: 0x0400784A RID: 30794
		public const int RankNamelessFieldNumber = 8;

		// Token: 0x0400784B RID: 30795
		private bool rankNameless_;
	}
}
