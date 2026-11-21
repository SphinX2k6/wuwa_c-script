using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8D RID: 3469
	public class ProgressBarControlComponent : IHitComponentBase
	{
		// Token: 0x06004EEA RID: 20202 RVA: 0x000C4832 File Offset: 0x000C2A32
		public static ProgressBarControlComponent Create(IProgressBarControlComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ProgressBarControlComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004EEB RID: 20203 RVA: 0x000C4854 File Offset: 0x000C2A54
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

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004EEC RID: 20204 RVA: 0x000C488A File Offset: 0x000C2A8A
		public override IHitBulletType HitBullet
		{
			get
			{
				if (this._HitBulletInited)
				{
					return this._HitBulletCache;
				}
				this._HitBulletInited = true;
				this._HitBulletCache = ComponentReadHelper.ReadProgressBarControlComponent_HitBullet(this.Instance);
				return this._HitBulletCache;
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004EED RID: 20205 RVA: 0x000C48B9 File Offset: 0x000C2AB9
		[Nullable(2)]
		public override IHitTimeScaleRatio AttackerHitTimeScaleRatio
		{
			[NullableContext(2)]
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

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004EEE RID: 20206 RVA: 0x000C48ED File Offset: 0x000C2AED
		[Nullable(2)]
		public override IHitTimeScaleRatio VictimHitTimeScaleRatio
		{
			[NullableContext(2)]
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

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004EEF RID: 20207 RVA: 0x000C4924 File Offset: 0x000C2B24
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

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06004EF0 RID: 20208 RVA: 0x000C49A0 File Offset: 0x000C2BA0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06004EF1 RID: 20209 RVA: 0x000C49B6 File Offset: 0x000C2BB6
		public virtual IProgressBarControl Control
		{
			get
			{
				if (this._ControlInited)
				{
					return this._ControlCache;
				}
				this._ControlInited = true;
				this._ControlCache = ComponentReadHelper.ReadProgressBarControlComponent_Control(this.Instance);
				return this._ControlCache;
			}
		}

		// Token: 0x04002CD2 RID: 11474
		private IProgressBarControlComponent Instance;

		// Token: 0x04002CD3 RID: 11475
		private IHitBulletType _HitBulletCache;

		// Token: 0x04002CD4 RID: 11476
		private bool _HitBulletInited;

		// Token: 0x04002CD5 RID: 11477
		[Nullable(2)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04002CD6 RID: 11478
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002CD7 RID: 11479
		[Nullable(2)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04002CD8 RID: 11480
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04002CD9 RID: 11481
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04002CDA RID: 11482
		private bool _AimPartsInited;

		// Token: 0x04002CDB RID: 11483
		private IProgressBarControl _ControlCache;

		// Token: 0x04002CDC RID: 11484
		private bool _ControlInited;
	}
}
