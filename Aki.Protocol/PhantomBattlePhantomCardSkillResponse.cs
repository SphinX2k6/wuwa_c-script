using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C8E RID: 3214
	[NetMessage(EMessageId.PhantomBattlePhantomCardSkillResponse)]
	public sealed class PhantomBattlePhantomCardSkillResponse : IMessage<PhantomBattlePhantomCardSkillResponse>, IMessage, IEquatable<PhantomBattlePhantomCardSkillResponse>, IDeepCloneable<PhantomBattlePhantomCardSkillResponse>, IBufferMessage
	{
		// Token: 0x06011709 RID: 71433 RVA: 0x0028E830 File Offset: 0x0028CA30
		[NullableContext(1)]
		public static PhantomBattlePhantomCardSkillResponse Create()
		{
			return new PhantomBattlePhantomCardSkillResponse();
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0601170A RID: 71434 RVA: 0x0028E837 File Offset: 0x0028CA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0601170B RID: 71435 RVA: 0x0028E83A File Offset: 0x0028CA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattlePhantomCardSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601170C RID: 71436 RVA: 0x0028E841 File Offset: 0x0028CA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillResponse()
		{
		}

		// Token: 0x0601170D RID: 71437 RVA: 0x0028E854 File Offset: 0x0028CA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillResponse(PhantomBattlePhantomCardSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.effectType_ = other.effectType_;
			this.fighterUId_ = other.fighterUId_.Clone();
			this.num_ = other.num_;
			this.cardUId_ = other.cardUId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601170E RID: 71438 RVA: 0x0028E8B9 File Offset: 0x0028CAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillResponse Clone()
		{
			return new PhantomBattlePhantomCardSkillResponse(this);
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0601170F RID: 71439 RVA: 0x0028E8C1 File Offset: 0x0028CAC1
		// (set) Token: 0x06011710 RID: 71440 RVA: 0x0028E8C9 File Offset: 0x0028CAC9
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

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x06011711 RID: 71441 RVA: 0x0028E8D2 File Offset: 0x0028CAD2
		// (set) Token: 0x06011712 RID: 71442 RVA: 0x0028E8DA File Offset: 0x0028CADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectType
		{
			get
			{
				return this.effectType_;
			}
			set
			{
				this.effectType_ = value;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x06011713 RID: 71443 RVA: 0x0028E8E3 File Offset: 0x0028CAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x06011714 RID: 71444 RVA: 0x0028E8EB File Offset: 0x0028CAEB
		// (set) Token: 0x06011715 RID: 71445 RVA: 0x0028E8F3 File Offset: 0x0028CAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x06011716 RID: 71446 RVA: 0x0028E8FC File Offset: 0x0028CAFC
		// (set) Token: 0x06011717 RID: 71447 RVA: 0x0028E904 File Offset: 0x0028CB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x06011718 RID: 71448 RVA: 0x0028E90D File Offset: 0x0028CB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattlePhantomCardSkillResponse);
		}

		// Token: 0x06011719 RID: 71449 RVA: 0x0028E91C File Offset: 0x0028CB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattlePhantomCardSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectType == other.EffectType && this.fighterUId_.Equals(other.fighterUId_) && this.Num == other.Num && this.CardUId == other.CardUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601171A RID: 71450 RVA: 0x0028E99C File Offset: 0x0028CB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EffectType != 0)
			{
				num ^= this.EffectType.GetHashCode();
			}
			num ^= this.fighterUId_.GetHashCode();
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601171B RID: 71451 RVA: 0x0028EA3A File Offset: 0x0028CC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601171C RID: 71452 RVA: 0x0028EA47 File Offset: 0x0028CC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601171D RID: 71453 RVA: 0x0028EA50 File Offset: 0x0028CC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EffectType);
			}
			if (this.CardUId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CardUId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.fighterUId_.WriteTo(ref output, PhantomBattlePhantomCardSkillResponse._repeated_fighterUId_codec);
			if (this.Num != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601171E RID: 71454 RVA: 0x0028EAF4 File Offset: 0x0028CCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EffectType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectType);
			}
			num += this.fighterUId_.CalculateSize(PhantomBattlePhantomCardSkillResponse._repeated_fighterUId_codec);
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601171F RID: 71455 RVA: 0x0028EB90 File Offset: 0x0028CD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattlePhantomCardSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EffectType != 0)
			{
				this.EffectType = other.EffectType;
			}
			this.fighterUId_.Add(other.fighterUId_);
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011720 RID: 71456 RVA: 0x0028EC19 File Offset: 0x0028CE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011721 RID: 71457 RVA: 0x0028EC24 File Offset: 0x0028CE24
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
				if (num <= 80U)
				{
					if (num == 32U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U || num == 90U)
					{
						this.fighterUId_.AddEntriesFrom(ref input, PhantomBattlePhantomCardSkillResponse._repeated_fighterUId_codec);
						continue;
					}
					if (num == 96U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E73 RID: 28275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E74 RID: 28276
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04006E75 RID: 28277
		private ErrorCode errorCode_;

		// Token: 0x04006E76 RID: 28278
		public const int EffectTypeFieldNumber = 4;

		// Token: 0x04006E77 RID: 28279
		private int effectType_;

		// Token: 0x04006E78 RID: 28280
		public const int FighterUIdFieldNumber = 11;

		// Token: 0x04006E79 RID: 28281
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006E7A RID: 28282
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();

		// Token: 0x04006E7B RID: 28283
		public const int NumFieldNumber = 12;

		// Token: 0x04006E7C RID: 28284
		private int num_;

		// Token: 0x04006E7D RID: 28285
		public const int CardUIdFieldNumber = 8;

		// Token: 0x04006E7E RID: 28286
		private int cardUId_;
	}
}
