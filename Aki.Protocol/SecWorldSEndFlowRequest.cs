using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B8 RID: 4536
	[NetMessage(EMessageId.SecWorldSEndFlowRequest)]
	public sealed class SecWorldSEndFlowRequest : IMessage<SecWorldSEndFlowRequest>, IMessage, IEquatable<SecWorldSEndFlowRequest>, IDeepCloneable<SecWorldSEndFlowRequest>, IBufferMessage
	{
		// Token: 0x06018326 RID: 99110 RVA: 0x0038535A File Offset: 0x0038355A
		[NullableContext(1)]
		public static SecWorldSEndFlowRequest Create()
		{
			return new SecWorldSEndFlowRequest();
		}

		// Token: 0x1700517A RID: 20858
		// (get) Token: 0x06018327 RID: 99111 RVA: 0x00385361 File Offset: 0x00383561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700517B RID: 20859
		// (get) Token: 0x06018328 RID: 99112 RVA: 0x00385364 File Offset: 0x00383564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldSEndFlowRequest.Descriptor;
			}
		}

		// Token: 0x06018329 RID: 99113 RVA: 0x0038536B File Offset: 0x0038356B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowRequest()
		{
		}

		// Token: 0x0601832A RID: 99114 RVA: 0x00385380 File Offset: 0x00383580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowRequest(SecWorldSEndFlowRequest other) : this()
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
			this.itemGetCount_ = other.itemGetCount_;
			this.itemGetDistanceMax_ = other.itemGetDistanceMax_;
			this.itemGetDistanceMin_ = other.itemGetDistanceMin_;
			this.comboMax_ = other.comboMax_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601832B RID: 99115 RVA: 0x00385488 File Offset: 0x00383688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowRequest Clone()
		{
			return new SecWorldSEndFlowRequest(this);
		}

		// Token: 0x1700517C RID: 20860
		// (get) Token: 0x0601832C RID: 99116 RVA: 0x00385490 File Offset: 0x00383690
		// (set) Token: 0x0601832D RID: 99117 RVA: 0x00385498 File Offset: 0x00383698
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

		// Token: 0x1700517D RID: 20861
		// (get) Token: 0x0601832E RID: 99118 RVA: 0x003854A1 File Offset: 0x003836A1
		// (set) Token: 0x0601832F RID: 99119 RVA: 0x003854A9 File Offset: 0x003836A9
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

		// Token: 0x1700517E RID: 20862
		// (get) Token: 0x06018330 RID: 99120 RVA: 0x003854BC File Offset: 0x003836BC
		// (set) Token: 0x06018331 RID: 99121 RVA: 0x003854C4 File Offset: 0x003836C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundTimeUse
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

		// Token: 0x1700517F RID: 20863
		// (get) Token: 0x06018332 RID: 99122 RVA: 0x003854CD File Offset: 0x003836CD
		// (set) Token: 0x06018333 RID: 99123 RVA: 0x003854D5 File Offset: 0x003836D5
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

		// Token: 0x17005180 RID: 20864
		// (get) Token: 0x06018334 RID: 99124 RVA: 0x003854DE File Offset: 0x003836DE
		// (set) Token: 0x06018335 RID: 99125 RVA: 0x003854E6 File Offset: 0x003836E6
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

		// Token: 0x17005181 RID: 20865
		// (get) Token: 0x06018336 RID: 99126 RVA: 0x003854EF File Offset: 0x003836EF
		// (set) Token: 0x06018337 RID: 99127 RVA: 0x003854F7 File Offset: 0x003836F7
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

		// Token: 0x17005182 RID: 20866
		// (get) Token: 0x06018338 RID: 99128 RVA: 0x00385500 File Offset: 0x00383700
		// (set) Token: 0x06018339 RID: 99129 RVA: 0x00385508 File Offset: 0x00383708
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

		// Token: 0x17005183 RID: 20867
		// (get) Token: 0x0601833A RID: 99130 RVA: 0x00385511 File Offset: 0x00383711
		// (set) Token: 0x0601833B RID: 99131 RVA: 0x00385519 File Offset: 0x00383719
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

		// Token: 0x17005184 RID: 20868
		// (get) Token: 0x0601833C RID: 99132 RVA: 0x00385522 File Offset: 0x00383722
		// (set) Token: 0x0601833D RID: 99133 RVA: 0x0038552A File Offset: 0x0038372A
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

		// Token: 0x17005185 RID: 20869
		// (get) Token: 0x0601833E RID: 99134 RVA: 0x00385533 File Offset: 0x00383733
		// (set) Token: 0x0601833F RID: 99135 RVA: 0x0038553B File Offset: 0x0038373B
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

		// Token: 0x17005186 RID: 20870
		// (get) Token: 0x06018340 RID: 99136 RVA: 0x00385544 File Offset: 0x00383744
		// (set) Token: 0x06018341 RID: 99137 RVA: 0x0038554C File Offset: 0x0038374C
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

		// Token: 0x17005187 RID: 20871
		// (get) Token: 0x06018342 RID: 99138 RVA: 0x00385555 File Offset: 0x00383755
		// (set) Token: 0x06018343 RID: 99139 RVA: 0x0038555D File Offset: 0x0038375D
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

		// Token: 0x17005188 RID: 20872
		// (get) Token: 0x06018344 RID: 99140 RVA: 0x00385566 File Offset: 0x00383766
		// (set) Token: 0x06018345 RID: 99141 RVA: 0x0038556E File Offset: 0x0038376E
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

		// Token: 0x17005189 RID: 20873
		// (get) Token: 0x06018346 RID: 99142 RVA: 0x00385577 File Offset: 0x00383777
		// (set) Token: 0x06018347 RID: 99143 RVA: 0x0038557F File Offset: 0x0038377F
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

		// Token: 0x1700518A RID: 20874
		// (get) Token: 0x06018348 RID: 99144 RVA: 0x00385588 File Offset: 0x00383788
		// (set) Token: 0x06018349 RID: 99145 RVA: 0x00385590 File Offset: 0x00383790
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

		// Token: 0x1700518B RID: 20875
		// (get) Token: 0x0601834A RID: 99146 RVA: 0x00385599 File Offset: 0x00383799
		// (set) Token: 0x0601834B RID: 99147 RVA: 0x003855A1 File Offset: 0x003837A1
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

		// Token: 0x1700518C RID: 20876
		// (get) Token: 0x0601834C RID: 99148 RVA: 0x003855AA File Offset: 0x003837AA
		// (set) Token: 0x0601834D RID: 99149 RVA: 0x003855B2 File Offset: 0x003837B2
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

		// Token: 0x1700518D RID: 20877
		// (get) Token: 0x0601834E RID: 99150 RVA: 0x003855BB File Offset: 0x003837BB
		// (set) Token: 0x0601834F RID: 99151 RVA: 0x003855C3 File Offset: 0x003837C3
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

		// Token: 0x1700518E RID: 20878
		// (get) Token: 0x06018350 RID: 99152 RVA: 0x003855CC File Offset: 0x003837CC
		// (set) Token: 0x06018351 RID: 99153 RVA: 0x003855D4 File Offset: 0x003837D4
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

		// Token: 0x06018352 RID: 99154 RVA: 0x003855DD File Offset: 0x003837DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldSEndFlowRequest);
		}

		// Token: 0x06018353 RID: 99155 RVA: 0x003855EC File Offset: 0x003837EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldSEndFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientEndTime != other.ClientEndTime) && this.RoundTimeUse == other.RoundTimeUse && this.SpeedMax == other.SpeedMax && this.SpeedMin == other.SpeedMin && this.SprintMax == other.SprintMax && this.SprintMin == other.SprintMin && this.SpeedAvg == other.SpeedAvg && this.PSReplyTotal == other.PSReplyTotal && this.PSCostTotal == other.PSCostTotal && this.PSReplySpeedMax == other.PSReplySpeedMax && this.PSReplySpeedMin == other.PSReplySpeedMin && this.PSUseCount == other.PSUseCount && this.PSUseNumMax == other.PSUseNumMax && this.PSUseNumMin == other.PSUseNumMin && this.ItemGetCount == other.ItemGetCount && this.ItemGetDistanceMax == other.ItemGetDistanceMax && this.ItemGetDistanceMin == other.ItemGetDistanceMin && this.ComboMax == other.ComboMax && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018354 RID: 99156 RVA: 0x0038574C File Offset: 0x0038394C
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
			if (this.RoundTimeUse != 0)
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
			if (this.ComboMax != 0)
			{
				num ^= this.ComboMax.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018355 RID: 99157 RVA: 0x0038594F File Offset: 0x00383B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018356 RID: 99158 RVA: 0x0038595C File Offset: 0x00383B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018357 RID: 99159 RVA: 0x00385968 File Offset: 0x00383B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpeedMin != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SpeedMin);
			}
			if (this.SpeedAvg != 0)
			{
				output.WriteRawTag(232, 2);
				output.WriteInt32(this.SpeedAvg);
			}
			if (this.PSReplySpeedMax != 0)
			{
				output.WriteRawTag(136, 3);
				output.WriteInt32(this.PSReplySpeedMax);
			}
			if (this.PSReplyTotal != 0L)
			{
				output.WriteRawTag(200, 3);
				output.WriteInt64(this.PSReplyTotal);
			}
			if (this.PSCostTotal != 0L)
			{
				output.WriteRawTag(160, 5);
				output.WriteInt64(this.PSCostTotal);
			}
			if (this.ItemGetDistanceMax != 0)
			{
				output.WriteRawTag(224, 5);
				output.WriteInt32(this.ItemGetDistanceMax);
			}
			if (this.SprintMax != 0)
			{
				output.WriteRawTag(200, 7);
				output.WriteInt32(this.SprintMax);
			}
			if (this.ClientEndTime.Length != 0)
			{
				output.WriteRawTag(242, 7);
				output.WriteString(this.ClientEndTime);
			}
			if (this.RoundTimeUse != 0)
			{
				output.WriteRawTag(192, 9);
				output.WriteInt32(this.RoundTimeUse);
			}
			if (this.ItemGetCount != 0)
			{
				output.WriteRawTag(144, 10);
				output.WriteInt32(this.ItemGetCount);
			}
			if (this.SprintMin != 0)
			{
				output.WriteRawTag(232, 10);
				output.WriteInt32(this.SprintMin);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(160, 12);
				output.WriteInt64(this.LogId);
			}
			if (this.SpeedMax != 0)
			{
				output.WriteRawTag(208, 12);
				output.WriteInt32(this.SpeedMax);
			}
			if (this.PSUseNumMax != 0)
			{
				output.WriteRawTag(208, 13);
				output.WriteInt32(this.PSUseNumMax);
			}
			if (this.PSReplySpeedMin != 0)
			{
				output.WriteRawTag(152, 14);
				output.WriteInt32(this.PSReplySpeedMin);
			}
			if (this.PSUseCount != 0)
			{
				output.WriteRawTag(184, 14);
				output.WriteInt32(this.PSUseCount);
			}
			if (this.ItemGetDistanceMin != 0)
			{
				output.WriteRawTag(144, 15);
				output.WriteInt32(this.ItemGetDistanceMin);
			}
			if (this.PSUseNumMin != 0)
			{
				output.WriteRawTag(168, 15);
				output.WriteInt32(this.PSUseNumMin);
			}
			if (this.ComboMax != 0)
			{
				output.WriteRawTag(224, 15);
				output.WriteInt32(this.ComboMax);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018358 RID: 99160 RVA: 0x00385BF8 File Offset: 0x00383DF8
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
			if (this.RoundTimeUse != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoundTimeUse);
			}
			if (this.SpeedMax != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SpeedMax);
			}
			if (this.SpeedMin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpeedMin);
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
			if (this.ComboMax != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ComboMax);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018359 RID: 99161 RVA: 0x00385DEC File Offset: 0x00383FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecWorldSEndFlowRequest other)
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
			if (other.RoundTimeUse != 0)
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
			if (other.ComboMax != 0)
			{
				this.ComboMax = other.ComboMax;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601835A RID: 99162 RVA: 0x00385F95 File Offset: 0x00384195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601835B RID: 99163 RVA: 0x00385FA0 File Offset: 0x003841A0
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
				if (num <= 1216U)
				{
					if (num <= 456U)
					{
						if (num <= 360U)
						{
							if (num == 88U)
							{
								this.SpeedMin = input.ReadInt32();
								continue;
							}
							if (num == 360U)
							{
								this.SpeedAvg = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 392U)
							{
								this.PSReplySpeedMax = input.ReadInt32();
								continue;
							}
							if (num == 456U)
							{
								this.PSReplyTotal = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 736U)
					{
						if (num == 672U)
						{
							this.PSCostTotal = input.ReadInt64();
							continue;
						}
						if (num == 736U)
						{
							this.ItemGetDistanceMax = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 968U)
						{
							this.SprintMax = input.ReadInt32();
							continue;
						}
						if (num == 1010U)
						{
							this.ClientEndTime = input.ReadString();
							continue;
						}
						if (num == 1216U)
						{
							this.RoundTimeUse = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1744U)
				{
					if (num <= 1384U)
					{
						if (num == 1296U)
						{
							this.ItemGetCount = input.ReadInt32();
							continue;
						}
						if (num == 1384U)
						{
							this.SprintMin = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 1568U)
						{
							this.LogId = input.ReadInt64();
							continue;
						}
						if (num == 1616U)
						{
							this.SpeedMax = input.ReadInt32();
							continue;
						}
						if (num == 1744U)
						{
							this.PSUseNumMax = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1848U)
				{
					if (num == 1816U)
					{
						this.PSReplySpeedMin = input.ReadInt32();
						continue;
					}
					if (num == 1848U)
					{
						this.PSUseCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 1936U)
					{
						this.ItemGetDistanceMin = input.ReadInt32();
						continue;
					}
					if (num == 1960U)
					{
						this.PSUseNumMin = input.ReadInt32();
						continue;
					}
					if (num == 2016U)
					{
						this.ComboMax = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008F6D RID: 36717
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F6E RID: 36718
		public const int LogIdFieldNumber = 196;

		// Token: 0x04008F6F RID: 36719
		private long logId_;

		// Token: 0x04008F70 RID: 36720
		public const int ClientEndTimeFieldNumber = 126;

		// Token: 0x04008F71 RID: 36721
		private string clientEndTime_ = "";

		// Token: 0x04008F72 RID: 36722
		public const int RoundTimeUseFieldNumber = 152;

		// Token: 0x04008F73 RID: 36723
		private int roundTimeUse_;

		// Token: 0x04008F74 RID: 36724
		public const int SpeedMaxFieldNumber = 202;

		// Token: 0x04008F75 RID: 36725
		private int speedMax_;

		// Token: 0x04008F76 RID: 36726
		public const int SpeedMinFieldNumber = 11;

		// Token: 0x04008F77 RID: 36727
		private int speedMin_;

		// Token: 0x04008F78 RID: 36728
		public const int SprintMaxFieldNumber = 121;

		// Token: 0x04008F79 RID: 36729
		private int sprintMax_;

		// Token: 0x04008F7A RID: 36730
		public const int SprintMinFieldNumber = 173;

		// Token: 0x04008F7B RID: 36731
		private int sprintMin_;

		// Token: 0x04008F7C RID: 36732
		public const int SpeedAvgFieldNumber = 45;

		// Token: 0x04008F7D RID: 36733
		private int speedAvg_;

		// Token: 0x04008F7E RID: 36734
		public const int PSReplyTotalFieldNumber = 57;

		// Token: 0x04008F7F RID: 36735
		private long pSReplyTotal_;

		// Token: 0x04008F80 RID: 36736
		public const int PSCostTotalFieldNumber = 84;

		// Token: 0x04008F81 RID: 36737
		private long pSCostTotal_;

		// Token: 0x04008F82 RID: 36738
		public const int PSReplySpeedMaxFieldNumber = 49;

		// Token: 0x04008F83 RID: 36739
		private int pSReplySpeedMax_;

		// Token: 0x04008F84 RID: 36740
		public const int PSReplySpeedMinFieldNumber = 227;

		// Token: 0x04008F85 RID: 36741
		private int pSReplySpeedMin_;

		// Token: 0x04008F86 RID: 36742
		public const int PSUseCountFieldNumber = 231;

		// Token: 0x04008F87 RID: 36743
		private int pSUseCount_;

		// Token: 0x04008F88 RID: 36744
		public const int PSUseNumMaxFieldNumber = 218;

		// Token: 0x04008F89 RID: 36745
		private int pSUseNumMax_;

		// Token: 0x04008F8A RID: 36746
		public const int PSUseNumMinFieldNumber = 245;

		// Token: 0x04008F8B RID: 36747
		private int pSUseNumMin_;

		// Token: 0x04008F8C RID: 36748
		public const int ItemGetCountFieldNumber = 162;

		// Token: 0x04008F8D RID: 36749
		private int itemGetCount_;

		// Token: 0x04008F8E RID: 36750
		public const int ItemGetDistanceMaxFieldNumber = 92;

		// Token: 0x04008F8F RID: 36751
		private int itemGetDistanceMax_;

		// Token: 0x04008F90 RID: 36752
		public const int ItemGetDistanceMinFieldNumber = 242;

		// Token: 0x04008F91 RID: 36753
		private int itemGetDistanceMin_;

		// Token: 0x04008F92 RID: 36754
		public const int ComboMaxFieldNumber = 252;

		// Token: 0x04008F93 RID: 36755
		private int comboMax_;
	}
}
