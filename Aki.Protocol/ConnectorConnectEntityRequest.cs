using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DB RID: 731
	[NetMessage(EMessageId.ConnectorConnectEntityRequest)]
	public sealed class ConnectorConnectEntityRequest : IMessage<ConnectorConnectEntityRequest>, IMessage, IEquatable<ConnectorConnectEntityRequest>, IDeepCloneable<ConnectorConnectEntityRequest>, IBufferMessage
	{
		// Token: 0x06004AA7 RID: 19111 RVA: 0x000B6335 File Offset: 0x000B4535
		[NullableContext(1)]
		public static ConnectorConnectEntityRequest Create()
		{
			return new ConnectorConnectEntityRequest();
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x000B633C File Offset: 0x000B453C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06004AA9 RID: 19113 RVA: 0x000B633F File Offset: 0x000B453F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorConnectEntityRequest.Descriptor;
			}
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x000B6346 File Offset: 0x000B4546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityRequest()
		{
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x000B634E File Offset: 0x000B454E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityRequest(ConnectorConnectEntityRequest other) : this()
		{
			this.connectEntityInfo_ = ((other.connectEntityInfo_ != null) ? other.connectEntityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x000B6383 File Offset: 0x000B4583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityRequest Clone()
		{
			return new ConnectorConnectEntityRequest(this);
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06004AAD RID: 19117 RVA: 0x000B638B File Offset: 0x000B458B
		// (set) Token: 0x06004AAE RID: 19118 RVA: 0x000B6393 File Offset: 0x000B4593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectEntityInfo ConnectEntityInfo
		{
			get
			{
				return this.connectEntityInfo_;
			}
			set
			{
				this.connectEntityInfo_ = value;
			}
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x000B639C File Offset: 0x000B459C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorConnectEntityRequest);
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x000B63AA File Offset: 0x000B45AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorConnectEntityRequest other)
		{
			return other != null && (other == this || (object.Equals(this.ConnectEntityInfo, other.ConnectEntityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x000B63E0 File Offset: 0x000B45E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.connectEntityInfo_ != null)
			{
				num ^= this.ConnectEntityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x000B641C File Offset: 0x000B461C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x000B6429 File Offset: 0x000B4629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x000B6432 File Offset: 0x000B4632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.connectEntityInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ConnectEntityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x000B6464 File Offset: 0x000B4664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.connectEntityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConnectEntityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x000B64A4 File Offset: 0x000B46A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectorConnectEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.connectEntityInfo_ != null)
			{
				if (this.connectEntityInfo_ == null)
				{
					this.ConnectEntityInfo = new ConnectEntityInfo();
				}
				this.ConnectEntityInfo.MergeFrom(other.ConnectEntityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x000B64F8 File Offset: 0x000B46F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x000B6504 File Offset: 0x000B4704
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.connectEntityInfo_ == null)
					{
						this.ConnectEntityInfo = new ConnectEntityInfo();
					}
					input.ReadMessage(this.ConnectEntityInfo);
				}
			}
		}

		// Token: 0x04003087 RID: 12423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003088 RID: 12424
		public const int ConnectEntityInfoFieldNumber = 13;

		// Token: 0x04003089 RID: 12425
		private ConnectEntityInfo connectEntityInfo_;
	}
}
