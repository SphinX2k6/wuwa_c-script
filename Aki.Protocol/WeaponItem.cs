using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EE RID: 5358
	public sealed class WeaponItem : IMessage<WeaponItem>, IMessage, IEquatable<WeaponItem>, IDeepCloneable<WeaponItem>, IBufferMessage
	{
		// Token: 0x0601C53D RID: 116029 RVA: 0x00417C27 File Offset: 0x00415E27
		[NullableContext(1)]
		public static WeaponItem Create()
		{
			return new WeaponItem();
		}

		// Token: 0x17005F7F RID: 24447
		// (get) Token: 0x0601C53E RID: 116030 RVA: 0x00417C2E File Offset: 0x00415E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeaponItem> Parser
		{
			get
			{
				return WeaponItem._parser;
			}
		}

		// Token: 0x17005F80 RID: 24448
		// (get) Token: 0x0601C53F RID: 116031 RVA: 0x00417C35 File Offset: 0x00415E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F81 RID: 24449
		// (get) Token: 0x0601C540 RID: 116032 RVA: 0x00417C38 File Offset: 0x00415E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItem.Descriptor;
			}
		}

		// Token: 0x0601C541 RID: 116033 RVA: 0x00417C3F File Offset: 0x00415E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItem()
		{
		}

		// Token: 0x0601C542 RID: 116034 RVA: 0x00417C48 File Offset: 0x00415E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItem(WeaponItem other) : this()
		{
			this.id_ = other.id_;
			this.incrId_ = other.incrId_;
			this.funcValue_ = other.funcValue_;
			this.weaponLevel_ = other.weaponLevel_;
			this.weaponExp_ = other.weaponExp_;
			this.weaponBreach_ = other.weaponBreach_;
			this.weaponResonLevel_ = other.weaponResonLevel_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C543 RID: 116035 RVA: 0x00417CCC File Offset: 0x00415ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItem Clone()
		{
			return new WeaponItem(this);
		}

		// Token: 0x17005F82 RID: 24450
		// (get) Token: 0x0601C544 RID: 116036 RVA: 0x00417CD4 File Offset: 0x00415ED4
		// (set) Token: 0x0601C545 RID: 116037 RVA: 0x00417CDC File Offset: 0x00415EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005F83 RID: 24451
		// (get) Token: 0x0601C546 RID: 116038 RVA: 0x00417CE5 File Offset: 0x00415EE5
		// (set) Token: 0x0601C547 RID: 116039 RVA: 0x00417CED File Offset: 0x00415EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17005F84 RID: 24452
		// (get) Token: 0x0601C548 RID: 116040 RVA: 0x00417CF6 File Offset: 0x00415EF6
		// (set) Token: 0x0601C549 RID: 116041 RVA: 0x00417CFE File Offset: 0x00415EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncValue
		{
			get
			{
				return this.funcValue_;
			}
			set
			{
				this.funcValue_ = value;
			}
		}

		// Token: 0x17005F85 RID: 24453
		// (get) Token: 0x0601C54A RID: 116042 RVA: 0x00417D07 File Offset: 0x00415F07
		// (set) Token: 0x0601C54B RID: 116043 RVA: 0x00417D0F File Offset: 0x00415F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponLevel
		{
			get
			{
				return this.weaponLevel_;
			}
			set
			{
				this.weaponLevel_ = value;
			}
		}

		// Token: 0x17005F86 RID: 24454
		// (get) Token: 0x0601C54C RID: 116044 RVA: 0x00417D18 File Offset: 0x00415F18
		// (set) Token: 0x0601C54D RID: 116045 RVA: 0x00417D20 File Offset: 0x00415F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponExp
		{
			get
			{
				return this.weaponExp_;
			}
			set
			{
				this.weaponExp_ = value;
			}
		}

		// Token: 0x17005F87 RID: 24455
		// (get) Token: 0x0601C54E RID: 116046 RVA: 0x00417D29 File Offset: 0x00415F29
		// (set) Token: 0x0601C54F RID: 116047 RVA: 0x00417D31 File Offset: 0x00415F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponBreach
		{
			get
			{
				return this.weaponBreach_;
			}
			set
			{
				this.weaponBreach_ = value;
			}
		}

		// Token: 0x17005F88 RID: 24456
		// (get) Token: 0x0601C550 RID: 116048 RVA: 0x00417D3A File Offset: 0x00415F3A
		// (set) Token: 0x0601C551 RID: 116049 RVA: 0x00417D42 File Offset: 0x00415F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponResonLevel
		{
			get
			{
				return this.weaponResonLevel_;
			}
			set
			{
				this.weaponResonLevel_ = value;
			}
		}

		// Token: 0x17005F89 RID: 24457
		// (get) Token: 0x0601C552 RID: 116050 RVA: 0x00417D4B File Offset: 0x00415F4B
		// (set) Token: 0x0601C553 RID: 116051 RVA: 0x00417D53 File Offset: 0x00415F53
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

		// Token: 0x0601C554 RID: 116052 RVA: 0x00417D5C File Offset: 0x00415F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItem);
		}

		// Token: 0x0601C555 RID: 116053 RVA: 0x00417D6C File Offset: 0x00415F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && this.WeaponLevel == other.WeaponLevel && this.WeaponExp == other.WeaponExp && this.WeaponBreach == other.WeaponBreach && this.WeaponResonLevel == other.WeaponResonLevel && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C556 RID: 116054 RVA: 0x00417E18 File Offset: 0x00416018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.FuncValue != 0)
			{
				num ^= this.FuncValue.GetHashCode();
			}
			if (this.WeaponLevel != 0)
			{
				num ^= this.WeaponLevel.GetHashCode();
			}
			if (this.WeaponExp != 0)
			{
				num ^= this.WeaponExp.GetHashCode();
			}
			if (this.WeaponBreach != 0)
			{
				num ^= this.WeaponBreach.GetHashCode();
			}
			if (this.WeaponResonLevel != 0)
			{
				num ^= this.WeaponResonLevel.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C557 RID: 116055 RVA: 0x00417F06 File Offset: 0x00416106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C558 RID: 116056 RVA: 0x00417F13 File Offset: 0x00416113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C559 RID: 116057 RVA: 0x00417F1C File Offset: 0x0041611C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FuncValue);
			}
			if (this.WeaponLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WeaponLevel);
			}
			if (this.WeaponExp != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WeaponExp);
			}
			if (this.WeaponBreach != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponBreach);
			}
			if (this.WeaponResonLevel != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.WeaponResonLevel);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C55A RID: 116058 RVA: 0x0041801C File Offset: 0x0041621C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncValue);
			}
			if (this.WeaponLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponLevel);
			}
			if (this.WeaponExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponExp);
			}
			if (this.WeaponBreach != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponBreach);
			}
			if (this.WeaponResonLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponResonLevel);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C55B RID: 116059 RVA: 0x00418104 File Offset: 0x00416304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.FuncValue != 0)
			{
				this.FuncValue = other.FuncValue;
			}
			if (other.WeaponLevel != 0)
			{
				this.WeaponLevel = other.WeaponLevel;
			}
			if (other.WeaponExp != 0)
			{
				this.WeaponExp = other.WeaponExp;
			}
			if (other.WeaponBreach != 0)
			{
				this.WeaponBreach = other.WeaponBreach;
			}
			if (other.WeaponResonLevel != 0)
			{
				this.WeaponResonLevel = other.WeaponResonLevel;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C55C RID: 116060 RVA: 0x004181CC File Offset: 0x004163CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C55D RID: 116061 RVA: 0x004181D8 File Offset: 0x004163D8
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IncrId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.FuncValue = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.WeaponLevel = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.WeaponExp = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.WeaponBreach = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.WeaponResonLevel = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A24A RID: 41546
		private static readonly MessageParser<WeaponItem> _parser = new MessageParser<WeaponItem>(() => new WeaponItem());

		// Token: 0x0400A24B RID: 41547
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A24C RID: 41548
		public const int IdFieldNumber = 1;

		// Token: 0x0400A24D RID: 41549
		private int id_;

		// Token: 0x0400A24E RID: 41550
		public const int IncrIdFieldNumber = 2;

		// Token: 0x0400A24F RID: 41551
		private int incrId_;

		// Token: 0x0400A250 RID: 41552
		public const int FuncValueFieldNumber = 3;

		// Token: 0x0400A251 RID: 41553
		private int funcValue_;

		// Token: 0x0400A252 RID: 41554
		public const int WeaponLevelFieldNumber = 4;

		// Token: 0x0400A253 RID: 41555
		private int weaponLevel_;

		// Token: 0x0400A254 RID: 41556
		public const int WeaponExpFieldNumber = 5;

		// Token: 0x0400A255 RID: 41557
		private int weaponExp_;

		// Token: 0x0400A256 RID: 41558
		public const int WeaponBreachFieldNumber = 6;

		// Token: 0x0400A257 RID: 41559
		private int weaponBreach_;

		// Token: 0x0400A258 RID: 41560
		public const int WeaponResonLevelFieldNumber = 7;

		// Token: 0x0400A259 RID: 41561
		private int weaponResonLevel_;

		// Token: 0x0400A25A RID: 41562
		public const int RoleIdFieldNumber = 8;

		// Token: 0x0400A25B RID: 41563
		private int roleId_;
	}
}
