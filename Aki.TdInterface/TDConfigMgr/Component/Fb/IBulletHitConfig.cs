using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D2C RID: 3372
	[NullableContext(2)]
	[Nullable(0)]
	public class IBulletHitConfig
	{
		// Token: 0x06004CF1 RID: 19697 RVA: 0x000BF78A File Offset: 0x000BD98A
		[NullableContext(1)]
		public static IBulletHitConfig Create(IBulletHitConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBulletHitConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x000BF7A9 File Offset: 0x000BD9A9
		[Nullable(1)]
		public virtual IHitBulletType HitBullet
		{
			[NullableContext(1)]
			get
			{
				if (this._HitBulletInited)
				{
					return this._HitBulletCache;
				}
				this._HitBulletInited = true;
				this._HitBulletCache = ComponentReadHelper.ReadIBulletHitConfig_HitBullet(this.Instance);
				return this._HitBulletCache;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06004CF3 RID: 19699 RVA: 0x000BF7D8 File Offset: 0x000BD9D8
		public virtual IHitTimeScaleRatio AttackerHitTimeScaleRatio
		{
			get
			{
				if (this._AttackerHitTimeScaleRatioInited)
				{
					return this._AttackerHitTimeScaleRatioCache;
				}
				this._AttackerHitTimeScaleRatioInited = true;
				this._AttackerHitTimeScaleRatioCache = IHitTimeScaleRatio.Create(this.Instance.AttackerHitTimeScaleRatio);
				return this._AttackerHitTimeScaleRatioCache;
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x000BF80C File Offset: 0x000BDA0C
		public virtual IHitTimeScaleRatio VictimHitTimeScaleRatio
		{
			get
			{
				if (this._VictimHitTimeScaleRatioInited)
				{
					return this._VictimHitTimeScaleRatioCache;
				}
				this._VictimHitTimeScaleRatioInited = true;
				this._VictimHitTimeScaleRatioCache = IHitTimeScaleRatio.Create(this.Instance.VictimHitTimeScaleRatio);
				return this._VictimHitTimeScaleRatioCache;
			}
		}

		// Token: 0x04002C0D RID: 11277
		private IBulletHitConfig Instance;

		// Token: 0x04002C0E RID: 11278
		[Nullable(1)]
		private IHitBulletType _HitBulletCache;

		// Token: 0x04002C0F RID: 11279
		private bool _HitBulletInited;

		// Token: 0x04002C10 RID: 11280
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04002C11 RID: 11281
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002C12 RID: 11282
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04002C13 RID: 11283
		private bool _VictimHitTimeScaleRatioInited;
	}
}
