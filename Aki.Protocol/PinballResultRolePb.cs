using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D57 RID: 3415
	public sealed class PinballResultRolePb : IMessage<PinballResultRolePb>, IMessage, IEquatable<PinballResultRolePb>, IDeepCloneable<PinballResultRolePb>, IBufferMessage
	{
		// Token: 0x060126BE RID: 75454 RVA: 0x002B0443 File Offset: 0x002AE643
		[NullableContext(1)]
		public static PinballResultRolePb Create()
		{
			return new PinballResultRolePb();
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x060126BF RID: 75455 RVA: 0x002B044A File Offset: 0x002AE64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballResultRolePb> Parser
		{
			get
			{
				return PinballResultRolePb._parser;
			}
		}

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x060126C0 RID: 75456 RVA: 0x002B0451 File Offset: 0x002AE651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x060126C1 RID: 75457 RVA: 0x002B0454 File Offset: 0x002AE654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballResultRolePb.Descriptor;
			}
		}

		// Token: 0x060126C2 RID: 75458 RVA: 0x002B045B File Offset: 0x002AE65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResultRolePb()
		{
		}

		// Token: 0x060126C3 RID: 75459 RVA: 0x002B0464 File Offset: 0x002AE664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResultRolePb(PinballResultRolePb other) : this()
		{
			this.roleId_ = other.roleId_;
			this.damage_ = other.damage_;
			this.skillTimes_ = other.skillTimes_;
			this.dropCostHp_ = other.dropCostHp_;
			this.hitCostHp_ = other.hitCostHp_;
			this.tempDieTimes_ = other.tempDieTimes_;
			this.tempReviveTimes_ = other.tempReviveTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060126C4 RID: 75460 RVA: 0x002B04DC File Offset: 0x002AE6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResultRolePb Clone()
		{
			return new PinballResultRolePb(this);
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x060126C5 RID: 75461 RVA: 0x002B04E4 File Offset: 0x002AE6E4
		// (set) Token: 0x060126C6 RID: 75462 RVA: 0x002B04EC File Offset: 0x002AE6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x060126C7 RID: 75463 RVA: 0x002B04F5 File Offset: 0x002AE6F5
		// (set) Token: 0x060126C8 RID: 75464 RVA: 0x002B04FD File Offset: 0x002AE6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Damage
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

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x060126C9 RID: 75465 RVA: 0x002B0506 File Offset: 0x002AE706
		// (set) Token: 0x060126CA RID: 75466 RVA: 0x002B050E File Offset: 0x002AE70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillTimes
		{
			get
			{
				return this.skillTimes_;
			}
			set
			{
				this.skillTimes_ = value;
			}
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x060126CB RID: 75467 RVA: 0x002B0517 File Offset: 0x002AE717
		// (set) Token: 0x060126CC RID: 75468 RVA: 0x002B051F File Offset: 0x002AE71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DropCostHp
		{
			get
			{
				return this.dropCostHp_;
			}
			set
			{
				this.dropCostHp_ = value;
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x060126CD RID: 75469 RVA: 0x002B0528 File Offset: 0x002AE728
		// (set) Token: 0x060126CE RID: 75470 RVA: 0x002B0530 File Offset: 0x002AE730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HitCostHp
		{
			get
			{
				return this.hitCostHp_;
			}
			set
			{
				this.hitCostHp_ = value;
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x060126CF RID: 75471 RVA: 0x002B0539 File Offset: 0x002AE739
		// (set) Token: 0x060126D0 RID: 75472 RVA: 0x002B0541 File Offset: 0x002AE741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TempDieTimes
		{
			get
			{
				return this.tempDieTimes_;
			}
			set
			{
				this.tempDieTimes_ = value;
			}
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x060126D1 RID: 75473 RVA: 0x002B054A File Offset: 0x002AE74A
		// (set) Token: 0x060126D2 RID: 75474 RVA: 0x002B0552 File Offset: 0x002AE752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TempReviveTimes
		{
			get
			{
				return this.tempReviveTimes_;
			}
			set
			{
				this.tempReviveTimes_ = value;
			}
		}

		// Token: 0x060126D3 RID: 75475 RVA: 0x002B055B File Offset: 0x002AE75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballResultRolePb);
		}

		// Token: 0x060126D4 RID: 75476 RVA: 0x002B056C File Offset: 0x002AE76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballResultRolePb other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Damage == other.Damage && this.SkillTimes == other.SkillTimes && this.DropCostHp == other.DropCostHp && this.HitCostHp == other.HitCostHp && this.TempDieTimes == other.TempDieTimes && this.TempReviveTimes == other.TempReviveTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060126D5 RID: 75477 RVA: 0x002B0608 File Offset: 0x002AE808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Damage != 0L)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.SkillTimes != 0)
			{
				num ^= this.SkillTimes.GetHashCode();
			}
			if (this.DropCostHp != 0L)
			{
				num ^= this.DropCostHp.GetHashCode();
			}
			if (this.HitCostHp != 0L)
			{
				num ^= this.HitCostHp.GetHashCode();
			}
			if (this.TempDieTimes != 0)
			{
				num ^= this.TempDieTimes.GetHashCode();
			}
			if (this.TempReviveTimes != 0)
			{
				num ^= this.TempReviveTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060126D6 RID: 75478 RVA: 0x002B06DD File Offset: 0x002AE8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060126D7 RID: 75479 RVA: 0x002B06EA File Offset: 0x002AE8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060126D8 RID: 75480 RVA: 0x002B06F4 File Offset: 0x002AE8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Damage != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Damage);
			}
			if (this.SkillTimes != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillTimes);
			}
			if (this.DropCostHp != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.DropCostHp);
			}
			if (this.HitCostHp != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.HitCostHp);
			}
			if (this.TempDieTimes != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TempDieTimes);
			}
			if (this.TempReviveTimes != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TempReviveTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060126D9 RID: 75481 RVA: 0x002B07D8 File Offset: 0x002AE9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Damage != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Damage);
			}
			if (this.SkillTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillTimes);
			}
			if (this.DropCostHp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DropCostHp);
			}
			if (this.HitCostHp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HitCostHp);
			}
			if (this.TempDieTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TempDieTimes);
			}
			if (this.TempReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TempReviveTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060126DA RID: 75482 RVA: 0x002B08A8 File Offset: 0x002AEAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballResultRolePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Damage != 0L)
			{
				this.Damage = other.Damage;
			}
			if (other.SkillTimes != 0)
			{
				this.SkillTimes = other.SkillTimes;
			}
			if (other.DropCostHp != 0L)
			{
				this.DropCostHp = other.DropCostHp;
			}
			if (other.HitCostHp != 0L)
			{
				this.HitCostHp = other.HitCostHp;
			}
			if (other.TempDieTimes != 0)
			{
				this.TempDieTimes = other.TempDieTimes;
			}
			if (other.TempReviveTimes != 0)
			{
				this.TempReviveTimes = other.TempReviveTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060126DB RID: 75483 RVA: 0x002B095C File Offset: 0x002AEB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060126DC RID: 75484 RVA: 0x002B0968 File Offset: 0x002AEB68
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Damage = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.SkillTimes = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.DropCostHp = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.HitCostHp = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.TempDieTimes = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.TempReviveTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040072AF RID: 29359
		private static readonly MessageParser<PinballResultRolePb> _parser = new MessageParser<PinballResultRolePb>(() => new PinballResultRolePb());

		// Token: 0x040072B0 RID: 29360
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072B1 RID: 29361
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040072B2 RID: 29362
		private int roleId_;

		// Token: 0x040072B3 RID: 29363
		public const int DamageFieldNumber = 2;

		// Token: 0x040072B4 RID: 29364
		private long damage_;

		// Token: 0x040072B5 RID: 29365
		public const int SkillTimesFieldNumber = 3;

		// Token: 0x040072B6 RID: 29366
		private int skillTimes_;

		// Token: 0x040072B7 RID: 29367
		public const int DropCostHpFieldNumber = 4;

		// Token: 0x040072B8 RID: 29368
		private long dropCostHp_;

		// Token: 0x040072B9 RID: 29369
		public const int HitCostHpFieldNumber = 5;

		// Token: 0x040072BA RID: 29370
		private long hitCostHp_;

		// Token: 0x040072BB RID: 29371
		public const int TempDieTimesFieldNumber = 6;

		// Token: 0x040072BC RID: 29372
		private int tempDieTimes_;

		// Token: 0x040072BD RID: 29373
		public const int TempReviveTimesFieldNumber = 7;

		// Token: 0x040072BE RID: 29374
		private int tempReviveTimes_;
	}
}
