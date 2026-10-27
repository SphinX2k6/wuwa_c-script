using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001370 RID: 4976
	[NetMessage(EMessageId.TimelineTraceControlResponse)]
	public sealed class TimelineTraceControlResponse : IMessage<TimelineTraceControlResponse>, IMessage, IEquatable<TimelineTraceControlResponse>, IDeepCloneable<TimelineTraceControlResponse>, IBufferMessage
	{
		// Token: 0x0601A6C6 RID: 108230 RVA: 0x003D624C File Offset: 0x003D444C
		[NullableContext(1)]
		public static TimelineTraceControlResponse Create()
		{
			return new TimelineTraceControlResponse();
		}

		// Token: 0x17005921 RID: 22817
		// (get) Token: 0x0601A6C7 RID: 108231 RVA: 0x003D6253 File Offset: 0x003D4453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005922 RID: 22818
		// (get) Token: 0x0601A6C8 RID: 108232 RVA: 0x003D6256 File Offset: 0x003D4456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceControlResponse.Descriptor;
			}
		}

		// Token: 0x0601A6C9 RID: 108233 RVA: 0x003D625D File Offset: 0x003D445D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlResponse()
		{
		}

		// Token: 0x0601A6CA RID: 108234 RVA: 0x003D6265 File Offset: 0x003D4465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlResponse(TimelineTraceControlResponse other) : this()
		{
			this.code_ = other.code_;
			this.controlPoint_ = other.controlPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A6CB RID: 108235 RVA: 0x003D6296 File Offset: 0x003D4496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlResponse Clone()
		{
			return new TimelineTraceControlResponse(this);
		}

		// Token: 0x17005923 RID: 22819
		// (get) Token: 0x0601A6CC RID: 108236 RVA: 0x003D629E File Offset: 0x003D449E
		// (set) Token: 0x0601A6CD RID: 108237 RVA: 0x003D62A6 File Offset: 0x003D44A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17005924 RID: 22820
		// (get) Token: 0x0601A6CE RID: 108238 RVA: 0x003D62AF File Offset: 0x003D44AF
		// (set) Token: 0x0601A6CF RID: 108239 RVA: 0x003D62B7 File Offset: 0x003D44B7
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

		// Token: 0x0601A6D0 RID: 108240 RVA: 0x003D62C0 File Offset: 0x003D44C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceControlResponse);
		}

		// Token: 0x0601A6D1 RID: 108241 RVA: 0x003D62CE File Offset: 0x003D44CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceControlResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.ControlPoint == other.ControlPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A6D2 RID: 108242 RVA: 0x003D630C File Offset: 0x003D450C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
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

		// Token: 0x0601A6D3 RID: 108243 RVA: 0x003D636A File Offset: 0x003D456A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6D4 RID: 108244 RVA: 0x003D6377 File Offset: 0x003D4577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6D5 RID: 108245 RVA: 0x003D6380 File Offset: 0x003D4580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this.ControlPoint != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ControlPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A6D6 RID: 108246 RVA: 0x003D63DC File Offset: 0x003D45DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
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

		// Token: 0x0601A6D7 RID: 108247 RVA: 0x003D6434 File Offset: 0x003D4634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceControlResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.ControlPoint != 0)
			{
				this.ControlPoint = other.ControlPoint;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A6D8 RID: 108248 RVA: 0x003D6484 File Offset: 0x003D4684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6D9 RID: 108249 RVA: 0x003D6490 File Offset: 0x003D4690
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ControlPoint = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040099DE RID: 39390
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099DF RID: 39391
		public const int CodeFieldNumber = 2;

		// Token: 0x040099E0 RID: 39392
		private ErrorCode code_;

		// Token: 0x040099E1 RID: 39393
		public const int ControlPointFieldNumber = 9;

		// Token: 0x040099E2 RID: 39394
		private int controlPoint_;
	}
}
