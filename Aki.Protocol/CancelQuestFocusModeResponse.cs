using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000234 RID: 564
	[NetMessage(EMessageId.CancelQuestFocusModeResponse)]
	public sealed class CancelQuestFocusModeResponse : IMessage<CancelQuestFocusModeResponse>, IMessage, IEquatable<CancelQuestFocusModeResponse>, IDeepCloneable<CancelQuestFocusModeResponse>, IBufferMessage
	{
		// Token: 0x06003CFD RID: 15613 RVA: 0x0009738D File Offset: 0x0009558D
		[NullableContext(1)]
		public static CancelQuestFocusModeResponse Create()
		{
			return new CancelQuestFocusModeResponse();
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x00097394 File Offset: 0x00095594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06003CFF RID: 15615 RVA: 0x00097397 File Offset: 0x00095597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelQuestFocusModeResponse.Descriptor;
			}
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x0009739E File Offset: 0x0009559E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeResponse()
		{
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x000973A6 File Offset: 0x000955A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeResponse(CancelQuestFocusModeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x000973CB File Offset: 0x000955CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeResponse Clone()
		{
			return new CancelQuestFocusModeResponse(this);
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x000973D3 File Offset: 0x000955D3
		// (set) Token: 0x06003D04 RID: 15620 RVA: 0x000973DB File Offset: 0x000955DB
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

		// Token: 0x06003D05 RID: 15621 RVA: 0x000973E4 File Offset: 0x000955E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelQuestFocusModeResponse);
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x000973F2 File Offset: 0x000955F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelQuestFocusModeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x00097420 File Offset: 0x00095620
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

		// Token: 0x06003D08 RID: 15624 RVA: 0x00097465 File Offset: 0x00095665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x00097472 File Offset: 0x00095672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x0009747B File Offset: 0x0009567B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x000974B0 File Offset: 0x000956B0
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

		// Token: 0x06003D0C RID: 15628 RVA: 0x000974EE File Offset: 0x000956EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelQuestFocusModeResponse other)
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

		// Token: 0x06003D0D RID: 15629 RVA: 0x0009751F File Offset: 0x0009571F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x00097528 File Offset: 0x00095728
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C8D RID: 11405
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C8E RID: 11406
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002C8F RID: 11407
		private ErrorCode errorCode_;
	}
}
