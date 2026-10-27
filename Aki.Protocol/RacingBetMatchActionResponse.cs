using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3D RID: 3645
	[NetMessage(EMessageId.RacingBetMatchActionResponse)]
	public sealed class RacingBetMatchActionResponse : IMessage<RacingBetMatchActionResponse>, IMessage, IEquatable<RacingBetMatchActionResponse>, IDeepCloneable<RacingBetMatchActionResponse>, IBufferMessage
	{
		// Token: 0x0601390D RID: 80141 RVA: 0x002D7BD0 File Offset: 0x002D5DD0
		[NullableContext(1)]
		public static RacingBetMatchActionResponse Create()
		{
			return new RacingBetMatchActionResponse();
		}

		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x0601390E RID: 80142 RVA: 0x002D7BD7 File Offset: 0x002D5DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x0601390F RID: 80143 RVA: 0x002D7BDA File Offset: 0x002D5DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchActionResponse.Descriptor;
			}
		}

		// Token: 0x06013910 RID: 80144 RVA: 0x002D7BE1 File Offset: 0x002D5DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionResponse()
		{
		}

		// Token: 0x06013911 RID: 80145 RVA: 0x002D7C00 File Offset: 0x002D5E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionResponse(RacingBetMatchActionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this.rounds_ = other.rounds_.Clone();
			this.replay_ = other.replay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013912 RID: 80146 RVA: 0x002D7C76 File Offset: 0x002D5E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionResponse Clone()
		{
			return new RacingBetMatchActionResponse(this);
		}

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x06013913 RID: 80147 RVA: 0x002D7C7E File Offset: 0x002D5E7E
		// (set) Token: 0x06013914 RID: 80148 RVA: 0x002D7C86 File Offset: 0x002D5E86
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

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x06013915 RID: 80149 RVA: 0x002D7C8F File Offset: 0x002D5E8F
		// (set) Token: 0x06013916 RID: 80150 RVA: 0x002D7C97 File Offset: 0x002D5E97
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

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x06013917 RID: 80151 RVA: 0x002D7CA0 File Offset: 0x002D5EA0
		// (set) Token: 0x06013918 RID: 80152 RVA: 0x002D7CA8 File Offset: 0x002D5EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x06013919 RID: 80153 RVA: 0x002D7CB1 File Offset: 0x002D5EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x170040E5 RID: 16613
		// (get) Token: 0x0601391A RID: 80154 RVA: 0x002D7CB9 File Offset: 0x002D5EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsMatchRoundInfo> Rounds
		{
			get
			{
				return this.rounds_;
			}
		}

		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x0601391B RID: 80155 RVA: 0x002D7CC1 File Offset: 0x002D5EC1
		// (set) Token: 0x0601391C RID: 80156 RVA: 0x002D7CC9 File Offset: 0x002D5EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Replay
		{
			get
			{
				return this.replay_;
			}
			set
			{
				this.replay_ = value;
			}
		}

		// Token: 0x0601391D RID: 80157 RVA: 0x002D7CD2 File Offset: 0x002D5ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchActionResponse);
		}

		// Token: 0x0601391E RID: 80158 RVA: 0x002D7CE0 File Offset: 0x002D5EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchActionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.dangoInfo_.Equals(other.dangoInfo_) && this.rounds_.Equals(other.rounds_) && this.Replay == other.Replay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601391F RID: 80159 RVA: 0x002D7D74 File Offset: 0x002D5F74
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
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			num ^= this.dangoInfo_.GetHashCode();
			num ^= this.rounds_.GetHashCode();
			if (this.Replay)
			{
				num ^= this.Replay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013920 RID: 80160 RVA: 0x002D7E20 File Offset: 0x002D6020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013921 RID: 80161 RVA: 0x002D7E2D File Offset: 0x002D602D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013922 RID: 80162 RVA: 0x002D7E38 File Offset: 0x002D6038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Replay)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Replay);
			}
			this.rounds_.WriteTo(ref output, RacingBetMatchActionResponse._repeated_rounds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LegMatchId);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchActionResponse._repeated_dangoInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013923 RID: 80163 RVA: 0x002D7EEC File Offset: 0x002D60EC
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
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			num += this.dangoInfo_.CalculateSize(RacingBetMatchActionResponse._repeated_dangoInfo_codec);
			num += this.rounds_.CalculateSize(RacingBetMatchActionResponse._repeated_rounds_codec);
			if (this.Replay)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013924 RID: 80164 RVA: 0x002D7F8C File Offset: 0x002D618C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchActionResponse other)
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
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this.dangoInfo_.Add(other.dangoInfo_);
			this.rounds_.Add(other.rounds_);
			if (other.Replay)
			{
				this.Replay = other.Replay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013925 RID: 80165 RVA: 0x002D8026 File Offset: 0x002D6226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013926 RID: 80166 RVA: 0x002D8030 File Offset: 0x002D6230
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
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.Replay = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						this.rounds_.AddEntriesFrom(ref input, RacingBetMatchActionResponse._repeated_rounds_codec);
						continue;
					}
					if (num == 56U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchActionResponse._repeated_dangoInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040077BA RID: 30650
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077BB RID: 30651
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040077BC RID: 30652
		private ErrorCode errorCode_;

		// Token: 0x040077BD RID: 30653
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x040077BE RID: 30654
		private int activityId_;

		// Token: 0x040077BF RID: 30655
		public const int LegMatchIdFieldNumber = 12;

		// Token: 0x040077C0 RID: 30656
		private int legMatchId_;

		// Token: 0x040077C1 RID: 30657
		public const int DangoInfoFieldNumber = 14;

		// Token: 0x040077C2 RID: 30658
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(114U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x040077C3 RID: 30659
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();

		// Token: 0x040077C4 RID: 30660
		public const int RoundsFieldNumber = 5;

		// Token: 0x040077C5 RID: 30661
		private static readonly FieldCodec<RacingBetsMatchRoundInfo> _repeated_rounds_codec = FieldCodec.ForMessage<RacingBetsMatchRoundInfo>(42U, RacingBetsMatchRoundInfo.Parser);

		// Token: 0x040077C6 RID: 30662
		private readonly RepeatedField<RacingBetsMatchRoundInfo> rounds_ = new RepeatedField<RacingBetsMatchRoundInfo>();

		// Token: 0x040077C7 RID: 30663
		public const int ReplayFieldNumber = 2;

		// Token: 0x040077C8 RID: 30664
		private bool replay_;
	}
}
