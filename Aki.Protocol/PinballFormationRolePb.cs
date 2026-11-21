using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D36 RID: 3382
	public sealed class PinballFormationRolePb : IMessage<PinballFormationRolePb>, IMessage, IEquatable<PinballFormationRolePb>, IDeepCloneable<PinballFormationRolePb>, IBufferMessage
	{
		// Token: 0x06012454 RID: 74836 RVA: 0x002AB064 File Offset: 0x002A9264
		[NullableContext(1)]
		public static PinballFormationRolePb Create()
		{
			return new PinballFormationRolePb();
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x06012455 RID: 74837 RVA: 0x002AB06B File Offset: 0x002A926B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballFormationRolePb> Parser
		{
			get
			{
				return PinballFormationRolePb._parser;
			}
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x06012456 RID: 74838 RVA: 0x002AB072 File Offset: 0x002A9272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C89 RID: 15497
		// (get) Token: 0x06012457 RID: 74839 RVA: 0x002AB075 File Offset: 0x002A9275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballFormationRolePb.Descriptor;
			}
		}

		// Token: 0x06012458 RID: 74840 RVA: 0x002AB07C File Offset: 0x002A927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFormationRolePb()
		{
		}

		// Token: 0x06012459 RID: 74841 RVA: 0x002AB090 File Offset: 0x002A9290
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

		// Token: 0x0601245A RID: 74842 RVA: 0x002AB101 File Offset: 0x002A9301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFormationRolePb Clone()
		{
			return new PinballFormationRolePb(this);
		}

		// Token: 0x17003C8A RID: 15498
		// (get) Token: 0x0601245B RID: 74843 RVA: 0x002AB109 File Offset: 0x002A9309
		// (set) Token: 0x0601245C RID: 74844 RVA: 0x002AB111 File Offset: 0x002A9311
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

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0601245D RID: 74845 RVA: 0x002AB11A File Offset: 0x002A931A
		// (set) Token: 0x0601245E RID: 74846 RVA: 0x002AB122 File Offset: 0x002A9322
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

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0601245F RID: 74847 RVA: 0x002AB12B File Offset: 0x002A932B
		// (set) Token: 0x06012460 RID: 74848 RVA: 0x002AB133 File Offset: 0x002A9333
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

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x06012461 RID: 74849 RVA: 0x002AB13C File Offset: 0x002A933C
		// (set) Token: 0x06012462 RID: 74850 RVA: 0x002AB144 File Offset: 0x002A9344
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

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x06012463 RID: 74851 RVA: 0x002AB14D File Offset: 0x002A934D
		// (set) Token: 0x06012464 RID: 74852 RVA: 0x002AB155 File Offset: 0x002A9355
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

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x06012465 RID: 74853 RVA: 0x002AB15E File Offset: 0x002A935E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RandomAffixIds
		{
			get
			{
				return this.randomAffixIds_;
			}
		}

		// Token: 0x06012466 RID: 74854 RVA: 0x002AB166 File Offset: 0x002A9366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballFormationRolePb);
		}

		// Token: 0x06012467 RID: 74855 RVA: 0x002AB174 File Offset: 0x002A9374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballFormationRolePb other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Trial == other.Trial && this.LevelId == other.LevelId && this.HasWeapon == other.HasWeapon && this.WeaponId == other.WeaponId && this.randomAffixIds_.Equals(other.randomAffixIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012468 RID: 74856 RVA: 0x002AB204 File Offset: 0x002A9404
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

		// Token: 0x06012469 RID: 74857 RVA: 0x002AB2B5 File Offset: 0x002A94B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601246A RID: 74858 RVA: 0x002AB2C2 File Offset: 0x002A94C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601246B RID: 74859 RVA: 0x002AB2CC File Offset: 0x002A94CC
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

		// Token: 0x0601246C RID: 74860 RVA: 0x002AB38C File Offset: 0x002A958C
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

		// Token: 0x0601246D RID: 74861 RVA: 0x002AB428 File Offset: 0x002A9628
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

		// Token: 0x0601246E RID: 74862 RVA: 0x002AB4C5 File Offset: 0x002A96C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601246F RID: 74863 RVA: 0x002AB4D0 File Offset: 0x002A96D0
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

		// Token: 0x04007251 RID: 29265
		private static readonly MessageParser<PinballFormationRolePb> _parser = new MessageParser<PinballFormationRolePb>(() => new PinballFormationRolePb());

		// Token: 0x04007252 RID: 29266
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007253 RID: 29267
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04007254 RID: 29268
		private int roleId_;

		// Token: 0x04007255 RID: 29269
		public const int TrialFieldNumber = 2;

		// Token: 0x04007256 RID: 29270
		private bool trial_;

		// Token: 0x04007257 RID: 29271
		public const int LevelIdFieldNumber = 3;

		// Token: 0x04007258 RID: 29272
		private int levelId_;

		// Token: 0x04007259 RID: 29273
		public const int HasWeaponFieldNumber = 4;

		// Token: 0x0400725A RID: 29274
		private bool hasWeapon_;

		// Token: 0x0400725B RID: 29275
		public const int WeaponIdFieldNumber = 6;

		// Token: 0x0400725C RID: 29276
		private int weaponId_;

		// Token: 0x0400725D RID: 29277
		public const int RandomAffixIdsFieldNumber = 7;

		// Token: 0x0400725E RID: 29278
		private static readonly FieldCodec<int> _repeated_randomAffixIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400725F RID: 29279
		private readonly RepeatedField<int> randomAffixIds_ = new RepeatedField<int>();
	}
}
