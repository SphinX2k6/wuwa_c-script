using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DF RID: 1759
	[NetMessage(EMessageId.GiantMaxLevelDeliveryItemRequest)]
	public sealed class GiantMaxLevelDeliveryItemRequest : IMessage<GiantMaxLevelDeliveryItemRequest>, IMessage, IEquatable<GiantMaxLevelDeliveryItemRequest>, IDeepCloneable<GiantMaxLevelDeliveryItemRequest>, IBufferMessage
	{
		// Token: 0x0600A08A RID: 41098 RVA: 0x00184B35 File Offset: 0x00182D35
		[NullableContext(1)]
		public static GiantMaxLevelDeliveryItemRequest Create()
		{
			return new GiantMaxLevelDeliveryItemRequest();
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x0600A08B RID: 41099 RVA: 0x00184B3C File Offset: 0x00182D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600A08C RID: 41100 RVA: 0x00184B3F File Offset: 0x00182D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantMaxLevelDeliveryItemRequest.Descriptor;
			}
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x00184B46 File Offset: 0x00182D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemRequest()
		{
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x00184B59 File Offset: 0x00182D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemRequest(GiantMaxLevelDeliveryItemRequest other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this.itemInfos_ = other.itemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x00184B8F File Offset: 0x00182D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemRequest Clone()
		{
			return new GiantMaxLevelDeliveryItemRequest(this);
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600A090 RID: 41104 RVA: 0x00184B97 File Offset: 0x00182D97
		// (set) Token: 0x0600A091 RID: 41105 RVA: 0x00184B9F File Offset: 0x00182D9F
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

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600A092 RID: 41106 RVA: 0x00184BA8 File Offset: 0x00182DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x00184BB0 File Offset: 0x00182DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantMaxLevelDeliveryItemRequest);
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x00184BC0 File Offset: 0x00182DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantMaxLevelDeliveryItemRequest other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && this.ItemInfos.Equals(other.ItemInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x00184C10 File Offset: 0x00182E10
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

		// Token: 0x0600A096 RID: 41110 RVA: 0x00184C63 File Offset: 0x00182E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x00184C70 File Offset: 0x00182E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x00184C7C File Offset: 0x00182E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemInfos_.WriteTo(ref output, GiantMaxLevelDeliveryItemRequest._map_itemInfos_codec);
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.GiantEcoType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x00184CCC File Offset: 0x00182ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantEcoType);
			}
			num += this.itemInfos_.CalculateSize(GiantMaxLevelDeliveryItemRequest._map_itemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x00184D20 File Offset: 0x00182F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantMaxLevelDeliveryItemRequest other)
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

		// Token: 0x0600A09B RID: 41115 RVA: 0x00184D6D File Offset: 0x00182F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A09C RID: 41116 RVA: 0x00184D78 File Offset: 0x00182F78
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
				if (num != 74U)
				{
					if (num != 80U)
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
					this.itemInfos_.AddEntriesFrom(ref input, GiantMaxLevelDeliveryItemRequest._map_itemInfos_codec);
				}
			}
		}

		// Token: 0x04004AB8 RID: 19128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AB9 RID: 19129
		public const int GiantEcoTypeFieldNumber = 10;

		// Token: 0x04004ABA RID: 19130
		private GiantEcoNetType giantEcoType_;

		// Token: 0x04004ABB RID: 19131
		public const int ItemInfosFieldNumber = 9;

		// Token: 0x04004ABC RID: 19132
		private static readonly MapField<int, int>.Codec _map_itemInfos_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04004ABD RID: 19133
		private readonly MapField<int, int> itemInfos_ = new MapField<int, int>();
	}
}
