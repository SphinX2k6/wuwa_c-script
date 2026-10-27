using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E9 RID: 2025
	public sealed class InfrOneRoad : IMessage<InfrOneRoad>, IMessage, IEquatable<InfrOneRoad>, IDeepCloneable<InfrOneRoad>, IBufferMessage
	{
		// Token: 0x0600B5A3 RID: 46499 RVA: 0x001B1B78 File Offset: 0x001AFD78
		[NullableContext(1)]
		public static InfrOneRoad Create()
		{
			return new InfrOneRoad();
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600B5A4 RID: 46500 RVA: 0x001B1B7F File Offset: 0x001AFD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InfrOneRoad> Parser
		{
			get
			{
				return InfrOneRoad._parser;
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x0600B5A5 RID: 46501 RVA: 0x001B1B86 File Offset: 0x001AFD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x0600B5A6 RID: 46502 RVA: 0x001B1B89 File Offset: 0x001AFD89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrOneRoad.Descriptor;
			}
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x001B1B90 File Offset: 0x001AFD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrOneRoad()
		{
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x001B1B98 File Offset: 0x001AFD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrOneRoad(InfrOneRoad other) : this()
		{
			this.roadId_ = other.roadId_;
			this.status_ = other.status_;
			this.completeTime_ = other.completeTime_;
			this.totalGiftCount_ = other.totalGiftCount_;
			this.lastGiftTime_ = other.lastGiftTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x001B1BF8 File Offset: 0x001AFDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrOneRoad Clone()
		{
			return new InfrOneRoad(this);
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x0600B5AA RID: 46506 RVA: 0x001B1C00 File Offset: 0x001AFE00
		// (set) Token: 0x0600B5AB RID: 46507 RVA: 0x001B1C08 File Offset: 0x001AFE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoadId
		{
			get
			{
				return this.roadId_;
			}
			set
			{
				this.roadId_ = value;
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x0600B5AC RID: 46508 RVA: 0x001B1C11 File Offset: 0x001AFE11
		// (set) Token: 0x0600B5AD RID: 46509 RVA: 0x001B1C19 File Offset: 0x001AFE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrStatusPb Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x0600B5AE RID: 46510 RVA: 0x001B1C22 File Offset: 0x001AFE22
		// (set) Token: 0x0600B5AF RID: 46511 RVA: 0x001B1C2A File Offset: 0x001AFE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CompleteTime
		{
			get
			{
				return this.completeTime_;
			}
			set
			{
				this.completeTime_ = value;
			}
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x0600B5B0 RID: 46512 RVA: 0x001B1C33 File Offset: 0x001AFE33
		// (set) Token: 0x0600B5B1 RID: 46513 RVA: 0x001B1C3B File Offset: 0x001AFE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalGiftCount
		{
			get
			{
				return this.totalGiftCount_;
			}
			set
			{
				this.totalGiftCount_ = value;
			}
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x0600B5B2 RID: 46514 RVA: 0x001B1C44 File Offset: 0x001AFE44
		// (set) Token: 0x0600B5B3 RID: 46515 RVA: 0x001B1C4C File Offset: 0x001AFE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastGiftTime
		{
			get
			{
				return this.lastGiftTime_;
			}
			set
			{
				this.lastGiftTime_ = value;
			}
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x001B1C55 File Offset: 0x001AFE55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrOneRoad);
		}

		// Token: 0x0600B5B5 RID: 46517 RVA: 0x001B1C64 File Offset: 0x001AFE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrOneRoad other)
		{
			return other != null && (other == this || (this.RoadId == other.RoadId && this.Status == other.Status && this.CompleteTime == other.CompleteTime && this.TotalGiftCount == other.TotalGiftCount && this.LastGiftTime == other.LastGiftTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5B6 RID: 46518 RVA: 0x001B1CE0 File Offset: 0x001AFEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoadId != 0)
			{
				num ^= this.RoadId.GetHashCode();
			}
			if (this.Status != InfrStatusPb.InfrStatusLock)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.CompleteTime != 0L)
			{
				num ^= this.CompleteTime.GetHashCode();
			}
			if (this.TotalGiftCount != 0L)
			{
				num ^= this.TotalGiftCount.GetHashCode();
			}
			if (this.LastGiftTime != 0L)
			{
				num ^= this.LastGiftTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B5B7 RID: 46519 RVA: 0x001B1D89 File Offset: 0x001AFF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5B8 RID: 46520 RVA: 0x001B1D96 File Offset: 0x001AFF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5B9 RID: 46521 RVA: 0x001B1DA0 File Offset: 0x001AFFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoadId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoadId);
			}
			if (this.Status != InfrStatusPb.InfrStatusLock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this.CompleteTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CompleteTime);
			}
			if (this.TotalGiftCount != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TotalGiftCount);
			}
			if (this.LastGiftTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.LastGiftTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5BA RID: 46522 RVA: 0x001B1E4C File Offset: 0x001B004C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoadId);
			}
			if (this.Status != InfrStatusPb.InfrStatusLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.CompleteTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CompleteTime);
			}
			if (this.TotalGiftCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalGiftCount);
			}
			if (this.LastGiftTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastGiftTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x001B1EEC File Offset: 0x001B00EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrOneRoad other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoadId != 0)
			{
				this.RoadId = other.RoadId;
			}
			if (other.Status != InfrStatusPb.InfrStatusLock)
			{
				this.Status = other.Status;
			}
			if (other.CompleteTime != 0L)
			{
				this.CompleteTime = other.CompleteTime;
			}
			if (other.TotalGiftCount != 0L)
			{
				this.TotalGiftCount = other.TotalGiftCount;
			}
			if (other.LastGiftTime != 0L)
			{
				this.LastGiftTime = other.LastGiftTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5BC RID: 46524 RVA: 0x001B1F78 File Offset: 0x001B0178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x001B1F84 File Offset: 0x001B0184
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoadId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Status = (InfrStatusPb)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CompleteTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.TotalGiftCount = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.LastGiftTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005092 RID: 20626
		private static readonly MessageParser<InfrOneRoad> _parser = new MessageParser<InfrOneRoad>(() => new InfrOneRoad());

		// Token: 0x04005093 RID: 20627
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005094 RID: 20628
		public const int RoadIdFieldNumber = 1;

		// Token: 0x04005095 RID: 20629
		private int roadId_;

		// Token: 0x04005096 RID: 20630
		public const int StatusFieldNumber = 2;

		// Token: 0x04005097 RID: 20631
		private InfrStatusPb status_;

		// Token: 0x04005098 RID: 20632
		public const int CompleteTimeFieldNumber = 3;

		// Token: 0x04005099 RID: 20633
		private long completeTime_;

		// Token: 0x0400509A RID: 20634
		public const int TotalGiftCountFieldNumber = 4;

		// Token: 0x0400509B RID: 20635
		private long totalGiftCount_;

		// Token: 0x0400509C RID: 20636
		public const int LastGiftTimeFieldNumber = 5;

		// Token: 0x0400509D RID: 20637
		private long lastGiftTime_;
	}
}
