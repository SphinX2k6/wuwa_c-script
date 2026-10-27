using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B93 RID: 2963
	public class IHitBulletTypeOnlyDropAttack : IHitBulletType
	{
		// Token: 0x06004418 RID: 17432 RVA: 0x000AD2E6 File Offset: 0x000AB4E6
		[NullableContext(1)]
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

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x000AD305 File Offset: 0x000AB505
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x0400266E RID: 9838
		private IHitBulletTypeOnlyDropAttack Instance;
	}
}
