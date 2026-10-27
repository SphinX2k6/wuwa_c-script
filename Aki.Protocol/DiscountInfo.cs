using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E1 RID: 993
	public sealed class DiscountInfo : IMessage<DiscountInfo>, IMessage, IEquatable<DiscountInfo>, IDeepCloneable<DiscountInfo>, IBufferMessage
	{
		// Token: 0x0600608D RID: 24717 RVA: 0x000E9681 File Offset: 0x000E7881
		[NullableContext(1)]
		public static DiscountInfo Create()
		{
			return new DiscountInfo();
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x0600608E RID: 24718 RVA: 0x000E9688 File Offset: 0x000E7888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600608F RID: 24719 RVA: 0x000E968B File Offset: 0x000E788B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscountInfo.Descriptor;
			}
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x000E9692 File Offset: 0x000E7892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscountInfo()
		{
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x000E96A5 File Offset: 0x000E78A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscountInfo(DiscountInfo other) : this()
		{
			this.buffPrice_ = other.buffPrice_.Clone();
			this.discounted_ = other.discounted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x000E96DB File Offset: 0x000E78DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscountInfo Clone()
		{
			return new DiscountInfo(this);
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06006093 RID: 24723 RVA: 0x000E96E3 File Offset: 0x000E78E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BuffPrice
		{
			get
			{
				return this.buffPrice_;
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06006094 RID: 24724 RVA: 0x000E96EB File Offset: 0x000E78EB
		// (set) Token: 0x06006095 RID: 24725 RVA: 0x000E96F3 File Offset: 0x000E78F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Discounted
		{
			get
			{
				return this.discounted_;
			}
			set
			{
				this.discounted_ = value;
			}
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x000E96FC File Offset: 0x000E78FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscountInfo);
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x000E970C File Offset: 0x000E790C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscountInfo other)
		{
			return other != null && (other == this || (this.BuffPrice.Equals(other.BuffPrice) && this.Discounted == other.Discounted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x000E975C File Offset: 0x000E795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.BuffPrice.GetHashCode();
			if (this.Discounted != 0)
			{
				num ^= this.Discounted.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x000E97A9 File Offset: 0x000E79A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x000E97B6 File Offset: 0x000E79B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x000E97C0 File Offset: 0x000E79C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffPrice_.WriteTo(ref output, DiscountInfo._map_buffPrice_codec);
			if (this.Discounted != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Discounted);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x000E9810 File Offset: 0x000E7A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffPrice_.CalculateSize(DiscountInfo._map_buffPrice_codec);
			if (this.Discounted != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Discounted);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x000E9864 File Offset: 0x000E7A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DiscountInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.buffPrice_.MergeFrom(other.buffPrice_);
			if (other.Discounted != 0)
			{
				this.Discounted = other.Discounted;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x000E98B1 File Offset: 0x000E7AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x000E98BC File Offset: 0x000E7ABC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Discounted = input.ReadInt32();
					}
				}
				else
				{
					this.buffPrice_.AddEntriesFrom(ref input, DiscountInfo._map_buffPrice_codec);
				}
			}
		}

		// Token: 0x04003767 RID: 14183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003768 RID: 14184
		public const int BuffPriceFieldNumber = 1;

		// Token: 0x04003769 RID: 14185
		private static readonly MapField<int, int>.Codec _map_buffPrice_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x0400376A RID: 14186
		private readonly MapField<int, int> buffPrice_ = new MapField<int, int>();

		// Token: 0x0400376B RID: 14187
		public const int DiscountedFieldNumber = 2;

		// Token: 0x0400376C RID: 14188
		private int discounted_;
	}
}
