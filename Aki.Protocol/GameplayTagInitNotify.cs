using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AC RID: 1708
	[NetMessage(EMessageId.GameplayTagInitNotify)]
	public sealed class GameplayTagInitNotify : IMessage<GameplayTagInitNotify>, IMessage, IEquatable<GameplayTagInitNotify>, IDeepCloneable<GameplayTagInitNotify>, IBufferMessage
	{
		// Token: 0x06009CB8 RID: 40120 RVA: 0x0017D693 File Offset: 0x0017B893
		[NullableContext(1)]
		public static GameplayTagInitNotify Create()
		{
			return new GameplayTagInitNotify();
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06009CB9 RID: 40121 RVA: 0x0017D69A File Offset: 0x0017B89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06009CBA RID: 40122 RVA: 0x0017D69D File Offset: 0x0017B89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagInitNotify.Descriptor;
			}
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x0017D6A4 File Offset: 0x0017B8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagInitNotify()
		{
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x0017D6B7 File Offset: 0x0017B8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagInitNotify(GameplayTagInitNotify other) : this()
		{
			this.id_ = other.id_;
			this.tags_ = other.tags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CBD RID: 40125 RVA: 0x0017D6ED File Offset: 0x0017B8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagInitNotify Clone()
		{
			return new GameplayTagInitNotify(this);
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06009CBE RID: 40126 RVA: 0x0017D6F5 File Offset: 0x0017B8F5
		// (set) Token: 0x06009CBF RID: 40127 RVA: 0x0017D6FD File Offset: 0x0017B8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x0017D706 File Offset: 0x0017B906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x0017D70E File Offset: 0x0017B90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagInitNotify);
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x0017D71C File Offset: 0x0017B91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagInitNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tags_.Equals(other.tags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x0017D76C File Offset: 0x0017B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.tags_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x0017D7B9 File Offset: 0x0017B9B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CC5 RID: 40133 RVA: 0x0017D7C6 File Offset: 0x0017B9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CC6 RID: 40134 RVA: 0x0017D7D0 File Offset: 0x0017B9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			this.tags_.WriteTo(ref output, GameplayTagInitNotify._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x0017D820 File Offset: 0x0017BA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.tags_.CalculateSize(GameplayTagInitNotify._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x0017D874 File Offset: 0x0017BA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayTagInitNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this.tags_.Add(other.tags_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x0017D8C1 File Offset: 0x0017BAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x0017D8CC File Offset: 0x0017BACC
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
				if (num != 24U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tags_.AddEntriesFrom(ref input, GameplayTagInitNotify._repeated_tags_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049D5 RID: 18901
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049D6 RID: 18902
		public const int IdFieldNumber = 3;

		// Token: 0x040049D7 RID: 18903
		private long id_;

		// Token: 0x040049D8 RID: 18904
		public const int TagsFieldNumber = 7;

		// Token: 0x040049D9 RID: 18905
		private static readonly FieldCodec<GameplayTagData> _repeated_tags_codec = FieldCodec.ForMessage<GameplayTagData>(58U, GameplayTagData.Parser);

		// Token: 0x040049DA RID: 18906
		private readonly RepeatedField<GameplayTagData> tags_ = new RepeatedField<GameplayTagData>();
	}
}
