using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E6 RID: 742
	[NetMessage(EMessageId.ConsumptiveRewardRequest)]
	public sealed class ConsumptiveRewardRequest : IMessage<ConsumptiveRewardRequest>, IMessage, IEquatable<ConsumptiveRewardRequest>, IDeepCloneable<ConsumptiveRewardRequest>, IBufferMessage
	{
		// Token: 0x06004B79 RID: 19321 RVA: 0x000B7DDF File Offset: 0x000B5FDF
		[NullableContext(1)]
		public static ConsumptiveRewardRequest Create()
		{
			return new ConsumptiveRewardRequest();
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06004B7A RID: 19322 RVA: 0x000B7DE6 File Offset: 0x000B5FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x000B7DE9 File Offset: 0x000B5FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x000B7DF0 File Offset: 0x000B5FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardRequest()
		{
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x000B7E03 File Offset: 0x000B6003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardRequest(ConsumptiveRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x000B7E39 File Offset: 0x000B6039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardRequest Clone()
		{
			return new ConsumptiveRewardRequest(this);
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06004B7F RID: 19327 RVA: 0x000B7E41 File Offset: 0x000B6041
		// (set) Token: 0x06004B80 RID: 19328 RVA: 0x000B7E49 File Offset: 0x000B6049
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

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06004B81 RID: 19329 RVA: 0x000B7E52 File Offset: 0x000B6052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x000B7E5A File Offset: 0x000B605A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveRewardRequest);
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x000B7E68 File Offset: 0x000B6068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x000B7EB8 File Offset: 0x000B60B8
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

		// Token: 0x06004B85 RID: 19333 RVA: 0x000B7F05 File Offset: 0x000B6105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x000B7F12 File Offset: 0x000B6112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x000B7F1C File Offset: 0x000B611C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, ConsumptiveRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x000B7F6C File Offset: 0x000B616C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(ConsumptiveRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x000B7FC0 File Offset: 0x000B61C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveRewardRequest other)
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

		// Token: 0x06004B8A RID: 19338 RVA: 0x000B800D File Offset: 0x000B620D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x000B8018 File Offset: 0x000B6218
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
				if (num != 112U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, ConsumptiveRewardRequest._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040030B5 RID: 12469
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030B6 RID: 12470
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x040030B7 RID: 12471
		private int activityId_;

		// Token: 0x040030B8 RID: 12472
		public const int TaskIdsFieldNumber = 15;

		// Token: 0x040030B9 RID: 12473
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040030BA RID: 12474
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
