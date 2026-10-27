using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDF RID: 3551
	[NetMessage(EMessageId.PrivateChatHistoryNotify)]
	public sealed class PrivateChatHistoryNotify : IMessage<PrivateChatHistoryNotify>, IMessage, IEquatable<PrivateChatHistoryNotify>, IDeepCloneable<PrivateChatHistoryNotify>, IBufferMessage
	{
		// Token: 0x060131B8 RID: 78264 RVA: 0x002C8992 File Offset: 0x002C6B92
		[NullableContext(1)]
		public static PrivateChatHistoryNotify Create()
		{
			return new PrivateChatHistoryNotify();
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x060131B9 RID: 78265 RVA: 0x002C8999 File Offset: 0x002C6B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x060131BA RID: 78266 RVA: 0x002C899C File Offset: 0x002C6B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatHistoryNotify.Descriptor;
			}
		}

		// Token: 0x060131BB RID: 78267 RVA: 0x002C89A3 File Offset: 0x002C6BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryNotify()
		{
		}

		// Token: 0x060131BC RID: 78268 RVA: 0x002C89B6 File Offset: 0x002C6BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryNotify(PrivateChatHistoryNotify other) : this()
		{
			this.allChats_ = other.allChats_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131BD RID: 78269 RVA: 0x002C89E0 File Offset: 0x002C6BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryNotify Clone()
		{
			return new PrivateChatHistoryNotify(this);
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x060131BE RID: 78270 RVA: 0x002C89E8 File Offset: 0x002C6BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PrivateChatHistoryContentProto> AllChats
		{
			get
			{
				return this.allChats_;
			}
		}

		// Token: 0x060131BF RID: 78271 RVA: 0x002C89F0 File Offset: 0x002C6BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatHistoryNotify);
		}

		// Token: 0x060131C0 RID: 78272 RVA: 0x002C89FE File Offset: 0x002C6BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatHistoryNotify other)
		{
			return other != null && (other == this || (this.allChats_.Equals(other.allChats_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131C1 RID: 78273 RVA: 0x002C8A34 File Offset: 0x002C6C34
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

		// Token: 0x060131C2 RID: 78274 RVA: 0x002C8A68 File Offset: 0x002C6C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131C3 RID: 78275 RVA: 0x002C8A75 File Offset: 0x002C6C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131C4 RID: 78276 RVA: 0x002C8A7E File Offset: 0x002C6C7E
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

		// Token: 0x060131C5 RID: 78277 RVA: 0x002C8AA8 File Offset: 0x002C6CA8
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

		// Token: 0x060131C6 RID: 78278 RVA: 0x002C8AE1 File Offset: 0x002C6CE1
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

		// Token: 0x060131C7 RID: 78279 RVA: 0x002C8B0F File Offset: 0x002C6D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060131C8 RID: 78280 RVA: 0x002C8B18 File Offset: 0x002C6D18
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.allChats_.AddEntriesFrom(ref input, PrivateChatHistoryNotify._repeated_allChats_codec);
				}
			}
		}

		// Token: 0x040075CB RID: 30155
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075CC RID: 30156
		public const int AllChatsFieldNumber = 11;

		// Token: 0x040075CD RID: 30157
		private static readonly FieldCodec<PrivateChatHistoryContentProto> _repeated_allChats_codec = FieldCodec.ForMessage<PrivateChatHistoryContentProto>(90U, PrivateChatHistoryContentProto.Parser);

		// Token: 0x040075CE RID: 30158
		private readonly RepeatedField<PrivateChatHistoryContentProto> allChats_ = new RepeatedField<PrivateChatHistoryContentProto>();
	}
}
