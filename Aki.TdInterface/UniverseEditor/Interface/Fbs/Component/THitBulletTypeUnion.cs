using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006256 RID: 25174
	public class THitBulletTypeUnion
	{
		// Token: 0x1700BB50 RID: 47952
		// (get) Token: 0x0602AD7B RID: 175483 RVA: 0x005D97A6 File Offset: 0x005D79A6
		// (set) Token: 0x0602AD7C RID: 175484 RVA: 0x005D97AE File Offset: 0x005D79AE
		public THitBulletType Type { get; set; }

		// Token: 0x1700BB51 RID: 47953
		// (get) Token: 0x0602AD7D RID: 175485 RVA: 0x005D97B7 File Offset: 0x005D79B7
		// (set) Token: 0x0602AD7E RID: 175486 RVA: 0x005D97BF File Offset: 0x005D79BF
		public object Value { get; set; }

		// Token: 0x0602AD7F RID: 175487 RVA: 0x005D97C8 File Offset: 0x005D79C8
		public THitBulletTypeUnion()
		{
			this.Type = THitBulletType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD80 RID: 175488 RVA: 0x005D97DE File Offset: 0x005D79DE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD81 RID: 175489 RVA: 0x005D97F0 File Offset: 0x005D79F0
		public IHitBulletTypeAllCharacterAttackT AsIHitBulletTypeAllCharacterAttack()
		{
			return this.As<IHitBulletTypeAllCharacterAttackT>();
		}

		// Token: 0x0602AD82 RID: 175490 RVA: 0x005D97F8 File Offset: 0x005D79F8
		public static THitBulletTypeUnion FromIHitBulletTypeAllCharacterAttack(IHitBulletTypeAllCharacterAttackT _ihitbullettypeallcharacterattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypeAllCharacterAttack,
				Value = _ihitbullettypeallcharacterattack
			};
		}

		// Token: 0x0602AD83 RID: 175491 RVA: 0x005D980D File Offset: 0x005D7A0D
		public IHitBulletTypeCrystalAttackT AsIHitBulletTypeCrystalAttack()
		{
			return this.As<IHitBulletTypeCrystalAttackT>();
		}

		// Token: 0x0602AD84 RID: 175492 RVA: 0x005D9815 File Offset: 0x005D7A15
		public static THitBulletTypeUnion FromIHitBulletTypeCrystalAttack(IHitBulletTypeCrystalAttackT _ihitbullettypecrystalattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypeCrystalAttack,
				Value = _ihitbullettypecrystalattack
			};
		}

		// Token: 0x0602AD85 RID: 175493 RVA: 0x005D982A File Offset: 0x005D7A2A
		public IHitBulletTypeFixedBulletIdT AsIHitBulletTypeFixedBulletId()
		{
			return this.As<IHitBulletTypeFixedBulletIdT>();
		}

		// Token: 0x0602AD86 RID: 175494 RVA: 0x005D9832 File Offset: 0x005D7A32
		public static THitBulletTypeUnion FromIHitBulletTypeFixedBulletId(IHitBulletTypeFixedBulletIdT _ihitbullettypefixedbulletid)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypeFixedBulletId,
				Value = _ihitbullettypefixedbulletid
			};
		}

		// Token: 0x0602AD87 RID: 175495 RVA: 0x005D9847 File Offset: 0x005D7A47
		public IHitBulletTypeOnlyDropAttackT AsIHitBulletTypeOnlyDropAttack()
		{
			return this.As<IHitBulletTypeOnlyDropAttackT>();
		}

		// Token: 0x0602AD88 RID: 175496 RVA: 0x005D984F File Offset: 0x005D7A4F
		public static THitBulletTypeUnion FromIHitBulletTypeOnlyDropAttack(IHitBulletTypeOnlyDropAttackT _ihitbullettypeonlydropattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypeOnlyDropAttack,
				Value = _ihitbullettypeonlydropattack
			};
		}

		// Token: 0x0602AD89 RID: 175497 RVA: 0x005D9864 File Offset: 0x005D7A64
		public IHitBulletTypePlayerAttackT AsIHitBulletTypePlayerAttack()
		{
			return this.As<IHitBulletTypePlayerAttackT>();
		}

		// Token: 0x0602AD8A RID: 175498 RVA: 0x005D986C File Offset: 0x005D7A6C
		public static THitBulletTypeUnion FromIHitBulletTypePlayerAttack(IHitBulletTypePlayerAttackT _ihitbullettypeplayerattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypePlayerAttack,
				Value = _ihitbullettypeplayerattack
			};
		}

		// Token: 0x0602AD8B RID: 175499 RVA: 0x005D9881 File Offset: 0x005D7A81
		public IHitBulletTypePlayerOrThrenodianAttackT AsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.As<IHitBulletTypePlayerOrThrenodianAttackT>();
		}

		// Token: 0x0602AD8C RID: 175500 RVA: 0x005D9889 File Offset: 0x005D7A89
		public static THitBulletTypeUnion FromIHitBulletTypePlayerOrThrenodianAttack(IHitBulletTypePlayerOrThrenodianAttackT _ihitbullettypeplayerorthrenodianattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypePlayerOrThrenodianAttack,
				Value = _ihitbullettypeplayerorthrenodianattack
			};
		}

		// Token: 0x0602AD8D RID: 175501 RVA: 0x005D98A0 File Offset: 0x005D7AA0
		public static int Pack(FlatBufferBuilder builder, THitBulletTypeUnion _o)
		{
			switch (_o.Type)
			{
			case THitBulletType.IHitBulletTypeAllCharacterAttack:
				return IHitBulletTypeAllCharacterAttack.Pack(builder, _o.AsIHitBulletTypeAllCharacterAttack()).Value;
			case THitBulletType.IHitBulletTypeCrystalAttack:
				return IHitBulletTypeCrystalAttack.Pack(builder, _o.AsIHitBulletTypeCrystalAttack()).Value;
			case THitBulletType.IHitBulletTypeFixedBulletId:
				return IHitBulletTypeFixedBulletId.Pack(builder, _o.AsIHitBulletTypeFixedBulletId()).Value;
			case THitBulletType.IHitBulletTypeOnlyDropAttack:
				return IHitBulletTypeOnlyDropAttack.Pack(builder, _o.AsIHitBulletTypeOnlyDropAttack()).Value;
			case THitBulletType.IHitBulletTypePlayerAttack:
				return IHitBulletTypePlayerAttack.Pack(builder, _o.AsIHitBulletTypePlayerAttack()).Value;
			case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
				return IHitBulletTypePlayerOrThrenodianAttack.Pack(builder, _o.AsIHitBulletTypePlayerOrThrenodianAttack()).Value;
			default:
				return 0;
			}
		}
	}
}
