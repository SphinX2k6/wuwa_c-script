using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000581 RID: 1409
	[NetMessage(EMessageId.FlagChallengeInstNotify)]
	public sealed class FlagChallengeInstNotify : IMessage<FlagChallengeInstNotify>, IMessage, IEquatable<FlagChallengeInstNotify>, IDeepCloneable<FlagChallengeInstNotify>, IBufferMessage
	{
		// Token: 0x06008307 RID: 33543 RVA: 0x0013BE5C File Offset: 0x0013A05C
		[NullableContext(1)]
		public static FlagChallengeInstNotify Create()
		{
			return new FlagChallengeInstNotify();
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06008308 RID: 33544 RVA: 0x0013BE63 File Offset: 0x0013A063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06008309 RID: 33545 RVA: 0x0013BE66 File Offset: 0x0013A066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeInstNotify.Descriptor;
			}
		}

		// Token: 0x0600830A RID: 33546 RVA: 0x0013BE6D File Offset: 0x0013A06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeInstNotify()
		{
		}

		// Token: 0x0600830B RID: 33547 RVA: 0x0013BE78 File Offset: 0x0013A078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeInstNotify(FlagChallengeInstNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.flagChallengePerRoleLevelInfo_ = ((other.flagChallengePerRoleLevelInfo_ != null) ? other.flagChallengePerRoleLevelInfo_.Clone() : null);
			this.flagChallengeTempRoleLevelInfo_ = ((other.flagChallengeTempRoleLevelInfo_ != null) ? other.flagChallengeTempRoleLevelInfo_.Clone() : null);
			this.boxExp_ = other.boxExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x0013BEEC File Offset: 0x0013A0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeInstNotify Clone()
		{
			return new FlagChallengeInstNotify(this);
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x0600830D RID: 33549 RVA: 0x0013BEF4 File Offset: 0x0013A0F4
		// (set) Token: 0x0600830E RID: 33550 RVA: 0x0013BEFC File Offset: 0x0013A0FC
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

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x0600830F RID: 33551 RVA: 0x0013BF05 File Offset: 0x0013A105
		// (set) Token: 0x06008310 RID: 33552 RVA: 0x0013BF0D File Offset: 0x0013A10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengePerRoleLevelInfo
		{
			get
			{
				return this.flagChallengePerRoleLevelInfo_;
			}
			set
			{
				this.flagChallengePerRoleLevelInfo_ = value;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06008311 RID: 33553 RVA: 0x0013BF16 File Offset: 0x0013A116
		// (set) Token: 0x06008312 RID: 33554 RVA: 0x0013BF1E File Offset: 0x0013A11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRoleLevelInfo FlagChallengeTempRoleLevelInfo
		{
			get
			{
				return this.flagChallengeTempRoleLevelInfo_;
			}
			set
			{
				this.flagChallengeTempRoleLevelInfo_ = value;
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06008313 RID: 33555 RVA: 0x0013BF27 File Offset: 0x0013A127
		// (set) Token: 0x06008314 RID: 33556 RVA: 0x0013BF2F File Offset: 0x0013A12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoxExp
		{
			get
			{
				return this.boxExp_;
			}
			set
			{
				this.boxExp_ = value;
			}
		}

		// Token: 0x06008315 RID: 33557 RVA: 0x0013BF38 File Offset: 0x0013A138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeInstNotify);
		}

		// Token: 0x06008316 RID: 33558 RVA: 0x0013BF48 File Offset: 0x0013A148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeInstNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && object.Equals(this.FlagChallengePerRoleLevelInfo, other.FlagChallengePerRoleLevelInfo) && object.Equals(this.FlagChallengeTempRoleLevelInfo, other.FlagChallengeTempRoleLevelInfo) && this.BoxExp == other.BoxExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008317 RID: 33559 RVA: 0x0013BFBC File Offset: 0x0013A1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeLevelId != 0)
			{
				num ^= this.ChallengeLevelId.GetHashCode();
			}
			if (this.flagChallengePerRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengePerRoleLevelInfo.GetHashCode();
			}
			if (this.flagChallengeTempRoleLevelInfo_ != null)
			{
				num ^= this.FlagChallengeTempRoleLevelInfo.GetHashCode();
			}
			if (this.BoxExp != 0)
			{
				num ^= this.BoxExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008318 RID: 33560 RVA: 0x0013C040 File Offset: 0x0013A240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x0013C04D File Offset: 0x0013A24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600831A RID: 33562 RVA: 0x0013C058 File Offset: 0x0013A258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeLevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeLevelId);
			}
			if (this.flagChallengePerRoleLevelInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.FlagChallengePerRoleLevelInfo);
			}
			if (this.BoxExp != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BoxExp);
			}
			if (this.flagChallengeTempRoleLevelInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.FlagChallengeTempRoleLevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x0013C0EC File Offset: 0x0013A2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeLevelId);
			}
			if (this.flagChallengePerRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengePerRoleLevelInfo);
			}
			if (this.flagChallengeTempRoleLevelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FlagChallengeTempRoleLevelInfo);
			}
			if (this.BoxExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoxExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x0013C174 File Offset: 0x0013A374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeInstNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeLevelId != 0)
			{
				this.ChallengeLevelId = other.ChallengeLevelId;
			}
			if (other.flagChallengePerRoleLevelInfo_ != null)
			{
				if (this.flagChallengePerRoleLevelInfo_ == null)
				{
					this.FlagChallengePerRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengePerRoleLevelInfo.MergeFrom(other.FlagChallengePerRoleLevelInfo);
			}
			if (other.flagChallengeTempRoleLevelInfo_ != null)
			{
				if (this.flagChallengeTempRoleLevelInfo_ == null)
				{
					this.FlagChallengeTempRoleLevelInfo = new FlagChallengeRoleLevelInfo();
				}
				this.FlagChallengeTempRoleLevelInfo.MergeFrom(other.FlagChallengeTempRoleLevelInfo);
			}
			if (other.BoxExp != 0)
			{
				this.BoxExp = other.BoxExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x0013C21C File Offset: 0x0013A41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x0013C228 File Offset: 0x0013A428
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
					if (num == 16U)
					{
						this.ChallengeLevelId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.flagChallengePerRoleLevelInfo_ == null)
						{
							this.FlagChallengePerRoleLevelInfo = new FlagChallengeRoleLevelInfo();
						}
						input.ReadMessage(this.FlagChallengePerRoleLevelInfo);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.BoxExp = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.flagChallengeTempRoleLevelInfo_ == null)
						{
							this.FlagChallengeTempRoleLevelInfo = new FlagChallengeRoleLevelInfo();
						}
						input.ReadMessage(this.FlagChallengeTempRoleLevelInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040041AE RID: 16814
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041AF RID: 16815
		public const int ChallengeLevelIdFieldNumber = 2;

		// Token: 0x040041B0 RID: 16816
		private int challengeLevelId_;

		// Token: 0x040041B1 RID: 16817
		public const int FlagChallengePerRoleLevelInfoFieldNumber = 5;

		// Token: 0x040041B2 RID: 16818
		private FlagChallengeRoleLevelInfo flagChallengePerRoleLevelInfo_;

		// Token: 0x040041B3 RID: 16819
		public const int FlagChallengeTempRoleLevelInfoFieldNumber = 13;

		// Token: 0x040041B4 RID: 16820
		private FlagChallengeRoleLevelInfo flagChallengeTempRoleLevelInfo_;

		// Token: 0x040041B5 RID: 16821
		public const int BoxExpFieldNumber = 12;

		// Token: 0x040041B6 RID: 16822
		private int boxExp_;
	}
}
