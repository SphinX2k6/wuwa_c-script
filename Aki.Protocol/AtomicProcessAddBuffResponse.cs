using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011A RID: 282
	[NetMessage(EMessageId.AtomicProcessAddBuffResponse)]
	public sealed class AtomicProcessAddBuffResponse : IMessage<AtomicProcessAddBuffResponse>, IMessage, IEquatable<AtomicProcessAddBuffResponse>, IDeepCloneable<AtomicProcessAddBuffResponse>, IBufferMessage
	{
		// Token: 0x06002665 RID: 9829 RVA: 0x000660F2 File Offset: 0x000642F2
		[NullableContext(1)]
		public static AtomicProcessAddBuffResponse Create()
		{
			return new AtomicProcessAddBuffResponse();
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x000660F9 File Offset: 0x000642F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x000660FC File Offset: 0x000642FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessAddBuffResponse.Descriptor;
			}
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00066103 File Offset: 0x00064303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffResponse()
		{
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x0006610B File Offset: 0x0006430B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffResponse(AtomicProcessAddBuffResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00066130 File Offset: 0x00064330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessAddBuffResponse Clone()
		{
			return new AtomicProcessAddBuffResponse(this);
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x00066138 File Offset: 0x00064338
		// (set) Token: 0x0600266C RID: 9836 RVA: 0x00066140 File Offset: 0x00064340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00066149 File Offset: 0x00064349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessAddBuffResponse);
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00066157 File Offset: 0x00064357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessAddBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00066188 File Offset: 0x00064388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x000661CD File Offset: 0x000643CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000661DA File Offset: 0x000643DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000661E3 File Offset: 0x000643E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00066218 File Offset: 0x00064418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00066256 File Offset: 0x00064456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessAddBuffResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00066287 File Offset: 0x00064487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00066290 File Offset: 0x00064490
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002615 RID: 9749
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002616 RID: 9750
		public const int ErrorIdFieldNumber = 12;

		// Token: 0x04002617 RID: 9751
		private ErrorCode errorId_;
	}
}
