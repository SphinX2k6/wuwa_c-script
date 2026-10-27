using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011FF RID: 4607
	[NetMessage(EMessageId.ShortMessageChatThemeChangeRequest)]
	public sealed class ShortMessageChatThemeChangeRequest : IMessage<ShortMessageChatThemeChangeRequest>, IMessage, IEquatable<ShortMessageChatThemeChangeRequest>, IDeepCloneable<ShortMessageChatThemeChangeRequest>, IBufferMessage
	{
		// Token: 0x060188F1 RID: 100593 RVA: 0x00392429 File Offset: 0x00390629
		[NullableContext(1)]
		public static ShortMessageChatThemeChangeRequest Create()
		{
			return new ShortMessageChatThemeChangeRequest();
		}

		// Token: 0x170052B9 RID: 21177
		// (get) Token: 0x060188F2 RID: 100594 RVA: 0x00392430 File Offset: 0x00390630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052BA RID: 21178
		// (get) Token: 0x060188F3 RID: 100595 RVA: 0x00392433 File Offset: 0x00390633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageChatThemeChangeRequest.Descriptor;
			}
		}

		// Token: 0x060188F4 RID: 100596 RVA: 0x0039243A File Offset: 0x0039063A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeRequest()
		{
		}

		// Token: 0x060188F5 RID: 100597 RVA: 0x00392442 File Offset: 0x00390642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeRequest(ShortMessageChatThemeChangeRequest other) : this()
		{
			this.chatThemeId_ = other.chatThemeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060188F6 RID: 100598 RVA: 0x00392467 File Offset: 0x00390667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeRequest Clone()
		{
			return new ShortMessageChatThemeChangeRequest(this);
		}

		// Token: 0x170052BB RID: 21179
		// (get) Token: 0x060188F7 RID: 100599 RVA: 0x0039246F File Offset: 0x0039066F
		// (set) Token: 0x060188F8 RID: 100600 RVA: 0x00392477 File Offset: 0x00390677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChatThemeId
		{
			get
			{
				return this.chatThemeId_;
			}
			set
			{
				this.chatThemeId_ = value;
			}
		}

		// Token: 0x060188F9 RID: 100601 RVA: 0x00392480 File Offset: 0x00390680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageChatThemeChangeRequest);
		}

		// Token: 0x060188FA RID: 100602 RVA: 0x0039248E File Offset: 0x0039068E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageChatThemeChangeRequest other)
		{
			return other != null && (other == this || (this.ChatThemeId == other.ChatThemeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060188FB RID: 100603 RVA: 0x003924BC File Offset: 0x003906BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChatThemeId != 0)
			{
				num ^= this.ChatThemeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060188FC RID: 100604 RVA: 0x003924FB File Offset: 0x003906FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188FD RID: 100605 RVA: 0x00392508 File Offset: 0x00390708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188FE RID: 100606 RVA: 0x00392511 File Offset: 0x00390711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChatThemeId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ChatThemeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188FF RID: 100607 RVA: 0x00392544 File Offset: 0x00390744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChatThemeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChatThemeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018900 RID: 100608 RVA: 0x00392582 File Offset: 0x00390782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageChatThemeChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChatThemeId != 0)
			{
				this.ChatThemeId = other.ChatThemeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018901 RID: 100609 RVA: 0x003925B3 File Offset: 0x003907B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018902 RID: 100610 RVA: 0x003925BC File Offset: 0x003907BC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChatThemeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009120 RID: 37152
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009121 RID: 37153
		public const int ChatThemeIdFieldNumber = 8;

		// Token: 0x04009122 RID: 37154
		private int chatThemeId_;
	}
}
