using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E33 RID: 3635
	[NetMessage(EMessageId.RacingBetMatchRoundActionResponse)]
	public sealed class RacingBetMatchRoundActionResponse : IMessage<RacingBetMatchRoundActionResponse>, IMessage, IEquatable<RacingBetMatchRoundActionResponse>, IDeepCloneable<RacingBetMatchRoundActionResponse>, IBufferMessage
	{
		// Token: 0x060138AE RID: 80046 RVA: 0x002D7A27 File Offset: 0x002D5C27
		[NullableContext(1)]
		public static RacingBetMatchRoundActionResponse Create()
		{
			return new RacingBetMatchRoundActionResponse();
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x060138AF RID: 80047 RVA: 0x002D7A2E File Offset: 0x002D5C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x060138B0 RID: 80048 RVA: 0x002D7A31 File Offset: 0x002D5C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRoundActionResponse.Descriptor;
			}
		}

		// Token: 0x060138B1 RID: 80049 RVA: 0x002D7A38 File Offset: 0x002D5C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionResponse()
		{
		}

		// Token: 0x060138B2 RID: 80050 RVA: 0x002D7A4C File Offset: 0x002D5C4C
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

		// Token: 0x060138B3 RID: 80051 RVA: 0x002D7AB5 File Offset: 0x002D5CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionResponse Clone()
		{
			return new RacingBetMatchRoundActionResponse(this);
		}

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x060138B4 RID: 80052 RVA: 0x002D7ABD File Offset: 0x002D5CBD
		// (set) Token: 0x060138B5 RID: 80053 RVA: 0x002D7AC5 File Offset: 0x002D5CC5
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

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x060138B6 RID: 80054 RVA: 0x002D7ACE File Offset: 0x002D5CCE
		// (set) Token: 0x060138B7 RID: 80055 RVA: 0x002D7AD6 File Offset: 0x002D5CD6
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

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x060138B8 RID: 80056 RVA: 0x002D7ADF File Offset: 0x002D5CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x060138B9 RID: 80057 RVA: 0x002D7AE7 File Offset: 0x002D5CE7
		// (set) Token: 0x060138BA RID: 80058 RVA: 0x002D7AEF File Offset: 0x002D5CEF
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

		// Token: 0x060138BB RID: 80059 RVA: 0x002D7AF8 File Offset: 0x002D5CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRoundActionResponse);
		}

		// Token: 0x060138BC RID: 80060 RVA: 0x002D7B08 File Offset: 0x002D5D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRoundActionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Rounds, other.Rounds) && this.dangoInfo_.Equals(other.dangoInfo_) && this.IsResultRound == other.IsResultRound && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060138BD RID: 80061 RVA: 0x002D7B7C File Offset: 0x002D5D7C
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

		// Token: 0x060138BE RID: 80062 RVA: 0x002D7BFE File Offset: 0x002D5DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060138BF RID: 80063 RVA: 0x002D7C0B File Offset: 0x002D5E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060138C0 RID: 80064 RVA: 0x002D7C14 File Offset: 0x002D5E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rounds_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rounds);
			}
			if (this.IsResultRound)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsResultRound);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchRoundActionResponse._repeated_dangoInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060138C1 RID: 80065 RVA: 0x002D7C9C File Offset: 0x002D5E9C
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

		// Token: 0x060138C2 RID: 80066 RVA: 0x002D7D14 File Offset: 0x002D5F14
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

		// Token: 0x060138C3 RID: 80067 RVA: 0x002D7DA1 File Offset: 0x002D5FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060138C4 RID: 80068 RVA: 0x002D7DAC File Offset: 0x002D5FAC
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
						if (this.rounds_ == null)
						{
							this.Rounds = new RacingBetsMatchRoundInfo();
						}
						input.ReadMessage(this.Rounds);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.IsResultRound = input.ReadBool();
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

		// Token: 0x04007817 RID: 30743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007818 RID: 30744
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007819 RID: 30745
		private ErrorCode errorCode_;

		// Token: 0x0400781A RID: 30746
		public const int RoundsFieldNumber = 5;

		// Token: 0x0400781B RID: 30747
		private RacingBetsMatchRoundInfo rounds_;

		// Token: 0x0400781C RID: 30748
		public const int DangoInfoFieldNumber = 13;

		// Token: 0x0400781D RID: 30749
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(106U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x0400781E RID: 30750
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();

		// Token: 0x0400781F RID: 30751
		public const int IsResultRoundFieldNumber = 12;

		// Token: 0x04007820 RID: 30752
		private bool isResultRound_;
	}
}
