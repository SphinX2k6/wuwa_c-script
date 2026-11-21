using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C3 RID: 1731
	[NetMessage(EMessageId.GiantDeliveryItemRequest)]
	public sealed class GiantDeliveryItemRequest : IMessage<GiantDeliveryItemRequest>, IMessage, IEquatable<GiantDeliveryItemRequest>, IDeepCloneable<GiantDeliveryItemRequest>, IBufferMessage
	{
		// Token: 0x06009E8D RID: 40589 RVA: 0x00180A01 File Offset: 0x0017EC01
		[NullableContext(1)]
		public static GiantDeliveryItemRequest Create()
		{
			return new GiantDeliveryItemRequest();
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06009E8E RID: 40590 RVA: 0x00180A08 File Offset: 0x0017EC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06009E8F RID: 40591 RVA: 0x00180A0B File Offset: 0x0017EC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantDeliveryItemRequest.Descriptor;
			}
		}

		// Token: 0x06009E90 RID: 40592 RVA: 0x00180A12 File Offset: 0x0017EC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemRequest()
		{
		}

		// Token: 0x06009E91 RID: 40593 RVA: 0x00180A25 File Offset: 0x0017EC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemRequest(GiantDeliveryItemRequest other) : this()
		{
			this.giantEcoType_ = other.giantEcoType_;
			this.itemInfos_ = other.itemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E92 RID: 40594 RVA: 0x00180A5B File Offset: 0x0017EC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantDeliveryItemRequest Clone()
		{
			return new GiantDeliveryItemRequest(this);
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06009E93 RID: 40595 RVA: 0x00180A63 File Offset: 0x0017EC63
		// (set) Token: 0x06009E94 RID: 40596 RVA: 0x00180A6B File Offset: 0x0017EC6B
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

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06009E95 RID: 40597 RVA: 0x00180A74 File Offset: 0x0017EC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemInfos
		{
			get
			{
				return this.itemInfos_;
			}
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x00180A7C File Offset: 0x0017EC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantDeliveryItemRequest);
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x00180A8C File Offset: 0x0017EC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantDeliveryItemRequest other)
		{
			return other != null && (other == this || (this.GiantEcoType == other.GiantEcoType && this.ItemInfos.Equals(other.ItemInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E98 RID: 40600 RVA: 0x00180ADC File Offset: 0x0017ECDC
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

		// Token: 0x06009E99 RID: 40601 RVA: 0x00180B2F File Offset: 0x0017ED2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x00180B3C File Offset: 0x0017ED3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E9B RID: 40603 RVA: 0x00180B48 File Offset: 0x0017ED48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantEcoType != GiantEcoNetType.Fire)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.GiantEcoType);
			}
			this.itemInfos_.WriteTo(ref output, GiantDeliveryItemRequest._map_itemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x00180B98 File Offset: 0x0017ED98
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

		// Token: 0x06009E9D RID: 40605 RVA: 0x00180BEC File Offset: 0x0017EDEC
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

		// Token: 0x06009E9E RID: 40606 RVA: 0x00180C39 File Offset: 0x0017EE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x00180C44 File Offset: 0x0017EE44
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
				if (num != 56U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemInfos_.AddEntriesFrom(ref input, GiantDeliveryItemRequest._map_itemInfos_codec);
					}
				}
				else
				{
					this.GiantEcoType = (GiantEcoNetType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004A7F RID: 19071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A80 RID: 19072
		public const int GiantEcoTypeFieldNumber = 7;

		// Token: 0x04004A81 RID: 19073
		private GiantEcoNetType giantEcoType_;

		// Token: 0x04004A82 RID: 19074
		public const int ItemInfosFieldNumber = 15;

		// Token: 0x04004A83 RID: 19075
		private static readonly MapField<int, int>.Codec _map_itemInfos_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x04004A84 RID: 19076
		private readonly MapField<int, int> itemInfos_ = new MapField<int, int>();
	}
}
