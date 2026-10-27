using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000298 RID: 664
	[NetMessage(EMessageId.ClientBasicInfoRequest)]
	public sealed class ClientBasicInfoRequest : IMessage<ClientBasicInfoRequest>, IMessage, IEquatable<ClientBasicInfoRequest>, IDeepCloneable<ClientBasicInfoRequest>, IBufferMessage
	{
		// Token: 0x06004546 RID: 17734 RVA: 0x000AA7A1 File Offset: 0x000A89A1
		[NullableContext(1)]
		public static ClientBasicInfoRequest Create()
		{
			return new ClientBasicInfoRequest();
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x000AA7A8 File Offset: 0x000A89A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06004548 RID: 17736 RVA: 0x000AA7AB File Offset: 0x000A89AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientBasicInfoRequest.Descriptor;
			}
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x000AA7B2 File Offset: 0x000A89B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoRequest()
		{
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x000AA7BA File Offset: 0x000A89BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoRequest(ClientBasicInfoRequest other) : this()
		{
			this.clientBasicInfo_ = ((other.clientBasicInfo_ != null) ? other.clientBasicInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x000AA7EF File Offset: 0x000A89EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoRequest Clone()
		{
			return new ClientBasicInfoRequest(this);
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600454C RID: 17740 RVA: 0x000AA7F7 File Offset: 0x000A89F7
		// (set) Token: 0x0600454D RID: 17741 RVA: 0x000AA7FF File Offset: 0x000A89FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfo ClientBasicInfo
		{
			get
			{
				return this.clientBasicInfo_;
			}
			set
			{
				this.clientBasicInfo_ = value;
			}
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x000AA808 File Offset: 0x000A8A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientBasicInfoRequest);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x000AA816 File Offset: 0x000A8A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientBasicInfoRequest other)
		{
			return other != null && (other == this || (object.Equals(this.ClientBasicInfo, other.ClientBasicInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x000AA84C File Offset: 0x000A8A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.clientBasicInfo_ != null)
			{
				num ^= this.ClientBasicInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x000AA888 File Offset: 0x000A8A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x000AA895 File Offset: 0x000A8A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x000AA89E File Offset: 0x000A8A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.clientBasicInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ClientBasicInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x000AA8D0 File Offset: 0x000A8AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.clientBasicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientBasicInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x000AA910 File Offset: 0x000A8B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientBasicInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.clientBasicInfo_ != null)
			{
				if (this.clientBasicInfo_ == null)
				{
					this.ClientBasicInfo = new ClientBasicInfo();
				}
				this.ClientBasicInfo.MergeFrom(other.ClientBasicInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x000AA964 File Offset: 0x000A8B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x000AA970 File Offset: 0x000A8B70
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.clientBasicInfo_ == null)
					{
						this.ClientBasicInfo = new ClientBasicInfo();
					}
					input.ReadMessage(this.ClientBasicInfo);
				}
			}
		}

		// Token: 0x04002F04 RID: 12036
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F05 RID: 12037
		public const int ClientBasicInfoFieldNumber = 14;

		// Token: 0x04002F06 RID: 12038
		private ClientBasicInfo clientBasicInfo_;
	}
}
