using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C64 RID: 3172
	public class IHitBulletTypePlayerAttack : IHitBulletType
	{
		// Token: 0x0600487D RID: 18557 RVA: 0x000B7516 File Offset: 0x000B5716
		public static IHitBulletTypePlayerAttack Create(IHitBulletTypePlayerAttack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypePlayerAttack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x000B7535 File Offset: 0x000B5735
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x040028BD RID: 10429
		private IHitBulletTypePlayerAttack Instance;
	}
}
