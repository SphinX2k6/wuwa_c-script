using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CB RID: 1739
	[NetMessage(EMessageId.GiantMaxLevelDeliveryItemRequest)]
	public sealed class GiantMaxLevelDeliveryItemRequest : IMessage<GiantMaxLevelDeliveryItemRequest>, IMessage, IEquatable<GiantMaxLevelDeliveryItemRequest>, IDeepCloneable<GiantMaxLevelDeliveryItemRequest>, IBufferMessage
	{
		// Token: 0x06009F34 RID: 40756 RVA: 0x00182101 File Offset: 0x00180301
		[NullableContext(1)]
		public static GiantMaxLevelDeliveryItemRequest Create()
		{
			return new GiantMaxLevelDeliveryItemRequest();
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06009F35 RID: 40757 RVA: 0x00182108 File Offset: 0x00180308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06009F36 RID: 40758 RVA: 0x0018210B File Offset: 0x0018030B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantMaxLevelDeliveryItemRequest.Descriptor;
			}
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x00182112 File Offset: 0x00180312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemRequest()
		{
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x00182125 File Offset: 0x00180325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemRequest(GiantMaxLevelDeliveryItemRequest other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this.itemInfos_ = other.itemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x0018215B File Offset: 0x0018035B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantMaxLevelDeliveryItemRequest Clone()
		{
			return new GiantMaxLevelDeliveryItemRequest(this);
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06009F3A RID: 40762 RVA: 0x00182163 File Offset: 0x00180363
		// (set) Token: 0x06009F3B RID: 40763 RVA: 0x0018216B File Offset: 0x0018036B
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

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06009F3C RID: 40764 RVA: 0x00182174 File Offset: 0x00180374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x0018217C File Offset: 0x0018037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantMaxLevelDeliveryItemRequest);
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x0018218C File Offset: 0x0018038C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantMaxLevelDeliveryItemRequest other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && this.ItemInfos.Equals(other.ItemInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F3F RID: 40767 RVA: 0x001821DC File Offset: 0x001803DC
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

		// Token: 0x06009F40 RID: 40768 RVA: 0x0018222F File Offset: 0x0018042F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x0018223C File Offset: 0x0018043C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x00182248 File Offset: 0x00180448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.GiantEcoType);
			}
			this.itemInfos_.WriteTo(ref output, GiantMaxLevelDeliveryItemRequest._map_itemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x00182298 File Offset: 0x00180498
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

		// Token: 0x06009F44 RID: 40772 RVA: 0x001822EC File Offset: 0x001804EC
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

		// Token: 0x06009F45 RID: 40773 RVA: 0x00182339 File Offset: 0x00180539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x00182344 File Offset: 0x00180544
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemInfos_.AddEntriesFrom(ref input, GiantMaxLevelDeliveryItemRequest._map_itemInfos_codec);
					}
				}
				else
				{
					this.GiantEcoType = (GiantEcoNetType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004AB1 RID: 19121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AB2 RID: 19122
		public const int GiantEcoTypeFieldNumber = 1;

		// Token: 0x04004AB3 RID: 19123
		private GiantEcoNetType giantEcoType_;

		// Token: 0x04004AB4 RID: 19124
		public const int ItemInfosFieldNumber = 9;

		// Token: 0x04004AB5 RID: 19125
		private static readonly MapField<int, int>.Codec _map_itemInfos_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04004AB6 RID: 19126
		private readonly MapField<int, int> itemInfos_ = new MapField<int, int>();
	}
}
