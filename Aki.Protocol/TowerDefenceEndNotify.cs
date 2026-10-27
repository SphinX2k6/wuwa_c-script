using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139D RID: 5021
	[NetMessage(EMessageId.TowerDefenceEndNotify)]
	public sealed class TowerDefenceEndNotify : IMessage<TowerDefenceEndNotify>, IMessage, IEquatable<TowerDefenceEndNotify>, IDeepCloneable<TowerDefenceEndNotify>, IBufferMessage
	{
		// Token: 0x0601AA40 RID: 109120 RVA: 0x003DD2F4 File Offset: 0x003DB4F4
		[NullableContext(1)]
		public static TowerDefenceEndNotify Create()
		{
			return new TowerDefenceEndNotify();
		}

		// Token: 0x170059D2 RID: 22994
		// (get) Token: 0x0601AA41 RID: 109121 RVA: 0x003DD2FB File Offset: 0x003DB4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059D3 RID: 22995
		// (get) Token: 0x0601AA42 RID: 109122 RVA: 0x003DD2FE File Offset: 0x003DB4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceEndNotify.Descriptor;
			}
		}

		// Token: 0x0601AA43 RID: 109123 RVA: 0x003DD305 File Offset: 0x003DB505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEndNotify()
		{
		}

		// Token: 0x0601AA44 RID: 109124 RVA: 0x003DD318 File Offset: 0x003DB518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEndNotify(TowerDefenceEndNotify other) : this()
		{
			this.success_ = other.success_;
			this.score_ = other.score_;
			this.maxScore_ = other.maxScore_;
			this.instId_ = other.instId_;
			this.passTime_ = other.passTime_;
			this.minPassTime_ = other.minPassTime_;
			this.battleInfo_ = other.battleInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA45 RID: 109125 RVA: 0x003DD395 File Offset: 0x003DB595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEndNotify Clone()
		{
			return new TowerDefenceEndNotify(this);
		}

		// Token: 0x170059D4 RID: 22996
		// (get) Token: 0x0601AA46 RID: 109126 RVA: 0x003DD39D File Offset: 0x003DB59D
		// (set) Token: 0x0601AA47 RID: 109127 RVA: 0x003DD3A5 File Offset: 0x003DB5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x170059D5 RID: 22997
		// (get) Token: 0x0601AA48 RID: 109128 RVA: 0x003DD3AE File Offset: 0x003DB5AE
		// (set) Token: 0x0601AA49 RID: 109129 RVA: 0x003DD3B6 File Offset: 0x003DB5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x170059D6 RID: 22998
		// (get) Token: 0x0601AA4A RID: 109130 RVA: 0x003DD3BF File Offset: 0x003DB5BF
		// (set) Token: 0x0601AA4B RID: 109131 RVA: 0x003DD3C7 File Offset: 0x003DB5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x170059D7 RID: 22999
		// (get) Token: 0x0601AA4C RID: 109132 RVA: 0x003DD3D0 File Offset: 0x003DB5D0
		// (set) Token: 0x0601AA4D RID: 109133 RVA: 0x003DD3D8 File Offset: 0x003DB5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170059D8 RID: 23000
		// (get) Token: 0x0601AA4E RID: 109134 RVA: 0x003DD3E1 File Offset: 0x003DB5E1
		// (set) Token: 0x0601AA4F RID: 109135 RVA: 0x003DD3E9 File Offset: 0x003DB5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x170059D9 RID: 23001
		// (get) Token: 0x0601AA50 RID: 109136 RVA: 0x003DD3F2 File Offset: 0x003DB5F2
		// (set) Token: 0x0601AA51 RID: 109137 RVA: 0x003DD3FA File Offset: 0x003DB5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinPassTime
		{
			get
			{
				return this.minPassTime_;
			}
			set
			{
				this.minPassTime_ = value;
			}
		}

		// Token: 0x170059DA RID: 23002
		// (get) Token: 0x0601AA52 RID: 109138 RVA: 0x003DD403 File Offset: 0x003DB603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceRoleScoreInfo> BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
		}

		// Token: 0x0601AA53 RID: 109139 RVA: 0x003DD40B File Offset: 0x003DB60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceEndNotify);
		}

		// Token: 0x0601AA54 RID: 109140 RVA: 0x003DD41C File Offset: 0x003DB61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceEndNotify other)
		{
			return other != null && (other == this || (this.Success == other.Success && this.Score == other.Score && this.MaxScore == other.MaxScore && this.InstId == other.InstId && this.PassTime == other.PassTime && this.MinPassTime == other.MinPassTime && this.battleInfo_.Equals(other.battleInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA55 RID: 109141 RVA: 0x003DD4BC File Offset: 0x003DB6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this.MinPassTime != 0)
			{
				num ^= this.MinPassTime.GetHashCode();
			}
			num ^= this.battleInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AA56 RID: 109142 RVA: 0x003DD586 File Offset: 0x003DB786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA57 RID: 109143 RVA: 0x003DD593 File Offset: 0x003DB793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA58 RID: 109144 RVA: 0x003DD59C File Offset: 0x003DB79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Score != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Score);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PassTime);
			}
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxScore);
			}
			if (this.Success)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Success);
			}
			if (this.MinPassTime != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MinPassTime);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.InstId);
			}
			this.battleInfo_.WriteTo(ref output, TowerDefenceEndNotify._repeated_battleInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA59 RID: 109145 RVA: 0x003DD678 File Offset: 0x003DB878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Success)
			{
				num += 2;
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this.MinPassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinPassTime);
			}
			num += this.battleInfo_.CalculateSize(TowerDefenceEndNotify._repeated_battleInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AA5A RID: 109146 RVA: 0x003DD738 File Offset: 0x003DB938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			if (other.MinPassTime != 0)
			{
				this.MinPassTime = other.MinPassTime;
			}
			this.battleInfo_.Add(other.battleInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AA5B RID: 109147 RVA: 0x003DD7E9 File Offset: 0x003DB9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA5C RID: 109148 RVA: 0x003DD7F4 File Offset: 0x003DB9F4
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
					if (num == 8U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.Success = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.MinPassTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						this.battleInfo_.AddEntriesFrom(ref input, TowerDefenceEndNotify._repeated_battleInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009AC3 RID: 39619
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AC4 RID: 39620
		public const int SuccessFieldNumber = 7;

		// Token: 0x04009AC5 RID: 39621
		private bool success_;

		// Token: 0x04009AC6 RID: 39622
		public const int ScoreFieldNumber = 1;

		// Token: 0x04009AC7 RID: 39623
		private int score_;

		// Token: 0x04009AC8 RID: 39624
		public const int MaxScoreFieldNumber = 4;

		// Token: 0x04009AC9 RID: 39625
		private int maxScore_;

		// Token: 0x04009ACA RID: 39626
		public const int InstIdFieldNumber = 11;

		// Token: 0x04009ACB RID: 39627
		private int instId_;

		// Token: 0x04009ACC RID: 39628
		public const int PassTimeFieldNumber = 3;

		// Token: 0x04009ACD RID: 39629
		private int passTime_;

		// Token: 0x04009ACE RID: 39630
		public const int MinPassTimeFieldNumber = 8;

		// Token: 0x04009ACF RID: 39631
		private int minPassTime_;

		// Token: 0x04009AD0 RID: 39632
		public const int BattleInfoFieldNumber = 13;

		// Token: 0x04009AD1 RID: 39633
		private static readonly FieldCodec<TowerDefenceRoleScoreInfo> _repeated_battleInfo_codec = FieldCodec.ForMessage<TowerDefenceRoleScoreInfo>(106U, TowerDefenceRoleScoreInfo.Parser);

		// Token: 0x04009AD2 RID: 39634
		private readonly RepeatedField<TowerDefenceRoleScoreInfo> battleInfo_ = new RepeatedField<TowerDefenceRoleScoreInfo>();
	}
}
