using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001374 RID: 4980
	[NetMessage(EMessageId.TimelineTraceStartResponse)]
	public sealed class TimelineTraceStartResponse : IMessage<TimelineTraceStartResponse>, IMessage, IEquatable<TimelineTraceStartResponse>, IDeepCloneable<TimelineTraceStartResponse>, IBufferMessage
	{
		// Token: 0x0601A712 RID: 108306 RVA: 0x003D6B37 File Offset: 0x003D4D37
		[NullableContext(1)]
		public static TimelineTraceStartResponse Create()
		{
			return new TimelineTraceStartResponse();
		}

		// Token: 0x1700592F RID: 22831
		// (get) Token: 0x0601A713 RID: 108307 RVA: 0x003D6B3E File Offset: 0x003D4D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005930 RID: 22832
		// (get) Token: 0x0601A714 RID: 108308 RVA: 0x003D6B41 File Offset: 0x003D4D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimelineTraceStartResponse.Descriptor;
			}
		}

		// Token: 0x0601A715 RID: 108309 RVA: 0x003D6B48 File Offset: 0x003D4D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartResponse()
		{
		}

		// Token: 0x0601A716 RID: 108310 RVA: 0x003D6B68 File Offset: 0x003D4D68
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

		// Token: 0x0601A717 RID: 108311 RVA: 0x003D6BD2 File Offset: 0x003D4DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTraceStartResponse Clone()
		{
			return new TimelineTraceStartResponse(this);
		}

		// Token: 0x17005931 RID: 22833
		// (get) Token: 0x0601A718 RID: 108312 RVA: 0x003D6BDA File Offset: 0x003D4DDA
		// (set) Token: 0x0601A719 RID: 108313 RVA: 0x003D6BE2 File Offset: 0x003D4DE2
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

		// Token: 0x17005932 RID: 22834
		// (get) Token: 0x0601A71A RID: 108314 RVA: 0x003D6BEB File Offset: 0x003D4DEB
		// (set) Token: 0x0601A71B RID: 108315 RVA: 0x003D6BF3 File Offset: 0x003D4DF3
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

		// Token: 0x17005933 RID: 22835
		// (get) Token: 0x0601A71C RID: 108316 RVA: 0x003D6BFC File Offset: 0x003D4DFC
		// (set) Token: 0x0601A71D RID: 108317 RVA: 0x003D6C04 File Offset: 0x003D4E04
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

		// Token: 0x17005934 RID: 22836
		// (get) Token: 0x0601A71E RID: 108318 RVA: 0x003D6C0D File Offset: 0x003D4E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x17005935 RID: 22837
		// (get) Token: 0x0601A71F RID: 108319 RVA: 0x003D6C15 File Offset: 0x003D4E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ControlPointData> PointDatas
		{
			get
			{
				return this.pointDatas_;
			}
		}

		// Token: 0x0601A720 RID: 108320 RVA: 0x003D6C1D File Offset: 0x003D4E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimelineTraceStartResponse);
		}

		// Token: 0x0601A721 RID: 108321 RVA: 0x003D6C2C File Offset: 0x003D4E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimelineTraceStartResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Index == other.Index && this.ControlPoint == other.ControlPoint && this.entityIds_.Equals(other.entityIds_) && this.pointDatas_.Equals(other.pointDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A722 RID: 108322 RVA: 0x003D6CB0 File Offset: 0x003D4EB0
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

		// Token: 0x0601A723 RID: 108323 RVA: 0x003D6D43 File Offset: 0x003D4F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A724 RID: 108324 RVA: 0x003D6D50 File Offset: 0x003D4F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A725 RID: 108325 RVA: 0x003D6D5C File Offset: 0x003D4F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ControlPoint != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ControlPoint);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Index);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			this.pointDatas_.WriteTo(ref output, TimelineTraceStartResponse._repeated_pointDatas_codec);
			this.entityIds_.WriteTo(ref output, TimelineTraceStartResponse._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A726 RID: 108326 RVA: 0x003D6DF4 File Offset: 0x003D4FF4
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

		// Token: 0x0601A727 RID: 108327 RVA: 0x003D6E88 File Offset: 0x003D5088
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

		// Token: 0x0601A728 RID: 108328 RVA: 0x003D6F0E File Offset: 0x003D510E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A729 RID: 108329 RVA: 0x003D6F18 File Offset: 0x003D5118
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
					if (num == 16U)
					{
						this.ControlPoint = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.pointDatas_.AddEntriesFrom(ref input, TimelineTraceStartResponse._repeated_pointDatas_codec);
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.entityIds_.AddEntriesFrom(ref input, TimelineTraceStartResponse._repeated_entityIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040099EE RID: 39406
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099EF RID: 39407
		public const int CodeFieldNumber = 8;

		// Token: 0x040099F0 RID: 39408
		private ErrorCode code_;

		// Token: 0x040099F1 RID: 39409
		public const int IndexFieldNumber = 5;

		// Token: 0x040099F2 RID: 39410
		private int index_;

		// Token: 0x040099F3 RID: 39411
		public const int ControlPointFieldNumber = 2;

		// Token: 0x040099F4 RID: 39412
		private int controlPoint_;

		// Token: 0x040099F5 RID: 39413
		public const int EntityIdsFieldNumber = 14;

		// Token: 0x040099F6 RID: 39414
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(114U);

		// Token: 0x040099F7 RID: 39415
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();

		// Token: 0x040099F8 RID: 39416
		public const int PointDatasFieldNumber = 11;

		// Token: 0x040099F9 RID: 39417
		private static readonly FieldCodec<ControlPointData> _repeated_pointDatas_codec = FieldCodec.ForMessage<ControlPointData>(90U, ControlPointData.Parser);

		// Token: 0x040099FA RID: 39418
		private readonly RepeatedField<ControlPointData> pointDatas_ = new RepeatedField<ControlPointData>();
	}
}
