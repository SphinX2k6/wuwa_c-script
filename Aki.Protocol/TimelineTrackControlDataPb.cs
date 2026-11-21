using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E9 RID: 5097
	public sealed class TimelineTrackControlDataPb : IMessage<TimelineTrackControlDataPb>, IMessage, IEquatable<TimelineTrackControlDataPb>, IDeepCloneable<TimelineTrackControlDataPb>, IBufferMessage
	{
		// Token: 0x0601B1C8 RID: 111048 RVA: 0x003F24A3 File Offset: 0x003F06A3
		[NullableContext(1)]
		public static TimelineTrackControlDataPb Create()
		{
			return new TimelineTrackControlDataPb();
		}

		// Token: 0x17005BCE RID: 23502
		// (get) Token: 0x0601B1C9 RID: 111049 RVA: 0x003F24AA File Offset: 0x003F06AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TimelineTrackControlDataPb> Parser
		{
			get
			{
				return TimelineTrackControlDataPb._parser;
			}
		}

		// Token: 0x17005BCF RID: 23503
		// (get) Token: 0x0601B1CA RID: 111050 RVA: 0x003F24B1 File Offset: 0x003F06B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD0 RID: 23504
		// (get) Token: 0x0601B1CB RID: 111051 RVA: 0x003F24B4 File Offset: 0x003F06B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTrackControlDataPb.Descriptor;
			}
		}

		// Token: 0x0601B1CC RID: 111052 RVA: 0x003F24BB File Offset: 0x003F06BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackControlDataPb()
		{
		}

		// Token: 0x0601B1CD RID: 111053 RVA: 0x003F24C3 File Offset: 0x003F06C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackControlDataPb(TimelineTrackControlDataPb other) : this()
		{
			this.controlPoint_ = other.controlPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B1CE RID: 111054 RVA: 0x003F24E8 File Offset: 0x003F06E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackControlDataPb Clone()
		{
			return new TimelineTrackControlDataPb(this);
		}

		// Token: 0x17005BD1 RID: 23505
		// (get) Token: 0x0601B1CF RID: 111055 RVA: 0x003F24F0 File Offset: 0x003F06F0
		// (set) Token: 0x0601B1D0 RID: 111056 RVA: 0x003F24F8 File Offset: 0x003F06F8
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

		// Token: 0x0601B1D1 RID: 111057 RVA: 0x003F2501 File Offset: 0x003F0701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTrackControlDataPb);
		}

		// Token: 0x0601B1D2 RID: 111058 RVA: 0x003F250F File Offset: 0x003F070F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTrackControlDataPb other)
		{
			return other != null && (other == this || (this.ControlPoint == other.ControlPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1D3 RID: 111059 RVA: 0x003F2540 File Offset: 0x003F0740
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

		// Token: 0x0601B1D4 RID: 111060 RVA: 0x003F257F File Offset: 0x003F077F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B1D5 RID: 111061 RVA: 0x003F258C File Offset: 0x003F078C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1D6 RID: 111062 RVA: 0x003F2595 File Offset: 0x003F0795
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

		// Token: 0x0601B1D7 RID: 111063 RVA: 0x003F25C8 File Offset: 0x003F07C8
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

		// Token: 0x0601B1D8 RID: 111064 RVA: 0x003F2606 File Offset: 0x003F0806
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

		// Token: 0x0601B1D9 RID: 111065 RVA: 0x003F2637 File Offset: 0x003F0837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B1DA RID: 111066 RVA: 0x003F2640 File Offset: 0x003F0840
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

		// Token: 0x04009E46 RID: 40518
		private static readonly MessageParser<TimelineTrackControlDataPb> _parser = new MessageParser<TimelineTrackControlDataPb>(() => new TimelineTrackControlDataPb());

		// Token: 0x04009E47 RID: 40519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E48 RID: 40520
		public const int ControlPointFieldNumber = 1;

		// Token: 0x04009E49 RID: 40521
		private int controlPoint_;
	}
}
