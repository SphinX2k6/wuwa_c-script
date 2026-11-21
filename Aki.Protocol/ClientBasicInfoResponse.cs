using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029E RID: 670
	[NetMessage(EMessageId.ClientBasicInfoResponse)]
	public sealed class ClientBasicInfoResponse : IMessage<ClientBasicInfoResponse>, IMessage, IEquatable<ClientBasicInfoResponse>, IDeepCloneable<ClientBasicInfoResponse>, IBufferMessage
	{
		// Token: 0x06004601 RID: 17921 RVA: 0x000AC744 File Offset: 0x000AA944
		[NullableContext(1)]
		public static ClientBasicInfoResponse Create()
		{
			return new ClientBasicInfoResponse();
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06004602 RID: 17922 RVA: 0x000AC74B File Offset: 0x000AA94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06004603 RID: 17923 RVA: 0x000AC74E File Offset: 0x000AA94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientBasicInfoResponse.Descriptor;
			}
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x000AC755 File Offset: 0x000AA955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoResponse()
		{
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x000AC75D File Offset: 0x000AA95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoResponse(ClientBasicInfoResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x000AC776 File Offset: 0x000AA976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoResponse Clone()
		{
			return new ClientBasicInfoResponse(this);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x000AC77E File Offset: 0x000AA97E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientBasicInfoResponse);
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x000AC78C File Offset: 0x000AA98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientBasicInfoResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x000AC7AC File Offset: 0x000AA9AC
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

		// Token: 0x0600460A RID: 17930 RVA: 0x000AC7D2 File Offset: 0x000AA9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x000AC7DF File Offset: 0x000AA9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x000AC7E8 File Offset: 0x000AA9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x000AC800 File Offset: 0x000AAA00
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

		// Token: 0x0600460E RID: 17934 RVA: 0x000AC826 File Offset: 0x000AAA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientBasicInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x000AC843 File Offset: 0x000AAA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x000AC84C File Offset: 0x000AAA4C
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

		// Token: 0x04002F8D RID: 12173
		private UnknownFieldSet _unknownFields;
	}
}
