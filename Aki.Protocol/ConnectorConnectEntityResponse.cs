using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E3 RID: 739
	[NetMessage(EMessageId.ConnectorConnectEntityResponse)]
	public sealed class ConnectorConnectEntityResponse : IMessage<ConnectorConnectEntityResponse>, IMessage, IEquatable<ConnectorConnectEntityResponse>, IDeepCloneable<ConnectorConnectEntityResponse>, IBufferMessage
	{
		// Token: 0x06004B92 RID: 19346 RVA: 0x000B8944 File Offset: 0x000B6B44
		[NullableContext(1)]
		public static ConnectorConnectEntityResponse Create()
		{
			return new ConnectorConnectEntityResponse();
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x000B894B File Offset: 0x000B6B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x000B894E File Offset: 0x000B6B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorConnectEntityResponse.Descriptor;
			}
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x000B8955 File Offset: 0x000B6B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityResponse()
		{
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x000B895D File Offset: 0x000B6B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityResponse(ConnectorConnectEntityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x000B8982 File Offset: 0x000B6B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityResponse Clone()
		{
			return new ConnectorConnectEntityResponse(this);
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06004B98 RID: 19352 RVA: 0x000B898A File Offset: 0x000B6B8A
		// (set) Token: 0x06004B99 RID: 19353 RVA: 0x000B8992 File Offset: 0x000B6B92
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

		// Token: 0x06004B9A RID: 19354 RVA: 0x000B899B File Offset: 0x000B6B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorConnectEntityResponse);
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x000B89A9 File Offset: 0x000B6BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorConnectEntityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x000B89D8 File Offset: 0x000B6BD8
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

		// Token: 0x06004B9D RID: 19357 RVA: 0x000B8A1D File Offset: 0x000B6C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x000B8A2A File Offset: 0x000B6C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x000B8A33 File Offset: 0x000B6C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x000B8A68 File Offset: 0x000B6C68
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

		// Token: 0x06004BA1 RID: 19361 RVA: 0x000B8AA6 File Offset: 0x000B6CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectorConnectEntityResponse other)
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

		// Token: 0x06004BA2 RID: 19362 RVA: 0x000B8AD7 File Offset: 0x000B6CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x000B8AE0 File Offset: 0x000B6CE0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003121 RID: 12577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003122 RID: 12578
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003123 RID: 12579
		private ErrorCode errorCode_;
	}
}
