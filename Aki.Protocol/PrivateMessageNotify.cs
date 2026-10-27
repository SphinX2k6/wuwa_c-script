using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE6 RID: 3558
	[NetMessage(EMessageId.PrivateMessageNotify)]
	public sealed class PrivateMessageNotify : IMessage<PrivateMessageNotify>, IMessage, IEquatable<PrivateMessageNotify>, IDeepCloneable<PrivateMessageNotify>, IBufferMessage
	{
		// Token: 0x0601324A RID: 78410 RVA: 0x002C9EA3 File Offset: 0x002C80A3
		[NullableContext(1)]
		public static PrivateMessageNotify Create()
		{
			return new PrivateMessageNotify();
		}

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x0601324B RID: 78411 RVA: 0x002C9EAA File Offset: 0x002C80AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x0601324C RID: 78412 RVA: 0x002C9EAD File Offset: 0x002C80AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateMessageNotify.Descriptor;
			}
		}

		// Token: 0x0601324D RID: 78413 RVA: 0x002C9EB4 File Offset: 0x002C80B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMessageNotify()
		{
		}

		// Token: 0x0601324E RID: 78414 RVA: 0x002C9EBC File Offset: 0x002C80BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMessageNotify(PrivateMessageNotify other) : this()
		{
			this.chatContent_ = ((other.chatContent_ != null) ? other.chatContent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601324F RID: 78415 RVA: 0x002C9EF1 File Offset: 0x002C80F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMessageNotify Clone()
		{
			return new PrivateMessageNotify(this);
		}

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x06013250 RID: 78416 RVA: 0x002C9EF9 File Offset: 0x002C80F9
		// (set) Token: 0x06013251 RID: 78417 RVA: 0x002C9F01 File Offset: 0x002C8101
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

		// Token: 0x06013252 RID: 78418 RVA: 0x002C9F0A File Offset: 0x002C810A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateMessageNotify);
		}

		// Token: 0x06013253 RID: 78419 RVA: 0x002C9F18 File Offset: 0x002C8118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateMessageNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ChatContent, other.ChatContent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013254 RID: 78420 RVA: 0x002C9F4C File Offset: 0x002C814C
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

		// Token: 0x06013255 RID: 78421 RVA: 0x002C9F88 File Offset: 0x002C8188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013256 RID: 78422 RVA: 0x002C9F95 File Offset: 0x002C8195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013257 RID: 78423 RVA: 0x002C9F9E File Offset: 0x002C819E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.chatContent_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChatContent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013258 RID: 78424 RVA: 0x002C9FD0 File Offset: 0x002C81D0
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

		// Token: 0x06013259 RID: 78425 RVA: 0x002CA010 File Offset: 0x002C8210
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

		// Token: 0x0601325A RID: 78426 RVA: 0x002CA064 File Offset: 0x002C8264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601325B RID: 78427 RVA: 0x002CA070 File Offset: 0x002C8270
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
				if (num != 18U)
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

		// Token: 0x040075F6 RID: 30198
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075F7 RID: 30199
		public const int ChatContentFieldNumber = 2;

		// Token: 0x040075F8 RID: 30200
		private ChatContentProto chatContent_;
	}
}
