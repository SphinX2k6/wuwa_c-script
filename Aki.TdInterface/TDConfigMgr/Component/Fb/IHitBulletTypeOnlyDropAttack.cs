using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C61 RID: 3169
	public class IHitBulletTypeOnlyDropAttack : IHitBulletType
	{
		// Token: 0x06004871 RID: 18545 RVA: 0x000B73AA File Offset: 0x000B55AA
		public static IHitBulletTypeOnlyDropAttack Create(IHitBulletTypeOnlyDropAttack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypeOnlyDropAttack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x000B73C9 File Offset: 0x000B55C9
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x040028B6 RID: 10422
		private IHitBulletTypeOnlyDropAttack Instance;
	}
}
