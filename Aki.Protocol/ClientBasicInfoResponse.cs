using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000299 RID: 665
	[NetMessage(EMessageId.ClientBasicInfoResponse)]
	public sealed class ClientBasicInfoResponse : IMessage<ClientBasicInfoResponse>, IMessage, IEquatable<ClientBasicInfoResponse>, IDeepCloneable<ClientBasicInfoResponse>, IBufferMessage
	{
		// Token: 0x06004558 RID: 17752 RVA: 0x000AA9C8 File Offset: 0x000A8BC8
		[NullableContext(1)]
		public static ClientBasicInfoResponse Create()
		{
			return new ClientBasicInfoResponse();
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06004559 RID: 17753 RVA: 0x000AA9CF File Offset: 0x000A8BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600455A RID: 17754 RVA: 0x000AA9D2 File Offset: 0x000A8BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientBasicInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x000AA9D9 File Offset: 0x000A8BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoResponse()
		{
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x000AA9E1 File Offset: 0x000A8BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoResponse(ClientBasicInfoResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x000AA9FA File Offset: 0x000A8BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoResponse Clone()
		{
			return new ClientBasicInfoResponse(this);
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x000AAA02 File Offset: 0x000A8C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientBasicInfoResponse);
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x000AAA10 File Offset: 0x000A8C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientBasicInfoResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x000AAA30 File Offset: 0x000A8C30
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

		// Token: 0x06004561 RID: 17761 RVA: 0x000AAA56 File Offset: 0x000A8C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x000AAA63 File Offset: 0x000A8C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x000AAA6C File Offset: 0x000A8C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x000AAA84 File Offset: 0x000A8C84
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

		// Token: 0x06004565 RID: 17765 RVA: 0x000AAAAA File Offset: 0x000A8CAA
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

		// Token: 0x06004566 RID: 17766 RVA: 0x000AAAC7 File Offset: 0x000A8CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x000AAAD0 File Offset: 0x000A8CD0
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

		// Token: 0x04002F07 RID: 12039
		private UnknownFieldSet _unknownFields;
	}
}
