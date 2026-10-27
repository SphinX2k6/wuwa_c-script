using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072C RID: 1836
	[NetMessage(EMessageId.H5CircumFluenceActivityReadRequest)]
	public sealed class H5CircumFluenceActivityReadRequest : IMessage<H5CircumFluenceActivityReadRequest>, IMessage, IEquatable<H5CircumFluenceActivityReadRequest>, IDeepCloneable<H5CircumFluenceActivityReadRequest>, IBufferMessage
	{
		// Token: 0x0600A6AC RID: 42668 RVA: 0x00191B00 File Offset: 0x0018FD00
		[NullableContext(1)]
		public static H5CircumFluenceActivityReadRequest Create()
		{
			return new H5CircumFluenceActivityReadRequest();
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x0600A6AD RID: 42669 RVA: 0x00191B07 File Offset: 0x0018FD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x0600A6AE RID: 42670 RVA: 0x00191B0A File Offset: 0x0018FD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5CircumFluenceActivityReadRequest.Descriptor;
			}
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x00191B11 File Offset: 0x0018FD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadRequest()
		{
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x00191B19 File Offset: 0x0018FD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadRequest(H5CircumFluenceActivityReadRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x00191B32 File Offset: 0x0018FD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityReadRequest Clone()
		{
			return new H5CircumFluenceActivityReadRequest(this);
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x00191B3A File Offset: 0x0018FD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5CircumFluenceActivityReadRequest);
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x00191B48 File Offset: 0x0018FD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5CircumFluenceActivityReadRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A6B4 RID: 42676 RVA: 0x00191B68 File Offset: 0x0018FD68
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

		// Token: 0x0600A6B5 RID: 42677 RVA: 0x00191B8E File Offset: 0x0018FD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6B6 RID: 42678 RVA: 0x00191B9B File Offset: 0x0018FD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6B7 RID: 42679 RVA: 0x00191BA4 File Offset: 0x0018FDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6B8 RID: 42680 RVA: 0x00191BBC File Offset: 0x0018FDBC
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

		// Token: 0x0600A6B9 RID: 42681 RVA: 0x00191BE2 File Offset: 0x0018FDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5CircumFluenceActivityReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x00191BFF File Offset: 0x0018FDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x00191C08 File Offset: 0x0018FE08
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

		// Token: 0x04004C67 RID: 19559
		private UnknownFieldSet _unknownFields;
	}
}
