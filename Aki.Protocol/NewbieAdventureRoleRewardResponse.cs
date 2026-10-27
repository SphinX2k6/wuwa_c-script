using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFA RID: 2810
	[NetMessage(EMessageId.NewbieAdventureRoleRewardResponse)]
	public sealed class NewbieAdventureRoleRewardResponse : IMessage<NewbieAdventureRoleRewardResponse>, IMessage, IEquatable<NewbieAdventureRoleRewardResponse>, IDeepCloneable<NewbieAdventureRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F44F RID: 62543 RVA: 0x0023AB2F File Offset: 0x00238D2F
		[NullableContext(1)]
		public static NewbieAdventureRoleRewardResponse Create()
		{
			return new NewbieAdventureRoleRewardResponse();
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600F450 RID: 62544 RVA: 0x0023AB36 File Offset: 0x00238D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600F451 RID: 62545 RVA: 0x0023AB39 File Offset: 0x00238D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F452 RID: 62546 RVA: 0x0023AB40 File Offset: 0x00238D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardResponse()
		{
		}

		// Token: 0x0600F453 RID: 62547 RVA: 0x0023AB48 File Offset: 0x00238D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardResponse(NewbieAdventureRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F454 RID: 62548 RVA: 0x0023AB6D File Offset: 0x00238D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureRoleRewardResponse Clone()
		{
			return new NewbieAdventureRoleRewardResponse(this);
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600F455 RID: 62549 RVA: 0x0023AB75 File Offset: 0x00238D75
		// (set) Token: 0x0600F456 RID: 62550 RVA: 0x0023AB7D File Offset: 0x00238D7D
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

		// Token: 0x0600F457 RID: 62551 RVA: 0x0023AB86 File Offset: 0x00238D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureRoleRewardResponse);
		}

		// Token: 0x0600F458 RID: 62552 RVA: 0x0023AB94 File Offset: 0x00238D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F459 RID: 62553 RVA: 0x0023ABC4 File Offset: 0x00238DC4
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

		// Token: 0x0600F45A RID: 62554 RVA: 0x0023AC09 File Offset: 0x00238E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F45B RID: 62555 RVA: 0x0023AC16 File Offset: 0x00238E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F45C RID: 62556 RVA: 0x0023AC1F File Offset: 0x00238E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F45D RID: 62557 RVA: 0x0023AC54 File Offset: 0x00238E54
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

		// Token: 0x0600F45E RID: 62558 RVA: 0x0023AC92 File Offset: 0x00238E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureRoleRewardResponse other)
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

		// Token: 0x0600F45F RID: 62559 RVA: 0x0023ACC3 File Offset: 0x00238EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F460 RID: 62560 RVA: 0x0023ACCC File Offset: 0x00238ECC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006264 RID: 25188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006265 RID: 25189
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006266 RID: 25190
		private ErrorCode errorCode_;
	}
}
