using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E80 RID: 3712
	[NetMessage(EMessageId.RacingBetsUpdateOddsResponse)]
	public sealed class RacingBetsUpdateOddsResponse : IMessage<RacingBetsUpdateOddsResponse>, IMessage, IEquatable<RacingBetsUpdateOddsResponse>, IDeepCloneable<RacingBetsUpdateOddsResponse>, IBufferMessage
	{
		// Token: 0x06013EF3 RID: 81651 RVA: 0x002E6E63 File Offset: 0x002E5063
		[NullableContext(1)]
		public static RacingBetsUpdateOddsResponse Create()
		{
			return new RacingBetsUpdateOddsResponse();
		}

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x06013EF4 RID: 81652 RVA: 0x002E6E6A File Offset: 0x002E506A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x06013EF5 RID: 81653 RVA: 0x002E6E6D File Offset: 0x002E506D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsUpdateOddsResponse.Descriptor;
			}
		}

		// Token: 0x06013EF6 RID: 81654 RVA: 0x002E6E74 File Offset: 0x002E5074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsResponse()
		{
		}

		// Token: 0x06013EF7 RID: 81655 RVA: 0x002E6E94 File Offset: 0x002E5094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsResponse(RacingBetsUpdateOddsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.oddsVersion_ = other.oddsVersion_;
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this.nextOddsTime_ = other.nextOddsTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013EF8 RID: 81656 RVA: 0x002E6F05 File Offset: 0x002E5105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsResponse Clone()
		{
			return new RacingBetsUpdateOddsResponse(this);
		}

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x06013EF9 RID: 81657 RVA: 0x002E6F0D File Offset: 0x002E510D
		// (set) Token: 0x06013EFA RID: 81658 RVA: 0x002E6F15 File Offset: 0x002E5115
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

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x06013EFB RID: 81659 RVA: 0x002E6F1E File Offset: 0x002E511E
		// (set) Token: 0x06013EFC RID: 81660 RVA: 0x002E6F26 File Offset: 0x002E5126
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

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x06013EFD RID: 81661 RVA: 0x002E6F2F File Offset: 0x002E512F
		// (set) Token: 0x06013EFE RID: 81662 RVA: 0x002E6F37 File Offset: 0x002E5137
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

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x06013EFF RID: 81663 RVA: 0x002E6F40 File Offset: 0x002E5140
		// (set) Token: 0x06013F00 RID: 81664 RVA: 0x002E6F48 File Offset: 0x002E5148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OddsVersion
		{
			get
			{
				return this.oddsVersion_;
			}
			set
			{
				this.oddsVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x06013F01 RID: 81665 RVA: 0x002E6F5B File Offset: 0x002E515B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x06013F02 RID: 81666 RVA: 0x002E6F63 File Offset: 0x002E5163
		// (set) Token: 0x06013F03 RID: 81667 RVA: 0x002E6F6B File Offset: 0x002E516B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextOddsTime
		{
			get
			{
				return this.nextOddsTime_;
			}
			set
			{
				this.nextOddsTime_ = value;
			}
		}

		// Token: 0x06013F04 RID: 81668 RVA: 0x002E6F74 File Offset: 0x002E5174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsUpdateOddsResponse);
		}

		// Token: 0x06013F05 RID: 81669 RVA: 0x002E6F84 File Offset: 0x002E5184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsUpdateOddsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && !(this.OddsVersion != other.OddsVersion) && this.dangoInfo_.Equals(other.dangoInfo_) && this.NextOddsTime == other.NextOddsTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F06 RID: 81670 RVA: 0x002E7018 File Offset: 0x002E5218
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
			if (this.OddsVersion.Length != 0)
			{
				num ^= this.OddsVersion.GetHashCode();
			}
			num ^= this.dangoInfo_.GetHashCode();
			if (this.NextOddsTime != 0L)
			{
				num ^= this.NextOddsTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013F07 RID: 81671 RVA: 0x002E70D1 File Offset: 0x002E52D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F08 RID: 81672 RVA: 0x002E70DE File Offset: 0x002E52DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F09 RID: 81673 RVA: 0x002E70E8 File Offset: 0x002E52E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.NextOddsTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.NextOddsTime);
			}
			if (this.OddsVersion.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.OddsVersion);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetsUpdateOddsResponse._repeated_dangoInfo_codec);
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013F0A RID: 81674 RVA: 0x002E71AC File Offset: 0x002E53AC
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
			if (this.OddsVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OddsVersion);
			}
			num += this.dangoInfo_.CalculateSize(RacingBetsUpdateOddsResponse._repeated_dangoInfo_codec);
			if (this.NextOddsTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextOddsTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013F0B RID: 81675 RVA: 0x002E7264 File Offset: 0x002E5464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsUpdateOddsResponse other)
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
			if (other.OddsVersion.Length != 0)
			{
				this.OddsVersion = other.OddsVersion;
			}
			this.dangoInfo_.Add(other.dangoInfo_);
			if (other.NextOddsTime != 0L)
			{
				this.NextOddsTime = other.NextOddsTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013F0C RID: 81676 RVA: 0x002E7306 File Offset: 0x002E5506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F0D RID: 81677 RVA: 0x002E7310 File Offset: 0x002E5510
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.NextOddsTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.OddsVersion = input.ReadString();
						continue;
					}
					if (num == 90U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetsUpdateOddsResponse._repeated_dangoInfo_codec);
						continue;
					}
					if (num == 104U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040079C8 RID: 31176
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079C9 RID: 31177
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040079CA RID: 31178
		private ErrorCode errorCode_;

		// Token: 0x040079CB RID: 31179
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040079CC RID: 31180
		private int activityId_;

		// Token: 0x040079CD RID: 31181
		public const int LegMatchIdFieldNumber = 13;

		// Token: 0x040079CE RID: 31182
		private int legMatchId_;

		// Token: 0x040079CF RID: 31183
		public const int OddsVersionFieldNumber = 9;

		// Token: 0x040079D0 RID: 31184
		private string oddsVersion_ = "";

		// Token: 0x040079D1 RID: 31185
		public const int DangoInfoFieldNumber = 11;

		// Token: 0x040079D2 RID: 31186
		private static readonly FieldCodec<RacingBetsDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsDangoInfo>(90U, RacingBetsDangoInfo.Parser);

		// Token: 0x040079D3 RID: 31187
		private readonly RepeatedField<RacingBetsDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsDangoInfo>();

		// Token: 0x040079D4 RID: 31188
		public const int NextOddsTimeFieldNumber = 8;

		// Token: 0x040079D5 RID: 31189
		private long nextOddsTime_;
	}
}
