using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2D RID: 3629
	[NetMessage(EMessageId.RacingBetMatchActionResponse)]
	public sealed class RacingBetMatchActionResponse : IMessage<RacingBetMatchActionResponse>, IMessage, IEquatable<RacingBetMatchActionResponse>, IDeepCloneable<RacingBetMatchActionResponse>, IBufferMessage
	{
		// Token: 0x06013828 RID: 79912 RVA: 0x002D6510 File Offset: 0x002D4710
		[NullableContext(1)]
		public static RacingBetMatchActionResponse Create()
		{
			return new RacingBetMatchActionResponse();
		}

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x06013829 RID: 79913 RVA: 0x002D6517 File Offset: 0x002D4717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x0601382A RID: 79914 RVA: 0x002D651A File Offset: 0x002D471A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchActionResponse.Descriptor;
			}
		}

		// Token: 0x0601382B RID: 79915 RVA: 0x002D6521 File Offset: 0x002D4721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionResponse()
		{
		}

		// Token: 0x0601382C RID: 79916 RVA: 0x002D6540 File Offset: 0x002D4740
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

		// Token: 0x0601382D RID: 79917 RVA: 0x002D65B6 File Offset: 0x002D47B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchActionResponse Clone()
		{
			return new RacingBetMatchActionResponse(this);
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x0601382E RID: 79918 RVA: 0x002D65BE File Offset: 0x002D47BE
		// (set) Token: 0x0601382F RID: 79919 RVA: 0x002D65C6 File Offset: 0x002D47C6
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

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x06013830 RID: 79920 RVA: 0x002D65CF File Offset: 0x002D47CF
		// (set) Token: 0x06013831 RID: 79921 RVA: 0x002D65D7 File Offset: 0x002D47D7
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

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x06013832 RID: 79922 RVA: 0x002D65E0 File Offset: 0x002D47E0
		// (set) Token: 0x06013833 RID: 79923 RVA: 0x002D65E8 File Offset: 0x002D47E8
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

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x06013834 RID: 79924 RVA: 0x002D65F1 File Offset: 0x002D47F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x06013835 RID: 79925 RVA: 0x002D65F9 File Offset: 0x002D47F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsMatchRoundInfo> Rounds
		{
			get
			{
				return this.rounds_;
			}
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x06013836 RID: 79926 RVA: 0x002D6601 File Offset: 0x002D4801
		// (set) Token: 0x06013837 RID: 79927 RVA: 0x002D6609 File Offset: 0x002D4809
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

		// Token: 0x06013838 RID: 79928 RVA: 0x002D6612 File Offset: 0x002D4812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchActionResponse);
		}

		// Token: 0x06013839 RID: 79929 RVA: 0x002D6620 File Offset: 0x002D4820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchActionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.dangoInfo_.Equals(other.dangoInfo_) && this.rounds_.Equals(other.rounds_) && this.Replay == other.Replay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601383A RID: 79930 RVA: 0x002D66B4 File Offset: 0x002D48B4
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

		// Token: 0x0601383B RID: 79931 RVA: 0x002D6760 File Offset: 0x002D4960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601383C RID: 79932 RVA: 0x002D676D File Offset: 0x002D496D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601383D RID: 79933 RVA: 0x002D6778 File Offset: 0x002D4978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.rounds_.WriteTo(ref output, RacingBetMatchActionResponse._repeated_rounds_codec);
			if (this.Replay)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Replay);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchActionResponse._repeated_dangoInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601383E RID: 79934 RVA: 0x002D682C File Offset: 0x002D4A2C
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

		// Token: 0x0601383F RID: 79935 RVA: 0x002D68CC File Offset: 0x002D4ACC
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

		// Token: 0x06013840 RID: 79936 RVA: 0x002D6966 File Offset: 0x002D4B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013841 RID: 79937 RVA: 0x002D6970 File Offset: 0x002D4B70
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
				if (num <= 34U)
				{
					if (num == 16U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.rounds_.AddEntriesFrom(ref input, RacingBetMatchActionResponse._repeated_rounds_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Replay = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 122U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchActionResponse._repeated_dangoInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040077E4 RID: 30692
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077E5 RID: 30693
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040077E6 RID: 30694
		private ErrorCode errorCode_;

		// Token: 0x040077E7 RID: 30695
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040077E8 RID: 30696
		private int activityId_;

		// Token: 0x040077E9 RID: 30697
		public const int LegMatchIdFieldNumber = 2;

		// Token: 0x040077EA RID: 30698
		private int legMatchId_;

		// Token: 0x040077EB RID: 30699
		public const int DangoInfoFieldNumber = 15;

		// Token: 0x040077EC RID: 30700
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(122U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x040077ED RID: 30701
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();

		// Token: 0x040077EE RID: 30702
		public const int RoundsFieldNumber = 4;

		// Token: 0x040077EF RID: 30703
		private static readonly FieldCodec<RacingBetsMatchRoundInfo> _repeated_rounds_codec = FieldCodec.ForMessage<RacingBetsMatchRoundInfo>(34U, RacingBetsMatchRoundInfo.Parser);

		// Token: 0x040077F0 RID: 30704
		private readonly RepeatedField<RacingBetsMatchRoundInfo> rounds_ = new RepeatedField<RacingBetsMatchRoundInfo>();

		// Token: 0x040077F1 RID: 30705
		public const int ReplayFieldNumber = 11;

		// Token: 0x040077F2 RID: 30706
		private bool replay_;
	}
}
