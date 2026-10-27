using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AA RID: 1706
	[NetMessage(EMessageId.GameplayTagChangedNotify)]
	public sealed class GameplayTagChangedNotify : IMessage<GameplayTagChangedNotify>, IMessage, IEquatable<GameplayTagChangedNotify>, IDeepCloneable<GameplayTagChangedNotify>, IBufferMessage
	{
		// Token: 0x06009C8E RID: 40078 RVA: 0x0017D131 File Offset: 0x0017B331
		[NullableContext(1)]
		public static GameplayTagChangedNotify Create()
		{
			return new GameplayTagChangedNotify();
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06009C8F RID: 40079 RVA: 0x0017D138 File Offset: 0x0017B338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06009C90 RID: 40080 RVA: 0x0017D13B File Offset: 0x0017B33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagChangedNotify.Descriptor;
			}
		}

		// Token: 0x06009C91 RID: 40081 RVA: 0x0017D142 File Offset: 0x0017B342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagChangedNotify()
		{
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x0017D155 File Offset: 0x0017B355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagChangedNotify(GameplayTagChangedNotify other) : this()
		{
			this.id_ = other.id_;
			this.tags_ = other.tags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C93 RID: 40083 RVA: 0x0017D18B File Offset: 0x0017B38B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagChangedNotify Clone()
		{
			return new GameplayTagChangedNotify(this);
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06009C94 RID: 40084 RVA: 0x0017D193 File Offset: 0x0017B393
		// (set) Token: 0x06009C95 RID: 40085 RVA: 0x0017D19B File Offset: 0x0017B39B
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

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x0017D1A4 File Offset: 0x0017B3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x06009C97 RID: 40087 RVA: 0x0017D1AC File Offset: 0x0017B3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagChangedNotify);
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x0017D1BC File Offset: 0x0017B3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagChangedNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tags_.Equals(other.tags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C99 RID: 40089 RVA: 0x0017D20C File Offset: 0x0017B40C
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

		// Token: 0x06009C9A RID: 40090 RVA: 0x0017D259 File Offset: 0x0017B459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x0017D266 File Offset: 0x0017B466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x0017D270 File Offset: 0x0017B470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			this.tags_.WriteTo(ref output, GameplayTagChangedNotify._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x0017D2C0 File Offset: 0x0017B4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.tags_.CalculateSize(GameplayTagChangedNotify._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C9E RID: 40094 RVA: 0x0017D314 File Offset: 0x0017B514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayTagChangedNotify other)
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

		// Token: 0x06009C9F RID: 40095 RVA: 0x0017D361 File Offset: 0x0017B561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CA0 RID: 40096 RVA: 0x0017D36C File Offset: 0x0017B56C
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tags_.AddEntriesFrom(ref input, GameplayTagChangedNotify._repeated_tags_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049C9 RID: 18889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049CA RID: 18890
		public const int IdFieldNumber = 1;

		// Token: 0x040049CB RID: 18891
		private long id_;

		// Token: 0x040049CC RID: 18892
		public const int TagsFieldNumber = 14;

		// Token: 0x040049CD RID: 18893
		private static readonly FieldCodec<GameplayTagData> _repeated_tags_codec = FieldCodec.ForMessage<GameplayTagData>(114U, GameplayTagData.Parser);

		// Token: 0x040049CE RID: 18894
		private readonly RepeatedField<GameplayTagData> tags_ = new RepeatedField<GameplayTagData>();
	}
}
