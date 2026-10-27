using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DD RID: 989
	[NetMessage(EMessageId.DirectTrainPreOpenCloseNotify)]
	public sealed class DirectTrainPreOpenCloseNotify : IMessage<DirectTrainPreOpenCloseNotify>, IMessage, IEquatable<DirectTrainPreOpenCloseNotify>, IDeepCloneable<DirectTrainPreOpenCloseNotify>, IBufferMessage
	{
		// Token: 0x06006041 RID: 24641 RVA: 0x000E8D01 File Offset: 0x000E6F01
		[NullableContext(1)]
		public static DirectTrainPreOpenCloseNotify Create()
		{
			return new DirectTrainPreOpenCloseNotify();
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x000E8D08 File Offset: 0x000E6F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06006043 RID: 24643 RVA: 0x000E8D0B File Offset: 0x000E6F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainPreOpenCloseNotify.Descriptor;
			}
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x000E8D12 File Offset: 0x000E6F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainPreOpenCloseNotify()
		{
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x000E8D1A File Offset: 0x000E6F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainPreOpenCloseNotify(DirectTrainPreOpenCloseNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x000E8D3F File Offset: 0x000E6F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainPreOpenCloseNotify Clone()
		{
			return new DirectTrainPreOpenCloseNotify(this);
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06006047 RID: 24647 RVA: 0x000E8D47 File Offset: 0x000E6F47
		// (set) Token: 0x06006048 RID: 24648 RVA: 0x000E8D4F File Offset: 0x000E6F4F
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

		// Token: 0x06006049 RID: 24649 RVA: 0x000E8D58 File Offset: 0x000E6F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainPreOpenCloseNotify);
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x000E8D66 File Offset: 0x000E6F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainPreOpenCloseNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x000E8D94 File Offset: 0x000E6F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600604C RID: 24652 RVA: 0x000E8DD3 File Offset: 0x000E6FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x000E8DE0 File Offset: 0x000E6FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x000E8DE9 File Offset: 0x000E6FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x000E8E1C File Offset: 0x000E701C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06006050 RID: 24656 RVA: 0x000E8E5A File Offset: 0x000E705A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DirectTrainPreOpenCloseNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x000E8E8B File Offset: 0x000E708B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x000E8E94 File Offset: 0x000E7094
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003757 RID: 14167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003758 RID: 14168
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04003759 RID: 14169
		private int activityId_;
	}
}
