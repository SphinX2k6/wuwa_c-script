using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027E RID: 638
	[NetMessage(EMessageId.ChatNotify)]
	public sealed class ChatNotify : IMessage<ChatNotify>, IMessage, IEquatable<ChatNotify>, IDeepCloneable<ChatNotify>, IBufferMessage
	{
		// Token: 0x060042F1 RID: 17137 RVA: 0x000A43E8 File Offset: 0x000A25E8
		[NullableContext(1)]
		public static ChatNotify Create()
		{
			return new ChatNotify();
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x000A43EF File Offset: 0x000A25EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x000A43F2 File Offset: 0x000A25F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatNotify.Descriptor;
			}
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x000A43F9 File Offset: 0x000A25F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatNotify()
		{
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x000A440C File Offset: 0x000A260C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatNotify(ChatNotify other) : this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x000A4431 File Offset: 0x000A2631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatNotify Clone()
		{
			return new ChatNotify(this);
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060042F7 RID: 17143 RVA: 0x000A4439 File Offset: 0x000A2639
		// (set) Token: 0x060042F8 RID: 17144 RVA: 0x000A4441 File Offset: 0x000A2641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			get
			{
				return this.content_;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x000A4454 File Offset: 0x000A2654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatNotify);
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x000A4462 File Offset: 0x000A2662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatNotify other)
		{
			return other != null && (other == this || (!(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x000A4498 File Offset: 0x000A2698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x000A44D9 File Offset: 0x000A26D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x000A44E6 File Offset: 0x000A26E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x000A44EF File Offset: 0x000A26EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x000A4528 File Offset: 0x000A2728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x000A456B File Offset: 0x000A276B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x000A45A1 File Offset: 0x000A27A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x000A45AC File Offset: 0x000A27AC
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x04002E32 RID: 11826
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E33 RID: 11827
		public const int ContentFieldNumber = 4;

		// Token: 0x04002E34 RID: 11828
		private string content_ = "";
	}
}
