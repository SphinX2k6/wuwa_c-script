using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x020016A0 RID: 5792
	[NetMessage(EMessageId.TestDamageRecordNotify)]
	public sealed class TestDamageRecordNotify : IMessage<TestDamageRecordNotify>, IMessage, IEquatable<TestDamageRecordNotify>, IDeepCloneable<TestDamageRecordNotify>, IBufferMessage
	{
		// Token: 0x0601D075 RID: 118901 RVA: 0x0043FB5F File Offset: 0x0043DD5F
		[NullableContext(1)]
		public static TestDamageRecordNotify Create()
		{
			return new TestDamageRecordNotify();
		}

		// Token: 0x1700627F RID: 25215
		// (get) Token: 0x0601D076 RID: 118902 RVA: 0x0043FB66 File Offset: 0x0043DD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006280 RID: 25216
		// (get) Token: 0x0601D077 RID: 118903 RVA: 0x0043FB69 File Offset: 0x0043DD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestDamageRecordNotify.Descriptor;
			}
		}

		// Token: 0x0601D078 RID: 118904 RVA: 0x0043FB70 File Offset: 0x0043DD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordNotify()
		{
		}

		// Token: 0x0601D079 RID: 118905 RVA: 0x0043FB83 File Offset: 0x0043DD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordNotify(TestDamageRecordNotify other) : this()
		{
			this.timestampMs_ = other.timestampMs_;
			this.entities_ = other.entities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D07A RID: 118906 RVA: 0x0043FBB9 File Offset: 0x0043DDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordNotify Clone()
		{
			return new TestDamageRecordNotify(this);
		}

		// Token: 0x17006281 RID: 25217
		// (get) Token: 0x0601D07B RID: 118907 RVA: 0x0043FBC1 File Offset: 0x0043DDC1
		// (set) Token: 0x0601D07C RID: 118908 RVA: 0x0043FBC9 File Offset: 0x0043DDC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TimestampMs
		{
			get
			{
				return this.timestampMs_;
			}
			set
			{
				this.timestampMs_ = value;
			}
		}

		// Token: 0x17006282 RID: 25218
		// (get) Token: 0x0601D07D RID: 118909 RVA: 0x0043FBD2 File Offset: 0x0043DDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TestDamageRecordEntity> Entities
		{
			get
			{
				return this.entities_;
			}
		}

		// Token: 0x0601D07E RID: 118910 RVA: 0x0043FBDA File Offset: 0x0043DDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestDamageRecordNotify);
		}

		// Token: 0x0601D07F RID: 118911 RVA: 0x0043FBE8 File Offset: 0x0043DDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestDamageRecordNotify other)
		{
			return other != null && (other == this || (this.TimestampMs == other.TimestampMs && this.entities_.Equals(other.entities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D080 RID: 118912 RVA: 0x0043FC38 File Offset: 0x0043DE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TimestampMs != 0L)
			{
				num ^= this.TimestampMs.GetHashCode();
			}
			num ^= this.entities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D081 RID: 118913 RVA: 0x0043FC85 File Offset: 0x0043DE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D082 RID: 118914 RVA: 0x0043FC92 File Offset: 0x0043DE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D083 RID: 118915 RVA: 0x0043FC9C File Offset: 0x0043DE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimestampMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TimestampMs);
			}
			this.entities_.WriteTo(ref output, TestDamageRecordNotify._repeated_entities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D084 RID: 118916 RVA: 0x0043FCEC File Offset: 0x0043DEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TimestampMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TimestampMs);
			}
			num += this.entities_.CalculateSize(TestDamageRecordNotify._repeated_entities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D085 RID: 118917 RVA: 0x0043FD40 File Offset: 0x0043DF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TestDamageRecordNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TimestampMs != 0L)
			{
				this.TimestampMs = other.TimestampMs;
			}
			this.entities_.Add(other.entities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D086 RID: 118918 RVA: 0x0043FD8D File Offset: 0x0043DF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D087 RID: 118919 RVA: 0x0043FD98 File Offset: 0x0043DF98
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
				if (num != 16U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entities_.AddEntriesFrom(ref input, TestDamageRecordNotify._repeated_entities_codec);
					}
				}
				else
				{
					this.TimestampMs = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C3EE RID: 50158
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3EF RID: 50159
		public const int TimestampMsFieldNumber = 2;

		// Token: 0x0400C3F0 RID: 50160
		private long timestampMs_;

		// Token: 0x0400C3F1 RID: 50161
		public const int EntitiesFieldNumber = 7;

		// Token: 0x0400C3F2 RID: 50162
		private static readonly FieldCodec<TestDamageRecordEntity> _repeated_entities_codec = FieldCodec.ForMessage<TestDamageRecordEntity>(58U, TestDamageRecordEntity.Parser);

		// Token: 0x0400C3F3 RID: 50163
		private readonly RepeatedField<TestDamageRecordEntity> entities_ = new RepeatedField<TestDamageRecordEntity>();
	}
}
