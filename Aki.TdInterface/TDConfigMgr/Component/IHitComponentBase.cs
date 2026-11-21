using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000475 RID: 1141
	[NullableContext(2)]
	[Nullable(0)]
	public class IHitComponentBase : IComponentBase
	{
		// Token: 0x060016CD RID: 5837 RVA: 0x00046814 File Offset: 0x00044A14
		[NullableContext(0)]
		private IHitComponentBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitComponentBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitComponentBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitComponentBase_SetValue());
			}
			return result;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0004684C File Offset: 0x00044A4C
		[NullableContext(0)]
		public static IHitComponentBase Create([Nullable(2)] IHitComponentBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitComponentBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0004685F File Offset: 0x00044A5F
		[NullableContext(0)]
		public static IHitComponentBase CreateFromSetValue([Nullable(2)] IHitComponentBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitComponentBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00046874 File Offset: 0x00044A74
		[NullableContext(0)]
		public new IHitComponentBase_SetValue ToSetValue()
		{
			return new IHitComponentBase_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				HitBullet = this.HitBullet,
				AttackerHitTimeScaleRatio = this.AttackerHitTimeScaleRatio,
				VictimHitTimeScaleRatio = this.VictimHitTimeScaleRatio,
				AimParts = this.AimParts
			};
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x000468D0 File Offset: 0x00044AD0
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x0004690A File Offset: 0x00044B0A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00046918 File Offset: 0x00044B18
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x00046942 File Offset: 0x00044B42
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

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00046950 File Offset: 0x00044B50
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x00046977 File Offset: 0x00044B77
		public virtual IHitBulletType HitBullet
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitBullet;
				}
				IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00046988 File Offset: 0x00044B88
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x000469E9 File Offset: 0x00044BE9
		public virtual IHitTimeScaleRatio AttackerHitTimeScaleRatio
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
					IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00046A00 File Offset: 0x00044C00
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00046A61 File Offset: 0x00044C61
		public virtual IHitTimeScaleRatio VictimHitTimeScaleRatio
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
					IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00046A78 File Offset: 0x00044C78
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x00046B0B File Offset: 0x00044D0B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IAimPart> AimParts
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
					IHitComponentBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001192 RID: 4498
		protected new IHitComponentBase FbInstance;

		// Token: 0x04001193 RID: 4499
		protected new IHitComponentBase_SetValue PocoInterface;

		// Token: 0x04001194 RID: 4500
		[Nullable(0)]
		private IHitTimeScaleRatio _AttackerHitTimeScaleRatioCache;

		// Token: 0x04001195 RID: 4501
		private bool _AttackerHitTimeScaleRatioInited;

		// Token: 0x04001196 RID: 4502
		[Nullable(0)]
		private IHitTimeScaleRatio _VictimHitTimeScaleRatioCache;

		// Token: 0x04001197 RID: 4503
		private bool _VictimHitTimeScaleRatioInited;

		// Token: 0x04001198 RID: 4504
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IAimPart> _AimPartsCache;

		// Token: 0x04001199 RID: 4505
		private bool _AimPartsInited;
	}
}
