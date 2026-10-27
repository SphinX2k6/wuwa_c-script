using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D46 RID: 3398
	public sealed class PinballFormationRolePb : IMessage<PinballFormationRolePb>, IMessage, IEquatable<PinballFormationRolePb>, IDeepCloneable<PinballFormationRolePb>, IBufferMessage
	{
		// Token: 0x06012550 RID: 75088 RVA: 0x002ACC7F File Offset: 0x002AAE7F
		[NullableContext(1)]
		public static PinballFormationRolePb Create()
		{
			return new PinballFormationRolePb();
		}

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x06012551 RID: 75089 RVA: 0x002ACC86 File Offset: 0x002AAE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballFormationRolePb> Parser
		{
			get
			{
				return PinballFormationRolePb._parser;
			}
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x06012552 RID: 75090 RVA: 0x002ACC8D File Offset: 0x002AAE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x06012553 RID: 75091 RVA: 0x002ACC90 File Offset: 0x002AAE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballFormationRolePb.Descriptor;
			}
		}

		// Token: 0x06012554 RID: 75092 RVA: 0x002ACC97 File Offset: 0x002AAE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFormationRolePb()
		{
		}

		// Token: 0x06012555 RID: 75093 RVA: 0x002ACCAC File Offset: 0x002AAEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFormationRolePb(PinballFormationRolePb other) : this()
		{
			this.roleId_ = other.roleId_;
			this.trial_ = other.trial_;
			this.levelId_ = other.levelId_;
			this.hasWeapon_ = other.hasWeapon_;
			this.weaponId_ = other.weaponId_;
			this.randomAffixIds_ = other.randomAffixIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012556 RID: 75094 RVA: 0x002ACD1D File Offset: 0x002AAF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFormationRolePb Clone()
		{
			return new PinballFormationRolePb(this);
		}

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x06012557 RID: 75095 RVA: 0x002ACD25 File Offset: 0x002AAF25
		// (set) Token: 0x06012558 RID: 75096 RVA: 0x002ACD2D File Offset: 0x002AAF2D
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

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x06012559 RID: 75097 RVA: 0x002ACD36 File Offset: 0x002AAF36
		// (set) Token: 0x0601255A RID: 75098 RVA: 0x002ACD3E File Offset: 0x002AAF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Trial
		{
			get
			{
				return this.trial_;
			}
			set
			{
				this.trial_ = value;
			}
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0601255B RID: 75099 RVA: 0x002ACD47 File Offset: 0x002AAF47
		// (set) Token: 0x0601255C RID: 75100 RVA: 0x002ACD4F File Offset: 0x002AAF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x0601255D RID: 75101 RVA: 0x002ACD58 File Offset: 0x002AAF58
		// (set) Token: 0x0601255E RID: 75102 RVA: 0x002ACD60 File Offset: 0x002AAF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasWeapon
		{
			get
			{
				return this.hasWeapon_;
			}
			set
			{
				this.hasWeapon_ = value;
			}
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0601255F RID: 75103 RVA: 0x002ACD69 File Offset: 0x002AAF69
		// (set) Token: 0x06012560 RID: 75104 RVA: 0x002ACD71 File Offset: 0x002AAF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x06012561 RID: 75105 RVA: 0x002ACD7A File Offset: 0x002AAF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RandomAffixIds
		{
			get
			{
				return this.randomAffixIds_;
			}
		}

		// Token: 0x06012562 RID: 75106 RVA: 0x002ACD82 File Offset: 0x002AAF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballFormationRolePb);
		}

		// Token: 0x06012563 RID: 75107 RVA: 0x002ACD90 File Offset: 0x002AAF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballFormationRolePb other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Trial == other.Trial && this.LevelId == other.LevelId && this.HasWeapon == other.HasWeapon && this.WeaponId == other.WeaponId && this.randomAffixIds_.Equals(other.randomAffixIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012564 RID: 75108 RVA: 0x002ACE20 File Offset: 0x002AB020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Trial)
			{
				num ^= this.Trial.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.HasWeapon)
			{
				num ^= this.HasWeapon.GetHashCode();
			}
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			num ^= this.randomAffixIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012565 RID: 75109 RVA: 0x002ACED1 File Offset: 0x002AB0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012566 RID: 75110 RVA: 0x002ACEDE File Offset: 0x002AB0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012567 RID: 75111 RVA: 0x002ACEE8 File Offset: 0x002AB0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Trial)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Trial);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LevelId);
			}
			if (this.HasWeapon)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.HasWeapon);
			}
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponId);
			}
			this.randomAffixIds_.WriteTo(ref output, PinballFormationRolePb._repeated_randomAffixIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012568 RID: 75112 RVA: 0x002ACFA8 File Offset: 0x002AB1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Trial)
			{
				num += 2;
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.HasWeapon)
			{
				num += 2;
			}
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			num += this.randomAffixIds_.CalculateSize(PinballFormationRolePb._repeated_randomAffixIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012569 RID: 75113 RVA: 0x002AD044 File Offset: 0x002AB244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballFormationRolePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Trial)
			{
				this.Trial = other.Trial;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.HasWeapon)
			{
				this.HasWeapon = other.HasWeapon;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			this.randomAffixIds_.Add(other.randomAffixIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601256A RID: 75114 RVA: 0x002AD0E1 File Offset: 0x002AB2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601256B RID: 75115 RVA: 0x002AD0EC File Offset: 0x002AB2EC
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
						this.Trial = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 48U)
				{
					if (num == 32U)
					{
						this.HasWeapon = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.WeaponId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 56U || num == 58U)
				{
					this.randomAffixIds_.AddEntriesFrom(ref input, PinballFormationRolePb._repeated_randomAffixIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007239 RID: 29241
		private static readonly MessageParser<PinballFormationRolePb> _parser = new MessageParser<PinballFormationRolePb>(() => new PinballFormationRolePb());

		// Token: 0x0400723A RID: 29242
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400723B RID: 29243
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400723C RID: 29244
		private int roleId_;

		// Token: 0x0400723D RID: 29245
		public const int TrialFieldNumber = 2;

		// Token: 0x0400723E RID: 29246
		private bool trial_;

		// Token: 0x0400723F RID: 29247
		public const int LevelIdFieldNumber = 3;

		// Token: 0x04007240 RID: 29248
		private int levelId_;

		// Token: 0x04007241 RID: 29249
		public const int HasWeaponFieldNumber = 4;

		// Token: 0x04007242 RID: 29250
		private bool hasWeapon_;

		// Token: 0x04007243 RID: 29251
		public const int WeaponIdFieldNumber = 6;

		// Token: 0x04007244 RID: 29252
		private int weaponId_;

		// Token: 0x04007245 RID: 29253
		public const int RandomAffixIdsFieldNumber = 7;

		// Token: 0x04007246 RID: 29254
		private static readonly FieldCodec<int> _repeated_randomAffixIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007247 RID: 29255
		private readonly RepeatedField<int> randomAffixIds_ = new RepeatedField<int>();
	}
}
