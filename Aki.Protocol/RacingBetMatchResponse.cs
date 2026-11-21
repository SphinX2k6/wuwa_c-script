using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E31 RID: 3633
	[NetMessage(EMessageId.RacingBetMatchResponse)]
	public sealed class RacingBetMatchResponse : IMessage<RacingBetMatchResponse>, IMessage, IEquatable<RacingBetMatchResponse>, IDeepCloneable<RacingBetMatchResponse>, IBufferMessage
	{
		// Token: 0x0601387F RID: 79999 RVA: 0x002D7234 File Offset: 0x002D5434
		[NullableContext(1)]
		public static RacingBetMatchResponse Create()
		{
			return new RacingBetMatchResponse();
		}

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x06013880 RID: 80000 RVA: 0x002D723B File Offset: 0x002D543B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x06013881 RID: 80001 RVA: 0x002D723E File Offset: 0x002D543E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchResponse.Descriptor;
			}
		}

		// Token: 0x06013882 RID: 80002 RVA: 0x002D7245 File Offset: 0x002D5445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchResponse()
		{
		}

		// Token: 0x06013883 RID: 80003 RVA: 0x002D7264 File Offset: 0x002D5464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchResponse(RacingBetMatchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this.rounds_ = other.rounds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013884 RID: 80004 RVA: 0x002D72CE File Offset: 0x002D54CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchResponse Clone()
		{
			return new RacingBetMatchResponse(this);
		}

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x06013885 RID: 80005 RVA: 0x002D72D6 File Offset: 0x002D54D6
		// (set) Token: 0x06013886 RID: 80006 RVA: 0x002D72DE File Offset: 0x002D54DE
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

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x06013887 RID: 80007 RVA: 0x002D72E7 File Offset: 0x002D54E7
		// (set) Token: 0x06013888 RID: 80008 RVA: 0x002D72EF File Offset: 0x002D54EF
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

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x06013889 RID: 80009 RVA: 0x002D72F8 File Offset: 0x002D54F8
		// (set) Token: 0x0601388A RID: 80010 RVA: 0x002D7300 File Offset: 0x002D5500
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

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x0601388B RID: 80011 RVA: 0x002D7309 File Offset: 0x002D5509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x0601388C RID: 80012 RVA: 0x002D7311 File Offset: 0x002D5511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsMatchRound> Rounds
		{
			get
			{
				return this.rounds_;
			}
		}

		// Token: 0x0601388D RID: 80013 RVA: 0x002D7319 File Offset: 0x002D5519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchResponse);
		}

		// Token: 0x0601388E RID: 80014 RVA: 0x002D7328 File Offset: 0x002D5528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.dangoInfo_.Equals(other.dangoInfo_) && this.rounds_.Equals(other.rounds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601388F RID: 80015 RVA: 0x002D73AC File Offset: 0x002D55AC
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013890 RID: 80016 RVA: 0x002D743F File Offset: 0x002D563F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013891 RID: 80017 RVA: 0x002D744C File Offset: 0x002D564C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013892 RID: 80018 RVA: 0x002D7458 File Offset: 0x002D5658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchResponse._repeated_dangoInfo_codec);
			this.rounds_.WriteTo(ref output, RacingBetMatchResponse._repeated_rounds_codec);
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013893 RID: 80019 RVA: 0x002D74F0 File Offset: 0x002D56F0
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
			num += this.dangoInfo_.CalculateSize(RacingBetMatchResponse._repeated_dangoInfo_codec);
			num += this.rounds_.CalculateSize(RacingBetMatchResponse._repeated_rounds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013894 RID: 80020 RVA: 0x002D7584 File Offset: 0x002D5784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchResponse other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013895 RID: 80021 RVA: 0x002D760A File Offset: 0x002D580A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013896 RID: 80022 RVA: 0x002D7614 File Offset: 0x002D5814
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchResponse._repeated_dangoInfo_codec);
						continue;
					}
					if (num == 106U)
					{
						this.rounds_.AddEntriesFrom(ref input, RacingBetMatchResponse._repeated_rounds_codec);
						continue;
					}
					if (num == 112U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007803 RID: 30723
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007804 RID: 30724
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007805 RID: 30725
		private ErrorCode errorCode_;

		// Token: 0x04007806 RID: 30726
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04007807 RID: 30727
		private int activityId_;

		// Token: 0x04007808 RID: 30728
		public const int LegMatchIdFieldNumber = 14;

		// Token: 0x04007809 RID: 30729
		private int legMatchId_;

		// Token: 0x0400780A RID: 30730
		public const int DangoInfoFieldNumber = 9;

		// Token: 0x0400780B RID: 30731
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(74U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x0400780C RID: 30732
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();

		// Token: 0x0400780D RID: 30733
		public const int RoundsFieldNumber = 13;

		// Token: 0x0400780E RID: 30734
		private static readonly FieldCodec<RacingBetsMatchRound> _repeated_rounds_codec = FieldCodec.ForMessage<RacingBetsMatchRound>(106U, RacingBetsMatchRound.Parser);

		// Token: 0x0400780F RID: 30735
		private readonly RepeatedField<RacingBetsMatchRound> rounds_ = new RepeatedField<RacingBetsMatchRound>();
	}
}
