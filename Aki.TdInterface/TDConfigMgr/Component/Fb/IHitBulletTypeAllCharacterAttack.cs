using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C65 RID: 3173
	public class IHitBulletTypeAllCharacterAttack : IHitBulletType
	{
		// Token: 0x06004880 RID: 18560 RVA: 0x000B754A File Offset: 0x000B574A
		public static IHitBulletTypeAllCharacterAttack Create(IHitBulletTypeAllCharacterAttack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletTypeAllCharacterAttack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x000B7569 File Offset: 0x000B5769
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x040028BE RID: 10430
		private IHitBulletTypeAllCharacterAttack Instance;
	}
}
