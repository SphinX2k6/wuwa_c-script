using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150A RID: 5386
	public sealed class WeeklyFrameworkInfo : IMessage<WeeklyFrameworkInfo>, IMessage, IEquatable<WeeklyFrameworkInfo>, IDeepCloneable<WeeklyFrameworkInfo>, IBufferMessage
	{
		// Token: 0x0601C778 RID: 116600 RVA: 0x0041C875 File Offset: 0x0041AA75
		[NullableContext(1)]
		public static WeeklyFrameworkInfo Create()
		{
			return new WeeklyFrameworkInfo();
		}

		// Token: 0x17005FF6 RID: 24566
		// (get) Token: 0x0601C779 RID: 116601 RVA: 0x0041C87C File Offset: 0x0041AA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FF7 RID: 24567
		// (get) Token: 0x0601C77A RID: 116602 RVA: 0x0041C87F File Offset: 0x0041AA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkInfo.Descriptor;
			}
		}

		// Token: 0x0601C77B RID: 116603 RVA: 0x0041C886 File Offset: 0x0041AA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo()
		{
		}

		// Token: 0x0601C77C RID: 116604 RVA: 0x0041C8A4 File Offset: 0x0041AAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo(WeeklyFrameworkInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.scoreTasks_ = other.scoreTasks_.Clone();
			this.weeklyPlayDatas_ = other.weeklyPlayDatas_.Clone();
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C77D RID: 116605 RVA: 0x0041C91A File Offset: 0x0041AB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo Clone()
		{
			return new WeeklyFrameworkInfo(this);
		}

		// Token: 0x17005FF8 RID: 24568
		// (get) Token: 0x0601C77E RID: 116606 RVA: 0x0041C922 File Offset: 0x0041AB22
		// (set) Token: 0x0601C77F RID: 116607 RVA: 0x0041C92A File Offset: 0x0041AB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005FF9 RID: 24569
		// (get) Token: 0x0601C780 RID: 116608 RVA: 0x0041C933 File Offset: 0x0041AB33
		// (set) Token: 0x0601C781 RID: 116609 RVA: 0x0041C93B File Offset: 0x0041AB3B
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

		// Token: 0x17005FFA RID: 24570
		// (get) Token: 0x0601C782 RID: 116610 RVA: 0x0041C944 File Offset: 0x0041AB44
		// (set) Token: 0x0601C783 RID: 116611 RVA: 0x0041C94C File Offset: 0x0041AB4C
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

		// Token: 0x17005FFB RID: 24571
		// (get) Token: 0x0601C784 RID: 116612 RVA: 0x0041C955 File Offset: 0x0041AB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTasks
		{
			get
			{
				return this.scoreTasks_;
			}
		}

		// Token: 0x17005FFC RID: 24572
		// (get) Token: 0x0601C785 RID: 116613 RVA: 0x0041C95D File Offset: 0x0041AB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeeklyPlayData> WeeklyPlayDatas
		{
			get
			{
				return this.weeklyPlayDatas_;
			}
		}

		// Token: 0x17005FFD RID: 24573
		// (get) Token: 0x0601C786 RID: 116614 RVA: 0x0041C965 File Offset: 0x0041AB65
		// (set) Token: 0x0601C787 RID: 116615 RVA: 0x0041C96D File Offset: 0x0041AB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x0601C788 RID: 116616 RVA: 0x0041C976 File Offset: 0x0041AB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkInfo);
		}

		// Token: 0x0601C789 RID: 116617 RVA: 0x0041C984 File Offset: 0x0041AB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.scoreTasks_.Equals(other.scoreTasks_) && this.weeklyPlayDatas_.Equals(other.weeklyPlayDatas_) && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C78A RID: 116618 RVA: 0x0041CA18 File Offset: 0x0041AC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.scoreTasks_.GetHashCode();
			num ^= this.weeklyPlayDatas_.GetHashCode();
			if (this.WorldLevel != 0)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C78B RID: 116619 RVA: 0x0041CABE File Offset: 0x0041ACBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C78C RID: 116620 RVA: 0x0041CACB File Offset: 0x0041ACCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C78D RID: 116621 RVA: 0x0041CAD4 File Offset: 0x0041ACD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EndTime);
			}
			this.scoreTasks_.WriteTo(ref output, WeeklyFrameworkInfo._repeated_scoreTasks_codec);
			this.weeklyPlayDatas_.WriteTo(ref output, WeeklyFrameworkInfo._repeated_weeklyPlayDatas_codec);
			if (this.WorldLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C78E RID: 116622 RVA: 0x0041CB88 File Offset: 0x0041AD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.scoreTasks_.CalculateSize(WeeklyFrameworkInfo._repeated_scoreTasks_codec);
			num += this.weeklyPlayDatas_.CalculateSize(WeeklyFrameworkInfo._repeated_weeklyPlayDatas_codec);
			if (this.WorldLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C78F RID: 116623 RVA: 0x0041CC34 File Offset: 0x0041AE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.scoreTasks_.Add(other.scoreTasks_);
			this.weeklyPlayDatas_.Add(other.weeklyPlayDatas_);
			if (other.WorldLevel != 0)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C790 RID: 116624 RVA: 0x0041CCCE File Offset: 0x0041AECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C791 RID: 116625 RVA: 0x0041CCD8 File Offset: 0x0041AED8
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
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.scoreTasks_.AddEntriesFrom(ref input, WeeklyFrameworkInfo._repeated_scoreTasks_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.weeklyPlayDatas_.AddEntriesFrom(ref input, WeeklyFrameworkInfo._repeated_weeklyPlayDatas_codec);
						continue;
					}
					if (num == 56U)
					{
						this.WorldLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A2F0 RID: 41712
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2F1 RID: 41713
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A2F2 RID: 41714
		private int configId_;

		// Token: 0x0400A2F3 RID: 41715
		public const int BeginTimeFieldNumber = 3;

		// Token: 0x0400A2F4 RID: 41716
		private long beginTime_;

		// Token: 0x0400A2F5 RID: 41717
		public const int EndTimeFieldNumber = 4;

		// Token: 0x0400A2F6 RID: 41718
		private long endTime_;

		// Token: 0x0400A2F7 RID: 41719
		public const int ScoreTasksFieldNumber = 5;

		// Token: 0x0400A2F8 RID: 41720
		private static readonly FieldCodec<int> _repeated_scoreTasks_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400A2F9 RID: 41721
		private readonly RepeatedField<int> scoreTasks_ = new RepeatedField<int>();

		// Token: 0x0400A2FA RID: 41722
		public const int WeeklyPlayDatasFieldNumber = 6;

		// Token: 0x0400A2FB RID: 41723
		private static readonly FieldCodec<WeeklyPlayData> _repeated_weeklyPlayDatas_codec = FieldCodec.ForMessage<WeeklyPlayData>(50U, WeeklyPlayData.Parser);

		// Token: 0x0400A2FC RID: 41724
		private readonly RepeatedField<WeeklyPlayData> weeklyPlayDatas_ = new RepeatedField<WeeklyPlayData>();

		// Token: 0x0400A2FD RID: 41725
		public const int WorldLevelFieldNumber = 7;

		// Token: 0x0400A2FE RID: 41726
		private int worldLevel_;
	}
}
