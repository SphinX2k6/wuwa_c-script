using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001053 RID: 4179
	[NetMessage(EMessageId.RogueWhiteCatRecordResponse)]
	public sealed class RogueWhiteCatRecordResponse : IMessage<RogueWhiteCatRecordResponse>, IMessage, IEquatable<RogueWhiteCatRecordResponse>, IDeepCloneable<RogueWhiteCatRecordResponse>, IBufferMessage
	{
		// Token: 0x06016544 RID: 91460 RVA: 0x0033E9B8 File Offset: 0x0033CBB8
		[NullableContext(1)]
		public static RogueWhiteCatRecordResponse Create()
		{
			return new RogueWhiteCatRecordResponse();
		}

		// Token: 0x17004AAF RID: 19119
		// (get) Token: 0x06016545 RID: 91461 RVA: 0x0033E9BF File Offset: 0x0033CBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AB0 RID: 19120
		// (get) Token: 0x06016546 RID: 91462 RVA: 0x0033E9C2 File Offset: 0x0033CBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatRecordResponse.Descriptor;
			}
		}

		// Token: 0x06016547 RID: 91463 RVA: 0x0033E9C9 File Offset: 0x0033CBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordResponse()
		{
		}

		// Token: 0x06016548 RID: 91464 RVA: 0x0033E9D1 File Offset: 0x0033CBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordResponse(RogueWhiteCatRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016549 RID: 91465 RVA: 0x0033E9F6 File Offset: 0x0033CBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatRecordResponse Clone()
		{
			return new RogueWhiteCatRecordResponse(this);
		}

		// Token: 0x17004AB1 RID: 19121
		// (get) Token: 0x0601654A RID: 91466 RVA: 0x0033E9FE File Offset: 0x0033CBFE
		// (set) Token: 0x0601654B RID: 91467 RVA: 0x0033EA06 File Offset: 0x0033CC06
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

		// Token: 0x0601654C RID: 91468 RVA: 0x0033EA0F File Offset: 0x0033CC0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatRecordResponse);
		}

		// Token: 0x0601654D RID: 91469 RVA: 0x0033EA1D File Offset: 0x0033CC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601654E RID: 91470 RVA: 0x0033EA4C File Offset: 0x0033CC4C
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

		// Token: 0x0601654F RID: 91471 RVA: 0x0033EA91 File Offset: 0x0033CC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016550 RID: 91472 RVA: 0x0033EA9E File Offset: 0x0033CC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016551 RID: 91473 RVA: 0x0033EAA7 File Offset: 0x0033CCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016552 RID: 91474 RVA: 0x0033EADC File Offset: 0x0033CCDC
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

		// Token: 0x06016553 RID: 91475 RVA: 0x0033EB1A File Offset: 0x0033CD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatRecordResponse other)
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

		// Token: 0x06016554 RID: 91476 RVA: 0x0033EB4B File Offset: 0x0033CD4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016555 RID: 91477 RVA: 0x0033EB54 File Offset: 0x0033CD54
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008591 RID: 34193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008592 RID: 34194
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04008593 RID: 34195
		private ErrorCode errorCode_;
	}
}
