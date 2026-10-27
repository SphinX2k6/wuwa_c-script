using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DFB RID: 3579
	[NetMessage(EMessageId.QingXiaoTaskRewardRequest)]
	public sealed class QingXiaoTaskRewardRequest : IMessage<QingXiaoTaskRewardRequest>, IMessage, IEquatable<QingXiaoTaskRewardRequest>, IDeepCloneable<QingXiaoTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060133F9 RID: 78841 RVA: 0x002CD8D5 File Offset: 0x002CBAD5
		[NullableContext(1)]
		public static QingXiaoTaskRewardRequest Create()
		{
			return new QingXiaoTaskRewardRequest();
		}

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x060133FA RID: 78842 RVA: 0x002CD8DC File Offset: 0x002CBADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x060133FB RID: 78843 RVA: 0x002CD8DF File Offset: 0x002CBADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QingXiaoTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060133FC RID: 78844 RVA: 0x002CD8E6 File Offset: 0x002CBAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardRequest()
		{
		}

		// Token: 0x060133FD RID: 78845 RVA: 0x002CD8F9 File Offset: 0x002CBAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardRequest(QingXiaoTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133FE RID: 78846 RVA: 0x002CD92F File Offset: 0x002CBB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QingXiaoTaskRewardRequest Clone()
		{
			return new QingXiaoTaskRewardRequest(this);
		}

		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x060133FF RID: 78847 RVA: 0x002CD937 File Offset: 0x002CBB37
		// (set) Token: 0x06013400 RID: 78848 RVA: 0x002CD93F File Offset: 0x002CBB3F
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

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x06013401 RID: 78849 RVA: 0x002CD948 File Offset: 0x002CBB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06013402 RID: 78850 RVA: 0x002CD950 File Offset: 0x002CBB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QingXiaoTaskRewardRequest);
		}

		// Token: 0x06013403 RID: 78851 RVA: 0x002CD960 File Offset: 0x002CBB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QingXiaoTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013404 RID: 78852 RVA: 0x002CD9B0 File Offset: 0x002CBBB0
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

		// Token: 0x06013405 RID: 78853 RVA: 0x002CD9FD File Offset: 0x002CBBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013406 RID: 78854 RVA: 0x002CDA0A File Offset: 0x002CBC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013407 RID: 78855 RVA: 0x002CDA14 File Offset: 0x002CBC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, QingXiaoTaskRewardRequest._repeated_taskIds_codec);
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

		// Token: 0x06013408 RID: 78856 RVA: 0x002CDA64 File Offset: 0x002CBC64
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

		// Token: 0x06013409 RID: 78857 RVA: 0x002CDAB8 File Offset: 0x002CBCB8
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

		// Token: 0x0601340A RID: 78858 RVA: 0x002CDB05 File Offset: 0x002CBD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601340B RID: 78859 RVA: 0x002CDB10 File Offset: 0x002CBD10
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
				if (num != 56U && num != 58U)
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
					this.taskIds_.AddEntriesFrom(ref input, QingXiaoTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x0400766F RID: 30319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007670 RID: 30320
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04007671 RID: 30321
		private int activityId_;

		// Token: 0x04007672 RID: 30322
		public const int TaskIdsFieldNumber = 7;

		// Token: 0x04007673 RID: 30323
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007674 RID: 30324
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
