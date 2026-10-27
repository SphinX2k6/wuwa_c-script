using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001059 RID: 4185
	[NetMessage(EMessageId.RoleBreakThroughViewResponse)]
	public sealed class RoleBreakThroughViewResponse : IMessage<RoleBreakThroughViewResponse>, IMessage, IEquatable<RoleBreakThroughViewResponse>, IDeepCloneable<RoleBreakThroughViewResponse>, IBufferMessage
	{
		// Token: 0x060165C6 RID: 91590 RVA: 0x0033FC65 File Offset: 0x0033DE65
		[NullableContext(1)]
		public static RoleBreakThroughViewResponse Create()
		{
			return new RoleBreakThroughViewResponse();
		}

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x060165C7 RID: 91591 RVA: 0x0033FC6C File Offset: 0x0033DE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ACD RID: 19149
		// (get) Token: 0x060165C8 RID: 91592 RVA: 0x0033FC6F File Offset: 0x0033DE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBreakThroughViewResponse.Descriptor;
			}
		}

		// Token: 0x060165C9 RID: 91593 RVA: 0x0033FC76 File Offset: 0x0033DE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewResponse()
		{
		}

		// Token: 0x060165CA RID: 91594 RVA: 0x0033FCA0 File Offset: 0x0033DEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewResponse(RoleBreakThroughViewResponse other) : this()
		{
			this.code_ = other.code_;
			this.levelLimit_ = other.levelLimit_;
			this.unLockSkillId_ = other.unLockSkillId_;
			this.costList_ = other.costList_.Clone();
			this.rewardList_ = other.rewardList_.Clone();
			this.finalProp_ = other.finalProp_.Clone();
			this.isConditionFinish_ = other.isConditionFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060165CB RID: 91595 RVA: 0x0033FD27 File Offset: 0x0033DF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewResponse Clone()
		{
			return new RoleBreakThroughViewResponse(this);
		}

		// Token: 0x17004ACE RID: 19150
		// (get) Token: 0x060165CC RID: 91596 RVA: 0x0033FD2F File Offset: 0x0033DF2F
		// (set) Token: 0x060165CD RID: 91597 RVA: 0x0033FD37 File Offset: 0x0033DF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17004ACF RID: 19151
		// (get) Token: 0x060165CE RID: 91598 RVA: 0x0033FD40 File Offset: 0x0033DF40
		// (set) Token: 0x060165CF RID: 91599 RVA: 0x0033FD48 File Offset: 0x0033DF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelLimit
		{
			get
			{
				return this.levelLimit_;
			}
			set
			{
				this.levelLimit_ = value;
			}
		}

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x060165D0 RID: 91600 RVA: 0x0033FD51 File Offset: 0x0033DF51
		// (set) Token: 0x060165D1 RID: 91601 RVA: 0x0033FD59 File Offset: 0x0033DF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockSkillId
		{
			get
			{
				return this.unLockSkillId_;
			}
			set
			{
				this.unLockSkillId_ = value;
			}
		}

		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x060165D2 RID: 91602 RVA: 0x0033FD62 File Offset: 0x0033DF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> CostList
		{
			get
			{
				return this.costList_;
			}
		}

		// Token: 0x17004AD2 RID: 19154
		// (get) Token: 0x060165D3 RID: 91603 RVA: 0x0033FD6A File Offset: 0x0033DF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> RewardList
		{
			get
			{
				return this.rewardList_;
			}
		}

		// Token: 0x17004AD3 RID: 19155
		// (get) Token: 0x060165D4 RID: 91604 RVA: 0x0033FD72 File Offset: 0x0033DF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntDouble> FinalProp
		{
			get
			{
				return this.finalProp_;
			}
		}

		// Token: 0x17004AD4 RID: 19156
		// (get) Token: 0x060165D5 RID: 91605 RVA: 0x0033FD7A File Offset: 0x0033DF7A
		// (set) Token: 0x060165D6 RID: 91606 RVA: 0x0033FD82 File Offset: 0x0033DF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConditionFinish
		{
			get
			{
				return this.isConditionFinish_;
			}
			set
			{
				this.isConditionFinish_ = value;
			}
		}

		// Token: 0x060165D7 RID: 91607 RVA: 0x0033FD8B File Offset: 0x0033DF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBreakThroughViewResponse);
		}

		// Token: 0x060165D8 RID: 91608 RVA: 0x0033FD9C File Offset: 0x0033DF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBreakThroughViewResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.LevelLimit == other.LevelLimit && this.UnLockSkillId == other.UnLockSkillId && this.costList_.Equals(other.costList_) && this.rewardList_.Equals(other.rewardList_) && this.finalProp_.Equals(other.finalProp_) && this.IsConditionFinish == other.IsConditionFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060165D9 RID: 91609 RVA: 0x0033FE44 File Offset: 0x0033E044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.LevelLimit != 0)
			{
				num ^= this.LevelLimit.GetHashCode();
			}
			if (this.UnLockSkillId != 0)
			{
				num ^= this.UnLockSkillId.GetHashCode();
			}
			num ^= this.costList_.GetHashCode();
			num ^= this.rewardList_.GetHashCode();
			num ^= this.finalProp_.GetHashCode();
			if (this.IsConditionFinish)
			{
				num ^= this.IsConditionFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060165DA RID: 91610 RVA: 0x0033FEFE File Offset: 0x0033E0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060165DB RID: 91611 RVA: 0x0033FF0B File Offset: 0x0033E10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060165DC RID: 91612 RVA: 0x0033FF14 File Offset: 0x0033E114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.costList_.WriteTo(ref output, RoleBreakThroughViewResponse._repeated_costList_codec);
			if (this.LevelLimit != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LevelLimit);
			}
			if (this.IsConditionFinish)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsConditionFinish);
			}
			this.finalProp_.WriteTo(ref output, RoleBreakThroughViewResponse._repeated_finalProp_codec);
			if (this.UnLockSkillId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.UnLockSkillId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			this.rewardList_.WriteTo(ref output, RoleBreakThroughViewResponse._repeated_rewardList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060165DD RID: 91613 RVA: 0x0033FFD8 File Offset: 0x0033E1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.LevelLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelLimit);
			}
			if (this.UnLockSkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockSkillId);
			}
			num += this.costList_.CalculateSize(RoleBreakThroughViewResponse._repeated_costList_codec);
			num += this.rewardList_.CalculateSize(RoleBreakThroughViewResponse._repeated_rewardList_codec);
			num += this.finalProp_.CalculateSize(RoleBreakThroughViewResponse._repeated_finalProp_codec);
			if (this.IsConditionFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060165DE RID: 91614 RVA: 0x0034008C File Offset: 0x0033E28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBreakThroughViewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.LevelLimit != 0)
			{
				this.LevelLimit = other.LevelLimit;
			}
			if (other.UnLockSkillId != 0)
			{
				this.UnLockSkillId = other.UnLockSkillId;
			}
			this.costList_.Add(other.costList_);
			this.rewardList_.Add(other.rewardList_);
			this.finalProp_.Add(other.finalProp_);
			if (other.IsConditionFinish)
			{
				this.IsConditionFinish = other.IsConditionFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060165DF RID: 91615 RVA: 0x00340137 File Offset: 0x0033E337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060165E0 RID: 91616 RVA: 0x00340140 File Offset: 0x0033E340
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
					if (num == 26U)
					{
						this.costList_.AddEntriesFrom(ref input, RoleBreakThroughViewResponse._repeated_costList_codec);
						continue;
					}
					if (num == 32U)
					{
						this.LevelLimit = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.IsConditionFinish = input.ReadBool();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 74U)
					{
						this.finalProp_.AddEntriesFrom(ref input, RoleBreakThroughViewResponse._repeated_finalProp_codec);
						continue;
					}
					if (num == 88U)
					{
						this.UnLockSkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 106U)
					{
						this.rewardList_.AddEntriesFrom(ref input, RoleBreakThroughViewResponse._repeated_rewardList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040085B9 RID: 34233
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085BA RID: 34234
		public const int CodeFieldNumber = 12;

		// Token: 0x040085BB RID: 34235
		private ErrorCode code_;

		// Token: 0x040085BC RID: 34236
		public const int LevelLimitFieldNumber = 4;

		// Token: 0x040085BD RID: 34237
		private int levelLimit_;

		// Token: 0x040085BE RID: 34238
		public const int UnLockSkillIdFieldNumber = 11;

		// Token: 0x040085BF RID: 34239
		private int unLockSkillId_;

		// Token: 0x040085C0 RID: 34240
		public const int CostListFieldNumber = 3;

		// Token: 0x040085C1 RID: 34241
		private static readonly FieldCodec<ArrayIntInt> _repeated_costList_codec = FieldCodec.ForMessage<ArrayIntInt>(26U, ArrayIntInt.Parser);

		// Token: 0x040085C2 RID: 34242
		private readonly RepeatedField<ArrayIntInt> costList_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040085C3 RID: 34243
		public const int RewardListFieldNumber = 13;

		// Token: 0x040085C4 RID: 34244
		private static readonly FieldCodec<ArrayIntInt> _repeated_rewardList_codec = FieldCodec.ForMessage<ArrayIntInt>(106U, ArrayIntInt.Parser);

		// Token: 0x040085C5 RID: 34245
		private readonly RepeatedField<ArrayIntInt> rewardList_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040085C6 RID: 34246
		public const int FinalPropFieldNumber = 9;

		// Token: 0x040085C7 RID: 34247
		private static readonly FieldCodec<ArrayIntDouble> _repeated_finalProp_codec = FieldCodec.ForMessage<ArrayIntDouble>(74U, ArrayIntDouble.Parser);

		// Token: 0x040085C8 RID: 34248
		private readonly RepeatedField<ArrayIntDouble> finalProp_ = new RepeatedField<ArrayIntDouble>();

		// Token: 0x040085C9 RID: 34249
		public const int IsConditionFinishFieldNumber = 7;

		// Token: 0x040085CA RID: 34250
		private bool isConditionFinish_;
	}
}
