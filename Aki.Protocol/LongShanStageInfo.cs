using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000954 RID: 2388
	public sealed class LongShanStageInfo : IMessage<LongShanStageInfo>, IMessage, IEquatable<LongShanStageInfo>, IDeepCloneable<LongShanStageInfo>, IBufferMessage
	{
		// Token: 0x0600D273 RID: 53875 RVA: 0x001F03C0 File Offset: 0x001EE5C0
		[NullableContext(1)]
		public static LongShanStageInfo Create()
		{
			return new LongShanStageInfo();
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0600D274 RID: 53876 RVA: 0x001F03C7 File Offset: 0x001EE5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LongShanStageInfo> Parser
		{
			get
			{
				return LongShanStageInfo._parser;
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0600D275 RID: 53877 RVA: 0x001F03CE File Offset: 0x001EE5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0600D276 RID: 53878 RVA: 0x001F03D1 File Offset: 0x001EE5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanStageInfo.Descriptor;
			}
		}

		// Token: 0x0600D277 RID: 53879 RVA: 0x001F03D8 File Offset: 0x001EE5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageInfo()
		{
		}

		// Token: 0x0600D278 RID: 53880 RVA: 0x001F03EC File Offset: 0x001EE5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageInfo(LongShanStageInfo other) : this()
		{
			this.id_ = other.id_;
			this.tasks_ = other.tasks_.Clone();
			this.unlock_ = other.unlock_;
			this.beginOpenTime_ = other.beginOpenTime_;
			this.endOpenTime_ = other.endOpenTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D279 RID: 53881 RVA: 0x001F0451 File Offset: 0x001EE651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanStageInfo Clone()
		{
			return new LongShanStageInfo(this);
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0600D27A RID: 53882 RVA: 0x001F0459 File Offset: 0x001EE659
		// (set) Token: 0x0600D27B RID: 53883 RVA: 0x001F0461 File Offset: 0x001EE661
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

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x0600D27C RID: 53884 RVA: 0x001F046A File Offset: 0x001EE66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LongShanTaskInfo> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x0600D27D RID: 53885 RVA: 0x001F0472 File Offset: 0x001EE672
		// (set) Token: 0x0600D27E RID: 53886 RVA: 0x001F047A File Offset: 0x001EE67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x0600D27F RID: 53887 RVA: 0x001F0483 File Offset: 0x001EE683
		// (set) Token: 0x0600D280 RID: 53888 RVA: 0x001F048B File Offset: 0x001EE68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginOpenTime
		{
			get
			{
				return this.beginOpenTime_;
			}
			set
			{
				this.beginOpenTime_ = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x0600D281 RID: 53889 RVA: 0x001F0494 File Offset: 0x001EE694
		// (set) Token: 0x0600D282 RID: 53890 RVA: 0x001F049C File Offset: 0x001EE69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndOpenTime
		{
			get
			{
				return this.endOpenTime_;
			}
			set
			{
				this.endOpenTime_ = value;
			}
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x001F04A5 File Offset: 0x001EE6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanStageInfo);
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x001F04B4 File Offset: 0x001EE6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanStageInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tasks_.Equals(other.tasks_) && this.Unlock == other.Unlock && this.BeginOpenTime == other.BeginOpenTime && this.EndOpenTime == other.EndOpenTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x001F0534 File Offset: 0x001EE734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.BeginOpenTime != 0L)
			{
				num ^= this.BeginOpenTime.GetHashCode();
			}
			if (this.EndOpenTime != 0L)
			{
				num ^= this.EndOpenTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x001F05CC File Offset: 0x001EE7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D287 RID: 53895 RVA: 0x001F05D9 File Offset: 0x001EE7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D288 RID: 53896 RVA: 0x001F05E4 File Offset: 0x001EE7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.tasks_.WriteTo(ref output, LongShanStageInfo._repeated_tasks_codec);
			if (this.Unlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Unlock);
			}
			if (this.BeginOpenTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EndOpenTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x001F0688 File Offset: 0x001EE888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.tasks_.CalculateSize(LongShanStageInfo._repeated_tasks_codec);
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.BeginOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginOpenTime);
			}
			if (this.EndOpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndOpenTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D28A RID: 53898 RVA: 0x001F0718 File Offset: 0x001EE918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanStageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.tasks_.Add(other.tasks_);
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.BeginOpenTime != 0L)
			{
				this.BeginOpenTime = other.BeginOpenTime;
			}
			if (other.EndOpenTime != 0L)
			{
				this.EndOpenTime = other.EndOpenTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D28B RID: 53899 RVA: 0x001F07A1 File Offset: 0x001EE9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D28C RID: 53900 RVA: 0x001F07AC File Offset: 0x001EE9AC
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.tasks_.AddEntriesFrom(ref input, LongShanStageInfo._repeated_tasks_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Unlock = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.BeginOpenTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.EndOpenTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005887 RID: 22663
		private static readonly MessageParser<LongShanStageInfo> _parser = new MessageParser<LongShanStageInfo>(() => new LongShanStageInfo());

		// Token: 0x04005888 RID: 22664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005889 RID: 22665
		public const int IdFieldNumber = 1;

		// Token: 0x0400588A RID: 22666
		private int id_;

		// Token: 0x0400588B RID: 22667
		public const int TasksFieldNumber = 2;

		// Token: 0x0400588C RID: 22668
		private static readonly FieldCodec<LongShanTaskInfo> _repeated_tasks_codec = FieldCodec.ForMessage<LongShanTaskInfo>(18U, LongShanTaskInfo.Parser);

		// Token: 0x0400588D RID: 22669
		private readonly RepeatedField<LongShanTaskInfo> tasks_ = new RepeatedField<LongShanTaskInfo>();

		// Token: 0x0400588E RID: 22670
		public const int UnlockFieldNumber = 3;

		// Token: 0x0400588F RID: 22671
		private bool unlock_;

		// Token: 0x04005890 RID: 22672
		public const int BeginOpenTimeFieldNumber = 4;

		// Token: 0x04005891 RID: 22673
		private long beginOpenTime_;

		// Token: 0x04005892 RID: 22674
		public const int EndOpenTimeFieldNumber = 5;

		// Token: 0x04005893 RID: 22675
		private long endOpenTime_;
	}
}
