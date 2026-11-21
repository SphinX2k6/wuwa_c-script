using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CA RID: 970
	public sealed class DiscountInfo : IMessage<DiscountInfo>, IMessage, IEquatable<DiscountInfo>, IDeepCloneable<DiscountInfo>, IBufferMessage
	{
		// Token: 0x06005EFD RID: 24317 RVA: 0x000E6501 File Offset: 0x000E4701
		[NullableContext(1)]
		public static DiscountInfo Create()
		{
			return new DiscountInfo();
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06005EFE RID: 24318 RVA: 0x000E6508 File Offset: 0x000E4708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06005EFF RID: 24319 RVA: 0x000E650B File Offset: 0x000E470B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiscountInfo.Descriptor;
			}
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x000E6512 File Offset: 0x000E4712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscountInfo()
		{
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x000E6525 File Offset: 0x000E4725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscountInfo(DiscountInfo other) : this()
		{
			this.buffPrice_ = other.buffPrice_.Clone();
			this.discounted_ = other.discounted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x000E655B File Offset: 0x000E475B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscountInfo Clone()
		{
			return new DiscountInfo(this);
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06005F03 RID: 24323 RVA: 0x000E6563 File Offset: 0x000E4763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BuffPrice
		{
			get
			{
				return this.buffPrice_;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06005F04 RID: 24324 RVA: 0x000E656B File Offset: 0x000E476B
		// (set) Token: 0x06005F05 RID: 24325 RVA: 0x000E6573 File Offset: 0x000E4773
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

		// Token: 0x06005F06 RID: 24326 RVA: 0x000E657C File Offset: 0x000E477C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiscountInfo);
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x000E658C File Offset: 0x000E478C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DiscountInfo other)
		{
			return other != null && (other == this || (this.BuffPrice.Equals(other.BuffPrice) && this.Discounted == other.Discounted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x000E65DC File Offset: 0x000E47DC
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

		// Token: 0x06005F09 RID: 24329 RVA: 0x000E6629 File Offset: 0x000E4829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x000E6636 File Offset: 0x000E4836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x000E6640 File Offset: 0x000E4840
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

		// Token: 0x06005F0C RID: 24332 RVA: 0x000E6690 File Offset: 0x000E4890
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

		// Token: 0x06005F0D RID: 24333 RVA: 0x000E66E4 File Offset: 0x000E48E4
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

		// Token: 0x06005F0E RID: 24334 RVA: 0x000E6731 File Offset: 0x000E4931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x000E673C File Offset: 0x000E493C
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

		// Token: 0x04003754 RID: 14164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003755 RID: 14165
		public const int BuffPriceFieldNumber = 1;

		// Token: 0x04003756 RID: 14166
		private static readonly MapField<int, int>.Codec _map_buffPrice_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04003757 RID: 14167
		private readonly MapField<int, int> buffPrice_ = new MapField<int, int>();

		// Token: 0x04003758 RID: 14168
		public const int DiscountedFieldNumber = 2;

		// Token: 0x04003759 RID: 14169
		private int discounted_;
	}
}
