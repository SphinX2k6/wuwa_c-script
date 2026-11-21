using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C56 RID: 3158
	[NetMessage(EMessageId.PhantomBattleCardTargetInfoResponse)]
	public sealed class PhantomBattleCardTargetInfoResponse : IMessage<PhantomBattleCardTargetInfoResponse>, IMessage, IEquatable<PhantomBattleCardTargetInfoResponse>, IDeepCloneable<PhantomBattleCardTargetInfoResponse>, IBufferMessage
	{
		// Token: 0x06011246 RID: 70214 RVA: 0x00282E74 File Offset: 0x00281074
		[NullableContext(1)]
		public static PhantomBattleCardTargetInfoResponse Create()
		{
			return new PhantomBattleCardTargetInfoResponse();
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x06011247 RID: 70215 RVA: 0x00282E7B File Offset: 0x0028107B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x06011248 RID: 70216 RVA: 0x00282E7E File Offset: 0x0028107E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardTargetInfoResponse.Descriptor;
			}
		}

		// Token: 0x06011249 RID: 70217 RVA: 0x00282E85 File Offset: 0x00281085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoResponse()
		{
		}

		// Token: 0x0601124A RID: 70218 RVA: 0x00282E98 File Offset: 0x00281098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoResponse(PhantomBattleCardTargetInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.effectType_ = other.effectType_;
			this.fighterUId_ = other.fighterUId_.Clone();
			this.num_ = other.num_;
			this.cardUId_ = other.cardUId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601124B RID: 70219 RVA: 0x00282F09 File Offset: 0x00281109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoResponse Clone()
		{
			return new PhantomBattleCardTargetInfoResponse(this);
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0601124C RID: 70220 RVA: 0x00282F11 File Offset: 0x00281111
		// (set) Token: 0x0601124D RID: 70221 RVA: 0x00282F19 File Offset: 0x00281119
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

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0601124E RID: 70222 RVA: 0x00282F22 File Offset: 0x00281122
		// (set) Token: 0x0601124F RID: 70223 RVA: 0x00282F2A File Offset: 0x0028112A
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

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x06011250 RID: 70224 RVA: 0x00282F33 File Offset: 0x00281133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x06011251 RID: 70225 RVA: 0x00282F3B File Offset: 0x0028113B
		// (set) Token: 0x06011252 RID: 70226 RVA: 0x00282F43 File Offset: 0x00281143
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

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x06011253 RID: 70227 RVA: 0x00282F4C File Offset: 0x0028114C
		// (set) Token: 0x06011254 RID: 70228 RVA: 0x00282F54 File Offset: 0x00281154
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

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x06011255 RID: 70229 RVA: 0x00282F5D File Offset: 0x0028115D
		// (set) Token: 0x06011256 RID: 70230 RVA: 0x00282F65 File Offset: 0x00281165
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

		// Token: 0x06011257 RID: 70231 RVA: 0x00282F6E File Offset: 0x0028116E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardTargetInfoResponse);
		}

		// Token: 0x06011258 RID: 70232 RVA: 0x00282F7C File Offset: 0x0028117C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardTargetInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectType == other.EffectType && this.fighterUId_.Equals(other.fighterUId_) && this.Num == other.Num && this.CardUId == other.CardUId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011259 RID: 70233 RVA: 0x0028300C File Offset: 0x0028120C
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

		// Token: 0x0601125A RID: 70234 RVA: 0x002830C3 File Offset: 0x002812C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601125B RID: 70235 RVA: 0x002830D0 File Offset: 0x002812D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601125C RID: 70236 RVA: 0x002830DC File Offset: 0x002812DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fighterUId_.WriteTo(ref output, PhantomBattleCardTargetInfoResponse._repeated_fighterUId_codec);
			if (this.EffectType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EffectType);
			}
			if (this.CardUId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CardUId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Num);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601125D RID: 70237 RVA: 0x0028319C File Offset: 0x0028139C
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
			num += this.fighterUId_.CalculateSize(PhantomBattleCardTargetInfoResponse._repeated_fighterUId_codec);
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
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

		// Token: 0x0601125E RID: 70238 RVA: 0x00283250 File Offset: 0x00281450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardTargetInfoResponse other)
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
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601125F RID: 70239 RVA: 0x002832ED File Offset: 0x002814ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011260 RID: 70240 RVA: 0x002832F8 File Offset: 0x002814F8
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
				if (num <= 40U)
				{
					if (num == 16U || num == 18U)
					{
						this.fighterUId_.AddEntriesFrom(ref input, PhantomBattleCardTargetInfoResponse._repeated_fighterUId_codec);
						continue;
					}
					if (num == 40U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 48U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006CE4 RID: 27876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CE5 RID: 27877
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006CE6 RID: 27878
		private ErrorCode errorCode_;

		// Token: 0x04006CE7 RID: 27879
		public const int EffectTypeFieldNumber = 5;

		// Token: 0x04006CE8 RID: 27880
		private int effectType_;

		// Token: 0x04006CE9 RID: 27881
		public const int FighterUIdFieldNumber = 2;

		// Token: 0x04006CEA RID: 27882
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006CEB RID: 27883
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();

		// Token: 0x04006CEC RID: 27884
		public const int NumFieldNumber = 14;

		// Token: 0x04006CED RID: 27885
		private int num_;

		// Token: 0x04006CEE RID: 27886
		public const int CardUIdFieldNumber = 6;

		// Token: 0x04006CEF RID: 27887
		private int cardUId_;

		// Token: 0x04006CF0 RID: 27888
		public const int SkillIdFieldNumber = 15;

		// Token: 0x04006CF1 RID: 27889
		private int skillId_;
	}
}
