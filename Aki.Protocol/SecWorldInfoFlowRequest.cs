using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F0 RID: 4592
	[NetMessage(EMessageId.SecWorldInfoFlowRequest)]
	public sealed class SecWorldInfoFlowRequest : IMessage<SecWorldInfoFlowRequest>, IMessage, IEquatable<SecWorldInfoFlowRequest>, IDeepCloneable<SecWorldInfoFlowRequest>, IBufferMessage
	{
		// Token: 0x06018881 RID: 100481 RVA: 0x0039366B File Offset: 0x0039186B
		[NullableContext(1)]
		public static SecWorldInfoFlowRequest Create()
		{
			return new SecWorldInfoFlowRequest();
		}

		// Token: 0x170052CF RID: 21199
		// (get) Token: 0x06018882 RID: 100482 RVA: 0x00393672 File Offset: 0x00391872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052D0 RID: 21200
		// (get) Token: 0x06018883 RID: 100483 RVA: 0x00393675 File Offset: 0x00391875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldInfoFlowRequest.Descriptor;
			}
		}

		// Token: 0x06018884 RID: 100484 RVA: 0x0039367C File Offset: 0x0039187C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowRequest()
		{
		}

		// Token: 0x06018885 RID: 100485 RVA: 0x00393690 File Offset: 0x00391890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowRequest(SecWorldInfoFlowRequest other) : this()
		{
			this.logId_ = other.logId_;
			this.clientTime_ = other.clientTime_;
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
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018886 RID: 100486 RVA: 0x00393780 File Offset: 0x00391980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowRequest Clone()
		{
			return new SecWorldInfoFlowRequest(this);
		}

		// Token: 0x170052D1 RID: 21201
		// (get) Token: 0x06018887 RID: 100487 RVA: 0x00393788 File Offset: 0x00391988
		// (set) Token: 0x06018888 RID: 100488 RVA: 0x00393790 File Offset: 0x00391990
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

		// Token: 0x170052D2 RID: 21202
		// (get) Token: 0x06018889 RID: 100489 RVA: 0x00393799 File Offset: 0x00391999
		// (set) Token: 0x0601888A RID: 100490 RVA: 0x003937A1 File Offset: 0x003919A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientTime
		{
			get
			{
				return this.clientTime_;
			}
			set
			{
				this.clientTime_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170052D3 RID: 21203
		// (get) Token: 0x0601888B RID: 100491 RVA: 0x003937B4 File Offset: 0x003919B4
		// (set) Token: 0x0601888C RID: 100492 RVA: 0x003937BC File Offset: 0x003919BC
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

		// Token: 0x170052D4 RID: 21204
		// (get) Token: 0x0601888D RID: 100493 RVA: 0x003937C5 File Offset: 0x003919C5
		// (set) Token: 0x0601888E RID: 100494 RVA: 0x003937CD File Offset: 0x003919CD
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

		// Token: 0x170052D5 RID: 21205
		// (get) Token: 0x0601888F RID: 100495 RVA: 0x003937D6 File Offset: 0x003919D6
		// (set) Token: 0x06018890 RID: 100496 RVA: 0x003937DE File Offset: 0x003919DE
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

		// Token: 0x170052D6 RID: 21206
		// (get) Token: 0x06018891 RID: 100497 RVA: 0x003937E7 File Offset: 0x003919E7
		// (set) Token: 0x06018892 RID: 100498 RVA: 0x003937EF File Offset: 0x003919EF
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

		// Token: 0x170052D7 RID: 21207
		// (get) Token: 0x06018893 RID: 100499 RVA: 0x003937F8 File Offset: 0x003919F8
		// (set) Token: 0x06018894 RID: 100500 RVA: 0x00393800 File Offset: 0x00391A00
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

		// Token: 0x170052D8 RID: 21208
		// (get) Token: 0x06018895 RID: 100501 RVA: 0x00393809 File Offset: 0x00391A09
		// (set) Token: 0x06018896 RID: 100502 RVA: 0x00393811 File Offset: 0x00391A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PSReplyTotal
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

		// Token: 0x170052D9 RID: 21209
		// (get) Token: 0x06018897 RID: 100503 RVA: 0x0039381A File Offset: 0x00391A1A
		// (set) Token: 0x06018898 RID: 100504 RVA: 0x00393822 File Offset: 0x00391A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PSCostTotal
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

		// Token: 0x170052DA RID: 21210
		// (get) Token: 0x06018899 RID: 100505 RVA: 0x0039382B File Offset: 0x00391A2B
		// (set) Token: 0x0601889A RID: 100506 RVA: 0x00393833 File Offset: 0x00391A33
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

		// Token: 0x170052DB RID: 21211
		// (get) Token: 0x0601889B RID: 100507 RVA: 0x0039383C File Offset: 0x00391A3C
		// (set) Token: 0x0601889C RID: 100508 RVA: 0x00393844 File Offset: 0x00391A44
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

		// Token: 0x170052DC RID: 21212
		// (get) Token: 0x0601889D RID: 100509 RVA: 0x0039384D File Offset: 0x00391A4D
		// (set) Token: 0x0601889E RID: 100510 RVA: 0x00393855 File Offset: 0x00391A55
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

		// Token: 0x170052DD RID: 21213
		// (get) Token: 0x0601889F RID: 100511 RVA: 0x0039385E File Offset: 0x00391A5E
		// (set) Token: 0x060188A0 RID: 100512 RVA: 0x00393866 File Offset: 0x00391A66
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

		// Token: 0x170052DE RID: 21214
		// (get) Token: 0x060188A1 RID: 100513 RVA: 0x0039386F File Offset: 0x00391A6F
		// (set) Token: 0x060188A2 RID: 100514 RVA: 0x00393877 File Offset: 0x00391A77
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

		// Token: 0x170052DF RID: 21215
		// (get) Token: 0x060188A3 RID: 100515 RVA: 0x00393880 File Offset: 0x00391A80
		// (set) Token: 0x060188A4 RID: 100516 RVA: 0x00393888 File Offset: 0x00391A88
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

		// Token: 0x170052E0 RID: 21216
		// (get) Token: 0x060188A5 RID: 100517 RVA: 0x00393891 File Offset: 0x00391A91
		// (set) Token: 0x060188A6 RID: 100518 RVA: 0x00393899 File Offset: 0x00391A99
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

		// Token: 0x170052E1 RID: 21217
		// (get) Token: 0x060188A7 RID: 100519 RVA: 0x003938A2 File Offset: 0x00391AA2
		// (set) Token: 0x060188A8 RID: 100520 RVA: 0x003938AA File Offset: 0x00391AAA
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

		// Token: 0x060188A9 RID: 100521 RVA: 0x003938B3 File Offset: 0x00391AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldInfoFlowRequest);
		}

		// Token: 0x060188AA RID: 100522 RVA: 0x003938C4 File Offset: 0x00391AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldInfoFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientTime != other.ClientTime) && this.SpeedMax == other.SpeedMax && this.SpeedMin == other.SpeedMin && this.SprintMax == other.SprintMax && this.SprintMin == other.SprintMin && this.SpeedAvg == other.SpeedAvg && this.PSReplyTotal == other.PSReplyTotal && this.PSCostTotal == other.PSCostTotal && this.PSReplySpeedMax == other.PSReplySpeedMax && this.PSReplySpeedMin == other.PSReplySpeedMin && this.PSUseCount == other.PSUseCount && this.PSUseNumMax == other.PSUseNumMax && this.PSUseNumMin == other.PSUseNumMin && this.ItemGetCount == other.ItemGetCount && this.ItemGetDistanceMax == other.ItemGetDistanceMax && this.ItemGetDistanceMin == other.ItemGetDistanceMin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060188AB RID: 100523 RVA: 0x00393A04 File Offset: 0x00391C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.ClientTime.Length != 0)
			{
				num ^= this.ClientTime.GetHashCode();
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
			if (this.PSReplyTotal != 0)
			{
				num ^= this.PSReplyTotal.GetHashCode();
			}
			if (this.PSCostTotal != 0)
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060188AC RID: 100524 RVA: 0x00393BD5 File Offset: 0x00391DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060188AD RID: 100525 RVA: 0x00393BE2 File Offset: 0x00391DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060188AE RID: 100526 RVA: 0x00393BEC File Offset: 0x00391DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemGetCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemGetCount);
			}
			if (this.PSUseNumMax != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PSUseNumMax);
			}
			if (this.PSReplyTotal != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PSReplyTotal);
			}
			if (this.SprintMax != 0)
			{
				output.WriteRawTag(216, 2);
				output.WriteInt32(this.SprintMax);
			}
			if (this.SprintMin != 0)
			{
				output.WriteRawTag(152, 3);
				output.WriteInt32(this.SprintMin);
			}
			if (this.PSUseCount != 0)
			{
				output.WriteRawTag(240, 3);
				output.WriteInt32(this.PSUseCount);
			}
			if (this.ItemGetDistanceMax != 0)
			{
				output.WriteRawTag(176, 4);
				output.WriteInt32(this.ItemGetDistanceMax);
			}
			if (this.PSReplySpeedMin != 0)
			{
				output.WriteRawTag(200, 4);
				output.WriteInt32(this.PSReplySpeedMin);
			}
			if (this.SpeedMin != 0)
			{
				output.WriteRawTag(176, 5);
				output.WriteInt32(this.SpeedMin);
			}
			if (this.ItemGetDistanceMin != 0)
			{
				output.WriteRawTag(224, 5);
				output.WriteInt32(this.ItemGetDistanceMin);
			}
			if (this.ClientTime.Length != 0)
			{
				output.WriteRawTag(234, 5);
				output.WriteString(this.ClientTime);
			}
			if (this.PSUseNumMin != 0)
			{
				output.WriteRawTag(152, 6);
				output.WriteInt32(this.PSUseNumMin);
			}
			if (this.SpeedMax != 0)
			{
				output.WriteRawTag(152, 8);
				output.WriteInt32(this.SpeedMax);
			}
			if (this.PSCostTotal != 0)
			{
				output.WriteRawTag(192, 9);
				output.WriteInt32(this.PSCostTotal);
			}
			if (this.PSReplySpeedMax != 0)
			{
				output.WriteRawTag(248, 9);
				output.WriteInt32(this.PSReplySpeedMax);
			}
			if (this.SpeedAvg != 0)
			{
				output.WriteRawTag(248, 10);
				output.WriteInt32(this.SpeedAvg);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(184, 15);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060188AF RID: 100527 RVA: 0x00393E2C File Offset: 0x0039202C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.ClientTime.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ClientTime);
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
			if (this.PSReplyTotal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PSReplyTotal);
			}
			if (this.PSCostTotal != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PSCostTotal);
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
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PSUseNumMax);
			}
			if (this.PSUseNumMin != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PSUseNumMin);
			}
			if (this.ItemGetCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemGetCount);
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

		// Token: 0x060188B0 RID: 100528 RVA: 0x00393FF0 File Offset: 0x003921F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecWorldInfoFlowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.ClientTime.Length != 0)
			{
				this.ClientTime = other.ClientTime;
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
			if (other.PSReplyTotal != 0)
			{
				this.PSReplyTotal = other.PSReplyTotal;
			}
			if (other.PSCostTotal != 0)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060188B1 RID: 100529 RVA: 0x00394171 File Offset: 0x00392371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060188B2 RID: 100530 RVA: 0x0039417C File Offset: 0x0039237C
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
				if (num <= 584U)
				{
					if (num <= 344U)
					{
						if (num <= 64U)
						{
							if (num == 8U)
							{
								this.ItemGetCount = input.ReadInt32();
								continue;
							}
							if (num == 64U)
							{
								this.PSUseNumMax = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 96U)
							{
								this.PSReplyTotal = input.ReadInt32();
								continue;
							}
							if (num == 344U)
							{
								this.SprintMax = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 496U)
					{
						if (num == 408U)
						{
							this.SprintMin = input.ReadInt32();
							continue;
						}
						if (num == 496U)
						{
							this.PSUseCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 560U)
						{
							this.ItemGetDistanceMax = input.ReadInt32();
							continue;
						}
						if (num == 584U)
						{
							this.PSReplySpeedMin = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 792U)
				{
					if (num <= 736U)
					{
						if (num == 688U)
						{
							this.SpeedMin = input.ReadInt32();
							continue;
						}
						if (num == 736U)
						{
							this.ItemGetDistanceMin = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 746U)
						{
							this.ClientTime = input.ReadString();
							continue;
						}
						if (num == 792U)
						{
							this.PSUseNumMin = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1216U)
				{
					if (num == 1048U)
					{
						this.SpeedMax = input.ReadInt32();
						continue;
					}
					if (num == 1216U)
					{
						this.PSCostTotal = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 1272U)
					{
						this.PSReplySpeedMax = input.ReadInt32();
						continue;
					}
					if (num == 1400U)
					{
						this.SpeedAvg = input.ReadInt32();
						continue;
					}
					if (num == 1976U)
					{
						this.LogId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040091D8 RID: 37336
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091D9 RID: 37337
		public const int LogIdFieldNumber = 247;

		// Token: 0x040091DA RID: 37338
		private long logId_;

		// Token: 0x040091DB RID: 37339
		public const int ClientTimeFieldNumber = 93;

		// Token: 0x040091DC RID: 37340
		private string clientTime_ = "";

		// Token: 0x040091DD RID: 37341
		public const int SpeedMaxFieldNumber = 131;

		// Token: 0x040091DE RID: 37342
		private int speedMax_;

		// Token: 0x040091DF RID: 37343
		public const int SpeedMinFieldNumber = 86;

		// Token: 0x040091E0 RID: 37344
		private int speedMin_;

		// Token: 0x040091E1 RID: 37345
		public const int SprintMaxFieldNumber = 43;

		// Token: 0x040091E2 RID: 37346
		private int sprintMax_;

		// Token: 0x040091E3 RID: 37347
		public const int SprintMinFieldNumber = 51;

		// Token: 0x040091E4 RID: 37348
		private int sprintMin_;

		// Token: 0x040091E5 RID: 37349
		public const int SpeedAvgFieldNumber = 175;

		// Token: 0x040091E6 RID: 37350
		private int speedAvg_;

		// Token: 0x040091E7 RID: 37351
		public const int PSReplyTotalFieldNumber = 12;

		// Token: 0x040091E8 RID: 37352
		private int pSReplyTotal_;

		// Token: 0x040091E9 RID: 37353
		public const int PSCostTotalFieldNumber = 152;

		// Token: 0x040091EA RID: 37354
		private int pSCostTotal_;

		// Token: 0x040091EB RID: 37355
		public const int PSReplySpeedMaxFieldNumber = 159;

		// Token: 0x040091EC RID: 37356
		private int pSReplySpeedMax_;

		// Token: 0x040091ED RID: 37357
		public const int PSReplySpeedMinFieldNumber = 73;

		// Token: 0x040091EE RID: 37358
		private int pSReplySpeedMin_;

		// Token: 0x040091EF RID: 37359
		public const int PSUseCountFieldNumber = 62;

		// Token: 0x040091F0 RID: 37360
		private int pSUseCount_;

		// Token: 0x040091F1 RID: 37361
		public const int PSUseNumMaxFieldNumber = 8;

		// Token: 0x040091F2 RID: 37362
		private int pSUseNumMax_;

		// Token: 0x040091F3 RID: 37363
		public const int PSUseNumMinFieldNumber = 99;

		// Token: 0x040091F4 RID: 37364
		private int pSUseNumMin_;

		// Token: 0x040091F5 RID: 37365
		public const int ItemGetCountFieldNumber = 1;

		// Token: 0x040091F6 RID: 37366
		private int itemGetCount_;

		// Token: 0x040091F7 RID: 37367
		public const int ItemGetDistanceMaxFieldNumber = 70;

		// Token: 0x040091F8 RID: 37368
		private int itemGetDistanceMax_;

		// Token: 0x040091F9 RID: 37369
		public const int ItemGetDistanceMinFieldNumber = 92;

		// Token: 0x040091FA RID: 37370
		private int itemGetDistanceMin_;
	}
}
