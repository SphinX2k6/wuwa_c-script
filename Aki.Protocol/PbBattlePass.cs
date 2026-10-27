using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFD RID: 3069
	public sealed class PbBattlePass : IMessage<PbBattlePass>, IMessage, IEquatable<PbBattlePass>, IDeepCloneable<PbBattlePass>, IBufferMessage
	{
		// Token: 0x06010A81 RID: 68225 RVA: 0x002703E2 File Offset: 0x0026E5E2
		[NullableContext(1)]
		public static PbBattlePass Create()
		{
			return new PbBattlePass();
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x06010A82 RID: 68226 RVA: 0x002703E9 File Offset: 0x0026E5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x06010A83 RID: 68227 RVA: 0x002703EC File Offset: 0x0026E5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbBattlePass.Descriptor;
			}
		}

		// Token: 0x06010A84 RID: 68228 RVA: 0x002703F3 File Offset: 0x0026E5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePass()
		{
		}

		// Token: 0x06010A85 RID: 68229 RVA: 0x00270414 File Offset: 0x0026E614
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

		// Token: 0x06010A86 RID: 68230 RVA: 0x002704C6 File Offset: 0x0026E6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePass Clone()
		{
			return new PbBattlePass(this);
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x06010A87 RID: 68231 RVA: 0x002704CE File Offset: 0x0026E6CE
		// (set) Token: 0x06010A88 RID: 68232 RVA: 0x002704D6 File Offset: 0x0026E6D6
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

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x06010A89 RID: 68233 RVA: 0x002704DF File Offset: 0x0026E6DF
		// (set) Token: 0x06010A8A RID: 68234 RVA: 0x002704E7 File Offset: 0x0026E6E7
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

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x06010A8B RID: 68235 RVA: 0x002704F0 File Offset: 0x0026E6F0
		// (set) Token: 0x06010A8C RID: 68236 RVA: 0x002704F8 File Offset: 0x0026E6F8
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

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x06010A8D RID: 68237 RVA: 0x00270501 File Offset: 0x0026E701
		// (set) Token: 0x06010A8E RID: 68238 RVA: 0x00270509 File Offset: 0x0026E709
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

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x06010A8F RID: 68239 RVA: 0x00270512 File Offset: 0x0026E712
		// (set) Token: 0x06010A90 RID: 68240 RVA: 0x0027051A File Offset: 0x0026E71A
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

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x06010A91 RID: 68241 RVA: 0x00270523 File Offset: 0x0026E723
		// (set) Token: 0x06010A92 RID: 68242 RVA: 0x0027052B File Offset: 0x0026E72B
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

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x06010A93 RID: 68243 RVA: 0x00270534 File Offset: 0x0026E734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassReward> TakenRewards
		{
			get
			{
				return this.takenRewards_;
			}
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x06010A94 RID: 68244 RVA: 0x0027053C File Offset: 0x0026E73C
		// (set) Token: 0x06010A95 RID: 68245 RVA: 0x00270544 File Offset: 0x0026E744
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

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x06010A96 RID: 68246 RVA: 0x0027054D File Offset: 0x0026E74D
		// (set) Token: 0x06010A97 RID: 68247 RVA: 0x00270555 File Offset: 0x0026E755
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

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x06010A98 RID: 68248 RVA: 0x0027055E File Offset: 0x0026E75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassRecurringReward> RecurringRewards
		{
			get
			{
				return this.recurringRewards_;
			}
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x06010A99 RID: 68249 RVA: 0x00270566 File Offset: 0x0026E766
		// (set) Token: 0x06010A9A RID: 68250 RVA: 0x0027056E File Offset: 0x0026E76E
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

		// Token: 0x06010A9B RID: 68251 RVA: 0x00270577 File Offset: 0x0026E777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbBattlePass);
		}

		// Token: 0x06010A9C RID: 68252 RVA: 0x00270588 File Offset: 0x0026E788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbBattlePass other)
		{
			return other != null && (other == this || (this.InTimeRange == other.InTimeRange && this.Id == other.Id && this.Level == other.Level && this.Exp == other.Exp && this.WeeklyTotalExp == other.WeeklyTotalExp && this.PayStatus == other.PayStatus && this.takenRewards_.Equals(other.takenRewards_) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.recurringRewards_.Equals(other.recurringRewards_) && this.HadEnter == other.HadEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A9D RID: 68253 RVA: 0x0027066C File Offset: 0x0026E86C
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

		// Token: 0x06010A9E RID: 68254 RVA: 0x00270797 File Offset: 0x0026E997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A9F RID: 68255 RVA: 0x002707A4 File Offset: 0x0026E9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010AA0 RID: 68256 RVA: 0x002707B0 File Offset: 0x0026E9B0
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

		// Token: 0x06010AA1 RID: 68257 RVA: 0x002708F0 File Offset: 0x0026EAF0
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

		// Token: 0x06010AA2 RID: 68258 RVA: 0x002709FC File Offset: 0x0026EBFC
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

		// Token: 0x06010AA3 RID: 68259 RVA: 0x00270AFA File Offset: 0x0026ECFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010AA4 RID: 68260 RVA: 0x00270B04 File Offset: 0x0026ED04
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

		// Token: 0x040069DC RID: 27100
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069DD RID: 27101
		public const int InTimeRangeFieldNumber = 1;

		// Token: 0x040069DE RID: 27102
		private bool inTimeRange_;

		// Token: 0x040069DF RID: 27103
		public const int IdFieldNumber = 2;

		// Token: 0x040069E0 RID: 27104
		private int id_;

		// Token: 0x040069E1 RID: 27105
		public const int LevelFieldNumber = 3;

		// Token: 0x040069E2 RID: 27106
		private int level_;

		// Token: 0x040069E3 RID: 27107
		public const int ExpFieldNumber = 4;

		// Token: 0x040069E4 RID: 27108
		private int exp_;

		// Token: 0x040069E5 RID: 27109
		public const int WeeklyTotalExpFieldNumber = 5;

		// Token: 0x040069E6 RID: 27110
		private int weeklyTotalExp_;

		// Token: 0x040069E7 RID: 27111
		public const int PayStatusFieldNumber = 6;

		// Token: 0x040069E8 RID: 27112
		private BattlePassPayStatus payStatus_;

		// Token: 0x040069E9 RID: 27113
		public const int TakenRewardsFieldNumber = 7;

		// Token: 0x040069EA RID: 27114
		private static readonly FieldCodec<PbBattlePassReward> _repeated_takenRewards_codec = FieldCodec.ForMessage<PbBattlePassReward>(58U, PbBattlePassReward.Parser);

		// Token: 0x040069EB RID: 27115
		private readonly RepeatedField<PbBattlePassReward> takenRewards_ = new RepeatedField<PbBattlePassReward>();

		// Token: 0x040069EC RID: 27116
		public const int BeginTimeFieldNumber = 8;

		// Token: 0x040069ED RID: 27117
		private long beginTime_;

		// Token: 0x040069EE RID: 27118
		public const int EndTimeFieldNumber = 9;

		// Token: 0x040069EF RID: 27119
		private long endTime_;

		// Token: 0x040069F0 RID: 27120
		public const int RecurringRewardsFieldNumber = 10;

		// Token: 0x040069F1 RID: 27121
		private static readonly FieldCodec<PbBattlePassRecurringReward> _repeated_recurringRewards_codec = FieldCodec.ForMessage<PbBattlePassRecurringReward>(82U, PbBattlePassRecurringReward.Parser);

		// Token: 0x040069F2 RID: 27122
		private readonly RepeatedField<PbBattlePassRecurringReward> recurringRewards_ = new RepeatedField<PbBattlePassRecurringReward>();

		// Token: 0x040069F3 RID: 27123
		public const int HadEnterFieldNumber = 11;

		// Token: 0x040069F4 RID: 27124
		private bool hadEnter_;
	}
}
