using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200068F RID: 1679
	public sealed class GachaDiscountInfo : IMessage<GachaDiscountInfo>, IMessage, IEquatable<GachaDiscountInfo>, IDeepCloneable<GachaDiscountInfo>, IBufferMessage
	{
		// Token: 0x060099A7 RID: 39335 RVA: 0x0017215B File Offset: 0x0017035B
		[NullableContext(1)]
		public static GachaDiscountInfo Create()
		{
			return new GachaDiscountInfo();
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x060099A8 RID: 39336 RVA: 0x00172162 File Offset: 0x00170362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaDiscountInfo> Parser
		{
			get
			{
				return GachaDiscountInfo._parser;
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x060099A9 RID: 39337 RVA: 0x00172169 File Offset: 0x00170369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x060099AA RID: 39338 RVA: 0x0017216C File Offset: 0x0017036C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaDiscountInfo.Descriptor;
			}
		}

		// Token: 0x060099AB RID: 39339 RVA: 0x00172173 File Offset: 0x00170373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountInfo()
		{
		}

		// Token: 0x060099AC RID: 39340 RVA: 0x0017217C File Offset: 0x0017037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountInfo(GachaDiscountInfo other) : this()
		{
			this.times_ = other.times_;
			this.limitTimes_ = other.limitTimes_;
			this.discountConsume_ = other.discountConsume_;
			this.usedTimes_ = other.usedTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x001721D0 File Offset: 0x001703D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountInfo Clone()
		{
			return new GachaDiscountInfo(this);
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x060099AE RID: 39342 RVA: 0x001721D8 File Offset: 0x001703D8
		// (set) Token: 0x060099AF RID: 39343 RVA: 0x001721E0 File Offset: 0x001703E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Times
		{
			get
			{
				return this.times_;
			}
			set
			{
				this.times_ = value;
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x001721E9 File Offset: 0x001703E9
		// (set) Token: 0x060099B1 RID: 39345 RVA: 0x001721F1 File Offset: 0x001703F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitTimes
		{
			get
			{
				return this.limitTimes_;
			}
			set
			{
				this.limitTimes_ = value;
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x060099B2 RID: 39346 RVA: 0x001721FA File Offset: 0x001703FA
		// (set) Token: 0x060099B3 RID: 39347 RVA: 0x00172202 File Offset: 0x00170402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiscountConsume
		{
			get
			{
				return this.discountConsume_;
			}
			set
			{
				this.discountConsume_ = value;
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x060099B4 RID: 39348 RVA: 0x0017220B File Offset: 0x0017040B
		// (set) Token: 0x060099B5 RID: 39349 RVA: 0x00172213 File Offset: 0x00170413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UsedTimes
		{
			get
			{
				return this.usedTimes_;
			}
			set
			{
				this.usedTimes_ = value;
			}
		}

		// Token: 0x060099B6 RID: 39350 RVA: 0x0017221C File Offset: 0x0017041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaDiscountInfo);
		}

		// Token: 0x060099B7 RID: 39351 RVA: 0x0017222C File Offset: 0x0017042C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaDiscountInfo other)
		{
			return other != null && (other == this || (this.Times == other.Times && this.LimitTimes == other.LimitTimes && this.DiscountConsume == other.DiscountConsume && this.UsedTimes == other.UsedTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099B8 RID: 39352 RVA: 0x00172298 File Offset: 0x00170498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Times != 0)
			{
				num ^= this.Times.GetHashCode();
			}
			if (this.LimitTimes != 0)
			{
				num ^= this.LimitTimes.GetHashCode();
			}
			if (this.DiscountConsume != 0)
			{
				num ^= this.DiscountConsume.GetHashCode();
			}
			if (this.UsedTimes != 0)
			{
				num ^= this.UsedTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099B9 RID: 39353 RVA: 0x00172322 File Offset: 0x00170522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099BA RID: 39354 RVA: 0x0017232F File Offset: 0x0017052F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099BB RID: 39355 RVA: 0x00172338 File Offset: 0x00170538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Times != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Times);
			}
			if (this.LimitTimes != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LimitTimes);
			}
			if (this.DiscountConsume != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DiscountConsume);
			}
			if (this.UsedTimes != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UsedTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099BC RID: 39356 RVA: 0x001723C8 File Offset: 0x001705C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Times != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Times);
			}
			if (this.LimitTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitTimes);
			}
			if (this.DiscountConsume != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiscountConsume);
			}
			if (this.UsedTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UsedTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099BD RID: 39357 RVA: 0x00172450 File Offset: 0x00170650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaDiscountInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Times != 0)
			{
				this.Times = other.Times;
			}
			if (other.LimitTimes != 0)
			{
				this.LimitTimes = other.LimitTimes;
			}
			if (other.DiscountConsume != 0)
			{
				this.DiscountConsume = other.DiscountConsume;
			}
			if (other.UsedTimes != 0)
			{
				this.UsedTimes = other.UsedTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099BE RID: 39358 RVA: 0x001724C8 File Offset: 0x001706C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099BF RID: 39359 RVA: 0x001724D4 File Offset: 0x001706D4
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
						this.Times = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LimitTimes = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.DiscountConsume = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.UsedTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048A6 RID: 18598
		private static readonly MessageParser<GachaDiscountInfo> _parser = new MessageParser<GachaDiscountInfo>(() => new GachaDiscountInfo());

		// Token: 0x040048A7 RID: 18599
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048A8 RID: 18600
		public const int TimesFieldNumber = 1;

		// Token: 0x040048A9 RID: 18601
		private int times_;

		// Token: 0x040048AA RID: 18602
		public const int LimitTimesFieldNumber = 2;

		// Token: 0x040048AB RID: 18603
		private int limitTimes_;

		// Token: 0x040048AC RID: 18604
		public const int DiscountConsumeFieldNumber = 3;

		// Token: 0x040048AD RID: 18605
		private int discountConsume_;

		// Token: 0x040048AE RID: 18606
		public const int UsedTimesFieldNumber = 4;

		// Token: 0x040048AF RID: 18607
		private int usedTimes_;
	}
}
