using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8F RID: 3983
	[NetMessage(EMessageId.RoguelikeGotoNextRoomResponse)]
	public sealed class RoguelikeGotoNextRoomResponse : IMessage<RoguelikeGotoNextRoomResponse>, IMessage, IEquatable<RoguelikeGotoNextRoomResponse>, IDeepCloneable<RoguelikeGotoNextRoomResponse>, IBufferMessage
	{
		// Token: 0x06015542 RID: 87362 RVA: 0x00318FCE File Offset: 0x003171CE
		[NullableContext(1)]
		public static RoguelikeGotoNextRoomResponse Create()
		{
			return new RoguelikeGotoNextRoomResponse();
		}

		// Token: 0x1700471A RID: 18202
		// (get) Token: 0x06015543 RID: 87363 RVA: 0x00318FD5 File Offset: 0x003171D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700471B RID: 18203
		// (get) Token: 0x06015544 RID: 87364 RVA: 0x00318FD8 File Offset: 0x003171D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGotoNextRoomResponse.Descriptor;
			}
		}

		// Token: 0x06015545 RID: 87365 RVA: 0x00318FDF File Offset: 0x003171DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomResponse()
		{
		}

		// Token: 0x06015546 RID: 87366 RVA: 0x00318FE7 File Offset: 0x003171E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomResponse(RoguelikeGotoNextRoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015547 RID: 87367 RVA: 0x0031900C File Offset: 0x0031720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomResponse Clone()
		{
			return new RoguelikeGotoNextRoomResponse(this);
		}

		// Token: 0x1700471C RID: 18204
		// (get) Token: 0x06015548 RID: 87368 RVA: 0x00319014 File Offset: 0x00317214
		// (set) Token: 0x06015549 RID: 87369 RVA: 0x0031901C File Offset: 0x0031721C
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

		// Token: 0x0601554A RID: 87370 RVA: 0x00319025 File Offset: 0x00317225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGotoNextRoomResponse);
		}

		// Token: 0x0601554B RID: 87371 RVA: 0x00319033 File Offset: 0x00317233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGotoNextRoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601554C RID: 87372 RVA: 0x00319064 File Offset: 0x00317264
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

		// Token: 0x0601554D RID: 87373 RVA: 0x003190A9 File Offset: 0x003172A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601554E RID: 87374 RVA: 0x003190B6 File Offset: 0x003172B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601554F RID: 87375 RVA: 0x003190BF File Offset: 0x003172BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015550 RID: 87376 RVA: 0x003190F0 File Offset: 0x003172F0
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

		// Token: 0x06015551 RID: 87377 RVA: 0x0031912E File Offset: 0x0031732E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeGotoNextRoomResponse other)
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

		// Token: 0x06015552 RID: 87378 RVA: 0x0031915F File Offset: 0x0031735F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015553 RID: 87379 RVA: 0x00319168 File Offset: 0x00317368
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040080CB RID: 32971
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080CC RID: 32972
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040080CD RID: 32973
		private ErrorCode errorCode_;
	}
}
