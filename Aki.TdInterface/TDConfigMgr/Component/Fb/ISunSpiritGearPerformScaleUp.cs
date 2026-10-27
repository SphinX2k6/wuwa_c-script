using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBD RID: 3517
	[NullableContext(2)]
	[Nullable(0)]
	public class ISunSpiritGearPerformScaleUp : ISunSpiritGearPerformConfig
	{
		// Token: 0x06004FD3 RID: 20435 RVA: 0x000C57CE File Offset: 0x000C39CE
		[NullableContext(1)]
		public static ISunSpiritGearPerformScaleUp Create(ISunSpiritGearPerformScaleUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformScaleUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x000C57ED File Offset: 0x000C39ED
		public override ESunSpiritGearPerformType Type
		{
			get
			{
				return (ESunSpiritGearPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x000C57FA File Offset: 0x000C39FA
		public virtual float Scale
		{
			get
			{
				return this.Instance.Scale;
			}
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x000C5807 File Offset: 0x000C3A07
		public virtual IScaleUpSpiritPerformConfig ScaleUpPerformConfig
		{
			get
			{
				if (this._ScaleUpPerformConfigInited)
				{
					return this._ScaleUpPerformConfigCache;
				}
				this._ScaleUpPerformConfigInited = true;
				this._ScaleUpPerformConfigCache = IScaleUpSpiritPerformConfig.Create(this.Instance.ScaleUpPerformConfig);
				return this._ScaleUpPerformConfigCache;
			}
		}

		// Token: 0x04002DC8 RID: 11720
		private ISunSpiritGearPerformScaleUp Instance;

		// Token: 0x04002DC9 RID: 11721
		private IScaleUpSpiritPerformConfig _ScaleUpPerformConfigCache;

		// Token: 0x04002DCA RID: 11722
		private bool _ScaleUpPerformConfigInited;
	}
}
