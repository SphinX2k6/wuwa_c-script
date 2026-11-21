using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001564 RID: 5476
	public sealed class WeaponItem : IMessage<WeaponItem>, IMessage, IEquatable<WeaponItem>, IDeepCloneable<WeaponItem>, IBufferMessage
	{
		// Token: 0x0601D004 RID: 118788 RVA: 0x004336E3 File Offset: 0x004318E3
		[NullableContext(1)]
		public static WeaponItem Create()
		{
			return new WeaponItem();
		}

		// Token: 0x17006220 RID: 25120
		// (get) Token: 0x0601D005 RID: 118789 RVA: 0x004336EA File Offset: 0x004318EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeaponItem> Parser
		{
			get
			{
				return WeaponItem._parser;
			}
		}

		// Token: 0x17006221 RID: 25121
		// (get) Token: 0x0601D006 RID: 118790 RVA: 0x004336F1 File Offset: 0x004318F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006222 RID: 25122
		// (get) Token: 0x0601D007 RID: 118791 RVA: 0x004336F4 File Offset: 0x004318F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItem.Descriptor;
			}
		}

		// Token: 0x0601D008 RID: 118792 RVA: 0x004336FB File Offset: 0x004318FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItem()
		{
		}

		// Token: 0x0601D009 RID: 118793 RVA: 0x00433704 File Offset: 0x00431904
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

		// Token: 0x0601D00A RID: 118794 RVA: 0x00433788 File Offset: 0x00431988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItem Clone()
		{
			return new WeaponItem(this);
		}

		// Token: 0x17006223 RID: 25123
		// (get) Token: 0x0601D00B RID: 118795 RVA: 0x00433790 File Offset: 0x00431990
		// (set) Token: 0x0601D00C RID: 118796 RVA: 0x00433798 File Offset: 0x00431998
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

		// Token: 0x17006224 RID: 25124
		// (get) Token: 0x0601D00D RID: 118797 RVA: 0x004337A1 File Offset: 0x004319A1
		// (set) Token: 0x0601D00E RID: 118798 RVA: 0x004337A9 File Offset: 0x004319A9
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

		// Token: 0x17006225 RID: 25125
		// (get) Token: 0x0601D00F RID: 118799 RVA: 0x004337B2 File Offset: 0x004319B2
		// (set) Token: 0x0601D010 RID: 118800 RVA: 0x004337BA File Offset: 0x004319BA
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

		// Token: 0x17006226 RID: 25126
		// (get) Token: 0x0601D011 RID: 118801 RVA: 0x004337C3 File Offset: 0x004319C3
		// (set) Token: 0x0601D012 RID: 118802 RVA: 0x004337CB File Offset: 0x004319CB
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

		// Token: 0x17006227 RID: 25127
		// (get) Token: 0x0601D013 RID: 118803 RVA: 0x004337D4 File Offset: 0x004319D4
		// (set) Token: 0x0601D014 RID: 118804 RVA: 0x004337DC File Offset: 0x004319DC
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

		// Token: 0x17006228 RID: 25128
		// (get) Token: 0x0601D015 RID: 118805 RVA: 0x004337E5 File Offset: 0x004319E5
		// (set) Token: 0x0601D016 RID: 118806 RVA: 0x004337ED File Offset: 0x004319ED
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

		// Token: 0x17006229 RID: 25129
		// (get) Token: 0x0601D017 RID: 118807 RVA: 0x004337F6 File Offset: 0x004319F6
		// (set) Token: 0x0601D018 RID: 118808 RVA: 0x004337FE File Offset: 0x004319FE
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

		// Token: 0x1700622A RID: 25130
		// (get) Token: 0x0601D019 RID: 118809 RVA: 0x00433807 File Offset: 0x00431A07
		// (set) Token: 0x0601D01A RID: 118810 RVA: 0x0043380F File Offset: 0x00431A0F
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

		// Token: 0x0601D01B RID: 118811 RVA: 0x00433818 File Offset: 0x00431A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItem);
		}

		// Token: 0x0601D01C RID: 118812 RVA: 0x00433828 File Offset: 0x00431A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && this.WeaponLevel == other.WeaponLevel && this.WeaponExp == other.WeaponExp && this.WeaponBreach == other.WeaponBreach && this.WeaponResonLevel == other.WeaponResonLevel && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D01D RID: 118813 RVA: 0x004338D4 File Offset: 0x00431AD4
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

		// Token: 0x0601D01E RID: 118814 RVA: 0x004339C2 File Offset: 0x00431BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D01F RID: 118815 RVA: 0x004339CF File Offset: 0x00431BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D020 RID: 118816 RVA: 0x004339D8 File Offset: 0x00431BD8
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

		// Token: 0x0601D021 RID: 118817 RVA: 0x00433AD8 File Offset: 0x00431CD8
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

		// Token: 0x0601D022 RID: 118818 RVA: 0x00433BC0 File Offset: 0x00431DC0
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

		// Token: 0x0601D023 RID: 118819 RVA: 0x00433C88 File Offset: 0x00431E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D024 RID: 118820 RVA: 0x00433C94 File Offset: 0x00431E94
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

		// Token: 0x0400A6A3 RID: 42659
		private static readonly MessageParser<WeaponItem> _parser = new MessageParser<WeaponItem>(() => new WeaponItem());

		// Token: 0x0400A6A4 RID: 42660
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6A5 RID: 42661
		public const int IdFieldNumber = 1;

		// Token: 0x0400A6A6 RID: 42662
		private int id_;

		// Token: 0x0400A6A7 RID: 42663
		public const int IncrIdFieldNumber = 2;

		// Token: 0x0400A6A8 RID: 42664
		private int incrId_;

		// Token: 0x0400A6A9 RID: 42665
		public const int FuncValueFieldNumber = 3;

		// Token: 0x0400A6AA RID: 42666
		private int funcValue_;

		// Token: 0x0400A6AB RID: 42667
		public const int WeaponLevelFieldNumber = 4;

		// Token: 0x0400A6AC RID: 42668
		private int weaponLevel_;

		// Token: 0x0400A6AD RID: 42669
		public const int WeaponExpFieldNumber = 5;

		// Token: 0x0400A6AE RID: 42670
		private int weaponExp_;

		// Token: 0x0400A6AF RID: 42671
		public const int WeaponBreachFieldNumber = 6;

		// Token: 0x0400A6B0 RID: 42672
		private int weaponBreach_;

		// Token: 0x0400A6B1 RID: 42673
		public const int WeaponResonLevelFieldNumber = 7;

		// Token: 0x0400A6B2 RID: 42674
		private int weaponResonLevel_;

		// Token: 0x0400A6B3 RID: 42675
		public const int RoleIdFieldNumber = 8;

		// Token: 0x0400A6B4 RID: 42676
		private int roleId_;
	}
}
