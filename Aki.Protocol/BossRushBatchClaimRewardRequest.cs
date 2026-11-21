using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D2 RID: 466
	[NetMessage(EMessageId.BossRushBatchClaimRewardRequest)]
	public sealed class BossRushBatchClaimRewardRequest : IMessage<BossRushBatchClaimRewardRequest>, IMessage, IEquatable<BossRushBatchClaimRewardRequest>, IDeepCloneable<BossRushBatchClaimRewardRequest>, IBufferMessage
	{
		// Token: 0x0600353D RID: 13629 RVA: 0x00086490 File Offset: 0x00084690
		[NullableContext(1)]
		public static BossRushBatchClaimRewardRequest Create()
		{
			return new BossRushBatchClaimRewardRequest();
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x00086497 File Offset: 0x00084697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600353F RID: 13631 RVA: 0x0008649A File Offset: 0x0008469A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushBatchClaimRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000864A1 File Offset: 0x000846A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardRequest()
		{
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000864B4 File Offset: 0x000846B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardRequest(BossRushBatchClaimRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskRewardIds_ = other.taskRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x000864EA File Offset: 0x000846EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardRequest Clone()
		{
			return new BossRushBatchClaimRewardRequest(this);
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x000864F2 File Offset: 0x000846F2
		// (set) Token: 0x06003544 RID: 13636 RVA: 0x000864FA File Offset: 0x000846FA
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

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x00086503 File Offset: 0x00084703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskRewardIds
		{
			get
			{
				return this.taskRewardIds_;
			}
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0008650B File Offset: 0x0008470B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushBatchClaimRewardRequest);
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x0008651C File Offset: 0x0008471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushBatchClaimRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskRewardIds_.Equals(other.taskRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0008656C File Offset: 0x0008476C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskRewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x000865B9 File Offset: 0x000847B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x000865C6 File Offset: 0x000847C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x000865D0 File Offset: 0x000847D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			this.taskRewardIds_.WriteTo(ref output, BossRushBatchClaimRewardRequest._repeated_taskRewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00086620 File Offset: 0x00084820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskRewardIds_.CalculateSize(BossRushBatchClaimRewardRequest._repeated_taskRewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00086674 File Offset: 0x00084874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushBatchClaimRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskRewardIds_.Add(other.taskRewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000866C1 File Offset: 0x000848C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000866CC File Offset: 0x000848CC
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
				if (num != 48U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskRewardIds_.AddEntriesFrom(ref input, BossRushBatchClaimRewardRequest._repeated_taskRewardIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002A97 RID: 10903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A98 RID: 10904
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04002A99 RID: 10905
		private int activityId_;

		// Token: 0x04002A9A RID: 10906
		public const int TaskRewardIdsFieldNumber = 9;

		// Token: 0x04002A9B RID: 10907
		private static readonly FieldCodec<int> _repeated_taskRewardIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04002A9C RID: 10908
		private readonly RepeatedField<int> taskRewardIds_ = new RepeatedField<int>();
	}
}
