using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAE RID: 3502
	public sealed class PlayerSettleInfo : IMessage<PlayerSettleInfo>, IMessage, IEquatable<PlayerSettleInfo>, IDeepCloneable<PlayerSettleInfo>, IBufferMessage
	{
		// Token: 0x06012DE4 RID: 77284 RVA: 0x002C0904 File Offset: 0x002BEB04
		[NullableContext(1)]
		public static PlayerSettleInfo Create()
		{
			return new PlayerSettleInfo();
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x06012DE5 RID: 77285 RVA: 0x002C090B File Offset: 0x002BEB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerSettleInfo> Parser
		{
			get
			{
				return PlayerSettleInfo._parser;
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x06012DE6 RID: 77286 RVA: 0x002C0912 File Offset: 0x002BEB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x06012DE7 RID: 77287 RVA: 0x002C0915 File Offset: 0x002BEB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSettleInfo.Descriptor;
			}
		}

		// Token: 0x06012DE8 RID: 77288 RVA: 0x002C091C File Offset: 0x002BEB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettleInfo()
		{
		}

		// Token: 0x06012DE9 RID: 77289 RVA: 0x002C0930 File Offset: 0x002BEB30
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

		// Token: 0x06012DEA RID: 77290 RVA: 0x002C09C0 File Offset: 0x002BEBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSettleInfo Clone()
		{
			return new PlayerSettleInfo(this);
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x06012DEB RID: 77291 RVA: 0x002C09C8 File Offset: 0x002BEBC8
		// (set) Token: 0x06012DEC RID: 77292 RVA: 0x002C09D0 File Offset: 0x002BEBD0
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

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x06012DED RID: 77293 RVA: 0x002C09D9 File Offset: 0x002BEBD9
		// (set) Token: 0x06012DEE RID: 77294 RVA: 0x002C09E1 File Offset: 0x002BEBE1
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

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x06012DEF RID: 77295 RVA: 0x002C09F4 File Offset: 0x002BEBF4
		// (set) Token: 0x06012DF0 RID: 77296 RVA: 0x002C09FC File Offset: 0x002BEBFC
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

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x06012DF1 RID: 77297 RVA: 0x002C0A05 File Offset: 0x002BEC05
		// (set) Token: 0x06012DF2 RID: 77298 RVA: 0x002C0A0D File Offset: 0x002BEC0D
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

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x06012DF3 RID: 77299 RVA: 0x002C0A16 File Offset: 0x002BEC16
		// (set) Token: 0x06012DF4 RID: 77300 RVA: 0x002C0A1E File Offset: 0x002BEC1E
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

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x06012DF5 RID: 77301 RVA: 0x002C0A27 File Offset: 0x002BEC27
		// (set) Token: 0x06012DF6 RID: 77302 RVA: 0x002C0A2F File Offset: 0x002BEC2F
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

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x06012DF7 RID: 77303 RVA: 0x002C0A38 File Offset: 0x002BEC38
		// (set) Token: 0x06012DF8 RID: 77304 RVA: 0x002C0A40 File Offset: 0x002BEC40
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

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x06012DF9 RID: 77305 RVA: 0x002C0A49 File Offset: 0x002BEC49
		// (set) Token: 0x06012DFA RID: 77306 RVA: 0x002C0A51 File Offset: 0x002BEC51
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

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x06012DFB RID: 77307 RVA: 0x002C0A5A File Offset: 0x002BEC5A
		// (set) Token: 0x06012DFC RID: 77308 RVA: 0x002C0A62 File Offset: 0x002BEC62
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

		// Token: 0x06012DFD RID: 77309 RVA: 0x002C0A6B File Offset: 0x002BEC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSettleInfo);
		}

		// Token: 0x06012DFE RID: 77310 RVA: 0x002C0A7C File Offset: 0x002BEC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSettleInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.HeadId == other.HeadId && this.Ranking == other.Ranking && this.ConsumeTime == other.ConsumeTime && this.Finish == other.Finish && this.GoldPoints == other.GoldPoints && this.RankPoints == other.RankPoints && this.DistancePoints == other.DistancePoints && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012DFF RID: 77311 RVA: 0x002C0B3C File Offset: 0x002BED3C
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

		// Token: 0x06012E00 RID: 77312 RVA: 0x002C0C45 File Offset: 0x002BEE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E01 RID: 77313 RVA: 0x002C0C52 File Offset: 0x002BEE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E02 RID: 77314 RVA: 0x002C0C5C File Offset: 0x002BEE5C
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

		// Token: 0x06012E03 RID: 77315 RVA: 0x002C0D80 File Offset: 0x002BEF80
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

		// Token: 0x06012E04 RID: 77316 RVA: 0x002C0E78 File Offset: 0x002BF078
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

		// Token: 0x06012E05 RID: 77317 RVA: 0x002C0F59 File Offset: 0x002BF159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E06 RID: 77318 RVA: 0x002C0F64 File Offset: 0x002BF164
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

		// Token: 0x040074CA RID: 29898
		private static readonly MessageParser<PlayerSettleInfo> _parser = new MessageParser<PlayerSettleInfo>(() => new PlayerSettleInfo());

		// Token: 0x040074CB RID: 29899
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074CC RID: 29900
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040074CD RID: 29901
		private int playerId_;

		// Token: 0x040074CE RID: 29902
		public const int NameFieldNumber = 2;

		// Token: 0x040074CF RID: 29903
		private string name_ = "";

		// Token: 0x040074D0 RID: 29904
		public const int HeadIdFieldNumber = 3;

		// Token: 0x040074D1 RID: 29905
		private int headId_;

		// Token: 0x040074D2 RID: 29906
		public const int RankingFieldNumber = 4;

		// Token: 0x040074D3 RID: 29907
		private int ranking_;

		// Token: 0x040074D4 RID: 29908
		public const int ConsumeTimeFieldNumber = 5;

		// Token: 0x040074D5 RID: 29909
		private int consumeTime_;

		// Token: 0x040074D6 RID: 29910
		public const int FinishFieldNumber = 6;

		// Token: 0x040074D7 RID: 29911
		private bool finish_;

		// Token: 0x040074D8 RID: 29912
		public const int GoldPointsFieldNumber = 7;

		// Token: 0x040074D9 RID: 29913
		private int goldPoints_;

		// Token: 0x040074DA RID: 29914
		public const int RankPointsFieldNumber = 8;

		// Token: 0x040074DB RID: 29915
		private int rankPoints_;

		// Token: 0x040074DC RID: 29916
		public const int DistancePointsFieldNumber = 9;

		// Token: 0x040074DD RID: 29917
		private int distancePoints_;
	}
}
