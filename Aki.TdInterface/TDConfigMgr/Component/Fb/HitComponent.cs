using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D2D RID: 3373
	[NullableContext(2)]
	[Nullable(0)]
	public class HitComponent : IHitComponentBase
	{
		// Token: 0x06004CF6 RID: 19702 RVA: 0x000BF848 File Offset: 0x000BDA48
		[NullableContext(1)]
		public static HitComponent Create(IHitComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HitComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x000BF868 File Offset: 0x000BDA68
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x000BF89E File Offset: 0x000BDA9E
		[Nullable(1)]
		public override IHitBulletType HitBullet
		{
			[NullableContext(1)]
			get
			{
				if (this._HitBulletInited)
				{
					return this._HitBulletCache;
				}
				this._HitBulletInited = true;
				this._HitBulletCache = ComponentReadHelper.ReadHitComponent_HitBullet(this.Instance);
				return this._HitBulletCache;
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x000BF8CD File Offset: 0x000BDACD
		public override IHitTimeScaleRatio AttackerHitTimeScaleRatio
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

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x000BF901 File Offset: 0x000BDB01
		public override IHitTimeScaleRatio VictimHitTimeScaleRatio
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

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x000BF938 File Offset: 0x000BDB38
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<IAimPart> AimParts
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._AimPartsInited)
				{
					return this._AimPartsCache;
				}
				this._AimPartsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int aimPartsLength = this.Instance.AimPartsLength;
				this._AimPartsCache = new List<IAimPart>(aimPartsLength);
				for (int i = 0; i < aimPartsLength; i++)
				{
					this._AimPartsCache.Add(IAimPart.Create(this.Instance.AimParts(i)));
				}
				return this._AimPartsCache;
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06004CFC RID: 19708 RVA: 0x000BF9B4 File Offset: 0x000BDBB4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06004CFD RID: 19709 RVA: 0x000BF9CC File Offset: 0x000BDBCC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IBulletHitConfig> BulletHitConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._BulletHitConfigsInited)
				{
					return this._BulletHitConfigsCache;
				}
				this._BulletHitConfigsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int bulletHitConfigsLength = this.Instance.BulletHitConfigsLength;
				this._BulletHitConfigsCache = new List<IBulletHitConfig>(bulletHitConfigsLength);
				for (int i = 0; i < bulletHitConfigsLength; i++)
				{
					this._BulletHitConfigsCache.Add(IBulletHitConfig.Create(this.Instance.BulletHitConfigs(i)));
				}
				return this._BulletHitConfigsCache;
			}
		}

		// Token: 0x04002C14 RID: 11284
		private IHitComponent Instance;

		// Token: 0x04002C15 RID: 11285
		[Nullable(1)]
		private IHitBulletType _HitBulletCache;

		// Token: 0x04002C16 RID: 11286
		private bool _HitBulletInited;

		// Token: 0x04002C17 RID: 11287
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04002C18 RID: 11288
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002C19 RID: 11289
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04002C1A RID: 11290
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04002C1B RID: 11291
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04002C1C RID: 11292
		private bool _AimPartsInited;

		// Token: 0x04002C1D RID: 11293
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IBulletHitConfig> _BulletHitConfigsCache;

		// Token: 0x04002C1E RID: 11294
		private bool _BulletHitConfigsInited;
	}
}
