using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000450 RID: 1104
	[NetMessage(EMessageId.EntityAddNotify)]
	public sealed class EntityAddNotify : IMessage<EntityAddNotify>, IMessage, IEquatable<EntityAddNotify>, IDeepCloneable<EntityAddNotify>, IBufferMessage
	{
		// Token: 0x06006A00 RID: 27136 RVA: 0x00100849 File Offset: 0x000FEA49
		[NullableContext(1)]
		public static EntityAddNotify Create()
		{
			return new EntityAddNotify();
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06006A01 RID: 27137 RVA: 0x00100850 File Offset: 0x000FEA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06006A02 RID: 27138 RVA: 0x00100853 File Offset: 0x000FEA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAddNotify.Descriptor;
			}
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x0010085A File Offset: 0x000FEA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddNotify()
		{
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x0010086D File Offset: 0x000FEA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddNotify(EntityAddNotify other) : this()
		{
			this.entityPbs_ = other.entityPbs_.Clone();
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x001008A3 File Offset: 0x000FEAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddNotify Clone()
		{
			return new EntityAddNotify(this);
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06006A06 RID: 27142 RVA: 0x001008AB File Offset: 0x000FEAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityPb> EntityPbs
		{
			get
			{
				return this.entityPbs_;
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x001008B3 File Offset: 0x000FEAB3
		// (set) Token: 0x06006A08 RID: 27144 RVA: 0x001008BB File Offset: 0x000FEABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x001008C4 File Offset: 0x000FEAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAddNotify);
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x001008D4 File Offset: 0x000FEAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAddNotify other)
		{
			return other != null && (other == this || (this.entityPbs_.Equals(other.entityPbs_) && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x00100924 File Offset: 0x000FEB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityPbs_.GetHashCode();
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x00100971 File Offset: 0x000FEB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x0010097E File Offset: 0x000FEB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x00100988 File Offset: 0x000FEB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityPbs_.WriteTo(ref output, EntityAddNotify._repeated_entityPbs_codec);
			if (this.IsAdd)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x001009D8 File Offset: 0x000FEBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityPbs_.CalculateSize(EntityAddNotify._repeated_entityPbs_codec);
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x00100A20 File Offset: 0x000FEC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityPbs_.Add(other.entityPbs_);
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x00100A6D File Offset: 0x000FEC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x00100A78 File Offset: 0x000FEC78
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
				if (num != 10U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsAdd = input.ReadBool();
					}
				}
				else
				{
					this.entityPbs_.AddEntriesFrom(ref input, EntityAddNotify._repeated_entityPbs_codec);
				}
			}
		}

		// Token: 0x04003A90 RID: 14992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A91 RID: 14993
		public const int EntityPbsFieldNumber = 1;

		// Token: 0x04003A92 RID: 14994
		private static readonly FieldCodec<EntityPb> _repeated_entityPbs_codec = FieldCodec.ForMessage<EntityPb>(10U, EntityPb.Parser);

		// Token: 0x04003A93 RID: 14995
		private readonly RepeatedField<EntityPb> entityPbs_ = new RepeatedField<EntityPb>();

		// Token: 0x04003A94 RID: 14996
		public const int IsAddFieldNumber = 9;

		// Token: 0x04003A95 RID: 14997
		private bool isAdd_;
	}
}
