using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011C RID: 284
	[NetMessage(EMessageId.AtomicProcessRemoveBuffResponse)]
	public sealed class AtomicProcessRemoveBuffResponse : IMessage<AtomicProcessRemoveBuffResponse>, IMessage, IEquatable<AtomicProcessRemoveBuffResponse>, IDeepCloneable<AtomicProcessRemoveBuffResponse>, IBufferMessage
	{
		// Token: 0x06002691 RID: 9873 RVA: 0x0006677D File Offset: 0x0006497D
		[NullableContext(1)]
		public static AtomicProcessRemoveBuffResponse Create()
		{
			return new AtomicProcessRemoveBuffResponse();
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x00066784 File Offset: 0x00064984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x00066787 File Offset: 0x00064987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessRemoveBuffResponse.Descriptor;
			}
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x0006678E File Offset: 0x0006498E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffResponse()
		{
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00066796 File Offset: 0x00064996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffResponse(AtomicProcessRemoveBuffResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000667BB File Offset: 0x000649BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffResponse Clone()
		{
			return new AtomicProcessRemoveBuffResponse(this);
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x000667C3 File Offset: 0x000649C3
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x000667CB File Offset: 0x000649CB
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

		// Token: 0x06002699 RID: 9881 RVA: 0x000667D4 File Offset: 0x000649D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessRemoveBuffResponse);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000667E2 File Offset: 0x000649E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessRemoveBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00066810 File Offset: 0x00064A10
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

		// Token: 0x0600269C RID: 9884 RVA: 0x00066855 File Offset: 0x00064A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00066862 File Offset: 0x00064A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0006686B File Offset: 0x00064A6B
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

		// Token: 0x0600269F RID: 9887 RVA: 0x000668A0 File Offset: 0x00064AA0
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

		// Token: 0x060026A0 RID: 9888 RVA: 0x000668DE File Offset: 0x00064ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AtomicProcessRemoveBuffResponse other)
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

		// Token: 0x060026A1 RID: 9889 RVA: 0x0006690F File Offset: 0x00064B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00066918 File Offset: 0x00064B18
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

		// Token: 0x04002624 RID: 9764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002625 RID: 9765
		public const int ErrorIdFieldNumber = 12;

		// Token: 0x04002626 RID: 9766
		private ErrorCode errorId_;
	}
}
