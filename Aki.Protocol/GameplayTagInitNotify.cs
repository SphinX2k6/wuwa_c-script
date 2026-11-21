using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000698 RID: 1688
	[NetMessage(EMessageId.GameplayTagInitNotify)]
	public sealed class GameplayTagInitNotify : IMessage<GameplayTagInitNotify>, IMessage, IEquatable<GameplayTagInitNotify>, IDeepCloneable<GameplayTagInitNotify>, IBufferMessage
	{
		// Token: 0x06009B62 RID: 39778 RVA: 0x0017AC5B File Offset: 0x00178E5B
		[NullableContext(1)]
		public static GameplayTagInitNotify Create()
		{
			return new GameplayTagInitNotify();
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06009B63 RID: 39779 RVA: 0x0017AC62 File Offset: 0x00178E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06009B64 RID: 39780 RVA: 0x0017AC65 File Offset: 0x00178E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagInitNotify.Descriptor;
			}
		}

		// Token: 0x06009B65 RID: 39781 RVA: 0x0017AC6C File Offset: 0x00178E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagInitNotify()
		{
		}

		// Token: 0x06009B66 RID: 39782 RVA: 0x0017AC7F File Offset: 0x00178E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagInitNotify(GameplayTagInitNotify other) : this()
		{
			this.id_ = other.id_;
			this.tags_ = other.tags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x0017ACB5 File Offset: 0x00178EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagInitNotify Clone()
		{
			return new GameplayTagInitNotify(this);
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06009B68 RID: 39784 RVA: 0x0017ACBD File Offset: 0x00178EBD
		// (set) Token: 0x06009B69 RID: 39785 RVA: 0x0017ACC5 File Offset: 0x00178EC5
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

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06009B6A RID: 39786 RVA: 0x0017ACCE File Offset: 0x00178ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x06009B6B RID: 39787 RVA: 0x0017ACD6 File Offset: 0x00178ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagInitNotify);
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x0017ACE4 File Offset: 0x00178EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagInitNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tags_.Equals(other.tags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B6D RID: 39789 RVA: 0x0017AD34 File Offset: 0x00178F34
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

		// Token: 0x06009B6E RID: 39790 RVA: 0x0017AD81 File Offset: 0x00178F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B6F RID: 39791 RVA: 0x0017AD8E File Offset: 0x00178F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B70 RID: 39792 RVA: 0x0017AD98 File Offset: 0x00178F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			this.tags_.WriteTo(ref output, GameplayTagInitNotify._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B71 RID: 39793 RVA: 0x0017ADE8 File Offset: 0x00178FE8
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

		// Token: 0x06009B72 RID: 39794 RVA: 0x0017AE3C File Offset: 0x0017903C
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

		// Token: 0x06009B73 RID: 39795 RVA: 0x0017AE89 File Offset: 0x00179089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x0017AE94 File Offset: 0x00179094
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
				if (num != 80U)
				{
					if (num != 106U)
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

		// Token: 0x040049CE RID: 18894
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049CF RID: 18895
		public const int IdFieldNumber = 10;

		// Token: 0x040049D0 RID: 18896
		private long id_;

		// Token: 0x040049D1 RID: 18897
		public const int TagsFieldNumber = 13;

		// Token: 0x040049D2 RID: 18898
		private static readonly FieldCodec<GameplayTagData> _repeated_tags_codec = FieldCodec.ForMessage<GameplayTagData>(106U, GameplayTagData.Parser);

		// Token: 0x040049D3 RID: 18899
		private readonly RepeatedField<GameplayTagData> tags_ = new RepeatedField<GameplayTagData>();
	}
}
