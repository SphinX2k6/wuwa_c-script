using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059D RID: 1437
	[NetMessage(EMessageId.FlagChallengeSettleNotify)]
	public sealed class FlagChallengeSettleNotify : IMessage<FlagChallengeSettleNotify>, IMessage, IEquatable<FlagChallengeSettleNotify>, IDeepCloneable<FlagChallengeSettleNotify>, IBufferMessage
	{
		// Token: 0x060084FF RID: 34047 RVA: 0x0013FE37 File Offset: 0x0013E037
		[NullableContext(1)]
		public static FlagChallengeSettleNotify Create()
		{
			return new FlagChallengeSettleNotify();
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06008500 RID: 34048 RVA: 0x0013FE3E File Offset: 0x0013E03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06008501 RID: 34049 RVA: 0x0013FE41 File Offset: 0x0013E041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeSettleNotify.Descriptor;
			}
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x0013FE48 File Offset: 0x0013E048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeSettleNotify()
		{
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x0013FE50 File Offset: 0x0013E050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeSettleNotify(FlagChallengeSettleNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.flagChallengePerRoleLevelInfo_ = ((other.flagChallengePerRoleLevelInfo_ != null) ? other.flagChallengePerRoleLevelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x0013FE9C File Offset: 0x0013E09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeSettleNotify Clone()
		{
			return new FlagChallengeSettleNotify(this);
		}

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06008505 RID: 34053 RVA: 0x0013FEA4 File Offset: 0x0013E0A4
		// (set) Token: 0x06008506 RID: 34054 RVA: 0x0013FEAC File Offset: 0x0013E0AC
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

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06008507 RID: 34055 RVA: 0x0013FEB5 File Offset: 0x0013E0B5
		// (set) Token: 0x06008508 RID: 34056 RVA: 0x0013FEBD File Offset: 0x0013E0BD
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

		// Token: 0x06008509 RID: 34057 RVA: 0x0013FEC6 File Offset: 0x0013E0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeSettleNotify);
		}

		// Token: 0x0600850A RID: 34058 RVA: 0x0013FED4 File Offset: 0x0013E0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeSettleNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && object.Equals(this.FlagChallengePerRoleLevelInfo, other.FlagChallengePerRoleLevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600850B RID: 34059 RVA: 0x0013FF24 File Offset: 0x0013E124
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600850C RID: 34060 RVA: 0x0013FF79 File Offset: 0x0013E179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600850D RID: 34061 RVA: 0x0013FF86 File Offset: 0x0013E186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x0013FF90 File Offset: 0x0013E190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.flagChallengePerRoleLevelInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FlagChallengePerRoleLevelInfo);
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

		// Token: 0x0600850F RID: 34063 RVA: 0x0013FFEC File Offset: 0x0013E1EC
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x00140044 File Offset: 0x0013E244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeSettleNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008511 RID: 34065 RVA: 0x001400AC File Offset: 0x0013E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008512 RID: 34066 RVA: 0x001400B8 File Offset: 0x0013E2B8
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
				if (num != 10U)
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
					if (this.flagChallengePerRoleLevelInfo_ == null)
					{
						this.FlagChallengePerRoleLevelInfo = new FlagChallengeRoleLevelInfo();
					}
					input.ReadMessage(this.FlagChallengePerRoleLevelInfo);
				}
			}
		}

		// Token: 0x040041E0 RID: 16864
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041E1 RID: 16865
		public const int ChallengeLevelIdFieldNumber = 12;

		// Token: 0x040041E2 RID: 16866
		private int challengeLevelId_;

		// Token: 0x040041E3 RID: 16867
		public const int FlagChallengePerRoleLevelInfoFieldNumber = 1;

		// Token: 0x040041E4 RID: 16868
		private FlagChallengeRoleLevelInfo flagChallengePerRoleLevelInfo_;
	}
}
