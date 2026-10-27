using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D7 RID: 1751
	[NetMessage(EMessageId.GiantDeliveryItemRequest)]
	public sealed class GiantDeliveryItemRequest : IMessage<GiantDeliveryItemRequest>, IMessage, IEquatable<GiantDeliveryItemRequest>, IDeepCloneable<GiantDeliveryItemRequest>, IBufferMessage
	{
		// Token: 0x06009FE3 RID: 40931 RVA: 0x00183435 File Offset: 0x00181635
		[NullableContext(1)]
		public static GiantDeliveryItemRequest Create()
		{
			return new GiantDeliveryItemRequest();
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06009FE4 RID: 40932 RVA: 0x0018343C File Offset: 0x0018163C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06009FE5 RID: 40933 RVA: 0x0018343F File Offset: 0x0018163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantDeliveryItemRequest.Descriptor;
			}
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x00183446 File Offset: 0x00181646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemRequest()
		{
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x00183459 File Offset: 0x00181659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemRequest(GiantDeliveryItemRequest other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this.itemInfos_ = other.itemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x0018348F File Offset: 0x0018168F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemRequest Clone()
		{
			return new GiantDeliveryItemRequest(this);
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06009FE9 RID: 40937 RVA: 0x00183497 File Offset: 0x00181697
		// (set) Token: 0x06009FEA RID: 40938 RVA: 0x0018349F File Offset: 0x0018169F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantEcoNetType GiantEcoType
		{
			get
			{
				return this.giantEcoType_;
			}
			set
			{
				this.giantEcoType_ = value;
			}
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06009FEB RID: 40939 RVA: 0x001834A8 File Offset: 0x001816A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x001834B0 File Offset: 0x001816B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantDeliveryItemRequest);
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x001834C0 File Offset: 0x001816C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantDeliveryItemRequest other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && this.ItemInfos.Equals(other.ItemInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x00183510 File Offset: 0x00181710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num ^= this.GiantEcoType.GetHashCode();
			}
			num ^= this.ItemInfos.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x00183563 File Offset: 0x00181763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x00183570 File Offset: 0x00181770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x0018357C File Offset: 0x0018177C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemInfos_.WriteTo(ref output, GiantDeliveryItemRequest._map_itemInfos_codec);
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.GiantEcoType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x001835CC File Offset: 0x001817CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantEcoType);
			}
			num += this.itemInfos_.CalculateSize(GiantDeliveryItemRequest._map_itemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x00183620 File Offset: 0x00181820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantDeliveryItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantEcoType != GiantEcoNetType.Fire)
			{
				this.GiantEcoType = other.GiantEcoType;
			}
			this.itemInfos_.MergeFrom(other.itemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x0018366D File Offset: 0x0018186D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x00183678 File Offset: 0x00181878
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
				if (num != 42U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GiantEcoType = (GiantEcoNetType)input.ReadEnum();
					}
				}
				else
				{
					this.itemInfos_.AddEntriesFrom(ref input, GiantDeliveryItemRequest._map_itemInfos_codec);
				}
			}
		}

		// Token: 0x04004A86 RID: 19078
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A87 RID: 19079
		public const int GiantEcoTypeFieldNumber = 11;

		// Token: 0x04004A88 RID: 19080
		private GiantEcoNetType giantEcoType_;

		// Token: 0x04004A89 RID: 19081
		public const int ItemInfosFieldNumber = 5;

		// Token: 0x04004A8A RID: 19082
		private static readonly MapField<int, int>.Codec _map_itemInfos_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04004A8B RID: 19083
		private readonly MapField<int, int> itemInfos_ = new MapField<int, int>();
	}
}
