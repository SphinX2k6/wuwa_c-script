using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFC RID: 2812
	[NetMessage(EMessageId.NewbieAdventureTaskRewardResponse)]
	public sealed class NewbieAdventureTaskRewardResponse : IMessage<NewbieAdventureTaskRewardResponse>, IMessage, IEquatable<NewbieAdventureTaskRewardResponse>, IDeepCloneable<NewbieAdventureTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F475 RID: 62581 RVA: 0x0023AFBC File Offset: 0x002391BC
		[NullableContext(1)]
		public static NewbieAdventureTaskRewardResponse Create()
		{
			return new NewbieAdventureTaskRewardResponse();
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600F476 RID: 62582 RVA: 0x0023AFC3 File Offset: 0x002391C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600F477 RID: 62583 RVA: 0x0023AFC6 File Offset: 0x002391C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F478 RID: 62584 RVA: 0x0023AFCD File Offset: 0x002391CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardResponse()
		{
		}

		// Token: 0x0600F479 RID: 62585 RVA: 0x0023AFD5 File Offset: 0x002391D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardResponse(NewbieAdventureTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F47A RID: 62586 RVA: 0x0023AFFA File Offset: 0x002391FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskRewardResponse Clone()
		{
			return new NewbieAdventureTaskRewardResponse(this);
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600F47B RID: 62587 RVA: 0x0023B002 File Offset: 0x00239202
		// (set) Token: 0x0600F47C RID: 62588 RVA: 0x0023B00A File Offset: 0x0023920A
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

		// Token: 0x0600F47D RID: 62589 RVA: 0x0023B013 File Offset: 0x00239213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureTaskRewardResponse);
		}

		// Token: 0x0600F47E RID: 62590 RVA: 0x0023B021 File Offset: 0x00239221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F47F RID: 62591 RVA: 0x0023B050 File Offset: 0x00239250
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

		// Token: 0x0600F480 RID: 62592 RVA: 0x0023B095 File Offset: 0x00239295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F481 RID: 62593 RVA: 0x0023B0A2 File Offset: 0x002392A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F482 RID: 62594 RVA: 0x0023B0AB File Offset: 0x002392AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F483 RID: 62595 RVA: 0x0023B0E0 File Offset: 0x002392E0
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

		// Token: 0x0600F484 RID: 62596 RVA: 0x0023B11E File Offset: 0x0023931E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureTaskRewardResponse other)
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

		// Token: 0x0600F485 RID: 62597 RVA: 0x0023B14F File Offset: 0x0023934F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F486 RID: 62598 RVA: 0x0023B158 File Offset: 0x00239358
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400626D RID: 25197
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400626E RID: 25198
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400626F RID: 25199
		private ErrorCode errorCode_;
	}
}
