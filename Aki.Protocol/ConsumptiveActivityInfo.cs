using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E8 RID: 744
	public sealed class ConsumptiveActivityInfo : IMessage<ConsumptiveActivityInfo>, IMessage, IEquatable<ConsumptiveActivityInfo>, IDeepCloneable<ConsumptiveActivityInfo>, IBufferMessage
	{
		// Token: 0x06004BF2 RID: 19442 RVA: 0x000B95CC File Offset: 0x000B77CC
		[NullableContext(1)]
		public static ConsumptiveActivityInfo Create()
		{
			return new ConsumptiveActivityInfo();
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x000B95D3 File Offset: 0x000B77D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x000B95D6 File Offset: 0x000B77D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityInfo.Descriptor;
			}
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x000B95DD File Offset: 0x000B77DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo()
		{
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x000B95F0 File Offset: 0x000B77F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo(ConsumptiveActivityInfo other) : this()
		{
			this.activityId_ = other.activityId_;
			this.tasks_ = other.tasks_.Clone();
			this.totalScore_ = other.totalScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x000B963D File Offset: 0x000B783D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfo Clone()
		{
			return new ConsumptiveActivityInfo(this);
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x000B9645 File Offset: 0x000B7845
		// (set) Token: 0x06004BF9 RID: 19449 RVA: 0x000B964D File Offset: 0x000B784D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x000B9656 File Offset: 0x000B7856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConsumptiveTaskInfo> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x000B965E File Offset: 0x000B785E
		// (set) Token: 0x06004BFC RID: 19452 RVA: 0x000B9666 File Offset: 0x000B7866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalScore
		{
			get
			{
				return this.totalScore_;
			}
			set
			{
				this.totalScore_ = value;
			}
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x000B966F File Offset: 0x000B786F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityInfo);
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x000B9680 File Offset: 0x000B7880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityInfo other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.tasks_.Equals(other.tasks_) && this.TotalScore == other.TotalScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x000B96E0 File Offset: 0x000B78E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x000B9746 File Offset: 0x000B7946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x000B9753 File Offset: 0x000B7953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x000B975C File Offset: 0x000B795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.tasks_.WriteTo(ref output, ConsumptiveActivityInfo._repeated_tasks_codec);
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x000B97C8 File Offset: 0x000B79C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.tasks_.CalculateSize(ConsumptiveActivityInfo._repeated_tasks_codec);
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x000B9834 File Offset: 0x000B7A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.tasks_.Add(other.tasks_);
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x000B9895 File Offset: 0x000B7A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x000B98A0 File Offset: 0x000B7AA0
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
				if (num != 16U)
				{
					if (num != 26U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TotalScore = input.ReadInt32();
						}
					}
					else
					{
						this.tasks_.AddEntriesFrom(ref input, ConsumptiveActivityInfo._repeated_tasks_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003136 RID: 12598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003137 RID: 12599
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04003138 RID: 12600
		private int activityId_;

		// Token: 0x04003139 RID: 12601
		public const int TasksFieldNumber = 3;

		// Token: 0x0400313A RID: 12602
		private static readonly FieldCodec<ConsumptiveTaskInfo> _repeated_tasks_codec = FieldCodec.ForMessage<ConsumptiveTaskInfo>(26U, ConsumptiveTaskInfo.Parser);

		// Token: 0x0400313B RID: 12603
		private readonly RepeatedField<ConsumptiveTaskInfo> tasks_ = new RepeatedField<ConsumptiveTaskInfo>();

		// Token: 0x0400313C RID: 12604
		public const int TotalScoreFieldNumber = 4;

		// Token: 0x0400313D RID: 12605
		private int totalScore_;
	}
}
