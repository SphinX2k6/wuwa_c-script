using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5B RID: 3675
	public sealed class RacingBetsMatchRoundInfo : IMessage<RacingBetsMatchRoundInfo>, IMessage, IEquatable<RacingBetsMatchRoundInfo>, IDeepCloneable<RacingBetsMatchRoundInfo>, IBufferMessage
	{
		// Token: 0x06013C63 RID: 80995 RVA: 0x002E1F55 File Offset: 0x002E0155
		[NullableContext(1)]
		public static RacingBetsMatchRoundInfo Create()
		{
			return new RacingBetsMatchRoundInfo();
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x06013C64 RID: 80996 RVA: 0x002E1F5C File Offset: 0x002E015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsMatchRoundInfo> Parser
		{
			get
			{
				return RacingBetsMatchRoundInfo._parser;
			}
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x06013C65 RID: 80997 RVA: 0x002E1F63 File Offset: 0x002E0163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x06013C66 RID: 80998 RVA: 0x002E1F66 File Offset: 0x002E0166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsMatchRoundInfo.Descriptor;
			}
		}

		// Token: 0x06013C67 RID: 80999 RVA: 0x002E1F6D File Offset: 0x002E016D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRoundInfo()
		{
		}

		// Token: 0x06013C68 RID: 81000 RVA: 0x002E1F80 File Offset: 0x002E0180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRoundInfo(RacingBetsMatchRoundInfo other) : this()
		{
			this.roundRank_ = other.roundRank_;
			this.roundAction_ = other.roundAction_.Clone();
			this.isFinalRound_ = other.isFinalRound_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C69 RID: 81001 RVA: 0x002E1FE9 File Offset: 0x002E01E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRoundInfo Clone()
		{
			return new RacingBetsMatchRoundInfo(this);
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x06013C6A RID: 81002 RVA: 0x002E1FF1 File Offset: 0x002E01F1
		// (set) Token: 0x06013C6B RID: 81003 RVA: 0x002E1FF9 File Offset: 0x002E01F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundRank
		{
			get
			{
				return this.roundRank_;
			}
			set
			{
				this.roundRank_ = value;
			}
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x06013C6C RID: 81004 RVA: 0x002E2002 File Offset: 0x002E0202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceRoundAction> RoundAction
		{
			get
			{
				return this.roundAction_;
			}
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x06013C6D RID: 81005 RVA: 0x002E200A File Offset: 0x002E020A
		// (set) Token: 0x06013C6E RID: 81006 RVA: 0x002E2012 File Offset: 0x002E0212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinalRound
		{
			get
			{
				return this.isFinalRound_;
			}
			set
			{
				this.isFinalRound_ = value;
			}
		}

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x06013C6F RID: 81007 RVA: 0x002E201B File Offset: 0x002E021B
		// (set) Token: 0x06013C70 RID: 81008 RVA: 0x002E2023 File Offset: 0x002E0223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x06013C71 RID: 81009 RVA: 0x002E202C File Offset: 0x002E022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsMatchRoundInfo);
		}

		// Token: 0x06013C72 RID: 81010 RVA: 0x002E203C File Offset: 0x002E023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsMatchRoundInfo other)
		{
			return other != null && (other == this || (this.RoundRank == other.RoundRank && this.roundAction_.Equals(other.roundAction_) && this.IsFinalRound == other.IsFinalRound && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C73 RID: 81011 RVA: 0x002E20B0 File Offset: 0x002E02B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundRank != 0)
			{
				num ^= this.RoundRank.GetHashCode();
			}
			num ^= this.roundAction_.GetHashCode();
			if (this.IsFinalRound)
			{
				num ^= this.IsFinalRound.GetHashCode();
			}
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013C74 RID: 81012 RVA: 0x002E212C File Offset: 0x002E032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C75 RID: 81013 RVA: 0x002E2139 File Offset: 0x002E0339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C76 RID: 81014 RVA: 0x002E2144 File Offset: 0x002E0344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoundRank != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoundRank);
			}
			this.roundAction_.WriteTo(ref output, RacingBetsMatchRoundInfo._repeated_roundAction_codec);
			if (this.IsFinalRound)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinalRound);
			}
			if (this.result_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C77 RID: 81015 RVA: 0x002E21CC File Offset: 0x002E03CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundRank);
			}
			num += this.roundAction_.CalculateSize(RacingBetsMatchRoundInfo._repeated_roundAction_codec);
			if (this.IsFinalRound)
			{
				num += 2;
			}
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013C78 RID: 81016 RVA: 0x002E2244 File Offset: 0x002E0444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsMatchRoundInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundRank != 0)
			{
				this.RoundRank = other.RoundRank;
			}
			this.roundAction_.Add(other.roundAction_);
			if (other.IsFinalRound)
			{
				this.IsFinalRound = other.IsFinalRound;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new MatchResult();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013C79 RID: 81017 RVA: 0x002E22D1 File Offset: 0x002E04D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C7A RID: 81018 RVA: 0x002E22DC File Offset: 0x002E04DC
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.RoundRank = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.roundAction_.AddEntriesFrom(ref input, RacingBetsMatchRoundInfo._repeated_roundAction_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsFinalRound = input.ReadBool();
						continue;
					}
					if (num == 34U)
					{
						if (this.result_ == null)
						{
							this.Result = new MatchResult();
						}
						input.ReadMessage(this.Result);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400797E RID: 31102
		private static readonly MessageParser<RacingBetsMatchRoundInfo> _parser = new MessageParser<RacingBetsMatchRoundInfo>(() => new RacingBetsMatchRoundInfo());

		// Token: 0x0400797F RID: 31103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007980 RID: 31104
		public const int RoundRankFieldNumber = 1;

		// Token: 0x04007981 RID: 31105
		private int roundRank_;

		// Token: 0x04007982 RID: 31106
		public const int RoundActionFieldNumber = 2;

		// Token: 0x04007983 RID: 31107
		private static readonly FieldCodec<RacingBetsInstanceRoundAction> _repeated_roundAction_codec = FieldCodec.ForMessage<RacingBetsInstanceRoundAction>(18U, RacingBetsInstanceRoundAction.Parser);

		// Token: 0x04007984 RID: 31108
		private readonly RepeatedField<RacingBetsInstanceRoundAction> roundAction_ = new RepeatedField<RacingBetsInstanceRoundAction>();

		// Token: 0x04007985 RID: 31109
		public const int IsFinalRoundFieldNumber = 3;

		// Token: 0x04007986 RID: 31110
		private bool isFinalRound_;

		// Token: 0x04007987 RID: 31111
		public const int ResultFieldNumber = 4;

		// Token: 0x04007988 RID: 31112
		private MatchResult result_;
	}
}
