using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD4 RID: 3028
	public sealed class PayItemInfo : IMessage<PayItemInfo>, IMessage, IEquatable<PayItemInfo>, IDeepCloneable<PayItemInfo>, IBufferMessage
	{
		// Token: 0x060106DA RID: 67290 RVA: 0x0026647F File Offset: 0x0026467F
		[NullableContext(1)]
		public static PayItemInfo Create()
		{
			return new PayItemInfo();
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x060106DB RID: 67291 RVA: 0x00266486 File Offset: 0x00264686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayItemInfo> Parser
		{
			get
			{
				return PayItemInfo._parser;
			}
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x060106DC RID: 67292 RVA: 0x0026648D File Offset: 0x0026468D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x060106DD RID: 67293 RVA: 0x00266490 File Offset: 0x00264690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayItemInfo.Descriptor;
			}
		}

		// Token: 0x060106DE RID: 67294 RVA: 0x00266497 File Offset: 0x00264697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemInfo()
		{
		}

		// Token: 0x060106DF RID: 67295 RVA: 0x002664CC File Offset: 0x002646CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemInfo(PayItemInfo other) : this()
		{
			this.id_ = other.id_;
			this.payId_ = other.payId_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this.bonusItemCount_ = other.bonusItemCount_;
			this.specialBonusItemCount_ = other.specialBonusItemCount_;
			this.canSpecialBonus_ = other.canSpecialBonus_;
			this.stageImage_ = other.stageImage_;
			this.productId_ = other.productId_;
			this.amount_ = other.amount_;
			this.complianceDetail_ = other.complianceDetail_;
			this.quality_ = other.quality_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060106E0 RID: 67296 RVA: 0x00266580 File Offset: 0x00264780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemInfo Clone()
		{
			return new PayItemInfo(this);
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x060106E1 RID: 67297 RVA: 0x00266588 File Offset: 0x00264788
		// (set) Token: 0x060106E2 RID: 67298 RVA: 0x00266590 File Offset: 0x00264790
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

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x060106E3 RID: 67299 RVA: 0x00266599 File Offset: 0x00264799
		// (set) Token: 0x060106E4 RID: 67300 RVA: 0x002665A1 File Offset: 0x002647A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PayId
		{
			get
			{
				return this.payId_;
			}
			set
			{
				this.payId_ = value;
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x060106E5 RID: 67301 RVA: 0x002665AA File Offset: 0x002647AA
		// (set) Token: 0x060106E6 RID: 67302 RVA: 0x002665B2 File Offset: 0x002647B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x060106E7 RID: 67303 RVA: 0x002665BB File Offset: 0x002647BB
		// (set) Token: 0x060106E8 RID: 67304 RVA: 0x002665C3 File Offset: 0x002647C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x060106E9 RID: 67305 RVA: 0x002665CC File Offset: 0x002647CC
		// (set) Token: 0x060106EA RID: 67306 RVA: 0x002665D4 File Offset: 0x002647D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BonusItemCount
		{
			get
			{
				return this.bonusItemCount_;
			}
			set
			{
				this.bonusItemCount_ = value;
			}
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x060106EB RID: 67307 RVA: 0x002665DD File Offset: 0x002647DD
		// (set) Token: 0x060106EC RID: 67308 RVA: 0x002665E5 File Offset: 0x002647E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpecialBonusItemCount
		{
			get
			{
				return this.specialBonusItemCount_;
			}
			set
			{
				this.specialBonusItemCount_ = value;
			}
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x060106ED RID: 67309 RVA: 0x002665EE File Offset: 0x002647EE
		// (set) Token: 0x060106EE RID: 67310 RVA: 0x002665F6 File Offset: 0x002647F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanSpecialBonus
		{
			get
			{
				return this.canSpecialBonus_;
			}
			set
			{
				this.canSpecialBonus_ = value;
			}
		}

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x060106EF RID: 67311 RVA: 0x002665FF File Offset: 0x002647FF
		// (set) Token: 0x060106F0 RID: 67312 RVA: 0x00266607 File Offset: 0x00264807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StageImage
		{
			get
			{
				return this.stageImage_;
			}
			set
			{
				this.stageImage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x060106F1 RID: 67313 RVA: 0x0026661A File Offset: 0x0026481A
		// (set) Token: 0x060106F2 RID: 67314 RVA: 0x00266622 File Offset: 0x00264822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ProductId
		{
			get
			{
				return this.productId_;
			}
			set
			{
				this.productId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x060106F3 RID: 67315 RVA: 0x00266635 File Offset: 0x00264835
		// (set) Token: 0x060106F4 RID: 67316 RVA: 0x0026663D File Offset: 0x0026483D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Amount
		{
			get
			{
				return this.amount_;
			}
			set
			{
				this.amount_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x060106F5 RID: 67317 RVA: 0x00266650 File Offset: 0x00264850
		// (set) Token: 0x060106F6 RID: 67318 RVA: 0x00266658 File Offset: 0x00264858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ComplianceDetail
		{
			get
			{
				return this.complianceDetail_;
			}
			set
			{
				this.complianceDetail_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x060106F7 RID: 67319 RVA: 0x0026666B File Offset: 0x0026486B
		// (set) Token: 0x060106F8 RID: 67320 RVA: 0x00266673 File Offset: 0x00264873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quality
		{
			get
			{
				return this.quality_;
			}
			set
			{
				this.quality_ = value;
			}
		}

		// Token: 0x060106F9 RID: 67321 RVA: 0x0026667C File Offset: 0x0026487C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayItemInfo);
		}

		// Token: 0x060106FA RID: 67322 RVA: 0x0026668C File Offset: 0x0026488C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayItemInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PayId == other.PayId && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && this.BonusItemCount == other.BonusItemCount && this.SpecialBonusItemCount == other.SpecialBonusItemCount && this.CanSpecialBonus == other.CanSpecialBonus && !(this.StageImage != other.StageImage) && !(this.ProductId != other.ProductId) && !(this.Amount != other.Amount) && !(this.ComplianceDetail != other.ComplianceDetail) && this.Quality == other.Quality && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060106FB RID: 67323 RVA: 0x0026678C File Offset: 0x0026498C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PayId != 0)
			{
				num ^= this.PayId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this.BonusItemCount != 0)
			{
				num ^= this.BonusItemCount.GetHashCode();
			}
			if (this.SpecialBonusItemCount != 0)
			{
				num ^= this.SpecialBonusItemCount.GetHashCode();
			}
			if (this.CanSpecialBonus)
			{
				num ^= this.CanSpecialBonus.GetHashCode();
			}
			if (this.StageImage.Length != 0)
			{
				num ^= this.StageImage.GetHashCode();
			}
			if (this.ProductId.Length != 0)
			{
				num ^= this.ProductId.GetHashCode();
			}
			if (this.Amount.Length != 0)
			{
				num ^= this.Amount.GetHashCode();
			}
			if (this.ComplianceDetail.Length != 0)
			{
				num ^= this.ComplianceDetail.GetHashCode();
			}
			if (this.Quality != 0)
			{
				num ^= this.Quality.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060106FC RID: 67324 RVA: 0x002668E6 File Offset: 0x00264AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060106FD RID: 67325 RVA: 0x002668F3 File Offset: 0x00264AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060106FE RID: 67326 RVA: 0x002668FC File Offset: 0x00264AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.PayId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PayId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemCount);
			}
			if (this.BonusItemCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BonusItemCount);
			}
			if (this.SpecialBonusItemCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SpecialBonusItemCount);
			}
			if (this.CanSpecialBonus)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.CanSpecialBonus);
			}
			if (this.StageImage.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.StageImage);
			}
			if (this.ProductId.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.ProductId);
			}
			if (this.Amount.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Amount);
			}
			if (this.ComplianceDetail.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ComplianceDetail);
			}
			if (this.Quality != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Quality);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060106FF RID: 67327 RVA: 0x00266A80 File Offset: 0x00264C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.PayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PayId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this.BonusItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BonusItemCount);
			}
			if (this.SpecialBonusItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpecialBonusItemCount);
			}
			if (this.CanSpecialBonus)
			{
				num += 2;
			}
			if (this.StageImage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StageImage);
			}
			if (this.ProductId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProductId);
			}
			if (this.Amount.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Amount);
			}
			if (this.ComplianceDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ComplianceDetail);
			}
			if (this.Quality != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quality);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010700 RID: 67328 RVA: 0x00266BD0 File Offset: 0x00264DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.PayId != 0)
			{
				this.PayId = other.PayId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			if (other.BonusItemCount != 0)
			{
				this.BonusItemCount = other.BonusItemCount;
			}
			if (other.SpecialBonusItemCount != 0)
			{
				this.SpecialBonusItemCount = other.SpecialBonusItemCount;
			}
			if (other.CanSpecialBonus)
			{
				this.CanSpecialBonus = other.CanSpecialBonus;
			}
			if (other.StageImage.Length != 0)
			{
				this.StageImage = other.StageImage;
			}
			if (other.ProductId.Length != 0)
			{
				this.ProductId = other.ProductId;
			}
			if (other.Amount.Length != 0)
			{
				this.Amount = other.Amount;
			}
			if (other.ComplianceDetail.Length != 0)
			{
				this.ComplianceDetail = other.ComplianceDetail;
			}
			if (other.Quality != 0)
			{
				this.Quality = other.Quality;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010701 RID: 67329 RVA: 0x00266CFC File Offset: 0x00264EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010702 RID: 67330 RVA: 0x00266D08 File Offset: 0x00264F08
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
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.PayId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.ItemId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.ItemCount = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.BonusItemCount = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.SpecialBonusItemCount = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 56U)
					{
						this.CanSpecialBonus = input.ReadBool();
						continue;
					}
					if (num == 66U)
					{
						this.StageImage = input.ReadString();
						continue;
					}
					if (num == 74U)
					{
						this.ProductId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.Amount = input.ReadString();
						continue;
					}
					if (num == 90U)
					{
						this.ComplianceDetail = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.Quality = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040068AF RID: 26799
		private static readonly MessageParser<PayItemInfo> _parser = new MessageParser<PayItemInfo>(() => new PayItemInfo());

		// Token: 0x040068B0 RID: 26800
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068B1 RID: 26801
		public const int IdFieldNumber = 1;

		// Token: 0x040068B2 RID: 26802
		private int id_;

		// Token: 0x040068B3 RID: 26803
		public const int PayIdFieldNumber = 2;

		// Token: 0x040068B4 RID: 26804
		private int payId_;

		// Token: 0x040068B5 RID: 26805
		public const int ItemIdFieldNumber = 3;

		// Token: 0x040068B6 RID: 26806
		private int itemId_;

		// Token: 0x040068B7 RID: 26807
		public const int ItemCountFieldNumber = 4;

		// Token: 0x040068B8 RID: 26808
		private int itemCount_;

		// Token: 0x040068B9 RID: 26809
		public const int BonusItemCountFieldNumber = 5;

		// Token: 0x040068BA RID: 26810
		private int bonusItemCount_;

		// Token: 0x040068BB RID: 26811
		public const int SpecialBonusItemCountFieldNumber = 6;

		// Token: 0x040068BC RID: 26812
		private int specialBonusItemCount_;

		// Token: 0x040068BD RID: 26813
		public const int CanSpecialBonusFieldNumber = 7;

		// Token: 0x040068BE RID: 26814
		private bool canSpecialBonus_;

		// Token: 0x040068BF RID: 26815
		public const int StageImageFieldNumber = 8;

		// Token: 0x040068C0 RID: 26816
		private string stageImage_ = "";

		// Token: 0x040068C1 RID: 26817
		public const int ProductIdFieldNumber = 9;

		// Token: 0x040068C2 RID: 26818
		private string productId_ = "";

		// Token: 0x040068C3 RID: 26819
		public const int AmountFieldNumber = 10;

		// Token: 0x040068C4 RID: 26820
		private string amount_ = "";

		// Token: 0x040068C5 RID: 26821
		public const int ComplianceDetailFieldNumber = 11;

		// Token: 0x040068C6 RID: 26822
		private string complianceDetail_ = "";

		// Token: 0x040068C7 RID: 26823
		public const int QualityFieldNumber = 12;

		// Token: 0x040068C8 RID: 26824
		private int quality_;
	}
}
