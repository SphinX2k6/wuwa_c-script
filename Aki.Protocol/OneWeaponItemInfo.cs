using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B84 RID: 2948
	public sealed class OneWeaponItemInfo : IMessage<OneWeaponItemInfo>, IMessage, IEquatable<OneWeaponItemInfo>, IDeepCloneable<OneWeaponItemInfo>, IBufferMessage
	{
		// Token: 0x0601001E RID: 65566 RVA: 0x00256901 File Offset: 0x00254B01
		[NullableContext(1)]
		public static OneWeaponItemInfo Create()
		{
			return new OneWeaponItemInfo();
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0601001F RID: 65567 RVA: 0x00256908 File Offset: 0x00254B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneWeaponItemInfo> Parser
		{
			get
			{
				return OneWeaponItemInfo._parser;
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x06010020 RID: 65568 RVA: 0x0025690F File Offset: 0x00254B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x06010021 RID: 65569 RVA: 0x00256912 File Offset: 0x00254B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneWeaponItemInfo.Descriptor;
			}
		}

		// Token: 0x06010022 RID: 65570 RVA: 0x00256919 File Offset: 0x00254B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneWeaponItemInfo()
		{
		}

		// Token: 0x06010023 RID: 65571 RVA: 0x00256924 File Offset: 0x00254B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneWeaponItemInfo(OneWeaponItemInfo other) : this()
		{
			this.incId_ = other.incId_;
			this.weaponLevel_ = other.weaponLevel_;
			this.weaponExp_ = other.weaponExp_;
			this.weaponBreach_ = other.weaponBreach_;
			this.weaponResonLevel_ = other.weaponResonLevel_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010024 RID: 65572 RVA: 0x00256990 File Offset: 0x00254B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneWeaponItemInfo Clone()
		{
			return new OneWeaponItemInfo(this);
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x06010025 RID: 65573 RVA: 0x00256998 File Offset: 0x00254B98
		// (set) Token: 0x06010026 RID: 65574 RVA: 0x002569A0 File Offset: 0x00254BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x06010027 RID: 65575 RVA: 0x002569A9 File Offset: 0x00254BA9
		// (set) Token: 0x06010028 RID: 65576 RVA: 0x002569B1 File Offset: 0x00254BB1
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

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x06010029 RID: 65577 RVA: 0x002569BA File Offset: 0x00254BBA
		// (set) Token: 0x0601002A RID: 65578 RVA: 0x002569C2 File Offset: 0x00254BC2
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

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0601002B RID: 65579 RVA: 0x002569CB File Offset: 0x00254BCB
		// (set) Token: 0x0601002C RID: 65580 RVA: 0x002569D3 File Offset: 0x00254BD3
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

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0601002D RID: 65581 RVA: 0x002569DC File Offset: 0x00254BDC
		// (set) Token: 0x0601002E RID: 65582 RVA: 0x002569E4 File Offset: 0x00254BE4
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

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0601002F RID: 65583 RVA: 0x002569ED File Offset: 0x00254BED
		// (set) Token: 0x06010030 RID: 65584 RVA: 0x002569F5 File Offset: 0x00254BF5
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

		// Token: 0x06010031 RID: 65585 RVA: 0x002569FE File Offset: 0x00254BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneWeaponItemInfo);
		}

		// Token: 0x06010032 RID: 65586 RVA: 0x00256A0C File Offset: 0x00254C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneWeaponItemInfo other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.WeaponLevel == other.WeaponLevel && this.WeaponExp == other.WeaponExp && this.WeaponBreach == other.WeaponBreach && this.WeaponResonLevel == other.WeaponResonLevel && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010033 RID: 65587 RVA: 0x00256A98 File Offset: 0x00254C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
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

		// Token: 0x06010034 RID: 65588 RVA: 0x00256B54 File Offset: 0x00254D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010035 RID: 65589 RVA: 0x00256B61 File Offset: 0x00254D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010036 RID: 65590 RVA: 0x00256B6C File Offset: 0x00254D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.WeaponLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WeaponLevel);
			}
			if (this.WeaponExp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeaponExp);
			}
			if (this.WeaponBreach != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WeaponBreach);
			}
			if (this.WeaponResonLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WeaponResonLevel);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010037 RID: 65591 RVA: 0x00256C34 File Offset: 0x00254E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
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

		// Token: 0x06010038 RID: 65592 RVA: 0x00256CEC File Offset: 0x00254EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneWeaponItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
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

		// Token: 0x06010039 RID: 65593 RVA: 0x00256D8C File Offset: 0x00254F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601003A RID: 65594 RVA: 0x00256D98 File Offset: 0x00254F98
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
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.WeaponLevel = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.WeaponExp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.WeaponBreach = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.WeaponResonLevel = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006684 RID: 26244
		private static readonly MessageParser<OneWeaponItemInfo> _parser = new MessageParser<OneWeaponItemInfo>(() => new OneWeaponItemInfo());

		// Token: 0x04006685 RID: 26245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006686 RID: 26246
		public const int IncIdFieldNumber = 1;

		// Token: 0x04006687 RID: 26247
		private int incId_;

		// Token: 0x04006688 RID: 26248
		public const int WeaponLevelFieldNumber = 2;

		// Token: 0x04006689 RID: 26249
		private int weaponLevel_;

		// Token: 0x0400668A RID: 26250
		public const int WeaponExpFieldNumber = 3;

		// Token: 0x0400668B RID: 26251
		private int weaponExp_;

		// Token: 0x0400668C RID: 26252
		public const int WeaponBreachFieldNumber = 4;

		// Token: 0x0400668D RID: 26253
		private int weaponBreach_;

		// Token: 0x0400668E RID: 26254
		public const int WeaponResonLevelFieldNumber = 5;

		// Token: 0x0400668F RID: 26255
		private int weaponResonLevel_;

		// Token: 0x04006690 RID: 26256
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04006691 RID: 26257
		private int roleId_;
	}
}
