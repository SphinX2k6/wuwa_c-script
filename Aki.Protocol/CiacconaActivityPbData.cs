using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028C RID: 652
	public sealed class CiacconaActivityPbData : IMessage<CiacconaActivityPbData>, IMessage, IEquatable<CiacconaActivityPbData>, IDeepCloneable<CiacconaActivityPbData>, IBufferMessage
	{
		// Token: 0x0600440E RID: 17422 RVA: 0x000A6E82 File Offset: 0x000A5082
		[NullableContext(1)]
		public static CiacconaActivityPbData Create()
		{
			return new CiacconaActivityPbData();
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x000A6E89 File Offset: 0x000A5089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x000A6E8C File Offset: 0x000A508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaActivityPbData.Descriptor;
			}
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x000A6E93 File Offset: 0x000A5093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityPbData()
		{
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x000A6EBC File Offset: 0x000A50BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityPbData(CiacconaActivityPbData other) : this()
		{
			this.chapterDatas_ = other.chapterDatas_.Clone();
			this.scheduleRewardDatas_ = other.scheduleRewardDatas_.Clone();
			this.activityResultDatas_ = other.activityResultDatas_.Clone();
			this.inspirationData_ = ((other.inspirationData_ != null) ? other.inspirationData_.Clone() : null);
			this.state1Unlock_ = other.state1Unlock_;
			this.state2Unlock_ = other.state2Unlock_;
			this.limitedStartTime_ = other.limitedStartTime_;
			this.limitedEndTime_ = other.limitedEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x000A6F5F File Offset: 0x000A515F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityPbData Clone()
		{
			return new CiacconaActivityPbData(this);
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x000A6F67 File Offset: 0x000A5167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaChapterPbData> ChapterDatas
		{
			get
			{
				return this.chapterDatas_;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x000A6F6F File Offset: 0x000A516F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaScheduleRewardPbData> ScheduleRewardDatas
		{
			get
			{
				return this.scheduleRewardDatas_;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06004416 RID: 17430 RVA: 0x000A6F77 File Offset: 0x000A5177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaActivityResultPbData> ActivityResultDatas
		{
			get
			{
				return this.activityResultDatas_;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06004417 RID: 17431 RVA: 0x000A6F7F File Offset: 0x000A517F
		// (set) Token: 0x06004418 RID: 17432 RVA: 0x000A6F87 File Offset: 0x000A5187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaInspirationPbData InspirationData
		{
			get
			{
				return this.inspirationData_;
			}
			set
			{
				this.inspirationData_ = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x000A6F90 File Offset: 0x000A5190
		// (set) Token: 0x0600441A RID: 17434 RVA: 0x000A6F98 File Offset: 0x000A5198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool State1Unlock
		{
			get
			{
				return this.state1Unlock_;
			}
			set
			{
				this.state1Unlock_ = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x000A6FA1 File Offset: 0x000A51A1
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x000A6FA9 File Offset: 0x000A51A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool State2Unlock
		{
			get
			{
				return this.state2Unlock_;
			}
			set
			{
				this.state2Unlock_ = value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x000A6FB2 File Offset: 0x000A51B2
		// (set) Token: 0x0600441E RID: 17438 RVA: 0x000A6FBA File Offset: 0x000A51BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitedStartTime
		{
			get
			{
				return this.limitedStartTime_;
			}
			set
			{
				this.limitedStartTime_ = value;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x000A6FC3 File Offset: 0x000A51C3
		// (set) Token: 0x06004420 RID: 17440 RVA: 0x000A6FCB File Offset: 0x000A51CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitedEndTime
		{
			get
			{
				return this.limitedEndTime_;
			}
			set
			{
				this.limitedEndTime_ = value;
			}
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x000A6FD4 File Offset: 0x000A51D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaActivityPbData);
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x000A6FE4 File Offset: 0x000A51E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaActivityPbData other)
		{
			return other != null && (other == this || (this.chapterDatas_.Equals(other.chapterDatas_) && this.scheduleRewardDatas_.Equals(other.scheduleRewardDatas_) && this.activityResultDatas_.Equals(other.activityResultDatas_) && object.Equals(this.InspirationData, other.InspirationData) && this.State1Unlock == other.State1Unlock && this.State2Unlock == other.State2Unlock && this.LimitedStartTime == other.LimitedStartTime && this.LimitedEndTime == other.LimitedEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x000A70A4 File Offset: 0x000A52A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chapterDatas_.GetHashCode();
			num ^= this.scheduleRewardDatas_.GetHashCode();
			num ^= this.activityResultDatas_.GetHashCode();
			if (this.inspirationData_ != null)
			{
				num ^= this.InspirationData.GetHashCode();
			}
			if (this.State1Unlock)
			{
				num ^= this.State1Unlock.GetHashCode();
			}
			if (this.State2Unlock)
			{
				num ^= this.State2Unlock.GetHashCode();
			}
			if (this.LimitedStartTime != 0L)
			{
				num ^= this.LimitedStartTime.GetHashCode();
			}
			if (this.LimitedEndTime != 0L)
			{
				num ^= this.LimitedEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x000A716E File Offset: 0x000A536E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x000A717B File Offset: 0x000A537B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x000A7184 File Offset: 0x000A5384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chapterDatas_.WriteTo(ref output, CiacconaActivityPbData._repeated_chapterDatas_codec);
			this.scheduleRewardDatas_.WriteTo(ref output, CiacconaActivityPbData._repeated_scheduleRewardDatas_codec);
			this.activityResultDatas_.WriteTo(ref output, CiacconaActivityPbData._repeated_activityResultDatas_codec);
			if (this.inspirationData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.InspirationData);
			}
			if (this.State1Unlock)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.State1Unlock);
			}
			if (this.State2Unlock)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.State2Unlock);
			}
			if (this.LimitedStartTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LimitedStartTime);
			}
			if (this.LimitedEndTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.LimitedEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x000A7264 File Offset: 0x000A5464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chapterDatas_.CalculateSize(CiacconaActivityPbData._repeated_chapterDatas_codec);
			num += this.scheduleRewardDatas_.CalculateSize(CiacconaActivityPbData._repeated_scheduleRewardDatas_codec);
			num += this.activityResultDatas_.CalculateSize(CiacconaActivityPbData._repeated_activityResultDatas_codec);
			if (this.inspirationData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InspirationData);
			}
			if (this.State1Unlock)
			{
				num += 2;
			}
			if (this.State2Unlock)
			{
				num += 2;
			}
			if (this.LimitedStartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitedStartTime);
			}
			if (this.LimitedEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitedEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x000A7324 File Offset: 0x000A5524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaActivityPbData other)
		{
			if (other == null)
			{
				return;
			}
			this.chapterDatas_.Add(other.chapterDatas_);
			this.scheduleRewardDatas_.Add(other.scheduleRewardDatas_);
			this.activityResultDatas_.Add(other.activityResultDatas_);
			if (other.inspirationData_ != null)
			{
				if (this.inspirationData_ == null)
				{
					this.InspirationData = new CiacconaInspirationPbData();
				}
				this.InspirationData.MergeFrom(other.InspirationData);
			}
			if (other.State1Unlock)
			{
				this.State1Unlock = other.State1Unlock;
			}
			if (other.State2Unlock)
			{
				this.State2Unlock = other.State2Unlock;
			}
			if (other.LimitedStartTime != 0L)
			{
				this.LimitedStartTime = other.LimitedStartTime;
			}
			if (other.LimitedEndTime != 0L)
			{
				this.LimitedEndTime = other.LimitedEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x000A73FB File Offset: 0x000A55FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x000A7404 File Offset: 0x000A5604
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
					if (num <= 18U)
					{
						if (num == 10U)
						{
							this.chapterDatas_.AddEntriesFrom(ref input, CiacconaActivityPbData._repeated_chapterDatas_codec);
							continue;
						}
						if (num == 18U)
						{
							this.scheduleRewardDatas_.AddEntriesFrom(ref input, CiacconaActivityPbData._repeated_scheduleRewardDatas_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.activityResultDatas_.AddEntriesFrom(ref input, CiacconaActivityPbData._repeated_activityResultDatas_codec);
							continue;
						}
						if (num == 34U)
						{
							if (this.inspirationData_ == null)
							{
								this.InspirationData = new CiacconaInspirationPbData();
							}
							input.ReadMessage(this.InspirationData);
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.State1Unlock = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.State2Unlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.LimitedStartTime = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.LimitedEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E76 RID: 11894
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E77 RID: 11895
		public const int ChapterDatasFieldNumber = 1;

		// Token: 0x04002E78 RID: 11896
		private static readonly FieldCodec<CiacconaChapterPbData> _repeated_chapterDatas_codec = FieldCodec.ForMessage<CiacconaChapterPbData>(10U, CiacconaChapterPbData.Parser);

		// Token: 0x04002E79 RID: 11897
		private readonly RepeatedField<CiacconaChapterPbData> chapterDatas_ = new RepeatedField<CiacconaChapterPbData>();

		// Token: 0x04002E7A RID: 11898
		public const int ScheduleRewardDatasFieldNumber = 2;

		// Token: 0x04002E7B RID: 11899
		private static readonly FieldCodec<CiacconaScheduleRewardPbData> _repeated_scheduleRewardDatas_codec = FieldCodec.ForMessage<CiacconaScheduleRewardPbData>(18U, CiacconaScheduleRewardPbData.Parser);

		// Token: 0x04002E7C RID: 11900
		private readonly RepeatedField<CiacconaScheduleRewardPbData> scheduleRewardDatas_ = new RepeatedField<CiacconaScheduleRewardPbData>();

		// Token: 0x04002E7D RID: 11901
		public const int ActivityResultDatasFieldNumber = 3;

		// Token: 0x04002E7E RID: 11902
		private static readonly FieldCodec<CiacconaActivityResultPbData> _repeated_activityResultDatas_codec = FieldCodec.ForMessage<CiacconaActivityResultPbData>(26U, CiacconaActivityResultPbData.Parser);

		// Token: 0x04002E7F RID: 11903
		private readonly RepeatedField<CiacconaActivityResultPbData> activityResultDatas_ = new RepeatedField<CiacconaActivityResultPbData>();

		// Token: 0x04002E80 RID: 11904
		public const int InspirationDataFieldNumber = 4;

		// Token: 0x04002E81 RID: 11905
		private CiacconaInspirationPbData inspirationData_;

		// Token: 0x04002E82 RID: 11906
		public const int State1UnlockFieldNumber = 5;

		// Token: 0x04002E83 RID: 11907
		private bool state1Unlock_;

		// Token: 0x04002E84 RID: 11908
		public const int State2UnlockFieldNumber = 6;

		// Token: 0x04002E85 RID: 11909
		private bool state2Unlock_;

		// Token: 0x04002E86 RID: 11910
		public const int LimitedStartTimeFieldNumber = 7;

		// Token: 0x04002E87 RID: 11911
		private long limitedStartTime_;

		// Token: 0x04002E88 RID: 11912
		public const int LimitedEndTimeFieldNumber = 8;

		// Token: 0x04002E89 RID: 11913
		private long limitedEndTime_;
	}
}
