using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E70 RID: 3696
	[NetMessage(EMessageId.RacingBetsUpdateOddsResponse)]
	public sealed class RacingBetsUpdateOddsResponse : IMessage<RacingBetsUpdateOddsResponse>, IMessage, IEquatable<RacingBetsUpdateOddsResponse>, IDeepCloneable<RacingBetsUpdateOddsResponse>, IBufferMessage
	{
		// Token: 0x06013E0E RID: 81422 RVA: 0x002E57A8 File Offset: 0x002E39A8
		[NullableContext(1)]
		public static RacingBetsUpdateOddsResponse Create()
		{
			return new RacingBetsUpdateOddsResponse();
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x06013E0F RID: 81423 RVA: 0x002E57AF File Offset: 0x002E39AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x06013E10 RID: 81424 RVA: 0x002E57B2 File Offset: 0x002E39B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsUpdateOddsResponse.Descriptor;
			}
		}

		// Token: 0x06013E11 RID: 81425 RVA: 0x002E57B9 File Offset: 0x002E39B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsResponse()
		{
		}

		// Token: 0x06013E12 RID: 81426 RVA: 0x002E57D8 File Offset: 0x002E39D8
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

		// Token: 0x06013E13 RID: 81427 RVA: 0x002E5849 File Offset: 0x002E3A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateOddsResponse Clone()
		{
			return new RacingBetsUpdateOddsResponse(this);
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x06013E14 RID: 81428 RVA: 0x002E5851 File Offset: 0x002E3A51
		// (set) Token: 0x06013E15 RID: 81429 RVA: 0x002E5859 File Offset: 0x002E3A59
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

		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x06013E16 RID: 81430 RVA: 0x002E5862 File Offset: 0x002E3A62
		// (set) Token: 0x06013E17 RID: 81431 RVA: 0x002E586A File Offset: 0x002E3A6A
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

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x06013E18 RID: 81432 RVA: 0x002E5873 File Offset: 0x002E3A73
		// (set) Token: 0x06013E19 RID: 81433 RVA: 0x002E587B File Offset: 0x002E3A7B
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

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x06013E1A RID: 81434 RVA: 0x002E5884 File Offset: 0x002E3A84
		// (set) Token: 0x06013E1B RID: 81435 RVA: 0x002E588C File Offset: 0x002E3A8C
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

		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x06013E1C RID: 81436 RVA: 0x002E589F File Offset: 0x002E3A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x06013E1D RID: 81437 RVA: 0x002E58A7 File Offset: 0x002E3AA7
		// (set) Token: 0x06013E1E RID: 81438 RVA: 0x002E58AF File Offset: 0x002E3AAF
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

		// Token: 0x06013E1F RID: 81439 RVA: 0x002E58B8 File Offset: 0x002E3AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsUpdateOddsResponse);
		}

		// Token: 0x06013E20 RID: 81440 RVA: 0x002E58C8 File Offset: 0x002E3AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsUpdateOddsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && !(this.OddsVersion != other.OddsVersion) && this.dangoInfo_.Equals(other.dangoInfo_) && this.NextOddsTime == other.NextOddsTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E21 RID: 81441 RVA: 0x002E595C File Offset: 0x002E3B5C
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

		// Token: 0x06013E22 RID: 81442 RVA: 0x002E5A15 File Offset: 0x002E3C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E23 RID: 81443 RVA: 0x002E5A22 File Offset: 0x002E3C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E24 RID: 81444 RVA: 0x002E5A2C File Offset: 0x002E3C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dangoInfo_.WriteTo(ref output, RacingBetsUpdateOddsResponse._repeated_dangoInfo_codec);
			if (this.OddsVersion.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.OddsVersion);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.NextOddsTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.NextOddsTime);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E25 RID: 81445 RVA: 0x002E5AF0 File Offset: 0x002E3CF0
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

		// Token: 0x06013E26 RID: 81446 RVA: 0x002E5BA8 File Offset: 0x002E3DA8
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

		// Token: 0x06013E27 RID: 81447 RVA: 0x002E5C4A File Offset: 0x002E3E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E28 RID: 81448 RVA: 0x002E5C54 File Offset: 0x002E3E54
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
					if (num == 34U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetsUpdateOddsResponse._repeated_dangoInfo_codec);
						continue;
					}
					if (num == 58U)
					{
						this.OddsVersion = input.ReadString();
						continue;
					}
					if (num == 64U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.NextOddsTime = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040079F2 RID: 31218
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079F3 RID: 31219
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040079F4 RID: 31220
		private ErrorCode errorCode_;

		// Token: 0x040079F5 RID: 31221
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x040079F6 RID: 31222
		private int activityId_;

		// Token: 0x040079F7 RID: 31223
		public const int LegMatchIdFieldNumber = 10;

		// Token: 0x040079F8 RID: 31224
		private int legMatchId_;

		// Token: 0x040079F9 RID: 31225
		public const int OddsVersionFieldNumber = 7;

		// Token: 0x040079FA RID: 31226
		private string oddsVersion_ = "";

		// Token: 0x040079FB RID: 31227
		public const int DangoInfoFieldNumber = 4;

		// Token: 0x040079FC RID: 31228
		private static readonly FieldCodec<RacingBetsDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsDangoInfo>(34U, RacingBetsDangoInfo.Parser);

		// Token: 0x040079FD RID: 31229
		private readonly RepeatedField<RacingBetsDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsDangoInfo>();

		// Token: 0x040079FE RID: 31230
		public const int NextOddsTimeFieldNumber = 11;

		// Token: 0x040079FF RID: 31231
		private long nextOddsTime_;
	}
}
