using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000355 RID: 853
	public sealed class DangoBrawlFightActionSkillCastInfo : IMessage<DangoBrawlFightActionSkillCastInfo>, IMessage, IEquatable<DangoBrawlFightActionSkillCastInfo>, IDeepCloneable<DangoBrawlFightActionSkillCastInfo>, IBufferMessage
	{
		// Token: 0x0600553F RID: 21823 RVA: 0x000D048A File Offset: 0x000CE68A
		[NullableContext(1)]
		public static DangoBrawlFightActionSkillCastInfo Create()
		{
			return new DangoBrawlFightActionSkillCastInfo();
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06005540 RID: 21824 RVA: 0x000D0491 File Offset: 0x000CE691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06005541 RID: 21825 RVA: 0x000D0494 File Offset: 0x000CE694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionSkillCastInfo.Descriptor;
			}
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x000D049B File Offset: 0x000CE69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionSkillCastInfo()
		{
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x000D04A4 File Offset: 0x000CE6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionSkillCastInfo(DangoBrawlFightActionSkillCastInfo other) : this()
		{
			this.sourceFighterUId_ = other.sourceFighterUId_;
			this.skillConfigId_ = other.skillConfigId_;
			this.weaponItemId_ = other.weaponItemId_;
			this.targetFighterUId_ = other.targetFighterUId_;
			this.damageInfo_ = ((other.damageInfo_ != null) ? other.damageInfo_.Clone() : null);
			this.weaponItemUId_ = other.weaponItemUId_;
			this.nextReadyMs_ = other.nextReadyMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x000D052C File Offset: 0x000CE72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionSkillCastInfo Clone()
		{
			return new DangoBrawlFightActionSkillCastInfo(this);
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06005545 RID: 21829 RVA: 0x000D0534 File Offset: 0x000CE734
		// (set) Token: 0x06005546 RID: 21830 RVA: 0x000D053C File Offset: 0x000CE73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceFighterUId
		{
			get
			{
				return this.sourceFighterUId_;
			}
			set
			{
				this.sourceFighterUId_ = value;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x000D0545 File Offset: 0x000CE745
		// (set) Token: 0x06005548 RID: 21832 RVA: 0x000D054D File Offset: 0x000CE74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillConfigId
		{
			get
			{
				return this.skillConfigId_;
			}
			set
			{
				this.skillConfigId_ = value;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x000D0556 File Offset: 0x000CE756
		// (set) Token: 0x0600554A RID: 21834 RVA: 0x000D055E File Offset: 0x000CE75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponItemId
		{
			get
			{
				return this.weaponItemId_;
			}
			set
			{
				this.weaponItemId_ = value;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x0600554B RID: 21835 RVA: 0x000D0567 File Offset: 0x000CE767
		// (set) Token: 0x0600554C RID: 21836 RVA: 0x000D056F File Offset: 0x000CE76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x000D0578 File Offset: 0x000CE778
		// (set) Token: 0x0600554E RID: 21838 RVA: 0x000D0580 File Offset: 0x000CE780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo DamageInfo
		{
			get
			{
				return this.damageInfo_;
			}
			set
			{
				this.damageInfo_ = value;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x0600554F RID: 21839 RVA: 0x000D0589 File Offset: 0x000CE789
		// (set) Token: 0x06005550 RID: 21840 RVA: 0x000D0591 File Offset: 0x000CE791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponItemUId
		{
			get
			{
				return this.weaponItemUId_;
			}
			set
			{
				this.weaponItemUId_ = value;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x000D059A File Offset: 0x000CE79A
		// (set) Token: 0x06005552 RID: 21842 RVA: 0x000D05A2 File Offset: 0x000CE7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextReadyMs
		{
			get
			{
				return this.nextReadyMs_;
			}
			set
			{
				this.nextReadyMs_ = value;
			}
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x000D05AB File Offset: 0x000CE7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionSkillCastInfo);
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x000D05BC File Offset: 0x000CE7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionSkillCastInfo other)
		{
			return other != null && (other == this || (this.SourceFighterUId == other.SourceFighterUId && this.SkillConfigId == other.SkillConfigId && this.WeaponItemId == other.WeaponItemId && this.TargetFighterUId == other.TargetFighterUId && object.Equals(this.DamageInfo, other.DamageInfo) && this.WeaponItemUId == other.WeaponItemUId && this.NextReadyMs == other.NextReadyMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x000D065C File Offset: 0x000CE85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceFighterUId != 0)
			{
				num ^= this.SourceFighterUId.GetHashCode();
			}
			if (this.SkillConfigId != 0)
			{
				num ^= this.SkillConfigId.GetHashCode();
			}
			if (this.WeaponItemId != 0)
			{
				num ^= this.WeaponItemId.GetHashCode();
			}
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this.damageInfo_ != null)
			{
				num ^= this.DamageInfo.GetHashCode();
			}
			if (this.WeaponItemUId != 0)
			{
				num ^= this.WeaponItemUId.GetHashCode();
			}
			if (this.NextReadyMs != 0)
			{
				num ^= this.NextReadyMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x000D072E File Offset: 0x000CE92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x000D073B File Offset: 0x000CE93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x000D0744 File Offset: 0x000CE944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SourceFighterUId);
			}
			if (this.SkillConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillConfigId);
			}
			if (this.WeaponItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeaponItemId);
			}
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this.damageInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DamageInfo);
			}
			if (this.WeaponItemUId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponItemUId);
			}
			if (this.NextReadyMs != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NextReadyMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x000D0828 File Offset: 0x000CEA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceFighterUId);
			}
			if (this.SkillConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillConfigId);
			}
			if (this.WeaponItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponItemId);
			}
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this.damageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageInfo);
			}
			if (this.WeaponItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponItemUId);
			}
			if (this.NextReadyMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextReadyMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x000D08F8 File Offset: 0x000CEAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionSkillCastInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceFighterUId != 0)
			{
				this.SourceFighterUId = other.SourceFighterUId;
			}
			if (other.SkillConfigId != 0)
			{
				this.SkillConfigId = other.SkillConfigId;
			}
			if (other.WeaponItemId != 0)
			{
				this.WeaponItemId = other.WeaponItemId;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			if (other.damageInfo_ != null)
			{
				if (this.damageInfo_ == null)
				{
					this.DamageInfo = new DangoBrawlDamageInfo();
				}
				this.DamageInfo.MergeFrom(other.DamageInfo);
			}
			if (other.WeaponItemUId != 0)
			{
				this.WeaponItemUId = other.WeaponItemUId;
			}
			if (other.NextReadyMs != 0)
			{
				this.NextReadyMs = other.NextReadyMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x000D09C4 File Offset: 0x000CEBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x000D09D0 File Offset: 0x000CEBD0
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
						this.SourceFighterUId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SkillConfigId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.WeaponItemId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 32U)
					{
						this.TargetFighterUId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.damageInfo_ == null)
						{
							this.DamageInfo = new DangoBrawlDamageInfo();
						}
						input.ReadMessage(this.DamageInfo);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.WeaponItemUId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.NextReadyMs = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003413 RID: 13331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003414 RID: 13332
		public const int SourceFighterUIdFieldNumber = 1;

		// Token: 0x04003415 RID: 13333
		private int sourceFighterUId_;

		// Token: 0x04003416 RID: 13334
		public const int SkillConfigIdFieldNumber = 2;

		// Token: 0x04003417 RID: 13335
		private int skillConfigId_;

		// Token: 0x04003418 RID: 13336
		public const int WeaponItemIdFieldNumber = 3;

		// Token: 0x04003419 RID: 13337
		private int weaponItemId_;

		// Token: 0x0400341A RID: 13338
		public const int TargetFighterUIdFieldNumber = 4;

		// Token: 0x0400341B RID: 13339
		private int targetFighterUId_;

		// Token: 0x0400341C RID: 13340
		public const int DamageInfoFieldNumber = 5;

		// Token: 0x0400341D RID: 13341
		private DangoBrawlDamageInfo damageInfo_;

		// Token: 0x0400341E RID: 13342
		public const int WeaponItemUIdFieldNumber = 6;

		// Token: 0x0400341F RID: 13343
		private int weaponItemUId_;

		// Token: 0x04003420 RID: 13344
		public const int NextReadyMsFieldNumber = 7;

		// Token: 0x04003421 RID: 13345
		private int nextReadyMs_;
	}
}
