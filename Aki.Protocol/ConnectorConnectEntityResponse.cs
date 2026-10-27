using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DC RID: 732
	[NetMessage(EMessageId.ConnectorConnectEntityResponse)]
	public sealed class ConnectorConnectEntityResponse : IMessage<ConnectorConnectEntityResponse>, IMessage, IEquatable<ConnectorConnectEntityResponse>, IDeepCloneable<ConnectorConnectEntityResponse>, IBufferMessage
	{
		// Token: 0x06004AB9 RID: 19129 RVA: 0x000B655C File Offset: 0x000B475C
		[NullableContext(1)]
		public static ConnectorConnectEntityResponse Create()
		{
			return new ConnectorConnectEntityResponse();
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06004ABA RID: 19130 RVA: 0x000B6563 File Offset: 0x000B4763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x000B6566 File Offset: 0x000B4766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorConnectEntityResponse.Descriptor;
			}
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x000B656D File Offset: 0x000B476D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityResponse()
		{
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x000B6575 File Offset: 0x000B4775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityResponse(ConnectorConnectEntityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x000B659A File Offset: 0x000B479A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorConnectEntityResponse Clone()
		{
			return new ConnectorConnectEntityResponse(this);
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06004ABF RID: 19135 RVA: 0x000B65A2 File Offset: 0x000B47A2
		// (set) Token: 0x06004AC0 RID: 19136 RVA: 0x000B65AA File Offset: 0x000B47AA
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

		// Token: 0x06004AC1 RID: 19137 RVA: 0x000B65B3 File Offset: 0x000B47B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorConnectEntityResponse);
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x000B65C1 File Offset: 0x000B47C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorConnectEntityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x000B65F0 File Offset: 0x000B47F0
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

		// Token: 0x06004AC4 RID: 19140 RVA: 0x000B6635 File Offset: 0x000B4835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x000B6642 File Offset: 0x000B4842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x000B664B File Offset: 0x000B484B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x000B6680 File Offset: 0x000B4880
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

		// Token: 0x06004AC8 RID: 19144 RVA: 0x000B66BE File Offset: 0x000B48BE
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

		// Token: 0x06004AC9 RID: 19145 RVA: 0x000B66EF File Offset: 0x000B48EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x000B66F8 File Offset: 0x000B48F8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400308A RID: 12426
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400308B RID: 12427
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400308C RID: 12428
		private ErrorCode errorCode_;
	}
}
