using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001376 RID: 4982
	public sealed class TimelineTrackControlDataPb : IMessage<TimelineTrackControlDataPb>, IMessage, IEquatable<TimelineTrackControlDataPb>, IDeepCloneable<TimelineTrackControlDataPb>, IBufferMessage
	{
		// Token: 0x0601A73F RID: 108351 RVA: 0x003D728F File Offset: 0x003D548F
		[NullableContext(1)]
		public static TimelineTrackControlDataPb Create()
		{
			return new TimelineTrackControlDataPb();
		}

		// Token: 0x1700593A RID: 22842
		// (get) Token: 0x0601A740 RID: 108352 RVA: 0x003D7296 File Offset: 0x003D5496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TimelineTrackControlDataPb> Parser
		{
			get
			{
				return TimelineTrackControlDataPb._parser;
			}
		}

		// Token: 0x1700593B RID: 22843
		// (get) Token: 0x0601A741 RID: 108353 RVA: 0x003D729D File Offset: 0x003D549D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700593C RID: 22844
		// (get) Token: 0x0601A742 RID: 108354 RVA: 0x003D72A0 File Offset: 0x003D54A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTrackControlDataPb.Descriptor;
			}
		}

		// Token: 0x0601A743 RID: 108355 RVA: 0x003D72A7 File Offset: 0x003D54A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackControlDataPb()
		{
		}

		// Token: 0x0601A744 RID: 108356 RVA: 0x003D72AF File Offset: 0x003D54AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackControlDataPb(TimelineTrackControlDataPb other) : this()
		{
			this.controlPoint_ = other.controlPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A745 RID: 108357 RVA: 0x003D72D4 File Offset: 0x003D54D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackControlDataPb Clone()
		{
			return new TimelineTrackControlDataPb(this);
		}

		// Token: 0x1700593D RID: 22845
		// (get) Token: 0x0601A746 RID: 108358 RVA: 0x003D72DC File Offset: 0x003D54DC
		// (set) Token: 0x0601A747 RID: 108359 RVA: 0x003D72E4 File Offset: 0x003D54E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ControlPoint
		{
			get
			{
				return this.controlPoint_;
			}
			set
			{
				this.controlPoint_ = value;
			}
		}

		// Token: 0x0601A748 RID: 108360 RVA: 0x003D72ED File Offset: 0x003D54ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTrackControlDataPb);
		}

		// Token: 0x0601A749 RID: 108361 RVA: 0x003D72FB File Offset: 0x003D54FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTrackControlDataPb other)
		{
			return other != null && (other == this || (this.ControlPoint == other.ControlPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A74A RID: 108362 RVA: 0x003D732C File Offset: 0x003D552C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ControlPoint != 0)
			{
				num ^= this.ControlPoint.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A74B RID: 108363 RVA: 0x003D736B File Offset: 0x003D556B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A74C RID: 108364 RVA: 0x003D7378 File Offset: 0x003D5578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A74D RID: 108365 RVA: 0x003D7381 File Offset: 0x003D5581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ControlPoint != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ControlPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A74E RID: 108366 RVA: 0x003D73B4 File Offset: 0x003D55B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ControlPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ControlPoint);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A74F RID: 108367 RVA: 0x003D73F2 File Offset: 0x003D55F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTrackControlDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ControlPoint != 0)
			{
				this.ControlPoint = other.ControlPoint;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A750 RID: 108368 RVA: 0x003D7423 File Offset: 0x003D5623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A751 RID: 108369 RVA: 0x003D742C File Offset: 0x003D562C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ControlPoint = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A01 RID: 39425
		private static readonly MessageParser<TimelineTrackControlDataPb> _parser = new MessageParser<TimelineTrackControlDataPb>(() => new TimelineTrackControlDataPb());

		// Token: 0x04009A02 RID: 39426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A03 RID: 39427
		public const int ControlPointFieldNumber = 1;

		// Token: 0x04009A04 RID: 39428
		private int controlPoint_;
	}
}
