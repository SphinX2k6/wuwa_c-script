using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072D RID: 1837
	[NetMessage(EMessageId.H5CircumFluenceActivityReadResponse)]
	public sealed class H5CircumFluenceActivityReadResponse : IMessage<H5CircumFluenceActivityReadResponse>, IMessage, IEquatable<H5CircumFluenceActivityReadResponse>, IDeepCloneable<H5CircumFluenceActivityReadResponse>, IBufferMessage
	{
		// Token: 0x0600A6BC RID: 42684 RVA: 0x00191C3A File Offset: 0x0018FE3A
		[NullableContext(1)]
		public static H5CircumFluenceActivityReadResponse Create()
		{
			return new H5CircumFluenceActivityReadResponse();
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x0600A6BD RID: 42685 RVA: 0x00191C41 File Offset: 0x0018FE41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x0600A6BE RID: 42686 RVA: 0x00191C44 File Offset: 0x0018FE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5CircumFluenceActivityReadResponse.Descriptor;
			}
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x00191C4B File Offset: 0x0018FE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadResponse()
		{
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x00191C53 File Offset: 0x0018FE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadResponse(H5CircumFluenceActivityReadResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x00191C6C File Offset: 0x0018FE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadResponse Clone()
		{
			return new H5CircumFluenceActivityReadResponse(this);
		}

		// Token: 0x0600A6C2 RID: 42690 RVA: 0x00191C74 File Offset: 0x0018FE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5CircumFluenceActivityReadResponse);
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x00191C82 File Offset: 0x0018FE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5CircumFluenceActivityReadResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A6C4 RID: 42692 RVA: 0x00191CA0 File Offset: 0x0018FEA0
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

		// Token: 0x0600A6C5 RID: 42693 RVA: 0x00191CC6 File Offset: 0x0018FEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6C6 RID: 42694 RVA: 0x00191CD3 File Offset: 0x0018FED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6C7 RID: 42695 RVA: 0x00191CDC File Offset: 0x0018FEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6C8 RID: 42696 RVA: 0x00191CF4 File Offset: 0x0018FEF4
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

		// Token: 0x0600A6C9 RID: 42697 RVA: 0x00191D1A File Offset: 0x0018FF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5CircumFluenceActivityReadResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6CA RID: 42698 RVA: 0x00191D37 File Offset: 0x0018FF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6CB RID: 42699 RVA: 0x00191D40 File Offset: 0x0018FF40
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

		// Token: 0x04004C68 RID: 19560
		private UnknownFieldSet _unknownFields;
	}
}
