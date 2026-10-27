using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C95 RID: 3221
	[NetMessage(EMessageId.PhantomBattleLeaveSlotResponse)]
	public sealed class PhantomBattleLeaveSlotResponse : IMessage<PhantomBattleLeaveSlotResponse>, IMessage, IEquatable<PhantomBattleLeaveSlotResponse>, IDeepCloneable<PhantomBattleLeaveSlotResponse>, IBufferMessage
	{
		// Token: 0x06011756 RID: 71510 RVA: 0x0028EDC1 File Offset: 0x0028CFC1
		[NullableContext(1)]
		public static PhantomBattleLeaveSlotResponse Create()
		{
			return new PhantomBattleLeaveSlotResponse();
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x06011757 RID: 71511 RVA: 0x0028EDC8 File Offset: 0x0028CFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x06011758 RID: 71512 RVA: 0x0028EDCB File Offset: 0x0028CFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleLeaveSlotResponse.Descriptor;
			}
		}

		// Token: 0x06011759 RID: 71513 RVA: 0x0028EDD2 File Offset: 0x0028CFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotResponse()
		{
		}

		// Token: 0x0601175A RID: 71514 RVA: 0x0028EDDC File Offset: 0x0028CFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotResponse(PhantomBattleLeaveSlotResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleHandCardInfo_ = ((other.phantomBattleHandCardInfo_ != null) ? other.phantomBattleHandCardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601175B RID: 71515 RVA: 0x0028EE28 File Offset: 0x0028D028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleLeaveSlotResponse Clone()
		{
			return new PhantomBattleLeaveSlotResponse(this);
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x0601175C RID: 71516 RVA: 0x0028EE30 File Offset: 0x0028D030
		// (set) Token: 0x0601175D RID: 71517 RVA: 0x0028EE38 File Offset: 0x0028D038
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

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0601175E RID: 71518 RVA: 0x0028EE41 File Offset: 0x0028D041
		// (set) Token: 0x0601175F RID: 71519 RVA: 0x0028EE49 File Offset: 0x0028D049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo PhantomBattleHandCardInfo
		{
			get
			{
				return this.phantomBattleHandCardInfo_;
			}
			set
			{
				this.phantomBattleHandCardInfo_ = value;
			}
		}

		// Token: 0x06011760 RID: 71520 RVA: 0x0028EE52 File Offset: 0x0028D052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleLeaveSlotResponse);
		}

		// Token: 0x06011761 RID: 71521 RVA: 0x0028EE60 File Offset: 0x0028D060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleLeaveSlotResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleHandCardInfo, other.PhantomBattleHandCardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011762 RID: 71522 RVA: 0x0028EEB0 File Offset: 0x0028D0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num ^= this.PhantomBattleHandCardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011763 RID: 71523 RVA: 0x0028EF0B File Offset: 0x0028D10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011764 RID: 71524 RVA: 0x0028EF18 File Offset: 0x0028D118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011765 RID: 71525 RVA: 0x0028EF24 File Offset: 0x0028D124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleHandCardInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PhantomBattleHandCardInfo);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011766 RID: 71526 RVA: 0x0028EF80 File Offset: 0x0028D180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleHandCardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011767 RID: 71527 RVA: 0x0028EFD8 File Offset: 0x0028D1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleLeaveSlotResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleHandCardInfo_ != null)
			{
				if (this.phantomBattleHandCardInfo_ == null)
				{
					this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
				}
				this.PhantomBattleHandCardInfo.MergeFrom(other.PhantomBattleHandCardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011768 RID: 71528 RVA: 0x0028F040 File Offset: 0x0028D240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011769 RID: 71529 RVA: 0x0028F04C File Offset: 0x0028D24C
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
				if (num != 34U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.phantomBattleHandCardInfo_ == null)
					{
						this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
					}
					input.ReadMessage(this.PhantomBattleHandCardInfo);
				}
			}
		}

		// Token: 0x04006E2F RID: 28207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E30 RID: 28208
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006E31 RID: 28209
		private ErrorCode errorCode_;

		// Token: 0x04006E32 RID: 28210
		public const int PhantomBattleHandCardInfoFieldNumber = 4;

		// Token: 0x04006E33 RID: 28211
		private PhantomBattleHandCardInfo phantomBattleHandCardInfo_;
	}
}
