using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C60 RID: 3168
	public class IHitBulletType
	{
		// Token: 0x0600486E RID: 18542 RVA: 0x000B7376 File Offset: 0x000B5576
		public static IHitBulletType Create(IHitBulletType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x000B7395 File Offset: 0x000B5595
		public virtual EHitBulletType Type
		{
			get
			{
				return (EHitBulletType)this.Instance.Type;
			}
		}

		// Token: 0x040028B5 RID: 10421
		private IHitBulletType Instance;
	}
}
