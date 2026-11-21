using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200171C RID: 5916
	[NetMessage(EMessageId.TestDamageRecordNotify)]
	public sealed class TestDamageRecordNotify : IMessage<TestDamageRecordNotify>, IMessage, IEquatable<TestDamageRecordNotify>, IDeepCloneable<TestDamageRecordNotify>, IBufferMessage
	{
		// Token: 0x0601DB44 RID: 121668 RVA: 0x0045B89F File Offset: 0x00459A9F
		[NullableContext(1)]
		public static TestDamageRecordNotify Create()
		{
			return new TestDamageRecordNotify();
		}

		// Token: 0x17006524 RID: 25892
		// (get) Token: 0x0601DB45 RID: 121669 RVA: 0x0045B8A6 File Offset: 0x00459AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006525 RID: 25893
		// (get) Token: 0x0601DB46 RID: 121670 RVA: 0x0045B8A9 File Offset: 0x00459AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestDamageRecordNotify.Descriptor;
			}
		}

		// Token: 0x0601DB47 RID: 121671 RVA: 0x0045B8B0 File Offset: 0x00459AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordNotify()
		{
		}

		// Token: 0x0601DB48 RID: 121672 RVA: 0x0045B8C3 File Offset: 0x00459AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordNotify(TestDamageRecordNotify other) : this()
		{
			this.timestampMs_ = other.timestampMs_;
			this.entities_ = other.entities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DB49 RID: 121673 RVA: 0x0045B8F9 File Offset: 0x00459AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestDamageRecordNotify Clone()
		{
			return new TestDamageRecordNotify(this);
		}

		// Token: 0x17006526 RID: 25894
		// (get) Token: 0x0601DB4A RID: 121674 RVA: 0x0045B901 File Offset: 0x00459B01
		// (set) Token: 0x0601DB4B RID: 121675 RVA: 0x0045B909 File Offset: 0x00459B09
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

		// Token: 0x17006527 RID: 25895
		// (get) Token: 0x0601DB4C RID: 121676 RVA: 0x0045B912 File Offset: 0x00459B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TestDamageRecordEntity> Entities
		{
			get
			{
				return this.entities_;
			}
		}

		// Token: 0x0601DB4D RID: 121677 RVA: 0x0045B91A File Offset: 0x00459B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestDamageRecordNotify);
		}

		// Token: 0x0601DB4E RID: 121678 RVA: 0x0045B928 File Offset: 0x00459B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestDamageRecordNotify other)
		{
			return other != null && (other == this || (this.TimestampMs == other.TimestampMs && this.entities_.Equals(other.entities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DB4F RID: 121679 RVA: 0x0045B978 File Offset: 0x00459B78
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

		// Token: 0x0601DB50 RID: 121680 RVA: 0x0045B9C5 File Offset: 0x00459BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DB51 RID: 121681 RVA: 0x0045B9D2 File Offset: 0x00459BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DB52 RID: 121682 RVA: 0x0045B9DC File Offset: 0x00459BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimestampMs != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TimestampMs);
			}
			this.entities_.WriteTo(ref output, TestDamageRecordNotify._repeated_entities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DB53 RID: 121683 RVA: 0x0045BA2C File Offset: 0x00459C2C
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

		// Token: 0x0601DB54 RID: 121684 RVA: 0x0045BA80 File Offset: 0x00459C80
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

		// Token: 0x0601DB55 RID: 121685 RVA: 0x0045BACD File Offset: 0x00459CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DB56 RID: 121686 RVA: 0x0045BAD8 File Offset: 0x00459CD8
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
					if (num != 34U)
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

		// Token: 0x0400C91D RID: 51485
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C91E RID: 51486
		public const int TimestampMsFieldNumber = 1;

		// Token: 0x0400C91F RID: 51487
		private long timestampMs_;

		// Token: 0x0400C920 RID: 51488
		public const int EntitiesFieldNumber = 4;

		// Token: 0x0400C921 RID: 51489
		private static readonly FieldCodec<TestDamageRecordEntity> _repeated_entities_codec = FieldCodec.ForMessage<TestDamageRecordEntity>(34U, TestDamageRecordEntity.Parser);

		// Token: 0x0400C922 RID: 51490
		private readonly RepeatedField<TestDamageRecordEntity> entities_ = new RepeatedField<TestDamageRecordEntity>();
	}
}
