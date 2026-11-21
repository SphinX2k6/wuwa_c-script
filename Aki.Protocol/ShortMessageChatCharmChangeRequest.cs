using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001239 RID: 4665
	[NetMessage(EMessageId.ShortMessageChatCharmChangeRequest)]
	public sealed class ShortMessageChatCharmChangeRequest : IMessage<ShortMessageChatCharmChangeRequest>, IMessage, IEquatable<ShortMessageChatCharmChangeRequest>, IDeepCloneable<ShortMessageChatCharmChangeRequest>, IBufferMessage
	{
		// Token: 0x06018EA7 RID: 102055 RVA: 0x003A1F10 File Offset: 0x003A0110
		[NullableContext(1)]
		public static ShortMessageChatCharmChangeRequest Create()
		{
			return new ShortMessageChatCharmChangeRequest();
		}

		// Token: 0x17005430 RID: 21552
		// (get) Token: 0x06018EA8 RID: 102056 RVA: 0x003A1F17 File Offset: 0x003A0117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005431 RID: 21553
		// (get) Token: 0x06018EA9 RID: 102057 RVA: 0x003A1F1A File Offset: 0x003A011A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageChatCharmChangeRequest.Descriptor;
			}
		}

		// Token: 0x06018EAA RID: 102058 RVA: 0x003A1F21 File Offset: 0x003A0121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeRequest()
		{
		}

		// Token: 0x06018EAB RID: 102059 RVA: 0x003A1F29 File Offset: 0x003A0129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeRequest(ShortMessageChatCharmChangeRequest other) : this()
		{
			this.chatCharmId_ = other.chatCharmId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018EAC RID: 102060 RVA: 0x003A1F4E File Offset: 0x003A014E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeRequest Clone()
		{
			return new ShortMessageChatCharmChangeRequest(this);
		}

		// Token: 0x17005432 RID: 21554
		// (get) Token: 0x06018EAD RID: 102061 RVA: 0x003A1F56 File Offset: 0x003A0156
		// (set) Token: 0x06018EAE RID: 102062 RVA: 0x003A1F5E File Offset: 0x003A015E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChatCharmId
		{
			get
			{
				return this.chatCharmId_;
			}
			set
			{
				this.chatCharmId_ = value;
			}
		}

		// Token: 0x06018EAF RID: 102063 RVA: 0x003A1F67 File Offset: 0x003A0167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageChatCharmChangeRequest);
		}

		// Token: 0x06018EB0 RID: 102064 RVA: 0x003A1F75 File Offset: 0x003A0175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageChatCharmChangeRequest other)
		{
			return other != null && (other == this || (this.ChatCharmId == other.ChatCharmId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018EB1 RID: 102065 RVA: 0x003A1FA4 File Offset: 0x003A01A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChatCharmId != 0)
			{
				num ^= this.ChatCharmId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018EB2 RID: 102066 RVA: 0x003A1FE3 File Offset: 0x003A01E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018EB3 RID: 102067 RVA: 0x003A1FF0 File Offset: 0x003A01F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018EB4 RID: 102068 RVA: 0x003A1FF9 File Offset: 0x003A01F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChatCharmId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ChatCharmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018EB5 RID: 102069 RVA: 0x003A202C File Offset: 0x003A022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChatCharmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChatCharmId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018EB6 RID: 102070 RVA: 0x003A206A File Offset: 0x003A026A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageChatCharmChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChatCharmId != 0)
			{
				this.ChatCharmId = other.ChatCharmId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018EB7 RID: 102071 RVA: 0x003A209B File Offset: 0x003A029B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018EB8 RID: 102072 RVA: 0x003A20A4 File Offset: 0x003A02A4
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
					this.ChatCharmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040093CB RID: 37835
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093CC RID: 37836
		public const int ChatCharmIdFieldNumber = 10;

		// Token: 0x040093CD RID: 37837
		private int chatCharmId_;
	}
}
