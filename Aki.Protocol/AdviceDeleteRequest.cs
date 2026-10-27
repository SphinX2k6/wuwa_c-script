using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C9 RID: 201
	[NetMessage(EMessageId.AdviceDeleteRequest)]
	public sealed class AdviceDeleteRequest : IMessage<AdviceDeleteRequest>, IMessage, IEquatable<AdviceDeleteRequest>, IDeepCloneable<AdviceDeleteRequest>, IBufferMessage
	{
		// Token: 0x06001F7D RID: 8061 RVA: 0x00055AEB File Offset: 0x00053CEB
		[NullableContext(1)]
		public static AdviceDeleteRequest Create()
		{
			return new AdviceDeleteRequest();
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00055AF2 File Offset: 0x00053CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00055AF5 File Offset: 0x00053CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceDeleteRequest.Descriptor;
			}
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00055AFC File Offset: 0x00053CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteRequest()
		{
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00055B04 File Offset: 0x00053D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteRequest(AdviceDeleteRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00055B29 File Offset: 0x00053D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteRequest Clone()
		{
			return new AdviceDeleteRequest(this);
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00055B31 File Offset: 0x00053D31
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00055B39 File Offset: 0x00053D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x06001F85 RID: 8069 RVA: 0x00055B42 File Offset: 0x00053D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceDeleteRequest);
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00055B50 File Offset: 0x00053D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceDeleteRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00055B80 File Offset: 0x00053D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00055BBF File Offset: 0x00053DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00055BCC File Offset: 0x00053DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00055BD5 File Offset: 0x00053DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00055C08 File Offset: 0x00053E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00055C46 File Offset: 0x00053E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceDeleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00055C77 File Offset: 0x00053E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00055C80 File Offset: 0x00053E80
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040023C0 RID: 9152
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023C1 RID: 9153
		public const int IdFieldNumber = 6;

		// Token: 0x040023C2 RID: 9154
		private long id_;
	}
}
