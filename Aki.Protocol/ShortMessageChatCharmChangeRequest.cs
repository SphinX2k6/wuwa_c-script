using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FD RID: 4605
	[NetMessage(EMessageId.ShortMessageChatCharmChangeRequest)]
	public sealed class ShortMessageChatCharmChangeRequest : IMessage<ShortMessageChatCharmChangeRequest>, IMessage, IEquatable<ShortMessageChatCharmChangeRequest>, IDeepCloneable<ShortMessageChatCharmChangeRequest>, IBufferMessage
	{
		// Token: 0x060188CD RID: 100557 RVA: 0x00392070 File Offset: 0x00390270
		[NullableContext(1)]
		public static ShortMessageChatCharmChangeRequest Create()
		{
			return new ShortMessageChatCharmChangeRequest();
		}

		// Token: 0x170052B3 RID: 21171
		// (get) Token: 0x060188CE RID: 100558 RVA: 0x00392077 File Offset: 0x00390277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052B4 RID: 21172
		// (get) Token: 0x060188CF RID: 100559 RVA: 0x0039207A File Offset: 0x0039027A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageChatCharmChangeRequest.Descriptor;
			}
		}

		// Token: 0x060188D0 RID: 100560 RVA: 0x00392081 File Offset: 0x00390281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeRequest()
		{
		}

		// Token: 0x060188D1 RID: 100561 RVA: 0x00392089 File Offset: 0x00390289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeRequest(ShortMessageChatCharmChangeRequest other) : this()
		{
			this.chatCharmId_ = other.chatCharmId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060188D2 RID: 100562 RVA: 0x003920AE File Offset: 0x003902AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatCharmChangeRequest Clone()
		{
			return new ShortMessageChatCharmChangeRequest(this);
		}

		// Token: 0x170052B5 RID: 21173
		// (get) Token: 0x060188D3 RID: 100563 RVA: 0x003920B6 File Offset: 0x003902B6
		// (set) Token: 0x060188D4 RID: 100564 RVA: 0x003920BE File Offset: 0x003902BE
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

		// Token: 0x060188D5 RID: 100565 RVA: 0x003920C7 File Offset: 0x003902C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageChatCharmChangeRequest);
		}

		// Token: 0x060188D6 RID: 100566 RVA: 0x003920D5 File Offset: 0x003902D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageChatCharmChangeRequest other)
		{
			return other != null && (other == this || (this.ChatCharmId == other.ChatCharmId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060188D7 RID: 100567 RVA: 0x00392104 File Offset: 0x00390304
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

		// Token: 0x060188D8 RID: 100568 RVA: 0x00392143 File Offset: 0x00390343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188D9 RID: 100569 RVA: 0x00392150 File Offset: 0x00390350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188DA RID: 100570 RVA: 0x00392159 File Offset: 0x00390359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChatCharmId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ChatCharmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188DB RID: 100571 RVA: 0x0039218C File Offset: 0x0039038C
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

		// Token: 0x060188DC RID: 100572 RVA: 0x003921CA File Offset: 0x003903CA
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

		// Token: 0x060188DD RID: 100573 RVA: 0x003921FB File Offset: 0x003903FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060188DE RID: 100574 RVA: 0x00392204 File Offset: 0x00390404
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
					this.ChatCharmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400911A RID: 37146
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400911B RID: 37147
		public const int ChatCharmIdFieldNumber = 14;

		// Token: 0x0400911C RID: 37148
		private int chatCharmId_;
	}
}
