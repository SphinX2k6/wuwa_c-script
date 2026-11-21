using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000283 RID: 643
	[NetMessage(EMessageId.ChatNotify)]
	public sealed class ChatNotify : IMessage<ChatNotify>, IMessage, IEquatable<ChatNotify>, IDeepCloneable<ChatNotify>, IBufferMessage
	{
		// Token: 0x06004398 RID: 17304 RVA: 0x000A60B0 File Offset: 0x000A42B0
		[NullableContext(1)]
		public static ChatNotify Create()
		{
			return new ChatNotify();
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x000A60B7 File Offset: 0x000A42B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x000A60BA File Offset: 0x000A42BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatNotify.Descriptor;
			}
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x000A60C1 File Offset: 0x000A42C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatNotify()
		{
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x000A60D4 File Offset: 0x000A42D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatNotify(ChatNotify other) : this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x000A60F9 File Offset: 0x000A42F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatNotify Clone()
		{
			return new ChatNotify(this);
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x000A6101 File Offset: 0x000A4301
		// (set) Token: 0x0600439F RID: 17311 RVA: 0x000A6109 File Offset: 0x000A4309
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

		// Token: 0x060043A0 RID: 17312 RVA: 0x000A611C File Offset: 0x000A431C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatNotify);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x000A612A File Offset: 0x000A432A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatNotify other)
		{
			return other != null && (other == this || (!(this.Content != other.Content) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x000A6160 File Offset: 0x000A4360
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

		// Token: 0x060043A3 RID: 17315 RVA: 0x000A61A1 File Offset: 0x000A43A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x000A61AE File Offset: 0x000A43AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x000A61B7 File Offset: 0x000A43B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x000A61F0 File Offset: 0x000A43F0
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

		// Token: 0x060043A7 RID: 17319 RVA: 0x000A6233 File Offset: 0x000A4433
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

		// Token: 0x060043A8 RID: 17320 RVA: 0x000A6269 File Offset: 0x000A4469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x000A6274 File Offset: 0x000A4474
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x04002EB6 RID: 11958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EB7 RID: 11959
		public const int ContentFieldNumber = 14;

		// Token: 0x04002EB8 RID: 11960
		private string content_ = "";
	}
}
