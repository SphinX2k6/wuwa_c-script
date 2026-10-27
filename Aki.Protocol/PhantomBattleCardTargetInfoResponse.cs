using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C66 RID: 3174
	[NetMessage(EMessageId.PhantomBattleCardTargetInfoResponse)]
	public sealed class PhantomBattleCardTargetInfoResponse : IMessage<PhantomBattleCardTargetInfoResponse>, IMessage, IEquatable<PhantomBattleCardTargetInfoResponse>, IDeepCloneable<PhantomBattleCardTargetInfoResponse>, IBufferMessage
	{
		// Token: 0x06011346 RID: 70470 RVA: 0x00284BE4 File Offset: 0x00282DE4
		[NullableContext(1)]
		public static PhantomBattleCardTargetInfoResponse Create()
		{
			return new PhantomBattleCardTargetInfoResponse();
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x06011347 RID: 70471 RVA: 0x00284BEB File Offset: 0x00282DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x06011348 RID: 70472 RVA: 0x00284BEE File Offset: 0x00282DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardTargetInfoResponse.Descriptor;
			}
		}

		// Token: 0x06011349 RID: 70473 RVA: 0x00284BF5 File Offset: 0x00282DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoResponse()
		{
		}

		// Token: 0x0601134A RID: 70474 RVA: 0x00284C08 File Offset: 0x00282E08
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

		// Token: 0x0601134B RID: 70475 RVA: 0x00284C79 File Offset: 0x00282E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardTargetInfoResponse Clone()
		{
			return new PhantomBattleCardTargetInfoResponse(this);
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0601134C RID: 70476 RVA: 0x00284C81 File Offset: 0x00282E81
		// (set) Token: 0x0601134D RID: 70477 RVA: 0x00284C89 File Offset: 0x00282E89
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

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0601134E RID: 70478 RVA: 0x00284C92 File Offset: 0x00282E92
		// (set) Token: 0x0601134F RID: 70479 RVA: 0x00284C9A File Offset: 0x00282E9A
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

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x06011350 RID: 70480 RVA: 0x00284CA3 File Offset: 0x00282EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FighterUId
		{
			get
			{
				return this.fighterUId_;
			}
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x06011351 RID: 70481 RVA: 0x00284CAB File Offset: 0x00282EAB
		// (set) Token: 0x06011352 RID: 70482 RVA: 0x00284CB3 File Offset: 0x00282EB3
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

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x06011353 RID: 70483 RVA: 0x00284CBC File Offset: 0x00282EBC
		// (set) Token: 0x06011354 RID: 70484 RVA: 0x00284CC4 File Offset: 0x00282EC4
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

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x06011355 RID: 70485 RVA: 0x00284CCD File Offset: 0x00282ECD
		// (set) Token: 0x06011356 RID: 70486 RVA: 0x00284CD5 File Offset: 0x00282ED5
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

		// Token: 0x06011357 RID: 70487 RVA: 0x00284CDE File Offset: 0x00282EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardTargetInfoResponse);
		}

		// Token: 0x06011358 RID: 70488 RVA: 0x00284CEC File Offset: 0x00282EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardTargetInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectType == other.EffectType && this.fighterUId_.Equals(other.fighterUId_) && this.Num == other.Num && this.CardUId == other.CardUId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011359 RID: 70489 RVA: 0x00284D7C File Offset: 0x00282F7C
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

		// Token: 0x0601135A RID: 70490 RVA: 0x00284E33 File Offset: 0x00283033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601135B RID: 70491 RVA: 0x00284E40 File Offset: 0x00283040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601135C RID: 70492 RVA: 0x00284E4C File Offset: 0x0028304C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.EffectType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EffectType);
			}
			this.fighterUId_.WriteTo(ref output, PhantomBattleCardTargetInfoResponse._repeated_fighterUId_codec);
			if (this.CardUId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CardUId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601135D RID: 70493 RVA: 0x00284F0C File Offset: 0x0028310C
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

		// Token: 0x0601135E RID: 70494 RVA: 0x00284FC0 File Offset: 0x002831C0
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

		// Token: 0x0601135F RID: 70495 RVA: 0x0028505D File Offset: 0x0028325D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011360 RID: 70496 RVA: 0x00285068 File Offset: 0x00283268
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
					if (num == 16U)
					{
						this.Num = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.EffectType = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						goto IL_6D;
					}
				}
				else if (num <= 48U)
				{
					if (num == 42U)
					{
						goto IL_6D;
					}
					if (num == 48U)
					{
						this.CardUId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_6D:
				this.fighterUId_.AddEntriesFrom(ref input, PhantomBattleCardTargetInfoResponse._repeated_fighterUId_codec);
			}
		}

		// Token: 0x04006CD0 RID: 27856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CD1 RID: 27857
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006CD2 RID: 27858
		private ErrorCode errorCode_;

		// Token: 0x04006CD3 RID: 27859
		public const int EffectTypeFieldNumber = 4;

		// Token: 0x04006CD4 RID: 27860
		private int effectType_;

		// Token: 0x04006CD5 RID: 27861
		public const int FighterUIdFieldNumber = 5;

		// Token: 0x04006CD6 RID: 27862
		private static readonly FieldCodec<int> _repeated_fighterUId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006CD7 RID: 27863
		private readonly RepeatedField<int> fighterUId_ = new RepeatedField<int>();

		// Token: 0x04006CD8 RID: 27864
		public const int NumFieldNumber = 2;

		// Token: 0x04006CD9 RID: 27865
		private int num_;

		// Token: 0x04006CDA RID: 27866
		public const int CardUIdFieldNumber = 6;

		// Token: 0x04006CDB RID: 27867
		private int cardUId_;

		// Token: 0x04006CDC RID: 27868
		public const int SkillIdFieldNumber = 14;

		// Token: 0x04006CDD RID: 27869
		private int skillId_;
	}
}
