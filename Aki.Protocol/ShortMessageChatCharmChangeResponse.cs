using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FE RID: 4606
	[NetMessage(EMessageId.ShortMessageChatCharmChangeResponse)]
	public sealed class ShortMessageChatCharmChangeResponse : IMessage<ShortMessageChatCharmChangeResponse>, IMessage, IEquatable<ShortMessageChatCharmChangeResponse>, IDeepCloneable<ShortMessageChatCharmChangeResponse>, IBufferMessage
	{
		// Token: 0x060188DF RID: 100575 RVA: 0x00392249 File Offset: 0x00390449
		[NullableContext(1)]
		public static ShortMessageChatCharmChangeResponse Create()
		{
			return new ShortMessageChatCharmChangeResponse();
		}

		// Token: 0x170052B6 RID: 21174
		// (get) Token: 0x060188E0 RID: 100576 RVA: 0x00392250 File Offset: 0x00390450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052B7 RID: 21175
		// (get) Token: 0x060188E1 RID: 100577 RVA: 0x00392253 File Offset: 0x00390453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageChatCharmChangeResponse.Descriptor;
			}
		}

		// Token: 0x060188E2 RID: 100578 RVA: 0x0039225A File Offset: 0x0039045A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeResponse()
		{
		}

		// Token: 0x060188E3 RID: 100579 RVA: 0x00392262 File Offset: 0x00390462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeResponse(ShortMessageChatCharmChangeResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060188E4 RID: 100580 RVA: 0x00392287 File Offset: 0x00390487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeResponse Clone()
		{
			return new ShortMessageChatCharmChangeResponse(this);
		}

		// Token: 0x170052B8 RID: 21176
		// (get) Token: 0x060188E5 RID: 100581 RVA: 0x0039228F File Offset: 0x0039048F
		// (set) Token: 0x060188E6 RID: 100582 RVA: 0x00392297 File Offset: 0x00390497
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

		// Token: 0x060188E7 RID: 100583 RVA: 0x003922A0 File Offset: 0x003904A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageChatCharmChangeResponse);
		}

		// Token: 0x060188E8 RID: 100584 RVA: 0x003922AE File Offset: 0x003904AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageChatCharmChangeResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060188E9 RID: 100585 RVA: 0x003922DC File Offset: 0x003904DC
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

		// Token: 0x060188EA RID: 100586 RVA: 0x00392321 File Offset: 0x00390521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188EB RID: 100587 RVA: 0x0039232E File Offset: 0x0039052E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188EC RID: 100588 RVA: 0x00392337 File Offset: 0x00390537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188ED RID: 100589 RVA: 0x0039236C File Offset: 0x0039056C
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

		// Token: 0x060188EE RID: 100590 RVA: 0x003923AA File Offset: 0x003905AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageChatCharmChangeResponse other)
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

		// Token: 0x060188EF RID: 100591 RVA: 0x003923DB File Offset: 0x003905DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060188F0 RID: 100592 RVA: 0x003923E4 File Offset: 0x003905E4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400911D RID: 37149
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400911E RID: 37150
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x0400911F RID: 37151
		private ErrorCode errCode_;
	}
}
