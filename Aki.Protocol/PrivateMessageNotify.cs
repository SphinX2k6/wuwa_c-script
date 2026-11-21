using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD6 RID: 3542
	[NetMessage(EMessageId.PrivateMessageNotify)]
	public sealed class PrivateMessageNotify : IMessage<PrivateMessageNotify>, IMessage, IEquatable<PrivateMessageNotify>, IDeepCloneable<PrivateMessageNotify>, IBufferMessage
	{
		// Token: 0x06013165 RID: 78181 RVA: 0x002C87DE File Offset: 0x002C69DE
		[NullableContext(1)]
		public static PrivateMessageNotify Create()
		{
			return new PrivateMessageNotify();
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x06013166 RID: 78182 RVA: 0x002C87E5 File Offset: 0x002C69E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x06013167 RID: 78183 RVA: 0x002C87E8 File Offset: 0x002C69E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateMessageNotify.Descriptor;
			}
		}

		// Token: 0x06013168 RID: 78184 RVA: 0x002C87EF File Offset: 0x002C69EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMessageNotify()
		{
		}

		// Token: 0x06013169 RID: 78185 RVA: 0x002C87F7 File Offset: 0x002C69F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMessageNotify(PrivateMessageNotify other) : this()
		{
			this.chatContent_ = ((other.chatContent_ != null) ? other.chatContent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601316A RID: 78186 RVA: 0x002C882C File Offset: 0x002C6A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMessageNotify Clone()
		{
			return new PrivateMessageNotify(this);
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x0601316B RID: 78187 RVA: 0x002C8834 File Offset: 0x002C6A34
		// (set) Token: 0x0601316C RID: 78188 RVA: 0x002C883C File Offset: 0x002C6A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentProto ChatContent
		{
			get
			{
				return this.chatContent_;
			}
			set
			{
				this.chatContent_ = value;
			}
		}

		// Token: 0x0601316D RID: 78189 RVA: 0x002C8845 File Offset: 0x002C6A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateMessageNotify);
		}

		// Token: 0x0601316E RID: 78190 RVA: 0x002C8853 File Offset: 0x002C6A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateMessageNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ChatContent, other.ChatContent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601316F RID: 78191 RVA: 0x002C8888 File Offset: 0x002C6A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.chatContent_ != null)
			{
				num ^= this.ChatContent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013170 RID: 78192 RVA: 0x002C88C4 File Offset: 0x002C6AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013171 RID: 78193 RVA: 0x002C88D1 File Offset: 0x002C6AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013172 RID: 78194 RVA: 0x002C88DA File Offset: 0x002C6ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.chatContent_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ChatContent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013173 RID: 78195 RVA: 0x002C890C File Offset: 0x002C6B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.chatContent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChatContent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013174 RID: 78196 RVA: 0x002C894C File Offset: 0x002C6B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateMessageNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.chatContent_ != null)
			{
				if (this.chatContent_ == null)
				{
					this.ChatContent = new ChatContentProto();
				}
				this.ChatContent.MergeFrom(other.ChatContent);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013175 RID: 78197 RVA: 0x002C89A0 File Offset: 0x002C6BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013176 RID: 78198 RVA: 0x002C89AC File Offset: 0x002C6BAC
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.chatContent_ == null)
					{
						this.ChatContent = new ChatContentProto();
					}
					input.ReadMessage(this.ChatContent);
				}
			}
		}

		// Token: 0x04007620 RID: 30240
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007621 RID: 30241
		public const int ChatContentFieldNumber = 13;

		// Token: 0x04007622 RID: 30242
		private ChatContentProto chatContent_;
	}
}
