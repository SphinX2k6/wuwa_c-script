using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F0 RID: 4592
	[NetMessage(EMessageId.ShopBuyResponse)]
	public sealed class ShopBuyResponse : IMessage<ShopBuyResponse>, IMessage, IEquatable<ShopBuyResponse>, IDeepCloneable<ShopBuyResponse>, IBufferMessage
	{
		// Token: 0x060187AA RID: 100266 RVA: 0x0038F2C5 File Offset: 0x0038D4C5
		[NullableContext(1)]
		public static ShopBuyResponse Create()
		{
			return new ShopBuyResponse();
		}

		// Token: 0x1700526E RID: 21102
		// (get) Token: 0x060187AB RID: 100267 RVA: 0x0038F2CC File Offset: 0x0038D4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700526F RID: 21103
		// (get) Token: 0x060187AC RID: 100268 RVA: 0x0038F2CF File Offset: 0x0038D4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x060187AD RID: 100269 RVA: 0x0038F2D6 File Offset: 0x0038D4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyResponse()
		{
		}

		// Token: 0x060187AE RID: 100270 RVA: 0x0038F2E0 File Offset: 0x0038D4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyResponse(ShopBuyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.shopId_ = other.shopId_;
			this.id_ = other.id_;
			this.boughtCount_ = other.boughtCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060187AF RID: 100271 RVA: 0x0038F334 File Offset: 0x0038D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyResponse Clone()
		{
			return new ShopBuyResponse(this);
		}

		// Token: 0x17005270 RID: 21104
		// (get) Token: 0x060187B0 RID: 100272 RVA: 0x0038F33C File Offset: 0x0038D53C
		// (set) Token: 0x060187B1 RID: 100273 RVA: 0x0038F344 File Offset: 0x0038D544
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

		// Token: 0x17005271 RID: 21105
		// (get) Token: 0x060187B2 RID: 100274 RVA: 0x0038F34D File Offset: 0x0038D54D
		// (set) Token: 0x060187B3 RID: 100275 RVA: 0x0038F355 File Offset: 0x0038D555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x17005272 RID: 21106
		// (get) Token: 0x060187B4 RID: 100276 RVA: 0x0038F35E File Offset: 0x0038D55E
		// (set) Token: 0x060187B5 RID: 100277 RVA: 0x0038F366 File Offset: 0x0038D566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005273 RID: 21107
		// (get) Token: 0x060187B6 RID: 100278 RVA: 0x0038F36F File Offset: 0x0038D56F
		// (set) Token: 0x060187B7 RID: 100279 RVA: 0x0038F377 File Offset: 0x0038D577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoughtCount
		{
			get
			{
				return this.boughtCount_;
			}
			set
			{
				this.boughtCount_ = value;
			}
		}

		// Token: 0x060187B8 RID: 100280 RVA: 0x0038F380 File Offset: 0x0038D580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopBuyResponse);
		}

		// Token: 0x060187B9 RID: 100281 RVA: 0x0038F390 File Offset: 0x0038D590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopBuyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ShopId == other.ShopId && this.Id == other.Id && this.BoughtCount == other.BoughtCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187BA RID: 100282 RVA: 0x0038F3FC File Offset: 0x0038D5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BoughtCount != 0)
			{
				num ^= this.BoughtCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060187BB RID: 100283 RVA: 0x0038F48C File Offset: 0x0038D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187BC RID: 100284 RVA: 0x0038F499 File Offset: 0x0038D699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187BD RID: 100285 RVA: 0x0038F4A4 File Offset: 0x0038D6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ShopId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.BoughtCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BoughtCount);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187BE RID: 100286 RVA: 0x0038F538 File Offset: 0x0038D738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.BoughtCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoughtCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060187BF RID: 100287 RVA: 0x0038F5C0 File Offset: 0x0038D7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopBuyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BoughtCount != 0)
			{
				this.BoughtCount = other.BoughtCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060187C0 RID: 100288 RVA: 0x0038F638 File Offset: 0x0038D838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187C1 RID: 100289 RVA: 0x0038F644 File Offset: 0x0038D844
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
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.ShopId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.BoughtCount = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040090B4 RID: 37044
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090B5 RID: 37045
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040090B6 RID: 37046
		private ErrorCode errorCode_;

		// Token: 0x040090B7 RID: 37047
		public const int ShopIdFieldNumber = 4;

		// Token: 0x040090B8 RID: 37048
		private int shopId_;

		// Token: 0x040090B9 RID: 37049
		public const int IdFieldNumber = 11;

		// Token: 0x040090BA RID: 37050
		private int id_;

		// Token: 0x040090BB RID: 37051
		public const int BoughtCountFieldNumber = 8;

		// Token: 0x040090BC RID: 37052
		private int boughtCount_;
	}
}
