using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C7 RID: 4807
	public sealed class SolarSchoolShopGoodsBuyDataPb : IMessage<SolarSchoolShopGoodsBuyDataPb>, IMessage, IEquatable<SolarSchoolShopGoodsBuyDataPb>, IDeepCloneable<SolarSchoolShopGoodsBuyDataPb>, IBufferMessage
	{
		// Token: 0x06019A85 RID: 105093 RVA: 0x003BE54D File Offset: 0x003BC74D
		[NullableContext(1)]
		public static SolarSchoolShopGoodsBuyDataPb Create()
		{
			return new SolarSchoolShopGoodsBuyDataPb();
		}

		// Token: 0x170056DF RID: 22239
		// (get) Token: 0x06019A86 RID: 105094 RVA: 0x003BE554 File Offset: 0x003BC754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolShopGoodsBuyDataPb> Parser
		{
			get
			{
				return SolarSchoolShopGoodsBuyDataPb._parser;
			}
		}

		// Token: 0x170056E0 RID: 22240
		// (get) Token: 0x06019A87 RID: 105095 RVA: 0x003BE55B File Offset: 0x003BC75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056E1 RID: 22241
		// (get) Token: 0x06019A88 RID: 105096 RVA: 0x003BE55E File Offset: 0x003BC75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolShopGoodsBuyDataPb.Descriptor;
			}
		}

		// Token: 0x06019A89 RID: 105097 RVA: 0x003BE565 File Offset: 0x003BC765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopGoodsBuyDataPb()
		{
		}

		// Token: 0x06019A8A RID: 105098 RVA: 0x003BE56D File Offset: 0x003BC76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopGoodsBuyDataPb(SolarSchoolShopGoodsBuyDataPb other) : this()
		{
			this.goodsId_ = other.goodsId_;
			this.boughtCount_ = other.boughtCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019A8B RID: 105099 RVA: 0x003BE59E File Offset: 0x003BC79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolShopGoodsBuyDataPb Clone()
		{
			return new SolarSchoolShopGoodsBuyDataPb(this);
		}

		// Token: 0x170056E2 RID: 22242
		// (get) Token: 0x06019A8C RID: 105100 RVA: 0x003BE5A6 File Offset: 0x003BC7A6
		// (set) Token: 0x06019A8D RID: 105101 RVA: 0x003BE5AE File Offset: 0x003BC7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoodsId
		{
			get
			{
				return this.goodsId_;
			}
			set
			{
				this.goodsId_ = value;
			}
		}

		// Token: 0x170056E3 RID: 22243
		// (get) Token: 0x06019A8E RID: 105102 RVA: 0x003BE5B7 File Offset: 0x003BC7B7
		// (set) Token: 0x06019A8F RID: 105103 RVA: 0x003BE5BF File Offset: 0x003BC7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoughtCount
		{
			get
			{
				return this.boughtCount_;
			}
			set
			{
				this.boughtCount_ = value;
			}
		}

		// Token: 0x06019A90 RID: 105104 RVA: 0x003BE5C8 File Offset: 0x003BC7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolShopGoodsBuyDataPb);
		}

		// Token: 0x06019A91 RID: 105105 RVA: 0x003BE5D6 File Offset: 0x003BC7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolShopGoodsBuyDataPb other)
		{
			return other != null && (other == this || (this.GoodsId == other.GoodsId && this.BoughtCount == other.BoughtCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019A92 RID: 105106 RVA: 0x003BE614 File Offset: 0x003BC814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GoodsId != 0)
			{
				num ^= this.GoodsId.GetHashCode();
			}
			if (this.BoughtCount != 0)
			{
				num ^= this.BoughtCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019A93 RID: 105107 RVA: 0x003BE66C File Offset: 0x003BC86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019A94 RID: 105108 RVA: 0x003BE679 File Offset: 0x003BC879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019A95 RID: 105109 RVA: 0x003BE684 File Offset: 0x003BC884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GoodsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GoodsId);
			}
			if (this.BoughtCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BoughtCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019A96 RID: 105110 RVA: 0x003BE6DC File Offset: 0x003BC8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GoodsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoodsId);
			}
			if (this.BoughtCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoughtCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019A97 RID: 105111 RVA: 0x003BE734 File Offset: 0x003BC934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolShopGoodsBuyDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GoodsId != 0)
			{
				this.GoodsId = other.GoodsId;
			}
			if (other.BoughtCount != 0)
			{
				this.BoughtCount = other.BoughtCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019A98 RID: 105112 RVA: 0x003BE784 File Offset: 0x003BC984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019A99 RID: 105113 RVA: 0x003BE790 File Offset: 0x003BC990
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BoughtCount = input.ReadInt32();
					}
				}
				else
				{
					this.GoodsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009791 RID: 38801
		private static readonly MessageParser<SolarSchoolShopGoodsBuyDataPb> _parser = new MessageParser<SolarSchoolShopGoodsBuyDataPb>(() => new SolarSchoolShopGoodsBuyDataPb());

		// Token: 0x04009792 RID: 38802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009793 RID: 38803
		public const int GoodsIdFieldNumber = 1;

		// Token: 0x04009794 RID: 38804
		private int goodsId_;

		// Token: 0x04009795 RID: 38805
		public const int BoughtCountFieldNumber = 2;

		// Token: 0x04009796 RID: 38806
		private int boughtCount_;
	}
}
