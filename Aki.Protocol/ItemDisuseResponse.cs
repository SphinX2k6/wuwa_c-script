using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084A RID: 2122
	[NetMessage(EMessageId.ItemDisuseResponse)]
	public sealed class ItemDisuseResponse : IMessage<ItemDisuseResponse>, IMessage, IEquatable<ItemDisuseResponse>, IDeepCloneable<ItemDisuseResponse>, IBufferMessage
	{
		// Token: 0x0600BD55 RID: 48469 RVA: 0x001C2378 File Offset: 0x001C0578
		[NullableContext(1)]
		public static ItemDisuseResponse Create()
		{
			return new ItemDisuseResponse();
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x0600BD56 RID: 48470 RVA: 0x001C237F File Offset: 0x001C057F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x0600BD57 RID: 48471 RVA: 0x001C2382 File Offset: 0x001C0582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDisuseResponse.Descriptor;
			}
		}

		// Token: 0x0600BD58 RID: 48472 RVA: 0x001C2389 File Offset: 0x001C0589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseResponse()
		{
		}

		// Token: 0x0600BD59 RID: 48473 RVA: 0x001C2391 File Offset: 0x001C0591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseResponse(ItemDisuseResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD5A RID: 48474 RVA: 0x001C23B6 File Offset: 0x001C05B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseResponse Clone()
		{
			return new ItemDisuseResponse(this);
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x0600BD5B RID: 48475 RVA: 0x001C23BE File Offset: 0x001C05BE
		// (set) Token: 0x0600BD5C RID: 48476 RVA: 0x001C23C6 File Offset: 0x001C05C6
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

		// Token: 0x0600BD5D RID: 48477 RVA: 0x001C23CF File Offset: 0x001C05CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDisuseResponse);
		}

		// Token: 0x0600BD5E RID: 48478 RVA: 0x001C23DD File Offset: 0x001C05DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDisuseResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x001C240C File Offset: 0x001C060C
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

		// Token: 0x0600BD60 RID: 48480 RVA: 0x001C2451 File Offset: 0x001C0651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x001C245E File Offset: 0x001C065E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x001C2467 File Offset: 0x001C0667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x001C249C File Offset: 0x001C069C
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

		// Token: 0x0600BD64 RID: 48484 RVA: 0x001C24DA File Offset: 0x001C06DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDisuseResponse other)
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

		// Token: 0x0600BD65 RID: 48485 RVA: 0x001C250B File Offset: 0x001C070B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x001C2514 File Offset: 0x001C0714
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040052C0 RID: 21184
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052C1 RID: 21185
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x040052C2 RID: 21186
		private ErrorCode errCode_;
	}
}
