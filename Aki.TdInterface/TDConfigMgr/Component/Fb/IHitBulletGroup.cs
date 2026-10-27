using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B89 RID: 2953
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitBulletGroup
	{
		// Token: 0x060043EA RID: 17386 RVA: 0x000ACC23 File Offset: 0x000AAE23
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

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x000ACC42 File Offset: 0x000AAE42
		public virtual bool MatchAny
		{
			get
			{
				return this.Instance.MatchAny;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x060043EC RID: 17388 RVA: 0x000ACC4F File Offset: 0x000AAE4F
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

		// Token: 0x04002648 RID: 9800
		private IHitBulletGroup Instance;

		// Token: 0x04002649 RID: 9801
		private List<IHitBulletType> _HitBulletsCache;

		// Token: 0x0400264A RID: 9802
		private bool _HitBulletsInited;
	}
}
