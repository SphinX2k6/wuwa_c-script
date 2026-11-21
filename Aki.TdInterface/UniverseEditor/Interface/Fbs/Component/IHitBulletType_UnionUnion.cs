using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590A RID: 22794
	public class IHitBulletType_UnionUnion
	{
		// Token: 0x1700A548 RID: 42312
		// (get) Token: 0x0602508A RID: 151690 RVA: 0x00514FC9 File Offset: 0x005131C9
		// (set) Token: 0x0602508B RID: 151691 RVA: 0x00514FD1 File Offset: 0x005131D1
		public IHitBulletType_Union Type { get; set; }

		// Token: 0x1700A549 RID: 42313
		// (get) Token: 0x0602508C RID: 151692 RVA: 0x00514FDA File Offset: 0x005131DA
		// (set) Token: 0x0602508D RID: 151693 RVA: 0x00514FE2 File Offset: 0x005131E2
		public object Value { get; set; }

		// Token: 0x0602508E RID: 151694 RVA: 0x00514FEB File Offset: 0x005131EB
		public IHitBulletType_UnionUnion()
		{
			this.Type = IHitBulletType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602508F RID: 151695 RVA: 0x00515001 File Offset: 0x00513201
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025090 RID: 151696 RVA: 0x00515013 File Offset: 0x00513213
		public IHitBulletTypeT AsIHitBulletType()
		{
			return this.As<IHitBulletTypeT>();
		}

		// Token: 0x06025091 RID: 151697 RVA: 0x0051501B File Offset: 0x0051321B
		public static IHitBulletType_UnionUnion FromIHitBulletType(IHitBulletTypeT _ihitbullettype)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletType,
				Value = _ihitbullettype
			};
		}

		// Token: 0x06025092 RID: 151698 RVA: 0x00515030 File Offset: 0x00513230
		public IHitBulletTypeOnlyDropAttackT AsIHitBulletTypeOnlyDropAttack()
		{
			return this.As<IHitBulletTypeOnlyDropAttackT>();
		}

		// Token: 0x06025093 RID: 151699 RVA: 0x00515038 File Offset: 0x00513238
		public static IHitBulletType_UnionUnion FromIHitBulletTypeOnlyDropAttack(IHitBulletTypeOnlyDropAttackT _ihitbullettypeonlydropattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypeOnlyDropAttack,
				Value = _ihitbullettypeonlydropattack
			};
		}

		// Token: 0x06025094 RID: 151700 RVA: 0x0051504D File Offset: 0x0051324D
		public IHitBulletTypeCrystalAttackT AsIHitBulletTypeCrystalAttack()
		{
			return this.As<IHitBulletTypeCrystalAttackT>();
		}

		// Token: 0x06025095 RID: 151701 RVA: 0x00515055 File Offset: 0x00513255
		public static IHitBulletType_UnionUnion FromIHitBulletTypeCrystalAttack(IHitBulletTypeCrystalAttackT _ihitbullettypecrystalattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypeCrystalAttack,
				Value = _ihitbullettypecrystalattack
			};
		}

		// Token: 0x06025096 RID: 151702 RVA: 0x0051506A File Offset: 0x0051326A
		public IHitBulletTypeFixedBulletIdT AsIHitBulletTypeFixedBulletId()
		{
			return this.As<IHitBulletTypeFixedBulletIdT>();
		}

		// Token: 0x06025097 RID: 151703 RVA: 0x00515072 File Offset: 0x00513272
		public static IHitBulletType_UnionUnion FromIHitBulletTypeFixedBulletId(IHitBulletTypeFixedBulletIdT _ihitbullettypefixedbulletid)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypeFixedBulletId,
				Value = _ihitbullettypefixedbulletid
			};
		}

		// Token: 0x06025098 RID: 151704 RVA: 0x00515087 File Offset: 0x00513287
		public IHitBulletTypePlayerAttackT AsIHitBulletTypePlayerAttack()
		{
			return this.As<IHitBulletTypePlayerAttackT>();
		}

		// Token: 0x06025099 RID: 151705 RVA: 0x0051508F File Offset: 0x0051328F
		public static IHitBulletType_UnionUnion FromIHitBulletTypePlayerAttack(IHitBulletTypePlayerAttackT _ihitbullettypeplayerattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypePlayerAttack,
				Value = _ihitbullettypeplayerattack
			};
		}

		// Token: 0x0602509A RID: 151706 RVA: 0x005150A4 File Offset: 0x005132A4
		public IHitBulletTypeAllCharacterAttackT AsIHitBulletTypeAllCharacterAttack()
		{
			return this.As<IHitBulletTypeAllCharacterAttackT>();
		}

		// Token: 0x0602509B RID: 151707 RVA: 0x005150AC File Offset: 0x005132AC
		public static IHitBulletType_UnionUnion FromIHitBulletTypeAllCharacterAttack(IHitBulletTypeAllCharacterAttackT _ihitbullettypeallcharacterattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypeAllCharacterAttack,
				Value = _ihitbullettypeallcharacterattack
			};
		}

		// Token: 0x0602509C RID: 151708 RVA: 0x005150C1 File Offset: 0x005132C1
		public IHitBulletTypePlayerOrThrenodianAttackT AsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.As<IHitBulletTypePlayerOrThrenodianAttackT>();
		}

		// Token: 0x0602509D RID: 151709 RVA: 0x005150C9 File Offset: 0x005132C9
		public static IHitBulletType_UnionUnion FromIHitBulletTypePlayerOrThrenodianAttack(IHitBulletTypePlayerOrThrenodianAttackT _ihitbullettypeplayerorthrenodianattack)
		{
			return new IHitBulletType_UnionUnion
			{
				Type = IHitBulletType_Union.IHitBulletTypePlayerOrThrenodianAttack,
				Value = _ihitbullettypeplayerorthrenodianattack
			};
		}

		// Token: 0x0602509E RID: 151710 RVA: 0x005150E0 File Offset: 0x005132E0
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
