using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200169F RID: 5791
	public sealed class TestDamageRecordEntity : IMessage<TestDamageRecordEntity>, IMessage, IEquatable<TestDamageRecordEntity>, IDeepCloneable<TestDamageRecordEntity>, IBufferMessage
	{
		// Token: 0x0601D05D RID: 118877 RVA: 0x0043F73E File Offset: 0x0043D93E
		[NullableContext(1)]
		public static TestDamageRecordEntity Create()
		{
			return new TestDamageRecordEntity();
		}

		// Token: 0x17006278 RID: 25208
		// (get) Token: 0x0601D05E RID: 118878 RVA: 0x0043F745 File Offset: 0x0043D945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TestDamageRecordEntity> Parser
		{
			get
			{
				return TestDamageRecordEntity._parser;
			}
		}

		// Token: 0x17006279 RID: 25209
		// (get) Token: 0x0601D05F RID: 118879 RVA: 0x0043F74C File Offset: 0x0043D94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700627A RID: 25210
		// (get) Token: 0x0601D060 RID: 118880 RVA: 0x0043F74F File Offset: 0x0043D94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestDamageRecordEntity.Descriptor;
			}
		}

		// Token: 0x0601D061 RID: 118881 RVA: 0x0043F756 File Offset: 0x0043D956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordEntity()
		{
		}

		// Token: 0x0601D062 RID: 118882 RVA: 0x0043F774 File Offset: 0x0043D974
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

		// Token: 0x0601D063 RID: 118883 RVA: 0x0043F7D2 File Offset: 0x0043D9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordEntity Clone()
		{
			return new TestDamageRecordEntity(this);
		}

		// Token: 0x1700627B RID: 25211
		// (get) Token: 0x0601D064 RID: 118884 RVA: 0x0043F7DA File Offset: 0x0043D9DA
		// (set) Token: 0x0601D065 RID: 118885 RVA: 0x0043F7E2 File Offset: 0x0043D9E2
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

		// Token: 0x1700627C RID: 25212
		// (get) Token: 0x0601D066 RID: 118886 RVA: 0x0043F7EB File Offset: 0x0043D9EB
		// (set) Token: 0x0601D067 RID: 118887 RVA: 0x0043F7F3 File Offset: 0x0043D9F3
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

		// Token: 0x1700627D RID: 25213
		// (get) Token: 0x0601D068 RID: 118888 RVA: 0x0043F7FC File Offset: 0x0043D9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x1700627E RID: 25214
		// (get) Token: 0x0601D069 RID: 118889 RVA: 0x0043F804 File Offset: 0x0043DA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attr
		{
			get
			{
				return this.attr_;
			}
		}

		// Token: 0x0601D06A RID: 118890 RVA: 0x0043F80C File Offset: 0x0043DA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestDamageRecordEntity);
		}

		// Token: 0x0601D06B RID: 118891 RVA: 0x0043F81C File Offset: 0x0043DA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestDamageRecordEntity other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ConfigId == other.ConfigId && this.buffIds_.Equals(other.buffIds_) && this.attr_.Equals(other.attr_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D06C RID: 118892 RVA: 0x0043F890 File Offset: 0x0043DA90
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

		// Token: 0x0601D06D RID: 118893 RVA: 0x0043F904 File Offset: 0x0043DB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D06E RID: 118894 RVA: 0x0043F911 File Offset: 0x0043DB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D06F RID: 118895 RVA: 0x0043F91C File Offset: 0x0043DB1C
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

		// Token: 0x0601D070 RID: 118896 RVA: 0x0043F998 File Offset: 0x0043DB98
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

		// Token: 0x0601D071 RID: 118897 RVA: 0x0043FA14 File Offset: 0x0043DC14
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

		// Token: 0x0601D072 RID: 118898 RVA: 0x0043FA86 File Offset: 0x0043DC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D073 RID: 118899 RVA: 0x0043FA90 File Offset: 0x0043DC90
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

		// Token: 0x0400C3E2 RID: 50146
		private static readonly MessageParser<TestDamageRecordEntity> _parser = new MessageParser<TestDamageRecordEntity>(() => new TestDamageRecordEntity());

		// Token: 0x0400C3E3 RID: 50147
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3E4 RID: 50148
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400C3E5 RID: 50149
		private long entityId_;

		// Token: 0x0400C3E6 RID: 50150
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x0400C3E7 RID: 50151
		private int configId_;

		// Token: 0x0400C3E8 RID: 50152
		public const int BuffIdsFieldNumber = 3;

		// Token: 0x0400C3E9 RID: 50153
		private static readonly FieldCodec<long> _repeated_buffIds_codec = FieldCodec.ForInt64(26U);

		// Token: 0x0400C3EA RID: 50154
		private readonly RepeatedField<long> buffIds_ = new RepeatedField<long>();

		// Token: 0x0400C3EB RID: 50155
		public const int AttrFieldNumber = 4;

		// Token: 0x0400C3EC RID: 50156
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attr_codec = FieldCodec.ForMessage<GameplayAttributeData>(34U, GameplayAttributeData.Parser);

		// Token: 0x0400C3ED RID: 50157
		private readonly RepeatedField<GameplayAttributeData> attr_ = new RepeatedField<GameplayAttributeData>();
	}
}
