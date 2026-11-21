using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E3 RID: 5091
	[NetMessage(EMessageId.TimelineTraceControlResponse)]
	public sealed class TimelineTraceControlResponse : IMessage<TimelineTraceControlResponse>, IMessage, IEquatable<TimelineTraceControlResponse>, IDeepCloneable<TimelineTraceControlResponse>, IBufferMessage
	{
		// Token: 0x0601B14F RID: 110927 RVA: 0x003F145C File Offset: 0x003EF65C
		[NullableContext(1)]
		public static TimelineTraceControlResponse Create()
		{
			return new TimelineTraceControlResponse();
		}

		// Token: 0x17005BB5 RID: 23477
		// (get) Token: 0x0601B150 RID: 110928 RVA: 0x003F1463 File Offset: 0x003EF663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BB6 RID: 23478
		// (get) Token: 0x0601B151 RID: 110929 RVA: 0x003F1466 File Offset: 0x003EF666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceControlResponse.Descriptor;
			}
		}

		// Token: 0x0601B152 RID: 110930 RVA: 0x003F146D File Offset: 0x003EF66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlResponse()
		{
		}

		// Token: 0x0601B153 RID: 110931 RVA: 0x003F1475 File Offset: 0x003EF675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlResponse(TimelineTraceControlResponse other) : this()
		{
			this.code_ = other.code_;
			this.controlPoint_ = other.controlPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B154 RID: 110932 RVA: 0x003F14A6 File Offset: 0x003EF6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceControlResponse Clone()
		{
			return new TimelineTraceControlResponse(this);
		}

		// Token: 0x17005BB7 RID: 23479
		// (get) Token: 0x0601B155 RID: 110933 RVA: 0x003F14AE File Offset: 0x003EF6AE
		// (set) Token: 0x0601B156 RID: 110934 RVA: 0x003F14B6 File Offset: 0x003EF6B6
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

		// Token: 0x17005BB8 RID: 23480
		// (get) Token: 0x0601B157 RID: 110935 RVA: 0x003F14BF File Offset: 0x003EF6BF
		// (set) Token: 0x0601B158 RID: 110936 RVA: 0x003F14C7 File Offset: 0x003EF6C7
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

		// Token: 0x0601B159 RID: 110937 RVA: 0x003F14D0 File Offset: 0x003EF6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceControlResponse);
		}

		// Token: 0x0601B15A RID: 110938 RVA: 0x003F14DE File Offset: 0x003EF6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceControlResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.ControlPoint == other.ControlPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B15B RID: 110939 RVA: 0x003F151C File Offset: 0x003EF71C
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

		// Token: 0x0601B15C RID: 110940 RVA: 0x003F157A File Offset: 0x003EF77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B15D RID: 110941 RVA: 0x003F1587 File Offset: 0x003EF787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B15E RID: 110942 RVA: 0x003F1590 File Offset: 0x003EF790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ControlPoint != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ControlPoint);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B15F RID: 110943 RVA: 0x003F15EC File Offset: 0x003EF7EC
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

		// Token: 0x0601B160 RID: 110944 RVA: 0x003F1644 File Offset: 0x003EF844
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

		// Token: 0x0601B161 RID: 110945 RVA: 0x003F1694 File Offset: 0x003EF894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B162 RID: 110946 RVA: 0x003F16A0 File Offset: 0x003EF8A0
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
				if (num != 64U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ControlPoint = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E23 RID: 40483
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E24 RID: 40484
		public const int CodeFieldNumber = 11;

		// Token: 0x04009E25 RID: 40485
		private ErrorCode code_;

		// Token: 0x04009E26 RID: 40486
		public const int ControlPointFieldNumber = 8;

		// Token: 0x04009E27 RID: 40487
		private int controlPoint_;
	}
}
