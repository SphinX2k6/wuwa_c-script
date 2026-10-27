using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CF RID: 1487
	[NetMessage(EMessageId.FloroRanchPlayShopBuyRequest)]
	public sealed class FloroRanchPlayShopBuyRequest : IMessage<FloroRanchPlayShopBuyRequest>, IMessage, IEquatable<FloroRanchPlayShopBuyRequest>, IDeepCloneable<FloroRanchPlayShopBuyRequest>, IBufferMessage
	{
		// Token: 0x0600896E RID: 35182 RVA: 0x0014B584 File Offset: 0x00149784
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyRequest Create()
		{
			return new FloroRanchPlayShopBuyRequest();
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600896F RID: 35183 RVA: 0x0014B58B File Offset: 0x0014978B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06008970 RID: 35184 RVA: 0x0014B58E File Offset: 0x0014978E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x0014B595 File Offset: 0x00149795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyRequest()
		{
		}

		// Token: 0x06008972 RID: 35186 RVA: 0x0014B5A0 File Offset: 0x001497A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyRequest(FloroRanchPlayShopBuyRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.type_ = other.type_;
			this.buyId_ = other.buyId_;
			this.incId_ = other.incId_;
			this.itemIncId_ = other.itemIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008973 RID: 35187 RVA: 0x0014B60C File Offset: 0x0014980C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyRequest Clone()
		{
			return new FloroRanchPlayShopBuyRequest(this);
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06008974 RID: 35188 RVA: 0x0014B614 File Offset: 0x00149814
		// (set) Token: 0x06008975 RID: 35189 RVA: 0x0014B61C File Offset: 0x0014981C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06008976 RID: 35190 RVA: 0x0014B625 File Offset: 0x00149825
		// (set) Token: 0x06008977 RID: 35191 RVA: 0x0014B62D File Offset: 0x0014982D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06008978 RID: 35192 RVA: 0x0014B636 File Offset: 0x00149836
		// (set) Token: 0x06008979 RID: 35193 RVA: 0x0014B63E File Offset: 0x0014983E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShopItemType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x0600897A RID: 35194 RVA: 0x0014B647 File Offset: 0x00149847
		// (set) Token: 0x0600897B RID: 35195 RVA: 0x0014B64F File Offset: 0x0014984F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuyId
		{
			get
			{
				return this.buyId_;
			}
			set
			{
				this.buyId_ = value;
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600897C RID: 35196 RVA: 0x0014B658 File Offset: 0x00149858
		// (set) Token: 0x0600897D RID: 35197 RVA: 0x0014B660 File Offset: 0x00149860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600897E RID: 35198 RVA: 0x0014B669 File Offset: 0x00149869
		// (set) Token: 0x0600897F RID: 35199 RVA: 0x0014B671 File Offset: 0x00149871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemIncId
		{
			get
			{
				return this.itemIncId_;
			}
			set
			{
				this.itemIncId_ = value;
			}
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x0014B67A File Offset: 0x0014987A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyRequest);
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x0014B688 File Offset: 0x00149888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.Type == other.Type && this.BuyId == other.BuyId && this.IncId == other.IncId && this.ItemIncId == other.ItemIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x0014B714 File Offset: 0x00149914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.Type != FloroRanchShopItemType.Card)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.BuyId != 0)
			{
				num ^= this.BuyId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.ItemIncId != 0)
			{
				num ^= this.ItemIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x0014B7D6 File Offset: 0x001499D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x0014B7E3 File Offset: 0x001499E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x0014B7EC File Offset: 0x001499EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuyId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuyId);
			}
			if (this.ItemIncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemIncId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Type != FloroRanchShopItemType.Card)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Type);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x0014B8B4 File Offset: 0x00149AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.Type != FloroRanchShopItemType.Card)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.BuyId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuyId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.ItemIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x0014B96C File Offset: 0x00149B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayShopBuyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.Type != FloroRanchShopItemType.Card)
			{
				this.Type = other.Type;
			}
			if (other.BuyId != 0)
			{
				this.BuyId = other.BuyId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.ItemIncId != 0)
			{
				this.ItemIncId = other.ItemIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x0014BA0C File Offset: 0x00149C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x0014BA18 File Offset: 0x00149C18
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.BuyId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ItemIncId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Type = (FloroRanchShopItemType)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004391 RID: 17297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004392 RID: 17298
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04004393 RID: 17299
		private int activityId_;

		// Token: 0x04004394 RID: 17300
		public const int SubInsIdFieldNumber = 14;

		// Token: 0x04004395 RID: 17301
		private int subInsId_;

		// Token: 0x04004396 RID: 17302
		public const int TypeFieldNumber = 13;

		// Token: 0x04004397 RID: 17303
		private FloroRanchShopItemType type_;

		// Token: 0x04004398 RID: 17304
		public const int BuyIdFieldNumber = 1;

		// Token: 0x04004399 RID: 17305
		private int buyId_;

		// Token: 0x0400439A RID: 17306
		public const int IncIdFieldNumber = 4;

		// Token: 0x0400439B RID: 17307
		private int incId_;

		// Token: 0x0400439C RID: 17308
		public const int ItemIncIdFieldNumber = 3;

		// Token: 0x0400439D RID: 17309
		private int itemIncId_;
	}
}
