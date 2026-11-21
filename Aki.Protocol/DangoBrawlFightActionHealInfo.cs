using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000356 RID: 854
	public sealed class DangoBrawlFightActionHealInfo : IMessage<DangoBrawlFightActionHealInfo>, IMessage, IEquatable<DangoBrawlFightActionHealInfo>, IDeepCloneable<DangoBrawlFightActionHealInfo>, IBufferMessage
	{
		// Token: 0x0600557A RID: 21882 RVA: 0x000D06F7 File Offset: 0x000CE8F7
		[NullableContext(1)]
		public static DangoBrawlFightActionHealInfo Create()
		{
			return new DangoBrawlFightActionHealInfo();
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x000D06FE File Offset: 0x000CE8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x0600557C RID: 21884 RVA: 0x000D0701 File Offset: 0x000CE901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionHealInfo.Descriptor;
			}
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x000D0708 File Offset: 0x000CE908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionHealInfo()
		{
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x000D071C File Offset: 0x000CE91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionHealInfo(DangoBrawlFightActionHealInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.healValues_ = other.healValues_.Clone();
			this.itemConfigId_ = other.itemConfigId_;
			this.itemUId_ = other.itemUId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x000D0775 File Offset: 0x000CE975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionHealInfo Clone()
		{
			return new DangoBrawlFightActionHealInfo(this);
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06005580 RID: 21888 RVA: 0x000D077D File Offset: 0x000CE97D
		// (set) Token: 0x06005581 RID: 21889 RVA: 0x000D0785 File Offset: 0x000CE985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06005582 RID: 21890 RVA: 0x000D078E File Offset: 0x000CE98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HealValues
		{
			get
			{
				return this.healValues_;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06005583 RID: 21891 RVA: 0x000D0796 File Offset: 0x000CE996
		// (set) Token: 0x06005584 RID: 21892 RVA: 0x000D079E File Offset: 0x000CE99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemConfigId
		{
			get
			{
				return this.itemConfigId_;
			}
			set
			{
				this.itemConfigId_ = value;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06005585 RID: 21893 RVA: 0x000D07A7 File Offset: 0x000CE9A7
		// (set) Token: 0x06005586 RID: 21894 RVA: 0x000D07AF File Offset: 0x000CE9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUId
		{
			get
			{
				return this.itemUId_;
			}
			set
			{
				this.itemUId_ = value;
			}
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x000D07B8 File Offset: 0x000CE9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionHealInfo);
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x000D07C8 File Offset: 0x000CE9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionHealInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.healValues_.Equals(other.healValues_) && this.ItemConfigId == other.ItemConfigId && this.ItemUId == other.ItemUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x000D0838 File Offset: 0x000CEA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			num ^= this.healValues_.GetHashCode();
			if (this.ItemConfigId != 0)
			{
				num ^= this.ItemConfigId.GetHashCode();
			}
			if (this.ItemUId != 0)
			{
				num ^= this.ItemUId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x000D08B7 File Offset: 0x000CEAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x000D08C4 File Offset: 0x000CEAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x000D08D0 File Offset: 0x000CEAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			this.healValues_.WriteTo(ref output, DangoBrawlFightActionHealInfo._repeated_healValues_codec);
			if (this.ItemConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemConfigId);
			}
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemUId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x000D0958 File Offset: 0x000CEB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			num += this.healValues_.CalculateSize(DangoBrawlFightActionHealInfo._repeated_healValues_codec);
			if (this.ItemConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemConfigId);
			}
			if (this.ItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x000D09DC File Offset: 0x000CEBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionHealInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			this.healValues_.Add(other.healValues_);
			if (other.ItemConfigId != 0)
			{
				this.ItemConfigId = other.ItemConfigId;
			}
			if (other.ItemUId != 0)
			{
				this.ItemUId = other.ItemUId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x000D0A51 File Offset: 0x000CEC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x000D0A5C File Offset: 0x000CEC5C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.TargetFighterUId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U)
					{
						this.ItemConfigId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ItemUId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.healValues_.AddEntriesFrom(ref input, DangoBrawlFightActionHealInfo._repeated_healValues_codec);
			}
		}

		// Token: 0x04003470 RID: 13424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003471 RID: 13425
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x04003472 RID: 13426
		private int targetFighterUId_;

		// Token: 0x04003473 RID: 13427
		public const int HealValuesFieldNumber = 2;

		// Token: 0x04003474 RID: 13428
		private static readonly FieldCodec<int> _repeated_healValues_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003475 RID: 13429
		private readonly RepeatedField<int> healValues_ = new RepeatedField<int>();

		// Token: 0x04003476 RID: 13430
		public const int ItemConfigIdFieldNumber = 3;

		// Token: 0x04003477 RID: 13431
		private int itemConfigId_;

		// Token: 0x04003478 RID: 13432
		public const int ItemUIdFieldNumber = 4;

		// Token: 0x04003479 RID: 13433
		private int itemUId_;
	}
}
