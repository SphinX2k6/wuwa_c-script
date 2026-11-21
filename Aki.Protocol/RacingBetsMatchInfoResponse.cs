using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E59 RID: 3673
	[NetMessage(EMessageId.RacingBetsMatchInfoResponse)]
	public sealed class RacingBetsMatchInfoResponse : IMessage<RacingBetsMatchInfoResponse>, IMessage, IEquatable<RacingBetsMatchInfoResponse>, IDeepCloneable<RacingBetsMatchInfoResponse>, IBufferMessage
	{
		// Token: 0x06013C30 RID: 80944 RVA: 0x002E155D File Offset: 0x002DF75D
		[NullableContext(1)]
		public static RacingBetsMatchInfoResponse Create()
		{
			return new RacingBetsMatchInfoResponse();
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x06013C31 RID: 80945 RVA: 0x002E1564 File Offset: 0x002DF764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x06013C32 RID: 80946 RVA: 0x002E1567 File Offset: 0x002DF767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsMatchInfoResponse.Descriptor;
			}
		}

		// Token: 0x06013C33 RID: 80947 RVA: 0x002E156E File Offset: 0x002DF76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoResponse()
		{
		}

		// Token: 0x06013C34 RID: 80948 RVA: 0x002E1584 File Offset: 0x002DF784
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

		// Token: 0x06013C35 RID: 80949 RVA: 0x002E15ED File Offset: 0x002DF7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoResponse Clone()
		{
			return new RacingBetsMatchInfoResponse(this);
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x06013C36 RID: 80950 RVA: 0x002E15F5 File Offset: 0x002DF7F5
		// (set) Token: 0x06013C37 RID: 80951 RVA: 0x002E15FD File Offset: 0x002DF7FD
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

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x06013C38 RID: 80952 RVA: 0x002E1606 File Offset: 0x002DF806
		// (set) Token: 0x06013C39 RID: 80953 RVA: 0x002E160E File Offset: 0x002DF80E
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

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x06013C3A RID: 80954 RVA: 0x002E1617 File Offset: 0x002DF817
		// (set) Token: 0x06013C3B RID: 80955 RVA: 0x002E161F File Offset: 0x002DF81F
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

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x06013C3C RID: 80956 RVA: 0x002E1628 File Offset: 0x002DF828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsGroupMatchesInfo> MatchInfos
		{
			get
			{
				return this.matchInfos_;
			}
		}

		// Token: 0x06013C3D RID: 80957 RVA: 0x002E1630 File Offset: 0x002DF830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsMatchInfoResponse);
		}

		// Token: 0x06013C3E RID: 80958 RVA: 0x002E1640 File Offset: 0x002DF840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsMatchInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && object.Equals(this.ActivityStarAndEndTime, other.ActivityStarAndEndTime) && this.matchInfos_.Equals(other.matchInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C3F RID: 80959 RVA: 0x002E16B4 File Offset: 0x002DF8B4
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

		// Token: 0x06013C40 RID: 80960 RVA: 0x002E1736 File Offset: 0x002DF936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C41 RID: 80961 RVA: 0x002E1743 File Offset: 0x002DF943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C42 RID: 80962 RVA: 0x002E174C File Offset: 0x002DF94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.matchInfos_.WriteTo(ref output, RacingBetsMatchInfoResponse._repeated_matchInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.activityStarAndEndTime_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ActivityStarAndEndTime);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C43 RID: 80963 RVA: 0x002E17D4 File Offset: 0x002DF9D4
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

		// Token: 0x06013C44 RID: 80964 RVA: 0x002E1858 File Offset: 0x002DFA58
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

		// Token: 0x06013C45 RID: 80965 RVA: 0x002E18E5 File Offset: 0x002DFAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C46 RID: 80966 RVA: 0x002E18F0 File Offset: 0x002DFAF0
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
				if (num <= 80U)
				{
					if (num == 66U)
					{
						this.matchInfos_.AddEntriesFrom(ref input, RacingBetsMatchInfoResponse._repeated_matchInfos_codec);
						continue;
					}
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.activityStarAndEndTime_ == null)
						{
							this.ActivityStarAndEndTime = new RacingBetsTimeTuple();
						}
						input.ReadMessage(this.ActivityStarAndEndTime);
						continue;
					}
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007963 RID: 31075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007964 RID: 31076
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007965 RID: 31077
		private ErrorCode errorCode_;

		// Token: 0x04007966 RID: 31078
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04007967 RID: 31079
		private int activityId_;

		// Token: 0x04007968 RID: 31080
		public const int ActivityStarAndEndTimeFieldNumber = 11;

		// Token: 0x04007969 RID: 31081
		private RacingBetsTimeTuple activityStarAndEndTime_;

		// Token: 0x0400796A RID: 31082
		public const int MatchInfosFieldNumber = 8;

		// Token: 0x0400796B RID: 31083
		private static readonly FieldCodec<RacingBetsGroupMatchesInfo> _repeated_matchInfos_codec = FieldCodec.ForMessage<RacingBetsGroupMatchesInfo>(66U, RacingBetsGroupMatchesInfo.Parser);

		// Token: 0x0400796C RID: 31084
		private readonly RepeatedField<RacingBetsGroupMatchesInfo> matchInfos_ = new RepeatedField<RacingBetsGroupMatchesInfo>();
	}
}
