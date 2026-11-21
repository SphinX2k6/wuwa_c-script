using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E27 RID: 3623
	[NullableContext(2)]
	[Nullable(0)]
	public class HitComponent : IHitComponentBase
	{
		// Token: 0x06005212 RID: 21010 RVA: 0x000CAF8C File Offset: 0x000C918C
		[NullableContext(0)]
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

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x000CAFAC File Offset: 0x000C91AC
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

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x000CAFE2 File Offset: 0x000C91E2
		[Nullable(0)]
		public override IHitBulletType HitBullet
		{
			[NullableContext(0)]
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

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x000CB011 File Offset: 0x000C9211
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

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06005216 RID: 21014 RVA: 0x000CB045 File Offset: 0x000C9245
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

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06005217 RID: 21015 RVA: 0x000CB07C File Offset: 0x000C927C
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

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x000CB0F8 File Offset: 0x000C92F8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06005219 RID: 21017 RVA: 0x000CB110 File Offset: 0x000C9310
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IBulletHitConfig> BulletHitConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04002ED4 RID: 11988
		private IHitComponent Instance;

		// Token: 0x04002ED5 RID: 11989
		[Nullable(0)]
		private IHitBulletType _HitBulletCache;

		// Token: 0x04002ED6 RID: 11990
		private bool _HitBulletInited;

		// Token: 0x04002ED7 RID: 11991
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04002ED8 RID: 11992
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002ED9 RID: 11993
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04002EDA RID: 11994
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04002EDB RID: 11995
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04002EDC RID: 11996
		private bool _AimPartsInited;

		// Token: 0x04002EDD RID: 11997
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IBulletHitConfig> _BulletHitConfigsCache;

		// Token: 0x04002EDE RID: 11998
		private bool _BulletHitConfigsInited;
	}
}
