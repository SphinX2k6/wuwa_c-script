using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CA RID: 4810
	public sealed class SolarSchoolSummaryDataPb : IMessage<SolarSchoolSummaryDataPb>, IMessage, IEquatable<SolarSchoolSummaryDataPb>, IDeepCloneable<SolarSchoolSummaryDataPb>, IBufferMessage
	{
		// Token: 0x06019AD0 RID: 105168 RVA: 0x003BF0E6 File Offset: 0x003BD2E6
		[NullableContext(1)]
		public static SolarSchoolSummaryDataPb Create()
		{
			return new SolarSchoolSummaryDataPb();
		}

		// Token: 0x170056F3 RID: 22259
		// (get) Token: 0x06019AD1 RID: 105169 RVA: 0x003BF0ED File Offset: 0x003BD2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056F4 RID: 22260
		// (get) Token: 0x06019AD2 RID: 105170 RVA: 0x003BF0F0 File Offset: 0x003BD2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolSummaryDataPb.Descriptor;
			}
		}

		// Token: 0x06019AD3 RID: 105171 RVA: 0x003BF0F7 File Offset: 0x003BD2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryDataPb()
		{
		}

		// Token: 0x06019AD4 RID: 105172 RVA: 0x003BF10C File Offset: 0x003BD30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryDataPb(SolarSchoolSummaryDataPb other) : this()
		{
			this.attr_ = other.attr_.Clone();
			this.completedNoticeCount_ = other.completedNoticeCount_;
			this.manualPurchaseCount_ = other.manualPurchaseCount_;
			this.gainedMoney_ = other.gainedMoney_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019AD5 RID: 105173 RVA: 0x003BF165 File Offset: 0x003BD365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolSummaryDataPb Clone()
		{
			return new SolarSchoolSummaryDataPb(this);
		}

		// Token: 0x170056F5 RID: 22261
		// (get) Token: 0x06019AD6 RID: 105174 RVA: 0x003BF16D File Offset: 0x003BD36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolAttrPb> Attr
		{
			get
			{
				return this.attr_;
			}
		}

		// Token: 0x170056F6 RID: 22262
		// (get) Token: 0x06019AD7 RID: 105175 RVA: 0x003BF175 File Offset: 0x003BD375
		// (set) Token: 0x06019AD8 RID: 105176 RVA: 0x003BF17D File Offset: 0x003BD37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CompletedNoticeCount
		{
			get
			{
				return this.completedNoticeCount_;
			}
			set
			{
				this.completedNoticeCount_ = value;
			}
		}

		// Token: 0x170056F7 RID: 22263
		// (get) Token: 0x06019AD9 RID: 105177 RVA: 0x003BF186 File Offset: 0x003BD386
		// (set) Token: 0x06019ADA RID: 105178 RVA: 0x003BF18E File Offset: 0x003BD38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ManualPurchaseCount
		{
			get
			{
				return this.manualPurchaseCount_;
			}
			set
			{
				this.manualPurchaseCount_ = value;
			}
		}

		// Token: 0x170056F8 RID: 22264
		// (get) Token: 0x06019ADB RID: 105179 RVA: 0x003BF197 File Offset: 0x003BD397
		// (set) Token: 0x06019ADC RID: 105180 RVA: 0x003BF19F File Offset: 0x003BD39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GainedMoney
		{
			get
			{
				return this.gainedMoney_;
			}
			set
			{
				this.gainedMoney_ = value;
			}
		}

		// Token: 0x06019ADD RID: 105181 RVA: 0x003BF1A8 File Offset: 0x003BD3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolSummaryDataPb);
		}

		// Token: 0x06019ADE RID: 105182 RVA: 0x003BF1B8 File Offset: 0x003BD3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolSummaryDataPb other)
		{
			return other != null && (other == this || (this.attr_.Equals(other.attr_) && this.CompletedNoticeCount == other.CompletedNoticeCount && this.ManualPurchaseCount == other.ManualPurchaseCount && this.GainedMoney == other.GainedMoney && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019ADF RID: 105183 RVA: 0x003BF228 File Offset: 0x003BD428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attr_.GetHashCode();
			if (this.CompletedNoticeCount != 0)
			{
				num ^= this.CompletedNoticeCount.GetHashCode();
			}
			if (this.ManualPurchaseCount != 0)
			{
				num ^= this.ManualPurchaseCount.GetHashCode();
			}
			if (this.GainedMoney != 0)
			{
				num ^= this.GainedMoney.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019AE0 RID: 105184 RVA: 0x003BF2A7 File Offset: 0x003BD4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019AE1 RID: 105185 RVA: 0x003BF2B4 File Offset: 0x003BD4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019AE2 RID: 105186 RVA: 0x003BF2C0 File Offset: 0x003BD4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attr_.WriteTo(ref output, SolarSchoolSummaryDataPb._repeated_attr_codec);
			if (this.CompletedNoticeCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CompletedNoticeCount);
			}
			if (this.ManualPurchaseCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ManualPurchaseCount);
			}
			if (this.GainedMoney != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GainedMoney);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019AE3 RID: 105187 RVA: 0x003BF348 File Offset: 0x003BD548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attr_.CalculateSize(SolarSchoolSummaryDataPb._repeated_attr_codec);
			if (this.CompletedNoticeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompletedNoticeCount);
			}
			if (this.ManualPurchaseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ManualPurchaseCount);
			}
			if (this.GainedMoney != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GainedMoney);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019AE4 RID: 105188 RVA: 0x003BF3CC File Offset: 0x003BD5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolSummaryDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.attr_.Add(other.attr_);
			if (other.CompletedNoticeCount != 0)
			{
				this.CompletedNoticeCount = other.CompletedNoticeCount;
			}
			if (other.ManualPurchaseCount != 0)
			{
				this.ManualPurchaseCount = other.ManualPurchaseCount;
			}
			if (other.GainedMoney != 0)
			{
				this.GainedMoney = other.GainedMoney;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019AE5 RID: 105189 RVA: 0x003BF441 File Offset: 0x003BD641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019AE6 RID: 105190 RVA: 0x003BF44C File Offset: 0x003BD64C
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
					if (num == 10U)
					{
						this.attr_.AddEntriesFrom(ref input, SolarSchoolSummaryDataPb._repeated_attr_codec);
						continue;
					}
					if (num == 16U)
					{
						this.CompletedNoticeCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ManualPurchaseCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.GainedMoney = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040097AE RID: 38830
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097AF RID: 38831
		public const int AttrFieldNumber = 1;

		// Token: 0x040097B0 RID: 38832
		private static readonly FieldCodec<SolarSchoolAttrPb> _repeated_attr_codec = FieldCodec.ForMessage<SolarSchoolAttrPb>(10U, SolarSchoolAttrPb.Parser);

		// Token: 0x040097B1 RID: 38833
		private readonly RepeatedField<SolarSchoolAttrPb> attr_ = new RepeatedField<SolarSchoolAttrPb>();

		// Token: 0x040097B2 RID: 38834
		public const int CompletedNoticeCountFieldNumber = 2;

		// Token: 0x040097B3 RID: 38835
		private int completedNoticeCount_;

		// Token: 0x040097B4 RID: 38836
		public const int ManualPurchaseCountFieldNumber = 3;

		// Token: 0x040097B5 RID: 38837
		private int manualPurchaseCount_;

		// Token: 0x040097B6 RID: 38838
		public const int GainedMoneyFieldNumber = 4;

		// Token: 0x040097B7 RID: 38839
		private int gainedMoney_;
	}
}
