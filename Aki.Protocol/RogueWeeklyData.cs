using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001035 RID: 4149
	public sealed class RogueWeeklyData : IMessage<RogueWeeklyData>, IMessage, IEquatable<RogueWeeklyData>, IDeepCloneable<RogueWeeklyData>, IBufferMessage
	{
		// Token: 0x060162B7 RID: 90807 RVA: 0x003385C3 File Offset: 0x003367C3
		[NullableContext(1)]
		public static RogueWeeklyData Create()
		{
			return new RogueWeeklyData();
		}

		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x060162B8 RID: 90808 RVA: 0x003385CA File Offset: 0x003367CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x060162B9 RID: 90809 RVA: 0x003385CD File Offset: 0x003367CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyData.Descriptor;
			}
		}

		// Token: 0x060162BA RID: 90810 RVA: 0x003385D4 File Offset: 0x003367D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyData()
		{
		}

		// Token: 0x060162BB RID: 90811 RVA: 0x003385E8 File Offset: 0x003367E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyData(RogueWeeklyData other) : this()
		{
			this.cycleId_ = other.cycleId_;
			this.score_ = other.score_;
			this.rogueWeeklyLastInfo_ = ((other.rogueWeeklyLastInfo_ != null) ? other.rogueWeeklyLastInfo_.Clone() : null);
			this.rogueWeeklyAwards_ = other.rogueWeeklyAwards_.Clone();
			this.maxScore_ = other.maxScore_;
			this.curWorldLevel_ = other.curWorldLevel_;
			this.useFreeCount_ = other.useFreeCount_;
			this.maxFreeCount_ = other.maxFreeCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162BC RID: 90812 RVA: 0x00338681 File Offset: 0x00336881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyData Clone()
		{
			return new RogueWeeklyData(this);
		}

		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x060162BD RID: 90813 RVA: 0x00338689 File Offset: 0x00336889
		// (set) Token: 0x060162BE RID: 90814 RVA: 0x00338691 File Offset: 0x00336891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleId
		{
			get
			{
				return this.cycleId_;
			}
			set
			{
				this.cycleId_ = value;
			}
		}

		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x060162BF RID: 90815 RVA: 0x0033869A File Offset: 0x0033689A
		// (set) Token: 0x060162C0 RID: 90816 RVA: 0x003386A2 File Offset: 0x003368A2
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

		// Token: 0x17004A1B RID: 18971
		// (get) Token: 0x060162C1 RID: 90817 RVA: 0x003386AB File Offset: 0x003368AB
		// (set) Token: 0x060162C2 RID: 90818 RVA: 0x003386B3 File Offset: 0x003368B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyLastInfo RogueWeeklyLastInfo
		{
			get
			{
				return this.rogueWeeklyLastInfo_;
			}
			set
			{
				this.rogueWeeklyLastInfo_ = value;
			}
		}

		// Token: 0x17004A1C RID: 18972
		// (get) Token: 0x060162C3 RID: 90819 RVA: 0x003386BC File Offset: 0x003368BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueWeeklyAward> RogueWeeklyAwards
		{
			get
			{
				return this.rogueWeeklyAwards_;
			}
		}

		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x060162C4 RID: 90820 RVA: 0x003386C4 File Offset: 0x003368C4
		// (set) Token: 0x060162C5 RID: 90821 RVA: 0x003386CC File Offset: 0x003368CC
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

		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x060162C6 RID: 90822 RVA: 0x003386D5 File Offset: 0x003368D5
		// (set) Token: 0x060162C7 RID: 90823 RVA: 0x003386DD File Offset: 0x003368DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWorldLevel
		{
			get
			{
				return this.curWorldLevel_;
			}
			set
			{
				this.curWorldLevel_ = value;
			}
		}

		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x060162C8 RID: 90824 RVA: 0x003386E6 File Offset: 0x003368E6
		// (set) Token: 0x060162C9 RID: 90825 RVA: 0x003386EE File Offset: 0x003368EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseFreeCount
		{
			get
			{
				return this.useFreeCount_;
			}
			set
			{
				this.useFreeCount_ = value;
			}
		}

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x060162CA RID: 90826 RVA: 0x003386F7 File Offset: 0x003368F7
		// (set) Token: 0x060162CB RID: 90827 RVA: 0x003386FF File Offset: 0x003368FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxFreeCount
		{
			get
			{
				return this.maxFreeCount_;
			}
			set
			{
				this.maxFreeCount_ = value;
			}
		}

		// Token: 0x060162CC RID: 90828 RVA: 0x00338708 File Offset: 0x00336908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyData);
		}

		// Token: 0x060162CD RID: 90829 RVA: 0x00338718 File Offset: 0x00336918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyData other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && this.Score == other.Score && object.Equals(this.RogueWeeklyLastInfo, other.RogueWeeklyLastInfo) && this.rogueWeeklyAwards_.Equals(other.rogueWeeklyAwards_) && this.MaxScore == other.MaxScore && this.CurWorldLevel == other.CurWorldLevel && this.UseFreeCount == other.UseFreeCount && this.MaxFreeCount == other.MaxFreeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060162CE RID: 90830 RVA: 0x003387CC File Offset: 0x003369CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CycleId != 0)
			{
				num ^= this.CycleId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.rogueWeeklyLastInfo_ != null)
			{
				num ^= this.RogueWeeklyLastInfo.GetHashCode();
			}
			num ^= this.rogueWeeklyAwards_.GetHashCode();
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.CurWorldLevel != 0)
			{
				num ^= this.CurWorldLevel.GetHashCode();
			}
			if (this.UseFreeCount != 0)
			{
				num ^= this.UseFreeCount.GetHashCode();
			}
			if (this.MaxFreeCount != 0)
			{
				num ^= this.MaxFreeCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060162CF RID: 90831 RVA: 0x003388AC File Offset: 0x00336AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060162D0 RID: 90832 RVA: 0x003388B9 File Offset: 0x00336AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060162D1 RID: 90833 RVA: 0x003388C4 File Offset: 0x00336AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CycleId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.rogueWeeklyLastInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueWeeklyLastInfo);
			}
			this.rogueWeeklyAwards_.WriteTo(ref output, RogueWeeklyData._repeated_rogueWeeklyAwards_codec);
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MaxScore);
			}
			if (this.CurWorldLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurWorldLevel);
			}
			if (this.UseFreeCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.UseFreeCount);
			}
			if (this.MaxFreeCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.MaxFreeCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060162D2 RID: 90834 RVA: 0x003389BC File Offset: 0x00336BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CycleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.rogueWeeklyLastInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueWeeklyLastInfo);
			}
			num += this.rogueWeeklyAwards_.CalculateSize(RogueWeeklyData._repeated_rogueWeeklyAwards_codec);
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.CurWorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWorldLevel);
			}
			if (this.UseFreeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseFreeCount);
			}
			if (this.MaxFreeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxFreeCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060162D3 RID: 90835 RVA: 0x00338AA0 File Offset: 0x00336CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CycleId != 0)
			{
				this.CycleId = other.CycleId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.rogueWeeklyLastInfo_ != null)
			{
				if (this.rogueWeeklyLastInfo_ == null)
				{
					this.RogueWeeklyLastInfo = new RogueWeeklyLastInfo();
				}
				this.RogueWeeklyLastInfo.MergeFrom(other.RogueWeeklyLastInfo);
			}
			this.rogueWeeklyAwards_.Add(other.rogueWeeklyAwards_);
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.CurWorldLevel != 0)
			{
				this.CurWorldLevel = other.CurWorldLevel;
			}
			if (other.UseFreeCount != 0)
			{
				this.UseFreeCount = other.UseFreeCount;
			}
			if (other.MaxFreeCount != 0)
			{
				this.MaxFreeCount = other.MaxFreeCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060162D4 RID: 90836 RVA: 0x00338B7D File Offset: 0x00336D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162D5 RID: 90837 RVA: 0x00338B88 File Offset: 0x00336D88
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
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.CycleId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Score = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.rogueWeeklyLastInfo_ == null)
							{
								this.RogueWeeklyLastInfo = new RogueWeeklyLastInfo();
							}
							input.ReadMessage(this.RogueWeeklyLastInfo);
							continue;
						}
						if (num == 34U)
						{
							this.rogueWeeklyAwards_.AddEntriesFrom(ref input, RogueWeeklyData._repeated_rogueWeeklyAwards_codec);
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CurWorldLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.UseFreeCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.MaxFreeCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040084AD RID: 33965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084AE RID: 33966
		public const int CycleIdFieldNumber = 1;

		// Token: 0x040084AF RID: 33967
		private int cycleId_;

		// Token: 0x040084B0 RID: 33968
		public const int ScoreFieldNumber = 2;

		// Token: 0x040084B1 RID: 33969
		private int score_;

		// Token: 0x040084B2 RID: 33970
		public const int RogueWeeklyLastInfoFieldNumber = 3;

		// Token: 0x040084B3 RID: 33971
		private RogueWeeklyLastInfo rogueWeeklyLastInfo_;

		// Token: 0x040084B4 RID: 33972
		public const int RogueWeeklyAwardsFieldNumber = 4;

		// Token: 0x040084B5 RID: 33973
		private static readonly FieldCodec<RogueWeeklyAward> _repeated_rogueWeeklyAwards_codec = FieldCodec.ForMessage<RogueWeeklyAward>(34U, RogueWeeklyAward.Parser);

		// Token: 0x040084B6 RID: 33974
		private readonly RepeatedField<RogueWeeklyAward> rogueWeeklyAwards_ = new RepeatedField<RogueWeeklyAward>();

		// Token: 0x040084B7 RID: 33975
		public const int MaxScoreFieldNumber = 7;

		// Token: 0x040084B8 RID: 33976
		private int maxScore_;

		// Token: 0x040084B9 RID: 33977
		public const int CurWorldLevelFieldNumber = 8;

		// Token: 0x040084BA RID: 33978
		private int curWorldLevel_;

		// Token: 0x040084BB RID: 33979
		public const int UseFreeCountFieldNumber = 9;

		// Token: 0x040084BC RID: 33980
		private int useFreeCount_;

		// Token: 0x040084BD RID: 33981
		public const int MaxFreeCountFieldNumber = 10;

		// Token: 0x040084BE RID: 33982
		private int maxFreeCount_;
	}
}
