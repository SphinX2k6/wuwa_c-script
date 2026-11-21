using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CA RID: 4298
	[NetMessage(EMessageId.RoleTowerFloorSettleNotify)]
	public sealed class RoleTowerFloorSettleNotify : IMessage<RoleTowerFloorSettleNotify>, IMessage, IEquatable<RoleTowerFloorSettleNotify>, IDeepCloneable<RoleTowerFloorSettleNotify>, IBufferMessage
	{
		// Token: 0x06016F92 RID: 94098 RVA: 0x00357428 File Offset: 0x00355628
		[NullableContext(1)]
		public static RoleTowerFloorSettleNotify Create()
		{
			return new RoleTowerFloorSettleNotify();
		}

		// Token: 0x17004D10 RID: 19728
		// (get) Token: 0x06016F93 RID: 94099 RVA: 0x0035742F File Offset: 0x0035562F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D11 RID: 19729
		// (get) Token: 0x06016F94 RID: 94100 RVA: 0x00357432 File Offset: 0x00355632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerFloorSettleNotify.Descriptor;
			}
		}

		// Token: 0x06016F95 RID: 94101 RVA: 0x00357439 File Offset: 0x00355639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorSettleNotify()
		{
		}

		// Token: 0x06016F96 RID: 94102 RVA: 0x00357444 File Offset: 0x00355644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorSettleNotify(RoleTowerFloorSettleNotify other) : this()
		{
			this.floorId_ = other.floorId_;
			this.totalGainTimeMs_ = other.totalGainTimeMs_;
			this.totalCostTimeMs_ = other.totalCostTimeMs_;
			this.remainTimeMs_ = other.remainTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F97 RID: 94103 RVA: 0x00357498 File Offset: 0x00355698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorSettleNotify Clone()
		{
			return new RoleTowerFloorSettleNotify(this);
		}

		// Token: 0x17004D12 RID: 19730
		// (get) Token: 0x06016F98 RID: 94104 RVA: 0x003574A0 File Offset: 0x003556A0
		// (set) Token: 0x06016F99 RID: 94105 RVA: 0x003574A8 File Offset: 0x003556A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FloorId
		{
			get
			{
				return this.floorId_;
			}
			set
			{
				this.floorId_ = value;
			}
		}

		// Token: 0x17004D13 RID: 19731
		// (get) Token: 0x06016F9A RID: 94106 RVA: 0x003574B1 File Offset: 0x003556B1
		// (set) Token: 0x06016F9B RID: 94107 RVA: 0x003574B9 File Offset: 0x003556B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalGainTimeMs
		{
			get
			{
				return this.totalGainTimeMs_;
			}
			set
			{
				this.totalGainTimeMs_ = value;
			}
		}

		// Token: 0x17004D14 RID: 19732
		// (get) Token: 0x06016F9C RID: 94108 RVA: 0x003574C2 File Offset: 0x003556C2
		// (set) Token: 0x06016F9D RID: 94109 RVA: 0x003574CA File Offset: 0x003556CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalCostTimeMs
		{
			get
			{
				return this.totalCostTimeMs_;
			}
			set
			{
				this.totalCostTimeMs_ = value;
			}
		}

		// Token: 0x17004D15 RID: 19733
		// (get) Token: 0x06016F9E RID: 94110 RVA: 0x003574D3 File Offset: 0x003556D3
		// (set) Token: 0x06016F9F RID: 94111 RVA: 0x003574DB File Offset: 0x003556DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RemainTimeMs
		{
			get
			{
				return this.remainTimeMs_;
			}
			set
			{
				this.remainTimeMs_ = value;
			}
		}

		// Token: 0x06016FA0 RID: 94112 RVA: 0x003574E4 File Offset: 0x003556E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerFloorSettleNotify);
		}

		// Token: 0x06016FA1 RID: 94113 RVA: 0x003574F4 File Offset: 0x003556F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerFloorSettleNotify other)
		{
			return other != null && (other == this || (this.FloorId == other.FloorId && this.TotalGainTimeMs == other.TotalGainTimeMs && this.TotalCostTimeMs == other.TotalCostTimeMs && this.RemainTimeMs == other.RemainTimeMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FA2 RID: 94114 RVA: 0x00357560 File Offset: 0x00355760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FloorId != 0)
			{
				num ^= this.FloorId.GetHashCode();
			}
			if (this.TotalGainTimeMs != 0L)
			{
				num ^= this.TotalGainTimeMs.GetHashCode();
			}
			if (this.TotalCostTimeMs != 0L)
			{
				num ^= this.TotalCostTimeMs.GetHashCode();
			}
			if (this.RemainTimeMs != 0L)
			{
				num ^= this.RemainTimeMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016FA3 RID: 94115 RVA: 0x003575EA File Offset: 0x003557EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FA4 RID: 94116 RVA: 0x003575F7 File Offset: 0x003557F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FA5 RID: 94117 RVA: 0x00357600 File Offset: 0x00355800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RemainTimeMs != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.RemainTimeMs);
			}
			if (this.TotalCostTimeMs != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.TotalCostTimeMs);
			}
			if (this.FloorId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FloorId);
			}
			if (this.TotalGainTimeMs != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TotalGainTimeMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016FA6 RID: 94118 RVA: 0x00357694 File Offset: 0x00355894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FloorId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FloorId);
			}
			if (this.TotalGainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalGainTimeMs);
			}
			if (this.TotalCostTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalCostTimeMs);
			}
			if (this.RemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RemainTimeMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016FA7 RID: 94119 RVA: 0x0035771C File Offset: 0x0035591C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerFloorSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FloorId != 0)
			{
				this.FloorId = other.FloorId;
			}
			if (other.TotalGainTimeMs != 0L)
			{
				this.TotalGainTimeMs = other.TotalGainTimeMs;
			}
			if (other.TotalCostTimeMs != 0L)
			{
				this.TotalCostTimeMs = other.TotalCostTimeMs;
			}
			if (other.RemainTimeMs != 0L)
			{
				this.RemainTimeMs = other.RemainTimeMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016FA8 RID: 94120 RVA: 0x00357794 File Offset: 0x00355994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FA9 RID: 94121 RVA: 0x003577A0 File Offset: 0x003559A0
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
				if (num <= 64U)
				{
					if (num == 24U)
					{
						this.RemainTimeMs = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.TotalCostTimeMs = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.FloorId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.TotalGainTimeMs = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400897E RID: 35198
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400897F RID: 35199
		public const int FloorIdFieldNumber = 9;

		// Token: 0x04008980 RID: 35200
		private int floorId_;

		// Token: 0x04008981 RID: 35201
		public const int TotalGainTimeMsFieldNumber = 15;

		// Token: 0x04008982 RID: 35202
		private long totalGainTimeMs_;

		// Token: 0x04008983 RID: 35203
		public const int TotalCostTimeMsFieldNumber = 8;

		// Token: 0x04008984 RID: 35204
		private long totalCostTimeMs_;

		// Token: 0x04008985 RID: 35205
		public const int RemainTimeMsFieldNumber = 3;

		// Token: 0x04008986 RID: 35206
		private long remainTimeMs_;
	}
}
