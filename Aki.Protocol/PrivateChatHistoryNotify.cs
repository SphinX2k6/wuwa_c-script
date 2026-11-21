using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCF RID: 3535
	[NetMessage(EMessageId.PrivateChatHistoryNotify)]
	public sealed class PrivateChatHistoryNotify : IMessage<PrivateChatHistoryNotify>, IMessage, IEquatable<PrivateChatHistoryNotify>, IDeepCloneable<PrivateChatHistoryNotify>, IBufferMessage
	{
		// Token: 0x060130D3 RID: 78035 RVA: 0x002C72CE File Offset: 0x002C54CE
		[NullableContext(1)]
		public static PrivateChatHistoryNotify Create()
		{
			return new PrivateChatHistoryNotify();
		}

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x060130D4 RID: 78036 RVA: 0x002C72D5 File Offset: 0x002C54D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x060130D5 RID: 78037 RVA: 0x002C72D8 File Offset: 0x002C54D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatHistoryNotify.Descriptor;
			}
		}

		// Token: 0x060130D6 RID: 78038 RVA: 0x002C72DF File Offset: 0x002C54DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryNotify()
		{
		}

		// Token: 0x060130D7 RID: 78039 RVA: 0x002C72F2 File Offset: 0x002C54F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryNotify(PrivateChatHistoryNotify other) : this()
		{
			this.allChats_ = other.allChats_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130D8 RID: 78040 RVA: 0x002C731C File Offset: 0x002C551C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryNotify Clone()
		{
			return new PrivateChatHistoryNotify(this);
		}

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x060130D9 RID: 78041 RVA: 0x002C7324 File Offset: 0x002C5524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PrivateChatHistoryContentProto> AllChats
		{
			get
			{
				return this.allChats_;
			}
		}

		// Token: 0x060130DA RID: 78042 RVA: 0x002C732C File Offset: 0x002C552C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatHistoryNotify);
		}

		// Token: 0x060130DB RID: 78043 RVA: 0x002C733A File Offset: 0x002C553A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatHistoryNotify other)
		{
			return other != null && (other == this || (this.allChats_.Equals(other.allChats_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060130DC RID: 78044 RVA: 0x002C7370 File Offset: 0x002C5570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.allChats_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060130DD RID: 78045 RVA: 0x002C73A4 File Offset: 0x002C55A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130DE RID: 78046 RVA: 0x002C73B1 File Offset: 0x002C55B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130DF RID: 78047 RVA: 0x002C73BA File Offset: 0x002C55BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allChats_.WriteTo(ref output, PrivateChatHistoryNotify._repeated_allChats_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060130E0 RID: 78048 RVA: 0x002C73E4 File Offset: 0x002C55E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.allChats_.CalculateSize(PrivateChatHistoryNotify._repeated_allChats_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060130E1 RID: 78049 RVA: 0x002C741D File Offset: 0x002C561D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatHistoryNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.allChats_.Add(other.allChats_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060130E2 RID: 78050 RVA: 0x002C744B File Offset: 0x002C564B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130E3 RID: 78051 RVA: 0x002C7454 File Offset: 0x002C5654
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
					this.allChats_.AddEntriesFrom(ref input, PrivateChatHistoryNotify._repeated_allChats_codec);
				}
			}
		}

		// Token: 0x040075F5 RID: 30197
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075F6 RID: 30198
		public const int AllChatsFieldNumber = 13;

		// Token: 0x040075F7 RID: 30199
		private static readonly FieldCodec<PrivateChatHistoryContentProto> _repeated_allChats_codec = FieldCodec.ForMessage<PrivateChatHistoryContentProto>(106U, PrivateChatHistoryContentProto.Parser);

		// Token: 0x040075F8 RID: 30200
		private readonly RepeatedField<PrivateChatHistoryContentProto> allChats_ = new RepeatedField<PrivateChatHistoryContentProto>();
	}
}
