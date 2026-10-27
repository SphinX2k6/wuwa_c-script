using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9A RID: 2970
	[NullableContext(2)]
	[Nullable(0)]
	public class IHitComponentBase : IComponentBase
	{
		// Token: 0x06004436 RID: 17462 RVA: 0x000AD597 File Offset: 0x000AB797
		[NullableContext(1)]
		public static IHitComponentBase Create(IHitComponentBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitComponentBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x000AD5B8 File Offset: 0x000AB7B8
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

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x000AD5F0 File Offset: 0x000AB7F0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x000AD606 File Offset: 0x000AB806
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
				this._HitBulletCache = ComponentReadHelper.ReadIHitComponentBase_HitBullet(this.Instance);
				return this._HitBulletCache;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x000AD635 File Offset: 0x000AB835
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

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x000AD669 File Offset: 0x000AB869
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

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x000AD6A0 File Offset: 0x000AB8A0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IAimPart> AimParts
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

		// Token: 0x0400267B RID: 9851
		private IHitComponentBase Instance;

		// Token: 0x0400267C RID: 9852
		[Nullable(1)]
		private IHitBulletType _HitBulletCache;

		// Token: 0x0400267D RID: 9853
		private bool _HitBulletInited;

		// Token: 0x0400267E RID: 9854
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x0400267F RID: 9855
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002680 RID: 9856
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04002681 RID: 9857
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04002682 RID: 9858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04002683 RID: 9859
		private bool _AimPartsInited;
	}
}
