using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E75 RID: 3701
	public class GravityFlipComponent : IComponentBase
	{
		// Token: 0x0600539D RID: 21405 RVA: 0x000CE2B7 File Offset: 0x000CC4B7
		public static GravityFlipComponent Create(IGravityFlipComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new GravityFlipComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x000CE2D8 File Offset: 0x000CC4D8
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

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x0600539F RID: 21407 RVA: 0x000CE310 File Offset: 0x000CC510
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x060053A0 RID: 21408 RVA: 0x000CE328 File Offset: 0x000CC528
		public virtual List<IGravityFlipConfig> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				int configLength = this.Instance.ConfigLength;
				this._ConfigCache = new List<IGravityFlipConfig>(configLength);
				for (int i = 0; i < configLength; i++)
				{
					this._ConfigCache.Add(IGravityFlipConfig.Create(this.Instance.Config(i)));
				}
				return this._ConfigCache;
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x060053A1 RID: 21409 RVA: 0x000CE391 File Offset: 0x000CC591
		public virtual EGravityFlipType DefaultGravity
		{
			get
			{
				return (EGravityFlipType)this.Instance.DefaultGravity;
			}
		}

		// Token: 0x04002FD0 RID: 12240
		private IGravityFlipComponent Instance;

		// Token: 0x04002FD1 RID: 12241
		private List<IGravityFlipConfig> _ConfigCache;

		// Token: 0x04002FD2 RID: 12242
		private bool _ConfigInited;
	}
}
