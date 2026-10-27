using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000731 RID: 1841
	[NetMessage(EMessageId.H5ViewActivityReadResponse)]
	public sealed class H5ViewActivityReadResponse : IMessage<H5ViewActivityReadResponse>, IMessage, IEquatable<H5ViewActivityReadResponse>, IDeepCloneable<H5ViewActivityReadResponse>, IBufferMessage
	{
		// Token: 0x0600A704 RID: 42756 RVA: 0x001923ED File Offset: 0x001905ED
		[NullableContext(1)]
		public static H5ViewActivityReadResponse Create()
		{
			return new H5ViewActivityReadResponse();
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x0600A705 RID: 42757 RVA: 0x001923F4 File Offset: 0x001905F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x0600A706 RID: 42758 RVA: 0x001923F7 File Offset: 0x001905F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5ViewActivityReadResponse.Descriptor;
			}
		}

		// Token: 0x0600A707 RID: 42759 RVA: 0x001923FE File Offset: 0x001905FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadResponse()
		{
		}

		// Token: 0x0600A708 RID: 42760 RVA: 0x00192406 File Offset: 0x00190606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadResponse(H5ViewActivityReadResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A709 RID: 42761 RVA: 0x0019241F File Offset: 0x0019061F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5ViewActivityReadResponse Clone()
		{
			return new H5ViewActivityReadResponse(this);
		}

		// Token: 0x0600A70A RID: 42762 RVA: 0x00192427 File Offset: 0x00190627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5ViewActivityReadResponse);
		}

		// Token: 0x0600A70B RID: 42763 RVA: 0x00192435 File Offset: 0x00190635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5ViewActivityReadResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A70C RID: 42764 RVA: 0x00192454 File Offset: 0x00190654
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

		// Token: 0x0600A70D RID: 42765 RVA: 0x0019247A File Offset: 0x0019067A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A70E RID: 42766 RVA: 0x00192487 File Offset: 0x00190687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A70F RID: 42767 RVA: 0x00192490 File Offset: 0x00190690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A710 RID: 42768 RVA: 0x001924A8 File Offset: 0x001906A8
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

		// Token: 0x0600A711 RID: 42769 RVA: 0x001924CE File Offset: 0x001906CE
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

		// Token: 0x0600A712 RID: 42770 RVA: 0x001924EB File Offset: 0x001906EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A713 RID: 42771 RVA: 0x001924F4 File Offset: 0x001906F4
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

		// Token: 0x04004C74 RID: 19572
		private UnknownFieldSet _unknownFields;
	}
}
