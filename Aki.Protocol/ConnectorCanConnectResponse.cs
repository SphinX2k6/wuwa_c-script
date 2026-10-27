using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D8 RID: 728
	[NetMessage(EMessageId.ConnectorCanConnectResponse)]
	public sealed class ConnectorCanConnectResponse : IMessage<ConnectorCanConnectResponse>, IMessage, IEquatable<ConnectorCanConnectResponse>, IDeepCloneable<ConnectorCanConnectResponse>, IBufferMessage
	{
		// Token: 0x06004A71 RID: 19057 RVA: 0x000B5DA8 File Offset: 0x000B3FA8
		[NullableContext(1)]
		public static ConnectorCanConnectResponse Create()
		{
			return new ConnectorCanConnectResponse();
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x000B5DAF File Offset: 0x000B3FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06004A73 RID: 19059 RVA: 0x000B5DB2 File Offset: 0x000B3FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorCanConnectResponse.Descriptor;
			}
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x000B5DB9 File Offset: 0x000B3FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectResponse()
		{
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x000B5DC1 File Offset: 0x000B3FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectResponse(ConnectorCanConnectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x000B5DE6 File Offset: 0x000B3FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectResponse Clone()
		{
			return new ConnectorCanConnectResponse(this);
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x000B5DEE File Offset: 0x000B3FEE
		// (set) Token: 0x06004A78 RID: 19064 RVA: 0x000B5DF6 File Offset: 0x000B3FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x000B5DFF File Offset: 0x000B3FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorCanConnectResponse);
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x000B5E0D File Offset: 0x000B400D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorCanConnectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x000B5E3C File Offset: 0x000B403C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x000B5E81 File Offset: 0x000B4081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x000B5E8E File Offset: 0x000B408E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x000B5E97 File Offset: 0x000B4097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x000B5ECC File Offset: 0x000B40CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x000B5F0A File Offset: 0x000B410A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectorCanConnectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x000B5F3B File Offset: 0x000B413B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x000B5F44 File Offset: 0x000B4144
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400307D RID: 12413
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400307E RID: 12414
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400307F RID: 12415
		private ErrorCode errorCode_;
	}
}
