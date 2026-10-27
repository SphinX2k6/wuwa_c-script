using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C31 RID: 23601
	public class THitBulletTypeUnion
	{
		// Token: 0x1700B1FE RID: 45566
		// (get) Token: 0x0602876D RID: 165741 RVA: 0x0059158E File Offset: 0x0058F78E
		// (set) Token: 0x0602876E RID: 165742 RVA: 0x00591596 File Offset: 0x0058F796
		public THitBulletType Type { get; set; }

		// Token: 0x1700B1FF RID: 45567
		// (get) Token: 0x0602876F RID: 165743 RVA: 0x0059159F File Offset: 0x0058F79F
		// (set) Token: 0x06028770 RID: 165744 RVA: 0x005915A7 File Offset: 0x0058F7A7
		public object Value { get; set; }

		// Token: 0x06028771 RID: 165745 RVA: 0x005915B0 File Offset: 0x0058F7B0
		public THitBulletTypeUnion()
		{
			this.Type = THitBulletType.NONE;
			this.Value = null;
		}

		// Token: 0x06028772 RID: 165746 RVA: 0x005915C6 File Offset: 0x0058F7C6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028773 RID: 165747 RVA: 0x005915D8 File Offset: 0x0058F7D8
		public IHitBulletTypeAllCharacterAttackT AsIHitBulletTypeAllCharacterAttack()
		{
			return this.As<IHitBulletTypeAllCharacterAttackT>();
		}

		// Token: 0x06028774 RID: 165748 RVA: 0x005915E0 File Offset: 0x0058F7E0
		public static THitBulletTypeUnion FromIHitBulletTypeAllCharacterAttack(IHitBulletTypeAllCharacterAttackT _ihitbullettypeallcharacterattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypeAllCharacterAttack,
				Value = _ihitbullettypeallcharacterattack
			};
		}

		// Token: 0x06028775 RID: 165749 RVA: 0x005915F5 File Offset: 0x0058F7F5
		public IHitBulletTypeCrystalAttackT AsIHitBulletTypeCrystalAttack()
		{
			return this.As<IHitBulletTypeCrystalAttackT>();
		}

		// Token: 0x06028776 RID: 165750 RVA: 0x005915FD File Offset: 0x0058F7FD
		public static THitBulletTypeUnion FromIHitBulletTypeCrystalAttack(IHitBulletTypeCrystalAttackT _ihitbullettypecrystalattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypeCrystalAttack,
				Value = _ihitbullettypecrystalattack
			};
		}

		// Token: 0x06028777 RID: 165751 RVA: 0x00591612 File Offset: 0x0058F812
		public IHitBulletTypeFixedBulletIdT AsIHitBulletTypeFixedBulletId()
		{
			return this.As<IHitBulletTypeFixedBulletIdT>();
		}

		// Token: 0x06028778 RID: 165752 RVA: 0x0059161A File Offset: 0x0058F81A
		public static THitBulletTypeUnion FromIHitBulletTypeFixedBulletId(IHitBulletTypeFixedBulletIdT _ihitbullettypefixedbulletid)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypeFixedBulletId,
				Value = _ihitbullettypefixedbulletid
			};
		}

		// Token: 0x06028779 RID: 165753 RVA: 0x0059162F File Offset: 0x0058F82F
		public IHitBulletTypeOnlyDropAttackT AsIHitBulletTypeOnlyDropAttack()
		{
			return this.As<IHitBulletTypeOnlyDropAttackT>();
		}

		// Token: 0x0602877A RID: 165754 RVA: 0x00591637 File Offset: 0x0058F837
		public static THitBulletTypeUnion FromIHitBulletTypeOnlyDropAttack(IHitBulletTypeOnlyDropAttackT _ihitbullettypeonlydropattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypeOnlyDropAttack,
				Value = _ihitbullettypeonlydropattack
			};
		}

		// Token: 0x0602877B RID: 165755 RVA: 0x0059164C File Offset: 0x0058F84C
		public IHitBulletTypePlayerAttackT AsIHitBulletTypePlayerAttack()
		{
			return this.As<IHitBulletTypePlayerAttackT>();
		}

		// Token: 0x0602877C RID: 165756 RVA: 0x00591654 File Offset: 0x0058F854
		public static THitBulletTypeUnion FromIHitBulletTypePlayerAttack(IHitBulletTypePlayerAttackT _ihitbullettypeplayerattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypePlayerAttack,
				Value = _ihitbullettypeplayerattack
			};
		}

		// Token: 0x0602877D RID: 165757 RVA: 0x00591669 File Offset: 0x0058F869
		public IHitBulletTypePlayerOrThrenodianAttackT AsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.As<IHitBulletTypePlayerOrThrenodianAttackT>();
		}

		// Token: 0x0602877E RID: 165758 RVA: 0x00591671 File Offset: 0x0058F871
		public static THitBulletTypeUnion FromIHitBulletTypePlayerOrThrenodianAttack(IHitBulletTypePlayerOrThrenodianAttackT _ihitbullettypeplayerorthrenodianattack)
		{
			return new THitBulletTypeUnion
			{
				Type = THitBulletType.IHitBulletTypePlayerOrThrenodianAttack,
				Value = _ihitbullettypeplayerorthrenodianattack
			};
		}

		// Token: 0x0602877F RID: 165759 RVA: 0x00591688 File Offset: 0x0058F888
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
