using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D3 RID: 5075
	[NetMessage(EMessageId.ThirdPartyShareResponse)]
	public sealed class ThirdPartyShareResponse : IMessage<ThirdPartyShareResponse>, IMessage, IEquatable<ThirdPartyShareResponse>, IDeepCloneable<ThirdPartyShareResponse>, IBufferMessage
	{
		// Token: 0x0601B010 RID: 110608 RVA: 0x003EEB51 File Offset: 0x003ECD51
		[NullableContext(1)]
		public static ThirdPartyShareResponse Create()
		{
			return new ThirdPartyShareResponse();
		}

		// Token: 0x17005B75 RID: 23413
		// (get) Token: 0x0601B011 RID: 110609 RVA: 0x003EEB58 File Offset: 0x003ECD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B76 RID: 23414
		// (get) Token: 0x0601B012 RID: 110610 RVA: 0x003EEB5B File Offset: 0x003ECD5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThirdPartyShareResponse.Descriptor;
			}
		}

		// Token: 0x0601B013 RID: 110611 RVA: 0x003EEB62 File Offset: 0x003ECD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareResponse()
		{
		}

		// Token: 0x0601B014 RID: 110612 RVA: 0x003EEB6A File Offset: 0x003ECD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareResponse(ThirdPartyShareResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B015 RID: 110613 RVA: 0x003EEB8F File Offset: 0x003ECD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThirdPartyShareResponse Clone()
		{
			return new ThirdPartyShareResponse(this);
		}

		// Token: 0x17005B77 RID: 23415
		// (get) Token: 0x0601B016 RID: 110614 RVA: 0x003EEB97 File Offset: 0x003ECD97
		// (set) Token: 0x0601B017 RID: 110615 RVA: 0x003EEB9F File Offset: 0x003ECD9F
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

		// Token: 0x0601B018 RID: 110616 RVA: 0x003EEBA8 File Offset: 0x003ECDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThirdPartyShareResponse);
		}

		// Token: 0x0601B019 RID: 110617 RVA: 0x003EEBB6 File Offset: 0x003ECDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThirdPartyShareResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B01A RID: 110618 RVA: 0x003EEBE4 File Offset: 0x003ECDE4
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

		// Token: 0x0601B01B RID: 110619 RVA: 0x003EEC29 File Offset: 0x003ECE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B01C RID: 110620 RVA: 0x003EEC36 File Offset: 0x003ECE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B01D RID: 110621 RVA: 0x003EEC3F File Offset: 0x003ECE3F
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

		// Token: 0x0601B01E RID: 110622 RVA: 0x003EEC74 File Offset: 0x003ECE74
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

		// Token: 0x0601B01F RID: 110623 RVA: 0x003EECB2 File Offset: 0x003ECEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThirdPartyShareResponse other)
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

		// Token: 0x0601B020 RID: 110624 RVA: 0x003EECE3 File Offset: 0x003ECEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B021 RID: 110625 RVA: 0x003EECEC File Offset: 0x003ECEEC
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

		// Token: 0x04009DD1 RID: 40401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DD2 RID: 40402
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009DD3 RID: 40403
		private ErrorCode errorCode_;
	}
}
