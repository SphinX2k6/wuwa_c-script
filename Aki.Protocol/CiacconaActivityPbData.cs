using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000291 RID: 657
	public sealed class CiacconaActivityPbData : IMessage<CiacconaActivityPbData>, IMessage, IEquatable<CiacconaActivityPbData>, IDeepCloneable<CiacconaActivityPbData>, IBufferMessage
	{
		// Token: 0x060044B5 RID: 17589 RVA: 0x000A8B4A File Offset: 0x000A6D4A
		[NullableContext(1)]
		public static CiacconaActivityPbData Create()
		{
			return new CiacconaActivityPbData();
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x000A8B51 File Offset: 0x000A6D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x000A8B54 File Offset: 0x000A6D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaActivityPbData.Descriptor;
			}
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x000A8B5B File Offset: 0x000A6D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityPbData()
		{
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x000A8B84 File Offset: 0x000A6D84
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

		// Token: 0x060044BA RID: 17594 RVA: 0x000A8C27 File Offset: 0x000A6E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaActivityPbData Clone()
		{
			return new CiacconaActivityPbData(this);
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060044BB RID: 17595 RVA: 0x000A8C2F File Offset: 0x000A6E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaChapterPbData> ChapterDatas
		{
			get
			{
				return this.chapterDatas_;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060044BC RID: 17596 RVA: 0x000A8C37 File Offset: 0x000A6E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaScheduleRewardPbData> ScheduleRewardDatas
		{
			get
			{
				return this.scheduleRewardDatas_;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060044BD RID: 17597 RVA: 0x000A8C3F File Offset: 0x000A6E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CiacconaActivityResultPbData> ActivityResultDatas
		{
			get
			{
				return this.activityResultDatas_;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x000A8C47 File Offset: 0x000A6E47
		// (set) Token: 0x060044BF RID: 17599 RVA: 0x000A8C4F File Offset: 0x000A6E4F
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

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x000A8C58 File Offset: 0x000A6E58
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x000A8C60 File Offset: 0x000A6E60
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

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x000A8C69 File Offset: 0x000A6E69
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x000A8C71 File Offset: 0x000A6E71
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

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x000A8C7A File Offset: 0x000A6E7A
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x000A8C82 File Offset: 0x000A6E82
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

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x000A8C8B File Offset: 0x000A6E8B
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x000A8C93 File Offset: 0x000A6E93
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

		// Token: 0x060044C8 RID: 17608 RVA: 0x000A8C9C File Offset: 0x000A6E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaActivityPbData);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x000A8CAC File Offset: 0x000A6EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaActivityPbData other)
		{
			return other != null && (other == this || (this.chapterDatas_.Equals(other.chapterDatas_) && this.scheduleRewardDatas_.Equals(other.scheduleRewardDatas_) && this.activityResultDatas_.Equals(other.activityResultDatas_) && object.Equals(this.InspirationData, other.InspirationData) && this.State1Unlock == other.State1Unlock && this.State2Unlock == other.State2Unlock && this.LimitedStartTime == other.LimitedStartTime && this.LimitedEndTime == other.LimitedEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x000A8D6C File Offset: 0x000A6F6C
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

		// Token: 0x060044CB RID: 17611 RVA: 0x000A8E36 File Offset: 0x000A7036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x000A8E43 File Offset: 0x000A7043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x000A8E4C File Offset: 0x000A704C
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

		// Token: 0x060044CE RID: 17614 RVA: 0x000A8F2C File Offset: 0x000A712C
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

		// Token: 0x060044CF RID: 17615 RVA: 0x000A8FEC File Offset: 0x000A71EC
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

		// Token: 0x060044D0 RID: 17616 RVA: 0x000A90C3 File Offset: 0x000A72C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x000A90CC File Offset: 0x000A72CC
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

		// Token: 0x04002EFA RID: 12026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EFB RID: 12027
		public const int ChapterDatasFieldNumber = 1;

		// Token: 0x04002EFC RID: 12028
		private static readonly FieldCodec<CiacconaChapterPbData> _repeated_chapterDatas_codec = FieldCodec.ForMessage<CiacconaChapterPbData>(10U, CiacconaChapterPbData.Parser);

		// Token: 0x04002EFD RID: 12029
		private readonly RepeatedField<CiacconaChapterPbData> chapterDatas_ = new RepeatedField<CiacconaChapterPbData>();

		// Token: 0x04002EFE RID: 12030
		public const int ScheduleRewardDatasFieldNumber = 2;

		// Token: 0x04002EFF RID: 12031
		private static readonly FieldCodec<CiacconaScheduleRewardPbData> _repeated_scheduleRewardDatas_codec = FieldCodec.ForMessage<CiacconaScheduleRewardPbData>(18U, CiacconaScheduleRewardPbData.Parser);

		// Token: 0x04002F00 RID: 12032
		private readonly RepeatedField<CiacconaScheduleRewardPbData> scheduleRewardDatas_ = new RepeatedField<CiacconaScheduleRewardPbData>();

		// Token: 0x04002F01 RID: 12033
		public const int ActivityResultDatasFieldNumber = 3;

		// Token: 0x04002F02 RID: 12034
		private static readonly FieldCodec<CiacconaActivityResultPbData> _repeated_activityResultDatas_codec = FieldCodec.ForMessage<CiacconaActivityResultPbData>(26U, CiacconaActivityResultPbData.Parser);

		// Token: 0x04002F03 RID: 12035
		private readonly RepeatedField<CiacconaActivityResultPbData> activityResultDatas_ = new RepeatedField<CiacconaActivityResultPbData>();

		// Token: 0x04002F04 RID: 12036
		public const int InspirationDataFieldNumber = 4;

		// Token: 0x04002F05 RID: 12037
		private CiacconaInspirationPbData inspirationData_;

		// Token: 0x04002F06 RID: 12038
		public const int State1UnlockFieldNumber = 5;

		// Token: 0x04002F07 RID: 12039
		private bool state1Unlock_;

		// Token: 0x04002F08 RID: 12040
		public const int State2UnlockFieldNumber = 6;

		// Token: 0x04002F09 RID: 12041
		private bool state2Unlock_;

		// Token: 0x04002F0A RID: 12042
		public const int LimitedStartTimeFieldNumber = 7;

		// Token: 0x04002F0B RID: 12043
		private long limitedStartTime_;

		// Token: 0x04002F0C RID: 12044
		public const int LimitedEndTimeFieldNumber = 8;

		// Token: 0x04002F0D RID: 12045
		private long limitedEndTime_;
	}
}
