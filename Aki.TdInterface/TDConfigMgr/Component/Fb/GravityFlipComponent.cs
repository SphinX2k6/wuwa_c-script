using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D79 RID: 3449
	[NullableContext(1)]
	[Nullable(0)]
	public class GravityFlipComponent : IComponentBase
	{
		// Token: 0x06004E78 RID: 20088 RVA: 0x000C2A67 File Offset: 0x000C0C67
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

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06004E79 RID: 20089 RVA: 0x000C2A88 File Offset: 0x000C0C88
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

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06004E7A RID: 20090 RVA: 0x000C2AC0 File Offset: 0x000C0CC0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06004E7B RID: 20091 RVA: 0x000C2AD8 File Offset: 0x000C0CD8
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

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06004E7C RID: 20092 RVA: 0x000C2B41 File Offset: 0x000C0D41
		public virtual EGravityFlipType DefaultGravity
		{
			get
			{
				return (EGravityFlipType)this.Instance.DefaultGravity;
			}
		}

		// Token: 0x04002D0A RID: 11530
		private IGravityFlipComponent Instance;

		// Token: 0x04002D0B RID: 11531
		private List<IGravityFlipConfig> _ConfigCache;

		// Token: 0x04002D0C RID: 11532
		private bool _ConfigInited;
	}
}
