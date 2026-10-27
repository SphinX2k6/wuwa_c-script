using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E45 RID: 3653
	[NetMessage(EMessageId.RacingBetMatchRoundResponse)]
	public sealed class RacingBetMatchRoundResponse : IMessage<RacingBetMatchRoundResponse>, IMessage, IEquatable<RacingBetMatchRoundResponse>, IDeepCloneable<RacingBetMatchRoundResponse>, IBufferMessage
	{
		// Token: 0x060139C1 RID: 80321 RVA: 0x002D9867 File Offset: 0x002D7A67
		[NullableContext(1)]
		public static RacingBetMatchRoundResponse Create()
		{
			return new RacingBetMatchRoundResponse();
		}

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x060139C2 RID: 80322 RVA: 0x002D986E File Offset: 0x002D7A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x060139C3 RID: 80323 RVA: 0x002D9871 File Offset: 0x002D7A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRoundResponse.Descriptor;
			}
		}

		// Token: 0x060139C4 RID: 80324 RVA: 0x002D9878 File Offset: 0x002D7A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundResponse()
		{
		}

		// Token: 0x060139C5 RID: 80325 RVA: 0x002D988C File Offset: 0x002D7A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundResponse(RacingBetMatchRoundResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.round_ = ((other.round_ != null) ? other.round_.Clone() : null);
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this.isResultRound_ = other.isResultRound_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139C6 RID: 80326 RVA: 0x002D98F5 File Offset: 0x002D7AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundResponse Clone()
		{
			return new RacingBetMatchRoundResponse(this);
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x060139C7 RID: 80327 RVA: 0x002D98FD File Offset: 0x002D7AFD
		// (set) Token: 0x060139C8 RID: 80328 RVA: 0x002D9905 File Offset: 0x002D7B05
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

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x060139C9 RID: 80329 RVA: 0x002D990E File Offset: 0x002D7B0E
		// (set) Token: 0x060139CA RID: 80330 RVA: 0x002D9916 File Offset: 0x002D7B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRound Round
		{
			get
			{
				return this.round_;
			}
			set
			{
				this.round_ = value;
			}
		}

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x060139CB RID: 80331 RVA: 0x002D991F File Offset: 0x002D7B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x060139CC RID: 80332 RVA: 0x002D9927 File Offset: 0x002D7B27
		// (set) Token: 0x060139CD RID: 80333 RVA: 0x002D992F File Offset: 0x002D7B2F
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

		// Token: 0x060139CE RID: 80334 RVA: 0x002D9938 File Offset: 0x002D7B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRoundResponse);
		}

		// Token: 0x060139CF RID: 80335 RVA: 0x002D9948 File Offset: 0x002D7B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRoundResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Round, other.Round) && this.dangoInfo_.Equals(other.dangoInfo_) && this.IsResultRound == other.IsResultRound && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139D0 RID: 80336 RVA: 0x002D99BC File Offset: 0x002D7BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.round_ != null)
			{
				num ^= this.Round.GetHashCode();
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

		// Token: 0x060139D1 RID: 80337 RVA: 0x002D9A3E File Offset: 0x002D7C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139D2 RID: 80338 RVA: 0x002D9A4B File Offset: 0x002D7C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139D3 RID: 80339 RVA: 0x002D9A54 File Offset: 0x002D7C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchRoundResponse._repeated_dangoInfo_codec);
			if (this.IsResultRound)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsResultRound);
			}
			if (this.round_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Round);
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

		// Token: 0x060139D4 RID: 80340 RVA: 0x002D9ADC File Offset: 0x002D7CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.round_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Round);
			}
			num += this.dangoInfo_.CalculateSize(RacingBetMatchRoundResponse._repeated_dangoInfo_codec);
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

		// Token: 0x060139D5 RID: 80341 RVA: 0x002D9B54 File Offset: 0x002D7D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchRoundResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.round_ != null)
			{
				if (this.round_ == null)
				{
					this.Round = new RacingBetsMatchRound();
				}
				this.Round.MergeFrom(other.Round);
			}
			this.dangoInfo_.Add(other.dangoInfo_);
			if (other.IsResultRound)
			{
				this.IsResultRound = other.IsResultRound;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060139D6 RID: 80342 RVA: 0x002D9BE1 File Offset: 0x002D7DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139D7 RID: 80343 RVA: 0x002D9BEC File Offset: 0x002D7DEC
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
				if (num <= 96U)
				{
					if (num == 34U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchRoundResponse._repeated_dangoInfo_codec);
						continue;
					}
					if (num == 96U)
					{
						this.IsResultRound = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.round_ == null)
						{
							this.Round = new RacingBetsMatchRound();
						}
						input.ReadMessage(this.Round);
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

		// Token: 0x040077FE RID: 30718
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077FF RID: 30719
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04007800 RID: 30720
		private ErrorCode errorCode_;

		// Token: 0x04007801 RID: 30721
		public const int RoundFieldNumber = 13;

		// Token: 0x04007802 RID: 30722
		private RacingBetsMatchRound round_;

		// Token: 0x04007803 RID: 30723
		public const int DangoInfoFieldNumber = 4;

		// Token: 0x04007804 RID: 30724
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(34U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x04007805 RID: 30725
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();

		// Token: 0x04007806 RID: 30726
		public const int IsResultRoundFieldNumber = 12;

		// Token: 0x04007807 RID: 30727
		private bool isResultRound_;
	}
}
