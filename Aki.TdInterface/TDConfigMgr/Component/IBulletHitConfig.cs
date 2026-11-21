using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000232 RID: 562
	public class IBulletHitConfig
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x00028BF8 File Offset: 0x00026DF8
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

		// Token: 0x06000923 RID: 2339 RVA: 0x00028C30 File Offset: 0x00026E30
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

		// Token: 0x06000924 RID: 2340 RVA: 0x00028C43 File Offset: 0x00026E43
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

		// Token: 0x06000925 RID: 2341 RVA: 0x00028C56 File Offset: 0x00026E56
		public IBulletHitConfig_SetValue ToSetValue()
		{
			return new IBulletHitConfig_SetValue
			{
				HitBullet = this.HitBullet,
				AttackerHitTimeScaleRatio = this.AttackerHitTimeScaleRatio,
				VictimHitTimeScaleRatio = this.VictimHitTimeScaleRatio
			};
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00028C81 File Offset: 0x00026E81
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00028CA8 File Offset: 0x00026EA8
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00028CB8 File Offset: 0x00026EB8
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00028D19 File Offset: 0x00026F19
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

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00028D30 File Offset: 0x00026F30
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00028D91 File Offset: 0x00026F91
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

		// Token: 0x040009CC RID: 2508
		[Nullable(2)]
		protected IBulletHitConfig FbInstance;

		// Token: 0x040009CD RID: 2509
		[Nullable(2)]
		protected IBulletHitConfig_SetValue PocoInterface;

		// Token: 0x040009CE RID: 2510
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x040009CF RID: 2511
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x040009D0 RID: 2512
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x040009D1 RID: 2513
		private bool _VictimHitTimeScaleRatioInited;
	}
}
