using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEB RID: 3563
	[NetMessage(EMessageId.QingXiaoTaskRewardRequest)]
	public sealed class QingXiaoTaskRewardRequest : IMessage<QingXiaoTaskRewardRequest>, IMessage, IEquatable<QingXiaoTaskRewardRequest>, IDeepCloneable<QingXiaoTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06013314 RID: 78612 RVA: 0x002CC211 File Offset: 0x002CA411
		[NullableContext(1)]
		public static QingXiaoTaskRewardRequest Create()
		{
			return new QingXiaoTaskRewardRequest();
		}

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x06013315 RID: 78613 RVA: 0x002CC218 File Offset: 0x002CA418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x06013316 RID: 78614 RVA: 0x002CC21B File Offset: 0x002CA41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QingXiaoTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06013317 RID: 78615 RVA: 0x002CC222 File Offset: 0x002CA422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardRequest()
		{
		}

		// Token: 0x06013318 RID: 78616 RVA: 0x002CC235 File Offset: 0x002CA435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardRequest(QingXiaoTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013319 RID: 78617 RVA: 0x002CC26B File Offset: 0x002CA46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardRequest Clone()
		{
			return new QingXiaoTaskRewardRequest(this);
		}

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x0601331A RID: 78618 RVA: 0x002CC273 File Offset: 0x002CA473
		// (set) Token: 0x0601331B RID: 78619 RVA: 0x002CC27B File Offset: 0x002CA47B
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

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x0601331C RID: 78620 RVA: 0x002CC284 File Offset: 0x002CA484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0601331D RID: 78621 RVA: 0x002CC28C File Offset: 0x002CA48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QingXiaoTaskRewardRequest);
		}

		// Token: 0x0601331E RID: 78622 RVA: 0x002CC29C File Offset: 0x002CA49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QingXiaoTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601331F RID: 78623 RVA: 0x002CC2EC File Offset: 0x002CA4EC
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

		// Token: 0x06013320 RID: 78624 RVA: 0x002CC339 File Offset: 0x002CA539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013321 RID: 78625 RVA: 0x002CC346 File Offset: 0x002CA546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013322 RID: 78626 RVA: 0x002CC350 File Offset: 0x002CA550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, QingXiaoTaskRewardRequest._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013323 RID: 78627 RVA: 0x002CC3A0 File Offset: 0x002CA5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(QingXiaoTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013324 RID: 78628 RVA: 0x002CC3F4 File Offset: 0x002CA5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QingXiaoTaskRewardRequest other)
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

		// Token: 0x06013325 RID: 78629 RVA: 0x002CC441 File Offset: 0x002CA641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013326 RID: 78630 RVA: 0x002CC44C File Offset: 0x002CA64C
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
				if (num != 24U && num != 26U)
				{
					if (num != 104U)
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
					this.taskIds_.AddEntriesFrom(ref input, QingXiaoTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007699 RID: 30361
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400769A RID: 30362
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x0400769B RID: 30363
		private int activityId_;

		// Token: 0x0400769C RID: 30364
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x0400769D RID: 30365
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400769E RID: 30366
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
