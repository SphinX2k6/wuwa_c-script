using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DF RID: 735
	[NetMessage(EMessageId.ConnectorCanConnectResponse)]
	public sealed class ConnectorCanConnectResponse : IMessage<ConnectorCanConnectResponse>, IMessage, IEquatable<ConnectorCanConnectResponse>, IDeepCloneable<ConnectorCanConnectResponse>, IBufferMessage
	{
		// Token: 0x06004B4A RID: 19274 RVA: 0x000B8190 File Offset: 0x000B6390
		[NullableContext(1)]
		public static ConnectorCanConnectResponse Create()
		{
			return new ConnectorCanConnectResponse();
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06004B4B RID: 19275 RVA: 0x000B8197 File Offset: 0x000B6397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x000B819A File Offset: 0x000B639A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorCanConnectResponse.Descriptor;
			}
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x000B81A1 File Offset: 0x000B63A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectResponse()
		{
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x000B81A9 File Offset: 0x000B63A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectResponse(ConnectorCanConnectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x000B81CE File Offset: 0x000B63CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectResponse Clone()
		{
			return new ConnectorCanConnectResponse(this);
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06004B50 RID: 19280 RVA: 0x000B81D6 File Offset: 0x000B63D6
		// (set) Token: 0x06004B51 RID: 19281 RVA: 0x000B81DE File Offset: 0x000B63DE
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

		// Token: 0x06004B52 RID: 19282 RVA: 0x000B81E7 File Offset: 0x000B63E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorCanConnectResponse);
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x000B81F5 File Offset: 0x000B63F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorCanConnectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x000B8224 File Offset: 0x000B6424
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

		// Token: 0x06004B55 RID: 19285 RVA: 0x000B8269 File Offset: 0x000B6469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x000B8276 File Offset: 0x000B6476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x000B827F File Offset: 0x000B647F
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

		// Token: 0x06004B58 RID: 19288 RVA: 0x000B82B4 File Offset: 0x000B64B4
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

		// Token: 0x06004B59 RID: 19289 RVA: 0x000B82F2 File Offset: 0x000B64F2
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

		// Token: 0x06004B5A RID: 19290 RVA: 0x000B8323 File Offset: 0x000B6523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x000B832C File Offset: 0x000B652C
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

		// Token: 0x04003114 RID: 12564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003115 RID: 12565
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003116 RID: 12566
		private ErrorCode errorCode_;
	}
}
