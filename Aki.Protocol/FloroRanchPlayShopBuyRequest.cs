using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BA RID: 1466
	[NetMessage(EMessageId.FloroRanchPlayShopBuyRequest)]
	public sealed class FloroRanchPlayShopBuyRequest : IMessage<FloroRanchPlayShopBuyRequest>, IMessage, IEquatable<FloroRanchPlayShopBuyRequest>, IDeepCloneable<FloroRanchPlayShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06008806 RID: 34822 RVA: 0x0014896C File Offset: 0x00146B6C
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyRequest Create()
		{
			return new FloroRanchPlayShopBuyRequest();
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06008807 RID: 34823 RVA: 0x00148973 File Offset: 0x00146B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06008808 RID: 34824 RVA: 0x00148976 File Offset: 0x00146B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x0014897D File Offset: 0x00146B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyRequest()
		{
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x00148988 File Offset: 0x00146B88
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

		// Token: 0x0600880B RID: 34827 RVA: 0x001489F4 File Offset: 0x00146BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyRequest Clone()
		{
			return new FloroRanchPlayShopBuyRequest(this);
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x0600880C RID: 34828 RVA: 0x001489FC File Offset: 0x00146BFC
		// (set) Token: 0x0600880D RID: 34829 RVA: 0x00148A04 File Offset: 0x00146C04
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

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x0600880E RID: 34830 RVA: 0x00148A0D File Offset: 0x00146C0D
		// (set) Token: 0x0600880F RID: 34831 RVA: 0x00148A15 File Offset: 0x00146C15
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

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06008810 RID: 34832 RVA: 0x00148A1E File Offset: 0x00146C1E
		// (set) Token: 0x06008811 RID: 34833 RVA: 0x00148A26 File Offset: 0x00146C26
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

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06008812 RID: 34834 RVA: 0x00148A2F File Offset: 0x00146C2F
		// (set) Token: 0x06008813 RID: 34835 RVA: 0x00148A37 File Offset: 0x00146C37
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

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06008814 RID: 34836 RVA: 0x00148A40 File Offset: 0x00146C40
		// (set) Token: 0x06008815 RID: 34837 RVA: 0x00148A48 File Offset: 0x00146C48
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

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06008816 RID: 34838 RVA: 0x00148A51 File Offset: 0x00146C51
		// (set) Token: 0x06008817 RID: 34839 RVA: 0x00148A59 File Offset: 0x00146C59
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

		// Token: 0x06008818 RID: 34840 RVA: 0x00148A62 File Offset: 0x00146C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyRequest);
		}

		// Token: 0x06008819 RID: 34841 RVA: 0x00148A70 File Offset: 0x00146C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.Type == other.Type && this.BuyId == other.BuyId && this.IncId == other.IncId && this.ItemIncId == other.ItemIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600881A RID: 34842 RVA: 0x00148AFC File Offset: 0x00146CFC
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

		// Token: 0x0600881B RID: 34843 RVA: 0x00148BBE File Offset: 0x00146DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x00148BCB File Offset: 0x00146DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600881D RID: 34845 RVA: 0x00148BD4 File Offset: 0x00146DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.BuyId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BuyId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ItemIncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemIncId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SubInsId);
			}
			if (this.Type != FloroRanchShopItemType.Card)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600881E RID: 34846 RVA: 0x00148C9C File Offset: 0x00146E9C
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

		// Token: 0x0600881F RID: 34847 RVA: 0x00148D54 File Offset: 0x00146F54
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

		// Token: 0x06008820 RID: 34848 RVA: 0x00148DF4 File Offset: 0x00146FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008821 RID: 34849 RVA: 0x00148E00 File Offset: 0x00147000
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
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BuyId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ItemIncId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Type = (FloroRanchShopItemType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004387 RID: 17287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004388 RID: 17288
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04004389 RID: 17289
		private int activityId_;

		// Token: 0x0400438A RID: 17290
		public const int SubInsIdFieldNumber = 11;

		// Token: 0x0400438B RID: 17291
		private int subInsId_;

		// Token: 0x0400438C RID: 17292
		public const int TypeFieldNumber = 13;

		// Token: 0x0400438D RID: 17293
		private FloroRanchShopItemType type_;

		// Token: 0x0400438E RID: 17294
		public const int BuyIdFieldNumber = 4;

		// Token: 0x0400438F RID: 17295
		private int buyId_;

		// Token: 0x04004390 RID: 17296
		public const int IncIdFieldNumber = 1;

		// Token: 0x04004391 RID: 17297
		private int incId_;

		// Token: 0x04004392 RID: 17298
		public const int ItemIncIdFieldNumber = 9;

		// Token: 0x04004393 RID: 17299
		private int itemIncId_;
	}
}
