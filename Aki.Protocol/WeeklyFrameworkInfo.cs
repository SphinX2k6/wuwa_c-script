using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001580 RID: 5504
	public sealed class WeeklyFrameworkInfo : IMessage<WeeklyFrameworkInfo>, IMessage, IEquatable<WeeklyFrameworkInfo>, IDeepCloneable<WeeklyFrameworkInfo>, IBufferMessage
	{
		// Token: 0x0601D23F RID: 119359 RVA: 0x00438335 File Offset: 0x00436535
		[NullableContext(1)]
		public static WeeklyFrameworkInfo Create()
		{
			return new WeeklyFrameworkInfo();
		}

		// Token: 0x17006297 RID: 25239
		// (get) Token: 0x0601D240 RID: 119360 RVA: 0x0043833C File Offset: 0x0043653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006298 RID: 25240
		// (get) Token: 0x0601D241 RID: 119361 RVA: 0x0043833F File Offset: 0x0043653F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkInfo.Descriptor;
			}
		}

		// Token: 0x0601D242 RID: 119362 RVA: 0x00438346 File Offset: 0x00436546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo()
		{
		}

		// Token: 0x0601D243 RID: 119363 RVA: 0x00438364 File Offset: 0x00436564
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

		// Token: 0x0601D244 RID: 119364 RVA: 0x004383DA File Offset: 0x004365DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo Clone()
		{
			return new WeeklyFrameworkInfo(this);
		}

		// Token: 0x17006299 RID: 25241
		// (get) Token: 0x0601D245 RID: 119365 RVA: 0x004383E2 File Offset: 0x004365E2
		// (set) Token: 0x0601D246 RID: 119366 RVA: 0x004383EA File Offset: 0x004365EA
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

		// Token: 0x1700629A RID: 25242
		// (get) Token: 0x0601D247 RID: 119367 RVA: 0x004383F3 File Offset: 0x004365F3
		// (set) Token: 0x0601D248 RID: 119368 RVA: 0x004383FB File Offset: 0x004365FB
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

		// Token: 0x1700629B RID: 25243
		// (get) Token: 0x0601D249 RID: 119369 RVA: 0x00438404 File Offset: 0x00436604
		// (set) Token: 0x0601D24A RID: 119370 RVA: 0x0043840C File Offset: 0x0043660C
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

		// Token: 0x1700629C RID: 25244
		// (get) Token: 0x0601D24B RID: 119371 RVA: 0x00438415 File Offset: 0x00436615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTasks
		{
			get
			{
				return this.scoreTasks_;
			}
		}

		// Token: 0x1700629D RID: 25245
		// (get) Token: 0x0601D24C RID: 119372 RVA: 0x0043841D File Offset: 0x0043661D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeeklyPlayData> WeeklyPlayDatas
		{
			get
			{
				return this.weeklyPlayDatas_;
			}
		}

		// Token: 0x1700629E RID: 25246
		// (get) Token: 0x0601D24D RID: 119373 RVA: 0x00438425 File Offset: 0x00436625
		// (set) Token: 0x0601D24E RID: 119374 RVA: 0x0043842D File Offset: 0x0043662D
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

		// Token: 0x0601D24F RID: 119375 RVA: 0x00438436 File Offset: 0x00436636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkInfo);
		}

		// Token: 0x0601D250 RID: 119376 RVA: 0x00438444 File Offset: 0x00436644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.scoreTasks_.Equals(other.scoreTasks_) && this.weeklyPlayDatas_.Equals(other.weeklyPlayDatas_) && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D251 RID: 119377 RVA: 0x004384D8 File Offset: 0x004366D8
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

		// Token: 0x0601D252 RID: 119378 RVA: 0x0043857E File Offset: 0x0043677E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D253 RID: 119379 RVA: 0x0043858B File Offset: 0x0043678B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D254 RID: 119380 RVA: 0x00438594 File Offset: 0x00436794
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

		// Token: 0x0601D255 RID: 119381 RVA: 0x00438648 File Offset: 0x00436848
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

		// Token: 0x0601D256 RID: 119382 RVA: 0x004386F4 File Offset: 0x004368F4
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

		// Token: 0x0601D257 RID: 119383 RVA: 0x0043878E File Offset: 0x0043698E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D258 RID: 119384 RVA: 0x00438798 File Offset: 0x00436998
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

		// Token: 0x0400A749 RID: 42825
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A74A RID: 42826
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A74B RID: 42827
		private int configId_;

		// Token: 0x0400A74C RID: 42828
		public const int BeginTimeFieldNumber = 3;

		// Token: 0x0400A74D RID: 42829
		private long beginTime_;

		// Token: 0x0400A74E RID: 42830
		public const int EndTimeFieldNumber = 4;

		// Token: 0x0400A74F RID: 42831
		private long endTime_;

		// Token: 0x0400A750 RID: 42832
		public const int ScoreTasksFieldNumber = 5;

		// Token: 0x0400A751 RID: 42833
		private static readonly FieldCodec<int> _repeated_scoreTasks_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400A752 RID: 42834
		private readonly RepeatedField<int> scoreTasks_ = new RepeatedField<int>();

		// Token: 0x0400A753 RID: 42835
		public const int WeeklyPlayDatasFieldNumber = 6;

		// Token: 0x0400A754 RID: 42836
		private static readonly FieldCodec<WeeklyPlayData> _repeated_weeklyPlayDatas_codec = FieldCodec.ForMessage<WeeklyPlayData>(50U, WeeklyPlayData.Parser);

		// Token: 0x0400A755 RID: 42837
		private readonly RepeatedField<WeeklyPlayData> weeklyPlayDatas_ = new RepeatedField<WeeklyPlayData>();

		// Token: 0x0400A756 RID: 42838
		public const int WorldLevelFieldNumber = 7;

		// Token: 0x0400A757 RID: 42839
		private int worldLevel_;
	}
}
