using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9E RID: 3230
	[NetMessage(EMessageId.PhantomBattlePhantomCardSkillResponse)]
	public sealed class PhantomBattlePhantomCardSkillResponse : IMessage<PhantomBattlePhantomCardSkillResponse>, IMessage, IEquatable<PhantomBattlePhantomCardSkillResponse>, IDeepCloneable<PhantomBattlePhantomCardSkillResponse>, IBufferMessage
	{
		// Token: 0x06011809 RID: 71689 RVA: 0x00290599 File Offset: 0x0028E799
		[NullableContext(1)]
		public static PhantomBattlePhantomCardSkillResponse Create()
		{
			return new PhantomBattlePhantomCardSkillResponse();
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0601180A RID: 71690 RVA: 0x002905A0 File Offset: 0x0028E7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0601180B RID: 71691 RVA: 0x002905A3 File Offset: 0x0028E7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattlePhantomCardSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601180C RID: 71692 RVA: 0x002905AA File Offset: 0x0028E7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillResponse()
		{
		}

		// Token: 0x0601180D RID: 71693 RVA: 0x002905C0 File Offset: 0x0028E7C0
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

		// Token: 0x0601180E RID: 71694 RVA: 0x00290625 File Offset: 0x0028E825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattlePhantomCardSkillResponse Clone()
		{
			return new PhantomBattlePhantomCardSkillResponse(this);
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0601180F RID: 71695 RVA: 0x0029062D File Offset: 0x0028E82D
		// (set) Token: 0x06011810 RID: 71696 RVA: 0x00290635 File Offset: 0x0028E835
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

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x06011811 RID: 71697 RVA: 0x0029063E File Offset: 0x0028E83E
		// (set) Token: 0x06011812 RID: 71698 RVA: 0x00290646 File Offset: 0x0028E846
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

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x06011813 RID: 71699 RVA: 0x0029064F File Offset: 0x0028E84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x06011814 RID: 71700 RVA: 0x00290657 File Offset: 0x0028E857
		// (set) Token: 0x06011815 RID: 71701 RVA: 0x0029065F File Offset: 0x0028E85F
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

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x06011816 RID: 71702 RVA: 0x00290668 File Offset: 0x0028E868
		// (set) Token: 0x06011817 RID: 71703 RVA: 0x00290670 File Offset: 0x0028E870
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

		// Token: 0x06011818 RID: 71704 RVA: 0x00290679 File Offset: 0x0028E879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattlePhantomCardSkillResponse);
		}

		// Token: 0x06011819 RID: 71705 RVA: 0x00290688 File Offset: 0x0028E888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattlePhantomCardSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectType == other.EffectType && this.fighterUId_.Equals(other.fighterUId_) && this.Num == other.Num && this.CardUId == other.CardUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601181A RID: 71706 RVA: 0x00290708 File Offset: 0x0028E908
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

		// Token: 0x0601181B RID: 71707 RVA: 0x002907A6 File Offset: 0x0028E9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601181C RID: 71708 RVA: 0x002907B3 File Offset: 0x0028E9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601181D RID: 71709 RVA: 0x002907BC File Offset: 0x0028E9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EffectType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EffectType);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Num);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CardUId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CardUId);
			}
			this.fighterUId_.WriteTo(ref output, PhantomBattlePhantomCardSkillResponse._repeated_fighterUId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601181E RID: 71710 RVA: 0x00290860 File Offset: 0x0028EA60
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

		// Token: 0x0601181F RID: 71711 RVA: 0x002908FC File Offset: 0x0028EAFC
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

		// Token: 0x06011820 RID: 71712 RVA: 0x00290985 File Offset: 0x0028EB85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011821 RID: 71713 RVA: 0x00290990 File Offset: 0x0028EB90
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
					if (num == 24U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.fighterUId_.AddEntriesFrom(ref input, PhantomBattlePhantomCardSkillResponse._repeated_fighterUId_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E5F RID: 28255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E60 RID: 28256
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04006E61 RID: 28257
		private ErrorCode errorCode_;

		// Token: 0x04006E62 RID: 28258
		public const int EffectTypeFieldNumber = 3;

		// Token: 0x04006E63 RID: 28259
		private int effectType_;

		// Token: 0x04006E64 RID: 28260
		public const int FighterUIdFieldNumber = 15;

		// Token: 0x04006E65 RID: 28261
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04006E66 RID: 28262
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();

		// Token: 0x04006E67 RID: 28263
		public const int NumFieldNumber = 6;

		// Token: 0x04006E68 RID: 28264
		private int num_;

		// Token: 0x04006E69 RID: 28265
		public const int CardUIdFieldNumber = 10;

		// Token: 0x04006E6A RID: 28266
		private int cardUId_;
	}
}
