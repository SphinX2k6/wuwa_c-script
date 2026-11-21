using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD7 RID: 3543
	public sealed class PrivateTag : IMessage<PrivateTag>, IMessage, IEquatable<PrivateTag>, IDeepCloneable<PrivateTag>, IBufferMessage
	{
		// Token: 0x06013177 RID: 78199 RVA: 0x002C8A04 File Offset: 0x002C6C04
		[NullableContext(1)]
		public static PrivateTag Create()
		{
			return new PrivateTag();
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x06013178 RID: 78200 RVA: 0x002C8A0B File Offset: 0x002C6C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrivateTag> Parser
		{
			get
			{
				return PrivateTag._parser;
			}
		}

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x06013179 RID: 78201 RVA: 0x002C8A12 File Offset: 0x002C6C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x0601317A RID: 78202 RVA: 0x002C8A15 File Offset: 0x002C6C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateTag.Descriptor;
			}
		}

		// Token: 0x0601317B RID: 78203 RVA: 0x002C8A1C File Offset: 0x002C6C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateTag()
		{
		}

		// Token: 0x0601317C RID: 78204 RVA: 0x002C8A2F File Offset: 0x002C6C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateTag(PrivateTag other) : this()
		{
			this.playerId_ = other.playerId_;
			this.tags_ = other.tags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601317D RID: 78205 RVA: 0x002C8A65 File Offset: 0x002C6C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateTag Clone()
		{
			return new PrivateTag(this);
		}

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x0601317E RID: 78206 RVA: 0x002C8A6D File Offset: 0x002C6C6D
		// (set) Token: 0x0601317F RID: 78207 RVA: 0x002C8A75 File Offset: 0x002C6C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x06013180 RID: 78208 RVA: 0x002C8A7E File Offset: 0x002C6C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x06013181 RID: 78209 RVA: 0x002C8A86 File Offset: 0x002C6C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateTag);
		}

		// Token: 0x06013182 RID: 78210 RVA: 0x002C8A94 File Offset: 0x002C6C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateTag other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.tags_.Equals(other.tags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013183 RID: 78211 RVA: 0x002C8AE4 File Offset: 0x002C6CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.tags_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013184 RID: 78212 RVA: 0x002C8B31 File Offset: 0x002C6D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013185 RID: 78213 RVA: 0x002C8B3E File Offset: 0x002C6D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013186 RID: 78214 RVA: 0x002C8B48 File Offset: 0x002C6D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.tags_.WriteTo(ref output, PrivateTag._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013187 RID: 78215 RVA: 0x002C8B98 File Offset: 0x002C6D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.tags_.CalculateSize(PrivateTag._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013188 RID: 78216 RVA: 0x002C8BEC File Offset: 0x002C6DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateTag other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.tags_.Add(other.tags_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013189 RID: 78217 RVA: 0x002C8C39 File Offset: 0x002C6E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601318A RID: 78218 RVA: 0x002C8C44 File Offset: 0x002C6E44
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
				if (num != 8U)
				{
					if (num != 250U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tags_.AddEntriesFrom(ref input, PrivateTag._repeated_tags_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007623 RID: 30243
		private static readonly MessageParser<PrivateTag> _parser = new MessageParser<PrivateTag>(() => new PrivateTag());

		// Token: 0x04007624 RID: 30244
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007625 RID: 30245
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007626 RID: 30246
		private int playerId_;

		// Token: 0x04007627 RID: 30247
		public const int TagsFieldNumber = 31;

		// Token: 0x04007628 RID: 30248
		private static readonly FieldCodec<string> _repeated_tags_codec = FieldCodec.ForString(250U);

		// Token: 0x04007629 RID: 30249
		private readonly RepeatedField<string> tags_ = new RepeatedField<string>();
	}
}
