using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E43 RID: 3651
	[NetMessage(EMessageId.RacingBetMatchRoundActionResponse)]
	public sealed class RacingBetMatchRoundActionResponse : IMessage<RacingBetMatchRoundActionResponse>, IMessage, IEquatable<RacingBetMatchRoundActionResponse>, IDeepCloneable<RacingBetMatchRoundActionResponse>, IBufferMessage
	{
		// Token: 0x06013993 RID: 80275 RVA: 0x002D90E2 File Offset: 0x002D72E2
		[NullableContext(1)]
		public static RacingBetMatchRoundActionResponse Create()
		{
			return new RacingBetMatchRoundActionResponse();
		}

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x06013994 RID: 80276 RVA: 0x002D90E9 File Offset: 0x002D72E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x06013995 RID: 80277 RVA: 0x002D90EC File Offset: 0x002D72EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRoundActionResponse.Descriptor;
			}
		}

		// Token: 0x06013996 RID: 80278 RVA: 0x002D90F3 File Offset: 0x002D72F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionResponse()
		{
		}

		// Token: 0x06013997 RID: 80279 RVA: 0x002D9108 File Offset: 0x002D7308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionResponse(RacingBetMatchRoundActionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rounds_ = ((other.rounds_ != null) ? other.rounds_.Clone() : null);
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this.isResultRound_ = other.isResultRound_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013998 RID: 80280 RVA: 0x002D9171 File Offset: 0x002D7371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionResponse Clone()
		{
			return new RacingBetMatchRoundActionResponse(this);
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x06013999 RID: 80281 RVA: 0x002D9179 File Offset: 0x002D7379
		// (set) Token: 0x0601399A RID: 80282 RVA: 0x002D9181 File Offset: 0x002D7381
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

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x0601399B RID: 80283 RVA: 0x002D918A File Offset: 0x002D738A
		// (set) Token: 0x0601399C RID: 80284 RVA: 0x002D9192 File Offset: 0x002D7392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRoundInfo Rounds
		{
			get
			{
				return this.rounds_;
			}
			set
			{
				this.rounds_ = value;
			}
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x0601399D RID: 80285 RVA: 0x002D919B File Offset: 0x002D739B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x0601399E RID: 80286 RVA: 0x002D91A3 File Offset: 0x002D73A3
		// (set) Token: 0x0601399F RID: 80287 RVA: 0x002D91AB File Offset: 0x002D73AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsResultRound
		{
			get
			{
				return this.isResultRound_;
			}
			set
			{
				this.isResultRound_ = value;
			}
		}

		// Token: 0x060139A0 RID: 80288 RVA: 0x002D91B4 File Offset: 0x002D73B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRoundActionResponse);
		}

		// Token: 0x060139A1 RID: 80289 RVA: 0x002D91C4 File Offset: 0x002D73C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRoundActionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Rounds, other.Rounds) && this.dangoInfo_.Equals(other.dangoInfo_) && this.IsResultRound == other.IsResultRound && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139A2 RID: 80290 RVA: 0x002D9238 File Offset: 0x002D7438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.rounds_ != null)
			{
				num ^= this.Rounds.GetHashCode();
			}
			num ^= this.dangoInfo_.GetHashCode();
			if (this.IsResultRound)
			{
				num ^= this.IsResultRound.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060139A3 RID: 80291 RVA: 0x002D92BA File Offset: 0x002D74BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139A4 RID: 80292 RVA: 0x002D92C7 File Offset: 0x002D74C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139A5 RID: 80293 RVA: 0x002D92D0 File Offset: 0x002D74D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsResultRound)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsResultRound);
			}
			if (this.rounds_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Rounds);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchRoundActionResponse._repeated_dangoInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060139A6 RID: 80294 RVA: 0x002D9358 File Offset: 0x002D7558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.rounds_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rounds);
			}
			num += this.dangoInfo_.CalculateSize(RacingBetMatchRoundActionResponse._repeated_dangoInfo_codec);
			if (this.IsResultRound)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060139A7 RID: 80295 RVA: 0x002D93D0 File Offset: 0x002D75D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchRoundActionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.rounds_ != null)
			{
				if (this.rounds_ == null)
				{
					this.Rounds = new RacingBetsMatchRoundInfo();
				}
				this.Rounds.MergeFrom(other.Rounds);
			}
			this.dangoInfo_.Add(other.dangoInfo_);
			if (other.IsResultRound)
			{
				this.IsResultRound = other.IsResultRound;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060139A8 RID: 80296 RVA: 0x002D945D File Offset: 0x002D765D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139A9 RID: 80297 RVA: 0x002D9468 File Offset: 0x002D7668
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
					if (num == 64U)
					{
						this.IsResultRound = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.rounds_ == null)
						{
							this.Rounds = new RacingBetsMatchRoundInfo();
						}
						input.ReadMessage(this.Rounds);
						continue;
					}
					if (num == 106U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchRoundActionResponse._repeated_dangoInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040077ED RID: 30701
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077EE RID: 30702
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040077EF RID: 30703
		private ErrorCode errorCode_;

		// Token: 0x040077F0 RID: 30704
		public const int RoundsFieldNumber = 10;

		// Token: 0x040077F1 RID: 30705
		private RacingBetsMatchRoundInfo rounds_;

		// Token: 0x040077F2 RID: 30706
		public const int DangoInfoFieldNumber = 13;

		// Token: 0x040077F3 RID: 30707
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(106U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x040077F4 RID: 30708
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();

		// Token: 0x040077F5 RID: 30709
		public const int IsResultRoundFieldNumber = 8;

		// Token: 0x040077F6 RID: 30710
		private bool isResultRound_;
	}
}
