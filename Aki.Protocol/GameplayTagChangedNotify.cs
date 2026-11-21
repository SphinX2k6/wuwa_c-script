using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000696 RID: 1686
	[NetMessage(EMessageId.GameplayTagChangedNotify)]
	public sealed class GameplayTagChangedNotify : IMessage<GameplayTagChangedNotify>, IMessage, IEquatable<GameplayTagChangedNotify>, IDeepCloneable<GameplayTagChangedNotify>, IBufferMessage
	{
		// Token: 0x06009B38 RID: 39736 RVA: 0x0017A6F9 File Offset: 0x001788F9
		[NullableContext(1)]
		public static GameplayTagChangedNotify Create()
		{
			return new GameplayTagChangedNotify();
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06009B39 RID: 39737 RVA: 0x0017A700 File Offset: 0x00178900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06009B3A RID: 39738 RVA: 0x0017A703 File Offset: 0x00178903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagChangedNotify.Descriptor;
			}
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x0017A70A File Offset: 0x0017890A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagChangedNotify()
		{
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x0017A71D File Offset: 0x0017891D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagChangedNotify(GameplayTagChangedNotify other) : this()
		{
			this.id_ = other.id_;
			this.tags_ = other.tags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x0017A753 File Offset: 0x00178953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagChangedNotify Clone()
		{
			return new GameplayTagChangedNotify(this);
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06009B3E RID: 39742 RVA: 0x0017A75B File Offset: 0x0017895B
		// (set) Token: 0x06009B3F RID: 39743 RVA: 0x0017A763 File Offset: 0x00178963
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

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06009B40 RID: 39744 RVA: 0x0017A76C File Offset: 0x0017896C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x0017A774 File Offset: 0x00178974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagChangedNotify);
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x0017A784 File Offset: 0x00178984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagChangedNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tags_.Equals(other.tags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x0017A7D4 File Offset: 0x001789D4
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

		// Token: 0x06009B44 RID: 39748 RVA: 0x0017A821 File Offset: 0x00178A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x0017A82E File Offset: 0x00178A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x0017A838 File Offset: 0x00178A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tags_.WriteTo(ref output, GameplayTagChangedNotify._repeated_tags_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x0017A888 File Offset: 0x00178A88
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

		// Token: 0x06009B48 RID: 39752 RVA: 0x0017A8DC File Offset: 0x00178ADC
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

		// Token: 0x06009B49 RID: 39753 RVA: 0x0017A929 File Offset: 0x00178B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x0017A934 File Offset: 0x00178B34
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
				if (num != 42U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.tags_.AddEntriesFrom(ref input, GameplayTagChangedNotify._repeated_tags_codec);
				}
			}
		}

		// Token: 0x040049C2 RID: 18882
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049C3 RID: 18883
		public const int IdFieldNumber = 15;

		// Token: 0x040049C4 RID: 18884
		private long id_;

		// Token: 0x040049C5 RID: 18885
		public const int TagsFieldNumber = 5;

		// Token: 0x040049C6 RID: 18886
		private static readonly FieldCodec<GameplayTagData> _repeated_tags_codec = FieldCodec.ForMessage<GameplayTagData>(42U, GameplayTagData.Parser);

		// Token: 0x040049C7 RID: 18887
		private readonly RepeatedField<GameplayTagData> tags_ = new RepeatedField<GameplayTagData>();
	}
}
