using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C4 RID: 2244
	public sealed class KurotatoShopPanelPbData : IMessage<KurotatoShopPanelPbData>, IMessage, IEquatable<KurotatoShopPanelPbData>, IDeepCloneable<KurotatoShopPanelPbData>, IBufferMessage
	{
		// Token: 0x0600C6EE RID: 50926 RVA: 0x001D6C94 File Offset: 0x001D4E94
		[NullableContext(1)]
		public static KurotatoShopPanelPbData Create()
		{
			return new KurotatoShopPanelPbData();
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x0600C6EF RID: 50927 RVA: 0x001D6C9B File Offset: 0x001D4E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x0600C6F0 RID: 50928 RVA: 0x001D6C9E File Offset: 0x001D4E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopPanelPbData.Descriptor;
			}
		}

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x001D6CA5 File Offset: 0x001D4EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopPanelPbData()
		{
		}

		// Token: 0x0600C6F2 RID: 50930 RVA: 0x001D6CB8 File Offset: 0x001D4EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopPanelPbData(KurotatoShopPanelPbData other) : this()
		{
			this.itemPbDatas_ = other.itemPbDatas_.Clone();
			this.refreshCost_ = other.refreshCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6F3 RID: 50931 RVA: 0x001D6CEE File Offset: 0x001D4EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopPanelPbData Clone()
		{
			return new KurotatoShopPanelPbData(this);
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x0600C6F4 RID: 50932 RVA: 0x001D6CF6 File Offset: 0x001D4EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoShopProductPbData> ItemPbDatas
		{
			get
			{
				return this.itemPbDatas_;
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x0600C6F5 RID: 50933 RVA: 0x001D6CFE File Offset: 0x001D4EFE
		// (set) Token: 0x0600C6F6 RID: 50934 RVA: 0x001D6D06 File Offset: 0x001D4F06
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

		// Token: 0x0600C6F7 RID: 50935 RVA: 0x001D6D0F File Offset: 0x001D4F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopPanelPbData);
		}

		// Token: 0x0600C6F8 RID: 50936 RVA: 0x001D6D20 File Offset: 0x001D4F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopPanelPbData other)
		{
			return other != null && (other == this || (this.itemPbDatas_.Equals(other.itemPbDatas_) && this.RefreshCost == other.RefreshCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6F9 RID: 50937 RVA: 0x001D6D70 File Offset: 0x001D4F70
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

		// Token: 0x0600C6FA RID: 50938 RVA: 0x001D6DBD File Offset: 0x001D4FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6FB RID: 50939 RVA: 0x001D6DCA File Offset: 0x001D4FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6FC RID: 50940 RVA: 0x001D6DD4 File Offset: 0x001D4FD4
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

		// Token: 0x0600C6FD RID: 50941 RVA: 0x001D6E24 File Offset: 0x001D5024
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

		// Token: 0x0600C6FE RID: 50942 RVA: 0x001D6E78 File Offset: 0x001D5078
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

		// Token: 0x0600C6FF RID: 50943 RVA: 0x001D6EC5 File Offset: 0x001D50C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C700 RID: 50944 RVA: 0x001D6ED0 File Offset: 0x001D50D0
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

		// Token: 0x04005559 RID: 21849
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400555A RID: 21850
		public const int ItemPbDatasFieldNumber = 1;

		// Token: 0x0400555B RID: 21851
		private static readonly FieldCodec<KurotatoShopProductPbData> _repeated_itemPbDatas_codec = FieldCodec.ForMessage<KurotatoShopProductPbData>(10U, KurotatoShopProductPbData.Parser);

		// Token: 0x0400555C RID: 21852
		private readonly RepeatedField<KurotatoShopProductPbData> itemPbDatas_ = new RepeatedField<KurotatoShopProductPbData>();

		// Token: 0x0400555D RID: 21853
		public const int RefreshCostFieldNumber = 2;

		// Token: 0x0400555E RID: 21854
		private int refreshCost_;
	}
}
