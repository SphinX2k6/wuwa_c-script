using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000547 RID: 1351
	[NetMessage(EMessageId.FishingActivityMilestoneRewardRequest)]
	public sealed class FishingActivityMilestoneRewardRequest : IMessage<FishingActivityMilestoneRewardRequest>, IMessage, IEquatable<FishingActivityMilestoneRewardRequest>, IDeepCloneable<FishingActivityMilestoneRewardRequest>, IBufferMessage
	{
		// Token: 0x06007E60 RID: 32352 RVA: 0x00131E7B File Offset: 0x0013007B
		[NullableContext(1)]
		public static FishingActivityMilestoneRewardRequest Create()
		{
			return new FishingActivityMilestoneRewardRequest();
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06007E61 RID: 32353 RVA: 0x00131E82 File Offset: 0x00130082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06007E62 RID: 32354 RVA: 0x00131E85 File Offset: 0x00130085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityMilestoneRewardRequest.Descriptor;
			}
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x00131E8C File Offset: 0x0013008C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardRequest()
		{
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x00131E9F File Offset: 0x0013009F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardRequest(FishingActivityMilestoneRewardRequest other) : this()
		{
			this.milestoneId_ = other.milestoneId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x00131ED5 File Offset: 0x001300D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardRequest Clone()
		{
			return new FishingActivityMilestoneRewardRequest(this);
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06007E66 RID: 32358 RVA: 0x00131EDD File Offset: 0x001300DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MilestoneId
		{
			get
			{
				return this.milestoneId_;
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06007E67 RID: 32359 RVA: 0x00131EE5 File Offset: 0x001300E5
		// (set) Token: 0x06007E68 RID: 32360 RVA: 0x00131EED File Offset: 0x001300ED
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

		// Token: 0x06007E69 RID: 32361 RVA: 0x00131EF6 File Offset: 0x001300F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityMilestoneRewardRequest);
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x00131F04 File Offset: 0x00130104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityMilestoneRewardRequest other)
		{
			return other != null && (other == this || (this.milestoneId_.Equals(other.milestoneId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E6B RID: 32363 RVA: 0x00131F54 File Offset: 0x00130154
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

		// Token: 0x06007E6C RID: 32364 RVA: 0x00131FA1 File Offset: 0x001301A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x00131FAE File Offset: 0x001301AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x00131FB8 File Offset: 0x001301B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.milestoneId_.WriteTo(ref output, FishingActivityMilestoneRewardRequest._repeated_milestoneId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x00132008 File Offset: 0x00130208
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

		// Token: 0x06007E70 RID: 32368 RVA: 0x0013205C File Offset: 0x0013025C
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

		// Token: 0x06007E71 RID: 32369 RVA: 0x001320A9 File Offset: 0x001302A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E72 RID: 32370 RVA: 0x001320B4 File Offset: 0x001302B4
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
				if (num != 80U && num != 82U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.milestoneId_.AddEntriesFrom(ref input, FishingActivityMilestoneRewardRequest._repeated_milestoneId_codec);
				}
			}
		}

		// Token: 0x04004014 RID: 16404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004015 RID: 16405
		public const int MilestoneIdFieldNumber = 10;

		// Token: 0x04004016 RID: 16406
		private static readonly FieldCodec<int> _repeated_milestoneId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04004017 RID: 16407
		private readonly RepeatedField<int> milestoneId_ = new RepeatedField<int>();

		// Token: 0x04004018 RID: 16408
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04004019 RID: 16409
		private int activityId_;
	}
}
