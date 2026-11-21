using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011E RID: 286
	[NetMessage(EMessageId.AtomicProcessRemoveBuffResponse)]
	public sealed class AtomicProcessRemoveBuffResponse : IMessage<AtomicProcessRemoveBuffResponse>, IMessage, IEquatable<AtomicProcessRemoveBuffResponse>, IDeepCloneable<AtomicProcessRemoveBuffResponse>, IBufferMessage
	{
		// Token: 0x060026F0 RID: 9968 RVA: 0x000677A1 File Offset: 0x000659A1
		[NullableContext(1)]
		public static AtomicProcessRemoveBuffResponse Create()
		{
			return new AtomicProcessRemoveBuffResponse();
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x000677A8 File Offset: 0x000659A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x000677AB File Offset: 0x000659AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AtomicProcessRemoveBuffResponse.Descriptor;
			}
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000677B2 File Offset: 0x000659B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffResponse()
		{
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000677BA File Offset: 0x000659BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffResponse(AtomicProcessRemoveBuffResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x000677DF File Offset: 0x000659DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AtomicProcessRemoveBuffResponse Clone()
		{
			return new AtomicProcessRemoveBuffResponse(this);
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x000677E7 File Offset: 0x000659E7
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x000677EF File Offset: 0x000659EF
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

		// Token: 0x060026F8 RID: 9976 RVA: 0x000677F8 File Offset: 0x000659F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AtomicProcessRemoveBuffResponse);
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00067806 File Offset: 0x00065A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AtomicProcessRemoveBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00067834 File Offset: 0x00065A34
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

		// Token: 0x060026FB RID: 9979 RVA: 0x00067879 File Offset: 0x00065A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00067886 File Offset: 0x00065A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x0006788F File Offset: 0x00065A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000678C4 File Offset: 0x00065AC4
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

		// Token: 0x060026FF RID: 9983 RVA: 0x00067902 File Offset: 0x00065B02
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

		// Token: 0x06002700 RID: 9984 RVA: 0x00067933 File Offset: 0x00065B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x0006793C File Offset: 0x00065B3C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400268F RID: 9871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002690 RID: 9872
		public const int ErrorIdFieldNumber = 10;

		// Token: 0x04002691 RID: 9873
		private ErrorCode errorId_;
	}
}
