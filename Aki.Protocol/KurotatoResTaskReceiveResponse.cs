using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A2 RID: 2210
	[NetMessage(EMessageId.KurotatoResTaskReceiveResponse)]
	public sealed class KurotatoResTaskReceiveResponse : IMessage<KurotatoResTaskReceiveResponse>, IMessage, IEquatable<KurotatoResTaskReceiveResponse>, IDeepCloneable<KurotatoResTaskReceiveResponse>, IBufferMessage
	{
		// Token: 0x0600C485 RID: 50309 RVA: 0x001D1E11 File Offset: 0x001D0011
		[NullableContext(1)]
		public static KurotatoResTaskReceiveResponse Create()
		{
			return new KurotatoResTaskReceiveResponse();
		}

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600C486 RID: 50310 RVA: 0x001D1E18 File Offset: 0x001D0018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600C487 RID: 50311 RVA: 0x001D1E1B File Offset: 0x001D001B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoResTaskReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600C488 RID: 50312 RVA: 0x001D1E22 File Offset: 0x001D0022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveResponse()
		{
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x001D1E2A File Offset: 0x001D002A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveResponse(KurotatoResTaskReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x001D1E4F File Offset: 0x001D004F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskReceiveResponse Clone()
		{
			return new KurotatoResTaskReceiveResponse(this);
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x0600C48B RID: 50315 RVA: 0x001D1E57 File Offset: 0x001D0057
		// (set) Token: 0x0600C48C RID: 50316 RVA: 0x001D1E5F File Offset: 0x001D005F
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

		// Token: 0x0600C48D RID: 50317 RVA: 0x001D1E68 File Offset: 0x001D0068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoResTaskReceiveResponse);
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x001D1E76 File Offset: 0x001D0076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoResTaskReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x001D1EA4 File Offset: 0x001D00A4
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

		// Token: 0x0600C490 RID: 50320 RVA: 0x001D1EE9 File Offset: 0x001D00E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x001D1EF6 File Offset: 0x001D00F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C492 RID: 50322 RVA: 0x001D1EFF File Offset: 0x001D00FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C493 RID: 50323 RVA: 0x001D1F34 File Offset: 0x001D0134
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

		// Token: 0x0600C494 RID: 50324 RVA: 0x001D1F72 File Offset: 0x001D0172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoResTaskReceiveResponse other)
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

		// Token: 0x0600C495 RID: 50325 RVA: 0x001D1FA3 File Offset: 0x001D01A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C496 RID: 50326 RVA: 0x001D1FAC File Offset: 0x001D01AC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005508 RID: 21768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005509 RID: 21769
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400550A RID: 21770
		private ErrorCode errorCode_;
	}
}
