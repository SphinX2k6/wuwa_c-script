using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE4 RID: 3044
	public sealed class PayItemInfo : IMessage<PayItemInfo>, IMessage, IEquatable<PayItemInfo>, IDeepCloneable<PayItemInfo>, IBufferMessage
	{
		// Token: 0x060107DE RID: 67550 RVA: 0x0026833F File Offset: 0x0026653F
		[NullableContext(1)]
		public static PayItemInfo Create()
		{
			return new PayItemInfo();
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x060107DF RID: 67551 RVA: 0x00268346 File Offset: 0x00266546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PayItemInfo> Parser
		{
			get
			{
				return PayItemInfo._parser;
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x060107E0 RID: 67552 RVA: 0x0026834D File Offset: 0x0026654D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x060107E1 RID: 67553 RVA: 0x00268350 File Offset: 0x00266550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayItemInfo.Descriptor;
			}
		}

		// Token: 0x060107E2 RID: 67554 RVA: 0x00268357 File Offset: 0x00266557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemInfo()
		{
		}

		// Token: 0x060107E3 RID: 67555 RVA: 0x0026838C File Offset: 0x0026658C
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

		// Token: 0x060107E4 RID: 67556 RVA: 0x00268440 File Offset: 0x00266640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemInfo Clone()
		{
			return new PayItemInfo(this);
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x060107E5 RID: 67557 RVA: 0x00268448 File Offset: 0x00266648
		// (set) Token: 0x060107E6 RID: 67558 RVA: 0x00268450 File Offset: 0x00266650
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

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x060107E7 RID: 67559 RVA: 0x00268459 File Offset: 0x00266659
		// (set) Token: 0x060107E8 RID: 67560 RVA: 0x00268461 File Offset: 0x00266661
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

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x060107E9 RID: 67561 RVA: 0x0026846A File Offset: 0x0026666A
		// (set) Token: 0x060107EA RID: 67562 RVA: 0x00268472 File Offset: 0x00266672
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

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x060107EB RID: 67563 RVA: 0x0026847B File Offset: 0x0026667B
		// (set) Token: 0x060107EC RID: 67564 RVA: 0x00268483 File Offset: 0x00266683
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

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x060107ED RID: 67565 RVA: 0x0026848C File Offset: 0x0026668C
		// (set) Token: 0x060107EE RID: 67566 RVA: 0x00268494 File Offset: 0x00266694
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

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x060107EF RID: 67567 RVA: 0x0026849D File Offset: 0x0026669D
		// (set) Token: 0x060107F0 RID: 67568 RVA: 0x002684A5 File Offset: 0x002666A5
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

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x060107F1 RID: 67569 RVA: 0x002684AE File Offset: 0x002666AE
		// (set) Token: 0x060107F2 RID: 67570 RVA: 0x002684B6 File Offset: 0x002666B6
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

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x060107F3 RID: 67571 RVA: 0x002684BF File Offset: 0x002666BF
		// (set) Token: 0x060107F4 RID: 67572 RVA: 0x002684C7 File Offset: 0x002666C7
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

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x060107F5 RID: 67573 RVA: 0x002684DA File Offset: 0x002666DA
		// (set) Token: 0x060107F6 RID: 67574 RVA: 0x002684E2 File Offset: 0x002666E2
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

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x060107F7 RID: 67575 RVA: 0x002684F5 File Offset: 0x002666F5
		// (set) Token: 0x060107F8 RID: 67576 RVA: 0x002684FD File Offset: 0x002666FD
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

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x060107F9 RID: 67577 RVA: 0x00268510 File Offset: 0x00266710
		// (set) Token: 0x060107FA RID: 67578 RVA: 0x00268518 File Offset: 0x00266718
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

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x060107FB RID: 67579 RVA: 0x0026852B File Offset: 0x0026672B
		// (set) Token: 0x060107FC RID: 67580 RVA: 0x00268533 File Offset: 0x00266733
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

		// Token: 0x060107FD RID: 67581 RVA: 0x0026853C File Offset: 0x0026673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayItemInfo);
		}

		// Token: 0x060107FE RID: 67582 RVA: 0x0026854C File Offset: 0x0026674C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayItemInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PayId == other.PayId && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && this.BonusItemCount == other.BonusItemCount && this.SpecialBonusItemCount == other.SpecialBonusItemCount && this.CanSpecialBonus == other.CanSpecialBonus && !(this.StageImage != other.StageImage) && !(this.ProductId != other.ProductId) && !(this.Amount != other.Amount) && !(this.ComplianceDetail != other.ComplianceDetail) && this.Quality == other.Quality && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060107FF RID: 67583 RVA: 0x0026864C File Offset: 0x0026684C
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

		// Token: 0x06010800 RID: 67584 RVA: 0x002687A6 File Offset: 0x002669A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010801 RID: 67585 RVA: 0x002687B3 File Offset: 0x002669B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010802 RID: 67586 RVA: 0x002687BC File Offset: 0x002669BC
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

		// Token: 0x06010803 RID: 67587 RVA: 0x00268940 File Offset: 0x00266B40
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

		// Token: 0x06010804 RID: 67588 RVA: 0x00268A90 File Offset: 0x00266C90
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

		// Token: 0x06010805 RID: 67589 RVA: 0x00268BBC File Offset: 0x00266DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010806 RID: 67590 RVA: 0x00268BC8 File Offset: 0x00266DC8
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

		// Token: 0x0400689F RID: 26783
		private static readonly MessageParser<PayItemInfo> _parser = new MessageParser<PayItemInfo>(() => new PayItemInfo());

		// Token: 0x040068A0 RID: 26784
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068A1 RID: 26785
		public const int IdFieldNumber = 1;

		// Token: 0x040068A2 RID: 26786
		private int id_;

		// Token: 0x040068A3 RID: 26787
		public const int PayIdFieldNumber = 2;

		// Token: 0x040068A4 RID: 26788
		private int payId_;

		// Token: 0x040068A5 RID: 26789
		public const int ItemIdFieldNumber = 3;

		// Token: 0x040068A6 RID: 26790
		private int itemId_;

		// Token: 0x040068A7 RID: 26791
		public const int ItemCountFieldNumber = 4;

		// Token: 0x040068A8 RID: 26792
		private int itemCount_;

		// Token: 0x040068A9 RID: 26793
		public const int BonusItemCountFieldNumber = 5;

		// Token: 0x040068AA RID: 26794
		private int bonusItemCount_;

		// Token: 0x040068AB RID: 26795
		public const int SpecialBonusItemCountFieldNumber = 6;

		// Token: 0x040068AC RID: 26796
		private int specialBonusItemCount_;

		// Token: 0x040068AD RID: 26797
		public const int CanSpecialBonusFieldNumber = 7;

		// Token: 0x040068AE RID: 26798
		private bool canSpecialBonus_;

		// Token: 0x040068AF RID: 26799
		public const int StageImageFieldNumber = 8;

		// Token: 0x040068B0 RID: 26800
		private string stageImage_ = "";

		// Token: 0x040068B1 RID: 26801
		public const int ProductIdFieldNumber = 9;

		// Token: 0x040068B2 RID: 26802
		private string productId_ = "";

		// Token: 0x040068B3 RID: 26803
		public const int AmountFieldNumber = 10;

		// Token: 0x040068B4 RID: 26804
		private string amount_ = "";

		// Token: 0x040068B5 RID: 26805
		public const int ComplianceDetailFieldNumber = 11;

		// Token: 0x040068B6 RID: 26806
		private string complianceDetail_ = "";

		// Token: 0x040068B7 RID: 26807
		public const int QualityFieldNumber = 12;

		// Token: 0x040068B8 RID: 26808
		private int quality_;
	}
}
