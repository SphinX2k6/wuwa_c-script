using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001693 RID: 5779
	public sealed class DamageRecordEntity : IMessage<DamageRecordEntity>, IMessage, IEquatable<DamageRecordEntity>, IDeepCloneable<DamageRecordEntity>, IBufferMessage
	{
		// Token: 0x0601CF5F RID: 118623 RVA: 0x0043D13D File Offset: 0x0043B33D
		[NullableContext(1)]
		public static DamageRecordEntity Create()
		{
			return new DamageRecordEntity();
		}

		// Token: 0x17006240 RID: 25152
		// (get) Token: 0x0601CF60 RID: 118624 RVA: 0x0043D144 File Offset: 0x0043B344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006241 RID: 25153
		// (get) Token: 0x0601CF61 RID: 118625 RVA: 0x0043D147 File Offset: 0x0043B347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageRecordEntity.Descriptor;
			}
		}

		// Token: 0x0601CF62 RID: 118626 RVA: 0x0043D14E File Offset: 0x0043B34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordEntity()
		{
		}

		// Token: 0x0601CF63 RID: 118627 RVA: 0x0043D178 File Offset: 0x0043B378
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

		// Token: 0x0601CF64 RID: 118628 RVA: 0x0043D1DB File Offset: 0x0043B3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageRecordEntity Clone()
		{
			return new DamageRecordEntity(this);
		}

		// Token: 0x17006242 RID: 25154
		// (get) Token: 0x0601CF65 RID: 118629 RVA: 0x0043D1E3 File Offset: 0x0043B3E3
		// (set) Token: 0x0601CF66 RID: 118630 RVA: 0x0043D1EB File Offset: 0x0043B3EB
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

		// Token: 0x17006243 RID: 25155
		// (get) Token: 0x0601CF67 RID: 118631 RVA: 0x0043D1F4 File Offset: 0x0043B3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x17006244 RID: 25156
		// (get) Token: 0x0601CF68 RID: 118632 RVA: 0x0043D1FC File Offset: 0x0043B3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attr
		{
			get
			{
				return this.attr_;
			}
		}

		// Token: 0x17006245 RID: 25157
		// (get) Token: 0x0601CF69 RID: 118633 RVA: 0x0043D204 File Offset: 0x0043B404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> AttrSnapshot
		{
			get
			{
				return this.attrSnapshot_;
			}
		}

		// Token: 0x0601CF6A RID: 118634 RVA: 0x0043D20C File Offset: 0x0043B40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageRecordEntity);
		}

		// Token: 0x0601CF6B RID: 118635 RVA: 0x0043D21C File Offset: 0x0043B41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageRecordEntity other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.buffIds_.Equals(other.buffIds_) && this.attr_.Equals(other.attr_) && this.attrSnapshot_.Equals(other.attrSnapshot_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF6C RID: 118636 RVA: 0x0043D294 File Offset: 0x0043B494
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

		// Token: 0x0601CF6D RID: 118637 RVA: 0x0043D2FD File Offset: 0x0043B4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF6E RID: 118638 RVA: 0x0043D30A File Offset: 0x0043B50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF6F RID: 118639 RVA: 0x0043D314 File Offset: 0x0043B514
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

		// Token: 0x0601CF70 RID: 118640 RVA: 0x0043D384 File Offset: 0x0043B584
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

		// Token: 0x0601CF71 RID: 118641 RVA: 0x0043D3FC File Offset: 0x0043B5FC
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

		// Token: 0x0601CF72 RID: 118642 RVA: 0x0043D46B File Offset: 0x0043B66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF73 RID: 118643 RVA: 0x0043D474 File Offset: 0x0043B674
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

		// Token: 0x0400C391 RID: 50065
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C392 RID: 50066
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400C393 RID: 50067
		private long entityId_;

		// Token: 0x0400C394 RID: 50068
		public const int BuffIdsFieldNumber = 2;

		// Token: 0x0400C395 RID: 50069
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x0400C396 RID: 50070
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();

		// Token: 0x0400C397 RID: 50071
		public const int AttrFieldNumber = 3;

		// Token: 0x0400C398 RID: 50072
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attr_codec = FieldCodec.ForMessage<GameplayAttributeData>(26U, GameplayAttributeData.Parser);

		// Token: 0x0400C399 RID: 50073
		private readonly RepeatedField<GameplayAttributeData> attr_ = new RepeatedField<GameplayAttributeData>();

		// Token: 0x0400C39A RID: 50074
		public const int AttrSnapshotFieldNumber = 4;

		// Token: 0x0400C39B RID: 50075
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attrSnapshot_codec = FieldCodec.ForMessage<GameplayAttributeData>(34U, GameplayAttributeData.Parser);

		// Token: 0x0400C39C RID: 50076
		private readonly RepeatedField<GameplayAttributeData> attrSnapshot_ = new RepeatedField<GameplayAttributeData>();
	}
}
