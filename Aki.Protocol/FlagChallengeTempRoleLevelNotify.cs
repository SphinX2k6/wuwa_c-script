using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059F RID: 1439
	[NetMessage(EMessageId.FlagChallengeTempRoleLevelNotify)]
	public sealed class FlagChallengeTempRoleLevelNotify : IMessage<FlagChallengeTempRoleLevelNotify>, IMessage, IEquatable<FlagChallengeTempRoleLevelNotify>, IDeepCloneable<FlagChallengeTempRoleLevelNotify>, IBufferMessage
	{
		// Token: 0x06008525 RID: 34085 RVA: 0x00140305 File Offset: 0x0013E505
		[NullableContext(1)]
		public static FlagChallengeTempRoleLevelNotify Create()
		{
			return new FlagChallengeTempRoleLevelNotify();
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06008526 RID: 34086 RVA: 0x0014030C File Offset: 0x0013E50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06008527 RID: 34087 RVA: 0x0014030F File Offset: 0x0013E50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeTempRoleLevelNotify.Descriptor;
			}
		}

		// Token: 0x06008528 RID: 34088 RVA: 0x00140316 File Offset: 0x0013E516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTempRoleLevelNotify()
		{
		}

		// Token: 0x06008529 RID: 34089 RVA: 0x00140320 File Offset: 0x0013E520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTempRoleLevelNotify(FlagChallengeTempRoleLevelNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.flagChallengeRoleLevelInfo_ = ((other.flagChallengeRoleLevelInfo_ != null) ? other.flagChallengeRoleLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600852A RID: 34090 RVA: 0x0014036C File Offset: 0x0013E56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTempRoleLevelNotify Clone()
		{
			return new FlagChallengeTempRoleLevelNotify(this);
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x0600852B RID: 34091 RVA: 0x00140374 File Offset: 0x0013E574
		// (set) Token: 0x0600852C RID: 34092 RVA: 0x0014037C File Offset: 0x0013E57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeLevelId
		{
			get
			{
				return this.challengeLevelId_;
			}
			set
			{
				this.challengeLevelId_ = value;
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x0600852D RID: 34093 RVA: 0x00140385 File Offset: 0x0013E585
		// (set) Token: 0x0600852E RID: 34094 RVA: 0x0014038D File Offset: 0x0013E58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengeRoleLevelInfo
		{
			get
			{
				return this.flagChallengeRoleLevelInfo_;
			}
			set
			{
				this.flagChallengeRoleLevelInfo_ = value;
			}
		}

		// Token: 0x0600852F RID: 34095 RVA: 0x00140396 File Offset: 0x0013E596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeTempRoleLevelNotify);
		}

		// Token: 0x06008530 RID: 34096 RVA: 0x001403A4 File Offset: 0x0013E5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeTempRoleLevelNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && object.Equals(this.FlagChallengeRoleLevelInfo, other.FlagChallengeRoleLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008531 RID: 34097 RVA: 0x001403F4 File Offset: 0x0013E5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeLevelId != 0)
			{
				num ^= this.ChallengeLevelId.GetHashCode();
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengeRoleLevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x00140449 File Offset: 0x0013E649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x00140456 File Offset: 0x0013E656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008534 RID: 34100 RVA: 0x00140460 File Offset: 0x0013E660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FlagChallengeRoleLevelInfo);
			}
			if (this.ChallengeLevelId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ChallengeLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008535 RID: 34101 RVA: 0x001404BC File Offset: 0x0013E6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeLevelId);
			}
			if (this.flagChallengeRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeRoleLevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008536 RID: 34102 RVA: 0x00140514 File Offset: 0x0013E714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeTempRoleLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeLevelId != 0)
			{
				this.ChallengeLevelId = other.ChallengeLevelId;
			}
			if (other.flagChallengeRoleLevelInfo_ != null)
			{
				if (this.flagChallengeRoleLevelInfo_ == null)
				{
					this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengeRoleLevelInfo.MergeFrom(other.FlagChallengeRoleLevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x0014057C File Offset: 0x0013E77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x00140588 File Offset: 0x0013E788
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
				if (num != 42U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeLevelId = input.ReadInt32();
					}
				}
				else
				{
					if (this.flagChallengeRoleLevelInfo_ == null)
					{
						this.FlagChallengeRoleLevelInfo = new FlagChallengeRoleLevelInfo();
					}
					input.ReadMessage(this.FlagChallengeRoleLevelInfo);
				}
			}
		}

		// Token: 0x040041E9 RID: 16873
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041EA RID: 16874
		public const int ChallengeLevelIdFieldNumber = 12;

		// Token: 0x040041EB RID: 16875
		private int challengeLevelId_;

		// Token: 0x040041EC RID: 16876
		public const int FlagChallengeRoleLevelInfoFieldNumber = 5;

		// Token: 0x040041ED RID: 16877
		private FlagChallengeRoleLevelInfo flagChallengeRoleLevelInfo_;
	}
}
