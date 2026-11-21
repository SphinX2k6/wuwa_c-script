using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067B RID: 1659
	public sealed class GachaDiscountInfo : IMessage<GachaDiscountInfo>, IMessage, IEquatable<GachaDiscountInfo>, IDeepCloneable<GachaDiscountInfo>, IBufferMessage
	{
		// Token: 0x06009851 RID: 38993 RVA: 0x0016F727 File Offset: 0x0016D927
		[NullableContext(1)]
		public static GachaDiscountInfo Create()
		{
			return new GachaDiscountInfo();
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06009852 RID: 38994 RVA: 0x0016F72E File Offset: 0x0016D92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaDiscountInfo> Parser
		{
			get
			{
				return GachaDiscountInfo._parser;
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06009853 RID: 38995 RVA: 0x0016F735 File Offset: 0x0016D935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06009854 RID: 38996 RVA: 0x0016F738 File Offset: 0x0016D938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaDiscountInfo.Descriptor;
			}
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x0016F73F File Offset: 0x0016D93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountInfo()
		{
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x0016F748 File Offset: 0x0016D948
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

		// Token: 0x06009857 RID: 38999 RVA: 0x0016F79C File Offset: 0x0016D99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaDiscountInfo Clone()
		{
			return new GachaDiscountInfo(this);
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06009858 RID: 39000 RVA: 0x0016F7A4 File Offset: 0x0016D9A4
		// (set) Token: 0x06009859 RID: 39001 RVA: 0x0016F7AC File Offset: 0x0016D9AC
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

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x0600985A RID: 39002 RVA: 0x0016F7B5 File Offset: 0x0016D9B5
		// (set) Token: 0x0600985B RID: 39003 RVA: 0x0016F7BD File Offset: 0x0016D9BD
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

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x0600985C RID: 39004 RVA: 0x0016F7C6 File Offset: 0x0016D9C6
		// (set) Token: 0x0600985D RID: 39005 RVA: 0x0016F7CE File Offset: 0x0016D9CE
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

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x0600985E RID: 39006 RVA: 0x0016F7D7 File Offset: 0x0016D9D7
		// (set) Token: 0x0600985F RID: 39007 RVA: 0x0016F7DF File Offset: 0x0016D9DF
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

		// Token: 0x06009860 RID: 39008 RVA: 0x0016F7E8 File Offset: 0x0016D9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaDiscountInfo);
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x0016F7F8 File Offset: 0x0016D9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaDiscountInfo other)
		{
			return other != null && (other == this || (this.Times == other.Times && this.LimitTimes == other.LimitTimes && this.DiscountConsume == other.DiscountConsume && this.UsedTimes == other.UsedTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x0016F864 File Offset: 0x0016DA64
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

		// Token: 0x06009863 RID: 39011 RVA: 0x0016F8EE File Offset: 0x0016DAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x0016F8FB File Offset: 0x0016DAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009865 RID: 39013 RVA: 0x0016F904 File Offset: 0x0016DB04
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

		// Token: 0x06009866 RID: 39014 RVA: 0x0016F994 File Offset: 0x0016DB94
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

		// Token: 0x06009867 RID: 39015 RVA: 0x0016FA1C File Offset: 0x0016DC1C
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

		// Token: 0x06009868 RID: 39016 RVA: 0x0016FA94 File Offset: 0x0016DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009869 RID: 39017 RVA: 0x0016FAA0 File Offset: 0x0016DCA0
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

		// Token: 0x0400489F RID: 18591
		private static readonly MessageParser<GachaDiscountInfo> _parser = new MessageParser<GachaDiscountInfo>(() => new GachaDiscountInfo());

		// Token: 0x040048A0 RID: 18592
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048A1 RID: 18593
		public const int TimesFieldNumber = 1;

		// Token: 0x040048A2 RID: 18594
		private int times_;

		// Token: 0x040048A3 RID: 18595
		public const int LimitTimesFieldNumber = 2;

		// Token: 0x040048A4 RID: 18596
		private int limitTimes_;

		// Token: 0x040048A5 RID: 18597
		public const int DiscountConsumeFieldNumber = 3;

		// Token: 0x040048A6 RID: 18598
		private int discountConsume_;

		// Token: 0x040048A7 RID: 18599
		public const int UsedTimesFieldNumber = 4;

		// Token: 0x040048A8 RID: 18600
		private int usedTimes_;
	}
}
