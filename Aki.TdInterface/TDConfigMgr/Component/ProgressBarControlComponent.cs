using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200085D RID: 2141
	[NullableContext(2)]
	[Nullable(0)]
	public class ProgressBarControlComponent : IHitComponentBase
	{
		// Token: 0x06002F43 RID: 12099 RVA: 0x00079F94 File Offset: 0x00078194
		[NullableContext(1)]
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

		// Token: 0x06002F44 RID: 12100 RVA: 0x00079FCC File Offset: 0x000781CC
		[NullableContext(1)]
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

		// Token: 0x06002F45 RID: 12101 RVA: 0x00079FDF File Offset: 0x000781DF
		[NullableContext(1)]
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

		// Token: 0x06002F46 RID: 12102 RVA: 0x00079FF4 File Offset: 0x000781F4
		[NullableContext(1)]
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

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x0007A05C File Offset: 0x0007825C
		// (set) Token: 0x06002F48 RID: 12104 RVA: 0x0007A096 File Offset: 0x00078296
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

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x0007A0A4 File Offset: 0x000782A4
		// (set) Token: 0x06002F4A RID: 12106 RVA: 0x0007A0CB File Offset: 0x000782CB
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

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x0007A0DC File Offset: 0x000782DC
		// (set) Token: 0x06002F4C RID: 12108 RVA: 0x0007A13D File Offset: 0x0007833D
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

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x0007A154 File Offset: 0x00078354
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x0007A1B5 File Offset: 0x000783B5
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

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x0007A1CC File Offset: 0x000783CC
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x0007A25F File Offset: 0x0007845F
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().AimParts = value;
				this._AimPartsInited = false;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x0007A274 File Offset: 0x00078474
		// (set) Token: 0x06002F52 RID: 12114 RVA: 0x0007A29E File Offset: 0x0007849E
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

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x0007A2AC File Offset: 0x000784AC
		// (set) Token: 0x06002F54 RID: 12116 RVA: 0x0007A2D3 File Offset: 0x000784D3
		[Nullable(1)]
		public virtual IProgressBarControl Control
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().Control = value;
			}
		}

		// Token: 0x04001F2F RID: 7983
		protected new ProgressBarControlComponent FbInstance;

		// Token: 0x04001F30 RID: 7984
		protected new ProgressBarControlComponent_SetValue PocoInterface;

		// Token: 0x04001F31 RID: 7985
		[Nullable(1)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04001F32 RID: 7986
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04001F33 RID: 7987
		[Nullable(1)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04001F34 RID: 7988
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04001F35 RID: 7989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04001F36 RID: 7990
		private bool _AimPartsInited;
	}
}
