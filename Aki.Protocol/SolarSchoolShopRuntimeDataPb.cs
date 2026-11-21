using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C8 RID: 4808
	public sealed class SolarSchoolShopRuntimeDataPb : IMessage<SolarSchoolShopRuntimeDataPb>, IMessage, IEquatable<SolarSchoolShopRuntimeDataPb>, IDeepCloneable<SolarSchoolShopRuntimeDataPb>, IBufferMessage
	{
		// Token: 0x06019A9B RID: 105115 RVA: 0x003BE803 File Offset: 0x003BCA03
		[NullableContext(1)]
		public static SolarSchoolShopRuntimeDataPb Create()
		{
			return new SolarSchoolShopRuntimeDataPb();
		}

		// Token: 0x170056E4 RID: 22244
		// (get) Token: 0x06019A9C RID: 105116 RVA: 0x003BE80A File Offset: 0x003BCA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolShopRuntimeDataPb> Parser
		{
			get
			{
				return SolarSchoolShopRuntimeDataPb._parser;
			}
		}

		// Token: 0x170056E5 RID: 22245
		// (get) Token: 0x06019A9D RID: 105117 RVA: 0x003BE811 File Offset: 0x003BCA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056E6 RID: 22246
		// (get) Token: 0x06019A9E RID: 105118 RVA: 0x003BE814 File Offset: 0x003BCA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolShopRuntimeDataPb.Descriptor;
			}
		}

		// Token: 0x06019A9F RID: 105119 RVA: 0x003BE81B File Offset: 0x003BCA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopRuntimeDataPb()
		{
		}

		// Token: 0x06019AA0 RID: 105120 RVA: 0x003BE830 File Offset: 0x003BCA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopRuntimeDataPb(SolarSchoolShopRuntimeDataPb other) : this()
		{
			this.shopId_ = other.shopId_;
			this.randomSeed_ = other.randomSeed_;
			this.refreshCycleIndex_ = other.refreshCycleIndex_;
			this.goodsBuyData_ = other.goodsBuyData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019AA1 RID: 105121 RVA: 0x003BE889 File Offset: 0x003BCA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopRuntimeDataPb Clone()
		{
			return new SolarSchoolShopRuntimeDataPb(this);
		}

		// Token: 0x170056E7 RID: 22247
		// (get) Token: 0x06019AA2 RID: 105122 RVA: 0x003BE891 File Offset: 0x003BCA91
		// (set) Token: 0x06019AA3 RID: 105123 RVA: 0x003BE899 File Offset: 0x003BCA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x170056E8 RID: 22248
		// (get) Token: 0x06019AA4 RID: 105124 RVA: 0x003BE8A2 File Offset: 0x003BCAA2
		// (set) Token: 0x06019AA5 RID: 105125 RVA: 0x003BE8AA File Offset: 0x003BCAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RandomSeed
		{
			get
			{
				return this.randomSeed_;
			}
			set
			{
				this.randomSeed_ = value;
			}
		}

		// Token: 0x170056E9 RID: 22249
		// (get) Token: 0x06019AA6 RID: 105126 RVA: 0x003BE8B3 File Offset: 0x003BCAB3
		// (set) Token: 0x06019AA7 RID: 105127 RVA: 0x003BE8BB File Offset: 0x003BCABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCycleIndex
		{
			get
			{
				return this.refreshCycleIndex_;
			}
			set
			{
				this.refreshCycleIndex_ = value;
			}
		}

		// Token: 0x170056EA RID: 22250
		// (get) Token: 0x06019AA8 RID: 105128 RVA: 0x003BE8C4 File Offset: 0x003BCAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolShopGoodsBuyDataPb> GoodsBuyData
		{
			get
			{
				return this.goodsBuyData_;
			}
		}

		// Token: 0x06019AA9 RID: 105129 RVA: 0x003BE8CC File Offset: 0x003BCACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolShopRuntimeDataPb);
		}

		// Token: 0x06019AAA RID: 105130 RVA: 0x003BE8DC File Offset: 0x003BCADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolShopRuntimeDataPb other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.RandomSeed == other.RandomSeed && this.RefreshCycleIndex == other.RefreshCycleIndex && this.goodsBuyData_.Equals(other.goodsBuyData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019AAB RID: 105131 RVA: 0x003BE94C File Offset: 0x003BCB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.RandomSeed != 0)
			{
				num ^= this.RandomSeed.GetHashCode();
			}
			if (this.RefreshCycleIndex != 0)
			{
				num ^= this.RefreshCycleIndex.GetHashCode();
			}
			num ^= this.goodsBuyData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019AAC RID: 105132 RVA: 0x003BE9CB File Offset: 0x003BCBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019AAD RID: 105133 RVA: 0x003BE9D8 File Offset: 0x003BCBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019AAE RID: 105134 RVA: 0x003BE9E4 File Offset: 0x003BCBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.RandomSeed != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RandomSeed);
			}
			if (this.RefreshCycleIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RefreshCycleIndex);
			}
			this.goodsBuyData_.WriteTo(ref output, SolarSchoolShopRuntimeDataPb._repeated_goodsBuyData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019AAF RID: 105135 RVA: 0x003BEA6C File Offset: 0x003BCC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.RandomSeed != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RandomSeed);
			}
			if (this.RefreshCycleIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCycleIndex);
			}
			num += this.goodsBuyData_.CalculateSize(SolarSchoolShopRuntimeDataPb._repeated_goodsBuyData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019AB0 RID: 105136 RVA: 0x003BEAF0 File Offset: 0x003BCCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolShopRuntimeDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.RandomSeed != 0)
			{
				this.RandomSeed = other.RandomSeed;
			}
			if (other.RefreshCycleIndex != 0)
			{
				this.RefreshCycleIndex = other.RefreshCycleIndex;
			}
			this.goodsBuyData_.Add(other.goodsBuyData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019AB1 RID: 105137 RVA: 0x003BEB65 File Offset: 0x003BCD65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019AB2 RID: 105138 RVA: 0x003BEB70 File Offset: 0x003BCD70
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
						this.ShopId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RandomSeed = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RefreshCycleIndex = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.goodsBuyData_.AddEntriesFrom(ref input, SolarSchoolShopRuntimeDataPb._repeated_goodsBuyData_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009797 RID: 38807
		private static readonly MessageParser<SolarSchoolShopRuntimeDataPb> _parser = new MessageParser<SolarSchoolShopRuntimeDataPb>(() => new SolarSchoolShopRuntimeDataPb());

		// Token: 0x04009798 RID: 38808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009799 RID: 38809
		public const int ShopIdFieldNumber = 1;

		// Token: 0x0400979A RID: 38810
		private int shopId_;

		// Token: 0x0400979B RID: 38811
		public const int RandomSeedFieldNumber = 2;

		// Token: 0x0400979C RID: 38812
		private int randomSeed_;

		// Token: 0x0400979D RID: 38813
		public const int RefreshCycleIndexFieldNumber = 3;

		// Token: 0x0400979E RID: 38814
		private int refreshCycleIndex_;

		// Token: 0x0400979F RID: 38815
		public const int GoodsBuyDataFieldNumber = 4;

		// Token: 0x040097A0 RID: 38816
		private static readonly FieldCodec<SolarSchoolShopGoodsBuyDataPb> _repeated_goodsBuyData_codec = FieldCodec.ForMessage<SolarSchoolShopGoodsBuyDataPb>(34U, SolarSchoolShopGoodsBuyDataPb.Parser);

		// Token: 0x040097A1 RID: 38817
		private readonly RepeatedField<SolarSchoolShopGoodsBuyDataPb> goodsBuyData_ = new RepeatedField<SolarSchoolShopGoodsBuyDataPb>();
	}
}
