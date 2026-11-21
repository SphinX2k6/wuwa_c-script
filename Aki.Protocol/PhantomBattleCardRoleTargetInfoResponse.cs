using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4E RID: 3150
	[NetMessage(EMessageId.PhantomBattleCardRoleTargetInfoResponse)]
	public sealed class PhantomBattleCardRoleTargetInfoResponse : IMessage<PhantomBattleCardRoleTargetInfoResponse>, IMessage, IEquatable<PhantomBattleCardRoleTargetInfoResponse>, IDeepCloneable<PhantomBattleCardRoleTargetInfoResponse>, IBufferMessage
	{
		// Token: 0x06011196 RID: 70038 RVA: 0x0028144D File Offset: 0x0027F64D
		[NullableContext(1)]
		public static PhantomBattleCardRoleTargetInfoResponse Create()
		{
			return new PhantomBattleCardRoleTargetInfoResponse();
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x06011197 RID: 70039 RVA: 0x00281454 File Offset: 0x0027F654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x06011198 RID: 70040 RVA: 0x00281457 File Offset: 0x0027F657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRoleTargetInfoResponse.Descriptor;
			}
		}

		// Token: 0x06011199 RID: 70041 RVA: 0x0028145E File Offset: 0x0027F65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoResponse()
		{
		}

		// Token: 0x0601119A RID: 70042 RVA: 0x00281474 File Offset: 0x0027F674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoResponse(PhantomBattleCardRoleTargetInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.effectType_ = other.effectType_;
			this.fighterUId_ = other.fighterUId_.Clone();
			this.num_ = other.num_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601119B RID: 70043 RVA: 0x002814D9 File Offset: 0x0027F6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoResponse Clone()
		{
			return new PhantomBattleCardRoleTargetInfoResponse(this);
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0601119C RID: 70044 RVA: 0x002814E1 File Offset: 0x0027F6E1
		// (set) Token: 0x0601119D RID: 70045 RVA: 0x002814E9 File Offset: 0x0027F6E9
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

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0601119E RID: 70046 RVA: 0x002814F2 File Offset: 0x0027F6F2
		// (set) Token: 0x0601119F RID: 70047 RVA: 0x002814FA File Offset: 0x0027F6FA
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

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x060111A0 RID: 70048 RVA: 0x00281503 File Offset: 0x0027F703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x060111A1 RID: 70049 RVA: 0x0028150B File Offset: 0x0027F70B
		// (set) Token: 0x060111A2 RID: 70050 RVA: 0x00281513 File Offset: 0x0027F713
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

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x060111A3 RID: 70051 RVA: 0x0028151C File Offset: 0x0027F71C
		// (set) Token: 0x060111A4 RID: 70052 RVA: 0x00281524 File Offset: 0x0027F724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x060111A5 RID: 70053 RVA: 0x0028152D File Offset: 0x0027F72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRoleTargetInfoResponse);
		}

		// Token: 0x060111A6 RID: 70054 RVA: 0x0028153C File Offset: 0x0027F73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRoleTargetInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectType == other.EffectType && this.fighterUId_.Equals(other.fighterUId_) && this.Num == other.Num && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111A7 RID: 70055 RVA: 0x002815BC File Offset: 0x0027F7BC
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
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060111A8 RID: 70056 RVA: 0x0028165A File Offset: 0x0027F85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111A9 RID: 70057 RVA: 0x00281667 File Offset: 0x0027F867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111AA RID: 70058 RVA: 0x00281670 File Offset: 0x0027F870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fighterUId_.WriteTo(ref output, PhantomBattleCardRoleTargetInfoResponse._repeated_fighterUId_codec);
			if (this.EffectType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.EffectType);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Num);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SkillId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060111AB RID: 70059 RVA: 0x00281714 File Offset: 0x0027F914
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
			num += this.fighterUId_.CalculateSize(PhantomBattleCardRoleTargetInfoResponse._repeated_fighterUId_codec);
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060111AC RID: 70060 RVA: 0x002817B0 File Offset: 0x0027F9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRoleTargetInfoResponse other)
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
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060111AD RID: 70061 RVA: 0x00281839 File Offset: 0x0027FA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111AE RID: 70062 RVA: 0x00281844 File Offset: 0x0027FA44
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
				if (num <= 56U)
				{
					if (num == 40U || num == 42U)
					{
						this.fighterUId_.AddEntriesFrom(ref input, PhantomBattleCardRoleTargetInfoResponse._repeated_fighterUId_codec);
						continue;
					}
					if (num == 56U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006CA8 RID: 27816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CA9 RID: 27817
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04006CAA RID: 27818
		private ErrorCode errorCode_;

		// Token: 0x04006CAB RID: 27819
		public const int EffectTypeFieldNumber = 7;

		// Token: 0x04006CAC RID: 27820
		private int effectType_;

		// Token: 0x04006CAD RID: 27821
		public const int FighterUIdFieldNumber = 5;

		// Token: 0x04006CAE RID: 27822
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006CAF RID: 27823
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();

		// Token: 0x04006CB0 RID: 27824
		public const int NumFieldNumber = 9;

		// Token: 0x04006CB1 RID: 27825
		private int num_;

		// Token: 0x04006CB2 RID: 27826
		public const int SkillIdFieldNumber = 11;

		// Token: 0x04006CB3 RID: 27827
		private int skillId_;
	}
}
