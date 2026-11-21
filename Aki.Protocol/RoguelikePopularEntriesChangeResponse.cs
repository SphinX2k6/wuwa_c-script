using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F96 RID: 3990
	[NetMessage(EMessageId.RoguelikePopularEntriesChangeResponse)]
	public sealed class RoguelikePopularEntriesChangeResponse : IMessage<RoguelikePopularEntriesChangeResponse>, IMessage, IEquatable<RoguelikePopularEntriesChangeResponse>, IDeepCloneable<RoguelikePopularEntriesChangeResponse>, IBufferMessage
	{
		// Token: 0x060155E0 RID: 87520 RVA: 0x0031AA9E File Offset: 0x00318C9E
		[NullableContext(1)]
		public static RoguelikePopularEntriesChangeResponse Create()
		{
			return new RoguelikePopularEntriesChangeResponse();
		}

		// Token: 0x17004741 RID: 18241
		// (get) Token: 0x060155E1 RID: 87521 RVA: 0x0031AAA5 File Offset: 0x00318CA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004742 RID: 18242
		// (get) Token: 0x060155E2 RID: 87522 RVA: 0x0031AAA8 File Offset: 0x00318CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikePopularEntriesChangeResponse.Descriptor;
			}
		}

		// Token: 0x060155E3 RID: 87523 RVA: 0x0031AAAF File Offset: 0x00318CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeResponse()
		{
		}

		// Token: 0x060155E4 RID: 87524 RVA: 0x0031AAB7 File Offset: 0x00318CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeResponse(RoguelikePopularEntriesChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060155E5 RID: 87525 RVA: 0x0031AADC File Offset: 0x00318CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikePopularEntriesChangeResponse Clone()
		{
			return new RoguelikePopularEntriesChangeResponse(this);
		}

		// Token: 0x17004743 RID: 18243
		// (get) Token: 0x060155E6 RID: 87526 RVA: 0x0031AAE4 File Offset: 0x00318CE4
		// (set) Token: 0x060155E7 RID: 87527 RVA: 0x0031AAEC File Offset: 0x00318CEC
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

		// Token: 0x060155E8 RID: 87528 RVA: 0x0031AAF5 File Offset: 0x00318CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikePopularEntriesChangeResponse);
		}

		// Token: 0x060155E9 RID: 87529 RVA: 0x0031AB03 File Offset: 0x00318D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikePopularEntriesChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060155EA RID: 87530 RVA: 0x0031AB34 File Offset: 0x00318D34
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

		// Token: 0x060155EB RID: 87531 RVA: 0x0031AB79 File Offset: 0x00318D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060155EC RID: 87532 RVA: 0x0031AB86 File Offset: 0x00318D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060155ED RID: 87533 RVA: 0x0031AB8F File Offset: 0x00318D8F
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

		// Token: 0x060155EE RID: 87534 RVA: 0x0031ABC4 File Offset: 0x00318DC4
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

		// Token: 0x060155EF RID: 87535 RVA: 0x0031AC02 File Offset: 0x00318E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikePopularEntriesChangeResponse other)
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

		// Token: 0x060155F0 RID: 87536 RVA: 0x0031AC33 File Offset: 0x00318E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060155F1 RID: 87537 RVA: 0x0031AC3C File Offset: 0x00318E3C
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

		// Token: 0x0400810B RID: 33035
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400810C RID: 33036
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400810D RID: 33037
		private ErrorCode errorCode_;
	}
}
