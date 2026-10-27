using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000429 RID: 1065
	[NetMessage(EMessageId.EdgeRunnerTaskRewardRequest)]
	public sealed class EdgeRunnerTaskRewardRequest : IMessage<EdgeRunnerTaskRewardRequest>, IMessage, IEquatable<EdgeRunnerTaskRewardRequest>, IDeepCloneable<EdgeRunnerTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06006647 RID: 26183 RVA: 0x000F5FD5 File Offset: 0x000F41D5
		[NullableContext(1)]
		public static EdgeRunnerTaskRewardRequest Create()
		{
			return new EdgeRunnerTaskRewardRequest();
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06006648 RID: 26184 RVA: 0x000F5FDC File Offset: 0x000F41DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06006649 RID: 26185 RVA: 0x000F5FDF File Offset: 0x000F41DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x000F5FE6 File Offset: 0x000F41E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardRequest()
		{
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x000F5FF9 File Offset: 0x000F41F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardRequest(EdgeRunnerTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x000F602F File Offset: 0x000F422F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerTaskRewardRequest Clone()
		{
			return new EdgeRunnerTaskRewardRequest(this);
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x000F6037 File Offset: 0x000F4237
		// (set) Token: 0x0600664E RID: 26190 RVA: 0x000F603F File Offset: 0x000F423F
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

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x000F6048 File Offset: 0x000F4248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x000F6050 File Offset: 0x000F4250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerTaskRewardRequest);
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x000F6060 File Offset: 0x000F4260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x000F60B0 File Offset: 0x000F42B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x000F60FD File Offset: 0x000F42FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x000F610A File Offset: 0x000F430A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x000F6114 File Offset: 0x000F4314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, EdgeRunnerTaskRewardRequest._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x000F6164 File Offset: 0x000F4364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(EdgeRunnerTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x000F61B8 File Offset: 0x000F43B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x000F6205 File Offset: 0x000F4405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x000F6210 File Offset: 0x000F4410
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
				if (num != 32U && num != 34U)
				{
					if (num != 48U)
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
					this.taskIds_.AddEntriesFrom(ref input, EdgeRunnerTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04003919 RID: 14617
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400391A RID: 14618
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x0400391B RID: 14619
		private int activityId_;

		// Token: 0x0400391C RID: 14620
		public const int TaskIdsFieldNumber = 4;

		// Token: 0x0400391D RID: 14621
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400391E RID: 14622
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
