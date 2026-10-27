using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001447 RID: 5191
	public sealed class TrapDefenseShopItemPbInfo : IMessage<TrapDefenseShopItemPbInfo>, IMessage, IEquatable<TrapDefenseShopItemPbInfo>, IDeepCloneable<TrapDefenseShopItemPbInfo>, IBufferMessage
	{
		// Token: 0x0601B7E0 RID: 112608 RVA: 0x003FAE1B File Offset: 0x003F901B
		[NullableContext(1)]
		public static TrapDefenseShopItemPbInfo Create()
		{
			return new TrapDefenseShopItemPbInfo();
		}

		// Token: 0x17005CB2 RID: 23730
		// (get) Token: 0x0601B7E1 RID: 112609 RVA: 0x003FAE22 File Offset: 0x003F9022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CB3 RID: 23731
		// (get) Token: 0x0601B7E2 RID: 112610 RVA: 0x003FAE25 File Offset: 0x003F9025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseShopItemPbInfo.Descriptor;
			}
		}

		// Token: 0x0601B7E3 RID: 112611 RVA: 0x003FAE2C File Offset: 0x003F902C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopItemPbInfo()
		{
		}

		// Token: 0x0601B7E4 RID: 112612 RVA: 0x003FAE34 File Offset: 0x003F9034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopItemPbInfo(TrapDefenseShopItemPbInfo other) : this()
		{
			this.itemConfigId_ = other.itemConfigId_;
			this.stockCount_ = other.stockCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7E5 RID: 112613 RVA: 0x003FAE65 File Offset: 0x003F9065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopItemPbInfo Clone()
		{
			return new TrapDefenseShopItemPbInfo(this);
		}

		// Token: 0x17005CB4 RID: 23732
		// (get) Token: 0x0601B7E6 RID: 112614 RVA: 0x003FAE6D File Offset: 0x003F906D
		// (set) Token: 0x0601B7E7 RID: 112615 RVA: 0x003FAE75 File Offset: 0x003F9075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemConfigId
		{
			get
			{
				return this.itemConfigId_;
			}
			set
			{
				this.itemConfigId_ = value;
			}
		}

		// Token: 0x17005CB5 RID: 23733
		// (get) Token: 0x0601B7E8 RID: 112616 RVA: 0x003FAE7E File Offset: 0x003F907E
		// (set) Token: 0x0601B7E9 RID: 112617 RVA: 0x003FAE86 File Offset: 0x003F9086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StockCount
		{
			get
			{
				return this.stockCount_;
			}
			set
			{
				this.stockCount_ = value;
			}
		}

		// Token: 0x0601B7EA RID: 112618 RVA: 0x003FAE8F File Offset: 0x003F908F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseShopItemPbInfo);
		}

		// Token: 0x0601B7EB RID: 112619 RVA: 0x003FAE9D File Offset: 0x003F909D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseShopItemPbInfo other)
		{
			return other != null && (other == this || (this.ItemConfigId == other.ItemConfigId && this.StockCount == other.StockCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B7EC RID: 112620 RVA: 0x003FAEDC File Offset: 0x003F90DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemConfigId != 0)
			{
				num ^= this.ItemConfigId.GetHashCode();
			}
			if (this.StockCount != 0)
			{
				num ^= this.StockCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B7ED RID: 112621 RVA: 0x003FAF34 File Offset: 0x003F9134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7EE RID: 112622 RVA: 0x003FAF41 File Offset: 0x003F9141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7EF RID: 112623 RVA: 0x003FAF4C File Offset: 0x003F914C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemConfigId);
			}
			if (this.StockCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StockCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7F0 RID: 112624 RVA: 0x003FAFA4 File Offset: 0x003F91A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemConfigId);
			}
			if (this.StockCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StockCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B7F1 RID: 112625 RVA: 0x003FAFFC File Offset: 0x003F91FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseShopItemPbInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemConfigId != 0)
			{
				this.ItemConfigId = other.ItemConfigId;
			}
			if (other.StockCount != 0)
			{
				this.StockCount = other.StockCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B7F2 RID: 112626 RVA: 0x003FB04C File Offset: 0x003F924C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7F3 RID: 112627 RVA: 0x003FB058 File Offset: 0x003F9258
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StockCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E95 RID: 40597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E96 RID: 40598
		public const int ItemConfigIdFieldNumber = 1;

		// Token: 0x04009E97 RID: 40599
		private int itemConfigId_;

		// Token: 0x04009E98 RID: 40600
		public const int StockCountFieldNumber = 2;

		// Token: 0x04009E99 RID: 40601
		private int stockCount_;
	}
}
