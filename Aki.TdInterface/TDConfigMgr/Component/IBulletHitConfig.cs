using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000209 RID: 521
	[NullableContext(1)]
	[Nullable(0)]
	public class IBulletHitConfig
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x000272A4 File Offset: 0x000254A4
		private IBulletHitConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBulletHitConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBulletHitConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBulletHitConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000272DC File Offset: 0x000254DC
		public static IBulletHitConfig Create([Nullable(2)] IBulletHitConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBulletHitConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000272EF File Offset: 0x000254EF
		public static IBulletHitConfig CreateFromSetValue([Nullable(2)] IBulletHitConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBulletHitConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00027302 File Offset: 0x00025502
		public IBulletHitConfig_SetValue ToSetValue()
		{
			return new IBulletHitConfig_SetValue
			{
				HitBullet = this.HitBullet,
				AttackerHitTimeScaleRatio = this.AttackerHitTimeScaleRatio,
				VictimHitTimeScaleRatio = this.VictimHitTimeScaleRatio
			};
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0002732D File Offset: 0x0002552D
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00027354 File Offset: 0x00025554
		public virtual IHitBulletType HitBullet
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitBullet;
				}
				IBulletHitConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitBullet;
			}
			set
			{
				this.GetOrCreatePoco().HitBullet = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00027364 File Offset: 0x00025564
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x000273C5 File Offset: 0x000255C5
		[Nullable(2)]
		public virtual IHitTimeScaleRatio AttackerHitTimeScaleRatio
		{
			[NullableContext(2)]
			get
			{
				if (this._AttackerHitTimeScaleRatioInited)
				{
					return this._AttackerHitTimeScaleRatioCache;
				}
				this._AttackerHitTimeScaleRatioInited = true;
				if (this.FbInstance != null)
				{
					this._AttackerHitTimeScaleRatioCache = IHitTimeScaleRatio.Create(this.FbInstance.AttackerHitTimeScaleRatio);
				}
				else
				{
					IBulletHitConfig_SetValue pocoInterface = this.PocoInterface;
					this._AttackerHitTimeScaleRatioCache = ((pocoInterface != null) ? pocoInterface.AttackerHitTimeScaleRatio : null);
				}
				return this._AttackerHitTimeScaleRatioCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AttackerHitTimeScaleRatio = value;
				this._AttackerHitTimeScaleRatioInited = false;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x000273DC File Offset: 0x000255DC
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0002743D File Offset: 0x0002563D
		[Nullable(2)]
		public virtual IHitTimeScaleRatio VictimHitTimeScaleRatio
		{
			[NullableContext(2)]
			get
			{
				if (this._VictimHitTimeScaleRatioInited)
				{
					return this._VictimHitTimeScaleRatioCache;
				}
				this._VictimHitTimeScaleRatioInited = true;
				if (this.FbInstance != null)
				{
					this._VictimHitTimeScaleRatioCache = IHitTimeScaleRatio.Create(this.FbInstance.VictimHitTimeScaleRatio);
				}
				else
				{
					IBulletHitConfig_SetValue pocoInterface = this.PocoInterface;
					this._VictimHitTimeScaleRatioCache = ((pocoInterface != null) ? pocoInterface.VictimHitTimeScaleRatio : null);
				}
				return this._VictimHitTimeScaleRatioCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().VictimHitTimeScaleRatio = value;
				this._VictimHitTimeScaleRatioInited = false;
			}
		}

		// Token: 0x0400093B RID: 2363
		[Nullable(2)]
		protected IBulletHitConfig FbInstance;

		// Token: 0x0400093C RID: 2364
		[Nullable(2)]
		protected IBulletHitConfig_SetValue PocoInterface;

		// Token: 0x0400093D RID: 2365
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x0400093E RID: 2366
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x0400093F RID: 2367
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04000940 RID: 2368
		private bool _VictimHitTimeScaleRatioInited;
	}
}
