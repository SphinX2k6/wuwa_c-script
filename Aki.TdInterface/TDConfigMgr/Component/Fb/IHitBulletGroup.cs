using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C57 RID: 3159
	public class IHitBulletGroup
	{
		// Token: 0x06004843 RID: 18499 RVA: 0x000B6CE7 File Offset: 0x000B4EE7
		public static IHitBulletGroup Create(IHitBulletGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitBulletGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x000B6D06 File Offset: 0x000B4F06
		public virtual bool MatchAny
		{
			get
			{
				return this.Instance.MatchAny;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x000B6D13 File Offset: 0x000B4F13
		public virtual List<IHitBulletType> HitBullets
		{
			get
			{
				if (this._HitBulletsInited)
				{
					return this._HitBulletsCache;
				}
				this._HitBulletsInited = true;
				this._HitBulletsCache = ComponentReadHelper.ReadIHitBulletGroup_HitBullets(this.Instance);
				return this._HitBulletsCache;
			}
		}

		// Token: 0x04002890 RID: 10384
		private IHitBulletGroup Instance;

		// Token: 0x04002891 RID: 10385
		private List<IHitBulletType> _HitBulletsCache;

		// Token: 0x04002892 RID: 10386
		private bool _HitBulletsInited;
	}
}
