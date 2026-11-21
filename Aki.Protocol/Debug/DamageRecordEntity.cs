using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200170F RID: 5903
	public sealed class DamageRecordEntity : IMessage<DamageRecordEntity>, IMessage, IEquatable<DamageRecordEntity>, IDeepCloneable<DamageRecordEntity>, IBufferMessage
	{
		// Token: 0x0601DA2E RID: 121390 RVA: 0x00458E78 File Offset: 0x00457078
		[NullableContext(1)]
		public static DamageRecordEntity Create()
		{
			return new DamageRecordEntity();
		}

		// Token: 0x170064E5 RID: 25829
		// (get) Token: 0x0601DA2F RID: 121391 RVA: 0x00458E7F File Offset: 0x0045707F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064E6 RID: 25830
		// (get) Token: 0x0601DA30 RID: 121392 RVA: 0x00458E82 File Offset: 0x00457082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageRecordEntity.Descriptor;
			}
		}

		// Token: 0x0601DA31 RID: 121393 RVA: 0x00458E89 File Offset: 0x00457089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordEntity()
		{
		}

		// Token: 0x0601DA32 RID: 121394 RVA: 0x00458EB4 File Offset: 0x004570B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordEntity(DamageRecordEntity other) : this()
		{
			this.entityId_ = other.entityId_;
			this.buffIds_ = other.buffIds_.Clone();
			this.attr_ = other.attr_.Clone();
			this.attrSnapshot_ = other.attrSnapshot_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DA33 RID: 121395 RVA: 0x00458F17 File Offset: 0x00457117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordEntity Clone()
		{
			return new DamageRecordEntity(this);
		}

		// Token: 0x170064E7 RID: 25831
		// (get) Token: 0x0601DA34 RID: 121396 RVA: 0x00458F1F File Offset: 0x0045711F
		// (set) Token: 0x0601DA35 RID: 121397 RVA: 0x00458F27 File Offset: 0x00457127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170064E8 RID: 25832
		// (get) Token: 0x0601DA36 RID: 121398 RVA: 0x00458F30 File Offset: 0x00457130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x170064E9 RID: 25833
		// (get) Token: 0x0601DA37 RID: 121399 RVA: 0x00458F38 File Offset: 0x00457138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attr
		{
			get
			{
				return this.attr_;
			}
		}

		// Token: 0x170064EA RID: 25834
		// (get) Token: 0x0601DA38 RID: 121400 RVA: 0x00458F40 File Offset: 0x00457140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> AttrSnapshot
		{
			get
			{
				return this.attrSnapshot_;
			}
		}

		// Token: 0x0601DA39 RID: 121401 RVA: 0x00458F48 File Offset: 0x00457148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageRecordEntity);
		}

		// Token: 0x0601DA3A RID: 121402 RVA: 0x00458F58 File Offset: 0x00457158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageRecordEntity other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.buffIds_.Equals(other.buffIds_) && this.attr_.Equals(other.attr_) && this.attrSnapshot_.Equals(other.attrSnapshot_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DA3B RID: 121403 RVA: 0x00458FD0 File Offset: 0x004571D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.buffIds_.GetHashCode();
			num ^= this.attr_.GetHashCode();
			num ^= this.attrSnapshot_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DA3C RID: 121404 RVA: 0x00459039 File Offset: 0x00457239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DA3D RID: 121405 RVA: 0x00459046 File Offset: 0x00457246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DA3E RID: 121406 RVA: 0x00459050 File Offset: 0x00457250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.buffIds_.WriteTo(ref output, DamageRecordEntity._repeated_buffIds_codec);
			this.attr_.WriteTo(ref output, DamageRecordEntity._repeated_attr_codec);
			this.attrSnapshot_.WriteTo(ref output, DamageRecordEntity._repeated_attrSnapshot_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DA3F RID: 121407 RVA: 0x004590C0 File Offset: 0x004572C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.buffIds_.CalculateSize(DamageRecordEntity._repeated_buffIds_codec);
			num += this.attr_.CalculateSize(DamageRecordEntity._repeated_attr_codec);
			num += this.attrSnapshot_.CalculateSize(DamageRecordEntity._repeated_attrSnapshot_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DA40 RID: 121408 RVA: 0x00459138 File Offset: 0x00457338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DamageRecordEntity other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.buffIds_.Add(other.buffIds_);
			this.attr_.Add(other.attr_);
			this.attrSnapshot_.Add(other.attrSnapshot_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DA41 RID: 121409 RVA: 0x004591A7 File Offset: 0x004573A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DA42 RID: 121410 RVA: 0x004591B0 File Offset: 0x004573B0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 26U)
					{
						this.attr_.AddEntriesFrom(ref input, DamageRecordEntity._repeated_attr_codec);
						continue;
					}
					if (num == 34U)
					{
						this.attrSnapshot_.AddEntriesFrom(ref input, DamageRecordEntity._repeated_attrSnapshot_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.buffIds_.AddEntriesFrom(ref input, DamageRecordEntity._repeated_buffIds_codec);
			}
		}

		// Token: 0x0400C8C0 RID: 51392
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C8C1 RID: 51393
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400C8C2 RID: 51394
		private long entityId_;

		// Token: 0x0400C8C3 RID: 51395
		public const int BuffIdsFieldNumber = 2;

		// Token: 0x0400C8C4 RID: 51396
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x0400C8C5 RID: 51397
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();

		// Token: 0x0400C8C6 RID: 51398
		public const int AttrFieldNumber = 3;

		// Token: 0x0400C8C7 RID: 51399
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attr_codec = FieldCodec.ForMessage<GameplayAttributeData>(26U, GameplayAttributeData.Parser);

		// Token: 0x0400C8C8 RID: 51400
		private readonly RepeatedField<GameplayAttributeData> attr_ = new RepeatedField<GameplayAttributeData>();

		// Token: 0x0400C8C9 RID: 51401
		public const int AttrSnapshotFieldNumber = 4;

		// Token: 0x0400C8CA RID: 51402
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attrSnapshot_codec = FieldCodec.ForMessage<GameplayAttributeData>(34U, GameplayAttributeData.Parser);

		// Token: 0x0400C8CB RID: 51403
		private readonly RepeatedField<GameplayAttributeData> attrSnapshot_ = new RepeatedField<GameplayAttributeData>();
	}
}
