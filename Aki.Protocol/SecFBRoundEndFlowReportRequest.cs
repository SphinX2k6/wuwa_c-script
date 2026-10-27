using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AC RID: 4524
	[NetMessage(EMessageId.SecFBRoundEndFlowReportRequest)]
	public sealed class SecFBRoundEndFlowReportRequest : IMessage<SecFBRoundEndFlowReportRequest>, IMessage, IEquatable<SecFBRoundEndFlowReportRequest>, IDeepCloneable<SecFBRoundEndFlowReportRequest>, IBufferMessage
	{
		// Token: 0x060181B3 RID: 98739 RVA: 0x003803D7 File Offset: 0x0037E5D7
		[NullableContext(1)]
		public static SecFBRoundEndFlowReportRequest Create()
		{
			return new SecFBRoundEndFlowReportRequest();
		}

		// Token: 0x17005108 RID: 20744
		// (get) Token: 0x060181B4 RID: 98740 RVA: 0x003803DE File Offset: 0x0037E5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005109 RID: 20745
		// (get) Token: 0x060181B5 RID: 98741 RVA: 0x003803E1 File Offset: 0x0037E5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecFBRoundEndFlowReportRequest.Descriptor;
			}
		}

		// Token: 0x060181B6 RID: 98742 RVA: 0x003803E8 File Offset: 0x0037E5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportRequest()
		{
		}

		// Token: 0x060181B7 RID: 98743 RVA: 0x003803FC File Offset: 0x0037E5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportRequest(SecFBRoundEndFlowReportRequest other) : this()
		{
			this.logId_ = other.logId_;
			this.clientEndTime_ = other.clientEndTime_;
			this.roundTimeUse_ = other.roundTimeUse_;
			this.speedMax_ = other.speedMax_;
			this.speedMin_ = other.speedMin_;
			this.sprintMax_ = other.sprintMax_;
			this.sprintMin_ = other.sprintMin_;
			this.speedAvg_ = other.speedAvg_;
			this.pSReplyTotal_ = other.pSReplyTotal_;
			this.pSCostTotal_ = other.pSCostTotal_;
			this.pSReplySpeedMax_ = other.pSReplySpeedMax_;
			this.pSReplySpeedMin_ = other.pSReplySpeedMin_;
			this.pSUseCount_ = other.pSUseCount_;
			this.pSUseNumMax_ = other.pSUseNumMax_;
			this.pSUseNumMin_ = other.pSUseNumMin_;
			this.comboMax_ = other.comboMax_;
			this.itemGetCount_ = other.itemGetCount_;
			this.itemGetDistanceMax_ = other.itemGetDistanceMax_;
			this.itemGetDistanceMin_ = other.itemGetDistanceMin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060181B8 RID: 98744 RVA: 0x00380504 File Offset: 0x0037E704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportRequest Clone()
		{
			return new SecFBRoundEndFlowReportRequest(this);
		}

		// Token: 0x1700510A RID: 20746
		// (get) Token: 0x060181B9 RID: 98745 RVA: 0x0038050C File Offset: 0x0037E70C
		// (set) Token: 0x060181BA RID: 98746 RVA: 0x00380514 File Offset: 0x0037E714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x1700510B RID: 20747
		// (get) Token: 0x060181BB RID: 98747 RVA: 0x0038051D File Offset: 0x0037E71D
		// (set) Token: 0x060181BC RID: 98748 RVA: 0x00380525 File Offset: 0x0037E725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientEndTime
		{
			get
			{
				return this.clientEndTime_;
			}
			set
			{
				this.clientEndTime_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700510C RID: 20748
		// (get) Token: 0x060181BD RID: 98749 RVA: 0x00380538 File Offset: 0x0037E738
		// (set) Token: 0x060181BE RID: 98750 RVA: 0x00380540 File Offset: 0x0037E740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RoundTimeUse
		{
			get
			{
				return this.roundTimeUse_;
			}
			set
			{
				this.roundTimeUse_ = value;
			}
		}

		// Token: 0x1700510D RID: 20749
		// (get) Token: 0x060181BF RID: 98751 RVA: 0x00380549 File Offset: 0x0037E749
		// (set) Token: 0x060181C0 RID: 98752 RVA: 0x00380551 File Offset: 0x0037E751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpeedMax
		{
			get
			{
				return this.speedMax_;
			}
			set
			{
				this.speedMax_ = value;
			}
		}

		// Token: 0x1700510E RID: 20750
		// (get) Token: 0x060181C1 RID: 98753 RVA: 0x0038055A File Offset: 0x0037E75A
		// (set) Token: 0x060181C2 RID: 98754 RVA: 0x00380562 File Offset: 0x0037E762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpeedMin
		{
			get
			{
				return this.speedMin_;
			}
			set
			{
				this.speedMin_ = value;
			}
		}

		// Token: 0x1700510F RID: 20751
		// (get) Token: 0x060181C3 RID: 98755 RVA: 0x0038056B File Offset: 0x0037E76B
		// (set) Token: 0x060181C4 RID: 98756 RVA: 0x00380573 File Offset: 0x0037E773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SprintMax
		{
			get
			{
				return this.sprintMax_;
			}
			set
			{
				this.sprintMax_ = value;
			}
		}

		// Token: 0x17005110 RID: 20752
		// (get) Token: 0x060181C5 RID: 98757 RVA: 0x0038057C File Offset: 0x0037E77C
		// (set) Token: 0x060181C6 RID: 98758 RVA: 0x00380584 File Offset: 0x0037E784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SprintMin
		{
			get
			{
				return this.sprintMin_;
			}
			set
			{
				this.sprintMin_ = value;
			}
		}

		// Token: 0x17005111 RID: 20753
		// (get) Token: 0x060181C7 RID: 98759 RVA: 0x0038058D File Offset: 0x0037E78D
		// (set) Token: 0x060181C8 RID: 98760 RVA: 0x00380595 File Offset: 0x0037E795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpeedAvg
		{
			get
			{
				return this.speedAvg_;
			}
			set
			{
				this.speedAvg_ = value;
			}
		}

		// Token: 0x17005112 RID: 20754
		// (get) Token: 0x060181C9 RID: 98761 RVA: 0x0038059E File Offset: 0x0037E79E
		// (set) Token: 0x060181CA RID: 98762 RVA: 0x003805A6 File Offset: 0x0037E7A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PSReplyTotal
		{
			get
			{
				return this.pSReplyTotal_;
			}
			set
			{
				this.pSReplyTotal_ = value;
			}
		}

		// Token: 0x17005113 RID: 20755
		// (get) Token: 0x060181CB RID: 98763 RVA: 0x003805AF File Offset: 0x0037E7AF
		// (set) Token: 0x060181CC RID: 98764 RVA: 0x003805B7 File Offset: 0x0037E7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PSCostTotal
		{
			get
			{
				return this.pSCostTotal_;
			}
			set
			{
				this.pSCostTotal_ = value;
			}
		}

		// Token: 0x17005114 RID: 20756
		// (get) Token: 0x060181CD RID: 98765 RVA: 0x003805C0 File Offset: 0x0037E7C0
		// (set) Token: 0x060181CE RID: 98766 RVA: 0x003805C8 File Offset: 0x0037E7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PSReplySpeedMax
		{
			get
			{
				return this.pSReplySpeedMax_;
			}
			set
			{
				this.pSReplySpeedMax_ = value;
			}
		}

		// Token: 0x17005115 RID: 20757
		// (get) Token: 0x060181CF RID: 98767 RVA: 0x003805D1 File Offset: 0x0037E7D1
		// (set) Token: 0x060181D0 RID: 98768 RVA: 0x003805D9 File Offset: 0x0037E7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PSReplySpeedMin
		{
			get
			{
				return this.pSReplySpeedMin_;
			}
			set
			{
				this.pSReplySpeedMin_ = value;
			}
		}

		// Token: 0x17005116 RID: 20758
		// (get) Token: 0x060181D1 RID: 98769 RVA: 0x003805E2 File Offset: 0x0037E7E2
		// (set) Token: 0x060181D2 RID: 98770 RVA: 0x003805EA File Offset: 0x0037E7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PSUseCount
		{
			get
			{
				return this.pSUseCount_;
			}
			set
			{
				this.pSUseCount_ = value;
			}
		}

		// Token: 0x17005117 RID: 20759
		// (get) Token: 0x060181D3 RID: 98771 RVA: 0x003805F3 File Offset: 0x0037E7F3
		// (set) Token: 0x060181D4 RID: 98772 RVA: 0x003805FB File Offset: 0x0037E7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PSUseNumMax
		{
			get
			{
				return this.pSUseNumMax_;
			}
			set
			{
				this.pSUseNumMax_ = value;
			}
		}

		// Token: 0x17005118 RID: 20760
		// (get) Token: 0x060181D5 RID: 98773 RVA: 0x00380604 File Offset: 0x0037E804
		// (set) Token: 0x060181D6 RID: 98774 RVA: 0x0038060C File Offset: 0x0037E80C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PSUseNumMin
		{
			get
			{
				return this.pSUseNumMin_;
			}
			set
			{
				this.pSUseNumMin_ = value;
			}
		}

		// Token: 0x17005119 RID: 20761
		// (get) Token: 0x060181D7 RID: 98775 RVA: 0x00380615 File Offset: 0x0037E815
		// (set) Token: 0x060181D8 RID: 98776 RVA: 0x0038061D File Offset: 0x0037E81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ComboMax
		{
			get
			{
				return this.comboMax_;
			}
			set
			{
				this.comboMax_ = value;
			}
		}

		// Token: 0x1700511A RID: 20762
		// (get) Token: 0x060181D9 RID: 98777 RVA: 0x00380626 File Offset: 0x0037E826
		// (set) Token: 0x060181DA RID: 98778 RVA: 0x0038062E File Offset: 0x0037E82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemGetCount
		{
			get
			{
				return this.itemGetCount_;
			}
			set
			{
				this.itemGetCount_ = value;
			}
		}

		// Token: 0x1700511B RID: 20763
		// (get) Token: 0x060181DB RID: 98779 RVA: 0x00380637 File Offset: 0x0037E837
		// (set) Token: 0x060181DC RID: 98780 RVA: 0x0038063F File Offset: 0x0037E83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemGetDistanceMax
		{
			get
			{
				return this.itemGetDistanceMax_;
			}
			set
			{
				this.itemGetDistanceMax_ = value;
			}
		}

		// Token: 0x1700511C RID: 20764
		// (get) Token: 0x060181DD RID: 98781 RVA: 0x00380648 File Offset: 0x0037E848
		// (set) Token: 0x060181DE RID: 98782 RVA: 0x00380650 File Offset: 0x0037E850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemGetDistanceMin
		{
			get
			{
				return this.itemGetDistanceMin_;
			}
			set
			{
				this.itemGetDistanceMin_ = value;
			}
		}

		// Token: 0x060181DF RID: 98783 RVA: 0x00380659 File Offset: 0x0037E859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecFBRoundEndFlowReportRequest);
		}

		// Token: 0x060181E0 RID: 98784 RVA: 0x00380668 File Offset: 0x0037E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecFBRoundEndFlowReportRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientEndTime != other.ClientEndTime) && this.RoundTimeUse == other.RoundTimeUse && this.SpeedMax == other.SpeedMax && this.SpeedMin == other.SpeedMin && this.SprintMax == other.SprintMax && this.SprintMin == other.SprintMin && this.SpeedAvg == other.SpeedAvg && this.PSReplyTotal == other.PSReplyTotal && this.PSCostTotal == other.PSCostTotal && this.PSReplySpeedMax == other.PSReplySpeedMax && this.PSReplySpeedMin == other.PSReplySpeedMin && this.PSUseCount == other.PSUseCount && this.PSUseNumMax == other.PSUseNumMax && this.PSUseNumMin == other.PSUseNumMin && this.ComboMax == other.ComboMax && this.ItemGetCount == other.ItemGetCount && this.ItemGetDistanceMax == other.ItemGetDistanceMax && this.ItemGetDistanceMin == other.ItemGetDistanceMin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060181E1 RID: 98785 RVA: 0x003807C8 File Offset: 0x0037E9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.ClientEndTime.Length != 0)
			{
				num ^= this.ClientEndTime.GetHashCode();
			}
			if (this.RoundTimeUse != 0L)
			{
				num ^= this.RoundTimeUse.GetHashCode();
			}
			if (this.SpeedMax != 0)
			{
				num ^= this.SpeedMax.GetHashCode();
			}
			if (this.SpeedMin != 0)
			{
				num ^= this.SpeedMin.GetHashCode();
			}
			if (this.SprintMax != 0)
			{
				num ^= this.SprintMax.GetHashCode();
			}
			if (this.SprintMin != 0)
			{
				num ^= this.SprintMin.GetHashCode();
			}
			if (this.SpeedAvg != 0)
			{
				num ^= this.SpeedAvg.GetHashCode();
			}
			if (this.PSReplyTotal != 0L)
			{
				num ^= this.PSReplyTotal.GetHashCode();
			}
			if (this.PSCostTotal != 0L)
			{
				num ^= this.PSCostTotal.GetHashCode();
			}
			if (this.PSReplySpeedMax != 0)
			{
				num ^= this.PSReplySpeedMax.GetHashCode();
			}
			if (this.PSReplySpeedMin != 0)
			{
				num ^= this.PSReplySpeedMin.GetHashCode();
			}
			if (this.PSUseCount != 0)
			{
				num ^= this.PSUseCount.GetHashCode();
			}
			if (this.PSUseNumMax != 0)
			{
				num ^= this.PSUseNumMax.GetHashCode();
			}
			if (this.PSUseNumMin != 0)
			{
				num ^= this.PSUseNumMin.GetHashCode();
			}
			if (this.ComboMax != 0)
			{
				num ^= this.ComboMax.GetHashCode();
			}
			if (this.ItemGetCount != 0)
			{
				num ^= this.ItemGetCount.GetHashCode();
			}
			if (this.ItemGetDistanceMax != 0)
			{
				num ^= this.ItemGetDistanceMax.GetHashCode();
			}
			if (this.ItemGetDistanceMin != 0)
			{
				num ^= this.ItemGetDistanceMin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060181E2 RID: 98786 RVA: 0x003809CB File Offset: 0x0037EBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060181E3 RID: 98787 RVA: 0x003809D8 File Offset: 0x0037EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060181E4 RID: 98788 RVA: 0x003809E4 File Offset: 0x0037EBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SprintMin != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SprintMin);
			}
			if (this.ClientEndTime.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.ClientEndTime);
			}
			if (this.SprintMax != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.SprintMax);
			}
			if (this.PSCostTotal != 0L)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt64(this.PSCostTotal);
			}
			if (this.PSUseCount != 0)
			{
				output.WriteRawTag(208, 1);
				output.WriteInt32(this.PSUseCount);
			}
			if (this.PSReplySpeedMax != 0)
			{
				output.WriteRawTag(184, 2);
				output.WriteInt32(this.PSReplySpeedMax);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(152, 3);
				output.WriteInt64(this.LogId);
			}
			if (this.ComboMax != 0)
			{
				output.WriteRawTag(176, 4);
				output.WriteInt32(this.ComboMax);
			}
			if (this.ItemGetCount != 0)
			{
				output.WriteRawTag(224, 6);
				output.WriteInt32(this.ItemGetCount);
			}
			if (this.SpeedMin != 0)
			{
				output.WriteRawTag(144, 7);
				output.WriteInt32(this.SpeedMin);
			}
			if (this.RoundTimeUse != 0L)
			{
				output.WriteRawTag(144, 8);
				output.WriteInt64(this.RoundTimeUse);
			}
			if (this.PSReplySpeedMin != 0)
			{
				output.WriteRawTag(152, 11);
				output.WriteInt32(this.PSReplySpeedMin);
			}
			if (this.ItemGetDistanceMax != 0)
			{
				output.WriteRawTag(200, 11);
				output.WriteInt32(this.ItemGetDistanceMax);
			}
			if (this.PSReplyTotal != 0L)
			{
				output.WriteRawTag(136, 13);
				output.WriteInt64(this.PSReplyTotal);
			}
			if (this.PSUseNumMin != 0)
			{
				output.WriteRawTag(176, 13);
				output.WriteInt32(this.PSUseNumMin);
			}
			if (this.PSUseNumMax != 0)
			{
				output.WriteRawTag(200, 13);
				output.WriteInt32(this.PSUseNumMax);
			}
			if (this.SpeedMax != 0)
			{
				output.WriteRawTag(232, 14);
				output.WriteInt32(this.SpeedMax);
			}
			if (this.ItemGetDistanceMin != 0)
			{
				output.WriteRawTag(216, 15);
				output.WriteInt32(this.ItemGetDistanceMin);
			}
			if (this.SpeedAvg != 0)
			{
				output.WriteRawTag(224, 15);
				output.WriteInt32(this.SpeedAvg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060181E5 RID: 98789 RVA: 0x00380C6C File Offset: 0x0037EE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.ClientEndTime.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientEndTime);
			}
			if (this.RoundTimeUse != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.RoundTimeUse);
			}
			if (this.SpeedMax != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SpeedMax);
			}
			if (this.SpeedMin != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SpeedMin);
			}
			if (this.SprintMax != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SprintMax);
			}
			if (this.SprintMin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SprintMin);
			}
			if (this.SpeedAvg != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SpeedAvg);
			}
			if (this.PSReplyTotal != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.PSReplyTotal);
			}
			if (this.PSCostTotal != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.PSCostTotal);
			}
			if (this.PSReplySpeedMax != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PSReplySpeedMax);
			}
			if (this.PSReplySpeedMin != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PSReplySpeedMin);
			}
			if (this.PSUseCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PSUseCount);
			}
			if (this.PSUseNumMax != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PSUseNumMax);
			}
			if (this.PSUseNumMin != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PSUseNumMin);
			}
			if (this.ComboMax != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ComboMax);
			}
			if (this.ItemGetCount != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ItemGetCount);
			}
			if (this.ItemGetDistanceMax != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ItemGetDistanceMax);
			}
			if (this.ItemGetDistanceMin != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ItemGetDistanceMin);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060181E6 RID: 98790 RVA: 0x00380E60 File Offset: 0x0037F060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecFBRoundEndFlowReportRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.ClientEndTime.Length != 0)
			{
				this.ClientEndTime = other.ClientEndTime;
			}
			if (other.RoundTimeUse != 0L)
			{
				this.RoundTimeUse = other.RoundTimeUse;
			}
			if (other.SpeedMax != 0)
			{
				this.SpeedMax = other.SpeedMax;
			}
			if (other.SpeedMin != 0)
			{
				this.SpeedMin = other.SpeedMin;
			}
			if (other.SprintMax != 0)
			{
				this.SprintMax = other.SprintMax;
			}
			if (other.SprintMin != 0)
			{
				this.SprintMin = other.SprintMin;
			}
			if (other.SpeedAvg != 0)
			{
				this.SpeedAvg = other.SpeedAvg;
			}
			if (other.PSReplyTotal != 0L)
			{
				this.PSReplyTotal = other.PSReplyTotal;
			}
			if (other.PSCostTotal != 0L)
			{
				this.PSCostTotal = other.PSCostTotal;
			}
			if (other.PSReplySpeedMax != 0)
			{
				this.PSReplySpeedMax = other.PSReplySpeedMax;
			}
			if (other.PSReplySpeedMin != 0)
			{
				this.PSReplySpeedMin = other.PSReplySpeedMin;
			}
			if (other.PSUseCount != 0)
			{
				this.PSUseCount = other.PSUseCount;
			}
			if (other.PSUseNumMax != 0)
			{
				this.PSUseNumMax = other.PSUseNumMax;
			}
			if (other.PSUseNumMin != 0)
			{
				this.PSUseNumMin = other.PSUseNumMin;
			}
			if (other.ComboMax != 0)
			{
				this.ComboMax = other.ComboMax;
			}
			if (other.ItemGetCount != 0)
			{
				this.ItemGetCount = other.ItemGetCount;
			}
			if (other.ItemGetDistanceMax != 0)
			{
				this.ItemGetDistanceMax = other.ItemGetDistanceMax;
			}
			if (other.ItemGetDistanceMin != 0)
			{
				this.ItemGetDistanceMin = other.ItemGetDistanceMin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060181E7 RID: 98791 RVA: 0x00381009 File Offset: 0x0037F209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060181E8 RID: 98792 RVA: 0x00381014 File Offset: 0x0037F214
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
				if (num <= 864U)
				{
					if (num <= 168U)
					{
						if (num <= 114U)
						{
							if (num == 8U)
							{
								this.SprintMin = input.ReadInt32();
								continue;
							}
							if (num == 114U)
							{
								this.ClientEndTime = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 136U)
							{
								this.SprintMax = input.ReadInt32();
								continue;
							}
							if (num == 168U)
							{
								this.PSCostTotal = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 312U)
					{
						if (num == 208U)
						{
							this.PSUseCount = input.ReadInt32();
							continue;
						}
						if (num == 312U)
						{
							this.PSReplySpeedMax = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 408U)
						{
							this.LogId = input.ReadInt64();
							continue;
						}
						if (num == 560U)
						{
							this.ComboMax = input.ReadInt32();
							continue;
						}
						if (num == 864U)
						{
							this.ItemGetCount = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1672U)
				{
					if (num <= 1040U)
					{
						if (num == 912U)
						{
							this.SpeedMin = input.ReadInt32();
							continue;
						}
						if (num == 1040U)
						{
							this.RoundTimeUse = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 1432U)
						{
							this.PSReplySpeedMin = input.ReadInt32();
							continue;
						}
						if (num == 1480U)
						{
							this.ItemGetDistanceMax = input.ReadInt32();
							continue;
						}
						if (num == 1672U)
						{
							this.PSReplyTotal = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 1736U)
				{
					if (num == 1712U)
					{
						this.PSUseNumMin = input.ReadInt32();
						continue;
					}
					if (num == 1736U)
					{
						this.PSUseNumMax = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 1896U)
					{
						this.SpeedMax = input.ReadInt32();
						continue;
					}
					if (num == 2008U)
					{
						this.ItemGetDistanceMin = input.ReadInt32();
						continue;
					}
					if (num == 2016U)
					{
						this.SpeedAvg = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008EAC RID: 36524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EAD RID: 36525
		public const int LogIdFieldNumber = 51;

		// Token: 0x04008EAE RID: 36526
		private long logId_;

		// Token: 0x04008EAF RID: 36527
		public const int ClientEndTimeFieldNumber = 14;

		// Token: 0x04008EB0 RID: 36528
		private string clientEndTime_ = "";

		// Token: 0x04008EB1 RID: 36529
		public const int RoundTimeUseFieldNumber = 130;

		// Token: 0x04008EB2 RID: 36530
		private long roundTimeUse_;

		// Token: 0x04008EB3 RID: 36531
		public const int SpeedMaxFieldNumber = 237;

		// Token: 0x04008EB4 RID: 36532
		private int speedMax_;

		// Token: 0x04008EB5 RID: 36533
		public const int SpeedMinFieldNumber = 114;

		// Token: 0x04008EB6 RID: 36534
		private int speedMin_;

		// Token: 0x04008EB7 RID: 36535
		public const int SprintMaxFieldNumber = 17;

		// Token: 0x04008EB8 RID: 36536
		private int sprintMax_;

		// Token: 0x04008EB9 RID: 36537
		public const int SprintMinFieldNumber = 1;

		// Token: 0x04008EBA RID: 36538
		private int sprintMin_;

		// Token: 0x04008EBB RID: 36539
		public const int SpeedAvgFieldNumber = 252;

		// Token: 0x04008EBC RID: 36540
		private int speedAvg_;

		// Token: 0x04008EBD RID: 36541
		public const int PSReplyTotalFieldNumber = 209;

		// Token: 0x04008EBE RID: 36542
		private long pSReplyTotal_;

		// Token: 0x04008EBF RID: 36543
		public const int PSCostTotalFieldNumber = 21;

		// Token: 0x04008EC0 RID: 36544
		private long pSCostTotal_;

		// Token: 0x04008EC1 RID: 36545
		public const int PSReplySpeedMaxFieldNumber = 39;

		// Token: 0x04008EC2 RID: 36546
		private int pSReplySpeedMax_;

		// Token: 0x04008EC3 RID: 36547
		public const int PSReplySpeedMinFieldNumber = 179;

		// Token: 0x04008EC4 RID: 36548
		private int pSReplySpeedMin_;

		// Token: 0x04008EC5 RID: 36549
		public const int PSUseCountFieldNumber = 26;

		// Token: 0x04008EC6 RID: 36550
		private int pSUseCount_;

		// Token: 0x04008EC7 RID: 36551
		public const int PSUseNumMaxFieldNumber = 217;

		// Token: 0x04008EC8 RID: 36552
		private int pSUseNumMax_;

		// Token: 0x04008EC9 RID: 36553
		public const int PSUseNumMinFieldNumber = 214;

		// Token: 0x04008ECA RID: 36554
		private int pSUseNumMin_;

		// Token: 0x04008ECB RID: 36555
		public const int ComboMaxFieldNumber = 70;

		// Token: 0x04008ECC RID: 36556
		private int comboMax_;

		// Token: 0x04008ECD RID: 36557
		public const int ItemGetCountFieldNumber = 108;

		// Token: 0x04008ECE RID: 36558
		private int itemGetCount_;

		// Token: 0x04008ECF RID: 36559
		public const int ItemGetDistanceMaxFieldNumber = 185;

		// Token: 0x04008ED0 RID: 36560
		private int itemGetDistanceMax_;

		// Token: 0x04008ED1 RID: 36561
		public const int ItemGetDistanceMinFieldNumber = 251;

		// Token: 0x04008ED2 RID: 36562
		private int itemGetDistanceMin_;
	}
}
