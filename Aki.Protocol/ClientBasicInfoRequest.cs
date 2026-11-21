using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029D RID: 669
	[NetMessage(EMessageId.ClientBasicInfoRequest)]
	public sealed class ClientBasicInfoRequest : IMessage<ClientBasicInfoRequest>, IMessage, IEquatable<ClientBasicInfoRequest>, IDeepCloneable<ClientBasicInfoRequest>, IBufferMessage
	{
		// Token: 0x060045EF RID: 17903 RVA: 0x000AC520 File Offset: 0x000AA720
		[NullableContext(1)]
		public static ClientBasicInfoRequest Create()
		{
			return new ClientBasicInfoRequest();
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x000AC527 File Offset: 0x000AA727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060045F1 RID: 17905 RVA: 0x000AC52A File Offset: 0x000AA72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientBasicInfoRequest.Descriptor;
			}
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x000AC531 File Offset: 0x000AA731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoRequest()
		{
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x000AC539 File Offset: 0x000AA739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoRequest(ClientBasicInfoRequest other) : this()
		{
			this.clientBasicInfo_ = ((other.clientBasicInfo_ != null) ? other.clientBasicInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x000AC56E File Offset: 0x000AA76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientBasicInfoRequest Clone()
		{
			return new ClientBasicInfoRequest(this);
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x000AC576 File Offset: 0x000AA776
		// (set) Token: 0x060045F6 RID: 17910 RVA: 0x000AC57E File Offset: 0x000AA77E
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

		// Token: 0x060045F7 RID: 17911 RVA: 0x000AC587 File Offset: 0x000AA787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientBasicInfoRequest);
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x000AC595 File Offset: 0x000AA795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientBasicInfoRequest other)
		{
			return other != null && (other == this || (object.Equals(this.ClientBasicInfo, other.ClientBasicInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x000AC5C8 File Offset: 0x000AA7C8
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

		// Token: 0x060045FA RID: 17914 RVA: 0x000AC604 File Offset: 0x000AA804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x000AC611 File Offset: 0x000AA811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x000AC61A File Offset: 0x000AA81A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.clientBasicInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ClientBasicInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x000AC64C File Offset: 0x000AA84C
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

		// Token: 0x060045FE RID: 17918 RVA: 0x000AC68C File Offset: 0x000AA88C
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

		// Token: 0x060045FF RID: 17919 RVA: 0x000AC6E0 File Offset: 0x000AA8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x000AC6EC File Offset: 0x000AA8EC
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
				if (num != 34U)
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

		// Token: 0x04002F8A RID: 12170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F8B RID: 12171
		public const int ClientBasicInfoFieldNumber = 4;

		// Token: 0x04002F8C RID: 12172
		private ClientBasicInfo clientBasicInfo_;
	}
}
