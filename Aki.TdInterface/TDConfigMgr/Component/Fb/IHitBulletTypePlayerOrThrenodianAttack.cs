using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C66 RID: 3174
	public class IHitBulletTypePlayerOrThrenodianAttack : IHitBulletType
	{
		// Token: 0x06004883 RID: 18563 RVA: 0x000B757E File Offset: 0x000B577E
		public static IHitBulletTypePlayerOrThrenodianAttack Create(IHitBulletTypePlayerOrThrenodianAttack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypePlayerOrThrenodianAttack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x000B759D File Offset: 0x000B579D
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x040028BF RID: 10431
		private IHitBulletTypePlayerOrThrenodianAttack Instance;
	}
}
