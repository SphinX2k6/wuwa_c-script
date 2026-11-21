using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E35 RID: 3637
	[NetMessage(EMessageId.RacingBetMatchRoundResponse)]
	public sealed class RacingBetMatchRoundResponse : IMessage<RacingBetMatchRoundResponse>, IMessage, IEquatable<RacingBetMatchRoundResponse>, IDeepCloneable<RacingBetMatchRoundResponse>, IBufferMessage
	{
		// Token: 0x060138DC RID: 80092 RVA: 0x002D81AB File Offset: 0x002D63AB
		[NullableContext(1)]
		public static RacingBetMatchRoundResponse Create()
		{
			return new RacingBetMatchRoundResponse();
		}

		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x060138DD RID: 80093 RVA: 0x002D81B2 File Offset: 0x002D63B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x060138DE RID: 80094 RVA: 0x002D81B5 File Offset: 0x002D63B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRoundResponse.Descriptor;
			}
		}

		// Token: 0x060138DF RID: 80095 RVA: 0x002D81BC File Offset: 0x002D63BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundResponse()
		{
		}

		// Token: 0x060138E0 RID: 80096 RVA: 0x002D81D0 File Offset: 0x002D63D0
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

		// Token: 0x060138E1 RID: 80097 RVA: 0x002D8239 File Offset: 0x002D6439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundResponse Clone()
		{
			return new RacingBetMatchRoundResponse(this);
		}

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x060138E2 RID: 80098 RVA: 0x002D8241 File Offset: 0x002D6441
		// (set) Token: 0x060138E3 RID: 80099 RVA: 0x002D8249 File Offset: 0x002D6449
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

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x060138E4 RID: 80100 RVA: 0x002D8252 File Offset: 0x002D6452
		// (set) Token: 0x060138E5 RID: 80101 RVA: 0x002D825A File Offset: 0x002D645A
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

		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x060138E6 RID: 80102 RVA: 0x002D8263 File Offset: 0x002D6463
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
		// (get) Token: 0x060138E7 RID: 80103 RVA: 0x002D826B File Offset: 0x002D646B
		// (set) Token: 0x060138E8 RID: 80104 RVA: 0x002D8273 File Offset: 0x002D6473
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

		// Token: 0x060138E9 RID: 80105 RVA: 0x002D827C File Offset: 0x002D647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRoundResponse);
		}

		// Token: 0x060138EA RID: 80106 RVA: 0x002D828C File Offset: 0x002D648C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRoundResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Round, other.Round) && this.dangoInfo_.Equals(other.dangoInfo_) && this.IsResultRound == other.IsResultRound && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060138EB RID: 80107 RVA: 0x002D8300 File Offset: 0x002D6500
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

		// Token: 0x060138EC RID: 80108 RVA: 0x002D8382 File Offset: 0x002D6582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060138ED RID: 80109 RVA: 0x002D838F File Offset: 0x002D658F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060138EE RID: 80110 RVA: 0x002D8398 File Offset: 0x002D6598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchRoundResponse._repeated_dangoInfo_codec);
			if (this.IsResultRound)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsResultRound);
			}
			if (this.round_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Round);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060138EF RID: 80111 RVA: 0x002D8420 File Offset: 0x002D6620
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

		// Token: 0x060138F0 RID: 80112 RVA: 0x002D8498 File Offset: 0x002D6698
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

		// Token: 0x060138F1 RID: 80113 RVA: 0x002D8525 File Offset: 0x002D6725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060138F2 RID: 80114 RVA: 0x002D8530 File Offset: 0x002D6730
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
				if (num <= 58U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 58U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchRoundResponse._repeated_dangoInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.IsResultRound = input.ReadBool();
						continue;
					}
					if (num == 74U)
					{
						if (this.round_ == null)
						{
							this.Round = new RacingBetsMatchRound();
						}
						input.ReadMessage(this.Round);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007828 RID: 30760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007829 RID: 30761
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400782A RID: 30762
		private ErrorCode errorCode_;

		// Token: 0x0400782B RID: 30763
		public const int RoundFieldNumber = 9;

		// Token: 0x0400782C RID: 30764
		private RacingBetsMatchRound round_;

		// Token: 0x0400782D RID: 30765
		public const int DangoInfoFieldNumber = 7;

		// Token: 0x0400782E RID: 30766
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(58U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x0400782F RID: 30767
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();

		// Token: 0x04007830 RID: 30768
		public const int IsResultRoundFieldNumber = 8;

		// Token: 0x04007831 RID: 30769
		private bool isResultRound_;
	}
}
