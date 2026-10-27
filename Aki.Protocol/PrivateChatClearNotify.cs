using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDB RID: 3547
	[NetMessage(EMessageId.PrivateChatClearNotify)]
	public sealed class PrivateChatClearNotify : IMessage<PrivateChatClearNotify>, IMessage, IEquatable<PrivateChatClearNotify>, IDeepCloneable<PrivateChatClearNotify>, IBufferMessage
	{
		// Token: 0x0601316B RID: 78187 RVA: 0x002C8095 File Offset: 0x002C6295
		[NullableContext(1)]
		public static PrivateChatClearNotify Create()
		{
			return new PrivateChatClearNotify();
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x0601316C RID: 78188 RVA: 0x002C809C File Offset: 0x002C629C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x0601316D RID: 78189 RVA: 0x002C809F File Offset: 0x002C629F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatClearNotify.Descriptor;
			}
		}

		// Token: 0x0601316E RID: 78190 RVA: 0x002C80A6 File Offset: 0x002C62A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatClearNotify()
		{
		}

		// Token: 0x0601316F RID: 78191 RVA: 0x002C80B9 File Offset: 0x002C62B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatClearNotify(PrivateChatClearNotify other) : this()
		{
			this.playerId_ = other.playerId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013170 RID: 78192 RVA: 0x002C80E3 File Offset: 0x002C62E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatClearNotify Clone()
		{
			return new PrivateChatClearNotify(this);
		}

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x06013171 RID: 78193 RVA: 0x002C80EB File Offset: 0x002C62EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerId
		{
			get
			{
				return this.playerId_;
			}
		}

		// Token: 0x06013172 RID: 78194 RVA: 0x002C80F3 File Offset: 0x002C62F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatClearNotify);
		}

		// Token: 0x06013173 RID: 78195 RVA: 0x002C8101 File Offset: 0x002C6301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatClearNotify other)
		{
			return other != null && (other == this || (this.playerId_.Equals(other.playerId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013174 RID: 78196 RVA: 0x002C8134 File Offset: 0x002C6334
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

		// Token: 0x06013175 RID: 78197 RVA: 0x002C8168 File Offset: 0x002C6368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013176 RID: 78198 RVA: 0x002C8175 File Offset: 0x002C6375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013177 RID: 78199 RVA: 0x002C817E File Offset: 0x002C637E
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

		// Token: 0x06013178 RID: 78200 RVA: 0x002C81A8 File Offset: 0x002C63A8
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

		// Token: 0x06013179 RID: 78201 RVA: 0x002C81E1 File Offset: 0x002C63E1
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

		// Token: 0x0601317A RID: 78202 RVA: 0x002C820F File Offset: 0x002C640F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601317B RID: 78203 RVA: 0x002C8218 File Offset: 0x002C6418
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerId_.AddEntriesFrom(ref input, PrivateChatClearNotify._repeated_playerId_codec);
				}
			}
		}

		// Token: 0x040075B8 RID: 30136
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075B9 RID: 30137
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x040075BA RID: 30138
		private static readonly FieldCodec<int> _repeated_playerId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040075BB RID: 30139
		private readonly RepeatedField<int> playerId_ = new RepeatedField<int>();
	}
}
