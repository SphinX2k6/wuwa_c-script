using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B6 RID: 4534
	[NetMessage(EMessageId.SecWorldInfoFlowRequest)]
	public sealed class SecWorldInfoFlowRequest : IMessage<SecWorldInfoFlowRequest>, IMessage, IEquatable<SecWorldInfoFlowRequest>, IDeepCloneable<SecWorldInfoFlowRequest>, IBufferMessage
	{
		// Token: 0x060182E0 RID: 99040 RVA: 0x00384303 File Offset: 0x00382503
		[NullableContext(1)]
		public static SecWorldInfoFlowRequest Create()
		{
			return new SecWorldInfoFlowRequest();
		}

		// Token: 0x17005163 RID: 20835
		// (get) Token: 0x060182E1 RID: 99041 RVA: 0x0038430A File Offset: 0x0038250A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005164 RID: 20836
		// (get) Token: 0x060182E2 RID: 99042 RVA: 0x0038430D File Offset: 0x0038250D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldInfoFlowRequest.Descriptor;
			}
		}

		// Token: 0x060182E3 RID: 99043 RVA: 0x00384314 File Offset: 0x00382514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowRequest()
		{
		}

		// Token: 0x060182E4 RID: 99044 RVA: 0x00384328 File Offset: 0x00382528
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

		// Token: 0x060182E5 RID: 99045 RVA: 0x00384418 File Offset: 0x00382618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldInfoFlowRequest Clone()
		{
			return new SecWorldInfoFlowRequest(this);
		}

		// Token: 0x17005165 RID: 20837
		// (get) Token: 0x060182E6 RID: 99046 RVA: 0x00384420 File Offset: 0x00382620
		// (set) Token: 0x060182E7 RID: 99047 RVA: 0x00384428 File Offset: 0x00382628
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

		// Token: 0x17005166 RID: 20838
		// (get) Token: 0x060182E8 RID: 99048 RVA: 0x00384431 File Offset: 0x00382631
		// (set) Token: 0x060182E9 RID: 99049 RVA: 0x00384439 File Offset: 0x00382639
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

		// Token: 0x17005167 RID: 20839
		// (get) Token: 0x060182EA RID: 99050 RVA: 0x0038444C File Offset: 0x0038264C
		// (set) Token: 0x060182EB RID: 99051 RVA: 0x00384454 File Offset: 0x00382654
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

		// Token: 0x17005168 RID: 20840
		// (get) Token: 0x060182EC RID: 99052 RVA: 0x0038445D File Offset: 0x0038265D
		// (set) Token: 0x060182ED RID: 99053 RVA: 0x00384465 File Offset: 0x00382665
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

		// Token: 0x17005169 RID: 20841
		// (get) Token: 0x060182EE RID: 99054 RVA: 0x0038446E File Offset: 0x0038266E
		// (set) Token: 0x060182EF RID: 99055 RVA: 0x00384476 File Offset: 0x00382676
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

		// Token: 0x1700516A RID: 20842
		// (get) Token: 0x060182F0 RID: 99056 RVA: 0x0038447F File Offset: 0x0038267F
		// (set) Token: 0x060182F1 RID: 99057 RVA: 0x00384487 File Offset: 0x00382687
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

		// Token: 0x1700516B RID: 20843
		// (get) Token: 0x060182F2 RID: 99058 RVA: 0x00384490 File Offset: 0x00382690
		// (set) Token: 0x060182F3 RID: 99059 RVA: 0x00384498 File Offset: 0x00382698
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

		// Token: 0x1700516C RID: 20844
		// (get) Token: 0x060182F4 RID: 99060 RVA: 0x003844A1 File Offset: 0x003826A1
		// (set) Token: 0x060182F5 RID: 99061 RVA: 0x003844A9 File Offset: 0x003826A9
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

		// Token: 0x1700516D RID: 20845
		// (get) Token: 0x060182F6 RID: 99062 RVA: 0x003844B2 File Offset: 0x003826B2
		// (set) Token: 0x060182F7 RID: 99063 RVA: 0x003844BA File Offset: 0x003826BA
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

		// Token: 0x1700516E RID: 20846
		// (get) Token: 0x060182F8 RID: 99064 RVA: 0x003844C3 File Offset: 0x003826C3
		// (set) Token: 0x060182F9 RID: 99065 RVA: 0x003844CB File Offset: 0x003826CB
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

		// Token: 0x1700516F RID: 20847
		// (get) Token: 0x060182FA RID: 99066 RVA: 0x003844D4 File Offset: 0x003826D4
		// (set) Token: 0x060182FB RID: 99067 RVA: 0x003844DC File Offset: 0x003826DC
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

		// Token: 0x17005170 RID: 20848
		// (get) Token: 0x060182FC RID: 99068 RVA: 0x003844E5 File Offset: 0x003826E5
		// (set) Token: 0x060182FD RID: 99069 RVA: 0x003844ED File Offset: 0x003826ED
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

		// Token: 0x17005171 RID: 20849
		// (get) Token: 0x060182FE RID: 99070 RVA: 0x003844F6 File Offset: 0x003826F6
		// (set) Token: 0x060182FF RID: 99071 RVA: 0x003844FE File Offset: 0x003826FE
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

		// Token: 0x17005172 RID: 20850
		// (get) Token: 0x06018300 RID: 99072 RVA: 0x00384507 File Offset: 0x00382707
		// (set) Token: 0x06018301 RID: 99073 RVA: 0x0038450F File Offset: 0x0038270F
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

		// Token: 0x17005173 RID: 20851
		// (get) Token: 0x06018302 RID: 99074 RVA: 0x00384518 File Offset: 0x00382718
		// (set) Token: 0x06018303 RID: 99075 RVA: 0x00384520 File Offset: 0x00382720
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

		// Token: 0x17005174 RID: 20852
		// (get) Token: 0x06018304 RID: 99076 RVA: 0x00384529 File Offset: 0x00382729
		// (set) Token: 0x06018305 RID: 99077 RVA: 0x00384531 File Offset: 0x00382731
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

		// Token: 0x17005175 RID: 20853
		// (get) Token: 0x06018306 RID: 99078 RVA: 0x0038453A File Offset: 0x0038273A
		// (set) Token: 0x06018307 RID: 99079 RVA: 0x00384542 File Offset: 0x00382742
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

		// Token: 0x06018308 RID: 99080 RVA: 0x0038454B File Offset: 0x0038274B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldInfoFlowRequest);
		}

		// Token: 0x06018309 RID: 99081 RVA: 0x0038455C File Offset: 0x0038275C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldInfoFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientTime != other.ClientTime) && this.SpeedMax == other.SpeedMax && this.SpeedMin == other.SpeedMin && this.SprintMax == other.SprintMax && this.SprintMin == other.SprintMin && this.SpeedAvg == other.SpeedAvg && this.PSReplyTotal == other.PSReplyTotal && this.PSCostTotal == other.PSCostTotal && this.PSReplySpeedMax == other.PSReplySpeedMax && this.PSReplySpeedMin == other.PSReplySpeedMin && this.PSUseCount == other.PSUseCount && this.PSUseNumMax == other.PSUseNumMax && this.PSUseNumMin == other.PSUseNumMin && this.ItemGetCount == other.ItemGetCount && this.ItemGetDistanceMax == other.ItemGetDistanceMax && this.ItemGetDistanceMin == other.ItemGetDistanceMin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601830A RID: 99082 RVA: 0x0038469C File Offset: 0x0038289C
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

		// Token: 0x0601830B RID: 99083 RVA: 0x0038486D File Offset: 0x00382A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601830C RID: 99084 RVA: 0x0038487A File Offset: 0x00382A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601830D RID: 99085 RVA: 0x00384884 File Offset: 0x00382A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemGetDistanceMin != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.ItemGetDistanceMin);
			}
			if (this.PSReplyTotal != 0)
			{
				output.WriteRawTag(144, 2);
				output.WriteInt32(this.PSReplyTotal);
			}
			if (this.PSCostTotal != 0)
			{
				output.WriteRawTag(248, 4);
				output.WriteInt32(this.PSCostTotal);
			}
			if (this.SpeedMin != 0)
			{
				output.WriteRawTag(224, 5);
				output.WriteInt32(this.SpeedMin);
			}
			if (this.SprintMin != 0)
			{
				output.WriteRawTag(248, 5);
				output.WriteInt32(this.SprintMin);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(136, 6);
				output.WriteInt64(this.LogId);
			}
			if (this.PSReplySpeedMin != 0)
			{
				output.WriteRawTag(144, 6);
				output.WriteInt32(this.PSReplySpeedMin);
			}
			if (this.ItemGetDistanceMax != 0)
			{
				output.WriteRawTag(168, 8);
				output.WriteInt32(this.ItemGetDistanceMax);
			}
			if (this.ItemGetCount != 0)
			{
				output.WriteRawTag(208, 8);
				output.WriteInt32(this.ItemGetCount);
			}
			if (this.PSUseNumMax != 0)
			{
				output.WriteRawTag(216, 8);
				output.WriteInt32(this.PSUseNumMax);
			}
			if (this.SpeedAvg != 0)
			{
				output.WriteRawTag(136, 9);
				output.WriteInt32(this.SpeedAvg);
			}
			if (this.PSUseNumMin != 0)
			{
				output.WriteRawTag(152, 9);
				output.WriteInt32(this.PSUseNumMin);
			}
			if (this.SprintMax != 0)
			{
				output.WriteRawTag(216, 12);
				output.WriteInt32(this.SprintMax);
			}
			if (this.ClientTime.Length != 0)
			{
				output.WriteRawTag(194, 13);
				output.WriteString(this.ClientTime);
			}
			if (this.PSUseCount != 0)
			{
				output.WriteRawTag(208, 13);
				output.WriteInt32(this.PSUseCount);
			}
			if (this.PSReplySpeedMax != 0)
			{
				output.WriteRawTag(136, 15);
				output.WriteInt32(this.PSReplySpeedMax);
			}
			if (this.SpeedMax != 0)
			{
				output.WriteRawTag(248, 15);
				output.WriteInt32(this.SpeedMax);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601830E RID: 99086 RVA: 0x00384AD4 File Offset: 0x00382CD4
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
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PSReplyTotal);
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601830F RID: 99087 RVA: 0x00384C98 File Offset: 0x00382E98
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

		// Token: 0x06018310 RID: 99088 RVA: 0x00384E19 File Offset: 0x00383019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018311 RID: 99089 RVA: 0x00384E24 File Offset: 0x00383024
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
				if (num <= 1064U)
				{
					if (num <= 736U)
					{
						if (num <= 272U)
						{
							if (num == 160U)
							{
								this.ItemGetDistanceMin = input.ReadInt32();
								continue;
							}
							if (num == 272U)
							{
								this.PSReplyTotal = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 632U)
							{
								this.PSCostTotal = input.ReadInt32();
								continue;
							}
							if (num == 736U)
							{
								this.SpeedMin = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 776U)
					{
						if (num == 760U)
						{
							this.SprintMin = input.ReadInt32();
							continue;
						}
						if (num == 776U)
						{
							this.LogId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 784U)
						{
							this.PSReplySpeedMin = input.ReadInt32();
							continue;
						}
						if (num == 1064U)
						{
							this.ItemGetDistanceMax = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1176U)
				{
					if (num <= 1112U)
					{
						if (num == 1104U)
						{
							this.ItemGetCount = input.ReadInt32();
							continue;
						}
						if (num == 1112U)
						{
							this.PSUseNumMax = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 1160U)
						{
							this.SpeedAvg = input.ReadInt32();
							continue;
						}
						if (num == 1176U)
						{
							this.PSUseNumMin = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1730U)
				{
					if (num == 1624U)
					{
						this.SprintMax = input.ReadInt32();
						continue;
					}
					if (num == 1730U)
					{
						this.ClientTime = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 1744U)
					{
						this.PSUseCount = input.ReadInt32();
						continue;
					}
					if (num == 1928U)
					{
						this.PSReplySpeedMax = input.ReadInt32();
						continue;
					}
					if (num == 2040U)
					{
						this.SpeedMax = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008F45 RID: 36677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F46 RID: 36678
		public const int LogIdFieldNumber = 97;

		// Token: 0x04008F47 RID: 36679
		private long logId_;

		// Token: 0x04008F48 RID: 36680
		public const int ClientTimeFieldNumber = 216;

		// Token: 0x04008F49 RID: 36681
		private string clientTime_ = "";

		// Token: 0x04008F4A RID: 36682
		public const int SpeedMaxFieldNumber = 255;

		// Token: 0x04008F4B RID: 36683
		private int speedMax_;

		// Token: 0x04008F4C RID: 36684
		public const int SpeedMinFieldNumber = 92;

		// Token: 0x04008F4D RID: 36685
		private int speedMin_;

		// Token: 0x04008F4E RID: 36686
		public const int SprintMaxFieldNumber = 203;

		// Token: 0x04008F4F RID: 36687
		private int sprintMax_;

		// Token: 0x04008F50 RID: 36688
		public const int SprintMinFieldNumber = 95;

		// Token: 0x04008F51 RID: 36689
		private int sprintMin_;

		// Token: 0x04008F52 RID: 36690
		public const int SpeedAvgFieldNumber = 145;

		// Token: 0x04008F53 RID: 36691
		private int speedAvg_;

		// Token: 0x04008F54 RID: 36692
		public const int PSReplyTotalFieldNumber = 34;

		// Token: 0x04008F55 RID: 36693
		private int pSReplyTotal_;

		// Token: 0x04008F56 RID: 36694
		public const int PSCostTotalFieldNumber = 79;

		// Token: 0x04008F57 RID: 36695
		private int pSCostTotal_;

		// Token: 0x04008F58 RID: 36696
		public const int PSReplySpeedMaxFieldNumber = 241;

		// Token: 0x04008F59 RID: 36697
		private int pSReplySpeedMax_;

		// Token: 0x04008F5A RID: 36698
		public const int PSReplySpeedMinFieldNumber = 98;

		// Token: 0x04008F5B RID: 36699
		private int pSReplySpeedMin_;

		// Token: 0x04008F5C RID: 36700
		public const int PSUseCountFieldNumber = 218;

		// Token: 0x04008F5D RID: 36701
		private int pSUseCount_;

		// Token: 0x04008F5E RID: 36702
		public const int PSUseNumMaxFieldNumber = 139;

		// Token: 0x04008F5F RID: 36703
		private int pSUseNumMax_;

		// Token: 0x04008F60 RID: 36704
		public const int PSUseNumMinFieldNumber = 147;

		// Token: 0x04008F61 RID: 36705
		private int pSUseNumMin_;

		// Token: 0x04008F62 RID: 36706
		public const int ItemGetCountFieldNumber = 138;

		// Token: 0x04008F63 RID: 36707
		private int itemGetCount_;

		// Token: 0x04008F64 RID: 36708
		public const int ItemGetDistanceMaxFieldNumber = 133;

		// Token: 0x04008F65 RID: 36709
		private int itemGetDistanceMax_;

		// Token: 0x04008F66 RID: 36710
		public const int ItemGetDistanceMinFieldNumber = 20;

		// Token: 0x04008F67 RID: 36711
		private int itemGetDistanceMin_;
	}
}
