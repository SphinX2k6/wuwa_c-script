using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000681 RID: 1665
	public sealed class GachaPoolDetail : IMessage<GachaPoolDetail>, IMessage, IEquatable<GachaPoolDetail>, IDeepCloneable<GachaPoolDetail>, IBufferMessage
	{
		// Token: 0x060098E9 RID: 39145 RVA: 0x00171242 File Offset: 0x0016F442
		[NullableContext(1)]
		public static GachaPoolDetail Create()
		{
			return new GachaPoolDetail();
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x060098EA RID: 39146 RVA: 0x00171249 File Offset: 0x0016F449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x060098EB RID: 39147 RVA: 0x0017124C File Offset: 0x0016F44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolDetail.Descriptor;
			}
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x00171254 File Offset: 0x0016F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetail()
		{
		}

		// Token: 0x060098ED RID: 39149 RVA: 0x001712EC File Offset: 0x0016F4EC
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

		// Token: 0x060098EE RID: 39150 RVA: 0x001713B9 File Offset: 0x0016F5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetail Clone()
		{
			return new GachaPoolDetail(this);
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x060098EF RID: 39151 RVA: 0x001713C1 File Offset: 0x0016F5C1
		// (set) Token: 0x060098F0 RID: 39152 RVA: 0x001713C9 File Offset: 0x0016F5C9
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

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x060098F1 RID: 39153 RVA: 0x001713DC File Offset: 0x0016F5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> FiveStarRoleList
		{
			get
			{
				return this.fiveStarRoleList_;
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x060098F2 RID: 39154 RVA: 0x001713E4 File Offset: 0x0016F5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> FiveStarWeaponList
		{
			get
			{
				return this.fiveStarWeaponList_;
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x060098F3 RID: 39155 RVA: 0x001713EC File Offset: 0x0016F5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> FourStarRoleList
		{
			get
			{
				return this.fourStarRoleList_;
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x060098F4 RID: 39156 RVA: 0x001713F4 File Offset: 0x0016F5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> FourStarWeaponList
		{
			get
			{
				return this.fourStarWeaponList_;
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x060098F5 RID: 39157 RVA: 0x001713FC File Offset: 0x0016F5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolDrop> ThreeStarWeaponList
		{
			get
			{
				return this.threeStarWeaponList_;
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x060098F6 RID: 39158 RVA: 0x00171404 File Offset: 0x0016F604
		// (set) Token: 0x060098F7 RID: 39159 RVA: 0x0017140C File Offset: 0x0016F60C
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

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x060098F8 RID: 39160 RVA: 0x0017141F File Offset: 0x0016F61F
		// (set) Token: 0x060098F9 RID: 39161 RVA: 0x00171427 File Offset: 0x0016F627
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

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x060098FA RID: 39162 RVA: 0x0017143A File Offset: 0x0016F63A
		// (set) Token: 0x060098FB RID: 39163 RVA: 0x00171442 File Offset: 0x0016F642
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

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x060098FC RID: 39164 RVA: 0x00171455 File Offset: 0x0016F655
		// (set) Token: 0x060098FD RID: 39165 RVA: 0x0017145D File Offset: 0x0016F65D
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

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x060098FE RID: 39166 RVA: 0x00171470 File Offset: 0x0016F670
		// (set) Token: 0x060098FF RID: 39167 RVA: 0x00171478 File Offset: 0x0016F678
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

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06009900 RID: 39168 RVA: 0x0017148B File Offset: 0x0016F68B
		// (set) Token: 0x06009901 RID: 39169 RVA: 0x00171493 File Offset: 0x0016F693
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

		// Token: 0x06009902 RID: 39170 RVA: 0x001714A6 File Offset: 0x0016F6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolDetail);
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x001714B4 File Offset: 0x0016F6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolDetail other)
		{
			return other != null && (other == this || (!(this.Detail != other.Detail) && this.fiveStarRoleList_.Equals(other.fiveStarRoleList_) && this.fiveStarWeaponList_.Equals(other.fiveStarWeaponList_) && this.fourStarRoleList_.Equals(other.fourStarRoleList_) && this.fourStarWeaponList_.Equals(other.fourStarWeaponList_) && this.threeStarWeaponList_.Equals(other.threeStarWeaponList_) && !(this.FiveStarTitle != other.FiveStarTitle) && !(this.FiveStarDetail != other.FiveStarDetail) && !(this.FourStarTitle != other.FourStarTitle) && !(this.FourStarDetail != other.FourStarDetail) && !(this.ThreeStarTitle != other.ThreeStarTitle) && !(this.ThreeStarDetail != other.ThreeStarDetail) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x001715DC File Offset: 0x0016F7DC
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

		// Token: 0x06009905 RID: 39173 RVA: 0x00171705 File Offset: 0x0016F905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009906 RID: 39174 RVA: 0x00171712 File Offset: 0x0016F912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009907 RID: 39175 RVA: 0x0017171C File Offset: 0x0016F91C
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

		// Token: 0x06009908 RID: 39176 RVA: 0x0017187C File Offset: 0x0016FA7C
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

		// Token: 0x06009909 RID: 39177 RVA: 0x001719CC File Offset: 0x0016FBCC
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

		// Token: 0x0600990A RID: 39178 RVA: 0x00171AF8 File Offset: 0x0016FCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x00171B04 File Offset: 0x0016FD04
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

		// Token: 0x040048E5 RID: 18661
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048E6 RID: 18662
		public const int DetailFieldNumber = 1;

		// Token: 0x040048E7 RID: 18663
		private string detail_ = "";

		// Token: 0x040048E8 RID: 18664
		public const int FiveStarRoleListFieldNumber = 2;

		// Token: 0x040048E9 RID: 18665
		private static readonly FieldCodec<GachaPoolDrop> _repeated_fiveStarRoleList_codec = FieldCodec.ForMessage<GachaPoolDrop>(18U, GachaPoolDrop.Parser);

		// Token: 0x040048EA RID: 18666
		private readonly RepeatedField<GachaPoolDrop> fiveStarRoleList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048EB RID: 18667
		public const int FiveStarWeaponListFieldNumber = 3;

		// Token: 0x040048EC RID: 18668
		private static readonly FieldCodec<GachaPoolDrop> _repeated_fiveStarWeaponList_codec = FieldCodec.ForMessage<GachaPoolDrop>(26U, GachaPoolDrop.Parser);

		// Token: 0x040048ED RID: 18669
		private readonly RepeatedField<GachaPoolDrop> fiveStarWeaponList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048EE RID: 18670
		public const int FourStarRoleListFieldNumber = 4;

		// Token: 0x040048EF RID: 18671
		private static readonly FieldCodec<GachaPoolDrop> _repeated_fourStarRoleList_codec = FieldCodec.ForMessage<GachaPoolDrop>(34U, GachaPoolDrop.Parser);

		// Token: 0x040048F0 RID: 18672
		private readonly RepeatedField<GachaPoolDrop> fourStarRoleList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048F1 RID: 18673
		public const int FourStarWeaponListFieldNumber = 5;

		// Token: 0x040048F2 RID: 18674
		private static readonly FieldCodec<GachaPoolDrop> _repeated_fourStarWeaponList_codec = FieldCodec.ForMessage<GachaPoolDrop>(42U, GachaPoolDrop.Parser);

		// Token: 0x040048F3 RID: 18675
		private readonly RepeatedField<GachaPoolDrop> fourStarWeaponList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048F4 RID: 18676
		public const int ThreeStarWeaponListFieldNumber = 6;

		// Token: 0x040048F5 RID: 18677
		private static readonly FieldCodec<GachaPoolDrop> _repeated_threeStarWeaponList_codec = FieldCodec.ForMessage<GachaPoolDrop>(50U, GachaPoolDrop.Parser);

		// Token: 0x040048F6 RID: 18678
		private readonly RepeatedField<GachaPoolDrop> threeStarWeaponList_ = new RepeatedField<GachaPoolDrop>();

		// Token: 0x040048F7 RID: 18679
		public const int FiveStarTitleFieldNumber = 7;

		// Token: 0x040048F8 RID: 18680
		private string fiveStarTitle_ = "";

		// Token: 0x040048F9 RID: 18681
		public const int FiveStarDetailFieldNumber = 8;

		// Token: 0x040048FA RID: 18682
		private string fiveStarDetail_ = "";

		// Token: 0x040048FB RID: 18683
		public const int FourStarTitleFieldNumber = 9;

		// Token: 0x040048FC RID: 18684
		private string fourStarTitle_ = "";

		// Token: 0x040048FD RID: 18685
		public const int FourStarDetailFieldNumber = 10;

		// Token: 0x040048FE RID: 18686
		private string fourStarDetail_ = "";

		// Token: 0x040048FF RID: 18687
		public const int ThreeStarTitleFieldNumber = 11;

		// Token: 0x04004900 RID: 18688
		private string threeStarTitle_ = "";

		// Token: 0x04004901 RID: 18689
		public const int ThreeStarDetailFieldNumber = 12;

		// Token: 0x04004902 RID: 18690
		private string threeStarDetail_ = "";
	}
}
