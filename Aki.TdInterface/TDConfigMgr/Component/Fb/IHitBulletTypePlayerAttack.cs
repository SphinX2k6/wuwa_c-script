using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B96 RID: 2966
	public class IHitBulletTypePlayerAttack : IHitBulletType
	{
		// Token: 0x06004424 RID: 17444 RVA: 0x000AD452 File Offset: 0x000AB652
		[NullableContext(1)]
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

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x000AD471 File Offset: 0x000AB671
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x04002675 RID: 9845
		private IHitBulletTypePlayerAttack Instance;
	}
}
