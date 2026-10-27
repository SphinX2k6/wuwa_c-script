using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034C RID: 844
	public sealed class DangoBrawlFightActionEffectShowInfo : IMessage<DangoBrawlFightActionEffectShowInfo>, IMessage, IEquatable<DangoBrawlFightActionEffectShowInfo>, IDeepCloneable<DangoBrawlFightActionEffectShowInfo>, IBufferMessage
	{
		// Token: 0x06005461 RID: 21601 RVA: 0x000CD9EC File Offset: 0x000CBBEC
		[NullableContext(1)]
		public static DangoBrawlFightActionEffectShowInfo Create()
		{
			return new DangoBrawlFightActionEffectShowInfo();
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06005462 RID: 21602 RVA: 0x000CD9F3 File Offset: 0x000CBBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06005463 RID: 21603 RVA: 0x000CD9F6 File Offset: 0x000CBBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionEffectShowInfo.Descriptor;
			}
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x000CD9FD File Offset: 0x000CBBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionEffectShowInfo()
		{
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x000CDA08 File Offset: 0x000CBC08
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

		// Token: 0x06005466 RID: 21606 RVA: 0x000CDA5C File Offset: 0x000CBC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionEffectShowInfo Clone()
		{
			return new DangoBrawlFightActionEffectShowInfo(this);
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x000CDA64 File Offset: 0x000CBC64
		// (set) Token: 0x06005468 RID: 21608 RVA: 0x000CDA6C File Offset: 0x000CBC6C
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

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06005469 RID: 21609 RVA: 0x000CDA75 File Offset: 0x000CBC75
		// (set) Token: 0x0600546A RID: 21610 RVA: 0x000CDA7D File Offset: 0x000CBC7D
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

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x0600546B RID: 21611 RVA: 0x000CDA86 File Offset: 0x000CBC86
		// (set) Token: 0x0600546C RID: 21612 RVA: 0x000CDA8E File Offset: 0x000CBC8E
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

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x0600546D RID: 21613 RVA: 0x000CDA97 File Offset: 0x000CBC97
		// (set) Token: 0x0600546E RID: 21614 RVA: 0x000CDA9F File Offset: 0x000CBC9F
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

		// Token: 0x0600546F RID: 21615 RVA: 0x000CDAA8 File Offset: 0x000CBCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionEffectShowInfo);
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x000CDAB8 File Offset: 0x000CBCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionEffectShowInfo other)
		{
			return other != null && (other == this || (this.OwnerFighterUId == other.OwnerFighterUId && this.EffectId == other.EffectId && this.ItemUId == other.ItemUId && this.IsTriggerLimit == other.IsTriggerLimit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x000CDB24 File Offset: 0x000CBD24
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

		// Token: 0x06005472 RID: 21618 RVA: 0x000CDBAE File Offset: 0x000CBDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x000CDBBB File Offset: 0x000CBDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x000CDBC4 File Offset: 0x000CBDC4
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

		// Token: 0x06005475 RID: 21621 RVA: 0x000CDC54 File Offset: 0x000CBE54
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

		// Token: 0x06005476 RID: 21622 RVA: 0x000CDCD0 File Offset: 0x000CBED0
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

		// Token: 0x06005477 RID: 21623 RVA: 0x000CDD48 File Offset: 0x000CBF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x000CDD54 File Offset: 0x000CBF54
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

		// Token: 0x040033C6 RID: 13254
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033C7 RID: 13255
		public const int OwnerFighterUIdFieldNumber = 1;

		// Token: 0x040033C8 RID: 13256
		private int ownerFighterUId_;

		// Token: 0x040033C9 RID: 13257
		public const int EffectIdFieldNumber = 2;

		// Token: 0x040033CA RID: 13258
		private int effectId_;

		// Token: 0x040033CB RID: 13259
		public const int ItemUIdFieldNumber = 3;

		// Token: 0x040033CC RID: 13260
		private int itemUId_;

		// Token: 0x040033CD RID: 13261
		public const int IsTriggerLimitFieldNumber = 4;

		// Token: 0x040033CE RID: 13262
		private bool isTriggerLimit_;
	}
}
