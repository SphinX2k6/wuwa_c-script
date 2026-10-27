using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAB RID: 3243
	[NullableContext(1)]
	[Nullable(0)]
	public class ProgressBarControlComponent : IHitComponentBase
	{
		// Token: 0x06004A3C RID: 19004 RVA: 0x000B9E22 File Offset: 0x000B8022
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

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06004A3D RID: 19005 RVA: 0x000B9E44 File Offset: 0x000B8044
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

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06004A3E RID: 19006 RVA: 0x000B9E7A File Offset: 0x000B807A
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

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06004A3F RID: 19007 RVA: 0x000B9EA9 File Offset: 0x000B80A9
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

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06004A40 RID: 19008 RVA: 0x000B9EDD File Offset: 0x000B80DD
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

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x000B9F14 File Offset: 0x000B8114
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

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06004A42 RID: 19010 RVA: 0x000B9F90 File Offset: 0x000B8190
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06004A43 RID: 19011 RVA: 0x000B9FA6 File Offset: 0x000B81A6
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

		// Token: 0x04002A58 RID: 10840
		private IProgressBarControlComponent Instance;

		// Token: 0x04002A59 RID: 10841
		private IHitBulletType _HitBulletCache;

		// Token: 0x04002A5A RID: 10842
		private bool _HitBulletInited;

		// Token: 0x04002A5B RID: 10843
		[Nullable(2)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04002A5C RID: 10844
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04002A5D RID: 10845
		[Nullable(2)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04002A5E RID: 10846
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04002A5F RID: 10847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04002A60 RID: 10848
		private bool _AimPartsInited;

		// Token: 0x04002A61 RID: 10849
		private IProgressBarControl _ControlCache;

		// Token: 0x04002A62 RID: 10850
		private bool _ControlInited;
	}
}
