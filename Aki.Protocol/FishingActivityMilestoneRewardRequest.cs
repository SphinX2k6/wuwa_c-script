using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000532 RID: 1330
	[NetMessage(EMessageId.FishingActivityMilestoneRewardRequest)]
	public sealed class FishingActivityMilestoneRewardRequest : IMessage<FishingActivityMilestoneRewardRequest>, IMessage, IEquatable<FishingActivityMilestoneRewardRequest>, IDeepCloneable<FishingActivityMilestoneRewardRequest>, IBufferMessage
	{
		// Token: 0x06007CF8 RID: 31992 RVA: 0x0012F277 File Offset: 0x0012D477
		[NullableContext(1)]
		public static FishingActivityMilestoneRewardRequest Create()
		{
			return new FishingActivityMilestoneRewardRequest();
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06007CF9 RID: 31993 RVA: 0x0012F27E File Offset: 0x0012D47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06007CFA RID: 31994 RVA: 0x0012F281 File Offset: 0x0012D481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityMilestoneRewardRequest.Descriptor;
			}
		}

		// Token: 0x06007CFB RID: 31995 RVA: 0x0012F288 File Offset: 0x0012D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardRequest()
		{
		}

		// Token: 0x06007CFC RID: 31996 RVA: 0x0012F29B File Offset: 0x0012D49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardRequest(FishingActivityMilestoneRewardRequest other) : this()
		{
			this.milestoneId_ = other.milestoneId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x0012F2D1 File Offset: 0x0012D4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardRequest Clone()
		{
			return new FishingActivityMilestoneRewardRequest(this);
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06007CFE RID: 31998 RVA: 0x0012F2D9 File Offset: 0x0012D4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MilestoneId
		{
			get
			{
				return this.milestoneId_;
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06007CFF RID: 31999 RVA: 0x0012F2E1 File Offset: 0x0012D4E1
		// (set) Token: 0x06007D00 RID: 32000 RVA: 0x0012F2E9 File Offset: 0x0012D4E9
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

		// Token: 0x06007D01 RID: 32001 RVA: 0x0012F2F2 File Offset: 0x0012D4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityMilestoneRewardRequest);
		}

		// Token: 0x06007D02 RID: 32002 RVA: 0x0012F300 File Offset: 0x0012D500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityMilestoneRewardRequest other)
		{
			return other != null && (other == this || (this.milestoneId_.Equals(other.milestoneId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x0012F350 File Offset: 0x0012D550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.milestoneId_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x0012F39D File Offset: 0x0012D59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x0012F3AA File Offset: 0x0012D5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x0012F3B4 File Offset: 0x0012D5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			this.milestoneId_.WriteTo(ref output, FishingActivityMilestoneRewardRequest._repeated_milestoneId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x0012F404 File Offset: 0x0012D604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.milestoneId_.CalculateSize(FishingActivityMilestoneRewardRequest._repeated_milestoneId_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x0012F458 File Offset: 0x0012D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityMilestoneRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.milestoneId_.Add(other.milestoneId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x0012F4A5 File Offset: 0x0012D6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x0012F4B0 File Offset: 0x0012D6B0
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
				if (num != 32U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.milestoneId_.AddEntriesFrom(ref input, FishingActivityMilestoneRewardRequest._repeated_milestoneId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400400A RID: 16394
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400400B RID: 16395
		public const int MilestoneIdFieldNumber = 12;

		// Token: 0x0400400C RID: 16396
		private static readonly FieldCodec<int> _repeated_milestoneId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400400D RID: 16397
		private readonly RepeatedField<int> milestoneId_ = new RepeatedField<int>();

		// Token: 0x0400400E RID: 16398
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x0400400F RID: 16399
		private int activityId_;
	}
}
