using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034E RID: 846
	public sealed class DangoBrawlFightActionHealInfo : IMessage<DangoBrawlFightActionHealInfo>, IMessage, IEquatable<DangoBrawlFightActionHealInfo>, IDeepCloneable<DangoBrawlFightActionHealInfo>, IBufferMessage
	{
		// Token: 0x0600548D RID: 21645 RVA: 0x000CE06B File Offset: 0x000CC26B
		[NullableContext(1)]
		public static DangoBrawlFightActionHealInfo Create()
		{
			return new DangoBrawlFightActionHealInfo();
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x000CE072 File Offset: 0x000CC272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x0600548F RID: 21647 RVA: 0x000CE075 File Offset: 0x000CC275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionHealInfo.Descriptor;
			}
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x000CE07C File Offset: 0x000CC27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionHealInfo()
		{
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x000CE090 File Offset: 0x000CC290
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

		// Token: 0x06005492 RID: 21650 RVA: 0x000CE0E9 File Offset: 0x000CC2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionHealInfo Clone()
		{
			return new DangoBrawlFightActionHealInfo(this);
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06005493 RID: 21651 RVA: 0x000CE0F1 File Offset: 0x000CC2F1
		// (set) Token: 0x06005494 RID: 21652 RVA: 0x000CE0F9 File Offset: 0x000CC2F9
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

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06005495 RID: 21653 RVA: 0x000CE102 File Offset: 0x000CC302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HealValues
		{
			get
			{
				return this.healValues_;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06005496 RID: 21654 RVA: 0x000CE10A File Offset: 0x000CC30A
		// (set) Token: 0x06005497 RID: 21655 RVA: 0x000CE112 File Offset: 0x000CC312
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

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06005498 RID: 21656 RVA: 0x000CE11B File Offset: 0x000CC31B
		// (set) Token: 0x06005499 RID: 21657 RVA: 0x000CE123 File Offset: 0x000CC323
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

		// Token: 0x0600549A RID: 21658 RVA: 0x000CE12C File Offset: 0x000CC32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionHealInfo);
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x000CE13C File Offset: 0x000CC33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionHealInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.healValues_.Equals(other.healValues_) && this.ItemConfigId == other.ItemConfigId && this.ItemUId == other.ItemUId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x000CE1AC File Offset: 0x000CC3AC
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

		// Token: 0x0600549D RID: 21661 RVA: 0x000CE22B File Offset: 0x000CC42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x000CE238 File Offset: 0x000CC438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x000CE244 File Offset: 0x000CC444
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

		// Token: 0x060054A0 RID: 21664 RVA: 0x000CE2CC File Offset: 0x000CC4CC
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

		// Token: 0x060054A1 RID: 21665 RVA: 0x000CE350 File Offset: 0x000CC550
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

		// Token: 0x060054A2 RID: 21666 RVA: 0x000CE3C5 File Offset: 0x000CC5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x000CE3D0 File Offset: 0x000CC5D0
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

		// Token: 0x040033D4 RID: 13268
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033D5 RID: 13269
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x040033D6 RID: 13270
		private int targetFighterUId_;

		// Token: 0x040033D7 RID: 13271
		public const int HealValuesFieldNumber = 2;

		// Token: 0x040033D8 RID: 13272
		private static readonly FieldCodec<int> _repeated_healValues_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040033D9 RID: 13273
		private readonly RepeatedField<int> healValues_ = new RepeatedField<int>();

		// Token: 0x040033DA RID: 13274
		public const int ItemConfigIdFieldNumber = 3;

		// Token: 0x040033DB RID: 13275
		private int itemConfigId_;

		// Token: 0x040033DC RID: 13276
		public const int ItemUIdFieldNumber = 4;

		// Token: 0x040033DD RID: 13277
		private int itemUId_;
	}
}
