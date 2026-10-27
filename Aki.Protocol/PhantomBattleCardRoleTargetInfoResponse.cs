using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5E RID: 3166
	[NetMessage(EMessageId.PhantomBattleCardRoleTargetInfoResponse)]
	public sealed class PhantomBattleCardRoleTargetInfoResponse : IMessage<PhantomBattleCardRoleTargetInfoResponse>, IMessage, IEquatable<PhantomBattleCardRoleTargetInfoResponse>, IDeepCloneable<PhantomBattleCardRoleTargetInfoResponse>, IBufferMessage
	{
		// Token: 0x06011296 RID: 70294 RVA: 0x002831BD File Offset: 0x002813BD
		[NullableContext(1)]
		public static PhantomBattleCardRoleTargetInfoResponse Create()
		{
			return new PhantomBattleCardRoleTargetInfoResponse();
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x06011297 RID: 70295 RVA: 0x002831C4 File Offset: 0x002813C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x06011298 RID: 70296 RVA: 0x002831C7 File Offset: 0x002813C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRoleTargetInfoResponse.Descriptor;
			}
		}

		// Token: 0x06011299 RID: 70297 RVA: 0x002831CE File Offset: 0x002813CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoResponse()
		{
		}

		// Token: 0x0601129A RID: 70298 RVA: 0x002831E4 File Offset: 0x002813E4
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

		// Token: 0x0601129B RID: 70299 RVA: 0x00283249 File Offset: 0x00281449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRoleTargetInfoResponse Clone()
		{
			return new PhantomBattleCardRoleTargetInfoResponse(this);
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0601129C RID: 70300 RVA: 0x00283251 File Offset: 0x00281451
		// (set) Token: 0x0601129D RID: 70301 RVA: 0x00283259 File Offset: 0x00281459
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

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0601129E RID: 70302 RVA: 0x00283262 File Offset: 0x00281462
		// (set) Token: 0x0601129F RID: 70303 RVA: 0x0028326A File Offset: 0x0028146A
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

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x060112A0 RID: 70304 RVA: 0x00283273 File Offset: 0x00281473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x060112A1 RID: 70305 RVA: 0x0028327B File Offset: 0x0028147B
		// (set) Token: 0x060112A2 RID: 70306 RVA: 0x00283283 File Offset: 0x00281483
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

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x060112A3 RID: 70307 RVA: 0x0028328C File Offset: 0x0028148C
		// (set) Token: 0x060112A4 RID: 70308 RVA: 0x00283294 File Offset: 0x00281494
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

		// Token: 0x060112A5 RID: 70309 RVA: 0x0028329D File Offset: 0x0028149D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRoleTargetInfoResponse);
		}

		// Token: 0x060112A6 RID: 70310 RVA: 0x002832AC File Offset: 0x002814AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRoleTargetInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectType == other.EffectType && this.fighterUId_.Equals(other.fighterUId_) && this.Num == other.Num && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112A7 RID: 70311 RVA: 0x0028332C File Offset: 0x0028152C
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

		// Token: 0x060112A8 RID: 70312 RVA: 0x002833CA File Offset: 0x002815CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112A9 RID: 70313 RVA: 0x002833D7 File Offset: 0x002815D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112AA RID: 70314 RVA: 0x002833E0 File Offset: 0x002815E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			this.fighterUId_.WriteTo(ref output, PhantomBattleCardRoleTargetInfoResponse._repeated_fighterUId_codec);
			if (this.EffectType != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EffectType);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060112AB RID: 70315 RVA: 0x00283484 File Offset: 0x00281684
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

		// Token: 0x060112AC RID: 70316 RVA: 0x00283520 File Offset: 0x00281720
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

		// Token: 0x060112AD RID: 70317 RVA: 0x002835A9 File Offset: 0x002817A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060112AE RID: 70318 RVA: 0x002835B4 File Offset: 0x002817B4
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
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.fighterUId_.AddEntriesFrom(ref input, PhantomBattleCardRoleTargetInfoResponse._repeated_fighterUId_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006C94 RID: 27796
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C95 RID: 27797
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006C96 RID: 27798
		private ErrorCode errorCode_;

		// Token: 0x04006C97 RID: 27799
		public const int EffectTypeFieldNumber = 8;

		// Token: 0x04006C98 RID: 27800
		private int effectType_;

		// Token: 0x04006C99 RID: 27801
		public const int FighterUIdFieldNumber = 2;

		// Token: 0x04006C9A RID: 27802
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006C9B RID: 27803
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();

		// Token: 0x04006C9C RID: 27804
		public const int NumFieldNumber = 15;

		// Token: 0x04006C9D RID: 27805
		private int num_;

		// Token: 0x04006C9E RID: 27806
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04006C9F RID: 27807
		private int skillId_;
	}
}
