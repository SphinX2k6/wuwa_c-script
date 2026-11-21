using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E26 RID: 3622
	[NullableContext(2)]
	[Nullable(0)]
	public class IBulletHitConfig
	{
		// Token: 0x0600520D RID: 21005 RVA: 0x000CAECE File Offset: 0x000C90CE
		[NullableContext(0)]
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

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x000CAEED File Offset: 0x000C90ED
		[Nullable(0)]
		public virtual IHitBulletType HitBullet
		{
			[NullableContext(0)]
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

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x0600520F RID: 21007 RVA: 0x000CAF1C File Offset: 0x000C911C
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

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x000CAF50 File Offset: 0x000C9150
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

		// Token: 0x04002ECD RID: 11981
		private IBulletHitConfig Instance;

		// Token: 0x04002ECE RID: 11982
		[Nullable(0)]
		private IHitBulletType _HitBulletCache;

		// Token: 0x04002ECF RID: 11983
		private bool _HitBulletInited;

		// Token: 0x04002ED0 RID: 11984
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04002ED1 RID: 11985
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002ED2 RID: 11986
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04002ED3 RID: 11987
		private bool _VictimHitTimeScaleRatioInited;
	}
}
