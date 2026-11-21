using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BED RID: 3053
	public sealed class PbBattlePass : IMessage<PbBattlePass>, IMessage, IEquatable<PbBattlePass>, IDeepCloneable<PbBattlePass>, IBufferMessage
	{
		// Token: 0x06010981 RID: 67969 RVA: 0x0026E67A File Offset: 0x0026C87A
		[NullableContext(1)]
		public static PbBattlePass Create()
		{
			return new PbBattlePass();
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x06010982 RID: 67970 RVA: 0x0026E681 File Offset: 0x0026C881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x06010983 RID: 67971 RVA: 0x0026E684 File Offset: 0x0026C884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbBattlePass.Descriptor;
			}
		}

		// Token: 0x06010984 RID: 67972 RVA: 0x0026E68B File Offset: 0x0026C88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePass()
		{
		}

		// Token: 0x06010985 RID: 67973 RVA: 0x0026E6AC File Offset: 0x0026C8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePass(PbBattlePass other) : this()
		{
			this.inTimeRange_ = other.inTimeRange_;
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.weeklyTotalExp_ = other.weeklyTotalExp_;
			this.payStatus_ = other.payStatus_;
			this.takenRewards_ = other.takenRewards_.Clone();
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.recurringRewards_ = other.recurringRewards_.Clone();
			this.hadEnter_ = other.hadEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010986 RID: 67974 RVA: 0x0026E75E File Offset: 0x0026C95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePass Clone()
		{
			return new PbBattlePass(this);
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x06010987 RID: 67975 RVA: 0x0026E766 File Offset: 0x0026C966
		// (set) Token: 0x06010988 RID: 67976 RVA: 0x0026E76E File Offset: 0x0026C96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InTimeRange
		{
			get
			{
				return this.inTimeRange_;
			}
			set
			{
				this.inTimeRange_ = value;
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x06010989 RID: 67977 RVA: 0x0026E777 File Offset: 0x0026C977
		// (set) Token: 0x0601098A RID: 67978 RVA: 0x0026E77F File Offset: 0x0026C97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0601098B RID: 67979 RVA: 0x0026E788 File Offset: 0x0026C988
		// (set) Token: 0x0601098C RID: 67980 RVA: 0x0026E790 File Offset: 0x0026C990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0601098D RID: 67981 RVA: 0x0026E799 File Offset: 0x0026C999
		// (set) Token: 0x0601098E RID: 67982 RVA: 0x0026E7A1 File Offset: 0x0026C9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0601098F RID: 67983 RVA: 0x0026E7AA File Offset: 0x0026C9AA
		// (set) Token: 0x06010990 RID: 67984 RVA: 0x0026E7B2 File Offset: 0x0026C9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeeklyTotalExp
		{
			get
			{
				return this.weeklyTotalExp_;
			}
			set
			{
				this.weeklyTotalExp_ = value;
			}
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x06010991 RID: 67985 RVA: 0x0026E7BB File Offset: 0x0026C9BB
		// (set) Token: 0x06010992 RID: 67986 RVA: 0x0026E7C3 File Offset: 0x0026C9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPayStatus PayStatus
		{
			get
			{
				return this.payStatus_;
			}
			set
			{
				this.payStatus_ = value;
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x06010993 RID: 67987 RVA: 0x0026E7CC File Offset: 0x0026C9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassReward> TakenRewards
		{
			get
			{
				return this.takenRewards_;
			}
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x06010994 RID: 67988 RVA: 0x0026E7D4 File Offset: 0x0026C9D4
		// (set) Token: 0x06010995 RID: 67989 RVA: 0x0026E7DC File Offset: 0x0026C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x06010996 RID: 67990 RVA: 0x0026E7E5 File Offset: 0x0026C9E5
		// (set) Token: 0x06010997 RID: 67991 RVA: 0x0026E7ED File Offset: 0x0026C9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x06010998 RID: 67992 RVA: 0x0026E7F6 File Offset: 0x0026C9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassRecurringReward> RecurringRewards
		{
			get
			{
				return this.recurringRewards_;
			}
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x06010999 RID: 67993 RVA: 0x0026E7FE File Offset: 0x0026C9FE
		// (set) Token: 0x0601099A RID: 67994 RVA: 0x0026E806 File Offset: 0x0026CA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HadEnter
		{
			get
			{
				return this.hadEnter_;
			}
			set
			{
				this.hadEnter_ = value;
			}
		}

		// Token: 0x0601099B RID: 67995 RVA: 0x0026E80F File Offset: 0x0026CA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbBattlePass);
		}

		// Token: 0x0601099C RID: 67996 RVA: 0x0026E820 File Offset: 0x0026CA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbBattlePass other)
		{
			return other != null && (other == this || (this.InTimeRange == other.InTimeRange && this.Id == other.Id && this.Level == other.Level && this.Exp == other.Exp && this.WeeklyTotalExp == other.WeeklyTotalExp && this.PayStatus == other.PayStatus && this.takenRewards_.Equals(other.takenRewards_) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.recurringRewards_.Equals(other.recurringRewards_) && this.HadEnter == other.HadEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601099D RID: 67997 RVA: 0x0026E904 File Offset: 0x0026CB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InTimeRange)
			{
				num ^= this.InTimeRange.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.WeeklyTotalExp != 0)
			{
				num ^= this.WeeklyTotalExp.GetHashCode();
			}
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				num ^= this.PayStatus.GetHashCode();
			}
			num ^= this.takenRewards_.GetHashCode();
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.recurringRewards_.GetHashCode();
			if (this.HadEnter)
			{
				num ^= this.HadEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601099E RID: 67998 RVA: 0x0026EA2F File Offset: 0x0026CC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601099F RID: 67999 RVA: 0x0026EA3C File Offset: 0x0026CC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060109A0 RID: 68000 RVA: 0x0026EA48 File Offset: 0x0026CC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InTimeRange)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.InTimeRange);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Exp);
			}
			if (this.WeeklyTotalExp != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WeeklyTotalExp);
			}
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.PayStatus);
			}
			this.takenRewards_.WriteTo(ref output, PbBattlePass._repeated_takenRewards_codec);
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EndTime);
			}
			this.recurringRewards_.WriteTo(ref output, PbBattlePass._repeated_recurringRewards_codec);
			if (this.HadEnter)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.HadEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060109A1 RID: 68001 RVA: 0x0026EB88 File Offset: 0x0026CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InTimeRange)
			{
				num += 2;
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.WeeklyTotalExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeeklyTotalExp);
			}
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PayStatus);
			}
			num += this.takenRewards_.CalculateSize(PbBattlePass._repeated_takenRewards_codec);
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.recurringRewards_.CalculateSize(PbBattlePass._repeated_recurringRewards_codec);
			if (this.HadEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060109A2 RID: 68002 RVA: 0x0026EC94 File Offset: 0x0026CE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbBattlePass other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InTimeRange)
			{
				this.InTimeRange = other.InTimeRange;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.WeeklyTotalExp != 0)
			{
				this.WeeklyTotalExp = other.WeeklyTotalExp;
			}
			if (other.PayStatus != BattlePassPayStatus.NoPaid)
			{
				this.PayStatus = other.PayStatus;
			}
			this.takenRewards_.Add(other.takenRewards_);
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.recurringRewards_.Add(other.recurringRewards_);
			if (other.HadEnter)
			{
				this.HadEnter = other.HadEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060109A3 RID: 68003 RVA: 0x0026ED92 File Offset: 0x0026CF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060109A4 RID: 68004 RVA: 0x0026ED9C File Offset: 0x0026CF9C
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
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.InTimeRange = input.ReadBool();
							continue;
						}
						if (num == 16U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Exp = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.WeeklyTotalExp = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.PayStatus = (BattlePassPayStatus)input.ReadEnum();
						continue;
					}
					if (num == 58U)
					{
						this.takenRewards_.AddEntriesFrom(ref input, PbBattlePass._repeated_takenRewards_codec);
						continue;
					}
					if (num == 64U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 82U)
					{
						this.recurringRewards_.AddEntriesFrom(ref input, PbBattlePass._repeated_recurringRewards_codec);
						continue;
					}
					if (num == 88U)
					{
						this.HadEnter = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040069F0 RID: 27120
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069F1 RID: 27121
		public const int InTimeRangeFieldNumber = 1;

		// Token: 0x040069F2 RID: 27122
		private bool inTimeRange_;

		// Token: 0x040069F3 RID: 27123
		public const int IdFieldNumber = 2;

		// Token: 0x040069F4 RID: 27124
		private int id_;

		// Token: 0x040069F5 RID: 27125
		public const int LevelFieldNumber = 3;

		// Token: 0x040069F6 RID: 27126
		private int level_;

		// Token: 0x040069F7 RID: 27127
		public const int ExpFieldNumber = 4;

		// Token: 0x040069F8 RID: 27128
		private int exp_;

		// Token: 0x040069F9 RID: 27129
		public const int WeeklyTotalExpFieldNumber = 5;

		// Token: 0x040069FA RID: 27130
		private int weeklyTotalExp_;

		// Token: 0x040069FB RID: 27131
		public const int PayStatusFieldNumber = 6;

		// Token: 0x040069FC RID: 27132
		private BattlePassPayStatus payStatus_;

		// Token: 0x040069FD RID: 27133
		public const int TakenRewardsFieldNumber = 7;

		// Token: 0x040069FE RID: 27134
		private static readonly FieldCodec<PbBattlePassReward> _repeated_takenRewards_codec = FieldCodec.ForMessage<PbBattlePassReward>(58U, PbBattlePassReward.Parser);

		// Token: 0x040069FF RID: 27135
		private readonly RepeatedField<PbBattlePassReward> takenRewards_ = new RepeatedField<PbBattlePassReward>();

		// Token: 0x04006A00 RID: 27136
		public const int BeginTimeFieldNumber = 8;

		// Token: 0x04006A01 RID: 27137
		private long beginTime_;

		// Token: 0x04006A02 RID: 27138
		public const int EndTimeFieldNumber = 9;

		// Token: 0x04006A03 RID: 27139
		private long endTime_;

		// Token: 0x04006A04 RID: 27140
		public const int RecurringRewardsFieldNumber = 10;

		// Token: 0x04006A05 RID: 27141
		private static readonly FieldCodec<PbBattlePassRecurringReward> _repeated_recurringRewards_codec = FieldCodec.ForMessage<PbBattlePassRecurringReward>(82U, PbBattlePassRecurringReward.Parser);

		// Token: 0x04006A06 RID: 27142
		private readonly RepeatedField<PbBattlePassRecurringReward> recurringRewards_ = new RepeatedField<PbBattlePassRecurringReward>();

		// Token: 0x04006A07 RID: 27143
		public const int HadEnterFieldNumber = 11;

		// Token: 0x04006A08 RID: 27144
		private bool hadEnter_;
	}
}
