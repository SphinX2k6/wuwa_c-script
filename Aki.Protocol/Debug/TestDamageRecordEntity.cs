using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200171B RID: 5915
	public sealed class TestDamageRecordEntity : IMessage<TestDamageRecordEntity>, IMessage, IEquatable<TestDamageRecordEntity>, IDeepCloneable<TestDamageRecordEntity>, IBufferMessage
	{
		// Token: 0x0601DB2C RID: 121644 RVA: 0x0045B47E File Offset: 0x0045967E
		[NullableContext(1)]
		public static TestDamageRecordEntity Create()
		{
			return new TestDamageRecordEntity();
		}

		// Token: 0x1700651D RID: 25885
		// (get) Token: 0x0601DB2D RID: 121645 RVA: 0x0045B485 File Offset: 0x00459685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TestDamageRecordEntity> Parser
		{
			get
			{
				return TestDamageRecordEntity._parser;
			}
		}

		// Token: 0x1700651E RID: 25886
		// (get) Token: 0x0601DB2E RID: 121646 RVA: 0x0045B48C File Offset: 0x0045968C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700651F RID: 25887
		// (get) Token: 0x0601DB2F RID: 121647 RVA: 0x0045B48F File Offset: 0x0045968F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestDamageRecordEntity.Descriptor;
			}
		}

		// Token: 0x0601DB30 RID: 121648 RVA: 0x0045B496 File Offset: 0x00459696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordEntity()
		{
		}

		// Token: 0x0601DB31 RID: 121649 RVA: 0x0045B4B4 File Offset: 0x004596B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordEntity(TestDamageRecordEntity other) : this()
		{
			this.entityId_ = other.entityId_;
			this.configId_ = other.configId_;
			this.buffIds_ = other.buffIds_.Clone();
			this.attr_ = other.attr_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DB32 RID: 121650 RVA: 0x0045B512 File Offset: 0x00459712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordEntity Clone()
		{
			return new TestDamageRecordEntity(this);
		}

		// Token: 0x17006520 RID: 25888
		// (get) Token: 0x0601DB33 RID: 121651 RVA: 0x0045B51A File Offset: 0x0045971A
		// (set) Token: 0x0601DB34 RID: 121652 RVA: 0x0045B522 File Offset: 0x00459722
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

		// Token: 0x17006521 RID: 25889
		// (get) Token: 0x0601DB35 RID: 121653 RVA: 0x0045B52B File Offset: 0x0045972B
		// (set) Token: 0x0601DB36 RID: 121654 RVA: 0x0045B533 File Offset: 0x00459733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17006522 RID: 25890
		// (get) Token: 0x0601DB37 RID: 121655 RVA: 0x0045B53C File Offset: 0x0045973C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x17006523 RID: 25891
		// (get) Token: 0x0601DB38 RID: 121656 RVA: 0x0045B544 File Offset: 0x00459744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attr
		{
			get
			{
				return this.attr_;
			}
		}

		// Token: 0x0601DB39 RID: 121657 RVA: 0x0045B54C File Offset: 0x0045974C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestDamageRecordEntity);
		}

		// Token: 0x0601DB3A RID: 121658 RVA: 0x0045B55C File Offset: 0x0045975C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestDamageRecordEntity other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ConfigId == other.ConfigId && this.buffIds_.Equals(other.buffIds_) && this.attr_.Equals(other.attr_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DB3B RID: 121659 RVA: 0x0045B5D0 File Offset: 0x004597D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			num ^= this.buffIds_.GetHashCode();
			num ^= this.attr_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DB3C RID: 121660 RVA: 0x0045B644 File Offset: 0x00459844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DB3D RID: 121661 RVA: 0x0045B651 File Offset: 0x00459851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DB3E RID: 121662 RVA: 0x0045B65C File Offset: 0x0045985C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigId);
			}
			this.buffIds_.WriteTo(ref output, TestDamageRecordEntity._repeated_buffIds_codec);
			this.attr_.WriteTo(ref output, TestDamageRecordEntity._repeated_attr_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DB3F RID: 121663 RVA: 0x0045B6D8 File Offset: 0x004598D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			num += this.buffIds_.CalculateSize(TestDamageRecordEntity._repeated_buffIds_codec);
			num += this.attr_.CalculateSize(TestDamageRecordEntity._repeated_attr_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DB40 RID: 121664 RVA: 0x0045B754 File Offset: 0x00459954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TestDamageRecordEntity other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this.buffIds_.Add(other.buffIds_);
			this.attr_.Add(other.attr_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DB41 RID: 121665 RVA: 0x0045B7C6 File Offset: 0x004599C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DB42 RID: 121666 RVA: 0x0045B7D0 File Offset: 0x004599D0
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
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.buffIds_.AddEntriesFrom(ref input, TestDamageRecordEntity._repeated_buffIds_codec);
						continue;
					}
					if (num == 34U)
					{
						this.attr_.AddEntriesFrom(ref input, TestDamageRecordEntity._repeated_attr_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C911 RID: 51473
		private static readonly MessageParser<TestDamageRecordEntity> _parser = new MessageParser<TestDamageRecordEntity>(() => new TestDamageRecordEntity());

		// Token: 0x0400C912 RID: 51474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C913 RID: 51475
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400C914 RID: 51476
		private long entityId_;

		// Token: 0x0400C915 RID: 51477
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x0400C916 RID: 51478
		private int configId_;

		// Token: 0x0400C917 RID: 51479
		public const int BuffIdsFieldNumber = 3;

		// Token: 0x0400C918 RID: 51480
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(26U);

		// Token: 0x0400C919 RID: 51481
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();

		// Token: 0x0400C91A RID: 51482
		public const int AttrFieldNumber = 4;

		// Token: 0x0400C91B RID: 51483
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attr_codec = FieldCodec.ForMessage<GameplayAttributeData>(34U, GameplayAttributeData.Parser);

		// Token: 0x0400C91C RID: 51484
		private readonly RepeatedField<GameplayAttributeData> attr_ = new RepeatedField<GameplayAttributeData>();
	}
}
