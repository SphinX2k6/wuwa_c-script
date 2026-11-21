using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123B RID: 4667
	[NetMessage(EMessageId.ShortMessageChatThemeChangeRequest)]
	public sealed class ShortMessageChatThemeChangeRequest : IMessage<ShortMessageChatThemeChangeRequest>, IMessage, IEquatable<ShortMessageChatThemeChangeRequest>, IDeepCloneable<ShortMessageChatThemeChangeRequest>, IBufferMessage
	{
		// Token: 0x06018ECB RID: 102091 RVA: 0x003A22C9 File Offset: 0x003A04C9
		[NullableContext(1)]
		public static ShortMessageChatThemeChangeRequest Create()
		{
			return new ShortMessageChatThemeChangeRequest();
		}

		// Token: 0x17005436 RID: 21558
		// (get) Token: 0x06018ECC RID: 102092 RVA: 0x003A22D0 File Offset: 0x003A04D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005437 RID: 21559
		// (get) Token: 0x06018ECD RID: 102093 RVA: 0x003A22D3 File Offset: 0x003A04D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageChatThemeChangeRequest.Descriptor;
			}
		}

		// Token: 0x06018ECE RID: 102094 RVA: 0x003A22DA File Offset: 0x003A04DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeRequest()
		{
		}

		// Token: 0x06018ECF RID: 102095 RVA: 0x003A22E2 File Offset: 0x003A04E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeRequest(ShortMessageChatThemeChangeRequest other) : this()
		{
			this.chatThemeId_ = other.chatThemeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018ED0 RID: 102096 RVA: 0x003A2307 File Offset: 0x003A0507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageChatThemeChangeRequest Clone()
		{
			return new ShortMessageChatThemeChangeRequest(this);
		}

		// Token: 0x17005438 RID: 21560
		// (get) Token: 0x06018ED1 RID: 102097 RVA: 0x003A230F File Offset: 0x003A050F
		// (set) Token: 0x06018ED2 RID: 102098 RVA: 0x003A2317 File Offset: 0x003A0517
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

		// Token: 0x06018ED3 RID: 102099 RVA: 0x003A2320 File Offset: 0x003A0520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageChatThemeChangeRequest);
		}

		// Token: 0x06018ED4 RID: 102100 RVA: 0x003A232E File Offset: 0x003A052E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageChatThemeChangeRequest other)
		{
			return other != null && (other == this || (this.ChatThemeId == other.ChatThemeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018ED5 RID: 102101 RVA: 0x003A235C File Offset: 0x003A055C
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

		// Token: 0x06018ED6 RID: 102102 RVA: 0x003A239B File Offset: 0x003A059B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018ED7 RID: 102103 RVA: 0x003A23A8 File Offset: 0x003A05A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018ED8 RID: 102104 RVA: 0x003A23B1 File Offset: 0x003A05B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChatThemeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChatThemeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018ED9 RID: 102105 RVA: 0x003A23E4 File Offset: 0x003A05E4
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

		// Token: 0x06018EDA RID: 102106 RVA: 0x003A2422 File Offset: 0x003A0622
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

		// Token: 0x06018EDB RID: 102107 RVA: 0x003A2453 File Offset: 0x003A0653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018EDC RID: 102108 RVA: 0x003A245C File Offset: 0x003A065C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChatThemeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040093D1 RID: 37841
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093D2 RID: 37842
		public const int ChatThemeIdFieldNumber = 1;

		// Token: 0x040093D3 RID: 37843
		private int chatThemeId_;
	}
}
