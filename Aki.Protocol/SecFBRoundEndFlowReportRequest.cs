using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E6 RID: 4582
	[NetMessage(EMessageId.SecFBRoundEndFlowReportRequest)]
	public sealed class SecFBRoundEndFlowReportRequest : IMessage<SecFBRoundEndFlowReportRequest>, IMessage, IEquatable<SecFBRoundEndFlowReportRequest>, IDeepCloneable<SecFBRoundEndFlowReportRequest>, IBufferMessage
	{
		// Token: 0x06018754 RID: 100180 RVA: 0x0038F71B File Offset: 0x0038D91B
		[NullableContext(1)]
		public static SecFBRoundEndFlowReportRequest Create()
		{
			return new SecFBRoundEndFlowReportRequest();
		}

		// Token: 0x17005274 RID: 21108
		// (get) Token: 0x06018755 RID: 100181 RVA: 0x0038F722 File Offset: 0x0038D922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005275 RID: 21109
		// (get) Token: 0x06018756 RID: 100182 RVA: 0x0038F725 File Offset: 0x0038D925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecFBRoundEndFlowReportRequest.Descriptor;
			}
		}

		// Token: 0x06018757 RID: 100183 RVA: 0x0038F72C File Offset: 0x0038D92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportRequest()
		{
		}

		// Token: 0x06018758 RID: 100184 RVA: 0x0038F740 File Offset: 0x0038D940
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

		// Token: 0x06018759 RID: 100185 RVA: 0x0038F848 File Offset: 0x0038DA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundEndFlowReportRequest Clone()
		{
			return new SecFBRoundEndFlowReportRequest(this);
		}

		// Token: 0x17005276 RID: 21110
		// (get) Token: 0x0601875A RID: 100186 RVA: 0x0038F850 File Offset: 0x0038DA50
		// (set) Token: 0x0601875B RID: 100187 RVA: 0x0038F858 File Offset: 0x0038DA58
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

		// Token: 0x17005277 RID: 21111
		// (get) Token: 0x0601875C RID: 100188 RVA: 0x0038F861 File Offset: 0x0038DA61
		// (set) Token: 0x0601875D RID: 100189 RVA: 0x0038F869 File Offset: 0x0038DA69
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

		// Token: 0x17005278 RID: 21112
		// (get) Token: 0x0601875E RID: 100190 RVA: 0x0038F87C File Offset: 0x0038DA7C
		// (set) Token: 0x0601875F RID: 100191 RVA: 0x0038F884 File Offset: 0x0038DA84
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

		// Token: 0x17005279 RID: 21113
		// (get) Token: 0x06018760 RID: 100192 RVA: 0x0038F88D File Offset: 0x0038DA8D
		// (set) Token: 0x06018761 RID: 100193 RVA: 0x0038F895 File Offset: 0x0038DA95
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

		// Token: 0x1700527A RID: 21114
		// (get) Token: 0x06018762 RID: 100194 RVA: 0x0038F89E File Offset: 0x0038DA9E
		// (set) Token: 0x06018763 RID: 100195 RVA: 0x0038F8A6 File Offset: 0x0038DAA6
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

		// Token: 0x1700527B RID: 21115
		// (get) Token: 0x06018764 RID: 100196 RVA: 0x0038F8AF File Offset: 0x0038DAAF
		// (set) Token: 0x06018765 RID: 100197 RVA: 0x0038F8B7 File Offset: 0x0038DAB7
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

		// Token: 0x1700527C RID: 21116
		// (get) Token: 0x06018766 RID: 100198 RVA: 0x0038F8C0 File Offset: 0x0038DAC0
		// (set) Token: 0x06018767 RID: 100199 RVA: 0x0038F8C8 File Offset: 0x0038DAC8
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

		// Token: 0x1700527D RID: 21117
		// (get) Token: 0x06018768 RID: 100200 RVA: 0x0038F8D1 File Offset: 0x0038DAD1
		// (set) Token: 0x06018769 RID: 100201 RVA: 0x0038F8D9 File Offset: 0x0038DAD9
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

		// Token: 0x1700527E RID: 21118
		// (get) Token: 0x0601876A RID: 100202 RVA: 0x0038F8E2 File Offset: 0x0038DAE2
		// (set) Token: 0x0601876B RID: 100203 RVA: 0x0038F8EA File Offset: 0x0038DAEA
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

		// Token: 0x1700527F RID: 21119
		// (get) Token: 0x0601876C RID: 100204 RVA: 0x0038F8F3 File Offset: 0x0038DAF3
		// (set) Token: 0x0601876D RID: 100205 RVA: 0x0038F8FB File Offset: 0x0038DAFB
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

		// Token: 0x17005280 RID: 21120
		// (get) Token: 0x0601876E RID: 100206 RVA: 0x0038F904 File Offset: 0x0038DB04
		// (set) Token: 0x0601876F RID: 100207 RVA: 0x0038F90C File Offset: 0x0038DB0C
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

		// Token: 0x17005281 RID: 21121
		// (get) Token: 0x06018770 RID: 100208 RVA: 0x0038F915 File Offset: 0x0038DB15
		// (set) Token: 0x06018771 RID: 100209 RVA: 0x0038F91D File Offset: 0x0038DB1D
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

		// Token: 0x17005282 RID: 21122
		// (get) Token: 0x06018772 RID: 100210 RVA: 0x0038F926 File Offset: 0x0038DB26
		// (set) Token: 0x06018773 RID: 100211 RVA: 0x0038F92E File Offset: 0x0038DB2E
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

		// Token: 0x17005283 RID: 21123
		// (get) Token: 0x06018774 RID: 100212 RVA: 0x0038F937 File Offset: 0x0038DB37
		// (set) Token: 0x06018775 RID: 100213 RVA: 0x0038F93F File Offset: 0x0038DB3F
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

		// Token: 0x17005284 RID: 21124
		// (get) Token: 0x06018776 RID: 100214 RVA: 0x0038F948 File Offset: 0x0038DB48
		// (set) Token: 0x06018777 RID: 100215 RVA: 0x0038F950 File Offset: 0x0038DB50
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

		// Token: 0x17005285 RID: 21125
		// (get) Token: 0x06018778 RID: 100216 RVA: 0x0038F959 File Offset: 0x0038DB59
		// (set) Token: 0x06018779 RID: 100217 RVA: 0x0038F961 File Offset: 0x0038DB61
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

		// Token: 0x17005286 RID: 21126
		// (get) Token: 0x0601877A RID: 100218 RVA: 0x0038F96A File Offset: 0x0038DB6A
		// (set) Token: 0x0601877B RID: 100219 RVA: 0x0038F972 File Offset: 0x0038DB72
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

		// Token: 0x17005287 RID: 21127
		// (get) Token: 0x0601877C RID: 100220 RVA: 0x0038F97B File Offset: 0x0038DB7B
		// (set) Token: 0x0601877D RID: 100221 RVA: 0x0038F983 File Offset: 0x0038DB83
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

		// Token: 0x17005288 RID: 21128
		// (get) Token: 0x0601877E RID: 100222 RVA: 0x0038F98C File Offset: 0x0038DB8C
		// (set) Token: 0x0601877F RID: 100223 RVA: 0x0038F994 File Offset: 0x0038DB94
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

		// Token: 0x06018780 RID: 100224 RVA: 0x0038F99D File Offset: 0x0038DB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecFBRoundEndFlowReportRequest);
		}

		// Token: 0x06018781 RID: 100225 RVA: 0x0038F9AC File Offset: 0x0038DBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecFBRoundEndFlowReportRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientEndTime != other.ClientEndTime) && this.RoundTimeUse == other.RoundTimeUse && this.SpeedMax == other.SpeedMax && this.SpeedMin == other.SpeedMin && this.SprintMax == other.SprintMax && this.SprintMin == other.SprintMin && this.SpeedAvg == other.SpeedAvg && this.PSReplyTotal == other.PSReplyTotal && this.PSCostTotal == other.PSCostTotal && this.PSReplySpeedMax == other.PSReplySpeedMax && this.PSReplySpeedMin == other.PSReplySpeedMin && this.PSUseCount == other.PSUseCount && this.PSUseNumMax == other.PSUseNumMax && this.PSUseNumMin == other.PSUseNumMin && this.ComboMax == other.ComboMax && this.ItemGetCount == other.ItemGetCount && this.ItemGetDistanceMax == other.ItemGetDistanceMax && this.ItemGetDistanceMin == other.ItemGetDistanceMin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018782 RID: 100226 RVA: 0x0038FB0C File Offset: 0x0038DD0C
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

		// Token: 0x06018783 RID: 100227 RVA: 0x0038FD0F File Offset: 0x0038DF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018784 RID: 100228 RVA: 0x0038FD1C File Offset: 0x0038DF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018785 RID: 100229 RVA: 0x0038FD28 File Offset: 0x0038DF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SprintMin != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.SprintMin);
			}
			if (this.PSCostTotal != 0L)
			{
				output.WriteRawTag(224, 1);
				output.WriteInt64(this.PSCostTotal);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(232, 1);
				output.WriteInt64(this.LogId);
			}
			if (this.RoundTimeUse != 0L)
			{
				output.WriteRawTag(128, 3);
				output.WriteInt64(this.RoundTimeUse);
			}
			if (this.PSReplySpeedMax != 0)
			{
				output.WriteRawTag(144, 4);
				output.WriteInt32(this.PSReplySpeedMax);
			}
			if (this.SpeedMax != 0)
			{
				output.WriteRawTag(192, 6);
				output.WriteInt32(this.SpeedMax);
			}
			if (this.PSUseCount != 0)
			{
				output.WriteRawTag(192, 8);
				output.WriteInt32(this.PSUseCount);
			}
			if (this.SpeedMin != 0)
			{
				output.WriteRawTag(144, 9);
				output.WriteInt32(this.SpeedMin);
			}
			if (this.PSReplyTotal != 0L)
			{
				output.WriteRawTag(232, 9);
				output.WriteInt64(this.PSReplyTotal);
			}
			if (this.ItemGetDistanceMax != 0)
			{
				output.WriteRawTag(240, 9);
				output.WriteInt32(this.ItemGetDistanceMax);
			}
			if (this.PSUseNumMin != 0)
			{
				output.WriteRawTag(192, 11);
				output.WriteInt32(this.PSUseNumMin);
			}
			if (this.ItemGetCount != 0)
			{
				output.WriteRawTag(240, 11);
				output.WriteInt32(this.ItemGetCount);
			}
			if (this.SpeedAvg != 0)
			{
				output.WriteRawTag(136, 12);
				output.WriteInt32(this.SpeedAvg);
			}
			if (this.PSUseNumMax != 0)
			{
				output.WriteRawTag(200, 12);
				output.WriteInt32(this.PSUseNumMax);
			}
			if (this.SprintMax != 0)
			{
				output.WriteRawTag(248, 13);
				output.WriteInt32(this.SprintMax);
			}
			if (this.ComboMax != 0)
			{
				output.WriteRawTag(216, 14);
				output.WriteInt32(this.ComboMax);
			}
			if (this.ItemGetDistanceMin != 0)
			{
				output.WriteRawTag(224, 14);
				output.WriteInt32(this.ItemGetDistanceMin);
			}
			if (this.PSReplySpeedMin != 0)
			{
				output.WriteRawTag(176, 15);
				output.WriteInt32(this.PSReplySpeedMin);
			}
			if (this.ClientEndTime.Length != 0)
			{
				output.WriteRawTag(202, 15);
				output.WriteString(this.ClientEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018786 RID: 100230 RVA: 0x0038FFBC File Offset: 0x0038E1BC
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
				num += 2 + CodedOutputStream.ComputeStringSize(this.ClientEndTime);
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
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SprintMin);
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

		// Token: 0x06018787 RID: 100231 RVA: 0x003901B0 File Offset: 0x0038E3B0
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

		// Token: 0x06018788 RID: 100232 RVA: 0x00390359 File Offset: 0x0038E559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018789 RID: 100233 RVA: 0x00390364 File Offset: 0x0038E564
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
				if (num <= 1256U)
				{
					if (num <= 384U)
					{
						if (num <= 224U)
						{
							if (num == 136U)
							{
								this.SprintMin = input.ReadInt32();
								continue;
							}
							if (num == 224U)
							{
								this.PSCostTotal = input.ReadInt64();
								continue;
							}
						}
						else
						{
							if (num == 232U)
							{
								this.LogId = input.ReadInt64();
								continue;
							}
							if (num == 384U)
							{
								this.RoundTimeUse = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 832U)
					{
						if (num == 528U)
						{
							this.PSReplySpeedMax = input.ReadInt32();
							continue;
						}
						if (num == 832U)
						{
							this.SpeedMax = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 1088U)
						{
							this.PSUseCount = input.ReadInt32();
							continue;
						}
						if (num == 1168U)
						{
							this.SpeedMin = input.ReadInt32();
							continue;
						}
						if (num == 1256U)
						{
							this.PSReplyTotal = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 1608U)
				{
					if (num <= 1472U)
					{
						if (num == 1264U)
						{
							this.ItemGetDistanceMax = input.ReadInt32();
							continue;
						}
						if (num == 1472U)
						{
							this.PSUseNumMin = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 1520U)
						{
							this.ItemGetCount = input.ReadInt32();
							continue;
						}
						if (num == 1544U)
						{
							this.SpeedAvg = input.ReadInt32();
							continue;
						}
						if (num == 1608U)
						{
							this.PSUseNumMax = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1880U)
				{
					if (num == 1784U)
					{
						this.SprintMax = input.ReadInt32();
						continue;
					}
					if (num == 1880U)
					{
						this.ComboMax = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 1888U)
					{
						this.ItemGetDistanceMin = input.ReadInt32();
						continue;
					}
					if (num == 1968U)
					{
						this.PSReplySpeedMin = input.ReadInt32();
						continue;
					}
					if (num == 1994U)
					{
						this.ClientEndTime = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400913F RID: 37183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009140 RID: 37184
		public const int LogIdFieldNumber = 29;

		// Token: 0x04009141 RID: 37185
		private long logId_;

		// Token: 0x04009142 RID: 37186
		public const int ClientEndTimeFieldNumber = 249;

		// Token: 0x04009143 RID: 37187
		private string clientEndTime_ = "";

		// Token: 0x04009144 RID: 37188
		public const int RoundTimeUseFieldNumber = 48;

		// Token: 0x04009145 RID: 37189
		private long roundTimeUse_;

		// Token: 0x04009146 RID: 37190
		public const int SpeedMaxFieldNumber = 104;

		// Token: 0x04009147 RID: 37191
		private int speedMax_;

		// Token: 0x04009148 RID: 37192
		public const int SpeedMinFieldNumber = 146;

		// Token: 0x04009149 RID: 37193
		private int speedMin_;

		// Token: 0x0400914A RID: 37194
		public const int SprintMaxFieldNumber = 223;

		// Token: 0x0400914B RID: 37195
		private int sprintMax_;

		// Token: 0x0400914C RID: 37196
		public const int SprintMinFieldNumber = 17;

		// Token: 0x0400914D RID: 37197
		private int sprintMin_;

		// Token: 0x0400914E RID: 37198
		public const int SpeedAvgFieldNumber = 193;

		// Token: 0x0400914F RID: 37199
		private int speedAvg_;

		// Token: 0x04009150 RID: 37200
		public const int PSReplyTotalFieldNumber = 157;

		// Token: 0x04009151 RID: 37201
		private long pSReplyTotal_;

		// Token: 0x04009152 RID: 37202
		public const int PSCostTotalFieldNumber = 28;

		// Token: 0x04009153 RID: 37203
		private long pSCostTotal_;

		// Token: 0x04009154 RID: 37204
		public const int PSReplySpeedMaxFieldNumber = 66;

		// Token: 0x04009155 RID: 37205
		private int pSReplySpeedMax_;

		// Token: 0x04009156 RID: 37206
		public const int PSReplySpeedMinFieldNumber = 246;

		// Token: 0x04009157 RID: 37207
		private int pSReplySpeedMin_;

		// Token: 0x04009158 RID: 37208
		public const int PSUseCountFieldNumber = 136;

		// Token: 0x04009159 RID: 37209
		private int pSUseCount_;

		// Token: 0x0400915A RID: 37210
		public const int PSUseNumMaxFieldNumber = 201;

		// Token: 0x0400915B RID: 37211
		private int pSUseNumMax_;

		// Token: 0x0400915C RID: 37212
		public const int PSUseNumMinFieldNumber = 184;

		// Token: 0x0400915D RID: 37213
		private int pSUseNumMin_;

		// Token: 0x0400915E RID: 37214
		public const int ComboMaxFieldNumber = 235;

		// Token: 0x0400915F RID: 37215
		private int comboMax_;

		// Token: 0x04009160 RID: 37216
		public const int ItemGetCountFieldNumber = 190;

		// Token: 0x04009161 RID: 37217
		private int itemGetCount_;

		// Token: 0x04009162 RID: 37218
		public const int ItemGetDistanceMaxFieldNumber = 158;

		// Token: 0x04009163 RID: 37219
		private int itemGetDistanceMax_;

		// Token: 0x04009164 RID: 37220
		public const int ItemGetDistanceMinFieldNumber = 236;

		// Token: 0x04009165 RID: 37221
		private int itemGetDistanceMin_;
	}
}
