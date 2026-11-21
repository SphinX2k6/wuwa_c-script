using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024A RID: 586
	[NetMessage(EMessageId.ChangeCardRequest)]
	public sealed class ChangeCardRequest : IMessage<ChangeCardRequest>, IMessage, IEquatable<ChangeCardRequest>, IDeepCloneable<ChangeCardRequest>, IBufferMessage
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x0009B7F2 File Offset: 0x000999F2
		[NullableContext(1)]
		public static ChangeCardRequest Create()
		{
			return new ChangeCardRequest();
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06003EEB RID: 16107 RVA: 0x0009B7F9 File Offset: 0x000999F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06003EEC RID: 16108 RVA: 0x0009B7FC File Offset: 0x000999FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeCardRequest.Descriptor;
			}
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x0009B803 File Offset: 0x00099A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardRequest()
		{
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0009B80B File Offset: 0x00099A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardRequest(ChangeCardRequest other) : this()
		{
			this.cardId_ = other.cardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0009B830 File Offset: 0x00099A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeCardRequest Clone()
		{
			return new ChangeCardRequest(this);
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x0009B838 File Offset: 0x00099A38
		// (set) Token: 0x06003EF1 RID: 16113 RVA: 0x0009B840 File Offset: 0x00099A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0009B849 File Offset: 0x00099A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeCardRequest);
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0009B857 File Offset: 0x00099A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeCardRequest other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0009B888 File Offset: 0x00099A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0009B8C7 File Offset: 0x00099AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0009B8D4 File Offset: 0x00099AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0009B8DD File Offset: 0x00099ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0009B910 File Offset: 0x00099B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0009B94E File Offset: 0x00099B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0009B97F File Offset: 0x00099B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x0009B988 File Offset: 0x00099B88
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
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D59 RID: 11609
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D5A RID: 11610
		public const int CardIdFieldNumber = 6;

		// Token: 0x04002D5B RID: 11611
		private int cardId_;
	}
}
