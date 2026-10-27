using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B94 RID: 2964
	public sealed class OneWeaponItemInfo : IMessage<OneWeaponItemInfo>, IMessage, IEquatable<OneWeaponItemInfo>, IDeepCloneable<OneWeaponItemInfo>, IBufferMessage
	{
		// Token: 0x06010122 RID: 65826 RVA: 0x002587D1 File Offset: 0x002569D1
		[NullableContext(1)]
		public static OneWeaponItemInfo Create()
		{
			return new OneWeaponItemInfo();
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x06010123 RID: 65827 RVA: 0x002587D8 File Offset: 0x002569D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneWeaponItemInfo> Parser
		{
			get
			{
				return OneWeaponItemInfo._parser;
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x06010124 RID: 65828 RVA: 0x002587DF File Offset: 0x002569DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x06010125 RID: 65829 RVA: 0x002587E2 File Offset: 0x002569E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneWeaponItemInfo.Descriptor;
			}
		}

		// Token: 0x06010126 RID: 65830 RVA: 0x002587E9 File Offset: 0x002569E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneWeaponItemInfo()
		{
		}

		// Token: 0x06010127 RID: 65831 RVA: 0x002587F4 File Offset: 0x002569F4
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

		// Token: 0x06010128 RID: 65832 RVA: 0x00258860 File Offset: 0x00256A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneWeaponItemInfo Clone()
		{
			return new OneWeaponItemInfo(this);
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x06010129 RID: 65833 RVA: 0x00258868 File Offset: 0x00256A68
		// (set) Token: 0x0601012A RID: 65834 RVA: 0x00258870 File Offset: 0x00256A70
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

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0601012B RID: 65835 RVA: 0x00258879 File Offset: 0x00256A79
		// (set) Token: 0x0601012C RID: 65836 RVA: 0x00258881 File Offset: 0x00256A81
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

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0601012D RID: 65837 RVA: 0x0025888A File Offset: 0x00256A8A
		// (set) Token: 0x0601012E RID: 65838 RVA: 0x00258892 File Offset: 0x00256A92
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

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0601012F RID: 65839 RVA: 0x0025889B File Offset: 0x00256A9B
		// (set) Token: 0x06010130 RID: 65840 RVA: 0x002588A3 File Offset: 0x00256AA3
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

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x06010131 RID: 65841 RVA: 0x002588AC File Offset: 0x00256AAC
		// (set) Token: 0x06010132 RID: 65842 RVA: 0x002588B4 File Offset: 0x00256AB4
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

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x06010133 RID: 65843 RVA: 0x002588BD File Offset: 0x00256ABD
		// (set) Token: 0x06010134 RID: 65844 RVA: 0x002588C5 File Offset: 0x00256AC5
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

		// Token: 0x06010135 RID: 65845 RVA: 0x002588CE File Offset: 0x00256ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneWeaponItemInfo);
		}

		// Token: 0x06010136 RID: 65846 RVA: 0x002588DC File Offset: 0x00256ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneWeaponItemInfo other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.WeaponLevel == other.WeaponLevel && this.WeaponExp == other.WeaponExp && this.WeaponBreach == other.WeaponBreach && this.WeaponResonLevel == other.WeaponResonLevel && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010137 RID: 65847 RVA: 0x00258968 File Offset: 0x00256B68
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

		// Token: 0x06010138 RID: 65848 RVA: 0x00258A24 File Offset: 0x00256C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010139 RID: 65849 RVA: 0x00258A31 File Offset: 0x00256C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601013A RID: 65850 RVA: 0x00258A3C File Offset: 0x00256C3C
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

		// Token: 0x0601013B RID: 65851 RVA: 0x00258B04 File Offset: 0x00256D04
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

		// Token: 0x0601013C RID: 65852 RVA: 0x00258BBC File Offset: 0x00256DBC
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

		// Token: 0x0601013D RID: 65853 RVA: 0x00258C5C File Offset: 0x00256E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601013E RID: 65854 RVA: 0x00258C68 File Offset: 0x00256E68
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

		// Token: 0x04006674 RID: 26228
		private static readonly MessageParser<OneWeaponItemInfo> _parser = new MessageParser<OneWeaponItemInfo>(() => new OneWeaponItemInfo());

		// Token: 0x04006675 RID: 26229
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006676 RID: 26230
		public const int IncIdFieldNumber = 1;

		// Token: 0x04006677 RID: 26231
		private int incId_;

		// Token: 0x04006678 RID: 26232
		public const int WeaponLevelFieldNumber = 2;

		// Token: 0x04006679 RID: 26233
		private int weaponLevel_;

		// Token: 0x0400667A RID: 26234
		public const int WeaponExpFieldNumber = 3;

		// Token: 0x0400667B RID: 26235
		private int weaponExp_;

		// Token: 0x0400667C RID: 26236
		public const int WeaponBreachFieldNumber = 4;

		// Token: 0x0400667D RID: 26237
		private int weaponBreach_;

		// Token: 0x0400667E RID: 26238
		public const int WeaponResonLevelFieldNumber = 5;

		// Token: 0x0400667F RID: 26239
		private int weaponResonLevel_;

		// Token: 0x04006680 RID: 26240
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04006681 RID: 26241
		private int roleId_;
	}
}
