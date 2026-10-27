using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B98 RID: 2968
	public class IHitBulletTypePlayerOrThrenodianAttack : IHitBulletType
	{
		// Token: 0x0600442A RID: 17450 RVA: 0x000AD4BA File Offset: 0x000AB6BA
		[NullableContext(1)]
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

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x000AD4D9 File Offset: 0x000AB6D9
		public override EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x04002677 RID: 9847
		private IHitBulletTypePlayerOrThrenodianAttack Instance;
	}
}
