using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BA RID: 5306
	public sealed class TrapDefenseShopItemPbInfo : IMessage<TrapDefenseShopItemPbInfo>, IMessage, IEquatable<TrapDefenseShopItemPbInfo>, IDeepCloneable<TrapDefenseShopItemPbInfo>, IBufferMessage
	{
		// Token: 0x0601C26B RID: 115307 RVA: 0x004160EF File Offset: 0x004142EF
		[NullableContext(1)]
		public static TrapDefenseShopItemPbInfo Create()
		{
			return new TrapDefenseShopItemPbInfo();
		}

		// Token: 0x17005F47 RID: 24391
		// (get) Token: 0x0601C26C RID: 115308 RVA: 0x004160F6 File Offset: 0x004142F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F48 RID: 24392
		// (get) Token: 0x0601C26D RID: 115309 RVA: 0x004160F9 File Offset: 0x004142F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseShopItemPbInfo.Descriptor;
			}
		}

		// Token: 0x0601C26E RID: 115310 RVA: 0x00416100 File Offset: 0x00414300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopItemPbInfo()
		{
		}

		// Token: 0x0601C26F RID: 115311 RVA: 0x00416108 File Offset: 0x00414308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopItemPbInfo(TrapDefenseShopItemPbInfo other) : this()
		{
			this.itemConfigId_ = other.itemConfigId_;
			this.stockCount_ = other.stockCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C270 RID: 115312 RVA: 0x00416139 File Offset: 0x00414339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopItemPbInfo Clone()
		{
			return new TrapDefenseShopItemPbInfo(this);
		}

		// Token: 0x17005F49 RID: 24393
		// (get) Token: 0x0601C271 RID: 115313 RVA: 0x00416141 File Offset: 0x00414341
		// (set) Token: 0x0601C272 RID: 115314 RVA: 0x00416149 File Offset: 0x00414349
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

		// Token: 0x17005F4A RID: 24394
		// (get) Token: 0x0601C273 RID: 115315 RVA: 0x00416152 File Offset: 0x00414352
		// (set) Token: 0x0601C274 RID: 115316 RVA: 0x0041615A File Offset: 0x0041435A
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

		// Token: 0x0601C275 RID: 115317 RVA: 0x00416163 File Offset: 0x00414363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseShopItemPbInfo);
		}

		// Token: 0x0601C276 RID: 115318 RVA: 0x00416171 File Offset: 0x00414371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseShopItemPbInfo other)
		{
			return other != null && (other == this || (this.ItemConfigId == other.ItemConfigId && this.StockCount == other.StockCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C277 RID: 115319 RVA: 0x004161B0 File Offset: 0x004143B0
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

		// Token: 0x0601C278 RID: 115320 RVA: 0x00416208 File Offset: 0x00414408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C279 RID: 115321 RVA: 0x00416215 File Offset: 0x00414415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C27A RID: 115322 RVA: 0x00416220 File Offset: 0x00414420
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

		// Token: 0x0601C27B RID: 115323 RVA: 0x00416278 File Offset: 0x00414478
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

		// Token: 0x0601C27C RID: 115324 RVA: 0x004162D0 File Offset: 0x004144D0
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

		// Token: 0x0601C27D RID: 115325 RVA: 0x00416320 File Offset: 0x00414520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C27E RID: 115326 RVA: 0x0041632C File Offset: 0x0041452C
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

		// Token: 0x0400A2DC RID: 41692
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2DD RID: 41693
		public const int ItemConfigIdFieldNumber = 1;

		// Token: 0x0400A2DE RID: 41694
		private int itemConfigId_;

		// Token: 0x0400A2DF RID: 41695
		public const int StockCountFieldNumber = 2;

		// Token: 0x0400A2E0 RID: 41696
		private int stockCount_;
	}
}
