using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B3 RID: 2227
	public sealed class KurotatoShopPanelPbData : IMessage<KurotatoShopPanelPbData>, IMessage, IEquatable<KurotatoShopPanelPbData>, IDeepCloneable<KurotatoShopPanelPbData>, IBufferMessage
	{
		// Token: 0x0600C5D2 RID: 50642 RVA: 0x001D49A8 File Offset: 0x001D2BA8
		[NullableContext(1)]
		public static KurotatoShopPanelPbData Create()
		{
			return new KurotatoShopPanelPbData();
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x0600C5D3 RID: 50643 RVA: 0x001D49AF File Offset: 0x001D2BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0600C5D4 RID: 50644 RVA: 0x001D49B2 File Offset: 0x001D2BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopPanelPbData.Descriptor;
			}
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x001D49B9 File Offset: 0x001D2BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopPanelPbData()
		{
		}

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x001D49CC File Offset: 0x001D2BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopPanelPbData(KurotatoShopPanelPbData other) : this()
		{
			this.itemPbDatas_ = other.itemPbDatas_.Clone();
			this.refreshCost_ = other.refreshCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x001D4A02 File Offset: 0x001D2C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopPanelPbData Clone()
		{
			return new KurotatoShopPanelPbData(this);
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x0600C5D8 RID: 50648 RVA: 0x001D4A0A File Offset: 0x001D2C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoShopProductPbData> ItemPbDatas
		{
			get
			{
				return this.itemPbDatas_;
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x0600C5D9 RID: 50649 RVA: 0x001D4A12 File Offset: 0x001D2C12
		// (set) Token: 0x0600C5DA RID: 50650 RVA: 0x001D4A1A File Offset: 0x001D2C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCost
		{
			get
			{
				return this.refreshCost_;
			}
			set
			{
				this.refreshCost_ = value;
			}
		}

		// Token: 0x0600C5DB RID: 50651 RVA: 0x001D4A23 File Offset: 0x001D2C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopPanelPbData);
		}

		// Token: 0x0600C5DC RID: 50652 RVA: 0x001D4A34 File Offset: 0x001D2C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopPanelPbData other)
		{
			return other != null && (other == this || (this.itemPbDatas_.Equals(other.itemPbDatas_) && this.RefreshCost == other.RefreshCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5DD RID: 50653 RVA: 0x001D4A84 File Offset: 0x001D2C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemPbDatas_.GetHashCode();
			if (this.RefreshCost != 0)
			{
				num ^= this.RefreshCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C5DE RID: 50654 RVA: 0x001D4AD1 File Offset: 0x001D2CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C5DF RID: 50655 RVA: 0x001D4ADE File Offset: 0x001D2CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5E0 RID: 50656 RVA: 0x001D4AE8 File Offset: 0x001D2CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemPbDatas_.WriteTo(ref output, KurotatoShopPanelPbData._repeated_itemPbDatas_codec);
			if (this.RefreshCost != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RefreshCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5E1 RID: 50657 RVA: 0x001D4B38 File Offset: 0x001D2D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemPbDatas_.CalculateSize(KurotatoShopPanelPbData._repeated_itemPbDatas_codec);
			if (this.RefreshCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C5E2 RID: 50658 RVA: 0x001D4B8C File Offset: 0x001D2D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopPanelPbData other)
		{
			if (other == null)
			{
				return;
			}
			this.itemPbDatas_.Add(other.itemPbDatas_);
			if (other.RefreshCost != 0)
			{
				this.RefreshCost = other.RefreshCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x001D4BD9 File Offset: 0x001D2DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x001D4BE4 File Offset: 0x001D2DE4
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
						this.RefreshCost = input.ReadInt32();
					}
				}
				else
				{
					this.itemPbDatas_.AddEntriesFrom(ref input, KurotatoShopPanelPbData._repeated_itemPbDatas_codec);
				}
			}
		}

		// Token: 0x04005560 RID: 21856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005561 RID: 21857
		public const int ItemPbDatasFieldNumber = 1;

		// Token: 0x04005562 RID: 21858
		private static readonly FieldCodec<KurotatoShopProductPbData> _repeated_itemPbDatas_codec = FieldCodec.ForMessage<KurotatoShopProductPbData>(10U, KurotatoShopProductPbData.Parser);

		// Token: 0x04005563 RID: 21859
		private readonly RepeatedField<KurotatoShopProductPbData> itemPbDatas_ = new RepeatedField<KurotatoShopProductPbData>();

		// Token: 0x04005564 RID: 21860
		public const int RefreshCostFieldNumber = 2;

		// Token: 0x04005565 RID: 21861
		private int refreshCost_;
	}
}
