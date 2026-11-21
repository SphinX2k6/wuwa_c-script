using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F2 RID: 4594
	[NetMessage(EMessageId.SecWorldSEndFlowRequest)]
	public sealed class SecWorldSEndFlowRequest : IMessage<SecWorldSEndFlowRequest>, IMessage, IEquatable<SecWorldSEndFlowRequest>, IDeepCloneable<SecWorldSEndFlowRequest>, IBufferMessage
	{
		// Token: 0x060188C7 RID: 100551 RVA: 0x003946A7 File Offset: 0x003928A7
		[NullableContext(1)]
		public static SecWorldSEndFlowRequest Create()
		{
			return new SecWorldSEndFlowRequest();
		}

		// Token: 0x170052E6 RID: 21222
		// (get) Token: 0x060188C8 RID: 100552 RVA: 0x003946AE File Offset: 0x003928AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052E7 RID: 21223
		// (get) Token: 0x060188C9 RID: 100553 RVA: 0x003946B1 File Offset: 0x003928B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldSEndFlowRequest.Descriptor;
			}
		}

		// Token: 0x060188CA RID: 100554 RVA: 0x003946B8 File Offset: 0x003928B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowRequest()
		{
		}

		// Token: 0x060188CB RID: 100555 RVA: 0x003946CC File Offset: 0x003928CC
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

		// Token: 0x060188CC RID: 100556 RVA: 0x003947D4 File Offset: 0x003929D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldSEndFlowRequest Clone()
		{
			return new SecWorldSEndFlowRequest(this);
		}

		// Token: 0x170052E8 RID: 21224
		// (get) Token: 0x060188CD RID: 100557 RVA: 0x003947DC File Offset: 0x003929DC
		// (set) Token: 0x060188CE RID: 100558 RVA: 0x003947E4 File Offset: 0x003929E4
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

		// Token: 0x170052E9 RID: 21225
		// (get) Token: 0x060188CF RID: 100559 RVA: 0x003947ED File Offset: 0x003929ED
		// (set) Token: 0x060188D0 RID: 100560 RVA: 0x003947F5 File Offset: 0x003929F5
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

		// Token: 0x170052EA RID: 21226
		// (get) Token: 0x060188D1 RID: 100561 RVA: 0x00394808 File Offset: 0x00392A08
		// (set) Token: 0x060188D2 RID: 100562 RVA: 0x00394810 File Offset: 0x00392A10
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

		// Token: 0x170052EB RID: 21227
		// (get) Token: 0x060188D3 RID: 100563 RVA: 0x00394819 File Offset: 0x00392A19
		// (set) Token: 0x060188D4 RID: 100564 RVA: 0x00394821 File Offset: 0x00392A21
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

		// Token: 0x170052EC RID: 21228
		// (get) Token: 0x060188D5 RID: 100565 RVA: 0x0039482A File Offset: 0x00392A2A
		// (set) Token: 0x060188D6 RID: 100566 RVA: 0x00394832 File Offset: 0x00392A32
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

		// Token: 0x170052ED RID: 21229
		// (get) Token: 0x060188D7 RID: 100567 RVA: 0x0039483B File Offset: 0x00392A3B
		// (set) Token: 0x060188D8 RID: 100568 RVA: 0x00394843 File Offset: 0x00392A43
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

		// Token: 0x170052EE RID: 21230
		// (get) Token: 0x060188D9 RID: 100569 RVA: 0x0039484C File Offset: 0x00392A4C
		// (set) Token: 0x060188DA RID: 100570 RVA: 0x00394854 File Offset: 0x00392A54
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

		// Token: 0x170052EF RID: 21231
		// (get) Token: 0x060188DB RID: 100571 RVA: 0x0039485D File Offset: 0x00392A5D
		// (set) Token: 0x060188DC RID: 100572 RVA: 0x00394865 File Offset: 0x00392A65
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

		// Token: 0x170052F0 RID: 21232
		// (get) Token: 0x060188DD RID: 100573 RVA: 0x0039486E File Offset: 0x00392A6E
		// (set) Token: 0x060188DE RID: 100574 RVA: 0x00394876 File Offset: 0x00392A76
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

		// Token: 0x170052F1 RID: 21233
		// (get) Token: 0x060188DF RID: 100575 RVA: 0x0039487F File Offset: 0x00392A7F
		// (set) Token: 0x060188E0 RID: 100576 RVA: 0x00394887 File Offset: 0x00392A87
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

		// Token: 0x170052F2 RID: 21234
		// (get) Token: 0x060188E1 RID: 100577 RVA: 0x00394890 File Offset: 0x00392A90
		// (set) Token: 0x060188E2 RID: 100578 RVA: 0x00394898 File Offset: 0x00392A98
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

		// Token: 0x170052F3 RID: 21235
		// (get) Token: 0x060188E3 RID: 100579 RVA: 0x003948A1 File Offset: 0x00392AA1
		// (set) Token: 0x060188E4 RID: 100580 RVA: 0x003948A9 File Offset: 0x00392AA9
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

		// Token: 0x170052F4 RID: 21236
		// (get) Token: 0x060188E5 RID: 100581 RVA: 0x003948B2 File Offset: 0x00392AB2
		// (set) Token: 0x060188E6 RID: 100582 RVA: 0x003948BA File Offset: 0x00392ABA
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

		// Token: 0x170052F5 RID: 21237
		// (get) Token: 0x060188E7 RID: 100583 RVA: 0x003948C3 File Offset: 0x00392AC3
		// (set) Token: 0x060188E8 RID: 100584 RVA: 0x003948CB File Offset: 0x00392ACB
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

		// Token: 0x170052F6 RID: 21238
		// (get) Token: 0x060188E9 RID: 100585 RVA: 0x003948D4 File Offset: 0x00392AD4
		// (set) Token: 0x060188EA RID: 100586 RVA: 0x003948DC File Offset: 0x00392ADC
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

		// Token: 0x170052F7 RID: 21239
		// (get) Token: 0x060188EB RID: 100587 RVA: 0x003948E5 File Offset: 0x00392AE5
		// (set) Token: 0x060188EC RID: 100588 RVA: 0x003948ED File Offset: 0x00392AED
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

		// Token: 0x170052F8 RID: 21240
		// (get) Token: 0x060188ED RID: 100589 RVA: 0x003948F6 File Offset: 0x00392AF6
		// (set) Token: 0x060188EE RID: 100590 RVA: 0x003948FE File Offset: 0x00392AFE
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

		// Token: 0x170052F9 RID: 21241
		// (get) Token: 0x060188EF RID: 100591 RVA: 0x00394907 File Offset: 0x00392B07
		// (set) Token: 0x060188F0 RID: 100592 RVA: 0x0039490F File Offset: 0x00392B0F
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

		// Token: 0x170052FA RID: 21242
		// (get) Token: 0x060188F1 RID: 100593 RVA: 0x00394918 File Offset: 0x00392B18
		// (set) Token: 0x060188F2 RID: 100594 RVA: 0x00394920 File Offset: 0x00392B20
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

		// Token: 0x060188F3 RID: 100595 RVA: 0x00394929 File Offset: 0x00392B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldSEndFlowRequest);
		}

		// Token: 0x060188F4 RID: 100596 RVA: 0x00394938 File Offset: 0x00392B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldSEndFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientEndTime != other.ClientEndTime) && this.RoundTimeUse == other.RoundTimeUse && this.SpeedMax == other.SpeedMax && this.SpeedMin == other.SpeedMin && this.SprintMax == other.SprintMax && this.SprintMin == other.SprintMin && this.SpeedAvg == other.SpeedAvg && this.PSReplyTotal == other.PSReplyTotal && this.PSCostTotal == other.PSCostTotal && this.PSReplySpeedMax == other.PSReplySpeedMax && this.PSReplySpeedMin == other.PSReplySpeedMin && this.PSUseCount == other.PSUseCount && this.PSUseNumMax == other.PSUseNumMax && this.PSUseNumMin == other.PSUseNumMin && this.ItemGetCount == other.ItemGetCount && this.ItemGetDistanceMax == other.ItemGetDistanceMax && this.ItemGetDistanceMin == other.ItemGetDistanceMin && this.ComboMax == other.ComboMax && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060188F5 RID: 100597 RVA: 0x00394A98 File Offset: 0x00392C98
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

		// Token: 0x060188F6 RID: 100598 RVA: 0x00394C9B File Offset: 0x00392E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188F7 RID: 100599 RVA: 0x00394CA8 File Offset: 0x00392EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188F8 RID: 100600 RVA: 0x00394CB4 File Offset: 0x00392EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SprintMax != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SprintMax);
			}
			if (this.PSUseNumMin != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PSUseNumMin);
			}
			if (this.ComboMax != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ComboMax);
			}
			if (this.RoundTimeUse != 0)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.RoundTimeUse);
			}
			if (this.ClientEndTime.Length != 0)
			{
				output.WriteRawTag(210, 3);
				output.WriteString(this.ClientEndTime);
			}
			if (this.PSUseNumMax != 0)
			{
				output.WriteRawTag(232, 5);
				output.WriteInt32(this.PSUseNumMax);
			}
			if (this.ItemGetDistanceMin != 0)
			{
				output.WriteRawTag(192, 6);
				output.WriteInt32(this.ItemGetDistanceMin);
			}
			if (this.SpeedMin != 0)
			{
				output.WriteRawTag(240, 6);
				output.WriteInt32(this.SpeedMin);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(200, 7);
				output.WriteInt64(this.LogId);
			}
			if (this.PSUseCount != 0)
			{
				output.WriteRawTag(224, 7);
				output.WriteInt32(this.PSUseCount);
			}
			if (this.ItemGetCount != 0)
			{
				output.WriteRawTag(144, 8);
				output.WriteInt32(this.ItemGetCount);
			}
			if (this.PSReplyTotal != 0L)
			{
				output.WriteRawTag(184, 8);
				output.WriteInt64(this.PSReplyTotal);
			}
			if (this.PSCostTotal != 0L)
			{
				output.WriteRawTag(152, 9);
				output.WriteInt64(this.PSCostTotal);
			}
			if (this.SpeedAvg != 0)
			{
				output.WriteRawTag(160, 9);
				output.WriteInt32(this.SpeedAvg);
			}
			if (this.SpeedMax != 0)
			{
				output.WriteRawTag(152, 10);
				output.WriteInt32(this.SpeedMax);
			}
			if (this.ItemGetDistanceMax != 0)
			{
				output.WriteRawTag(184, 10);
				output.WriteInt32(this.ItemGetDistanceMax);
			}
			if (this.PSReplySpeedMin != 0)
			{
				output.WriteRawTag(232, 10);
				output.WriteInt32(this.PSReplySpeedMin);
			}
			if (this.PSReplySpeedMax != 0)
			{
				output.WriteRawTag(160, 11);
				output.WriteInt32(this.PSReplySpeedMax);
			}
			if (this.SprintMin != 0)
			{
				output.WriteRawTag(248, 12);
				output.WriteInt32(this.SprintMin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188F9 RID: 100601 RVA: 0x00394F34 File Offset: 0x00393134
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
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SpeedMin);
			}
			if (this.SprintMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SprintMax);
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
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PSUseNumMin);
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
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ComboMax);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060188FA RID: 100602 RVA: 0x00395128 File Offset: 0x00393328
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

		// Token: 0x060188FB RID: 100603 RVA: 0x003952D1 File Offset: 0x003934D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060188FC RID: 100604 RVA: 0x003952DC File Offset: 0x003934DC
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
				if (num <= 968U)
				{
					if (num <= 184U)
					{
						if (num <= 40U)
						{
							if (num == 8U)
							{
								this.SprintMax = input.ReadInt32();
								continue;
							}
							if (num == 40U)
							{
								this.PSUseNumMin = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 56U)
							{
								this.ComboMax = input.ReadInt32();
								continue;
							}
							if (num == 184U)
							{
								this.RoundTimeUse = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 744U)
					{
						if (num == 466U)
						{
							this.ClientEndTime = input.ReadString();
							continue;
						}
						if (num == 744U)
						{
							this.PSUseNumMax = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 832U)
						{
							this.ItemGetDistanceMin = input.ReadInt32();
							continue;
						}
						if (num == 880U)
						{
							this.SpeedMin = input.ReadInt32();
							continue;
						}
						if (num == 968U)
						{
							this.LogId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 1184U)
				{
					if (num <= 1040U)
					{
						if (num == 992U)
						{
							this.PSUseCount = input.ReadInt32();
							continue;
						}
						if (num == 1040U)
						{
							this.ItemGetCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 1080U)
						{
							this.PSReplyTotal = input.ReadInt64();
							continue;
						}
						if (num == 1176U)
						{
							this.PSCostTotal = input.ReadInt64();
							continue;
						}
						if (num == 1184U)
						{
							this.SpeedAvg = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1336U)
				{
					if (num == 1304U)
					{
						this.SpeedMax = input.ReadInt32();
						continue;
					}
					if (num == 1336U)
					{
						this.ItemGetDistanceMax = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 1384U)
					{
						this.PSReplySpeedMin = input.ReadInt32();
						continue;
					}
					if (num == 1440U)
					{
						this.PSReplySpeedMax = input.ReadInt32();
						continue;
					}
					if (num == 1656U)
					{
						this.SprintMin = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009200 RID: 37376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009201 RID: 37377
		public const int LogIdFieldNumber = 121;

		// Token: 0x04009202 RID: 37378
		private long logId_;

		// Token: 0x04009203 RID: 37379
		public const int ClientEndTimeFieldNumber = 58;

		// Token: 0x04009204 RID: 37380
		private string clientEndTime_ = "";

		// Token: 0x04009205 RID: 37381
		public const int RoundTimeUseFieldNumber = 23;

		// Token: 0x04009206 RID: 37382
		private int roundTimeUse_;

		// Token: 0x04009207 RID: 37383
		public const int SpeedMaxFieldNumber = 163;

		// Token: 0x04009208 RID: 37384
		private int speedMax_;

		// Token: 0x04009209 RID: 37385
		public const int SpeedMinFieldNumber = 110;

		// Token: 0x0400920A RID: 37386
		private int speedMin_;

		// Token: 0x0400920B RID: 37387
		public const int SprintMaxFieldNumber = 1;

		// Token: 0x0400920C RID: 37388
		private int sprintMax_;

		// Token: 0x0400920D RID: 37389
		public const int SprintMinFieldNumber = 207;

		// Token: 0x0400920E RID: 37390
		private int sprintMin_;

		// Token: 0x0400920F RID: 37391
		public const int SpeedAvgFieldNumber = 148;

		// Token: 0x04009210 RID: 37392
		private int speedAvg_;

		// Token: 0x04009211 RID: 37393
		public const int PSReplyTotalFieldNumber = 135;

		// Token: 0x04009212 RID: 37394
		private long pSReplyTotal_;

		// Token: 0x04009213 RID: 37395
		public const int PSCostTotalFieldNumber = 147;

		// Token: 0x04009214 RID: 37396
		private long pSCostTotal_;

		// Token: 0x04009215 RID: 37397
		public const int PSReplySpeedMaxFieldNumber = 180;

		// Token: 0x04009216 RID: 37398
		private int pSReplySpeedMax_;

		// Token: 0x04009217 RID: 37399
		public const int PSReplySpeedMinFieldNumber = 173;

		// Token: 0x04009218 RID: 37400
		private int pSReplySpeedMin_;

		// Token: 0x04009219 RID: 37401
		public const int PSUseCountFieldNumber = 124;

		// Token: 0x0400921A RID: 37402
		private int pSUseCount_;

		// Token: 0x0400921B RID: 37403
		public const int PSUseNumMaxFieldNumber = 93;

		// Token: 0x0400921C RID: 37404
		private int pSUseNumMax_;

		// Token: 0x0400921D RID: 37405
		public const int PSUseNumMinFieldNumber = 5;

		// Token: 0x0400921E RID: 37406
		private int pSUseNumMin_;

		// Token: 0x0400921F RID: 37407
		public const int ItemGetCountFieldNumber = 130;

		// Token: 0x04009220 RID: 37408
		private int itemGetCount_;

		// Token: 0x04009221 RID: 37409
		public const int ItemGetDistanceMaxFieldNumber = 167;

		// Token: 0x04009222 RID: 37410
		private int itemGetDistanceMax_;

		// Token: 0x04009223 RID: 37411
		public const int ItemGetDistanceMinFieldNumber = 104;

		// Token: 0x04009224 RID: 37412
		private int itemGetDistanceMin_;

		// Token: 0x04009225 RID: 37413
		public const int ComboMaxFieldNumber = 7;

		// Token: 0x04009226 RID: 37414
		private int comboMax_;
	}
}
