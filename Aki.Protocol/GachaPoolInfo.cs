using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000685 RID: 1669
	public sealed class GachaPoolInfo : IMessage<GachaPoolInfo>, IMessage, IEquatable<GachaPoolInfo>, IDeepCloneable<GachaPoolInfo>, IBufferMessage
	{
		// Token: 0x06009949 RID: 39241 RVA: 0x0017245B File Offset: 0x0017065B
		[NullableContext(1)]
		public static GachaPoolInfo Create()
		{
			return new GachaPoolInfo();
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x0600994A RID: 39242 RVA: 0x00172462 File Offset: 0x00170662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaPoolInfo> Parser
		{
			get
			{
				return GachaPoolInfo._parser;
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x0600994B RID: 39243 RVA: 0x00172469 File Offset: 0x00170669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x0600994C RID: 39244 RVA: 0x0017246C File Offset: 0x0017066C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolInfo.Descriptor;
			}
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x00172474 File Offset: 0x00170674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolInfo()
		{
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x001724D4 File Offset: 0x001706D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolInfo(GachaPoolInfo other) : this()
		{
			this.id_ = other.id_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.title_ = other.title_;
			this.summaryDescribe_ = other.summaryDescribe_;
			this.uIType_ = other.uIType_;
			this.themeColor_ = other.themeColor_;
			this.showIdList_ = other.showIdList_.Clone();
			this.upList_ = other.upList_.Clone();
			this.previewIdList_ = other.previewIdList_.Clone();
			this.complianceDetail_ = other.complianceDetail_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x0017258B File Offset: 0x0017078B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolInfo Clone()
		{
			return new GachaPoolInfo(this);
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06009950 RID: 39248 RVA: 0x00172593 File Offset: 0x00170793
		// (set) Token: 0x06009951 RID: 39249 RVA: 0x0017259B File Offset: 0x0017079B
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

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06009952 RID: 39250 RVA: 0x001725A4 File Offset: 0x001707A4
		// (set) Token: 0x06009953 RID: 39251 RVA: 0x001725AC File Offset: 0x001707AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06009954 RID: 39252 RVA: 0x001725B5 File Offset: 0x001707B5
		// (set) Token: 0x06009955 RID: 39253 RVA: 0x001725BD File Offset: 0x001707BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x06009956 RID: 39254 RVA: 0x001725C6 File Offset: 0x001707C6
		// (set) Token: 0x06009957 RID: 39255 RVA: 0x001725CE File Offset: 0x001707CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Title
		{
			get
			{
				return this.title_;
			}
			set
			{
				this.title_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x06009958 RID: 39256 RVA: 0x001725E1 File Offset: 0x001707E1
		// (set) Token: 0x06009959 RID: 39257 RVA: 0x001725E9 File Offset: 0x001707E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SummaryDescribe
		{
			get
			{
				return this.summaryDescribe_;
			}
			set
			{
				this.summaryDescribe_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x0600995A RID: 39258 RVA: 0x001725FC File Offset: 0x001707FC
		// (set) Token: 0x0600995B RID: 39259 RVA: 0x00172604 File Offset: 0x00170804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UIType
		{
			get
			{
				return this.uIType_;
			}
			set
			{
				this.uIType_ = value;
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x0600995C RID: 39260 RVA: 0x0017260D File Offset: 0x0017080D
		// (set) Token: 0x0600995D RID: 39261 RVA: 0x00172615 File Offset: 0x00170815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ThemeColor
		{
			get
			{
				return this.themeColor_;
			}
			set
			{
				this.themeColor_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x0600995E RID: 39262 RVA: 0x00172628 File Offset: 0x00170828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ShowIdList
		{
			get
			{
				return this.showIdList_;
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x0600995F RID: 39263 RVA: 0x00172630 File Offset: 0x00170830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UpList
		{
			get
			{
				return this.upList_;
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06009960 RID: 39264 RVA: 0x00172638 File Offset: 0x00170838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreviewIdList
		{
			get
			{
				return this.previewIdList_;
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06009961 RID: 39265 RVA: 0x00172640 File Offset: 0x00170840
		// (set) Token: 0x06009962 RID: 39266 RVA: 0x00172648 File Offset: 0x00170848
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

		// Token: 0x06009963 RID: 39267 RVA: 0x0017265B File Offset: 0x0017085B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolInfo);
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x0017266C File Offset: 0x0017086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && !(this.Title != other.Title) && !(this.SummaryDescribe != other.SummaryDescribe) && this.UIType == other.UIType && !(this.ThemeColor != other.ThemeColor) && this.showIdList_.Equals(other.showIdList_) && this.upList_.Equals(other.upList_) && this.previewIdList_.Equals(other.previewIdList_) && !(this.ComplianceDetail != other.ComplianceDetail) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009965 RID: 39269 RVA: 0x00172768 File Offset: 0x00170968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.Title.Length != 0)
			{
				num ^= this.Title.GetHashCode();
			}
			if (this.SummaryDescribe.Length != 0)
			{
				num ^= this.SummaryDescribe.GetHashCode();
			}
			if (this.UIType != 0)
			{
				num ^= this.UIType.GetHashCode();
			}
			if (this.ThemeColor.Length != 0)
			{
				num ^= this.ThemeColor.GetHashCode();
			}
			num ^= this.showIdList_.GetHashCode();
			num ^= this.upList_.GetHashCode();
			num ^= this.previewIdList_.GetHashCode();
			if (this.ComplianceDetail.Length != 0)
			{
				num ^= this.ComplianceDetail.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009966 RID: 39270 RVA: 0x00172888 File Offset: 0x00170A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009967 RID: 39271 RVA: 0x00172895 File Offset: 0x00170A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x001728A0 File Offset: 0x00170AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			if (this.Title.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Title);
			}
			if (this.SummaryDescribe.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.SummaryDescribe);
			}
			if (this.UIType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UIType);
			}
			if (this.ThemeColor.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.ThemeColor);
			}
			this.showIdList_.WriteTo(ref output, GachaPoolInfo._repeated_showIdList_codec);
			this.upList_.WriteTo(ref output, GachaPoolInfo._repeated_upList_codec);
			this.previewIdList_.WriteTo(ref output, GachaPoolInfo._repeated_previewIdList_codec);
			if (this.ComplianceDetail.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ComplianceDetail);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009969 RID: 39273 RVA: 0x001729E8 File Offset: 0x00170BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.Title.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Title);
			}
			if (this.SummaryDescribe.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SummaryDescribe);
			}
			if (this.UIType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UIType);
			}
			if (this.ThemeColor.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ThemeColor);
			}
			num += this.showIdList_.CalculateSize(GachaPoolInfo._repeated_showIdList_codec);
			num += this.upList_.CalculateSize(GachaPoolInfo._repeated_upList_codec);
			num += this.previewIdList_.CalculateSize(GachaPoolInfo._repeated_previewIdList_codec);
			if (this.ComplianceDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ComplianceDetail);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x00172B1C File Offset: 0x00170D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaPoolInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.Title.Length != 0)
			{
				this.Title = other.Title;
			}
			if (other.SummaryDescribe.Length != 0)
			{
				this.SummaryDescribe = other.SummaryDescribe;
			}
			if (other.UIType != 0)
			{
				this.UIType = other.UIType;
			}
			if (other.ThemeColor.Length != 0)
			{
				this.ThemeColor = other.ThemeColor;
			}
			this.showIdList_.Add(other.showIdList_);
			this.upList_.Add(other.upList_);
			this.previewIdList_.Add(other.previewIdList_);
			if (other.ComplianceDetail.Length != 0)
			{
				this.ComplianceDetail = other.ComplianceDetail;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600996B RID: 39275 RVA: 0x00172C2B File Offset: 0x00170E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600996C RID: 39276 RVA: 0x00172C34 File Offset: 0x00170E34
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
				if (num > 58U)
				{
					if (num > 72U)
					{
						if (num <= 80U)
						{
							if (num == 74U)
							{
								goto IL_130;
							}
							if (num != 80U)
							{
								goto IL_9E;
							}
						}
						else if (num != 82U)
						{
							if (num != 90U)
							{
								goto IL_9E;
							}
							this.ComplianceDetail = input.ReadString();
							continue;
						}
						this.previewIdList_.AddEntriesFrom(ref input, GachaPoolInfo._repeated_previewIdList_codec);
						continue;
					}
					if (num == 64U || num == 66U)
					{
						this.showIdList_.AddEntriesFrom(ref input, GachaPoolInfo._repeated_showIdList_codec);
						continue;
					}
					if (num != 72U)
					{
						goto IL_9E;
					}
					IL_130:
					this.upList_.AddEntriesFrom(ref input, GachaPoolInfo._repeated_upList_codec);
					continue;
				}
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.BeginTime = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						this.Title = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.SummaryDescribe = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.UIType = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						this.ThemeColor = input.ReadString();
						continue;
					}
				}
				IL_9E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004911 RID: 18705
		private static readonly MessageParser<GachaPoolInfo> _parser = new MessageParser<GachaPoolInfo>(() => new GachaPoolInfo());

		// Token: 0x04004912 RID: 18706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004913 RID: 18707
		public const int IdFieldNumber = 1;

		// Token: 0x04004914 RID: 18708
		private int id_;

		// Token: 0x04004915 RID: 18709
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x04004916 RID: 18710
		private long beginTime_;

		// Token: 0x04004917 RID: 18711
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04004918 RID: 18712
		private long endTime_;

		// Token: 0x04004919 RID: 18713
		public const int TitleFieldNumber = 4;

		// Token: 0x0400491A RID: 18714
		private string title_ = "";

		// Token: 0x0400491B RID: 18715
		public const int SummaryDescribeFieldNumber = 5;

		// Token: 0x0400491C RID: 18716
		private string summaryDescribe_ = "";

		// Token: 0x0400491D RID: 18717
		public const int UITypeFieldNumber = 6;

		// Token: 0x0400491E RID: 18718
		private int uIType_;

		// Token: 0x0400491F RID: 18719
		public const int ThemeColorFieldNumber = 7;

		// Token: 0x04004920 RID: 18720
		private string themeColor_ = "";

		// Token: 0x04004921 RID: 18721
		public const int ShowIdListFieldNumber = 8;

		// Token: 0x04004922 RID: 18722
		private static readonly FieldCodec<int> _repeated_showIdList_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04004923 RID: 18723
		private readonly RepeatedField<int> showIdList_ = new RepeatedField<int>();

		// Token: 0x04004924 RID: 18724
		public const int UpListFieldNumber = 9;

		// Token: 0x04004925 RID: 18725
		private static readonly FieldCodec<int> _repeated_upList_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04004926 RID: 18726
		private readonly RepeatedField<int> upList_ = new RepeatedField<int>();

		// Token: 0x04004927 RID: 18727
		public const int PreviewIdListFieldNumber = 10;

		// Token: 0x04004928 RID: 18728
		private static readonly FieldCodec<int> _repeated_previewIdList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04004929 RID: 18729
		private readonly RepeatedField<int> previewIdList_ = new RepeatedField<int>();

		// Token: 0x0400492A RID: 18730
		public const int ComplianceDetailFieldNumber = 11;

		// Token: 0x0400492B RID: 18731
		private string complianceDetail_ = "";
	}
}
