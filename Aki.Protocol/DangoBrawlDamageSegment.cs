using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000347 RID: 839
	public sealed class DangoBrawlDamageSegment : IMessage<DangoBrawlDamageSegment>, IMessage, IEquatable<DangoBrawlDamageSegment>, IDeepCloneable<DangoBrawlDamageSegment>, IBufferMessage
	{
		// Token: 0x06005432 RID: 21554 RVA: 0x000CD738 File Offset: 0x000CB938
		[NullableContext(1)]
		public static DangoBrawlDamageSegment Create()
		{
			return new DangoBrawlDamageSegment();
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06005433 RID: 21555 RVA: 0x000CD73F File Offset: 0x000CB93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlDamageSegment> Parser
		{
			get
			{
				return DangoBrawlDamageSegment._parser;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x000CD746 File Offset: 0x000CB946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06005435 RID: 21557 RVA: 0x000CD749 File Offset: 0x000CB949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlDamageSegment.Descriptor;
			}
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x000CD750 File Offset: 0x000CB950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageSegment()
		{
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x000CD758 File Offset: 0x000CB958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageSegment(DangoBrawlDamageSegment other) : this()
		{
			this.damageType_ = other.damageType_;
			this.damage_ = other.damage_;
			this.itemUId_ = other.itemUId_;
			this.showType_ = other.showType_;
			this.buffConfigId_ = other.buffConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x000CD7B8 File Offset: 0x000CB9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageSegment Clone()
		{
			return new DangoBrawlDamageSegment(this);
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06005439 RID: 21561 RVA: 0x000CD7C0 File Offset: 0x000CB9C0
		// (set) Token: 0x0600543A RID: 21562 RVA: 0x000CD7C8 File Offset: 0x000CB9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageType DamageType
		{
			get
			{
				return this.damageType_;
			}
			set
			{
				this.damageType_ = value;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x000CD7D1 File Offset: 0x000CB9D1
		// (set) Token: 0x0600543C RID: 21564 RVA: 0x000CD7D9 File Offset: 0x000CB9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x000CD7E2 File Offset: 0x000CB9E2
		// (set) Token: 0x0600543E RID: 21566 RVA: 0x000CD7EA File Offset: 0x000CB9EA
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

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x0600543F RID: 21567 RVA: 0x000CD7F3 File Offset: 0x000CB9F3
		// (set) Token: 0x06005440 RID: 21568 RVA: 0x000CD7FB File Offset: 0x000CB9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowType
		{
			get
			{
				return this.showType_;
			}
			set
			{
				this.showType_ = value;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x000CD804 File Offset: 0x000CBA04
		// (set) Token: 0x06005442 RID: 21570 RVA: 0x000CD80C File Offset: 0x000CBA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffConfigId
		{
			get
			{
				return this.buffConfigId_;
			}
			set
			{
				this.buffConfigId_ = value;
			}
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x000CD815 File Offset: 0x000CBA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlDamageSegment);
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x000CD824 File Offset: 0x000CBA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlDamageSegment other)
		{
			return other != null && (other == this || (this.DamageType == other.DamageType && this.Damage == other.Damage && this.ItemUId == other.ItemUId && this.ShowType == other.ShowType && this.BuffConfigId == other.BuffConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x000CD8A0 File Offset: 0x000CBAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DamageType != DangoBrawlDamageType.DangoBrawlDamageWeapon)
			{
				num ^= this.DamageType.GetHashCode();
			}
			if (this.Damage != 0)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.ItemUId != 0)
			{
				num ^= this.ItemUId.GetHashCode();
			}
			if (this.ShowType != 0)
			{
				num ^= this.ShowType.GetHashCode();
			}
			if (this.BuffConfigId != 0)
			{
				num ^= this.BuffConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x000CD949 File Offset: 0x000CBB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x000CD956 File Offset: 0x000CBB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x000CD960 File Offset: 0x000CBB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DamageType != DangoBrawlDamageType.DangoBrawlDamageWeapon)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.DamageType);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Damage);
			}
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemUId);
			}
			if (this.ShowType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ShowType);
			}
			if (this.BuffConfigId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BuffConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x000CDA0C File Offset: 0x000CBC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DamageType != DangoBrawlDamageType.DangoBrawlDamageWeapon)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DamageType);
			}
			if (this.Damage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Damage);
			}
			if (this.ItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUId);
			}
			if (this.ShowType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowType);
			}
			if (this.BuffConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x000CDAAC File Offset: 0x000CBCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlDamageSegment other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DamageType != DangoBrawlDamageType.DangoBrawlDamageWeapon)
			{
				this.DamageType = other.DamageType;
			}
			if (other.Damage != 0)
			{
				this.Damage = other.Damage;
			}
			if (other.ItemUId != 0)
			{
				this.ItemUId = other.ItemUId;
			}
			if (other.ShowType != 0)
			{
				this.ShowType = other.ShowType;
			}
			if (other.BuffConfigId != 0)
			{
				this.BuffConfigId = other.BuffConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x000CDB38 File Offset: 0x000CBD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x000CDB44 File Offset: 0x000CBD44
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
						this.DamageType = (DangoBrawlDamageType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Damage = input.ReadInt32();
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
						this.ShowType = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.BuffConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003408 RID: 13320
		private static readonly MessageParser<DangoBrawlDamageSegment> _parser = new MessageParser<DangoBrawlDamageSegment>(() => new DangoBrawlDamageSegment());

		// Token: 0x04003409 RID: 13321
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400340A RID: 13322
		public const int DamageTypeFieldNumber = 1;

		// Token: 0x0400340B RID: 13323
		private DangoBrawlDamageType damageType_;

		// Token: 0x0400340C RID: 13324
		public const int DamageFieldNumber = 2;

		// Token: 0x0400340D RID: 13325
		private int damage_;

		// Token: 0x0400340E RID: 13326
		public const int ItemUIdFieldNumber = 3;

		// Token: 0x0400340F RID: 13327
		private int itemUId_;

		// Token: 0x04003410 RID: 13328
		public const int ShowTypeFieldNumber = 4;

		// Token: 0x04003411 RID: 13329
		private int showType_;

		// Token: 0x04003412 RID: 13330
		public const int BuffConfigIdFieldNumber = 5;

		// Token: 0x04003413 RID: 13331
		private int buffConfigId_;
	}
}
