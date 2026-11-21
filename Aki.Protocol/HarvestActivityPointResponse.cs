using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000733 RID: 1843
	[NetMessage(EMessageId.HarvestActivityPointResponse)]
	public sealed class HarvestActivityPointResponse : IMessage<HarvestActivityPointResponse>, IMessage, IEquatable<HarvestActivityPointResponse>, IDeepCloneable<HarvestActivityPointResponse>, IBufferMessage
	{
		// Token: 0x0600A764 RID: 42852 RVA: 0x00193338 File Offset: 0x00191538
		[NullableContext(1)]
		public static HarvestActivityPointResponse Create()
		{
			return new HarvestActivityPointResponse();
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x0600A765 RID: 42853 RVA: 0x0019333F File Offset: 0x0019153F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x0600A766 RID: 42854 RVA: 0x00193342 File Offset: 0x00191542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityPointResponse.Descriptor;
			}
		}

		// Token: 0x0600A767 RID: 42855 RVA: 0x00193349 File Offset: 0x00191549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointResponse()
		{
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x0019335C File Offset: 0x0019155C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointResponse(HarvestActivityPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A769 RID: 42857 RVA: 0x00193392 File Offset: 0x00191592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointResponse Clone()
		{
			return new HarvestActivityPointResponse(this);
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x0600A76A RID: 42858 RVA: 0x0019339A File Offset: 0x0019159A
		// (set) Token: 0x0600A76B RID: 42859 RVA: 0x001933A2 File Offset: 0x001915A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x0600A76C RID: 42860 RVA: 0x001933AB File Offset: 0x001915AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0600A76D RID: 42861 RVA: 0x001933B3 File Offset: 0x001915B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityPointResponse);
		}

		// Token: 0x0600A76E RID: 42862 RVA: 0x001933C4 File Offset: 0x001915C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x00193414 File Offset: 0x00191614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x00193467 File Offset: 0x00191667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x00193474 File Offset: 0x00191674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x00193480 File Offset: 0x00191680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, HarvestActivityPointResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x001934D0 File Offset: 0x001916D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemMap_.CalculateSize(HarvestActivityPointResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x00193524 File Offset: 0x00191724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityPointResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x00193571 File Offset: 0x00191771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x0019357C File Offset: 0x0019177C
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
				if (num != 18U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, HarvestActivityPointResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x04004CE3 RID: 19683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CE4 RID: 19684
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004CE5 RID: 19685
		private ErrorCode errorCode_;

		// Token: 0x04004CE6 RID: 19686
		public const int ItemMapFieldNumber = 2;

		// Token: 0x04004CE7 RID: 19687
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04004CE8 RID: 19688
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
