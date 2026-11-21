using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E1 RID: 4577
	[NetMessage(EMessageId.SeamlessTeleportResponse)]
	public sealed class SeamlessTeleportResponse : IMessage<SeamlessTeleportResponse>, IMessage, IEquatable<SeamlessTeleportResponse>, IDeepCloneable<SeamlessTeleportResponse>, IBufferMessage
	{
		// Token: 0x060186E9 RID: 100073 RVA: 0x0038E797 File Offset: 0x0038C997
		[NullableContext(1)]
		public static SeamlessTeleportResponse Create()
		{
			return new SeamlessTeleportResponse();
		}

		// Token: 0x1700525C RID: 21084
		// (get) Token: 0x060186EA RID: 100074 RVA: 0x0038E79E File Offset: 0x0038C99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700525D RID: 21085
		// (get) Token: 0x060186EB RID: 100075 RVA: 0x0038E7A1 File Offset: 0x0038C9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportResponse.Descriptor;
			}
		}

		// Token: 0x060186EC RID: 100076 RVA: 0x0038E7A8 File Offset: 0x0038C9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportResponse()
		{
		}

		// Token: 0x060186ED RID: 100077 RVA: 0x0038E7B0 File Offset: 0x0038C9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportResponse(SeamlessTeleportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060186EE RID: 100078 RVA: 0x0038E7D5 File Offset: 0x0038C9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportResponse Clone()
		{
			return new SeamlessTeleportResponse(this);
		}

		// Token: 0x1700525E RID: 21086
		// (get) Token: 0x060186EF RID: 100079 RVA: 0x0038E7DD File Offset: 0x0038C9DD
		// (set) Token: 0x060186F0 RID: 100080 RVA: 0x0038E7E5 File Offset: 0x0038C9E5
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

		// Token: 0x060186F1 RID: 100081 RVA: 0x0038E7EE File Offset: 0x0038C9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportResponse);
		}

		// Token: 0x060186F2 RID: 100082 RVA: 0x0038E7FC File Offset: 0x0038C9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186F3 RID: 100083 RVA: 0x0038E82C File Offset: 0x0038CA2C
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

		// Token: 0x060186F4 RID: 100084 RVA: 0x0038E871 File Offset: 0x0038CA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060186F5 RID: 100085 RVA: 0x0038E87E File Offset: 0x0038CA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060186F6 RID: 100086 RVA: 0x0038E887 File Offset: 0x0038CA87
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

		// Token: 0x060186F7 RID: 100087 RVA: 0x0038E8BC File Offset: 0x0038CABC
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

		// Token: 0x060186F8 RID: 100088 RVA: 0x0038E8FA File Offset: 0x0038CAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportResponse other)
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

		// Token: 0x060186F9 RID: 100089 RVA: 0x0038E92B File Offset: 0x0038CB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186FA RID: 100090 RVA: 0x0038E934 File Offset: 0x0038CB34
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

		// Token: 0x0400911D RID: 37149
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400911E RID: 37150
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400911F RID: 37151
		private ErrorCode errorCode_;
	}
}
