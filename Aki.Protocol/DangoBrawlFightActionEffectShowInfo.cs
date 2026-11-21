using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000354 RID: 852
	public sealed class DangoBrawlFightActionEffectShowInfo : IMessage<DangoBrawlFightActionEffectShowInfo>, IMessage, IEquatable<DangoBrawlFightActionEffectShowInfo>, IDeepCloneable<DangoBrawlFightActionEffectShowInfo>, IBufferMessage
	{
		// Token: 0x0600554E RID: 21838 RVA: 0x000D0078 File Offset: 0x000CE278
		[NullableContext(1)]
		public static DangoBrawlFightActionEffectShowInfo Create()
		{
			return new DangoBrawlFightActionEffectShowInfo();
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x0600554F RID: 21839 RVA: 0x000D007F File Offset: 0x000CE27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x000D0082 File Offset: 0x000CE282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionEffectShowInfo.Descriptor;
			}
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x000D0089 File Offset: 0x000CE289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionEffectShowInfo()
		{
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x000D0094 File Offset: 0x000CE294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionEffectShowInfo(DangoBrawlFightActionEffectShowInfo other) : this()
		{
			this.ownerFighterUId_ = other.ownerFighterUId_;
			this.effectId_ = other.effectId_;
			this.itemUId_ = other.itemUId_;
			this.isTriggerLimit_ = other.isTriggerLimit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x000D00E8 File Offset: 0x000CE2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionEffectShowInfo Clone()
		{
			return new DangoBrawlFightActionEffectShowInfo(this);
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06005554 RID: 21844 RVA: 0x000D00F0 File Offset: 0x000CE2F0
		// (set) Token: 0x06005555 RID: 21845 RVA: 0x000D00F8 File Offset: 0x000CE2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OwnerFighterUId
		{
			get
			{
				return this.ownerFighterUId_;
			}
			set
			{
				this.ownerFighterUId_ = value;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06005556 RID: 21846 RVA: 0x000D0101 File Offset: 0x000CE301
		// (set) Token: 0x06005557 RID: 21847 RVA: 0x000D0109 File Offset: 0x000CE309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectId
		{
			get
			{
				return this.effectId_;
			}
			set
			{
				this.effectId_ = value;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06005558 RID: 21848 RVA: 0x000D0112 File Offset: 0x000CE312
		// (set) Token: 0x06005559 RID: 21849 RVA: 0x000D011A File Offset: 0x000CE31A
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

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x0600555A RID: 21850 RVA: 0x000D0123 File Offset: 0x000CE323
		// (set) Token: 0x0600555B RID: 21851 RVA: 0x000D012B File Offset: 0x000CE32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTriggerLimit
		{
			get
			{
				return this.isTriggerLimit_;
			}
			set
			{
				this.isTriggerLimit_ = value;
			}
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x000D0134 File Offset: 0x000CE334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionEffectShowInfo);
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x000D0144 File Offset: 0x000CE344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionEffectShowInfo other)
		{
			return other != null && (other == this || (this.OwnerFighterUId == other.OwnerFighterUId && this.EffectId == other.EffectId && this.ItemUId == other.ItemUId && this.IsTriggerLimit == other.IsTriggerLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x000D01B0 File Offset: 0x000CE3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OwnerFighterUId != 0)
			{
				num ^= this.OwnerFighterUId.GetHashCode();
			}
			if (this.EffectId != 0)
			{
				num ^= this.EffectId.GetHashCode();
			}
			if (this.ItemUId != 0)
			{
				num ^= this.ItemUId.GetHashCode();
			}
			if (this.IsTriggerLimit)
			{
				num ^= this.IsTriggerLimit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x000D023A File Offset: 0x000CE43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x000D0247 File Offset: 0x000CE447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x000D0250 File Offset: 0x000CE450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OwnerFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.OwnerFighterUId);
			}
			if (this.EffectId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EffectId);
			}
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemUId);
			}
			if (this.IsTriggerLimit)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsTriggerLimit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x000D02E0 File Offset: 0x000CE4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OwnerFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OwnerFighterUId);
			}
			if (this.EffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectId);
			}
			if (this.ItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUId);
			}
			if (this.IsTriggerLimit)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x000D035C File Offset: 0x000CE55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionEffectShowInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OwnerFighterUId != 0)
			{
				this.OwnerFighterUId = other.OwnerFighterUId;
			}
			if (other.EffectId != 0)
			{
				this.EffectId = other.EffectId;
			}
			if (other.ItemUId != 0)
			{
				this.ItemUId = other.ItemUId;
			}
			if (other.IsTriggerLimit)
			{
				this.IsTriggerLimit = other.IsTriggerLimit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x000D03D4 File Offset: 0x000CE5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x000D03E0 File Offset: 0x000CE5E0
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
						this.OwnerFighterUId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EffectId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ItemUId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsTriggerLimit = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003462 RID: 13410
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003463 RID: 13411
		public const int OwnerFighterUIdFieldNumber = 1;

		// Token: 0x04003464 RID: 13412
		private int ownerFighterUId_;

		// Token: 0x04003465 RID: 13413
		public const int EffectIdFieldNumber = 2;

		// Token: 0x04003466 RID: 13414
		private int effectId_;

		// Token: 0x04003467 RID: 13415
		public const int ItemUIdFieldNumber = 3;

		// Token: 0x04003468 RID: 13416
		private int itemUId_;

		// Token: 0x04003469 RID: 13417
		public const int IsTriggerLimitFieldNumber = 4;

		// Token: 0x0400346A RID: 13418
		private bool isTriggerLimit_;
	}
}
