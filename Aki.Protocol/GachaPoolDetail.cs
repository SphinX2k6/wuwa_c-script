using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000695 RID: 1685
	public sealed class GachaPoolDetail : IMessage<GachaPoolDetail>, IMessage, IEquatable<GachaPoolDetail>, IDeepCloneable<GachaPoolDetail>, IBufferMessage
	{
		// Token: 0x06009A3F RID: 39487 RVA: 0x00173C76 File Offset: 0x00171E76
		[NullableContext(1)]
		public static GachaPoolDetail Create()
		{
			return new GachaPoolDetail();
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06009A40 RID: 39488 RVA: 0x00173C7D File Offset: 0x00171E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06009A41 RID: 39489 RVA: 0x00173C80 File Offset: 0x00171E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolDetail.Descriptor;
			}
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x00173C88 File Offset: 0x00171E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetail()
		{
		}

		// Token: 0x06009A43 RID: 39491 RVA: 0x00173D20 File Offset: 0x00171F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetail(GachaPoolDetail other) : this()
		{
			this.detail_ = other.detail_;
			this.fiveStarRoleList_ = other.fiveStarRoleList_.Clone();
			this.fiveStarWeaponList_ = other.fiveStarWeaponList_.Clone();
			this.fourStarRoleList_ = other.fourStarRoleList_.Clone();
			this.fourStarWeaponList_ = other.fourStarWeaponList_.Clone();
			this.threeStarWeaponList_ = other.threeStarWeaponList_.Clone();
			this.fiveStarTitle_ = other.fiveStarTitle_;
			this.fiveStarDetail_ = other.fiveStarDetail_;
			this.fourStarTitle_ = other.fourStarTitle_;
			this.fourStarDetail_ = other.fourStarDetail_;
			this.threeStarTitle_ = other.threeStarTitle_;
			this.threeStarDetail_ = other.threeStarDetail_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x00173DED File Offset: 0x00171FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetail Clone()
		{
			return new GachaPoolDetail(this);
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06009A45 RID: 39493 RVA: 0x00173DF5 File Offset: 0x00171FF5
		// (set) Token: 0x06009A46 RID: 39494 RVA: 0x00173DFD File Offset: 0x00171FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Detail
		{
			get
			{
				return this.detail_;
			}
			set
			{
				this.detail_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06009A47 RID: 39495 RVA: 0x00173E10 File Offset: 0x00172010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> FiveStarRoleList
		{
			get
			{
				return this.fiveStarRoleList_;
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06009A48 RID: 39496 RVA: 0x00173E18 File Offset: 0x00172018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> FiveStarWeaponList
		{
			get
			{
				return this.fiveStarWeaponList_;
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06009A49 RID: 39497 RVA: 0x00173E20 File Offset: 0x00172020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> FourStarRoleList
		{
			get
			{
				return this.fourStarRoleList_;
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06009A4A RID: 39498 RVA: 0x00173E28 File Offset: 0x00172028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> FourStarWeaponList
		{
			get
			{
				return this.fourStarWeaponList_;
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06009A4B RID: 39499 RVA: 0x00173E30 File Offset: 0x00172030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> ThreeStarWeaponList
		{
			get
			{
				return this.threeStarWeaponList_;
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x06009A4C RID: 39500 RVA: 0x00173E38 File Offset: 0x00172038
		// (set) Token: 0x06009A4D RID: 39501 RVA: 0x00173E40 File Offset: 0x00172040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FiveStarTitle
		{
			get
			{
				return this.fiveStarTitle_;
			}
			set
			{
				this.fiveStarTitle_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06009A4E RID: 39502 RVA: 0x00173E53 File Offset: 0x00172053
		// (set) Token: 0x06009A4F RID: 39503 RVA: 0x00173E5B File Offset: 0x0017205B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FiveStarDetail
		{
			get
			{
				return this.fiveStarDetail_;
			}
			set
			{
				this.fiveStarDetail_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06009A50 RID: 39504 RVA: 0x00173E6E File Offset: 0x0017206E
		// (set) Token: 0x06009A51 RID: 39505 RVA: 0x00173E76 File Offset: 0x00172076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FourStarTitle
		{
			get
			{
				return this.fourStarTitle_;
			}
			set
			{
				this.fourStarTitle_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06009A52 RID: 39506 RVA: 0x00173E89 File Offset: 0x00172089
		// (set) Token: 0x06009A53 RID: 39507 RVA: 0x00173E91 File Offset: 0x00172091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FourStarDetail
		{
			get
			{
				return this.fourStarDetail_;
			}
			set
			{
				this.fourStarDetail_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06009A54 RID: 39508 RVA: 0x00173EA4 File Offset: 0x001720A4
		// (set) Token: 0x06009A55 RID: 39509 RVA: 0x00173EAC File Offset: 0x001720AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ThreeStarTitle
		{
			get
			{
				return this.threeStarTitle_;
			}
			set
			{
				this.threeStarTitle_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06009A56 RID: 39510 RVA: 0x00173EBF File Offset: 0x001720BF
		// (set) Token: 0x06009A57 RID: 39511 RVA: 0x00173EC7 File Offset: 0x001720C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ThreeStarDetail
		{
			get
			{
				return this.threeStarDetail_;
			}
			set
			{
				this.threeStarDetail_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x00173EDA File Offset: 0x001720DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolDetail);
		}

		// Token: 0x06009A59 RID: 39513 RVA: 0x00173EE8 File Offset: 0x001720E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolDetail other)
		{
			return other != null && (other == this || (!(this.Detail != other.Detail) && this.fiveStarRoleList_.Equals(other.fiveStarRoleList_) && this.fiveStarWeaponList_.Equals(other.fiveStarWeaponList_) && this.fourStarRoleList_.Equals(other.fourStarRoleList_) && this.fourStarWeaponList_.Equals(other.fourStarWeaponList_) && this.threeStarWeaponList_.Equals(other.threeStarWeaponList_) && !(this.FiveStarTitle != other.FiveStarTitle) && !(this.FiveStarDetail != other.FiveStarDetail) && !(this.FourStarTitle != other.FourStarTitle) && !(this.FourStarDetail != other.FourStarDetail) && !(this.ThreeStarTitle != other.ThreeStarTitle) && !(this.ThreeStarDetail != other.ThreeStarDetail) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x00174010 File Offset: 0x00172210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			num ^= this.fiveStarRoleList_.GetHashCode();
			num ^= this.fiveStarWeaponList_.GetHashCode();
			num ^= this.fourStarRoleList_.GetHashCode();
			num ^= this.fourStarWeaponList_.GetHashCode();
			num ^= this.threeStarWeaponList_.GetHashCode();
			if (this.FiveStarTitle.Length != 0)
			{
				num ^= this.FiveStarTitle.GetHashCode();
			}
			if (this.FiveStarDetail.Length != 0)
			{
				num ^= this.FiveStarDetail.GetHashCode();
			}
			if (this.FourStarTitle.Length != 0)
			{
				num ^= this.FourStarTitle.GetHashCode();
			}
			if (this.FourStarDetail.Length != 0)
			{
				num ^= this.FourStarDetail.GetHashCode();
			}
			if (this.ThreeStarTitle.Length != 0)
			{
				num ^= this.ThreeStarTitle.GetHashCode();
			}
			if (this.ThreeStarDetail.Length != 0)
			{
				num ^= this.ThreeStarDetail.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x00174139 File Offset: 0x00172339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x00174146 File Offset: 0x00172346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A5D RID: 39517 RVA: 0x00174150 File Offset: 0x00172350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Detail);
			}
			this.fiveStarRoleList_.WriteTo(ref output, GachaPoolDetail._repeated_fiveStarRoleList_codec);
			this.fiveStarWeaponList_.WriteTo(ref output, GachaPoolDetail._repeated_fiveStarWeaponList_codec);
			this.fourStarRoleList_.WriteTo(ref output, GachaPoolDetail._repeated_fourStarRoleList_codec);
			this.fourStarWeaponList_.WriteTo(ref output, GachaPoolDetail._repeated_fourStarWeaponList_codec);
			this.threeStarWeaponList_.WriteTo(ref output, GachaPoolDetail._repeated_threeStarWeaponList_codec);
			if (this.FiveStarTitle.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.FiveStarTitle);
			}
			if (this.FiveStarDetail.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.FiveStarDetail);
			}
			if (this.FourStarTitle.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.FourStarTitle);
			}
			if (this.FourStarDetail.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.FourStarDetail);
			}
			if (this.ThreeStarTitle.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ThreeStarTitle);
			}
			if (this.ThreeStarDetail.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.ThreeStarDetail);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x001742B0 File Offset: 0x001724B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Detail);
			}
			num += this.fiveStarRoleList_.CalculateSize(GachaPoolDetail._repeated_fiveStarRoleList_codec);
			num += this.fiveStarWeaponList_.CalculateSize(GachaPoolDetail._repeated_fiveStarWeaponList_codec);
			num += this.fourStarRoleList_.CalculateSize(GachaPoolDetail._repeated_fourStarRoleList_codec);
			num += this.fourStarWeaponList_.CalculateSize(GachaPoolDetail._repeated_fourStarWeaponList_codec);
			num += this.threeStarWeaponList_.CalculateSize(GachaPoolDetail._repeated_threeStarWeaponList_codec);
			if (this.FiveStarTitle.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FiveStarTitle);
			}
			if (this.FiveStarDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FiveStarDetail);
			}
			if (this.FourStarTitle.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FourStarTitle);
			}
			if (this.FourStarDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FourStarDetail);
			}
			if (this.ThreeStarTitle.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ThreeStarTitle);
			}
			if (this.ThreeStarDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ThreeStarDetail);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x00174400 File Offset: 0x00172600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaPoolDetail other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			this.fiveStarRoleList_.Add(other.fiveStarRoleList_);
			this.fiveStarWeaponList_.Add(other.fiveStarWeaponList_);
			this.fourStarRoleList_.Add(other.fourStarRoleList_);
			this.fourStarWeaponList_.Add(other.fourStarWeaponList_);
			this.threeStarWeaponList_.Add(other.threeStarWeaponList_);
			if (other.FiveStarTitle.Length != 0)
			{
				this.FiveStarTitle = other.FiveStarTitle;
			}
			if (other.FiveStarDetail.Length != 0)
			{
				this.FiveStarDetail = other.FiveStarDetail;
			}
			if (other.FourStarTitle.Length != 0)
			{
				this.FourStarTitle = other.FourStarTitle;
			}
			if (other.FourStarDetail.Length != 0)
			{
				this.FourStarDetail = other.FourStarDetail;
			}
			if (other.ThreeStarTitle.Length != 0)
			{
				this.ThreeStarTitle = other.ThreeStarTitle;
			}
			if (other.ThreeStarDetail.Length != 0)
			{
				this.ThreeStarDetail = other.ThreeStarDetail;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x0017452C File Offset: 0x0017272C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A61 RID: 39521 RVA: 0x00174538 File Offset: 0x00172738
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
				if (num <= 50U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							this.Detail = input.ReadString();
							continue;
						}
						if (num == 18U)
						{
							this.fiveStarRoleList_.AddEntriesFrom(ref input, GachaPoolDetail._repeated_fiveStarRoleList_codec);
							continue;
						}
						if (num == 26U)
						{
							this.fiveStarWeaponList_.AddEntriesFrom(ref input, GachaPoolDetail._repeated_fiveStarWeaponList_codec);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.fourStarRoleList_.AddEntriesFrom(ref input, GachaPoolDetail._repeated_fourStarRoleList_codec);
							continue;
						}
						if (num == 42U)
						{
							this.fourStarWeaponList_.AddEntriesFrom(ref input, GachaPoolDetail._repeated_fourStarWeaponList_codec);
							continue;
						}
						if (num == 50U)
						{
							this.threeStarWeaponList_.AddEntriesFrom(ref input, GachaPoolDetail._repeated_threeStarWeaponList_codec);
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 58U)
					{
						this.FiveStarTitle = input.ReadString();
						continue;
					}
					if (num == 66U)
					{
						this.FiveStarDetail = input.ReadString();
						continue;
					}
					if (num == 74U)
					{
						this.FourStarTitle = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.FourStarDetail = input.ReadString();
						continue;
					}
					if (num == 90U)
					{
						this.ThreeStarTitle = input.ReadString();
						continue;
					}
					if (num == 98U)
					{
						this.ThreeStarDetail = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048EC RID: 18668
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048ED RID: 18669
		public const int DetailFieldNumber = 1;

		// Token: 0x040048EE RID: 18670
		private string detail_ = "";

		// Token: 0x040048EF RID: 18671
		public const int FiveStarRoleListFieldNumber = 2;

		// Token: 0x040048F0 RID: 18672
		private static readonly FieldCodec<GachaPoolDrop> _repeated_fiveStarRoleList_codec = FieldCodec.ForMessage<GachaPoolDrop>(18U, GachaPoolDrop.Parser);

		// Token: 0x040048F1 RID: 18673
		private readonly RepeatedField<GachaPoolDrop> fiveStarRoleList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048F2 RID: 18674
		public const int FiveStarWeaponListFieldNumber = 3;

		// Token: 0x040048F3 RID: 18675
		private static readonly FieldCodec<GachaPoolDrop> _repeated_fiveStarWeaponList_codec = FieldCodec.ForMessage<GachaPoolDrop>(26U, GachaPoolDrop.Parser);

		// Token: 0x040048F4 RID: 18676
		private readonly RepeatedField<GachaPoolDrop> fiveStarWeaponList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048F5 RID: 18677
		public const int FourStarRoleListFieldNumber = 4;

		// Token: 0x040048F6 RID: 18678
		private static readonly FieldCodec<GachaPoolDrop> _repeated_fourStarRoleList_codec = FieldCodec.ForMessage<GachaPoolDrop>(34U, GachaPoolDrop.Parser);

		// Token: 0x040048F7 RID: 18679
		private readonly RepeatedField<GachaPoolDrop> fourStarRoleList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048F8 RID: 18680
		public const int FourStarWeaponListFieldNumber = 5;

		// Token: 0x040048F9 RID: 18681
		private static readonly FieldCodec<GachaPoolDrop> _repeated_fourStarWeaponList_codec = FieldCodec.ForMessage<GachaPoolDrop>(42U, GachaPoolDrop.Parser);

		// Token: 0x040048FA RID: 18682
		private readonly RepeatedField<GachaPoolDrop> fourStarWeaponList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048FB RID: 18683
		public const int ThreeStarWeaponListFieldNumber = 6;

		// Token: 0x040048FC RID: 18684
		private static readonly FieldCodec<GachaPoolDrop> _repeated_threeStarWeaponList_codec = FieldCodec.ForMessage<GachaPoolDrop>(50U, GachaPoolDrop.Parser);

		// Token: 0x040048FD RID: 18685
		private readonly RepeatedField<GachaPoolDrop> threeStarWeaponList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048FE RID: 18686
		public const int FiveStarTitleFieldNumber = 7;

		// Token: 0x040048FF RID: 18687
		private string fiveStarTitle_ = "";

		// Token: 0x04004900 RID: 18688
		public const int FiveStarDetailFieldNumber = 8;

		// Token: 0x04004901 RID: 18689
		private string fiveStarDetail_ = "";

		// Token: 0x04004902 RID: 18690
		public const int FourStarTitleFieldNumber = 9;

		// Token: 0x04004903 RID: 18691
		private string fourStarTitle_ = "";

		// Token: 0x04004904 RID: 18692
		public const int FourStarDetailFieldNumber = 10;

		// Token: 0x04004905 RID: 18693
		private string fourStarDetail_ = "";

		// Token: 0x04004906 RID: 18694
		public const int ThreeStarTitleFieldNumber = 11;

		// Token: 0x04004907 RID: 18695
		private string threeStarTitle_ = "";

		// Token: 0x04004908 RID: 18696
		public const int ThreeStarDetailFieldNumber = 12;

		// Token: 0x04004909 RID: 18697
		private string threeStarDetail_ = "";
	}
}
