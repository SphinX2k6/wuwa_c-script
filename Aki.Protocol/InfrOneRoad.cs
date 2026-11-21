using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D5 RID: 2005
	public sealed class InfrOneRoad : IMessage<InfrOneRoad>, IMessage, IEquatable<InfrOneRoad>, IDeepCloneable<InfrOneRoad>, IBufferMessage
	{
		// Token: 0x0600B44D RID: 46157 RVA: 0x001AF144 File Offset: 0x001AD344
		[NullableContext(1)]
		public static InfrOneRoad Create()
		{
			return new InfrOneRoad();
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x0600B44E RID: 46158 RVA: 0x001AF14B File Offset: 0x001AD34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InfrOneRoad> Parser
		{
			get
			{
				return InfrOneRoad._parser;
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x0600B44F RID: 46159 RVA: 0x001AF152 File Offset: 0x001AD352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x0600B450 RID: 46160 RVA: 0x001AF155 File Offset: 0x001AD355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrOneRoad.Descriptor;
			}
		}

		// Token: 0x0600B451 RID: 46161 RVA: 0x001AF15C File Offset: 0x001AD35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrOneRoad()
		{
		}

		// Token: 0x0600B452 RID: 46162 RVA: 0x001AF164 File Offset: 0x001AD364
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

		// Token: 0x0600B453 RID: 46163 RVA: 0x001AF1C4 File Offset: 0x001AD3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrOneRoad Clone()
		{
			return new InfrOneRoad(this);
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x0600B454 RID: 46164 RVA: 0x001AF1CC File Offset: 0x001AD3CC
		// (set) Token: 0x0600B455 RID: 46165 RVA: 0x001AF1D4 File Offset: 0x001AD3D4
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

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x0600B456 RID: 46166 RVA: 0x001AF1DD File Offset: 0x001AD3DD
		// (set) Token: 0x0600B457 RID: 46167 RVA: 0x001AF1E5 File Offset: 0x001AD3E5
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

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x0600B458 RID: 46168 RVA: 0x001AF1EE File Offset: 0x001AD3EE
		// (set) Token: 0x0600B459 RID: 46169 RVA: 0x001AF1F6 File Offset: 0x001AD3F6
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

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x0600B45A RID: 46170 RVA: 0x001AF1FF File Offset: 0x001AD3FF
		// (set) Token: 0x0600B45B RID: 46171 RVA: 0x001AF207 File Offset: 0x001AD407
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

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x0600B45C RID: 46172 RVA: 0x001AF210 File Offset: 0x001AD410
		// (set) Token: 0x0600B45D RID: 46173 RVA: 0x001AF218 File Offset: 0x001AD418
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

		// Token: 0x0600B45E RID: 46174 RVA: 0x001AF221 File Offset: 0x001AD421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrOneRoad);
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x001AF230 File Offset: 0x001AD430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrOneRoad other)
		{
			return other != null && (other == this || (this.RoadId == other.RoadId && this.Status == other.Status && this.CompleteTime == other.CompleteTime && this.TotalGiftCount == other.TotalGiftCount && this.LastGiftTime == other.LastGiftTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x001AF2AC File Offset: 0x001AD4AC
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

		// Token: 0x0600B461 RID: 46177 RVA: 0x001AF355 File Offset: 0x001AD555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B462 RID: 46178 RVA: 0x001AF362 File Offset: 0x001AD562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x001AF36C File Offset: 0x001AD56C
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

		// Token: 0x0600B464 RID: 46180 RVA: 0x001AF418 File Offset: 0x001AD618
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

		// Token: 0x0600B465 RID: 46181 RVA: 0x001AF4B8 File Offset: 0x001AD6B8
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

		// Token: 0x0600B466 RID: 46182 RVA: 0x001AF544 File Offset: 0x001AD744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x001AF550 File Offset: 0x001AD750
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

		// Token: 0x0400508B RID: 20619
		private static readonly MessageParser<InfrOneRoad> _parser = new MessageParser<InfrOneRoad>(() => new InfrOneRoad());

		// Token: 0x0400508C RID: 20620
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400508D RID: 20621
		public const int RoadIdFieldNumber = 1;

		// Token: 0x0400508E RID: 20622
		private int roadId_;

		// Token: 0x0400508F RID: 20623
		public const int StatusFieldNumber = 2;

		// Token: 0x04005090 RID: 20624
		private InfrStatusPb status_;

		// Token: 0x04005091 RID: 20625
		public const int CompleteTimeFieldNumber = 3;

		// Token: 0x04005092 RID: 20626
		private long completeTime_;

		// Token: 0x04005093 RID: 20627
		public const int TotalGiftCountFieldNumber = 4;

		// Token: 0x04005094 RID: 20628
		private long totalGiftCount_;

		// Token: 0x04005095 RID: 20629
		public const int LastGiftTimeFieldNumber = 5;

		// Token: 0x04005096 RID: 20630
		private long lastGiftTime_;
	}
}
