using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005384 RID: 21380
	public class IHitBulletType_UnionUnion
	{
		// Token: 0x17009D10 RID: 40208
		// (get) Token: 0x06022FD6 RID: 143318 RVA: 0x004D80F5 File Offset: 0x004D62F5
		// (set) Token: 0x06022FD7 RID: 143319 RVA: 0x004D80FD File Offset: 0x004D62FD
		public IHitBulletType_Union Type { get; set; }

		// Token: 0x17009D11 RID: 40209
		// (get) Token: 0x06022FD8 RID: 143320 RVA: 0x004D8106 File Offset: 0x004D6306
		// (set) Token: 0x06022FD9 RID: 143321 RVA: 0x004D810E File Offset: 0x004D630E
		public object Value { get; set; }

		// Token: 0x06022FDA RID: 143322 RVA: 0x004D8117 File Offset: 0x004D6317
		public IHitBulletType_UnionUnion()
		{
			this.Type = IHitBulletType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022FDB RID: 143323 RVA: 0x004D812D File Offset: 0x004D632D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022FDC RID: 143324 RVA: 0x004D813F File Offset: 0x004D633F
		public IHitBulletTypeT AsIHitBulletType()
		{
			return this.As<IHitBulletTypeT>();
		}

		// Token: 0x06022FDD RID: 143325 RVA: 0x004D8147 File Offset: 0x004D6347
		public static IHitBulletType_UnionUnion FromIHitBulletType(IHitBulletTypeT _ihitbullettype)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletType,
				Value = _ihitbullettype
			};
		}

		// Token: 0x06022FDE RID: 143326 RVA: 0x004D815C File Offset: 0x004D635C
		public IHitBulletTypeOnlyDropAttackT AsIHitBulletTypeOnlyDropAttack()
		{
			return this.As<IHitBulletTypeOnlyDropAttackT>();
		}

		// Token: 0x06022FDF RID: 143327 RVA: 0x004D8164 File Offset: 0x004D6364
		public static IHitBulletType_UnionUnion FromIHitBulletTypeOnlyDropAttack(IHitBulletTypeOnlyDropAttackT _ihitbullettypeonlydropattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypeOnlyDropAttack,
				Value = _ihitbullettypeonlydropattack
			};
		}

		// Token: 0x06022FE0 RID: 143328 RVA: 0x004D8179 File Offset: 0x004D6379
		public IHitBulletTypeCrystalAttackT AsIHitBulletTypeCrystalAttack()
		{
			return this.As<IHitBulletTypeCrystalAttackT>();
		}

		// Token: 0x06022FE1 RID: 143329 RVA: 0x004D8181 File Offset: 0x004D6381
		public static IHitBulletType_UnionUnion FromIHitBulletTypeCrystalAttack(IHitBulletTypeCrystalAttackT _ihitbullettypecrystalattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypeCrystalAttack,
				Value = _ihitbullettypecrystalattack
			};
		}

		// Token: 0x06022FE2 RID: 143330 RVA: 0x004D8196 File Offset: 0x004D6396
		public IHitBulletTypeFixedBulletIdT AsIHitBulletTypeFixedBulletId()
		{
			return this.As<IHitBulletTypeFixedBulletIdT>();
		}

		// Token: 0x06022FE3 RID: 143331 RVA: 0x004D819E File Offset: 0x004D639E
		public static IHitBulletType_UnionUnion FromIHitBulletTypeFixedBulletId(IHitBulletTypeFixedBulletIdT _ihitbullettypefixedbulletid)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypeFixedBulletId,
				Value = _ihitbullettypefixedbulletid
			};
		}

		// Token: 0x06022FE4 RID: 143332 RVA: 0x004D81B3 File Offset: 0x004D63B3
		public IHitBulletTypePlayerAttackT AsIHitBulletTypePlayerAttack()
		{
			return this.As<IHitBulletTypePlayerAttackT>();
		}

		// Token: 0x06022FE5 RID: 143333 RVA: 0x004D81BB File Offset: 0x004D63BB
		public static IHitBulletType_UnionUnion FromIHitBulletTypePlayerAttack(IHitBulletTypePlayerAttackT _ihitbullettypeplayerattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypePlayerAttack,
				Value = _ihitbullettypeplayerattack
			};
		}

		// Token: 0x06022FE6 RID: 143334 RVA: 0x004D81D0 File Offset: 0x004D63D0
		public IHitBulletTypeAllCharacterAttackT AsIHitBulletTypeAllCharacterAttack()
		{
			return this.As<IHitBulletTypeAllCharacterAttackT>();
		}

		// Token: 0x06022FE7 RID: 143335 RVA: 0x004D81D8 File Offset: 0x004D63D8
		public static IHitBulletType_UnionUnion FromIHitBulletTypeAllCharacterAttack(IHitBulletTypeAllCharacterAttackT _ihitbullettypeallcharacterattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypeAllCharacterAttack,
				Value = _ihitbullettypeallcharacterattack
			};
		}

		// Token: 0x06022FE8 RID: 143336 RVA: 0x004D81ED File Offset: 0x004D63ED
		public IHitBulletTypePlayerOrThrenodianAttackT AsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.As<IHitBulletTypePlayerOrThrenodianAttackT>();
		}

		// Token: 0x06022FE9 RID: 143337 RVA: 0x004D81F5 File Offset: 0x004D63F5
		public static IHitBulletType_UnionUnion FromIHitBulletTypePlayerOrThrenodianAttack(IHitBulletTypePlayerOrThrenodianAttackT _ihitbullettypeplayerorthrenodianattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypePlayerOrThrenodianAttack,
				Value = _ihitbullettypeplayerorthrenodianattack
			};
		}

		// Token: 0x06022FEA RID: 143338 RVA: 0x004D820C File Offset: 0x004D640C
		public static int Pack(FlatBufferBuilder builder, IHitBulletType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHitBulletType_Union.IHitBulletType:
				return IHitBulletType.Pack(builder, _o.AsIHitBulletType()).Value;
			case IHitBulletType_Union.IHitBulletTypeOnlyDropAttack:
				return IHitBulletTypeOnlyDropAttack.Pack(builder, _o.AsIHitBulletTypeOnlyDropAttack()).Value;
			case IHitBulletType_Union.IHitBulletTypeCrystalAttack:
				return IHitBulletTypeCrystalAttack.Pack(builder, _o.AsIHitBulletTypeCrystalAttack()).Value;
			case IHitBulletType_Union.IHitBulletTypeFixedBulletId:
				return IHitBulletTypeFixedBulletId.Pack(builder, _o.AsIHitBulletTypeFixedBulletId()).Value;
			case IHitBulletType_Union.IHitBulletTypePlayerAttack:
				return IHitBulletTypePlayerAttack.Pack(builder, _o.AsIHitBulletTypePlayerAttack()).Value;
			case IHitBulletType_Union.IHitBulletTypeAllCharacterAttack:
				return IHitBulletTypeAllCharacterAttack.Pack(builder, _o.AsIHitBulletTypeAllCharacterAttack()).Value;
			case IHitBulletType_Union.IHitBulletTypePlayerOrThrenodianAttack:
				return IHitBulletTypePlayerOrThrenodianAttack.Pack(builder, _o.AsIHitBulletTypePlayerOrThrenodianAttack()).Value;
			default:
				return 0;
			}
		}
	}
}
