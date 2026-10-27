using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000699 RID: 1689
	public sealed class GachaPoolInfo : IMessage<GachaPoolInfo>, IMessage, IEquatable<GachaPoolInfo>, IDeepCloneable<GachaPoolInfo>, IBufferMessage
	{
		// Token: 0x06009A9F RID: 39583 RVA: 0x00174E8F File Offset: 0x0017308F
		[NullableContext(1)]
		public static GachaPoolInfo Create()
		{
			return new GachaPoolInfo();
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06009AA0 RID: 39584 RVA: 0x00174E96 File Offset: 0x00173096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaPoolInfo> Parser
		{
			get
			{
				return GachaPoolInfo._parser;
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06009AA1 RID: 39585 RVA: 0x00174E9D File Offset: 0x0017309D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06009AA2 RID: 39586 RVA: 0x00174EA0 File Offset: 0x001730A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolInfo.Descriptor;
			}
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x00174EA8 File Offset: 0x001730A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolInfo()
		{
		}

		// Token: 0x06009AA4 RID: 39588 RVA: 0x00174F08 File Offset: 0x00173108
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

		// Token: 0x06009AA5 RID: 39589 RVA: 0x00174FBF File Offset: 0x001731BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolInfo Clone()
		{
			return new GachaPoolInfo(this);
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x06009AA6 RID: 39590 RVA: 0x00174FC7 File Offset: 0x001731C7
		// (set) Token: 0x06009AA7 RID: 39591 RVA: 0x00174FCF File Offset: 0x001731CF
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

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x06009AA8 RID: 39592 RVA: 0x00174FD8 File Offset: 0x001731D8
		// (set) Token: 0x06009AA9 RID: 39593 RVA: 0x00174FE0 File Offset: 0x001731E0
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

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x06009AAA RID: 39594 RVA: 0x00174FE9 File Offset: 0x001731E9
		// (set) Token: 0x06009AAB RID: 39595 RVA: 0x00174FF1 File Offset: 0x001731F1
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

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06009AAC RID: 39596 RVA: 0x00174FFA File Offset: 0x001731FA
		// (set) Token: 0x06009AAD RID: 39597 RVA: 0x00175002 File Offset: 0x00173202
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

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06009AAE RID: 39598 RVA: 0x00175015 File Offset: 0x00173215
		// (set) Token: 0x06009AAF RID: 39599 RVA: 0x0017501D File Offset: 0x0017321D
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

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x06009AB0 RID: 39600 RVA: 0x00175030 File Offset: 0x00173230
		// (set) Token: 0x06009AB1 RID: 39601 RVA: 0x00175038 File Offset: 0x00173238
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

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x06009AB2 RID: 39602 RVA: 0x00175041 File Offset: 0x00173241
		// (set) Token: 0x06009AB3 RID: 39603 RVA: 0x00175049 File Offset: 0x00173249
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

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06009AB4 RID: 39604 RVA: 0x0017505C File Offset: 0x0017325C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ShowIdList
		{
			get
			{
				return this.showIdList_;
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x06009AB5 RID: 39605 RVA: 0x00175064 File Offset: 0x00173264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UpList
		{
			get
			{
				return this.upList_;
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06009AB6 RID: 39606 RVA: 0x0017506C File Offset: 0x0017326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreviewIdList
		{
			get
			{
				return this.previewIdList_;
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06009AB7 RID: 39607 RVA: 0x00175074 File Offset: 0x00173274
		// (set) Token: 0x06009AB8 RID: 39608 RVA: 0x0017507C File Offset: 0x0017327C
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

		// Token: 0x06009AB9 RID: 39609 RVA: 0x0017508F File Offset: 0x0017328F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolInfo);
		}

		// Token: 0x06009ABA RID: 39610 RVA: 0x001750A0 File Offset: 0x001732A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && !(this.Title != other.Title) && !(this.SummaryDescribe != other.SummaryDescribe) && this.UIType == other.UIType && !(this.ThemeColor != other.ThemeColor) && this.showIdList_.Equals(other.showIdList_) && this.upList_.Equals(other.upList_) && this.previewIdList_.Equals(other.previewIdList_) && !(this.ComplianceDetail != other.ComplianceDetail) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009ABB RID: 39611 RVA: 0x0017519C File Offset: 0x0017339C
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

		// Token: 0x06009ABC RID: 39612 RVA: 0x001752BC File Offset: 0x001734BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x001752C9 File Offset: 0x001734C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009ABE RID: 39614 RVA: 0x001752D4 File Offset: 0x001734D4
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

		// Token: 0x06009ABF RID: 39615 RVA: 0x0017541C File Offset: 0x0017361C
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

		// Token: 0x06009AC0 RID: 39616 RVA: 0x00175550 File Offset: 0x00173750
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

		// Token: 0x06009AC1 RID: 39617 RVA: 0x0017565F File Offset: 0x0017385F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x00175668 File Offset: 0x00173868
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

		// Token: 0x04004918 RID: 18712
		private static readonly MessageParser<GachaPoolInfo> _parser = new MessageParser<GachaPoolInfo>(() => new GachaPoolInfo());

		// Token: 0x04004919 RID: 18713
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400491A RID: 18714
		public const int IdFieldNumber = 1;

		// Token: 0x0400491B RID: 18715
		private int id_;

		// Token: 0x0400491C RID: 18716
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x0400491D RID: 18717
		private long beginTime_;

		// Token: 0x0400491E RID: 18718
		public const int EndTimeFieldNumber = 3;

		// Token: 0x0400491F RID: 18719
		private long endTime_;

		// Token: 0x04004920 RID: 18720
		public const int TitleFieldNumber = 4;

		// Token: 0x04004921 RID: 18721
		private string title_ = "";

		// Token: 0x04004922 RID: 18722
		public const int SummaryDescribeFieldNumber = 5;

		// Token: 0x04004923 RID: 18723
		private string summaryDescribe_ = "";

		// Token: 0x04004924 RID: 18724
		public const int UITypeFieldNumber = 6;

		// Token: 0x04004925 RID: 18725
		private int uIType_;

		// Token: 0x04004926 RID: 18726
		public const int ThemeColorFieldNumber = 7;

		// Token: 0x04004927 RID: 18727
		private string themeColor_ = "";

		// Token: 0x04004928 RID: 18728
		public const int ShowIdListFieldNumber = 8;

		// Token: 0x04004929 RID: 18729
		private static readonly FieldCodec<int> _repeated_showIdList_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400492A RID: 18730
		private readonly RepeatedField<int> showIdList_ = new RepeatedField<int>();

		// Token: 0x0400492B RID: 18731
		public const int UpListFieldNumber = 9;

		// Token: 0x0400492C RID: 18732
		private static readonly FieldCodec<int> _repeated_upList_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400492D RID: 18733
		private readonly RepeatedField<int> upList_ = new RepeatedField<int>();

		// Token: 0x0400492E RID: 18734
		public const int PreviewIdListFieldNumber = 10;

		// Token: 0x0400492F RID: 18735
		private static readonly FieldCodec<int> _repeated_previewIdList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04004930 RID: 18736
		private readonly RepeatedField<int> previewIdList_ = new RepeatedField<int>();

		// Token: 0x04004931 RID: 18737
		public const int ComplianceDetailFieldNumber = 11;

		// Token: 0x04004932 RID: 18738
		private string complianceDetail_ = "";
	}
}
