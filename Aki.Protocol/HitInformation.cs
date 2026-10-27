using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000753 RID: 1875
	public sealed class HitInformation : IMessage<HitInformation>, IMessage, IEquatable<HitInformation>, IDeepCloneable<HitInformation>, IBufferMessage
	{
		// Token: 0x0600A9A8 RID: 43432 RVA: 0x00197B71 File Offset: 0x00195D71
		[NullableContext(1)]
		public static HitInformation Create()
		{
			return new HitInformation();
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x0600A9A9 RID: 43433 RVA: 0x00197B78 File Offset: 0x00195D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x0600A9AA RID: 43434 RVA: 0x00197B7B File Offset: 0x00195D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitInformation.Descriptor;
			}
		}

		// Token: 0x0600A9AB RID: 43435 RVA: 0x00197B82 File Offset: 0x00195D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitInformation()
		{
		}

		// Token: 0x0600A9AC RID: 43436 RVA: 0x00197B98 File Offset: 0x00195D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitInformation(HitInformation other) : this()
		{
			this.originator_ = other.originator_;
			this.id_ = other.id_;
			this.targetId_ = other.targetId_;
			this.bulletId_ = other.bulletId_;
			this.hasBeHitData_ = other.hasBeHitData_;
			this.hitEffectPos_ = ((other.hitEffectPos_ != null) ? other.hitEffectPos_.Clone() : null);
			this.hitEffectRotate_ = ((other.hitEffectRotate_ != null) ? other.hitEffectRotate_.Clone() : null);
			this.isShake_ = other.isShake_;
			this.hitPos_ = ((other.hitPos_ != null) ? other.hitPos_.Clone() : null);
			this.enterFk_ = other.enterFk_;
			this.isHitWeakness_ = other.isHitWeakness_;
			this.isTriggerCounterattack_ = other.isTriggerCounterattack_;
			this.victimRotation_ = ((other.victimRotation_ != null) ? other.victimRotation_.Clone() : null);
			this.isChangeVictimRotation_ = other.isChangeVictimRotation_;
			this.hitPart_ = other.hitPart_;
			this.isTriggerVisionCounterAttack_ = other.isTriggerVisionCounterAttack_;
			this.skillId_ = other.skillId_;
			this.fightState_ = other.fightState_;
			this.beHitAnim_ = other.beHitAnim_;
			this.source_ = other.source_;
			this.phantomSkillIdentify_ = other.phantomSkillIdentify_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9AD RID: 43437 RVA: 0x00197CF8 File Offset: 0x00195EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitInformation Clone()
		{
			return new HitInformation(this);
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x0600A9AE RID: 43438 RVA: 0x00197D00 File Offset: 0x00195F00
		// (set) Token: 0x0600A9AF RID: 43439 RVA: 0x00197D08 File Offset: 0x00195F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Originator
		{
			get
			{
				return this.originator_;
			}
			set
			{
				this.originator_ = value;
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x0600A9B0 RID: 43440 RVA: 0x00197D11 File Offset: 0x00195F11
		// (set) Token: 0x0600A9B1 RID: 43441 RVA: 0x00197D19 File Offset: 0x00195F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0600A9B2 RID: 43442 RVA: 0x00197D22 File Offset: 0x00195F22
		// (set) Token: 0x0600A9B3 RID: 43443 RVA: 0x00197D2A File Offset: 0x00195F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0600A9B4 RID: 43444 RVA: 0x00197D33 File Offset: 0x00195F33
		// (set) Token: 0x0600A9B5 RID: 43445 RVA: 0x00197D3B File Offset: 0x00195F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletId
		{
			get
			{
				return this.bulletId_;
			}
			set
			{
				this.bulletId_ = value;
			}
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0600A9B6 RID: 43446 RVA: 0x00197D44 File Offset: 0x00195F44
		// (set) Token: 0x0600A9B7 RID: 43447 RVA: 0x00197D4C File Offset: 0x00195F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBeHitData
		{
			get
			{
				return this.hasBeHitData_;
			}
			set
			{
				this.hasBeHitData_ = value;
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x0600A9B8 RID: 43448 RVA: 0x00197D55 File Offset: 0x00195F55
		// (set) Token: 0x0600A9B9 RID: 43449 RVA: 0x00197D5D File Offset: 0x00195F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector HitEffectPos
		{
			get
			{
				return this.hitEffectPos_;
			}
			set
			{
				this.hitEffectPos_ = value;
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x0600A9BA RID: 43450 RVA: 0x00197D66 File Offset: 0x00195F66
		// (set) Token: 0x0600A9BB RID: 43451 RVA: 0x00197D6E File Offset: 0x00195F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator HitEffectRotate
		{
			get
			{
				return this.hitEffectRotate_;
			}
			set
			{
				this.hitEffectRotate_ = value;
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x0600A9BC RID: 43452 RVA: 0x00197D77 File Offset: 0x00195F77
		// (set) Token: 0x0600A9BD RID: 43453 RVA: 0x00197D7F File Offset: 0x00195F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShake
		{
			get
			{
				return this.isShake_;
			}
			set
			{
				this.isShake_ = value;
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0600A9BE RID: 43454 RVA: 0x00197D88 File Offset: 0x00195F88
		// (set) Token: 0x0600A9BF RID: 43455 RVA: 0x00197D90 File Offset: 0x00195F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector HitPos
		{
			get
			{
				return this.hitPos_;
			}
			set
			{
				this.hitPos_ = value;
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x0600A9C0 RID: 43456 RVA: 0x00197D99 File Offset: 0x00195F99
		// (set) Token: 0x0600A9C1 RID: 43457 RVA: 0x00197DA1 File Offset: 0x00195FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnterFk
		{
			get
			{
				return this.enterFk_;
			}
			set
			{
				this.enterFk_ = value;
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0600A9C2 RID: 43458 RVA: 0x00197DAA File Offset: 0x00195FAA
		// (set) Token: 0x0600A9C3 RID: 43459 RVA: 0x00197DB2 File Offset: 0x00195FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsHitWeakness
		{
			get
			{
				return this.isHitWeakness_;
			}
			set
			{
				this.isHitWeakness_ = value;
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x0600A9C4 RID: 43460 RVA: 0x00197DBB File Offset: 0x00195FBB
		// (set) Token: 0x0600A9C5 RID: 43461 RVA: 0x00197DC3 File Offset: 0x00195FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTriggerCounterattack
		{
			get
			{
				return this.isTriggerCounterattack_;
			}
			set
			{
				this.isTriggerCounterattack_ = value;
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x0600A9C6 RID: 43462 RVA: 0x00197DCC File Offset: 0x00195FCC
		// (set) Token: 0x0600A9C7 RID: 43463 RVA: 0x00197DD4 File Offset: 0x00195FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator VictimRotation
		{
			get
			{
				return this.victimRotation_;
			}
			set
			{
				this.victimRotation_ = value;
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x0600A9C8 RID: 43464 RVA: 0x00197DDD File Offset: 0x00195FDD
		// (set) Token: 0x0600A9C9 RID: 43465 RVA: 0x00197DE5 File Offset: 0x00195FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsChangeVictimRotation
		{
			get
			{
				return this.isChangeVictimRotation_;
			}
			set
			{
				this.isChangeVictimRotation_ = value;
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x0600A9CA RID: 43466 RVA: 0x00197DEE File Offset: 0x00195FEE
		// (set) Token: 0x0600A9CB RID: 43467 RVA: 0x00197DF6 File Offset: 0x00195FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HitPart
		{
			get
			{
				return this.hitPart_;
			}
			set
			{
				this.hitPart_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x0600A9CC RID: 43468 RVA: 0x00197E09 File Offset: 0x00196009
		// (set) Token: 0x0600A9CD RID: 43469 RVA: 0x00197E11 File Offset: 0x00196011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTriggerVisionCounterAttack
		{
			get
			{
				return this.isTriggerVisionCounterAttack_;
			}
			set
			{
				this.isTriggerVisionCounterAttack_ = value;
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x0600A9CE RID: 43470 RVA: 0x00197E1A File Offset: 0x0019601A
		// (set) Token: 0x0600A9CF RID: 43471 RVA: 0x00197E22 File Offset: 0x00196022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x0600A9D0 RID: 43472 RVA: 0x00197E2B File Offset: 0x0019602B
		// (set) Token: 0x0600A9D1 RID: 43473 RVA: 0x00197E33 File Offset: 0x00196033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightState
		{
			get
			{
				return this.fightState_;
			}
			set
			{
				this.fightState_ = value;
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x0600A9D2 RID: 43474 RVA: 0x00197E3C File Offset: 0x0019603C
		// (set) Token: 0x0600A9D3 RID: 43475 RVA: 0x00197E44 File Offset: 0x00196044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BeHitAnim
		{
			get
			{
				return this.beHitAnim_;
			}
			set
			{
				this.beHitAnim_ = value;
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600A9D4 RID: 43476 RVA: 0x00197E4D File Offset: 0x0019604D
		// (set) Token: 0x0600A9D5 RID: 43477 RVA: 0x00197E55 File Offset: 0x00196055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EBulletCreateSource Source
		{
			get
			{
				return this.source_;
			}
			set
			{
				this.source_ = value;
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600A9D6 RID: 43478 RVA: 0x00197E5E File Offset: 0x0019605E
		// (set) Token: 0x0600A9D7 RID: 43479 RVA: 0x00197E66 File Offset: 0x00196066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomSkillIdentify
		{
			get
			{
				return this.phantomSkillIdentify_;
			}
			set
			{
				this.phantomSkillIdentify_ = value;
			}
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x00197E6F File Offset: 0x0019606F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitInformation);
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x00197E80 File Offset: 0x00196080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitInformation other)
		{
			return other != null && (other == this || (this.Originator == other.Originator && this.Id == other.Id && this.TargetId == other.TargetId && this.BulletId == other.BulletId && this.HasBeHitData == other.HasBeHitData && object.Equals(this.HitEffectPos, other.HitEffectPos) && object.Equals(this.HitEffectRotate, other.HitEffectRotate) && this.IsShake == other.IsShake && object.Equals(this.HitPos, other.HitPos) && this.EnterFk == other.EnterFk && this.IsHitWeakness == other.IsHitWeakness && this.IsTriggerCounterattack == other.IsTriggerCounterattack && object.Equals(this.VictimRotation, other.VictimRotation) && this.IsChangeVictimRotation == other.IsChangeVictimRotation && !(this.HitPart != other.HitPart) && this.IsTriggerVisionCounterAttack == other.IsTriggerVisionCounterAttack && this.SkillId == other.SkillId && this.FightState == other.FightState && this.BeHitAnim == other.BeHitAnim && this.Source == other.Source && this.PhantomSkillIdentify == other.PhantomSkillIdentify && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x00198014 File Offset: 0x00196214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Originator != 0L)
			{
				num ^= this.Originator.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.BulletId != 0L)
			{
				num ^= this.BulletId.GetHashCode();
			}
			if (this.HasBeHitData)
			{
				num ^= this.HasBeHitData.GetHashCode();
			}
			if (this.hitEffectPos_ != null)
			{
				num ^= this.HitEffectPos.GetHashCode();
			}
			if (this.hitEffectRotate_ != null)
			{
				num ^= this.HitEffectRotate.GetHashCode();
			}
			if (this.IsShake)
			{
				num ^= this.IsShake.GetHashCode();
			}
			if (this.hitPos_ != null)
			{
				num ^= this.HitPos.GetHashCode();
			}
			if (this.EnterFk)
			{
				num ^= this.EnterFk.GetHashCode();
			}
			if (this.IsHitWeakness)
			{
				num ^= this.IsHitWeakness.GetHashCode();
			}
			if (this.IsTriggerCounterattack)
			{
				num ^= this.IsTriggerCounterattack.GetHashCode();
			}
			if (this.victimRotation_ != null)
			{
				num ^= this.VictimRotation.GetHashCode();
			}
			if (this.IsChangeVictimRotation)
			{
				num ^= this.IsChangeVictimRotation.GetHashCode();
			}
			if (this.HitPart.Length != 0)
			{
				num ^= this.HitPart.GetHashCode();
			}
			if (this.IsTriggerVisionCounterAttack)
			{
				num ^= this.IsTriggerVisionCounterAttack.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.FightState != 0)
			{
				num ^= this.FightState.GetHashCode();
			}
			if (this.BeHitAnim != 0)
			{
				num ^= this.BeHitAnim.GetHashCode();
			}
			if (this.Source != EBulletCreateSource.NormalSource)
			{
				num ^= this.Source.GetHashCode();
			}
			if (this.PhantomSkillIdentify != 0)
			{
				num ^= this.PhantomSkillIdentify.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x00198244 File Offset: 0x00196444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x00198251 File Offset: 0x00196451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x0019825C File Offset: 0x0019645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Originator != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Originator);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TargetId);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BulletId);
			}
			if (this.HasBeHitData)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.HasBeHitData);
			}
			if (this.hitEffectPos_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.HitEffectPos);
			}
			if (this.hitEffectRotate_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.HitEffectRotate);
			}
			if (this.IsShake)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsShake);
			}
			if (this.hitPos_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.HitPos);
			}
			if (this.EnterFk)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.EnterFk);
			}
			if (this.IsHitWeakness)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsHitWeakness);
			}
			if (this.IsTriggerCounterattack)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsTriggerCounterattack);
			}
			if (this.victimRotation_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.VictimRotation);
			}
			if (this.IsChangeVictimRotation)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsChangeVictimRotation);
			}
			if (this.HitPart.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.HitPart);
			}
			if (this.IsTriggerVisionCounterAttack)
			{
				output.WriteRawTag(128, 1);
				output.WriteBool(this.IsTriggerVisionCounterAttack);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt64(this.SkillId);
			}
			if (this.FightState != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.FightState);
			}
			if (this.BeHitAnim != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.BeHitAnim);
			}
			if (this.Source != EBulletCreateSource.NormalSource)
			{
				output.WriteRawTag(160, 1);
				output.WriteEnum((int)this.Source);
			}
			if (this.PhantomSkillIdentify != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.PhantomSkillIdentify);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x001984E8 File Offset: 0x001966E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Originator != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Originator);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this.BulletId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletId);
			}
			if (this.HasBeHitData)
			{
				num += 2;
			}
			if (this.hitEffectPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitEffectPos);
			}
			if (this.hitEffectRotate_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitEffectRotate);
			}
			if (this.IsShake)
			{
				num += 2;
			}
			if (this.hitPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HitPos);
			}
			if (this.EnterFk)
			{
				num += 2;
			}
			if (this.IsHitWeakness)
			{
				num += 2;
			}
			if (this.IsTriggerCounterattack)
			{
				num += 2;
			}
			if (this.victimRotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VictimRotation);
			}
			if (this.IsChangeVictimRotation)
			{
				num += 2;
			}
			if (this.HitPart.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HitPart);
			}
			if (this.IsTriggerVisionCounterAttack)
			{
				num += 3;
			}
			if (this.SkillId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.FightState != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.FightState);
			}
			if (this.BeHitAnim != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BeHitAnim);
			}
			if (this.Source != EBulletCreateSource.NormalSource)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
			if (this.PhantomSkillIdentify != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PhantomSkillIdentify);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x001986B8 File Offset: 0x001968B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Originator != 0L)
			{
				this.Originator = other.Originator;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			if (other.BulletId != 0L)
			{
				this.BulletId = other.BulletId;
			}
			if (other.HasBeHitData)
			{
				this.HasBeHitData = other.HasBeHitData;
			}
			if (other.hitEffectPos_ != null)
			{
				if (this.hitEffectPos_ == null)
				{
					this.HitEffectPos = new Vector();
				}
				this.HitEffectPos.MergeFrom(other.HitEffectPos);
			}
			if (other.hitEffectRotate_ != null)
			{
				if (this.hitEffectRotate_ == null)
				{
					this.HitEffectRotate = new Rotator();
				}
				this.HitEffectRotate.MergeFrom(other.HitEffectRotate);
			}
			if (other.IsShake)
			{
				this.IsShake = other.IsShake;
			}
			if (other.hitPos_ != null)
			{
				if (this.hitPos_ == null)
				{
					this.HitPos = new Vector();
				}
				this.HitPos.MergeFrom(other.HitPos);
			}
			if (other.EnterFk)
			{
				this.EnterFk = other.EnterFk;
			}
			if (other.IsHitWeakness)
			{
				this.IsHitWeakness = other.IsHitWeakness;
			}
			if (other.IsTriggerCounterattack)
			{
				this.IsTriggerCounterattack = other.IsTriggerCounterattack;
			}
			if (other.victimRotation_ != null)
			{
				if (this.victimRotation_ == null)
				{
					this.VictimRotation = new Rotator();
				}
				this.VictimRotation.MergeFrom(other.VictimRotation);
			}
			if (other.IsChangeVictimRotation)
			{
				this.IsChangeVictimRotation = other.IsChangeVictimRotation;
			}
			if (other.HitPart.Length != 0)
			{
				this.HitPart = other.HitPart;
			}
			if (other.IsTriggerVisionCounterAttack)
			{
				this.IsTriggerVisionCounterAttack = other.IsTriggerVisionCounterAttack;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.FightState != 0)
			{
				this.FightState = other.FightState;
			}
			if (other.BeHitAnim != 0)
			{
				this.BeHitAnim = other.BeHitAnim;
			}
			if (other.Source != EBulletCreateSource.NormalSource)
			{
				this.Source = other.Source;
			}
			if (other.PhantomSkillIdentify != 0)
			{
				this.PhantomSkillIdentify = other.PhantomSkillIdentify;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x001988E9 File Offset: 0x00196AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x001988F4 File Offset: 0x00196AF4
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
				if (num <= 80U)
				{
					if (num <= 40U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.Originator = input.ReadInt64();
								continue;
							}
							if (num == 16U)
							{
								this.Id = input.ReadInt64();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.TargetId = input.ReadInt64();
								continue;
							}
							if (num == 32U)
							{
								this.BulletId = input.ReadInt64();
								continue;
							}
							if (num == 40U)
							{
								this.HasBeHitData = input.ReadBool();
								continue;
							}
						}
					}
					else if (num <= 58U)
					{
						if (num == 50U)
						{
							if (this.hitEffectPos_ == null)
							{
								this.HitEffectPos = new Vector();
							}
							input.ReadMessage(this.HitEffectPos);
							continue;
						}
						if (num == 58U)
						{
							if (this.hitEffectRotate_ == null)
							{
								this.HitEffectRotate = new Rotator();
							}
							input.ReadMessage(this.HitEffectRotate);
							continue;
						}
					}
					else
					{
						if (num == 64U)
						{
							this.IsShake = input.ReadBool();
							continue;
						}
						if (num == 74U)
						{
							if (this.hitPos_ == null)
							{
								this.HitPos = new Vector();
							}
							input.ReadMessage(this.HitPos);
							continue;
						}
						if (num == 80U)
						{
							this.EnterFk = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 122U)
				{
					if (num <= 96U)
					{
						if (num == 88U)
						{
							this.IsHitWeakness = input.ReadBool();
							continue;
						}
						if (num == 96U)
						{
							this.IsTriggerCounterattack = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 106U)
						{
							if (this.victimRotation_ == null)
							{
								this.VictimRotation = new Rotator();
							}
							input.ReadMessage(this.VictimRotation);
							continue;
						}
						if (num == 112U)
						{
							this.IsChangeVictimRotation = input.ReadBool();
							continue;
						}
						if (num == 122U)
						{
							this.HitPart = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 144U)
				{
					if (num == 128U)
					{
						this.IsTriggerVisionCounterAttack = input.ReadBool();
						continue;
					}
					if (num == 136U)
					{
						this.SkillId = input.ReadInt64();
						continue;
					}
					if (num == 144U)
					{
						this.FightState = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 152U)
					{
						this.BeHitAnim = input.ReadInt32();
						continue;
					}
					if (num == 160U)
					{
						this.Source = (EBulletCreateSource)input.ReadEnum();
						continue;
					}
					if (num == 168U)
					{
						this.PhantomSkillIdentify = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D23 RID: 19747
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D24 RID: 19748
		public const int OriginatorFieldNumber = 1;

		// Token: 0x04004D25 RID: 19749
		private long originator_;

		// Token: 0x04004D26 RID: 19750
		public const int IdFieldNumber = 2;

		// Token: 0x04004D27 RID: 19751
		private long id_;

		// Token: 0x04004D28 RID: 19752
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04004D29 RID: 19753
		private long targetId_;

		// Token: 0x04004D2A RID: 19754
		public const int BulletIdFieldNumber = 4;

		// Token: 0x04004D2B RID: 19755
		private long bulletId_;

		// Token: 0x04004D2C RID: 19756
		public const int HasBeHitDataFieldNumber = 5;

		// Token: 0x04004D2D RID: 19757
		private bool hasBeHitData_;

		// Token: 0x04004D2E RID: 19758
		public const int HitEffectPosFieldNumber = 6;

		// Token: 0x04004D2F RID: 19759
		private Vector hitEffectPos_;

		// Token: 0x04004D30 RID: 19760
		public const int HitEffectRotateFieldNumber = 7;

		// Token: 0x04004D31 RID: 19761
		private Rotator hitEffectRotate_;

		// Token: 0x04004D32 RID: 19762
		public const int IsShakeFieldNumber = 8;

		// Token: 0x04004D33 RID: 19763
		private bool isShake_;

		// Token: 0x04004D34 RID: 19764
		public const int HitPosFieldNumber = 9;

		// Token: 0x04004D35 RID: 19765
		private Vector hitPos_;

		// Token: 0x04004D36 RID: 19766
		public const int EnterFkFieldNumber = 10;

		// Token: 0x04004D37 RID: 19767
		private bool enterFk_;

		// Token: 0x04004D38 RID: 19768
		public const int IsHitWeaknessFieldNumber = 11;

		// Token: 0x04004D39 RID: 19769
		private bool isHitWeakness_;

		// Token: 0x04004D3A RID: 19770
		public const int IsTriggerCounterattackFieldNumber = 12;

		// Token: 0x04004D3B RID: 19771
		private bool isTriggerCounterattack_;

		// Token: 0x04004D3C RID: 19772
		public const int VictimRotationFieldNumber = 13;

		// Token: 0x04004D3D RID: 19773
		private Rotator victimRotation_;

		// Token: 0x04004D3E RID: 19774
		public const int IsChangeVictimRotationFieldNumber = 14;

		// Token: 0x04004D3F RID: 19775
		private bool isChangeVictimRotation_;

		// Token: 0x04004D40 RID: 19776
		public const int HitPartFieldNumber = 15;

		// Token: 0x04004D41 RID: 19777
		private string hitPart_ = "";

		// Token: 0x04004D42 RID: 19778
		public const int IsTriggerVisionCounterAttackFieldNumber = 16;

		// Token: 0x04004D43 RID: 19779
		private bool isTriggerVisionCounterAttack_;

		// Token: 0x04004D44 RID: 19780
		public const int SkillIdFieldNumber = 17;

		// Token: 0x04004D45 RID: 19781
		private long skillId_;

		// Token: 0x04004D46 RID: 19782
		public const int FightStateFieldNumber = 18;

		// Token: 0x04004D47 RID: 19783
		private int fightState_;

		// Token: 0x04004D48 RID: 19784
		public const int BeHitAnimFieldNumber = 19;

		// Token: 0x04004D49 RID: 19785
		private int beHitAnim_;

		// Token: 0x04004D4A RID: 19786
		public const int SourceFieldNumber = 20;

		// Token: 0x04004D4B RID: 19787
		private EBulletCreateSource source_;

		// Token: 0x04004D4C RID: 19788
		public const int PhantomSkillIdentifyFieldNumber = 21;

		// Token: 0x04004D4D RID: 19789
		private int phantomSkillIdentify_;
	}
}
