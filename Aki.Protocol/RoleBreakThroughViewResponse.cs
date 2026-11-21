using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001049 RID: 4169
	[NetMessage(EMessageId.RoleBreakThroughViewResponse)]
	public sealed class RoleBreakThroughViewResponse : IMessage<RoleBreakThroughViewResponse>, IMessage, IEquatable<RoleBreakThroughViewResponse>, IDeepCloneable<RoleBreakThroughViewResponse>, IBufferMessage
	{
		// Token: 0x060164E1 RID: 91361 RVA: 0x0033E591 File Offset: 0x0033C791
		[NullableContext(1)]
		public static RoleBreakThroughViewResponse Create()
		{
			return new RoleBreakThroughViewResponse();
		}

		// Token: 0x17004AA2 RID: 19106
		// (get) Token: 0x060164E2 RID: 91362 RVA: 0x0033E598 File Offset: 0x0033C798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AA3 RID: 19107
		// (get) Token: 0x060164E3 RID: 91363 RVA: 0x0033E59B File Offset: 0x0033C79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBreakThroughViewResponse.Descriptor;
			}
		}

		// Token: 0x060164E4 RID: 91364 RVA: 0x0033E5A2 File Offset: 0x0033C7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewResponse()
		{
		}

		// Token: 0x060164E5 RID: 91365 RVA: 0x0033E5CC File Offset: 0x0033C7CC
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

		// Token: 0x060164E6 RID: 91366 RVA: 0x0033E653 File Offset: 0x0033C853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBreakThroughViewResponse Clone()
		{
			return new RoleBreakThroughViewResponse(this);
		}

		// Token: 0x17004AA4 RID: 19108
		// (get) Token: 0x060164E7 RID: 91367 RVA: 0x0033E65B File Offset: 0x0033C85B
		// (set) Token: 0x060164E8 RID: 91368 RVA: 0x0033E663 File Offset: 0x0033C863
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

		// Token: 0x17004AA5 RID: 19109
		// (get) Token: 0x060164E9 RID: 91369 RVA: 0x0033E66C File Offset: 0x0033C86C
		// (set) Token: 0x060164EA RID: 91370 RVA: 0x0033E674 File Offset: 0x0033C874
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

		// Token: 0x17004AA6 RID: 19110
		// (get) Token: 0x060164EB RID: 91371 RVA: 0x0033E67D File Offset: 0x0033C87D
		// (set) Token: 0x060164EC RID: 91372 RVA: 0x0033E685 File Offset: 0x0033C885
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

		// Token: 0x17004AA7 RID: 19111
		// (get) Token: 0x060164ED RID: 91373 RVA: 0x0033E68E File Offset: 0x0033C88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> CostList
		{
			get
			{
				return this.costList_;
			}
		}

		// Token: 0x17004AA8 RID: 19112
		// (get) Token: 0x060164EE RID: 91374 RVA: 0x0033E696 File Offset: 0x0033C896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> RewardList
		{
			get
			{
				return this.rewardList_;
			}
		}

		// Token: 0x17004AA9 RID: 19113
		// (get) Token: 0x060164EF RID: 91375 RVA: 0x0033E69E File Offset: 0x0033C89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntDouble> FinalProp
		{
			get
			{
				return this.finalProp_;
			}
		}

		// Token: 0x17004AAA RID: 19114
		// (get) Token: 0x060164F0 RID: 91376 RVA: 0x0033E6A6 File Offset: 0x0033C8A6
		// (set) Token: 0x060164F1 RID: 91377 RVA: 0x0033E6AE File Offset: 0x0033C8AE
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

		// Token: 0x060164F2 RID: 91378 RVA: 0x0033E6B7 File Offset: 0x0033C8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBreakThroughViewResponse);
		}

		// Token: 0x060164F3 RID: 91379 RVA: 0x0033E6C8 File Offset: 0x0033C8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBreakThroughViewResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.LevelLimit == other.LevelLimit && this.UnLockSkillId == other.UnLockSkillId && this.costList_.Equals(other.costList_) && this.rewardList_.Equals(other.rewardList_) && this.finalProp_.Equals(other.finalProp_) && this.IsConditionFinish == other.IsConditionFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060164F4 RID: 91380 RVA: 0x0033E770 File Offset: 0x0033C970
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

		// Token: 0x060164F5 RID: 91381 RVA: 0x0033E82A File Offset: 0x0033CA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060164F6 RID: 91382 RVA: 0x0033E837 File Offset: 0x0033CA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060164F7 RID: 91383 RVA: 0x0033E840 File Offset: 0x0033CA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			this.finalProp_.WriteTo(ref output, RoleBreakThroughViewResponse._repeated_finalProp_codec);
			this.costList_.WriteTo(ref output, RoleBreakThroughViewResponse._repeated_costList_codec);
			if (this.UnLockSkillId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.UnLockSkillId);
			}
			this.rewardList_.WriteTo(ref output, RoleBreakThroughViewResponse._repeated_rewardList_codec);
			if (this.LevelLimit != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LevelLimit);
			}
			if (this.IsConditionFinish)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsConditionFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060164F8 RID: 91384 RVA: 0x0033E904 File Offset: 0x0033CB04
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

		// Token: 0x060164F9 RID: 91385 RVA: 0x0033E9B8 File Offset: 0x0033CBB8
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

		// Token: 0x060164FA RID: 91386 RVA: 0x0033EA63 File Offset: 0x0033CC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060164FB RID: 91387 RVA: 0x0033EA6C File Offset: 0x0033CC6C
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
				if (num <= 66U)
				{
					if (num == 8U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 18U)
					{
						this.finalProp_.AddEntriesFrom(ref input, RoleBreakThroughViewResponse._repeated_finalProp_codec);
						continue;
					}
					if (num == 66U)
					{
						this.costList_.AddEntriesFrom(ref input, RoleBreakThroughViewResponse._repeated_costList_codec);
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num == 72U)
					{
						this.UnLockSkillId = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						this.rewardList_.AddEntriesFrom(ref input, RoleBreakThroughViewResponse._repeated_rewardList_codec);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.LevelLimit = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsConditionFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040085E3 RID: 34275
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085E4 RID: 34276
		public const int CodeFieldNumber = 1;

		// Token: 0x040085E5 RID: 34277
		private ErrorCode code_;

		// Token: 0x040085E6 RID: 34278
		public const int LevelLimitFieldNumber = 14;

		// Token: 0x040085E7 RID: 34279
		private int levelLimit_;

		// Token: 0x040085E8 RID: 34280
		public const int UnLockSkillIdFieldNumber = 9;

		// Token: 0x040085E9 RID: 34281
		private int unLockSkillId_;

		// Token: 0x040085EA RID: 34282
		public const int CostListFieldNumber = 8;

		// Token: 0x040085EB RID: 34283
		private static readonly FieldCodec<ArrayIntInt> _repeated_costList_codec = FieldCodec.ForMessage<ArrayIntInt>(66U, ArrayIntInt.Parser);

		// Token: 0x040085EC RID: 34284
		private readonly RepeatedField<ArrayIntInt> costList_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040085ED RID: 34285
		public const int RewardListFieldNumber = 11;

		// Token: 0x040085EE RID: 34286
		private static readonly FieldCodec<ArrayIntInt> _repeated_rewardList_codec = FieldCodec.ForMessage<ArrayIntInt>(90U, ArrayIntInt.Parser);

		// Token: 0x040085EF RID: 34287
		private readonly RepeatedField<ArrayIntInt> rewardList_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x040085F0 RID: 34288
		public const int FinalPropFieldNumber = 2;

		// Token: 0x040085F1 RID: 34289
		private static readonly FieldCodec<ArrayIntDouble> _repeated_finalProp_codec = FieldCodec.ForMessage<ArrayIntDouble>(18U, ArrayIntDouble.Parser);

		// Token: 0x040085F2 RID: 34290
		private readonly RepeatedField<ArrayIntDouble> finalProp_ = new RepeatedField<ArrayIntDouble>();

		// Token: 0x040085F3 RID: 34291
		public const int IsConditionFinishFieldNumber = 15;

		// Token: 0x040085F4 RID: 34292
		private bool isConditionFinish_;
	}
}
