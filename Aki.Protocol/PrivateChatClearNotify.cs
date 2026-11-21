using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCB RID: 3531
	[NetMessage(EMessageId.PrivateChatClearNotify)]
	public sealed class PrivateChatClearNotify : IMessage<PrivateChatClearNotify>, IMessage, IEquatable<PrivateChatClearNotify>, IDeepCloneable<PrivateChatClearNotify>, IBufferMessage
	{
		// Token: 0x06013086 RID: 77958 RVA: 0x002C69D1 File Offset: 0x002C4BD1
		[NullableContext(1)]
		public static PrivateChatClearNotify Create()
		{
			return new PrivateChatClearNotify();
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x06013087 RID: 77959 RVA: 0x002C69D8 File Offset: 0x002C4BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x06013088 RID: 77960 RVA: 0x002C69DB File Offset: 0x002C4BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatClearNotify.Descriptor;
			}
		}

		// Token: 0x06013089 RID: 77961 RVA: 0x002C69E2 File Offset: 0x002C4BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatClearNotify()
		{
		}

		// Token: 0x0601308A RID: 77962 RVA: 0x002C69F5 File Offset: 0x002C4BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatClearNotify(PrivateChatClearNotify other) : this()
		{
			this.playerId_ = other.playerId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601308B RID: 77963 RVA: 0x002C6A1F File Offset: 0x002C4C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatClearNotify Clone()
		{
			return new PrivateChatClearNotify(this);
		}

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x0601308C RID: 77964 RVA: 0x002C6A27 File Offset: 0x002C4C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerId
		{
			get
			{
				return this.playerId_;
			}
		}

		// Token: 0x0601308D RID: 77965 RVA: 0x002C6A2F File Offset: 0x002C4C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatClearNotify);
		}

		// Token: 0x0601308E RID: 77966 RVA: 0x002C6A3D File Offset: 0x002C4C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatClearNotify other)
		{
			return other != null && (other == this || (this.playerId_.Equals(other.playerId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601308F RID: 77967 RVA: 0x002C6A70 File Offset: 0x002C4C70
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

		// Token: 0x06013090 RID: 77968 RVA: 0x002C6AA4 File Offset: 0x002C4CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013091 RID: 77969 RVA: 0x002C6AB1 File Offset: 0x002C4CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013092 RID: 77970 RVA: 0x002C6ABA File Offset: 0x002C4CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerId_.WriteTo(ref output, PrivateChatClearNotify._repeated_playerId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013093 RID: 77971 RVA: 0x002C6AE4 File Offset: 0x002C4CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerId_.CalculateSize(PrivateChatClearNotify._repeated_playerId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013094 RID: 77972 RVA: 0x002C6B1D File Offset: 0x002C4D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatClearNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerId_.Add(other.playerId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013095 RID: 77973 RVA: 0x002C6B4B File Offset: 0x002C4D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013096 RID: 77974 RVA: 0x002C6B54 File Offset: 0x002C4D54
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerId_.AddEntriesFrom(ref input, PrivateChatClearNotify._repeated_playerId_codec);
				}
			}
		}

		// Token: 0x040075E2 RID: 30178
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075E3 RID: 30179
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x040075E4 RID: 30180
		private static readonly FieldCodec<int> _repeated_playerId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040075E5 RID: 30181
		private readonly RepeatedField<int> playerId_ = new RepeatedField<int>();
	}
}
