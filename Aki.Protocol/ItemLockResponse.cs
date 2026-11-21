using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000845 RID: 2117
	[NetMessage(EMessageId.ItemLockResponse)]
	public sealed class ItemLockResponse : IMessage<ItemLockResponse>, IMessage, IEquatable<ItemLockResponse>, IDeepCloneable<ItemLockResponse>, IBufferMessage
	{
		// Token: 0x0600BD30 RID: 48432 RVA: 0x001C20F0 File Offset: 0x001C02F0
		[NullableContext(1)]
		public static ItemLockResponse Create()
		{
			return new ItemLockResponse();
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x0600BD31 RID: 48433 RVA: 0x001C20F7 File Offset: 0x001C02F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x0600BD32 RID: 48434 RVA: 0x001C20FA File Offset: 0x001C02FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemLockResponse.Descriptor;
			}
		}

		// Token: 0x0600BD33 RID: 48435 RVA: 0x001C2101 File Offset: 0x001C0301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockResponse()
		{
		}

		// Token: 0x0600BD34 RID: 48436 RVA: 0x001C2109 File Offset: 0x001C0309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockResponse(ItemLockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD35 RID: 48437 RVA: 0x001C212E File Offset: 0x001C032E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemLockResponse Clone()
		{
			return new ItemLockResponse(this);
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x0600BD36 RID: 48438 RVA: 0x001C2136 File Offset: 0x001C0336
		// (set) Token: 0x0600BD37 RID: 48439 RVA: 0x001C213E File Offset: 0x001C033E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600BD38 RID: 48440 RVA: 0x001C2147 File Offset: 0x001C0347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemLockResponse);
		}

		// Token: 0x0600BD39 RID: 48441 RVA: 0x001C2155 File Offset: 0x001C0355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemLockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD3A RID: 48442 RVA: 0x001C2184 File Offset: 0x001C0384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD3B RID: 48443 RVA: 0x001C21C9 File Offset: 0x001C03C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD3C RID: 48444 RVA: 0x001C21D6 File Offset: 0x001C03D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD3D RID: 48445 RVA: 0x001C21DF File Offset: 0x001C03DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD3E RID: 48446 RVA: 0x001C2214 File Offset: 0x001C0414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD3F RID: 48447 RVA: 0x001C2252 File Offset: 0x001C0452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemLockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD40 RID: 48448 RVA: 0x001C2283 File Offset: 0x001C0483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD41 RID: 48449 RVA: 0x001C228C File Offset: 0x001C048C
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400530C RID: 21260
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400530D RID: 21261
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x0400530E RID: 21262
		private ErrorCode errCode_;
	}
}
