using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9E RID: 3486
	public sealed class PlayerSettleInfo : IMessage<PlayerSettleInfo>, IMessage, IEquatable<PlayerSettleInfo>, IDeepCloneable<PlayerSettleInfo>, IBufferMessage
	{
		// Token: 0x06012CE8 RID: 77032 RVA: 0x002BECE0 File Offset: 0x002BCEE0
		[NullableContext(1)]
		public static PlayerSettleInfo Create()
		{
			return new PlayerSettleInfo();
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x06012CE9 RID: 77033 RVA: 0x002BECE7 File Offset: 0x002BCEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSettleInfo> Parser
		{
			get
			{
				return PlayerSettleInfo._parser;
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x06012CEA RID: 77034 RVA: 0x002BECEE File Offset: 0x002BCEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x06012CEB RID: 77035 RVA: 0x002BECF1 File Offset: 0x002BCEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSettleInfo.Descriptor;
			}
		}

		// Token: 0x06012CEC RID: 77036 RVA: 0x002BECF8 File Offset: 0x002BCEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettleInfo()
		{
		}

		// Token: 0x06012CED RID: 77037 RVA: 0x002BED0C File Offset: 0x002BCF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettleInfo(PlayerSettleInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.headId_ = other.headId_;
			this.ranking_ = other.ranking_;
			this.consumeTime_ = other.consumeTime_;
			this.finish_ = other.finish_;
			this.goldPoints_ = other.goldPoints_;
			this.rankPoints_ = other.rankPoints_;
			this.distancePoints_ = other.distancePoints_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CEE RID: 77038 RVA: 0x002BED9C File Offset: 0x002BCF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettleInfo Clone()
		{
			return new PlayerSettleInfo(this);
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x06012CEF RID: 77039 RVA: 0x002BEDA4 File Offset: 0x002BCFA4
		// (set) Token: 0x06012CF0 RID: 77040 RVA: 0x002BEDAC File Offset: 0x002BCFAC
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

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x06012CF1 RID: 77041 RVA: 0x002BEDB5 File Offset: 0x002BCFB5
		// (set) Token: 0x06012CF2 RID: 77042 RVA: 0x002BEDBD File Offset: 0x002BCFBD
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

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x06012CF3 RID: 77043 RVA: 0x002BEDD0 File Offset: 0x002BCFD0
		// (set) Token: 0x06012CF4 RID: 77044 RVA: 0x002BEDD8 File Offset: 0x002BCFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadId
		{
			get
			{
				return this.headId_;
			}
			set
			{
				this.headId_ = value;
			}
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x06012CF5 RID: 77045 RVA: 0x002BEDE1 File Offset: 0x002BCFE1
		// (set) Token: 0x06012CF6 RID: 77046 RVA: 0x002BEDE9 File Offset: 0x002BCFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Ranking
		{
			get
			{
				return this.ranking_;
			}
			set
			{
				this.ranking_ = value;
			}
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x06012CF7 RID: 77047 RVA: 0x002BEDF2 File Offset: 0x002BCFF2
		// (set) Token: 0x06012CF8 RID: 77048 RVA: 0x002BEDFA File Offset: 0x002BCFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConsumeTime
		{
			get
			{
				return this.consumeTime_;
			}
			set
			{
				this.consumeTime_ = value;
			}
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x06012CF9 RID: 77049 RVA: 0x002BEE03 File Offset: 0x002BD003
		// (set) Token: 0x06012CFA RID: 77050 RVA: 0x002BEE0B File Offset: 0x002BD00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Finish
		{
			get
			{
				return this.finish_;
			}
			set
			{
				this.finish_ = value;
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x06012CFB RID: 77051 RVA: 0x002BEE14 File Offset: 0x002BD014
		// (set) Token: 0x06012CFC RID: 77052 RVA: 0x002BEE1C File Offset: 0x002BD01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoldPoints
		{
			get
			{
				return this.goldPoints_;
			}
			set
			{
				this.goldPoints_ = value;
			}
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x06012CFD RID: 77053 RVA: 0x002BEE25 File Offset: 0x002BD025
		// (set) Token: 0x06012CFE RID: 77054 RVA: 0x002BEE2D File Offset: 0x002BD02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankPoints
		{
			get
			{
				return this.rankPoints_;
			}
			set
			{
				this.rankPoints_ = value;
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x06012CFF RID: 77055 RVA: 0x002BEE36 File Offset: 0x002BD036
		// (set) Token: 0x06012D00 RID: 77056 RVA: 0x002BEE3E File Offset: 0x002BD03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DistancePoints
		{
			get
			{
				return this.distancePoints_;
			}
			set
			{
				this.distancePoints_ = value;
			}
		}

		// Token: 0x06012D01 RID: 77057 RVA: 0x002BEE47 File Offset: 0x002BD047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSettleInfo);
		}

		// Token: 0x06012D02 RID: 77058 RVA: 0x002BEE58 File Offset: 0x002BD058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSettleInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.HeadId == other.HeadId && this.Ranking == other.Ranking && this.ConsumeTime == other.ConsumeTime && this.Finish == other.Finish && this.GoldPoints == other.GoldPoints && this.RankPoints == other.RankPoints && this.DistancePoints == other.DistancePoints && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D03 RID: 77059 RVA: 0x002BEF18 File Offset: 0x002BD118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.HeadId != 0)
			{
				num ^= this.HeadId.GetHashCode();
			}
			if (this.Ranking != 0)
			{
				num ^= this.Ranking.GetHashCode();
			}
			if (this.ConsumeTime != 0)
			{
				num ^= this.ConsumeTime.GetHashCode();
			}
			if (this.Finish)
			{
				num ^= this.Finish.GetHashCode();
			}
			if (this.GoldPoints != 0)
			{
				num ^= this.GoldPoints.GetHashCode();
			}
			if (this.RankPoints != 0)
			{
				num ^= this.RankPoints.GetHashCode();
			}
			if (this.DistancePoints != 0)
			{
				num ^= this.DistancePoints.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D04 RID: 77060 RVA: 0x002BF021 File Offset: 0x002BD221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D05 RID: 77061 RVA: 0x002BF02E File Offset: 0x002BD22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D06 RID: 77062 RVA: 0x002BF038 File Offset: 0x002BD238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.HeadId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HeadId);
			}
			if (this.Ranking != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Ranking);
			}
			if (this.ConsumeTime != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ConsumeTime);
			}
			if (this.Finish)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Finish);
			}
			if (this.GoldPoints != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.GoldPoints);
			}
			if (this.RankPoints != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RankPoints);
			}
			if (this.DistancePoints != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DistancePoints);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D07 RID: 77063 RVA: 0x002BF15C File Offset: 0x002BD35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.HeadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadId);
			}
			if (this.Ranking != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Ranking);
			}
			if (this.ConsumeTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConsumeTime);
			}
			if (this.Finish)
			{
				num += 2;
			}
			if (this.GoldPoints != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoldPoints);
			}
			if (this.RankPoints != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RankPoints);
			}
			if (this.DistancePoints != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DistancePoints);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D08 RID: 77064 RVA: 0x002BF254 File Offset: 0x002BD454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSettleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.HeadId != 0)
			{
				this.HeadId = other.HeadId;
			}
			if (other.Ranking != 0)
			{
				this.Ranking = other.Ranking;
			}
			if (other.ConsumeTime != 0)
			{
				this.ConsumeTime = other.ConsumeTime;
			}
			if (other.Finish)
			{
				this.Finish = other.Finish;
			}
			if (other.GoldPoints != 0)
			{
				this.GoldPoints = other.GoldPoints;
			}
			if (other.RankPoints != 0)
			{
				this.RankPoints = other.RankPoints;
			}
			if (other.DistancePoints != 0)
			{
				this.DistancePoints = other.DistancePoints;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D09 RID: 77065 RVA: 0x002BF335 File Offset: 0x002BD535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D0A RID: 77066 RVA: 0x002BF340 File Offset: 0x002BD540
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
				if (num <= 32U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.PlayerId = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							this.Name = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.HeadId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Ranking = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.ConsumeTime = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Finish = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.GoldPoints = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.RankPoints = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.DistancePoints = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040074E2 RID: 29922
		private static readonly MessageParser<PlayerSettleInfo> _parser = new MessageParser<PlayerSettleInfo>(() => new PlayerSettleInfo());

		// Token: 0x040074E3 RID: 29923
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074E4 RID: 29924
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040074E5 RID: 29925
		private int playerId_;

		// Token: 0x040074E6 RID: 29926
		public const int NameFieldNumber = 2;

		// Token: 0x040074E7 RID: 29927
		private string name_ = "";

		// Token: 0x040074E8 RID: 29928
		public const int HeadIdFieldNumber = 3;

		// Token: 0x040074E9 RID: 29929
		private int headId_;

		// Token: 0x040074EA RID: 29930
		public const int RankingFieldNumber = 4;

		// Token: 0x040074EB RID: 29931
		private int ranking_;

		// Token: 0x040074EC RID: 29932
		public const int ConsumeTimeFieldNumber = 5;

		// Token: 0x040074ED RID: 29933
		private int consumeTime_;

		// Token: 0x040074EE RID: 29934
		public const int FinishFieldNumber = 6;

		// Token: 0x040074EF RID: 29935
		private bool finish_;

		// Token: 0x040074F0 RID: 29936
		public const int GoldPointsFieldNumber = 7;

		// Token: 0x040074F1 RID: 29937
		private int goldPoints_;

		// Token: 0x040074F2 RID: 29938
		public const int RankPointsFieldNumber = 8;

		// Token: 0x040074F3 RID: 29939
		private int rankPoints_;

		// Token: 0x040074F4 RID: 29940
		public const int DistancePointsFieldNumber = 9;

		// Token: 0x040074F5 RID: 29941
		private int distancePoints_;
	}
}
