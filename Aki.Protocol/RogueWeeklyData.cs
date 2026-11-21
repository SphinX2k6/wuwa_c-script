using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001025 RID: 4133
	public sealed class RogueWeeklyData : IMessage<RogueWeeklyData>, IMessage, IEquatable<RogueWeeklyData>, IDeepCloneable<RogueWeeklyData>, IBufferMessage
	{
		// Token: 0x060161D2 RID: 90578 RVA: 0x00336EFF File Offset: 0x003350FF
		[NullableContext(1)]
		public static RogueWeeklyData Create()
		{
			return new RogueWeeklyData();
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x060161D3 RID: 90579 RVA: 0x00336F06 File Offset: 0x00335106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049EE RID: 18926
		// (get) Token: 0x060161D4 RID: 90580 RVA: 0x00336F09 File Offset: 0x00335109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyData.Descriptor;
			}
		}

		// Token: 0x060161D5 RID: 90581 RVA: 0x00336F10 File Offset: 0x00335110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyData()
		{
		}

		// Token: 0x060161D6 RID: 90582 RVA: 0x00336F24 File Offset: 0x00335124
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

		// Token: 0x060161D7 RID: 90583 RVA: 0x00336FBD File Offset: 0x003351BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyData Clone()
		{
			return new RogueWeeklyData(this);
		}

		// Token: 0x170049EF RID: 18927
		// (get) Token: 0x060161D8 RID: 90584 RVA: 0x00336FC5 File Offset: 0x003351C5
		// (set) Token: 0x060161D9 RID: 90585 RVA: 0x00336FCD File Offset: 0x003351CD
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

		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x060161DA RID: 90586 RVA: 0x00336FD6 File Offset: 0x003351D6
		// (set) Token: 0x060161DB RID: 90587 RVA: 0x00336FDE File Offset: 0x003351DE
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

		// Token: 0x170049F1 RID: 18929
		// (get) Token: 0x060161DC RID: 90588 RVA: 0x00336FE7 File Offset: 0x003351E7
		// (set) Token: 0x060161DD RID: 90589 RVA: 0x00336FEF File Offset: 0x003351EF
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

		// Token: 0x170049F2 RID: 18930
		// (get) Token: 0x060161DE RID: 90590 RVA: 0x00336FF8 File Offset: 0x003351F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueWeeklyAward> RogueWeeklyAwards
		{
			get
			{
				return this.rogueWeeklyAwards_;
			}
		}

		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x060161DF RID: 90591 RVA: 0x00337000 File Offset: 0x00335200
		// (set) Token: 0x060161E0 RID: 90592 RVA: 0x00337008 File Offset: 0x00335208
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

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x060161E1 RID: 90593 RVA: 0x00337011 File Offset: 0x00335211
		// (set) Token: 0x060161E2 RID: 90594 RVA: 0x00337019 File Offset: 0x00335219
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

		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x060161E3 RID: 90595 RVA: 0x00337022 File Offset: 0x00335222
		// (set) Token: 0x060161E4 RID: 90596 RVA: 0x0033702A File Offset: 0x0033522A
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

		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x060161E5 RID: 90597 RVA: 0x00337033 File Offset: 0x00335233
		// (set) Token: 0x060161E6 RID: 90598 RVA: 0x0033703B File Offset: 0x0033523B
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

		// Token: 0x060161E7 RID: 90599 RVA: 0x00337044 File Offset: 0x00335244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyData);
		}

		// Token: 0x060161E8 RID: 90600 RVA: 0x00337054 File Offset: 0x00335254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyData other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && this.Score == other.Score && object.Equals(this.RogueWeeklyLastInfo, other.RogueWeeklyLastInfo) && this.rogueWeeklyAwards_.Equals(other.rogueWeeklyAwards_) && this.MaxScore == other.MaxScore && this.CurWorldLevel == other.CurWorldLevel && this.UseFreeCount == other.UseFreeCount && this.MaxFreeCount == other.MaxFreeCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060161E9 RID: 90601 RVA: 0x00337108 File Offset: 0x00335308
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

		// Token: 0x060161EA RID: 90602 RVA: 0x003371E8 File Offset: 0x003353E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060161EB RID: 90603 RVA: 0x003371F5 File Offset: 0x003353F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060161EC RID: 90604 RVA: 0x00337200 File Offset: 0x00335400
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

		// Token: 0x060161ED RID: 90605 RVA: 0x003372F8 File Offset: 0x003354F8
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

		// Token: 0x060161EE RID: 90606 RVA: 0x003373DC File Offset: 0x003355DC
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

		// Token: 0x060161EF RID: 90607 RVA: 0x003374B9 File Offset: 0x003356B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060161F0 RID: 90608 RVA: 0x003374C4 File Offset: 0x003356C4
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

		// Token: 0x040084D7 RID: 34007
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084D8 RID: 34008
		public const int CycleIdFieldNumber = 1;

		// Token: 0x040084D9 RID: 34009
		private int cycleId_;

		// Token: 0x040084DA RID: 34010
		public const int ScoreFieldNumber = 2;

		// Token: 0x040084DB RID: 34011
		private int score_;

		// Token: 0x040084DC RID: 34012
		public const int RogueWeeklyLastInfoFieldNumber = 3;

		// Token: 0x040084DD RID: 34013
		private RogueWeeklyLastInfo rogueWeeklyLastInfo_;

		// Token: 0x040084DE RID: 34014
		public const int RogueWeeklyAwardsFieldNumber = 4;

		// Token: 0x040084DF RID: 34015
		private static readonly FieldCodec<RogueWeeklyAward> _repeated_rogueWeeklyAwards_codec = FieldCodec.ForMessage<RogueWeeklyAward>(34U, RogueWeeklyAward.Parser);

		// Token: 0x040084E0 RID: 34016
		private readonly RepeatedField<RogueWeeklyAward> rogueWeeklyAwards_ = new RepeatedField<RogueWeeklyAward>();

		// Token: 0x040084E1 RID: 34017
		public const int MaxScoreFieldNumber = 7;

		// Token: 0x040084E2 RID: 34018
		private int maxScore_;

		// Token: 0x040084E3 RID: 34019
		public const int CurWorldLevelFieldNumber = 8;

		// Token: 0x040084E4 RID: 34020
		private int curWorldLevel_;

		// Token: 0x040084E5 RID: 34021
		public const int UseFreeCountFieldNumber = 9;

		// Token: 0x040084E6 RID: 34022
		private int useFreeCount_;

		// Token: 0x040084E7 RID: 34023
		public const int MaxFreeCountFieldNumber = 10;

		// Token: 0x040084E8 RID: 34024
		private int maxFreeCount_;
	}
}
