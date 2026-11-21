using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000467 RID: 1127
	[NetMessage(EMessageId.EntityCommonTagNotify)]
	public sealed class EntityCommonTagNotify : IMessage<EntityCommonTagNotify>, IMessage, IEquatable<EntityCommonTagNotify>, IDeepCloneable<EntityCommonTagNotify>, IBufferMessage
	{
		// Token: 0x06006BE4 RID: 27620 RVA: 0x00104F17 File Offset: 0x00103117
		[NullableContext(1)]
		public static EntityCommonTagNotify Create()
		{
			return new EntityCommonTagNotify();
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x00104F1E File Offset: 0x0010311E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06006BE6 RID: 27622 RVA: 0x00104F21 File Offset: 0x00103121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCommonTagNotify.Descriptor;
			}
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x00104F28 File Offset: 0x00103128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCommonTagNotify()
		{
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x00104F3B File Offset: 0x0010313B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCommonTagNotify(EntityCommonTagNotify other) : this()
		{
			this.id_ = other.id_;
			this.tags_ = other.tags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x00104F71 File Offset: 0x00103171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCommonTagNotify Clone()
		{
			return new EntityCommonTagNotify(this);
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06006BEA RID: 27626 RVA: 0x00104F79 File Offset: 0x00103179
		// (set) Token: 0x06006BEB RID: 27627 RVA: 0x00104F81 File Offset: 0x00103181
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

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06006BEC RID: 27628 RVA: 0x00104F8A File Offset: 0x0010318A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CommonTagData> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x00104F92 File Offset: 0x00103192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCommonTagNotify);
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x00104FA0 File Offset: 0x001031A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCommonTagNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tags_.Equals(other.tags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x00104FF0 File Offset: 0x001031F0
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

		// Token: 0x06006BF0 RID: 27632 RVA: 0x0010503D File Offset: 0x0010323D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x0010504A File Offset: 0x0010324A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x00105054 File Offset: 0x00103254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tags_.WriteTo(ref output, EntityCommonTagNotify._repeated_tags_codec);
			if (this.Id != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x001050A4 File Offset: 0x001032A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.tags_.CalculateSize(EntityCommonTagNotify._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x001050F8 File Offset: 0x001032F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityCommonTagNotify other)
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

		// Token: 0x06006BF5 RID: 27637 RVA: 0x00105145 File Offset: 0x00103345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x00105150 File Offset: 0x00103350
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
				if (num != 82U)
				{
					if (num != 104U)
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
					this.tags_.AddEntriesFrom(ref input, EntityCommonTagNotify._repeated_tags_codec);
				}
			}
		}

		// Token: 0x04003B22 RID: 15138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B23 RID: 15139
		public const int IdFieldNumber = 13;

		// Token: 0x04003B24 RID: 15140
		private long id_;

		// Token: 0x04003B25 RID: 15141
		public const int TagsFieldNumber = 10;

		// Token: 0x04003B26 RID: 15142
		private static readonly FieldCodec<CommonTagData> _repeated_tags_codec = FieldCodec.ForMessage<CommonTagData>(82U, CommonTagData.Parser);

		// Token: 0x04003B27 RID: 15143
		private readonly RepeatedField<CommonTagData> tags_ = new RepeatedField<CommonTagData>();
	}
}
