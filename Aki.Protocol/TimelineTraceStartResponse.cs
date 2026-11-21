using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013E7 RID: 5095
	[NetMessage(EMessageId.TimelineTraceStartResponse)]
	public sealed class TimelineTraceStartResponse : IMessage<TimelineTraceStartResponse>, IMessage, IEquatable<TimelineTraceStartResponse>, IDeepCloneable<TimelineTraceStartResponse>, IBufferMessage
	{
		// Token: 0x0601B19B RID: 111003 RVA: 0x003F1D4C File Offset: 0x003EFF4C
		[NullableContext(1)]
		public static TimelineTraceStartResponse Create()
		{
			return new TimelineTraceStartResponse();
		}

		// Token: 0x17005BC3 RID: 23491
		// (get) Token: 0x0601B19C RID: 111004 RVA: 0x003F1D53 File Offset: 0x003EFF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BC4 RID: 23492
		// (get) Token: 0x0601B19D RID: 111005 RVA: 0x003F1D56 File Offset: 0x003EFF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceStartResponse.Descriptor;
			}
		}

		// Token: 0x0601B19E RID: 111006 RVA: 0x003F1D5D File Offset: 0x003EFF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartResponse()
		{
		}

		// Token: 0x0601B19F RID: 111007 RVA: 0x003F1D7C File Offset: 0x003EFF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartResponse(TimelineTraceStartResponse other) : this()
		{
			this.code_ = other.code_;
			this.index_ = other.index_;
			this.controlPoint_ = other.controlPoint_;
			this.entityIds_ = other.entityIds_.Clone();
			this.pointDatas_ = other.pointDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B1A0 RID: 111008 RVA: 0x003F1DE6 File Offset: 0x003EFFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartResponse Clone()
		{
			return new TimelineTraceStartResponse(this);
		}

		// Token: 0x17005BC5 RID: 23493
		// (get) Token: 0x0601B1A1 RID: 111009 RVA: 0x003F1DEE File Offset: 0x003EFFEE
		// (set) Token: 0x0601B1A2 RID: 111010 RVA: 0x003F1DF6 File Offset: 0x003EFFF6
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

		// Token: 0x17005BC6 RID: 23494
		// (get) Token: 0x0601B1A3 RID: 111011 RVA: 0x003F1DFF File Offset: 0x003EFFFF
		// (set) Token: 0x0601B1A4 RID: 111012 RVA: 0x003F1E07 File Offset: 0x003F0007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17005BC7 RID: 23495
		// (get) Token: 0x0601B1A5 RID: 111013 RVA: 0x003F1E10 File Offset: 0x003F0010
		// (set) Token: 0x0601B1A6 RID: 111014 RVA: 0x003F1E18 File Offset: 0x003F0018
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

		// Token: 0x17005BC8 RID: 23496
		// (get) Token: 0x0601B1A7 RID: 111015 RVA: 0x003F1E21 File Offset: 0x003F0021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x17005BC9 RID: 23497
		// (get) Token: 0x0601B1A8 RID: 111016 RVA: 0x003F1E29 File Offset: 0x003F0029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ControlPointData> PointDatas
		{
			get
			{
				return this.pointDatas_;
			}
		}

		// Token: 0x0601B1A9 RID: 111017 RVA: 0x003F1E31 File Offset: 0x003F0031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceStartResponse);
		}

		// Token: 0x0601B1AA RID: 111018 RVA: 0x003F1E40 File Offset: 0x003F0040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceStartResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Index == other.Index && this.ControlPoint == other.ControlPoint && this.entityIds_.Equals(other.entityIds_) && this.pointDatas_.Equals(other.pointDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1AB RID: 111019 RVA: 0x003F1EC4 File Offset: 0x003F00C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.ControlPoint != 0)
			{
				num ^= this.ControlPoint.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			num ^= this.pointDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B1AC RID: 111020 RVA: 0x003F1F57 File Offset: 0x003F0157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B1AD RID: 111021 RVA: 0x003F1F64 File Offset: 0x003F0164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1AE RID: 111022 RVA: 0x003F1F70 File Offset: 0x003F0170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.ControlPoint != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ControlPoint);
			}
			this.entityIds_.WriteTo(ref output, TimelineTraceStartResponse._repeated_entityIds_codec);
			this.pointDatas_.WriteTo(ref output, TimelineTraceStartResponse._repeated_pointDatas_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B1AF RID: 111023 RVA: 0x003F2008 File Offset: 0x003F0208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.ControlPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ControlPoint);
			}
			num += this.entityIds_.CalculateSize(TimelineTraceStartResponse._repeated_entityIds_codec);
			num += this.pointDatas_.CalculateSize(TimelineTraceStartResponse._repeated_pointDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B1B0 RID: 111024 RVA: 0x003F209C File Offset: 0x003F029C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimelineTraceStartResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.ControlPoint != 0)
			{
				this.ControlPoint = other.ControlPoint;
			}
			this.entityIds_.Add(other.entityIds_);
			this.pointDatas_.Add(other.pointDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B1B1 RID: 111025 RVA: 0x003F2122 File Offset: 0x003F0322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B1B2 RID: 111026 RVA: 0x003F212C File Offset: 0x003F032C
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
				if (num <= 48U)
				{
					if (num == 16U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ControlPoint = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						goto IL_61;
					}
				}
				else
				{
					if (num == 50U)
					{
						goto IL_61;
					}
					if (num == 58U)
					{
						this.pointDatas_.AddEntriesFrom(ref input, TimelineTraceStartResponse._repeated_pointDatas_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_61:
				this.entityIds_.AddEntriesFrom(ref input, TimelineTraceStartResponse._repeated_entityIds_codec);
			}
		}

		// Token: 0x04009E33 RID: 40499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E34 RID: 40500
		public const int CodeFieldNumber = 14;

		// Token: 0x04009E35 RID: 40501
		private ErrorCode code_;

		// Token: 0x04009E36 RID: 40502
		public const int IndexFieldNumber = 2;

		// Token: 0x04009E37 RID: 40503
		private int index_;

		// Token: 0x04009E38 RID: 40504
		public const int ControlPointFieldNumber = 4;

		// Token: 0x04009E39 RID: 40505
		private int controlPoint_;

		// Token: 0x04009E3A RID: 40506
		public const int EntityIdsFieldNumber = 6;

		// Token: 0x04009E3B RID: 40507
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(50U);

		// Token: 0x04009E3C RID: 40508
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();

		// Token: 0x04009E3D RID: 40509
		public const int PointDatasFieldNumber = 7;

		// Token: 0x04009E3E RID: 40510
		private static readonly FieldCodec<ControlPointData> _repeated_pointDatas_codec = FieldCodec.ForMessage<ControlPointData>(58U, ControlPointData.Parser);

		// Token: 0x04009E3F RID: 40511
		private readonly RepeatedField<ControlPointData> pointDatas_ = new RepeatedField<ControlPointData>();
	}
}
