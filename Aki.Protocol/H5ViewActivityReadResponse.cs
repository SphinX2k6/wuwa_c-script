using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200071D RID: 1821
	[NetMessage(EMessageId.H5ViewActivityReadResponse)]
	public sealed class H5ViewActivityReadResponse : IMessage<H5ViewActivityReadResponse>, IMessage, IEquatable<H5ViewActivityReadResponse>, IDeepCloneable<H5ViewActivityReadResponse>, IBufferMessage
	{
		// Token: 0x0600A5AE RID: 42414 RVA: 0x0018F9B9 File Offset: 0x0018DBB9
		[NullableContext(1)]
		public static H5ViewActivityReadResponse Create()
		{
			return new H5ViewActivityReadResponse();
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x0600A5AF RID: 42415 RVA: 0x0018F9C0 File Offset: 0x0018DBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x0600A5B0 RID: 42416 RVA: 0x0018F9C3 File Offset: 0x0018DBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5ViewActivityReadResponse.Descriptor;
			}
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x0018F9CA File Offset: 0x0018DBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadResponse()
		{
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x0018F9D2 File Offset: 0x0018DBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadResponse(H5ViewActivityReadResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x0018F9EB File Offset: 0x0018DBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadResponse Clone()
		{
			return new H5ViewActivityReadResponse(this);
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x0018F9F3 File Offset: 0x0018DBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5ViewActivityReadResponse);
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x0018FA01 File Offset: 0x0018DC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5ViewActivityReadResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x0018FA20 File Offset: 0x0018DC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x0018FA46 File Offset: 0x0018DC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x0018FA53 File Offset: 0x0018DC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x0018FA5C File Offset: 0x0018DC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x0018FA74 File Offset: 0x0018DC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x0018FA9A File Offset: 0x0018DC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5ViewActivityReadResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x0018FAB7 File Offset: 0x0018DCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x0018FAC0 File Offset: 0x0018DCC0
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C6D RID: 19565
		private UnknownFieldSet _unknownFields;
	}
}
