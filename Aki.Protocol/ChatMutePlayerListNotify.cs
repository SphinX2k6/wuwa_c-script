using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027B RID: 635
	[NetMessage(EMessageId.ChatMutePlayerListNotify)]
	public sealed class ChatMutePlayerListNotify : IMessage<ChatMutePlayerListNotify>, IMessage, IEquatable<ChatMutePlayerListNotify>, IDeepCloneable<ChatMutePlayerListNotify>, IBufferMessage
	{
		// Token: 0x060042B7 RID: 17079 RVA: 0x000A3CCC File Offset: 0x000A1ECC
		[NullableContext(1)]
		public static ChatMutePlayerListNotify Create()
		{
			return new ChatMutePlayerListNotify();
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x000A3CD3 File Offset: 0x000A1ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x000A3CD6 File Offset: 0x000A1ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatMutePlayerListNotify.Descriptor;
			}
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x000A3CDD File Offset: 0x000A1EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerListNotify()
		{
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x000A3CF0 File Offset: 0x000A1EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerListNotify(ChatMutePlayerListNotify other) : this()
		{
			this.playerId_ = other.playerId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x000A3D1A File Offset: 0x000A1F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerListNotify Clone()
		{
			return new ChatMutePlayerListNotify(this);
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x000A3D22 File Offset: 0x000A1F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerId
		{
			get
			{
				return this.playerId_;
			}
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x000A3D2A File Offset: 0x000A1F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatMutePlayerListNotify);
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x000A3D38 File Offset: 0x000A1F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatMutePlayerListNotify other)
		{
			return other != null && (other == this || (this.playerId_.Equals(other.playerId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x000A3D6C File Offset: 0x000A1F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x000A3DA0 File Offset: 0x000A1FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x000A3DAD File Offset: 0x000A1FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x000A3DB6 File Offset: 0x000A1FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerId_.WriteTo(ref output, ChatMutePlayerListNotify._repeated_playerId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x000A3DE0 File Offset: 0x000A1FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerId_.CalculateSize(ChatMutePlayerListNotify._repeated_playerId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x000A3E19 File Offset: 0x000A2019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatMutePlayerListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerId_.Add(other.playerId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x000A3E47 File Offset: 0x000A2047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x000A3E50 File Offset: 0x000A2050
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerId_.AddEntriesFrom(ref input, ChatMutePlayerListNotify._repeated_playerId_codec);
				}
			}
		}

		// Token: 0x04002E23 RID: 11811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E24 RID: 11812
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04002E25 RID: 11813
		private static readonly FieldCodec<int> _repeated_playerId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04002E26 RID: 11814
		private readonly RepeatedField<int> playerId_ = new RepeatedField<int>();
	}
}
