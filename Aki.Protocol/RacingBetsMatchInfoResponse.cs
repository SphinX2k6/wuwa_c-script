using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E69 RID: 3689
	[NetMessage(EMessageId.RacingBetsMatchInfoResponse)]
	public sealed class RacingBetsMatchInfoResponse : IMessage<RacingBetsMatchInfoResponse>, IMessage, IEquatable<RacingBetsMatchInfoResponse>, IDeepCloneable<RacingBetsMatchInfoResponse>, IBufferMessage
	{
		// Token: 0x06013D15 RID: 81173 RVA: 0x002E2C1D File Offset: 0x002E0E1D
		[NullableContext(1)]
		public static RacingBetsMatchInfoResponse Create()
		{
			return new RacingBetsMatchInfoResponse();
		}

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x06013D16 RID: 81174 RVA: 0x002E2C24 File Offset: 0x002E0E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x06013D17 RID: 81175 RVA: 0x002E2C27 File Offset: 0x002E0E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsMatchInfoResponse.Descriptor;
			}
		}

		// Token: 0x06013D18 RID: 81176 RVA: 0x002E2C2E File Offset: 0x002E0E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoResponse()
		{
		}

		// Token: 0x06013D19 RID: 81177 RVA: 0x002E2C44 File Offset: 0x002E0E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoResponse(RacingBetsMatchInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.activityStarAndEndTime_ = ((other.activityStarAndEndTime_ != null) ? other.activityStarAndEndTime_.Clone() : null);
			this.matchInfos_ = other.matchInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D1A RID: 81178 RVA: 0x002E2CAD File Offset: 0x002E0EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoResponse Clone()
		{
			return new RacingBetsMatchInfoResponse(this);
		}

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x06013D1B RID: 81179 RVA: 0x002E2CB5 File Offset: 0x002E0EB5
		// (set) Token: 0x06013D1C RID: 81180 RVA: 0x002E2CBD File Offset: 0x002E0EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x06013D1D RID: 81181 RVA: 0x002E2CC6 File Offset: 0x002E0EC6
		// (set) Token: 0x06013D1E RID: 81182 RVA: 0x002E2CCE File Offset: 0x002E0ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x06013D1F RID: 81183 RVA: 0x002E2CD7 File Offset: 0x002E0ED7
		// (set) Token: 0x06013D20 RID: 81184 RVA: 0x002E2CDF File Offset: 0x002E0EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple ActivityStarAndEndTime
		{
			get
			{
				return this.activityStarAndEndTime_;
			}
			set
			{
				this.activityStarAndEndTime_ = value;
			}
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x06013D21 RID: 81185 RVA: 0x002E2CE8 File Offset: 0x002E0EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsGroupMatchesInfo> MatchInfos
		{
			get
			{
				return this.matchInfos_;
			}
		}

		// Token: 0x06013D22 RID: 81186 RVA: 0x002E2CF0 File Offset: 0x002E0EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsMatchInfoResponse);
		}

		// Token: 0x06013D23 RID: 81187 RVA: 0x002E2D00 File Offset: 0x002E0F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsMatchInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && object.Equals(this.ActivityStarAndEndTime, other.ActivityStarAndEndTime) && this.matchInfos_.Equals(other.matchInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D24 RID: 81188 RVA: 0x002E2D74 File Offset: 0x002E0F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.activityStarAndEndTime_ != null)
			{
				num ^= this.ActivityStarAndEndTime.GetHashCode();
			}
			num ^= this.matchInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013D25 RID: 81189 RVA: 0x002E2DF6 File Offset: 0x002E0FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D26 RID: 81190 RVA: 0x002E2E03 File Offset: 0x002E1003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D27 RID: 81191 RVA: 0x002E2E0C File Offset: 0x002E100C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.activityStarAndEndTime_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ActivityStarAndEndTime);
			}
			this.matchInfos_.WriteTo(ref output, RacingBetsMatchInfoResponse._repeated_matchInfos_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D28 RID: 81192 RVA: 0x002E2E94 File Offset: 0x002E1094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.activityStarAndEndTime_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityStarAndEndTime);
			}
			num += this.matchInfos_.CalculateSize(RacingBetsMatchInfoResponse._repeated_matchInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013D29 RID: 81193 RVA: 0x002E2F18 File Offset: 0x002E1118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsMatchInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.activityStarAndEndTime_ != null)
			{
				if (this.activityStarAndEndTime_ == null)
				{
					this.ActivityStarAndEndTime = new RacingBetsTimeTuple();
				}
				this.ActivityStarAndEndTime.MergeFrom(other.ActivityStarAndEndTime);
			}
			this.matchInfos_.Add(other.matchInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013D2A RID: 81194 RVA: 0x002E2FA5 File Offset: 0x002E11A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D2B RID: 81195 RVA: 0x002E2FB0 File Offset: 0x002E11B0
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
				if (num <= 42U)
				{
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 42U)
					{
						if (this.activityStarAndEndTime_ == null)
						{
							this.ActivityStarAndEndTime = new RacingBetsTimeTuple();
						}
						input.ReadMessage(this.ActivityStarAndEndTime);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.matchInfos_.AddEntriesFrom(ref input, RacingBetsMatchInfoResponse._repeated_matchInfos_codec);
						continue;
					}
					if (num == 112U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007939 RID: 31033
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400793A RID: 31034
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400793B RID: 31035
		private ErrorCode errorCode_;

		// Token: 0x0400793C RID: 31036
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x0400793D RID: 31037
		private int activityId_;

		// Token: 0x0400793E RID: 31038
		public const int ActivityStarAndEndTimeFieldNumber = 5;

		// Token: 0x0400793F RID: 31039
		private RacingBetsTimeTuple activityStarAndEndTime_;

		// Token: 0x04007940 RID: 31040
		public const int MatchInfosFieldNumber = 13;

		// Token: 0x04007941 RID: 31041
		private static readonly FieldCodec<RacingBetsGroupMatchesInfo> _repeated_matchInfos_codec = FieldCodec.ForMessage<RacingBetsGroupMatchesInfo>(106U, RacingBetsGroupMatchesInfo.Parser);

		// Token: 0x04007942 RID: 31042
		private readonly RepeatedField<RacingBetsGroupMatchesInfo> matchInfos_ = new RepeatedField<RacingBetsGroupMatchesInfo>();
	}
}
