using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000900 RID: 2304
	[NullableContext(2)]
	[Nullable(0)]
	public class ProgressBarControlComponent : IHitComponentBase
	{
		// Token: 0x0600327F RID: 12927 RVA: 0x0008147C File Offset: 0x0007F67C
		[NullableContext(0)]
		private ProgressBarControlComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ProgressBarControlComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ProgressBarControlComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ProgressBarControlComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x000814B4 File Offset: 0x0007F6B4
		[NullableContext(0)]
		public static ProgressBarControlComponent Create([Nullable(2)] ProgressBarControlComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ProgressBarControlComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x000814C7 File Offset: 0x0007F6C7
		[NullableContext(0)]
		public static ProgressBarControlComponent CreateFromSetValue([Nullable(2)] ProgressBarControlComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ProgressBarControlComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x000814DC File Offset: 0x0007F6DC
		[NullableContext(0)]
		public new ProgressBarControlComponent_SetValue ToSetValue()
		{
			return new ProgressBarControlComponent_SetValue
			{
				Disabled = this.Disabled,
				HitBullet = this.HitBullet,
				AttackerHitTimeScaleRatio = this.AttackerHitTimeScaleRatio,
				VictimHitTimeScaleRatio = this.VictimHitTimeScaleRatio,
				AimParts = this.AimParts,
				EdIsLocked = this.EdIsLocked,
				Control = this.Control
			};
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x00081544 File Offset: 0x0007F744
		// (set) Token: 0x06003284 RID: 12932 RVA: 0x0008157E File Offset: 0x0007F77E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ProgressBarControlComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06003285 RID: 12933 RVA: 0x0008158C File Offset: 0x0007F78C
		// (set) Token: 0x06003286 RID: 12934 RVA: 0x000815B3 File Offset: 0x0007F7B3
		public override IHitBulletType HitBullet
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitBullet;
				}
				ProgressBarControlComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x000815C4 File Offset: 0x0007F7C4
		// (set) Token: 0x06003288 RID: 12936 RVA: 0x00081625 File Offset: 0x0007F825
		public override IHitTimeScaleRatio AttackerHitTimeScaleRatio
		{
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
					ProgressBarControlComponent_SetValue pocoInterface = this.PocoInterface;
					this._AttackerHitTimeScaleRatioCache = ((pocoInterface != null) ? pocoInterface.AttackerHitTimeScaleRatio : null);
				}
				return this._AttackerHitTimeScaleRatioCache;
			}
			set
			{
				this.GetOrCreatePoco().AttackerHitTimeScaleRatio = value;
				this._AttackerHitTimeScaleRatioInited = false;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x0008163C File Offset: 0x0007F83C
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x0008169D File Offset: 0x0007F89D
		public override IHitTimeScaleRatio VictimHitTimeScaleRatio
		{
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
					ProgressBarControlComponent_SetValue pocoInterface = this.PocoInterface;
					this._VictimHitTimeScaleRatioCache = ((pocoInterface != null) ? pocoInterface.VictimHitTimeScaleRatio : null);
				}
				return this._VictimHitTimeScaleRatioCache;
			}
			set
			{
				this.GetOrCreatePoco().VictimHitTimeScaleRatio = value;
				this._VictimHitTimeScaleRatioInited = false;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x000816B4 File Offset: 0x0007F8B4
		// (set) Token: 0x0600328C RID: 12940 RVA: 0x00081747 File Offset: 0x0007F947
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<IAimPart> AimParts
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._AimPartsInited)
				{
					return this._AimPartsCache;
				}
				this._AimPartsInited = true;
				if (this.FbInstance != null)
				{
					List<IAimPart> aimParts = this.FbInstance.AimParts;
					if (aimParts != null)
					{
						this._AimPartsCache = new List<IAimPart>(aimParts.Count);
						for (int i = 0; i < aimParts.Count; i++)
						{
							this._AimPartsCache.Add(IAimPart.Create(aimParts[i]));
						}
					}
				}
				else
				{
					ProgressBarControlComponent_SetValue pocoInterface = this.PocoInterface;
					this._AimPartsCache = ((pocoInterface != null) ? pocoInterface.AimParts : null);
				}
				return this._AimPartsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().AimParts = value;
				this._AimPartsInited = false;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x0008175C File Offset: 0x0007F95C
		// (set) Token: 0x0600328E RID: 12942 RVA: 0x00081786 File Offset: 0x0007F986
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x00081794 File Offset: 0x0007F994
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x000817BB File Offset: 0x0007F9BB
		[Nullable(0)]
		public virtual IProgressBarControl Control
		{
			[NullableContext(0)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Control;
				}
				ProgressBarControlComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Control;
			}
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().Control = value;
			}
		}

		// Token: 0x04002141 RID: 8513
		protected new ProgressBarControlComponent FbInstance;

		// Token: 0x04002142 RID: 8514
		protected new ProgressBarControlComponent_SetValue PocoInterface;

		// Token: 0x04002143 RID: 8515
		[Nullable(0)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04002144 RID: 8516
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002145 RID: 8517
		[Nullable(0)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04002146 RID: 8518
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04002147 RID: 8519
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04002148 RID: 8520
		private bool _AimPartsInited;
	}
}
